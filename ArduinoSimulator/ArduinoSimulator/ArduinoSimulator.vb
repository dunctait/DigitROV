Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports Microsoft.Win32

Public Class ArduinoSimulator

    Dim running As Boolean = False
    Dim serverThread As New Threading.Thread(AddressOf startserver)
    Dim server As TcpListener = New TcpListener(IPAddress.Loopback, 1234)
    Dim client As TcpClient

    Private Sub startserver()

        Try
            updateStatus("Initialising Server..")
            server.Start()
            updateStatus("Server Started")

            Do
                If server.Pending Then accept(server.AcceptTcpClient)
                Thread.Sleep(500)
            Loop

        Catch ex As Exception
        End Try

    End Sub

    Private Sub accept(ByVal client As TcpClient)

        updateStatus("Client Connected")

        Dim netStream As NetworkStream = client.GetStream()

        While (IsConnected(client))
            Try

                Dim bytes(client.ReceiveBufferSize) As Byte
                netStream.Read(bytes, 0, CInt(client.ReceiveBufferSize))
                Dim returndata As String = System.Text.Encoding.ASCII.GetString(bytes)

                Dim time As String = DateTime.Now.ToString()

                Debug.WriteLine("," + returndata + ",")

                If (returndata <> "") Then
                    updateDataLabel("Data Received at " + time + " - " + returndata)
                End If

            Catch ex As Exception
            End Try


        End While

        client.Close()
        updateStatus("Client Disconnected, awaiting new connection...")

    End Sub

    Private Function IsConnected(ByVal client As TcpClient)


        'This is how you can determine whether a socket is still connected.
        Try

            Dim netStream As NetworkStream = client.GetStream()

            Dim bytes(client.ReceiveBufferSize) As Byte

            netStream.Read(bytes, 0, CInt(client.ReceiveBufferSize))

            'updateStatus("Still Connected")

            If client.Connected Then
                Return True
            Else
                updateStatus("Disconnected")
                Return False
            End If

        Catch ex As Exception

            updateStatus("Disconnected")
            Return False

        End Try
    End Function


    Delegate Sub UpdateStatusCallback(ByVal status As String)

    Private Sub updateStatus(ByVal status As String)

        Try

            If Me.InvokeRequired Then
                Dim d As New UpdateStatusCallback(AddressOf updateStatus)
                Me.Invoke(d, New Object() {status})
            Else
                StatusLabel.Text = status
            End If

        Catch ex As Exception

        End Try

    End Sub

    Delegate Sub UpdateDataLabelCallback(ByVal status As String)

    Private Sub updateDataLabel(ByVal data As String)

        Try

            If Me.InvokeRequired Then
                Dim d As New UpdateStatusCallback(AddressOf updateDataLabel)
                Me.Invoke(d, New Object() {data})
            Else
                DataLabel.Text = data
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub arduinoSimulator_open() Handles Me.Load
        running = True

        regSettings()
        MaximumSize = Size
        MinimumSize = Size

        Dim serverThread As New Threading.Thread(AddressOf startserver)
        serverThread.IsBackground = True
        serverThread.Start()
    End Sub

    Private Sub ArduinoSimulator_close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        running = False
        Try
            serverThread.Abort()
            server.Stop()
        Catch ex As Exception
        End Try

        Dim regKey As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\ArduinoSimulator")
        regKey.SetValue("mainX", Me.Location.X.ToString)
        regKey.SetValue("mainY", Me.Location.Y.ToString)
        regKey.Close()

    End Sub

    Private Sub regSettings()

        Dim regKey As RegistryKey
        Dim subkey As String = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\ArduinoSimulator", "Version", Nothing)

        If subkey Is Nothing Then
            regKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\ArduinoSimulator")
            regKey.SetValue("Version", "1.0")
            regKey.SetValue("mainX", Me.Location.X.ToString)
            regKey.SetValue("mainY", Me.Location.Y.ToString)
        Else
            regKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\ArduinoSimulator")
            Me.Location = New Point(Convert.ToInt32(regKey.GetValue("mainX")), Convert.ToInt32(regKey.GetValue("mainY")))
        End If

        regKey.Close()

    End Sub

End Class
