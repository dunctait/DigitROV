Imports System.Net

Public Class NetworkSettings

    Dim ip As IPAddress
    Dim port As Integer

    Private Sub NetworkSettingsLoad() Handles Me.Load

        MaximumSize = Size
        MinimumSize = Size

        ip = Main.getIP
        port = Main.getPort

        Dim ipbytes As Byte() = ip.GetAddressBytes

        ipBox1.Text = ipbytes(0).ToString
        ipBox2.Text = ipbytes(1).ToString
        ipBox3.Text = ipbytes(2).ToString
        ipBox4.Text = ipbytes(3).ToString

        portBox.Text = port.ToString
        'Convert.ToInt32

    End Sub

    Private Sub saveSettings()

        Dim ipbytes As Byte() = New Byte() {Convert.ToByte(ipBox1.Text), Convert.ToByte(ipBox2.Text), Convert.ToByte(ipBox3.Text), Convert.ToByte(ipBox4.Text)}
        Dim newIP As IPAddress = New IPAddress(ipbytes)
        Main.setIP(newIP)

        Main.setPort(Convert.ToInt32(portBox.Text))
        MsgBox("Restart program to apply settings.")
        Main.Close()
        Me.Close()

    End Sub



    Private Sub networkSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles networkSaveButton.Click
        If (ipBox1.Text <> "" And ipBox2.Text <> "" And ipBox3.Text <> "" And ipBox4.Text <> "" And portBox.Text <> "") Then
            saveSettings()
            Me.Close()
        Else
            MsgBox("Please do not leave empty values")
        End If

    End Sub

    Private Sub networkCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles networkCancelButton.Click
        Me.Close()
    End Sub

    Private Sub ipBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipBox1.TextChanged
        Try
            If (ipBox1.Text <> "") Then
                If (Convert.ToInt32(ipBox1.Text) < 0 Or Convert.ToInt32(ipBox1.Text) > 255) Then
                    ipBox1.Text = ""
                End If
            End If
        Catch ex As Exception
            ipBox1.Text = ""
        End Try

    End Sub

    Private Sub ipBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipBox2.TextChanged
        Try
            If (ipBox2.Text <> "") Then
                If (Convert.ToInt32(ipBox2.Text) < 0 Or Convert.ToInt32(ipBox2.Text) > 255) Then
                    ipBox2.Text = ""
                End If
            End If
        Catch ex As Exception
            ipBox2.Text = ""
        End Try

    End Sub

    Private Sub ipBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipBox3.TextChanged
        Try
            If (ipBox3.Text <> "") Then
                If (Convert.ToInt32(ipBox3.Text) < 0 Or Convert.ToInt32(ipBox3.Text) > 255) Then
                    ipBox3.Text = ""
                End If
            End If
        Catch ex As Exception
            ipBox3.Text = ""
        End Try

    End Sub

    Private Sub ipBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ipBox4.TextChanged
        Try
            If (ipBox4.Text <> "") Then
                If (Convert.ToInt32(ipBox4.Text) < 0 Or Convert.ToInt32(ipBox4.Text) > 255) Then
                    ipBox4.Text = ""
                End If
            End If
        Catch ex As Exception
            ipBox4.Text = ""
        End Try

    End Sub

    Private Sub portBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles portBox.TextChanged
        Try
            If (portBox.Text <> "") Then
                If (Convert.ToInt32(portBox.Text) < 1 Or Convert.ToInt32(portBox.Text) > 65536) Then
                    portBox.Text = ""
                End If
            End If
        Catch ex As Exception
            portBox.Text = ""
        End Try

    End Sub
End Class