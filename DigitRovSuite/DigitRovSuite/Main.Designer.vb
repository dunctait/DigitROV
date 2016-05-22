<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.xboxLabel = New System.Windows.Forms.Label
        Me.inputGroup = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.FSneg = New System.Windows.Forms.ProgressBar
        Me.FSpos = New System.Windows.Forms.ProgressBar
        Me.FSLabel = New System.Windows.Forms.Label
        Me.FPLabel = New System.Windows.Forms.Label
        Me.FPpos = New System.Windows.Forms.ProgressBar
        Me.FPneg = New System.Windows.Forms.ProgressBar
        Me.APLabel = New System.Windows.Forms.Label
        Me.APpos = New System.Windows.Forms.ProgressBar
        Me.APNeg = New System.Windows.Forms.ProgressBar
        Me.ASLabel = New System.Windows.Forms.Label
        Me.ASpos = New System.Windows.Forms.ProgressBar
        Me.ASneg = New System.Windows.Forms.ProgressBar
        Me.VertLabel = New System.Windows.Forms.Label
        Me.Vpos = New System.Windows.Forms.ProgressBar
        Me.Vneg = New System.Windows.Forms.ProgressBar
        Me.YoffsetBar = New System.Windows.Forms.VScrollBar
        Me.XoffsetBar = New System.Windows.Forms.HScrollBar
        Me.RotationLabel = New System.Windows.Forms.Label
        Me.Rotpos = New System.Windows.Forms.ProgressBar
        Me.Rotneg = New System.Windows.Forms.ProgressBar
        Me.Label37 = New System.Windows.Forms.Label
        Me.VoffsetBar = New System.Windows.Forms.VScrollBar
        Me.YoffsetLabel = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NetworkSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuInputs = New System.Windows.Forms.ToolStripMenuItem
        Me.XoffsetLabel = New System.Windows.Forms.Label
        Me.VoffsetLabel = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.xbcCheck = New System.Windows.Forms.CheckBox
        Me.RovLabel = New System.Windows.Forms.Label
        Me.inputGroup.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'xboxLabel
        '
        Me.xboxLabel.AutoSize = True
        Me.xboxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xboxLabel.ForeColor = System.Drawing.Color.Red
        Me.xboxLabel.Location = New System.Drawing.Point(32, 239)
        Me.xboxLabel.Name = "xboxLabel"
        Me.xboxLabel.Size = New System.Drawing.Size(147, 13)
        Me.xboxLabel.TabIndex = 0
        Me.xboxLabel.Text = "Xbox Controller Disconnected"
        '
        'inputGroup
        '
        Me.inputGroup.Controls.Add(Me.TableLayoutPanel1)
        Me.inputGroup.Location = New System.Drawing.Point(504, 28)
        Me.inputGroup.Name = "inputGroup"
        Me.inputGroup.Size = New System.Drawing.Size(316, 220)
        Me.inputGroup.TabIndex = 1
        Me.inputGroup.TabStop = False
        Me.inputGroup.Text = "Controller Inputs"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label26, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label28, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label34, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label36, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label27, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label33, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label35, 2, 9)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(301, 196)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Y Button"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(80, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "False"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "X Button"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(80, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "False"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "B Button"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "False"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "A Button"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Right Trigger"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Left Trigger"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0, 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Right Stick X,Y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0, 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Left Stick X,Y"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(157, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "D-Pad Up"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(251, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "False"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(157, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "D-Pad Down"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(80, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "False"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(251, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "False"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(251, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "False"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(251, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "False"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(251, 80)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "False"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(251, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 13)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "False"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(251, 120)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "False"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(251, 140)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 13)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = "False"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(251, 160)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(32, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "False"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(251, 180)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(32, 13)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "False"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(157, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "D-Pad Left"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(157, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "D-Pad Right"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(157, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "L3"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(157, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(21, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "R3"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(157, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 13)
        Me.Label29.TabIndex = 32
        Me.Label29.Text = "Left Bumper"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(157, 140)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 13)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "Right Bumper"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(157, 160)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(32, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Back"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(157, 180)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(29, 13)
        Me.Label35.TabIndex = 38
        Me.Label35.Text = "Start"
        '
        'FSneg
        '
        Me.FSneg.Location = New System.Drawing.Point(162, 53)
        Me.FSneg.Name = "FSneg"
        Me.FSneg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FSneg.RightToLeftLayout = True
        Me.FSneg.Size = New System.Drawing.Size(50, 23)
        Me.FSneg.TabIndex = 2
        '
        'FSpos
        '
        Me.FSpos.Location = New System.Drawing.Point(211, 53)
        Me.FSpos.Name = "FSpos"
        Me.FSpos.Size = New System.Drawing.Size(50, 23)
        Me.FSpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.FSpos.TabIndex = 3
        Me.FSpos.Tag = ""
        '
        'FSLabel
        '
        Me.FSLabel.AutoSize = True
        Me.FSLabel.Location = New System.Drawing.Point(179, 80)
        Me.FSLabel.Name = "FSLabel"
        Me.FSLabel.Size = New System.Drawing.Size(65, 13)
        Me.FSLabel.TabIndex = 4
        Me.FSLabel.Text = "FS Thrust: 0"
        '
        'FPLabel
        '
        Me.FPLabel.AutoSize = True
        Me.FPLabel.Location = New System.Drawing.Point(41, 80)
        Me.FPLabel.Name = "FPLabel"
        Me.FPLabel.Size = New System.Drawing.Size(65, 13)
        Me.FPLabel.TabIndex = 7
        Me.FPLabel.Text = "FP Thrust: 0"
        '
        'FPpos
        '
        Me.FPpos.Location = New System.Drawing.Point(73, 53)
        Me.FPpos.Name = "FPpos"
        Me.FPpos.Size = New System.Drawing.Size(50, 23)
        Me.FPpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.FPpos.TabIndex = 6
        Me.FPpos.Tag = ""
        '
        'FPneg
        '
        Me.FPneg.Location = New System.Drawing.Point(24, 53)
        Me.FPneg.Name = "FPneg"
        Me.FPneg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FPneg.RightToLeftLayout = True
        Me.FPneg.Size = New System.Drawing.Size(50, 23)
        Me.FPneg.TabIndex = 5
        '
        'APLabel
        '
        Me.APLabel.AutoSize = True
        Me.APLabel.Location = New System.Drawing.Point(41, 182)
        Me.APLabel.Name = "APLabel"
        Me.APLabel.Size = New System.Drawing.Size(66, 13)
        Me.APLabel.TabIndex = 10
        Me.APLabel.Text = "AP Thrust: 0"
        '
        'APpos
        '
        Me.APpos.Location = New System.Drawing.Point(73, 155)
        Me.APpos.Name = "APpos"
        Me.APpos.Size = New System.Drawing.Size(50, 23)
        Me.APpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.APpos.TabIndex = 9
        Me.APpos.Tag = ""
        '
        'APNeg
        '
        Me.APNeg.Location = New System.Drawing.Point(24, 155)
        Me.APNeg.Name = "APNeg"
        Me.APNeg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.APNeg.RightToLeftLayout = True
        Me.APNeg.Size = New System.Drawing.Size(50, 23)
        Me.APNeg.TabIndex = 8
        '
        'ASLabel
        '
        Me.ASLabel.AutoSize = True
        Me.ASLabel.Location = New System.Drawing.Point(179, 182)
        Me.ASLabel.Name = "ASLabel"
        Me.ASLabel.Size = New System.Drawing.Size(66, 13)
        Me.ASLabel.TabIndex = 13
        Me.ASLabel.Text = "AS Thrust: 0"
        '
        'ASpos
        '
        Me.ASpos.Location = New System.Drawing.Point(211, 155)
        Me.ASpos.Name = "ASpos"
        Me.ASpos.Size = New System.Drawing.Size(50, 23)
        Me.ASpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ASpos.TabIndex = 12
        Me.ASpos.Tag = ""
        '
        'ASneg
        '
        Me.ASneg.Location = New System.Drawing.Point(162, 155)
        Me.ASneg.Name = "ASneg"
        Me.ASneg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ASneg.RightToLeftLayout = True
        Me.ASneg.Size = New System.Drawing.Size(50, 23)
        Me.ASneg.TabIndex = 11
        '
        'VertLabel
        '
        Me.VertLabel.AutoSize = True
        Me.VertLabel.Location = New System.Drawing.Point(108, 132)
        Me.VertLabel.Name = "VertLabel"
        Me.VertLabel.Size = New System.Drawing.Size(71, 13)
        Me.VertLabel.TabIndex = 16
        Me.VertLabel.Text = "Vert Thrust: 0"
        '
        'Vpos
        '
        Me.Vpos.Location = New System.Drawing.Point(143, 105)
        Me.Vpos.Name = "Vpos"
        Me.Vpos.Size = New System.Drawing.Size(50, 23)
        Me.Vpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Vpos.TabIndex = 15
        Me.Vpos.Tag = ""
        '
        'Vneg
        '
        Me.Vneg.Location = New System.Drawing.Point(94, 105)
        Me.Vneg.Name = "Vneg"
        Me.Vneg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Vneg.RightToLeftLayout = True
        Me.Vneg.Size = New System.Drawing.Size(50, 23)
        Me.Vneg.TabIndex = 14
        '
        'YoffsetBar
        '
        Me.YoffsetBar.Location = New System.Drawing.Point(316, 51)
        Me.YoffsetBar.Maximum = 109
        Me.YoffsetBar.Minimum = -100
        Me.YoffsetBar.Name = "YoffsetBar"
        Me.YoffsetBar.Size = New System.Drawing.Size(20, 100)
        Me.YoffsetBar.TabIndex = 17
        '
        'XoffsetBar
        '
        Me.XoffsetBar.Location = New System.Drawing.Point(335, 151)
        Me.XoffsetBar.Maximum = 109
        Me.XoffsetBar.Minimum = -100
        Me.XoffsetBar.Name = "XoffsetBar"
        Me.XoffsetBar.Size = New System.Drawing.Size(100, 20)
        Me.XoffsetBar.TabIndex = 18
        '
        'RotationLabel
        '
        Me.RotationLabel.AutoSize = True
        Me.RotationLabel.Location = New System.Drawing.Point(352, 228)
        Me.RotationLabel.Name = "RotationLabel"
        Me.RotationLabel.Size = New System.Drawing.Size(59, 13)
        Me.RotationLabel.TabIndex = 21
        Me.RotationLabel.Text = "Rotation: 0"
        '
        'Rotpos
        '
        Me.Rotpos.Location = New System.Drawing.Point(384, 201)
        Me.Rotpos.Name = "Rotpos"
        Me.Rotpos.Size = New System.Drawing.Size(50, 23)
        Me.Rotpos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Rotpos.TabIndex = 20
        Me.Rotpos.Tag = ""
        '
        'Rotneg
        '
        Me.Rotneg.Location = New System.Drawing.Point(335, 201)
        Me.Rotneg.Name = "Rotneg"
        Me.Rotneg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Rotneg.RightToLeftLayout = True
        Me.Rotneg.Size = New System.Drawing.Size(50, 23)
        Me.Rotneg.TabIndex = 19
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(366, 98)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(40, 13)
        Me.Label37.TabIndex = 22
        Me.Label37.Text = "Offsets"
        '
        'VoffsetBar
        '
        Me.VoffsetBar.Location = New System.Drawing.Point(436, 51)
        Me.VoffsetBar.Maximum = 109
        Me.VoffsetBar.Minimum = -100
        Me.VoffsetBar.Name = "VoffsetBar"
        Me.VoffsetBar.Size = New System.Drawing.Size(20, 100)
        Me.VoffsetBar.TabIndex = 23
        '
        'YoffsetLabel
        '
        Me.YoffsetLabel.AutoSize = True
        Me.YoffsetLabel.Location = New System.Drawing.Point(273, 96)
        Me.YoffsetLabel.Name = "YoffsetLabel"
        Me.YoffsetLabel.Size = New System.Drawing.Size(26, 13)
        Me.YoffsetLabel.TabIndex = 24
        Me.YoffsetLabel.Text = "Y: 0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetworkSettingsToolStripMenuItem, Me.menuInputs})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'NetworkSettingsToolStripMenuItem
        '
        Me.NetworkSettingsToolStripMenuItem.Name = "NetworkSettingsToolStripMenuItem"
        Me.NetworkSettingsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NetworkSettingsToolStripMenuItem.Text = "Network Settings"
        '
        'menuInputs
        '
        Me.menuInputs.Checked = True
        Me.menuInputs.CheckOnClick = True
        Me.menuInputs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuInputs.Name = "menuInputs"
        Me.menuInputs.Size = New System.Drawing.Size(164, 22)
        Me.menuInputs.Text = "Controller Inputs"
        '
        'XoffsetLabel
        '
        Me.XoffsetLabel.AutoSize = True
        Me.XoffsetLabel.Location = New System.Drawing.Point(366, 175)
        Me.XoffsetLabel.Name = "XoffsetLabel"
        Me.XoffsetLabel.Size = New System.Drawing.Size(26, 13)
        Me.XoffsetLabel.TabIndex = 26
        Me.XoffsetLabel.Text = "X: 0"
        '
        'VoffsetLabel
        '
        Me.VoffsetLabel.AutoSize = True
        Me.VoffsetLabel.Location = New System.Drawing.Point(458, 96)
        Me.VoffsetLabel.Name = "VoffsetLabel"
        Me.VoffsetLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VoffsetLabel.Size = New System.Drawing.Size(26, 13)
        Me.VoffsetLabel.TabIndex = 27
        Me.VoffsetLabel.Text = "V: 0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'xbcCheck
        '
        Me.xbcCheck.AutoSize = True
        Me.xbcCheck.Enabled = False
        Me.xbcCheck.Location = New System.Drawing.Point(14, 238)
        Me.xbcCheck.Name = "xbcCheck"
        Me.xbcCheck.Size = New System.Drawing.Size(15, 14)
        Me.xbcCheck.TabIndex = 28
        Me.xbcCheck.UseVisualStyleBackColor = True
        '
        'RovLabel
        '
        Me.RovLabel.AutoSize = True
        Me.RovLabel.ForeColor = System.Drawing.Color.Red
        Me.RovLabel.Location = New System.Drawing.Point(11, 217)
        Me.RovLabel.Name = "RovLabel"
        Me.RovLabel.Size = New System.Drawing.Size(99, 13)
        Me.RovLabel.TabIndex = 29
        Me.RovLabel.Text = "ROV Disconnected"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 262)
        Me.Controls.Add(Me.RovLabel)
        Me.Controls.Add(Me.xbcCheck)
        Me.Controls.Add(Me.VoffsetLabel)
        Me.Controls.Add(Me.XoffsetLabel)
        Me.Controls.Add(Me.YoffsetLabel)
        Me.Controls.Add(Me.VoffsetBar)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.RotationLabel)
        Me.Controls.Add(Me.Rotpos)
        Me.Controls.Add(Me.Rotneg)
        Me.Controls.Add(Me.XoffsetBar)
        Me.Controls.Add(Me.YoffsetBar)
        Me.Controls.Add(Me.VertLabel)
        Me.Controls.Add(Me.Vpos)
        Me.Controls.Add(Me.Vneg)
        Me.Controls.Add(Me.ASLabel)
        Me.Controls.Add(Me.ASpos)
        Me.Controls.Add(Me.ASneg)
        Me.Controls.Add(Me.APLabel)
        Me.Controls.Add(Me.APpos)
        Me.Controls.Add(Me.APNeg)
        Me.Controls.Add(Me.FPLabel)
        Me.Controls.Add(Me.FPpos)
        Me.Controls.Add(Me.FPneg)
        Me.Controls.Add(Me.FSLabel)
        Me.Controls.Add(Me.FSpos)
        Me.Controls.Add(Me.FSneg)
        Me.Controls.Add(Me.inputGroup)
        Me.Controls.Add(Me.xboxLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Tag = ""
        Me.Text = "Digit ROV Suite"
        Me.inputGroup.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xboxLabel As System.Windows.Forms.Label
    Friend WithEvents inputGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FSneg As System.Windows.Forms.ProgressBar
    Friend WithEvents FSpos As System.Windows.Forms.ProgressBar
    Friend WithEvents FSLabel As System.Windows.Forms.Label
    Friend WithEvents FPLabel As System.Windows.Forms.Label
    Friend WithEvents FPpos As System.Windows.Forms.ProgressBar
    Friend WithEvents FPneg As System.Windows.Forms.ProgressBar
    Friend WithEvents APLabel As System.Windows.Forms.Label
    Friend WithEvents APpos As System.Windows.Forms.ProgressBar
    Friend WithEvents APNeg As System.Windows.Forms.ProgressBar
    Friend WithEvents ASLabel As System.Windows.Forms.Label
    Friend WithEvents ASpos As System.Windows.Forms.ProgressBar
    Friend WithEvents ASneg As System.Windows.Forms.ProgressBar
    Friend WithEvents VertLabel As System.Windows.Forms.Label
    Friend WithEvents Vpos As System.Windows.Forms.ProgressBar
    Friend WithEvents Vneg As System.Windows.Forms.ProgressBar
    Friend WithEvents YoffsetBar As System.Windows.Forms.VScrollBar
    Friend WithEvents XoffsetBar As System.Windows.Forms.HScrollBar
    Friend WithEvents RotationLabel As System.Windows.Forms.Label
    Friend WithEvents Rotpos As System.Windows.Forms.ProgressBar
    Friend WithEvents Rotneg As System.Windows.Forms.ProgressBar
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents VoffsetBar As System.Windows.Forms.VScrollBar
    Friend WithEvents YoffsetLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XoffsetLabel As System.Windows.Forms.Label
    Friend WithEvents VoffsetLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuInputs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xbcCheck As System.Windows.Forms.CheckBox
    Friend WithEvents RovLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
