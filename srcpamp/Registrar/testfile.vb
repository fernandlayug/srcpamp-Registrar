Imports System.Data.SqlClient
Imports System.IO


Public Class testfile

    Dim yrlevelcategory, coursecode, depLevel As String
    Dim bc, f138, gm, tr As String
    Dim AddSchool As Boolean
    Public schoolcode As String
    Public schoolid As Integer
    Dim sem As Integer




    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sqlserver.connect()
        CenterToScreen()

    End Sub


    Private Sub fetch_yrlevel()
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & yrlevelcategory & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)

            level.DataSource = ds_level.Tables(0)
            level.ValueMember = "yrlevel"
            level.DisplayMember = "yrlevel"
        End If
    End Sub
    Private Sub fetch_sy()
        Dim cmdsy As New SqlCommand("Select * FROM sy order by sy DESC;", sqlconn)
        Dim adptsy As New SqlDataAdapter(cmdsy)
        Dim ds_sy As New DataSet

        If (adptsy.Fill(ds_sy, "sy")) Then
            ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)

            cmbsy.DataSource = ds_sy.Tables(0)
            cmbsy.ValueMember = "sy"
            cmbsy.DisplayMember = "sy"

        End If
    End Sub
    Private Sub fetch_level()
        Dim cmdlevel As New SqlCommand("Select yrlevel FROM admission WHERE studentid = '" & studid.Text & "' AND sy = '" & cmbsy.Text & "';", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet

        If (adptlevel.Fill(ds_level, "admission")) Then
            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)

            level.DataSource = ds_level.Tables(0)
            level.ValueMember = "yrlevel"
            level.DisplayMember = "yrlevel"

        End If
    End Sub
    Private Sub fetch_course()
        Dim cmdcourse As New SqlCommand("select COUNT(coursecategory), coursename, SUM(courseID) FROM course " & _
                                        "where coursecategory = '" & yrlevelcategory & "' group by coursename;", sqlconn)
        Dim adptcourse As New SqlDataAdapter(cmdcourse)
        Dim ds_course As New DataSet()
        If (adptcourse.Fill(ds_course, "course")) Then

            ds_course.Tables(0).Rows.InsertAt(ds_course.Tables(0).NewRow(), 0)

            cmbCourse.DataSource = ds_course.Tables(0)
            cmbCourse.ValueMember = "coursename"
            cmbCourse.DisplayMember = "coursename"
        End If
    End Sub

    Private Sub fetch_coursecode()
        Try
            sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                c_code.Text = daMyname.Item("coursecode")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_admission()


        sqlcmd.CommandText = "select  * FROM admissionVIEW where sy = '" & cmbsy.Text & "' AND studentid = '" & studid.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            level.Text = daMyname.Item("yrlevel")
            cmbCourse.Text = daMyname.Item("coursename")
            c_code.Text = daMyname.Item("coursecode")
            cmbMajor.Text = daMyname.Item("coursemajor")
            sem = daMyname.Item("term")
            txtcourseid.Text = daMyname.Item("courseid")
            txtlevelid.Text = daMyname.Item("levelid")
            txtCategory.Text = daMyname.Item("category")
        End If

        If sem = 1 Then
            firstsem.Checked = True
        ElseIf sem = 2 Then
            secondsem.Checked = True
        ElseIf sem = 3 Then
            summer.Checked = True
        End If
    End Sub
    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursecode = '" & c_code.Text & "'order by courseid ASC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then
            cmbMajor.Enabled = True

            ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else
            cmbMajor.Enabled = False

            ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            cmbMajor.DataSource = Nothing
        End If
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
            Call fetch_sy()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        End If

    End Sub

    Private Sub cmbsy_TextChanged(sender As Object, e As System.EventArgs) Handles cmbsy.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_admission()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_admission()
            sqlconn.Close()

        End If

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

        txtSY.Text = cmbsy.Text
    End Sub
    Public Sub fetch_subjectsenrolled()

        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select studentid, sy, levelid, term, subjectcode, subjectdescription, " & _
                                  "isnull(subjectlecunit,0) as sublec, isnull(subjectlabunit,0) as sublab, isnull(subjectunits, 0) as subunit, subjectprereq, days, time, room, " & _
                                  "remarks FROM subjectEnrolledView  Where (studentid = '" & studid.Text & "' and levelid = '" & txtlevelid.Text & "' and term = '" & sem & "' and sy = '" & cmbsy.Text & "') order by subjectunits desc;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "subjectEnrolledView")) Then

            dtsubjects.DataSource = ds.Tables(0)

            dtsubjects.Columns("studentid").Visible = False
            dtsubjects.Columns("sy").Visible = False
            dtsubjects.Columns("levelid").Visible = False
            dtsubjects.Columns("term").Visible = False
            dtsubjects.Columns("remarks").Visible = False


            dtsubjects.Columns("subjectcode").DisplayIndex = 0
            dtsubjects.Columns("subjectcode").Width = 60
            dtsubjects.Columns("subjectcode").HeaderText = "Code"

            dtsubjects.Columns("subjectdescription").DisplayIndex = 1
            dtsubjects.Columns("subjectdescription").HeaderText = "Subject"
            dtsubjects.Columns("subjectdescription").Width = 300

            dtsubjects.Columns("sublec").DisplayIndex = 2
            dtsubjects.Columns("sublec").HeaderText = "LecUnits"
            dtsubjects.Columns("sublec").Width = 50
            dtsubjects.Columns("sublec").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dtsubjects.Columns("subjectprereq").DisplayIndex = 5
            dtsubjects.Columns("subjectprereq").HeaderText = "Pre-req"
            dtsubjects.Columns("subjectprereq").Width = 100

            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else
            dtsubjects.DataSource = Nothing
        End If

    End Sub

    Private Sub firstsem_CheckedChanged(sender As Object, e As System.EventArgs) Handles firstsem.CheckedChanged, secondsem.CheckedChanged, summer.CheckedChanged

        If sem = 1 Then
            firstsem.Checked = True
        ElseIf sem = 2 Then
            secondsem.Checked = True
        ElseIf sem = 3 Then
            summer.Checked = True
        End If

    End Sub


    Private Sub addsubject_Click(sender As System.Object, e As System.EventArgs) Handles btnADD.Click
        frmSubjectsEnrolled.cmbSubjectCategory.Text = txtCategory.Text
        frmSubjectsEnrolled.txtCourse.Text = cmbCourse.Text
        frmSubjectsEnrolled.txtMajor.Text = cmbMajor.Text
        frmSubjectsEnrolled.txtLevel.Text = level.Text
        frmSubjectsEnrolled.txtLevelID.Text = txtlevelid.Text
        frmSubjectsEnrolled.txtCourseID.Text = txtcourseid.Text
        frmSubjectsEnrolled.txtTermID.Text = sem
        frmSubjectsEnrolled.txtSY.Text = cmbsy.Text
        frmSubjectsEnrolled.txtstudentid.Text = studid.Text

        frmSubjectsEnrolled.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub dtsubjects_DataSourceChanged(sender As Object, e As System.EventArgs) Handles dtsubjects.DataSourceChanged
        txtlecunits.Text = total_lecunits()
 
    End Sub

    Private Sub level_TextChanged(sender As Object, e As System.EventArgs) Handles level.TextChanged, txtCategory.TextChanged, cmbCourse.TextChanged, c_code.TextChanged, cmbMajor.TextChanged, firstsem.CheckedChanged, secondsem.CheckedChanged, summer.CheckedChanged
        txtLevel.Text = level.Text
        txtCategoryA.Text = txtCategory.Text
        txtCourse.Text = cmbCourse.Text
        txtCourseCode.Text = c_code.Text
        txtMajor.Text = cmbMajor.Text

        If firstsem.Checked = True Then
            txtSemester.Text = "First Semester"
        ElseIf secondsem.Checked = True Then
            txtSemester.Text = "Second Semester"
        ElseIf summer.Checked = True Then
            txtSemester.Text = "Summer"
        End If
    End Sub
End Class