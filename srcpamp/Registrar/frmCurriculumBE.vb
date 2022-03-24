Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmCurriculumBE
    Dim category As String
    Dim cID As Integer
    Dim str As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub frmCurriculumBE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call ActiveAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call ActiveAY()
            sqlconn.Close()
        End If


    End Sub
    Private Sub numberzero()
        Dim units As Double
        Units = 0
    End Sub

    Private Sub fetch_courseID()
        Try
            sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & category & "'"
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
        Try
            sqlcmd.CommandText = "select  * FROM level where yrlevel = '" & cmbLevel.Text & "' AND category = '" & category & "'"
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

    Public Sub fetch_subjects()

        Try
            Dim obj As Object = DBNull.Value

            'Dim a As String = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "' AND levelid = '" & txtLevelID.Text & "' AND term = '" & txtTerm.Text & "');"
            ' Dim b As String = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "' AND levelid = '" & txtLevelID.Text & "');"
            ' Dim c As String = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "');"

            If txtTerm.Text = "" And txtLevelID.Text = "" Then
                str = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "');"
            ElseIf txtTerm.Text = "" And txtLevelID.Text = String.Empty = False Then
                str = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "' AND levelid = '" & txtLevelID.Text & "');"
            ElseIf txtTerm.Text = String.Empty = False And txtLevelID.Text = String.Empty = False Then
                str = "select * FROM CurriculumView WHERE (courseid = '" & txtCourseID.Text & "' AND CAY = '" & cmbCAY.Text & "' AND levelid = '" & txtLevelID.Text & "' AND term = '" & txtTerm.Text & "');"
            Else
            End If

            Dim cmd As New SqlCommand(str, sqlconn)


            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "curriculumview")) Then

                dtSubjects.Columns.Clear()

                dtSubjects.DataSource = ds.Tables(0)
                dtSubjects.Columns("curriculumid").Visible = False
                dtSubjects.Columns("courseid").Visible = False
                dtSubjects.Columns("levelid").Visible = False
                dtSubjects.Columns("subjectid").Visible = False
                dtSubjects.Columns("coursecode").Visible = False
                dtSubjects.Columns("coursename").Visible = False
                dtSubjects.Columns("coursecategory").Visible = False
                dtSubjects.Columns("coursemajor").Visible = False
                dtSubjects.Columns("yrlevel").Visible = False
                dtSubjects.Columns("subjectlecunit").Visible = False
                dtSubjects.Columns("subjectlabunit").Visible = False
                dtSubjects.Columns("CAY").Visible = False
                dtSubjects.Columns("subjectcategory").Visible = False

                Dim Remove As New DataGridViewCheckBoxColumn


                dtSubjects.Columns.Add(Remove)
                Remove.HeaderText = "Remove"
                Remove.Name = "Remove"

                dtSubjects.Columns("Remove").DisplayIndex = 0
                dtSubjects.Columns("Remove").Width = 50

                dtSubjects.Columns("subjectcode").DisplayIndex = 1
                dtSubjects.Columns("subjectcode").Width = 60
                dtSubjects.Columns("subjectcode").HeaderText = "Code"

                dtSubjects.Columns("subjectdescription").DisplayIndex = 2
                dtSubjects.Columns("subjectdescription").Width = 350
                dtSubjects.Columns("subjectdescription").HeaderText = "Subject"

                dtSubjects.Columns("subjectunits").DisplayIndex = 3
                dtSubjects.Columns("subjectunits").Width = 40
                dtSubjects.Columns("subjectunits").HeaderText = "Units"

                dtSubjects.Columns("subjectprereq").DisplayIndex = 4
                dtSubjects.Columns("subjectprereq").Width = 100
                dtSubjects.Columns("subjectprereq").HeaderText = "Pre-Req"

                dtSubjects.Columns("term").DisplayIndex = 5
                dtSubjects.Columns("term").Width = 60
                dtSubjects.Columns("term").HeaderText = "Semester"

            Else

                dtSubjects.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try




    End Sub
    Private Sub delete_subjects()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "Delete from curriculum where curriculumid = '" & cID & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub remove_subjects()
        For i = 0 To Me.dtsubjects.RowCount - 1
            cID = Me.dtSubjects.Rows(i).Cells("curriculumid").Value

            If CBool(Me.dtSubjects.Rows(i).Cells("remove").Value) = True Then
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call delete_subjects()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call delete_subjects()
                    sqlconn.Close()
                End If
            End If
        Next
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()
        End If
        MsgBox("Done.")

    End Sub
    Private Sub fetch_course()
        If chkJuniorHS.Checked = True Then
            category = "Junior HS"
        ElseIf chkElementary.Checked = True Then
            category = "Elementary"
        End If


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
    Private Sub fetch_AY()
        Try
            Dim cmd As New SqlCommand("select count(courseid), CAY FROM curriculum " & _
                                            "where courseid = '" & txtCourseID.Text & "' group by CAY order by CAY desc;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "curriculum")) Then

                'ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
                cmbCAY.DataSource = ds.Tables(0)
                cmbCAY.ValueMember = "CAY"
                cmbCAY.DisplayMember = "CAY"
            Else
                cmbCAY.DataSource = ""
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_yrlevel()
        Dim cmdlevel As New SqlCommand("select * FROM level where category = '" & category & "' order by levelid ASC;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "level")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
            cmbLevel.DataSource = ds_level.Tables(0)
            cmbLevel.ValueMember = "yrlevel"
            cmbLevel.DisplayMember = "yrlevel"
        End If
    End Sub


    Private Sub chkCollege_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkJuniorHS.CheckedChanged, chkElementary.CheckedChanged
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

    Private Sub cmbCourse_TextChanged(sender As Object, e As System.EventArgs) Handles cmbCourse.TextChanged

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_courseID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_courseID()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_AY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_AY()
            sqlconn.Close()
        End If
        If cmbCourse.Text = "" Then
            cmbCAY.Text = ""
        Else

        End If
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If

        cmbLevel.Text = ""
        cmbTerm.Text = ""
        txtLevelID.Text = ""
        txtTerm.Text = ""

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
            Call fetch_AY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_AY()
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
            txtTerm.Text = "4"
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmSubjects.txtCourseID.Text = txtCourseID.Text
        frmSubjects.txtLevelID.Text = txtLevelID.Text
        frmSubjects.txtTermID.Text = txtTerm.Text
        frmSubjects.txtCourse.Text = cmbCourse.Text
        frmSubjects.txtLevel.Text = cmbLevel.Text
        frmSubjects.txtTerm.Text = cmbTerm.Text
        frmSubjects.txtMajor.Text = cmbMajor.Text
        frmSubjects.txtCAY.Text = cmbCAY.Text
        frmSubjects.txtAY.Text = cmbAY.Text


        frmSubjects.cmbSubjectCategory.Text = category

        frmSubjects.ShowDialog()
    End Sub
    Private Sub print_curriculum()
        If category = String.Empty = True And cmbCourse.Text = "" And cmbMajor.Text = "" Then
            MessageBox.Show("No selected course. Please select course.")
        Else
            Dim sqlQRY1 As String = "select * FROM curriculumview where courseid = '" & txtCourseID.Text & "' and CAY = '" & cmbCAY.Text & "';"

            Dim cmdExec1 As SqlCommand = New SqlCommand(sqlQRY1, sqlconn)

            'create data adapter

            Dim da1 As SqlDataAdapter = New SqlDataAdapter(sqlQRY1, sqlconn)

            'create dataset
            Dim ds As DataSet = New DataSet

            'fill dataset
            da1.Fill(ds, "curriculumview")
            Dim Report As printrpt = New printrpt

            Dim mReport As rptCurriculum = New rptCurriculum

            mReport.SetDataSource(ds)

            Report.CrystalReportViewer1.ReportSource = mReport

            Report.ShowDialog()

        End If

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            Call print_curriculum()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call print_curriculum()
            sqlconn.Close()

        End If
    End Sub

    Private Sub dtSubjects_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtSubjects.CellEnter
        Dim myVariable As String = dtSubjects.CurrentRow.Cells("subjectid").Value.ToString
        txtsubjectid.Text = myVariable
    End Sub


    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        Dim result = MessageBox.Show("Are you sure you want to removed selected subject/s?", "Remove Subject", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Call remove_subjects()
        Else
        End If

    End Sub

    Private Sub ActiveAY()
        Dim cmdSY As New SqlCommand("select * From activesy ORDER BY sy_id DESC;", sqlconn)
        Dim adptSY As New SqlDataAdapter(cmdSY)
        Dim ds_SY As New DataSet()
        If (adptSY.Fill(ds_SY, "active")) Then

            'ds_SY.Tables(0).Rows.InsertAt(ds_SY.Tables(0).NewRow(), 0)
            cmbAY.DataSource = ds_SY.Tables(0)
            cmbAY.ValueMember = "active"
            cmbAY.DisplayMember = "active"

        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmActiveCurriculum
        frm.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subjects()
            sqlconn.Close()

        End If
    End Sub
End Class