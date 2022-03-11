Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Configuration

Public Class classmanagement
    Private Sub classmanagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        male.Checked = False
        female.Checked = False

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_advisory()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_advisory()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sectionlist()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionlist()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_male()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_male()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_female()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_female()
            sqlconn.Close()
        End If

        Dim Tstudent As Integer = m + f
        Dim b As String
        b = Tstudent
        Dim a As String = "Total No. of Student: "
        nos.Text = a + b
    End Sub
    Private Sub fetch_sectionlist()

        Dim cmd As New SqlCommand("select * FROM admission Where (sy = '" & Main.SY.Text & "' AND level = '" & level.Text & "' AND  section = '" & section.Text & "') order by surname ASC ;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet(CommandBehavior.CloseConnection)
        If (adpt.Fill(ds, "admission")) Then

            sectionlist.DataSource = ds.Tables(0)
            sectionlist.Columns("lastschl").Visible = False
            sectionlist.Columns("lastschlyear").Visible = False
            sectionlist.Columns("lastschlaverage").Visible = False
            sectionlist.Columns("sy").Visible = False
            sectionlist.Columns("level").Visible = False
            sectionlist.Columns("dateregistered").Visible = False
            sectionlist.Columns("studentstatus").Visible = False
            sectionlist.Columns("schooltransfer").Visible = False
            sectionlist.Columns("address").Visible = False
            sectionlist.Columns("remarks").Visible = False
            sectionlist.Columns("section").Visible = False

            sectionlist.Columns(0).DisplayIndex = 1
            sectionlist.Columns(0).Width = 60
            sectionlist.Columns(0).HeaderText = "ID"
            sectionlist.Columns(3).DisplayIndex = 2
            sectionlist.Columns(3).Width = 130
            sectionlist.Columns(3).HeaderText = "Surname"
            sectionlist.Columns(1).DisplayIndex = 3
            sectionlist.Columns(1).Width = 130
            sectionlist.Columns(1).HeaderText = "Firstname"
            sectionlist.Columns(2).DisplayIndex = 4
            sectionlist.Columns(2).Width = 130
            sectionlist.Columns(2).HeaderText = "Middle Name"
            sectionlist.Columns(4).DisplayIndex = 5
            sectionlist.Columns(4).Width = 50
            sectionlist.Columns(4).HeaderText = "Gender"
            ' sectionlist.Columns(4).DisplayIndex = 5

            ' sectionlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else
            MsgBox("No match Found")
            sectionlist.DataSource = Nothing
        End If

    End Sub
    Public m As Integer
    Public f As Integer

    Private Sub fetch_male()
        Try
            Dim male As String = "Male"
            Dim cmd As New SqlCommand("select * FROM admission Where (sy = '" & Main.SY.Text & "' AND level = '" & level.Text & "' AND  section = '" & section.Text & "' AND sex = '" & male & "')  ;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "admission")) Then

                m = ds.Tables(0).Rows.Count

                Dim m1 As String
                m1 = m
                Dim statement As String = "Male: "
                maleCOUNT.Text = statement + m1
            Else

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub fetch_female()
        Try
            Dim female As String = "Female"
            Dim cmd As New SqlCommand("select * FROM admission Where (sy = '" & Main.SY.Text & "' AND level = '" & level.Text & "' AND  section = '" & section.Text & "' AND sex = '" & female & "')  ;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds1 As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds1, "admission")) Then

                f = ds1.Tables(0).Rows.Count
                Dim f1 As String
                f1 = f
                Dim statement As String = "Female: "
                femaleCOUNT.Text = statement + f1
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_student()
        Try
            Dim obj As Object = DBNull.Value

            Dim cmd As New SqlCommand("select * FROM admission Where (sy = '" & Main.SY.Text & "' AND level = '" & level.Text & "' AND section IS NULL AND sex = '" & sex.Text & "')  order by surname ASC;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet(CommandBehavior.CloseConnection)
            If (adpt.Fill(ds, "admission")) Then

                gridparticular.DataSource = ds.Tables(0)
                gridparticular.Columns("lastschl").Visible = False
                gridparticular.Columns("sex").Visible = False
                gridparticular.Columns("lastschlyear").Visible = False
                gridparticular.Columns("lastschlaverage").Visible = False
                gridparticular.Columns("status").Visible = False
                gridparticular.Columns("sy").Visible = False
                gridparticular.Columns("level").Visible = False
                gridparticular.Columns("dateregistered").Visible = False
                gridparticular.Columns("studentstatus").Visible = False
                gridparticular.Columns("schooltransfer").Visible = False
                gridparticular.Columns("address").Visible = False
                gridparticular.Columns("remarks").Visible = False
                gridparticular.Columns("section").Visible = False


                Dim chk As New DataGridViewCheckBoxColumn

                gridparticular.Columns.Add(chk)
                chk.HeaderText = "Add"
                chk.Name = "chk"

                gridparticular.Columns("chk").DisplayIndex = 0
                gridparticular.Columns("chk").Width = 50
                gridparticular.Columns(0).DisplayIndex = 1
                gridparticular.Columns(0).Width = 60
                gridparticular.Columns(0).HeaderText = "ID"
                gridparticular.Columns(3).DisplayIndex = 2
                gridparticular.Columns(3).Width = 130
                gridparticular.Columns(3).HeaderText = "Surname"
                gridparticular.Columns(1).DisplayIndex = 3
                gridparticular.Columns(1).Width = 130
                gridparticular.Columns(1).HeaderText = "Firstname"
                gridparticular.Columns(2).DisplayIndex = 4
                gridparticular.Columns(2).Width = 130
                gridparticular.Columns(2).HeaderText = "Middle Name"
                ' gridparticular.Columns(4).DisplayIndex = 5

                ' gridparticular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                MsgBox("No match Found")
                gridparticular.DataSource = Nothing
            End If

        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub fetch_advisory()
        Try
            sqlcmd.CommandText = "select * FROM section Where (adviser = '" & Main.empid.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                department.Text = daMyname.Item("category")
                level.Text = daMyname.Item("level")
                section.Text = daMyname.Item("section")

                sec.Text = level.Text + " - " + section.Text


            Else
                department.Text = ""
                level.Text = ""
                section.Text = ""
                sec.Text = ""

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub update_records()
        Try
            For i = 0 To Me.gridparticular.RowCount - 1
                Dim rowID = Me.gridparticular.Rows(i).Cells(0).Value

                ' If CBool(Me.gridparticular.Rows(i).Cells(0).Value) = True Then
                If CBool(Me.gridparticular.Rows(i).Cells("chk").Value) = True Then


                    Dim sqlcmd As New SqlClient.SqlCommand
                    ' strsql = "update admission set section = '" & Label1.Text & "'"
                    strsql = "update admission set section = '" & section.Text & "' where id = '" & rowID & "'"
                    sqlcmd.CommandText = strsql
                    sqlcmd.Connection = sqlconn
                    sqlcmd.ExecuteNonQuery()


                End If

            Next
            MsgBox("Update Finished")

            gridparticular.DataSource = Nothing
            gridparticular.Columns.Clear()
            gridparticular.Rows.Clear()



        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try



    End Sub


    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Dispose()
    End Sub


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If sqlconn.State = ConnectionState.Open Then
            Call update_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_records()
            sqlconn.Close()
        End If

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

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sectionlist()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sectionlist()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_male()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_male()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_female()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_female()
            sqlconn.Close()
        End If

        Dim Tstudent As Integer = m + f
        Dim b As String
        b = Tstudent
        Dim a As String = "Total No. of Student: "
        nos.Text = a + b
    End Sub

    Private Sub male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles male.CheckedChanged
        If male.Checked = True Then
            female.Checked = False
            sex.Text = "Male"

            gridparticular.DataSource = Nothing
            gridparticular.Columns.Clear()
            gridparticular.Rows.Clear()

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
        Else
            gridparticular.DataSource = Nothing
            gridparticular.Columns.Clear()
            gridparticular.Rows.Clear()
            sex.Text = ""
        End If
    End Sub

    Private Sub female_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles female.CheckedChanged
        If female.Checked = True Then
            male.Checked = False
            sex.Text = "Female"

            gridparticular.DataSource = Nothing
            gridparticular.Columns.Clear()
            gridparticular.Rows.Clear()

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
        Else
            gridparticular.DataSource = Nothing
            gridparticular.Columns.Clear()
            gridparticular.Rows.Clear()
            sex.Text = ""
        End If
    End Sub


    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class