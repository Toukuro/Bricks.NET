Imports BricksCore
Imports BricksForm

Public Class Form1

#Region "Form Events"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        T01_Init()
    End Sub

#End Region

#Region "Logging"

    Private _Logger As New Logging.Logger
    Private _Accessor As Logging.LogAccessor = Nothing

    Private Sub T01_Init()
        With T01_cmbLogger.Items
            .Add("Logger")
            .Add("FormattedLogger")
        End With
        T01_cmbLogger.SelectedIndex = 0

        With T01_cmbAccessor.Items
            .Add("FormAccessor")
            .Add("FileAccessor")
            .Add("NullAccessor")
        End With
        T01_cmbAccessor.SelectedIndex = 0
    End Sub

    Private Sub T01_cmbLogger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbLogger.SelectedIndexChanged
        Select Case T01_cmbLogger.SelectedItem
            Case "Logger"
                _Logger = New Logging.Logger(_Accessor)
            Case "FormattedLogger"
                _Logger = New Logging.FormattedLogger(_Accessor)
        End Select
    End Sub

    Private Sub T01_cmbAccessor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbAccessor.SelectedIndexChanged
        Select Case T01_cmbAccessor.SelectedItem
            Case "FormAccessor"
                _Accessor = New Logging.FormAccessor(txtLog)
                _Logger.Accessor = _Accessor
            Case "FileAccessor"
                _Accessor = New Logging.FileAccessor()
                _Logger.Accessor = _Accessor
            Case "NullAccessor"
                _Accessor = New Logging.NullAccessor
                _Logger.Accessor = _Accessor
        End Select
    End Sub

    Private Sub T01_btnDebug_Click(sender As Object, e As EventArgs) Handles T01_btnDebug.Click
        _Logger.Debug(T01_txtDebug.Text)
    End Sub

    Private Sub T01_btnDetail_Click(sender As Object, e As EventArgs) Handles T01_btnDetail.Click
        _Logger.Detail(T01_txtDetail.Text)
    End Sub

    Private Sub T01_btnInfo_Click(sender As Object, e As EventArgs) Handles T01_btnInfo.Click
        _Logger.Info(T01_txtInfo.Text)
    End Sub

    Private Sub T01_btnWarning_Click(sender As Object, e As EventArgs) Handles T01_btnWarning.Click
        _Logger.Warning(T01_txtWarning.Text)
    End Sub

    Private Sub T01_btnError_Click(sender As Object, e As EventArgs) Handles T01_btnError.Click
        _Logger.Error(T01_txtError.Text)
    End Sub

    Private Sub T01_btnFatal_Click(sender As Object, e As EventArgs) Handles T01_btnFatal.Click
        _Logger.Fatal(T01_txtFatal.Text)
    End Sub

#End Region

End Class
