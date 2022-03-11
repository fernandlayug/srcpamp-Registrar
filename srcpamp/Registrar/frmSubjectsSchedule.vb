Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjectsschedule
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public rowID As String
    Public subjectunit As Double
    Public classscheduleid As String

    Private Sub classmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        datetoday.Text = Now



        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sujects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sujects()
            sqlconn.Close()
        End If


        If txtTermID.Text = "1" Then
            firstsem.Checked = True
        ElseIf txtTermID.Text = "2" Then
            secondsem.Checked = True
        ElseIf txtTermID.Text = "3" Then
            summer.Checked = True
        End If

        'SendMessage(Me.txtDescription.Handle, &H1501, 0, "Search subjects here...")
    End Sub
    Private Sub fetch_course()
        Dim cmdcourse As New SqlCommand("select COUNT(coursecategory), coursename, SUM(courseID) FROM course " & _
                                        "where coursecategory = '" & cmbSubjectCategory.Text & "' group by coursename;", sqlconn)
        Dim adptcourse As New SqlDataAdapter(cmdcourse)
        Dim ds_course As New DataSet()
        If (adptcourse.Fill(ds_course, "course")) Then

            ds_course.Tables(0).Rows.InsertAt(ds_course.Tables(0).NewRow(), 0)

            txtCourse.DataSource = ds_course.Tables(0)
            txtCourse.ValueMember = "coursename"
            txtCourse.DisplayMember = "coursename"
        End If
    End Sub
    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursecode = '" & coursecode.Text & "'order by courseid ASC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then
            txtMajor.Enabled = True

            'ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            txtMajor.DataSource = ds_major.Tables(0)
            txtMajor.ValueMember = "coursemajor"
            txtMajor.DisplayMember = "coursemajor"
        Else
            txtMajor.DataSource = Nothing


        End If

    End Sub

    Private Sub fetch_yrlevel()
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & cmbSubjectCategory.Text & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)

            txtLevel.DataSource = ds_level.Tables(0)
            txtLevel.ValueMember = "yrlevel"
            txtLevel.DisplayMember = "yrlevel"
        End If
    End Sub
    Private Sub fetch_sujects()
        Try
            Dim obj As Object = DBNull.Value

            Dim cmd As New SqlCommand("select * FROM Subjectsview Where (courseid = '" & txtCourseID.Text & "' and levelid = '" & txtLevelID.Text & "' and term = '" & txtTermID.Text & "')  order by subjectid ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "subjectsview")) Then

                gridparticular.Columns.Clear()

                gridparticular.DataSource = ds.Tables(0)

                Dim chk As New DataGridViewCheckBoxColumn
                gridparticular.Columns("subjectid").Visible = False
                gridparticular.Columns("courseid").Visible = False
                gridparticular.Columns("coursecode").Visible = False
                gridparticular.Columns("coursename").Visible = False
                gridparticular.Columns("coursecategory").Visible = False
                gridparticular.Columns("coursemajor").Visible = False
                gridparticular.Columns("classscheduleID").Visible = False
                gridparticular.Columns("yrlevel").Visible = False
                gridparticular.Columns("term").Visible = False
                gridparticular.Columns("levelid").Visible = False
                gridparticular.Columns("curriculumid").Visible = False


                gridparticular.Columns.Add(chk)
                chk.HeaderText = "Add"
                chk.Name = "chk"

                gridparticular.Columns("chk").DisplayIndex = 0
                gridparticular.Columns("chk").Width = 50

                gridparticular.Columns("subjectcode").DisplayIndex = 1
                gridparticular.Columns("subjectcode").Width = 60
                gridparticular.Columns("subjectcode").HeaderText = "Code"

                gridparticular.Columns("subjectdescription").DisplayIndex = 2
                gridparticular.Columns("subjectdescription").HeaderText = "Subject"
                gridparticular.Columns("subjectdescription").Width = 280

                gridparticular.Columns("subjectlecunit").DisplayIndex = 3
                gridparticular.Columns("subjectlecunit").HeaderText = "LecUnits"
                gridparticular.Columns("subjectlecunit").Width = 50
                gridparticular.Columns("subjectlecunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                gridparticular.Columns("subjectlabunit").DisplayIndex = 4
                gridparticular.Columns("subjectlabunit").HeaderText = "LabUnits"
                gridparticular.Columns("subjectlabunit").Width = 50
                gridparticular.Columns("subjectlabunit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                gridparticular.Columns("subjectunits").DisplayIndex = 5
                gridparticular.Columns("subjectunits").HeaderText = "Units"
                gridparticular.Columns("subjectunits").Width = 50
                gridparticular.Columns("subjectunits").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                gridparticular.Columns("subjectprereq").DisplayIndex = 6
                gridparticular.Columns("subjectprereq").HeaderText = "Pre-req"
                gridparticular.Columns("subjectprereq").Width = 70

                gridparticular.Columns("days").DisplayIndex = 7
                gridparticular.Columns("days").HeaderText = "Days"
                gridparticular.Columns("days").Width = 50

                gridparticular.Columns("time").DisplayIndex = 8
                gridparticular.Columns("time").HeaderText = "Time"
                gridparticular.Columns("time").Width = 120

                gridparticular.Columns("room").DisplayIndex = 9
                gridparticular.Columns("room").HeaderText = "Room"
                gridparticular.Columns("room").Width = 100
                ' gridparticular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Else
                gridparticular.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub save_gradingA()
        Dim a As Double = 0
        Dim b As String = ""
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into gradingA ([studentid],[sy],[levelid], " & _
            "[term],[curriculumid],[1st],[2nd],[3rd],[final],[remarks], " & _
            "[units],[comment],[systemdate] ) values ('" & txtstudentid.Text & "', " & _
            "'" & txtSY.Text & "','" & txtLevelID.Text & "','" & txtTermID.Text & "', " & _
            "'" & rowID & "', '" & a & "', '" & a & "', '" & a & "', " & _
            "'" & a & "', '" & b & "','" & subjectunit & "','" & b & "','" & datetoday.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()

    End Sub

    Private Sub addSubjects()
        For i = 0 To Me.gridparticular.RowCount - 1
            rowID = Me.gridparticular.Rows(i).Cells("curriculumid").Value
            subjectunit = Me.gridparticular.Rows(i).Cells("subjectunits").Value
            'classscheduleid = Me.gridparticular.Rows(i).Cells("classscheduleID").Value

            ' If CBool(Me.gridparticular.Rows(i).Cells(0).Value) = True Then
            If CBool(Me.gridparticular.Rows(i).Cells("chk").Value) = True Then


                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    sqlcmd.CommandText = "select * FROM gradingA Where (studentid = '" & txtstudentid.Text & "') and (sy = '" & txtSY.Text & "') and (levelid = '" & txtLevelID.Text & "') and (term = '" & txtTermID.Text & "') and (curriculumid = '" & rowID & "');"
                    sqlcmd.Connection = sqlconn
                    Dim daMyname As SqlDataReader
                    daMyname = sqlcmd.ExecuteReader()
                    If daMyname.HasRows Then
                        daMyname.Read()

                    Else
                        If sqlconn.State = ConnectionState.Open Then
                            sqlconn.Close()
                            sqlconn.Open()

                            Call save_gradingA()
                            sqlconn.Close()
                        ElseIf sqlconn.State = ConnectionState.Closed Then
                            sqlconn.Open()
                            Call save_gradingA()
                            sqlconn.Close()

                        End If
                    End If

                ElseIf sqlconn.State = ConnectionState.Closed Then
                    sqlconn.Open()

                    sqlcmd.CommandText = "select * FROM gradingA Where (studentid = '" & txtstudentid.Text & "') and (sy = '" & txtSY.Text & "') and (levelid = '" & txtLevelID.Text & "') and (term = '" & txtTermID.Text & "') and (curriculumid = '" & rowID & "');"
                    sqlcmd.Connection = sqlconn
                    Dim daMyname As SqlDataReader
                    daMyname = sqlcmd.ExecuteReader()
                    If daMyname.HasRows Then
                        daMyname.Read()

                    Else
                        If sqlconn.State = ConnectionState.Open Then
                            sqlconn.Close()
                            sqlconn.Open()

                            Call save_gradingA()
                            sqlconn.Close()
                        ElseIf sqlconn.State = ConnectionState.Closed Then
                            sqlconn.Open()
                            Call save_gradingA()
                            sqlconn.Close()

                        End If
                    End If
                End If

            End If

        Next
        MsgBox("Update Finished")

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call studentfile.fetch_subjectsenrolled()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call studentfile.fetch_subjectsenrolled()
            sqlconn.Close()
        End If
        Me.Dispose()


    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call addSubjects()
    End Sub


    Private Sub firstsem_CheckedChanged(sender As Object, e As System.EventArgs) Handles firstsem.CheckedChanged, secondsem.CheckedChanged, summer.CheckedChanged
        If firstsem.Checked = True Then
            txtTermID.Text = 1
        ElseIf secondsem.Checked = True Then
            txtTermID.Text = 2
        ElseIf summer.Checked = True Then
            txtTermID.Text = 3
        End If
    End Sub

    Private Sub txtCourse_Enter(sender As Object, e As System.EventArgs) Handles txtCourse.Enter
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()

            Call fetch_course()
            sqlconn.Close()
        ElseIf sqlconn.State = ConnectionState.Closed Then
            sqlconn.Open()
            Call fetch_course()
            sqlconn.Close()

        End If

    End Sub


    Private Sub txtMajor_Click(sender As Object, e As System.EventArgs) Handles txtMajor.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()

            Call fetch_coursemajor()
            sqlconn.Close()
        ElseIf sqlconn.State = ConnectionState.Closed Then
            sqlconn.Open()
            Call fetch_coursemajor()
            sqlconn.Close()

        End If
    End Sub
    Private Sub txtLevel_Click(sender As Object, e As System.EventArgs) Handles txtLevel.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()

            Call fetch_yrlevel()
            sqlconn.Close()
        ElseIf sqlconn.State = ConnectionState.Closed Then
            sqlconn.Open()
            Call fetch_yrlevel()
            sqlconn.Close()

        End If
    End Sub
    Private Sub fetch_levelid()
        Try
            sqlcmd.CommandText = "select  * FROM level where yrlevel = '" & txtLevel.Text & "' AND category = '" & cmbSubjectCategory.Text & "'"
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

    Private Sub txtLevel_TextChanged(sender As Object, e As System.EventArgs) Handles txtLevel.TextChanged

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_levelid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_levelid()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sujects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sujects()
            sqlconn.Close()
        End If

    End Sub
End Class