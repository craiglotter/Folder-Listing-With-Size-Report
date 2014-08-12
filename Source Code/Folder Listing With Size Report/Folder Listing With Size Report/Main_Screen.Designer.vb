<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.InputFolder_Textbox = New System.Windows.Forms.TextBox
        Me.Description_Label = New System.Windows.Forms.Label
        Me.Browse_Button = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.FullErrors_Checkbox = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Status_Textbox = New System.Windows.Forms.TextBox
        Me.SizeUnit1 = New System.Windows.Forms.RadioButton
        Me.SizeUnit2 = New System.Windows.Forms.RadioButton
        Me.SizeUnit3 = New System.Windows.Forms.RadioButton
        Me.SizeUnit4 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.bytes_label = New System.Windows.Forms.Label
        Me.cancelAsyncButton = New System.Windows.Forms.Button
        Me.startAsyncButton = New System.Windows.Forms.Button
        Me.Recursive_Checkbox = New System.Windows.Forms.CheckBox
        Me.currentfilename_label = New System.Windows.Forms.Label
        Me.filecount_label = New System.Windows.Forms.Label
        Me.foldercount_label = New System.Windows.Forms.Label
        Me.datelaunched_label = New System.Windows.Forms.Label
        Me.savefilename_label = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.currentfoldername_label = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.FullPath_CheckBox = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputFolder_Textbox
        '
        Me.InputFolder_Textbox.AllowDrop = True
        Me.InputFolder_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputFolder_Textbox.Location = New System.Drawing.Point(82, 22)
        Me.InputFolder_Textbox.Name = "InputFolder_Textbox"
        Me.InputFolder_Textbox.ReadOnly = True
        Me.InputFolder_Textbox.Size = New System.Drawing.Size(411, 20)
        Me.InputFolder_Textbox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.InputFolder_Textbox, "Input folder")
        '
        'Description_Label
        '
        Me.Description_Label.AutoSize = True
        Me.Description_Label.Location = New System.Drawing.Point(12, 9)
        Me.Description_Label.Name = "Description_Label"
        Me.Description_Label.Size = New System.Drawing.Size(474, 26)
        Me.Description_Label.TabIndex = 2
        Me.Description_Label.Text = "To generate the folder listing simply select an input folder below, select the ba" & _
            "se size unit and other " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "optional switches, and hit the Start button to continue" & _
            "."
        '
        'Browse_Button
        '
        Me.Browse_Button.Location = New System.Drawing.Point(499, 19)
        Me.Browse_Button.Name = "Browse_Button"
        Me.Browse_Button.Size = New System.Drawing.Size(75, 23)
        Me.Browse_Button.TabIndex = 3
        Me.Browse_Button.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.Browse_Button, "Browse for input folder")
        Me.Browse_Button.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select your Input Folder"
        '
        'FullErrors_Checkbox
        '
        Me.FullErrors_Checkbox.AutoSize = True
        Me.FullErrors_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullErrors_Checkbox.Location = New System.Drawing.Point(605, 409)
        Me.FullErrors_Checkbox.Name = "FullErrors_Checkbox"
        Me.FullErrors_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.FullErrors_Checkbox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.FullErrors_Checkbox, "If checked then full error messages will be displayed")
        Me.FullErrors_Checkbox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(535, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "20060314.1"
        Me.ToolTip1.SetToolTip(Me.Label1, "Application Build Number")
        '
        'Status_Textbox
        '
        Me.Status_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Status_Textbox.Location = New System.Drawing.Point(11, 409)
        Me.Status_Textbox.Name = "Status_Textbox"
        Me.Status_Textbox.ReadOnly = True
        Me.Status_Textbox.Size = New System.Drawing.Size(518, 10)
        Me.Status_Textbox.TabIndex = 6
        '
        'SizeUnit1
        '
        Me.SizeUnit1.AutoSize = True
        Me.SizeUnit1.Location = New System.Drawing.Point(80, 59)
        Me.SizeUnit1.Name = "SizeUnit1"
        Me.SizeUnit1.Size = New System.Drawing.Size(50, 17)
        Me.SizeUnit1.TabIndex = 7
        Me.SizeUnit1.Text = "bytes"
        Me.SizeUnit1.UseVisualStyleBackColor = True
        '
        'SizeUnit2
        '
        Me.SizeUnit2.AutoSize = True
        Me.SizeUnit2.Location = New System.Drawing.Point(133, 59)
        Me.SizeUnit2.Name = "SizeUnit2"
        Me.SizeUnit2.Size = New System.Drawing.Size(38, 17)
        Me.SizeUnit2.TabIndex = 8
        Me.SizeUnit2.Text = "Kb"
        Me.SizeUnit2.UseVisualStyleBackColor = True
        '
        'SizeUnit3
        '
        Me.SizeUnit3.AutoSize = True
        Me.SizeUnit3.Location = New System.Drawing.Point(180, 59)
        Me.SizeUnit3.Name = "SizeUnit3"
        Me.SizeUnit3.Size = New System.Drawing.Size(40, 17)
        Me.SizeUnit3.TabIndex = 9
        Me.SizeUnit3.Text = "Mb"
        Me.SizeUnit3.UseVisualStyleBackColor = True
        '
        'SizeUnit4
        '
        Me.SizeUnit4.AutoSize = True
        Me.SizeUnit4.Location = New System.Drawing.Point(226, 59)
        Me.SizeUnit4.Name = "SizeUnit4"
        Me.SizeUnit4.Size = New System.Drawing.Size(39, 17)
        Me.SizeUnit4.TabIndex = 10
        Me.SizeUnit4.Text = "Gb"
        Me.SizeUnit4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Input Folder:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Size unit:"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 348)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(256, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'bytes_label
        '
        Me.bytes_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bytes_label.Location = New System.Drawing.Point(135, 137)
        Me.bytes_label.Name = "bytes_label"
        Me.bytes_label.Size = New System.Drawing.Size(441, 23)
        Me.bytes_label.TabIndex = 17
        Me.bytes_label.Text = "(no result)"
        Me.bytes_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.Location = New System.Drawing.Point(153, 377)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(119, 23)
        Me.cancelAsyncButton.TabIndex = 16
        Me.cancelAsyncButton.Text = "Cancel"
        '
        'startAsyncButton
        '
        Me.startAsyncButton.Location = New System.Drawing.Point(16, 377)
        Me.startAsyncButton.Name = "startAsyncButton"
        Me.startAsyncButton.Size = New System.Drawing.Size(120, 23)
        Me.startAsyncButton.TabIndex = 15
        Me.startAsyncButton.Text = "Start"
        '
        'Recursive_Checkbox
        '
        Me.Recursive_Checkbox.AutoSize = True
        Me.Recursive_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recursive_Checkbox.Location = New System.Drawing.Point(442, 59)
        Me.Recursive_Checkbox.Name = "Recursive_Checkbox"
        Me.Recursive_Checkbox.Size = New System.Drawing.Size(105, 17)
        Me.Recursive_Checkbox.TabIndex = 19
        Me.Recursive_Checkbox.Text = "Recursive Listing"
        Me.Recursive_Checkbox.UseVisualStyleBackColor = True
        '
        'currentfilename_label
        '
        Me.currentfilename_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.currentfilename_label.Location = New System.Drawing.Point(135, 114)
        Me.currentfilename_label.Name = "currentfilename_label"
        Me.currentfilename_label.Size = New System.Drawing.Size(441, 23)
        Me.currentfilename_label.TabIndex = 20
        Me.currentfilename_label.Text = "(no result)"
        Me.currentfilename_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'filecount_label
        '
        Me.filecount_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.filecount_label.Location = New System.Drawing.Point(134, 91)
        Me.filecount_label.Name = "filecount_label"
        Me.filecount_label.Size = New System.Drawing.Size(441, 23)
        Me.filecount_label.TabIndex = 21
        Me.filecount_label.Text = "(no result)"
        Me.filecount_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'foldercount_label
        '
        Me.foldercount_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.foldercount_label.Location = New System.Drawing.Point(134, 45)
        Me.foldercount_label.Name = "foldercount_label"
        Me.foldercount_label.Size = New System.Drawing.Size(441, 23)
        Me.foldercount_label.TabIndex = 22
        Me.foldercount_label.Text = "(no result)"
        Me.foldercount_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datelaunched_label
        '
        Me.datelaunched_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datelaunched_label.Location = New System.Drawing.Point(135, 160)
        Me.datelaunched_label.Name = "datelaunched_label"
        Me.datelaunched_label.Size = New System.Drawing.Size(441, 23)
        Me.datelaunched_label.TabIndex = 23
        Me.datelaunched_label.Text = "(no result)"
        Me.datelaunched_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'savefilename_label
        '
        Me.savefilename_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.savefilename_label.Location = New System.Drawing.Point(135, 22)
        Me.savefilename_label.Name = "savefilename_label"
        Me.savefilename_label.Size = New System.Drawing.Size(441, 23)
        Me.savefilename_label.TabIndex = 24
        Me.savefilename_label.Text = "(no result)"
        Me.savefilename_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.FileName = "List_"
        Me.SaveFileDialog1.Filter = "Text files|*.txt"
        Me.SaveFileDialog1.Title = "Select the filename for the resultant output"
        '
        'currentfoldername_label
        '
        Me.currentfoldername_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.currentfoldername_label.Location = New System.Drawing.Point(135, 68)
        Me.currentfoldername_label.Name = "currentfoldername_label"
        Me.currentfoldername_label.Size = New System.Drawing.Size(441, 23)
        Me.currentfoldername_label.TabIndex = 25
        Me.currentfoldername_label.Text = "(no result)"
        Me.currentfoldername_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Total Bytes Parsed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Last Accessed File:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Last Accessed Folder:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Total Files Located:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Folders Located:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(15, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Operational Time:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Report File:"
        '
        'FullPath_CheckBox
        '
        Me.FullPath_CheckBox.AutoSize = True
        Me.FullPath_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullPath_CheckBox.Location = New System.Drawing.Point(299, 59)
        Me.FullPath_CheckBox.Name = "FullPath_CheckBox"
        Me.FullPath_CheckBox.Size = New System.Drawing.Size(125, 17)
        Me.FullPath_CheckBox.TabIndex = 33
        Me.FullPath_CheckBox.Text = "Write Full Folder Path"
        Me.FullPath_CheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.FullPath_CheckBox)
        Me.GroupBox1.Controls.Add(Me.InputFolder_Textbox)
        Me.GroupBox1.Controls.Add(Me.Browse_Button)
        Me.GroupBox1.Controls.Add(Me.SizeUnit1)
        Me.GroupBox1.Controls.Add(Me.SizeUnit2)
        Me.GroupBox1.Controls.Add(Me.SizeUnit3)
        Me.GroupBox1.Controls.Add(Me.SizeUnit4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Recursive_Checkbox)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 89)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Options"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.currentfilename_label)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.filecount_label)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.bytes_label)
        Me.GroupBox2.Controls.Add(Me.foldercount_label)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.datelaunched_label)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.savefilename_label)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.currentfoldername_label)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 189)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation Status"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(465, 358)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 13)
        Me.LinkLabel1.TabIndex = 37
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[Open Last Generated Listing]"
        Me.LinkLabel1.Visible = False
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 428)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.startAsyncButton)
        Me.Controls.Add(Me.Status_Textbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FullErrors_Checkbox)
        Me.Controls.Add(Me.Description_Label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(632, 462)
        Me.Name = "Main_Screen"
        Me.Text = "Folder Listing With Size Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputFolder_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Description_Label As System.Windows.Forms.Label
    Friend WithEvents Browse_Button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FullErrors_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Status_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents SizeUnit1 As System.Windows.Forms.RadioButton
    Friend WithEvents SizeUnit2 As System.Windows.Forms.RadioButton
    Friend WithEvents SizeUnit3 As System.Windows.Forms.RadioButton
    Friend WithEvents SizeUnit4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents bytes_label As System.Windows.Forms.Label
    Private WithEvents cancelAsyncButton As System.Windows.Forms.Button
    Private WithEvents startAsyncButton As System.Windows.Forms.Button
    Friend WithEvents Recursive_Checkbox As System.Windows.Forms.CheckBox
    Private WithEvents currentfilename_label As System.Windows.Forms.Label
    Private WithEvents filecount_label As System.Windows.Forms.Label
    Private WithEvents foldercount_label As System.Windows.Forms.Label
    Private WithEvents datelaunched_label As System.Windows.Forms.Label
    Private WithEvents savefilename_label As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents currentfoldername_label As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FullPath_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
