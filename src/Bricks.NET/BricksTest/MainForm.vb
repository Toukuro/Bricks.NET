Imports BricksCore
Imports BricksForm

Public Class MainForm

#Region "Form Events"

    Public TestLog As Logging.Logger = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim logfname As String = String.Format("Test-{0:yyyyMMdd}.log", DateTime.Today)
        TestLog = New Logging.FormattedLogger(New Logging.FileAccessor(logfname))
        Dim s As String = My.Resources.ResourceManager.GetString("TestString")
        TestLog.Info("======== Bricks Test Start.")
        T01_Init()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TestLog.Info("======== Bricks Test Ended.")
    End Sub

#End Region

#Region "Logging"

    Private _Logger As New Logging.Logger
    Private _Accessor As Logging.LogAccessor = Nothing

    Private Sub T01_Init()
        TestLog.Info("method start")

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

        TestLog.Info("method end")
    End Sub

    Private Sub T01_cmbLogger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbLogger.SelectedIndexChanged
        TestLog.Info("method start")

        Select Case T01_cmbLogger.SelectedItem
            Case "Logger"
                _Logger = New Logging.Logger(_Accessor)
            Case "FormattedLogger"
                _Logger = New Logging.FormattedLogger(_Accessor)
        End Select

        TestLog.Info("method end")
    End Sub

    Private Sub T01_cmbAccessor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles T01_cmbAccessor.SelectedIndexChanged
        TestLog.Info("method start")

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

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnDebug_Click(sender As Object, e As EventArgs) Handles T01_btnDebug.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtDebug.Text)

        _Logger.Debug(T01_txtDebug.Text)

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnDetail_Click(sender As Object, e As EventArgs) Handles T01_btnDetail.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtDetail.Text)

        _Logger.Detail(T01_txtDetail.Text)

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnInfo_Click(sender As Object, e As EventArgs) Handles T01_btnInfo.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtInfo.Text)

        _Logger.Info(T01_txtInfo.Text)

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnWarning_Click(sender As Object, e As EventArgs) Handles T01_btnWarning.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtWarning.Text)

        _Logger.Warning(T01_txtWarning.Text)

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnError_Click(sender As Object, e As EventArgs) Handles T01_btnError.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtError.Text)

        _Logger.Error(T01_txtError.Text)

        TestLog.Info("method end")
    End Sub

    Private Sub T01_btnFatal_Click(sender As Object, e As EventArgs) Handles T01_btnFatal.Click
        TestLog.Info("method start. Text=[{0}]", T01_txtFatal.Text)

        _Logger.Fatal(T01_txtFatal.Text)

        TestLog.Info("method end")
    End Sub

#End Region

End Class
