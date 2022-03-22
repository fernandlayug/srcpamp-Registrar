Public Class frmSubjectScheduleOption

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If department.Text = "Elementary" Then

        ElseIf department.Text = "Junior HS" Then

        ElseIf department.Text = "Senior HS" Then
            frmScheduleCollege.Show()
            frmScheduleCollege.SeniorHS.Checked = True

        ElseIf department.Text = "College" Then
            frmScheduleCollege.Show()
            frmScheduleCollege.College.Checked = True
        End If
    End Sub
End Class