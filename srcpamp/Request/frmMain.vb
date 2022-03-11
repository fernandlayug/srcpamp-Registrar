Public Class frmMain



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmrequest As New frmRequest
        frmrequest.Show()
        frmrequest.MdiParent = Main

        'frmRequest.Show()
        'frmRequest.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmview As New frmView
        frmview.Show()
        'frmview.MdiParent = Main

        'frmView.Show()
        'frmView.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frmcloserequest As New frmCloseRequest
        frmcloserequest.Show()
        frmcloserequest.MdiParent = Main
        'frmCloseRequest.Show()
        'frmCloseRequest.WindowState = FormWindowState.Normal
    End Sub


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'LoginForm1.Dispose()

    End Sub
End Class