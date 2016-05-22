Imports X9Tech
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports Microsoft.Win32

Public Class Main

    Dim xcm As X9Tech.XBox.Input.XBoxControllerManager = New X9Tech.XBox.Input.XBoxControllerManager()
    Dim xc As XBox.Input.XBoxController
    Dim xcCon = False
    Dim xcEnabled = False

    Dim rovCon = False

    Dim FSThrust As Integer = 0
    Dim ASThrust As Integer = 0
    Dim APThrust As Integer = 0
    Dim FPThrust As Integer = 0

    Dim VThrust As Integer = 0
    Dim RotThrust As Integer = 0

    Dim XOffset As Integer = 0
    Dim YOffset As Integer = 0
    Dim VOffset As Integer = 0

    Dim port As Integer = 1234
    Dim ip As IPAddress = IPAddress.Loopback
    Dim client As TcpClient
    Dim clientThread As New Threading.Thread(AddressOf StartClient)

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getRegSettings()
        MaximumSize = Size
        MinimumSize = Size

        clientThread.IsBackground = True
        clientThread.Start()

    End Sub

    Private Sub MainClose() Handles Me.FormClosing
        Dim regKey As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\DigitROV")
        regKey.SetValue("mainX", Me.Location.X.ToString)
        regKey.SetValue("mainY", Me.Location.Y.ToString)
        regKey.SetValue("ip", ip.ToString)
        regKey.SetValue("port", port.ToString)
        regKey.Close()
    End Sub

    Private Sub getRegSettings()

        Dim regKey As RegistryKey
        Dim subkey As String = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\DigitROV", "Version", Nothing)

        If subkey Is Nothing Then
            regKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\DigitROV")
            regKey.SetValue("Version", "1.0")
            regKey.SetValue("mainX", Me.Location.X.ToString)
            regKey.SetValue("mainY", Me.Location.Y.ToString)
            regKey.SetValue("ip", ip.ToString)
            regKey.SetValue("port", port.ToString)
        Else
            regKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\DigitROV")
            Me.Location = New Point(Convert.ToInt32(regKey.GetValue("mainX")), Convert.ToInt32(regKey.GetValue("mainY")))
            ip = IPAddress.Parse(regKey.GetValue("ip"))
            port = Convert.ToInt32(regKey.GetValue("port"))
        End If

        regKey.Close()

    End Sub

    Private Sub connectController()

        If (xcm.GetConnectedControllers.Count > 0) And (xcCon = False) Then

            Dim controllers As List(Of XBox.Input.XBoxController) = xcm.GetConnectedControllers()
            xc = controllers.Item(0)
            xc.SnapDeadZoneTolerance = 8

            xcCon = True
            xcEnabled = True

            xboxLabel.Text = "Xbox Controller Connected & Enabled"
            xboxLabel.ForeColor = Color.Green
            xboxLabel.Font = New Font(xboxLabel.Font, FontStyle.Regular)

            xbcCheck.Enabled = True
            xbcCheck.Checked = True

        ElseIf (xcCon = True) And (xcEnabled = False) Then

            xboxLabel.Text = "Xbox Controller Connected & Disabled"
            xboxLabel.ForeColor = Color.DarkOrange
            xboxLabel.Font = New Font(xboxLabel.Font, FontStyle.Regular)

            xbcCheck.Enabled = True
            xbcCheck.Checked = False

        Else
            xcCon = False
            xcEnabled = False

            xboxLabel.Text = "Xbox Controller Disconnected"
            xboxLabel.ForeColor = Color.Red
            xboxLabel.Font = New Font(xboxLabel.Font, FontStyle.Bold)

            xbcCheck.Enabled = False
            xbcCheck.Checked = False
        End If

    End Sub

    Private Sub getInputs()

        'If (xc.ButtonBackPressed) Then xcEnabled = False
        'If (xc.ButtonStartPressed) Then xcEnabled = True

        RotThrust = (xc.ThumbRightX * 2) - 100
        VThrust = (xc.ThumbRightY * 2) - 100

        Dim increase As Double = 2

        If (xc.ButtonUpPressed) Then YOffset += increase
        If (xc.ButtonDownPressed) Then YOffset -= increase

        If (YOffset < -100) Then YOffset = -100
        If (YOffset > 100) Then YOffset = 100
        YoffsetBar.Value = YOffset * -1

        If (xc.ButtonRightPressed) Then XOffset += increase
        If (xc.ButtonLeftPressed) Then XOffset -= increase

        If (XOffset < -100) Then XOffset = -100
        If (XOffset > 100) Then XOffset = 100
        XoffsetBar.Value = XOffset

        If (xc.ButtonShoulderLeftPressed) Then VOffset -= increase
        If (xc.ButtonShoulderRightPressed) Then VOffset += increase
        VoffsetBar.Value = VOffset * -1

        If (VOffset < -100) Then VOffset = -100
        If (VOffset > 100) Then VOffset = 100


    End Sub

    Private Sub calculateThrusts()

        Dim x As Double = 0
        Dim y As Double = 0

        If (xcEnabled) Then
            x = (xc.ThumbLeftX * 2) - 100
            y = (xc.ThumbLeftY * 2) - 100
        End If

        Dim thrust As Double = Math.Sqrt(x ^ 2 + y ^ 2)

        Dim angle As Double = 90 - (180 / Math.PI) * Math.Atan2(y, x)
        If angle < 0 Then
            angle += 360
        End If

        FSThrust = joystickThrust(45, thrust, angle)
        ASThrust = joystickThrust(135, thrust, angle)
        APThrust = joystickThrust(225, thrust, angle)
        FPThrust = joystickThrust(315, thrust, angle)

        offsetXThrust()
        offsetYThrust()
        offsetRotate()

        offsetVThrust()

    End Sub

    Private Sub offsetXThrust()

        FSThrust -= XOffset
        ASThrust -= XOffset
        APThrust += XOffset
        FPThrust += XOffset

        If FSThrust > 100 Then FSThrust = 100
        If FSThrust < -100 Then FSThrust = -100

        If ASThrust > 100 Then ASThrust = 100
        If ASThrust < -100 Then ASThrust = -100

        If APThrust > 100 Then APThrust = 100
        If APThrust < -100 Then APThrust = -100

        If FPThrust > 100 Then FPThrust = 100
        If FPThrust < -100 Then FPThrust = -100

    End Sub

    Private Sub offsetYThrust()

        FSThrust += YOffset
        ASThrust -= YOffset
        APThrust -= YOffset
        FPThrust += YOffset

        If FSThrust > 100 Then FSThrust = 100
        If FSThrust < -100 Then FSThrust = -100

        If ASThrust > 100 Then ASThrust = 100
        If ASThrust < -100 Then ASThrust = -100

        If APThrust > 100 Then APThrust = 100
        If APThrust < -100 Then APThrust = -100

        If FPThrust > 100 Then FPThrust = 100
        If FPThrust < -100 Then FPThrust = -100

    End Sub

    Private Sub offsetRotate()

        FSThrust -= RotThrust
        ASThrust += RotThrust
        APThrust -= RotThrust
        FPThrust += RotThrust

        If FSthrust > 100 Then FSthrust = 100
        If FSthrust < -100 Then FSthrust = -100

        If ASthrust > 100 Then ASthrust = 100
        If ASthrust < -100 Then ASthrust = -100

        If APthrust > 100 Then APthrust = 100
        If APthrust < -100 Then APthrust = -100

        If FPthrust > 100 Then FPthrust = 100
        If FPthrust < -100 Then FPthrust = -100

    End Sub

    Private Sub offsetVThrust()

        VThrust = 0

        VThrust += VOffset
        If VThrust > 100 Then VThrust = 100
        If VThrust < -100 Then VThrust = -100

    End Sub

    Private Function joystickThrust(ByVal offsetAngle As Integer, ByVal thrust As Double, ByVal angle As Integer)

        ' y = 1.414 * cos (2*math.pi * (angle + offset) / 360)
        ' the above function create a cos wave where thrust is 1 at 0, 0 at 45degrees, -1 at 90 degrees
        ' this is multiplied by the thrust to get each thrusters value
        ' as the cos wave goes to -1.414 at 135degrees etc, we limit it to max of 1 and min of -1 

        Dim thrustScaler As Double = 1.414 * Math.Cos(2 * Math.PI * (angle + offsetAngle) / 360)

        If thrustScaler > 1 Then
            thrustScaler = 1
        End If
        If thrustScaler < -1 Then
            thrustScaler = -1
        End If

        thrust = thrust * thrustScaler
        Return thrust

    End Function

    Private Sub updateGraphics()

        If FSThrust > 0 Then
            FSpos.Value = FSThrust
            FSneg.Value = 0
        Else
            FSpos.Value = 0
            FSneg.Value = FSThrust * -1
        End If
        FSLabel.Text = "FS Thrust: " + FSThrust.ToString

        If ASThrust > 0 Then
            ASpos.Value = ASThrust
            ASneg.Value = 0
        Else
            ASpos.Value = 0
            ASneg.Value = ASThrust * -1
        End If
        ASLabel.Text = "AS Thrust: " + ASThrust.ToString

        If APThrust > 0 Then
            APpos.Value = APThrust
            APNeg.Value = 0
        Else
            APpos.Value = 0
            APNeg.Value = APThrust * -1
        End If
        APLabel.Text = "AP Thrust: " + APThrust.ToString

        If FPThrust > 0 Then
            FPpos.Value = FPThrust
            FPneg.Value = 0
        Else
            FPpos.Value = 0
            FPneg.Value = FPThrust * -1
        End If
        FPLabel.Text = "FP Thrust: " + FPThrust.ToString



        If VThrust > 0 Then
            Vpos.Value = VThrust
            Vneg.Value = 0
        Else
            Vpos.Value = 0
            Vneg.Value = VThrust * -1
        End If
        VertLabel.Text = "Vert Thrust: " + VThrust.ToString

        If RotThrust > 0 Then
            Rotpos.Value = RotThrust
            Rotneg.Value = 0
        Else
            Rotpos.Value = 0
            Rotneg.Value = RotThrust * -1
        End If
        RotationLabel.Text = "Rotation: " + RotThrust.ToString

        YoffsetLabel.Text = "Y: " + YOffset.ToString

        XoffsetLabel.Text = "X: " + XOffset.ToString

        VoffsetLabel.Text = "V: " + VOffset.ToString

    End Sub

    Private Sub updateInputGroup()

        If (xcCon) Then

            Label2.Text = Math.Round((xc.ThumbLeftX * 2) - 100, 1).ToString + ", " + Math.Round((xc.ThumbLeftY * 2) - 100, 1).ToString
            Label4.Text = Math.Round((xc.ThumbRightX * 2) - 100, 1).ToString + ", " + Math.Round((xc.ThumbRightY * 2) - 100, 1).ToString

            Label6.Text = Math.Round(xc.TriggerLeftPosition, 1).ToString
            Label8.Text = Math.Round(xc.TriggerRightPosition, 1).ToString

            Label10.Text = xc.ButtonAPressed
            Label12.Text = xc.ButtonBPressed
            Label14.Text = xc.ButtonXPressed
            Label16.Text = xc.ButtonYPressed

            Label18.Text = xc.ButtonUpPressed
            Label20.Text = xc.ButtonDownPressed
            Label22.Text = xc.ButtonLeftPressed
            Label24.Text = xc.ButtonRightPressed

            Label26.Text = xc.ThumbpadLeftPressed
            Label28.Text = xc.ThumbpadRightPressed

            Label30.Text = xc.ButtonShoulderLeftPressed
            Label32.Text = xc.ButtonShoulderRightPressed

            Label34.Text = xc.ButtonBackPressed
            Label36.Text = xc.ButtonStartPressed

        End If

    End Sub

    Private Sub StartClient()


        Do
            'Debug.WriteLine("Initialising Client..")
            Try
                client = New TcpClient(ip.ToString, port)
                rovCon = True
                'Debug.WriteLine("Connected to : " & IPAddress.Parse(CType(client.Client.LocalEndPoint, IPEndPoint).Address.ToString).ToString & " ")
                Do
                    'Debug.WriteLine("Sending test message. Client connected: " + client.Connected.ToString)
                    SendMessage(getDataString())
                    Thread.Sleep(50)
                Loop While client.Connected

            Catch ex As Exception
                rovCon = False
            End Try
            
            
        Loop

    End Sub

    Private Sub SendMessage(ByVal msg As String)
        Dim sw As IO.StreamWriter
        Try
            sw = New IO.StreamWriter(client.GetStream)
            sw.Write(msg)
            sw.Flush()
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function getDataString()
        Dim drovString = "#DROV," + FSThrust.ToString + "," + ASThrust.ToString + "," + APThrust.ToString + "," + FPThrust.ToString + "," + VThrust.ToString + ",1,1,1"
        Return drovString
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If xcm.GetConnectedControllers.Count = 0 Then
            xcCon = False
        End If

        If (xcCon) And (xcEnabled) Then
            getInputs()
            updateInputGroup()
        ElseIf (xcCon) And (xcEnabled = False) Then
            updateInputGroup()
        Else
            connectController()
        End If


        If (rovCon) Then
            RovLabel.Text = "ROV Connected"
            RovLabel.ForeColor = Color.Green
            RovLabel.Font = New Font(RovLabel.Font, FontStyle.Regular)
        Else
            RovLabel.Text = "ROV Disconnected"
            RovLabel.ForeColor = Color.Red
            RovLabel.Font = New Font(RovLabel.Font, FontStyle.Bold)
        End If


        calculateThrusts()
        updateGraphics()

        'Debug.WriteLine("IP: " + ip.ToString + ", Port: " + port.ToString)

    End Sub


    Public Sub setIP(byVal newIP As IPAddress)
        ip = newIP
    End Sub

    Public Function getIP()
        Return ip
    End Function

    Public Sub setPort(ByVal newPort As Integer)
        port = newPort
    End Sub

    Public Function getPort()
        Return port
    End Function


    Private Sub YoffsetBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles YoffsetBar.Scroll
        YOffset = YoffsetBar.Value * -1
        YoffsetLabel.Text = ("Y: " + YOffset.ToString)
    End Sub

    Private Sub XoffsetBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles XoffsetBar.Scroll

        XOffset = XoffsetBar.Value
        XoffsetLabel.Text = ("X: " + XOffset.ToString)

    End Sub

    Private Sub VoffsetBar_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VoffsetBar.Scroll

        VOffset = VoffsetBar.Value * -1
        VoffsetLabel.Text = ("V: " + VOffset.ToString)

    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub menuInputs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInputs.Click
        If menuInputs.Checked Then
            MaximumSize = New System.Drawing.Size(850, 300)
            MinimumSize = New System.Drawing.Size(850, 300)
            Width = 810
        Else
            MaximumSize = New System.Drawing.Size(520, 300)
            MinimumSize = New System.Drawing.Size(520, 300)
            Width = 515
        End If
    End Sub

    Private Sub xbcCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xbcCheck.CheckedChanged
        If xbcCheck.Checked = True Then
            xcEnabled = True
        Else
            xcEnabled = False
        End If

    End Sub

    Private Sub NetworkSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkSettingsToolStripMenuItem.Click
        If NetworkSettings.Visible = False Then
            NetworkSettings.Show()
        End If
    End Sub
End Class
