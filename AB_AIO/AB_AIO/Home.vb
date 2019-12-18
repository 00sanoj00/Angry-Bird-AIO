Public Class Home

    Private Sub Home_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        'or you can use 

        Me.CenterToParent()
    End Sub

    Private Sub ElTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElTheme1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
        Form1.Close()

    End Sub
End Class