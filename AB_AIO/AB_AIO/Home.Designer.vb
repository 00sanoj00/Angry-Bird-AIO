<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ElTheme1 = New AB_AIO.ElTheme
        Me.Button1 = New AB_AIO.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ElTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElTheme1
        '
        Me.ElTheme1.BackColor = System.Drawing.Color.White
        Me.ElTheme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ElTheme1.Controls.Add(Me.Panel1)
        Me.ElTheme1.Controls.Add(Me.Button1)
        Me.ElTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElTheme1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ElTheme1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ElTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ElTheme1.Name = "ElTheme1"
        Me.ElTheme1.Resizable = True
        Me.ElTheme1.Size = New System.Drawing.Size(992, 721)
        Me.ElTheme1.TabIndex = 0
        Me.ElTheme1.Text = "Angry-Bird-AIO"
        '
        'Button1
        '
        Me.Button1.DisabledColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.FrontColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button1.GlowColor = System.Drawing.Color.Gold
        Me.Button1.GroundColor1 = System.Drawing.Color.GreenYellow
        Me.Button1.GroundColor2 = System.Drawing.Color.Gold
        Me.Button1.GroundColor3 = System.Drawing.Color.DarkOrange
        Me.Button1.Location = New System.Drawing.Point(952, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 24)
        Me.Button1.SolidText = True
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 682)
        Me.Panel1.TabIndex = 1
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 721)
        Me.Controls.Add(Me.ElTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ElTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ElTheme1 As AB_AIO.ElTheme
    Friend WithEvents Button1 As AB_AIO.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
