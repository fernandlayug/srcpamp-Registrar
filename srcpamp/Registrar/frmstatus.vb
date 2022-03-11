Imports System.Data.SqlClient
Imports System.IO

Public Class frmstatus

    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub fetch_admission()
        sqlcmd.CommandText = "select * FROM admission Where (id = '" & studid.Text & "')and (sy = '" & sy.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname.HasRows Then
            daMyname.Read()
            lastschl.Text = daMyname.Item("lastschl")
            lastschlyear.Text = daMyname.Item("lastschlyear")
            average.Text = daMyname.Item("lastschlaverage")
            class_status.Text = daMyname.Item("status")
            birthcertificate.Text = daMyname.Item("req1")
            formone.Text = daMyname.Item("req2")
            gmoral.Text = daMyname.Item("req3")
            other.Text = daMyname.Item("req4")
            level.Text = daMyname.Item("level")
            status.Text = daMyname.Item("studentstatus")
            schltrans.Text = daMyname.Item("schooltransfer")
            schladd.Text = daMyname.Item("address")
            remarks.Text = daMyname.Item("remarks")
        Else
        End If
    End Sub

    Private Sub fetch_studentdata()
        sqlcmd.CommandText = "select * FROM studentdata Where (id = '" & studid.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            firstname.Text = daMyname.Item("firstname")
            'firstname.Enabled = False
            mname.Text = daMyname.Item("mname")
            'mname.Enabled = False
            surname.Text = daMyname.Item("surname")
            'surname.Enabled = False
            sex.Text = daMyname.Item("sex")
            'sex.Enabled = False
            birthday.Text = daMyname.Item("birthday")
            'birthday.Enabled = False
            birthplace.Text = daMyname.Item("birthplace")
            address.Text = daMyname.Item("address")
            address1.Text = daMyname.Item("address1")
            address2.Text = daMyname.Item("address2")
            address3.Text = daMyname.Item("address3")
            telephone.Text = daMyname.Item("telephone")
            mobile.Text = daMyname.Item("mobile")
            citizenship.Text = daMyname.Item("citizenship")
            religion.Text = daMyname.Item("religion")
            father.Text = daMyname.Item("father")
            mother.Text = daMyname.Item("mother")
            'mobile.Enabled = False
            guardian.Text = daMyname.Item("guardian")
            guardcontact.Text = daMyname.Item("guardcontact")
            'guardian.Enabled = False
        Else
            MsgBox("No records Found")
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

        If birthcertificate.Text = "Photocopy of Birth Certificate" Then
            bcert.Checked = True
        Else
            bcert.Checked = False
            bcert.Enabled = False
        End If
        If formone.Text = "Form-138" Then
            form138.Checked = True
        Else
            form138.Checked = False
            form138.Enabled = False
        End If
        If gmoral.Text = "Certificate of Good Moral Character" Then
            goodmoral.Checked = True
        Else
            goodmoral.Checked = False
            goodmoral.Enabled = False
        End If


    End Sub


    Private Sub frmstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        'Combo box for status
        Dim cmd As New SqlCommand("select * FROM student_status;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "student_status")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)
            status.DataSource = ds.Tables(0)
            status.ValueMember = "student_status"
            status.DisplayMember = "student_status"
        End If

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

        'Combo box for level
        Dim cmdlevel As New SqlCommand("select * FROM level order by yrlevel desc;", sqlconn)
        Dim adptlevel As New SqlDataAdapter(cmdlevel)
        Dim ds_level As New DataSet()
        If (adptlevel.Fill(ds_level, "yrlevel")) Then

            ds_level.Tables(0).Rows.InsertAt(ds_level.Tables(0).NewRow(), 0)
            level.DataSource = ds_level.Tables(0)
            level.ValueMember = "yrlevel"
            level.DisplayMember = "yrlevel"
        End If
    End Sub

    Private Sub bcert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bcert.Click
        MsgBox("You cannot change the status at this module.  Please see the IT Department")
        bcert.Checked = True
    End Sub

    Private Sub form138_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles form138.Click
        MsgBox("You cannot change the status at this module.  Please see the IT Department")
        form138.Checked = True
    End Sub

    Private Sub goodmoral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles goodmoral.Click
        MsgBox("You cannot change the status at this module.  Please see the IT Department")
        goodmoral.Checked = True
    End Sub

    Private Sub update_admission()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE admission SET studentstatus = '" & status.Text & "' , schooltransfer = '" & schltrans.Text & "'  , address = '" & schladd.Text & "', remarks = '" & remarks.Text & "',level = '" & level.Text & "'where ID = '" & studid.Text & "' and sy = '" & sy.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_studentledger()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE studentledger SET status = '" & status.Text & "', level = '" & level.Text & "' where ID = '" & studid.Text & "' and sy = '" & sy.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub update_studentstats()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE studentstats SET remarks = '" & status.Text & "',level = '" & level.Text & "'where ID = '" & studid.Text & "' and sy = '" & sy.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_booksrent()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE booksrentsale SET level = '" & level.Text & "'where ID = '" & studid.Text & "' and sy = '" & sy.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_ledger_particular()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE ledger_particular SET level = '" & level.Text & "'where ID = '" & studid.Text & "' and sy = '" & sy.Text & "' "
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub update_ledger_particular_credit()
        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE ledger_particular_credit SET level = '" & level.Text & "'where ID = '" & studid.Text & "' and sy = '" & sy.Text & "' "
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatestatus.Click
        If status.Text = "Assessed" Then
            MsgBox("You cannot save the Assessed status at this module.  Please see the administrator.")
            Me.Dispose()
        Else
            Dim result = MessageBox.Show("Are you sure you want to Change the Status of the Student?", "Student Information", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                'Update Admission
                If sqlconn.State = ConnectionState.Open Then
                    Call update_admission()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_admission()
                    sqlconn.Close()
                End If

                'UPdate Studentledger
                If sqlconn.State = ConnectionState.Open Then
                    Call update_studentledger()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_studentledger()
                    sqlconn.Close()
                End If

                'Update Student Stats
                If sqlconn.State = ConnectionState.Open Then
                    Call update_studentstats()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_studentstats()
                    sqlconn.Close()
                End If

                'Update Books Rent
                If sqlconn.State = ConnectionState.Open Then
                    Call update_booksrent()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_booksrent()
                    sqlconn.Close()
                End If

                'Update Ledger Particular
                If sqlconn.State = ConnectionState.Open Then
                    Call update_ledger_particular()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_ledger_particular()
                    sqlconn.Close()
                End If

                'Update Ledger Particular Credit
                If sqlconn.State = ConnectionState.Open Then
                    Call update_ledger_particular_credit()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call update_ledger_particular_credit()
                    sqlconn.Close()
                End If

                Dim result2 = MessageBox.Show("Records successfully update. Do you want to modify another entry", "Modify Entry", MessageBoxButtons.YesNo)
                If result2 = DialogResult.Yes Then
                    Me.Dispose()

                    Dim frm As New frmstatus
                    frm.Show()

                ElseIf result2 = DialogResult.No Then
                    Me.Dispose()
                End If


            ElseIf result = DialogResult.No Then
                Me.Dispose()
            ElseIf result = DialogResult.Cancel Then
                MessageBox.Show("Please check all the information")
            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub


End Class