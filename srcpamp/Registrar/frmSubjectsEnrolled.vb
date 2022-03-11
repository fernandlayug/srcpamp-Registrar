Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjectsEnrolled
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Public rowID As String
    Public subjectunit As Double
    Public classscheduleid As String
    Dim today As Date
    Public secid As Integer
    Dim studentsection As String

    Private Sub classmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        today = Format(Now, "short date")

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_AY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_AY()
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


        If txtTermID.Text = "1" Then
            firstsem.Checked = True
        ElseIf txtTermID.Text = "2" Then
            secondsem.Checked = True
        ElseIf txtTermID.Text = "3" Then
            summer.Checked = True
        End If

        'SendMessage(Me.txtDescription.Handle, &H1501, 0, "Search subjects here...")
    End Sub
    Private Function total_lecunits()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To gridparticular.Rows.Count - 1
            tot = tot + Convert.ToDouble(gridparticular.Rows(i).Cells("subjectlecunit").Value)
        Next i
        Return tot

    End Function
    Private Function total_units()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To gridparticular.Rows.Count - 1
            tot = tot + Convert.ToDouble(gridparticular.Rows(i).Cells("subjectunits").Value)
        Next i
        Return tot

    End Function
    Private Function total_labunits()
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To gridparticular.Rows.Count - 1
            tot = tot + Convert.ToDouble(gridparticular.Rows(i).Cells("subjectlabunit").Value)
        Next i
        Return tot

    End Function

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
    Public Sub fetch_sujects()


        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname + ', ' + firstname as facultyname, coursecode, coursename, coursecategory, coursemajor, yrlevel, subjectcode, subjectdescription, subjectlecunit, subjectunits, subjectlabunit, subjectcategory, subjectprereq, term_classsched, sy, time, days, room, sectionid, sectioname, courseid, subjectid, levelid, classscheduleid FROM Subjectsview Where (courseid = '" & txtCourseID.Text & "' and sy = '" & txtSY.Text & "' and levelid = '" & txtLevelID.Text & "' and term_classsched = '" & txtTermID.Text & "' and sectionid = '" & secid & "')  order by subjectid ASC;", sqlconn)
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
            gridparticular.Columns("yrlevel").Visible = False
            gridparticular.Columns("term_classsched").Visible = False
            gridparticular.Columns("levelid").Visible = False
            gridparticular.Columns("sy").Visible = False
            gridparticular.Columns("sectionid").Visible = False
            gridparticular.Columns("sectioname").Visible = False
            gridparticular.Columns("subjectcategory").Visible = False
            gridparticular.Columns("classscheduleid").Visible = False


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
            gridparticular.Columns("subjectdescription").Width = 250

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

            gridparticular.Columns("time").DisplayIndex = 7
            gridparticular.Columns("time").HeaderText = "Time"
            gridparticular.Columns("time").Width = 100

            gridparticular.Columns("days").DisplayIndex = 8
            gridparticular.Columns("days").HeaderText = "Days"
            gridparticular.Columns("days").Width = 40

            gridparticular.Columns("room").DisplayIndex = 9
            gridparticular.Columns("room").HeaderText = "Room"
            gridparticular.Columns("room").Width = 70

            gridparticular.Columns("facultyname").DisplayIndex = 10
            gridparticular.Columns("facultyname").HeaderText = "Faculty"
            gridparticular.Columns("facultyname").Width = 150


            ' gridparticular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Else
            gridparticular.DataSource = Nothing
        End If


    End Sub
    Private Sub fetch_AY()
        Try
            Dim cmd As New SqlCommand("select count(courseid), AY FROM curriculum " & _
                                            "where courseid = '" & txtCourseID.Text & "' group by AY order by AY desc;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "curriculum")) Then

                'ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
                cmbAY.DataSource = ds.Tables(0)
                cmbAY.ValueMember = "AY"
                cmbAY.DisplayMember = "AY"
            Else
                cmbAY.DataSource = ""
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub save_gradingA()
        Dim a As Double = 0
        Dim b As String = ""
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into gradingA ([studentid],[sy],[levelid], " & _
            "[term],[subjectid],[classscheduleid],[1st],[2nd],[3rd],[final],[remarks], " & _
            "[units],[comment],[systemdate] ) values ('" & txtstudentid.Text & "', " & _
            "'" & txtSY.Text & "','" & txtStudentLevelID.Text & "','" & txtTermID2.Text & "', " & _
            "'" & rowID & "', '" & classscheduleid & "','" & a & "', '" & a & "', '" & a & "', " & _
            "'" & a & "', '" & b & "','" & subjectunit & "','" & b & "','" & today & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()
    End Sub
    Private Sub addSubjects()
        For i = 0 To Me.gridparticular.RowCount - 1
            rowID = Me.gridparticular.Rows(i).Cells("subjectid").Value
            subjectunit = Me.gridparticular.Rows(i).Cells("subjectunits").Value
            classscheduleid = Me.gridparticular.Rows(i).Cells("classscheduleid").Value

            ' If CBool(Me.gridparticular.Rows(i).Cells(0).Value) = True Then
            If CBool(Me.gridparticular.Rows(i).Cells("chk").Value) = True Then


                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    sqlcmd.CommandText = "select * FROM gradingA Where (studentid = '" & txtstudentid.Text & "') and (sy = '" & txtSY.Text & "') and (levelid = '" & txtStudentLevelID.Text & "') and (term = '" & txtTermID2.Text & "') and (subjectid = '" & rowID & "');"
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

                    sqlcmd.CommandText = "select * FROM gradingA Where (studentid = '" & txtstudentid.Text & "') and (sy = '" & txtSY.Text & "') and (levelid = '" & txtStudentLevelID.Text & "') and (term = '" & txtTermID2.Text & "') and (subjectid = '" & rowID & "');"
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btncheckall.Click
        If btnCheckAll.Text = "Check All" Then

            For Each row As DataGridViewRow In gridparticular.Rows

                CType(row.Cells("chk"), DataGridViewCheckBoxCell).Value = True
            Next
            btncheckall.Text = "Uncheck All"
        Else
            For Each row As DataGridViewRow In gridparticular.Rows

                CType(row.Cells("chk"), DataGridViewCheckBoxCell).Value = False

            Next

            btncheckall.Text = "Check All"

        End If
    End Sub

    Private Sub cmbAY_TextChanged(sender As Object, e As System.EventArgs) Handles cmbAY.TextChanged
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

    Private Sub gridparticular_DataSourceChanged(sender As Object, e As System.EventArgs) Handles gridparticular.DataSourceChanged
        Try
            txtlecunits.Text = total_lecunits()
            txtlabunits.Text = total_labunits()
            txttotalunits.Text = total_units()
            txttotalsubjects.Text = gridparticular.RowCount
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_section()
        Dim cmdsection As New SqlCommand("select * FROM section " & _
                                        "where category = '" & cmbSubjectCategory.Text & "';", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "course")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)

            cmbSection.DataSource = ds_section.Tables(0)
            cmbSection.ValueMember = "sectioname"
            cmbSection.DisplayMember = "sectioname"
        End If
    End Sub

    Private Sub btnchangesection_Click(sender As Object, e As EventArgs) Handles btnchangesection.Click
        If btnchangesection.Text = "Change Section" Then
            cmbSection.Enabled = True
            studentsection = cmbSection.Text
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
            btnchangesection.Text = "Return to Current Section"
        ElseIf btnchangesection.Text = "Return to Current Section" Then
 

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

            btnchangesection.Text = "Change Section"
            cmbSection.Text = studentsection
            cmbSection.Enabled = False
        End If
    End Sub
    Private Sub fetch_sectionid()
        sqlcmd.CommandText = "select  * FROM section where category = '" & cmbSubjectCategory.Text & "' AND sectioname = '" & cmbSection.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            secid = daMyname.Item("sectionid")
        Else
            secid = 0
        End If

    End Sub


    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
        If btnchangesection.Text = "Return to Current Section" Then
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

        ElseIf btnchangesection.Text = "Change Section" Then

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        CourseChangeSchedule.Show()
    End Sub
End Class