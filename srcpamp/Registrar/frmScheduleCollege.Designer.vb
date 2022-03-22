<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleCollege
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtSubjects = New System.Windows.Forms.DataGridView()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.subjectGroup = New System.Windows.Forms.GroupBox()
        Me.btnSection = New System.Windows.Forms.Button()
        Me.cmbcurriculum = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTimeIn_1 = New System.Windows.Forms.DateTimePicker()
        Me.txtTimeOut_1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbsection = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.sat = New System.Windows.Forms.CheckBox()
        Me.mon = New System.Windows.Forms.CheckBox()
        Me.tue = New System.Windows.Forms.CheckBox()
        Me.wed = New System.Windows.Forms.CheckBox()
        Me.thurs = New System.Windows.Forms.CheckBox()
        Me.fri = New System.Windows.Forms.CheckBox()
        Me.txtroom = New System.Windows.Forms.ComboBox()
        Me.txtTimeIN = New System.Windows.Forms.DateTimePicker()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTimeOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtCourseID = New System.Windows.Forms.Label()
        Me.txtLevelID = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.d1 = New System.Windows.Forms.TextBox()
        Me.d2 = New System.Windows.Forms.TextBox()
        Me.d3 = New System.Windows.Forms.TextBox()
        Me.d6 = New System.Windows.Forms.TextBox()
        Me.d5 = New System.Windows.Forms.TextBox()
        Me.d4 = New System.Windows.Forms.TextBox()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtClassscheduleid = New System.Windows.Forms.TextBox()
        Me.cID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbcurrentterm = New System.Windows.Forms.ComboBox()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.dvgfaculty = New System.Windows.Forms.DataGridView()
        Me.empid = New System.Windows.Forms.TextBox()
        Me.txtsectionID = New System.Windows.Forms.TextBox()
        Me.nofaculty = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnRemoveSchedule = New System.Windows.Forms.Button()
        Me.txtCAY = New System.Windows.Forms.ComboBox()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.College = New System.Windows.Forms.RadioButton()
        Me.SeniorHS = New System.Windows.Forms.RadioButton()
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.subjectGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgfaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.semester.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 260
        Me.Label15.Text = "Course"
        '
        'dtSubjects
        '
        Me.dtSubjects.AllowUserToAddRows = False
        Me.dtSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSubjects.Enabled = False
        Me.dtSubjects.Location = New System.Drawing.Point(346, 40)
        Me.dtSubjects.Name = "dtSubjects"
        Me.dtSubjects.Size = New System.Drawing.Size(357, 413)
        Me.dtSubjects.TabIndex = 0
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(62, 16)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(260, 21)
        Me.cmbCourse.TabIndex = 272
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(880, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Subjects"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Major"
        '
        'cmbMajor
        '
        Me.cmbMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(62, 42)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(196, 21)
        Me.cmbMajor.TabIndex = 281
        '
        'subjectGroup
        '
        Me.subjectGroup.BackColor = System.Drawing.Color.Transparent
        Me.subjectGroup.Controls.Add(Me.btnSection)
        Me.subjectGroup.Controls.Add(Me.cmbcurriculum)
        Me.subjectGroup.Controls.Add(Me.btnRemove)
        Me.subjectGroup.Controls.Add(Me.Label13)
        Me.subjectGroup.Controls.Add(Me.btnAdd)
        Me.subjectGroup.Controls.Add(Me.Label12)
        Me.subjectGroup.Controls.Add(Me.txtTimeIn_1)
        Me.subjectGroup.Controls.Add(Me.txtTimeOut_1)
        Me.subjectGroup.Controls.Add(Me.Label11)
        Me.subjectGroup.Controls.Add(Me.cmbsection)
        Me.subjectGroup.Controls.Add(Me.Label8)
        Me.subjectGroup.Controls.Add(Me.GroupBox2)
        Me.subjectGroup.Controls.Add(Me.txtroom)
        Me.subjectGroup.Controls.Add(Me.txtTimeIN)
        Me.subjectGroup.Controls.Add(Me.txtsubject)
        Me.subjectGroup.Controls.Add(Me.Label6)
        Me.subjectGroup.Controls.Add(Me.Label7)
        Me.subjectGroup.Controls.Add(Me.Label9)
        Me.subjectGroup.Controls.Add(Me.txtTimeOut)
        Me.subjectGroup.Controls.Add(Me.Label15)
        Me.subjectGroup.Controls.Add(Me.cmbCourse)
        Me.subjectGroup.Controls.Add(Me.Label3)
        Me.subjectGroup.Controls.Add(Me.cmbMajor)
        Me.subjectGroup.Controls.Add(Me.cmbTerm)
        Me.subjectGroup.Controls.Add(Me.Label2)
        Me.subjectGroup.Controls.Add(Me.cmbLevel)
        Me.subjectGroup.Controls.Add(Me.Label4)
        Me.subjectGroup.Enabled = False
        Me.subjectGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectGroup.Location = New System.Drawing.Point(12, 35)
        Me.subjectGroup.Name = "subjectGroup"
        Me.subjectGroup.Size = New System.Drawing.Size(328, 371)
        Me.subjectGroup.TabIndex = 285
        Me.subjectGroup.TabStop = False
        '
        'btnSection
        '
        Me.btnSection.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSection.Location = New System.Drawing.Point(200, 191)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(122, 26)
        Me.btnSection.TabIndex = 321
        Me.btnSection.Text = "Fetch Section"
        Me.btnSection.UseVisualStyleBackColor = False
        '
        'cmbcurriculum
        '
        Me.cmbcurriculum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcurriculum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcurriculum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcurriculum.FormattingEnabled = True
        Me.cmbcurriculum.Location = New System.Drawing.Point(108, 67)
        Me.cmbcurriculum.Name = "cmbcurriculum"
        Me.cmbcurriculum.Size = New System.Drawing.Size(150, 21)
        Me.cmbcurriculum.TabIndex = 319
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(7, 303)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 28)
        Me.btnRemove.TabIndex = 314
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 16)
        Me.Label13.TabIndex = 320
        Me.Label13.Text = "Curriculum Year"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(73, 303)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(238, 28)
        Me.btnAdd.TabIndex = 313
        Me.btnAdd.Text = "Add Time Slot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(182, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 312
        Me.Label12.Text = "-"
        '
        'txtTimeIn_1
        '
        Me.txtTimeIn_1.CustomFormat = "hh:mm tt"
        Me.txtTimeIn_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTimeIn_1.Location = New System.Drawing.Point(73, 304)
        Me.txtTimeIn_1.Name = "txtTimeIn_1"
        Me.txtTimeIn_1.ShowUpDown = True
        Me.txtTimeIn_1.Size = New System.Drawing.Size(97, 24)
        Me.txtTimeIn_1.TabIndex = 310
        '
        'txtTimeOut_1
        '
        Me.txtTimeOut_1.CustomFormat = "hh:mm tt"
        Me.txtTimeOut_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTimeOut_1.Location = New System.Drawing.Point(215, 304)
        Me.txtTimeOut_1.Name = "txtTimeOut_1"
        Me.txtTimeOut_1.ShowUpDown = True
        Me.txtTimeOut_1.Size = New System.Drawing.Size(96, 24)
        Me.txtTimeOut_1.TabIndex = 311
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 309
        Me.Label11.Text = "Section"
        '
        'cmbsection
        '
        Me.cmbsection.FormattingEnabled = True
        Me.cmbsection.Location = New System.Drawing.Point(62, 191)
        Me.cmbsection.Name = "cmbsection"
        Me.cmbsection.Size = New System.Drawing.Size(132, 26)
        Me.cmbsection.TabIndex = 308
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 302
        Me.Label8.Text = "Room"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.sat)
        Me.GroupBox2.Controls.Add(Me.mon)
        Me.GroupBox2.Controls.Add(Me.tue)
        Me.GroupBox2.Controls.Add(Me.wed)
        Me.GroupBox2.Controls.Add(Me.thurs)
        Me.GroupBox2.Controls.Add(Me.fri)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 51)
        Me.GroupBox2.TabIndex = 307
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Day"
        '
        'sat
        '
        Me.sat.AutoSize = True
        Me.sat.Location = New System.Drawing.Point(258, 19)
        Me.sat.Name = "sat"
        Me.sat.Size = New System.Drawing.Size(44, 19)
        Me.sat.TabIndex = 5
        Me.sat.Text = "Sat"
        Me.sat.UseVisualStyleBackColor = True
        '
        'mon
        '
        Me.mon.AutoSize = True
        Me.mon.Location = New System.Drawing.Point(5, 18)
        Me.mon.Name = "mon"
        Me.mon.Size = New System.Drawing.Size(51, 19)
        Me.mon.TabIndex = 0
        Me.mon.Text = "Mon"
        Me.mon.UseVisualStyleBackColor = True
        '
        'tue
        '
        Me.tue.AutoSize = True
        Me.tue.Location = New System.Drawing.Point(56, 18)
        Me.tue.Name = "tue"
        Me.tue.Size = New System.Drawing.Size(47, 19)
        Me.tue.TabIndex = 1
        Me.tue.Text = "Tue"
        Me.tue.UseVisualStyleBackColor = True
        '
        'wed
        '
        Me.wed.AutoSize = True
        Me.wed.Location = New System.Drawing.Point(103, 19)
        Me.wed.Name = "wed"
        Me.wed.Size = New System.Drawing.Size(51, 19)
        Me.wed.TabIndex = 2
        Me.wed.Text = "Wed"
        Me.wed.UseVisualStyleBackColor = True
        '
        'thurs
        '
        Me.thurs.AutoSize = True
        Me.thurs.Location = New System.Drawing.Point(157, 19)
        Me.thurs.Name = "thurs"
        Me.thurs.Size = New System.Drawing.Size(57, 19)
        Me.thurs.TabIndex = 3
        Me.thurs.Text = "Thurs"
        Me.thurs.UseVisualStyleBackColor = True
        '
        'fri
        '
        Me.fri.AutoSize = True
        Me.fri.Location = New System.Drawing.Point(217, 19)
        Me.fri.Name = "fri"
        Me.fri.Size = New System.Drawing.Size(40, 19)
        Me.fri.TabIndex = 4
        Me.fri.Text = "Fri"
        Me.fri.UseVisualStyleBackColor = True
        '
        'txtroom
        '
        Me.txtroom.FormattingEnabled = True
        Me.txtroom.Location = New System.Drawing.Point(73, 339)
        Me.txtroom.Name = "txtroom"
        Me.txtroom.Size = New System.Drawing.Size(238, 26)
        Me.txtroom.TabIndex = 301
        '
        'txtTimeIN
        '
        Me.txtTimeIN.CustomFormat = "hh:mm tt"
        Me.txtTimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTimeIN.Location = New System.Drawing.Point(72, 272)
        Me.txtTimeIN.Name = "txtTimeIN"
        Me.txtTimeIN.ShowUpDown = True
        Me.txtTimeIN.Size = New System.Drawing.Size(97, 24)
        Me.txtTimeIN.TabIndex = 296
        '
        'txtsubject
        '
        Me.txtsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubject.Location = New System.Drawing.Point(62, 121)
        Me.txtsubject.Multiline = True
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.ReadOnly = True
        Me.txtsubject.Size = New System.Drawing.Size(260, 64)
        Me.txtsubject.TabIndex = 304
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 298
        Me.Label6.Text = "Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(181, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 300
        Me.Label7.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 303
        Me.Label9.Text = "Subject"
        '
        'txtTimeOut
        '
        Me.txtTimeOut.CustomFormat = "hh:mm tt"
        Me.txtTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTimeOut.Location = New System.Drawing.Point(214, 272)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.ShowUpDown = True
        Me.txtTimeOut.Size = New System.Drawing.Size(96, 24)
        Me.txtTimeOut.TabIndex = 299
        '
        'cmbTerm
        '
        Me.cmbTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Items.AddRange(New Object() {"", "All", "1st Semester", "2nd Semester", "Summer"})
        Me.cmbTerm.Location = New System.Drawing.Point(206, 95)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(116, 21)
        Me.cmbTerm.TabIndex = 291
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 286
        Me.Label2.Text = "Level"
        '
        'cmbLevel
        '
        Me.cmbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Location = New System.Drawing.Point(62, 94)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(87, 21)
        Me.cmbLevel.TabIndex = 287
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 290
        Me.Label4.Text = "Term"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(808, 11)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(72, 20)
        Me.txtTime.TabIndex = 306
        Me.txtTime.Visible = False
        '
        'txtCourseID
        '
        Me.txtCourseID.AutoSize = True
        Me.txtCourseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseID.Location = New System.Drawing.Point(886, 21)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(64, 16)
        Me.txtCourseID.TabIndex = 288
        Me.txtCourseID.Text = "CourseID"
        Me.txtCourseID.Visible = False
        '
        'txtLevelID
        '
        Me.txtLevelID.AutoSize = True
        Me.txtLevelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevelID.Location = New System.Drawing.Point(886, 3)
        Me.txtLevelID.Name = "txtLevelID"
        Me.txtLevelID.Size = New System.Drawing.Size(54, 16)
        Me.txtLevelID.TabIndex = 289
        Me.txtLevelID.Text = "LevelID"
        Me.txtLevelID.Visible = False
        '
        'txtTerm
        '
        Me.txtTerm.AutoSize = True
        Me.txtTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(606, 26)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(0, 16)
        Me.txtTerm.TabIndex = 292
        Me.txtTerm.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnClose.Location = New System.Drawing.Point(278, 412)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 41)
        Me.btnClose.TabIndex = 293
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(972, 317)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(92, 20)
        Me.txtDay.TabIndex = 296
        Me.txtDay.Visible = False
        '
        'd1
        '
        Me.d1.Location = New System.Drawing.Point(972, 238)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(33, 20)
        Me.d1.TabIndex = 297
        Me.d1.Visible = False
        '
        'd2
        '
        Me.d2.Location = New System.Drawing.Point(972, 283)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(33, 20)
        Me.d2.TabIndex = 298
        Me.d2.Visible = False
        '
        'd3
        '
        Me.d3.Location = New System.Drawing.Point(972, 60)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(33, 20)
        Me.d3.TabIndex = 299
        Me.d3.Visible = False
        '
        'd6
        '
        Me.d6.Location = New System.Drawing.Point(972, 133)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(33, 20)
        Me.d6.TabIndex = 302
        Me.d6.Visible = False
        '
        'd5
        '
        Me.d5.Location = New System.Drawing.Point(972, 112)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(33, 20)
        Me.d5.TabIndex = 301
        Me.d5.Visible = False
        '
        'd4
        '
        Me.d4.Location = New System.Drawing.Point(972, 86)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(33, 20)
        Me.d4.TabIndex = 300
        Me.d4.Visible = False
        '
        'txtSubjectID
        '
        Me.txtSubjectID.Location = New System.Drawing.Point(785, 3)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(40, 20)
        Me.txtSubjectID.TabIndex = 303
        Me.txtSubjectID.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.ForestGreen
        Me.btnGenerate.Location = New System.Drawing.Point(12, 412)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(133, 41)
        Me.btnGenerate.TabIndex = 304
        Me.btnGenerate.Text = "Generate Schedule"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtClassscheduleid
        '
        Me.txtClassscheduleid.Location = New System.Drawing.Point(972, 196)
        Me.txtClassscheduleid.Name = "txtClassscheduleid"
        Me.txtClassscheduleid.Size = New System.Drawing.Size(33, 20)
        Me.txtClassscheduleid.TabIndex = 307
        Me.txtClassscheduleid.Visible = False
        '
        'cID
        '
        Me.cID.Location = New System.Drawing.Point(972, 19)
        Me.cID.Name = "cID"
        Me.cID.Size = New System.Drawing.Size(33, 20)
        Me.cID.TabIndex = 308
        Me.cID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 309
        Me.Label5.Text = "School Year:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 310
        Me.Label10.Text = "Current Term"
        '
        'cmbcurrentterm
        '
        Me.cmbcurrentterm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcurrentterm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcurrentterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcurrentterm.FormattingEnabled = True
        Me.cmbcurrentterm.Items.AddRange(New Object() {"", "1st Semester", "2nd Semester", "Summer"})
        Me.cmbcurrentterm.Location = New System.Drawing.Point(350, 10)
        Me.cmbcurrentterm.Name = "cmbcurrentterm"
        Me.cmbcurrentterm.Size = New System.Drawing.Size(145, 21)
        Me.cmbcurrentterm.TabIndex = 308
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Location = New System.Drawing.Point(15, 459)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.Size = New System.Drawing.Size(942, 206)
        Me.dgvSchedule.TabIndex = 313
        '
        'dvgfaculty
        '
        Me.dvgfaculty.AllowUserToDeleteRows = False
        Me.dvgfaculty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgfaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgfaculty.Location = New System.Drawing.Point(709, 40)
        Me.dvgfaculty.Name = "dvgfaculty"
        Me.dvgfaculty.ReadOnly = True
        Me.dvgfaculty.Size = New System.Drawing.Size(248, 384)
        Me.dvgfaculty.TabIndex = 314
        '
        'empid
        '
        Me.empid.Location = New System.Drawing.Point(972, 257)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(33, 20)
        Me.empid.TabIndex = 315
        Me.empid.Visible = False
        '
        'txtsectionID
        '
        Me.txtsectionID.Location = New System.Drawing.Point(746, 10)
        Me.txtsectionID.Name = "txtsectionID"
        Me.txtsectionID.Size = New System.Drawing.Size(33, 20)
        Me.txtsectionID.TabIndex = 316
        Me.txtsectionID.Visible = False
        '
        'nofaculty
        '
        Me.nofaculty.AutoSize = True
        Me.nofaculty.Location = New System.Drawing.Point(711, 430)
        Me.nofaculty.Name = "nofaculty"
        Me.nofaculty.Size = New System.Drawing.Size(114, 17)
        Me.nofaculty.TabIndex = 317
        Me.nofaculty.Text = "No Assign Faculty "
        Me.nofaculty.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(275, -6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 16)
        Me.Label14.TabIndex = 318
        '
        'btnRemoveSchedule
        '
        Me.btnRemoveSchedule.BackColor = System.Drawing.Color.Gold
        Me.btnRemoveSchedule.Location = New System.Drawing.Point(144, 412)
        Me.btnRemoveSchedule.Name = "btnRemoveSchedule"
        Me.btnRemoveSchedule.Size = New System.Drawing.Size(131, 41)
        Me.btnRemoveSchedule.TabIndex = 319
        Me.btnRemoveSchedule.Text = "Remove Schedule"
        Me.btnRemoveSchedule.UseVisualStyleBackColor = False
        '
        'txtCAY
        '
        Me.txtCAY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCAY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAY.FormattingEnabled = True
        Me.txtCAY.Location = New System.Drawing.Point(97, 10)
        Me.txtCAY.Name = "txtCAY"
        Me.txtCAY.Size = New System.Drawing.Size(140, 21)
        Me.txtCAY.TabIndex = 320
        '
        'semester
        '
        Me.semester.Controls.Add(Me.College)
        Me.semester.Controls.Add(Me.SeniorHS)
        Me.semester.Enabled = False
        Me.semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(501, 2)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(195, 32)
        Me.semester.TabIndex = 321
        Me.semester.TabStop = False
        '
        'College
        '
        Me.College.AutoSize = True
        Me.College.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.College.Location = New System.Drawing.Point(111, 10)
        Me.College.Name = "College"
        Me.College.Size = New System.Drawing.Size(67, 19)
        Me.College.TabIndex = 221
        Me.College.TabStop = True
        Me.College.Text = "College"
        Me.College.UseVisualStyleBackColor = True
        '
        'SeniorHS
        '
        Me.SeniorHS.AutoSize = True
        Me.SeniorHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeniorHS.Location = New System.Drawing.Point(15, 9)
        Me.SeniorHS.Name = "SeniorHS"
        Me.SeniorHS.Size = New System.Drawing.Size(81, 19)
        Me.SeniorHS.TabIndex = 3
        Me.SeniorHS.TabStop = True
        Me.SeniorHS.Text = "Senior HS"
        Me.SeniorHS.UseVisualStyleBackColor = True
        '
        'frmScheduleCollege
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(967, 667)
        Me.Controls.Add(Me.semester)
        Me.Controls.Add(Me.txtCAY)
        Me.Controls.Add(Me.btnRemoveSchedule)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.nofaculty)
        Me.Controls.Add(Me.txtsectionID)
        Me.Controls.Add(Me.empid)
        Me.Controls.Add(Me.dvgfaculty)
        Me.Controls.Add(Me.dgvSchedule)
        Me.Controls.Add(Me.cmbcurrentterm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cID)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtClassscheduleid)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.d6)
        Me.Controls.Add(Me.d5)
        Me.Controls.Add(Me.d4)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtLevelID)
        Me.Controls.Add(Me.txtCourseID)
        Me.Controls.Add(Me.subjectGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtSubjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmScheduleCollege"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Schedule"
        CType(Me.dtSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.subjectGroup.ResumeLayout(False)
        Me.subjectGroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgfaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.semester.ResumeLayout(False)
        Me.semester.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents subjectGroup As System.Windows.Forms.GroupBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCourseID As System.Windows.Forms.Label
    Friend WithEvents txtLevelID As System.Windows.Forms.Label
    Friend WithEvents cmbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents sat As System.Windows.Forms.CheckBox
    Friend WithEvents fri As System.Windows.Forms.CheckBox
    Friend WithEvents thurs As System.Windows.Forms.CheckBox
    Friend WithEvents wed As System.Windows.Forms.CheckBox
    Friend WithEvents tue As System.Windows.Forms.CheckBox
    Friend WithEvents mon As System.Windows.Forms.CheckBox
    Friend WithEvents txtTimeIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtroom As System.Windows.Forms.ComboBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents d1 As System.Windows.Forms.TextBox
    Friend WithEvents d2 As System.Windows.Forms.TextBox
    Friend WithEvents d3 As System.Windows.Forms.TextBox
    Friend WithEvents d6 As System.Windows.Forms.TextBox
    Friend WithEvents d5 As System.Windows.Forms.TextBox
    Friend WithEvents d4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtClassscheduleid As System.Windows.Forms.TextBox
    Friend WithEvents cID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbcurrentterm As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbsection As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents dvgfaculty As System.Windows.Forms.DataGridView
    Friend WithEvents empid As System.Windows.Forms.TextBox
    Friend WithEvents txtsectionID As System.Windows.Forms.TextBox
    Friend WithEvents nofaculty As System.Windows.Forms.CheckBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTimeOut_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbcurriculum As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveSchedule As Button
    Friend WithEvents txtCAY As ComboBox
    Friend WithEvents semester As GroupBox
    Friend WithEvents College As RadioButton
    Friend WithEvents SeniorHS As RadioButton
    Friend WithEvents btnSection As Button
End Class
