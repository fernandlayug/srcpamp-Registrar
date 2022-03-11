Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class loginform1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        sqlcmd.CommandText = " select * From employee where(username = '" & UsernameTextBox.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader()
        If damyname.HasRows Then
            damyname.Read()
            verifyusername.Text = damyname.Item("username")
            verifypassword.Text = damyname.Item("password")
            firstname.Text = damyname.Item("firstname")
            surname.Text = damyname.Item("surname")
            designation.Text = damyname.Item("designation")
            account.Text = damyname.Item("accounttype")


            If Me.UsernameTextBox.Text = verifyusername.Text And Me.PasswordTextBox.Text = verifypassword.Text And Me.account.Text = "Administrator" Or Me.account.Text = "Accountant-Power User" Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
                Dim space As String = " "

                'billing.designation.Text = designation.Text

            Else
                MsgBox("Password was incorrect please try again.", MsgBoxStyle.OkOnly, "ERROR")
                'MsgBox("Invalid Username/Password! Verify your accounts.")
            End If
        Else
            MsgBox("Administrator not exist")
        End If
        damyname.Close()

    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'Me.Close()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub loginform1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub
End Class
