<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepass
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
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.retypepass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.TextBox()
        Me.verified = New System.Windows.Forms.TextBox()
        Me.oldpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(148, 97)
        Me.newpass.Name = "newpass"
        Me.newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpass.Size = New System.Drawing.Size(197, 20)
        Me.newpass.TabIndex = 1
        Me.newpass.UseSystemPasswordChar = True
        '
        'retypepass
        '
        Me.retypepass.Location = New System.Drawing.Point(148, 123)
        Me.retypepass.Name = "retypepass"
        Me.retypepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.retypepass.Size = New System.Drawing.Size(197, 20)
        Me.retypepass.TabIndex = 2
        Me.retypepass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Re-type Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.pass)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.verified)
        Me.Panel1.Location = New System.Drawing.Point(29, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 31)
        Me.Panel1.TabIndex = 8
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(202, 3)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(136, 20)
        Me.pass.TabIndex = 11
        Me.pass.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Change Password"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(211, 3)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(136, 20)
        Me.user.TabIndex = 9
        Me.user.Visible = False
        '
        'verified
        '
        Me.verified.Location = New System.Drawing.Point(193, 3)
        Me.verified.Name = "verified"
        Me.verified.Size = New System.Drawing.Size(136, 20)
        Me.verified.TabIndex = 10
        Me.verified.Visible = False
        '
        'oldpass
        '
        Me.oldpass.Location = New System.Drawing.Point(148, 71)
        Me.oldpass.Name = "oldpass"
        Me.oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpass.Size = New System.Drawing.Size(197, 20)
        Me.oldpass.TabIndex = 0
        Me.oldpass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Old Password"
        '
        'changepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 208)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.retypepass)
        Me.Controls.Add(Me.newpass)
        Me.Controls.Add(Me.oldpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changepass"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newpass As System.Windows.Forms.TextBox
    Friend WithEvents retypepass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents verified As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents oldpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
