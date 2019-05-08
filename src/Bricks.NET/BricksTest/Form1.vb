Imports BricksCore
Imports BricksForm

Public Class Form1

#Region "Form Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

#End Region

#Region "Logging"

    Private _T01_Logger As Logging.Logger = Nothing
    Private _T01_Accessor As Logging.LogAccessor = Nothing

    Private Sub T01Init()
        With T01_cmbLogger.Items
            .Add("Logger")
            .Add("FormattedLogger")
        End With
        With T01_cmbAccessor.Items
            .Add("FormAccessor")
            .Add("FileAccessor")
            .Add("NullAccessor")
        End With
    End Sub

    Private Sub T01_cmbLogger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbLogger.SelectedIndexChanged

    End Sub

    Private Sub T01_cmbAccessor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbAccessor.SelectedIndexChanged
        Select Case T01_cmbAccessor.SelectedText
            Case "FormAccessor"
                _T01_Accessor = New Logging.FormAccessor(txtLog)
            Case "FileAccessor"
                _T01_Accessor = New Logging.FileAccessor()
            Case "NullAccessor"
                _T01_Accessor = New Logging.NullAccessor
        End Select
    End Sub


#End Region

End Class
