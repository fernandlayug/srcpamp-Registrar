<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmuser
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
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.designation = New System.Windows.Forms.ComboBox()
        Me.account = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.department = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.empID = New System.Windows.Forms.TextBox()
        Me.designation1 = New System.Windows.Forms.TextBox()
        Me.account1 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.cancel1 = New System.Windows.Forms.LinkLabel()
        Me.cancel2 = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(123, 38)
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        Me.firstname.Size = New System.Drawing.Size(145, 20)
        Me.firstname.TabIndex = 500
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(123, 64)
        Me.mname.Name = "mname"
        Me.mname.ReadOnly = True
        Me.mname.Size = New System.Drawing.Size(145, 20)
        Me.mname.TabIndex = 1
        '
        'surname
        '
        Me.surname.Location = New System.Drawing.Point(123, 90)
        Me.surname.Name = "surname"
        Me.surname.ReadOnly = True
        Me.surname.Size = New System.Drawing.Size(145, 20)
        Me.surname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Designation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Account Type"
        '
        'designation
        '
        Me.designation.FormattingEnabled = True
        Me.designation.Location = New System.Drawing.Point(123, 144)
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(145, 21)
        Me.designation.TabIndex = 16
        Me.designation.Visible = False
        '
        'account
        '
        Me.account.FormattingEnabled = True
        Me.account.Location = New System.Drawing.Point(123, 223)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(145, 21)
        Me.account.TabIndex = 17
        Me.account.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(80, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Department"
        '
        'department
        '
        Me.department.Enabled = False
        Me.department.Location = New System.Drawing.Point(123, 171)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(145, 20)
        Me.department.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Employee ID"
        '
        'empID
        '
        Me.empID.Location = New System.Drawing.Point(123, 13)
        Me.empID.Name = "empID"
        Me.empID.Size = New System.Drawing.Size(78, 20)
        Me.empID.TabIndex = 0
        '
        'designation1
        '
        Me.designation1.Location = New System.Drawing.Point(123, 117)
        Me.designation1.Name = "designation1"
        Me.designation1.ReadOnly = True
        Me.designation1.Size = New System.Drawing.Size(145, 20)
        Me.designation1.TabIndex = 23
        '
        'account1
        '
        Me.account1.Enabled = False
        Me.account1.Location = New System.Drawing.Point(123, 197)
        Me.account1.Name = "account1"
        Me.account1.ReadOnly = True
        Me.account1.Size = New System.Drawing.Size(145, 20)
        Me.account1.TabIndex = 24
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(165, 149)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 13)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Designation"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(181, 226)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel2.TabIndex = 26
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Account"
        '
        'cancel1
        '
        Me.cancel1.AutoSize = True
        Me.cancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel1.Location = New System.Drawing.Point(76, 150)
        Me.cancel1.Name = "cancel1"
        Me.cancel1.Size = New System.Drawing.Size(40, 13)
        Me.cancel1.TabIndex = 27
        Me.cancel1.TabStop = True
        Me.cancel1.Text = "Cancel"
        Me.cancel1.Visible = False
        '
        'cancel2
        '
        Me.cancel2.AutoSize = True
        Me.cancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel2.Location = New System.Drawing.Point(77, 231)
        Me.cancel2.Name = "cancel2"
        Me.cancel2.Size = New System.Drawing.Size(40, 13)
        Me.cancel2.TabIndex = 28
        Me.cancel2.TabStop = True
        Me.cancel2.Text = "Cancel"
        Me.cancel2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 25)
        Me.Button2.TabIndex = 501
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 299)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cancel2)
        Me.Controls.Add(Me.cancel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.account1)
        Me.Controls.Add(Me.designation1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.empID)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.account)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.firstname)
        Me.KeyPreview = True
        Me.Name = "frmuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update USER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents designation As System.Windows.Forms.ComboBox
    Friend WithEvents account As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents department As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents empID As System.Windows.Forms.TextBox
    Friend WithEvents designation1 As System.Windows.Forms.TextBox
    Friend WithEvents account1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents cancel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cancel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
