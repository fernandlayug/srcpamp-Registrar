

Imports System.IO
Imports System.Net.Sockets
Public Class intranetmessage
    Dim listerner As New TcpListener(44444)
    Dim client As TcpClient
    Dim message As String = ""
    Dim tts

    Private Sub intranetmessage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        listerner.Stop()
    End Sub

    Private Sub intranetmessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Main.loguser.Text
        listerner.Start()
        Timer1.Enabled = True
        Timer1.Start()

        TextBox4.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If listerner.Pending = True Then
                message = ""
                client = listerner.AcceptTcpClient
                Dim reader As New StreamReader(client.GetStream())
                While reader.Peek > -1
                    message = message + Convert.ToChar(reader.Read()).ToString
                End While
                Me.Focus()
                TextBox4.Text = (TextBox4.Text + message + vbCrLf)
                tts = CreateObject("sapi.spvoice")
                tts.speak(message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("Sorry Uncomplete data")
            Else
                client = New TcpClient(TextBox2.Text, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write(TextBox1.Text + "   says:" + TextBox3.Text)
                writer.Flush()
                TextBox3.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class