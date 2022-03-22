<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.Stop_Button = New System.Windows.Forms.Button()
        Me.Notes_TextBox = New System.Windows.Forms.TextBox()
        Me.StartTime_TextBox = New System.Windows.Forms.TextBox()
        Me.StopTime_TextBox = New System.Windows.Forms.TextBox()
        Me.SampleNum_TextBox = New System.Windows.Forms.TextBox()
        Me.Reason_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TestButton = New System.Windows.Forms.Button()
        Me.Warn_start_TextBox = New System.Windows.Forms.TextBox()
        Me.Current_Time_TextBox = New System.Windows.Forms.TextBox()
        Me.Warn_Duration_TextBox = New System.Windows.Forms.TextBox()
        Me.Duration_Label = New System.Windows.Forms.Label()
        Me.Sample_Label = New System.Windows.Forms.Label()
        Me.Reason_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.PartNum_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_Label = New System.Windows.Forms.Label()
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Real_Duration_TextBox = New System.Windows.Forms.TextBox()
        Me.Real_last_Time_Textbox = New System.Windows.Forms.TextBox()
        Me.Real_Current_Time_Textbox = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Start_Button
        '
        Me.Start_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_Button.Location = New System.Drawing.Point(32, 125)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(141, 47)
        Me.Start_Button.TabIndex = 0
        Me.Start_Button.Text = "Start"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'Stop_Button
        '
        Me.Stop_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stop_Button.Location = New System.Drawing.Point(818, 125)
        Me.Stop_Button.Name = "Stop_Button"
        Me.Stop_Button.Size = New System.Drawing.Size(141, 47)
        Me.Stop_Button.TabIndex = 1
        Me.Stop_Button.Text = "Stop"
        Me.Stop_Button.UseVisualStyleBackColor = True
        '
        'Notes_TextBox
        '
        Me.Notes_TextBox.Location = New System.Drawing.Point(32, 248)
        Me.Notes_TextBox.Multiline = True
        Me.Notes_TextBox.Name = "Notes_TextBox"
        Me.Notes_TextBox.Size = New System.Drawing.Size(938, 353)
        Me.Notes_TextBox.TabIndex = 2
        '
        'StartTime_TextBox
        '
        Me.StartTime_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartTime_TextBox.Location = New System.Drawing.Point(13, 182)
        Me.StartTime_TextBox.Name = "StartTime_TextBox"
        Me.StartTime_TextBox.Size = New System.Drawing.Size(181, 26)
        Me.StartTime_TextBox.TabIndex = 3
        Me.StartTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StopTime_TextBox
        '
        Me.StopTime_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopTime_TextBox.Location = New System.Drawing.Point(803, 182)
        Me.StopTime_TextBox.Name = "StopTime_TextBox"
        Me.StopTime_TextBox.Size = New System.Drawing.Size(181, 26)
        Me.StopTime_TextBox.TabIndex = 4
        Me.StopTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SampleNum_TextBox
        '
        Me.SampleNum_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SampleNum_TextBox.Location = New System.Drawing.Point(411, 182)
        Me.SampleNum_TextBox.Name = "SampleNum_TextBox"
        Me.SampleNum_TextBox.Size = New System.Drawing.Size(162, 26)
        Me.SampleNum_TextBox.TabIndex = 5
        Me.SampleNum_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reason_ComboBox
        '
        Me.Reason_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_ComboBox.FormattingEnabled = True
        Me.Reason_ComboBox.Location = New System.Drawing.Point(618, 178)
        Me.Reason_ComboBox.Name = "Reason_ComboBox"
        Me.Reason_ComboBox.Size = New System.Drawing.Size(162, 28)
        Me.Reason_ComboBox.TabIndex = 6
        '
        'Submit_Button
        '
        Me.Submit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit_Button.Location = New System.Drawing.Point(229, 633)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(132, 46)
        Me.Submit_Button.TabIndex = 7
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_Button
        '
        Me.Clear_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Button.Location = New System.Drawing.Point(648, 633)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(132, 47)
        Me.Clear_Button.TabIndex = 8
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(884, 608)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(75, 23)
        Me.TestButton.TabIndex = 10
        Me.TestButton.Text = "Button5"
        Me.TestButton.UseVisualStyleBackColor = True
        Me.TestButton.Visible = False
        '
        'Warn_start_TextBox
        '
        Me.Warn_start_TextBox.Location = New System.Drawing.Point(870, 651)
        Me.Warn_start_TextBox.Name = "Warn_start_TextBox"
        Me.Warn_start_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Warn_start_TextBox.TabIndex = 11
        Me.Warn_start_TextBox.Visible = False
        '
        'Current_Time_TextBox
        '
        Me.Current_Time_TextBox.Location = New System.Drawing.Point(870, 671)
        Me.Current_Time_TextBox.Name = "Current_Time_TextBox"
        Me.Current_Time_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Current_Time_TextBox.TabIndex = 12
        Me.Current_Time_TextBox.Visible = False
        '
        'Warn_Duration_TextBox
        '
        Me.Warn_Duration_TextBox.Location = New System.Drawing.Point(870, 630)
        Me.Warn_Duration_TextBox.Name = "Warn_Duration_TextBox"
        Me.Warn_Duration_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Warn_Duration_TextBox.TabIndex = 13
        Me.Warn_Duration_TextBox.Visible = False
        '
        'Duration_Label
        '
        Me.Duration_Label.AutoSize = True
        Me.Duration_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Duration_Label.Location = New System.Drawing.Point(401, 630)
        Me.Duration_Label.Name = "Duration_Label"
        Me.Duration_Label.Size = New System.Drawing.Size(172, 42)
        Me.Duration_Label.TabIndex = 14
        Me.Duration_Label.Text = "00:00:00"
        '
        'Sample_Label
        '
        Me.Sample_Label.AutoSize = True
        Me.Sample_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sample_Label.Location = New System.Drawing.Point(385, 141)
        Me.Sample_Label.Name = "Sample_Label"
        Me.Sample_Label.Size = New System.Drawing.Size(217, 25)
        Me.Sample_Label.TabIndex = 15
        Me.Sample_Label.Text = "QA Sample Number"
        '
        'Reason_Label
        '
        Me.Reason_Label.AutoSize = True
        Me.Reason_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_Label.Location = New System.Drawing.Point(652, 139)
        Me.Reason_Label.Name = "Reason_Label"
        Me.Reason_Label.Size = New System.Drawing.Size(92, 25)
        Me.Reason_Label.TabIndex = 16
        Me.Reason_Label.Text = "Reason"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem, Me.FontColorToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FontColorToolStripMenuItem.Text = "Font Color"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'PartNum_TextBox
        '
        Me.PartNum_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartNum_TextBox.Location = New System.Drawing.Point(218, 182)
        Me.PartNum_TextBox.Name = "PartNum_TextBox"
        Me.PartNum_TextBox.Size = New System.Drawing.Size(162, 26)
        Me.PartNum_TextBox.TabIndex = 18
        Me.PartNum_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_Label
        '
        Me.Part_Label.AutoSize = True
        Me.Part_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_Label.Location = New System.Drawing.Point(262, 141)
        Me.Part_Label.Name = "Part_Label"
        Me.Part_Label.Size = New System.Drawing.Size(75, 25)
        Me.Part_Label.TabIndex = 19
        Me.Part_Label.Text = "Part #"
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Georgia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(295, 24)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(417, 72)
        Me.Title_Label.TabIndex = 20
        Me.Title_Label.Text = "GOGO-Task"
        '
        'Timer2
        '
        '
        'Real_Duration_TextBox
        '
        Me.Real_Duration_TextBox.Location = New System.Drawing.Point(12, 630)
        Me.Real_Duration_TextBox.Name = "Real_Duration_TextBox"
        Me.Real_Duration_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Real_Duration_TextBox.TabIndex = 21
        Me.Real_Duration_TextBox.Visible = False
        '
        'Real_last_Time_Textbox
        '
        Me.Real_last_Time_Textbox.Location = New System.Drawing.Point(12, 651)
        Me.Real_last_Time_Textbox.Name = "Real_last_Time_Textbox"
        Me.Real_last_Time_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Real_last_Time_Textbox.TabIndex = 22
        Me.Real_last_Time_Textbox.Visible = False
        '
        'Real_Current_Time_Textbox
        '
        Me.Real_Current_Time_Textbox.Location = New System.Drawing.Point(13, 671)
        Me.Real_Current_Time_Textbox.Name = "Real_Current_Time_Textbox"
        Me.Real_Current_Time_Textbox.Size = New System.Drawing.Size(100, 20)
        Me.Real_Current_Time_Textbox.TabIndex = 23
        Me.Real_Current_Time_Textbox.Visible = False
        '
        'Timer3
        '
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 696)
        Me.Controls.Add(Me.Real_Current_Time_Textbox)
        Me.Controls.Add(Me.Real_last_Time_Textbox)
        Me.Controls.Add(Me.Real_Duration_TextBox)
        Me.Controls.Add(Me.Title_Label)
        Me.Controls.Add(Me.Part_Label)
        Me.Controls.Add(Me.PartNum_TextBox)
        Me.Controls.Add(Me.Reason_Label)
        Me.Controls.Add(Me.Sample_Label)
        Me.Controls.Add(Me.Duration_Label)
        Me.Controls.Add(Me.Warn_Duration_TextBox)
        Me.Controls.Add(Me.Current_Time_TextBox)
        Me.Controls.Add(Me.Warn_start_TextBox)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.Clear_Button)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Reason_ComboBox)
        Me.Controls.Add(Me.SampleNum_TextBox)
        Me.Controls.Add(Me.StopTime_TextBox)
        Me.Controls.Add(Me.StartTime_TextBox)
        Me.Controls.Add(Me.Notes_TextBox)
        Me.Controls.Add(Me.Stop_Button)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.Text = "GOGO_Task"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Start_Button As Button
    Friend WithEvents Stop_Button As Button
    Friend WithEvents Notes_TextBox As TextBox
    Friend WithEvents StartTime_TextBox As TextBox
    Friend WithEvents StopTime_TextBox As TextBox
    Friend WithEvents SampleNum_TextBox As TextBox
    Friend WithEvents Reason_ComboBox As ComboBox
    Friend WithEvents Submit_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TestButton As Button
    Friend WithEvents Warn_start_TextBox As TextBox
    Friend WithEvents Current_Time_TextBox As TextBox
    Friend WithEvents Warn_Duration_TextBox As TextBox
    Friend WithEvents Duration_Label As Label
    Friend WithEvents Sample_Label As Label
    Friend WithEvents Reason_Label As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents PartNum_TextBox As TextBox
    Friend WithEvents Part_Label As Label
    Friend WithEvents Title_Label As Label
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Real_Duration_TextBox As TextBox
    Friend WithEvents Real_last_Time_Textbox As TextBox
    Friend WithEvents Real_Current_Time_Textbox As TextBox
    Friend WithEvents Timer3 As Timer
End Class
