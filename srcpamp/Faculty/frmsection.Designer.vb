<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsection
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
        Me.section = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.yrlevel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sectionlist = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.faculty = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.adviser = New System.Windows.Forms.TextBox()
        Me.updatesection = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.sectionlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.faculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'section
        '
        Me.section.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.section.Location = New System.Drawing.Point(384, 57)
        Me.section.Name = "section"
        Me.section.ReadOnly = True
        Me.section.Size = New System.Drawing.Size(195, 26)
        Me.section.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Section"
        '
        'yrlevel
        '
        Me.yrlevel.Enabled = False
        Me.yrlevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrlevel.FormattingEnabled = True
        Me.yrlevel.Location = New System.Drawing.Point(95, 54)
        Me.yrlevel.Name = "yrlevel"
        Me.yrlevel.Size = New System.Drawing.Size(195, 28)
        Me.yrlevel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Level"
        '
        'Add
        '
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Location = New System.Drawing.Point(387, 440)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(88, 21)
        Me.Add.TabIndex = 6
        Me.Add.Text = "ADD"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 30)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(6, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Section Entry"
        '
        'sectionlist
        '
        Me.sectionlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sectionlist.Location = New System.Drawing.Point(8, 19)
        Me.sectionlist.Name = "sectionlist"
        Me.sectionlist.ReadOnly = True
        Me.sectionlist.Size = New System.Drawing.Size(542, 290)
        Me.sectionlist.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sectionlist)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 315)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section List and Adviser"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.faculty)
        Me.GroupBox2.Location = New System.Drawing.Point(585, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 391)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Faculty Line Up"
        '
        'faculty
        '
        Me.faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.faculty.Location = New System.Drawing.Point(6, 19)
        Me.faculty.Name = "faculty"
        Me.faculty.ReadOnly = True
        Me.faculty.Size = New System.Drawing.Size(389, 366)
        Me.faculty.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Click to select Adviser"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Adviser"
        '
        'adviser
        '
        Me.adviser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adviser.Location = New System.Drawing.Point(94, 87)
        Me.adviser.Name = "adviser"
        Me.adviser.ReadOnly = True
        Me.adviser.Size = New System.Drawing.Size(485, 26)
        Me.adviser.TabIndex = 13
        '
        'updatesection
        '
        Me.updatesection.Enabled = False
        Me.updatesection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatesection.Location = New System.Drawing.Point(290, 440)
        Me.updatesection.Name = "updatesection"
        Me.updatesection.Size = New System.Drawing.Size(88, 21)
        Me.updatesection.TabIndex = 15
        Me.updatesection.Text = "UPDATE"
        Me.updatesection.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Location = New System.Drawing.Point(484, 440)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(88, 21)
        Me.delete.TabIndex = 16
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(734, 22)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(23, 13)
        Me.id.TabIndex = 17
        Me.id.Text = "null"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Location = New System.Drawing.Point(772, 22)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(49, 13)
        Me.firstname.TabIndex = 18
        Me.firstname.Text = "firstname"
        '
        'mname
        '
        Me.mname.AutoSize = True
        Me.mname.Location = New System.Drawing.Point(837, 22)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(41, 13)
        Me.mname.TabIndex = 19
        Me.mname.Text = "mname"
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.Location = New System.Drawing.Point(892, 21)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(49, 13)
        Me.lastname.TabIndex = 20
        Me.lastname.Text = "lastname"
        '
        'cancel
        '
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Location = New System.Drawing.Point(195, 440)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(88, 21)
        Me.cancel.TabIndex = 21
        Me.cancel.Text = "CANCEL"
        Me.cancel.UseVisualStyleBackColor = True
        Me.cancel.Visible = False
        '
        'frmsection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 470)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.updatesection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.adviser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.yrlevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.section)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmsection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmtuition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sectionlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.faculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents section As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yrlevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sectionlist As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents faculty As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents adviser As System.Windows.Forms.TextBox
    Friend WithEvents updatesection As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents firstname As System.Windows.Forms.Label
    Friend WithEvents mname As System.Windows.Forms.Label
    Friend WithEvents lastname As System.Windows.Forms.Label
    Friend WithEvents cancel As System.Windows.Forms.Button
End Class
