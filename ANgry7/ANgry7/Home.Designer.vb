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
        Me.PeForm1 = New ANgry7.PEForm()
        Me.SuspendLayout()
        '
        'PeForm1
        '
        Me.PeForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PeForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeForm1.Font = New System.Drawing.Font("Segoe UI Semibold", 35.0!)
        Me.PeForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PeForm1.Location = New System.Drawing.Point(0, 0)
        Me.PeForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.PeForm1.Name = "PeForm1"
        Me.PeForm1.Sizable = True
        Me.PeForm1.Size = New System.Drawing.Size(768, 529)
        Me.PeForm1.TabIndex = 0
        Me.PeForm1.Text = "Angry Birds All in One"
        Me.PeForm1.TextGradBottomScale = 1.0R
        Me.PeForm1.TextGradTopScale = 1.0R
        Me.PeForm1.TextYOffset = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 529)
        Me.Controls.Add(Me.PeForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeForm1 As ANgry7.PEForm
End Class
