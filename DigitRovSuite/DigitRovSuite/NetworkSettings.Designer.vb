<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkSettings
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ipBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.portBox = New System.Windows.Forms.TextBox
        Me.ipBox2 = New System.Windows.Forms.TextBox
        Me.ipBox3 = New System.Windows.Forms.TextBox
        Me.ipBox4 = New System.Windows.Forms.TextBox
        Me.networkSaveButton = New System.Windows.Forms.Button
        Me.networkCancelButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP Address"
        '
        'ipBox1
        '
        Me.ipBox1.Location = New System.Drawing.Point(76, 6)
        Me.ipBox1.Name = "ipBox1"
        Me.ipBox1.Size = New System.Drawing.Size(28, 20)
        Me.ipBox1.TabIndex = 1
        Me.ipBox1.Text = "111"
        Me.ipBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Port"
        '
        'portBox
        '
        Me.portBox.Location = New System.Drawing.Point(249, 6)
        Me.portBox.Name = "portBox"
        Me.portBox.Size = New System.Drawing.Size(47, 20)
        Me.portBox.TabIndex = 7
        Me.portBox.Text = "88888"
        '
        'ipBox2
        '
        Me.ipBox2.Location = New System.Drawing.Point(110, 6)
        Me.ipBox2.Name = "ipBox2"
        Me.ipBox2.Size = New System.Drawing.Size(28, 20)
        Me.ipBox2.TabIndex = 3
        Me.ipBox2.Text = "888"
        Me.ipBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ipBox3
        '
        Me.ipBox3.Location = New System.Drawing.Point(144, 6)
        Me.ipBox3.Name = "ipBox3"
        Me.ipBox3.Size = New System.Drawing.Size(28, 20)
        Me.ipBox3.TabIndex = 4
        Me.ipBox3.Text = "888"
        Me.ipBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ipBox4
        '
        Me.ipBox4.Location = New System.Drawing.Point(178, 6)
        Me.ipBox4.Name = "ipBox4"
        Me.ipBox4.Size = New System.Drawing.Size(28, 20)
        Me.ipBox4.TabIndex = 5
        Me.ipBox4.Text = "888"
        Me.ipBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'networkSaveButton
        '
        Me.networkSaveButton.Location = New System.Drawing.Point(144, 41)
        Me.networkSaveButton.Name = "networkSaveButton"
        Me.networkSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.networkSaveButton.TabIndex = 8
        Me.networkSaveButton.Text = "Save"
        Me.networkSaveButton.UseVisualStyleBackColor = True
        '
        'networkCancelButton
        '
        Me.networkCancelButton.Location = New System.Drawing.Point(225, 41)
        Me.networkCancelButton.Name = "networkCancelButton"
        Me.networkCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.networkCancelButton.TabIndex = 9
        Me.networkCancelButton.Text = "Cancel"
        Me.networkCancelButton.UseVisualStyleBackColor = True
        '
        'NetworkSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 71)
        Me.Controls.Add(Me.networkCancelButton)
        Me.Controls.Add(Me.networkSaveButton)
        Me.Controls.Add(Me.ipBox4)
        Me.Controls.Add(Me.ipBox3)
        Me.Controls.Add(Me.ipBox2)
        Me.Controls.Add(Me.portBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ipBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "NetworkSettings"
        Me.Text = "Network Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ipBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents portBox As System.Windows.Forms.TextBox
    Friend WithEvents ipBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ipBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ipBox4 As System.Windows.Forms.TextBox
    Friend WithEvents networkSaveButton As System.Windows.Forms.Button
    Friend WithEvents networkCancelButton As System.Windows.Forms.Button
End Class
