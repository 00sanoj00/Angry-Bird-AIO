Imports System.Net
Imports System.IO
Public Class Form1

    Public link As String
    Dim dataDirectory As String = String.Format("{0}\Wallpeper\w.jpg", Environment.CurrentDirectory)
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
        ProgressBar1.MaxValue = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link, dataDirectory)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer1.Start()
        Downloader.RunWorkerAsync()
    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

        'or you can use 

        Me.CenterToParent()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory) Then
            Dim o As New System.IO.FileInfo(dataDirectory)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            ProgressBar1.Value = amount
        End If
    End Sub

    Private Sub Downloader_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Downloader.RunWorkerCompleted
        Me.Hide()
        Home.Show()

    End Sub

    Private Sub FormSkin1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FormSkin1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormSkin1.Click

    End Sub
End Class
