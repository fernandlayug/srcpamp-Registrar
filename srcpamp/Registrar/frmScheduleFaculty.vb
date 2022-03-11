Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmScheduleFaculty
    Dim category As String
    Dim cAY As String


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub frmCurriculum_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cAY = Main.SY.Text
        sqlserver.connect()
    End Sub
    Private Sub numberzero()
        Dim units As Double
        Units = 0
    End Sub
    Private Sub fetch_courseID()
        Try
            sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & category & "' AND coursemajor = '" & cmbMajor.Text & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtcourseid.Text = daMyname.Item("courseid")
            Else
                txtcourseid.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub fetch_subjects()
        Try
            Dim obj As Object = DBNull.Value

            'Dim a As String = "select * FROM FacultyScheduleView WHERE (courseid = '" & txtcourseid.Text & "' AND levelid = '" & txtlevelid.Text & "' AND term = '" & txtTerm.Text & "');"
            'Dim b As String = "select * FROM FacultyScheduleView WHERE (courseid = '" & txtcourseid.Text & "' AND levelid = '" & txtlevelid.Text & "');"
            'Dim str As String
            'If txtTerm.Text = "" Then
            'Str = b
            ' Else
            'Str = a
            'End If
            Dim str As String = "select * FROM FacultyScheduleView WHERE (courseid = '" & txtcourseid.Text & "' and Cterm = '" & txtTerm.Text & "' and CAY = '" & cAY & "');"

            Dim cmd As New SqlCommand(Str, sqlconn)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "FacultyScheduleView")) Then
                dtSubjects.Columns.Clear()

                dtSubjects.DataSource = ds.Tables(0)

                dtSubjects.Columns("ay").Visible = False

                dtSubjects.Columns("curriculumid").Visible = False
                dtSubjects.Columns("courseid").Visible = False
                dtSubjects.Columns("levelid").Visible = False
                'dtSubjects.Columns("term").Visible = False
                dtSubjects.Columns("classscheduleid").Visible = False
                dtSubjects.Columns("subjectid").Visible = False
                dtSubjects.Columns("coursecode").Visible = False
                dtSubjects.Columns("coursename").Visible = False
                dtSubjects.Columns("coursecategory").Visible = False
                dtSubjects.Columns("coursemajor").Visible = False
                'dtSubjects.Columns("yrlevel").Visible = False
                dtSubjects.Columns("subjectlecunit").Visible = False
                dtSubjects.Columns("subjectlabunit").Visible = False
                dtSubjects.Columns("subjectunits").Visible = False
                dtSubjects.Columns("subjectprereq").Visible = False
                dtSubjects.Columns("CAY").Visible = False
                dtSubjects.Columns("Cterm").Visible = False
                dtSubjects.Columns("facultyid").Visible = False
                dtSubjects.Columns("firstname").Visible = False
                dtSubjects.Columns("mname").Visible = False
                dtSubjects.Columns("surname").Visible = False

                dtSubjects.Columns("subjectcode").DisplayIndex = 0
                dtSubjects.Columns("subjectcode").Width = 80
                dtSubjects.Columns("subjectcode").HeaderText = "Code"

                dtSubjects.Columns("subjectdescription").DisplayIndex = 1
                dtSubjects.Columns("subjectdescription").Width = 250
                dtSubjects.Columns("subjectdescription").HeaderText = "Subject"

                dtSubjects.Columns("yrlevel").DisplayIndex = 2
                dtSubjects.Columns("yrlevel").Width = 40
                dtSubjects.Columns("yrlevel").HeaderText = "Level"

                dtSubjects.Columns("term").DisplayIndex = 3
                dtSubjects.Columns("term").Width = 40
                dtSubjects.Columns("term").HeaderText = "Term"

                dtSubjects.Columns("days").DisplayIndex = 4
                dtSubjects.Columns("days").Width = 35
                dtSubjects.Columns("days").HeaderText = "Day"

                dtSubjects.Columns("time").DisplayIndex = 5
                dtSubjects.Columns("time").Width = 115
                dtSubjects.Columns("time").HeaderText = "Time"

                dtSubjects.Columns("room").DisplayIndex = 6
                dtSubjects.Columns("room").Width = 80
                dtSubjects.Columns("room").HeaderText = "Room"

                For RCnt As Integer = 0 To dtSubjects.Rows.Count - 1
                    If dtSubjects.Rows(RCnt).Cells("facultyid").Value <> 0 And dtSubjects.Rows(RCnt).Cells("CAY").Value = cAY And dtSubjects.Rows(RCnt).Cells("Cterm").Value = txtTerm.Text Then
                        'dtSubjects.Rows(RCnt).ReadOnly = True
                        dtSubjects.Rows(RCnt).DefaultCellStyle.BackColor = Color.Yellow
                    Else
                    End If
                Next
            Else
                dtSubjects.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub fetch_subjectswithfaculty()
        Try
            Dim obj As Object = DBNull.Value

            Dim str As String = "select surname +', ' + firstname as name, subjectcode, subjectdescription, days, time, room FROM FacultyScheduleView WHERE (facultyid = '" & txtFacultyid.Text & "');"

            Dim cmd As New SqlCommand(str, sqlconn)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "FacultyScheduleView")) Then
                dtSchedule.Columns.Clear()

                dtSchedule.DataSource = ds.Tables(0)

                dtSchedule.Columns("name").Visible = False

                dtSchedule.Columns("subjectcode").DisplayIndex = 0
                dtSchedule.Columns("subjectcode").Width = 60
                dtSchedule.Columns("subjectcode").HeaderText = "Code"

                dtSchedule.Columns("subjectdescription").DisplayIndex = 1
                dtSchedule.Columns("subjectdescription").Width = 305
                dtSchedule.Columns("subjectdescription").HeaderText = "Subject"

                dtSchedule.Columns("days").DisplayIndex = 2
                dtSchedule.Columns("days").Width = 40
                dtSchedule.Columns("days").HeaderText = "Day"

                dtSchedule.Columns("time").DisplayIndex = 3
                dtSchedule.Columns("time").Width = 120
                dtSchedule.Columns("time").HeaderText = "Time"

                dtSchedule.Columns("room").DisplayIndex = 4
                dtSchedule.Columns("room").Width = 110
                dtSchedule.Columns("room").HeaderText = "Room"


                ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else

                dtSchedule.Columns.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub fetch_course()


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
        Dim cmdmajor As New SqlCommand("select * FROM course where coursename = '" & cmbCourse.Text & "'order by courseid Desc;", sqlconn)
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


    Private Sub chkCollege_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkCollege.CheckedChanged, chkSenior.CheckedChanged
        If chkCollege.Checked = True Then
            category = "College"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_college_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_college_faculty()
                sqlconn.Close()

            End If
        ElseIf chkSenior.Checked = True Then
            category = "Senior HS"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_SHS_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_SHS_faculty()
                sqlconn.Close()

            End If
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_course()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_course()
            sqlconn.Close()

        End If

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

    Private Sub update_curriculum()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE curriculum SET facultyid = '" & txtFacultyid.Text & "' where curriculumid = '" & txtcurriculumid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Subject added to faculty schedule.")
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

            dtFaculty.Columns("id").DisplayIndex = 0
            dtFaculty.Columns("id").Width = 40
            dtFaculty.Columns("id").HeaderText = "ID"

            dtFaculty.Columns("name").DisplayIndex = 1
            dtFaculty.Columns("name").Width = 140
            dtFaculty.Columns("name").HeaderText = "Name"

          

            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else


        End If
    End Sub
    Private Sub fetch_SHS_faculty()
        Dim category As String = "HS Faculty"
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

            dtFaculty.Columns("id").DisplayIndex = 0
            dtFaculty.Columns("id").Width = 40
            dtFaculty.Columns("id").HeaderText = "ID"

            dtFaculty.Columns("name").DisplayIndex = 1
            dtFaculty.Columns("name").Width = 140
            dtFaculty.Columns("name").HeaderText = "Name"



            ' dtsubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else


        End If
    End Sub
    Private Sub dtFaculty_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtFaculty.CellClick, dtFaculty.CellEnter
        Dim myVariable As String = dtFaculty.CurrentRow.Cells("id").Value.ToString
        txtFacultyid.Text = myVariable

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_facultyname()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_facultyname()
            sqlconn.Close()

        End If
    End Sub
    Private Sub dtSubjects_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtSubjects.CellClick
        Dim myVariable As String = dtSubjects.CurrentRow.Cells("curriculumid").Value.ToString
        txtcurriculumid.Text = myVariable
    End Sub

    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        If sqlconn.State = ConnectionState.Open Then
            Call update_curriculum()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_curriculum()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjectswithfaculty()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjectswithfaculty()
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

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
    Private Sub fetch_facultyname()
        Try
            sqlcmd.CommandText = "select surname +', ' + firstname as name, id FROM employee WHERE (id = '" & txtFacultyid.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                txtfacultname.Text = daMyname.Item("name")
            Else
                txtfacultname.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFacultyid_TextChanged(sender As Object, e As System.EventArgs) Handles txtFacultyid.TextChanged
        Try
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_subjectswithfaculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_subjectswithfaculty()
                sqlconn.Close()

            End If
        Catch ex As Exception

        End Try
    End Sub


End Class