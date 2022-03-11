Imports System.Data.SqlClient
Imports System.IO

Public Class frmtransferSECTION

    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub fetch_admission()
        Try
            sqlcmd.CommandText = "select * FROM admission Where (id = '" & studid.Text & "')and (sy = '" & sy.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
            If daMyname.HasRows Then
                daMyname.Read()
                firstname.Text = daMyname.Item("firstname")
                'firstname.Enabled = False
                mname.Text = daMyname.Item("mname")
                'mname.Enabled = False
                surname.Text = daMyname.Item("surname")
                'surname.Enabled = False
                sex.Text = daMyname.Item("sex")
                level.Text = daMyname.Item("level")
                currentsection.Text = daMyname.Item("section")
            Else
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub fetch_studentdata()
        sqlcmd.CommandText = "select * FROM studentdata Where (id = '" & studid.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
        

            birthday.Text = daMyname.Item("birthday")
        Else

        End If
    End Sub
    Private Sub studid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles studid.Leave
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_studentdata()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_studentdata()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_admission()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_admission()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_advisoryidNAME()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_advisoryidNAME()
            sqlconn.Close()
        End If


    End Sub


    Private Sub frmstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    End Sub
    Private Sub fetch_advisoryidNAME()
        Try
            sqlcmd.CommandText = "select * FROM sectionVIEW Where (level = '" & level.Text & "' AND section = '" & currentsection.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                Dim f As String
                Dim m As String
                Dim l As String

                f = daMyname.Item("firstname")
                m = daMyname.Item("mname")
                l = daMyname.Item("surname")
                id.Text = daMyname.Item("adviser")

                adviser.Text = f + " " + m + " " + l


            Else
                adviser.Text = ""
                id.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub fetch_advisoryidNAME_NEW()
        Try
            sqlcmd.CommandText = "select * FROM sectionVIEW Where (level = '" & level.Text & "' AND section = '" & section.Text & "');"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                Dim f As String
                Dim m As String
                Dim l As String

                f = daMyname.Item("firstname")
                m = daMyname.Item("mname")
                l = daMyname.Item("surname")
                id.Text = daMyname.Item("adviser")

                adviser.Text = f + " " + m + " " + l


            Else
                id.Text = ""
                adviser.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub section_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles section.Click
        Try
            Dim cmdsy As New SqlCommand("select * FROM section where (level = '" & level.Text & "');", sqlconn)
            Dim adptsy As New SqlDataAdapter(cmdsy)
            Dim ds_sy As New DataSet()
            If (adptsy.Fill(ds_sy, "section")) Then

                ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)
                section.DataSource = ds_sy.Tables(0)
                section.ValueMember = "section"
                section.DisplayMember = "section"
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub section_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles section.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_advisoryidNAME_NEW()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_advisoryidNAME_NEW()
            sqlconn.Close()
        End If
    End Sub
    Private Sub update_section()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET section = '" & section.Text & "' where(ID = '" & studid.Text & "') and (sy = '" & sy.Text & "') and (level = '" & level.Text & "');"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()

        Dim result = MessageBox.Show("Update Complete.  Do you you want to Process  Another?", "Student Information", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Dispose()
            Dim frm As New frmtransferSECTION
            frm.Show()
            frm.MdiParent = Main
        ElseIf result = DialogResult.No Then
            Me.Dispose()
        End If

    End Sub
    Private Sub updatestatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatestatus.Click
        Dim result = MessageBox.Show("Are you sure you want to Process Transfer Section?", "Student Information", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
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
        ElseIf result = DialogResult.No Then
            Me.Dispose()

        End If
    End Sub
End Class