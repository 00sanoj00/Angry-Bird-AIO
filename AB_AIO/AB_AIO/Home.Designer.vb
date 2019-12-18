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
        Me.HeavenTheme1 = New AB_AIO.HeavenTheme
        Me.HeavenTopControl1 = New AB_AIO.HeavenTopControl
        Me.HeavenTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeavenTheme1
        '
        Me.HeavenTheme1.BackColor = System.Drawing.Color.White
        Me.HeavenTheme1.Controls.Add(Me.HeavenTopControl1)
        Me.HeavenTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeavenTheme1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.HeavenTheme1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.HeavenTheme1.Location = New System.Drawing.Point(0, 0)
        Me.HeavenTheme1.Name = "HeavenTheme1"
        Me.HeavenTheme1.Resizable = True
        Me.HeavenTheme1.SecondText = "Pro"
        Me.HeavenTheme1.Size = New System.Drawing.Size(992, 721)
        Me.HeavenTheme1.TabIndex = 0
        Me.HeavenTheme1.Text = "HeavenTheme1"
        '
        'HeavenTopControl1
        '
        Me.HeavenTopControl1.BackColor = System.Drawing.Color.Transparent
        Me.HeavenTopControl1.ButtonType = AB_AIO.HeavenTopControl.BType.Close
        Me.HeavenTopControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HeavenTopControl1.Font = New System.Drawing.Font("Marlett", 8.0!)
        Me.HeavenTopControl1.Location = New System.Drawing.Point(958, 54)
        Me.HeavenTopControl1.Name = "HeavenTopControl1"
        Me.HeavenTopControl1.Size = New System.Drawing.Size(11, 11)
        Me.HeavenTopControl1.TabIndex = 0
        Me.HeavenTopControl1.Text = "HeavenTopControl1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 721)
        Me.Controls.Add(Me.HeavenTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.HeavenTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeavenTheme1 As AB_AIO.HeavenTheme
    Friend WithEvents HeavenTopControl1 As AB_AIO.HeavenTopControl

End Class
