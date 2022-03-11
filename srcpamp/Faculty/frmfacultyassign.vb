Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmfacultyassign

    Private Sub frmassess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub view_hsfaculty()
        Try
            'Dim cmd As New SqlCommand("select * FROM employee Where (department = '" & Main.dep.Text & "') order by surname ASC;", sqlconn)
            Dim cmd As New SqlCommand("select * FROM employee order by surname ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "employee")) Then

                faculty.DataSource = ds.Tables(0)
                faculty.Columns("sex").Visible = False
                faculty.Columns("birthday").Visible = False
                faculty.Columns("address").Visible = False
                faculty.Columns("address1").Visible = False
                faculty.Columns("address2").Visible = False
                faculty.Columns("address3").Visible = False
                faculty.Columns("telephone").Visible = False
                faculty.Columns("mobile").Visible = False
                faculty.Columns("religion").Visible = False
                faculty.Columns("citizenship").Visible = False
                faculty.Columns("civilstatus").Visible = False
                faculty.Columns("spouse").Visible = False
                faculty.Columns("spousecontact").Visible = False
                faculty.Columns("education").Visible = False
                faculty.Columns("education1").Visible = False
                faculty.Columns("education2").Visible = False
                faculty.Columns("education3").Visible = False
                faculty.Columns("datehired").Visible = False
                faculty.Columns("designation").Visible = False
                faculty.Columns("department").Visible = False
                faculty.Columns("username").Visible = False
                faculty.Columns("password").Visible = False
                faculty.Columns("accounttype").Visible = False
                faculty.Columns("status").Visible = False
                faculty.Columns("pic").Visible = False
                faculty.Columns("designation1").Visible = False
                faculty.Columns("dep1").Visible = False
                faculty.Columns("status1").Visible = False
                faculty.Columns("designation2").Visible = False
                faculty.Columns("dep2").Visible = False
                faculty.Columns("status2").Visible = False


                faculty.Columns(0).DisplayIndex = 0
                faculty.Columns(0).HeaderText = "ID"
                faculty.Columns(0).Width = 50

                faculty.Columns(3).DisplayIndex = 1
                faculty.Columns(3).HeaderText = "Surname"
                faculty.Columns(3).Width = 80

                faculty.Columns(1).DisplayIndex = 2
                faculty.Columns(1).HeaderText = "Firstname"
                faculty.Columns(1).Width = 80

                faculty.Columns(2).DisplayIndex = 3
                faculty.Columns(2).HeaderText = "M. Initial"
                faculty.Columns(2).Width = 80

                'assignment.AutoSizeColumnsMode = facultytaGridViewAutoSizeColumnsMode.Fill

            Else
                'MessageBox.Show("No match Found")
                faculty.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub frmfacultyassign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        'Combo box for SY
        Dim cmdsy As New SqlCommand("select * FROM sy order by sy desc;", sqlconn)
        Dim adptsy As New SqlDataAdapter(cmdsy)
        Dim ds_sy As New DataSet()
        If (adptsy.Fill(ds_sy, "sy")) Then

            'ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)
            sy.DataSource = ds_sy.Tables(0)
            sy.ValueMember = "sy"
            sy.DisplayMember = "sy"

        End If


        Try
            'Combo box for level
            Dim cmdlevel As New SqlCommand("select * FROM level where (category = '" & Main.dep.Text & "');", sqlconn)
            Dim adptlevel As New SqlDataAdapter(cmdlevel)
            Dim ds_level As New DataSet()
            If (adptlevel.Fill(ds_level, "level")) Then

                ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
                level.DataSource = ds_level.Tables(0)
                level.ValueMember = "yrlevel"
                level.DisplayMember = "yrlevel"
            End If
        Catch ex As Exception

        End Try


        Try

            Dim cmdsub As New SqlCommand("select * FROM assignSUBJECT where (category = '" & Main.dep.Text & "');", sqlconn)
            Dim adptsub As New SqlDataAdapter(cmdsub)
            Dim ds_sub As New DataSet()
            If (adptsub.Fill(ds_sub, "subject")) Then

                ds_sub.Tables(0).Rows.InsertAt(ds_sub.Tables(0).NewRow(), 0)
                subject.DataSource = ds_sub.Tables(0)
                subject.ValueMember = "subject"
                subject.DisplayMember = "subject"
            End If
        Catch ex As Exception

        End Try


        If sqlconn.State = ConnectionState.Open Then
            Call fetch_location()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_location()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call view_hsfaculty()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call view_hsfaculty()
            sqlconn.Close()
        End If
    End Sub
    Private Sub fetch_records()
        sqlcmd.CommandText = "select * FROM employee Where (id = '" & ID.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            firstname.Text = daMyname.Item("firstname")
            firstname.Enabled = False
            mname.Text = daMyname.Item("mname")
            mname.Enabled = False
            surname.Text = daMyname.Item("surname")
            surname.Enabled = False
            department.Text = daMyname.Item("department")
            'department.Enabled = False
            designation.Text = daMyname.Item("designation")

        Else
            ' MsgBox("No records Found")
            firstname.Text = ""
            mname.Text = ""
            surname.Text = ""
            department.Text = ""
            designation.Text = ""
        End If
    End Sub
    Private Sub fetch_assignment()
        Try
            Dim cmd As New SqlCommand("select * FROM classassign Where (empid = '" & ID.Text & "');", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "classassign")) Then

                assignment.DataSource = ds.Tables(0)
                'assignment.DataSource = bs
                assignment.Columns("empid").Visible = False
                'assignment.Columns("assignid").Visible = False
                assignment.Columns("sy").Visible = False

                assignment.Columns(0).HeaderText = "Assign ID"
                assignment.Columns(0).Width = 50
                assignment.Columns(3).HeaderText = "Level"
                assignment.Columns(3).Width = 80
                assignment.Columns(4).HeaderText = "Section"
                assignment.Columns(4).Width = 110
                assignment.Columns(5).HeaderText = "Subject"
                assignment.Columns(5).Width = 80
                assignment.Columns(6).HeaderText = "Time"
                assignment.Columns(6).Width = 90
                assignment.Columns(7).HeaderText = "Mon"
                assignment.Columns(7).Width = 50
                assignment.Columns(8).HeaderText = "Tue"
                assignment.Columns(8).Width = 50
                assignment.Columns(9).HeaderText = "Wed"
                assignment.Columns(9).Width = 50
                assignment.Columns(10).HeaderText = "Thu"
                assignment.Columns(10).Width = 50
                assignment.Columns(11).HeaderText = "Fri"
                assignment.Columns(11).Width = 50
                assignment.Columns(12).HeaderText = "Room"
                assignment.Columns(12).Width = 110

                'assignment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                'MessageBox.Show("No match Found")
                assignment.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID.Leave
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_records()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_assignment()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_assignment()
            sqlconn.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mResult
        'Dim ObjConnection As New SqlConnection()
        mResult = MsgBox("Do you really want to delete the selected record?", _
        vbYesNo + vbQuestion, "Removal Confirmation")
        If mResult = vbNo Then
            Exit Sub
        End If
        'ObjConnection.ConnectionString = "Database=ITtry;" & "Data Source=SLSDB\SLSREP;" & "Uid=sa;Password=****"
        sqlconn.Open()
        Try
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = sqlconn

            ObjCommand.CommandText = "delete from classassign where assignid ='" & Me.assignment.CurrentRow.Cells(0).Value & "'"
            ObjCommand.ExecuteNonQuery()
        Finally
            sqlconn.Close()
        End Try

        Me.assignment.Rows.Remove(Me.assignment.CurrentRow)

    End Sub

    Private Sub save_records()
        Dim yes As Boolean = True
        Dim no As Boolean = False

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into classassign ([empid],[sy],[level],[section],[assign],[time],[day1],[day2],[day3],[day4],[day5],[room]) values ('" & ID.Text & "','" & Main.SY.Text & "' ,'" & level.Text & "','" & section.Text & "','" & subject.Text & "','" & time.Text & "', '" & IIf(mon.Checked, yes, no) & "', '" & IIf(tue.Checked, yes, no) & "', '" & IIf(wed.Checked, yes, no) & "', '" & IIf(thu.Checked, yes, no) & "', '" & IIf(fri.Checked, yes, no) & "', '" & room.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Records Saved!")
        level.Text = ""
        section.Text = ""
        subject.Text = ""
        time.Text = ""
        mon.Checked = False
        tue.Checked = False
        wed.Checked = False
        thu.Checked = False
        fri.Checked = False
        room.Text = ""
    End Sub
    Private Sub verify_records()
        sqlcmd.CommandText = "select * FROM classassign Where (empid = '" & ID.Text & "') and (sy = '" & Main.SY.Text & "') and (level = '" & level.Text & "') and (section = '" & section.Text & "')and (assign = '" & subject.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            daMyname2.Read()
            MsgBox("Assignments already assign to the same Employee's ID")
            level.Text = ""
            section.Text = ""
            subject.Text = ""
            time.Text = ""
            mon.Checked = False
            tue.Checked = False
            wed.Checked = False
            thu.Checked = False
            fri.Checked = False
            room.Text = ""
        Else
            Dim result = MessageBox.Show("Are you sure you want to Add Records?", "Teacher Information", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call save_records()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call save_records()
                    sqlconn.Close()
                End If
            ElseIf result = DialogResult.No Then
                ' Me.Dispose()
            End If

        End If
    End Sub

    Private Sub section_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles section.Click
        'Combo box for level
        Try
            Dim cmd As New SqlCommand("select * FROM section Where (level = '" & level.Text & "');", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "section")) Then

                ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
                section.DataSource = ds.Tables(0)
                section.ValueMember = "section"
                section.DisplayMember = "section"
            Else
                section.DataSource = Nothing

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call verify_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call verify_records()
            sqlconn.Close()
        End If


        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_assignment()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_assignment()
            sqlconn.Close()
        End If
    End Sub
    Private Sub fetch_location()
        Try
            Dim category As String = "e-room"
            Dim cmd As New SqlCommand("select * FROM location where (category = '" & category & "');", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "location")) Then

                ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

                room.DataSource = ds.Tables(0)
                room.ValueMember = "location"
                room.DisplayMember = "location"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub faculty_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles faculty.CellClick
        Dim myVariable As String = faculty.CurrentRow.Cells(0).Value.ToString
        ID.Text = myVariable
    End Sub
    Private Sub fetch_advisory()
        Try
            sqlcmd.CommandText = "select * FROM sectionVIEW Where (adviser = '" & ID.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                Dim l As String
                Dim s As String
                l = daMyname.Item("level")
                s = daMyname.Item("section")

                advisory.Text = l + "-" + s

            Else
                advisory.Text = ""

            End If
        Catch ex As Exception

        End Try
   
    End Sub
    Private Sub ID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_records()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_assignment()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_assignment()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_advisory()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_advisory()
            sqlconn.Close()
        End If
    End Sub

    Private Sub faculty_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles faculty.CellEnter
        Dim myVariable As String = faculty.CurrentRow.Cells(0).Value.ToString
        ID.Text = myVariable
    End Sub
End Class