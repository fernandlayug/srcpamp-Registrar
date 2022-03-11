Imports System.Data.SqlClient
Imports System.IO
Imports System.Text


Public Class modifyrecord

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub


   
    Private Sub ID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ID.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub fetch_ID()
        sqlcmd.CommandText = "select * FROM studentdata Where (id = '" & ID.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            firstname.Text = daMyname.Item("firstname")
            mname.Text = daMyname.Item("mname")
            surname.Text = daMyname.Item("surname")
            sex.Text = daMyname.Item("sex")
            birthday.Text = daMyname.Item("birthday")
            birthplace.Text = daMyname.Item("birthplace")
            address.Text = daMyname.Item("address")
            address1.Text = daMyname.Item("address1")
            address2.Text = daMyname.Item("address2")
            address3.Text = daMyname.Item("address3")
            telephone.Text = daMyname.Item("telephone")
            mobile.Text = daMyname.Item("mobile")
            religion.Text = daMyname.Item("religion")
            citizenship.Text = daMyname.Item("citizenship")
            father.Text = daMyname.Item("father")
            mother.Text = daMyname.Item("mother")
            guardian.Text = daMyname.Item("guardian")
            guardcontact.Text = daMyname.Item("guardcontact")
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
    End Sub

    Private Sub ID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID.Leave
        If sqlconn.State = ConnectionState.Open Then
            Call fetch_ID()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_ID()
            sqlconn.Close()
        End If
    End Sub

    Private Sub firstname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles firstname.Click
        firstname.ReadOnly = False
    End Sub

    Private Sub firstname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles firstname.Leave
        firstname.ReadOnly = True
    End Sub

    Private Sub mname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mname.Click
        mname.ReadOnly = False
    End Sub

    Private Sub mname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mname.Leave
        mname.ReadOnly = True
    End Sub

    Private Sub surname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles surname.Click
        surname.ReadOnly = False
    End Sub

    Private Sub surname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles surname.Leave
        surname.ReadOnly = True
    End Sub

    Private Sub address_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address.Click
        address.ReadOnly = False
    End Sub

    Private Sub address_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles address.Leave
        address.ReadOnly = True
    End Sub

    Private Sub address1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address1.Click
        address1.ReadOnly = False
    End Sub

    Private Sub address1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles address1.Leave
        address1.ReadOnly = True
    End Sub

    Private Sub address2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address2.Click
        address2.ReadOnly = False
    End Sub

    Private Sub address2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles address2.Leave
        address2.ReadOnly = True
    End Sub

    Private Sub address3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address3.Click
        address3.ReadOnly = False
    End Sub

    Private Sub address3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles address3.Leave
        address3.ReadOnly = True
    End Sub

    Private Sub telephone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles telephone.Click
        telephone.ReadOnly = False
    End Sub

    Private Sub telephone_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles telephone.Leave
        telephone.ReadOnly = True
    End Sub

    Private Sub mobile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mobile.Click
        mobile.ReadOnly = False
    End Sub

    Private Sub mobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mobile.Leave
        mobile.ReadOnly = True
    End Sub

    Private Sub citizenship_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles citizenship.Click
        citizenship.ReadOnly = False
    End Sub

    Private Sub citizenship_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles citizenship.Leave
        citizenship.ReadOnly = True
    End Sub

    Private Sub religion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles religion.Click
        religion.ReadOnly = False
    End Sub

    Private Sub religion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles religion.Leave
        religion.ReadOnly = True
    End Sub

    Private Sub father_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles father.Click
        father.ReadOnly = False
    End Sub

    Private Sub father_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles father.Leave
        father.ReadOnly = True
    End Sub

    Private Sub mother_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mother.Click
        mother.ReadOnly = False
    End Sub

    Private Sub mother_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mother.Leave
        mother.ReadOnly = True
    End Sub

    Private Sub guardian_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles guardian.Click
        guardian.ReadOnly = False
    End Sub

    Private Sub guardian_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles guardian.Leave
        guardian.ReadOnly = True
    End Sub

    Private Sub guardcontact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles guardcontact.Click
        guardcontact.ReadOnly = False
    End Sub

    Private Sub guardcontact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles guardcontact.Leave
        guardcontact.ReadOnly = True
    End Sub

    Private Sub sex_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sex.Click
        sex.ReadOnly = False
    End Sub

    Private Sub sex_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles sex.Leave
        sex.ReadOnly = True
    End Sub

    Private Sub birthday_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthday.Click
        birthday.ReadOnly = False
    End Sub

    Private Sub birthday_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthday.Leave
        birthday.ReadOnly = True
    End Sub

    Private Sub birthplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthplace.Click
        birthplace.ReadOnly = False
    End Sub

    Private Sub birthplace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthplace.Leave
        birthplace.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub update_records()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE studentdata SET firstname = '" & firstname.Text & "', mname = '" & mname.Text & "', surname = '" & surname.Text & "',sex = '" & sex.Text & "', birthday = '" & birthday.Text & "', birthplace = '" & birthplace.Text & "', address = '" & address.Text & "', address1 = '" & address1.Text & "', address2 = '" & address2.Text & "', address3 = '" & address3.Text & "',telephone = '" & telephone.Text & "', mobile = '" & mobile.Text & "',religion = '" & religion.Text & "', citizenship = '" & citizenship.Text & "', father = '" & father.Text & "', mother = '" & mother.Text & "', guardian = '" & guardian.Text & "', guardcontact = '" & guardcontact.Text & "' where ID = '" & ID.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        Dim result = MessageBox.Show("Information Updated. Do you want to modify another records?", "Student Information", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Dispose()
            Dim frm As New modifyrecord
            frm.Show()
        ElseIf result = DialogResult.No Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call update_records()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call update_records()
            sqlconn.Close()
        End If
    End Sub
End Class
