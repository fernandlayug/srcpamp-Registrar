Public Class frmSubjectScheduleOption
    Private Sub frmSubjectScheduleOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If department.Text = "Elementary" Then

        ElseIf department.Text = "Junior HS" Then

        ElseIf department.Text = "Senior HS" Then
            frmScheduleSHS.Show()
        ElseIf department.Text = "College" Then
            frmScheduleCollege.Show()
        End If
    End Sub
End Class