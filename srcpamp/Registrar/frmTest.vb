Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Public Class frmTest
    Dim table_id As Integer
    Public student_email As String

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Excel | *.xls;*xlsx;*.gsheet"
        OpenFileDialog1.ShowDialog()
        txtPath.Text = OpenFileDialog1.FileName
        Dim filepath As String = txtPath.Text
        Dim connstring As String = String.Empty
        If filepath.EndsWith(".xls") Then
            connstring = String.Format("Provider=Microsoft.Jet.Oledb.4.0;" &
                                       "Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filepath)
        Else
            connstring = String.Format("Provider=Microsoft.Ace.Oledb.12.0;" &
                                       "Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filepath)
        End If
        Dim conn As New OleDbConnection(connstring)
        conn.Open()
        cmbsheet.DataSource = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
        cmbsheet.DisplayMember = "Table_Name"
        cmbsheet.ValueMember = "Table_name"
        conn.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim filepath As String = txtPath.Text
        Dim connstring As String = String.Empty
        If filepath.EndsWith(".xls") Then
            connstring = String.Format("Provider=Microsoft.Jet.Oledb.4.0;" &
                                       "Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filepath)
        Else
            connstring = String.Format("Provider=Microsoft.Ace.Oledb.12.0;" &
                                       "Data Source={0};Extended Properties='Excel 8.0;HDR=yes'", filepath)
        End If
        Dim cmd As New OleDbDataAdapter("Select * from [" & cmbsheet.Text & "" & "]", connstring)
        cmd.TableMappings.Add("Table", "Table")
        Dim dt As New DataSet
        cmd.Fill(dt)
        dgvReg.DataSource = dt.Tables(0)
    End Sub

    Private Sub dgvReg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReg.CellClick
        Dim myeMAIL As String = dgvReg.CurrentRow.Cells("Email Address").Value.ToString
        student_email = myeMAIL

        Dim myVariable As String = dgvReg.CurrentRow.Cells("LRN").Value.ToString
        txtLRN.Text = myVariable

        Dim fname As String = dgvReg.CurrentRow.Cells("Firstname").Value.ToString
        txtFirstname.Text = fname

        Dim lname As String = dgvReg.CurrentRow.Cells("Lastname").Value.ToString
        txtLastname.Text = lname

        Dim mname As String = dgvReg.CurrentRow.Cells("Middlename").Value.ToString
        txtMiddlename.Text = mname

        Dim gender As String = dgvReg.CurrentRow.Cells("Gender").Value.ToString
        txtGender.Text = gender

        Dim bday As String = dgvReg.CurrentRow.Cells("Birthday").Value.ToString
        txtBirthday.Text = bday

        Dim bplace As String = dgvReg.CurrentRow.Cells("Birthplace").Value.ToString
        txtBirthplace.Text = bplace

        Dim add1 As String = dgvReg.CurrentRow.Cells("Barrio").Value.ToString
        txtaddress1.Text = add1

        Dim add2 As String = dgvReg.CurrentRow.Cells("Municipality").Value.ToString
        txtaddress2.Text = add2

        Dim add3 As String = dgvReg.CurrentRow.Cells("Province").Value.ToString
        txtaddress3.Text = add3

        Dim zip As String = dgvReg.CurrentRow.Cells("Zip Code").Value.ToString
        txtzipcode.Text = zip

        Dim mobile As String = dgvReg.CurrentRow.Cells("Mobile No").Value.ToString
        txtMobileNo.Text = mobile

        Dim rel As String = dgvReg.CurrentRow.Cells("Religion").Value.ToString
        txtReligion.Text = rel

        Dim cat As String = dgvReg.CurrentRow.Cells("Religion").Value.ToString
        txtReligion.Text = rel

        Dim cit As String = dgvReg.CurrentRow.Cells("Citizenship").Value.ToString
        txtCitizenship.Text = cit

        Dim f_name As String = dgvReg.CurrentRow.Cells("Father First name").Value.ToString
        txt_f_fname.Text = f_name

        Dim f_lname As String = dgvReg.CurrentRow.Cells("Father Surname").Value.ToString
        txt_f_lname.Text = f_lname

        Dim f_mname As String = dgvReg.CurrentRow.Cells("Father Middle Initial").Value.ToString
        txt_f_mname.Text = f_mname

        Dim m_name As String = dgvReg.CurrentRow.Cells("Mother Firstname").Value.ToString
        txt_m_fname.Text = m_name

        Dim m_lname As String = dgvReg.CurrentRow.Cells("Mother Surname").Value.ToString
        txt_m_lname.Text = m_lname

        Dim m_mname As String = dgvReg.CurrentRow.Cells("Mother Middle Initial").Value.ToString
        txt_m_mname.Text = m_mname

        Dim guardian As String = dgvReg.CurrentRow.Cells("Guardian Complete Name").Value.ToString
        txtGuardian.Text = guardian

        Try
            Dim req1a As String = dgvReg.CurrentRow.Cells("Certificate of Indigency from Brgy Captain").Value.ToString
            req1.Text = req1a

        Catch ex As Exception

        End Try
        Try
            Dim req2a As String = dgvReg.CurrentRow.Cells("2x2 Picture").Value.ToString
            req2.Text = req2a


        Catch ex As Exception

        End Try
        Try
            Dim req3a As String = dgvReg.CurrentRow.Cells("Form 138 Report Card with 3rd Grading grade").Value.ToString
            req3.Text = req3a


        Catch ex As Exception

        End Try
        Try
            Dim req4a As String = dgvReg.CurrentRow.Cells("PSA Birth Certificate").Value.ToString
            req4.Text = req4a


        Catch ex As Exception

        End Try
        Try
            Dim req5a As String = dgvReg.CurrentRow.Cells("Certificate of Good Moral Character").Value.ToString
            req5.Text = req5a
        Catch ex As Exception

        End Try

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_last_id()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_last_id()
            sqlconn.Close()
        End If


        If sqlconn.State = ConnectionState.Open Then
            Call check_students()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call check_students()
            sqlconn.Close()
        End If


    End Sub

    Private Sub req1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles req1.LinkClicked
        Dim webAddress As String = req1.Text
        Process.Start(webAddress)
    End Sub

    Private Sub req2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles req2.LinkClicked
        Dim webAddress As String = req2.Text
        Process.Start(webAddress)
    End Sub

    Private Sub req3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles req3.LinkClicked
        Dim webAddress As String = req3.Text
        Process.Start(webAddress)
    End Sub

    Private Sub req4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles req4.LinkClicked
        Dim webAddress As String = req4.Text
        Process.Start(webAddress)
    End Sub

    Private Sub req5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles req5.LinkClicked
        Dim webAddress As String = req5.Text
        Process.Start(webAddress)
    End Sub
    Private Sub generate_id()

        Dim increment As Double

        increment = 1

        Dim y As Date = txtBirthday.Text
        Dim birthyear As String
        birthyear = Format(y, "yyyy")

        Try
            Dim lastid As Double = last_eid.Text
            Dim student As Double
            Dim studentsequenceID As String
            student = 0 + lastid + increment

            studentsequenceID = student.ToString.PadLeft(7, "0"c)

            studentid.Text = birthyear + "-" + studentsequenceID

            table_id = lastid + 1
        Catch ex As Exception

        End Try

    End Sub
    Private Sub fetch_last_id()
        Try
            sqlcmd.CommandText = "select top 1 * FROM studentdata_temp ORDER BY ID DESC;"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                last_eid.Text = daMyname.Item("ID")

            End If
        Catch ex As Exception
            MsgBox("You records found." & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub check_students()
        sqlcmd.CommandText = "select * FROM studentdata_temp Where (firstname = '" & txtFirstname.Text & "') and (mname = '" & txtMiddlename.Text & "') and (surname = '" & txtLastname.Text & "')and (sex = '" & txtGender.Text & "') and (birthday = '" & txtBirthday.Text & "');"
        sqlcmd.Connection = sqlconn

        Dim daMyname2 As SqlDataReader

        daMyname2 = sqlcmd.ExecuteReader()

        If daMyname2.HasRows Then
            daMyname2.Read()

            lblStatus.Text = "Same student already Registered!"
            btnRegister.Enabled = False
            btnResend.Enabled = True
            studentid.Text = daMyname2.Item("studentID")
            'command para insert ang mga data
        Else
            lblStatus.Text = ""
            btnRegister.Enabled = True
            btnResend.Enabled = False
            Call generate_id()

            'studentid.Text = ""
        End If
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click



        If sqlconn.State = ConnectionState.Open Then
            Call temporary_register()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call temporary_register()
            sqlconn.Close()
        End If


    End Sub
    Private Sub temporary_register()
        Try
            Dim sqlcmd As New SqlClient.SqlCommand
            strsql = " INSERT into studentdata_temp ([id],[studentid],[lrn],[firstname],[mname],[surname], " &
                    "[sex],[birthday],[birthplace],[address1],[address2],[address3], " &
                    "[ZIPCODE],[mobile],[email],[religion],[citizenship], " &
                    "[father], [f_firstname], [f_mname],[mother],[m_firstname], [m_mname],  " &
                    "[guardian],[req1], [req2], [req3],[req4], [req5],[dateregistered]) values ('" & table_id & "','" & studentid.Text & "', " &
                    "'" & txtLRN.Text & "','" & txtFirstname.Text & "','" & txtMiddlename.Text & "','" & txtLastname.Text & "','" & txtGender.Text & "', " &
                    "'" & txtBirthday.Text & "'," &
                    "'" & txtBirthplace.Text & "','" & txtaddress1.Text & "','" & txtaddress2.Text & "', " &
                    "'" & txtaddress3.Text & "','" & txtzipcode.Text & "','" & txtMobileNo.Text & "','" & student_email & "','" & txtReligion.Text & "'," &
                    "'" & txtCitizenship.Text & "','" & txt_f_lname.Text & "','" & txt_f_fname.Text & "','" & txt_f_mname.Text & "','" & txt_m_lname.Text & "'," &
                    "'" & txt_m_fname.Text & "','" & txt_m_mname.Text & "','" & txtGuardian.Text & "','" & req1.Text & "'," &
                    "'" & req2.Text & "','" & req3.Text & "','" & req4.Text & "','" & req5.Text & "','" & datetoday.Text & "')"
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()

            Call check_students()




            Dim result = MessageBox.Show("Registered! Do you want to sent an e-mail acknowledgement?", "Send E-mail", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                frmMail.txtTo.Text = student_email
                frmMail.studentname = txtFirstname.Text
                frmMail.studentId = studentid.Text

                frmMail.ShowDialog()

            ElseIf result = DialogResult.No Then

            End If

        Catch ex As Exception
            MsgBox("Unable to save entries." & vbCrLf & ex.Message)
        End Try


    End Sub

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlserver.connect()
        datetoday.Text = Now()


    End Sub

    Private Sub btnResend_Click(sender As Object, e As EventArgs) Handles btnResend.Click
        frmMail.txtTo.Text = student_email
        frmMail.studentname = txtFirstname.Text
        frmMail.studentId = studentid.Text

        frmMail.ShowDialog()
    End Sub
    Private Sub print_register()

        Dim sqlQRY1 As String = "select * FROM studentdata_temp where studentID = '" & studentid.Text & "';"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "studentdata_temp")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptStudentData = New rptStudentData

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_register()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_register()
            sqlconn.Close()
        End If
    End Sub
End Class