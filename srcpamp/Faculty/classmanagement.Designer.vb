<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classmanagement
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.femaleCOUNT = New System.Windows.Forms.Label()
        Me.maleCOUNT = New System.Windows.Forms.Label()
        Me.nos = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.female = New System.Windows.Forms.CheckBox()
        Me.male = New System.Windows.Forms.CheckBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.sex = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.section = New System.Windows.Forms.TextBox()
        Me.department = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.sectionlist = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gridparticular = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sectionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.femaleCOUNT)
        Me.Panel1.Controls.Add(Me.maleCOUNT)
        Me.Panel1.Controls.Add(Me.nos)
        Me.Panel1.Controls.Add(Me.sec)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 133)
        Me.Panel1.TabIndex = 1
        '
        'femaleCOUNT
        '
        Me.femaleCOUNT.AutoSize = True
        Me.femaleCOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleCOUNT.Location = New System.Drawing.Point(594, 73)
        Me.femaleCOUNT.Name = "femaleCOUNT"
        Me.femaleCOUNT.Size = New System.Drawing.Size(15, 20)
        Me.femaleCOUNT.TabIndex = 274
        Me.femaleCOUNT.Text = "-"
        '
        'maleCOUNT
        '
        Me.maleCOUNT.AutoSize = True
        Me.maleCOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleCOUNT.Location = New System.Drawing.Point(594, 99)
        Me.maleCOUNT.Name = "maleCOUNT"
        Me.maleCOUNT.Size = New System.Drawing.Size(15, 20)
        Me.maleCOUNT.TabIndex = 273
        Me.maleCOUNT.Text = "-"
        '
        'nos
        '
        Me.nos.AutoSize = True
        Me.nos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nos.Location = New System.Drawing.Point(594, 40)
        Me.nos.Name = "nos"
        Me.nos.Size = New System.Drawing.Size(15, 20)
        Me.nos.TabIndex = 272
        Me.nos.Text = "-"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(594, 12)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(15, 20)
        Me.sec.TabIndex = 271
        Me.sec.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.female)
        Me.GroupBox1.Controls.Add(Me.male)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.sex)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.section)
        Me.GroupBox1.Controls.Add(Me.department)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.level)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 118)
        Me.GroupBox1.TabIndex = 270
        Me.GroupBox1.TabStop = False
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(82, 88)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(60, 17)
        Me.female.TabIndex = 271
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(12, 88)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(49, 17)
        Me.male.TabIndex = 270
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(484, 84)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(43, 16)
        Me.LinkLabel3.TabIndex = 269
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Close"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(391, 84)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(83, 16)
        Me.LinkLabel2.TabIndex = 268
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Update Now"
        '
        'sex
        '
        Me.sex.AutoSize = True
        Me.sex.Location = New System.Drawing.Point(189, 80)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(10, 13)
        Me.sex.TabIndex = 266
        Me.sex.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(448, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "Section"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 264
        Me.Label2.Text = "Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Department"
        '
        'section
        '
        Me.section.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section.Location = New System.Drawing.Point(394, 25)
        Me.section.Name = "section"
        Me.section.ReadOnly = True
        Me.section.Size = New System.Drawing.Size(145, 21)
        Me.section.TabIndex = 262
        '
        'department
        '
        Me.department.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.department.Location = New System.Drawing.Point(110, 25)
        Me.department.Name = "department"
        Me.department.ReadOnly = True
        Me.department.Size = New System.Drawing.Size(137, 21)
        Me.department.TabIndex = 261
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 260
        Me.Label15.Text = "Class Advisory"
        '
        'level
        '
        Me.level.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level.Location = New System.Drawing.Point(249, 25)
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        Me.level.Size = New System.Drawing.Size(142, 21)
        Me.level.TabIndex = 259
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(555, 139)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(21, 444)
        Me.Panel4.TabIndex = 4
        '
        'sectionlist
        '
        Me.sectionlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sectionlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sectionlist.Location = New System.Drawing.Point(0, 0)
        Me.sectionlist.Name = "sectionlist"
        Me.sectionlist.Size = New System.Drawing.Size(501, 495)
        Me.sectionlist.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.gridparticular)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(562, 495)
        Me.Panel3.TabIndex = 3
        '
        'gridparticular
        '
        Me.gridparticular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridparticular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridparticular.Location = New System.Drawing.Point(0, 0)
        Me.gridparticular.Name = "gridparticular"
        Me.gridparticular.Size = New System.Drawing.Size(560, 493)
        Me.gridparticular.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.sectionlist)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(562, 133)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(501, 495)
        Me.Panel5.TabIndex = 4
        '
        'classmanagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1063, 628)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "classmanagement"
        Me.Text = "Class Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sectionlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.gridparticular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents sex As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents section As System.Windows.Forms.TextBox
    Friend WithEvents department As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents level As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents gridparticular As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents sectionlist As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents sec As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents female As System.Windows.Forms.CheckBox
    Friend WithEvents male As System.Windows.Forms.CheckBox
    Friend WithEvents nos As System.Windows.Forms.Label
    Friend WithEvents maleCOUNT As System.Windows.Forms.Label
    Friend WithEvents femaleCOUNT As System.Windows.Forms.Label
End Class
