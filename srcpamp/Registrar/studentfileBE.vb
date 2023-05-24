Imports System.Data.SqlClient
Imports System.IO


Public Class studentfileBE
   
    Dim yrlevelcategory, coursecode, depLevel As String
    Dim bc, f138, gm, tr As String
    Dim AddSchool As Boolean
    Public schoolcode As String
    Public schoolid As Integer
    Public sem As Integer
    Dim chk As New DataGridViewCheckBoxColumn
    Dim modesubject As Boolean
    Dim GradingIDRow As String
    Dim admission As Integer
    Public formstatus As String
    Dim txtCAY As String
    Dim prnName, paperName As String
    Public frmname As String
    Public sectionID As Double
    Public cat As String

    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.F3 Then
            searchid.frmactive = "studentfileBE"
            searchid.ShowDialog()

        End If
    End Sub
    Private Sub displayFORMNAME()
        For Each FRM As Form In Application.OpenForms
            frmname = FRM.Name
        Next
    End Sub
    Private Sub fetch_printSETUP()
        sqlcmd.CommandText = "select * FROM printSETUP Where (frmNAME = '" & frmname & "' AND hostname = '" & pcname.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            daMyname2.Read()
            printerName.Text = daMyname2.Item("prnNAME")
            paperSize.Text = daMyname2.Item("paperNAME")

            prnName = daMyname2.Item("prnNAME")
            paperName = daMyname2.Item("paperNAME")
        Else
            Dim printer As String = "No Declared Printer for this Form"
            Dim paper As String = "________________"
            printerName.Text = printer
            paperSize.Text = paper
        End If
    End Sub


    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If formstatus = "admission" Then
            dgvEnrollment.Enabled = False
        Else
            dgvEnrollment.Enabled = True

        End If
        sqlserver.connect()
        CenterToScreen()
        studid.Focus()

        Call displayFORMNAME()
   
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_printSETUP()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_printSETUP()
            sqlconn.Close()
        End If

    End Sub



    Private Sub fetch_admission()

        'sqlcmd.CommandText = "select  * FROM admissionVIEW where sy = '" & txtSY.Text & "' AND studentid = '" & studid.Text & "' and term = '" & sem & "' and yrlevel = '" & level.Text & "'"
        sqlcmd.CommandText = "select  * FROM admissionVIEW where sy = '" & txtSY.Text & "' AND studentid = '" & studid.Text & "' and term = '" & sem & "' and yrlevel = '" & txtLevel.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()

            txtcourseid.Text = daMyname.Item("courseid")
            txtCategory.Text = daMyname.Item("category")
            txtStatus.Text = daMyname.Item("studentstatus")
            sectionID = daMyname.Item("section")

            txtCAY = daMyname.Item("cay")
            txtComment.Text = daMyname.Item("remarks") & ""
            lda.Text = daMyname.Item("lda") & ""
            cmbSection.Text = daMyname.Item("sectioname").ToString()
        Else

            txtcourseid.Text = ""

            txtCategory.Text = ""
            txtStatus.Text = ""
            txtComment.Text = ""
            lda.Text = ""
            txtCAY = ""
            sectionID = 0
            cmbSection.Text = ""
        End If


        If txtComment.Text = "" Then
            commentbox.Enabled = False
            DateTimePicker1.Enabled = True
            txtComment.Enabled = True
        ElseIf txtComment.Text = String.Empty = False Then
            commentbox.Enabled = True
            DateTimePicker1.Enabled = False
            txtComment.Enabled = False
        End If
        txtCAYlabelA.Text = txtCAY

    End Sub
    Private Sub fetch_studentData()
        Dim f As String
        Dim m As String
        Dim s As String

        sqlcmd.CommandText = "select * FROM studentdata Where (studentID = '" & studid.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            Dim bdate As Date
            f = daMyname.Item("firstname")
            m = daMyname.Item("mname")
            s = daMyname.Item("surname")
            'surname.Enabled = False
            sex.Text = daMyname.Item("sex")
            bdate = daMyname.Item("birthday")
            birthday.Text = bdate
            bdateOLD.Text = bdate
            txtLRN.Text = daMyname.Item("lrn")
            surname.Text = s + ", " + f + " " + m
        Else
            Dim bdate As String

            surname.Text = ""
            sex.Text = ""
            txtLRN.Text = ""
            bdate = "__/__/____"
            birthday.Text = bdate
            bdateOLD.Text = bdate
        End If


    End Sub

    Private Function total_lecunits()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To dtsubjects.Rows.Count - 1
            tot = tot + Convert.ToDouble(dtsubjects.Rows(i).Cells("subjectlecunit").Value)
        Next i
        Return tot

    End Function
    Private Function total_units()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To dtsubjects.Rows.Count - 1
            tot = tot + Convert.ToDouble(dtsubjects.Rows(i).Cells("subjectunits").Value)
        Next i
        Return tot

    End Function
    Private Function total_labunits()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To dtsubjects.Rows.Count - 1
            tot = tot + Convert.ToDouble(dtsubjects.Rows(i).Cells("subjectlabunit").Value)
        Next i
        Return tot

    End Function
    Private Sub studid_TextChanged(sender As Object, e As System.EventArgs) Handles studid.TextChanged
        txtStatus.Text = ""

        btnPrint.Enabled = True
        btnPrint.Text = "Print"
        btnADD.Enabled = True
        btnADD.Text = "Add Subject"
        btnRemove.Enabled = True
        btnRemove.Text = "Remove Subject"
        btndropstudent.Enabled = True
        btndropstudent.Text = "Drop Student"
        btnDrop.Enabled = True
        btnDrop.Text = "Drop Subject"
        btntransferout.Enabled = True
        btntransferout.Text = "Transfer Out"
        btnClose.Enabled = True
        btnClose.Text = "Close"


        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_studentData()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentData()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_EnrollmentHistory()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_EnrollmentHistory()
            sqlconn.Close()
        End If



    End Sub

    Private Sub dgvEnrollment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrollment.CellClick
        Dim myVariable As String = dgvEnrollment.CurrentRow.Cells("sy").Value.ToString
        txtSY.Text = myVariable

        Dim myVariable2 As String = dgvEnrollment.CurrentRow.Cells("yrlevel").Value.ToString
        txtLevel.Text = myVariable2

        Dim myVariable3 As String = dgvEnrollment.CurrentRow.Cells("term").Value.ToString
        txtSemester.Text = myVariable3
        sem = myVariable3

        Dim myVariable4 As String = dgvEnrollment.CurrentRow.Cells("coursecode").Value.ToString
        txtCourseCode.Text = myVariable4

        Dim myVariable5 As String = dgvEnrollment.CurrentRow.Cells("coursename").Value.ToString
        txtCourse.Text = myVariable5

        Dim myVariable6 As String = dgvEnrollment.CurrentRow.Cells("coursemajor").Value.ToString
        txtMajor.Text = myVariable6

        Dim myVariable7 As String = dgvEnrollment.CurrentRow.Cells("sectioname").Value.ToString
        cmbSection.Text = myVariable7

        Dim myVariable8 As String = dgvEnrollment.CurrentRow.Cells("levelid").Value.ToString
        txtlevelid.Text = myVariable8

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_admission()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_admission()
            sqlconn.Close()
        End If

    End Sub
    Public Sub fetch_EnrollmentHistory()

        Dim obj As Object = DBNull.Value

        'Dim cmd As New SqlCommand("SELECT coursecode, coursename, coursemajor, sectioname, sy, yrlevel, term, category, levelid  FROM admissionVIEW  Where (studentid = '" & studid.Text & "' and category = '" & cat & "') ORDER by sy asc;", sqlconn)
        Dim cmd As New SqlCommand("SELECT coursecode, coursename, coursemajor, sectioname, sy, yrlevel, term, category, levelid  FROM admissionVIEW  Where (studentid = '" & studid.Text & "') ORDER by sy asc;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "admissionVIEW")) Then
            dgvEnrollment.Columns.Clear()

            dgvEnrollment.DataSource = ds.Tables(0)

            dgvEnrollment.Columns("category").Visible = False
            dgvEnrollment.Columns("coursename").Visible = False
            dgvEnrollment.Columns("levelid").Visible = False

            dgvEnrollment.Columns("coursecode").DisplayIndex = 1
            dgvEnrollment.Columns("coursecode").Width = 60
            dgvEnrollment.Columns("coursecode").HeaderText = "Code"

            'dgvEnrollment.Columns("coursename").DisplayIndex = 2
            'dgvEnrollment.Columns("coursename").HeaderText = "Course"
            'dgvEnrollment.Columns("coursename").Width = 300

            dgvEnrollment.Columns("coursemajor").DisplayIndex = 3
            dgvEnrollment.Columns("coursemajor").HeaderText = "Major"
            dgvEnrollment.Columns("coursemajor").Width = 100

            dgvEnrollment.Columns("sectioname").DisplayIndex = 4
            dgvEnrollment.Columns("sectioname").HeaderText = "Section"
            dgvEnrollment.Columns("sectioname").Width = 60

            dgvEnrollment.Columns("sy").DisplayIndex = 5
            dgvEnrollment.Columns("sy").HeaderText = "Academic Year"
            dgvEnrollment.Columns("sy").Width = 120

            dgvEnrollment.Columns("term").DisplayIndex = 6
            dgvEnrollment.Columns("term").HeaderText = "Term"
            dgvEnrollment.Columns("term").Width = 40

            dgvEnrollment.Columns("yrlevel").DisplayIndex = 7
            dgvEnrollment.Columns("yrlevel").HeaderText = "Level"
            dgvEnrollment.Columns("yrlevel").Width = 60



        Else
            dgvEnrollment.DataSource = Nothing
        End If


    End Sub
    Public Sub fetch_subjectsenrolled()

        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname +', ' + firstname as facultyname, gradingid, studentid, subjectID, levelid, sy, term, subjectcode, subjectdescription, subjectlecunit, subjectlabunit, subjectunits, subjectprereq, remarks, units, classscheduleid, days, time, room, facultyid  FROM subjectEnrolledView  Where (studentid = '" & studid.Text & "' and levelid = '" & txtlevelid.Text & "' and  term = '" & sem & "' and sy = '" & txtSY.Text & "') ORDER by subjectcode asc;", sqlconn)
        'Dim cmd As New SqlCommand("select surname +', ' + firstname as facultyname, gradingid, studentid, subjectID, levelid, sy, term, subjectcode, subjectdescription, subjectlecunit, subjectlabunit, subjectunits, subjectprereq, remarks, units, classscheduleid, days, time, room, facultyid  FROM subjectEnrolledView  Where (studentid = '" & studid.Text & "' and levelid = '" & txtlevelid.Text & "' and  term = '" & sem & "' and sy = '" & txtSY.Text & "') ORDER by subjectcode asc;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "subjectEnrolledView")) Then
            dtsubjects.Columns.Clear()

            dtsubjects.DataSource = ds.Tables(0)

            dtsubjects.Columns("studentid").Visible = False
            dtsubjects.Columns("sy").Visible = False
            dtsubjects.Columns("levelid").Visible = False
            dtsubjects.Columns("term").Visible = False
            dtsubjects.Columns("remarks").Visible = False
            dtsubjects.Columns("gradingid").Visible = False
            dtsubjects.Columns("units").Visible = False
            dtsubjects.Columns("subjectid").Visible = False
            dtsubjects.Columns("classscheduleid").Visible = False
            dtsubjects.Columns("facultyid").Visible = False

            dtsubjects.Columns("subjectcode").DisplayIndex = 1
            dtsubjects.Columns("subjectcode").Width = 60
            dtsubjects.Columns("subjectcode").HeaderText = "Code"

            dtsubjects.Columns("subjectdescription").DisplayIndex = 2
            dtsubjects.Columns("subjectdescription").HeaderText = "Subject"
            dtsubjects.Columns("subjectdescription").Width = 250

            dtsubjects.Columns("subjectlecunit").DisplayIndex = 3
            dtsubjects.Columns("subjectlecunit").HeaderText = "LecUnits"
            dtsubjects.Columns("subjectlecunit").Width = 50
            dtsubjects.Columns("subjectlecunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectlabunit").DisplayIndex = 4
            dtsubjects.Columns("subjectlabunit").HeaderText = "LabUnits"
            dtsubjects.Columns("subjectlabunit").Width = 50
            dtsubjects.Columns("subjectlabunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectunits").DisplayIndex = 5
            dtsubjects.Columns("subjectunits").HeaderText = "Units"
            dtsubjects.Columns("subjectunits").Width = 50
            dtsubjects.Columns("subjectunits").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectprereq").DisplayIndex = 6
            dtsubjects.Columns("subjectprereq").HeaderText = "Pre-req"
            dtsubjects.Columns("subjectprereq").Width = 70

            dtsubjects.Columns("days").DisplayIndex = 7
            dtsubjects.Columns("days").HeaderText = "Day"
            dtsubjects.Columns("days").Width = 50

            dtsubjects.Columns("time").DisplayIndex = 8
            dtsubjects.Columns("time").HeaderText = "Time"
            dtsubjects.Columns("time").Width = 120

            dtsubjects.Columns("room").DisplayIndex = 9
            dtsubjects.Columns("room").HeaderText = "Room"
            dtsubjects.Columns("room").Width = 100

            dtsubjects.Columns("facultyname").DisplayIndex = 10
            dtsubjects.Columns("facultyname").HeaderText = "Faculty"
            dtsubjects.Columns("facultyname").Width = 150

            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            For RCnt As Integer = 0 To dtsubjects.Rows.Count - 1
                If dtsubjects.Rows(RCnt).Cells("remarks").Value = "DROPPED" Then
                    dtsubjects.Rows(RCnt).ReadOnly = True
                    dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Violet

                ElseIf dtsubjects.Rows(RCnt).Cells("remarks").Value = "Transfer Out" Then
                    dtsubjects.Rows(RCnt).ReadOnly = True
                    dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Pink

                ElseIf dtsubjects.Rows(RCnt).Cells("remarks").Value = "" Then
                    dtsubjects.Rows(RCnt).ReadOnly = False
                    'dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Pink
                End If
            Next


        Else
            dtsubjects.DataSource = Nothing
        End If


    End Sub
    Public Sub Remove_dropped()

        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select * FROM subjectEnrolledView  Where (studentid = '" & studid.Text & "' and term = '" & sem & "' and sy = '" & txtSY.Text & "') order by subjectunits desc;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "subjectEnrolledView")) Then

            dtsubjects.Columns.Clear()


            dtsubjects.DataSource = ds.Tables(0)

            dtsubjects.Columns("studentid").Visible = False
            dtsubjects.Columns("sy").Visible = False
            dtsubjects.Columns("levelid").Visible = False
            dtsubjects.Columns("term").Visible = False
            dtsubjects.Columns("remarks").Visible = False
            dtsubjects.Columns("gradingid").Visible = False
            dtsubjects.Columns("units").Visible = False

            dtsubjects.Columns.Add(chk)
            chk.HeaderText = "Select"
            chk.Name = "chk"

            dtsubjects.Columns("chk").DisplayIndex = 0
            dtsubjects.Columns("chk").Width = 50

            dtsubjects.Columns("subjectcode").DisplayIndex = 1
            dtsubjects.Columns("subjectcode").Width = 60
            dtsubjects.Columns("subjectcode").HeaderText = "Code"

            dtsubjects.Columns("subjectdescription").DisplayIndex = 2
            dtsubjects.Columns("subjectdescription").HeaderText = "Subject"
            dtsubjects.Columns("subjectdescription").Width = 270

            dtsubjects.Columns("subjectlecunit").DisplayIndex = 3
            dtsubjects.Columns("subjectlecunit").HeaderText = "LecUnits"
            dtsubjects.Columns("subjectlecunit").Width = 50
            dtsubjects.Columns("subjectlecunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectlabunit").DisplayIndex = 4
            dtsubjects.Columns("subjectlabunit").HeaderText = "LabUnits"
            dtsubjects.Columns("subjectlabunit").Width = 50
            dtsubjects.Columns("subjectlabunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectunits").DisplayIndex = 5
            dtsubjects.Columns("subjectunits").HeaderText = "Units"
            dtsubjects.Columns("subjectunits").Width = 50
            dtsubjects.Columns("subjectunits").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtsubjects.Columns("subjectprereq").DisplayIndex = 6
            dtsubjects.Columns("subjectprereq").HeaderText = "Pre-req"
            dtsubjects.Columns("subjectprereq").Width = 90

            dtsubjects.Columns("days").DisplayIndex = 7
            dtsubjects.Columns("days").HeaderText = "Day"
            dtsubjects.Columns("days").Width = 50

            dtsubjects.Columns("time").DisplayIndex = 8
            dtsubjects.Columns("time").HeaderText = "Time"
            dtsubjects.Columns("time").Width = 120

            dtsubjects.Columns("room").DisplayIndex = 9
            dtsubjects.Columns("room").HeaderText = "Room"
            dtsubjects.Columns("room").Width = 100
            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            For RCnt As Integer = 0 To dtsubjects.Rows.Count - 1
                If dtsubjects.Rows(RCnt).Cells("remarks").Value = "DROPPED" Then
                    dtsubjects.Rows(RCnt).ReadOnly = True
                    dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Violet

                ElseIf dtsubjects.Rows(RCnt).Cells("remarks").Value = "Transfer Out" Then
                    dtsubjects.Rows(RCnt).ReadOnly = True
                    dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Pink

                ElseIf dtsubjects.Rows(RCnt).Cells("remarks").Value = "" Then
                    dtsubjects.Rows(RCnt).ReadOnly = False
                    'dtsubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Pink
                End If
            Next
        Else
            dtsubjects.DataSource = Nothing
        End If

    End Sub



    Private Sub addsubject_Click(sender As System.Object, e As System.EventArgs) Handles btnADD.Click

        frmSubjectsEnrolled.cmbSubjectCategory.Text = txtCategory.Text
        frmSubjectsEnrolled.txtCourse.Text = txtCourse.Text
        frmSubjectsEnrolled.coursecode.Text = txtCourseCode.Text
        frmSubjectsEnrolled.txtMajor.Text = txtMajor.Text
        frmSubjectsEnrolled.txtLevel.Text = txtLevel.Text
        frmSubjectsEnrolled.txtLevelID.Text = txtlevelid.Text
        frmSubjectsEnrolled.txtCourseID.Text = txtcourseid.Text
        frmSubjectsEnrolled.txtTermID.Text = sem
        frmSubjectsEnrolled.txtTermID2.Text = sem
        frmSubjectsEnrolled.txtSY.Text = txtSY.Text
        frmSubjectsEnrolled.txtstudentid.Text = studid.Text
        frmSubjectsEnrolled.txtStudentLevelID.Text = txtlevelid.Text
        frmSubjectsEnrolled.cmbAY.Text = txtCAY
        frmSubjectsEnrolled.cmbSection.Text = txtSectioname.Text
        frmSubjectsEnrolled.secid = sectionID
        frmSubjectsEnrolled.studentfileDepartment = frmname


        frmSubjectsEnrolled.Show()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If btnClose.Text = "Cancel" Then
            btnClose.Text = "Close"
            btnDrop.Text = "Drop Subject"
            btnRemove.Text = "Remove Subject"
            btndropstudent.Text = "Drop Student"
            btntransferout.Text = "Transfer Out"
            txtComment.Text = ""
            lda.Text = ""
            btnDrop.Enabled = True
            btnADD.Enabled = True
            btnRemove.Enabled = True
            btnPrint.Enabled = True
            btndropstudent.Enabled = True
            btntransferout.Enabled = True

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_subjectsenrolled()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_subjectsenrolled()
                sqlconn.Close()
            End If
        ElseIf btnClose.Text = "Close" Then
            Me.Dispose()
            ' Dim result = MessageBox.Show("Do you want to Enroll another students?", "Enrolment", MessageBoxButtons.YesNo)
            ' If result = DialogResult.Yes Then
            'Me.Dispose()


            '  ElseIf result = DialogResult.No Then
            '    Me.Dispose()

            '  End If

        End If
    End Sub

    Private Sub dtsubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtsubjects.CellClick
        Dim myVariable As String = dtsubjects.CurrentRow.Cells("gradingid").Value.ToString
        txtGradingID.Text = myVariable

        Dim myVariable2 As String = dtsubjects.CurrentRow.Cells("subjectid").Value.ToString
        txtsubjectID.Text = myVariable2
    End Sub



    Private Sub dtsubjects_DataSourceChanged(sender As Object, e As System.EventArgs) Handles dtsubjects.DataSourceChanged

        Try
            txtlecunits.Text = total_lecunits()
            txtlabunits.Text = total_labunits()
            txttotalunits.Text = total_units()
            txttotalsubjects.Text = dtsubjects.RowCount
        Catch ex As Exception

        End Try



    End Sub


    Private Sub btnDrop_Click(sender As System.Object, e As System.EventArgs) Handles btnDrop.Click
        If btnDrop.Text = "Drop Subject" Then
            btnDrop.Text = "Apply Changes"
            btnPrint.Enabled = False
            btnADD.Enabled = False
            btnRemove.Enabled = False
            btndropstudent.Enabled = False
            btntransferout.Enabled = False
            btnClose.Text = "Cancel"

            commentbox.Enabled = True

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call Remove_dropped()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call Remove_dropped()
                sqlconn.Close()
            End If
        ElseIf btnDrop.Text = "Apply Changes" Then

            If String.IsNullOrEmpty(txtComment.Text) Then
                MessageBox.Show("Please add comment/remarks")
                txtComment.Focus()
            ElseIf String.IsNullOrEmpty(lda.Text) Then
                MessageBox.Show("Please enter the last date of attendance")
                lda.Focus()
            Else

                btnDrop.Text = "Drop Subject"
                Call dropSubjects()
                btnPrint.Enabled = True
                btnADD.Enabled = True
                btnRemove.Enabled = True
                btndropstudent.Enabled = True
                btntransferout.Enabled = True
                lda.Text = ""
                txtComment.Text = ""
                btnClose.Text = "Close"

            End If

        End If
    End Sub

    Private Sub update_grading()
        Dim d As String = "DROPPED"
        Dim z As Double = 0
        Dim sysdate As Date = Main.datetoday.Text
        Dim ldate As Date = lda.Text
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET remarks = '" & d & "', units = '" & z & "', comment = '" & txtReason.Text & "', systemdate = '" & sysdate & "', lda = '" & ldate & "'  where gradingid = '" & GradingIDRow & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_gradingALL()
        Dim d As String = "DROPPED"
        Dim z As Double = 0
        Dim nodata As String = ""
        Dim sysdate As Date = Main.datetoday.Text
        Dim ldate As Date = lda.Text
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET remarks = '" & d & "', units = '" & z & "', comment = '" & txtReason.Text & "', systemdate = '" & sysdate & "', lda = '" & ldate & "'  where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and term = '" & sem & "' and levelid = '" & txtlevelid.Text & "' and comment = '" & nodata & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_admission()
        Dim d As String = "DROPPED"
        Dim z As Double = 0
        Dim ldate As Date = lda.Text
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET studentstatus = '" & d & "', remarks = '" & txtReason.Text & "', lda = '" & ldate & "'  where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and term = '" & sem & "' and levelid = '" & txtlevelid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_gradingALLTransfer()
        Dim d As String = "Transfer Out"
        Dim z As Double = 0
        Dim nodata As String = ""
        Dim sysdate As Date = Main.datetoday.Text
        Dim ldate As Date = lda.Text
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET remarks = '" & d & "', units = '" & z & "', comment = '" & txtReason.Text & "', systemdate = '" & sysdate & "', lda = '" & ldate & "'  where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and term = '" & sem & "' and levelid = '" & txtlevelid.Text & "' and comment = '" & nodata & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_admissionTransfer()
        Dim d As String = "Transfer Out"
        Dim ldate As Date = lda.Text
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET studentstatus = '" & d & "', remarks = '" & txtReason.Text & "', lda = '" & ldate & "'  where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and term = '" & sem & "' and levelid = '" & txtlevelid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_grading_todelete()
        Dim r As String = "TO DELETE"
        Dim s As String = ""

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET remarks = '" & r & "'  where gradingid = '" & GradingIDRow & "' AND remarks = '" & s & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub dropSubjects()
        For i = 0 To Me.dtsubjects.RowCount - 1
            GradingIDRow = Me.dtsubjects.Rows(i).Cells("gradingid").Value

            If CBool(Me.dtsubjects.Rows(i).Cells("chk").Value) = True Then

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call update_grading()
                    sqlconn.Close()
                ElseIf sqlconn.State = ConnectionState.Closed Then
                    sqlconn.Open()
                    Call update_grading()
                    sqlconn.Close()

                End If


            End If

        Next
        MsgBox("Update Status Finished")
        txtComment.Text = ""
        commentbox.Enabled = False
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        End If

    End Sub
    Private Sub Updateanddelete()
        For i = 0 To Me.dtsubjects.RowCount - 1
            GradingIDRow = Me.dtsubjects.Rows(i).Cells("gradingid").Value

            If CBool(Me.dtsubjects.Rows(i).Cells("chk").Value) = True Then

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call update_grading_todelete()
                    sqlconn.Close()
                ElseIf sqlconn.State = ConnectionState.Closed Then
                    sqlconn.Open()
                    Call update_grading_todelete()
                    sqlconn.Close()
                End If
            End If
        Next

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call delete_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call delete_subjects()
            sqlconn.Close()
        End If
        MsgBox("Done.")

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjectsenrolled()
            sqlconn.Close()
        End If


    End Sub
    Private Sub delete_subjects()
        Dim s As String = "TO DELETE"
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "Delete from gradingA where remarks = '" & s & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If btnRemove.Text = "Remove Subject" Then
            btnRemove.Text = "Apply Changes"
            btnClose.Text = "Cancel"

            btnDrop.Enabled = False
            btnPrint.Enabled = False
            btnADD.Enabled = False
            btndropstudent.Enabled = False
            btntransferout.Enabled = False

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call Remove_dropped()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call Remove_dropped()
                sqlconn.Close()
            End If
        ElseIf btnRemove.Text = "Apply Changes" Then
            btnRemove.Text = "Remove Subject"
            btnClose.Text = "Close"
            Call Updateanddelete()
            btnPrint.Enabled = True
            btnADD.Enabled = True
            btnDrop.Enabled = True
            btndropstudent.Enabled = True
            btntransferout.Enabled = True


        End If
    End Sub
    Private Sub print_registration()
        Dim sqlQRY1 As String = "select * FROM admissionVIEW where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ;"
        Dim sqlQRY2 As String = "select * FROM subjectenrolledview where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ORDER BY subjectcode ASC;"
        Dim sqlQRY3 As String = "select * FROM studentdata where studentid = '" & studid.Text & "'"



        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)
        Dim cmdexec3 As SqlCommand = New SqlCommand(sqlQRY3, sqlconn)


        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)
        Dim da3 As SqlDataAdapter = New SqlDataAdapter(sqlQRY3, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da1.Fill(ds, "admissionView")
        da2.Fill(ds, "subjectEnrolledView")
        da3.Fill(ds, "studentdata")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptSubjectEnrolledBE = New rptSubjectEnrolledBE

        mReport.SetDataSource(ds)

        Dim pname As String = prnName
        Dim pprname As String = paperName

        Dim i As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = pname
        Dim rawKind As Integer
        For i = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = pprname Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                Exit For
            End If
        Next
        mReport.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize) '
        Report.CrystalReportViewer1.ReportSource = mReport
        mReport.PrintToPrinter(1, False, 0, 0)


        Report.CrystalReportViewer1.ReportSource = mReport

        'Report.ShowDialog()
    End Sub
    Private Sub print_registrationAcct()
        Dim sqlQRY1 As String = "select * FROM admissionVIEW where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ;"
        Dim sqlQRY2 As String = "select * FROM subjectenrolledview where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ORDER BY subjectcode ASC;"
        Dim sqlQRY3 As String = "select * FROM studentdata where studentid = '" & studid.Text & "'"



        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)
        Dim cmdexec3 As SqlCommand = New SqlCommand(sqlQRY3, sqlconn)


        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)
        Dim da3 As SqlDataAdapter = New SqlDataAdapter(sqlQRY3, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da1.Fill(ds, "admissionView")
        da2.Fill(ds, "subjectEnrolledView")
        da3.Fill(ds, "studentdata")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptSubjectEnrolledBEAcct = New rptSubjectEnrolledBEAcct

        mReport.SetDataSource(ds)

        Dim pname As String = prnName
        Dim pprname As String = paperName

        Dim i As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = pname
        Dim rawKind As Integer
        For i = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = pprname Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                Exit For
            End If
        Next
        mReport.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize) '
        Report.CrystalReportViewer1.ReportSource = mReport
        mReport.PrintToPrinter(1, False, 0, 0)


        Report.CrystalReportViewer1.ReportSource = mReport

        'Report.ShowDialog()
    End Sub
    Private Sub print_registration_LIB()
        Dim sqlQRY1 As String = "select * FROM admissionVIEW where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ;"
        Dim sqlQRY2 As String = "select * FROM subjectenrolledview where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ORDER BY subjectcode ASC;"
        Dim sqlQRY3 As String = "select * FROM studentdata where studentid = '" & studid.Text & "'"



        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)
        Dim cmdexec3 As SqlCommand = New SqlCommand(sqlQRY3, sqlconn)


        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)
        Dim da3 As SqlDataAdapter = New SqlDataAdapter(sqlQRY3, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da1.Fill(ds, "admissionView")
        da2.Fill(ds, "subjectEnrolledView")
        da3.Fill(ds, "studentdata")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptSubjectEnrolledBE_Library = New rptSubjectEnrolledBE_Library

        mReport.SetDataSource(ds)

        Dim pname As String = prnName
        Dim pprname As String = paperName

        Dim i As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        doctoprint.PrinterSettings.PrinterName = pname
        Dim rawKind As Integer
        For i = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = pprname Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                Exit For
            End If
        Next
        mReport.PrintOptions.PaperSize = CType(rawKind, CrystalDecisions.Shared.PaperSize) '
        Report.CrystalReportViewer1.ReportSource = mReport
        mReport.PrintToPrinter(1, False, 0, 0)


        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub


    Private Sub print_classcard()
        Dim sqlQRY1 As String = "select * FROM admissionVIEW where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ;"
        Dim sqlQRY2 As String = "select * FROM subjectenrolledview where studentid = '" & studid.Text & "'AND sy = '" & txtSY.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & sem & "' ORDER BY subjectcode ASC;"
        Dim sqlQRY3 As String = "select * FROM studentdata where studentid = '" & studid.Text & "'"



        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)
        Dim cmdexec3 As SqlCommand = New SqlCommand(sqlQRY3, sqlconn)


        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)
        Dim da3 As SqlDataAdapter = New SqlDataAdapter(sqlQRY3, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da1.Fill(ds, "admissionView")
        da2.Fill(ds, "subjectEnrolledView")
        da3.Fill(ds, "studentdata")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptClassCard = New rptClassCard

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call print_registration()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_registration()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call print_registrationAcct()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_registrationAcct()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call print_registration_LIB()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_registration_LIB()
            sqlconn.Close()
        End If


    End Sub


    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btntransferout.Click
        If btntransferout.Text = "Transfer Out" Then
            btntransferout.Text = "Apply Changes"
            btnPrint.Enabled = False
            btnADD.Enabled = False
            btnRemove.Enabled = False
            btndropstudent.Enabled = False
            btnDrop.Enabled = False
            btnClose.Text = "Cancel"

            commentbox.Enabled = True


        ElseIf btntransferout.Text = "Apply Changes" Then

            If String.IsNullOrEmpty(txtComment.Text) Then
                MessageBox.Show("Please add comment/remarks")
                txtComment.Focus()
            ElseIf String.IsNullOrEmpty(lda.Text) Then
                MessageBox.Show("Please enter the last date of attendance")
                lda.Focus()
            Else
                Dim result = MessageBox.Show("Are you sure you want to Transfer Out the student and update all his/her subjects enrolled?", "Student Information", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    If sqlconn.State = ConnectionState.Open Then
                        sqlconn.Close()
                        sqlconn.Open()
                        Call update_gradingALLTransfer()
                        Call update_admissionTransfer()
                        sqlconn.Close()
                    ElseIf sqlconn.State = ConnectionState.Closed Then
                        sqlconn.Open()
                        Call update_gradingALLTransfer()
                        Call update_admissionTransfer()
                        sqlconn.Close()
                    End If

                    dtsubjects.Columns.Clear()
                    If sqlconn.State = ConnectionState.Open Then
                        sqlconn.Close()
                        sqlconn.Open()
                        Call fetch_subjectsenrolled()
                        sqlconn.Close()
                    Else
                        sqlconn.Open()
                        Call fetch_subjectsenrolled()
                        sqlconn.Close()
                    End If

                    txtStatus.Text = "Transfer Out"

                    btntransferout.Text = "Transfer Out"
                    btnPrint.Enabled = True
                    btnADD.Enabled = True
                    btnRemove.Enabled = True
                    btndropstudent.Enabled = True
                    btntransferout.Enabled = True
                    btnDrop.Enabled = True
                    lda.Text = ""
                    txtComment.Text = ""
                    btnClose.Text = "Close"

                End If
            End If

        End If
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As System.EventArgs) Handles txtStatus.TextChanged
        If txtStatus.Text = "Enrolled" Or txtStatus.Text = "ENROLLED" Then
            txtStatus.BackColor = Color.LightBlue
            btnADD.Enabled = True
            btnRemove.Enabled = True
            btnDrop.Enabled = True
            btndropstudent.Enabled = True
            btntransferout.Enabled = True
        ElseIf txtStatus.Text = "DROPPED" Or txtStatus.Text = "Dropped" Then
            txtStatus.BackColor = Color.Red
            btnADD.Enabled = False
            btnRemove.Enabled = False
            btnDrop.Enabled = False
            btndropstudent.Enabled = False
            btntransferout.Enabled = False
        ElseIf txtStatus.Text = "Transfer Out" Then
            txtStatus.BackColor = Color.Pink
            btnADD.Enabled = False
            btnRemove.Enabled = False
            btnDrop.Enabled = False
            btndropstudent.Enabled = False
            btntransferout.Enabled = False
        ElseIf txtStatus.Text = "" Then
            txtStatus.BackColor = Color.LightGray
            btnADD.Enabled = True
            btnRemove.Enabled = True
            btnDrop.Enabled = True
            btndropstudent.Enabled = True
            btntransferout.Enabled = True
        End If
    End Sub


    Private Sub DateTimePicker1_Enter(sender As Object, e As System.EventArgs) Handles DateTimePicker1.Enter, DateTimePicker1.ValueChanged
        lda.Text = DateTimePicker1.Text
    End Sub

    Private Sub btndropstudent_Click(sender As System.Object, e As System.EventArgs) Handles btndropstudent.Click
        If btndropstudent.Text = "Drop Student" Then
            btndropstudent.Text = "Apply Changes"
            btnPrint.Enabled = False
            btnADD.Enabled = False
            btnRemove.Enabled = False
            btntransferout.Enabled = False
            btnDrop.Enabled = False
            btnClose.Text = "Cancel"

            commentbox.Enabled = True


        ElseIf btndropstudent.Text = "Apply Changes" Then

            If String.IsNullOrEmpty(txtComment.Text) Then
                MessageBox.Show("Please add comment/remarks")
                txtComment.Focus()
            ElseIf String.IsNullOrEmpty(lda.Text) Then
                MessageBox.Show("Please enter the last date of attendance")
                lda.Focus()
            Else
                Dim result = MessageBox.Show("Are you sure you want to DROPPED the student and all his/her subjects enrolled?", "Student Information", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    If sqlconn.State = ConnectionState.Open Then
                        sqlconn.Close()
                        sqlconn.Open()
                        Call update_gradingALL()
                        Call update_admission()
                        sqlconn.Close()
                    ElseIf sqlconn.State = ConnectionState.Closed Then
                        sqlconn.Open()
                        Call update_gradingALL()
                        Call update_admission()
                        sqlconn.Close()
                    End If

                    dtsubjects.Columns.Clear()
                    If sqlconn.State = ConnectionState.Open Then
                        sqlconn.Close()
                        sqlconn.Open()
                        Call fetch_subjectsenrolled()
                        sqlconn.Close()
                    Else
                        sqlconn.Open()
                        Call fetch_subjectsenrolled()
                        sqlconn.Close()
                    End If

                    txtStatus.Text = "DROPPED"

                    btndropstudent.Text = "Drop Student"
                    btnPrint.Enabled = True
                    btnADD.Enabled = True
                    btnRemove.Enabled = True
                    btntransferout.Enabled = True
                    btnDrop.Enabled = True
                    btndropstudent.Enabled = True
                    lda.Text = ""
                    txtComment.Text = ""
                    btnClose.Text = "Close"
                ElseIf result = DialogResult.No Then


                End If
            End If

        End If

    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As System.EventArgs) Handles txtComment.TextChanged
        If txtComment.Text = "Others" Then
            txtReason.Enabled = True
            txtReason.ReadOnly = False
            txtReason.Text = ""
            txtReason.Focus()
        Else
            txtReason.Text = txtComment.Text
        End If

    End Sub

    Private Sub txtReason_Leave(sender As Object, e As System.EventArgs) Handles txtReason.Leave
        txtReason.ReadOnly = True
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        printer.pcname.Text = pcname.Text
        printer.frm.Text = Me.frmname
        printer.ShowDialog()

    End Sub

    Private Sub update_classscheduleid()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET classscheduleid = '" & classscheduleid.Text & "'  where studentid = '" & studid.Text & "' AND gradingid = '" & txtGradingID.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Update Complete")
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnchangesched.Click

        If btnchangesched.Text = "Change Schedule" Then
            btnchangesched.Text = "Apply Changes"

            frmSubjectCurrentSked.txtSubjectID.Text = txtsubjectID.Text
            frmSubjectCurrentSked.sy.Text = txtSY.Text
            frmSubjectCurrentSked.term.Text = sem

            frmSubjectCurrentSked.ShowDialog()

        ElseIf btnchangesched.Text = "Apply Changes" Then

            If sqlconn.State = ConnectionState.Open Then

                Call update_classscheduleid()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_classscheduleid()
                sqlconn.Close()
            End If

            txtGradingID.Text = ""
            txtsubjectID.Text = ""
            classscheduleid.Text = ""

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_subjectsenrolled()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_subjectsenrolled()
                sqlconn.Close()
            End If

            btnchangesched.Text = "Change Schedule"
        End If


    End Sub

    Private Sub txtGradingID_TextChanged(sender As Object, e As EventArgs) Handles txtGradingID.TextChanged
        If txtGradingID.Text = "" Then
            btnchangesched.Enabled = False
        ElseIf txtGradingID.Text = String.Empty = False Then
            btnchangesched.Enabled = True
        End If
    End Sub
    Private Sub fetch_section()
        Dim cmdsection As New SqlCommand("select * FROM section " &
                     "where (category = '" & txtCategory.Text & "' AND level = '" & txtLevel.Text & "') or( category = '" & txtCategoryA.Text & "' AND level = '" & txtLevel.Text & "');", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "course")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)

            cmbSection.DataSource = ds_section.Tables(0)
            cmbSection.ValueMember = "sectioname"
            cmbSection.DisplayMember = "sectioname"
        End If
    End Sub

    Private Sub update_sectionID()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET section = '" & sectionID & "' where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and term = '" & sem & "' and levelid = '" & txtlevelid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub fetch_sectionid()
        sqlcmd.CommandText = "select  * FROM section where (category = '" & txtCategory.Text & "' AND sectioname = '" & cmbSection.Text & "') OR (category = '" & txtCategoryA.Text & "' AND sectioname = '" & cmbSection.Text & "')"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            sectionID = daMyname.Item("sectionid")
        Else
            sectionID = 0
        End If

    End Sub

    Private Sub btnsection_Click(sender As Object, e As EventArgs) Handles btnsection.Click
        If btnsection.Text = "CHANGE SECTION" Then
            cmbSection.Enabled = True
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_section()
                sqlconn.Close()
            End If
            btnsection.Text = "UPDATE SECTION"
        ElseIf btnsection.Text = "UPDATE SECTION" Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_sectionID()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_sectionID()
                sqlconn.Close()
            End If

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_EnrollmentHistory()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_EnrollmentHistory()
                sqlconn.Close()
            End If


            btnsection.Text = "CHANGE SECTION"
            cmbSection.Enabled = False
        End If
    End Sub

    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
        txtSectioname.Text = cmbSection.Text

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sectionid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionid()
            sqlconn.Close()
        End If
        TextBox8.Text = sectionID
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged

    End Sub



    Private Sub DeleteAdmissionEntry()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "Delete from admission where studentID = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and levelid = '" & txtlevelid.Text & "' and term = '" & sem & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Admission Entry successfully deleted")
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        If btnStatus.Text = "Update Status" Then
            cmbStatus.Visible = True
            btnStatus.Text = "Apply"
        ElseIf btnStatus.Text = "Apply" Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call UpdateAdmissionEntry()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call UpdateAdmissionEntry()
                sqlconn.Close()
                btnStatus.Text = "Update Status"
                txtStatus.Text = cmbStatus.Text
                cmbStatus.Visible = False
            End If
        End If
    End Sub

    Private Sub DeleteGradingEntry()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "Delete from gradingA where studentid = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and levelid = '" & txtlevelid.Text & "' and term = '" & sem & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Grading Entry successfully deleted")
    End Sub
    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dlg As New DeleteAdmission
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call DeleteAdmissionEntry()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call DeleteAdmissionEntry()
                sqlconn.Close()
            End If
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call DeleteGradingEntry()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call DeleteGradingEntry()
                sqlconn.Close()
            End If
        Else

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call print_classcard()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_classcard()
            sqlconn.Close()
        End If
    End Sub


    Private Sub btnChangeCourse_Click(sender As Object, e As EventArgs) Handles btnChangeCourse.Click
        CourseChange.studid.Text = studid.Text
        CourseChange.surname.Text = surname.Text
        CourseChange.txtCourseID.Text = txtcourseid.Text
        CourseChange.cmbCourse.Text = txtCourse.Text
        CourseChange.c_code.Text = txtCourseCode.Text
        CourseChange.cmbMajor.Text = txtMajor.Text
        CourseChange.txtTerm.Text = sem
        CourseChange.sy.Text = txtSY.Text
        CourseChange.Show()
    End Sub

    Private Sub txttotalsubjects_TextChanged(sender As Object, e As EventArgs) Handles txttotalsubjects.TextChanged
        If txttotalsubjects.Text = "" Then
            btnChangeCourse.Enabled = True
        ElseIf txttotalsubjects.Text >= 1 Then
            btnChangeCourse.Enabled = False
        ElseIf txttotalsubjects.Text = 0 Then
            btnChangeCourse.Enabled = True
        End If
    End Sub

    Private Sub UpdateAdmissionEntry()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "Update admission  SET studentstatus = '" & cmbStatus.Text & "' where studentID = '" & studid.Text & "' and sy = '" & txtSY.Text & "' and levelid = '" & txtlevelid.Text & "' and term = '" & sem & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Student Status updated!")
    End Sub


End Class