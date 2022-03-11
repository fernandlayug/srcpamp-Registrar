Public Class frmsy

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub frmsy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlcmd As New SqlClient.SqlCommand

        strsql = "INSERT into sy ([sy]) values ('" & sy.Text & "')"

        If String.IsNullOrEmpty(sy.Text) Then
            MessageBox.Show("Please enter School Year")
            sy.Focus()
        Else
            Dim result = MessageBox.Show("Are you sure you want to add School Year?", "Year Level", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlconn
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("New School Year Saved!")
                Me.Dispose()


            ElseIf result = DialogResult.No Then
                Me.Dispose()

            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Please check all the information")
            End If

        End If
        sqlconn.Close()

    End Sub
End Class