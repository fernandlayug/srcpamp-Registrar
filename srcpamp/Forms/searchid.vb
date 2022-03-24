Imports System.Data.SqlClient
Public Class searchid
    Public frmactive As String

    Private Sub searchid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.F4 Then
            Me.Dispose()
        End If

        If e.KeyCode = Keys.F3 Then
            searchbox.Text = ""
            searchbox.Focus()
        End If


        If e.KeyCode = Keys.F2 Then
            If frmactive = "Registration" Then
                registration.oldstudent.Checked = True
                registration.newstudent.Checked = False
                registration.studid.Text = studentID.Text
                Me.Dispose()
            ElseIf frmactive = "studentfile" Then
                studentfile.studid.Text = studentID.Text
                Me.Dispose()
            ElseIf frmactive = "studentfileJHS" Then
                'studentfileJHS.studid.Text = studentID.Text
                Me.Dispose()
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub searchid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub


    Private Sub lastname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchbox.TextChanged
        'Dim cmd As New SqlCommand("select studentID, firstname, mname, surname FROM studentdata Where (firstname like '%" & lastname.Text & "%' or surname like '%" & lastname.Text & "%') ;", sqlconn)
        Dim cmd As New SqlCommand("select studentID, firstname, mname, surname, sex, birthday FROM studentdata Where (surname + ' ' + firstname + ' ' + mname like '%" & searchbox.Text & "%' or studentID like '%" & searchbox.Text & "%') ;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "studentdata")) Then

            student.Visible = True
            student.DataSource = ds.Tables(0)
            student.Columns("studentID").DisplayIndex = 0
            student.Columns("studentID").HeaderText = "StudentID"
            student.Columns("studentID").Width = 90

            student.Columns("surname").DisplayIndex = 1
            student.Columns("surname").HeaderText = "Surname"
            student.Columns("surname").Width = 110

            student.Columns("firstname").HeaderText = "Firstname"
            student.Columns("firstname").Width = 140

            student.Columns("mname").DisplayIndex = 3
            student.Columns("mname").HeaderText = "M.I."
            student.Columns("mname").Width = 100

            student.Columns("sex").DisplayIndex = 4
            student.Columns("sex").HeaderText = "Gender"
            student.Columns("sex").Width = 60

            student.Columns("birthday").DisplayIndex = 5
            student.Columns("birthday").HeaderText = "B-day."
            student.Columns("birthday").Width = 80

            'student.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Else
            'MessageBox.Show("No match Found")
            student.Visible = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub student_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles student.CellDoubleClick
        If frmactive = "Registration" Then
            registration.oldstudent.Checked = True
            registration.newstudent.Checked = False
            registration.studid.Text = studentID.Text
            Me.Dispose()
        ElseIf frmactive = "studentfile" Then
            studentfile.studid.Text = studentID.Text
            Me.Dispose()
        ElseIf frmactive = "studentfileBE" Then
            studentfileBE.studid.Text = studentID.Text
            Me.Dispose()
        End If
    End Sub

    Private Sub student_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles student.CellEnter
        Dim myVariable As String = student.CurrentRow.Cells(0).Value.ToString
        studentID.Text = myVariable
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        searchbox.Text = ""
        searchbox.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If frmactive = "Registration" Then
            registration.oldstudent.Checked = True
            registration.newstudent.Checked = False
            registration.studid.Text = studentID.Text
            Me.Dispose()
        ElseIf frmactive = "studentfile" Then
            studentfile.studid.Text = studentID.Text
            Me.Dispose()
        ElseIf frmactive = "studentfileJHS" Then
            'studentfileJHS.studid.Text = studentID.Text
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class