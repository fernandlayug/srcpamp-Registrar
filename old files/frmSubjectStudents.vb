﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjectStudents
    Dim selectedprint As String
    Dim category As String
    Dim AY As ComboBox
    Dim yrlevel As ComboBox
    Dim cay As String
    Private Sub frmSubjectStudents_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        cay = Main.SY.Text


        If sqlconn.State = ConnectionState.Open Then
            Call fetch_cmbourse()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_cmbourse()
            sqlconn.Close()
        End If



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
    Private Sub fetch_cmbourse()
        Dim category As String = "College"

        Dim cmdcourse As New SqlCommand("select COUNT(coursecategory), coursename, SUM(courseID) FROM course " & _
                                        "where coursecategory = '" & category & "' group by coursename;", sqlconn)
        Dim adptcourse As New SqlDataAdapter(cmdcourse)
        Dim ds_course As New DataSet()
        If (adptcourse.Fill(ds_course, "course")) Then

            ds_course.Tables(0).Rows.InsertAt(ds_course.Tables(0).NewRow(), 0)
            cmbCourse.DataSource = ds_course.Tables(0)
            cmbCourse.ValueMember = "coursename"
            cmbCourse.DisplayMember = "coursename"

        End If
    End Sub
    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursename = '" & cmbCourse.Text & "'order by courseid ASC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then


            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else

            cmbMajor.DataSource = Nothing
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

    Private Sub tabCourse_Enter(sender As System.Object, e As System.EventArgs) Handles tabCourse.Enter
        'chkCollegeCourse.Checked = False
        'chkSeniorCourse.Checked = False

        btnEnrollees.Text = "Print Course Enrollees"

        selectedprint = "course"
        groupCourse.Visible = True
        groupSubject.Visible = False
        'cmbTermCourse.Text = ""
        dtPrint.Columns.Clear()

        If chkCollegeCourse.Checked = True Then
            category = "College"
        ElseIf chkSeniorCourse.Checked = True Then
            category = "Senior HS"
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_course()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_course()
            sqlconn.Close()
        End If

        AY = cmbAYCourse

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_sy()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        End If

        yrlevel = cmbLevelCourse

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
    End Sub
    Private Sub tabSubject_Enter(sender As Object, e As System.EventArgs) Handles tabSubject.Enter
        'chkCollegeSubject.Checked = False
        'chkSeniorSubject.Checked = False

        btnEnrollees.Text = "Print Subject Enrollees"

        selectedprint = "subject"
        groupCourse.Visible = False
        groupSubject.Visible = True
        'cmbTermSubject.Text = ""
        dtPrint.Columns.Clear()

        If cmbTermSubject.Text = "1st Semester" Then
            txtTerm.Text = 1
        ElseIf cmbTermSubject.Text = "2nd Semester" Then
            txtTerm.Text = 2
        ElseIf cmbTermSubject.Text = "Summer" Then
            txtTerm.Text = 3
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject()
            sqlconn.Close()
        End If

        AY = cmbAySubject

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_sy()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        End If
        yrlevel = cmblevelSubject

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If


    End Sub
    Private Sub tabFaculty_Enter(sender As Object, e As System.EventArgs) Handles tabFaculty.Enter
        'chkCollegeSubject.Checked = False
        'chkSeniorSubject.Checked = False

        btnEnrollees.Text = "Print Class List"

        selectedprint = "faculty"
        groupCourse.Visible = False
        groupSubject.Visible = False
        'cmbTermSubject.Text = ""
        dtPrint.Columns.Clear()

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
    Private Sub fetch_subject()


        Try
            Dim obj As Object = DBNull.Value
            Dim str As String = "select subjectid, sectionid, levelid , classscheduleid,  " & _
                "coursecode, subjectcode, subjectdescription, sectioname, yrlevel, term, sy, days, time, room " & _
                "FROM ClassScheduleView WHERE sy = '" & cmbAySubject.Text & "' AND yrlevel = '" & cmblevelSubject.Text & "' AND term = '" & txtTerm.Text & "' AND courseid = '" & courseid.Text & "' "

            Dim cmd As New SqlCommand(str, sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "ClassScheduleView")) Then

                dtPrint.Columns.Clear()

                dtPrint.DataSource = ds.Tables(0)

                dtPrint.Columns("subjectid").Visible = False
                dtPrint.Columns("sectionid").Visible = False
                dtPrint.Columns("levelid").Visible = False
                dtPrint.Columns("term").Visible = False
                dtPrint.Columns("yrlevel").Visible = False
                dtPrint.Columns("sy").Visible = False
                dtPrint.Columns("coursecode").Visible = False
                dtPrint.Columns("classscheduleid").Visible = False


                dtPrint.Columns("subjectcode").DisplayIndex = 0
                dtPrint.Columns("subjectcode").Width = 60
                dtPrint.Columns("subjectcode").HeaderText = "Code"

                dtPrint.Columns("subjectdescription").DisplayIndex = 1
                dtPrint.Columns("subjectdescription").Width = 350
                dtPrint.Columns("subjectdescription").HeaderText = "Subject"

                dtPrint.Columns("sectioname").DisplayIndex = 2
                dtPrint.Columns("sectioname").Width = 50
                dtPrint.Columns("sectioname").HeaderText = "Section"

                dtPrint.Columns("days").DisplayIndex = 3
                dtPrint.Columns("days").Width = 100
                dtPrint.Columns("days").HeaderText = "Day"

                dtPrint.Columns("time").DisplayIndex = 4
                dtPrint.Columns("time").Width = 110
                dtPrint.Columns("time").HeaderText = "Time"

                dtPrint.Columns("room").DisplayIndex = 6
                dtPrint.Columns("room").Width = 80
                dtPrint.Columns("room").HeaderText = "Room"

            Else

                dtPrint.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub fetch_college_faculty()
        Dim category As String = "COL Faculty"
        Dim stat As Boolean = True
        Dim obj As Object = DBNull.Value
        Dim str As String = "select designation, designation1, designation2, p, p1, p2, surname + ', ' + firstname as name, id FROM employee WHERE (designation = '" & category & "' and p = '" & stat & "') or (designation1 = '" & category & "' and p1 = '" & stat & "') or (designation2 = '" & category & "' and p2 = '" & stat & "') order by surname asc;"
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
  
    Private Sub chkCollege_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkCollegeCourse.CheckedChanged, chkSeniorCourse.CheckedChanged
        If chkCollegeCourse.Checked = True Then
            category = "College"
        ElseIf chkSeniorCourse.Checked = True Then
            category = "Senior HS"
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_course()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_course()
            sqlconn.Close()
        End If

        ' yrlevel = cmbLevelCourse

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
    End Sub
    Private Sub cmbTermSubject_TextChanged(sender As Object, e As System.EventArgs) Handles cmbTermSubject.TextChanged, cmblevelSubject.TextChanged
        If cmbTermSubject.Text = "1st Semester" Then
            txtTerm.Text = 1
        ElseIf cmbTermSubject.Text = "2nd Semester" Then
            txtTerm.Text = 2
        ElseIf cmbTermSubject.Text = "Summer" Then
            txtTerm.Text = 3
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject()
            sqlconn.Close()
        End If
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
        ' Dim category As String = "College"
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & category & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then


            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
            ' yrlevel.Items.Insert(0,New ("name"))
            ' yrlevel.Items.Insert(0, "All")

            'yrlevel.DataSource = ds_level.Tables(0)
            yrlevel.DataSource = ds_level.Tables(0)
            yrlevel.ValueMember = "yrlevel"
            yrlevel.DisplayMember = "yrlevel"
        End If
    End Sub




    Private Sub print_persubject()

        Dim sqlQRY1 As String = "select * FROM SubjectsStudentsView where classscheduleid = '" & classscheduleid.Text & "' and sy = '" & cmbAySubject.Text & "' and term = '" & txtTerm.Text & "' order by sex desc, surname asc;"
        ' Dim sqlQRY1 As String = "select * FROM SubjectsStudentsView where subjectid = '" & txtsubjectid.Text & "' and sy = '" & cmbAySubject.Text & "' and term = '" & txtTerm.Text & "' and section = '" & sectionid.Text & "'  order by sex desc, surname asc;"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "SubjectsStudentsView")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptSubjectEnrollees = New rptSubjectEnrollees

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()

    End Sub

    Private Sub print_percourse()
        Dim sqlQRY1 As String = "select * FROM AdmissionView where courseid = '" & txtcoursecode.Text & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' order by sex desc, surname asc;"
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

        Dim mReport As rptSubjectEnrollees = New rptSubjectEnrollees

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()

    End Sub
    Private Sub print_SummaryCourse()

        Dim sqlQRY1 As String = "select * FROM AdmissionView where coursecategory = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "';"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "AdmissionView")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptCourseEnrolleesSummary = New rptCourseEnrolleesSummary

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_alphalist()
        Dim sqlQRY2 As String = "select * FROM AdmissionInfo where category = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' order by surname ASC"


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
        Dim sqlQRY2 As String = "select * FROM AdmissionInfo where category = '" & category & "' and sy = '" & cmbAYCourse.Text & "' and term = '" & txtTerm.Text & "' and courseid = '" & txtcoursecode.Text & "' and yrlevel = '" & cmbLevelCourse.Text & "' and sectioname = '" & cmbSection.Text & "' order by surname ASC"


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
    Private Sub print_perSubjectSummary()
        Dim sqlQRY1 As String = "select * FROM SubjectsStudentsView where sy = '" & cmbAySubject.Text & "' and term = '" & txtTerm.Text & "' order by sex desc, surname asc;"

        Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

        'create data adapter

        Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset

        da1.Fill(ds, "SubjectsStudentsView")

        Dim Report As printrpt = New printrpt

        Dim mReport As rptSubjectEnrolleesSummary = New rptSubjectEnrolleesSummary

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()
    End Sub
    Private Sub print_persection()
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

        Dim mReport As rptCourseEnrolleesSection = New rptCourseEnrolleesSection

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
        ElseIf btnEnrollees.Text = "Print Subject Enrollees" Then
            If sqlconn.State = ConnectionState.Open Then
                Call print_persubject()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_persubject()
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
            If sqlconn.State = ConnectionState.Open Then
                Call print_perSubjectSummary()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call print_perSubjectSummary()
                sqlconn.Close()
            End If
        End If
    End Sub

    Private Sub chkCollegeFaculty_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkCollegeFaculty.CheckedChanged, chkSeniorHSFaculty.CheckedChanged
        If chkCollegeFaculty.Checked = True Then
            category = "College"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_college_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_college_faculty()
                sqlconn.Close()

            End If

        ElseIf chkSeniorHSFaculty.Checked = True Then
            category = "HS Faculty"

        End If


        dtPrint.Columns.Clear()

    End Sub
    Private Sub fetch_facultysubject()
        Try
            Dim obj As Object = DBNull.Value

            'Dim str As String = "select surname +', ' + firstname as name, subjectcode, subjectdescription, days, time, room, CAY, Cterm, coursecode FROM FacultyScheduleView WHERE (facultyid = '" & txtFacultyID.Text & "' and CAY = '" & cay & "' and Cterm = '" & txtTerm.Text & "');"
            Dim str As String = "select surname +', ' + firstname as name, subjectcode, subjectdescription, days, time, room, sy, term, coursecode, facultyid, classscheduleid FROM ClassScheduleView WHERE (facultyid = '" & txtFacultyID.Text & "' and sy = '" & cay & "' and term = '" & txtTerm.Text & "');"

            Dim cmd As New SqlCommand(str, sqlconn)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "FacultyScheduleView")) Then
                dtPrint.Columns.Clear()

                dtPrint.DataSource = ds.Tables(0)

                dtPrint.Columns("sy").Visible = False
                dtPrint.Columns("term").Visible = False
                dtPrint.Columns("classscheduleid").Visible = False
                dtPrint.Columns("facultyid").Visible = False

                dtPrint.Columns("name").DisplayIndex = 0
                dtPrint.Columns("name").Width = 160
                dtPrint.Columns("name").HeaderText = "Name"

                dtPrint.Columns("coursecode").DisplayIndex = 1
                dtPrint.Columns("coursecode").Width = 50
                dtPrint.Columns("coursecode").HeaderText = "Course"

                dtPrint.Columns("subjectcode").DisplayIndex = 2
                dtPrint.Columns("subjectcode").Width = 60
                dtPrint.Columns("subjectcode").HeaderText = "Code"

                dtPrint.Columns("subjectdescription").DisplayIndex = 3
                dtPrint.Columns("subjectdescription").Width = 305
                dtPrint.Columns("subjectdescription").HeaderText = "Subject"

                dtPrint.Columns("days").DisplayIndex = 4
                dtPrint.Columns("days").Width = 40
                dtPrint.Columns("days").HeaderText = "Day"

                dtPrint.Columns("time").DisplayIndex = 5
                dtPrint.Columns("time").Width = 120
                dtPrint.Columns("time").HeaderText = "Time"

                dtPrint.Columns("room").DisplayIndex = 6
                dtPrint.Columns("room").Width = 100
                dtPrint.Columns("room").HeaderText = "Room"


            Else

                dtPrint.Columns.Clear()
                txtlevel.Text = ""

            End If
        Catch ex As Exception

        End Try
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

    Private Sub cmbtermfaculty_TextChanged(sender As Object, e As System.EventArgs) Handles cmbtermfaculty.TextChanged
        If cmbtermfaculty.Text = "1st Semester" Then
            txtTerm.Text = 1
        ElseIf cmbtermfaculty.Text = "2nd Semester" Then
            txtTerm.Text = 2
        ElseIf cmbtermfaculty.Text = "Summer" Then
            txtTerm.Text = 3
        End If

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
    Private Sub cmbCourse_TextChanged(sender As Object, e As EventArgs) Handles cmbCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_coursemajor()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_coursemajor()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()

        End If
    End Sub
    Private Sub fetch_courseid()
        sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursemajor = '" & cmbMajor.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            courseid.Text = daMyname.Item("courseid")

        Else
            courseid.Text = 0

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_alphalist()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_alphalist()
            sqlconn.Close()

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_alphalistsection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_alphalistsection()
            sqlconn.Close()

        End If
    End Sub


    Private Sub cmbMajor_TextChanged(sender As Object, e As EventArgs) Handles cmbMajor.TextChanged

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_persectionTES()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_persectionTES()
            sqlconn.Close()

        End If
    End Sub
End Class