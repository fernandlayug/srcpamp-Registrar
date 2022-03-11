<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfacultyassign
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sy = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.designation = New System.Windows.Forms.TextBox()
        Me.department = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Cachedrefundreceipt1 = New srcregistrar.Cachedrefundreceipt()
        Me.assignment = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.time = New System.Windows.Forms.MaskedTextBox()
        Me.room = New System.Windows.Forms.ComboBox()
        Me.fri = New System.Windows.Forms.CheckBox()
        Me.thu = New System.Windows.Forms.CheckBox()
        Me.wed = New System.Windows.Forms.CheckBox()
        Me.tue = New System.Windows.Forms.CheckBox()
        Me.mon = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.ComboBox()
        Me.section = New System.Windows.Forms.ComboBox()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.faculty = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.advisory = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.assignment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.faculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(562, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 238
        Me.Label7.Text = "Active School Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(611, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(393, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Firstname"
        '
        'sy
        '
        Me.sy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sy.FormattingEnabled = True
        Me.sy.Location = New System.Drawing.Point(675, 21)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(147, 23)
        Me.sy.TabIndex = 238
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.sy)
        Me.GroupBox1.Controls.Add(Me.designation)
        Me.GroupBox1.Controls.Add(Me.department)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.surname)
        Me.GroupBox1.Controls.Add(Me.mname)
        Me.GroupBox1.Controls.Add(Me.firstname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(383, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 122)
        Me.GroupBox1.TabIndex = 232
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teacher Information"
        '
        'designation
        '
        Me.designation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.designation.Location = New System.Drawing.Point(369, 47)
        Me.designation.Name = "designation"
        Me.designation.ReadOnly = True
        Me.designation.Size = New System.Drawing.Size(167, 21)
        Me.designation.TabIndex = 244
        '
        'department
        '
        Me.department.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.Location = New System.Drawing.Point(369, 21)
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        Me.department.Size = New System.Drawing.Size(167, 21)
        Me.department.TabIndex = 243
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Department"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(290, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 242
        Me.Label11.Text = "Designation"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 20)
        Me.Label17.TabIndex = 216
        Me.Label17.Text = "Employee ID"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.Red
        Me.ID.Location = New System.Drawing.Point(140, 30)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(139, 38)
        Me.ID.TabIndex = 211
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Employee's Name"
        '
        'surname
        '
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(543, 74)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(218, 21)
        Me.surname.TabIndex = 214
        '
        'mname
        '
        Me.mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.Location = New System.Drawing.Point(369, 74)
        Me.mname.Name = "mname"
        Me.mname.ReadOnly = True
        Me.mname.Size = New System.Drawing.Size(167, 21)
        Me.mname.TabIndex = 213
        '
        'firstname
        '
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(139, 74)
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        Me.firstname.Size = New System.Drawing.Size(224, 21)
        Me.firstname.TabIndex = 212
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Location = New System.Drawing.Point(20, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 34)
        Me.Panel1.TabIndex = 272
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(17, 2)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(274, 29)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Manage Faculty Loads"
        '
        'assignment
        '
        Me.assignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.assignment.Location = New System.Drawing.Point(10, 16)
        Me.assignment.Name = "assignment"
        Me.assignment.Size = New System.Drawing.Size(816, 185)
        Me.assignment.TabIndex = 273
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.assignment)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(387, 343)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(835, 209)
        Me.GroupBox7.TabIndex = 274
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Assignment"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1117, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 29)
        Me.Button1.TabIndex = 275
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1115, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 29)
        Me.Button2.TabIndex = 276
        Me.Button2.Text = "Add Assignment"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(957, 555)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 29)
        Me.Button3.TabIndex = 277
        Me.Button3.Text = "Remove Assignment"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.time)
        Me.GroupBox2.Controls.Add(Me.room)
        Me.GroupBox2.Controls.Add(Me.fri)
        Me.GroupBox2.Controls.Add(Me.thu)
        Me.GroupBox2.Controls.Add(Me.wed)
        Me.GroupBox2.Controls.Add(Me.tue)
        Me.GroupBox2.Controls.Add(Me.mon)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.subject)
        Me.GroupBox2.Controls.Add(Me.section)
        Me.GroupBox2.Controls.Add(Me.level)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(383, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(835, 95)
        Me.GroupBox2.TabIndex = 278
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADD Assignment"
        '
        'time
        '
        Me.time.Location = New System.Drawing.Point(675, 18)
        Me.time.Mask = "90:00-90:00"
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(154, 20)
        Me.time.TabIndex = 4
        '
        'room
        '
        Me.room.FormattingEnabled = True
        Me.room.Location = New System.Drawing.Point(528, 54)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(121, 21)
        Me.room.TabIndex = 10
        Me.room.TabStop = False
        '
        'fri
        '
        Me.fri.AutoSize = True
        Me.fri.Location = New System.Drawing.Point(373, 62)
        Me.fri.Name = "fri"
        Me.fri.Size = New System.Drawing.Size(60, 17)
        Me.fri.TabIndex = 9
        Me.fri.Text = "Friday"
        Me.fri.UseVisualStyleBackColor = True
        '
        'thu
        '
        Me.thu.AutoSize = True
        Me.thu.Location = New System.Drawing.Point(291, 62)
        Me.thu.Name = "thu"
        Me.thu.Size = New System.Drawing.Size(78, 17)
        Me.thu.TabIndex = 8
        Me.thu.Text = "Thursday"
        Me.thu.UseVisualStyleBackColor = True
        '
        'wed
        '
        Me.wed.AutoSize = True
        Me.wed.Location = New System.Drawing.Point(194, 61)
        Me.wed.Name = "wed"
        Me.wed.Size = New System.Drawing.Size(92, 17)
        Me.wed.TabIndex = 7
        Me.wed.Text = "Wednesday"
        Me.wed.UseVisualStyleBackColor = True
        '
        'tue
        '
        Me.tue.AutoSize = True
        Me.tue.Location = New System.Drawing.Point(117, 61)
        Me.tue.Name = "tue"
        Me.tue.Size = New System.Drawing.Size(74, 17)
        Me.tue.TabIndex = 6
        Me.tue.Text = "Tuesday"
        Me.tue.UseVisualStyleBackColor = True
        '
        'mon
        '
        Me.mon.AutoSize = True
        Me.mon.Location = New System.Drawing.Point(41, 61)
        Me.mon.Name = "mon"
        Me.mon.Size = New System.Drawing.Size(70, 17)
        Me.mon.TabIndex = 5
        Me.mon.Text = "Monday"
        Me.mon.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(466, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Location"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Day"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(635, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(347, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Subject/Assignment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Level"
        '
        'subject
        '
        Me.subject.FormattingEnabled = True
        Me.subject.Location = New System.Drawing.Point(469, 22)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(146, 21)
        Me.subject.TabIndex = 2
        '
        'section
        '
        Me.section.FormattingEnabled = True
        Me.section.Location = New System.Drawing.Point(216, 23)
        Me.section.Name = "section"
        Me.section.Size = New System.Drawing.Size(118, 21)
        Me.section.TabIndex = 1
        '
        'level
        '
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(50, 25)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(109, 21)
        Me.level.TabIndex = 0
        '
        'faculty
        '
        Me.faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.faculty.Location = New System.Drawing.Point(20, 77)
        Me.faculty.Name = "faculty"
        Me.faculty.Size = New System.Drawing.Size(357, 475)
        Me.faculty.TabIndex = 279
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 16)
        Me.Label14.TabIndex = 280
        Me.Label14.Text = "FACUTLY"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(383, 184)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 246
        Me.Label15.Text = "Class Advisory"
        '
        'advisory
        '
        Me.advisory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advisory.Location = New System.Drawing.Point(491, 179)
        Me.advisory.Name = "advisory"
        Me.advisory.ReadOnly = True
        Me.advisory.Size = New System.Drawing.Size(224, 21)
        Me.advisory.TabIndex = 245
        '
        'frmfacultyassign
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1236, 598)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.advisory)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.faculty)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmfacultyassign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Faculty Loads"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.assignment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.faculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sy As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents designation As System.Windows.Forms.TextBox
    Friend WithEvents department As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Cachedrefundreceipt1 As srcregistrar.Cachedrefundreceipt
    Friend WithEvents assignment As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents subject As System.Windows.Forms.ComboBox
    Friend WithEvents section As System.Windows.Forms.ComboBox
    Friend WithEvents level As System.Windows.Forms.ComboBox
    Friend WithEvents fri As System.Windows.Forms.CheckBox
    Friend WithEvents thu As System.Windows.Forms.CheckBox
    Friend WithEvents wed As System.Windows.Forms.CheckBox
    Friend WithEvents tue As System.Windows.Forms.CheckBox
    Friend WithEvents mon As System.Windows.Forms.CheckBox
    Friend WithEvents room As System.Windows.Forms.ComboBox
    Friend WithEvents time As System.Windows.Forms.MaskedTextBox
    Friend WithEvents faculty As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents advisory As System.Windows.Forms.TextBox
End Class
