Imports System.Data.SqlClient
Imports System.IO

Public Class changeuser

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_user()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_user()
            sqlconn.Close()
        End If

    End Sub
    Private Sub fetch_user()
        sqlcmd.CommandText = " select * From employee where(username = '" & Main.username.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS);"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader()
        If damyname.HasRows Then
            damyname.Read()
            user.Text = damyname.Item("username")
        End If
    End Sub
    Private Sub retypepass_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles retypepass.Leave
        If retypepass.Text = newpass.Text Then
            verified.Text = newpass.Text
        Else
            Dim result = MessageBox.Show("Your New Username doesn't match to your Re-type Username.  Do you want to continue", "Change Username", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                retypepass.Text = ""
                retypepass.Focus()
            ElseIf result = DialogResult.No Then
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub update_pass()
        If retypepass.Text = "" Or retypepass.Text = Nothing Or newpass.Text = "" Or newpass.Text = Nothing Then
            MsgBox("You cannot proceed the process with an empty field!")
        Else
            Dim result = MessageBox.Show("Are you sure you want to change your username?", "Change Username", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim sqlcmd As New SqlClient.SqlCommand
                strsql = "UPDATE employee SET username = '" & verified.Text & "' where firstname = '" & Main.loguser.Text & "' and username = '" & Main.username.Text & "'"
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlconn
                sqlcmd.ExecuteNonQuery()
                MsgBox("Username Change")
                Me.Dispose()
                Call logoff_status()

                Dim frm As New mainlogin
                frm.Show()
                frm.MdiParent = Main

            ElseIf result = DialogResult.No Then
                Me.Dispose()
            End If
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