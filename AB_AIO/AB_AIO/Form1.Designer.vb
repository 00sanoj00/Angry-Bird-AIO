<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Downloader = New System.ComponentModel.BackgroundWorker
        Me.FormSkin1 = New AB_AIO.FormSkin
        Me.ProgressBar1 = New AB_AIO.ProgressBar
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Downloader
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.Color1 = System.Drawing.Color.DarkOrange
        Me.FormSkin1.Color2 = System.Drawing.Color.Gold
        Me.FormSkin1.Color3 = System.Drawing.Color.GreenYellow
        Me.FormSkin1.Controls.Add(Me.ProgressBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormSkin1.ForeColor = System.Drawing.Color.Gray
        Me.FormSkin1.HeaderSize = 38
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.MoveHeight = 38
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Resizable = True
        Me.FormSkin1.Size = New System.Drawing.Size(610, 104)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "FormSkin1"
        Me.FormSkin1.TextOffset = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Angle = 0
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.BarColor1 = System.Drawing.Color.DarkOrange
        Me.ProgressBar1.BarColor2 = System.Drawing.Color.Yellow
        Me.ProgressBar1.BarColor3 = System.Drawing.Color.GreenYellow
        Me.ProgressBar1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Gray
        Me.ProgressBar1.GlowColor = System.Drawing.Color.Gold
        Me.ProgressBar1.GlowEnabled = True
        Me.ProgressBar1.GroundColor = System.Drawing.Color.Silver
        Me.ProgressBar1.LinesColor = System.Drawing.Color.Black
        Me.ProgressBar1.LinesEnabled = True
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 53)
        Me.ProgressBar1.MaxValue = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(586, 30)
        Me.ProgressBar1.Symbol = "%"
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Text = "ProgressBar1"
        Me.ProgressBar1.TextVisible = True
        Me.ProgressBar1.Thickness = 20
        Me.ProgressBar1.Value = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 104)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Loading AB-AIO"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Downloader As System.ComponentModel.BackgroundWorker
    Friend WithEvents FormSkin1 As AB_AIO.FormSkin
    Friend WithEvents ProgressBar1 As AB_AIO.ProgressBar

End Class
