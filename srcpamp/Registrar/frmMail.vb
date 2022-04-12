Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmMail
    Public studentname As String
    Public studentId As String
    Dim MISusername As String
    Dim MISpassword As String

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            ProgressBar1.Value = 10
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(MISusername, MISpassword)
            ProgressBar1.Value = 20
            Smtp_Server.Port = 587
            Smtp_Server.Host = "smtp.office365.com"
            ProgressBar1.Value = 30
            Smtp_Server.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
            Smtp_Server.EnableSsl = True

            ProgressBar1.Value = 40
            Smtp_Server.Timeout = 600000

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtFrom.Text)
            ProgressBar1.Value = 50
            e_mail.To.Add(txtTo.Text)
            ProgressBar1.Value = 60
            e_mail.Subject = txtSubject.Text
            ProgressBar1.Value = 70
            e_mail.IsBodyHtml = False
            e_mail.Body = txtMessage.Text
            ProgressBar1.Value = 80
            Smtp_Server.Send(e_mail)
            ProgressBar1.Value = 100


            MessageBox.Show("Mail Sended, Thank You!")
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub fetch_credentials()
        Try
            Dim dep As String = "MIS"
            sqlcmd.CommandText = "select * FROM tblemail where department = '" & dep & "';"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                MISusername = daMyname.Item("emailadd")
                MISpassword = daMyname.Item("password")
                txtFrom.Text = daMyname.Item("emailadd")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlserver.connect()

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_credentials()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_credentials()
            sqlconn.Close()
        End If



    End Sub

    Private Sub btncredential_Click(sender As Object, e As EventArgs) Handles btncredential.Click
        'If sqlconn.State = ConnectionState.Open Then
        '    Call fetch_credentials()
        '    sqlconn.Close()
        'Else
        '    sqlconn.Open()
        '    Call fetch_credentials()
        '    sqlconn.Close()
        'End If
    End Sub

    Private Sub chknewstudents_CheckedChanged(sender As Object, e As EventArgs) Handles chknewstudents.CheckedChanged, chkoldstudents.CheckedChanged
        If chknewstudents.Checked = True Then

            txtSubject.Text = "SRC Online Admission - " & studentId

            Dim messagecontent As String
            messagecontent = "Hello " + studentname & "," & vbNewLine & vbNewLine & "This is to acknowledge the receipt of your Online Registration" &
                " with attached Admission Requirements." & vbNewLine & vbNewLine & "Your Temporary Student ID: " & studentId & vbNewLine & vbNewLine & "You can now proceed to" &
                " STEP 2 up to STEP 7." & vbNewLine & vbNewLine & "Thank You!" & vbNewLine & vbNewLine & "MIS Department" & vbNewLine & "Santa Rita College of Pampanga"


            txtMessage.Text = messagecontent

        ElseIf chkoldstudents.Checked = True Then
            txtSubject.Text = "SRC Online Registration - " & studentId

            Dim messagecontent As String
            messagecontent = "Hello " + studentname & "," & vbNewLine & vbNewLine & "This is to acknowledge the receipt of your Online Registration" &
                "." & vbNewLine & vbNewLine & "Your Temporary Student ID: " & studentId & vbNewLine & vbNewLine & " " &
                "Thank You!" & vbNewLine & vbNewLine & "MIS Department" & vbNewLine & "Santa Rita College of Pampanga"


            txtMessage.Text = messagecontent
        End If
    End Sub
End Class