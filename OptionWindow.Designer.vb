<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionWindow
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
        Me.Network_fileTextBox = New System.Windows.Forms.TextBox()
        Me.Reason_optionTextBox = New System.Windows.Forms.TextBox()
        Me.Netloc_Label = New System.Windows.Forms.Label()
        Me.Options_TitleLabel = New System.Windows.Forms.Label()
        Me.Save_settingButton = New System.Windows.Forms.Button()
        Me.Tool_Tip_WarnComboBox = New System.Windows.Forms.ComboBox()
        Me.Tool_TipWarnLabel = New System.Windows.Forms.Label()
        Me.ReasondropLabel = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SoundFileTextBox = New System.Windows.Forms.TextBox()
        Me.SoundFileLabel = New System.Windows.Forms.Label()
        Me.Tool_Tip_Msg_StopTextBox = New System.Windows.Forms.TextBox()
        Me.Tool_Tip_Msg_stopLabel = New System.Windows.Forms.Label()
        Me.Tool_Tip_Msg_startLabel = New System.Windows.Forms.Label()
        Me.Tool_Tip_Msg_StartTextBox = New System.Windows.Forms.TextBox()
        Me.Reason_File_Label = New System.Windows.Forms.Label()
        Me.Reason_File_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Network_fileTextBox
        '
        Me.Network_fileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Network_fileTextBox.Location = New System.Drawing.Point(15, 49)
        Me.Network_fileTextBox.Name = "Network_fileTextBox"
        Me.Network_fileTextBox.Size = New System.Drawing.Size(267, 26)
        Me.Network_fileTextBox.TabIndex = 0
        '
        'Reason_optionTextBox
        '
        Me.Reason_optionTextBox.Location = New System.Drawing.Point(686, 103)
        Me.Reason_optionTextBox.Multiline = True
        Me.Reason_optionTextBox.Name = "Reason_optionTextBox"
        Me.Reason_optionTextBox.Size = New System.Drawing.Size(310, 326)
        Me.Reason_optionTextBox.TabIndex = 1
        '
        'Netloc_Label
        '
        Me.Netloc_Label.AutoSize = True
        Me.Netloc_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Netloc_Label.Location = New System.Drawing.Point(12, 21)
        Me.Netloc_Label.Name = "Netloc_Label"
        Me.Netloc_Label.Size = New System.Drawing.Size(156, 20)
        Me.Netloc_Label.TabIndex = 2
        Me.Netloc_Label.Text = "Network file Location"
        '
        'Options_TitleLabel
        '
        Me.Options_TitleLabel.AutoSize = True
        Me.Options_TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Options_TitleLabel.Location = New System.Drawing.Point(376, 9)
        Me.Options_TitleLabel.Name = "Options_TitleLabel"
        Me.Options_TitleLabel.Size = New System.Drawing.Size(254, 73)
        Me.Options_TitleLabel.TabIndex = 3
        Me.Options_TitleLabel.Text = "Options"
        '
        'Save_settingButton
        '
        Me.Save_settingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_settingButton.Location = New System.Drawing.Point(454, 443)
        Me.Save_settingButton.Name = "Save_settingButton"
        Me.Save_settingButton.Size = New System.Drawing.Size(97, 39)
        Me.Save_settingButton.TabIndex = 4
        Me.Save_settingButton.Text = "Save"
        Me.Save_settingButton.UseVisualStyleBackColor = True
        '
        'Tool_Tip_WarnComboBox
        '
        Me.Tool_Tip_WarnComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Tip_WarnComboBox.FormattingEnabled = True
        Me.Tool_Tip_WarnComboBox.Items.AddRange(New Object() {"1 minute", "5 minutes", "15 minutes", "30  minutes", "60  minutes"})
        Me.Tool_Tip_WarnComboBox.Location = New System.Drawing.Point(15, 277)
        Me.Tool_Tip_WarnComboBox.Name = "Tool_Tip_WarnComboBox"
        Me.Tool_Tip_WarnComboBox.Size = New System.Drawing.Size(267, 28)
        Me.Tool_Tip_WarnComboBox.TabIndex = 5
        '
        'Tool_TipWarnLabel
        '
        Me.Tool_TipWarnLabel.AutoSize = True
        Me.Tool_TipWarnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_TipWarnLabel.Location = New System.Drawing.Point(12, 254)
        Me.Tool_TipWarnLabel.Name = "Tool_TipWarnLabel"
        Me.Tool_TipWarnLabel.Size = New System.Drawing.Size(127, 20)
        Me.Tool_TipWarnLabel.TabIndex = 6
        Me.Tool_TipWarnLabel.Text = "Tool Tip Warning"
        '
        'ReasondropLabel
        '
        Me.ReasondropLabel.AutoSize = True
        Me.ReasondropLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReasondropLabel.Location = New System.Drawing.Point(681, 75)
        Me.ReasondropLabel.Name = "ReasondropLabel"
        Me.ReasondropLabel.Size = New System.Drawing.Size(315, 25)
        Me.ReasondropLabel.TabIndex = 7
        Me.ReasondropLabel.Text = "Reason Drop Down Combo Box"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 147)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 24)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Sound Yes/No"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SoundFileTextBox
        '
        Me.SoundFileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundFileTextBox.Location = New System.Drawing.Point(16, 207)
        Me.SoundFileTextBox.Name = "SoundFileTextBox"
        Me.SoundFileTextBox.Size = New System.Drawing.Size(267, 26)
        Me.SoundFileTextBox.TabIndex = 9
        '
        'SoundFileLabel
        '
        Me.SoundFileLabel.AutoSize = True
        Me.SoundFileLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundFileLabel.Location = New System.Drawing.Point(11, 184)
        Me.SoundFileLabel.Name = "SoundFileLabel"
        Me.SoundFileLabel.Size = New System.Drawing.Size(150, 20)
        Me.SoundFileLabel.TabIndex = 10
        Me.SoundFileLabel.Text = "Sound File Location"
        '
        'Tool_Tip_Msg_StopTextBox
        '
        Me.Tool_Tip_Msg_StopTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Tip_Msg_StopTextBox.Location = New System.Drawing.Point(16, 403)
        Me.Tool_Tip_Msg_StopTextBox.Name = "Tool_Tip_Msg_StopTextBox"
        Me.Tool_Tip_Msg_StopTextBox.Size = New System.Drawing.Size(267, 26)
        Me.Tool_Tip_Msg_StopTextBox.TabIndex = 11
        '
        'Tool_Tip_Msg_stopLabel
        '
        Me.Tool_Tip_Msg_stopLabel.AutoSize = True
        Me.Tool_Tip_Msg_stopLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Tip_Msg_stopLabel.Location = New System.Drawing.Point(11, 381)
        Me.Tool_Tip_Msg_stopLabel.Name = "Tool_Tip_Msg_stopLabel"
        Me.Tool_Tip_Msg_stopLabel.Size = New System.Drawing.Size(171, 20)
        Me.Tool_Tip_Msg_stopLabel.TabIndex = 12
        Me.Tool_Tip_Msg_stopLabel.Text = "Tool Tip Stop Message"
        '
        'Tool_Tip_Msg_startLabel
        '
        Me.Tool_Tip_Msg_startLabel.AutoSize = True
        Me.Tool_Tip_Msg_startLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Tip_Msg_startLabel.Location = New System.Drawing.Point(12, 318)
        Me.Tool_Tip_Msg_startLabel.Name = "Tool_Tip_Msg_startLabel"
        Me.Tool_Tip_Msg_startLabel.Size = New System.Drawing.Size(172, 20)
        Me.Tool_Tip_Msg_startLabel.TabIndex = 14
        Me.Tool_Tip_Msg_startLabel.Text = "Tool Tip Start Message"
        '
        'Tool_Tip_Msg_StartTextBox
        '
        Me.Tool_Tip_Msg_StartTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_Tip_Msg_StartTextBox.Location = New System.Drawing.Point(16, 341)
        Me.Tool_Tip_Msg_StartTextBox.Name = "Tool_Tip_Msg_StartTextBox"
        Me.Tool_Tip_Msg_StartTextBox.Size = New System.Drawing.Size(267, 26)
        Me.Tool_Tip_Msg_StartTextBox.TabIndex = 13
        '
        'Reason_File_Label
        '
        Me.Reason_File_Label.AutoSize = True
        Me.Reason_File_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_File_Label.Location = New System.Drawing.Point(13, 87)
        Me.Reason_File_Label.Name = "Reason_File_Label"
        Me.Reason_File_Label.Size = New System.Drawing.Size(159, 20)
        Me.Reason_File_Label.TabIndex = 16
        Me.Reason_File_Label.Text = "Reason File Location"
        '
        'Reason_File_TextBox
        '
        Me.Reason_File_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_File_TextBox.Location = New System.Drawing.Point(16, 115)
        Me.Reason_File_TextBox.Name = "Reason_File_TextBox"
        Me.Reason_File_TextBox.Size = New System.Drawing.Size(267, 26)
        Me.Reason_File_TextBox.TabIndex = 15
        '
        'OptionWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 494)
        Me.Controls.Add(Me.Reason_File_Label)
        Me.Controls.Add(Me.Reason_File_TextBox)
        Me.Controls.Add(Me.Tool_Tip_Msg_startLabel)
        Me.Controls.Add(Me.Tool_Tip_Msg_StartTextBox)
        Me.Controls.Add(Me.Tool_Tip_Msg_stopLabel)
        Me.Controls.Add(Me.Tool_Tip_Msg_StopTextBox)
        Me.Controls.Add(Me.SoundFileLabel)
        Me.Controls.Add(Me.SoundFileTextBox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ReasondropLabel)
        Me.Controls.Add(Me.Tool_TipWarnLabel)
        Me.Controls.Add(Me.Tool_Tip_WarnComboBox)
        Me.Controls.Add(Me.Save_settingButton)
        Me.Controls.Add(Me.Options_TitleLabel)
        Me.Controls.Add(Me.Netloc_Label)
        Me.Controls.Add(Me.Reason_optionTextBox)
        Me.Controls.Add(Me.Network_fileTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "OptionWindow"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Network_fileTextBox As TextBox
    Friend WithEvents Reason_optionTextBox As TextBox
    Friend WithEvents Netloc_Label As Label
    Friend WithEvents Options_TitleLabel As Label
    Friend WithEvents Save_settingButton As Button
    Friend WithEvents Tool_Tip_WarnComboBox As ComboBox
    Friend WithEvents Tool_TipWarnLabel As Label
    Friend WithEvents ReasondropLabel As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents SoundFileTextBox As TextBox
    Friend WithEvents SoundFileLabel As Label
    Friend WithEvents Tool_Tip_Msg_StopTextBox As TextBox
    Friend WithEvents Tool_Tip_Msg_stopLabel As Label
    Friend WithEvents Tool_Tip_Msg_startLabel As Label
    Friend WithEvents Tool_Tip_Msg_StartTextBox As TextBox
    Friend WithEvents Reason_File_Label As Label
    Friend WithEvents Reason_File_TextBox As TextBox
End Class
