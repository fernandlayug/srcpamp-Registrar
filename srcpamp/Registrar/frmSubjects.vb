Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class frmSubjects
    Dim rowID As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub frmSubjects_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        gridparticular.DataSource = Nothing
    End Sub

    Private Sub classmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()


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

        SendMessage(Me.txtDescription.Handle, &H1501, 0, "Search subjects here...")



    End Sub
    Private Sub Search_subject()

        Dim cmd As New SqlCommand("select * FROM subject Where (subjectdescription like '%" & txtDescription.Text & "%' and subjectcategory = '" & cmbSubjectCategory.Text & "') ;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "subject")) Then

            gridparticular.Columns.Clear()

            gridparticular.Visible = True
            gridparticular.DataSource = ds.Tables(0)

            Dim chk As New DataGridViewCheckBoxColumn
            gridparticular.Columns("subjectID").Visible = False
            gridparticular.Columns("subjectcategory").Visible = False
            gridparticular.Columns("status").Visible = False

            gridparticular.Columns.Add(chk)
            chk.HeaderText = "Add"
            chk.Name = "chk"

            gridparticular.Columns("chk").DisplayIndex = 0
            gridparticular.Columns("chk").Width = 50
            gridparticular.Columns("subjectcode").DisplayIndex = 1
            gridparticular.Columns("subjectcode").HeaderText = "Code"
            gridparticular.Columns("subjectcode").Width = 120

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
            gridparticular.Columns("subjectprereq").Width = 100

            'student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else
            gridparticular.DataSource = Nothing
        End If
    End Sub
    Private Sub fetch_student()
        Try
            Dim obj As Object = DBNull.Value

            Dim cmd As New SqlCommand("select * FROM subject Where (subjectcategory = '" & cmbSubjectCategory.Text & "')  order by subjectid ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "subject")) Then

                gridparticular.Columns.Clear()

                gridparticular.DataSource = ds.Tables(0)

                Dim chk As New DataGridViewCheckBoxColumn
                gridparticular.Columns("subjectID").Visible = False
                gridparticular.Columns("subjectcategory").Visible = False
                gridparticular.Columns("status").Visible = False

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
                gridparticular.Columns("subjectdescription").Width = 300

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
                gridparticular.Columns("subjectprereq").Width = 100

                ' gridparticular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                gridparticular.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub save_curriculum()
       
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into curriculum ([courseid],[levelid],[term],[subjectid], [CAY]) values ('" & txtCourseID.Text & "','" & txtLevelID.Text & "','" & txtTermID.Text & "','" & rowID & "', '" & txtCAY.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        sqlconn.Close()
    End Sub
    Private Sub addSubjects()

        For i = 0 To Me.gridparticular.RowCount - 1
            rowID = Me.gridparticular.Rows(i).Cells("subjectid").Value

            ' If CBool(Me.gridparticular.Rows(i).Cells(0).Value) = True Then
            If CBool(Me.gridparticular.Rows(i).Cells("chk").Value) = True Then


                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    sqlcmd.CommandText = "select * FROM curriculum Where (courseid = '" & txtCourseID.Text & "') and (subjectid = '" & rowID & "') and (CAY = '" & txtCAY.Text & "');"
                    sqlcmd.Connection = sqlconn
                    Dim daMyname As SqlDataReader
                    daMyname = sqlcmd.ExecuteReader()
                    If daMyname.HasRows Then
                        daMyname.Read()

                    Else
                        If sqlconn.State = ConnectionState.Open Then
                            sqlconn.Close()
                            sqlconn.Open()

                            Call save_curriculum()
                            sqlconn.Close()
                        ElseIf sqlconn.State = ConnectionState.Closed Then
                            sqlconn.Open()
                            Call save_curriculum()
                            sqlconn.Close()

                        End If
                    End If
                Else
                    sqlconn.Open()
                    sqlconn.Close()
                    sqlconn.Open()
                    sqlcmd.CommandText = "select * FROM curriculum Where (courseid = '" & txtCourseID.Text & "') and (subjectid = '" & rowID & "') and (CAY = '" & txtCAY.Text & "');"
                    sqlcmd.Connection = sqlconn
                    Dim daMyname As SqlDataReader
                    daMyname = sqlcmd.ExecuteReader()
                    If daMyname.HasRows Then
                        daMyname.Read()

                    Else
                        If sqlconn.State = ConnectionState.Open Then
                            sqlconn.Close()
                            sqlconn.Open()

                            Call save_curriculum()
                            sqlconn.Close()
                        ElseIf sqlconn.State = ConnectionState.Closed Then
                            sqlconn.Open()
                            Call save_curriculum()
                            sqlconn.Close()

                        End If
                    End If
                End If
            End If

        Next
        MsgBox("Update Finished")
        txtDescription.Focus()
        txtDescription.Text = ""

        If sqlconn.State = ConnectionState.Open Then
            Call frmCurriculum.fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call frmCurriculum.fetch_subjects()
            sqlconn.Close()

        End If
    End Sub
    Private Sub txtDescription_TextChanged(sender As Object, e As System.EventArgs) Handles txtDescription.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call Search_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call Search_subject()
            sqlconn.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call addSubjects()


    End Sub
    Private Sub update_subject()
        If sqlconn.State = ConnectionState.Open Then
            Call frmCurriculum.fetch_subjects()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call frmCurriculum.fetch_subjects()
            sqlconn.Close()

        End If
    End Sub



End Class