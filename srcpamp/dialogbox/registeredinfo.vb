Public Class registeredinfo


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        admissionFrm.studid.Text = id.Text()
        admissionFrm.ShowDialog()

        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class