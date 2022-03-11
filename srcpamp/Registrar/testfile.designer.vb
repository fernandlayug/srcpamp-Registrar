<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(testfile))
        Me.surname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.student = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.MaskedTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.studid = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.StudentInfo = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.sex = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bdateOLD = New System.Windows.Forms.TextBox()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.admissioninfo = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.cmbsy = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c_code = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.summer = New System.Windows.Forms.RadioButton()
        Me.secondsem = New System.Windows.Forms.RadioButton()
        Me.firstsem = New System.Windows.Forms.RadioButton()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dtsubjects = New System.Windows.Forms.DataGridView()
        Me.txtlevelid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcourseid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlabunits = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlecunits = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttotalunits = New System.Windows.Forms.TextBox()
        Me.txttotalsubjects = New System.Windows.Forms.TextBox()
        Me.picstudent = New System.Windows.Forms.PictureBox()
        Me.admissioninfoB = New System.Windows.Forms.GroupBox()
        Me.txtSemester = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.txtSY = New System.Windows.Forms.TextBox()
        Me.txtCategoryA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StudentInfo.SuspendLayout()
        Me.admissioninfo.SuspendLayout()
        Me.semester.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.admissioninfoB.SuspendLayout()
        Me.SuspendLayout()
        '
        'surname
        '
        Me.surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(99, 61)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(396, 23)
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
        'btnDrop
        '
        Me.btnDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrop.ForeColor = System.Drawing.Color.Blue
        Me.btnDrop.Location = New System.Drawing.Point(707, 4)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(134, 43)
        Me.btnDrop.TabIndex = 18
        Me.btnDrop.Text = "Drop Subject"
        Me.btnDrop.UseVisualStyleBackColor = True
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
        Me.studid.Location = New System.Drawing.Point(99, 28)
        Me.studid.Name = "studid"
        Me.studid.Size = New System.Drawing.Size(199, 24)
        Me.studid.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 18)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Student ID"
        '
        'StudentInfo
        '
        Me.StudentInfo.Controls.Add(Me.Label9)
        Me.StudentInfo.Controls.Add(Me.TextBox2)
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
        Me.StudentInfo.Location = New System.Drawing.Point(31, 2)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(978, 104)
        Me.StudentInfo.TabIndex = 66
        Me.StudentInfo.TabStop = False
        Me.StudentInfo.Text = "Student Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(700, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 568
        Me.Label9.Text = "ESC No"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(771, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(177, 24)
        Me.TextBox2.TabIndex = 567
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
        Me.Label18.Location = New System.Drawing.Point(324, 31)
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
        Me.txtLRN.Location = New System.Drawing.Point(372, 28)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.ReadOnly = True
        Me.txtLRN.Size = New System.Drawing.Size(299, 24)
        Me.txtLRN.TabIndex = 564
        '
        'admissioninfo
        '
        Me.admissioninfo.Controls.Add(Me.txtCategory)
        Me.admissioninfo.Controls.Add(Me.cmbsy)
        Me.admissioninfo.Controls.Add(Me.Label30)
        Me.admissioninfo.Controls.Add(Me.Label3)
        Me.admissioninfo.Controls.Add(Me.c_code)
        Me.admissioninfo.Controls.Add(Me.Label2)
        Me.admissioninfo.Controls.Add(Me.cmbMajor)
        Me.admissioninfo.Controls.Add(Me.cmbCourse)
        Me.admissioninfo.Controls.Add(Me.Label1)
        Me.admissioninfo.Controls.Add(Me.Label34)
        Me.admissioninfo.Controls.Add(Me.semester)
        Me.admissioninfo.Controls.Add(Me.level)
        Me.admissioninfo.Controls.Add(Me.Label19)
        Me.admissioninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfo.Location = New System.Drawing.Point(31, 106)
        Me.admissioninfo.Name = "admissioninfo"
        Me.admissioninfo.Size = New System.Drawing.Size(978, 85)
        Me.admissioninfo.TabIndex = 14
        Me.admissioninfo.TabStop = False
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(800, 20)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(158, 23)
        Me.txtCategory.TabIndex = 569
        '
        'cmbsy
        '
        Me.cmbsy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsy.FormattingEnabled = True
        Me.cmbsy.Location = New System.Drawing.Point(103, 17)
        Me.cmbsy.Name = "cmbsy"
        Me.cmbsy.Size = New System.Drawing.Size(148, 23)
        Me.cmbsy.TabIndex = 229
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(4, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 16)
        Me.Label30.TabIndex = 108
        Me.Label30.Text = "School Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(467, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Course Code"
        '
        'c_code
        '
        Me.c_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_code.Location = New System.Drawing.Point(568, 52)
        Me.c_code.Name = "c_code"
        Me.c_code.ReadOnly = True
        Me.c_code.Size = New System.Drawing.Size(101, 21)
        Me.c_code.TabIndex = 227
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(671, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Major/Track"
        '
        'cmbMajor
        '
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(773, 50)
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
        Me.cmbCourse.Location = New System.Drawing.Point(129, 52)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(322, 23)
        Me.cmbCourse.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Course/Program"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(430, 23)
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
        Me.semester.Location = New System.Drawing.Point(506, 12)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(288, 32)
        Me.semester.TabIndex = 220
        Me.semester.TabStop = False
        '
        'summer
        '
        Me.summer.AutoSize = True
        Me.summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summer.Location = New System.Drawing.Point(213, 10)
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
        Me.secondsem.Location = New System.Drawing.Point(111, 10)
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
        Me.firstsem.Location = New System.Drawing.Point(15, 10)
        Me.firstsem.Name = "firstsem"
        Me.firstsem.Size = New System.Drawing.Size(97, 19)
        Me.firstsem.TabIndex = 3
        Me.firstsem.TabStop = True
        Me.firstsem.Text = "1st Semester"
        Me.firstsem.UseVisualStyleBackColor = True
        '
        'level
        '
        Me.level.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.level.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(341, 17)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(84, 23)
        Me.level.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(258, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 16)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "Year Level"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Blue
        Me.btnClose.Location = New System.Drawing.Point(842, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 44)
        Me.btnClose.TabIndex = 213
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnDrop)
        Me.Panel1.Location = New System.Drawing.Point(31, 520)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 52)
        Me.Panel1.TabIndex = 567
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Blue
        Me.btnRemove.Location = New System.Drawing.Point(452, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(126, 44)
        Me.btnRemove.TabIndex = 216
        Me.btnRemove.Text = "Remove Subject"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.Color.Blue
        Me.btnADD.Location = New System.Drawing.Point(579, 4)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(126, 44)
        Me.btnADD.TabIndex = 215
        Me.btnADD.Text = "Add Subject"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Blue
        Me.btnPrint.Location = New System.Drawing.Point(317, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(134, 43)
        Me.btnPrint.TabIndex = 214
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dtsubjects
        '
        Me.dtsubjects.AllowUserToAddRows = False
        Me.dtsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsubjects.Location = New System.Drawing.Point(31, 196)
        Me.dtsubjects.Name = "dtsubjects"
        Me.dtsubjects.Size = New System.Drawing.Size(978, 255)
        Me.dtsubjects.TabIndex = 568
        '
        'txtlevelid
        '
        Me.txtlevelid.Enabled = False
        Me.txtlevelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlevelid.Location = New System.Drawing.Point(38, 457)
        Me.txtlevelid.Name = "txtlevelid"
        Me.txtlevelid.Size = New System.Drawing.Size(47, 24)
        Me.txtlevelid.TabIndex = 568
        Me.txtlevelid.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 465)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 567
        Me.Label5.Text = "Total No. of Subjects"
        '
        'txtcourseid
        '
        Me.txtcourseid.Enabled = False
        Me.txtcourseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourseid.Location = New System.Drawing.Point(38, 487)
        Me.txtcourseid.Name = "txtcourseid"
        Me.txtcourseid.Size = New System.Drawing.Size(47, 24)
        Me.txtcourseid.TabIndex = 570
        Me.txtcourseid.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(91, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 569
        Me.Label7.Text = "Total No. of Units"
        '
        'txtlabunits
        '
        Me.txtlabunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlabunits.Location = New System.Drawing.Point(763, 487)
        Me.txtlabunits.Name = "txtlabunits"
        Me.txtlabunits.ReadOnly = True
        Me.txtlabunits.Size = New System.Drawing.Size(136, 24)
        Me.txtlabunits.TabIndex = 574
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(606, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 16)
        Me.Label8.TabIndex = 573
        Me.Label8.Text = "Laboratory Units"
        '
        'txtlecunits
        '
        Me.txtlecunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlecunits.Location = New System.Drawing.Point(763, 457)
        Me.txtlecunits.Name = "txtlecunits"
        Me.txtlecunits.ReadOnly = True
        Me.txtlecunits.Size = New System.Drawing.Size(136, 24)
        Me.txtlecunits.TabIndex = 572
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(606, 465)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 571
        Me.Label10.Text = "Lecture Units"
        '
        'txttotalunits
        '
        Me.txttotalunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalunits.Location = New System.Drawing.Point(245, 486)
        Me.txttotalunits.Name = "txttotalunits"
        Me.txttotalunits.ReadOnly = True
        Me.txttotalunits.Size = New System.Drawing.Size(136, 24)
        Me.txttotalunits.TabIndex = 576
        '
        'txttotalsubjects
        '
        Me.txttotalsubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalsubjects.Location = New System.Drawing.Point(245, 456)
        Me.txttotalsubjects.Name = "txttotalsubjects"
        Me.txttotalsubjects.ReadOnly = True
        Me.txttotalsubjects.Size = New System.Drawing.Size(136, 24)
        Me.txttotalsubjects.TabIndex = 575
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
        'admissioninfoB
        '
        Me.admissioninfoB.Controls.Add(Me.txtSemester)
        Me.admissioninfoB.Controls.Add(Me.Label17)
        Me.admissioninfoB.Controls.Add(Me.txtMajor)
        Me.admissioninfoB.Controls.Add(Me.txtCourse)
        Me.admissioninfoB.Controls.Add(Me.txtLevel)
        Me.admissioninfoB.Controls.Add(Me.txtSY)
        Me.admissioninfoB.Controls.Add(Me.txtCategoryA)
        Me.admissioninfoB.Controls.Add(Me.Label11)
        Me.admissioninfoB.Controls.Add(Me.Label12)
        Me.admissioninfoB.Controls.Add(Me.txtCourseCode)
        Me.admissioninfoB.Controls.Add(Me.Label13)
        Me.admissioninfoB.Controls.Add(Me.Label14)
        Me.admissioninfoB.Controls.Add(Me.Label15)
        Me.admissioninfoB.Controls.Add(Me.Label16)
        Me.admissioninfoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfoB.Location = New System.Drawing.Point(31, 105)
        Me.admissioninfoB.Name = "admissioninfoB"
        Me.admissioninfoB.Size = New System.Drawing.Size(978, 85)
        Me.admissioninfoB.TabIndex = 570
        Me.admissioninfoB.TabStop = False
        Me.admissioninfoB.Visible = False
        '
        'txtSemester
        '
        Me.txtSemester.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSemester.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemester.Location = New System.Drawing.Point(510, 18)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.ReadOnly = True
        Me.txtSemester.Size = New System.Drawing.Size(159, 23)
        Me.txtSemester.TabIndex = 575
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(677, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 16)
        Me.Label17.TabIndex = 574
        Me.Label17.Text = "Category"
        '
        'txtMajor
        '
        Me.txtMajor.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMajor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMajor.Location = New System.Drawing.Point(769, 47)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.ReadOnly = True
        Me.txtMajor.Size = New System.Drawing.Size(189, 23)
        Me.txtMajor.TabIndex = 573
        '
        'txtCourse
        '
        Me.txtCourse.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(125, 51)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(340, 23)
        Me.txtCourse.TabIndex = 572
        '
        'txtLevel
        '
        Me.txtLevel.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Location = New System.Drawing.Point(347, 17)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(84, 23)
        Me.txtLevel.TabIndex = 571
        '
        'txtSY
        '
        Me.txtSY.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtSY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSY.Location = New System.Drawing.Point(97, 17)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.ReadOnly = True
        Me.txtSY.Size = New System.Drawing.Size(158, 23)
        Me.txtSY.TabIndex = 570
        '
        'txtCategoryA
        '
        Me.txtCategoryA.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCategoryA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCategoryA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCategoryA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoryA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryA.Location = New System.Drawing.Point(754, 16)
        Me.txtCategoryA.Name = "txtCategoryA"
        Me.txtCategoryA.ReadOnly = True
        Me.txtCategoryA.Size = New System.Drawing.Size(204, 23)
        Me.txtCategoryA.TabIndex = 569
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "School Year"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(467, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 16)
        Me.Label12.TabIndex = 228
        Me.Label12.Text = "Course Code"
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseCode.Location = New System.Drawing.Point(568, 52)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.ReadOnly = True
        Me.txtCourseCode.Size = New System.Drawing.Size(101, 21)
        Me.txtCourseCode.TabIndex = 227
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(671, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 16)
        Me.Label13.TabIndex = 225
        Me.Label13.Text = "Major/Track"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 16)
        Me.Label14.TabIndex = 223
        Me.Label14.Text = "Course/Program"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(430, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 221
        Me.Label15.Text = "Semester"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(258, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 16)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Year Level"
        '
        'studentfile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 592)
        Me.Controls.Add(Me.txttotalunits)
        Me.Controls.Add(Me.txttotalsubjects)
        Me.Controls.Add(Me.txtlabunits)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtlecunits)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcourseid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtlevelid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtsubjects)
        Me.Controls.Add(Me.admissioninfo)
        Me.Controls.Add(Me.StudentInfo)
        Me.Controls.Add(Me.picstudent)
        Me.Controls.Add(Me.student)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.admissioninfoB)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "studentfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Enrolment File"
        Me.StudentInfo.ResumeLayout(False)
        Me.StudentInfo.PerformLayout()
        Me.admissioninfo.ResumeLayout(False)
        Me.admissioninfo.PerformLayout()
        Me.semester.ResumeLayout(False)
        Me.semester.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.admissioninfoB.ResumeLayout(False)
        Me.admissioninfoB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDrop As System.Windows.Forms.Button
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
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bdateOLD As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents semester As System.Windows.Forms.GroupBox
    Friend WithEvents secondsem As System.Windows.Forms.RadioButton
    Friend WithEvents firstsem As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c_code As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents sex As System.Windows.Forms.TextBox
    Friend WithEvents summer As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dtsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtlevelid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcourseid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlabunits As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtlecunits As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents cmbsy As System.Windows.Forms.ComboBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txttotalunits As System.Windows.Forms.TextBox
    Friend WithEvents txttotalsubjects As System.Windows.Forms.TextBox
    Friend WithEvents admissioninfoB As System.Windows.Forms.GroupBox
    Friend WithEvents txtSemester As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMajor As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtSY As System.Windows.Forms.TextBox
    Friend WithEvents txtCategoryA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
