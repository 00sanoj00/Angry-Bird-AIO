Imports System.Windows.Forms.LinkLabel
Imports System.Net



Public Class Home
    Public link1 As String
    Public link2 As String
    Public link3 As String
    Public link4 As String
    Public link5 As String
    Public link6 As String
    Public link7 As String

    Dim dataDirectory1 As String = String.Format("{0}\Assist\1\Angry_Birds.7z", Environment.CurrentDirectory)
    Dim dataDirectory2 As String = String.Format("{0}\Assist\2\AngryBirdsSeasons.exe", Environment.CurrentDirectory)
    Dim dataDirectory3 As String = String.Format("{0}\Assist\3\AngryBirdsRio.exe", Environment.CurrentDirectory)
    Dim dataDirectory4 As String = String.Format("{0}\Assist\4\AngryBirdSpace.exe", Environment.CurrentDirectory)
    Dim dataDirectory5 As String = String.Format("{0}\Assist\5\AngryBirdsStarWars.exe", Environment.CurrentDirectory)
    Dim dataDirectory6 As String = String.Format("{0}\Assist\6\AngryBirdsStarWars2.exe", Environment.CurrentDirectory)
    Dim dataDirectory7 As String = String.Format("{0}\Assist\7\AngryBirdsSeasons2.exe", Environment.CurrentDirectory)


    Dim newfolderasst1 As String = String.Format("{0}\Assist\1", Environment.CurrentDirectory)
    Dim newfolderasst2 As String = String.Format("{0}\Assist\2", Environment.CurrentDirectory)
    Dim newfolderasst3 As String = String.Format("{0}\Assist\3", Environment.CurrentDirectory)
    Dim newfolderasst4 As String = String.Format("{0}\Assist\4", Environment.CurrentDirectory)
    Dim newfolderasst5 As String = String.Format("{0}\Assist\5", Environment.CurrentDirectory)
    Dim newfolderasst6 As String = String.Format("{0}\Assist\6", Environment.CurrentDirectory)
    Dim newfolderasst7 As String = String.Format("{0}\Assist\7", Environment.CurrentDirectory)

    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CenterToParent()

        PeProgressBar1.Value = 0
        PeProgressBar2.Value = 0
        PeProgressBar3.Value = 0
        PeProgressBar4.Value = 0
        PeProgressBar5.Value = 0
        PeProgressBar6.Value = 0
        PeProgressBar7.Value = 0

        If System.IO.File.Exists(dataDirectory1) Then
            PeProgressBar1.Value = 100
            PeButtonAlt1.Text = "Open and Install"
        Else
            PeProgressBar1.Value = 0
        End If



    End Sub

    Private Sub AngryBirds_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirds.DoWork
        link1 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds/Angry%20Birds.7zf"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link1)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar1.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link1, dataDirectory1)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdsSeasons_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdsSeasons.DoWork
        link2 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds%20Seasons/ABS.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link2)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar2.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link2, dataDirectory2)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdsRio_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdsRio.DoWork
        link3 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds%20Rio/AR.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link3)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar3.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link3, dataDirectory3)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdSpace_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdSpace.DoWork
        link4 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Bird%20Space/A.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link4)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar4.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link4, dataDirectory4)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdsStarWars_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdsStarWars.DoWork
        link5 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds%20Star%20Wars/ABSW.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link5)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar5.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link5, dataDirectory5)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdsStarWars2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdsStarWars2.DoWork
        link6 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds%20Star%20Wars%202/ABSW2.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link6)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar6.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link6, dataDirectory6)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirdsSeasons2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AngryBirdsSeasons2.DoWork
        link7 = "https://raw.githubusercontent.com/00sanoj00/Angry-Bird-AIO/master/Assist/Angry%20Birds%20Seasons%202/ABS2.exef"
        Dim size As Integer
        Dim wr As WebRequest
        wr = WebRequest.Create(link7)
        Dim webr As WebResponse = wr.GetResponse
        size = webr.ContentLength
        size = size / 1024
        PeProgressBar7.Maximum = size
        'Label2.Text = size

        Dim wc As New WebClient
        wc.DownloadFile(link7, dataDirectory7)
        Exit Sub

        MsgBox("ERROR", vbCritical, "ERROR")
    End Sub

    Private Sub AngryBirds_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirds.RunWorkerCompleted

        Timer1.Stop()
        Relaod()

    End Sub

    Private Sub AngryBirdsSeasons_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdsSeasons.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        MsgBox("ERROR")
        Timer2.Stop()
    End Sub

    Private Sub AngryBirdsRio_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdsRio.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        MsgBox("ERROR")
        Timer3.Stop()
    End Sub

    Private Sub AngryBirdSpace_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdSpace.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        MsgBox("ERROR")
        Timer4.Stop()
    End Sub

    Private Sub AngryBirdsStarWars_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdsStarWars.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        MsgBox("ERROR")
        Timer5.Stop()
    End Sub

    Private Sub AngryBirdsStarWars2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdsStarWars2.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        Timer6.Stop()
    End Sub

    Private Sub AngryBirdsSeasons2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AngryBirdsSeasons2.RunWorkerCompleted
        Control.CheckForIllegalCrossThreadCalls = True
        MsgBox("ERROR")
        Timer7.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory1) Then
            Dim o As New System.IO.FileInfo(dataDirectory1)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar1.Value = amount
        End If
    End Sub

    Private Sub PeButtonAlt1_Click(sender As Object, e As EventArgs) Handles PeButtonAlt1.Click

        If System.IO.File.Exists(dataDirectory1) Then
            Process.Start("explorer.exe", newfolderasst1)
        Else
            Control.CheckForIllegalCrossThreadCalls = False
            'Label2.Text = dataDirectory
            Timer1.Start()
            AngryBirds.RunWorkerAsync()
        End If
    End Sub

    Private Sub PeButtonAlt2_Click(sender As Object, e As EventArgs) Handles PeButtonAlt2.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer2.Start()
        AngryBirdsSeasons.RunWorkerAsync()
    End Sub

    Private Sub PeButtonAlt3_Click(sender As Object, e As EventArgs) Handles PeButtonAlt3.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer3.Start()
        AngryBirdsRio.RunWorkerAsync()
    End Sub

    Private Sub PeButtonAlt4_Click(sender As Object, e As EventArgs) Handles PeButtonAlt4.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer4.Start()
        AngryBirdSpace.RunWorkerAsync()
    End Sub

    Private Sub PeButtonAlt5_Click(sender As Object, e As EventArgs) Handles PeButtonAlt5.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer5.Start()
        AngryBirdsStarWars.RunWorkerAsync()
    End Sub

    Private Sub PeButtonAlt6_Click(sender As Object, e As EventArgs) Handles PeButtonAlt6.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer6.Start()
        AngryBirdsStarWars2.RunWorkerAsync()
    End Sub

    Private Sub PeButtonAlt7_Click(sender As Object, e As EventArgs) Handles PeButtonAlt7.Click
        Control.CheckForIllegalCrossThreadCalls = False
        'Label2.Text = dataDirectory
        Timer7.Start()
        AngryBirdsSeasons2.RunWorkerAsync()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory2) Then
            Dim o As New System.IO.FileInfo(dataDirectory2)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar2.Value = amount
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory3) Then
            Dim o As New System.IO.FileInfo(dataDirectory3)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar3.Value = amount
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory4) Then
            Dim o As New System.IO.FileInfo(dataDirectory4)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar4.Value = amount
        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory5) Then
            Dim o As New System.IO.FileInfo(dataDirectory5)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar5.Value = amount
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory6) Then
            Dim o As New System.IO.FileInfo(dataDirectory6)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar6.Value = amount
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Dim amount As Integer
        If System.IO.File.Exists(dataDirectory7) Then
            Dim o As New System.IO.FileInfo(dataDirectory7)
            amount = o.Length
            amount = amount / 1024
            'Label3.Text = amount
            PeProgressBar7.Value = amount
        End If
    End Sub

    Private Sub Relaod()

        Application.Restart()

    End Sub




End Class