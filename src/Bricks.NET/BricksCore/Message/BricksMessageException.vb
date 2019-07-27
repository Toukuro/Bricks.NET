Namespace Message

    Public Class BricksMessageException
        Inherits Common.BricksException

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(iMessage As String)
            MyBase.New(iMessage)
        End Sub

        Public Sub New(iMessage As String, iInnerException As Exception)
            MyBase.New(iMessage, iInnerException)
        End Sub

    End Class

End Namespace
