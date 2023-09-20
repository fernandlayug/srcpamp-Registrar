Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class registration
    Dim table_id As Integer
    Dim domainname As String
    Dim f, m As String
    Public importname As String
    Public temp_sid As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub fetch_sy()
        Dim cmdsy As New SqlCommand("Select * FROM sy order by sy DESC;", sqlconn)
        Dim adptsy As New SqlDataAdapter(cmdsy)
        Dim ds_sy As New DataSet

        If (adptsy.Fill(ds_sy, "sy")) Then
            'ds_sy.Tables(0).Rows.InsertAt(ds_sy.Tables(0).NewRow(), 0)

            p_sy.DataSource = ds_sy.Tables(0)
            p_sy.ValueMember = "sy"
            p_sy.DisplayMember = "sy"

        End If
    End Sub
    Private Sub registration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.Alt + Keys.M Then
            If NomName.Checked = True Then
                mname.ReadOnly = True
            ElseIf NomName.Checked = False And oldstudent.Checked = True Then
                mname.ReadOnly = True
            ElseIf NomName.Checked = False And newstudent.Checked = True Then
                mname.ReadOnly = False

            End If
        End If


        If e.KeyCode = Keys.F1 Then
            newstudent.Checked = True
            oldstudent.Checked = False
            Call newstudentOption()
            surname.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            newstudent.Checked = False
            oldstudent.Checked = True
            Call oldstudentOption()
        ElseIf e.KeyCode = Keys.F3 Then
            searchid.frmactive = "Registration"
            searchid.ShowDialog()
        ElseIf e.KeyCode = Keys.F4 Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F5 Then
            Call finalize_records()
        ElseIf e.KeyCode = Keys.F6 Then
            If studid.Text = "" Then
                MessageBox.Show("No Records to Update.")
            Else
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
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            father_guardian.Checked = True
        ElseIf e.KeyCode = Keys.F10 Then
            mother_guardian.Checked = True

        End If
    End Sub
    Private Sub fetch_province()
        Dim cmd As New SqlCommand("select province FROM addresslist group by province order by province ASC;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address3.DataSource = ds.Tables(0)
            address3.ValueMember = "province"
            address3.DisplayMember = "province"
        End If
    End Sub
    Private Sub fetch_city()
        Dim cmd As New SqlCommand("select city FROM addresslist where province = '" & address3.Text & "'  group by city;", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address2.DataSource = ds.Tables(0)
            address2.ValueMember = "city"
            address2.DisplayMember = "city"
        End If
    End Sub
    Private Sub fetch_barrio()
        Dim cmd As New SqlCommand("select barrio FROM addresslist where province = '" & address3.Text & "' AND city = '" & address2.Text & "';", sqlconn)
        Dim adpt As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        If (adpt.Fill(ds, "addresslist")) Then

            ds.Tables(0).Rows.InsertAt(ds.Tables(0).NewRow(), 0)

            address1.DataSource = ds.Tables(0)
            address1.ValueMember = "barrio"
            address1.DisplayMember = "barrio"
        End If
    End Sub

    Private Sub registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        domainname = "@srcpamp.com"
        sqlserver.connect()

        datetoday.Text = Format(Now, "short Date")
        ' p_sy.Text = Main.SY.Text


        Dim increment As Double

        increment = 1

        Try
            sqlcmd.CommandText = "select top 1 * FROM studentdata ORDER BY ID DESC;"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()
                last_eid.Text = daMyname.Item("ID")

                sqlconn.Close()


            End If
        Catch ex As Exception

        End Try


        Dim y As Date = datetoday.Text
        Dim CurrentYear As String
        CurrentYear = Format(y, "yy")


        Try
            Dim lastid As Double = last_eid.Text
            Dim student As Double
            Dim studentsequenceID As String
            student = 0 + lastid + increment

            studentsequenceID = student.ToString.PadLeft(7, "0"c)

            studentid.Text = CurrentYear + "-" + studentsequenceID
        Catch ex As Exception

        End Try


        CenterToScreen()



        If importname = "ImportName" Then
        Else
            ' Call Provinces
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_province()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_province()
                sqlconn.Close()
            End If
        End If

        If oldstudent.Checked = False And newstudent.Checked = False Then
            personalinfo.Enabled = False
            studid.Enabled = False
            txtLRN.Enabled = False

            btnUpdate.Enabled = False

        Else
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_sy()
            sqlconn.Close()
        End If
    End Sub



    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Dim sqlQRY As String = "SELECT * FROM studentdata where id = '" & TextBox1.Text & "'"
        Dim sqlQRY As String = "select * FROM studentdata Where (firstname = '" & firstname.Text & "') and (mname = '" & mname.Text & "') and (surname = '" & surname.Text & "')and (sex = '" & sex.Text & "')and (birthday = '" & birthday.Text & "');"

        Dim cmdExec As SqlCommand = New SqlCommand(sqlQRY, sqlconn)

        'create data adapter
        Dim da As SqlDataAdapter = New SqlDataAdapter(sqlQRY, sqlconn)

        'create dataset
        Dim ds As DataSet = New DataSet

        'fill dataset
        da.Fill(ds, "studentdata")

        Dim Report As Form2 = New Form2

        Dim mReport As CrystalReport1 = New CrystalReport1

        mReport.SetDataSource(ds)

        Report.CrystalReportViewer1.ReportSource = mReport

        Report.ShowDialog()

        Me.Dispose()

    End Sub
    Private Sub newstudentOption()
        If newstudent.Checked = True Then

            Call newstudentcontrols()
            Call clear_controls()

            address3.Text = "PAMPANGA"
            submit.Text = "Register"
            citizenship.Text = "FILIPINO"
            txtLRN.Enabled = True
            txtLRN.ReadOnly = False
            txtESC.ReadOnly = False
            txtLRN.Focus()



            SendMessage(Me.txtLRN.Handle, &H1501, 0, "Learner's Reference Number")
            SendMessage(Me.surname.Handle, &H1501, 0, "Surname")
            SendMessage(Me.firstname.Handle, &H1501, 0, "Firstname")
            SendMessage(Me.mname.Handle, &H1501, 0, "MiddleName")
            SendMessage(Me.ExtName.Handle, &H1501, 0, "Extension Name")

            SendMessage(Me.address.Handle, &H1501, 0, "House No. / Zone / Street /  Village")

            SendMessage(Me.birthplace.Handle, &H1501, 0, "Place of Birth")

            SendMessage(Me.txtEmail.Handle, &H1501, 0, "Email Address")
            SendMessage(Me.religion.Handle, &H1501, 0, "Religion")

            SendMessage(Me.father.Handle, &H1501, 0, "Father's Surname")
            SendMessage(Me.f_firstname.Handle, &H1501, 0, "Father's Given Name")
            SendMessage(Me.f_mname.Handle, &H1501, 0, "Father's Middle Name")

            SendMessage(Me.mother.Handle, &H1501, 0, "Mother's Maiden Surname")
            SendMessage(Me.m_firstname.Handle, &H1501, 0, "Mother's Given Name")
            SendMessage(Me.m_mname.Handle, &H1501, 0, "Mother's Maiden Middle Name")
        Else
            Call clear_controls()
            Call noselected()

            oldstudent.Enabled = True
            studid.Enabled = False
            submit.Text = ""
            txtLRN.ReadOnly = True
        End If
    End Sub
    Private Sub newstudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newstudent.CheckedChanged
        Call newstudentOption()

    End Sub
    Private Sub oldstudentOption()
        If oldstudent.Checked = True Then
            Call oldstudnetcontrolsNoUPDATE()
            txtLRN.Enabled = True
            studid.Text = ""
            studid.Focus()
            submit.Text = "Enroll"

        ElseIf oldstudent.Checked = False Then
            Call clear_controls()
            Call noselected()

            studid.Enabled = False
            newstudent.Enabled = True
            submit.Text = ""
            studid.Text = ""
        End If
    End Sub
    Private Sub oldstudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oldstudent.CheckedChanged
        Call oldstudentOption()
    End Sub
    Private Sub fetch_last_id()
        Try
            sqlcmd.CommandText = "select top 1 * FROM studentdata ORDER BY ID DESC;"
            sqlcmd.Connection = sqlconn
            Dim daMyname As SqlDataReader
            daMyname = sqlcmd.ExecuteReader()
            If daMyname.HasRows Then
                daMyname.Read()

                last_eid.Text = daMyname.Item("ID")

            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub generate_id()

        Dim increment As Double

        increment = 1

        Dim y As Date = datetoday.Text
        Dim CurrentYear As String
        CurrentYear = Format(y, "yy")

        Try
            Dim lastid As Double = last_eid.Text
            Dim student As Double
            Dim studentsequenceID As String
            student = 0 + lastid + increment

            studentsequenceID = student.ToString.PadLeft(7, "0"c)

            studentid.Text = CurrentYear + "-" + studentsequenceID

            table_id = lastid + 1
        Catch ex As Exception

        End Try

    End Sub
    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_last_id()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_last_id()
            sqlconn.Close()
        End If

        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call generate_id()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call generate_id()
            sqlconn.Close()
        End If

        Call finalize_records()



    End Sub

    Private Sub finalize_records()
        If submit.Text = "Enroll" Then
            admissionFrm.studid.Text = studid.Text
            admissionFrm.ShowDialog()
            Me.Dispose()
        ElseIf submit.Text = "Register" Then

            Dim sqlcmd As New SqlClient.SqlCommand

            Dim ms As New MemoryStream()

            picstudent.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@picstudent", SqlDbType.Image)
            p.Value = data
            sqlcmd.Parameters.Add(p)


            Dim r As String = "Registered"

            strsql = " INSERT into studentdata ([id],[studentid],[lrn],[ESCNO],[firstname],[mname],[surname],[ExtName], " & _
                "[sex],[birthday],[birthplace],[address],[address1],[address2],[address3], " & _
                "[telephone],[mobile],[email],[religion],[citizenship], " & _
                "[father], [f_firstname], [f_mname],[f_ext],[mother],[m_firstname], [m_mname], [m_ext], " & _
                "[guardian],[guardcontact], [cmbrelation], [pic],[remarks], [dateregistered]) values ('" & table_id & "','" & studentid.Text & "', " & _
                "'" & txtLRN.Text & "','" & txtESC.Text & "','" & firstname.Text & "','" & mname.Text & "','" & surname.Text & "', " & _
                "'" & ExtName.Text & "'," & _
                "'" & sex.Text & "','" & birthday.Text & "','" & birthplace.Text & "', " & _
                "'" & address.Text & "','" & address1.Text & "','" & address2.Text & "','" & address3.Text & "'," & _
                "'" & telephone.Text & "','" & mobile.Text & "','" & txtEmail.Text & "','" & religion.Text & "','" & citizenship.Text & "'," & _
                "'" & father.Text & "','" & f_firstname.Text & "','" & f_mname.Text & "','" & f_ext.Text & "'," & _
                "'" & mother.Text & "','" & m_firstname.Text & "','" & m_mname.Text & "','" & m_ext.Text & "'," & _
                "'" & guardian.Text & "','" & guardcontact.Text & "', " & _
                "'" & cmbrelation.Text & "', @picstudent,'" & r & "','" & datetoday.Text & "')"

            If String.IsNullOrEmpty(firstname.Text) Then
                MessageBox.Show("Please enter your Firstname")
                firstname.Focus()
            ElseIf String.IsNullOrEmpty(mname.Text) And NomName.Checked = False Then
                MessageBox.Show("Please enter your MiddleName")
                mname.Focus()
            ElseIf String.IsNullOrEmpty(surname.Text) Then
                MessageBox.Show("Please enter your Surname")
                surname.Focus()
            ElseIf String.IsNullOrEmpty(sex.Text) Then
                MessageBox.Show("Please enter your Gender")
                sex.Focus()
                'ElseIf String.IsNullOrEmpty(birthday.Text) Then
            ElseIf birthday.Text = "  /  /" Then
                MessageBox.Show("Please enter your Birthday")
                birthday.Focus()
            ElseIf String.IsNullOrEmpty(birthplace.Text) Then
                MessageBox.Show("Please enter your Birthplace")
                birthplace.Focus()
            ElseIf String.IsNullOrEmpty(address.Text) Then
                MessageBox.Show("Please enter your Address")
                address.Focus()
                'ElseIf String.IsNullOrEmpty(mobile.Text) Then
            ElseIf mobile.Text = "(    )    -" Then
                MessageBox.Show("Please enter your Mobile Number")
                mobile.Focus()
            ElseIf String.IsNullOrEmpty(religion.Text) Then
                MessageBox.Show("Please enter your Religion")
                religion.Focus()
            ElseIf String.IsNullOrEmpty(citizenship.Text) Then
                MessageBox.Show("Please enter your Citizenship")
                citizenship.Focus()
            ElseIf String.IsNullOrEmpty(father.Text) Then
                MessageBox.Show("Please enter your Father Name")
                father.Focus()
            ElseIf String.IsNullOrEmpty(mother.Text) Then
                MessageBox.Show("Please enter your Mother Name")
                mother.Focus()
            ElseIf String.IsNullOrEmpty(guardian.Text) Then
                MessageBox.Show("Please enter your Guardian Name")
                guardian.Focus()
            ElseIf String.IsNullOrEmpty(guardcontact.Text) Then
                MessageBox.Show("Please enter your Guardian Contact No.")
                guardcontact.Focus()
            ElseIf String.IsNullOrEmpty(p_sy.Text) Then
                MessageBox.Show("Please enter School Year")
                p_sy.Focus()

            Else

                Dim result = MessageBox.Show("Are you sure you want to submit the Information?", "Student Information", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    'command to check if already registered
                    sqlconn.Open()

                    sqlcmd.CommandText = "select * FROM studentdata Where (firstname = '" & firstname.Text & "') and (mname = '" & mname.Text & "') and (surname = '" & surname.Text & "')and (sex = '" & sex.Text & "') and (birthday = '" & birthday.Text & "');"
                    sqlcmd.Connection = sqlconn

                    Dim daMyname2 As SqlDataReader


                    daMyname2 = sqlcmd.ExecuteReader()

                    If daMyname2.HasRows Then


                        MessageBox.Show("You are already Registered.  For assisstance please see the administrator.")

                        Me.Dispose()

                        'command para insert ang mga data
                    Else
                        sqlconn.Close()
                        Me.Refresh()
                        sqlconn.Open()
                        sqlcmd.CommandText = strsql
                        sqlcmd.Connection = sqlconn
                        sqlcmd.ExecuteNonQuery()


                        sqlcmd.CommandText = "select * FROM studentdata Where (firstname = '" & firstname.Text & "') and (mname = '" & mname.Text & "') and (surname = '" & surname.Text & "') " & _
                            " and (sex = '" & sex.Text & "') and (birthday = '" & birthday.Text & "');"
                        sqlcmd.Connection = sqlconn
                        Dim daMyname As SqlDataReader
                        daMyname = sqlcmd.ExecuteReader()
                        If daMyname.HasRows Then
                            daMyname.Read()
                            id.Text = daMyname.Item("studentID")
                            student.Text = daMyname.Item("firstname")
                        End If
                        sqlconn.Close()

                        'Show the Form for registered
                        registeredinfo.student.Text = Me.firstname.Text
                        registeredinfo.id.Text = Me.id.Text
                        registeredinfo.picbarcode.BackgroundImage = Code128(id.Text, "A")
                        registeredinfo.ShowDialog()
                        Me.Dispose()
                        Me.Dispose()

                        If importname = "ImportName" Then
                            If sqlconn.State = ConnectionState.Open Then
                                sqlconn.Close()
                                sqlconn.Open()
                                Call delete_temporary_id()
                                sqlconn.Close()
                            Else
                                sqlconn.Open()
                                Call delete_temporary_id()
                                sqlconn.Close()
                            End If
                        Else

                        End If


                    End If
                ElseIf result = DialogResult.No Then
                    firstname.Text = ""
                    mname.Text = ""
                    surname.Text = ""
                    sex.Text = ""
                    birthday.Text = ""
                    birthplace.Text = ""
                    address.Text = ""
                    telephone.Text = ""
                    mobile.Text = ""
                    religion.Text = ""
                    citizenship.Text = ""
                    father.Text = ""
                    mother.Text = ""
                    guardian.Text = ""

                ElseIf result = DialogResult.Cancel Then
                    MessageBox.Show("Please check all the information")
                    sqlconn.Close()
                End If
            End If

        End If

    End Sub
    Private Sub fetch_studentData()
        sqlcmd.CommandText = "select * FROM studentdata Where (studentID = '" & studid.Text & "');"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            Dim bdate As Date
          
            mname.Text = daMyname.Item("mname")
            surname.Text = daMyname.Item("surname")
            ExtName.Text = daMyname.Item("extname")
            sex.Text = daMyname.Item("sex")
            txtLRN.Text = daMyname.Item("lrn")
            txtESC.Text = daMyname.Item("ESCNO")
            bdate = daMyname.Item("birthday")
            '  birthday.Text = bdate
            bdateOLD.Text = bdate
            firstname.Text = daMyname.Item("firstname")
            birthplace.Text = daMyname.Item("birthplace")
            address.Text = daMyname.Item("address")
            address1.Text = daMyname.Item("address1")
            address2.Text = daMyname.Item("address2")
            address3.Text = daMyname.Item("address3")
            telephone.Text = daMyname.Item("telephone")
            mobile.Text = daMyname.Item("mobile")
            txtEmail.Text = daMyname.Item("email")
            citizenship.Text = daMyname.Item("citizenship")
            religion.Text = daMyname.Item("religion")
            father.Text = daMyname.Item("father")
            f_firstname.Text = daMyname.Item("f_firstname")
            f_mname.Text = daMyname.Item("f_mname")
            mother.Text = daMyname.Item("mother")
            m_firstname.Text = daMyname.Item("m_firstname")
            m_mname.Text = daMyname.Item("m_mname")
            'mobile.Enabled = False
            guardian.Text = daMyname.Item("guardian")
            guardcontact.Text = daMyname.Item("guardcontact")
            cmbrelation.Text = daMyname.Item("cmbrelation")
            'guardian.Enabled = False
        
        Else
            Dim bdate As String
            firstname.Text = ""
            'firstname.Enabled = False
            mname.Text = ""
            'mname.Enabled = False
            surname.Text = ""
            'surname.Enabled = False
            sex.Text = ""
            'sex.Enabled = False
            bdate = "__/__/____"
            birthday.Text = bdate
            bdateOLD.Text = bdate
            'birthday.Enabled = False
            birthplace.Text = ""
            address.Text = ""
            address1.Text = ""
            address2.Text = ""
            address3.Text = ""
            telephone.Text = ""
            mobile.Text = ""
            citizenship.Text = ""
            religion.Text = ""
            father.Text = ""
            mother.Text = ""
            'mobile.Enabled = False
            guardian.Text = ""
            guardcontact.Text = ""
        End If


    End Sub

    Private Sub studid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles studid.Leave, studid.TextChanged
        If newstudent.Checked = True Then
        ElseIf oldstudent.Checked = True Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call fetch_studentData()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call fetch_studentData()
                sqlconn.Close()
            End If

            If mname.Text = "" Then
                NomName.Checked = True
                NomName.Enabled = False
            ElseIf mname.Text = " " Then
                NomName.Checked = True
                NomName.Enabled = False
            ElseIf mname.Text = String.Empty = False Then
                NomName.Checked = False
                NomName.Enabled = False
            End If


        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
    Private Sub father_guardian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles father_guardian.CheckedChanged
        Dim m As String = f_mname.Text
        Dim m2 As String
        Dim mi As String

        If father_guardian.Checked = True Then
            If f_mname.Text = String.Empty = False Then
                m2 = m.Substring(0, 1)
                mi = m2 + "."
                guardian.Text = f_firstname.Text + " " + mi + " " + father.Text + " " + f_ext.Text
                cmbrelation.Text = "PARENT"
                guardcontact.Focus()
            ElseIf f_mname.Text = String.Empty = True Then
                mi = ""
                guardian.Text = f_firstname.Text + "" + mi + " " + father.Text + " " + f_ext.Text
                cmbrelation.Text = "PARENT"
                guardcontact.Focus()
            End If

        Else
            guardian.Text = ""
            cmbrelation.Text = ""
        End If
    End Sub

    Private Sub mother_guardian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mother_guardian.CheckedChanged
        Dim m As String = m_mname.Text
        Dim m2 As String
        Dim mi As String

        If mother_guardian.Checked = True Then
            If m_mname.Text = String.Empty = False Then
                m2 = m.Substring(0, 1)
                mi = m2 + "."
                guardian.Text = m_firstname.Text + " " + mi + " " + mother.Text + " " + m_ext.Text
                cmbrelation.Text = "PARENT"
                guardcontact.Focus()
            ElseIf f_mname.Text = String.Empty = True Then
                mi = ""
                guardian.Text = m_firstname.Text + "" + mi + " " + mother.Text + " " + m_ext.Text
                cmbrelation.Text = "PARENT"
                guardcontact.Focus()
            End If

        Else
            guardian.Text = ""
            cmbrelation.Text = ""
        End If
    End Sub

    Private Sub mobile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mobile.Leave
        txtEmail.Focus()
    End Sub

    Private Sub txtEmail_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.Leave
        religion.Focus()
    End Sub
    Private Sub religion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles religion.Enter
        religion.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub religion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles religion.Leave
        If religion.Text = "" Then
            father.Focus()
            religion.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.religion.Handle, &H1501, 0, "Religion")

        Else
            father.Focus()
        End If

    End Sub

    Private Sub father_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles father.Enter
        father.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub father_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles father.Leave
        If father.Text = "" Then
            f_firstname.Focus()
            father.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.father.Handle, &H1501, 0, "Father's Surname")

        Else
            f_firstname.Focus()
        End If

    End Sub
    Private Sub f_firstname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_firstname.Enter
        f_firstname.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub f_firstname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_firstname.Leave
        If f_firstname.Text = "" Then
            f_mname.Focus()
            f_firstname.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.f_firstname.Handle, &H1501, 0, "Father's Given Name")

        Else
            f_mname.Focus()
        End If
    End Sub
    Private Sub f_mname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_mname.Enter
        f_mname.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub f_mname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_mname.Leave
        If f_mname.Text = "" Then
            mother.Focus()
            f_mname.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.f_mname.Handle, &H1501, 0, "Father's Middle Name")
        Else
        End If

    End Sub
    Private Sub mother_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles mother.Enter
        mother.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub mother_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mother.Leave
        If mother.Text = "" Then
            m_firstname.Focus()
            mother.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.mother.Handle, &H1501, 0, "Mother's Maiden Surname")

        Else
            m_firstname.Focus()
        End If

    End Sub
    Private Sub m_firstname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_firstname.Enter
        m_firstname.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub m_firstname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_firstname.Leave
        If m_firstname.Text = "" Then
            m_mname.Focus()
            m_firstname.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.m_firstname.Handle, &H1501, 0, "Mother's Given Name")

        Else
            m_mname.Focus()
        End If

    End Sub
    Private Sub m_mname_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_mname.Enter
        m_mname.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub m_mname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_mname.Leave
        If m_mname.Text = "" Then
            guardian.Focus()
            m_mname.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.m_mname.Handle, &H1501, 0, "Mother's Middle Maiden Name")

        Else
            guardian.Focus()
        End If

    End Sub
    Private Sub guardcontact_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles guardcontact.Leave
        cmbrelation.Focus()
    End Sub

    Private Sub cmbrelation_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbrelation.Leave
        submit.Focus()
    End Sub

    Private Sub cmbday_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbday.Leave
        If cmbday.Text.Length = 1 Then
            Dim z As String = "0"
            cmbday.Text = z + cmbday.Text
        End If
    End Sub
    Private Sub cmbyear_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbyear.Leave
        If cmbyear.Text.Length <= 3 Then
            MessageBox.Show("Please enter year in format YYYY. i.e: 1970 ")
            cmbyear.Focus()
        Else

        End If
    End Sub
    Private Sub cmbMos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMos.TextChanged, cmbday.TextChanged, cmbyear.TextChanged

        If cmbMos.Text = "January" Then
            Dim jan As String = "01"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "February" Then
            Dim jan As String = "02"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "March" Then
            Dim jan As String = "03"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "April" Then
            Dim jan As String = "04"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "May" Then
            Dim jan As String = "05"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "June" Then
            Dim jan As String = "06"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "July" Then
            Dim jan As String = "07"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "August" Then
            Dim jan As String = "08"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "September" Then
            Dim jan As String = "09"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "October" Then
            Dim jan As String = "10"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "November" Then
            Dim jan As String = "11"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y
        ElseIf cmbMos.Text = "December" Then
            Dim jan As String = "12"
            Dim d As String = cmbday.Text
            Dim y As String = cmbyear.Text
            birthday.Text = jan + d + y

        End If
    End Sub

    Private Sub address2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address2.Enter
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_city()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_city()
            sqlconn.Close()
        End If
    End Sub

    Private Sub address1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles address1.Enter
        If sqlconn.State = ConnectionState.Open Then
            sqlconn.Close()
            sqlconn.Open()
            Call fetch_barrio()
            sqlconn.Close()
        Else
            sqlconn.Open()
            Call fetch_barrio()
            sqlconn.Close()
        End If
    End Sub

    Private Sub mname_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mname.Leave, mname.TextChanged
        If mname.Text = String.Empty = False Then
            NomName.Enabled = False
        ElseIf mname.Text = String.Empty = True Then
            NomName.Enabled = True

        End If

        If firstname.Text = "" Then
            f = ""
        Else
            Dim fn = firstname.Text
            f = fn(0)
        End If

        If mname.Text = "" Then
            m = ""
        Else
            Dim mi = mname.Text
            m = mi(0)
        End If


        txtEmail.Text = f + m + "." + surname.Text + domainname
    End Sub
    Private Sub bdateOLD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bdateOLD.TextChanged
        Try
            Dim m As Date = bdateOLD.Text
            cmbMos.Text = Format(m, "MMMM")

            Dim d As Date = bdateOLD.Text
            cmbday.Text = Format(d, "dd")

            Dim y As Date = bdateOLD.Text
            cmbyear.Text = Format(y, "yyyy")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sex_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sex.TextChanged
        If sex.Text = "Female" Then
            optionFemale.Checked = True
        ElseIf sex.Text = "" Then
            optionMale.Checked = False
            optionFemale.Checked = False
        ElseIf sex.Text = "Male" Then
            optionMale.Checked = True
        End If
    End Sub


    Private Sub birthplace_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthplace.Enter
        birthplace.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub birthplace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles birthplace.Leave
        If birthplace.Text = "" Then
            birthplace.CharacterCasing = CharacterCasing.Normal
            SendMessage(Me.birthplace.Handle, &H1501, 0, "Place of Birth")
        Else
            address2.Focus()
        End If

    End Sub

    Private Sub NomName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomName.CheckedChanged
        If NomName.Checked = True Then
            mname.ReadOnly = True
        ElseIf NomName.Checked = False And oldstudent.Checked = True Then
            mname.ReadOnly = True
        ElseIf NomName.Checked = False And newstudent.Checked = True Then
            mname.ReadOnly = False

        End If
    End Sub
    Private Sub noselected()
        personalinfo.Enabled = False
        studid.Enabled = False
        txtLRN.Enabled = False

        btnUpdate.Enabled = False
    End Sub
    Private Sub oldstudnetcontrols()
        personalinfo.Enabled = True
        parentguardian.Enabled = False
        studid.Enabled = True
        newstudent.Enabled = False
        btnUpdate.Enabled = True

        txtLRN.ReadOnly = False
        txtESC.ReadOnly = False
        address.ReadOnly = False
        telephone.ReadOnly = False
        mobile.ReadOnly = False
        txtEmail.ReadOnly = False
        religion.ReadOnly = False
        surname.ReadOnly = False
        firstname.ReadOnly = False
        mname.ReadOnly = False
        ExtName.ReadOnly = False
        NomName.Enabled = True
        optionMale.Enabled = True
        optionFemale.Enabled = True
        cmbMos.Enabled = True
        cmbday.Enabled = True
        cmbyear.Enabled = True
        birthplace.ReadOnly = False
        citizenship.ReadOnly = False
        father.ReadOnly = False
        f_firstname.ReadOnly = False
        f_mname.ReadOnly = False
        f_ext.ReadOnly = False
        mother.ReadOnly = False
        m_firstname.ReadOnly = False
        m_mname.ReadOnly = False
        m_ext.ReadOnly = False
        guardian.ReadOnly = False
        guardcontact.ReadOnly = False
    End Sub
    Private Sub oldstudnetcontrolsNoUPDATE()
        personalinfo.Enabled = True
        parentguardian.Enabled = False
        studid.Enabled = True
        newstudent.Enabled = False
        btnUpdate.Enabled = True

        txtLRN.ReadOnly = True
        txtESC.ReadOnly = True
        address.ReadOnly = True
        telephone.ReadOnly = True
        mobile.ReadOnly = True
        txtEmail.ReadOnly = True
        religion.ReadOnly = True
        surname.ReadOnly = True
        firstname.ReadOnly = True
        mname.ReadOnly = True
        ExtName.ReadOnly = True
        NomName.Enabled = True
        optionMale.Enabled = False
        optionFemale.Enabled = False
        cmbMos.Enabled = False
        cmbday.Enabled = False
        cmbyear.Enabled = False
        birthplace.ReadOnly = True
        citizenship.ReadOnly = True
        father.ReadOnly = True
        f_firstname.ReadOnly = True
        f_mname.ReadOnly = True
        f_ext.ReadOnly = True
        mother.ReadOnly = True
        m_firstname.ReadOnly = True
        m_mname.ReadOnly = True
        m_ext.ReadOnly = True
        guardian.ReadOnly = True
        guardcontact.ReadOnly = True
    End Sub

    Private Sub newstudentcontrols()
        personalinfo.Enabled = True
        parentguardian.Enabled = True
        studid.Enabled = False
        oldstudent.Enabled = False
        btnUpdate.Enabled = False

        surname.ReadOnly = False
        firstname.ReadOnly = False
        mname.ReadOnly = False
        ExtName.ReadOnly = False
        NomName.Enabled = True
        optionMale.Enabled = True
        optionFemale.Enabled = True
        cmbMos.Enabled = True
        cmbday.Enabled = True
        cmbyear.Enabled = True
        birthplace.ReadOnly = False
        citizenship.ReadOnly = False
        father.ReadOnly = False
        f_firstname.ReadOnly = False
        f_mname.ReadOnly = False
        mother.ReadOnly = False
        m_firstname.ReadOnly = False
        m_mname.ReadOnly = False

    End Sub
    Private Sub clear_controls()
        surname.Text = ""
        firstname.Text = ""
        mname.Text = ""
        ExtName.Text = ""
        NomName.Checked = False
        optionMale.Checked = False
        optionFemale.Checked = False
        cmbMos.Text = ""
        cmbday.Text = ""
        cmbyear.Text = ""
        address3.Text = ""
        address2.Text = ""
        address1.Text = ""
        address.Text = ""
        telephone.Text = ""
        mobile.Text = ""
        txtEmail.Text = ""
        birthplace.Text = ""
        citizenship.Text = ""
        religion.Text = ""
        father.Text = ""
        f_firstname.Text = ""
        f_mname.Text = ""
        mother.Text = ""
        m_firstname.Text = ""
        m_mname.Text = ""
        father_guardian.Checked = False
        mother_guardian.Checked = False
        guardian.Text = ""
        guardcontact.Text = ""
        cmbrelation.Text = ""
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If studid.Text = "" Then
            MessageBox.Show("No Records to Update.")
        Else
            If btnUpdate.Text = "Update" Then
                Call oldstudnetcontrols()
                btnUpdate.Text = "Apply"
            ElseIf btnUpdate.Text = "Apply" Then
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
                btnUpdate.Text = "Update"
                Call oldstudnetcontrolsNoUPDATE()
            End If
        End If
    End Sub

    Private Sub optionMale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optionMale.CheckedChanged, optionFemale.CheckedChanged
        If optionMale.Checked = True Then
            sex.Text = "Male"
        ElseIf optionFemale.Checked = True Then
            sex.Text = "Female"
        End If

    End Sub
    Private Sub update_records()

        Dim sqlcmd As New SqlClient.SqlCommand
        strsql = "UPDATE studentdata SET lrn = '" & txtLRN.Text & "', " & _
            "ESCNO = '" & txtESC.Text & "'," & _
            "surname = '" & surname.Text & "', " & _
            "firstname = '" & firstname.Text & "', " & _
            "mname = '" & mname.Text & "', " & _
            "EXTNAME = '" & ExtName.Text & "', " & _
            "sex = '" & sex.Text & "', " & _
            "birthday = '" & birthday.Text & "'," & _
            "birthplace = '" & birthplace.Text & "'," & _
            "citizenship = '" & citizenship.Text & "'," & _
            "address3 = '" & address3.Text & "'," & _
            "address2 = '" & address2.Text & "', " & _
            "address1 = '" & address1.Text & "', " & _
            "address = '" & address.Text & "', " & _
            "telephone = '" & telephone.Text & "', " & _
            "mobile = '" & mobile.Text & "', " & _
            "email = '" & txtEmail.Text & "', " & _
            "religion = '" & religion.Text & "', " & _
            "father = '" & father.Text & "', " & _
            "f_firstname = '" & f_firstname.Text & "', " & _
            "f_mname = '" & f_mname.Text & "', " & _
            "f_ext = '" & f_ext.Text & "', " & _
            "mother = '" & mother.Text & "', " & _
            "m_firstname = '" & m_firstname.Text & "', " & _
            "m_mname = '" & m_mname.Text & "', " & _
            "m_ext = '" & m_ext.Text & "', " & _
            "guardian = '" & guardian.Text & "', " & _
            "guardcontact = '" & guardcontact.Text & "', " & _
            "cmbrelation = '" & cmbrelation.Text & "' where studentID = '" & studid.Text & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
        MessageBox.Show("Records Updated")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        searchid.frmactive = "Registration"
        searchid.ShowDialog()
    End Sub

    Private Sub ExtName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExtName.Leave, NomName.Leave
        optionMale.Focus()
    End Sub


    Private Sub txtLRN_Leave(sender As Object, e As System.EventArgs) Handles txtLRN.Leave
        txtESC.Focus()
    End Sub

    Private Sub txtESC_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtESC.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtESC_Leave(sender As Object, e As System.EventArgs) Handles txtESC.Leave
        surname.Focus()
    End Sub

    Private Sub surname_TextChanged(sender As Object, e As EventArgs) Handles surname.TextChanged
        If newstudent.Checked = True Then
            If firstname.Text = "" Then
                f = ""
            Else
                Dim fn = firstname.Text
                f = fn(0)
            End If

            If mname.Text = "" Then
                m = ""
            Else
                Dim mi = mname.Text
                m = mi(0)
            End If


            txtEmail.Text = f + m + "." + surname.Text + domainname

        ElseIf oldstudent.Checked = True Then
            
        End If

    End Sub

    Private Sub firstname_TextChanged(sender As Object, e As EventArgs) Handles firstname.TextChanged
        If newstudent.Checked = True Then
            If firstname.Text = "" Then
                f = ""
            Else
                Dim fn = firstname.Text
                f = fn(0)
            End If

            If mname.Text = "" Then
                m = ""
            Else
                Dim mi = mname.Text
                m = mi(0)
            End If
            txtEmail.Text = f + m + "." + surname.Text + domainname
        ElseIf oldstudent.Checked = True Then

        End If
    End Sub

    Private Sub verify_email()

        sqlcmd.CommandText = "select * FROM studentdata where email = '" & txtEmail.Text & "';"
        sqlcmd.Connection = sqlconn
        Dim daMyname As SqlDataReader
        daMyname = sqlcmd.ExecuteReader()
        If daMyname.HasRows Then
            daMyname.Read()
            emailnotification.ForeColor = Color.Red
            emailnotification.Text = "Email Address already exist!"
            submit.Enabled = True
        Else
            emailnotification.ForeColor = Color.Green
            emailnotification.Text = txtEmail.Text + " is available"
            submit.Enabled = True
        End If
    End Sub



    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If newstudent.Checked = True Then
            If sqlconn.State = ConnectionState.Open Then
                sqlconn.Close()
                sqlconn.Open()
                Call verify_email()
                sqlconn.Close()
            Else
                sqlconn.Open()
                Call verify_email()
                sqlconn.Close()
            End If
        ElseIf oldstudent.Checked = True Then
            ' If sqlconn.State = ConnectionState.Open Then
            'sqlconn.Close()
            ' sqlconn.Open()
            '  Call verify_email()
            '  sqlconn.Close()
            ' Else
            'sqlconn.Open()
            ' Call verify_email()
            ' sqlconn.Close()
            '  End If
        End If
    End Sub



    Private Sub delete_temporary_id()
        Dim sqlcmd As New SqlClient.SqlCommand
        Dim status As String = "REGISTERED"
        strsql = "Update studentdata_temp set remarks='" & status & "' where studentID = '" & temp_sid & "'"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlcmd.ExecuteNonQuery()
    End Sub


End Class