
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class CreateEmail
    Dim sid, f, s, m, mail, domainname As String
    Dim yrlevelcategory As String = "College"
    Dim courseid_temp As String
    Dim levelid As Integer
    Dim sectionID As Integer
    Dim term As Integer = 1
    Dim sy As String = "2020-2021"


    Private Sub CreateEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlserver.connect()
        domainname = "@srcpamp.com"

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
    End Sub
    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursename = '" & cmbCourse.Text & "'order by courseid ASC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then
            cmbMajor.Enabled = True

            ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else
            cmbMajor.DataSource = Nothing
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
    Private Sub fetch_student()
        Dim blank As String = ""
        Dim cmd As New SqlCommand("select studentID, surname, firstname, mname, email FROM studentdata Where (email = '" & blank & "');", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "employee")) Then

            dgview.DataSource = ds.Tables(0)

            dgview.Columns("studentID").DisplayIndex = 0
            dgview.Columns(0).HeaderText = "ID"
            'faculty.Columns(0).Width = 50

            dgview.Columns("surname").DisplayIndex = 1
            dgview.Columns("surname").HeaderText = "Surname"
            ' faculty.Columns(3).Width = 80

            dgview.Columns("firstname").DisplayIndex = 2
            dgview.Columns("firstname").HeaderText = "Firstname"
            'faculty.Columns(1).Width = 80

            dgview.Columns("mname").DisplayIndex = 3
            dgview.Columns("mname").HeaderText = "M. Initial"
            'faculty.Columns(2).Width = 80

            dgview.Columns("email").DisplayIndex = 4
            dgview.Columns("email").HeaderText = "Email"
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            'MessageBox.Show("No match Found")
            dgview.DataSource = Nothing
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_student()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_student()
            sqlconn.Close()
        End If
    End Sub
    Private Sub update_records()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE studentdata SET email = '" & mail & "' where studentID = '" & sid & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Records Updated")
    End Sub

    Private Sub verify_email()
        sqlcmd.CommandText = "select * FROM studentdata where email = '" & mail & "';"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            MessageBox.Show("Email Already Exist")
            sqlconn.Close()
        Else
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_records()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_records()
                sqlconn.Close()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index As Integer = 0
        Dim numrows As Integer
        numrows = dgview.RowCount

        For Each row As DataGridViewRow In dgview.Rows
            sid = (CStr(row.Cells(0).FormattedValue))
            s = (CStr(row.Cells(1).FormattedValue))
            f = (CStr(row.Cells(2).FormattedValue))

                mail = LCase(f) + "." + LCase(s) + domainname


                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call verify_email()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call verify_email()
                    sqlconn.Close()
                End If


                Dim currentrows As Integer
                index += 1
                currentrows = index

        Next
        MessageBox.Show("Complete")
    End Sub
    Private Sub fetch_courseid()
        sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursemajor = '" & cmbMajor.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            courseID_temp = daMyname.Item("courseid")

        Else
            courseID_temp = 0

        End If

    End Sub

    Private Sub cmbCourse_TextChanged(sender As Object, e As EventArgs) Handles cmbCourse.TextChanged
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


    End Sub


    Private Sub level_TextChanged(sender As Object, e As EventArgs) Handles level.TextChanged
        If level.Text = 1 Then
            levelid_temp.Text = "17"
            levelid = "17"
        ElseIf level.Text = 2 Then
            levelid_temp.Text = "18"
            levelid = "18"
        ElseIf level.Text = 3 Then
            levelid_temp.Text = "19"
            levelid = "19"
        ElseIf level.Text = 4 Then
            levelid_temp.Text = "20"
            levelid = "20"
        End If
    End Sub

    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
        If cmbSection.Text = "A" Then
            sectionID = 1
        ElseIf cmbSection.Text = "B" Then
            sectionID = 2
        ElseIf cmbSection.Text = "C" Then
            sectionID = 3
        End If




        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_studentlist_INsection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentlist_INsection()
            sqlconn.Close()
        End If
    End Sub

    Private Sub fetch_studentlist_INsection()

        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname + ', ' +  firstname + ' ' + mname as name, studentID, sex, lastschlaverage FROM AdmissionView  Where  courseid = " & courseid_temp & " AND levelid = " & levelid & " AND term = " & term & " AND section = " & sectionID & " AND sy = '" & sy & "';", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)


        If (adpt.Fill(ds, "AdmissionView")) Then
            dgvsection.Columns.Clear()

            dgvsection.DataSource = ds.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn

            dgvsection.Columns("lastschlaverage").Visible = False

            dgvsection.Columns("studentID").DisplayIndex = 0
            dgvsection.Columns("studentID").Width = 75
            dgvsection.Columns("studentID").HeaderText = "Student ID"

            dgvsection.Columns("name").DisplayIndex = 1
            dgvsection.Columns("name").Width = 210
            dgvsection.Columns("name").HeaderText = "Name"

            dgvsection.Columns("sex").DisplayIndex = 2
            dgvsection.Columns("sex").Width = 60
            dgvsection.Columns("sex").HeaderText = "Gender"

        Else
            dgvsection.DataSource = Nothing
        End If
      
    End Sub

    Private Sub fetch_Schedule()
        Dim empcategory As String = "COL Faculty"
        Dim stat As Boolean = True
        Dim obj As Object = DBNull.Value
        Dim str As String = "select classscheduleid , surname + ', ' + firstname as name, facultyid, subjectid, subjectcode, subjectdescription, days, time, room FROM ClassScheduleView WHERE (courseid = '" & courseid_temp & "' AND levelid = '" & levelid & "' AND sectionid = '" & sectionID & "' AND term = '" & term & "' AND sy = '" & sy & "');"
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

    Private Sub getsched_Click(sender As Object, e As EventArgs) Handles getsched.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_Schedule()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_Schedule()
            sqlconn.Close()
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Call process_schedule()
    End Sub

    Private Sub dgvSchedule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick
        Dim myVariable2 As String = dgvSchedule.CurrentRow.Cells("classscheduleid").Value.ToString
        classid.Text = myVariable2

        Dim myVariable3 As String = dgvSchedule.CurrentRow.Cells("subjectid").Value.ToString
        subjectID.Text = myVariable3
    End Sub
    Private Sub update_gradingA()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE gradingA SET classscheduleid = '" & classid.Text & "' where studentID = '" & sid & "' AND subjectid = '" & subjectID.Text & "' AND sy = '" & sy & "' AND term = '" & term & "' AND levelid ='" & levelid_temp.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub process_schedule()
        Dim index As Integer = 0
        Dim numrows As Integer
        numrows = dgview.RowCount

        For Each row As DataGridViewRow In dgvsection.Rows
            sid = (CStr(row.Cells(1).FormattedValue))

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_gradingA()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_gradingA()
                sqlconn.Close()
            End If


            Dim currentrows As Integer
            index += 1
            currentrows = index

        Next
        MessageBox.Show("Complete")
    End Sub

    Private Sub cmbMajor_TextChanged(sender As Object, e As EventArgs) Handles cmbMajor.TextChanged
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
    End Sub
End Class