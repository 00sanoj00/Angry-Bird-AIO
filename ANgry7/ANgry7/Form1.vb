Imports System.Net
Imports System.IO
Public Class Form1

    Public link As String
    Dim dataDirectory As String = String.Format("{0}\Wallpeper\w.jpg", Environment.CurrentDirectory)
    Dim newfolder As String = String.Format("{0}\Wallpeper", Environment.CurrentDirectory)
    Dim newfolderasst As String = String.Format("{0}\Assist", Environment.CurrentDirectory)

    Dim newfolderasst1 As String = String.Format("{0}\Assist\1", Environment.CurrentDirectory)
    Dim newfolderasst2 As String = String.Format("{0}\Assist\2", Environment.CurrentDirectory)
    Dim newfolderasst3 As String = String.Format("{0}\Assist\3", Environment.CurrentDirectory)
    Dim newfolderasst4 As String = String.Format("{0}\Assist\4", Environment.CurrentDirectory)
    Dim newfolderasst5 As String = String.Format("{0}\Assist\5", Environment.CurrentDirectory)
    Dim newfolderasst6 As String = String.Format("{0}\Assist\6", Environment.CurrentDirectory)
    Dim newfolderasst7 As String = String.Format("{0}\Assist\7", Environment.CurrentDirectory)


    Private Sub Downloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Downloader.DoWork
        Try
            File.Delete(dataDirectory)
        Catch ex As Exception

        End Try
        link = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Screen/Mainscreen.jpg"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar1.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link, dataDirectory)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Directory.CreateDirectory(newfolder)
            Directory.CreateDirectory(newfolderasst)
            Directory.CreateDirectory(newfolderasst1)
            Directory.CreateDirectory(newfolderasst2)
            Directory.CreateDirectory(newfolderasst3)
            Directory.CreateDirectory(newfolderasst4)
            Directory.CreateDirectory(newfolderasst5)
            Directory.CreateDirectory(newfolderasst6)
            Directory.CreateDirectory(newfolderasst7)

        Catch ex As Exception

        End Try


        PeProgressBar1.Value = 0
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer1.Start()
        Downloader.RunWorkerAsync()
    End Sub

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CenterToParent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory) Then
            Dim o As New System.IO.FileInfo(dataDirectory)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar1.Value = amount
        End If
    End Sub

    Private Sub Downloader_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Downloader.RunWorkerCompleted
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub PeForm1_Click(sender As Object, e As EventArgs) Handles PeForm1.Click

    End Sub
End Class
