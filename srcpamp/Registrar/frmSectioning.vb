Imports System.Data.SqlClient
Imports System.IO
Public Class frmSectioning
    Dim yrlevelcategory, depLevel As String

    Dim studentIDrow As String
    Dim colsec As String
    Dim student_query, average_query As String
    Dim sec As Integer = 0
    Dim z As Integer = 0

    Dim genFrom As Double
    Dim genTo As Double

    Dim levelID_temp, courseID_temp, sectionid_temp, term As Integer
    Dim p_sy As String


    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
        ' p_sy = Main.SY.Text
        p_sy = Main.SY.Text

        Call clear_tools()
        allOption.Checked = True

        student_query = "(sy = '" & p_sy & "') AND (section = '" & sec & "' OR section = '" & 0 & "')"
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_studentlist()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentlist()
            sqlconn.Close()
        End If
       CenterToScreen()
    End Sub
    Private Sub clear_tools()
        elemOption.Checked = False
        jhsOption.Checked = False
        shsOption.Checked = False
        collegeOption.Checked = False
        firstsem.Checked = False
        secondsem.Checked = False
        summer.Checked = False

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
    Private Sub fetch_sectionBasicEd()
        Dim cmdsection As New SqlCommand("select * FROM section " & _
                                        "where category = '" & yrlevelcategory & "' and level = '" & level.Text & "';", sqlconn)
        Dim adptsection As New SqlDataAdapter(cmdsection)
        Dim ds_section As New DataSet()
        If (adptsection.Fill(ds_section, "course")) Then

            ds_section.Tables(0).Rows.InsertAt(ds_section.Tables(0).NewRow(), 0)

            cmbSection.DataSource = ds_section.Tables(0)
            cmbSection.ValueMember = "sectioname"
            cmbSection.DisplayMember = "sectioname"
        End If
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

    Private Sub elemOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles elemOption.CheckedChanged
        If elemOption.Checked = True Then
            yrlevelcategory = "Elementary"
            semester.Enabled = False
            cmbCourse.Enabled = False
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""

            firstsem.Checked = False
            secondsem.Checked = False

            admissioninfo.Enabled = True
            depLevel = "Elementary"
            cmbCourse.Text = "Elementary"

        ElseIf elemOption.Checked = False Then
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

        

        Call run_query()
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
        firstsem.Checked = False
            secondsem.Checked = False
            admissioninfo.Enabled = True
            depLevel = "Junior HS"
            cmbCourse.Text = "Junior High School"

        ElseIf jhsOption.Checked = False Then
            cmbCourse.Text = ""
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
        

        Call run_query()
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

            firstsem.Checked = False
            secondsem.Checked = False
            admissioninfo.Enabled = True
            depLevel = "Senior HS"


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
     

        Call run_query()
    End Sub

    Private Sub collegeOption_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles collegeOption.CheckedChanged
        If collegeOption.Checked = True Then
            yrlevelcategory = "college"
            semester.Enabled = True
            cmbCourse.Enabled = True
            cmbMajor.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""
            firstsem.Checked = False
            secondsem.Checked = False
            admissioninfo.Enabled = True
            depLevel = "College"

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
        Call run_query()
    End Sub
    Private Sub fetch_levelid()
        Try
            sqlcmd.CommandText = "select  * FROM level where yrlevel = '" & level.Text & "' AND category = '" & yrlevelcategory & "'"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                levelID_temp = daMyname.Item("levelid")
            Else
                levelID_temp = 0
            End If
        Catch ex As Exception
        End Try
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

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sectionBasicEd()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionBasicEd()
            sqlconn.Close()
        End If


        Call run_query()

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


        Else

        End If
        Call run_query()

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
            Call fetch_courseid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseid()
            sqlconn.Close()
        End If

        Call run_query()
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

        Call run_query()
    End Sub

    Private Sub update_section()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET section = '" & sectionid_temp & "' where studentID = '" & studentIDrow & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_unsection()
        Dim z As Integer = 0
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET section = '" & z & "' where studentID = '" & studentIDrow & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub update_sectionlist()
        For i = 0 To Me.dgvunsection.RowCount - 1
            studentIDrow = Me.dgvunsection.Rows(i).Cells("studentID").Value

            If CBool(Me.dgvunsection.Rows(i).Cells("chk").Value) = True Then

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
             
            'MessageBox.Show("Next")
        Next
        MessageBox.Show("Update Completed")

    End Sub
    Private Sub update_Unsectionlist()
        For i = 0 To Me.dgvsection.RowCount - 1
            studentIDrow = Me.dgvsection.Rows(i).Cells("studentID").Value

            If CBool(Me.dgvsection.Rows(i).Cells("chk").Value) = True Then

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call update_unsection()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_unsection()
                    sqlconn.Close()
                End If

            End If

            'MessageBox.Show("Next")
        Next
        MessageBox.Show("Update Completed")

    End Sub

    Private Sub fetch_studentlist()
    
        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname + ', ' +  firstname + ' ' + mname as name, studentID, sex, lastschlaverage, yrlevel FROM AdmissionView  Where " & student_query & ";", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)

        If (adpt.Fill(ds, "AdmissionView")) Then
            dgvunsection.Columns.Clear()

            dgvunsection.DataSource = ds.Tables(0)

            dgvunsection.Columns("studentID").DisplayIndex = 0
            dgvunsection.Columns("studentID").Width = 75
            dgvunsection.Columns("studentID").HeaderText = "Student ID"

            dgvunsection.Columns("name").DisplayIndex = 1
            dgvunsection.Columns("name").Width = 210
            dgvunsection.Columns("name").HeaderText = "Name"

            dgvunsection.Columns("sex").DisplayIndex = 2
            dgvunsection.Columns("sex").Width = 60
            dgvunsection.Columns("sex").HeaderText = "Gender"

            dgvunsection.Columns("yrlevel").DisplayIndex = 3
            dgvunsection.Columns("yrlevel").Width = 60
            dgvunsection.Columns("yrlevel").HeaderText = "Level"

            dgvunsection.Columns("lastschlaverage").DisplayIndex = 4
            dgvunsection.Columns("lastschlaverage").Width = 60
            dgvunsection.Columns("lastschlaverage").HeaderText = "Average"

        Else
            dgvunsection.DataSource = Nothing
        End If
        lblTotalStudents.Text = dgvunsection.RowCount

        'Count the number of Male
        Dim Value As String = "Male"
        Dim ColumnName As String = "sex"
        lblMale.Text = dgvunsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName).Value)) AndAlso (row.Cells(ColumnName).Value = Value)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName).Value).Count.ToString

        'Count the number of FEmale
        Dim Value2 As String = "Female"
        Dim ColumnName2 As String = "sex"
        lblFemale.Text = dgvunsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName2).Value)) AndAlso (row.Cells(ColumnName2).Value = Value2)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName2).Value).Count.ToString
    End Sub

    Private Sub fetch_studentlist_section()
        Dim cat As String = "college"
        Dim sec As String = ""
        Dim z As Integer = 0
        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname + ', ' +  firstname + ' ' + mname as name, studentID, sex, lastschlaverage FROM AdmissionView  Where " & student_query & ";", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)


        If (adpt.Fill(ds, "AdmissionView")) Then
            dgvunsection.Columns.Clear()

            dgvunsection.DataSource = ds.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn
            dgvunsection.Columns.Add(chk)
            chk.HeaderText = "Select"
            chk.Name = "chk"

            dgvunsection.Columns("chk").DisplayIndex = 0
            dgvunsection.Columns("chk").Width = 50

            dgvunsection.Columns("studentID").DisplayIndex = 1
            dgvunsection.Columns("studentID").Width = 75
            dgvunsection.Columns("studentID").HeaderText = "Student ID"

            dgvunsection.Columns("name").DisplayIndex = 2
            dgvunsection.Columns("name").Width = 210
            dgvunsection.Columns("name").HeaderText = "Name"

            dgvunsection.Columns("sex").DisplayIndex = 3
            dgvunsection.Columns("sex").Width = 60
            dgvunsection.Columns("sex").HeaderText = "Gender"

            dgvunsection.Columns("lastschlaverage").DisplayIndex = 4
            dgvunsection.Columns("lastschlaverage").Width = 60
            dgvunsection.Columns("lastschlaverage").HeaderText = "Average"


        Else
            dgvunsection.DataSource = Nothing
        End If
        lblTotalStudents.Text = dgvunsection.RowCount

        'Count the number of Male
        Dim Value As String = "Male"
        Dim ColumnName As String = "sex"
        lblMale.Text = dgvunsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName).Value)) AndAlso (row.Cells(ColumnName).Value = Value)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName).Value).Count.ToString

        'Count the number of FEmale
        Dim Value2 As String = "Female"
        Dim ColumnName2 As String = "sex"
        lblFemale.Text = dgvunsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName2).Value)) AndAlso (row.Cells(ColumnName2).Value = Value2)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName2).Value).Count.ToString

    End Sub

    Private Sub fetch_studentlist_INsection()
  

        Dim obj As Object = DBNull.Value

        Dim cmd As New SqlCommand("select surname + ', ' +  firstname + ' ' + mname as name, studentID, sex, lastschlaverage FROM AdmissionView  Where  courseid = " & courseID_temp & " AND levelid = " & levelID_temp & " AND term = " & term & " AND section = " & sectionid_temp & " AND sy = '" & p_sy & "';", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)


        If (adpt.Fill(ds, "AdmissionView")) Then
            dgvsection.Columns.Clear()

            dgvsection.DataSource = ds.Tables(0)
            Dim chk As New DataGridViewCheckBoxColumn
            dgvsection.Columns.Add(chk)
            chk.HeaderText = "Select"
            chk.Name = "chk"

            dgvsection.Columns("chk").DisplayIndex = 0
            dgvsection.Columns("chk").Width = 50

            dgvsection.Columns("lastschlaverage").Visible = False

            dgvsection.Columns("studentID").DisplayIndex = 1
            dgvsection.Columns("studentID").Width = 75
            dgvsection.Columns("studentID").HeaderText = "Student ID"

            dgvsection.Columns("name").DisplayIndex = 2
            dgvsection.Columns("name").Width = 210
            dgvsection.Columns("name").HeaderText = "Name"

            dgvsection.Columns("sex").DisplayIndex = 3
            dgvsection.Columns("sex").Width = 60
            dgvsection.Columns("sex").HeaderText = "Gender"

        Else
            dgvsection.DataSource = Nothing
        End If
        lblTotalStudentsSection.Text = dgvsection.RowCount

        'Count the number of Male
        Dim Value As String = "Male"
        Dim ColumnName As String = "sex"
        lblMaleSection.Text = dgvsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName).Value)) AndAlso (row.Cells(ColumnName).Value = Value)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName).Value).Count.ToString

        'Count the number of FEmale
        Dim Value2 As String = "Female"
        Dim ColumnName2 As String = "sex"
        lblFemaleSection.Text = dgvsection _
            .Rows.Cast(Of DataGridViewRow) _
            .Where(Function(row)
                       Return (Not IsDBNull(row.Cells(ColumnName2).Value)) AndAlso (row.Cells(ColumnName2).Value = Value2)
                   End Function) _
            .Select(Function(row) row.Cells(ColumnName2).Value).Count.ToString

    End Sub

    Private Sub query_elemJHS()

        If level.Text = "" And cmbgenavFrom.Text = "" And cmbgenavTo.Text = "" Then
            'SQL Query Level 2
            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and category = '" & yrlevelcategory & "')"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If
        ElseIf level.Text = String.Empty = False And cmbgenavFrom.Text = String.Empty = True And cmbgenavTo.Text = String.Empty = True Then
            'SQL Query Level 3

            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "')"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If
        ElseIf level.Text = String.Empty = False And cmbgenavFrom.Text = String.Empty = False And cmbgenavTo.Text = String.Empty = True Then

            Try
                'SQL Query Level 4
                genFrom = cmbgenavFrom.Text
                student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and lastschlaverage = '" & genFrom & "%')"
                If sqlconn.State = ConnectionState.Open Then
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                End If
            Catch ex As Exception

            End Try
        ElseIf level.Text = String.Empty = False And cmbgenavFrom.Text = String.Empty = False And cmbgenavTo.Text = String.Empty = False Then

            Try
                'SQL Query Level 5
                genFrom = cmbgenavFrom.Text
                genTo = cmbgenavTo.Text
                student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and (lastschlaverage BETWEEN '" & genTo & "' AND '" & genFrom & "'))"
                If sqlconn.State = ConnectionState.Open Then
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub query_SHSCollege()


        If level.Text = "" And term = 0 And courseID_temp = 0 And cmbgenavFrom.Text = "" And cmbgenavTo.Text = "" Then
            'Sql Query Level 2
            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and category = '" & yrlevelcategory & "')"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If

        ElseIf level.Text = String.Empty = False And term = 0 And courseID_temp = 0 And cmbgenavFrom.Text = String.Empty = True And cmbgenavTo.Text = String.Empty = True Then

            'SQL Query Level 3
            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "')"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If
        ElseIf level.Text = String.Empty = False And term <> 0 And courseID_temp = 0 And cmbgenavFrom.Text = String.Empty = True And cmbgenavTo.Text = String.Empty = True Then

            'SQL Query Level 6
            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "')"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If

        ElseIf level.Text = String.Empty = False And term <> 0 And courseID_temp <> 0 And cmbgenavFrom.Text = String.Empty = True And cmbgenavTo.Text = String.Empty = True Then

            'SQL Query Level 7
            student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "' and courseid = '" & courseID_temp & "')"

            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_section()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_section()
                sqlconn.Close()
            End If

        ElseIf level.Text = String.Empty = False And term <> 0 And courseID_temp <> 0 And cmbgenavFrom.Text = String.Empty = False And cmbgenavTo.Text = String.Empty = True Then
            'SQL Query Level 8
            Try
                genFrom = cmbgenavFrom.Text
                student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "' and courseid = '" & courseID_temp & "' and lastschlaverage like '" & genFrom & "%')"


                If sqlconn.State = ConnectionState.Open Then
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                End If

            Catch ex As Exception

            End Try
        ElseIf level.Text = String.Empty = False And term <> 0 And courseID_temp <> 0 And cmbgenavFrom.Text = String.Empty = False And cmbgenavTo.Text = String.Empty = False Then
            'SQL Query Level 9
            Try
                genFrom = cmbgenavFrom.Text
                genTo = cmbgenavTo.Text

                student_query = "(sy = '" & p_sy & "' and section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "' and courseid = '" & courseID_temp & "' and lastschlaverage BETWEEN '" & genTo & "' AND '" & genFrom & "')"

                If sqlconn.State = ConnectionState.Open Then
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call fetch_studentlist_section()
                    sqlconn.Close()
                End If
            Catch ex As Exception

            End Try


    
        End If
    End Sub
    Private Sub fetch_genavfrom()
        Dim cmdgenavfrom As New SqlCommand("select COUNT(levelid), count(category), count(section), count(term), lastschlaverage, SUM(courseID) FROM AdmissionView where section = '" & sec & "' and levelid = '" & levelID_temp & "' group by lastschlaverage order by lastschlaverage DESC", sqlconn)
        Dim adptgenavfrom As New SqlDataAdapter(cmdgenavfrom)
        Dim ds_genavfrom As New DataSet()
        If (adptgenavfrom.Fill(ds_genavfrom, "AdmissionView")) Then

            ds_genavfrom.Tables(0).Rows.InsertAt(ds_genavfrom.Tables(0).NewRow(), 0)

            cmbgenavFrom.DataSource = ds_genavfrom.Tables(0)
            cmbgenavFrom.ValueMember = "lastschlaverage"
            cmbgenavFrom.DisplayMember = "lastschlaverage"
        End If
    End Sub
    Private Sub fetch_genavfromSHSCollege()
        Dim cmdgenavfrom As New SqlCommand("select COUNT(levelid), count(category), count(section), count(term), lastschlaverage, SUM(courseID) FROM AdmissionView where section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "' and courseid = '" & courseID_temp & "' group by lastschlaverage order by lastschlaverage DESC", sqlconn)
        Dim adptgenavfrom As New SqlDataAdapter(cmdgenavfrom)
        Dim ds_genavfrom As New DataSet()
        If (adptgenavfrom.Fill(ds_genavfrom, "AdmissionView")) Then

            ds_genavfrom.Tables(0).Rows.InsertAt(ds_genavfrom.Tables(0).NewRow(), 0)

            cmbgenavFrom.DataSource = ds_genavfrom.Tables(0)
            cmbgenavFrom.ValueMember = "lastschlaverage"
            cmbgenavFrom.DisplayMember = "lastschlaverage"
        End If
    End Sub
    Private Sub fetch_genavto()
        Dim cmdgenavto As New SqlCommand("select COUNT(levelid), count(category), count(section), count(term), lastschlaverage, SUM(courseID) FROM AdmissionView where section = '" & sec & "' and levelid = '" & levelID_temp & "' group by lastschlaverage order by lastschlaverage DESC", sqlconn)
        Dim adptgenavto As New SqlDataAdapter(cmdgenavto)
        Dim ds_genavto As New DataSet()
        If (adptgenavto.Fill(ds_genavto, "AdmissionView")) Then

            ds_genavto.Tables(0).Rows.InsertAt(ds_genavto.Tables(0).NewRow(), 0)

            cmbgenavTo.DataSource = ds_genavto.Tables(0)
            cmbgenavTo.ValueMember = "lastschlaverage"
            cmbgenavTo.DisplayMember = "lastschlaverage"
        End If
    End Sub
    Private Sub fetch_genavtoSHSCollege()
        Dim cmdgenavto As New SqlCommand("select COUNT(levelid), count(category), count(section), count(term), lastschlaverage, SUM(courseID) FROM AdmissionView where section = '" & sec & "' and levelid = '" & levelID_temp & "' and term = '" & term & "' and courseid = '" & courseID_temp & "' group by lastschlaverage order by lastschlaverage DESC", sqlconn)
        Dim adptgenavto As New SqlDataAdapter(cmdgenavto)
        Dim ds_genavto As New DataSet()
        If (adptgenavto.Fill(ds_genavto, "AdmissionView")) Then

            ds_genavto.Tables(0).Rows.InsertAt(ds_genavto.Tables(0).NewRow(), 0)

            cmbgenavTo.DataSource = ds_genavto.Tables(0)
            cmbgenavTo.ValueMember = "lastschlaverage"
            cmbgenavTo.DisplayMember = "lastschlaverage"
        End If
    End Sub
    Private Sub cmbgenavFrom_Enter(sender As Object, e As System.EventArgs) Handles cmbgenavFrom.Enter
        If elemOption.Checked = True Or jhsOption.Checked = True Then
            Call fetch_genavfrom()
        ElseIf shsOption.Checked = True Or collegeOption.Checked = True Then
            Call fetch_genavfromSHSCollege()
        End If
    End Sub
    Private Sub cmbgenavTo_Enter(sender As Object, e As System.EventArgs) Handles cmbgenavTo.Enter
        If elemOption.Checked = True Or jhsOption.Checked = True Then
            Call fetch_genavto()
        ElseIf shsOption.Checked = True Or collegeOption.Checked = True Then
            Call fetch_genavtoSHSCollege()
        End If
    End Sub

    Private Sub cmbgenavTo_TextChanged(sender As Object, e As System.EventArgs) Handles cmbgenavTo.TextChanged

        If cmbgenavTo.Text = String.Empty = False Then
            cmbgenavFrom.Enabled = False
        ElseIf cmbgenavTo.Text = String.Empty = True Then
            cmbgenavFrom.Enabled = True
        End If
  
    End Sub

    Private Sub run_query()
        If elemOption.Checked = True Or jhsOption.Checked = True Then
            Call query_elemJHS()
        ElseIf shsOption.Checked = True Or collegeOption.Checked = True Then
            Call query_SHSCollege()
        End If
    End Sub
    Private Sub allOption_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles allOption.CheckedChanged
        If allOption.Checked = True Then
            student_query = "(sy = '" & p_sy & "' and (section = '" & sec & "' or section = '" & 0 & "'))"
            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist()
                sqlconn.Close()
            End If
            yrlevelcategory = ""
            semester.Enabled = False
            cmbCourse.Enabled = False
            cmbMajor.Enabled = False
            level.Enabled = False
            level.Text = ""
            cmbCourse.Text = ""
            cmbMajor.Text = ""

            firstsem.Checked = False
            secondsem.Checked = False
        ElseIf allOption.Checked = False Then
            level.Enabled = True
        End If
    End Sub


    Private Sub cmbgenavFrom_TextChanged(sender As Object, e As System.EventArgs) Handles cmbgenavFrom.TextChanged, cmbgenavTo.TextChanged
        Call run_query()
    End Sub



    Private Sub cmbSection_TextChanged(sender As Object, e As EventArgs) Handles cmbSection.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_sectionid()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionid()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_studentlist_INsection()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentlist_INsection()
            sqlconn.Close()
        End If
    End Sub

   
    Private Sub btnClassSection_Click(sender As Object, e As EventArgs) Handles btnClassSection.Click
        If cmbSection.Text = "" Then
            MsgBox("Please select section name!")
        Else
            Dim result = MessageBox.Show("Are you sure you want to Assign the Class Section?", "Class Section", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Call update_sectionlist()

                If sqlconn.State = ConnectionState.Open Then
                    Call fetch_studentlist_INsection()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call fetch_studentlist_INsection()
                    sqlconn.Close()
                End If

                Call run_query()
            ElseIf result = DialogResult.No Then

            End If
        End If


    End Sub

 


  

    Private Sub btnUnSection_Click(sender As Object, e As EventArgs) Handles btnUnSection.Click
        Dim result = MessageBox.Show("Are you sure you want to Assign the Class Section?", "Class Section", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Call update_Unsectionlist()

            If sqlconn.State = ConnectionState.Open Then
                Call fetch_studentlist_INsection()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentlist_INsection()
                sqlconn.Close()
            End If

            Call run_query()
        ElseIf result = DialogResult.No Then

        End If
    End Sub
  


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\1\Myfile.xls", True)
        If dgvsection.Rows.Count = 0 Then GoTo loopend

        ' collect the header's names 
        Dim Headerline As String
        For k = 0 To dgvsection.Columns.Count - 1
            If k = dgvsection.Columns.Count - 1 Then ' last column dont put , separate 
                Headerline = Headerline & dgvsection.Columns(k).HeaderText
            Else
                Headerline = Headerline & dgvsection.Columns(k).HeaderText & ","
            End If
        Next
        file.WriteLine(Headerline)  ' this will write header names at the first line 
        ' collect the data 

        For i = 0 To dgvsection.Rows.Count - 1
            Dim DataRow As String
            For k = 0 To dgvsection.Columns.Count - 1
                If k = dgvsection.Columns.Count - 1 Then
                    DataRow = DataRow & dgvsection.Rows(i).Cells(k).Value ' last column dont put , separate 
                End If
                DataRow = DataRow & dgvsection.Rows(i).Cells(k).Value & ","
            Next

            file.WriteLine(DataRow)
            DataRow = ""
        Next



loopend:
        file.Close()
    End Sub

End Class