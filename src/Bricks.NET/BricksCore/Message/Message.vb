Namespace Message

    Public Class Message

        Private _MsgSource As IMessageSource
        Private _NextMessage As Message
        Protected _MsgInfo As Object

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="iMsgSource"></param>
        ''' <param name="iNextMsg"></param>
        Public Sub New(iMsgSource As IMessageSource, Optional iNextMsg As Message = Nothing)
            _MsgSource = iMsgSource
            _NextMessage = iNextMsg
        End Sub

        ''' <summary>
        ''' メッセージの取得
        ''' </summary>
        ''' <param name="iMsgId"></param>
        ''' <returns></returns>
        Public Function GetMessage(iMsgId As String) As String
            Try
                _MsgInfo = _MsgSource.GetMessageInfo(iMsgId, GetISOLanguageLetter)
                Return _MsgSource.ExtractMessage(_MsgInfo)

            Catch ex As BricksMessageException
                Return iMsgId
            End Try

            Return _NextMessage.GetMessage(iMsgId)
        End Function

        Public Function GetMessageWithId(iMsgId As String) As String

        End Function

        ''' <summary>
        ''' ISO言語文字列の取得
        ''' </summary>
        ''' <returns></returns>
        Protected ReadOnly Property GetISOLanguageLetter As String
            Get
                Return Threading.Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName
            End Get
        End Property
    End Class

End Namespace
