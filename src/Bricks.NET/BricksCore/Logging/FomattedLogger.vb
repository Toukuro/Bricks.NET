Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions

Namespace Logging

    ''' <summary>
    ''' ログ出力の基本クラス
    ''' </summary>
    Public Class FormattedLogger
        Inherits Logger

        ''' <summary>タイムスタンプ</summary>
        Protected Const KWD_TIMESTAMP As String = "TIMESTAMP"
        ''' <summary>ログ出力レベル</summary>
        Protected Const KWD_LOGLEVEL As String = "LOGLEVEL"
        ''' <summary>スレッド番号</summary>
        Protected Const KWD_THREADNO As String = "THREADNO"
        ''' <summary>呼び出し元メソッド名</summary>
        Public Const KWD_CALLER As String = "CALLER"
        ''' <summary>出力メッセージ</summary>
        Public Const KWD_MESSAGE As String = "MESSAGE"
        ''' <summary>TAB文字</summary>
        Public Const KWD_TAB As String = "TAB"
        ''' <summary>改行文字</summary>
        Public Const KWD_CRLF As String = "CRLF"

        ''' <summary>キーワードのパターン</summary>
        Public Const KWD_PATTERN As String = "\{([A-Z_][0-9A-Z_]*)\}"

        ''' <summary>出力フォーマット</summary>
        Private Shared _DefaultFormat As String = "{TIMESTAMP} [{LOGLEVEL}] {CALLER} {MESSAGE}"
        ''' <summary>呼び出し元として無視するクラスのリスト</summary>
        Private Shared _IgnoreClasses As New ArrayList

#Region "コンストラクタ"

        ''' <summary>
        ''' クラスコンストラクタ
        ''' </summary>
        Shared Sub New()
            Dim myType As Type = Reflection.MethodBase.GetCurrentMethod.DeclaringType

            AddIgnoreClassAndParent(myType)
        End Sub

        ''' <summary>
        ''' デフォルトのコンストラクタ
        ''' </summary>
        Public Sub New()
            MyBase.New
        End Sub

        ''' <summary>
        ''' 出力先指定のコンストラクタ
        ''' </summary>
        ''' <param name="iLogAccessor">ログの出力先</param>
        Public Sub New(iLogAccessor As LogAccessor)
            MyBase.New(iLogAccessor)
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' デフォルトの出力書式の参照と設定
        ''' </summary>
        ''' <returns>デフォルトの出力書式を返却する</returns>
        Public Shared Property DefaultFormat As String
            Get
                Return _DefaultFormat
            End Get
            Set(value As String)
                _DefaultFormat = value
            End Set
        End Property

        ''' <summary>
        ''' このLoggerの出力書式の参照と設定
        ''' </summary>
        ''' <returns>このロガーの出力書式を返却する</returns>
        Public Property LogFormat As String = _DefaultFormat

#End Region

#Region "メソッド"

        ''' <summary>
        ''' 呼び出し元として無視するクラスを追加する
        ''' </summary>
        ''' <param name="iType">無視するクラス</param>
        Public Shared Sub AddIgnoreClass(iType As Type)
            _IgnoreClasses.Add(iType.Name)
        End Sub

        ''' <summary>
        ''' 呼び出し元として無視するクラスとObjectクラスを除くその親のクラスを追加する
        ''' </summary>
        ''' <param name="iType">無視するクラス</param>
        Public Shared Sub AddIgnoreClassAndParent(iType As Type)
            Do While iType IsNot Nothing
                If iType.Equals(GetType(Object)) Then
                    Exit Do
                End If
                _IgnoreClasses.Add(iType.Name)
                iType = iType.BaseType
            Loop
        End Sub
#End Region

#Region "ログ出力メソッド"

#Region "出力レベル指定"

        ''' <summary>
        ''' レベル指定出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iLevel">ログ出力レベル</param>
        ''' <param name="iMessage">出力メッセージ</param>
        ''' <param name="iData">埋め込みデータ</param>
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            MyBase.Write(iLevel, FormatMsg(iMessage, iLevel), iData)
        End Sub

        ''' <summary>
        ''' レベル指定出力（例外出力）
        ''' </summary>
        ''' <param name="iLevel">ログ出力レベル</param>
        ''' <param name="iMessage">出力メッセージ</param>
        ''' <param name="iException">例外オブジェクト</param>
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
            MyBase.Write(iLevel, FormatMsg(iMessage, iLevel), iException)
        End Sub

        ''' <summary>
        ''' ログフォーマットのキーワード埋め込み処理
        ''' </summary>
        ''' <param name="iMsg">出力メッセージ</param>
        ''' <param name="iLevel">ログ出力レベル</param>
        ''' <returns></returns>
        Private Function FormatMsg(iMsg As String, iLevel As OutputLevelEnum) As String
            Dim pattern As String = _LogFormat
            Dim outMsg As New StringBuilder
            Dim proc As Process = Process.GetCurrentProcess

            Dim rex As New Regex(KWD_PATTERN)
            Do
                Dim m As Match = rex.Match(pattern)
                Dim dt As String = String.Empty

                If m Is Match.Empty Then
                    outMsg.Append(pattern)
                    Exit Do
                End If

                Select Case m.Groups(1).Value
                    Case KWD_TIMESTAMP
                        dt = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")
                    Case KWD_LOGLEVEL
                        dt = iLevel.ToString
                    Case KWD_THREADNO
                        dt = proc.Threads(0).Id.ToString
                    Case KWD_CALLER
                        dt = GetCaller()
                    Case KWD_MESSAGE
                        dt = iMsg
                    Case KWD_TAB
                        dt = vbTab
                    Case KWD_CRLF
                        dt = vbCrLf
                    Case Else
                        dt = m.Groups(1).Value
                End Select

                outMsg.Append(pattern.Substring(0, m.Index))
                outMsg.Append(dt)
                pattern = pattern.Substring(m.Index + m.Length)
            Loop Until String.IsNullOrEmpty(pattern)

            Return outMsg.ToString
        End Function

#End Region

#End Region

        ''' <summary>
        ''' 呼び出し元のメソッド名を取得
        ''' </summary>
        ''' <returns>呼び出し元のメソッド名</returns>
        Public Shared Function GetCaller() As String
            Dim stkTrc As New StackTrace()
            Dim stkFrm As StackFrame
            Dim stkIdx As Integer = 0
            Dim mtdInf As MethodBase

            Do
                stkFrm = stkTrc.GetFrame(stkIdx)
                mtdInf = stkFrm.GetMethod
                stkIdx += 1
            Loop While _IgnoreClasses.Contains(mtdInf.DeclaringType.Name)

            Dim caller As String = String.Format("{0}.{1}", mtdInf.DeclaringType.Name, mtdInf.Name)

            Return caller
        End Function

    End Class
End Namespace
