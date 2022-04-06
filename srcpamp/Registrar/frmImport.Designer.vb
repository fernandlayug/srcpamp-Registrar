<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.cmbsheet = New System.Windows.Forms.ComboBox()
        Me.dgvReg = New System.Windows.Forms.DataGridView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.PersonalDetails = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.txt_m_mname = New System.Windows.Forms.TextBox()
        Me.txt_m_fname = New System.Windows.Forms.TextBox()
        Me.txt_m_lname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_f_mname = New System.Windows.Forms.TextBox()
        Me.txt_f_fname = New System.Windows.Forms.TextBox()
        Me.txt_f_lname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtzipcode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBirthplace = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLRN = New System.Windows.Forms.TextBox()
        Me.txtaddress3 = New System.Windows.Forms.TextBox()
        Me.txtaddress2 = New System.Windows.Forms.TextBox()
        Me.txtaddress1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.studentid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.req5 = New System.Windows.Forms.LinkLabel()
        Me.req4 = New System.Windows.Forms.LinkLabel()
        Me.req3 = New System.Windows.Forms.LinkLabel()
        Me.req2 = New System.Windows.Forms.LinkLabel()
        Me.req1 = New System.Windows.Forms.LinkLabel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.last_eid = New System.Windows.Forms.TextBox()
        Me.datetoday = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnResend = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.dgvReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(391, 20)
        Me.txtPath.TabIndex = 0
        '
        'cmbsheet
        '
        Me.cmbsheet.FormattingEnabled = True
        Me.cmbsheet.Location = New System.Drawing.Point(12, 38)
        Me.cmbsheet.Name = "cmbsheet"
        Me.cmbsheet.Size = New System.Drawing.Size(224, 21)
        Me.cmbsheet.TabIndex = 1
        '
        'dgvReg
        '
        Me.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReg.Location = New System.Drawing.Point(12, 65)
        Me.dgvReg.Name = "dgvReg"
        Me.dgvReg.Size = New System.Drawing.Size(608, 513)
        Me.dgvReg.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(423, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(99, 20)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(242, 39)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(99, 20)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'PersonalDetails
        '
        Me.PersonalDetails.Controls.Add(Me.Label15)
        Me.PersonalDetails.Controls.Add(Me.txtGuardian)
        Me.PersonalDetails.Controls.Add(Me.txt_m_mname)
        Me.PersonalDetails.Controls.Add(Me.txt_m_fname)
        Me.PersonalDetails.Controls.Add(Me.txt_m_lname)
        Me.PersonalDetails.Controls.Add(Me.Label14)
        Me.PersonalDetails.Controls.Add(Me.txt_f_mname)
        Me.PersonalDetails.Controls.Add(Me.txt_f_fname)
        Me.PersonalDetails.Controls.Add(Me.txt_f_lname)
        Me.PersonalDetails.Controls.Add(Me.Label13)
        Me.PersonalDetails.Controls.Add(Me.txtCitizenship)
        Me.PersonalDetails.Controls.Add(Me.Label11)
        Me.PersonalDetails.Controls.Add(Me.txtReligion)
        Me.PersonalDetails.Controls.Add(Me.Label12)
        Me.PersonalDetails.Controls.Add(Me.txtMobileNo)
        Me.PersonalDetails.Controls.Add(Me.Label10)
        Me.PersonalDetails.Controls.Add(Me.txtzipcode)
        Me.PersonalDetails.Controls.Add(Me.Label9)
        Me.PersonalDetails.Controls.Add(Me.txtBirthplace)
        Me.PersonalDetails.Controls.Add(Me.Label8)
        Me.PersonalDetails.Controls.Add(Me.Label7)
        Me.PersonalDetails.Controls.Add(Me.txtLRN)
        Me.PersonalDetails.Controls.Add(Me.txtaddress3)
        Me.PersonalDetails.Controls.Add(Me.txtaddress2)
        Me.PersonalDetails.Controls.Add(Me.txtaddress1)
        Me.PersonalDetails.Controls.Add(Me.Label6)
        Me.PersonalDetails.Controls.Add(Me.txtaddress)
        Me.PersonalDetails.Controls.Add(Me.txtBirthday)
        Me.PersonalDetails.Controls.Add(Me.Label5)
        Me.PersonalDetails.Controls.Add(Me.txtGender)
        Me.PersonalDetails.Controls.Add(Me.Label4)
        Me.PersonalDetails.Controls.Add(Me.Label3)
        Me.PersonalDetails.Controls.Add(Me.txtMiddlename)
        Me.PersonalDetails.Controls.Add(Me.Label2)
        Me.PersonalDetails.Controls.Add(Me.txtFirstname)
        Me.PersonalDetails.Controls.Add(Me.Label1)
        Me.PersonalDetails.Controls.Add(Me.txtLastname)
        Me.PersonalDetails.Location = New System.Drawing.Point(631, 11)
        Me.PersonalDetails.Name = "PersonalDetails"
        Me.PersonalDetails.Size = New System.Drawing.Size(397, 354)
        Me.PersonalDetails.TabIndex = 5
        Me.PersonalDetails.TabStop = False
        Me.PersonalDetails.Text = "Personal Information"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 333)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Guardian"
        '
        'txtGuardian
        '
        Me.txtGuardian.Location = New System.Drawing.Point(85, 329)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.ReadOnly = True
        Me.txtGuardian.Size = New System.Drawing.Size(300, 20)
        Me.txtGuardian.TabIndex = 36
        '
        'txt_m_mname
        '
        Me.txt_m_mname.Location = New System.Drawing.Point(307, 303)
        Me.txt_m_mname.Name = "txt_m_mname"
        Me.txt_m_mname.ReadOnly = True
        Me.txt_m_mname.Size = New System.Drawing.Size(81, 20)
        Me.txt_m_mname.TabIndex = 35
        '
        'txt_m_fname
        '
        Me.txt_m_fname.Location = New System.Drawing.Point(193, 303)
        Me.txt_m_fname.Name = "txt_m_fname"
        Me.txt_m_fname.ReadOnly = True
        Me.txt_m_fname.Size = New System.Drawing.Size(107, 20)
        Me.txt_m_fname.TabIndex = 34
        '
        'txt_m_lname
        '
        Me.txt_m_lname.Location = New System.Drawing.Point(85, 303)
        Me.txt_m_lname.Name = "txt_m_lname"
        Me.txt_m_lname.ReadOnly = True
        Me.txt_m_lname.Size = New System.Drawing.Size(102, 20)
        Me.txt_m_lname.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 310)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Mother"
        '
        'txt_f_mname
        '
        Me.txt_f_mname.Location = New System.Drawing.Point(307, 277)
        Me.txt_f_mname.Name = "txt_f_mname"
        Me.txt_f_mname.ReadOnly = True
        Me.txt_f_mname.Size = New System.Drawing.Size(81, 20)
        Me.txt_f_mname.TabIndex = 31
        '
        'txt_f_fname
        '
        Me.txt_f_fname.Location = New System.Drawing.Point(193, 277)
        Me.txt_f_fname.Name = "txt_f_fname"
        Me.txt_f_fname.ReadOnly = True
        Me.txt_f_fname.Size = New System.Drawing.Size(107, 20)
        Me.txt_f_fname.TabIndex = 30
        '
        'txt_f_lname
        '
        Me.txt_f_lname.Location = New System.Drawing.Point(85, 277)
        Me.txt_f_lname.Name = "txt_f_lname"
        Me.txt_f_lname.ReadOnly = True
        Me.txt_f_lname.Size = New System.Drawing.Size(102, 20)
        Me.txt_f_lname.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Father"
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Location = New System.Drawing.Point(272, 249)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.ReadOnly = True
        Me.txtCitizenship.Size = New System.Drawing.Size(114, 20)
        Me.txtCitizenship.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(207, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Citizenship"
        '
        'txtReligion
        '
        Me.txtReligion.Location = New System.Drawing.Point(85, 250)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.ReadOnly = True
        Me.txtReligion.Size = New System.Drawing.Size(120, 20)
        Me.txtReligion.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Religion"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(248, 223)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.ReadOnly = True
        Me.txtMobileNo.Size = New System.Drawing.Size(140, 20)
        Me.txtMobileNo.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Mobile No."
        '
        'txtzipcode
        '
        Me.txtzipcode.Location = New System.Drawing.Point(85, 223)
        Me.txtzipcode.Name = "txtzipcode"
        Me.txtzipcode.ReadOnly = True
        Me.txtzipcode.Size = New System.Drawing.Size(92, 20)
        Me.txtzipcode.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Zip Code"
        '
        'txtBirthplace
        '
        Me.txtBirthplace.Location = New System.Drawing.Point(85, 144)
        Me.txtBirthplace.Name = "txtBirthplace"
        Me.txtBirthplace.ReadOnly = True
        Me.txtBirthplace.Size = New System.Drawing.Size(301, 20)
        Me.txtBirthplace.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "BirthPlace"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "LRN"
        '
        'txtLRN
        '
        Me.txtLRN.Location = New System.Drawing.Point(85, 17)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.ReadOnly = True
        Me.txtLRN.Size = New System.Drawing.Size(300, 20)
        Me.txtLRN.TabIndex = 16
        '
        'txtaddress3
        '
        Me.txtaddress3.Location = New System.Drawing.Point(248, 197)
        Me.txtaddress3.Name = "txtaddress3"
        Me.txtaddress3.ReadOnly = True
        Me.txtaddress3.Size = New System.Drawing.Size(137, 20)
        Me.txtaddress3.TabIndex = 15
        '
        'txtaddress2
        '
        Me.txtaddress2.Location = New System.Drawing.Point(85, 197)
        Me.txtaddress2.Name = "txtaddress2"
        Me.txtaddress2.ReadOnly = True
        Me.txtaddress2.Size = New System.Drawing.Size(157, 20)
        Me.txtaddress2.TabIndex = 14
        '
        'txtaddress1
        '
        Me.txtaddress1.Location = New System.Drawing.Point(248, 171)
        Me.txtaddress1.Name = "txtaddress1"
        Me.txtaddress1.ReadOnly = True
        Me.txtaddress1.Size = New System.Drawing.Size(137, 20)
        Me.txtaddress1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(85, 171)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(157, 20)
        Me.txtaddress.TabIndex = 11
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(272, 117)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.ReadOnly = True
        Me.txtBirthday.Size = New System.Drawing.Size(114, 20)
        Me.txtBirthday.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Birthday"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(85, 117)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(92, 20)
        Me.txtGender.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Middle Name"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Location = New System.Drawing.Point(85, 93)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.ReadOnly = True
        Me.txtMiddlename.Size = New System.Drawing.Size(300, 20)
        Me.txtMiddlename.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Firstname"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(85, 67)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(300, 20)
        Me.txtFirstname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LastName"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(85, 42)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.ReadOnly = True
        Me.txtLastname.Size = New System.Drawing.Size(300, 20)
        Me.txtLastname.TabIndex = 0
        '
        'studentid
        '
        Me.studentid.Location = New System.Drawing.Point(546, 43)
        Me.studentid.Name = "studentid"
        Me.studentid.ReadOnly = True
        Me.studentid.Size = New System.Drawing.Size(74, 20)
        Me.studentid.TabIndex = 39
        Me.studentid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.req5)
        Me.GroupBox1.Controls.Add(Me.req4)
        Me.GroupBox1.Controls.Add(Me.req3)
        Me.GroupBox1.Controls.Add(Me.req2)
        Me.GroupBox1.Controls.Add(Me.req1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(631, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 131)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requirements"
        '
        'req5
        '
        Me.req5.AutoSize = True
        Me.req5.Location = New System.Drawing.Point(31, 108)
        Me.req5.Name = "req5"
        Me.req5.Size = New System.Drawing.Size(10, 13)
        Me.req5.TabIndex = 9
        Me.req5.TabStop = True
        Me.req5.Text = "-"
        '
        'req4
        '
        Me.req4.AutoSize = True
        Me.req4.Location = New System.Drawing.Point(31, 87)
        Me.req4.Name = "req4"
        Me.req4.Size = New System.Drawing.Size(10, 13)
        Me.req4.TabIndex = 8
        Me.req4.TabStop = True
        Me.req4.Text = "-"
        '
        'req3
        '
        Me.req3.AutoSize = True
        Me.req3.Location = New System.Drawing.Point(31, 65)
        Me.req3.Name = "req3"
        Me.req3.Size = New System.Drawing.Size(10, 13)
        Me.req3.TabIndex = 7
        Me.req3.TabStop = True
        Me.req3.Text = "-"
        '
        'req2
        '
        Me.req2.AutoSize = True
        Me.req2.Location = New System.Drawing.Point(31, 42)
        Me.req2.Name = "req2"
        Me.req2.Size = New System.Drawing.Size(10, 13)
        Me.req2.TabIndex = 6
        Me.req2.TabStop = True
        Me.req2.Text = "-"
        '
        'req1
        '
        Me.req1.AutoSize = True
        Me.req1.Location = New System.Drawing.Point(30, 21)
        Me.req1.Name = "req1"
        Me.req1.Size = New System.Drawing.Size(10, 13)
        Me.req1.TabIndex = 5
        Me.req1.TabStop = True
        Me.req1.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "5."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "4."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "3."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "2."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "1."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(913, 508)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(106, 34)
        Me.btnRegister.TabIndex = 7
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseMnemonic = False
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'last_eid
        '
        Me.last_eid.Location = New System.Drawing.Point(466, 42)
        Me.last_eid.Name = "last_eid"
        Me.last_eid.ReadOnly = True
        Me.last_eid.Size = New System.Drawing.Size(74, 20)
        Me.last_eid.TabIndex = 38
        Me.last_eid.Visible = False
        '
        'datetoday
        '
        Me.datetoday.Location = New System.Drawing.Point(528, 11)
        Me.datetoday.Name = "datetoday"
        Me.datetoday.ReadOnly = True
        Me.datetoday.Size = New System.Drawing.Size(74, 20)
        Me.datetoday.TabIndex = 40
        Me.datetoday.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.lblStatus.Location = New System.Drawing.Point(347, 43)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 40
        '
        'btnResend
        '
        Me.btnResend.Enabled = False
        Me.btnResend.Location = New System.Drawing.Point(689, 508)
        Me.btnResend.Name = "btnResend"
        Me.btnResend.Size = New System.Drawing.Size(106, 34)
        Me.btnResend.TabIndex = 41
        Me.btnResend.Text = "ReSend Email"
        Me.btnResend.UseMnemonic = False
        Me.btnResend.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(801, 508)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(106, 34)
        Me.btnPrint.TabIndex = 42
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseMnemonic = False
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 590)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnResend)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.studentid)
        Me.Controls.Add(Me.datetoday)
        Me.Controls.Add(Me.last_eid)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PersonalDetails)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.dgvReg)
        Me.Controls.Add(Me.cmbsheet)
        Me.Controls.Add(Me.txtPath)
        Me.Name = "frmImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Registration"
        CType(Me.dgvReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalDetails.ResumeLayout(False)
        Me.PersonalDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPath As TextBox
    Friend WithEvents cmbsheet As ComboBox
    Friend WithEvents dgvReg As DataGridView
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents PersonalDetails As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtGuardian As TextBox
    Friend WithEvents txt_m_mname As TextBox
    Friend WithEvents txt_m_fname As TextBox
    Friend WithEvents txt_m_lname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_f_mname As TextBox
    Friend WithEvents txt_f_fname As TextBox
    Friend WithEvents txt_f_lname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReligion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtzipcode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBirthplace As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLRN As TextBox
    Friend WithEvents txtaddress3 As TextBox
    Friend WithEvents txtaddress2 As TextBox
    Friend WithEvents txtaddress1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents req5 As LinkLabel
    Friend WithEvents req4 As LinkLabel
    Friend WithEvents req3 As LinkLabel
    Friend WithEvents req2 As LinkLabel
    Friend WithEvents req1 As LinkLabel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnRegister As Button
    Friend WithEvents last_eid As TextBox
    Friend WithEvents studentid As TextBox
    Friend WithEvents datetoday As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnResend As Button
    Friend WithEvents btnPrint As Button
End Class
