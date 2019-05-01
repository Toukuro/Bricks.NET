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

        Public Sub New()
            accessor = New NullAccessor
        End Sub

        Public Sub New(iLogAccessor As LogAccessor)

        End Sub

#End Region

#Region "ログ出力メソッド"

#Region "情報"

        Public Overridable Sub Info(iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "詳細"

        Public Overridable Sub Detail(iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "デバッグ"

        Public Overridable Sub Debug(iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "警告"

        Public Overridable Sub Warning(iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "エラー"

        Public Overridable Sub [Error](iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "致命的エラー"

        Public Overridable Sub Fatal(iMessage As String, ParamArray iData() As Object)

        End Sub

#End Region

#Region "出力レベル指定"

        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            Dim outMsg As String = String.Format(iMessage, iData)

            If accessor IsNot Nothing Then
                With accessor
                    .Open()
                    .Write(outMsg, iLevel)
                    .Close()
                End With
            End If
        End Sub

        Public Overridable Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
            If accessor IsNot Nothing Then
                With accessor
                    .Open()
                    .Write(iMessage)
                    .Write(String.Format("Exception: {0}", iException.Message))
                    .Write(iException.StackTrace)
                    If iException.InnerException IsNot Nothing Then

                    End If
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
