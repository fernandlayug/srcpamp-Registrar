Imports System.Data.SqlClient
Public Class SearchSubject

    Private Sub SearchSubject_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub SearchSubject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub


    Private Sub Search_subject()

        Try
            Dim cmd As New SqlCommand("select subjectcode, subjectdescription, subjectunits,status FROM subject Where (subjectdescription like '%" & txtDescription.Text & "%' and subjectcategory = '" & cmbSubjectCategory.Text & "') ;", sqlconn)
            Dim adpt As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            If (adpt.Fill(ds, "subject")) Then

                SubjectResult.Visible = True
                SubjectResult.DataSource = ds.Tables(0)
                SubjectResult.Columns("subjectcode").DisplayIndex = 0
                SubjectResult.Columns("subjectcode").HeaderText = "Subject Code"
                SubjectResult.Columns("subjectcode").Width = 110

                SubjectResult.Columns("subjectdescription").DisplayIndex = 1
                SubjectResult.Columns("subjectdescription").HeaderText = "Subject Description"
                SubjectResult.Columns("subjectdescription").Width = 380


                SubjectResult.Columns("subjectunits").DisplayIndex = 2
                SubjectResult.Columns("subjectunits").HeaderText = "Units"
                SubjectResult.Columns("subjectunits").Width = 80
                SubjectResult.Columns("subjectunits").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                SubjectResult.Columns("status").DisplayIndex = 3
                SubjectResult.Columns("status").HeaderText = "Status"
                SubjectResult.Columns("status").Width = 70


                'student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else
                SubjectResult.DataSource = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As System.EventArgs) Handles txtDescription.TextChanged
        If sqlconn.State = ConnectionState.Open Then
            Call Search_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call Search_subject()
            sqlconn.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub save_subject()
        Dim y As Boolean = True
        Dim n As Boolean = False

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "INSERT into subject ([subjectcode],[subjectdescription],[subjectunits],[subjectcategory],[subjectprereq],[status]) values ('" & txtCode.Text & "','" & txtDescription.Text & "','" & txtUnits.Text & "', '" & cmbSubjectCategory.Text & "', '" & txtPrereq.Text & "','" & IIf(chkStatus.Checked, y, n) & "')"

        If String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please add Subject Description")
            txtDescription.Focus()
        ElseIf String.IsNullOrEmpty(txtCode.Text) Then
            MessageBox.Show("Please enter subject code")
            txtCode.Focus()
        ElseIf String.IsNullOrEmpty(txtUnits.Text) Then
            MessageBox.Show("Please enter subject units")
            txtUnits.Focus()

        Else
            Dim result = MessageBox.Show("Are you sure you want to add the subject?", "Subjects", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                sqlcmd.CommandText = strsql
                sqlcmd.Connection = sqlconn
                sqlcmd.ExecuteNonQuery()


                Dim result2 = MessageBox.Show("Information Saved. Do you want to Add New Entry?", "Subject", MessageBoxButtons.YesNo)
                If result2 = DialogResult.Yes Then

                    Call clear_records()
                    txtDescription.Focus()

                ElseIf result2 = DialogResult.No Then
                    Me.Dispose()
                End If


            ElseIf result = DialogResult.No Then
                Me.Dispose()
            End If

        End If
    End Sub
    Private Sub clear_records()
        txtDescription.Clear()
        txtCode.Clear()
        txtUnits.Clear()
        chkStatus.Checked = False
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If sqlconn.State = ConnectionState.Open Then
            Call save_subject()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call save_subject()
            sqlconn.Close()
        End If
    End Sub

    Private Sub txtUnits_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnits.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class