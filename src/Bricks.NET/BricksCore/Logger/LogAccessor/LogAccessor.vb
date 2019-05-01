Namespace Logging

    ''' <summary>
    ''' 
    ''' </summary>
    Public MustInherit Class LogAccessor

        Public Overridable Sub Open()

        End Sub

        Public Overridable Sub Close()

        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="iMsg"></param>
        ''' <param name="iLevel"></param>
        Public Overridable Sub Write(iMsg As String, Optional iLevel As OutputLevelEnum = OutputLevelEnum.All)

        End Sub

    End Class

End Namespace