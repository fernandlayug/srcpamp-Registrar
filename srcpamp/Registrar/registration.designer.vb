<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registration))
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.birthplace = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.citizenship = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.religion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.father = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.mother = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.guardian = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.student = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.MaskedTextBox()
        Me.mobile = New System.Windows.Forms.MaskedTextBox()
        Me.telephone = New System.Windows.Forms.MaskedTextBox()
        Me.guardcontact = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.oldstudent = New System.Windows.Forms.CheckBox()
        Me.newstudent = New System.Windows.Forms.CheckBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.studid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.personalinfo = New System.Windows.Forms.GroupBox()
        Me.emailnotification = New System.Windows.Forms.Label()
        Me.m_ext = New System.Windows.Forms.TextBox()
        Me.f_ext = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExtName = New System.Windows.Forms.TextBox()
        Me.address1 = New System.Windows.Forms.ComboBox()
        Me.address2 = New System.Windows.Forms.ComboBox()
        Me.address3 = New System.Windows.Forms.ComboBox()
        Me.cmbyear = New System.Windows.Forms.ComboBox()
        Me.cmbday = New System.Windows.Forms.ComboBox()
        Me.cmbMos = New System.Windows.Forms.ComboBox()
        Me.optionFemale = New System.Windows.Forms.RadioButton()
        Me.optionMale = New System.Windows.Forms.RadioButton()
        Me.NomName = New System.Windows.Forms.CheckBox()
        Me.parentguardian = New System.Windows.Forms.GroupBox()
        Me.mother_guardian = New System.Windows.Forms.RadioButton()
        Me.father_guardian = New System.Windows.Forms.RadioButton()
        Me.cmbrelation = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.m_mname = New System.Windows.Forms.TextBox()
        Me.f_mname = New System.Windows.Forms.TextBox()
        Me.m_firstname = New System.Windows.Forms.TextBox()
        Me.f_firstname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bdateOLD = New System.Windows.Forms.TextBox()
        Me.p_sy = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.datetoday = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sex = New System.Windows.Forms.TextBox()
        Me.studentid = New System.Windows.Forms.TextBox()
        Me.last_eid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.picbarcode = New System.Windows.Forms.PictureBox()
        Me.picstudent = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtESC = New System.Windows.Forms.TextBox()
        Me.personalinfo.SuspendLayout()
        Me.parentguardian.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'firstname
        '
        Me.firstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(279, 28)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(211, 22)
        Me.firstname.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.firstname, "Enter Firstname here")
        '
        'surname
        '
        Me.surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(65, 28)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(210, 22)
        Me.surname.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.surname, "Enter Surname here")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sex"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(606, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Place of Birth"
        '
        'birthplace
        '
        Me.birthplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthplace.Location = New System.Drawing.Point(730, 60)
        Me.birthplace.Name = "birthplace"
        Me.birthplace.Size = New System.Drawing.Size(234, 23)
        Me.birthplace.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.birthplace, "Enter Place of Birth here")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(698, 98)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(266, 23)
        Me.address.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.address, "Enter House No. here")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Telephone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(300, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Mobile No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Citizenship"
        '
        'citizenship
        '
        Me.citizenship.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.citizenship.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.citizenship.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.citizenship.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.citizenship.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.citizenship.Location = New System.Drawing.Point(156, 159)
        Me.citizenship.Name = "citizenship"
        Me.citizenship.Size = New System.Drawing.Size(228, 23)
        Me.citizenship.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.citizenship, "Enter Citizenship here")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(387, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Religion"
        '
        'religion
        '
        Me.religion.AutoCompleteCustomSource.AddRange(New String() {"Catholic", "Iglesia Ni Cristo", "Born Again", "Jehovas Witness"})
        Me.religion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.religion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.religion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.religion.Location = New System.Drawing.Point(462, 159)
        Me.religion.Name = "religion"
        Me.religion.Size = New System.Drawing.Size(228, 23)
        Me.religion.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.religion, "Enter Religion here")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Father's Name"
        '
        'father
        '
        Me.father.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.father.Location = New System.Drawing.Point(155, 188)
        Me.father.Name = "father"
        Me.father.Size = New System.Drawing.Size(192, 23)
        Me.father.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.father, "Enter Father`s Surname here")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 18)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Mother's Name"
        '
        'mother
        '
        Me.mother.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mother.Location = New System.Drawing.Point(155, 215)
        Me.mother.Name = "mother"
        Me.mother.Size = New System.Drawing.Size(192, 23)
        Me.mother.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.mother, "Enter Mother`s Maiden Surname here")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 18)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Guardian's Name"
        '
        'guardian
        '
        Me.guardian.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.guardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardian.Location = New System.Drawing.Point(155, 244)
        Me.guardian.Name = "guardian"
        Me.guardian.Size = New System.Drawing.Size(300, 23)
        Me.guardian.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.guardian, "Enter Guardian`s Name here")
        '
        'id
        '
        Me.id.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Red
        Me.id.Location = New System.Drawing.Point(911, 78)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(76, 76)
        Me.id.TabIndex = 31
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.id.Visible = False
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.Blue
        Me.submit.Location = New System.Drawing.Point(716, 4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(128, 48)
        Me.submit.TabIndex = 31
        Me.submit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.submit.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(1020, 149)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 41
        Me.student.Visible = False
        '
        'birthday
        '
        Me.birthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.Location = New System.Drawing.Point(473, 51)
        Me.birthday.Mask = "00/00/0000"
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(79, 23)
        Me.birthday.TabIndex = 200
        Me.birthday.TabStop = False
        Me.birthday.Visible = False
        '
        'mobile
        '
        Me.mobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile.Location = New System.Drawing.Point(390, 129)
        Me.mobile.Mask = "(9999) 000-0000"
        Me.mobile.Name = "mobile"
        Me.mobile.Size = New System.Drawing.Size(126, 23)
        Me.mobile.TabIndex = 18
        '
        'telephone
        '
        Me.telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephone.Location = New System.Drawing.Point(104, 128)
        Me.telephone.Mask = "(999) 000-0000"
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(190, 23)
        Me.telephone.TabIndex = 17
        '
        'guardcontact
        '
        Me.guardcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardcontact.Location = New System.Drawing.Point(564, 243)
        Me.guardcontact.Mask = "(9999) 000-0000"
        Me.guardcontact.Name = "guardcontact"
        Me.guardcontact.Size = New System.Drawing.Size(112, 23)
        Me.guardcontact.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(464, 247)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 18)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Contact No:"
        '
        'oldstudent
        '
        Me.oldstudent.AutoSize = True
        Me.oldstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldstudent.Location = New System.Drawing.Point(157, 56)
        Me.oldstudent.Name = "oldstudent"
        Me.oldstudent.Size = New System.Drawing.Size(115, 22)
        Me.oldstudent.TabIndex = 1
        Me.oldstudent.Text = "Old Student"
        Me.oldstudent.UseVisualStyleBackColor = True
        '
        'newstudent
        '
        Me.newstudent.AutoSize = True
        Me.newstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newstudent.Location = New System.Drawing.Point(20, 56)
        Me.newstudent.Name = "newstudent"
        Me.newstudent.Size = New System.Drawing.Size(122, 22)
        Me.newstudent.TabIndex = 2
        Me.newstudent.TabStop = False
        Me.newstudent.Text = "New Student"
        Me.newstudent.UseVisualStyleBackColor = True
        '
        'mname
        '
        Me.mname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.Location = New System.Drawing.Point(493, 28)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(194, 22)
        Me.mname.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.mname, "Enter Middlename here")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 18)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Name"
        '
        'studid
        '
        Me.studid.Enabled = False
        Me.studid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studid.Location = New System.Drawing.Point(108, 81)
        Me.studid.Name = "studid"
        Me.studid.Size = New System.Drawing.Size(199, 24)
        Me.studid.TabIndex = 0
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 18)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Student ID"
        '
        'personalinfo
        '
        Me.personalinfo.Controls.Add(Me.emailnotification)
        Me.personalinfo.Controls.Add(Me.m_ext)
        Me.personalinfo.Controls.Add(Me.f_ext)
        Me.personalinfo.Controls.Add(Me.Label5)
        Me.personalinfo.Controls.Add(Me.Label3)
        Me.personalinfo.Controls.Add(Me.Label2)
        Me.personalinfo.Controls.Add(Me.Label1)
        Me.personalinfo.Controls.Add(Me.ExtName)
        Me.personalinfo.Controls.Add(Me.address1)
        Me.personalinfo.Controls.Add(Me.address2)
        Me.personalinfo.Controls.Add(Me.address3)
        Me.personalinfo.Controls.Add(Me.cmbyear)
        Me.personalinfo.Controls.Add(Me.cmbday)
        Me.personalinfo.Controls.Add(Me.cmbMos)
        Me.personalinfo.Controls.Add(Me.optionFemale)
        Me.personalinfo.Controls.Add(Me.optionMale)
        Me.personalinfo.Controls.Add(Me.NomName)
        Me.personalinfo.Controls.Add(Me.parentguardian)
        Me.personalinfo.Controls.Add(Me.cmbrelation)
        Me.personalinfo.Controls.Add(Me.Label29)
        Me.personalinfo.Controls.Add(Me.m_mname)
        Me.personalinfo.Controls.Add(Me.f_mname)
        Me.personalinfo.Controls.Add(Me.m_firstname)
        Me.personalinfo.Controls.Add(Me.f_firstname)
        Me.personalinfo.Controls.Add(Me.txtEmail)
        Me.personalinfo.Controls.Add(Me.Label16)
        Me.personalinfo.Controls.Add(Me.Label25)
        Me.personalinfo.Controls.Add(Me.Label20)
        Me.personalinfo.Controls.Add(Me.guardcontact)
        Me.personalinfo.Controls.Add(Me.telephone)
        Me.personalinfo.Controls.Add(Me.mobile)
        Me.personalinfo.Controls.Add(Me.Label15)
        Me.personalinfo.Controls.Add(Me.guardian)
        Me.personalinfo.Controls.Add(Me.Label14)
        Me.personalinfo.Controls.Add(Me.mother)
        Me.personalinfo.Controls.Add(Me.Label13)
        Me.personalinfo.Controls.Add(Me.father)
        Me.personalinfo.Controls.Add(Me.Label12)
        Me.personalinfo.Controls.Add(Me.religion)
        Me.personalinfo.Controls.Add(Me.Label11)
        Me.personalinfo.Controls.Add(Me.citizenship)
        Me.personalinfo.Controls.Add(Me.Label10)
        Me.personalinfo.Controls.Add(Me.Label9)
        Me.personalinfo.Controls.Add(Me.Label8)
        Me.personalinfo.Controls.Add(Me.address)
        Me.personalinfo.Controls.Add(Me.Label7)
        Me.personalinfo.Controls.Add(Me.birthplace)
        Me.personalinfo.Controls.Add(Me.Label6)
        Me.personalinfo.Controls.Add(Me.Label4)
        Me.personalinfo.Controls.Add(Me.surname)
        Me.personalinfo.Controls.Add(Me.mname)
        Me.personalinfo.Controls.Add(Me.firstname)
        Me.personalinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personalinfo.Location = New System.Drawing.Point(15, 111)
        Me.personalinfo.Name = "personalinfo"
        Me.personalinfo.Size = New System.Drawing.Size(978, 276)
        Me.personalinfo.TabIndex = 66
        Me.personalinfo.TabStop = False
        Me.personalinfo.Text = "Personal Information"
        '
        'emailnotification
        '
        Me.emailnotification.AutoSize = True
        Me.emailnotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailnotification.ForeColor = System.Drawing.Color.Black
        Me.emailnotification.Location = New System.Drawing.Point(699, 154)
        Me.emailnotification.Name = "emailnotification"
        Me.emailnotification.Size = New System.Drawing.Size(0, 15)
        Me.emailnotification.TabIndex = 569
        '
        'm_ext
        '
        Me.m_ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_ext.Location = New System.Drawing.Point(710, 215)
        Me.m_ext.Name = "m_ext"
        Me.m_ext.Size = New System.Drawing.Size(47, 23)
        Me.m_ext.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.m_ext, "Enter Mother`s Maiden Middle Name here")
        '
        'f_ext
        '
        Me.f_ext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_ext.Location = New System.Drawing.Point(710, 188)
        Me.f_ext.Name = "f_ext"
        Me.f_ext.Size = New System.Drawing.Size(47, 23)
        Me.f_ext.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.f_ext, "Enter Father`s Middle Name here")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(723, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 12)
        Me.Label5.TabIndex = 570
        Me.Label5.Text = "Extension Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(561, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 12)
        Me.Label3.TabIndex = 569
        Me.Label3.Text = "Middle Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 568
        Me.Label2.Text = "Firstname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Surname"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ExtName
        '
        Me.ExtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ExtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtName.Location = New System.Drawing.Point(690, 28)
        Me.ExtName.Name = "ExtName"
        Me.ExtName.Size = New System.Drawing.Size(143, 22)
        Me.ExtName.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ExtName, "Enter Extension Name here")
        '
        'address1
        '
        Me.address1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.address1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.address1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address1.FormattingEnabled = True
        Me.address1.Location = New System.Drawing.Point(496, 98)
        Me.address1.Name = "address1"
        Me.address1.Size = New System.Drawing.Size(192, 24)
        Me.address1.TabIndex = 15
        '
        'address2
        '
        Me.address2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.address2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.address2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address2.FormattingEnabled = True
        Me.address2.Location = New System.Drawing.Point(301, 98)
        Me.address2.Name = "address2"
        Me.address2.Size = New System.Drawing.Size(192, 24)
        Me.address2.TabIndex = 14
        '
        'address3
        '
        Me.address3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address3.FormattingEnabled = True
        Me.address3.Location = New System.Drawing.Point(104, 98)
        Me.address3.Name = "address3"
        Me.address3.Size = New System.Drawing.Size(192, 24)
        Me.address3.TabIndex = 13
        Me.address3.TabStop = False
        '
        'cmbyear
        '
        Me.cmbyear.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.cmbyear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbyear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Items.AddRange(New Object() {"2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966"})
        Me.cmbyear.Location = New System.Drawing.Point(510, 61)
        Me.cmbyear.MaxLength = 4
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(64, 24)
        Me.cmbyear.TabIndex = 11
        '
        'cmbday
        '
        Me.cmbday.AutoCompleteCustomSource.AddRange(New String() {"MALE", "FEMALE"})
        Me.cmbday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbday.FormattingEnabled = True
        Me.cmbday.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbday.Location = New System.Drawing.Point(458, 61)
        Me.cmbday.MaxLength = 2
        Me.cmbday.Name = "cmbday"
        Me.cmbday.Size = New System.Drawing.Size(46, 24)
        Me.cmbday.TabIndex = 10
        '
        'cmbMos
        '
        Me.cmbMos.AutoCompleteCustomSource.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbMos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMos.FormattingEnabled = True
        Me.cmbMos.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMos.Location = New System.Drawing.Point(334, 61)
        Me.cmbMos.Name = "cmbMos"
        Me.cmbMos.Size = New System.Drawing.Size(118, 24)
        Me.cmbMos.TabIndex = 9
        '
        'optionFemale
        '
        Me.optionFemale.AutoSize = True
        Me.optionFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionFemale.Location = New System.Drawing.Point(141, 65)
        Me.optionFemale.Name = "optionFemale"
        Me.optionFemale.Size = New System.Drawing.Size(72, 20)
        Me.optionFemale.TabIndex = 8
        Me.optionFemale.TabStop = True
        Me.optionFemale.Text = "Female"
        Me.optionFemale.UseVisualStyleBackColor = True
        '
        'optionMale
        '
        Me.optionMale.AutoSize = True
        Me.optionMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionMale.Location = New System.Drawing.Point(66, 65)
        Me.optionMale.Name = "optionMale"
        Me.optionMale.Size = New System.Drawing.Size(56, 20)
        Me.optionMale.TabIndex = 7
        Me.optionMale.TabStop = True
        Me.optionMale.Text = "Male"
        Me.optionMale.UseVisualStyleBackColor = True
        '
        'NomName
        '
        Me.NomName.AutoSize = True
        Me.NomName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomName.Location = New System.Drawing.Point(835, 30)
        Me.NomName.Name = "NomName"
        Me.NomName.Size = New System.Drawing.Size(129, 20)
        Me.NomName.TabIndex = 567
        Me.NomName.Text = "No &Middle Name"
        Me.NomName.UseVisualStyleBackColor = True
        '
        'parentguardian
        '
        Me.parentguardian.Controls.Add(Me.mother_guardian)
        Me.parentguardian.Controls.Add(Me.father_guardian)
        Me.parentguardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentguardian.Location = New System.Drawing.Point(759, 178)
        Me.parentguardian.Name = "parentguardian"
        Me.parentguardian.Size = New System.Drawing.Size(212, 61)
        Me.parentguardian.TabIndex = 76
        Me.parentguardian.TabStop = False
        '
        'mother_guardian
        '
        Me.mother_guardian.AutoSize = True
        Me.mother_guardian.Location = New System.Drawing.Point(6, 41)
        Me.mother_guardian.Name = "mother_guardian"
        Me.mother_guardian.Size = New System.Drawing.Size(206, 17)
        Me.mother_guardian.TabIndex = 1
        Me.mother_guardian.TabStop = True
        Me.mother_guardian.Text = "Press F10 if the Mother is the guardian"
        Me.mother_guardian.UseVisualStyleBackColor = True
        '
        'father_guardian
        '
        Me.father_guardian.AutoSize = True
        Me.father_guardian.Location = New System.Drawing.Point(6, 14)
        Me.father_guardian.Name = "father_guardian"
        Me.father_guardian.Size = New System.Drawing.Size(197, 17)
        Me.father_guardian.TabIndex = 0
        Me.father_guardian.TabStop = True
        Me.father_guardian.Text = "Press F9 if the Father is the guardian"
        Me.father_guardian.UseVisualStyleBackColor = True
        '
        'cmbrelation
        '
        Me.cmbrelation.AutoCompleteCustomSource.AddRange(New String() {"PARENT", "GRANDPARENT", "SIBLING", "RELATIVES"})
        Me.cmbrelation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbrelation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbrelation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrelation.FormattingEnabled = True
        Me.cmbrelation.Items.AddRange(New Object() {"PARENT", "GRANDPARENT", "SIBLING", "RELATIVES"})
        Me.cmbrelation.Location = New System.Drawing.Point(772, 242)
        Me.cmbrelation.Name = "cmbrelation"
        Me.cmbrelation.Size = New System.Drawing.Size(192, 24)
        Me.cmbrelation.TabIndex = 30
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(693, 247)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(70, 18)
        Me.Label29.TabIndex = 74
        Me.Label29.Text = "Relation"
        '
        'm_mname
        '
        Me.m_mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_mname.Location = New System.Drawing.Point(546, 215)
        Me.m_mname.Name = "m_mname"
        Me.m_mname.Size = New System.Drawing.Size(158, 23)
        Me.m_mname.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.m_mname, "Enter Mother`s Maiden Middle Name here")
        '
        'f_mname
        '
        Me.f_mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_mname.Location = New System.Drawing.Point(546, 188)
        Me.f_mname.Name = "f_mname"
        Me.f_mname.Size = New System.Drawing.Size(158, 23)
        Me.f_mname.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.f_mname, "Enter Father`s Middle Name here")
        '
        'm_firstname
        '
        Me.m_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m_firstname.Location = New System.Drawing.Point(349, 215)
        Me.m_firstname.Name = "m_firstname"
        Me.m_firstname.Size = New System.Drawing.Size(195, 23)
        Me.m_firstname.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.m_firstname, "Enter Mother`s Given Name here")
        '
        'f_firstname
        '
        Me.f_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_firstname.Location = New System.Drawing.Point(349, 188)
        Me.f_firstname.Name = "f_firstname"
        Me.f_firstname.Size = New System.Drawing.Size(194, 23)
        Me.f_firstname.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.f_firstname, "Enter Father`s Given Name here")
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Blue
        Me.txtEmail.Location = New System.Drawing.Point(585, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(379, 23)
        Me.txtEmail.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtEmail, "Enter Email Address here")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(523, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "E-mail"
        '
        'bdateOLD
        '
        Me.bdateOLD.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.bdateOLD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bdateOLD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.bdateOLD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bdateOLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdateOLD.Location = New System.Drawing.Point(705, 9)
        Me.bdateOLD.Name = "bdateOLD"
        Me.bdateOLD.Size = New System.Drawing.Size(130, 23)
        Me.bdateOLD.TabIndex = 64
        Me.bdateOLD.Visible = False
        '
        'p_sy
        '
        Me.p_sy.Enabled = False
        Me.p_sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_sy.FormattingEnabled = True
        Me.p_sy.Location = New System.Drawing.Point(850, 78)
        Me.p_sy.Name = "p_sy"
        Me.p_sy.Size = New System.Drawing.Size(135, 23)
        Me.p_sy.TabIndex = 22
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(816, 83)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 16)
        Me.Label30.TabIndex = 108
        Me.Label30.Text = "SY"
        '
        'datetoday
        '
        Me.datetoday.Location = New System.Drawing.Point(823, 53)
        Me.datetoday.Name = "datetoday"
        Me.datetoday.Size = New System.Drawing.Size(111, 20)
        Me.datetoday.TabIndex = 212
        Me.datetoday.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(846, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
        Me.Button1.TabIndex = 213
        Me.Button1.TabStop = False
        Me.Button1.Text = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F4"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.sex)
        Me.Panel1.Controls.Add(Me.studentid)
        Me.Panel1.Controls.Add(Me.last_eid)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.bdateOLD)
        Me.Panel1.Location = New System.Drawing.Point(18, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 41)
        Me.Panel1.TabIndex = 214
        '
        'sex
        '
        Me.sex.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.sex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex.Location = New System.Drawing.Point(493, 9)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(78, 23)
        Me.sex.TabIndex = 567
        Me.sex.Visible = False
        '
        'studentid
        '
        Me.studentid.Enabled = False
        Me.studentid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentid.Location = New System.Drawing.Point(593, 3)
        Me.studentid.Name = "studentid"
        Me.studentid.Size = New System.Drawing.Size(108, 29)
        Me.studentid.TabIndex = 567
        Me.studentid.Visible = False
        '
        'last_eid
        '
        Me.last_eid.Enabled = False
        Me.last_eid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_eid.Location = New System.Drawing.Point(300, 7)
        Me.last_eid.Name = "last_eid"
        Me.last_eid.Size = New System.Drawing.Size(106, 29)
        Me.last_eid.TabIndex = 566
        Me.last_eid.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(7, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(390, 31)
        Me.Label17.TabIndex = 215
        Me.Label17.Text = "Registration/Admission Form"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(316, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 18)
        Me.Label18.TabIndex = 565
        Me.Label18.Text = "LRN"
        '
        'txtLRN
        '
        Me.txtLRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.Location = New System.Drawing.Point(365, 80)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.Size = New System.Drawing.Size(199, 24)
        Me.txtLRN.TabIndex = 1
        '
        'picbarcode
        '
        Me.picbarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picbarcode.Location = New System.Drawing.Point(330, 22)
        Me.picbarcode.Name = "picbarcode"
        Me.picbarcode.Size = New System.Drawing.Size(173, 21)
        Me.picbarcode.TabIndex = 52
        Me.picbarcode.TabStop = False
        '
        'picstudent
        '
        Me.picstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picstudent.Image = CType(resources.GetObject("picstudent.Image"), System.Drawing.Image)
        Me.picstudent.Location = New System.Drawing.Point(1231, 12)
        Me.picstudent.Name = "picstudent"
        Me.picstudent.Size = New System.Drawing.Size(111, 87)
        Me.picstudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstudent.TabIndex = 47
        Me.picstudent.TabStop = False
        Me.picstudent.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.picbarcode)
        Me.Panel2.Controls.Add(Me.submit)
        Me.Panel2.Location = New System.Drawing.Point(19, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(977, 57)
        Me.Panel2.TabIndex = 566
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(765, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 18)
        Me.Label19.TabIndex = 567
        Me.Label19.Text = "F5"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(119, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 49)
        Me.Button4.TabIndex = 217
        Me.Button4.TabStop = False
        Me.Button4.Text = "&Old Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(5, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 49)
        Me.Button3.TabIndex = 216
        Me.Button3.TabStop = False
        Me.Button3.Text = "&New Student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(232, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 49)
        Me.Button2.TabIndex = 215
        Me.Button2.TabStop = False
        Me.Button2.Text = "&Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Brown
        Me.btnUpdate.Location = New System.Drawing.Point(592, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 48)
        Me.btnUpdate.TabIndex = 214
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Yellow
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(583, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 18)
        Me.Label21.TabIndex = 568
        Me.Label21.Text = "ESC No"
        '
        'txtESC
        '
        Me.txtESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtESC.Location = New System.Drawing.Point(663, 80)
        Me.txtESC.Name = "txtESC"
        Me.txtESC.Size = New System.Drawing.Size(147, 24)
        Me.txtESC.TabIndex = 567
        '
        'registration
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtESC)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtLRN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datetoday)
        Me.Controls.Add(Me.personalinfo)
        Me.Controls.Add(Me.birthday)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.studid)
        Me.Controls.Add(Me.newstudent)
        Me.Controls.Add(Me.oldstudent)
        Me.Controls.Add(Me.picstudent)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.p_sy)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.id)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.ToolTip1.SetToolTip(Me, "5")
        Me.personalinfo.ResumeLayout(False)
        Me.personalinfo.PerformLayout()
        Me.parentguardian.ResumeLayout(False)
        Me.parentguardian.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picbarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents birthplace As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents citizenship As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents religion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents father As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents mother As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents guardian As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents picstudent As System.Windows.Forms.PictureBox
    Friend WithEvents birthday As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mobile As System.Windows.Forms.MaskedTextBox
    Friend WithEvents telephone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents guardcontact As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents picbarcode As System.Windows.Forms.PictureBox
    Friend WithEvents oldstudent As System.Windows.Forms.CheckBox
    Friend WithEvents newstudent As System.Windows.Forms.CheckBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents studid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents personalinfo As System.Windows.Forms.GroupBox
    Friend WithEvents p_sy As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents datetoday As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents bdateOLD As System.Windows.Forms.TextBox
    Friend WithEvents last_eid As System.Windows.Forms.TextBox
    Friend WithEvents studentid As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbrelation As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents m_firstname As System.Windows.Forms.TextBox
    Friend WithEvents f_firstname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents parentguardian As System.Windows.Forms.GroupBox
    Friend WithEvents mother_guardian As System.Windows.Forms.RadioButton
    Friend WithEvents father_guardian As System.Windows.Forms.RadioButton
    Friend WithEvents NomName As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents optionFemale As System.Windows.Forms.RadioButton
    Friend WithEvents optionMale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbday As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMos As System.Windows.Forms.ComboBox
    Friend WithEvents address1 As System.Windows.Forms.ComboBox
    Friend WithEvents address2 As System.Windows.Forms.ComboBox
    Friend WithEvents address3 As System.Windows.Forms.ComboBox
    Friend WithEvents sex As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ExtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents m_ext As System.Windows.Forms.TextBox
    Friend WithEvents f_ext As System.Windows.Forms.TextBox
    Friend WithEvents m_mname As System.Windows.Forms.TextBox
    Friend WithEvents f_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtESC As System.Windows.Forms.TextBox
    Friend WithEvents emailnotification As System.Windows.Forms.Label
End Class
