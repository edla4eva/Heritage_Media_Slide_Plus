<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditor
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
        Me.ButtonLoadFile = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonSaveAs = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.ButtonSaveDB = New System.Windows.Forms.Button()
        Me.RadioButtonDB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFile = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxAuthour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.ButtonShowDB = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLoadFile
        '
        Me.ButtonLoadFile.Location = New System.Drawing.Point(12, 12)
        Me.ButtonLoadFile.Name = "ButtonLoadFile"
        Me.ButtonLoadFile.Size = New System.Drawing.Size(107, 24)
        Me.ButtonLoadFile.TabIndex = 0
        Me.ButtonLoadFile.Text = "Load File"
        Me.ButtonLoadFile.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(125, 12)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(107, 24)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save File (Update)"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonSaveAs
        '
        Me.ButtonSaveAs.Location = New System.Drawing.Point(238, 12)
        Me.ButtonSaveAs.Name = "ButtonSaveAs"
        Me.ButtonSaveAs.Size = New System.Drawing.Size(107, 24)
        Me.ButtonSaveAs.TabIndex = 2
        Me.ButtonSaveAs.Text = "Save File As..."
        Me.ButtonSaveAs.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 42)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(333, 328)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.ButtonSaveDB)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDB)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxAuthour)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxTitle)
        Me.GroupBox1.Controls.Add(Me.ButtonShowDB)
        Me.GroupBox1.Location = New System.Drawing.Point(365, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 273)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Info"
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(202, 233)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(52, 23)
        Me.ButtonSearch.TabIndex = 8
        Me.ButtonSearch.Text = "Find"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'ButtonSaveDB
        '
        Me.ButtonSaveDB.Enabled = False
        Me.ButtonSaveDB.Location = New System.Drawing.Point(8, 191)
        Me.ButtonSaveDB.Name = "ButtonSaveDB"
        Me.ButtonSaveDB.Size = New System.Drawing.Size(107, 23)
        Me.ButtonSaveDB.TabIndex = 7
        Me.ButtonSaveDB.Text = "Save"
        Me.ButtonSaveDB.UseVisualStyleBackColor = True
        '
        'RadioButtonDB
        '
        Me.RadioButtonDB.AutoSize = True
        Me.RadioButtonDB.Location = New System.Drawing.Point(10, 152)
        Me.RadioButtonDB.Name = "RadioButtonDB"
        Me.RadioButtonDB.Size = New System.Drawing.Size(118, 17)
        Me.RadioButtonDB.TabIndex = 6
        Me.RadioButtonDB.Text = "Insert into database"
        Me.RadioButtonDB.UseVisualStyleBackColor = True
        '
        'RadioButtonFile
        '
        Me.RadioButtonFile.AutoSize = True
        Me.RadioButtonFile.Checked = True
        Me.RadioButtonFile.Location = New System.Drawing.Point(10, 125)
        Me.RadioButtonFile.Name = "RadioButtonFile"
        Me.RadioButtonFile.Size = New System.Drawing.Size(105, 17)
        Me.RadioButtonFile.TabIndex = 5
        Me.RadioButtonFile.TabStop = True
        Me.RadioButtonFile.Text = "Save as plain file"
        Me.RadioButtonFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Authour"
        '
        'TextBoxAuthour
        '
        Me.TextBoxAuthour.Location = New System.Drawing.Point(8, 98)
        Me.TextBoxAuthour.Name = "TextBoxAuthour"
        Me.TextBoxAuthour.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxAuthour.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(6, 46)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxTitle.TabIndex = 1
        '
        'ButtonShowDB
        '
        Me.ButtonShowDB.Location = New System.Drawing.Point(6, 233)
        Me.ButtonShowDB.Name = "ButtonShowDB"
        Me.ButtonShowDB.Size = New System.Drawing.Size(107, 23)
        Me.ButtonShowDB.TabIndex = 0
        Me.ButtonShowDB.Text = "Show Database>>"
        Me.ButtonShowDB.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(666, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(378, 327)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.Visible = False
        '
        'FormEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 383)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ButtonSaveAs)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonLoadFile)
        Me.Name = "FormEditor"
        Me.Text = "Text Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonLoadFile As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonSaveAs As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonDB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonFile As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAuthour As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents ButtonShowDB As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSaveDB As System.Windows.Forms.Button
    Friend WithEvents ButtonSearch As System.Windows.Forms.Button

End Class
