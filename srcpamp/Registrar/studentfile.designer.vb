﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentfile))
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
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtCategoryA = New System.Windows.Forms.TextBox()
        Me.sex = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.bdateOLD = New System.Windows.Forms.TextBox()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnchangesched = New System.Windows.Forms.Button()
        Me.btntransferout = New System.Windows.Forms.Button()
        Me.btndropstudent = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtcourseid = New System.Windows.Forms.TextBox()
        Me.dtsubjects = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtlabunits = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtlecunits = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttotalunits = New System.Windows.Forms.TextBox()
        Me.txttotalsubjects = New System.Windows.Forms.TextBox()
        Me.admissioninfoB = New System.Windows.Forms.GroupBox()
        Me.txtCAYlabelA = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtSemester = New System.Windows.Forms.TextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.txtSY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.commentbox = New System.Windows.Forms.GroupBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.ComboBox()
        Me.lda = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.paperSize = New System.Windows.Forms.Label()
        Me.printerName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pcname = New System.Windows.Forms.Label()
        Me.txtGradingID = New System.Windows.Forms.TextBox()
        Me.txtsubjectID = New System.Windows.Forms.TextBox()
        Me.classscheduleid = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.cmbSection = New System.Windows.Forms.ComboBox()
        Me.btnsection = New System.Windows.Forms.Button()
        Me.txtSectioname = New System.Windows.Forms.TextBox()
        Me.picstudent = New System.Windows.Forms.PictureBox()
        Me.btnChangeCourse = New System.Windows.Forms.Button()
        Me.dgvEnrollment = New System.Windows.Forms.DataGridView()
        Me.txtlevelid = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.StudentInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtsubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.admissioninfoB.SuspendLayout()
        Me.commentbox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'surname
        '
        Me.surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(99, 58)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(396, 20)
        Me.surname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(678, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date of Birth"
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sex"
        '
        'btnDrop
        '
        Me.btnDrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrop.ForeColor = System.Drawing.Color.Blue
        Me.btnDrop.Location = New System.Drawing.Point(371, 6)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(69, 43)
        Me.btnDrop.TabIndex = 18
        Me.btnDrop.Text = "Drop Subject"
        Me.btnDrop.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(1020, 142)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(0, 39)
        Me.student.TabIndex = 41
        Me.student.Visible = False
        '
        'birthday
        '
        Me.birthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday.Location = New System.Drawing.Point(771, 58)
        Me.birthday.Mask = "00/00/0000"
        Me.birthday.Name = "birthday"
        Me.birthday.ReadOnly = True
        Me.birthday.Size = New System.Drawing.Size(177, 20)
        Me.birthday.TabIndex = 8
        Me.birthday.ValidatingType = GetType(Date)
        Me.birthday.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Name"
        '
        'studid
        '
        Me.studid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studid.Location = New System.Drawing.Point(99, 35)
        Me.studid.Name = "studid"
        Me.studid.Size = New System.Drawing.Size(169, 21)
        Me.studid.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(13, 39)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 15)
        Me.Label26.TabIndex = 65
        Me.Label26.Text = "Student ID"
        '
        'StudentInfo
        '
        Me.StudentInfo.Controls.Add(Me.txtCategory)
        Me.StudentInfo.Controls.Add(Me.Label24)
        Me.StudentInfo.Controls.Add(Me.txtStatus)
        Me.StudentInfo.Controls.Add(Me.Label29)
        Me.StudentInfo.Controls.Add(Me.Label9)
        Me.StudentInfo.Controls.Add(Me.TextBox2)
        Me.StudentInfo.Controls.Add(Me.txtCategoryA)
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
        Me.StudentInfo.Location = New System.Drawing.Point(31, 6)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(978, 85)
        Me.StudentInfo.TabIndex = 66
        Me.StudentInfo.TabStop = False
        Me.StudentInfo.Text = "Student Information"
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(790, 0)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(158, 23)
        Me.txtCategory.TabIndex = 569
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(721, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 15)
        Me.Label24.TabIndex = 581
        Me.Label24.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(772, 33)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(176, 21)
        Me.txtStatus.TabIndex = 580
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(133, 17)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(133, 13)
        Me.Label29.TabIndex = 579
        Me.Label29.Text = "Press F3 to search student"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(505, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 568
        Me.Label9.Text = "ESC No"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(576, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(141, 21)
        Me.TextBox2.TabIndex = 567
        '
        'txtCategoryA
        '
        Me.txtCategoryA.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCategoryA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCategoryA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCategoryA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoryA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryA.Location = New System.Drawing.Point(654, 0)
        Me.txtCategoryA.Name = "txtCategoryA"
        Me.txtCategoryA.ReadOnly = True
        Me.txtCategoryA.Size = New System.Drawing.Size(130, 23)
        Me.txtCategoryA.TabIndex = 569
        '
        'sex
        '
        Me.sex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex.Location = New System.Drawing.Point(543, 58)
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Size = New System.Drawing.Size(128, 20)
        Me.sex.TabIndex = 566
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(272, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 15)
        Me.Label18.TabIndex = 565
        Me.Label18.Text = "LRN"
        '
        'bdateOLD
        '
        Me.bdateOLD.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.bdateOLD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bdateOLD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.bdateOLD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.bdateOLD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdateOLD.Location = New System.Drawing.Point(771, 58)
        Me.bdateOLD.Name = "bdateOLD"
        Me.bdateOLD.ReadOnly = True
        Me.bdateOLD.Size = New System.Drawing.Size(177, 20)
        Me.bdateOLD.TabIndex = 64
        Me.bdateOLD.Visible = False
        '
        'txtLRN
        '
        Me.txtLRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.Location = New System.Drawing.Point(318, 33)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.ReadOnly = True
        Me.txtLRN.Size = New System.Drawing.Size(177, 21)
        Me.txtLRN.TabIndex = 564
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Blue
        Me.btnClose.Location = New System.Drawing.Point(665, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 44)
        Me.btnClose.TabIndex = 213
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnchangesched)
        Me.Panel1.Controls.Add(Me.btntransferout)
        Me.Panel1.Controls.Add(Me.btndropstudent)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnADD)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnDrop)
        Me.Panel1.Location = New System.Drawing.Point(280, 545)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 52)
        Me.Panel1.TabIndex = 567
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(59, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 43)
        Me.Button3.TabIndex = 221
        Me.Button3.Text = "Print Classcard"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(593, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 44)
        Me.Button2.TabIndex = 220
        Me.Button2.Text = "Delete Admission"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnchangesched
        '
        Me.btnchangesched.AllowDrop = True
        Me.btnchangesched.Enabled = False
        Me.btnchangesched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangesched.ForeColor = System.Drawing.Color.Blue
        Me.btnchangesched.Location = New System.Drawing.Point(288, 5)
        Me.btnchangesched.Name = "btnchangesched"
        Me.btnchangesched.Size = New System.Drawing.Size(83, 44)
        Me.btnchangesched.TabIndex = 219
        Me.btnchangesched.Text = "Change Schedule"
        Me.btnchangesched.UseVisualStyleBackColor = True
        '
        'btntransferout
        '
        Me.btntransferout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransferout.ForeColor = System.Drawing.Color.Blue
        Me.btntransferout.Location = New System.Drawing.Point(507, 5)
        Me.btntransferout.Name = "btntransferout"
        Me.btntransferout.Size = New System.Drawing.Size(87, 44)
        Me.btntransferout.TabIndex = 218
        Me.btntransferout.Text = "Transfer Out"
        Me.btntransferout.UseVisualStyleBackColor = True
        '
        'btndropstudent
        '
        Me.btndropstudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndropstudent.ForeColor = System.Drawing.Color.Blue
        Me.btndropstudent.Location = New System.Drawing.Point(439, 5)
        Me.btndropstudent.Name = "btndropstudent"
        Me.btndropstudent.Size = New System.Drawing.Size(69, 44)
        Me.btndropstudent.TabIndex = 217
        Me.btndropstudent.Text = "Drop Student"
        Me.btndropstudent.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Blue
        Me.btnRemove.Location = New System.Drawing.Point(131, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(85, 44)
        Me.btnRemove.TabIndex = 216
        Me.btnRemove.Text = "Remove Subject"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.Color.Blue
        Me.btnADD.Location = New System.Drawing.Point(215, 5)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(73, 44)
        Me.btnADD.TabIndex = 215
        Me.btnADD.Text = "Add Subject"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Blue
        Me.btnPrint.Location = New System.Drawing.Point(2, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(58, 43)
        Me.btnPrint.TabIndex = 214
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtcourseid
        '
        Me.txtcourseid.Enabled = False
        Me.txtcourseid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourseid.Location = New System.Drawing.Point(1083, 38)
        Me.txtcourseid.Name = "txtcourseid"
        Me.txtcourseid.Size = New System.Drawing.Size(62, 24)
        Me.txtcourseid.TabIndex = 570
        Me.txtcourseid.Visible = False
        '
        'dtsubjects
        '
        Me.dtsubjects.AllowUserToAddRows = False
        Me.dtsubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtsubjects.Location = New System.Drawing.Point(31, 247)
        Me.dtsubjects.Name = "dtsubjects"
        Me.dtsubjects.Size = New System.Drawing.Size(978, 224)
        Me.dtsubjects.TabIndex = 568
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 567
        Me.Label5.Text = "Total No. of Subjects"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 569
        Me.Label7.Text = "Total No. of Units"
        '
        'txtlabunits
        '
        Me.txtlabunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlabunits.Location = New System.Drawing.Point(454, 512)
        Me.txtlabunits.Name = "txtlabunits"
        Me.txtlabunits.ReadOnly = True
        Me.txtlabunits.Size = New System.Drawing.Size(72, 24)
        Me.txtlabunits.TabIndex = 574
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 16)
        Me.Label8.TabIndex = 573
        Me.Label8.Text = "Laboratory Units Enrolled"
        '
        'txtlecunits
        '
        Me.txtlecunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlecunits.Location = New System.Drawing.Point(454, 482)
        Me.txtlecunits.Name = "txtlecunits"
        Me.txtlecunits.ReadOnly = True
        Me.txtlecunits.Size = New System.Drawing.Size(72, 24)
        Me.txtlecunits.TabIndex = 572
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 490)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 16)
        Me.Label10.TabIndex = 571
        Me.Label10.Text = "Lecture Units Enrolled"
        '
        'txttotalunits
        '
        Me.txttotalunits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalunits.Location = New System.Drawing.Point(181, 511)
        Me.txttotalunits.Name = "txttotalunits"
        Me.txttotalunits.ReadOnly = True
        Me.txttotalunits.Size = New System.Drawing.Size(72, 24)
        Me.txttotalunits.TabIndex = 576
        '
        'txttotalsubjects
        '
        Me.txttotalsubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalsubjects.Location = New System.Drawing.Point(181, 481)
        Me.txttotalsubjects.Name = "txttotalsubjects"
        Me.txttotalsubjects.ReadOnly = True
        Me.txttotalsubjects.Size = New System.Drawing.Size(72, 24)
        Me.txttotalsubjects.TabIndex = 575
        '
        'admissioninfoB
        '
        Me.admissioninfoB.Controls.Add(Me.txtCAYlabelA)
        Me.admissioninfoB.Controls.Add(Me.Label35)
        Me.admissioninfoB.Controls.Add(Me.txtSemester)
        Me.admissioninfoB.Controls.Add(Me.txtMajor)
        Me.admissioninfoB.Controls.Add(Me.txtCourse)
        Me.admissioninfoB.Controls.Add(Me.txtLevel)
        Me.admissioninfoB.Controls.Add(Me.txtSY)
        Me.admissioninfoB.Controls.Add(Me.Label11)
        Me.admissioninfoB.Controls.Add(Me.Label12)
        Me.admissioninfoB.Controls.Add(Me.txtCourseCode)
        Me.admissioninfoB.Controls.Add(Me.Label13)
        Me.admissioninfoB.Controls.Add(Me.Label14)
        Me.admissioninfoB.Controls.Add(Me.Label15)
        Me.admissioninfoB.Controls.Add(Me.Label16)
        Me.admissioninfoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admissioninfoB.Location = New System.Drawing.Point(556, 90)
        Me.admissioninfoB.Name = "admissioninfoB"
        Me.admissioninfoB.Size = New System.Drawing.Size(453, 127)
        Me.admissioninfoB.TabIndex = 570
        Me.admissioninfoB.TabStop = False
        '
        'txtCAYlabelA
        '
        Me.txtCAYlabelA.AutoSize = True
        Me.txtCAYlabelA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAYlabelA.ForeColor = System.Drawing.Color.Maroon
        Me.txtCAYlabelA.Location = New System.Drawing.Point(302, 102)
        Me.txtCAYlabelA.Name = "txtCAYlabelA"
        Me.txtCAYlabelA.Size = New System.Drawing.Size(10, 13)
        Me.txtCAYlabelA.TabIndex = 233
        Me.txtCAYlabelA.Text = "-"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Maroon
        Me.Label35.Location = New System.Drawing.Point(266, 101)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(31, 13)
        Me.Label35.TabIndex = 232
        Me.Label35.Text = "CAY:"
        '
        'txtSemester
        '
        Me.txtSemester.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSemester.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemester.Location = New System.Drawing.Point(327, 18)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.ReadOnly = True
        Me.txtSemester.Size = New System.Drawing.Size(120, 20)
        Me.txtSemester.TabIndex = 575
        '
        'txtMajor
        '
        Me.txtMajor.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMajor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMajor.Location = New System.Drawing.Point(99, 98)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.ReadOnly = True
        Me.txtMajor.Size = New System.Drawing.Size(155, 20)
        Me.txtMajor.TabIndex = 573
        '
        'txtCourse
        '
        Me.txtCourse.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(99, 72)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.ReadOnly = True
        Me.txtCourse.Size = New System.Drawing.Size(348, 20)
        Me.txtCourse.TabIndex = 572
        '
        'txtLevel
        '
        Me.txtLevel.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLevel.Location = New System.Drawing.Point(99, 46)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(123, 20)
        Me.txtLevel.TabIndex = 571
        '
        'txtSY
        '
        Me.txtSY.AutoCompleteCustomSource.AddRange(New String() {"Filipino"})
        Me.txtSY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtSY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSY.Location = New System.Drawing.Point(99, 18)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.ReadOnly = True
        Me.txtSY.Size = New System.Drawing.Size(123, 20)
        Me.txtSY.TabIndex = 570
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "School Year"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(246, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 228
        Me.Label12.Text = "Course Code"
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseCode.Location = New System.Drawing.Point(327, 46)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.ReadOnly = True
        Me.txtCourseCode.Size = New System.Drawing.Size(120, 20)
        Me.txtCourseCode.TabIndex = 227
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 225
        Me.Label13.Text = "Major/Track"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 223
        Me.Label14.Text = "Course/Program"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(246, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 221
        Me.Label15.Text = "Semester"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Year Level"
        '
        'commentbox
        '
        Me.commentbox.Controls.Add(Me.txtReason)
        Me.commentbox.Controls.Add(Me.Label32)
        Me.commentbox.Controls.Add(Me.txtComment)
        Me.commentbox.Controls.Add(Me.lda)
        Me.commentbox.Controls.Add(Me.Label31)
        Me.commentbox.Controls.Add(Me.DateTimePicker1)
        Me.commentbox.Enabled = False
        Me.commentbox.Location = New System.Drawing.Point(532, 477)
        Me.commentbox.Name = "commentbox"
        Me.commentbox.Size = New System.Drawing.Size(477, 62)
        Me.commentbox.TabIndex = 577
        Me.commentbox.TabStop = False
        Me.commentbox.Text = "Remarks"
        '
        'txtReason
        '
        Me.txtReason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(9, 31)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.ReadOnly = True
        Me.txtReason.Size = New System.Drawing.Size(323, 23)
        Me.txtReason.TabIndex = 582
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 13)
        Me.Label32.TabIndex = 594
        Me.Label32.Text = "Select Reason"
        '
        'txtComment
        '
        Me.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.FormattingEnabled = True
        Me.txtComment.Items.AddRange(New Object() {"Had to take care of siblings", "Early marriage/pregnancy", "Parents attitude toward schooling", "Family problems/feuds", "Illnes", "Overage", "Death", "Drug Abuse", "Poor academic performance", "Lack of Interest/Distractions", "Hunger/Malnutrition", "Teacher factor", "Physical conditions of classroom", "Peer Influences", "Distance between home and school", "Armed conflict", "Calamities/Disasters", "Child labor, work", "Change of residence", "Bullying", "Too large of course load", "Others", "Undetermined"})
        Me.txtComment.Location = New System.Drawing.Point(9, 31)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(341, 23)
        Me.txtComment.TabIndex = 570
        '
        'lda
        '
        Me.lda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lda.Location = New System.Drawing.Point(364, 34)
        Me.lda.Name = "lda"
        Me.lda.ReadOnly = True
        Me.lda.Size = New System.Drawing.Size(79, 20)
        Me.lda.TabIndex = 570
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(360, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(111, 13)
        Me.Label31.TabIndex = 593
        Me.Label31.Text = "Last Date Attendance"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(364, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 580
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 541)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 54)
        Me.GroupBox1.TabIndex = 579
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legend"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(224, 27)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 13)
        Me.Label28.TabIndex = 592
        Me.Label28.Text = "E"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(62, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(23, 13)
        Me.Label27.TabIndex = 590
        Me.Label27.Text = "UD"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Pink
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(44, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(18, 24)
        Me.TextBox6.TabIndex = 588
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(202, 20)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(18, 24)
        Me.TextBox7.TabIndex = 591
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(190, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 587
        Me.Label23.Text = "F"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Red
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(166, 19)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(20, 24)
        Me.TextBox5.TabIndex = 586
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(153, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 13)
        Me.Label22.TabIndex = 585
        Me.Label22.Text = "P"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Green
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(130, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(21, 24)
        Me.TextBox4.TabIndex = 584
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(106, 27)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 13)
        Me.Label21.TabIndex = 583
        Me.Label21.Text = "INC"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Yellow
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(85, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(18, 24)
        Me.TextBox3.TabIndex = 582
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 581
        Me.Label20.Text = "D"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Violet
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 24)
        Me.TextBox1.TabIndex = 580
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(172, 604)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 16)
        Me.Label17.TabIndex = 580
        Me.Label17.Text = "Printer Name:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(611, 607)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(88, 16)
        Me.Label36.TabIndex = 581
        Me.Label36.Text = "Paper Size:"
        '
        'paperSize
        '
        Me.paperSize.AutoSize = True
        Me.paperSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paperSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.paperSize.Location = New System.Drawing.Point(711, 609)
        Me.paperSize.Name = "paperSize"
        Me.paperSize.Size = New System.Drawing.Size(13, 16)
        Me.paperSize.TabIndex = 583
        Me.paperSize.Text = "-"
        '
        'printerName
        '
        Me.printerName.AutoSize = True
        Me.printerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.printerName.Location = New System.Drawing.Point(272, 606)
        Me.printerName.Name = "printerName"
        Me.printerName.Size = New System.Drawing.Size(13, 16)
        Me.printerName.TabIndex = 582
        Me.printerName.Text = "-"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(30, 597)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 29)
        Me.Button1.TabIndex = 219
        Me.Button1.Text = "Print Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pcname
        '
        Me.pcname.AutoSize = True
        Me.pcname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcname.Location = New System.Drawing.Point(178, 626)
        Me.pcname.Name = "pcname"
        Me.pcname.Size = New System.Drawing.Size(13, 16)
        Me.pcname.TabIndex = 584
        Me.pcname.Text = "-"
        Me.pcname.Visible = False
        '
        'txtGradingID
        '
        Me.txtGradingID.Enabled = False
        Me.txtGradingID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGradingID.Location = New System.Drawing.Point(1015, 9)
        Me.txtGradingID.Name = "txtGradingID"
        Me.txtGradingID.Size = New System.Drawing.Size(62, 24)
        Me.txtGradingID.TabIndex = 585
        Me.txtGradingID.Visible = False
        '
        'txtsubjectID
        '
        Me.txtsubjectID.Enabled = False
        Me.txtsubjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectID.Location = New System.Drawing.Point(1015, 34)
        Me.txtsubjectID.Name = "txtsubjectID"
        Me.txtsubjectID.Size = New System.Drawing.Size(62, 24)
        Me.txtsubjectID.TabIndex = 586
        Me.txtsubjectID.Visible = False
        '
        'classscheduleid
        '
        Me.classscheduleid.Enabled = False
        Me.classscheduleid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classscheduleid.Location = New System.Drawing.Point(1015, 62)
        Me.classscheduleid.Name = "classscheduleid"
        Me.classscheduleid.Size = New System.Drawing.Size(62, 24)
        Me.classscheduleid.TabIndex = 587
        Me.classscheduleid.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(563, 228)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 13)
        Me.Label37.TabIndex = 570
        Me.Label37.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSection.Enabled = False
        Me.cmbSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(610, 221)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(118, 21)
        Me.cmbSection.TabIndex = 569
        '
        'btnsection
        '
        Me.btnsection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsection.ForeColor = System.Drawing.Color.Blue
        Me.btnsection.Location = New System.Drawing.Point(749, 221)
        Me.btnsection.Name = "btnsection"
        Me.btnsection.Size = New System.Drawing.Size(112, 23)
        Me.btnsection.TabIndex = 220
        Me.btnsection.Text = "CHANGE SECTION"
        Me.btnsection.UseVisualStyleBackColor = True
        '
        'txtSectioname
        '
        Me.txtSectioname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSectioname.Location = New System.Drawing.Point(1083, 66)
        Me.txtSectioname.Name = "txtSectioname"
        Me.txtSectioname.ReadOnly = True
        Me.txtSectioname.Size = New System.Drawing.Size(62, 20)
        Me.txtSectioname.TabIndex = 569
        Me.txtSectioname.Visible = False
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
        'btnChangeCourse
        '
        Me.btnChangeCourse.Enabled = False
        Me.btnChangeCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeCourse.ForeColor = System.Drawing.Color.Blue
        Me.btnChangeCourse.Location = New System.Drawing.Point(881, 220)
        Me.btnChangeCourse.Name = "btnChangeCourse"
        Me.btnChangeCourse.Size = New System.Drawing.Size(125, 23)
        Me.btnChangeCourse.TabIndex = 588
        Me.btnChangeCourse.Text = "CHANGE COURSE"
        Me.btnChangeCourse.UseVisualStyleBackColor = True
        '
        'dgvEnrollment
        '
        Me.dgvEnrollment.AllowUserToAddRows = False
        Me.dgvEnrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnrollment.Location = New System.Drawing.Point(30, 98)
        Me.dgvEnrollment.Name = "dgvEnrollment"
        Me.dgvEnrollment.Size = New System.Drawing.Size(520, 140)
        Me.dgvEnrollment.TabIndex = 589
        '
        'txtlevelid
        '
        Me.txtlevelid.Enabled = False
        Me.txtlevelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlevelid.Location = New System.Drawing.Point(1083, 9)
        Me.txtlevelid.Name = "txtlevelid"
        Me.txtlevelid.Size = New System.Drawing.Size(62, 24)
        Me.txtlevelid.TabIndex = 590
        Me.txtlevelid.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1083, 92)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(62, 20)
        Me.TextBox8.TabIndex = 576
        Me.TextBox8.Visible = False
        '
        'studentfile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1023, 694)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.txtlevelid)
        Me.Controls.Add(Me.dgvEnrollment)
        Me.Controls.Add(Me.btnChangeCourse)
        Me.Controls.Add(Me.txtSectioname)
        Me.Controls.Add(Me.btnsection)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.classscheduleid)
        Me.Controls.Add(Me.txtsubjectID)
        Me.Controls.Add(Me.txtGradingID)
        Me.Controls.Add(Me.pcname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.paperSize)
        Me.Controls.Add(Me.printerName)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.commentbox)
        Me.Controls.Add(Me.txttotalunits)
        Me.Controls.Add(Me.txttotalsubjects)
        Me.Controls.Add(Me.txtlabunits)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcourseid)
        Me.Controls.Add(Me.txtlecunits)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtsubjects)
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
        Me.Text = "r"
        Me.StudentInfo.ResumeLayout(False)
        Me.StudentInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtsubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.admissioninfoB.ResumeLayout(False)
        Me.admissioninfoB.PerformLayout()
        Me.commentbox.ResumeLayout(False)
        Me.commentbox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picstudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents bdateOLD As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLRN As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents sex As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dtsubjects As System.Windows.Forms.DataGridView
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcourseid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtlabunits As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtlecunits As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txttotalunits As System.Windows.Forms.TextBox
    Friend WithEvents txttotalsubjects As System.Windows.Forms.TextBox
    Friend WithEvents admissioninfoB As System.Windows.Forms.GroupBox
    Friend WithEvents txtSemester As System.Windows.Forms.TextBox
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
    Friend WithEvents commentbox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents btndropstudent As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents btntransferout As System.Windows.Forms.Button
    Friend WithEvents lda As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.ComboBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents txtCAYlabelA As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents paperSize As System.Windows.Forms.Label
    Friend WithEvents printerName As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pcname As System.Windows.Forms.Label
    Friend WithEvents btnchangesched As System.Windows.Forms.Button
    Friend WithEvents txtGradingID As System.Windows.Forms.TextBox
    Friend WithEvents txtsubjectID As System.Windows.Forms.TextBox
    Friend WithEvents classscheduleid As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnsection As System.Windows.Forms.Button
    Friend WithEvents txtSectioname As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnChangeCourse As System.Windows.Forms.Button
    Friend WithEvents dgvEnrollment As DataGridView
    Friend WithEvents txtlevelid As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
