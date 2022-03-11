<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSectioning
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
        Me.student = New System.Windows.Forms.Label()
        Me.admissioninfo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMajor = New System.Windows.Forms.ComboBox()
        Me.cmbgenavTo = New System.Windows.Forms.ComboBox()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.cmbgenavFrom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.semester = New System.Windows.Forms.GroupBox()
        Me.summer = New System.Windows.Forms.RadioButton()
        Me.secondsem = New System.Windows.Forms.RadioButton()
        Me.firstsem = New System.Windows.Forms.RadioButton()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.shsOption = New System.Windows.Forms.RadioButton()
        Me.jhsOption = New System.Windows.Forms.RadioButton()
        Me.elemOption = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.allOption = New System.Windows.Forms.RadioButton()
        Me.collegeOption = New System.Windows.Forms.RadioButton()
        Me.dgvunsection = New System.Windows.Forms.DataGridView()
        Me.dgvsection = New System.Windows.Forms.DataGridView()
        Me.btnUnSection = New System.Windows.Forms.Button()
        Me.btnClassSection = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFemaleSection = New System.Windows.Forms.Label()
        Me.lblMaleSection = New System.Windows.Forms.Label()
        Me.lblTotalStudentsSection = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.admissioninfo.SuspendLayout()
        Me.semester.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvunsection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(1010, 156)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 41
        Me.student.Visible = False
        '
        'admissioninfo
        '
        Me.admissioninfo.Controls.Add(Me.Label3)
        Me.admissioninfo.Controls.Add(Me.cmbSection)
        Me.admissioninfo.Controls.Add(Me.Label2)
        Me.admissioninfo.Controls.Add(Me.Label4)
        Me.admissioninfo.Controls.Add(Me.cmbMajor)
        Me.admissioninfo.Controls.Add(Me.cmbgenavTo)
        Me.admissioninfo.Controls.Add(Me.cmbCourse)
        Me.admissioninfo.Controls.Add(Me.cmbgenavFrom)
        Me.admissioninfo.Controls.Add(Me.Label1)
        Me.admissioninfo.Controls.Add(Me.Label5)
        Me.admissioninfo.Controls.Add(Me.semester)
        Me.admissioninfo.Controls.Add(Me.level)
        Me.admissioninfo.Controls.Add(Me.Label19)
        Me.admissioninfo.Enabled = False
        Me.admissioninfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfo.Location = New System.Drawing.Point(21, 34)
        Me.admissioninfo.Name = "admissioninfo"
        Me.admissioninfo.Size = New System.Drawing.Size(571, 115)
        Me.admissioninfo.TabIndex = 14
        Me.admissioninfo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 583
        Me.Label3.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(401, 83)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(160, 24)
        Me.cmbSection.TabIndex = 582
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Major"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 581
        Me.Label4.Text = "-"
        '
        'cmbMajor
        '
        Me.cmbMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMajor.FormattingEnabled = True
        Me.cmbMajor.Location = New System.Drawing.Point(390, 52)
        Me.cmbMajor.Name = "cmbMajor"
        Me.cmbMajor.Size = New System.Drawing.Size(170, 24)
        Me.cmbMajor.TabIndex = 224
        '
        'cmbgenavTo
        '
        Me.cmbgenavTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgenavTo.FormattingEnabled = True
        Me.cmbgenavTo.Location = New System.Drawing.Point(220, 84)
        Me.cmbgenavTo.Name = "cmbgenavTo"
        Me.cmbgenavTo.Size = New System.Drawing.Size(115, 23)
        Me.cmbgenavTo.TabIndex = 580
        '
        'cmbCourse
        '
        Me.cmbCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(53, 52)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(283, 24)
        Me.cmbCourse.TabIndex = 4
        '
        'cmbgenavFrom
        '
        Me.cmbgenavFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgenavFrom.FormattingEnabled = True
        Me.cmbgenavFrom.Location = New System.Drawing.Point(86, 83)
        Me.cmbgenavFrom.Name = "cmbgenavFrom"
        Me.cmbgenavFrom.Size = New System.Drawing.Size(115, 23)
        Me.cmbgenavFrom.TabIndex = 576
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 572
        Me.Label5.Text = "Gen. Ave."
        '
        'semester
        '
        Me.semester.Controls.Add(Me.summer)
        Me.semester.Controls.Add(Me.secondsem)
        Me.semester.Controls.Add(Me.firstsem)
        Me.semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semester.Location = New System.Drawing.Point(205, 12)
        Me.semester.Name = "semester"
        Me.semester.Size = New System.Drawing.Size(355, 36)
        Me.semester.TabIndex = 220
        Me.semester.TabStop = False
        '
        'summer
        '
        Me.summer.AutoSize = True
        Me.summer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summer.Location = New System.Drawing.Point(267, 11)
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
        Me.secondsem.Location = New System.Drawing.Point(134, 11)
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
        Me.firstsem.Location = New System.Drawing.Point(15, 11)
        Me.firstsem.Name = "firstsem"
        Me.firstsem.Size = New System.Drawing.Size(97, 19)
        Me.firstsem.TabIndex = 3
        Me.firstsem.TabStop = True
        Me.firstsem.Text = "1st Semester"
        Me.firstsem.UseVisualStyleBackColor = True
        '
        'level
        '
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(53, 25)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(114, 23)
        Me.level.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 16)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = " Level"
        '
        'shsOption
        '
        Me.shsOption.AutoSize = True
        Me.shsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shsOption.Location = New System.Drawing.Point(266, 18)
        Me.shsOption.Name = "shsOption"
        Me.shsOption.Size = New System.Drawing.Size(136, 20)
        Me.shsOption.TabIndex = 218
        Me.shsOption.TabStop = True
        Me.shsOption.Text = "Senior Highschool"
        Me.shsOption.UseVisualStyleBackColor = True
        '
        'jhsOption
        '
        Me.jhsOption.AutoSize = True
        Me.jhsOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jhsOption.Location = New System.Drawing.Point(116, 18)
        Me.jhsOption.Name = "jhsOption"
        Me.jhsOption.Size = New System.Drawing.Size(133, 20)
        Me.jhsOption.TabIndex = 217
        Me.jhsOption.TabStop = True
        Me.jhsOption.Text = "Junior Highschool"
        Me.jhsOption.UseVisualStyleBackColor = True
        '
        'elemOption
        '
        Me.elemOption.AutoSize = True
        Me.elemOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elemOption.Location = New System.Drawing.Point(9, 17)
        Me.elemOption.Name = "elemOption"
        Me.elemOption.Size = New System.Drawing.Size(94, 20)
        Me.elemOption.TabIndex = 216
        Me.elemOption.TabStop = True
        Me.elemOption.Text = "Elementary"
        Me.elemOption.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.allOption)
        Me.GroupBox3.Controls.Add(Me.elemOption)
        Me.GroupBox3.Controls.Add(Me.jhsOption)
        Me.GroupBox3.Controls.Add(Me.shsOption)
        Me.GroupBox3.Controls.Add(Me.collegeOption)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(571, 41)
        Me.GroupBox3.TabIndex = 220
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Level"
        '
        'allOption
        '
        Me.allOption.AutoSize = True
        Me.allOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allOption.Location = New System.Drawing.Point(523, 17)
        Me.allOption.Name = "allOption"
        Me.allOption.Size = New System.Drawing.Size(41, 20)
        Me.allOption.TabIndex = 220
        Me.allOption.TabStop = True
        Me.allOption.Text = "All"
        Me.allOption.UseVisualStyleBackColor = True
        '
        'collegeOption
        '
        Me.collegeOption.AutoSize = True
        Me.collegeOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collegeOption.Location = New System.Drawing.Point(429, 18)
        Me.collegeOption.Name = "collegeOption"
        Me.collegeOption.Size = New System.Drawing.Size(73, 20)
        Me.collegeOption.TabIndex = 219
        Me.collegeOption.TabStop = True
        Me.collegeOption.Text = "College"
        Me.collegeOption.UseVisualStyleBackColor = True
        '
        'dgvunsection
        '
        Me.dgvunsection.AllowUserToAddRows = False
        Me.dgvunsection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvunsection.Location = New System.Drawing.Point(20, 155)
        Me.dgvunsection.Name = "dgvunsection"
        Me.dgvunsection.Size = New System.Drawing.Size(571, 489)
        Me.dgvunsection.TabIndex = 571
        '
        'dgvsection
        '
        Me.dgvsection.AllowUserToAddRows = False
        Me.dgvsection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsection.Location = New System.Drawing.Point(694, 12)
        Me.dgvsection.Name = "dgvsection"
        Me.dgvsection.Size = New System.Drawing.Size(427, 632)
        Me.dgvsection.TabIndex = 582
        '
        'btnUnSection
        '
        Me.btnUnSection.BackgroundImage = Global.srcregistrar.My.Resources.Resources.left
        Me.btnUnSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnSection.Location = New System.Drawing.Point(597, 399)
        Me.btnUnSection.Name = "btnUnSection"
        Me.btnUnSection.Size = New System.Drawing.Size(91, 73)
        Me.btnUnSection.TabIndex = 584
        Me.btnUnSection.UseVisualStyleBackColor = True
        '
        'btnClassSection
        '
        Me.btnClassSection.BackgroundImage = Global.srcregistrar.My.Resources.Resources.right
        Me.btnClassSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassSection.Location = New System.Drawing.Point(597, 290)
        Me.btnClassSection.Name = "btnClassSection"
        Me.btnClassSection.Size = New System.Drawing.Size(91, 73)
        Me.btnClassSection.TabIndex = 583
        Me.btnClassSection.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(619, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 585
        Me.Label6.Text = "Assign"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(595, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 15)
        Me.Label7.TabIndex = 586
        Me.Label7.Text = "Class Section"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(595, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 588
        Me.Label8.Text = "Class Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(596, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 587
        Me.Label9.Text = "Remove from"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFemale)
        Me.GroupBox1.Controls.Add(Me.lblMale)
        Me.GroupBox1.Controls.Add(Me.lblTotalStudents)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 645)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 43)
        Me.GroupBox1.TabIndex = 223
        Me.GroupBox1.TabStop = False
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.Maroon
        Me.lblFemale.Location = New System.Drawing.Point(487, 18)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(16, 16)
        Me.lblFemale.TabIndex = 589
        Me.lblFemale.Text = "0"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.Maroon
        Me.lblMale.Location = New System.Drawing.Point(329, 18)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(16, 16)
        Me.lblMale.TabIndex = 588
        Me.lblMale.Text = "0"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalStudents.Location = New System.Drawing.Point(157, 19)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(16, 16)
        Me.lblTotalStudents.TabIndex = 587
        Me.lblTotalStudents.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(425, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 586
        Me.Label12.Text = "Female:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(287, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 585
        Me.Label11.Text = "Male:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 16)
        Me.Label10.TabIndex = 584
        Me.Label10.Text = "Total No. of Students:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFemaleSection)
        Me.GroupBox2.Controls.Add(Me.lblMaleSection)
        Me.GroupBox2.Controls.Add(Me.lblTotalStudentsSection)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(694, 647)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 43)
        Me.GroupBox2.TabIndex = 588
        Me.GroupBox2.TabStop = False
        '
        'lblFemaleSection
        '
        Me.lblFemaleSection.AutoSize = True
        Me.lblFemaleSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemaleSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblFemaleSection.Location = New System.Drawing.Point(371, 21)
        Me.lblFemaleSection.Name = "lblFemaleSection"
        Me.lblFemaleSection.Size = New System.Drawing.Size(16, 16)
        Me.lblFemaleSection.TabIndex = 591
        Me.lblFemaleSection.Text = "0"
        '
        'lblMaleSection
        '
        Me.lblMaleSection.AutoSize = True
        Me.lblMaleSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblMaleSection.Location = New System.Drawing.Point(255, 19)
        Me.lblMaleSection.Name = "lblMaleSection"
        Me.lblMaleSection.Size = New System.Drawing.Size(16, 16)
        Me.lblMaleSection.TabIndex = 590
        Me.lblMaleSection.Text = "0"
        '
        'lblTotalStudentsSection
        '
        Me.lblTotalStudentsSection.AutoSize = True
        Me.lblTotalStudentsSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudentsSection.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalStudentsSection.Location = New System.Drawing.Point(157, 19)
        Me.lblTotalStudentsSection.Name = "lblTotalStudentsSection"
        Me.lblTotalStudentsSection.Size = New System.Drawing.Size(16, 16)
        Me.lblTotalStudentsSection.TabIndex = 587
        Me.lblTotalStudentsSection.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(312, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 586
        Me.Label14.Text = "Female:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(213, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 585
        Me.Label15.Text = "Male:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 16)
        Me.Label16.TabIndex = 584
        Me.Label16.Text = "Total No. of Students:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(599, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 589
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSectioning
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1133, 698)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnUnSection)
        Me.Controls.Add(Me.btnClassSection)
        Me.Controls.Add(Me.dgvsection)
        Me.Controls.Add(Me.dgvunsection)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.admissioninfo)
        Me.Controls.Add(Me.student)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSectioning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admission"
        Me.admissioninfo.ResumeLayout(False)
        Me.admissioninfo.PerformLayout()
        Me.semester.ResumeLayout(False)
        Me.semester.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvunsection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents student As System.Windows.Forms.Label
    Friend WithEvents admissioninfo As System.Windows.Forms.GroupBox
    Friend WithEvents level As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents semester As System.Windows.Forms.GroupBox
    Friend WithEvents secondsem As System.Windows.Forms.RadioButton
    Friend WithEvents firstsem As System.Windows.Forms.RadioButton
    Friend WithEvents shsOption As System.Windows.Forms.RadioButton
    Friend WithEvents jhsOption As System.Windows.Forms.RadioButton
    Friend WithEvents elemOption As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMajor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents summer As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents collegeOption As System.Windows.Forms.RadioButton
    Friend WithEvents dgvunsection As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbgenavFrom As System.Windows.Forms.ComboBox
    Friend WithEvents allOption As System.Windows.Forms.RadioButton
    Friend WithEvents cmbgenavTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvsection As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnClassSection As System.Windows.Forms.Button
    Friend WithEvents btnUnSection As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalStudents As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalStudentsSection As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents lblFemaleSection As System.Windows.Forms.Label
    Friend WithEvents lblMaleSection As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
