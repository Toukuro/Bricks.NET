<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T01_txtFatal = New System.Windows.Forms.TextBox()
        Me.T01_txtError = New System.Windows.Forms.TextBox()
        Me.T01_txtWarning = New System.Windows.Forms.TextBox()
        Me.T01_txtInfo = New System.Windows.Forms.TextBox()
        Me.T01_txtDetail = New System.Windows.Forms.TextBox()
        Me.T01_txtDebug = New System.Windows.Forms.TextBox()
        Me.T01_btnFatal = New System.Windows.Forms.Button()
        Me.T01_btnError = New System.Windows.Forms.Button()
        Me.T01_btnWarning = New System.Windows.Forms.Button()
        Me.T01_btnInfo = New System.Windows.Forms.Button()
        Me.T01_btnDetail = New System.Windows.Forms.Button()
        Me.T01_btnDebug = New System.Windows.Forms.Button()
        Me.T01_cmbLogger = New System.Windows.Forms.ComboBox()
        Me.T01_cmbAccessor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T01_txtOption = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.T02_btnGet = New System.Windows.Forms.Button()
        Me.T02_lblMessage = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.T02_cmbMsgSource = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.T02_txtMsgId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.T02_cmbLang = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.T02_btnSet = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(519, 522)
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
        Me.TabControl1.Size = New System.Drawing.Size(519, 265)
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
        Me.TabPage1.Size = New System.Drawing.Size(511, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Logging"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(5, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 175)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "FATAL :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ERROR :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "WARNING :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "INFO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "DETAIL :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DEBUG :"
        '
        'T01_txtFatal
        '
        Me.T01_txtFatal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtFatal.Location = New System.Drawing.Point(64, 143)
        Me.T01_txtFatal.Name = "T01_txtFatal"
        Me.T01_txtFatal.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtFatal.TabIndex = 1
        '
        'T01_txtError
        '
        Me.T01_txtError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtError.Location = New System.Drawing.Point(64, 118)
        Me.T01_txtError.Name = "T01_txtError"
        Me.T01_txtError.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtError.TabIndex = 1
        '
        'T01_txtWarning
        '
        Me.T01_txtWarning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtWarning.Location = New System.Drawing.Point(64, 93)
        Me.T01_txtWarning.Name = "T01_txtWarning"
        Me.T01_txtWarning.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtWarning.TabIndex = 1
        '
        'T01_txtInfo
        '
        Me.T01_txtInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtInfo.Location = New System.Drawing.Point(64, 68)
        Me.T01_txtInfo.Name = "T01_txtInfo"
        Me.T01_txtInfo.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtInfo.TabIndex = 1
        '
        'T01_txtDetail
        '
        Me.T01_txtDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtDetail.Location = New System.Drawing.Point(64, 43)
        Me.T01_txtDetail.Name = "T01_txtDetail"
        Me.T01_txtDetail.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtDetail.TabIndex = 1
        '
        'T01_txtDebug
        '
        Me.T01_txtDebug.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtDebug.Location = New System.Drawing.Point(64, 18)
        Me.T01_txtDebug.Name = "T01_txtDebug"
        Me.T01_txtDebug.Size = New System.Drawing.Size(361, 19)
        Me.T01_txtDebug.TabIndex = 1
        '
        'T01_btnFatal
        '
        Me.T01_btnFatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnFatal.Location = New System.Drawing.Point(430, 141)
        Me.T01_btnFatal.Name = "T01_btnFatal"
        Me.T01_btnFatal.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnFatal.TabIndex = 3
        Me.T01_btnFatal.Text = "Write"
        Me.T01_btnFatal.UseVisualStyleBackColor = True
        '
        'T01_btnError
        '
        Me.T01_btnError.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnError.Location = New System.Drawing.Point(430, 116)
        Me.T01_btnError.Name = "T01_btnError"
        Me.T01_btnError.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnError.TabIndex = 3
        Me.T01_btnError.Text = "Write"
        Me.T01_btnError.UseVisualStyleBackColor = True
        '
        'T01_btnWarning
        '
        Me.T01_btnWarning.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnWarning.Location = New System.Drawing.Point(430, 91)
        Me.T01_btnWarning.Name = "T01_btnWarning"
        Me.T01_btnWarning.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnWarning.TabIndex = 3
        Me.T01_btnWarning.Text = "Write"
        Me.T01_btnWarning.UseVisualStyleBackColor = True
        '
        'T01_btnInfo
        '
        Me.T01_btnInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnInfo.Location = New System.Drawing.Point(430, 66)
        Me.T01_btnInfo.Name = "T01_btnInfo"
        Me.T01_btnInfo.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnInfo.TabIndex = 3
        Me.T01_btnInfo.Text = "Write"
        Me.T01_btnInfo.UseVisualStyleBackColor = True
        '
        'T01_btnDetail
        '
        Me.T01_btnDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnDetail.Location = New System.Drawing.Point(430, 41)
        Me.T01_btnDetail.Name = "T01_btnDetail"
        Me.T01_btnDetail.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnDetail.TabIndex = 3
        Me.T01_btnDetail.Text = "Write"
        Me.T01_btnDetail.UseVisualStyleBackColor = True
        '
        'T01_btnDebug
        '
        Me.T01_btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_btnDebug.Location = New System.Drawing.Point(430, 16)
        Me.T01_btnDebug.Name = "T01_btnDebug"
        Me.T01_btnDebug.Size = New System.Drawing.Size(64, 23)
        Me.T01_btnDebug.TabIndex = 3
        Me.T01_btnDebug.Text = "Write"
        Me.T01_btnDebug.UseVisualStyleBackColor = True
        '
        'T01_cmbLogger
        '
        Me.T01_cmbLogger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_cmbLogger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T01_cmbLogger.FormattingEnabled = True
        Me.T01_cmbLogger.Location = New System.Drawing.Point(69, 6)
        Me.T01_cmbLogger.Name = "T01_cmbLogger"
        Me.T01_cmbLogger.Size = New System.Drawing.Size(248, 20)
        Me.T01_cmbLogger.TabIndex = 4
        '
        'T01_cmbAccessor
        '
        Me.T01_cmbAccessor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_cmbAccessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T01_cmbAccessor.FormattingEnabled = True
        Me.T01_cmbAccessor.Location = New System.Drawing.Point(69, 32)
        Me.T01_cmbAccessor.Name = "T01_cmbAccessor"
        Me.T01_cmbAccessor.Size = New System.Drawing.Size(248, 20)
        Me.T01_cmbAccessor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Logger :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Accessor :"
        '
        'T01_txtOption
        '
        Me.T01_txtOption.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T01_txtOption.Location = New System.Drawing.Point(322, 32)
        Me.T01_txtOption.Name = "T01_txtOption"
        Me.T01_txtOption.Size = New System.Drawing.Size(183, 19)
        Me.T01_txtOption.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.T02_btnGet)
        Me.TabPage2.Controls.Add(Me.T02_lblMessage)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.T02_txtMsgId)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(511, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Message"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'T02_btnGet
        '
        Me.T02_btnGet.Location = New System.Drawing.Point(297, 60)
        Me.T02_btnGet.Name = "T02_btnGet"
        Me.T02_btnGet.Size = New System.Drawing.Size(75, 23)
        Me.T02_btnGet.TabIndex = 8
        Me.T02_btnGet.Text = "GET"
        Me.T02_btnGet.UseVisualStyleBackColor = True
        '
        'T02_lblMessage
        '
        Me.T02_lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T02_lblMessage.Location = New System.Drawing.Point(70, 87)
        Me.T02_lblMessage.Margin = New System.Windows.Forms.Padding(3)
        Me.T02_lblMessage.Name = "T02_lblMessage"
        Me.T02_lblMessage.Size = New System.Drawing.Size(300, 20)
        Me.T02_lblMessage.TabIndex = 7
        Me.T02_lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 12)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "MessageSource:"
        '
        'T02_cmbMsgSource
        '
        Me.T02_cmbMsgSource.FormattingEnabled = True
        Me.T02_cmbMsgSource.Items.AddRange(New Object() {"StringResourceMessage", "FileResourceMessage"})
        Me.T02_cmbMsgSource.Location = New System.Drawing.Point(99, 18)
        Me.T02_cmbMsgSource.Name = "T02_cmbMsgSource"
        Me.T02_cmbMsgSource.Size = New System.Drawing.Size(150, 20)
        Me.T02_cmbMsgSource.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Message:"
        '
        'T02_txtMsgId
        '
        Me.T02_txtMsgId.Location = New System.Drawing.Point(70, 62)
        Me.T02_txtMsgId.Name = "T02_txtMsgId"
        Me.T02_txtMsgId.Size = New System.Drawing.Size(200, 19)
        Me.T02_txtMsgId.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "MsgId:"
        '
        'T02_cmbLang
        '
        Me.T02_cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.T02_cmbLang.FormattingEnabled = True
        Me.T02_cmbLang.Items.AddRange(New Object() {" ", "JPN", "ENG"})
        Me.T02_cmbLang.Location = New System.Drawing.Point(316, 18)
        Me.T02_cmbLang.Name = "T02_cmbLang"
        Me.T02_cmbLang.Size = New System.Drawing.Size(50, 20)
        Me.T02_cmbLang.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Language:"
        '
        'txtLog
        '
        Me.txtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLog.Location = New System.Drawing.Point(0, 0)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(519, 253)
        Me.txtLog.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.T02_btnSet)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.T02_cmbMsgSource)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.T02_cmbLang)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 50)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Settings"
        '
        'T02_btnSet
        '
        Me.T02_btnSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T02_btnSet.Location = New System.Drawing.Point(418, 16)
        Me.T02_btnSet.Name = "T02_btnSet"
        Me.T02_btnSet.Size = New System.Drawing.Size(75, 23)
        Me.T02_btnSet.TabIndex = 9
        Me.T02_btnSet.Text = "SET"
        Me.T02_btnSet.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 522)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MainForm"
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
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label11 As Label
    Friend WithEvents T02_txtMsgId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents T02_cmbLang As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents T02_lblMessage As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents T02_cmbMsgSource As ComboBox
    Friend WithEvents T02_btnGet As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents T02_btnSet As Button
End Class
