Namespace Message
    Public MustInherit Class ResourceMessage
        Implements IMessageSource

        Protected _Resource As Resources.ResourceManager

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iResourceMgr"></param>
        Public Sub New(iResourceMgr As Resources.ResourceManager)
            _Resource = iResourceMgr
        End Sub

#Region "インターフェースの実装"

        Public Overridable Function GetMessageInfo(iMsgId As String, iLang As String) As Object Implements IMessageSource.GetMessageInfo
            Throw New NotImplementedException()
        End Function

        Public Overridable Function ExtractMessage(iMsgInfo As Object) As String Implements IMessageSource.ExtractMessage
            Throw New NotImplementedException()
        End Function

#End Region
    End Class

End Namespace
