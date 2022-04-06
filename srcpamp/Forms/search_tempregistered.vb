Imports System.Data.SqlClient
Public Class search_tempregistered
    Public frmactive As String
    Dim studid, lrn, middlename, firstname, lastname, gender, placebirth, add3, add2, add1, add, citizen, rel, mob, mail, fs, ff, fm, ms, mf, mm, g As String
    Public importname As String = "ImportName"
    Dim bday As Date

    Private Sub search_tempregistered_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
    Private Sub search_tempregistered_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlserver.connect()
    End Sub


    Private Sub lastname_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchbox.TextChanged
        'Dim cmd As New SqlCommand("select studentID, firstname, mname, surname FROM studentdata Where (firstname like '%" & lastname.Text & "%' or surname like '%" & lastname.Text & "%') ;", sqlconn)
        Dim cmd As New SqlCommand("select * FROM studentdata_temp Where (surname + ' ' + firstname + ' ' + mname like '%" & searchbox.Text & "%' or studentID like '%" & searchbox.Text & "%') ;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "studentdata_temp")) Then

            student.Visible = True
            student.DataSource = ds.Tables(0)

            student.Columns("id").Visible = False
            student.Columns("lrn").Visible = False
            student.Columns("ESCNO").Visible = False
            student.Columns("ExtName").Visible = False
            student.Columns("birthplace").Visible = False
            student.Columns("address").Visible = False
            student.Columns("address1").Visible = False
            student.Columns("address2").Visible = False
            student.Columns("address3").Visible = False
            student.Columns("ZIPCODE").Visible = False
            student.Columns("telephone").Visible = False
            student.Columns("mobile").Visible = False
            student.Columns("email").Visible = False
            student.Columns("religion").Visible = False
            student.Columns("citizenship").Visible = False
            student.Columns("father").Visible = False
            student.Columns("f_firstname").Visible = False
            student.Columns("f_mname").Visible = False
            student.Columns("f_ext").Visible = False
            student.Columns("mother").Visible = False
            student.Columns("m_mname").Visible = False
            student.Columns("m_firstname").Visible = False
            student.Columns("m_ext").Visible = False
            student.Columns("guardian").Visible = False
            student.Columns("guardcontact").Visible = False
            student.Columns("cmbrelation").Visible = False
            student.Columns("remarks").Visible = False
            student.Columns("dateregistered").Visible = False
            student.Columns("pic").Visible = False
            student.Columns("req1").Visible = False
            student.Columns("req2").Visible = False
            student.Columns("req3").Visible = False
            student.Columns("req4").Visible = False
            student.Columns("req5").Visible = False

            student.Columns("studentID").DisplayIndex = 0
            student.Columns("studentID").HeaderText = "StudentID"
            student.Columns("studentID").Width = 90

            student.Columns("surname").DisplayIndex = 1
            student.Columns("surname").HeaderText = "Surname"
            student.Columns("surname").Width = 110

            student.Columns("firstname").DisplayIndex = 2
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
        registration.importname = importname
        registration.temp_sid = studid

        registration.newstudent.Checked = True
        registration.txtLRN.Text = lrn
        registration.surname.Text = lastname
        registration.firstname.Text = firstname
        registration.mname.Text = middlename


        If gender = "Male" Then
            registration.optionMale.Checked = True
            registration.optionFemale.Checked = False
        ElseIf gender = "Female" Then
            registration.optionFemale.Checked = True
            registration.optionMale.Checked = False
        End If

        Dim y As Date = bday
        registration.cmbyear.Text = Format(y, "yyyy")

        Dim d As Date = bday
        registration.cmbday.Text = Format(d, "dd")

        Dim m As Date = bday
        Dim month_temp As String
        month_temp = Format(m, "MM")
        ' registration.TextBox1.Text = Format(m, "MM")

        If month_temp = "01" Then
            registration.cmbMos.Text = "January"
        ElseIf month_temp = "02" Then
            registration.cmbMos.Text = "February"
        ElseIf month_temp = "03" Then
            registration.cmbMos.Text = "March"
        ElseIf month_temp = "04" Then
            registration.cmbMos.Text = "April"
        ElseIf month_temp = "05" Then
            registration.cmbMos.Text = "May"
        ElseIf month_temp = "06" Then
            registration.cmbMos.Text = "June"
        ElseIf month_temp = "07" Then
            registration.cmbMos.Text = "July"
        ElseIf month_temp = "08" Then
            registration.cmbMos.Text = "August"
        ElseIf month_temp = "09" Then
            registration.cmbMos.Text = "September"
        ElseIf month_temp = "10" Then
            registration.cmbMos.Text = "October"
        ElseIf month_temp = "11" Then
            registration.cmbMos.Text = "November"
        ElseIf month_temp = "12" Then
            registration.cmbMos.Text = "December"
        End If
        registration.birthplace.Text = placebirth

        registration.address2.Text = add2
        registration.address1.Text = add1
        registration.address.Text = add
        registration.address3.Text = add3
        registration.citizenship.Text = citizen
        registration.religion.Text = rel
        'registration.mobile.Text = mob
        Dim mdigit As String = mob(0)

        If mdigit = "0" Then
            registration.mobile.Text = mob
        Else
            Dim updatedmobile As String = "0" & mob
            registration.mobile.Text = updatedmobile
        End If

        registration.txtEmail.Text = mail
        registration.father.Text = fs
        registration.f_firstname.Text = ff
        registration.f_mname.Text = fm
        registration.mother.Text = ms
        registration.m_firstname.Text = mf
        registration.m_mname.Text = mm
        registration.guardian.Text = g

        registration.Show()


        'If frmactive = "Registration" Then
        '    registration.oldstudent.Checked = True
        '    registration.newstudent.Checked = False
        '    registration.studid.Text = studentID.Text
        '    Me.Dispose()
        'ElseIf frmactive = "studentfile" Then
        '    studentfile.studid.Text = studentID.Text
        '    Me.Dispose()
        'ElseIf frmactive = "studentfileBE" Then
        '    studentfileBE.studid.Text = studentID.Text
        '    Me.Dispose()
        'End If
    End Sub

    Private Sub student_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles student.CellEnter
        Dim sid As String = student.CurrentRow.Cells("studentID").Value.ToString
        studid = sid

        Dim gn As String = student.CurrentRow.Cells("guardian").Value.ToString
        g = gn

        Dim f1 As String = student.CurrentRow.Cells("father").Value.ToString
        fs = f1

        Dim f2 As String = student.CurrentRow.Cells("f_firstname").Value.ToString
        ff = f2

        Dim f3 As String = student.CurrentRow.Cells("f_mname").Value.ToString
        fm = f3

        Dim m1 As String = student.CurrentRow.Cells("mother").Value.ToString
        ms = m1

        Dim m2 As String = student.CurrentRow.Cells("m_firstname").Value.ToString
        mf = m2

        Dim m3 As String = student.CurrentRow.Cells("m_mname").Value.ToString
        mm = m3

        Dim em As String = student.CurrentRow.Cells("email").Value.ToString
        mail = em

        Dim myVariable As String = student.CurrentRow.Cells("lrn").Value.ToString
        lrn = myVariable

        Dim fname As String = student.CurrentRow.Cells("firstname").Value.ToString
        firstname = fname

        Dim lname As String = student.CurrentRow.Cells("surname").Value.ToString
        lastname = lname

        Dim mname As String = student.CurrentRow.Cells("mname").Value.ToString
        middlename = mname

        Dim sex As String = student.CurrentRow.Cells("sex").Value.ToString
        gender = sex

        Dim bd As String = student.CurrentRow.Cells("birthday").Value.ToString
        bday = bd

        Dim pbirth As String = student.CurrentRow.Cells("birthplace").Value.ToString
        placebirth = pbirth

        Dim province As String = student.CurrentRow.Cells("address3").Value.ToString
        add3 = province

        Dim municipality As String = student.CurrentRow.Cells("address2").Value.ToString
        add2 = municipality

        Dim barrio As String = student.CurrentRow.Cells("address1").Value.ToString
        add1 = barrio


        Dim street As String = student.CurrentRow.Cells("address").Value.ToString
        add = street

        Dim cit As String = student.CurrentRow.Cells("citizenship").Value.ToString
        citizen = cit

        Dim r As String = student.CurrentRow.Cells("religion").Value.ToString
        rel = r

        Dim m As String = student.CurrentRow.Cells("mobile").Value.ToString
        mob = m


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