Namespace Message

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class StringResourceMessage
        Inherits ResourceMessage

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="iResourceMgr"></param>
        Public Sub New(iResourceMgr As Resources.ResourceManager)
            MyBase.New(iResourceMgr)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iMsgId"></param>
        ''' <param name="iLang"></param>
        ''' <returns></returns>
        Public Overrides Function GetMessageInfo(iMsgId As String, iLang As String) As Object
            Dim msgInfo As Object = _Resource.GetString(String.Format("{1}_{0}", iMsgId, iLang))
            If msgInfo Is Nothing Then
                msgInfo = _Resource.GetString(iMsgId)
            End If
            Return msgInfo
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iMsgInfo"></param>
        ''' <returns></returns>
        Public Overrides Function ExtractMessage(iMsgInfo As Object) As String
            If TypeOf iMsgInfo IsNot String Then
                Return Nothing
            End If
            Return CType(iMsgInfo, String)
        End Function
    End Class

End Namespace
