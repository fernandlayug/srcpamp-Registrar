Public Class frmSubjectScheduleOption

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If department.Text = "Elementary" Then

            frmScheduleBE.Cterm = 4
            frmScheduleBE.Elementary.Checked = True
            If sqlconn.State = ConnectionState.Open Then
                Call frmScheduleBE.fetch_college_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call frmScheduleBE.fetch_college_faculty()
                sqlconn.Close()

            End If

            If sqlconn.State = ConnectionState.Open Then
                Call frmScheduleBE.fetch_course()
                Call frmScheduleBE.fetch_yrlevel()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call frmScheduleBE.fetch_course()
                Call frmScheduleBE.fetch_yrlevel()
                sqlconn.Close()

            End If

            frmScheduleBE.Show()

        ElseIf department.Text = "Junior HS" Then
            frmScheduleBE.Cterm = 4
            frmScheduleBE.JuniorHS.Checked = True
            If sqlconn.State = ConnectionState.Open Then
                Call frmScheduleBE.fetch_college_faculty()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call frmScheduleBE.fetch_college_faculty()
                sqlconn.Close()

            End If

            If sqlconn.State = ConnectionState.Open Then
                Call frmScheduleBE.fetch_course()
                Call frmScheduleBE.fetch_yrlevel()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call frmScheduleBE.fetch_course()
                Call frmScheduleBE.fetch_yrlevel()
                sqlconn.Close()

            End If

            frmScheduleBE.Show()

        ElseIf department.Text = "Senior HS" Then
            frmScheduleCollege.Show()
            frmScheduleCollege.SeniorHS.Checked = True

        ElseIf department.Text = "College" Then
            frmScheduleCollege.Show()
            frmScheduleCollege.College.Checked = True
        End If
    End Sub
End Class