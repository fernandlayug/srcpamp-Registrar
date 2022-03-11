Imports System.Data.SqlClient
Imports System.IO
Imports System.Text


Public Class photocap

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub

    Private Sub OpenPreviewWindow()
        'Para buksan ang camera...
        Dim iHeight As Integer = picstudent.Height
        Dim iWidth As Integer = picstudent.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, picstudent.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picstudent.Width, picstudent.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub
    Private Sub ClosePreviewWindow()
        'Pagsara ng camera...
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sqlcmd As New SqlClient.SqlCommand
        Dim ms As New MemoryStream()
        picstudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlParameter("@picstudent", SqlDbType.Image)
        p.Value = data
        sqlcmd.Parameters.Add(p)

        'strsql = "INSERT into studentdata ([firstname],[mname],[surname],[sex],[birthday],[birthplace],[age],[address],[telephone],[religion],[citizenship],[father],[mother], [pic]) values ('" & firstname.Text & "','" & mname.Text & "','" & surname.Text & "','" & sex.Text & "','" & birthday.Text & "','" & birthplace.Text & "','" & age.Text & "','" & address.Text & "','" & telephone.Text & "','" & religion.Text & "','" & citizenship.Text & "','" & father.Text & "','" & mother.Text & "', @picstudent )"
        strsql = "UPDATE studentdata SET pic = @picstudent where ID = '" & ID.Text & "'"

        Dim result = MessageBox.Show("Are you sure you want to save the Information", "Student Information", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
        End If

        'sqlconn.Close()
    End Sub

    Private Sub bcapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcapture.Click
        'Kung BstartCapture ang Text nya ay "Start Camera:"
        'Heto po ang magiging function nya...
        If bcapture.Text = "Start Camera:" Then
            Call OpenPreviewWindow()
            bcapture.Text = "Capture:"
            bremove.Text = "Cancel Capture:"
            'Label5.Text = ""
            camstat.Text = "Camera is running..."
        Else
            'Mapapansin na lang po kapag nirun na yung program...
            Dim Data As IDataObject
            Dim Bmap As Image
            SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
            Data = Clipboard.GetDataObject()
            If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
                picstudent.Image = Bmap
                bcapture.Text = "Start Camera:"
                bremove.Text = "Remove Photo:"
                ClosePreviewWindow()
                MsgBox("Captured...", MsgBoxStyle.Information, "Captured...")
                camstat.Text = ""
            End If
        End If
    End Sub


    Private Sub bremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bremove.Click
        If bremove.Text = "Cancel Capture:" Then
            picstudent.Refresh()
            camstat.Text = ""
            bcapture.Text = "Start Camera:"
            bremove.Text = "Remove Photo:"
            Call ClosePreviewWindow()
            Exit Sub
        End If

        If bremove.Text = "Remove Photo:" Then
            'Para sa permanenteng pag remove ng photo, isave changes...
            picstudent.Image = Nothing
            Call ClosePreviewWindow()
            Exit Sub
        End If
    End Sub

    Private Sub ID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ID.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID.Leave
        sqlcmd.CommandText = "select * FROM studentdata Where (id = '" & ID.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            firstname.Text = daMyname.Item("firstname")
            firstname.Enabled = False
            mname.Text = daMyname.Item("mname")
            mname.Enabled = False
            surname.Text = daMyname.Item("surname")
            surname.Enabled = False
            sex.Text = daMyname.Item("sex")
            sex.Enabled = False
            birthday.Text = daMyname.Item("birthday")
            birthday.Enabled = False
            birthplace.Text = daMyname.Item("birthplace")
            birthplace.Enabled = False
            address.Text = daMyname.Item("address")
            address.Enabled = False
            address1.Text = daMyname.Item("address1")
            address1.Enabled = False
            address2.Text = daMyname.Item("address2")
            address2.Enabled = False
            address3.Text = daMyname.Item("address3")
            address3.Enabled = False
            telephone.Text = daMyname.Item("telephone")
            telephone.Enabled = False
            mobile.Text = daMyname.Item("mobile")
            mobile.Enabled = False
            religion.Text = daMyname.Item("religion")
            religion.Enabled = False
            citizenship.Text = daMyname.Item("citizenship")
            citizenship.Enabled = False
            father.Text = daMyname.Item("father")
            father.Enabled = False
            mother.Text = daMyname.Item("mother")
            mother.Enabled = False
            guardian.Text = daMyname.Item("guardian")
            guardian.Enabled = False
            Dim data As Byte() = DirectCast(daMyname("pic"), Byte())
            Dim ms As New MemoryStream(data)
            picstudent.Image = Image.FromStream(ms)
            daMyname.Close()

        Else
            MsgBox("No records Found")
            firstname.Text = ""
            mname.Text = ""
            surname.Text = ""
            sex.Text = ""
            birthday.Text = ""
            birthplace.Text = ""
            address.Text = ""
            address1.Text = ""
            address2.Text = ""
            address3.Text = ""
            telephone.Text = ""
            mobile.Text = ""
            religion.Text = ""
            citizenship.Text = ""
            father.Text = ""
            mother.Text = ""
            guardian.Text = ""
            picstudent.Image = Nothing

        End If

        daMyname.Close()

    End Sub


    Private Sub newsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newsearch.Click
        firstname.Text = ""
        mname.Text = ""
        surname.Text = ""
        sex.Text = ""
        birthday.Text = ""
        birthplace.Text = ""
        address.Text = ""
        address1.Text = ""
        address2.Text = ""
        address3.Text = ""
        telephone.Text = ""
        mobile.Text = ""
        religion.Text = ""
        citizenship.Text = ""
        father.Text = ""
        mother.Text = ""
        guardian.Text = ""
        picstudent.Image = Nothing
        ID.Text = ""
        ID.Focus()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Dispose()
    End Sub
End Class
