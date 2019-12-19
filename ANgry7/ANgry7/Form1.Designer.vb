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
        Me.components = New System.ComponentModel.Container()
        Me.PeForm1 = New ANgry7.PEForm()
        Me.PeProgressBar1 = New ANgry7.PEProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Downloader = New System.ComponentModel.BackgroundWorker()
        Me.PeForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeForm1
        '
        Me.PeForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PeForm1.Controls.Add(Me.PeProgressBar1)
        Me.PeForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeForm1.Font = New System.Drawing.Font("Segoe UI Semibold", 35.0!)
        Me.PeForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PeForm1.Location = New System.Drawing.Point(0, 0)
        Me.PeForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.PeForm1.Name = "PeForm1"
        Me.PeForm1.Sizable = True
        Me.PeForm1.Size = New System.Drawing.Size(651, 175)
        Me.PeForm1.TabIndex = 0
        Me.PeForm1.Text = "Loading ABAIO"
        Me.PeForm1.TextGradBottomScale = 1.0R
        Me.PeForm1.TextGradTopScale = 1.0R
        Me.PeForm1.TextYOffset = 0
        '
        'PeProgressBar1
        '
        Me.PeProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PeProgressBar1.DisplayMode = ANgry7.PEProgressBar.Type.Ticked
        Me.PeProgressBar1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.PeProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PeProgressBar1.Location = New System.Drawing.Point(12, 102)
        Me.PeProgressBar1.Maximum = 100
        Me.PeProgressBar1.Minimum = 0
        Me.PeProgressBar1.MinimumSize = New System.Drawing.Size(20, 19)
        Me.PeProgressBar1.Name = "PeProgressBar1"
        Me.PeProgressBar1.Rounded = True
        Me.PeProgressBar1.Size = New System.Drawing.Size(627, 24)
        Me.PeProgressBar1.TabIndex = 0
        Me.PeProgressBar1.Text = "Loading ABAIO"
        Me.PeProgressBar1.TickStart = 2
        Me.PeProgressBar1.TickWidth = 5
        Me.PeProgressBar1.Value = 50
        '
        'Timer1
        '
        '
        'Downloader
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 175)
        Me.Controls.Add(Me.PeForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.PeForm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeForm1 As ANgry7.PEForm
    Friend WithEvents PeProgressBar1 As ANgry7.PEProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Downloader As System.ComponentModel.BackgroundWorker

End Class
