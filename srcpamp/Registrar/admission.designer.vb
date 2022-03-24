<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admissionFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admissionFrm))
        Me.surname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.student = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.studid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.StudentInfo = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtESC = New System.Windows.Forms.TextBox()
        Me.sex = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bdateOLD = New System.Windows.Forms.TextBox()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.admissioninfo = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbTypeA = New System.Windows.Forms.ComboBox()
        Me.cmblastschlA = New System.Windows.Forms.ComboBox()
        Me.lastschlyearA = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.address1 = New System.Windows.Forms.ComboBox()
        Me.address2 = New System.Windows.Forms.ComboBox()
        Me.address3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.remarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmblastschl = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c_code = New System.Windows.Forms.TextBox()
        Me.tor = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.summer = New System.Windows.Forms.RadioButton()
        Me.secondsem = New System.Windows.Forms.RadioButton()
        Me.firstsem = New System.Windows.Forms.RadioButton()
        Me.lastschlyear = New System.Windows.Forms.ComboBox()
        Me.other = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.average = New System.Windows.Forms.TextBox()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.goodmoral = New System.Windows.Forms.CheckBox()
        Me.form138 = New System.Windows.Forms.CheckBox()
        Me.bcert = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCAY = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtLevelID = New System.Windows.Forms.TextBox()
        Me.collegeOption = New System.Windows.Forms.RadioButton()
        Me.shsOption = New System.Windows.Forms.RadioButton()
        Me.jhsOption = New System.Windows.Forms.RadioButton()
        Me.elemOption = New System.Windows.Forms.RadioButton()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.p_sy = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCredentials = New System.Windows.Forms.TextBox()
        Me.picstudent = New System.Windows.Forms.PictureBox()
        Me.dtAdmissionHistory = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StudentInfo.SuspendLayout()
        Me.admissioninfo.SuspendLayout()
        Me.semester.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAdmissionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'surname
        '
        Me.surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(99, 61)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(384, 23)
        Me.surname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(678, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sex"
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.Blue
        Me.submit.Location = New System.Drawing.Point(707, 4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(134, 43)
        Me.submit.TabIndex = 18
        Me.submit.Text = "Submit"
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
        Me.birthday.Location = New System.Drawing.Point(771, 58)
        Me.birthday.Mask = "00/00/0000"
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        Me.birthday.Size = New System.Drawing.Size(177, 23)
        Me.birthday.TabIndex = 8
        Me.birthday.ValidatingType = GetType(Date)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 18)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Name"
        '
        'studid
        '
        Me.studid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studid.Location = New System.Drawing.Point(99, 22)
        Me.studid.Name = "studid"
        Me.studid.ReadOnly = True
        Me.studid.Size = New System.Drawing.Size(199, 24)
        Me.studid.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 18)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Student ID"
        '
        'StudentInfo
        '
        Me.StudentInfo.Controls.Add(Me.Label9)
        Me.StudentInfo.Controls.Add(Me.txtESC)
        Me.StudentInfo.Controls.Add(Me.sex)
        Me.StudentInfo.Controls.Add(Me.Label18)
        Me.StudentInfo.Controls.Add(Me.bdateOLD)
        Me.StudentInfo.Controls.Add(Me.txtLRN)
        Me.StudentInfo.Controls.Add(Me.Label25)
        Me.StudentInfo.Controls.Add(Me.birthday)
        Me.StudentInfo.Controls.Add(Me.Label6)
        Me.StudentInfo.Controls.Add(Me.Label4)
        Me.StudentInfo.Controls.Add(Me.surname)
        Me.StudentInfo.Controls.Add(Me.Label26)
        Me.StudentInfo.Controls.Add(Me.studid)
        Me.StudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentInfo.Location = New System.Drawing.Point(30, 47)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(978, 98)
        Me.StudentInfo.TabIndex = 66
        Me.StudentInfo.TabStop = False
        Me.StudentInfo.Text = "Student Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(700, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 568
        Me.Label9.Text = "ESC No"
        '
        'txtESC
        '
        Me.txtESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtESC.Location = New System.Drawing.Point(771, 22)
        Me.txtESC.Name = "txtESC"
        Me.txtESC.ReadOnly = True
        Me.txtESC.Size = New System.Drawing.Size(177, 24)
        Me.txtESC.TabIndex = 567
        '
        'sex
        '
        Me.sex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex.Location = New System.Drawing.Point(543, 61)
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Size = New System.Drawing.Size(128, 23)
        Me.sex.TabIndex = 566
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(324, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 18)
        Me.Label18.TabIndex = 565
        Me.Label18.Text = "LRN"
        '
        'bdateOLD
        '
        Me.bdateOLD.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.bdateOLD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bdateOLD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.bdateOLD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bdateOLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdateOLD.Location = New System.Drawing.Point(771, 57)
        Me.bdateOLD.Name = "bdateOLD"
        Me.bdateOLD.ReadOnly = True
        Me.bdateOLD.Size = New System.Drawing.Size(177, 23)
        Me.bdateOLD.TabIndex = 64
        Me.bdateOLD.Visible = False
        '
        'txtLRN
        '
        Me.txtLRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.Location = New System.Drawing.Point(372, 22)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.ReadOnly = True
        Me.txtLRN.Size = New System.Drawing.Size(299, 24)
        Me.txtLRN.TabIndex = 564
        '
        'admissioninfo
        '
        Me.admissioninfo.Controls.Add(Me.Label14)
        Me.admissioninfo.Controls.Add(Me.cmbSection)
        Me.admissioninfo.Controls.Add(Me.cmbStatus)
        Me.admissioninfo.Controls.Add(Me.Label10)
        Me.admissioninfo.Controls.Add(Me.Label13)
        Me.admissioninfo.Controls.Add(Me.cmbTypeA)
        Me.admissioninfo.Controls.Add(Me.cmblastschlA)
        Me.admissioninfo.Controls.Add(Me.lastschlyearA)
        Me.admissioninfo.Controls.Add(Me.Label11)
        Me.admissioninfo.Controls.Add(Me.Label12)
        Me.admissioninfo.Controls.Add(Me.txtCourseID)
        Me.admissioninfo.Controls.Add(Me.address1)
        Me.admissioninfo.Controls.Add(Me.address2)
        Me.admissioninfo.Controls.Add(Me.address3)
        Me.admissioninfo.Controls.Add(Me.Label8)
        Me.admissioninfo.Controls.Add(Me.Label7)
        Me.admissioninfo.Controls.Add(Me.remarks)
        Me.admissioninfo.Controls.Add(Me.Label5)
        Me.admissioninfo.Controls.Add(Me.cmbType)
        Me.admissioninfo.Controls.Add(Me.cmblastschl)
        Me.admissioninfo.Controls.Add(Me.Label3)
        Me.admissioninfo.Controls.Add(Me.c_code)
        Me.admissioninfo.Controls.Add(Me.tor)
        Me.admissioninfo.Controls.Add(Me.Label2)
        Me.admissioninfo.Controls.Add(Me.cmbMajor)
        Me.admissioninfo.Controls.Add(Me.cmbCourse)
        Me.admissioninfo.Controls.Add(Me.Label1)
        Me.admissioninfo.Controls.Add(Me.Label34)
        Me.admissioninfo.Controls.Add(Me.semester)
        Me.admissioninfo.Controls.Add(Me.lastschlyear)
        Me.admissioninfo.Controls.Add(Me.other)
        Me.admissioninfo.Controls.Add(Me.Label32)
        Me.admissioninfo.Controls.Add(Me.Label31)
        Me.admissioninfo.Controls.Add(Me.average)
        Me.admissioninfo.Controls.Add(Me.level)
        Me.admissioninfo.Controls.Add(Me.Label19)
        Me.admissioninfo.Controls.Add(Me.Label27)
        Me.admissioninfo.Controls.Add(Me.goodmoral)
        Me.admissioninfo.Controls.Add(Me.form138)
        Me.admissioninfo.Controls.Add(Me.bcert)
        Me.admissioninfo.Controls.Add(Me.Label28)
        Me.admissioninfo.Controls.Add(Me.Label29)
        Me.admissioninfo.Enabled = False
        Me.admissioninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfo.Location = New System.Drawing.Point(31, 340)
        Me.admissioninfo.Name = "admissioninfo"
        Me.admissioninfo.Size = New System.Drawing.Size(978, 250)
        Me.admissioninfo.TabIndex = 14
        Me.admissioninfo.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(750, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 585
        Me.Label14.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(810, 18)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(160, 24)
        Me.cmbSection.TabIndex = 584
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Enrolled", "Registered"})
        Me.cmbStatus.Location = New System.Drawing.Point(707, 201)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(248, 24)
        Me.cmbStatus.TabIndex = 578
        Me.cmbStatus.TabStop = False
        Me.cmbStatus.Text = "Enrolled"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(312, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 24)
        Me.Label10.TabIndex = 577
        Me.Label10.Text = "|"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(658, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 16)
        Me.Label13.TabIndex = 579
        Me.Label13.Text = "Status"
        '
        'cmbTypeA
        '
        Me.cmbTypeA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTypeA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTypeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypeA.FormattingEnabled = True
        Me.cmbTypeA.Items.AddRange(New Object() {"", "Public", "Private", "SUC"})
        Me.cmbTypeA.Location = New System.Drawing.Point(168, 84)
        Me.cmbTypeA.Name = "cmbTypeA"
        Me.cmbTypeA.Size = New System.Drawing.Size(143, 23)
        Me.cmbTypeA.TabIndex = 572
        '
        'cmblastschlA
        '
        Me.cmblastschlA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblastschlA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblastschlA.Enabled = False
        Me.cmblastschlA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblastschlA.FormattingEnabled = True
        Me.cmblastschlA.Location = New System.Drawing.Point(327, 84)
        Me.cmblastschlA.Name = "cmblastschlA"
        Me.cmblastschlA.Size = New System.Drawing.Size(298, 23)
        Me.cmblastschlA.TabIndex = 573
        '
        'lastschlyearA
        '
        Me.lastschlyearA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lastschlyearA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lastschlyearA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastschlyearA.FormattingEnabled = True
        Me.lastschlyearA.Location = New System.Drawing.Point(674, 84)
        Me.lastschlyearA.Name = "lastschlyearA"
        Me.lastschlyearA.Size = New System.Drawing.Size(143, 23)
        Me.lastschlyearA.TabIndex = 574
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(628, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 16)
        Me.Label11.TabIndex = 576
        Me.Label11.Text = "S.Y."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 16)
        Me.Label12.TabIndex = 575
        Me.Label12.Text = "Intermediate Course"
        '
        'txtCourseID
        '
        Me.txtCourseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(770, 52)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.ReadOnly = True
        Me.txtCourseID.Size = New System.Drawing.Size(65, 23)
        Me.txtCourseID.TabIndex = 571
        Me.txtCourseID.Visible = False
        '
        'address1
        '
        Me.address1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.address1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.address1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address1.FormattingEnabled = True
        Me.address1.Location = New System.Drawing.Point(593, 141)
        Me.address1.Name = "address1"
        Me.address1.Size = New System.Drawing.Size(224, 24)
        Me.address1.TabIndex = 11
        '
        'address2
        '
        Me.address2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.address2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.address2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address2.FormattingEnabled = True
        Me.address2.Location = New System.Drawing.Point(365, 141)
        Me.address2.Name = "address2"
        Me.address2.Size = New System.Drawing.Size(224, 24)
        Me.address2.TabIndex = 10
        '
        'address3
        '
        Me.address3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.address3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.address3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address3.FormattingEnabled = True
        Me.address3.Location = New System.Drawing.Point(128, 141)
        Me.address3.Name = "address3"
        Me.address3.Size = New System.Drawing.Size(232, 24)
        Me.address3.TabIndex = 9
        Me.address3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "School Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 233
        Me.Label7.Text = "Remarks"
        '
        'remarks
        '
        Me.remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarks.Location = New System.Drawing.Point(80, 200)
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.Size = New System.Drawing.Size(571, 39)
        Me.remarks.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 24)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "|"
        '
        'cmbType
        '
        Me.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"", "Public", "Private", "SUC"})
        Me.cmbType.Location = New System.Drawing.Point(168, 113)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(143, 23)
        Me.cmbType.TabIndex = 5
        '
        'cmblastschl
        '
        Me.cmblastschl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblastschl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblastschl.Enabled = False
        Me.cmblastschl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblastschl.FormattingEnabled = True
        Me.cmblastschl.Location = New System.Drawing.Point(327, 113)
        Me.cmblastschl.Name = "cmblastschl"
        Me.cmblastschl.Size = New System.Drawing.Size(298, 23)
        Me.cmblastschl.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(768, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Course Code"
        '
        'c_code
        '
        Me.c_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_code.Location = New System.Drawing.Point(869, 52)
        Me.c_code.Name = "c_code"
        Me.c_code.ReadOnly = True
        Me.c_code.Size = New System.Drawing.Size(101, 21)
        Me.c_code.TabIndex = 227
        '
        'tor
        '
        Me.tor.AutoSize = True
        Me.tor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tor.Location = New System.Drawing.Point(571, 175)
        Me.tor.Name = "tor"
        Me.tor.Size = New System.Drawing.Size(59, 20)
        Me.tor.TabIndex = 15
        Me.tor.Text = "TOR"
        Me.tor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(468, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Major/Track"
        '
        'cmbMajor
        '
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(566, 51)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(185, 23)
        Me.cmbMajor.TabIndex = 224
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(129, 53)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(322, 23)
        Me.cmbCourse.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Course/Program"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(237, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(74, 16)
        Me.Label34.TabIndex = 221
        Me.Label34.Text = "Semester"
        '
        'semester
        '
        Me.semester.Controls.Add(Me.summer)
        Me.semester.Controls.Add(Me.secondsem)
        Me.semester.Controls.Add(Me.firstsem)
        Me.semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(313, 11)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(351, 32)
        Me.semester.TabIndex = 220
        Me.semester.TabStop = False
        '
        'summer
        '
        Me.summer.AutoSize = True
        Me.summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summer.Location = New System.Drawing.Point(248, 10)
        Me.summer.Name = "summer"
        Me.summer.Size = New System.Drawing.Size(73, 19)
        Me.summer.TabIndex = 222
        Me.summer.TabStop = True
        Me.summer.Text = "Summer"
        Me.summer.UseVisualStyleBackColor = True
        '
        'secondsem
        '
        Me.secondsem.AutoSize = True
        Me.secondsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondsem.Location = New System.Drawing.Point(128, 10)
        Me.secondsem.Name = "secondsem"
        Me.secondsem.Size = New System.Drawing.Size(102, 19)
        Me.secondsem.TabIndex = 221
        Me.secondsem.TabStop = True
        Me.secondsem.Text = "2nd Semester"
        Me.secondsem.UseVisualStyleBackColor = True
        '
        'firstsem
        '
        Me.firstsem.AutoSize = True
        Me.firstsem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstsem.Location = New System.Drawing.Point(14, 10)
        Me.firstsem.Name = "firstsem"
        Me.firstsem.Size = New System.Drawing.Size(97, 19)
        Me.firstsem.TabIndex = 3
        Me.firstsem.TabStop = True
        Me.firstsem.Text = "1st Semester"
        Me.firstsem.UseVisualStyleBackColor = True
        '
        'lastschlyear
        '
        Me.lastschlyear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.lastschlyear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lastschlyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastschlyear.FormattingEnabled = True
        Me.lastschlyear.Location = New System.Drawing.Point(674, 113)
        Me.lastschlyear.Name = "lastschlyear"
        Me.lastschlyear.Size = New System.Drawing.Size(143, 23)
        Me.lastschlyear.TabIndex = 7
        '
        'other
        '
        Me.other.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.other.FormattingEnabled = True
        Me.other.Items.AddRange(New Object() {"", "Certificate of Indigency", "Certificate of Merit"})
        Me.other.Location = New System.Drawing.Point(707, 170)
        Me.other.Name = "other"
        Me.other.Size = New System.Drawing.Size(249, 23)
        Me.other.TabIndex = 16
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(822, 115)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 16)
        Me.Label32.TabIndex = 123
        Me.Label32.Text = "Average"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(628, 117)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 16)
        Me.Label31.TabIndex = 122
        Me.Label31.Text = "S.Y."
        '
        'average
        '
        Me.average.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.average.Location = New System.Drawing.Point(892, 112)
        Me.average.Name = "average"
        Me.average.Size = New System.Drawing.Size(64, 21)
        Me.average.TabIndex = 8
        Me.average.Text = "0"
        '
        'level
        '
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(99, 18)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(130, 23)
        Me.level.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "Year Level"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(656, 177)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 16)
        Me.Label27.TabIndex = 116
        Me.Label27.Text = "Other"
        '
        'goodmoral
        '
        Me.goodmoral.AutoSize = True
        Me.goodmoral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goodmoral.Location = New System.Drawing.Point(434, 177)
        Me.goodmoral.Name = "goodmoral"
        Me.goodmoral.Size = New System.Drawing.Size(108, 20)
        Me.goodmoral.TabIndex = 14
        Me.goodmoral.Text = "Good Moral"
        Me.goodmoral.UseVisualStyleBackColor = True
        '
        'form138
        '
        Me.form138.AutoSize = True
        Me.form138.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form138.Location = New System.Drawing.Point(323, 176)
        Me.form138.Name = "form138"
        Me.form138.Size = New System.Drawing.Size(90, 20)
        Me.form138.TabIndex = 13
        Me.form138.Text = "Form 138"
        Me.form138.UseVisualStyleBackColor = True
        '
        'bcert
        '
        Me.bcert.AutoSize = True
        Me.bcert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcert.Location = New System.Drawing.Point(176, 175)
        Me.bcert.Name = "bcert"
        Me.bcert.Size = New System.Drawing.Size(132, 20)
        Me.bcert.TabIndex = 12
        Me.bcert.Text = "Birth Certificate"
        Me.bcert.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(4, 175)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(160, 16)
        Me.Label28.TabIndex = 112
        Me.Label28.Text = "Credentials Submitted"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(4, 117)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(155, 16)
        Me.Label29.TabIndex = 110
        Me.Label29.Text = "Last School Attended"
        '
        'txtCAY
        '
        Me.txtCAY.AutoSize = True
        Me.txtCAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAY.ForeColor = System.Drawing.Color.Maroon
        Me.txtCAY.Location = New System.Drawing.Point(850, 151)
        Me.txtCAY.Name = "txtCAY"
        Me.txtCAY.Size = New System.Drawing.Size(13, 16)
        Me.txtCAY.TabIndex = 581
        Me.txtCAY.Text = "-"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Maroon
        Me.label.Location = New System.Drawing.Point(727, 149)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(121, 16)
        Me.label.TabIndex = 580
        Me.label.Text = "Curriculum Year:"
        '
        'txtLevelID
        '
        Me.txtLevelID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLevelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelID.Location = New System.Drawing.Point(-16, 340)
        Me.txtLevelID.Name = "txtLevelID"
        Me.txtLevelID.ReadOnly = True
        Me.txtLevelID.Size = New System.Drawing.Size(46, 23)
        Me.txtLevelID.TabIndex = 570
        Me.txtLevelID.Visible = False
        '
        'collegeOption
        '
        Me.collegeOption.AutoSize = True
        Me.collegeOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collegeOption.Location = New System.Drawing.Point(629, 15)
        Me.collegeOption.Name = "collegeOption"
        Me.collegeOption.Size = New System.Drawing.Size(83, 22)
        Me.collegeOption.TabIndex = 219
        Me.collegeOption.TabStop = True
        Me.collegeOption.Text = "College"
        Me.collegeOption.UseVisualStyleBackColor = True
        '
        'shsOption
        '
        Me.shsOption.AutoSize = True
        Me.shsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shsOption.Location = New System.Drawing.Point(406, 15)
        Me.shsOption.Name = "shsOption"
        Me.shsOption.Size = New System.Drawing.Size(165, 22)
        Me.shsOption.TabIndex = 218
        Me.shsOption.TabStop = True
        Me.shsOption.Text = "Senior Highschool"
        Me.shsOption.UseVisualStyleBackColor = True
        '
        'jhsOption
        '
        Me.jhsOption.AutoSize = True
        Me.jhsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jhsOption.Location = New System.Drawing.Point(200, 15)
        Me.jhsOption.Name = "jhsOption"
        Me.jhsOption.Size = New System.Drawing.Size(163, 22)
        Me.jhsOption.TabIndex = 217
        Me.jhsOption.TabStop = True
        Me.jhsOption.Text = "Junior Highschool"
        Me.jhsOption.UseVisualStyleBackColor = True
        '
        'elemOption
        '
        Me.elemOption.AutoSize = True
        Me.elemOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elemOption.Location = New System.Drawing.Point(43, 15)
        Me.elemOption.Name = "elemOption"
        Me.elemOption.Size = New System.Drawing.Size(110, 22)
        Me.elemOption.TabIndex = 216
        Me.elemOption.TabStop = True
        Me.elemOption.Text = "Elementary"
        Me.elemOption.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(773, 26)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 16)
        Me.Label30.TabIndex = 108
        Me.Label30.Text = "School Year"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(846, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 44)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.elemOption)
        Me.GroupBox3.Controls.Add(Me.jhsOption)
        Me.GroupBox3.Controls.Add(Me.shsOption)
        Me.GroupBox3.Controls.Add(Me.collegeOption)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(31, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(721, 42)
        Me.GroupBox3.TabIndex = 220
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Level"
        '
        'p_sy
        '
        Me.p_sy.Enabled = False
        Me.p_sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_sy.Location = New System.Drawing.Point(866, 20)
        Me.p_sy.Name = "p_sy"
        Me.p_sy.Size = New System.Drawing.Size(136, 24)
        Me.p_sy.TabIndex = 566
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.txtCredentials)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Location = New System.Drawing.Point(31, 597)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 52)
        Me.Panel1.TabIndex = 567
        '
        'txtCredentials
        '
        Me.txtCredentials.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredentials.Location = New System.Drawing.Point(16, 17)
        Me.txtCredentials.Name = "txtCredentials"
        Me.txtCredentials.ReadOnly = True
        Me.txtCredentials.Size = New System.Drawing.Size(508, 21)
        Me.txtCredentials.TabIndex = 230
        Me.txtCredentials.Visible = False
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
        'dtAdmissionHistory
        '
        Me.dtAdmissionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAdmissionHistory.Location = New System.Drawing.Point(5, 19)
        Me.dtAdmissionHistory.Name = "dtAdmissionHistory"
        Me.dtAdmissionHistory.Size = New System.Drawing.Size(965, 149)
        Me.dtAdmissionHistory.TabIndex = 568
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtAdmissionHistory)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(978, 174)
        Me.GroupBox1.TabIndex = 569
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrolment History"
        '
        'admissionFrm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 672)
        Me.Controls.Add(Me.txtCAY)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.p_sy)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.admissioninfo)
        Me.Controls.Add(Me.StudentInfo)
        Me.Controls.Add(Me.picstudent)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtLevelID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admissionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.StudentInfo.ResumeLayout(False)
        Me.StudentInfo.PerformLayout()
        Me.admissioninfo.ResumeLayout(False)
        Me.admissioninfo.PerformLayout()
        Me.semester.ResumeLayout(False)
        Me.semester.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAdmissionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents picstudent As System.Windows.Forms.PictureBox
    Friend WithEvents birthday As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents studid As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents StudentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents admissioninfo As System.Windows.Forms.GroupBox
    Friend WithEvents level As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents goodmoral As System.Windows.Forms.CheckBox
    Friend WithEvents form138 As System.Windows.Forms.CheckBox
    Friend WithEvents bcert As System.Windows.Forms.CheckBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents average As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents other As System.Windows.Forms.ComboBox
    Friend WithEvents lastschlyear As System.Windows.Forms.ComboBox
    Friend WithEvents bdateOLD As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents semester As System.Windows.Forms.GroupBox
    Friend WithEvents secondsem As System.Windows.Forms.RadioButton
    Friend WithEvents firstsem As System.Windows.Forms.RadioButton
    Friend WithEvents collegeOption As System.Windows.Forms.RadioButton
    Friend WithEvents shsOption As System.Windows.Forms.RadioButton
    Friend WithEvents jhsOption As System.Windows.Forms.RadioButton
    Friend WithEvents elemOption As System.Windows.Forms.RadioButton
    Friend WithEvents tor As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents p_sy As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c_code As System.Windows.Forms.TextBox
    Friend WithEvents cmblastschl As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCredentials As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents sex As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents remarks As System.Windows.Forms.TextBox
    Friend WithEvents summer As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtESC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents address1 As System.Windows.Forms.ComboBox
    Friend WithEvents address2 As System.Windows.Forms.ComboBox
    Friend WithEvents address3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtLevelID As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeA As System.Windows.Forms.ComboBox
    Friend WithEvents cmblastschlA As System.Windows.Forms.ComboBox
    Friend WithEvents lastschlyearA As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtAdmissionHistory As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtCAY As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
End Class
