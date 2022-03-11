<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class DeleteAdmission
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.verifyusername = New System.Windows.Forms.TextBox
        Me.verifypassword = New System.Windows.Forms.TextBox
        Me.firstname = New System.Windows.Forms.TextBox
        Me.surname = New System.Windows.Forms.TextBox
        Me.designation = New System.Windows.Forms.TextBox
        Me.account = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 5)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 48)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(12, 30)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(12, 70)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(26, 98)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(138, 98)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'verifyusername
        '
        Me.verifyusername.Location = New System.Drawing.Point(132, 25)
        Me.verifyusername.Name = "verifyusername"
        Me.verifyusername.Size = New System.Drawing.Size(100, 20)
        Me.verifyusername.TabIndex = 6
        Me.verifyusername.Visible = False
        '
        'verifypassword
        '
        Me.verifypassword.Location = New System.Drawing.Point(165, 37)
        Me.verifypassword.Name = "verifypassword"
        Me.verifypassword.Size = New System.Drawing.Size(100, 20)
        Me.verifypassword.TabIndex = 7
        Me.verifypassword.Visible = False
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(144, 5)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(100, 20)
        Me.firstname.TabIndex = 8
        Me.firstname.Visible = False
        '
        'surname
        '
        Me.surname.Location = New System.Drawing.Point(165, 20)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(100, 20)
        Me.surname.TabIndex = 9
        Me.surname.Visible = False
        '
        'designation
        '
        Me.designation.Location = New System.Drawing.Point(106, 4)
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(100, 20)
        Me.designation.TabIndex = 10
        Me.designation.Visible = False
        '
        'account
        '
        Me.account.Location = New System.Drawing.Point(87, 5)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(100, 20)
        Me.account.TabIndex = 11
        Me.account.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.account)
        Me.Panel1.Controls.Add(Me.designation)
        Me.Panel1.Controls.Add(Me.firstname)
        Me.Panel1.Controls.Add(Me.verifyusername)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.UsernameTextBox)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Location = New System.Drawing.Point(9, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 136)
        Me.Panel1.TabIndex = 12
        '
        'loginform1
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(273, 155)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.verifypassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginform1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents verifyusername As System.Windows.Forms.TextBox
    Friend WithEvents verifypassword As System.Windows.Forms.TextBox
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents designation As System.Windows.Forms.TextBox
    Friend WithEvents account As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
