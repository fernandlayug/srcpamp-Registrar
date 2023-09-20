Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjectStudentsBE
    Dim selectedprint As String
    Dim category As String
    Dim AY As ComboBox
    '  Dim yrlevel As ComboBox
    Public cay As String
    Dim categoryFaculty As String

    Private Sub frmSubjectStudentsBE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        ' cay = Main.SY.Text



        cmbTermCourse.Text = 4
        cmbTermCourse.Enabled = False
        txtTerm.Text = cmbTermCourse.Text


    End Sub
    Private Sub cmblevelcourse_TExt(sender As System.Object, e As System.EventArgs) Handles cmbLevelCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_section()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_section()
            sqlconn.Close()
        End If
    End Sub


    Private Sub fetch_txtlevelid()
        Dim level As Integer = 15
        sqlcmd.CommandText = "select * FROM level Where (yrlevel = '" & cmbLevelCourse.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            txtLevelID.Text = daMyname("levelid")
        Else
            txtLevelID.Text = 0

        End If
    End Sub

    'Private Sub tabCourse_Enter(sender As System.Object, e As System.EventArgs) Handles tabCourse.Enter
    '    'chkCollegeCourse.Checked = False
    '    'chkSeniorCourse.Checked = False

    '    btnEnrollees.Text = "Print Course Enrollees"

    '    selectedprint = "course"
    '    groupCourse.Visible = True
    '    groupSubject.Visible = False
    '    btnAlphalist.Enabled = True
    '    btnAlphalistSection.Enabled = True
    '    btnSummary.Enabled = True
    '    'cmbTermCourse.Text = ""
    '    'dtPrint.Columns.Clear()

    '    'If chkJuniorHS.Checked = True Then
    '    '    category = "Junior HS"
    '    '    If sqlconn.State = ConnectionState.Open Then
    '    '        Call fetch_yrlevel()
    '    '        sqlconn.Close()
    '    '    Else
    '    '        sqlconn.Open()
    '    '        Call fetch_yrlevel()
    '    '        sqlconn.Close()
    '    '    End If
    '    'ElseIf chkElementary.Checked = True Then
    '    '    category = "Elementary"
    '    '    If sqlconn.State = ConnectionState.Open Then
    '    '        Call fetch_yrlevel()
    '    '        sqlconn.Close()
    '    '    Else
    '    '        sqlconn.Open()
    '    '        Call fetch_yrlevel()
    '    '        sqlconn.Close()
    '    '    End If
    '    'End If

    '    'If sqlconn.State = ConnectionState.Open Then
    '    '    Call fetch_course()
    '    '    sqlconn.Close()
    '    'Else
    '    '    sqlconn.Open()
    '    '    Call fetch_course()
    '    '    sqlconn.Close()
    '    'End If

    '    AY = cmbAYCourse

    '    If sqlconn.State = ConnectionState.Open Then
    '        Call fetch_sy()
    '        sqlconn.Close()
    '    Else
    '        sqlconn.Open()
    '        Call fetch_sy()
    '        sqlconn.Close()
    '    End If

    '    'yrlevel = cmbLevelCourse


    'End Sub

    Private Sub tabFaculty_Enter(sender As Object, e As System.EventArgs) Handles tabFaculty.Enter
        'chkCollegeSubject.Checked = False
        'chkSeniorSubject.Checked = False

        btnEnrollees.Text = "Print Class List"

        selectedprint = "faculty"
        groupCourse.Visible = False
        groupSubject.Visible = False
        'cmbTermSubject.Text = ""
        btnAlphalist.Enabled = False
        btnAlphalistSection.Enabled = False
        btnSummary.Enabled = False





    End Sub
    Private Sub fetch_section()
        'Dim category As String = "college"
        Dim cmdsection As New SqlCommand("select *  FROM section where category = '" & category & "' and level = '" & cmbLevelCourse.Text & "';", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "section")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)
            cmbSection.DataSource = ds_section.Tables(0)
            cmbSection.ValueMember = "sectioname"
            cmbSection.DisplayMember = "sectioname"

        End If
    End Sub
    Private Sub fetch_course()

        Dim obj As Object = DBNull.Value
        Dim cmd As New SqlCommand("select * FROM course Where (coursecategory = '" & category & "')  order by coursename ASC;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "course")) Then

            dtPrint.Columns.Clear()

            dtPrint.DataSource = ds.Tables(0)

            Dim chk As New DataGridViewCheckBoxColumn
            dtPrint.Columns("courseid").Visible = False
            dtPrint.Columns("coursecategory").Visible = False

            dtPrint.Columns("coursecode").DisplayIndex = 1
            dtPrint.Columns("coursecode").Width = 60
            dtPrint.Columns("coursecode").HeaderText = "Code"

            dtPrint.Columns("coursename").DisplayIndex = 2
            dtPrint.Columns("coursename").HeaderText = "Course"
            dtPrint.Columns("coursename").Width = 400

            dtPrint.Columns("coursemajor").DisplayIndex = 3
            dtPrint.Columns("coursemajor").HeaderText = "Major"
            dtPrint.Columns("coursemajor").Width = 170
            dtPrint.Columns("coursemajor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Else
            dtPrint.DataSource = Nothing
        End If
    End Sub

    Private Sub fetch_faculty()
        Dim category As String = "COL Faculty"
        Dim stat As Boolean = True
        Dim obj As Object = DBNull.Value
        Dim str As String = "select designation, designation1, designation2, p, p1, p2, surname + ', ' + firstname as name, id FROM employee WHERE (designation = '" & categoryFaculty & "' and p = '" & stat & "') or (designation1 = '" & categoryFaculty & "' and p1 = '" & stat & "') or (designation2 = '" & categoryFaculty & "' and p2 = '" & stat & "') order by surname asc;"
        Dim cmd As New SqlCommand(str, sqlconn)


        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "employee")) Then


            dtFaculty.DataSource = ds.Tables(0)
            dtFaculty.Columns("designation").Visible = False
            dtFaculty.Columns("designation1").Visible = False
            dtFaculty.Columns("designation2").Visible = False
            dtFaculty.Columns("p").Visible = False
            dtFaculty.Columns("p1").Visible = False
            dtFaculty.Columns("p2").Visible = False
            dtFaculty.Columns("id").Visible = False



            dtFaculty.Columns("name").DisplayIndex = 1
            dtFaculty.Columns("name").Width = 160
            dtFaculty.Columns("name").HeaderText = "Name"



            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else


        End If
    End Sub


    Private Sub chkCollege_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkJuniorHS.CheckedChanged, chkElementary.CheckedChanged
        If chkJuniorHS.Checked = True Then
            category = "Junior HS"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_course()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_course()
                sqlconn.Close()
            End If

            If sqlconn.State = ConnectionState.Open Then
                Call fetch_yrlevel()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_yrlevel()
                sqlconn.Close()
            End If
        ElseIf chkElementary.Checked = True Then
            category = "Elementary"

            If sqlconn.State = ConnectionState.Open Then
                Call fetch_course()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_course()
                sqlconn.Close()
            End If
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_yrlevel()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_yrlevel()
                sqlconn.Close()
            End If
        End If



        ' yrlevel = cmbLevelCourse


    End Sub

    Private Sub fetch_sy()
        Dim cmdsy As New SqlCommand("Select * FROM sy order by sy DESC;", sqlconn)
        Dim adptsy As New SqlDataAdapter(cmdsy)
        Dim ds_sy As New DataSet

        If (adptsy.Fill(ds_sy, "sy")) Then
            AY.DataSource = ds_sy.Tables(0)
            AY.ValueMember = "sy"
            AY.DisplayMember = "sy"

        End If
    End Sub
    Private Sub fetch_yrlevel()
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & category & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then


            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
            ' yrlevel.Items.Insert(0,New ("name"))
            ' yrlevel.Items.Insert(0, "All")

            'yrlevel.DataSource = ds_level.Tables(0)
            cmbLevelCourse.DataSource = ds_level.Tables(0)
            cmbLevelCourse.ValueMember = "yrlevel"
            cmbLevelCourse.DisplayMember = "yrlevel"


        End If
    End Sub





    Private Sub print_percourse()
        Dim sqlQRY1 As String = "select * FROM AdmissionView where courseid = '" & txtcoursecode.Text & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' and studentstatus = '" & cmbStatus.Text & "'  order by sex desc, surname asc;"
        Dim sqlQRY2 As String = "select * FROM AdmissionUnits where sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "'"


        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "AdmissionView")
        da2.Fill(ds, "AdmissionUnits")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptCourseEnrolleesAll = New rptCourseEnrolleesAll

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_perfaculty()
        Try

            Dim sqlQRY1 As String = "select * FROM SubjectsStudentsView where classscheduleid = '" & txtclassid.Text & "' and sy = '" & cay & "' and term = '" & txtTerm.Text & "' order by sex desc, surname asc;"
            ' Dim sqlQRY1 As String = "select * FROM SubjectsStudentsView where subjectid = '" & txtsubjectid.Text & "' and sy = '" & cmbAySubject.Text & "' and term = '" & txtTerm.Text & "' and section = '" & sectionid.Text & "'  order by sex desc, surname asc;"

            Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

            'create data adapter

            Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

            'create dataset
            Dim ds As DataSet = New DataSet

            'fill dataset

            da1.Fill(ds, "SubjectsStudentsView")

            Dim Report As printrpt = New printrpt

            Dim mReport As rptSubjectEnrolleesBE = New rptSubjectEnrolleesBE

            mReport.SetDataSource(ds)

            Report.CrystalReportViewer1.ReportSource = mReport

            Report.ShowDialog()
        Catch ex As Exception
            MsgBox("Can't print report! Please select faculty schedule first." & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub print_SummaryCourse()

        Dim sqlQRY1 As String = "select * FROM AdmissionView where coursecategory = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and studentstatus = '" & cmbStatus.Text & "'  order by levelid ASC;"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "AdmissionView")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptCourseEnrolleesSummaryBE = New rptCourseEnrolleesSummaryBE

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_alphalist()
        Dim sqlQRY2 As String = "select * FROM AdmissionInfo where category = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and studentstatus = '" & cmbStatus.Text & "' order by surname ASC"


        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)

        'create data adapter


        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset


        da2.Fill(ds, "AdmissionInfo")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptAdmissionAlpha = New rptAdmissionAlpha

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_alphalistsection()
        Dim sqlQRY2 As String = "select * FROM AdmissionInfo where category = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and courseid = '" & txtcoursecode.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' and sectioname = '" & cmbSection.Text & "' and studentstatus = '" & cmbStatus.Text & "' order by surname ASC"


        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)

        'create data adapter


        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset


        da2.Fill(ds, "AdmissionInfo")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptAlphalistSection = New rptAlphalistSection

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub

    Private Sub print_perfacultySummary()
        Dim sqlQRY1 As String = "select * FROM FacultySubjectsView where facultyid = '" & txtFacultyID.Text & "' order by sex desc, studentsname asc;"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "FacultySubjectsView")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptFacultySubjectsSummary = New rptFacultySubjectsSummary

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub

    Private Sub print_persection()
        ' Dim stat As String = "Enrolled"
        Dim sqlQRY1 As String = "select * FROM AdmissionView where courseid = '" & txtcoursecode.Text & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' and sectioname = '" & cmbSection.Text & "' and studentstatus = '" & cmbStatus.Text & "'order by surname asc;"



        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)


        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)


        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "AdmissionView")


        Dim Report As printrpt = New printrpt

        Dim mReport As rptCourseEnrolleesSectionBE = New rptCourseEnrolleesSectionBE

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_persectionTES()
        Dim sqlQRY1 As String = "select * FROM AdmissionView where courseid = '" & txtcoursecode.Text & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' and sectioname = '" & cmbSection.Text & "'order by surname asc;"
        Dim sqlQRY2 As String = "select * FROM AdmissionUnits where sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "'"


        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)
        Dim cmdExec2 As SqlCommand = New SqlCommand(sqlQRY2, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter(sqlQRY2, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "AdmissionView")
        da2.Fill(ds, "AdmissionUnits")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptCourseEnrolleesTES = New rptCourseEnrolleesTES

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub btnEnrollees_Click(sender As System.Object, e As System.EventArgs) Handles btnEnrollees.Click
        If btnEnrollees.Text = "Print Course Enrollees" Then
            If sqlconn.State = ConnectionState.Open Then
                Call print_percourse()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_percourse()
                sqlconn.Close()
            End If

        ElseIf btnEnrollees.Text = "Print Class List" Then
            If sqlconn.State = ConnectionState.Open Then
                Call print_perfaculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_perfaculty()
                sqlconn.Close()
            End If
        End If
    End Sub

    Private Sub cmbTermCourse_TextChanged(sender As Object, e As System.EventArgs) Handles cmbTermCourse.TextChanged
        If cmbTermCourse.Text = "1st Semester" Then
            txtTerm.Text = 1
        ElseIf cmbTermCourse.Text = "2nd Semester" Then
            txtTerm.Text = 2
        ElseIf cmbTermCourse.Text = "Summer" Then
            txtTerm.Text = 3
        ElseIf cmbTermCourse.Text = "All" Then
            txtTerm.Text = 4
        End If

    End Sub


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSummary_Click(sender As System.Object, e As System.EventArgs) Handles btnSummary.Click
        If selectedprint = "course" Then
            If sqlconn.State = ConnectionState.Open Then
                Call print_SummaryCourse()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_SummaryCourse()
                sqlconn.Close()
            End If
        ElseIf selectedprint = "faculty" Then
            If sqlconn.State = ConnectionState.Open Then
                Call print_perfacultySummary()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_perfacultySummary()
                sqlconn.Close()
            End If
        ElseIf selectedprint = "subject" Then

        End If
    End Sub

    Private Sub chkCollegeFaculty_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkElementaryFaculty.CheckedChanged, chkJuniorHSFaculty.CheckedChanged
        If chkElementaryFaculty.Checked = True Then
            dtPrint.Columns.Clear()
            categoryFaculty = "ELEM Faculty"
            txtTerm.Text = 4
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_faculty()
                sqlconn.Close()

            End If

        ElseIf chkJuniorHSFaculty.Checked = True Then
            dtPrint.Columns.Clear()
            categoryFaculty = "HS Faculty"
            txtTerm.Text = 4
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_faculty()
                sqlconn.Close()

            End If
        End If


        dtPrint.Columns.Clear()

    End Sub
    Private Sub fetch_facultysubject()
        'Dim str As String = "select surname +', ' + firstname as name, subjectcode, subjectdescription, days, time, room, CAY, Cterm, coursecode FROM FacultyScheduleView WHERE (facultyid = '" & txtFacultyID.Text & "' and CAY = '" & cay & "' and Cterm = '" & txtTerm.Text & "');"
        Dim str As String = "select surname +', ' + firstname as name, subjectcode, subjectdescription, days, time, room, sy, term, coursecode, yrlevel, sectioname, facultyid, classscheduleid FROM ClassScheduleView WHERE (facultyid = '" & txtFacultyID.Text & "' and sy = '" & cay & "' and term = '" & txtTerm.Text & "');"

        Dim cmd As New SqlCommand(str, sqlconn)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "FacultyScheduleView")) Then
                dtPrint.Columns.Clear()

                dtPrint.DataSource = ds.Tables(0)

                dtPrint.Columns("sy").Visible = False
                dtPrint.Columns("term").Visible = False
                dtPrint.Columns("classscheduleid").Visible = False
            'dtPrint.Columns("facultyid").Visible = False
            dtPrint.Columns("coursecode").Visible = False
            dtPrint.Columns("subjectcode").Visible = False

            dtPrint.Columns("facultyid").DisplayIndex = 0
            dtPrint.Columns("facultyid").Width = 100
            dtPrint.Columns("facultyid").HeaderText = "FacultyID"

            dtPrint.Columns("name").DisplayIndex = 1
            dtPrint.Columns("name").Width = 160
                dtPrint.Columns("name").HeaderText = "Name"

            dtPrint.Columns("yrlevel").DisplayIndex = 2
            dtPrint.Columns("yrlevel").Width = 160
                dtPrint.Columns("yrlevel").HeaderText = "Level"

            dtPrint.Columns("sectioname").DisplayIndex = 3
            dtPrint.Columns("sectioname").Width = 100
            dtPrint.Columns("sectioname").HeaderText = "Section"

            dtPrint.Columns("subjectdescription").DisplayIndex = 4
            dtPrint.Columns("subjectdescription").Width = 150
            dtPrint.Columns("subjectdescription").HeaderText = "Subject"

            dtPrint.Columns("days").DisplayIndex = 5
            dtPrint.Columns("days").Width = 40
                dtPrint.Columns("days").HeaderText = "Day"

            dtPrint.Columns("time").DisplayIndex = 6
            dtPrint.Columns("time").Width = 120
                dtPrint.Columns("time").HeaderText = "Time"

            dtPrint.Columns("room").DisplayIndex = 7
            dtPrint.Columns("room").Width = 100
                dtPrint.Columns("room").HeaderText = "Room"


            Else

                dtPrint.Columns.Clear()
                txtlevel.Text = ""

            End If

    End Sub

    Private Sub dtFaculty_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtFaculty.CellClick, dtFaculty.CellEnter

        Dim myVariable As String = dtFaculty.CurrentRow.Cells("id").Value.ToString
        txtFacultyID.Text = myVariable


        If sqlconn.State = ConnectionState.Open Then
            Call fetch_facultysubject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_facultysubject()
            sqlconn.Close()

        End If
    End Sub


    Private Sub cmbLevelCourse_TextChanged(sender As Object, e As System.EventArgs) Handles cmbLevelCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_txtlevelid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_txtlevelid()
            sqlconn.Close()

        End If
    End Sub




    Private Sub dtPrint_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPrint.CellClick

        If selectedprint = "course" Then
            Dim myVariable As String = dtPrint.CurrentRow.Cells("coursename").Value.ToString
            txtcoursename.Text = myVariable

            Dim myVariable2 As String = dtPrint.CurrentRow.Cells("coursemajor").Value.ToString
            txtMajor.Text = myVariable2

            Dim myVariable3 As String = dtPrint.CurrentRow.Cells("courseid").Value.ToString
            txtcoursecode.Text = myVariable3

        ElseIf selectedprint = "subject" Then
            Dim myVariable As String = dtPrint.CurrentRow.Cells("subjectdescription").Value.ToString
            txtSubject.Text = myVariable

            Dim myVariable2 As String = dtPrint.CurrentRow.Cells("subjectcode").Value.ToString
            txtcode.Text = myVariable2

            Dim myVariable3 As String = dtPrint.CurrentRow.Cells("days").Value.ToString
            txtday.Text = myVariable3

            Dim myVariable4 As String = dtPrint.CurrentRow.Cells("time").Value.ToString
            txttime.Text = myVariable4

            Dim myVariable5 As String = dtPrint.CurrentRow.Cells("room").Value.ToString
            txtroom.Text = myVariable5

            Dim myVariable6 As String = dtPrint.CurrentRow.Cells("yrlevel").Value.ToString
            txtlevel.Text = myVariable6

            Dim myVariable7 As String = dtPrint.CurrentRow.Cells("subjectid").Value.ToString
            txtsubjectid.Text = myVariable7

            Dim myVariable9 As String = dtPrint.CurrentRow.Cells("sectionid").Value.ToString
            sectionid.Text = myVariable9

            Dim myVariable10 As String = dtPrint.CurrentRow.Cells("classscheduleid").Value.ToString
            classscheduleid.Text = myVariable10

        ElseIf selectedprint = "faculty" Then
            Dim myVariable11 As String = dtPrint.CurrentRow.Cells("classscheduleid").Value.ToString
            txtclassid.Text = myVariable11

            Dim myVariable12 As String = dtPrint.CurrentRow.Cells("facultyid").Value.ToString
            txtfaculty.Text = myVariable12
        End If

    End Sub


    Private Sub btnPrintSection_Click(sender As Object, e As EventArgs) Handles btnPrintSection.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_persection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_persection()
            sqlconn.Close()

        End If
    End Sub

    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
        If cmbSection.Text = String.Empty = False Then
            btnPrintSection.Visible = True
        Else
            btnPrintSection.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAlphalist.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_alphalist()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_alphalist()
            sqlconn.Close()

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAlphalistSection.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_alphalistsection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_alphalistsection()
            sqlconn.Close()

        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If sqlconn.State = ConnectionState.Open Then
            Call print_persectionTES()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_persectionTES()
            sqlconn.Close()

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
        'chkCollegeCourse.Checked = False
        'chkSeniorCourse.Checked = False

        btnEnrollees.Text = "Print Course Enrollees"

        selectedprint = "course"
        groupCourse.Visible = True
        groupSubject.Visible = False
        btnAlphalist.Enabled = True
        btnAlphalistSection.Enabled = True
        btnSummary.Enabled = True
        'cmbTermCourse.Text = ""
        'dtPrint.Columns.Clear()

        'If chkJuniorHS.Checked = True Then
        '    category = "Junior HS"
        '    If sqlconn.State = ConnectionState.Open Then
        '        Call fetch_yrlevel()
        '        sqlconn.Close()
        '    Else
        '        sqlconn.Open()
        '        Call fetch_yrlevel()
        '        sqlconn.Close()
        '    End If
        'ElseIf chkElementary.Checked = True Then
        '    category = "Elementary"
        '    If sqlconn.State = ConnectionState.Open Then
        '        Call fetch_yrlevel()
        '        sqlconn.Close()
        '    Else
        '        sqlconn.Open()
        '        Call fetch_yrlevel()
        '        sqlconn.Close()
        '    End If
        'End If

        'If sqlconn.State = ConnectionState.Open Then
        '    Call fetch_course()
        '    sqlconn.Close()
        'Else
        '    sqlconn.Open()
        '    Call fetch_course()
        '    sqlconn.Close()
        'End If

        AY = cmbAYCourse

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_sy()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        End If

        'yrlevel = cmbLevelCourse

    End Sub
End Class