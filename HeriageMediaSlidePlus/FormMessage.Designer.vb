<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMessage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMessage))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAddress = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PicClient = New System.Windows.Forms.PictureBox()
        Me.ButtonAddIP = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lnkOnline = New System.Windows.Forms.LinkLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.cmsEditing = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwayToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBusy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAppearOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.SendFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSaveLoc = New System.Windows.Forms.ToolStripTextBox()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveConversationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutRapidChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.cmsEditing.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAddress)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.PicClient)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Data"
        '
        'cmbAddress
        '
        Me.cmbAddress.FormattingEnabled = True
        Me.cmbAddress.Location = New System.Drawing.Point(6, 15)
        Me.cmbAddress.Name = "cmbAddress"
        Me.cmbAddress.Size = New System.Drawing.Size(84, 21)
        Me.cmbAddress.TabIndex = 7
        '
        'btnConnect
        '
        Me.btnConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConnect.BackColor = System.Drawing.Color.LightGray
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(96, 15)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(74, 64)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect..."
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Display Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(6, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(72, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "Navigator"
        '
        'PicClient
        '
        Me.PicClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicClient.ErrorImage = CType(resources.GetObject("PicClient.ErrorImage"), System.Drawing.Image)
        Me.PicClient.Location = New System.Drawing.Point(326, 11)
        Me.PicClient.Name = "PicClient"
        Me.PicClient.Size = New System.Drawing.Size(10, 25)
        Me.PicClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicClient.TabIndex = 0
        Me.PicClient.TabStop = False
        '
        'ButtonAddIP
        '
        Me.ButtonAddIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddIP.Location = New System.Drawing.Point(13, 30)
        Me.ButtonAddIP.Name = "ButtonAddIP"
        Me.ButtonAddIP.Size = New System.Drawing.Size(72, 19)
        Me.ButtonAddIP.TabIndex = 7
        Me.ButtonAddIP.Text = "Add IP"
        Me.ButtonAddIP.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.pnlStatus)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.ButtonClear)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.MenuStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 218)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History"
        '
        'pnlStatus
        '
        Me.pnlStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lnkOnline)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.btnClose)
        Me.pnlStatus.Location = New System.Drawing.Point(5, 39)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(283, 40)
        Me.pnlStatus.TabIndex = 7
        Me.pnlStatus.Visible = False
        '
        'lnkOnline
        '
        Me.lnkOnline.AutoSize = True
        Me.lnkOnline.Location = New System.Drawing.Point(3, 20)
        Me.lnkOnline.Name = "lnkOnline"
        Me.lnkOnline.Size = New System.Drawing.Size(114, 13)
        Me.lnkOnline.TabIndex = 8
        Me.lnkOnline.TabStop = True
        Me.lnkOnline.Text = "Click here to go Online"
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.Location = New System.Drawing.Point(3, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(222, 18)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Label2"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.Color.LightGray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(236, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ContextMenuStrip = Me.cmsEditing
        Me.RichTextBox1.Location = New System.Drawing.Point(-1, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(301, 127)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'cmsEditing
        '
        Me.cmsEditing.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsmCut, Me.cmsmCopy, Me.ToolStripSeparator12, Me.SelectAllToolStripMenuItem})
        Me.cmsEditing.Name = "cmsEditing"
        Me.cmsEditing.Size = New System.Drawing.Size(145, 76)
        '
        'cmsmCut
        '
        Me.cmsmCut.Enabled = False
        Me.cmsmCut.Name = "cmsmCut"
        Me.cmsmCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmsmCut.Size = New System.Drawing.Size(144, 22)
        Me.cmsmCut.Text = "&Cut"
        '
        'cmsmCopy
        '
        Me.cmsmCopy.Enabled = False
        Me.cmsmCopy.Name = "cmsmCopy"
        Me.cmsmCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.cmsmCopy.Size = New System.Drawing.Size(144, 22)
        Me.cmsmCopy.Text = "&Copy"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "S&elect All"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 72)
        Me.TextBox1.MaxLength = 88888
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(185, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripMenuItem2, Me.ToolStripSeparator9, Me.SendFileToolStripMenuItem, Me.SaveLocationToolStripMenuItem, Me.ToolStripSeparator6, Me.SaveConversationToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator7, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'StatusToolStripMenuItem2
        '
        Me.StatusToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineToolStripMenuItem2, Me.AwayToolStripMenuItem2, Me.mnuBusy, Me.mnuAppearOff})
        Me.StatusToolStripMenuItem2.Image = CType(resources.GetObject("StatusToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.StatusToolStripMenuItem2.Name = "StatusToolStripMenuItem2"
        Me.StatusToolStripMenuItem2.Size = New System.Drawing.Size(147, 22)
        Me.StatusToolStripMenuItem2.Text = "Status"
        '
        'OnlineToolStripMenuItem2
        '
        Me.OnlineToolStripMenuItem2.Name = "OnlineToolStripMenuItem2"
        Me.OnlineToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.OnlineToolStripMenuItem2.Text = "Online"
        '
        'AwayToolStripMenuItem2
        '
        Me.AwayToolStripMenuItem2.Name = "AwayToolStripMenuItem2"
        Me.AwayToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.AwayToolStripMenuItem2.Tag = "My Status is Currently Set To Away"
        Me.AwayToolStripMenuItem2.Text = "Away"
        '
        'mnuBusy
        '
        Me.mnuBusy.Name = "mnuBusy"
        Me.mnuBusy.Size = New System.Drawing.Size(151, 22)
        Me.mnuBusy.Tag = "My Status is Currently Set To Busy"
        Me.mnuBusy.Text = "Busy"
        '
        'mnuAppearOff
        '
        Me.mnuAppearOff.Name = "mnuAppearOff"
        Me.mnuAppearOff.Size = New System.Drawing.Size(151, 22)
        Me.mnuAppearOff.Text = "Appear Offline"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(144, 6)
        '
        'SendFileToolStripMenuItem
        '
        Me.SendFileToolStripMenuItem.Name = "SendFileToolStripMenuItem"
        Me.SendFileToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SendFileToolStripMenuItem.Text = "S&end Files..."
        '
        'SaveLocationToolStripMenuItem
        '
        Me.SaveLocationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSaveLoc, Me.BrowseToolStripMenuItem})
        Me.SaveLocationToolStripMenuItem.Name = "SaveLocationToolStripMenuItem"
        Me.SaveLocationToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveLocationToolStripMenuItem.Text = "Save Location"
        '
        'txtSaveLoc
        '
        Me.txtSaveLoc.Name = "txtSaveLoc"
        Me.txtSaveLoc.Size = New System.Drawing.Size(100, 23)
        Me.txtSaveLoc.Text = "C:\"
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BrowseToolStripMenuItem.Text = "Browse..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(144, 6)
        '
        'SaveConversationToolStripMenuItem
        '
        Me.SaveConversationToolStripMenuItem.Name = "SaveConversationToolStripMenuItem"
        Me.SaveConversationToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveConversationToolStripMenuItem.Text = "Save &As..."
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(144, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(147, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCut, Me.mnuCopy, Me.ToolStripSeparator5, Me.mnuSelectAll, Me.ToolStripSeparator11, Me.SettingsToolStripMenuItem2})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'mnuCut
        '
        Me.mnuCut.Enabled = False
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuCut.Text = "&Cut"
        '
        'mnuCopy
        '
        Me.mnuCopy.Enabled = False
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuCopy.Text = "&Copy"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(141, 6)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.Size = New System.Drawing.Size(144, 22)
        Me.mnuSelectAll.Text = "S&elect All..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(141, 6)
        '
        'SettingsToolStripMenuItem2
        '
        Me.SettingsToolStripMenuItem2.Name = "SettingsToolStripMenuItem2"
        Me.SettingsToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.SettingsToolStripMenuItem2.Text = "Settings"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem1, Me.FontColourToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.FontToolStripMenuItem1.Text = "Font"
        '
        'FontColourToolStripMenuItem
        '
        Me.FontColourToolStripMenuItem.Name = "FontColourToolStripMenuItem"
        Me.FontColourToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FontColourToolStripMenuItem.Text = "Font Colour"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutRapidChatToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Image = CType(resources.GetObject("HelpToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutRapidChatToolStripMenuItem
        '
        Me.AboutRapidChatToolStripMenuItem.Name = "AboutRapidChatToolStripMenuItem"
        Me.AboutRapidChatToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AboutRapidChatToolStripMenuItem.Text = "About Rapid Chat..."
        '
        'txtmessage
        '
        Me.txtmessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmessage.Location = New System.Drawing.Point(447, 137)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(198, 40)
        Me.txtmessage.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonClear.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClear.Location = New System.Drawing.Point(187, 15)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(89, 20)
        Me.ButtonClear.TabIndex = 0
        Me.ButtonClear.Text = "Clear All"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.LightGray
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Enabled = False
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Location = New System.Drawing.Point(583, 179)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(62, 29)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(524, 179)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(53, 29)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(447, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ButtonAddIP)
        Me.Panel1.Controls.Add(Me.txtIP)
        Me.Panel1.Location = New System.Drawing.Point(172, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 53)
        Me.Panel1.TabIndex = 1
        '
        'txtIP
        '
        Me.txtIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIP.Location = New System.Drawing.Point(13, 4)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(111, 20)
        Me.txtIP.TabIndex = 4
        '
        'FormMessage
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 466)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(349, 505)
        Me.Name = "FormMessage"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navigator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.cmsEditing.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicClient As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmessage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSaveLoc As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveConversationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutRapidChatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontColourToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents StatusToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwayToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBusy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAppearOff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsEditing As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsmCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsmCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lnkOnline As System.Windows.Forms.LinkLabel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ButtonAddIP As System.Windows.Forms.Button
    Friend WithEvents cmbAddress As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtIP As System.Windows.Forms.TextBox

End Class
