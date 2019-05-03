Imports System.Reflection

Namespace Logging

    ''' <summary>
    ''' ログの出力レベル
    ''' </summary>
    Public Enum OutputLevelEnum
        ''' <summary>全て</summary>
        All
        ''' <summary>デバッグ</summary>
        Debug
        ''' <summary>詳細</summary>
        Detail
        ''' <summary>情報</summary>
        Info
        ''' <summary>警告</summary>
        Warning
        ''' <summary>エラー</summary>
        [Error]
        ''' <summary>致命的エラー</summary>
        Fatal
        ''' <summary>出力なし</summary>
        None
    End Enum

    ''' <summary>
    ''' ログ出力の基本クラス
    ''' </summary>
    Public Class Logger

        Private accessor As LogAccessor = Nothing

#Region "コンストラクタ"

        ''' <summary>
        ''' デフォルトのコンストラクタ
        ''' </summary>
        Public Sub New()
            accessor = New NullAccessor
        End Sub

        ''' <summary>
        ''' 出力先指定のコンストラクタ
        ''' </summary>
        ''' <param name="iLogAccessor"></param>
        Public Sub New(iLogAccessor As LogAccessor)
            accessor = iLogAccessor
        End Sub

#End Region

#Region "ログ出力メソッド"

#Region "情報"

        Public Overridable Sub Info(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Info, iMessage, iData)
        End Sub

        Public Overridable Sub Info(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Info, iMessage, iException)
        End Sub

#End Region

#Region "詳細"

        Public Overridable Sub Detail(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Detail, iMessage, iData)
        End Sub

        Public Overridable Sub Detail(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Detail, iMessage, iException)
        End Sub

#End Region

#Region "デバッグ"

        Public Overridable Sub Debug(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Debug, iMessage, iData)
        End Sub

        Public Overridable Sub Debug(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Debug, iMessage, iException)
        End Sub

#End Region

#Region "警告"

        Public Overridable Sub Warning(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Warning, iMessage, iData)
        End Sub

        Public Overridable Sub Warning(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Warning, iMessage, iException)
        End Sub

#End Region

#Region "エラー"

        Public Overridable Sub [Error](iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Error, iMessage, iData)
        End Sub

        Public Overridable Sub [Error](iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Error, iMessage, iException)
        End Sub

#End Region

#Region "致命的エラー"

        Public Overridable Sub Fatal(iMessage As String, ParamArray iData() As Object)
            Write(OutputLevelEnum.Fatal, iMessage, iData)
        End Sub

        Public Overridable Sub Fagtal(iMessage As String, iException As Exception)
            Write(OutputLevelEnum.Fatal, iMessage, iException)
        End Sub
#End Region

#Region "出力レベル指定"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iLevel"></param>
        ''' <param name="iMessage"></param>
        ''' <param name="iData"></param>
        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            Dim outMsg As String = If(iData.Length > 0, String.Format(iMessage, iData), iMessage)

            If accessor IsNot Nothing Then
                With accessor
                    .Open()
                    .Write(outMsg, iLevel)
                    .Close()
                End With
            End If
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iLevel"></param>
        ''' <param name="iMessage"></param>
        ''' <param name="iException"></param>
        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
            If accessor IsNot Nothing Then
                With accessor
                    Dim exMsg As String = "Exception"
                    .Open()
                    .Write(iMessage)
                    While iException IsNot Nothing
                        .Write(String.Format("{0}: {1}", exMsg, iException.Message))
                        .Write(iException.StackTrace)
                        iException = iException.InnerException
                        exMsg = "Inner " & exMsg
                    End While
                    .Close()
                End With
            End If
        End Sub

#End Region

#End Region

        Public Function GetCaller(ParamArray iIgnoreModuleNames() As String) As String
            Dim stkTrc As New StackTrace()
            Dim stkFrm As StackFrame
            Dim stkIdx As Integer = 0
            Dim mtdInf As MethodBase
            Dim ignoreNames As New ArrayList(iIgnoreModuleNames)
            ignoreNames.Add(Me.GetType.Name)

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
