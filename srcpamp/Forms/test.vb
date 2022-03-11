Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration

Public Class test

    Private Sub disabledCombo()



        ddldisabled.ForeColor = System.Drawing.Color.Red

        ddldisabled.Items.Clear()


    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Date = TextBox1.Text
        Dim b As Date = TextBox2.Text
        TextBox3.Text = DateDiff(DateInterval.Year, a, b)


    End Sub


    Private Sub test_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub
End Class