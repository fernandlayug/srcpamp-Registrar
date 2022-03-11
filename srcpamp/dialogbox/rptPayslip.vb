Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class rptpayslip

    Private Sub rptPayrolMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        Dim mi As String
        mi = Main.mname.Text
        Dim m As Char
        m = mi.Substring(0, 1)

        namePM.Text = Main.loguser.Text + " " + m + ". " + Main.surname.Text

    End Sub
    Private Sub fetch_payslip()
        Dim cmd As New SqlCommand("select * FROM payroll where empid = '" & Main.empid.Text & "' AND (DATEPART(month, dtefrom)  = '" & Month.Text & "')  AND (DATEPART(year, dtefrom)  = '" & yr.Text & "')order by dtefrom ASC;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "payroll")) Then

            'ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)

            payslipno.DataSource = ds.Tables(0)
            payslipno.ValueMember = "payslipno"
            payslipno.DisplayMember = "payslipno"
        Else
            payslipno.DataSource = Nothing

        End If

    End Sub
    Private Sub generate_abstract_first()

        '(department = '" & department.Text & "') AND (DATEPART(month, dtefrom)  = '" & month.Text & "')  AND (DATEPART(year, dtefrom)  = '" & yr.Text & "') AND (first = '" & first.Checked & "')

        Dim sqlQRY As String = "select * FROM payroll Where payslipno = '" & payslipno.Text & "';"
        Dim sqlQRY1 As String = "select * FROM employee  order by surname ASC;"
        Dim cmdExec As SqlCommand = New SqlCommand(sqlQRY, sqlconn)
        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        'create data adapter
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlQRY, sqlconn)
        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da.Fill(ds, "payroll")
        da1.Fill(ds, "employee")



        Dim Report As reports = New reports

        Dim mReport As payslip = New payslip


        mReport.SetDataSource(ds)
        'mReport.SetParameterValue("mytextBoxValue", namePM.Text)
        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()

    End Sub
   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call generate_abstract_first()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub monthCovered_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthCovered.TextChanged
        If monthCovered.Text = "January" Then
            Month.Text = "1"
        ElseIf monthCovered.Text = "February" Then
            Month.Text = "2"
        ElseIf monthCovered.Text = "March" Then
            Month.Text = "3"
        ElseIf monthCovered.Text = "April" Then
            Month.Text = "4"
        ElseIf monthCovered.Text = "May" Then
            Month.Text = "5"
        ElseIf monthCovered.Text = "June" Then
            Month.Text = "6"
        ElseIf monthCovered.Text = "July" Then
            Month.Text = "7"
        ElseIf monthCovered.Text = "August" Then
            Month.Text = "8"
        ElseIf monthCovered.Text = "September" Then
            Month.Text = "9"
        ElseIf monthCovered.Text = "October" Then
            Month.Text = "10"
        ElseIf monthCovered.Text = "November" Then
            Month.Text = "11"
        ElseIf monthCovered.Text = "December" Then
            Month.Text = "12"
        End If

        If yr.Text = Nothing Then
        ElseIf yr.Text = String.Empty = False Then
            Call fetch_payslip()
        End If
    End Sub

    Private Sub yr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles yr.TextChanged
        Call fetch_payslip()
    End Sub
End Class