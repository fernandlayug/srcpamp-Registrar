Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmSubject

    Private Sub frmassess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub fetch_subject()
        Try
            Dim cmd As New SqlCommand("select * FROM assignSUBJECT Where (category= '" & Main.dep.Text & "');", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "assignSUBJECT")) Then

                subject.DataSource = ds.Tables(0)
                '
                subject.Columns(0).HeaderText = "Subject ID"
                subject.Columns(1).HeaderText = "Category"
                subject.Columns(2).HeaderText = "Subject"

               
                subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                'MessageBox.Show("No match Found")
                subject.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub fetch_subject1()
        Try
            Dim cmd As New SqlCommand("select * FROM assignSUBJECT Where (category= '" & category.Text & "');", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "assignSUBJECT")) Then

                subject.DataSource = ds.Tables(0)
                '
                subject.Columns(0).HeaderText = "Subject ID"
                subject.Columns(1).HeaderText = "Category"
                subject.Columns(2).HeaderText = "Subject"


                subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                'MessageBox.Show("No match Found")
                subject.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mResult
        'Dim ObjConnection As New SqlConnection()
        mResult = MsgBox("Do you really want to delete the selected record?", _
        vbYesNo + vbQuestion, "Removal Confirmation")
        If mResult = vbNo Then
            Exit Sub
        End If
        'ObjConnection.ConnectionString = "Database=ITtry;" & "Data Source=SLSDB\SLSREP;" & "Uid=sa;Password=****"
        sqlconn.Open()
        Try
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = sqlconn

            ObjCommand.CommandText = "delete from assignSUBJECT where subID ='" & Me.subject.CurrentRow.Cells(0).Value & "'"
            ObjCommand.ExecuteNonQuery()
        Finally
            sqlconn.Close()
        End Try

        Me.subject.Rows.Remove(Me.subject.CurrentRow)

    End Sub

    Private Sub save_records()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into assignSUBJECT ([category],[subject]) values ('" & category.Text & "','" & addsubject.Text & "')"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MsgBox("Records Saved!")
        addsubject.Text = ""
        
    End Sub
    Private Sub verify_records()
        sqlcmd.CommandText = "select * FROM assignSUBJECT Where (category = '" & category.Text & "') and (subject = '" & addsubject.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname2 As SqlDataReader
        daMyname2 = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection)
        If daMyname2.HasRows Then
            daMyname2.Read()
            MsgBox("Subject Name already exist")
            addsubject.Text = ""
           
        Else
            Dim result = MessageBox.Show("Are you sure you want to Add Records?", "Subject Information", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                    sqlconn.Open()
                    Call save_records()
                    sqlconn.Close()
                Else
                    sqlconn.Open()
                    Call save_records()
                    sqlconn.Close()
                End If
            ElseIf result = DialogResult.No Then
                ' Me.Dispose()
            End If

        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call verify_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call verify_records()
            sqlconn.Close()
        End If


        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subject1()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject1()
            sqlconn.Close()
        End If
    End Sub

 
    Private Sub frmSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()

        category.Text = Main.dep.Text

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject()
            sqlconn.Close()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dlg As New overide
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            category.Enabled = True
        Else
        End If
    End Sub

    Private Sub category_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles category.Leave
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_subject1()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_subject1()
            sqlconn.Close()
        End If
    End Sub
End Class