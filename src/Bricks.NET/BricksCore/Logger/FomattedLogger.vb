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
        Public Const KWD_PATTERN As String = "\{([A-Z9-0_]+)\}"

        ''' <summary></summary>
        Private Shared _DefaultFormat As String = "{TIMESTAMP} [{LOGLEVEL}] {CALLER} {MESSAGE}{CRLF}"

#Region "コンストラクタ"

        ''' <summary>
        ''' デフォルトのコンストラクタ
        ''' </summary>
        Public Sub New()
            MyBase.New
        End Sub

        ''' <summary>
        ''' 出力先指定のコンストラクタ
        ''' </summary>
        ''' <param name="iLogAccessor"></param>
        Public Sub New(iLogAccessor As LogAccessor)
            MyBase.New(iLogAccessor)
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' デフォルトの出力書式の参照と設定
        ''' </summary>
        ''' <returns></returns>
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
        ''' <returns></returns>
        Public Property LogFormat As String = _DefaultFormat

#End Region

#Region "ログ出力メソッド"

#Region "出力レベル指定"

        ''' <summary>
        ''' レベル指定出力（フォーマット指定）
        ''' </summary>
        ''' <param name="iLevel"></param>
        ''' <param name="iMessage"></param>
        ''' <param name="iData"></param>
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            MyBase.Write(iLevel, FormatMsg(iMessage, iLevel), iData)
        End Sub

        ''' <summary>
        ''' レベル指定出力（例外出力）
        ''' </summary>
        ''' <param name="iLevel"></param>
        ''' <param name="iMessage"></param>
        ''' <param name="iException"></param>
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
            MyBase.Write(iLevel, FormatMsg(iMessage, iLevel), iException)
        End Sub

        ''' <summary>
        ''' ログフォーマットのキーワード埋め込み処理
        ''' </summary>
        ''' <param name="iMsg"></param>
        ''' <param name="iLevel"></param>
        ''' <returns></returns>
        Private Function FormatMsg(iMsg As String, iLevel As OutputLevelEnum) As String
            Dim pattern As String = _LogFormat
            Dim outMsg As New StringBuilder
            Dim proc As Process = Process.GetCurrentProcess

            Dim rex As New Regex(KWD_PATTERN)
            Do
                Dim m As Match = rex.Match(pattern)
                Dim m2 As Match = Nothing
                Dim dt As String = String.Empty

                If m Is Match.Empty Then
                    outMsg.Append(pattern)
                    Exit Do
                End If

                m2 = m.Groups(1)
                Select Case m2.Value
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
                        dt = m2.Value
                End Select

                outMsg.Append(pattern.Substring(0, m.Index + 1))
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
        ''' <param name="iIgnoreModuleNames"></param>
        ''' <returns></returns>
        Public Shared Function GetCaller(ParamArray iIgnoreModuleNames() As String) As String
            Dim stkTrc As New StackTrace()
            Dim stkFrm As StackFrame
            Dim stkIdx As Integer = 0
            Dim mtdInf As MethodBase
            Dim ignoreNames As New ArrayList(iIgnoreModuleNames)
            ignoreNames.Add(GetType(FormattedLogger).Name)

            Do
                stkFrm = stkTrc.GetFrame(stkIdx)
                mtdInf = stkFrm.GetMethod
                stkIdx += 1
            Loop While ignoreNames.Contains(mtdInf.DeclaringType.Name)

            Dim caller As String = String.Format("{0}.{1}", mtdInf.DeclaringType.Name, mtdInf.Name)

            Return caller
        End Function

    End Class
End Namespace
