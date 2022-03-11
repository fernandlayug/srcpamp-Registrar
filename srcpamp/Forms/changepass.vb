Imports System.Data.SqlClient
Imports System.IO

Public Class changepass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub
    Private Sub fetch_user()
        sqlcmd.CommandText = " select * From employee where(username = '" & Main.username.Text & "' and password = '" & oldpass.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS);"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader()
        If damyname.HasRows Then
            damyname.Read()
            user.Text = damyname.Item("username")
            pass.Text = damyname.Item("password")
        ElseIf oldpass.Text = Nothing Then
            MsgBox("NO password entered")
            sqlconn.Close()
            Button1.Focus()
        Else
            MsgBox("Wrong password. Try again")
            oldpass.Text = ""
            oldpass.Focus()
        End If
    End Sub

    Private Sub oldpass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles oldpass.Leave
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_user()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_user()
            sqlconn.Close()
        End If
    End Sub

    Private Sub retypepass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles retypepass.Leave
        If retypepass.Text = newpass.Text Then
            verified.Text = newpass.Text
        Else
            Dim result = MessageBox.Show("Your New password doesn't match to your Re-type Password.  Do you want to continue", "Change Password", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                retypepass.Text = ""
                retypepass.Focus()
            ElseIf result = DialogResult.No Then
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub update_pass()
        Dim result = MessageBox.Show("Are you sure you want to change your password?", "Change Password", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim sqlcmd As New SqlClient.SqlCommand
            strsql = "UPDATE employee SET password = '" & verified.Text & "' where firstname = '" & Main.loguser.Text & "' and username = '" & Main.username.Text & "' and password = '" & oldpass.Text & "'"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
            MsgBox("Password Change")
            Me.Dispose()
            Call logoff_status()

            Dim frm As New mainlogin
            frm.Show()
            frm.MdiParent = Main

        ElseIf result = DialogResult.No Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            Call update_pass()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_pass()
            sqlconn.Close()
        End If
    End Sub
End Class