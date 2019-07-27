Namespace Message

    ''' <summary>
    ''' メッセージの取得元を実装するためのインターフェース
    ''' </summary>
    Public Interface IMessageSource

        ''' <summary>
        ''' メッセージ情報の返却
        ''' </summary>
        ''' <param name="iMsgId"></param>
        ''' <param name="iLang"></param>
        ''' <returns></returns>
        Function GetMessageInfo(iMsgId As String, iLang As String) As Object

        ''' <summary>
        ''' メッセージ情報からメッセージ本体を抽出する
        ''' </summary>
        ''' <param name="iMsgInfo"><c>GetMessageInfo</c>で取得したメッセージ情報</param>
        ''' <returns></returns>
        Function ExtractMessage(iMsgInfo As Object) As String

    End Interface

End Namespace
