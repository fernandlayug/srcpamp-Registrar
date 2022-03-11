Imports System.Data.SqlClient
Public Class testform




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim cmd As New SqlCommand("select * From admission Where (level like '%" + TextBox1.Text + "%' and sex like '" & TextBox2.Text + "%' );", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "admission")) Then
                ' DataGridView1.Visible = True
                DataGridView1.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("No Scheduled Activity Found")
                'DataGridView1.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub testform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class