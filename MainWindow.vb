Imports System.Globalization

Imports System.Threading
Public Class MainWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Real_last_Time_Textbox.Text = DateTime.Now
        Timer2.Start()

        Try
            If IO.File.Exists(My.Settings.Dropdownreason) Then
                Using sr As New IO.StreamReader(My.Settings.Dropdownreason)
                    While Not sr.EndOfStream
                        Reason_ComboBox.Items.Add(sr.ReadLine)
                    End While
                End Using
            Else
                MsgBox("Oooops, File not found !!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.BackColor = My.Settings.BKcolor
        Me.StartTime_TextBox.ForeColor = My.Settings.FontColor
        Me.PartNum_TextBox.ForeColor = My.Settings.FontColor
        Me.SampleNum_TextBox.ForeColor = My.Settings.FontColor
        Me.Reason_ComboBox.ForeColor = My.Settings.FontColor
        Me.StopTime_TextBox.ForeColor = My.Settings.FontColor
        Me.Duration_Label.ForeColor = My.Settings.FontColor
        Me.Start_Button.ForeColor = My.Settings.FontColor
        Me.Stop_Button.ForeColor = My.Settings.FontColor
        Me.Submit_Button.ForeColor = My.Settings.FontColor
        Me.Clear_Button.ForeColor = My.Settings.FontColor
        Me.Part_Label.ForeColor = My.Settings.FontColor
        Me.Sample_Label.ForeColor = My.Settings.FontColor
        Me.Reason_Label.ForeColor = My.Settings.FontColor
        Me.Title_Label.ForeColor = My.Settings.FontColor
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start_Button.Click
        StartTime_TextBox.Text = DateTime.Now
        Warn_start_TextBox.Text = DateTime.Now
        Timer1.Start()
        Start_Button.BackColor = Color.Green
        Stop_Button.BackColor = Color.LightGray
        Submit_Button.BackColor = Color.LightGray

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Stop_Button.Click
        StopTime_TextBox.Text = DateTime.Now
        Timer1.Stop()
        Start_Button.BackColor = Color.LightGray
        Stop_Button.BackColor = Color.Red
        Submit_Button.BackColor = Color.LightGray
        Real_last_Time_Textbox.Text = DateTime.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Current_Time_TextBox.Text = DateTime.Now
        Dim st1 As DateTime = StartTime_TextBox.Text
        Dim st2 As DateTime = Current_Time_TextBox.Text
        Dim st3 = st1.Subtract(st2).Duration
        Duration_Label.Text = st3.Duration.ToString
        If StartTime_TextBox.Text = "" Then
        Else
            If StopTime_TextBox.Text = "" Then
                Dim st4 As DateTime = Warn_start_TextBox.Text
                Dim st5 As DateTime = Current_Time_TextBox.Text
                Dim st6 = st4.Subtract(st5).Duration
                Warn_Duration_TextBox.Text = st6.Duration.ToString
                If Warn_Duration_TextBox.Text = My.Settings.WarnTime Then
                    Warn_start_TextBox.Text = DateTime.Now
                    If StopTime_TextBox.Text = "" Then
                        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                        NotifyIcon1.BalloonTipText = My.Settings.ToolTipMsgStop
                        NotifyIcon1.BalloonTipTitle = "GOGO-Task"
                        NotifyIcon1.ShowBalloonTip(5000)
                        If My.Settings.SoundCheck = True Then
                            Timer3.Start()
                        End If
                    Else
                        GoTo fail2
                    End If
fail2:
                End If
            Else

            End If
        End If

    End Sub

    Private Sub PlayBackgroundSoundFile()
        Throw New NotImplementedException()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Keep current time
        Real_Current_Time_Textbox.Text = DateTime.Now

        'Update Duration
        Dim st4 As DateTime = Real_Current_Time_Textbox.Text
        Dim st5 As DateTime = Real_last_Time_Textbox.Text
        Dim st6 = st4.Subtract(st5).Duration
        Real_Duration_TextBox.Text = st6.Duration.ToString

        'When Duration reaches X update last time textbox
        If Timer1.Enabled = True Then
            Real_last_Time_Textbox.Text = DateTime.Now
        Else
            If Real_Duration_TextBox.Text = My.Settings.WarnTime Then
                Real_last_Time_Textbox.Text = DateTime.Now
                'Notify
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = "did you forgot to start?"
                NotifyIcon1.BalloonTipTitle = "GOGO-Task"
                NotifyIcon1.ShowBalloonTip(5000)
                If My.Settings.SoundCheck = True Then
                    Timer3.Start()
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        On Error GoTo ErrorHandler
        If StartTime_TextBox.Text = "" Or StopTime_TextBox.Text = "" Then
            MsgBox("missing time Value")
            GoTo fail
        Else
            Dim st1 As DateTime = StartTime_TextBox.Text
            Dim st2 As DateTime = StopTime_TextBox.Text
            Dim st3 = st1.Subtract(st2).Duration
            Duration_Label.Text = st3.Duration.ToString
            Submit_Button.BackColor = Color.Green
            'File Save
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.networksave, True)
            file.WriteLine("Sample#:" + "," + SampleNum_TextBox.Text + "," + "Part#:" + "," + PartNum_TextBox.Text + "," + "Reason:" + "," + Reason_ComboBox.Text + "," + "StartTime:" + "," + StartTime_TextBox.Text + "," + "StopTime:" + "," + StopTime_TextBox.Text + "," + "DurationTime:" + "," + "_" + Duration_Label.Text + "," + "Notes:" + "," + Notes_TextBox.Text + "," + "PCname:" + "," + My.User.Name + "," + "Date&Time:" + "," + DateAndTime.Now)
            file.Close()
            GoTo Success
ErrorHandler:
            MsgBox("Something went wrong or A program has data storage open. Call Kevin if you need help.")
            GoTo Done
Success:
            MsgBox("Data Sumbited")
            GoTo Done
Done:
        End If


fail:
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        If StopTime_TextBox.Text = "" Then
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipText = "Do not forget to add a stop time!"
            NotifyIcon1.BalloonTipTitle = "GOGO-Task"
            NotifyIcon1.ShowBalloonTip(5000)
        Else
            GoTo fail2
        End If
fail2:
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        Timer1.Stop()
        Notes_TextBox.Text = ""
        StartTime_TextBox.Text = ""
        StopTime_TextBox.Text = ""
        SampleNum_TextBox.Text = ""
        Duration_Label.Text = "00:00:00"
        Warn_start_TextBox.Text = ""
        Current_Time_TextBox.Text = ""
        Warn_Duration_TextBox.Text = ""
        Start_Button.BackColor = Color.LightGray
        Stop_Button.BackColor = Color.LightGray
        Submit_Button.BackColor = Color.LightGray

    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Dim colordig As New ColorDialog
        colordig.ShowDialog()
        Me.BackColor = colordig.Color
        My.Settings.BKcolor = colordig.Color
        Me.BackColor = My.Settings.BKcolor
        Me.StartTime_TextBox.ForeColor = My.Settings.FontColor
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        Dim colordigfont As New ColorDialog
        colordigfont.ShowDialog()
        My.Settings.FontColor = colordigfont.Color
        Me.StartTime_TextBox.ForeColor = colordigfont.Color
        Me.StartTime_TextBox.ForeColor = My.Settings.FontColor
        Me.PartNum_TextBox.ForeColor = My.Settings.FontColor
        Me.SampleNum_TextBox.ForeColor = My.Settings.FontColor
        Me.Reason_ComboBox.ForeColor = My.Settings.FontColor
        Me.StopTime_TextBox.ForeColor = My.Settings.FontColor
        Me.Duration_Label.ForeColor = My.Settings.FontColor
        Me.Start_Button.ForeColor = My.Settings.FontColor
        Me.Stop_Button.ForeColor = My.Settings.FontColor
        Me.Submit_Button.ForeColor = My.Settings.FontColor
        Me.Clear_Button.ForeColor = My.Settings.FontColor
        Me.Part_Label.ForeColor = My.Settings.FontColor
        Me.Sample_Label.ForeColor = My.Settings.FontColor
        Me.Reason_Label.ForeColor = My.Settings.FontColor
        Me.Title_Label.ForeColor = My.Settings.FontColor
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        OptionWindow.Show()
    End Sub

    Private Sub Reason_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Reason_ComboBox.SelectedIndexChanged
        ' Dim strBuff As String
        ' Dim strArr() As String
        ' On Error GoTo Err_Handler
        ' List

        'Dim fileReader2 As String



        'Open and load the ComboBox with the Text File
        'fileReader2 = My.Computer.FileSystem.ReadAllText("V:\Quality\Drop.txt") ' For Input As #1
        'Reason_ComboBox.DataSource = fileReader2
        ' Reason_ComboBox.ValueMember = Text
        ' Until EOF(1)
        'Line Input #1, strBuff
        'son_ComboBox.AddItem strBuff
        'Loop
        'Close #1
        'Err_Handler:
        '   MsgBox "Number: " & Err.Number & vbCrLf &
        ' "Description: " & Err.Description, vbOKOnly + vbInformation, "File I/O Error"

    End Sub

    Private Sub Warn_Duration_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Warn_Duration_TextBox.TextChanged

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        My.Computer.Audio.Play(My.Settings.SoundFile, AudioPlayMode.WaitToComplete)
        Timer3.Stop()
    End Sub
End Class
'notes & Junk

'1/25/22 
'getting back to this project
'
'junk i found under submit button probaably test code that failed
'Dim num1 As Integer = st1.Subtract(st2).Duration.Hours
'Dim num2 As Integer = st1.Subtract(st2).Duration.Minutes
'Dim num3 As Integer = st1.Subtract(st2).Duration.Seconds
'TextBox4.Text = num1.ToString + ":" + num2.ToString + ":" + num3.ToString



