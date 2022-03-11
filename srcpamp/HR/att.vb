Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class att

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_attendance()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_attendance()
            sqlconn.Close()
        End If
    End Sub
    Private Sub fetch_attendance()
        Dim startdate As DateTime = date1.Text
        Dim enddate As DateTime = date2.Text
        Dim sqlQRY As String = "select * FROM Checkinout Where (CheckTime >= '" & date1.Text & "' and Checktime <= '" & date2.Text & "')and (userid = '" & Main.empid.Text & "');"
        Dim sqlQRY1 As String = "select * FROM employee Where (id = '" & Main.empid.Text & "');"

        Dim cmdExec As SqlCommand = New SqlCommand(sqlQRY, sqlconn)
        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlQRY, sqlconn)
        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da.Fill(ds, "Checkinout")
        da1.Fill(ds, "employee")

        Dim Report As reports = New reports

        Dim mReport As empattendance = New empattendance

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class