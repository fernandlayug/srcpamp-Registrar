Imports System.Data.SqlClient
Imports System.IO
Public Class admissionFrm
    Dim yrlevelcategory, coursecode, depLevel As String
    Dim bc, f138, gm, tr As String
    Dim AddSchool As Boolean
    Dim AddSchoolA As Boolean
    Public schoolcode As String
    Public schoolid As Integer
    Public schoolidA As Integer
    Dim term As Integer
    Dim activeCAY As String
    Dim Ac_CAY As String
    Dim sectionid_temp As Integer

    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()


        p_sy.Text = Main.SY.Text

        'Combo box for SY
        Dim cmdsy As New SqlCommand("select * FROM sy order by sy desc;", sqlconn)
        Dim adptsy As New SqlDataAdapter(cmdsy)
        Dim ds_sy As New DataSet()
        If (adptsy.Fill(ds_sy, "sy")) Then

            ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)

            lastschlyear.DataSource = ds_sy.Tables(0)
            lastschlyear.ValueMember = "sy"
            lastschlyear.DisplayMember = "sy"

            lastschlyearA.DataSource = ds_sy.Tables(0)
            lastschlyearA.ValueMember = "sy"
            lastschlyearA.DisplayMember = "sy"
        End If

        'Combo box for SY
        Dim cmdsyA As New SqlCommand("select * FROM sy order by sy desc;", sqlconn)
        Dim adptsyA As New SqlDataAdapter(cmdsyA)
        Dim ds_syA As New DataSet()
        If (adptsyA.Fill(ds_syA, "sy")) Then

            ds_syA.Tables(0).Rows.InsertAt(ds_syA.Tables(0).NewRow(), 0)

            lastschlyearA.DataSource = ds_syA.Tables(0)
            lastschlyearA.ValueMember = "sy"
            lastschlyearA.DisplayMember = "sy"
        End If

        CenterToScreen()

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_admission_history()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_admission_history()
            sqlconn.Close()
        End If

        sectionid_temp = 0
    End Sub
    Private Sub fetch_section()
        Dim cmdsection As New SqlCommand("select * FROM section " & _
                                        "where category = '" & yrlevelcategory & "';", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "course")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)

            cmbSection.DataSource = ds_section.Tables(0)
            cmbSection.ValueMember = "sectioname"
            cmbSection.DisplayMember = "sectioname"
        End If
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub elemOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles elemOption.CheckedChanged
        If elemOption.Checked = True Then
            yrlevelcategory = "Elementary"
            semester.Enabled = False
            cmbCourse.Enabled = False
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""
            c_code.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            cmblastschl.Text = ""
            lastschlyear.Text = ""
            average.Text = 0
            bcert.Checked = False
            goodmoral.Checked = False
            form138.Checked = False
            tor.Checked = False
            other.Text = ""
            admissioninfo.Enabled = True
            depLevel = "Elementary"
            cmbCourse.Text = "Elementary"

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_courseid_elem()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_courseid_elem()
                sqlconn.Close()
            End If
        ElseIf elemOption.Checked = False Then
            yrlevelcategory = ""
            semester.Enabled = True
            cmbCourse.Enabled = True
            cmbMajor.Enabled = True
            cmbCourse.Text = ""
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
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
    End Sub
    Private Sub jhsOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jhsOption.CheckedChanged
        If jhsOption.Checked = True Then
            yrlevelcategory = "Junior HS"
            semester.Enabled = False
            cmbCourse.Enabled = False
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""
            c_code.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            cmblastschl.Text = ""
            lastschlyear.Text = ""
            average.Text = 0
            bcert.Checked = False
            goodmoral.Checked = False
            form138.Checked = False
            tor.Checked = False
            other.Text = ""
            admissioninfo.Enabled = True
            depLevel = "Junior HS"

            cmbCourse.Text = "Junior High School"

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_courseid_jhs()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_courseid_jhs()
                sqlconn.Close()
            End If
        ElseIf jhsOption.Checked = False Then
            yrlevelcategory = ""
            semester.Enabled = True
            cmbCourse.Enabled = True
            cmbMajor.Enabled = True
        End If
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
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
    End Sub

    Private Sub shsOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles shsOption.CheckedChanged
        If shsOption.Checked = True Then
            yrlevelcategory = "Senior HS"
            semester.Enabled = True
            cmbCourse.Enabled = True
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""
            c_code.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            cmblastschl.Text = ""
            lastschlyear.Text = ""
            average.Text = 0
            bcert.Checked = False
            goodmoral.Checked = False
            form138.Checked = False
            tor.Checked = False
            other.Text = ""
            admissioninfo.Enabled = True
            depLevel = "Senior HS"
            studentfile.cat = "Senior HS"
        ElseIf shsOption.Checked = False Then
            yrlevelcategory = ""
        End If
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
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
    End Sub

    Private Sub collegeOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles collegeOption.CheckedChanged
        If collegeOption.Checked = True Then
            yrlevelcategory = "College"
            semester.Enabled = True
            cmbCourse.Enabled = True
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""
            c_code.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            cmblastschl.Text = ""
            lastschlyear.Text = ""
            average.Text = 0
            bcert.Checked = False
            goodmoral.Checked = False
            form138.Checked = False
            tor.Checked = False
            other.Text = ""
            admissioninfo.Enabled = True
            depLevel = "College"
            studentfile.cat = "College"
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_curriculumAY()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_curriculumAY()
                sqlconn.Close()
            End If

        ElseIf collegeOption.Checked = False Then
            yrlevelcategory = ""
        End If
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()
        End If
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
    Private Sub cmbCourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_coursecode()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_coursecode()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_ActiveCurriculumAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_ActiveCurriculumAY()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_curriculumAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_curriculumAY()
            sqlconn.Close()
        End If

      


    End Sub
    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursecode = '" & c_code.Text & "'order by courseid DESC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then
            cmbMajor.Enabled = True

            'ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else
            cmbMajor.DataSource = Nothing

     
        End If
   
    End Sub
    Private Sub fetch_levelid()
        Try
            sqlcmd.CommandText = "select  * FROM level where yrlevel = '" & level.Text & "' AND category = '" & yrlevelcategory & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtLevelID.Text = daMyname.Item("levelid")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub fetch_courseid_elem()
        sqlcmd.CommandText = "Select * FROM course WHERE coursename = '" & cmbCourse.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader
        If damyname.HasRows Then
            damyname.Read()
            txtCourseID.Text = damyname.Item("courseid")
        Else
            txtCourseID.Text = 0
        End If
    End Sub
    Private Sub fetch_courseid_jhs()
        sqlcmd.CommandText = "Select * FROM course WHERE coursename = '" & cmbCourse.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader
        If damyname.HasRows Then
            damyname.Read()
            txtCourseID.Text = damyname.Item("courseid")
        Else
            txtCourseID.Text = 0
        End If
    End Sub
    Private Sub fetch_courseid()
        sqlcmd.CommandText = "Select * FROM course WHERE coursecode = '" & c_code.Text & "' AND coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & yrlevelcategory & "' AND coursemajor = '" & cmbMajor.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader
        If damyname.HasRows Then
            damyname.Read()
            txtCourseID.Text = damyname.Item("courseid")
        Else
            txtCourseID.Text = 0
        End If
    End Sub
    Private Sub c_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c_code.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_coursemajor()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_coursemajor()
            sqlconn.Close()
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
            txtESC.Text = daMyname.Item("ESCNO")
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


    End Sub
    Private Sub save_admission()

        Dim yes As Boolean = True
        Dim no As Boolean = False
        'Dim sec As Integer = 0
        Dim d As Date = Now()
        Dim r2 As String = ""
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into admission([studentID],[intermediateSchooliD],[intermediateSY],[SchooliD], " & _
            "[lastschlyear],[lastschlaverage],[credentials], " & _
            "[sy],[levelid],[term],[courseid], " & _
            "[section],[dateregistered], " & _
            "[studentstatus],[remarks],[cay]) values ('" & studid.Text & "', " & _
            "'" & schoolidA & "','" & lastschlyearA.Text & "', " & _
            "'" & schoolid & "', " & _
            " '" & lastschlyear.Text & "'," & _
            " '" & average.Text & "'," & _
            " '" & txtCredentials.Text & "'," & _
            " '" & p_sy.Text & "'," & _
            " '" & txtLevelID.Text & "'," & _
            " '" & term & "'," & _
            " '" & txtCourseID.Text & "'," & _
            " '" & sectionid_temp & "'," & _
            " '" & d & "'," & _
            " '" & cmbStatus.Text & "'," & _
            " '" & remarks.Text & "'," & _
            " '" & txtCAY.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()

        MessageBox.Show("Student successfully registered")

        If shsOption.Checked = True Or collegeOption.Checked = True Then

            studentfile.studid.Text = studid.Text
            studentfile.txtSY.Text = p_sy.Text
            studentfile.txtLevel.Text = level.Text

            If firstsem.Checked = True Then

                studentfile.sem = 1
                studentfile.txtSemester.Text = "First Semester"
            ElseIf secondsem.Checked = True Then

                studentfile.sem = 2
                studentfile.txtSemester.Text = "Second Semester"
            ElseIf summer.Checked = True Then

                studentfile.sem = 3
                studentfile.txtSemester.Text = "Summer"
            End If


            studentfile.txtCourse.Text = cmbCourse.Text
            studentfile.txtcourseid.Text = txtCourseID.Text
            studentfile.txtCourseCode.Text = c_code.Text

            studentfile.txtMajor.Text = cmbMajor.Text
            studentfile.txtCategoryA.Text = yrlevelcategory
            studentfile.txtCategory.Text = yrlevelcategory
            studentfile.cmbSection.Text = cmbSection.Text
            studentfile.sectionID = sectionid_temp
            studentfile.txtlevelid.Text = txtLevelID.Text

            studentfile.studid.ReadOnly = True



            studentfile.btnDrop.Enabled = False
            studentfile.formstatus = "admission"
            studentfile.ShowDialog()



        End If
        Me.Dispose()

    End Sub

    Private Sub submit_Click(sender As System.Object, e As System.EventArgs) Handles submit.Click

        If schoolid = 0 Then

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_schoolid()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_schoolid()
                sqlconn.Close()
            End If

        ElseIf schoolidA = 0 Then

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_schoolidA()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_schoolidA()
                sqlconn.Close()
            End If
        End If


        If elemOption.Checked = True Or jhsOption.Checked = True Then
            If String.IsNullOrEmpty(level.Text) Then
                MessageBox.Show("Please select year level")
                level.Focus()
            ElseIf String.IsNullOrEmpty(cmbType.Text) Then
                MessageBox.Show("Please select school type")
                cmbType.Focus()
            ElseIf String.IsNullOrEmpty(cmblastschl.Text) Then
                MessageBox.Show("Please select school")
                cmbType.Focus()
            ElseIf String.IsNullOrEmpty(lastschlyear.Text) Then
                MessageBox.Show("Please select SY")
                lastschlyear.Focus()
            Else
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call save_admission()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call save_admission()
                    sqlconn.Close()
                End If

            End If
        ElseIf shsOption.Checked = True Or collegeOption.Checked = True Then
            If String.IsNullOrEmpty(level.Text) Then
                MessageBox.Show("Please select year level")
                level.Focus()
            ElseIf String.IsNullOrEmpty(cmbType.Text) Then
                MessageBox.Show("Please select school type")
                cmbType.Focus()
            ElseIf String.IsNullOrEmpty(cmblastschl.Text) Then
                MessageBox.Show("Please select school")
                cmbType.Focus()
            ElseIf String.IsNullOrEmpty(lastschlyear.Text) Then
                MessageBox.Show("Please select SY")
                lastschlyear.Focus()
            ElseIf firstsem.Checked = False And secondsem.Checked = False Then
                MessageBox.Show("Please select semester.")
            ElseIf String.IsNullOrEmpty(cmbCourse.Text) Then
                MessageBox.Show("Please select course")
                cmbCourse.Focus()
            Else
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call save_admission()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call save_admission()
                    sqlconn.Close()
                End If


            End If
        End If

    End Sub

    Private Sub bcert_CheckedChanged(sender As Object, e As System.EventArgs) Handles bcert.CheckedChanged, form138.CheckedChanged, goodmoral.CheckedChanged, tor.CheckedChanged
        If bcert.Checked = True Then
            bc = "| Photocopy of Birth Certificate "
        ElseIf bcert.Checked = False Then
            bc = ""
        End If

        If form138.Checked = True Then
            f138 = "| Form 138 "
        ElseIf bcert.Checked = False Then
            f138 = ""
        End If

        If goodmoral.Checked = True Then
            gm = "| Good Moral "
        ElseIf goodmoral.Checked = False Then
            gm = ""
        End If

        If tor.Checked = True Then
            tr = "| T.O.R "
        ElseIf tor.Checked = False Then
            tr = ""
        End If

        txtCredentials.Text = bc + f138 + gm + tr + "| " + other.Text
    End Sub

    Private Sub other_TextChanged(sender As Object, e As System.EventArgs) Handles other.TextChanged
        txtCredentials.Text = bc + f138 + gm + tr + "| " + other.Text
    End Sub
    Private Sub fetch_school()
        'Combo box for School List
        Dim cmdsn As New SqlCommand("select * FROM schoollist where schoolcategory = '" & cmbType.Text & "' order by schoolname ASC;", sqlconn)
        Dim adptsn As New SqlDataAdapter(cmdsn)
        Dim ds_sn As New DataSet()
        If (adptsn.Fill(ds_sn, "schoollist")) Then

            ds_sn.Tables(0).Rows.InsertAt(ds_sn.Tables(0).NewRow(), 0)

            cmblastschl.DataSource = ds_sn.Tables(0)
            cmblastschl.ValueMember = "schoolname"
            cmblastschl.DisplayMember = "schoolname"
        Else
            cmblastschl.DataSource = Nothing
        End If
    End Sub
    Private Sub fetch_schoolA()
        'Combo box for School List
        Dim cmdsn As New SqlCommand("select * FROM schoollist where schoolcategory = '" & cmbTypeA.Text & "' order by schoolname ASC;", sqlconn)
        Dim adptsn As New SqlDataAdapter(cmdsn)
        Dim ds_sn As New DataSet()
        If (adptsn.Fill(ds_sn, "schoollist")) Then

            ds_sn.Tables(0).Rows.InsertAt(ds_sn.Tables(0).NewRow(), 0)

            cmblastschlA.DataSource = ds_sn.Tables(0)
            cmblastschlA.ValueMember = "schoolname"
            cmblastschlA.DisplayMember = "schoolname"
        Else
            cmblastschlA.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbType_TextChanged(sender As Object, e As System.EventArgs) Handles cmbType.TextChanged
        If cmbType.Text = "" Then
            cmblastschl.Enabled = False
        ElseIf cmbType.Text = "Public" Or cmbType.Text = "Private" Or cmbType.Text = "SUC" Then
            cmblastschl.Enabled = True
        End If
        cmblastschl.Text = ""

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_school()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_school()
            sqlconn.Close()

        End If
    End Sub
    Private Sub fetch_schooladdress()
        sqlcmd.CommandText = "select * FROM schoollist Where (schoolname = '" & cmblastschl.Text & "' AND schoolcategory = '" & cmbType.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()

            AddSchool = True
            schoolid = daMyname.Item("ID")
            schoolcode = daMyname.Item("schoolcode")
            address3.Text = daMyname.Item("address3")
            address2.Text = daMyname.Item("address2")
            address1.Text = daMyname.Item("address1")
            address3.Enabled = False
            address2.Enabled = False
            address1.Enabled = False

        Else
            AddSchool = False
            schoolid = 0
            schoolcode = ""
            address3.Text = ""
            address2.Text = ""
            address1.Text = ""
            address3.Enabled = True
            address2.Enabled = True
            address1.Enabled = True
        End If

    End Sub
    Private Sub fetch_schoolidA()
        sqlcmd.CommandText = "select * FROM schoollist Where (schoolname = '" & cmblastschlA.Text & "' AND schoolcategory = '" & cmbTypeA.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()

            schoolidA = daMyname.Item("ID")
            AddSchoolA = True
        Else
            AddSchoolA = False
        End If

    End Sub
    Private Sub fetch_schoolid()
        sqlcmd.CommandText = "select * FROM schoollist Where (schoolname = '" & cmblastschl.Text & "' AND schoolcategory = '" & cmbType.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()

            schoolid = daMyname.Item("ID")
        Else
        End If

    End Sub

    Private Sub cmblastschl_TextChanged(sender As Object, e As System.EventArgs) Handles cmblastschl.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_schooladdress()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_schooladdress()
            sqlconn.Close()
        End If
    End Sub

    Private Sub AddSchoolList()
        If AddSchool = False Then
            Dim result = MessageBox.Show("Do you want to add the school to your list?", "School List", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ListOfSchool.txtType.Text = cmbType.Text
                ListOfSchool.txtSchoolname.Text = cmblastschl.Text
                ListOfSchool.txtAddress3.Text = address3.Text
                ListOfSchool.txtAddress2.Text = address2.Text
                ListOfSchool.txtAddress1.Text = address1.Text

                ListOfSchool.txtAddress3.ReadOnly = True
                ListOfSchool.txtAddress2.ReadOnly = True
                ListOfSchool.txtAddress1.ReadOnly = True
                ListOfSchool.ShowDialog()

            ElseIf result = DialogResult.No Then

            End If

        ElseIf AddSchool = True Then

        End If

    End Sub
    Private Sub AddSchoolListA()
        If AddSchoolA = False Then
            Dim result = MessageBox.Show("Do you want to add the school to your list?", "School List", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ListOfSchool.txtType.Text = cmbTypeA.Text
                ListOfSchool.txtSchoolname.Text = cmblastschlA.Text


                ListOfSchool.txtAddress3.ReadOnly = False
                ListOfSchool.txtAddress2.ReadOnly = False
                ListOfSchool.txtAddress1.ReadOnly = False

                ListOfSchool.ShowDialog()

            ElseIf result = DialogResult.No Then

            End If

        ElseIf AddSchoolA = True Then

        End If

    End Sub

    Private Sub address2_GotFocus(sender As Object, e As System.EventArgs) Handles address2.GotFocus
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_city()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_city()
            sqlconn.Close()
        End If
    End Sub

    Private Sub address1_GotFocus(sender As Object, e As System.EventArgs) Handles address1.GotFocus
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_barrio()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_barrio()
            sqlconn.Close()
        End If
    End Sub
    Private Sub address1_Leave(sender As Object, e As System.EventArgs) Handles address1.Leave
        Call AddSchoolList()
    End Sub
    Private Sub fetch_province()
        Dim cmd As New SqlCommand("select province FROM addresslist group by province order by province ASC;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address3.DataSource = ds.Tables(0)
            address3.ValueMember = "province"
            address3.DisplayMember = "province"
        End If
    End Sub
    Private Sub fetch_city()
        Dim cmd As New SqlCommand("select city FROM addresslist where province = '" & address3.Text & "'  group by city;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address2.DataSource = ds.Tables(0)
            address2.ValueMember = "city"
            address2.DisplayMember = "city"
        End If
    End Sub
    Private Sub fetch_barrio()
        Dim cmd As New SqlCommand("select barrio FROM addresslist where province = '" & address3.Text & "' AND city = '" & address2.Text & "';", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address1.DataSource = ds.Tables(0)
            address1.ValueMember = "barrio"
            address1.DisplayMember = "barrio"
        End If
    End Sub

    Private Sub address3_GotFocus(sender As Object, e As System.EventArgs) Handles address3.GotFocus
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_province()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_province()
            sqlconn.Close()
        End If
    End Sub

    Private Sub level_TextChanged(sender As Object, e As System.EventArgs) Handles level.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_levelid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_levelid()
            sqlconn.Close()
        End If
    End Sub

    Private Sub cmbMajor_TextChanged(sender As Object, e As System.EventArgs) Handles cmbMajor.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()
        End If
    End Sub

    Private Sub cmbTypeA_TextChanged(sender As Object, e As System.EventArgs) Handles cmbTypeA.TextChanged
        If cmbTypeA.Text = "" Then
            cmblastschlA.Enabled = False
        ElseIf cmbTypeA.Text = "Public" Or cmbTypeA.Text = "Private" Then
            cmblastschlA.Enabled = True
        End If
        cmblastschlA.Text = ""

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_schoolA()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_schoolA()
            sqlconn.Close()

        End If
    End Sub

    Private Sub firstsem_CheckedChanged(sender As Object, e As System.EventArgs) Handles firstsem.CheckedChanged, secondsem.CheckedChanged, summer.CheckedChanged
        If semester.Enabled = True Then
            If firstsem.Checked = True Then
                term = 1
            ElseIf secondsem.Checked = True Then
                term = 2
            ElseIf summer.Checked = True Then
                term = 3
            ElseIf firstsem.Checked = False And secondsem.Checked = False And summer.Checked = False Then
                term = 0
            End If

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_course()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_course()
                sqlconn.Close()
            End If

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call verify_enroleesSHS_College()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_enroleesSHS_College()
                sqlconn.Close()
            End If
        Else

        End If
    End Sub


    Private Sub cmblastschlA_Leave(sender As Object, e As System.EventArgs) Handles cmblastschlA.Leave

        Call AddSchoolListA()
    End Sub

    Private Sub cmblastschlA_TextChanged(sender As Object, e As System.EventArgs) Handles cmblastschlA.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_schoolidA()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_schoolidA()
            sqlconn.Close()
        End If
    End Sub
    Private Sub verify_enroleesJHSandELEM()

        sqlcmd.CommandText = "select * FROM admission Where (studentid = '" & studid.Text & "') and (sy = '" & p_sy.Text & "') and (levelid = '" & txtLevelID.Text & "') ;"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            txtLevelID.Text = ""
            MessageBox.Show("Student is currently enrolled. Select another level")
            level.Text = ""
            level.Focus()
        Else

        End If
    End Sub
    Private Sub verify_enroleesSHS_College()

        sqlcmd.CommandText = "select * FROM admission Where (studentid = '" & studid.Text & "') and (sy = '" & p_sy.Text & "') and (levelid = '" & txtLevelID.Text & "') and (term = '" & term & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            txtLevelID.Text = ""
            level.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            summer.Checked = False
            MessageBox.Show("Student is currently enrolled.")
        Else
        End If
    End Sub


    Private Sub txtLevelID_TextChanged(sender As Object, e As System.EventArgs) Handles txtLevelID.TextChanged
        If elemOption.Checked = True Or jhsOption.Checked = True Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call verify_enroleesJHSandELEM()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_enroleesJHSandELEM()
                sqlconn.Close()
            End If
        ElseIf shsOption.Checked = True Or collegeOption.Checked = True Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call verify_enroleesSHS_College()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_enroleesSHS_College()
                sqlconn.Close()
            End If
        End If
    End Sub

    Private Sub fetch_admission_history()
        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select studentID, coursecode, coursename, coursemajor, sy, yrlevel, term, cay FROM AdmissionView Where (studentID = '" & studid.Text & "')  order by sy DESC;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "AdmissionView")) Then

            'dtAdmissionHistory.Columns.Clear()

            dtAdmissionHistory.DataSource = ds.Tables(0)

            Dim chk As New DataGridViewCheckBoxColumn
            dtAdmissionHistory.Columns("studentID").Visible = False
'

            dtAdmissionHistory.Columns("coursecode").DisplayIndex = 0
            dtAdmissionHistory.Columns("coursecode").Width = 60
            dtAdmissionHistory.Columns("coursecode").HeaderText = "Code"

            dtAdmissionHistory.Columns("coursename").DisplayIndex = 1
            dtAdmissionHistory.Columns("coursename").HeaderText = "Course"
            dtAdmissionHistory.Columns("coursename").Width = 280

            dtAdmissionHistory.Columns("coursemajor").DisplayIndex = 2
            dtAdmissionHistory.Columns("coursemajor").HeaderText = "Major"
            dtAdmissionHistory.Columns("coursemajor").Width = 150

            dtAdmissionHistory.Columns("sy").DisplayIndex = 3
            dtAdmissionHistory.Columns("sy").HeaderText = "Academic Year"
            dtAdmissionHistory.Columns("sy").Width = 150
            dtAdmissionHistory.Columns("sy").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtAdmissionHistory.Columns("yrlevel").DisplayIndex = 4
            dtAdmissionHistory.Columns("yrlevel").HeaderText = "Year Level"
            dtAdmissionHistory.Columns("yrlevel").Width = 80
            dtAdmissionHistory.Columns("yrlevel").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtAdmissionHistory.Columns("term").DisplayIndex = 5
            dtAdmissionHistory.Columns("term").HeaderText = "Term"
            dtAdmissionHistory.Columns("term").Width = 50
            dtAdmissionHistory.Columns("term").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dtAdmissionHistory.Columns("cay").DisplayIndex = 6
            dtAdmissionHistory.Columns("cay").HeaderText = "CAY"
            dtAdmissionHistory.Columns("cay").Width = 70

            ' dtAdmissionHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else
            dtAdmissionHistory.DataSource = Nothing
        End If
    End Sub



    Private Sub fetch_curriculumAY()
        Try
            sqlcmd.CommandText = "select  * FROM AdmissionView where studentID = '" & studid.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtCAY.Text = daMyname.Item("cay")
            Else
                txtCAY.Text = activeCAY
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_ActiveCurriculumAY()
        Try
            sqlcmd.CommandText = "select  * FROM activecurriculum where courseid = '" & txtCourseID.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                activeCAY = daMyname.Item("ay")
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fetch_classSchedule()
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Open()
            Call fetch_admission_history()
            sqlconn.Close()
        Else
            sqlconn.Close()
        End If
    End Sub
    Private Sub fetch_sectionid()
        sqlcmd.CommandText = "select  * FROM section where category = '" & yrlevelcategory & "' AND sectioname = '" & cmbSection.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            sectionid_temp = daMyname.Item("sectionid")

        Else
            sectionid_temp = 0

        End If

    End Sub


    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
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
    End Sub


End Class