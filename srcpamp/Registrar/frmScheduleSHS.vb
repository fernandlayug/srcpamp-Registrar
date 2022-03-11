Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmScheduleSHS
    'Dim category As String
    Dim cAY As String
    Dim Cterm As Integer
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub frmCurriculum_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cAY = Main.SY.Text
        txtCAY.Text = Main.SY.Text

        sqlserver.connect()

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_classroom()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_classroom()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_section()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_section()
            sqlconn.Close()

        End If
    End Sub
    Private Sub fetch_classroom()
        Dim category As String = "classroom"
        Dim cmdroom As New SqlCommand("select *  FROM location where category = '" & category & "';", sqlconn)
        Dim adptroom As New SqlDataAdapter(cmdroom)
        Dim ds_room As New DataSet()
        If (adptroom.Fill(ds_room, "location")) Then

            ds_room.Tables(0).Rows.InsertAt(ds_room.Tables(0).NewRow(), 0)
            txtroom.DataSource = ds_room.Tables(0)
            txtroom.ValueMember = "location"
            txtroom.DisplayMember = "location"
        End If
    End Sub
    Private Sub fetch_section()
        Dim category As String = "Senior HS"
        Dim cmdsection As New SqlCommand("select *  FROM section where category = '" & category & "';", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "section")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)
            cmbsection.DataSource = ds_section.Tables(0)
            cmbsection.ValueMember = "sectioname"
            cmbsection.DisplayMember = "sectioname"

        End If
    End Sub
    Private Sub numberzero()
        Dim units As Double
        Units = 0
    End Sub
    Private Sub fetch_courseID()
        Dim category As String = "Senior HS"
        Try
            sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & Category & "' AND coursemajor = '" & cmbMajor.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtCourseID.Text = daMyname.Item("courseid")
            Else
                txtCourseID.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_LeveLID()
        Dim category As String = "Senior HS"
        Try
            sqlcmd.CommandText = "select  * FROM level where yrlevel = '" & cmbLevel.Text & "' AND category = '" & Category & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtLevelID.Text = daMyname.Item("levelid")
            Else
                txtLevelID.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub fetch_sectionID()
        Dim category As String = "Senior HS"
        Try
            sqlcmd.CommandText = "select  * FROM section where sectioname = '" & cmbsection.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtsectionID.Text = daMyname.Item("sectionid")
            Else
                txtsectionID.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_subjects()

        Try
            Dim obj As Object = DBNull.Value

            Dim a As String = "select subjectcode, subjectdescription, courseid, levelid, term, subjectid FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND levelid = '" & txtLevelID.Text & "' AND term = '" & txtTerm.Text & "' AND CAY = '" & cmbcurriculum.Text & "');"
            Dim b As String = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND levelid = '" & txtLevelID.Text & "' AND CAY = '" & cmbcurriculum.Text & "');"
            Dim str As String
            If txtTerm.Text = "" Then
                str = b
            Else
                str = a
            End If

            Dim cmd As New SqlCommand(str, sqlconn)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "CurriculumView")) Then
                dtSubjects.Columns.Clear()

                dtSubjects.DataSource = ds.Tables(0)

                dtSubjects.Columns("courseid").Visible = False
                dtSubjects.Columns("levelid").Visible = False
                dtSubjects.Columns("term").Visible = False
                dtSubjects.Columns("subjectid").Visible = False

                dtSubjects.Columns("subjectcode").DisplayIndex = 0
                dtSubjects.Columns("subjectcode").Width = 60
                dtSubjects.Columns("subjectcode").HeaderText = "Code"

                dtSubjects.Columns("subjectdescription").DisplayIndex = 1
                dtSubjects.Columns("subjectdescription").Width = 300
                dtSubjects.Columns("subjectdescription").HeaderText = "Subject"

                'Dim sy As String = cAY

                For RCnt As Integer = 0 To dtSubjects.Rows.Count - 1
                    If dtSubjects.Rows(RCnt).Cells("CAY").Value = cAY And dtSubjects.Rows(RCnt).Cells("Cterm").Value = 2 Then
                        dtSubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Yellow
                    Else
                    End If
                Next

                For RCnt As Integer = 0 To dtSubjects.Rows.Count - 1
                    If dtSubjects.Rows(RCnt).Cells("CAY").Value = cAY And dtSubjects.Rows(RCnt).Cells("Cterm").Value = 1 Then
                        dtSubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Pink
                    Else
                    End If
                Next

                For RCnt As Integer = 0 To dtSubjects.Rows.Count - 1
                    If dtSubjects.Rows(RCnt).Cells("CAY").Value = cAY And dtSubjects.Rows(RCnt).Cells("Cterm").Value = 3 Then
                        dtSubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Green
                    Else

                    End If
                Next

            Else

                dtSubjects.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try

    End Sub
  
    Private Sub fetch_course()
        Dim category As String = "Senior HS"

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
    Private Sub fetch_yrlevel()
        Dim category As String = "Senior HS"
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & Category & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
            cmbLevel.DataSource = ds_level.Tables(0)
            cmbLevel.ValueMember = "yrlevel"
            cmbLevel.DisplayMember = "yrlevel"
        End If
    End Sub


    Private Sub chkCollege_CheckedChanged(sender As Object, e As System.EventArgs)



    End Sub

    Private Sub cmbCourse_TextChanged(sender As Object, e As System.EventArgs) Handles cmbCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_coursemajor()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_coursemajor()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseID()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If

    End Sub
    Private Sub Checkedlevel()

    End Sub

    Private Sub cmbMajor_TextChanged(sender As Object, e As System.EventArgs) Handles cmbMajor.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseID()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If
    End Sub

    Private Sub cmbLevel_TextChanged(sender As Object, e As System.EventArgs) Handles cmbLevel.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_LeveLID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_LeveLID()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If
    End Sub

    Private Sub cmbTerm_TextChanged(sender As Object, e As System.EventArgs) Handles cmbTerm.TextChanged
        If cmbTerm.Text = "1st Semester" Then
            txtTerm.Text = 1
        ElseIf cmbTerm.Text = "2nd Semester" Then
            txtTerm.Text = 2
        ElseIf cmbTerm.Text = "Summer" Then
            txtTerm.Text = 3
        ElseIf cmbTerm.Text = "All" Then
            txtTerm.Text = ""
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If
    End Sub


    Private Sub mon_CheckedChanged(sender As Object, e As System.EventArgs) Handles mon.CheckedChanged, tue.CheckedChanged, wed.CheckedChanged, thurs.CheckedChanged, fri.CheckedChanged, sat.CheckedChanged


        If mon.Checked = True Then
            Dim m As String = "M"
            d1.Text = m
        Else
            d1.Text = ""
        End If

        If tue.Checked = True Then
            Dim t As String = "T"
            d2.Text = t
        Else
            d2.Text = ""
        End If

        If wed.Checked = True Then
            Dim w As String = "W"
            d3.Text = w
        Else
            d3.Text = ""
        End If

        If thurs.Checked = True Then
            Dim th As String = "TH"
            d4.Text = th
        Else
            d4.Text = ""
        End If

        If fri.Checked = True Then
            Dim f As String = "F"
            d5.Text = f
        Else
            d5.Text = ""
        End If

        If sat.Checked = True Then
            Dim s As String = "S"
            d6.Text = s
        Else
            d6.Text = ""
        End If

    End Sub

    Private Sub d1_TextChanged(sender As Object, e As System.EventArgs) Handles d1.TextChanged, d2.TextChanged, d3.TextChanged, d4.TextChanged, d5.TextChanged, d6.TextChanged
        txtDay.Text = d1.Text + d2.Text + d3.Text + d4.Text + d5.Text + d6.Text

    End Sub

    Private Sub dtSubjects_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtSubjects.CellClick
        Dim myVariable As String = dtSubjects.CurrentRow.Cells("subjectid").Value.ToString
        txtSubjectID.Text = myVariable

        Dim myVariable2 As String = dtSubjects.CurrentRow.Cells("subjectdescription").Value.ToString
        txtsubject.Text = myVariable2

    End Sub

    Private Sub generate_classschedule()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into classschedule ([facultyid],[courseid],[subjectid],[sectionid], [levelid]," & _
            "[term],[sy],[days], [time], [room]) values ('" & empid.Text & "', '" & txtCourseID.Text & "', '" & txtSubjectID.Text & "', '" & txtsectionID.Text & "','" & txtLevelID.Text & "'," & _
            "'" & Cterm & "','" & txtCAY.Text & "','" & txtDay.Text & "','" & txtTime.Text & "','" & txtroom.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()
    End Sub
   

    Private Sub verify_existingSchedule()

        sqlcmd.CommandText = "select  * FROM classschedule where courseid = '" & txtCourseID.Text & "' AND subjectid = '" & txtSubjectID.Text & "' AND sectionid = '" & txtsectionID.Text & "' AND levelid = '" & txtLevelID.Text & "' AND term = '" & Cterm & "' AND sy = '" & txtCAY.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            txtClassscheduleid.Text = daMyname.Item("classscheduleid")

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_classscheduleID()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_classscheduleID()
                sqlconn.Close()
            End If
            MessageBox.Show("Schedule Updated")
        Else
            txtClassscheduleid.Text = ""

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call generate_classschedule()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call generate_classschedule()
                sqlconn.Close()

            End If
            MessageBox.Show("Schedule Generated")
        End If

    End Sub
    Private Sub update_classscheduleID()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE classschedule SET facultyid = '" & empid.Text & "', courseid = '" & txtCourseID.Text & "', subjectid = '" & txtSubjectID.Text & "', sectionid = '" & txtsectionID.Text & "', levelid = '" & txtLevelID.Text & "' , term = '" & Cterm & "' , sy = '" & txtCAY.Text & "', days = '" & txtDay.Text & "', time = '" & txtTime.Text & "' , room = '" & txtroom.Text & "' where classscheduleid = '" & txtClassscheduleid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()

    End Sub
    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call verify_existingSchedule()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call verify_existingSchedule()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_Schedule()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_Schedule()
            sqlconn.Close()

        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub cmbcurrentterm_TextChanged(sender As Object, e As System.EventArgs) Handles cmbcurrentterm.TextChanged
        If cmbcurrentterm.Text = "1st Semester" Then
            Cterm = 1
            subjectGroup.Enabled = True
            dtSubjects.Enabled = True

        ElseIf cmbcurrentterm.Text = "2nd Semester" Then
            Cterm = 2
            subjectGroup.Enabled = True
            dtSubjects.Enabled = True

        ElseIf cmbcurrentterm.Text = "Summer" Then
            Cterm = 3
            subjectGroup.Enabled = True
            dtSubjects.Enabled = True
        ElseIf cmbcurrentterm.Text = "" Then
            Cterm = 0
            subjectGroup.Enabled = False
            dtSubjects.Enabled = False
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_college_faculty()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_college_faculty()
            sqlconn.Close()

        End If
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_course()
            Call fetch_yrlevel()

            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_course()
            Call fetch_yrlevel()
            sqlconn.Close()

        End If

    End Sub

    Private Sub fetch_college_faculty()
        Dim empcategory As String = "HS Faculty"
        Dim stat As Boolean = True
        Dim obj As Object = DBNull.Value
        Dim str As String = "select designation, designation1, designation2, p, p1, p2, surname + ', ' + firstname as name, id FROM employee WHERE (designation = '" & empcategory & "' and p = '" & stat & "') or (designation1 = '" & empcategory & "' and p1 = '" & stat & "') or (designation2 = '" & empcategory & "' and p2 = '" & stat & "') order by surname asc;"
        Dim cmd As New SqlCommand(str, sqlconn)


        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "employee")) Then

            dvgfaculty.Columns.Clear()


            dvgfaculty.DataSource = ds.Tables(0)
            dvgfaculty.Columns("designation").Visible = False
            dvgfaculty.Columns("designation1").Visible = False
            dvgfaculty.Columns("designation2").Visible = False
            dvgfaculty.Columns("p").Visible = False
            dvgfaculty.Columns("p1").Visible = False
            dvgfaculty.Columns("p2").Visible = False




            dvgfaculty.Columns("id").DisplayIndex = 0
            dvgfaculty.Columns("id").Width = 40
            dvgfaculty.Columns("id").HeaderText = "ID"

            dvgfaculty.Columns("name").DisplayIndex = 1
            dvgfaculty.Columns("name").Width = 140
            dvgfaculty.Columns("name").HeaderText = "Name"



            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else

        End If
    End Sub

    Private Sub fetch_Schedule()
        Dim empcategory As String = "HS Faculty"
        Dim stat As Boolean = True
        Dim obj As Object = DBNull.Value
        Dim str As String = "select surname + ', ' + firstname as name, facultyid, subjectcode, subjectdescription, days, time, room FROM ClassScheduleView WHERE (courseid = '" & txtCourseID.Text & "' AND levelid = '" & txtLevelID.Text & "' AND sectionid = '" & txtsectionID.Text & "' AND term = '" & Cterm & "' AND sy = '" & txtCAY.Text & "');"
        Dim cmd As New SqlCommand(str, sqlconn)


        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "ClassScheduleView")) Then

            dgvSchedule.Columns.Clear()


            dgvSchedule.DataSource = ds.Tables(0)



            dgvSchedule.Columns("facultyid").DisplayIndex = 0
            dgvSchedule.Columns("facultyid").Width = 60
            dgvSchedule.Columns("facultyid").HeaderText = "ID"

            dgvSchedule.Columns("name").DisplayIndex = 1
            dgvSchedule.Columns("name").Width = 180
            dgvSchedule.Columns("name").HeaderText = "Name"

            dgvSchedule.Columns("subjectcode").DisplayIndex = 2
            dgvSchedule.Columns("subjectcode").Width = 80
            dgvSchedule.Columns("subjectcode").HeaderText = "Subject Code"

            dgvSchedule.Columns("subjectdescription").DisplayIndex = 3
            dgvSchedule.Columns("subjectdescription").Width = 250
            dgvSchedule.Columns("subjectdescription").HeaderText = "Subject"

            dgvSchedule.Columns("days").DisplayIndex = 4
            dgvSchedule.Columns("days").Width = 80
            dgvSchedule.Columns("days").HeaderText = "Day"



            dgvSchedule.Columns("time").DisplayIndex = 5
            dgvSchedule.Columns("time").Width = 110
            dgvSchedule.Columns("time").HeaderText = "Time"


            dgvSchedule.Columns("room").DisplayIndex = 6
            dgvSchedule.Columns("room").Width = 120
            dgvSchedule.Columns("room").HeaderText = "Room"
            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else

        End If
    End Sub


    Private Sub dvgfaculty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgfaculty.CellClick

        Dim myVariable2 As String = dvgfaculty.CurrentRow.Cells("id").Value.ToString
        empid.Text = myVariable2
    End Sub

    Private Sub cmbsection_TextChanged(sender As Object, e As EventArgs) Handles cmbsection.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_sectionID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionID()
            sqlconn.Close()

        End If


        If sqlconn.State = ConnectionState.Open Then
            Call fetch_Schedule()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_Schedule()
            sqlconn.Close()

        End If

    End Sub


    Private Sub nofaculty_CheckedChanged(sender As Object, e As EventArgs) Handles nofaculty.CheckedChanged
        If nofaculty.Checked = True Then
            empid.Text = 0
            dvgfaculty.Enabled = False
        ElseIf nofaculty.Checked = False Then
            empid.Text = ""
            dvgfaculty.Enabled = True

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnRemove.Visible = True
        btnAdd.Visible = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        btnAdd.Visible = True
        btnRemove.Visible = False
        txtTime.Text = txtTimeIN.Text + "-" + txtTimeOut.Text
    End Sub

    Private Sub txtTimeIN_TextChanged(sender As Object, e As System.EventArgs) Handles txtTimeIN.TextChanged, txtTimeOut.TextChanged, txtTimeIn_1.TextChanged, txtTimeOut_1.TextChanged
        If btnRemove.Visible = True And btnAdd.Visible = False Then

            txtTime.Text = txtTimeIN.Text + "-" + txtTimeOut.Text + " | " + txtTimeIn_1.Text + "-" + txtTimeOut_1.Text
        ElseIf btnRemove.Visible = False And btnAdd.Visible = True Then
            txtTime.Text = txtTimeIN.Text + "-" + txtTimeOut.Text

        End If
    End Sub
    Private Sub fetch_CAY()
        Try
            Dim cmd As New SqlCommand("select count(courseid), CAY FROM curriculum " & _
                                            "where courseid = '" & txtCourseID.Text & "' group by CAY order by CAY desc;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "curriculum")) Then

                'ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
                cmbcurriculum.DataSource = ds.Tables(0)
                cmbcurriculum.ValueMember = "CAY"
                cmbcurriculum.DisplayMember = "CAY"
            Else
                cmbcurriculum.DataSource = ""
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbcurriculum_Click(sender As Object, e As EventArgs) Handles cmbcurriculum.Click
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_CAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_CAY()
            sqlconn.Close()

        End If
    End Sub
End Class