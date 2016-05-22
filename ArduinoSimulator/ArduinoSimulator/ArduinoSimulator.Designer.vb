<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArduinoSimulator
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
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.DataLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(12, 9)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(70, 13)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Not Initiated.."
        '
        'DataLabel
        '
        Me.DataLabel.AutoSize = True
        Me.DataLabel.Location = New System.Drawing.Point(12, 27)
        Me.DataLabel.Name = "DataLabel"
        Me.DataLabel.Size = New System.Drawing.Size(129, 13)
        Me.DataLabel.TabIndex = 1
        Me.DataLabel.Text = "Waiting for Data Stream..."
        '
        'ArduinoSimulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 49)
        Me.Controls.Add(Me.DataLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.MaximizeBox = False
        Me.Name = "ArduinoSimulator"
        Me.Text = "ArduinoSimulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents DataLabel As System.Windows.Forms.Label

End Class
