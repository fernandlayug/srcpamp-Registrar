Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class Category

    Private Sub save_category()

        Dim result = MessageBox.Show("Are you sure you want to submit the Particular Category?", "Particular Category", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Dim sqlcmd As New SqlClient.SqlCommand
            strsql = "INSERT into particular_category([category]) values ('" & inputcategory.Text & "')"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
            Me.Dispose()
        ElseIf result = DialogResult.No Then
            Me.Dispose()
        ElseIf result = DialogResult.Cancel Then
            MessageBox.Show("Please check the information")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sqlconn.State = ConnectionState.Open Then
            Call save_category()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call save_category()
            sqlconn.Close()
        End If
    End Sub
End Class