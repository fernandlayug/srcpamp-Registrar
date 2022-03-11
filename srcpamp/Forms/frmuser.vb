Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class frmuser

    Private Sub frmuser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        'combobox for account type

        Dim cmdaccount As New SqlCommand("select * FROM accounttype;", sqlconn)
        Dim adptaccount As New SqlDataAdapter(cmdaccount)
        Dim ds_account As New DataSet()
        If (adptaccount.Fill(ds_account, "accounttype")) Then

            ds_account.Tables(0).Rows.InsertAt(ds_account.Tables(0).NewRow(), 0)

            account.DataSource = ds_account.Tables(0)
            account.ValueMember = "account"
            account.DisplayMember = "account"
        End If

        'Combobox for designation

        Dim cmddesignation As New SqlCommand("select * FROM designation;", sqlconn)
        Dim adptdesignation As New SqlDataAdapter(cmddesignation)
        Dim ds_designation As New DataSet()
        If (adptdesignation.Fill(ds_designation, "designation")) Then

            ds_designation.Tables(0).Rows.InsertAt(ds_designation.Tables(0).NewRow(), 0)

            designation.DataSource = ds_designation.Tables(0)
            designation.ValueMember = "position"
            designation.DisplayMember = "position"
        End If
    End Sub
    Private Sub fetch_designation()
        sqlcmd.CommandText = "select * FROM designation Where (position = '" & designation.Text & "' );"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then

            daMyname.Read()
            department.Text = daMyname.Item("department")
            account1.Text = daMyname.Item("account")
            daMyname.Close()
        Else
            department.Text = Nothing
            account.Text = Nothing

        End If
    End Sub
    Private Sub fetch_info()
        sqlcmd.CommandText = "select * FROM employee Where (id = '" & empID.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader()
        If daMyname2.HasRows Then
            daMyname2.Read()
            firstname.Text = daMyname2.Item("firstname")
            mname.Text = daMyname2.Item("mname")
            surname.Text = daMyname2.Item("surname")
            firstname.Text = daMyname2.Item("firstname")
            designation1.Text = daMyname2.Item("designation")
            department.Text = daMyname2.Item("department")
            account1.Text = daMyname2.Item("accounttype")

        Else
            MsgBox("NO Registered Employee's ID")
            empID.Text = ""
            empID.Focus()
        End If
    End Sub
    Private Sub empID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles empID.Leave
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_info()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_info()
            sqlconn.Close()
        End If
    End Sub

    Private Sub designation_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles designation.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_designation()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_designation()
            sqlconn.Close()
        End If
        designation1.Text = designation.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        designation.Visible = True
        cancel1.Visible = True
        LinkLabel1.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        account.Visible = True
        cancel2.Visible = True
        LinkLabel2.Visible = False
    End Sub

    Private Sub cancel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cancel1.LinkClicked
        designation.Visible = False
        cancel1.Visible = False
        LinkLabel1.Visible = True
    End Sub

    Private Sub cancel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cancel2.LinkClicked
        account.Visible = False
        cancel2.Visible = False
        LinkLabel2.Visible = True
    End Sub

    Private Sub account_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles account.TextChanged
        account1.Text = account.Text
    End Sub
    Private Sub update_account()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE employee SET designation = '" & designation1.Text & "', department = '" & department.Text & "', accounttype = '" & account1.Text & "' where ID = '" & empID.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure you want to update the Information?", "Employee's Information", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call update_account()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call update_account()
                sqlconn.Close()
            End If
            Dim result1 = MessageBox.Show("Update Complete. Do you want to reload form?", "Employee's Information", MessageBoxButtons.YesNo)
            If result1 = DialogResult.Yes Then
                Me.Dispose()
                Dim frm As New frmuser
                frm.Show()
                frm.MdiParent = Main
            ElseIf result1 = DialogResult.No Then
                Me.Dispose()

            End If

        ElseIf result = DialogResult.No Then
            Me.Dispose()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class