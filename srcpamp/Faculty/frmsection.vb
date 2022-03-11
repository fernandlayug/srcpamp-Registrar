Imports System.Data.SqlClient
Public Class frmsection

    Private Sub add_Section()

        Dim sqlcmd As New SqlClient.SqlCommand

        Dim strsql2 As String
      
        strsql = "INSERT into section ([category],[level],[section],[adviser]) values ('" & Main.dep.Text & "','" & yrlevel.Text & "','" & section.Text & "','" & id.Text & "')"
        strsql2 = "INSERT into section ([category],[level],[section]) values ('" & Main.dep.Text & "','" & yrlevel.Text & "','" & section.Text & "')"

        If String.IsNullOrEmpty(yrlevel.Text) Then
            MessageBox.Show("Please enter Year Level for the Section Name")
            yrlevel.Focus()
        ElseIf String.IsNullOrEmpty(section.Text) Then
            MessageBox.Show("Please enter Section Name")
            section.Focus()
        Else
            Dim result = MessageBox.Show("Are you sure you want to save the Information for the Section Table?", "Section Table Information", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If adviser.Text = "" Then
                    sqlcmd.CommandText = strsql2
                    sqlcmd.Connection = sqlconn
                    sqlcmd.ExecuteNonQuery()
                ElseIf adviser.Text = String.Empty = False Then
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlconn
                    sqlcmd.ExecuteNonQuery()
                End If
               

                Add.Text = "ADD"
                updatesection.Enabled = True
                yrlevel.Enabled = False
                section.ReadOnly = True

                yrlevel.Text = ""
                section.Text = ""
                adviser.Text = ""
                id.Text = ""

                'Refresh Grid
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call view_hssection()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call view_hssection()
                    sqlconn.Close()
                End If


            ElseIf result = DialogResult.No Then
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub verify_class_adviser()
        sqlcmd.CommandText = "select * FROM section Where (adviser = '" & id.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            MsgBox("You cannot assign two sections to the same Employee ID")
            updatesection.Enabled = False
            yrlevel.Enabled = True
            section.ReadOnly = False
            Add.Text = "Submit"
        Else

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call add_Section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call add_Section()
                sqlconn.Close()
            End If

        End If
    End Sub
    Private Sub verify_section()
        sqlcmd.CommandText = "select * FROM section Where (category = '" & Main.dep.Text & "') and (level = '" & yrlevel.Text & "') and (section = '" & section.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            MsgBox("Section Name already exist")
            updatesection.Enabled = False
            yrlevel.Enabled = True
            section.ReadOnly = False
            Add.Text = "Submit"
        Else

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call verify_class_adviser()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_class_adviser()
                sqlconn.Close()
            End If

        End If
    End Sub
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        If Add.Text = "ADD" Then
            cancel.Visible = False
            updatesection.Enabled = False
            yrlevel.Text = ""
            yrlevel.Enabled = True
            section.Text = ""
            section.ReadOnly = False
            adviser.Text = ""
            id.Text = ""
            Add.Text = "Submit"
        ElseIf Add.Text = "Submit" Then

            If sqlconn.State = ConnectionState.Open Then
                Call verify_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_section()
                sqlconn.Close()
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmsection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        Dim cmdlevel As New SqlCommand("select * FROM level where (category = '" & Main.dep.Text & "');", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)

            yrlevel.DataSource = ds_level.Tables(0)
            yrlevel.ValueMember = "yrlevel"
            yrlevel.DisplayMember = "yrlevel"
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call view_hssection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call view_hssection()
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
    Private Sub view_hsfaculty()
        Try
            Dim cmd As New SqlCommand("select id, surname, firstname, mname, department FROM employee Where (department = '" & Main.dep.Text & "') order by surname ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "employee")) Then

                faculty.DataSource = ds.Tables(0)
               
                faculty.Columns("department").Visible = False
               


                faculty.Columns("id").DisplayIndex = 0
                faculty.Columns(0).HeaderText = "ID"
                'faculty.Columns(0).Width = 50

                faculty.Columns("surname").DisplayIndex = 1
                faculty.Columns("surname").HeaderText = "Surname"
                ' faculty.Columns(3).Width = 80

                faculty.Columns("firstname").DisplayIndex = 2
                faculty.Columns("firstname").HeaderText = "Firstname"
                'faculty.Columns(1).Width = 80

                faculty.Columns("mname").DisplayIndex = 3
                faculty.Columns("mname").HeaderText = "M. Initial"
                'faculty.Columns(2).Width = 80

                faculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                'MessageBox.Show("No match Found")
                faculty.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub view_hssection()
        Try
            Dim cmd As New SqlCommand("select * FROM sectionVIEW Where (category = '" & Main.dep.Text & "') order by level ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "sectionVIEW")) Then

                sectionlist.DataSource = ds.Tables(0)
                sectionlist.Columns("sectionid").Visible = False
                sectionlist.Columns("category").Visible = False
                sectionlist.Columns("adviser").Visible = False

                sectionlist.Columns(2).HeaderText = "Level"
                sectionlist.Columns(3).HeaderText = "Section"
                sectionlist.Columns(4).HeaderText = "Adviser"
                sectionlist.Columns(5).HeaderText = ""
                sectionlist.Columns(6).HeaderText = ""

                sectionlist.Item(2, 0).Selected = False

                sectionlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                'MessageBox.Show("No match Found")
                sectionlist.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        MsgBox("You cannot delete at this module.  You can request a deletion of records to Database Administrator.")
    End Sub

    Private Sub faculty_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles faculty.CellClick
        Dim myid As String = faculty.CurrentRow.Cells(0).Value.ToString
        id.Text = myid

        Dim myfirstname As String = faculty.CurrentRow.Cells(1).Value.ToString
        firstname.Text = myfirstname

        Dim mymname As String = faculty.CurrentRow.Cells(2).Value.ToString
        mname.Text = mymname

        Dim mysurname As String = faculty.CurrentRow.Cells(3).Value.ToString
        lastname.Text = mysurname

        Dim f As String = firstname.Text
        Dim m As String = mname.Text
        Dim l As String = lastname.Text

        adviser.Text = f + " " + m + " " + l

    End Sub


    Private Sub sectionlist_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles sectionlist.CellClick
        updatesection.Enabled = True
        cancel.Visible = True

        Dim level As String = sectionlist.CurrentRow.Cells(2).Value.ToString
        yrlevel.Text = level

        Dim sec As String = sectionlist.CurrentRow.Cells(3).Value.ToString
        section.Text = sec

        Dim adv As String = sectionlist.CurrentRow.Cells(4).Value.ToString
        id.text = adv

        Dim myfirstname As String = sectionlist.CurrentRow.Cells(5).Value.ToString
        firstname.Text = myfirstname

        Dim mymname As String = sectionlist.CurrentRow.Cells(6).Value.ToString
        mname.Text = mymname

        Dim mysurname As String = sectionlist.CurrentRow.Cells(7).Value.ToString
        lastname.Text = mysurname

        Dim f As String = firstname.Text
        Dim m As String = mname.Text
        Dim l As String = lastname.Text

        adviser.Text = f + " " + m + " " + l

    End Sub
    Private Sub verify_existing_adviser()
        sqlcmd.CommandText = "select * FROM section Where (adviser = '" & id.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            MsgBox("You cannot assign two sections to the same Employee ID")
            adviser.Text = ""

        Else
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_section()
                sqlconn.Close()
            End If
 
        End If
    End Sub
    Private Sub update_section()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE section SET adviser = '" & id.Text & "' where level = '" & yrlevel.Text & "' and section = '" & section.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()

        MsgBox("Update Complete")
        yrlevel.Text = ""
        section.Text = ""
        adviser.Text = ""
        cancel.Visible = False
        updatesection.Enabled = False

    End Sub
    Private Sub updatesection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatesection.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call verify_existing_adviser()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call verify_existing_adviser()
            sqlconn.Close()
        End If

        'Refresh Grid
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call view_hssection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call view_hssection()
            sqlconn.Close()
        End If
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        updatesection.Enabled = False
        yrlevel.Text = ""
        section.Text = ""
        adviser.Text = ""
        id.Text = ""
        firstname.Text = ""
        mname.Text = ""

        cancel.Visible = False

    End Sub

    Private Sub sectionlist_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles sectionlist.CellEnter
        updatesection.Enabled = True
        cancel.Visible = True

        Dim level As String = sectionlist.CurrentRow.Cells(2).Value.ToString
        yrlevel.Text = level

        Dim sec As String = sectionlist.CurrentRow.Cells(3).Value.ToString
        section.Text = sec

        Dim adv As String = sectionlist.CurrentRow.Cells(4).Value.ToString
        id.Text = adv

        Dim myfirstname As String = sectionlist.CurrentRow.Cells(5).Value.ToString
        firstname.Text = myfirstname

        Dim mymname As String = sectionlist.CurrentRow.Cells(6).Value.ToString
        mname.Text = mymname

        Dim mysurname As String = sectionlist.CurrentRow.Cells(7).Value.ToString
        lastname.Text = mysurname

        Dim f As String = firstname.Text
        Dim m As String = mname.Text
        Dim l As String = lastname.Text

        adviser.Text = f + " " + m + " " + l
    End Sub

    Private Sub faculty_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles faculty.CellEnter
        Dim myid As String = faculty.CurrentRow.Cells(0).Value.ToString
        id.Text = myid

        Dim myfirstname As String = faculty.CurrentRow.Cells(1).Value.ToString
        firstname.Text = myfirstname

        Dim mymname As String = faculty.CurrentRow.Cells(2).Value.ToString
        mname.Text = mymname

        Dim mysurname As String = faculty.CurrentRow.Cells(3).Value.ToString
        lastname.Text = mysurname

        Dim f As String = firstname.Text
        Dim m As String = mname.Text
        Dim l As String = lastname.Text

        adviser.Text = f + " " + m + " " + l
    End Sub
End Class