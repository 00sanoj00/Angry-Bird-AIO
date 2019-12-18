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
        Me.BaWGUIThemeContainer1 = New AB_AIO.BaWGUIThemeContainer
        Me.SuspendLayout()
        '
        'BaWGUIThemeContainer1
        '
        Me.BaWGUIThemeContainer1.BackColor = System.Drawing.Color.White
        Me.BaWGUIThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaWGUIThemeContainer1.DrawButtonStrings = True
        Me.BaWGUIThemeContainer1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BaWGUIThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.BaWGUIThemeContainer1.Name = "BaWGUIThemeContainer1"
        Me.BaWGUIThemeContainer1.Size = New System.Drawing.Size(992, 721)
        Me.BaWGUIThemeContainer1.TabIndex = 0
        Me.BaWGUIThemeContainer1.Text = "BaWGUIThemeContainer1"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 721)
        Me.Controls.Add(Me.BaWGUIThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaWGUIThemeContainer1 As AB_AIO.BaWGUIThemeContainer

End Class
