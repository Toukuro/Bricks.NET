﻿Imports System.Reflection

Namespace Logging


    ''' <summary>
    ''' ログ出力の基本クラス
    ''' </summary>
    Public Class FormattedLogger
        Inherits Logger

        ''' <summary></summary>
        Public Const KWD_TIMESTAMP As String = "{TIMESTAMP}"
        ''' <summary></summary>
        Public Const KWD_LOGLEVEL As String = "{LOGLEVEL}"
        ''' <summary></summary>
        Public Const KWD_THREADNO As String = "{THREADNO}"
        ''' <summary></summary>
        Public Const KWD_CALLER As String = "{CALLER}"
        ''' <summary></summary>
        Public Const KWD_MESSAGE As String = "{MESSAGE}"
        ''' <summary></summary>
        Public Const KWD_TAB As String = "{TAB}"
        ''' <summary></summary>
        Public Const KWD_CRLF As String = "{CRLF}"

        ''' <summary></summary>
        Private Shared _DefaultFormat As String = "{TIMESTAMP} [{LOGLEVEL}] {CALLER} {MESSAGE}{CRLF}"

#Region "コンストラクタ"

        ''' <summary>
        ''' 
        ''' </summary>
        Public Sub New()
            MyBase.New
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iLogAccessor"></param>
        Public Sub New(iLogAccessor As LogAccessor)
            MyBase.New(iLogAccessor)
        End Sub

#End Region

#Region "プロパティ"

        ''' <summary>
        ''' 
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
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Public Property LogFormat As String = _DefaultFormat

#End Region

#Region "ログ出力メソッド"

#Region "出力レベル指定"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iLevel"></param>
        ''' <param name="iMessage"></param>
        ''' <param name="iData"></param>
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, ParamArray iData() As Object)
            Dim outMsg As String = String.Format(iMessage, iData)

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
        Public Overrides Sub Write(iLevel As OutputLevelEnum, iMessage As String, iException As Exception)
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

        Private Function FormatMsg(iLevel As OutputLevelEnum, iMsg As String) As String
            Dim outMsg As String = _LogFormat
            Dim proc As Process = System.Diagnostics.Process.GetCurrentProcess

            outMsg = outMsg.Substring(KWD_TIMESTAMP, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"))
            outMsg = outMsg.Substring(KWD_LOGLEVEL, iLevel.ToString)
            outMsg = outMsg.Substring(KWD_THREADNO, proc.Threads(0).Id)
            outMsg = outMsg.Substring(KWD_CALLER, GetCaller)
            outMsg = outMsg.Substring(KWD_MESSAGE, iMsg)
            outMsg = outMsg.Substring(KWD_TAB, vbTab)
            outMsg = outMsg.Substring(KWD_CRLF, vbCrLf)

            Return outMsg
        End Function

#End Region

#End Region

        ''' <summary>
        ''' 
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
