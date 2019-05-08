<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.T01_cmbLogger = New System.Windows.Forms.ComboBox()
        Me.T01_cmbAccessor = New System.Windows.Forms.ComboBox()
        Me.T01_btnDebug = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T01_txtDebug = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T01_txtDetail = New System.Windows.Forms.TextBox()
        Me.T01_txtInfo = New System.Windows.Forms.TextBox()
        Me.T01_txtWarning = New System.Windows.Forms.TextBox()
        Me.T01_txtError = New System.Windows.Forms.TextBox()
        Me.T01_txtFatal = New System.Windows.Forms.TextBox()
        Me.T01_btnDetail = New System.Windows.Forms.Button()
        Me.T01_btnInfo = New System.Windows.Forms.Button()
        Me.T01_btnWarning = New System.Windows.Forms.Button()
        Me.T01_btnError = New System.Windows.Forms.Button()
        Me.T01_btnFatal = New System.Windows.Forms.Button()
        Me.T01_txtOption = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLog)
        Me.SplitContainer1.Size = New System.Drawing.Size(605, 522)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(605, 265)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.T01_cmbLogger)
        Me.TabPage1.Controls.Add(Me.T01_cmbAccessor)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.T01_txtOption)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(597, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Logging"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'T01_cmbLogger
        '
        Me.T01_cmbLogger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_cmbLogger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T01_cmbLogger.FormattingEnabled = True
        Me.T01_cmbLogger.Location = New System.Drawing.Point(81, 6)
        Me.T01_cmbLogger.Name = "T01_cmbLogger"
        Me.T01_cmbLogger.Size = New System.Drawing.Size(289, 20)
        Me.T01_cmbLogger.TabIndex = 4
        '
        'T01_cmbAccessor
        '
        Me.T01_cmbAccessor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_cmbAccessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T01_cmbAccessor.FormattingEnabled = True
        Me.T01_cmbAccessor.Location = New System.Drawing.Point(81, 32)
        Me.T01_cmbAccessor.Name = "T01_cmbAccessor"
        Me.T01_cmbAccessor.Size = New System.Drawing.Size(289, 20)
        Me.T01_cmbAccessor.TabIndex = 4
        '
        'T01_btnDebug
        '
        Me.T01_btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnDebug.Location = New System.Drawing.Point(502, 16)
        Me.T01_btnDebug.Name = "T01_btnDebug"
        Me.T01_btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnDebug.TabIndex = 3
        Me.T01_btnDebug.Text = "Write"
        Me.T01_btnDebug.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Logger :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Accessor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DEBUG :"
        '
        'T01_txtDebug
        '
        Me.T01_txtDebug.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtDebug.Location = New System.Drawing.Point(75, 18)
        Me.T01_txtDebug.Name = "T01_txtDebug"
        Me.T01_txtDebug.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtDebug.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(597, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(0, 0)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(605, 253)
        Me.txtLog.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.T01_txtFatal)
        Me.GroupBox1.Controls.Add(Me.T01_txtError)
        Me.GroupBox1.Controls.Add(Me.T01_txtWarning)
        Me.GroupBox1.Controls.Add(Me.T01_txtInfo)
        Me.GroupBox1.Controls.Add(Me.T01_txtDetail)
        Me.GroupBox1.Controls.Add(Me.T01_txtDebug)
        Me.GroupBox1.Controls.Add(Me.T01_btnFatal)
        Me.GroupBox1.Controls.Add(Me.T01_btnError)
        Me.GroupBox1.Controls.Add(Me.T01_btnWarning)
        Me.GroupBox1.Controls.Add(Me.T01_btnInfo)
        Me.GroupBox1.Controls.Add(Me.T01_btnDetail)
        Me.GroupBox1.Controls.Add(Me.T01_btnDebug)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 175)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DETAIL :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "INFO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "WARNING :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ERROR :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "FATAL :"
        '
        'T01_txtDetail
        '
        Me.T01_txtDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtDetail.Location = New System.Drawing.Point(75, 43)
        Me.T01_txtDetail.Name = "T01_txtDetail"
        Me.T01_txtDetail.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtDetail.TabIndex = 1
        '
        'T01_txtInfo
        '
        Me.T01_txtInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtInfo.Location = New System.Drawing.Point(75, 68)
        Me.T01_txtInfo.Name = "T01_txtInfo"
        Me.T01_txtInfo.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtInfo.TabIndex = 1
        '
        'T01_txtWarning
        '
        Me.T01_txtWarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtWarning.Location = New System.Drawing.Point(75, 93)
        Me.T01_txtWarning.Name = "T01_txtWarning"
        Me.T01_txtWarning.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtWarning.TabIndex = 1
        '
        'T01_txtError
        '
        Me.T01_txtError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtError.Location = New System.Drawing.Point(75, 118)
        Me.T01_txtError.Name = "T01_txtError"
        Me.T01_txtError.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtError.TabIndex = 1
        '
        'T01_txtFatal
        '
        Me.T01_txtFatal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtFatal.Location = New System.Drawing.Point(75, 143)
        Me.T01_txtFatal.Name = "T01_txtFatal"
        Me.T01_txtFatal.Size = New System.Drawing.Size(421, 19)
        Me.T01_txtFatal.TabIndex = 1
        '
        'T01_btnDetail
        '
        Me.T01_btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnDetail.Location = New System.Drawing.Point(502, 41)
        Me.T01_btnDetail.Name = "T01_btnDetail"
        Me.T01_btnDetail.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnDetail.TabIndex = 3
        Me.T01_btnDetail.Text = "Write"
        Me.T01_btnDetail.UseVisualStyleBackColor = True
        '
        'T01_btnInfo
        '
        Me.T01_btnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnInfo.Location = New System.Drawing.Point(502, 66)
        Me.T01_btnInfo.Name = "T01_btnInfo"
        Me.T01_btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnInfo.TabIndex = 3
        Me.T01_btnInfo.Text = "Write"
        Me.T01_btnInfo.UseVisualStyleBackColor = True
        '
        'T01_btnWarning
        '
        Me.T01_btnWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnWarning.Location = New System.Drawing.Point(502, 91)
        Me.T01_btnWarning.Name = "T01_btnWarning"
        Me.T01_btnWarning.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnWarning.TabIndex = 3
        Me.T01_btnWarning.Text = "Write"
        Me.T01_btnWarning.UseVisualStyleBackColor = True
        '
        'T01_btnError
        '
        Me.T01_btnError.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnError.Location = New System.Drawing.Point(502, 116)
        Me.T01_btnError.Name = "T01_btnError"
        Me.T01_btnError.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnError.TabIndex = 3
        Me.T01_btnError.Text = "Write"
        Me.T01_btnError.UseVisualStyleBackColor = True
        '
        'T01_btnFatal
        '
        Me.T01_btnFatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnFatal.Location = New System.Drawing.Point(502, 141)
        Me.T01_btnFatal.Name = "T01_btnFatal"
        Me.T01_btnFatal.Size = New System.Drawing.Size(75, 23)
        Me.T01_btnFatal.TabIndex = 3
        Me.T01_btnFatal.Text = "Write"
        Me.T01_btnFatal.UseVisualStyleBackColor = True
        '
        'T01_txtOption
        '
        Me.T01_txtOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtOption.Location = New System.Drawing.Point(376, 32)
        Me.T01_txtOption.Name = "T01_txtOption"
        Me.T01_txtOption.Size = New System.Drawing.Size(213, 19)
        Me.T01_txtOption.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Bricks Test"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents T01_btnDebug As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents T01_txtDebug As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtLog As TextBox
    Friend WithEvents T01_cmbAccessor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents T01_cmbLogger As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents T01_txtFatal As TextBox
    Friend WithEvents T01_txtError As TextBox
    Friend WithEvents T01_txtWarning As TextBox
    Friend WithEvents T01_txtInfo As TextBox
    Friend WithEvents T01_txtDetail As TextBox
    Friend WithEvents T01_btnFatal As Button
    Friend WithEvents T01_btnError As Button
    Friend WithEvents T01_btnWarning As Button
    Friend WithEvents T01_btnInfo As Button
    Friend WithEvents T01_btnDetail As Button
    Friend WithEvents T01_txtOption As TextBox
End Class
