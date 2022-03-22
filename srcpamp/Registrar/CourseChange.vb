Imports System.Data.SqlClient
Imports System.IO
Public Class CourseChange
    Dim yrlevelcategory, coursecode, depLevel As String
    Dim bc, f138, gm, tr As String
    Dim AddSchool As Boolean
    Dim AddSchoolA As Boolean
    Public schoolcode As String
    Public schoolid As Integer
    Public schoolidA As Integer
    Dim term As Integer
    Dim activeCAY As String
    Dim Ac_CAY As String
    Dim sectionid_temp As Integer


    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        CenterToScreen()


    End Sub

    Private Sub fetch_course()
        yrlevelcategory = "College"
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
  
    Private Sub fetch_coursecode()

        sqlcmd.CommandText = "select  * FROM course where coursename = '" & cmbCourse.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            c_code.Text = daMyname.Item("coursecode")
        End If
 
    End Sub

    Private Sub fetch_coursemajor()
        Dim cmdmajor As New SqlCommand("select * FROM course where coursecode = '" & c_code.Text & "'order by courseid DESC;", sqlconn)
        Dim adptmajor As New SqlDataAdapter(cmdmajor)
        Dim ds_major As New DataSet()
        If (adptmajor.Fill(ds_major, "course")) Then
            cmbMajor.Enabled = True

            'ds_major.Tables(0).Rows.InsertAt(ds_major.Tables(0).NewRow(), 0)

            cmbMajor.DataSource = ds_major.Tables(0)
            cmbMajor.ValueMember = "coursemajor"
            cmbMajor.DisplayMember = "coursemajor"
        Else
            cmbMajor.DataSource = Nothing


        End If

    End Sub


    Private Sub fetch_courseid()
        yrlevelcategory = "College"
        sqlcmd.CommandText = "Select * FROM course WHERE coursecode = '" & c_code.Text & "' AND coursename = '" & cmbCourse.Text & "' AND coursecategory = '" & yrlevelcategory & "' AND coursemajor = '" & cmbMajor.Text & "'"
        sqlcmd.Connection = sqlconn
        Dim damyname As SqlDataReader
        damyname = sqlcmd.ExecuteReader
        If damyname.HasRows Then
            damyname.Read()
            txtCourseID.Text = damyname.Item("courseid")
        Else
            txtCourseID.Text = 0
        End If
    End Sub
    Private Sub c_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c_code.TextChanged
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
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmbCourse.Enabled = True
        cmbMajor.Enabled = True
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

    Private Sub cmbCourse_TextChanged(sender As Object, e As EventArgs) Handles cmbCourse.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_coursecode()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_coursecode()
            sqlconn.Close()
        End If
    End Sub
    Private Sub Update_admission()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET courseid = '" & txtCourseID.Text & "'  where studentid = '" & studid.Text & "' and sy = '" & sy.Text & "' and term = '" & txtTerm.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Changes Applied")
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call Update_admission()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call Update_admission()
            sqlconn.Close()
        End If
        'studentfile.cmbCourse.Text = cmbCourse.Text
        'studentfile.c_code.Text = c_code.Text
        'studentfile.cmbMajor.Text = cmbMajor.Text
        studentfile.txtcourseid.Text = txtCourseID.Text
        Me.Dispose()
    End Sub
End Class