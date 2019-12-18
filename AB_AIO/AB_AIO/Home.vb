Public Class Home
    Dim dataDirectory As String = String.Format("{0}\Wallpeper\w.jpg", Environment.CurrentDirectory)
    Private Sub Home_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Panel1.BackgroundImage = Image.FromFile(dataDirectory)
    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        'or you can use 

        Me.CenterToParent()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
        Form1.Close()

    End Sub

    Private Sub HeavenTopControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeavenTopControl1.Click
        End
        Form1.Close()

    End Sub
End Class