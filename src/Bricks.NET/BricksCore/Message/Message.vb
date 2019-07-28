Namespace Message

    Public Class Message

        Public Shared DefaultLanguage As String
        Public Language As String

        Private _MsgSource As IMessageSource
        Private _NextMessage As Message
        Protected _MsgInfo As Object

        Shared Sub New()
            DefaultLanguage = Threading.Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName
        End Sub

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="iMsgSource"></param>
        ''' <param name="iNextMsg"></param>
        Public Sub New(iMsgSource As IMessageSource, Optional iNextMsg As Message = Nothing)
            Language = DefaultLanguage

            _MsgSource = iMsgSource
            _NextMessage = iNextMsg
        End Sub

        ''' <summary>
        ''' メッセージの取得
        ''' </summary>
        ''' <param name="iMsgId"></param>
        ''' <returns></returns>
        Public Function GetMessage(iMsgId As String) As String
            Dim msgInfo As Object = _MsgSource.GetMessageInfo(iMsgId, Language)
            If msgInfo Is Nothing AndAlso _NextMessage IsNot Nothing Then
                Return _NextMessage.GetMessage(iMsgId)
            End If

            Return _MsgSource.ExtractMessage(msgInfo)
        End Function

        Public Function GetMessageWithId(iMsgId As String) As String
            Return ""
        End Function

    End Class

End Namespace
