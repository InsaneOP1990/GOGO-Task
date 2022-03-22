Public Class OptionWindow
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load color settings
        Me.BackColor = My.Settings.BKcolor
        Me.Options_TitleLabel.ForeColor = My.Settings.FontColor
        Me.Netloc_Label.ForeColor = My.Settings.FontColor
        Me.Network_fileTextBox.ForeColor = My.Settings.FontColor
        Me.SoundFileLabel.ForeColor = My.Settings.FontColor
        Me.SoundFileTextBox.ForeColor = My.Settings.FontColor
        Me.CheckBox1.ForeColor = My.Settings.FontColor
        Me.Tool_TipWarnLabel.ForeColor = My.Settings.FontColor
        Me.Tool_Tip_Msg_stopLabel.ForeColor = My.Settings.FontColor
        Me.Tool_Tip_Msg_StopTextBox.ForeColor = My.Settings.FontColor
        Me.Tool_Tip_WarnComboBox.ForeColor = My.Settings.FontColor
        Me.ReasondropLabel.ForeColor = My.Settings.FontColor
        Me.Reason_optionTextBox.ForeColor = My.Settings.FontColor
        Me.Save_settingButton.ForeColor = My.Settings.FontColor
        Me.Tool_Tip_Msg_startLabel.ForeColor = My.Settings.FontColor
        Me.Tool_Tip_Msg_StartTextBox.ForeColor = My.Settings.FontColor
        Me.Reason_File_Label.ForeColor = My.Settings.FontColor
        Me.Reason_File_TextBox.ForeColor = My.Settings.FontColor
        'load File
        If System.IO.File.Exists(My.Settings.Dropdownreason) = True Then
            Dim fileReader5 As String
            fileReader5 = My.Computer.FileSystem.ReadAllText(My.Settings.Dropdownreason)
            Reason_optionTextBox.Text = fileReader5
            FileClose()
        End If
        'load combo box
        If My.Settings.WarnTime = "00:01:00" Then
            Tool_Tip_WarnComboBox.Text = "1 minute"
        End If
        If My.Settings.WarnTime = "00:05:00" Then
            Tool_Tip_WarnComboBox.Text = "5 minutes"
        End If
        If My.Settings.WarnTime = "00:15:00" Then
            Tool_Tip_WarnComboBox.Text = "15 minutes"
        End If
        If My.Settings.WarnTime = "00:30:00" Then
            Tool_Tip_WarnComboBox.Text = "30 minutes"
        End If
        If My.Settings.WarnTime = "01:00:00" Then
            Tool_Tip_WarnComboBox.Text = "60 minutes"
        End If
        'load settings
        Network_fileTextBox.Text = My.Settings.networksave
        Tool_Tip_Msg_StopTextBox.Text = My.Settings.ToolTipMsgStop
        Tool_Tip_Msg_StartTextBox.Text = My.Settings.ToolTipMsgStart
        CheckBox1.Checked = My.Settings.SoundCheck
        SoundFileTextBox.Text = My.Settings.SoundFile
        Me.Reason_File_TextBox.Text = My.Settings.Dropdownreason
    End Sub

    Private Sub Save_settingButton_Click(sender As Object, e As EventArgs) Handles Save_settingButton.Click
        'save settings
        My.Settings.ToolTipMsgStop = Tool_Tip_Msg_StopTextBox.Text
        My.Settings.networksave = Network_fileTextBox.Text
        My.Settings.ToolTipMsgStart = Tool_Tip_Msg_StartTextBox.Text
        My.Settings.SoundCheck = CheckBox1.Checked
        My.Settings.SoundFile = SoundFileTextBox.Text
        My.Settings.Dropdownreason = Me.Reason_File_TextBox.Text

        'remove the drop down file
        If System.IO.File.Exists(My.Settings.Dropdownreason) = True Then
            My.Computer.FileSystem.DeleteFile(My.Settings.Dropdownreason)
            GoTo Success
        End If
ErrorHandler:
        MsgBox("Something went wrong or A program has data storage open. Call Kevin if you need help.")
        GoTo fail
Success:
        'save new drop down file
        Dim fileNameA1 As System.IO.StreamWriter
        fileNameA1 = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.Dropdownreason, True)
        fileNameA1.Write(Reason_optionTextBox.Text)
        fileNameA1.Close()
        'cobo box
        If Tool_Tip_WarnComboBox.Text = "1 minute" Then
            My.Settings.WarnTime = "00:01:00"
        End If
        If Tool_Tip_WarnComboBox.Text = "5 minutes" Then
            My.Settings.WarnTime = "00:05:00"
        End If
        If Tool_Tip_WarnComboBox.Text = "15 minutes" Then
            My.Settings.WarnTime = "00:15:00"
        End If
        If Tool_Tip_WarnComboBox.Text = "30 minutes" Then
            My.Settings.WarnTime = "00:30:00"
        End If
        If Tool_Tip_WarnComboBox.Text = "60 minutes" Then
            My.Settings.WarnTime = "01:00:00"
        End If
        GoTo Done
Done:
        MsgBox("Data Sumbited, Restart app for changes to take effect")
fail:

    End Sub
End Class