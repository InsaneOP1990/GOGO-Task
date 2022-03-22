Imports System
Imports System.Net
Imports System.IO
Imports System.Net.Dns
Imports System.Text.RegularExpressions
Public Class Splash
    Private Function GetExternalIp() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function
    Private Function getHTML(ByVal address As String) As String
        Try
            Dim rt As String = ""
            Dim wRequest As WebRequest
            Dim wResponse As WebResponse
            Dim SR As StreamReader
            wRequest = WebRequest.Create(address)
            wResponse = wRequest.GetResponse
            SR = New StreamReader(wResponse.GetResponseStream)
            rt = SR.ReadToEnd
            SR.Close()
            Return rt
        Catch ex As Exception
            Return "Error"
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer0.Interval = 1000 'ms
        Timer0.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer0.Tick
        ProgressBar1.Value += 20
        Label6.Text = ProgressBar1.Value & "%"
        If Label6.Text = "100%" Then
            MainWindow.Show()
            Timer0.Stop()
            Me.Close()
        End If
Success:
        GoTo Done
Done:

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class