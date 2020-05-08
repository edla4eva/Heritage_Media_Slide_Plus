<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Genesis 1:1 (KJV)", "In the begining was the world and the..."}, -1)
        Me.ListBoxMain = New System.Windows.Forms.ListBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelNavigator = New System.Windows.Forms.Label()
        Me.SplitContainerDriverTab = New System.Windows.Forms.SplitContainer()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.ListBoxNavigaor = New System.Windows.Forms.ListBox()
        Me.ListBoxDriver = New System.Windows.Forms.ListBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonUse = New System.Windows.Forms.Button()
        Me.ButtonUseNavigaor = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPageService = New System.Windows.Forms.TabPage()
        Me.ListBoxService = New System.Windows.Forms.ListBox()
        Me.TabPageBackgrounds = New System.Windows.Forms.TabPage()
        Me.ButtonNewImage = New System.Windows.Forms.Button()
        Me.CheckBoxScaled = New System.Windows.Forms.CheckBox()
        Me.ButtonImportImage = New System.Windows.Forms.Button()
        Me.TabPageFormat = New System.Windows.Forms.TabPage()
        Me.comboboxdisplayOption = New System.Windows.Forms.ComboBox()
        Me.Resolution = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxProjectorResolutionW = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxProjectorResolutionH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxResolutionW = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxResolutionH = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonFull = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLowerThird = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.LabelBackColor = New System.Windows.Forms.Label()
        Me.LabelForeColor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxMaxCharsPerLine = New System.Windows.Forms.TextBox()
        Me.CheckBoxTransparent = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxFontSize = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxMaxLines = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonApplyFormatSettings = New System.Windows.Forms.Button()
        Me.TextBoxFontFamily = New System.Windows.Forms.TextBox()
        Me.ButtonFont = New System.Windows.Forms.Button()
        Me.TabPageBibles = New System.Windows.Forms.TabPage()
        Me.LabelExpand = New System.Windows.Forms.Label()
        Me.CheckBoxLive = New System.Windows.Forms.CheckBox()
        Me.ListBoxVerse = New System.Windows.Forms.ListBox()
        Me.ListBoxChapter = New System.Windows.Forms.ListBox()
        Me.ListBoxBook = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBoxBibles = New System.Windows.Forms.ListBox()
        Me.ListBoxBibleVersions = New System.Windows.Forms.ListBox()
        Me.ListViewBible = New System.Windows.Forms.ListView()
        Me.ColumnHeaderRef = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPassage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageSongs = New System.Windows.Forms.TabPage()
        Me.ListBoxSongs = New System.Windows.Forms.ListBox()
        Me.TabPageSearch = New System.Windows.Forms.TabPage()
        Me.LabelExpandSearch = New System.Windows.Forms.Label()
        Me.ListBoxSearchBible = New System.Windows.Forms.ListBox()
        Me.ListBoxSearchSongsDB = New System.Windows.Forms.ListBox()
        Me.ButtonSearchSongFiles = New System.Windows.Forms.Button()
        Me.ButtonDBSongs = New System.Windows.Forms.Button()
        Me.ListBoxSearch = New System.Windows.Forms.ListBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearchBible = New System.Windows.Forms.Button()
        Me.RichTextBoxSearch = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageLayouts = New System.Windows.Forms.TabPage()
        Me.ButtonDeleteLayout = New System.Windows.Forms.Button()
        Me.ButtonLoadLayout = New System.Windows.Forms.Button()
        Me.ButtonSaveLayout = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelLayouts = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMultiuser = New System.Windows.Forms.CheckBox()
        Me.cmbAddress = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PicClient = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtonAddIP = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.TabPageMulti = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lnkOnline = New System.Windows.Forms.LinkLabel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelDriver = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxStatus = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBoxLive = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonBlank = New System.Windows.Forms.Button()
        Me.ButtonI = New System.Windows.Forms.Button()
        Me.ButtonLive = New System.Windows.Forms.Button()
        Me.ButtonSendToDriver = New System.Windows.Forms.Button()
        Me.PictureBoxPreview = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clrFont = New System.Windows.Forms.ColorDialog()
        Me.cmsEditing = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsmCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainerDriverTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerDriverTab.Panel1.SuspendLayout()
        Me.SplitContainerDriverTab.Panel2.SuspendLayout()
        Me.SplitContainerDriverTab.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPageService.SuspendLayout()
        Me.TabPageBackgrounds.SuspendLayout()
        Me.TabPageFormat.SuspendLayout()
        Me.Resolution.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBibles.SuspendLayout()
        Me.TabPageSongs.SuspendLayout()
        Me.TabPageSearch.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageLayouts.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabPageMulti.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBoxLive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsEditing.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxMain
        '
        Me.ListBoxMain.FormattingEnabled = True
        Me.ListBoxMain.HorizontalScrollbar = True
        Me.ListBoxMain.ItemHeight = 20
        Me.ListBoxMain.Items.AddRange(New Object() {"In the begining God created the ", "heaven and the earth."})
        Me.ListBoxMain.Location = New System.Drawing.Point(3, 24)
        Me.ListBoxMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxMain.Name = "ListBoxMain"
        Me.ListBoxMain.Size = New System.Drawing.Size(240, 504)
        Me.ListBoxMain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(827, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Preview"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Live"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Location = New System.Drawing.Point(28, 11)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelNavigator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainerDriverTab)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelDriver)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBoxMain)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(752, 541)
        Me.SplitContainer1.SplitterDistance = 489
        Me.SplitContainer1.TabIndex = 6
        '
        'LabelNavigator
        '
        Me.LabelNavigator.AutoSize = True
        Me.LabelNavigator.Location = New System.Drawing.Point(18, 2)
        Me.LabelNavigator.Name = "LabelNavigator"
        Me.LabelNavigator.Size = New System.Drawing.Size(78, 20)
        Me.LabelNavigator.TabIndex = 17
        Me.LabelNavigator.Text = "Navigator:"
        '
        'SplitContainerDriverTab
        '
        Me.SplitContainerDriverTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainerDriverTab.Location = New System.Drawing.Point(2, 19)
        Me.SplitContainerDriverTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainerDriverTab.Name = "SplitContainerDriverTab"
        Me.SplitContainerDriverTab.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerDriverTab.Panel1
        '
        Me.SplitContainerDriverTab.Panel1.Controls.Add(Me.lblMessage)
        Me.SplitContainerDriverTab.Panel1.Controls.Add(Me.ListBoxNavigaor)
        Me.SplitContainerDriverTab.Panel1.Controls.Add(Me.ListBoxDriver)
        Me.SplitContainerDriverTab.Panel1.Controls.Add(Me.Panel7)
        '
        'SplitContainerDriverTab.Panel2
        '
        Me.SplitContainerDriverTab.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainerDriverTab.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainerDriverTab.Size = New System.Drawing.Size(485, 506)
        Me.SplitContainerDriverTab.SplitterDistance = 242
        Me.SplitContainerDriverTab.SplitterWidth = 3
        Me.SplitContainerDriverTab.TabIndex = 16
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(10, 182)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(45, 40)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "         " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMessage.Visible = False
        '
        'ListBoxNavigaor
        '
        Me.ListBoxNavigaor.FormattingEnabled = True
        Me.ListBoxNavigaor.HorizontalScrollbar = True
        Me.ListBoxNavigaor.ItemHeight = 20
        Me.ListBoxNavigaor.Items.AddRange(New Object() {"[SONG TITLE]", "Once Again", "[AUTHOUR]", "Unknown", "Once again I look upon the cross where you died", "Im humbled by our mercy and I'm broken inside", "Once again I thank You", "Once again I pour out my love", "", "Repeat", "Once again I thank You", "Once again I pour out my love", ""})
        Me.ListBoxNavigaor.Location = New System.Drawing.Point(20, 7)
        Me.ListBoxNavigaor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxNavigaor.Name = "ListBoxNavigaor"
        Me.ListBoxNavigaor.Size = New System.Drawing.Size(211, 184)
        Me.ListBoxNavigaor.TabIndex = 2
        '
        'ListBoxDriver
        '
        Me.ListBoxDriver.FormattingEnabled = True
        Me.ListBoxDriver.HorizontalScrollbar = True
        Me.ListBoxDriver.ItemHeight = 20
        Me.ListBoxDriver.Items.AddRange(New Object() {"Oh Oh Oh Oh Lord", "Hear my cry when I call", "Oh Oh Oh Oh Lord", "I cant go on without you", "", "Oh Oh Oh Oh Lord", "Hear my cry when I call", "Oh Oh Oh Oh Lord", "I cant go on without you", "", "Oh Oh Oh Oh Lord", "Hear my cry when I call", "Oh Oh Oh Oh Lord", "I cant go on without you"})
        Me.ListBoxDriver.Location = New System.Drawing.Point(237, 7)
        Me.ListBoxDriver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxDriver.Name = "ListBoxDriver"
        Me.ListBoxDriver.Size = New System.Drawing.Size(240, 184)
        Me.ListBoxDriver.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.ButtonUse)
        Me.Panel7.Controls.Add(Me.ButtonUseNavigaor)
        Me.Panel7.Location = New System.Drawing.Point(8, 189)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(468, 42)
        Me.Panel7.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoEllipsis = True
        Me.Label13.BackColor = System.Drawing.Color.AliceBlue
        Me.Label13.Location = New System.Drawing.Point(6, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 43)
        Me.Label13.TabIndex = 13
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonUse
        '
        Me.ButtonUse.Location = New System.Drawing.Point(242, 7)
        Me.ButtonUse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonUse.Name = "ButtonUse"
        Me.ButtonUse.Size = New System.Drawing.Size(136, 33)
        Me.ButtonUse.TabIndex = 7
        Me.ButtonUse.Text = "Use (Live)"
        Me.ButtonUse.UseVisualStyleBackColor = True
        '
        'ButtonUseNavigaor
        '
        Me.ButtonUseNavigaor.Location = New System.Drawing.Point(40, 4)
        Me.ButtonUseNavigaor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonUseNavigaor.Name = "ButtonUseNavigaor"
        Me.ButtonUseNavigaor.Size = New System.Drawing.Size(133, 36)
        Me.ButtonUseNavigaor.TabIndex = 8
        Me.ButtonUseNavigaor.Text = "Use"
        Me.ButtonUseNavigaor.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPageService)
        Me.TabControl2.Controls.Add(Me.TabPageBackgrounds)
        Me.TabControl2.Controls.Add(Me.TabPageFormat)
        Me.TabControl2.Controls.Add(Me.TabPageBibles)
        Me.TabControl2.Controls.Add(Me.TabPageSongs)
        Me.TabControl2.Controls.Add(Me.TabPageSearch)
        Me.TabControl2.Location = New System.Drawing.Point(4, 32)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(489, 221)
        Me.TabControl2.TabIndex = 15
        '
        'TabPageService
        '
        Me.TabPageService.Controls.Add(Me.ListBoxService)
        Me.TabPageService.Location = New System.Drawing.Point(4, 29)
        Me.TabPageService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageService.Name = "TabPageService"
        Me.TabPageService.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageService.Size = New System.Drawing.Size(481, 188)
        Me.TabPageService.TabIndex = 0
        Me.TabPageService.Text = "Service"
        Me.TabPageService.UseVisualStyleBackColor = True
        '
        'ListBoxService
        '
        Me.ListBoxService.AllowDrop = True
        Me.ListBoxService.FormattingEnabled = True
        Me.ListBoxService.ItemHeight = 20
        Me.ListBoxService.Items.AddRange(New Object() {"John 1:1 KJV", "Amazing grace", "@Love feast"})
        Me.ListBoxService.Location = New System.Drawing.Point(6, 8)
        Me.ListBoxService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxService.Name = "ListBoxService"
        Me.ListBoxService.Size = New System.Drawing.Size(379, 164)
        Me.ListBoxService.TabIndex = 1
        '
        'TabPageBackgrounds
        '
        Me.TabPageBackgrounds.AutoScroll = True
        Me.TabPageBackgrounds.Controls.Add(Me.ButtonNewImage)
        Me.TabPageBackgrounds.Controls.Add(Me.CheckBoxScaled)
        Me.TabPageBackgrounds.Controls.Add(Me.ButtonImportImage)
        Me.TabPageBackgrounds.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBackgrounds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageBackgrounds.Name = "TabPageBackgrounds"
        Me.TabPageBackgrounds.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageBackgrounds.Size = New System.Drawing.Size(481, 195)
        Me.TabPageBackgrounds.TabIndex = 1
        Me.TabPageBackgrounds.Text = "Backgrounds"
        Me.TabPageBackgrounds.UseVisualStyleBackColor = True
        '
        'ButtonNewImage
        '
        Me.ButtonNewImage.Location = New System.Drawing.Point(332, 112)
        Me.ButtonNewImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNewImage.Name = "ButtonNewImage"
        Me.ButtonNewImage.Size = New System.Drawing.Size(123, 31)
        Me.ButtonNewImage.TabIndex = 6
        Me.ButtonNewImage.Text = "Import Images ..."
        Me.ButtonNewImage.UseVisualStyleBackColor = True
        '
        'CheckBoxScaled
        '
        Me.CheckBoxScaled.AutoSize = True
        Me.CheckBoxScaled.Checked = True
        Me.CheckBoxScaled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxScaled.Location = New System.Drawing.Point(332, 83)
        Me.CheckBoxScaled.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxScaled.Name = "CheckBoxScaled"
        Me.CheckBoxScaled.Size = New System.Drawing.Size(121, 24)
        Me.CheckBoxScaled.TabIndex = 5
        Me.CheckBoxScaled.Text = "Stretch Image"
        Me.CheckBoxScaled.UseVisualStyleBackColor = True
        '
        'ButtonImportImage
        '
        Me.ButtonImportImage.Location = New System.Drawing.Point(332, 41)
        Me.ButtonImportImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonImportImage.Name = "ButtonImportImage"
        Me.ButtonImportImage.Size = New System.Drawing.Size(123, 31)
        Me.ButtonImportImage.TabIndex = 4
        Me.ButtonImportImage.Text = "Load Images ..."
        Me.ButtonImportImage.UseVisualStyleBackColor = True
        '
        'TabPageFormat
        '
        Me.TabPageFormat.Controls.Add(Me.comboboxdisplayOption)
        Me.TabPageFormat.Controls.Add(Me.Resolution)
        Me.TabPageFormat.Controls.Add(Me.GroupBox4)
        Me.TabPageFormat.Controls.Add(Me.GroupBox3)
        Me.TabPageFormat.Controls.Add(Me.ButtonApplyFormatSettings)
        Me.TabPageFormat.Controls.Add(Me.TextBoxFontFamily)
        Me.TabPageFormat.Controls.Add(Me.ButtonFont)
        Me.TabPageFormat.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFormat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageFormat.Name = "TabPageFormat"
        Me.TabPageFormat.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageFormat.Size = New System.Drawing.Size(481, 195)
        Me.TabPageFormat.TabIndex = 1
        Me.TabPageFormat.Text = "Format"
        Me.TabPageFormat.UseVisualStyleBackColor = True
        '
        'comboboxdisplayOption
        '
        Me.comboboxdisplayOption.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxdisplayOption.FormattingEnabled = True
        Me.comboboxdisplayOption.Items.AddRange(New Object() {"1. Same resolution; with PC bounds            ", "2. Same resolution;  with PC & projector (set by user)", "3. Different resolution; PC (set by user), projector bounds", "4. Different resolution;  PC (set by user), projector (set by user)", "5. Different; PC bounds, projector (set by user)"})
        Me.comboboxdisplayOption.Location = New System.Drawing.Point(19, 42)
        Me.comboboxdisplayOption.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboboxdisplayOption.Name = "comboboxdisplayOption"
        Me.comboboxdisplayOption.Size = New System.Drawing.Size(285, 26)
        Me.comboboxdisplayOption.TabIndex = 11
        Me.comboboxdisplayOption.Text = "4. Different resolution;  PC (set by user), projector (set by user)            "
        '
        'Resolution
        '
        Me.Resolution.Controls.Add(Me.Label17)
        Me.Resolution.Controls.Add(Me.Label15)
        Me.Resolution.Controls.Add(Me.Label18)
        Me.Resolution.Controls.Add(Me.TextBoxProjectorResolutionW)
        Me.Resolution.Controls.Add(Me.Label16)
        Me.Resolution.Controls.Add(Me.TextBoxProjectorResolutionH)
        Me.Resolution.Controls.Add(Me.Label5)
        Me.Resolution.Controls.Add(Me.TextBoxResolutionW)
        Me.Resolution.Controls.Add(Me.Label11)
        Me.Resolution.Controls.Add(Me.TextBoxResolutionH)
        Me.Resolution.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resolution.Location = New System.Drawing.Point(327, 53)
        Me.Resolution.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Resolution.Size = New System.Drawing.Size(144, 94)
        Me.Resolution.TabIndex = 10
        Me.Resolution.TabStop = False
        Me.Resolution.Text = "Resolution"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(28, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 18)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "PC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(83, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 18)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "W:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(110, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 18)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Scr"
        '
        'TextBoxProjectorResolutionW
        '
        Me.TextBoxProjectorResolutionW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProjectorResolutionW.Location = New System.Drawing.Point(86, 32)
        Me.TextBoxProjectorResolutionW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxProjectorResolutionW.Name = "TextBoxProjectorResolutionW"
        Me.TextBoxProjectorResolutionW.Size = New System.Drawing.Size(58, 25)
        Me.TextBoxProjectorResolutionW.TabIndex = 14
        Me.TextBoxProjectorResolutionW.Text = "1366"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(83, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 18)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "H:"
        '
        'TextBoxProjectorResolutionH
        '
        Me.TextBoxProjectorResolutionH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProjectorResolutionH.Location = New System.Drawing.Point(86, 68)
        Me.TextBoxProjectorResolutionH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxProjectorResolutionH.Name = "TextBoxProjectorResolutionH"
        Me.TextBoxProjectorResolutionH.Size = New System.Drawing.Size(58, 25)
        Me.TextBoxProjectorResolutionH.TabIndex = 12
        Me.TextBoxProjectorResolutionH.Text = "768"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "W: "
        '
        'TextBoxResolutionW
        '
        Me.TextBoxResolutionW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResolutionW.Location = New System.Drawing.Point(6, 32)
        Me.TextBoxResolutionW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxResolutionW.Name = "TextBoxResolutionW"
        Me.TextBoxResolutionW.Size = New System.Drawing.Size(43, 25)
        Me.TextBoxResolutionW.TabIndex = 10
        Me.TextBoxResolutionW.Text = "1366"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "H:"
        '
        'TextBoxResolutionH
        '
        Me.TextBoxResolutionH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxResolutionH.Location = New System.Drawing.Point(6, 68)
        Me.TextBoxResolutionH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxResolutionH.Name = "TextBoxResolutionH"
        Me.TextBoxResolutionH.Size = New System.Drawing.Size(43, 25)
        Me.TextBoxResolutionH.TabIndex = 8
        Me.TextBoxResolutionH.Text = "768"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButtonFull)
        Me.GroupBox4.Controls.Add(Me.RadioButtonLowerThird)
        Me.GroupBox4.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(327, 2)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(134, 50)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Position"
        '
        'RadioButtonFull
        '
        Me.RadioButtonFull.AutoSize = True
        Me.RadioButtonFull.Checked = True
        Me.RadioButtonFull.Location = New System.Drawing.Point(6, 31)
        Me.RadioButtonFull.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonFull.Name = "RadioButtonFull"
        Me.RadioButtonFull.Size = New System.Drawing.Size(49, 22)
        Me.RadioButtonFull.TabIndex = 1
        Me.RadioButtonFull.TabStop = True
        Me.RadioButtonFull.Text = "Full"
        Me.RadioButtonFull.UseVisualStyleBackColor = True
        '
        'RadioButtonLowerThird
        '
        Me.RadioButtonLowerThird.AutoSize = True
        Me.RadioButtonLowerThird.Location = New System.Drawing.Point(6, 13)
        Me.RadioButtonLowerThird.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonLowerThird.Name = "RadioButtonLowerThird"
        Me.RadioButtonLowerThird.Size = New System.Drawing.Size(102, 22)
        Me.RadioButtonLowerThird.TabIndex = 0
        Me.RadioButtonLowerThird.Text = "Lower Third"
        Me.RadioButtonLowerThird.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonDefault)
        Me.GroupBox3.Controls.Add(Me.LabelBackColor)
        Me.GroupBox3.Controls.Add(Me.LabelForeColor)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBoxMaxCharsPerLine)
        Me.GroupBox3.Controls.Add(Me.CheckBoxTransparent)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBoxFontSize)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBoxMaxLines)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 68)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(308, 107)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Format"
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Location = New System.Drawing.Point(219, 54)
        Me.ButtonDefault.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(78, 32)
        Me.ButtonDefault.TabIndex = 13
        Me.ButtonDefault.Text = "Default"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'LabelBackColor
        '
        Me.LabelBackColor.AutoSize = True
        Me.LabelBackColor.BackColor = System.Drawing.Color.Black
        Me.LabelBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelBackColor.Location = New System.Drawing.Point(160, 72)
        Me.LabelBackColor.Name = "LabelBackColor"
        Me.LabelBackColor.Size = New System.Drawing.Size(27, 15)
        Me.LabelBackColor.TabIndex = 12
        Me.LabelBackColor.Text = "      "
        '
        'LabelForeColor
        '
        Me.LabelForeColor.AutoSize = True
        Me.LabelForeColor.BackColor = System.Drawing.Color.Yellow
        Me.LabelForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelForeColor.Location = New System.Drawing.Point(160, 58)
        Me.LabelForeColor.Name = "LabelForeColor"
        Me.LabelForeColor.Size = New System.Drawing.Size(27, 15)
        Me.LabelForeColor.TabIndex = 11
        Me.LabelForeColor.Text = "      "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(99, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "BackColor:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(99, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "ForeColor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(99, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "No of Characers per line"
        '
        'TextBoxMaxCharsPerLine
        '
        Me.TextBoxMaxCharsPerLine.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxMaxCharsPerLine.Location = New System.Drawing.Point(102, 30)
        Me.TextBoxMaxCharsPerLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxMaxCharsPerLine.Name = "TextBoxMaxCharsPerLine"
        Me.TextBoxMaxCharsPerLine.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxMaxCharsPerLine.TabIndex = 4
        Me.TextBoxMaxCharsPerLine.Text = "40"
        '
        'CheckBoxTransparent
        '
        Me.CheckBoxTransparent.AutoSize = True
        Me.CheckBoxTransparent.Location = New System.Drawing.Point(219, 29)
        Me.CheckBoxTransparent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxTransparent.Name = "CheckBoxTransparent"
        Me.CheckBoxTransparent.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxTransparent.TabIndex = 8
        Me.CheckBoxTransparent.Text = "Transparent"
        Me.CheckBoxTransparent.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Font Size"
        '
        'TextBoxFontSize
        '
        Me.TextBoxFontSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFontSize.Location = New System.Drawing.Point(12, 29)
        Me.TextBoxFontSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxFontSize.Name = "TextBoxFontSize"
        Me.TextBoxFontSize.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxFontSize.TabIndex = 6
        Me.TextBoxFontSize.Text = "50"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Number of lines"
        '
        'TextBoxMaxLines
        '
        Me.TextBoxMaxLines.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMaxLines.Location = New System.Drawing.Point(12, 68)
        Me.TextBoxMaxLines.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxMaxLines.Name = "TextBoxMaxLines"
        Me.TextBoxMaxLines.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxMaxLines.TabIndex = 4
        Me.TextBoxMaxLines.Text = "4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(326, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonApplyFormatSettings
        '
        Me.ButtonApplyFormatSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonApplyFormatSettings.BackColor = System.Drawing.Color.LightGray
        Me.ButtonApplyFormatSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonApplyFormatSettings.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonApplyFormatSettings.ForeColor = System.Drawing.Color.Black
        Me.ButtonApplyFormatSettings.Location = New System.Drawing.Point(333, 150)
        Me.ButtonApplyFormatSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonApplyFormatSettings.Name = "ButtonApplyFormatSettings"
        Me.ButtonApplyFormatSettings.Size = New System.Drawing.Size(112, 28)
        Me.ButtonApplyFormatSettings.TabIndex = 6
        Me.ButtonApplyFormatSettings.Text = "Apply"
        Me.ButtonApplyFormatSettings.UseVisualStyleBackColor = False
        '
        'TextBoxFontFamily
        '
        Me.TextBoxFontFamily.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFontFamily.Location = New System.Drawing.Point(16, 10)
        Me.TextBoxFontFamily.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxFontFamily.Name = "TextBoxFontFamily"
        Me.TextBoxFontFamily.Size = New System.Drawing.Size(206, 25)
        Me.TextBoxFontFamily.TabIndex = 1
        Me.TextBoxFontFamily.Text = "Arial"
        '
        'ButtonFont
        '
        Me.ButtonFont.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFont.Location = New System.Drawing.Point(230, 8)
        Me.ButtonFont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonFont.Name = "ButtonFont"
        Me.ButtonFont.Size = New System.Drawing.Size(75, 31)
        Me.ButtonFont.TabIndex = 0
        Me.ButtonFont.Text = "Font ..."
        Me.ButtonFont.UseVisualStyleBackColor = True
        '
        'TabPageBibles
        '
        Me.TabPageBibles.Controls.Add(Me.LabelExpand)
        Me.TabPageBibles.Controls.Add(Me.CheckBoxLive)
        Me.TabPageBibles.Controls.Add(Me.ListBoxVerse)
        Me.TabPageBibles.Controls.Add(Me.ListBoxChapter)
        Me.TabPageBibles.Controls.Add(Me.ListBoxBook)
        Me.TabPageBibles.Controls.Add(Me.Button4)
        Me.TabPageBibles.Controls.Add(Me.ListBoxBibles)
        Me.TabPageBibles.Controls.Add(Me.ListBoxBibleVersions)
        Me.TabPageBibles.Controls.Add(Me.ListViewBible)
        Me.TabPageBibles.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBibles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageBibles.Name = "TabPageBibles"
        Me.TabPageBibles.Size = New System.Drawing.Size(481, 195)
        Me.TabPageBibles.TabIndex = 2
        Me.TabPageBibles.Text = "Bibles"
        Me.TabPageBibles.UseVisualStyleBackColor = True
        '
        'LabelExpand
        '
        Me.LabelExpand.AutoSize = True
        Me.LabelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelExpand.Location = New System.Drawing.Point(63, 156)
        Me.LabelExpand.Name = "LabelExpand"
        Me.LabelExpand.Size = New System.Drawing.Size(19, 22)
        Me.LabelExpand.TabIndex = 70
        Me.LabelExpand.Text = "^"
        '
        'CheckBoxLive
        '
        Me.CheckBoxLive.AutoSize = True
        Me.CheckBoxLive.Checked = True
        Me.CheckBoxLive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLive.Location = New System.Drawing.Point(8, 154)
        Me.CheckBoxLive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxLive.Name = "CheckBoxLive"
        Me.CheckBoxLive.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxLive.TabIndex = 69
        Me.CheckBoxLive.Text = "Live"
        Me.CheckBoxLive.UseVisualStyleBackColor = True
        '
        'ListBoxVerse
        '
        Me.ListBoxVerse.FormattingEnabled = True
        Me.ListBoxVerse.ItemHeight = 20
        Me.ListBoxVerse.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ListBoxVerse.Location = New System.Drawing.Point(431, 9)
        Me.ListBoxVerse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxVerse.Name = "ListBoxVerse"
        Me.ListBoxVerse.Size = New System.Drawing.Size(36, 164)
        Me.ListBoxVerse.TabIndex = 6
        '
        'ListBoxChapter
        '
        Me.ListBoxChapter.FormattingEnabled = True
        Me.ListBoxChapter.ItemHeight = 20
        Me.ListBoxChapter.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.ListBoxChapter.Location = New System.Drawing.Point(384, 9)
        Me.ListBoxChapter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxChapter.Name = "ListBoxChapter"
        Me.ListBoxChapter.Size = New System.Drawing.Size(44, 164)
        Me.ListBoxChapter.TabIndex = 5
        '
        'ListBoxBook
        '
        Me.ListBoxBook.FormattingEnabled = True
        Me.ListBoxBook.ItemHeight = 20
        Me.ListBoxBook.Items.AddRange(New Object() {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "Song of Songs", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"})
        Me.ListBoxBook.Location = New System.Drawing.Point(302, 9)
        Me.ListBoxBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxBook.Name = "ListBoxBook"
        Me.ListBoxBook.Size = New System.Drawing.Size(80, 164)
        Me.ListBoxBook.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(334, 11)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 22)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Select ..."
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'ListBoxBibles
        '
        Me.ListBoxBibles.FormattingEnabled = True
        Me.ListBoxBibles.ItemHeight = 20
        Me.ListBoxBibles.Items.AddRange(New Object() {"Gen 1:1 In the begining God ..."})
        Me.ListBoxBibles.Location = New System.Drawing.Point(87, 9)
        Me.ListBoxBibles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxBibles.Name = "ListBoxBibles"
        Me.ListBoxBibles.Size = New System.Drawing.Size(214, 164)
        Me.ListBoxBibles.TabIndex = 2
        '
        'ListBoxBibleVersions
        '
        Me.ListBoxBibleVersions.FormattingEnabled = True
        Me.ListBoxBibleVersions.ItemHeight = 20
        Me.ListBoxBibleVersions.Items.AddRange(New Object() {"KJV", "ASV", "RSV"})
        Me.ListBoxBibleVersions.Location = New System.Drawing.Point(6, 11)
        Me.ListBoxBibleVersions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxBibleVersions.Name = "ListBoxBibleVersions"
        Me.ListBoxBibleVersions.Size = New System.Drawing.Size(75, 144)
        Me.ListBoxBibleVersions.TabIndex = 1
        '
        'ListViewBible
        '
        Me.ListViewBible.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderRef, Me.ColumnHeaderPassage})
        Me.ListViewBible.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.ListViewBible.Location = New System.Drawing.Point(87, 128)
        Me.ListViewBible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListViewBible.Name = "ListViewBible"
        Me.ListViewBible.Size = New System.Drawing.Size(214, 38)
        Me.ListViewBible.TabIndex = 68
        Me.ListViewBible.UseCompatibleStateImageBehavior = False
        Me.ListViewBible.View = System.Windows.Forms.View.Details
        Me.ListViewBible.Visible = False
        '
        'ColumnHeaderRef
        '
        Me.ColumnHeaderRef.Text = "Ref"
        Me.ColumnHeaderRef.Width = 107
        '
        'ColumnHeaderPassage
        '
        Me.ColumnHeaderPassage.Text = "Passage"
        Me.ColumnHeaderPassage.Width = 300
        '
        'TabPageSongs
        '
        Me.TabPageSongs.Controls.Add(Me.ListBoxSongs)
        Me.TabPageSongs.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSongs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSongs.Name = "TabPageSongs"
        Me.TabPageSongs.Size = New System.Drawing.Size(481, 195)
        Me.TabPageSongs.TabIndex = 3
        Me.TabPageSongs.Text = "Songs"
        Me.TabPageSongs.UseVisualStyleBackColor = True
        '
        'ListBoxSongs
        '
        Me.ListBoxSongs.FormattingEnabled = True
        Me.ListBoxSongs.ItemHeight = 20
        Me.ListBoxSongs.Items.AddRange(New Object() {"Once Again - Hillsong", "Mi Corason - Don Moen", "Lion and the Lamb - Chingtok Ishaku"})
        Me.ListBoxSongs.Location = New System.Drawing.Point(18, -2)
        Me.ListBoxSongs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxSongs.Name = "ListBoxSongs"
        Me.ListBoxSongs.Size = New System.Drawing.Size(432, 204)
        Me.ListBoxSongs.TabIndex = 1
        '
        'TabPageSearch
        '
        Me.TabPageSearch.Controls.Add(Me.LabelExpandSearch)
        Me.TabPageSearch.Controls.Add(Me.ListBoxSearchBible)
        Me.TabPageSearch.Controls.Add(Me.ListBoxSearchSongsDB)
        Me.TabPageSearch.Controls.Add(Me.ButtonSearchSongFiles)
        Me.TabPageSearch.Controls.Add(Me.ButtonDBSongs)
        Me.TabPageSearch.Controls.Add(Me.ListBoxSearch)
        Me.TabPageSearch.Controls.Add(Me.TextBoxSearch)
        Me.TabPageSearch.Controls.Add(Me.ButtonSearchBible)
        Me.TabPageSearch.Controls.Add(Me.RichTextBoxSearch)
        Me.TabPageSearch.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSearch.Name = "TabPageSearch"
        Me.TabPageSearch.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSearch.Size = New System.Drawing.Size(481, 195)
        Me.TabPageSearch.TabIndex = 4
        Me.TabPageSearch.Text = "Search"
        Me.TabPageSearch.UseVisualStyleBackColor = True
        '
        'LabelExpandSearch
        '
        Me.LabelExpandSearch.AutoSize = True
        Me.LabelExpandSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelExpandSearch.Location = New System.Drawing.Point(118, 164)
        Me.LabelExpandSearch.Name = "LabelExpandSearch"
        Me.LabelExpandSearch.Size = New System.Drawing.Size(19, 22)
        Me.LabelExpandSearch.TabIndex = 71
        Me.LabelExpandSearch.Text = "^"
        '
        'ListBoxSearchBible
        '
        Me.ListBoxSearchBible.FormattingEnabled = True
        Me.ListBoxSearchBible.ItemHeight = 20
        Me.ListBoxSearchBible.Items.AddRange(New Object() {"songs"})
        Me.ListBoxSearchBible.Location = New System.Drawing.Point(145, 8)
        Me.ListBoxSearchBible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxSearchBible.Name = "ListBoxSearchBible"
        Me.ListBoxSearchBible.Size = New System.Drawing.Size(310, 184)
        Me.ListBoxSearchBible.TabIndex = 12
        '
        'ListBoxSearchSongsDB
        '
        Me.ListBoxSearchSongsDB.FormattingEnabled = True
        Me.ListBoxSearchSongsDB.ItemHeight = 20
        Me.ListBoxSearchSongsDB.Items.AddRange(New Object() {"songs"})
        Me.ListBoxSearchSongsDB.Location = New System.Drawing.Point(144, 8)
        Me.ListBoxSearchSongsDB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxSearchSongsDB.Name = "ListBoxSearchSongsDB"
        Me.ListBoxSearchSongsDB.Size = New System.Drawing.Size(310, 184)
        Me.ListBoxSearchSongsDB.TabIndex = 10
        '
        'ButtonSearchSongFiles
        '
        Me.ButtonSearchSongFiles.Location = New System.Drawing.Point(8, 132)
        Me.ButtonSearchSongFiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSearchSongFiles.Name = "ButtonSearchSongFiles"
        Me.ButtonSearchSongFiles.Size = New System.Drawing.Size(130, 41)
        Me.ButtonSearchSongFiles.TabIndex = 9
        Me.ButtonSearchSongFiles.Text = "Search Files"
        Me.ButtonSearchSongFiles.UseVisualStyleBackColor = True
        '
        'ButtonDBSongs
        '
        Me.ButtonDBSongs.Location = New System.Drawing.Point(8, 87)
        Me.ButtonDBSongs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDBSongs.Name = "ButtonDBSongs"
        Me.ButtonDBSongs.Size = New System.Drawing.Size(130, 41)
        Me.ButtonDBSongs.TabIndex = 8
        Me.ButtonDBSongs.Text = "Search Database"
        Me.ButtonDBSongs.UseVisualStyleBackColor = True
        '
        'ListBoxSearch
        '
        Me.ListBoxSearch.FormattingEnabled = True
        Me.ListBoxSearch.ItemHeight = 20
        Me.ListBoxSearch.Items.AddRange(New Object() {"songs"})
        Me.ListBoxSearch.Location = New System.Drawing.Point(144, 8)
        Me.ListBoxSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxSearch.Name = "ListBoxSearch"
        Me.ListBoxSearch.Size = New System.Drawing.Size(310, 184)
        Me.ListBoxSearch.TabIndex = 7
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(8, 8)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(130, 28)
        Me.TextBoxSearch.TabIndex = 1
        '
        'ButtonSearchBible
        '
        Me.ButtonSearchBible.Location = New System.Drawing.Point(8, 40)
        Me.ButtonSearchBible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSearchBible.Name = "ButtonSearchBible"
        Me.ButtonSearchBible.Size = New System.Drawing.Size(130, 41)
        Me.ButtonSearchBible.TabIndex = 6
        Me.ButtonSearchBible.Text = "Search Bible"
        Me.ButtonSearchBible.UseVisualStyleBackColor = True
        '
        'RichTextBoxSearch
        '
        Me.RichTextBoxSearch.Location = New System.Drawing.Point(145, 8)
        Me.RichTextBoxSearch.Name = "RichTextBoxSearch"
        Me.RichTextBoxSearch.Size = New System.Drawing.Size(321, 666)
        Me.RichTextBoxSearch.TabIndex = 11
        Me.RichTextBoxSearch.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageLayouts)
        Me.TabControl1.Controls.Add(Me.TabPageSettings)
        Me.TabControl1.Controls.Add(Me.TabPageMulti)
        Me.TabControl1.Location = New System.Drawing.Point(4, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(489, 244)
        Me.TabControl1.TabIndex = 14
        '
        'TabPageLayouts
        '
        Me.TabPageLayouts.Controls.Add(Me.ButtonDeleteLayout)
        Me.TabPageLayouts.Controls.Add(Me.ButtonLoadLayout)
        Me.TabPageLayouts.Controls.Add(Me.ButtonSaveLayout)
        Me.TabPageLayouts.Controls.Add(Me.FlowLayoutPanelLayouts)
        Me.TabPageLayouts.Location = New System.Drawing.Point(4, 29)
        Me.TabPageLayouts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageLayouts.Name = "TabPageLayouts"
        Me.TabPageLayouts.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageLayouts.Size = New System.Drawing.Size(481, 211)
        Me.TabPageLayouts.TabIndex = 0
        Me.TabPageLayouts.Text = "Layouts"
        Me.TabPageLayouts.UseVisualStyleBackColor = True
        '
        'ButtonDeleteLayout
        '
        Me.ButtonDeleteLayout.Location = New System.Drawing.Point(384, 162)
        Me.ButtonDeleteLayout.Name = "ButtonDeleteLayout"
        Me.ButtonDeleteLayout.Size = New System.Drawing.Size(87, 39)
        Me.ButtonDeleteLayout.TabIndex = 4
        Me.ButtonDeleteLayout.Text = "Delete"
        Me.ButtonDeleteLayout.UseVisualStyleBackColor = True
        '
        'ButtonLoadLayout
        '
        Me.ButtonLoadLayout.Location = New System.Drawing.Point(384, 104)
        Me.ButtonLoadLayout.Name = "ButtonLoadLayout"
        Me.ButtonLoadLayout.Size = New System.Drawing.Size(87, 39)
        Me.ButtonLoadLayout.TabIndex = 3
        Me.ButtonLoadLayout.Text = "Load"
        Me.ButtonLoadLayout.UseVisualStyleBackColor = True
        '
        'ButtonSaveLayout
        '
        Me.ButtonSaveLayout.Location = New System.Drawing.Point(384, 49)
        Me.ButtonSaveLayout.Name = "ButtonSaveLayout"
        Me.ButtonSaveLayout.Size = New System.Drawing.Size(87, 39)
        Me.ButtonSaveLayout.TabIndex = 2
        Me.ButtonSaveLayout.Text = "Save"
        Me.ButtonSaveLayout.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelLayouts
        '
        Me.FlowLayoutPanelLayouts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanelLayouts.Location = New System.Drawing.Point(11, 49)
        Me.FlowLayoutPanelLayouts.Name = "FlowLayoutPanelLayouts"
        Me.FlowLayoutPanelLayouts.Size = New System.Drawing.Size(365, 153)
        Me.FlowLayoutPanelLayouts.TabIndex = 1
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.GroupBox1)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Size = New System.Drawing.Size(481, 218)
        Me.TabPageSettings.TabIndex = 3
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxMultiuser)
        Me.GroupBox1.Controls.Add(Me.cmbAddress)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.PicClient)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 44)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(308, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network"
        '
        'CheckBoxMultiuser
        '
        Me.CheckBoxMultiuser.AutoSize = True
        Me.CheckBoxMultiuser.Checked = True
        Me.CheckBoxMultiuser.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMultiuser.Location = New System.Drawing.Point(6, 84)
        Me.CheckBoxMultiuser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxMultiuser.Name = "CheckBoxMultiuser"
        Me.CheckBoxMultiuser.Size = New System.Drawing.Size(136, 17)
        Me.CheckBoxMultiuser.TabIndex = 8
        Me.CheckBoxMultiuser.Text = "Turn ON/OFF multiuser"
        Me.CheckBoxMultiuser.UseVisualStyleBackColor = True
        '
        'cmbAddress
        '
        Me.cmbAddress.FormattingEnabled = True
        Me.cmbAddress.Location = New System.Drawing.Point(6, 13)
        Me.cmbAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.btnConnect.Location = New System.Drawing.Point(96, 13)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(74, 58)
        Me.btnConnect.TabIndex = 6
        Me.btnConnect.Text = "Connect..."
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Display Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(6, 53)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(72, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "Navigator"
        '
        'PicClient
        '
        Me.PicClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicClient.ErrorImage = CType(resources.GetObject("PicClient.ErrorImage"), System.Drawing.Image)
        Me.PicClient.Location = New System.Drawing.Point(326, 10)
        Me.PicClient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicClient.Name = "PicClient"
        Me.PicClient.Size = New System.Drawing.Size(10, 23)
        Me.PicClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicClient.TabIndex = 0
        Me.PicClient.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.ButtonAddIP)
        Me.Panel4.Controls.Add(Me.txtIP)
        Me.Panel4.Location = New System.Drawing.Point(174, 13)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 48)
        Me.Panel4.TabIndex = 1
        '
        'ButtonAddIP
        '
        Me.ButtonAddIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonAddIP.Location = New System.Drawing.Point(14, 28)
        Me.ButtonAddIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAddIP.Name = "ButtonAddIP"
        Me.ButtonAddIP.Size = New System.Drawing.Size(72, 18)
        Me.ButtonAddIP.TabIndex = 7
        Me.ButtonAddIP.Text = "Add IP"
        Me.ButtonAddIP.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIP.Location = New System.Drawing.Point(14, 3)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(111, 20)
        Me.txtIP.TabIndex = 4
        '
        'TabPageMulti
        '
        Me.TabPageMulti.Controls.Add(Me.GroupBox2)
        Me.TabPageMulti.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMulti.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageMulti.Name = "TabPageMulti"
        Me.TabPageMulti.Size = New System.Drawing.Size(481, 218)
        Me.TabPageMulti.TabIndex = 4
        Me.TabPageMulti.Text = "Multi User"
        Me.TabPageMulti.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.ButtonTest)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnSend)
        Me.GroupBox2.Controls.Add(Me.txtmessage)
        Me.GroupBox2.Controls.Add(Me.pnlStatus)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.ButtonClear)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(90, 44)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(292, 198)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History"
        '
        'ButtonTest
        '
        Me.ButtonTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTest.BackColor = System.Drawing.Color.LightGray
        Me.ButtonTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTest.ForeColor = System.Drawing.Color.Black
        Me.ButtonTest.Location = New System.Drawing.Point(231, 152)
        Me.ButtonTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(55, 21)
        Me.ButtonTest.TabIndex = 13
        Me.ButtonTest.Text = "Test"
        Me.ButtonTest.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(231, 170)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 22)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.Color.LightGray
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Enabled = False
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Location = New System.Drawing.Point(163, 154)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(62, 37)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtmessage
        '
        Me.txtmessage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmessage.Location = New System.Drawing.Point(0, 154)
        Me.txtmessage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(163, 36)
        Me.txtmessage.TabIndex = 10
        '
        'pnlStatus
        '
        Me.pnlStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lnkOnline)
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Controls.Add(Me.btnClose)
        Me.pnlStatus.Location = New System.Drawing.Point(4, 36)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(283, 36)
        Me.pnlStatus.TabIndex = 7
        Me.pnlStatus.Visible = False
        '
        'lnkOnline
        '
        Me.lnkOnline.AutoSize = True
        Me.lnkOnline.Location = New System.Drawing.Point(3, 18)
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
        Me.lblStatus.Size = New System.Drawing.Size(222, 17)
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
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(42, 21)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Location = New System.Drawing.Point(-1, 36)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(301, 116)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = ""
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonClear.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClear.Location = New System.Drawing.Point(187, 13)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(89, 18)
        Me.ButtonClear.TabIndex = 0
        Me.ButtonClear.Text = "Clear All"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 66)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.MaxLength = 88888
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'LabelDriver
        '
        Me.LabelDriver.AutoSize = True
        Me.LabelDriver.Location = New System.Drawing.Point(236, 1)
        Me.LabelDriver.Name = "LabelDriver"
        Me.LabelDriver.Size = New System.Drawing.Size(56, 20)
        Me.LabelDriver.TabIndex = 10
        Me.LabelDriver.Text = "Driver:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Main:"
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxStatus.Location = New System.Drawing.Point(10, 237)
        Me.TextBoxStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxStatus.Multiline = True
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.Size = New System.Drawing.Size(324, 62)
        Me.TextBoxStatus.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Location = New System.Drawing.Point(796, 11)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBoxLive)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBoxStatus)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.PictureBoxPreview)
        Me.SplitContainer2.Size = New System.Drawing.Size(316, 527)
        Me.SplitContainer2.SplitterDistance = 217
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 7
        '
        'PictureBoxLive
        '
        Me.PictureBoxLive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxLive.Location = New System.Drawing.Point(4, 20)
        Me.PictureBoxLive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxLive.Name = "PictureBoxLive"
        Me.PictureBoxLive.Size = New System.Drawing.Size(304, 188)
        Me.PictureBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLive.TabIndex = 2
        Me.PictureBoxLive.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ButtonBlank)
        Me.Panel2.Controls.Add(Me.ButtonI)
        Me.Panel2.Controls.Add(Me.ButtonLive)
        Me.Panel2.Controls.Add(Me.ButtonSendToDriver)
        Me.Panel2.Location = New System.Drawing.Point(9, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 48)
        Me.Panel2.TabIndex = 4
        '
        'ButtonBlank
        '
        Me.ButtonBlank.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBlank.Location = New System.Drawing.Point(237, 7)
        Me.ButtonBlank.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonBlank.Name = "ButtonBlank"
        Me.ButtonBlank.Size = New System.Drawing.Size(22, 37)
        Me.ButtonBlank.TabIndex = 8
        Me.ButtonBlank.UseVisualStyleBackColor = True
        '
        'ButtonI
        '
        Me.ButtonI.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonI.Location = New System.Drawing.Point(271, 7)
        Me.ButtonI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonI.Name = "ButtonI"
        Me.ButtonI.Size = New System.Drawing.Size(22, 37)
        Me.ButtonI.TabIndex = 7
        Me.ButtonI.Text = "i"
        Me.ButtonI.UseVisualStyleBackColor = True
        '
        'ButtonLive
        '
        Me.ButtonLive.Location = New System.Drawing.Point(4, 6)
        Me.ButtonLive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLive.Name = "ButtonLive"
        Me.ButtonLive.Size = New System.Drawing.Size(232, 37)
        Me.ButtonLive.TabIndex = 6
        Me.ButtonLive.Text = "Go Live"
        Me.ButtonLive.UseVisualStyleBackColor = True
        '
        'ButtonSendToDriver
        '
        Me.ButtonSendToDriver.Location = New System.Drawing.Point(4, 6)
        Me.ButtonSendToDriver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSendToDriver.Name = "ButtonSendToDriver"
        Me.ButtonSendToDriver.Size = New System.Drawing.Size(232, 37)
        Me.ButtonSendToDriver.TabIndex = 9
        Me.ButtonSendToDriver.Text = "Send to Driver"
        Me.ButtonSendToDriver.UseVisualStyleBackColor = True
        '
        'PictureBoxPreview
        '
        Me.PictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxPreview.Location = New System.Drawing.Point(10, 58)
        Me.PictureBoxPreview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxPreview.Name = "PictureBoxPreview"
        Me.PictureBoxPreview.Size = New System.Drawing.Size(299, 174)
        Me.PictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPreview.TabIndex = 3
        Me.PictureBoxPreview.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
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
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 667)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.Text = "Heritage Media Slide+ (Demo)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainerDriverTab.Panel1.ResumeLayout(False)
        Me.SplitContainerDriverTab.Panel1.PerformLayout()
        Me.SplitContainerDriverTab.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerDriverTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerDriverTab.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPageService.ResumeLayout(False)
        Me.TabPageBackgrounds.ResumeLayout(False)
        Me.TabPageBackgrounds.PerformLayout()
        Me.TabPageFormat.ResumeLayout(False)
        Me.TabPageFormat.PerformLayout()
        Me.Resolution.ResumeLayout(False)
        Me.Resolution.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBibles.ResumeLayout(False)
        Me.TabPageBibles.PerformLayout()
        Me.TabPageSongs.ResumeLayout(False)
        Me.TabPageSearch.ResumeLayout(False)
        Me.TabPageSearch.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageLayouts.ResumeLayout(False)
        Me.TabPageSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPageMulti.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBoxLive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBoxPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsEditing.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxMain As System.Windows.Forms.ListBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBoxLive As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonLive As System.Windows.Forms.Button
    Friend WithEvents PictureBoxPreview As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearchBible As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents ButtonUseNavigaor As System.Windows.Forms.Button
    Friend WithEvents ButtonUse As System.Windows.Forms.Button
    Friend WithEvents ListBoxDriver As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonI As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents clrFont As System.Windows.Forms.ColorDialog
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageService As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxService As System.Windows.Forms.ListBox
    Friend WithEvents TabPageFormat As System.Windows.Forms.TabPage
    Friend WithEvents TextBoxFontFamily As System.Windows.Forms.TextBox
    Friend WithEvents ButtonFont As System.Windows.Forms.Button
    Friend WithEvents TabPageBibles As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxBibles As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxBibleVersions As System.Windows.Forms.ListBox
    Friend WithEvents TabPageSongs As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxSongs As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageLayouts As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBackgrounds As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbAddress As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents PicClient As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAddIP As System.Windows.Forms.Button
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents TabPageMulti As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonTest As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtmessage As System.Windows.Forms.TextBox
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lnkOnline As System.Windows.Forms.LinkLabel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmsEditing As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsmCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsmCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFontSize As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaxLines As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaxCharsPerLine As System.Windows.Forms.TextBox
    Friend WithEvents ButtonApplyFormatSettings As System.Windows.Forms.Button
    Friend WithEvents TabPageSearch As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxSearch As System.Windows.Forms.ListBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ListBoxNavigaor As System.Windows.Forms.ListBox
    Friend WithEvents LabelDriver As System.Windows.Forms.Label
    Friend WithEvents ListBoxVerse As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxChapter As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxBook As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SplitContainerDriverTab As System.Windows.Forms.SplitContainer
    Friend WithEvents LabelNavigator As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonFull As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLowerThird As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonImportImage As System.Windows.Forms.Button
    Friend WithEvents CheckBoxMultiuser As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxScaled As System.Windows.Forms.CheckBox
    Friend WithEvents ListViewBible As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeaderRef As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderPassage As System.Windows.Forms.ColumnHeader
    Friend WithEvents Resolution As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxResolutionW As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxResolutionH As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents LabelBackColor As System.Windows.Forms.Label
    Friend WithEvents LabelForeColor As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ButtonDefault As System.Windows.Forms.Button
    Friend WithEvents comboboxdisplayOption As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProjectorResolutionW As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProjectorResolutionH As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSearchSongFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonDBSongs As System.Windows.Forms.Button
    Friend WithEvents ListBoxSearchSongsDB As System.Windows.Forms.ListBox
    Friend WithEvents ButtonNewImage As System.Windows.Forms.Button
    Friend WithEvents ButtonBlank As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxLive As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonSendToDriver As System.Windows.Forms.Button
    Friend WithEvents LabelExpand As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxSearch As System.Windows.Forms.RichTextBox
    Friend WithEvents FlowLayoutPanelLayouts As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ButtonDeleteLayout As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadLayout As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveLayout As System.Windows.Forms.Button
    Friend WithEvents ListBoxSearchBible As System.Windows.Forms.ListBox
    Friend WithEvents LabelExpandSearch As System.Windows.Forms.Label

End Class
