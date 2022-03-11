Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmActiveCurriculum
    Dim category As String = "College"
    Private Sub fetch_course()

        Dim cmdcourse As New SqlCommand("select COUNT(coursecategory), coursename, SUM(courseID) FROM course where coursecategory = '" & category & "' group by coursename;", sqlconn)
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
            cmbMajor.Enabled = True

            'ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)
            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else
            cmbMajor.Enabled = False
            'ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)
            cmbMajor.DataSource = Nothing
        End If
    End Sub
    Private Sub fetch_courseID()
        Try
            sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & category & "' AND coursemajor = '" & cmbMajor.Text & "'"
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
    Private Sub fetch_CAY()
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

    Private Sub frmActiveCurriculum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_course()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_course()
            sqlconn.Close()

        End If

        If sqlconn.State = ConnectionState.Open Then
            Call fetch_CurriculumAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_CurriculumAY()
            sqlconn.Close()
        End If
    End Sub

    Private Sub cmbCourse_TextChanged(sender As Object, e As EventArgs) Handles cmbCourse.TextChanged
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
            Call fetch_CAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_CAY()
            sqlconn.Close()
        End If
        If cmbCourse.Text = "" Then
            cmbCAY.Text = ""
        Else

        End If
    End Sub
    Private Sub save_activeCurriculum()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into activecurriculum([courseid],[ay]) values ('" & txtCourseID.Text & "', '" & cmbCAY.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Curriculum set Active!")
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If sqlconn.State = ConnectionState.Open Then
            Call verify_courseID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call verify_courseID()
            sqlconn.Close()
        End If


        If sqlconn.State = ConnectionState.Open Then
            Call fetch_CurriculumAY()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_CurriculumAY()
            sqlconn.Close()
        End If


    End Sub
    Private Sub fetch_CurriculumAY()
        Try
            Dim obj As Object = DBNull.Value

            Dim str As String = "select * FROM ActiveCurriculumView;"
            Dim cmd As New SqlCommand(str, sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "ActiveCurriculumView")) Then


                dtCourse.DataSource = ds.Tables(0)

                dtCourse.Columns("courseid").Visible = False

                dtCourse.Columns("coursename").DisplayIndex = 1
                dtCourse.Columns("coursename").Width = 280
                dtCourse.Columns("coursename").HeaderText = "Course"

                dtCourse.Columns("ay").DisplayIndex = 2
                dtCourse.Columns("ay").Width = 100
                dtCourse.Columns("ay").HeaderText = "CAY"
            Else

                dtCourse.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub update_activecurriculum()
        'Dim fid As Integer = 0
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE activecurriculum SET ay = '" & cmbCAY.Text & "' where courseid = '" & txtCourseID.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Curriculum AY set Active!")

    End Sub
    Private Sub verify_courseID()

        sqlcmd.CommandText = "select  * FROM activecurriculum where courseid = '" & txtCourseID.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()

            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_activecurriculum()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_activecurriculum()
                sqlconn.Close()
            End If

        Else

            Dim result = MessageBox.Show("DO you want to Add and set the Curriculum Academic Year active?", "Curriculum Academic Year", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then

                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()

                    Call save_activeCurriculum()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call save_activeCurriculum()
                    sqlconn.Close()
                End If
            ElseIf result = DialogResult.No Then

            End If

        End If
   
    End Sub
End Class