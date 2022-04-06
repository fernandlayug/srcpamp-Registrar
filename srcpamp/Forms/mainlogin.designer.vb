<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class mainlogin
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
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.verifyusername = New System.Windows.Forms.TextBox()
        Me.verifypassword = New System.Windows.Forms.TextBox()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.designation = New System.Windows.Forms.TextBox()
        Me.account = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.department = New System.Windows.Forms.TextBox()
        Me.activesy = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.host = New System.Windows.Forms.Label()
        Me.ip = New System.Windows.Forms.Label()
        Me.domain = New System.Windows.Forms.Label()
        Me.PCuser = New System.Windows.Forms.Label()
        Me.sysID = New System.Windows.Forms.Label()
        Me.dateandtime = New System.Windows.Forms.Label()
        Me.sessionid = New System.Windows.Forms.Label()
        Me.empid = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAccounttype = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(22, 50)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(22, 93)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(22, 75)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(22, 115)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'verifyusername
        '
        Me.verifyusername.Location = New System.Drawing.Point(116, 44)
        Me.verifyusername.Name = "verifyusername"
        Me.verifyusername.Size = New System.Drawing.Size(100, 20)
        Me.verifyusername.TabIndex = 6
        Me.verifyusername.Visible = False
        '
        'verifypassword
        '
        Me.verifypassword.Location = New System.Drawing.Point(116, 44)
        Me.verifypassword.Name = "verifypassword"
        Me.verifypassword.Size = New System.Drawing.Size(100, 20)
        Me.verifypassword.TabIndex = 7
        Me.verifypassword.Visible = False
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(102, 44)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(100, 20)
        Me.firstname.TabIndex = 8
        Me.firstname.Visible = False
        '
        'surname
        '
        Me.surname.Location = New System.Drawing.Point(116, 44)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(100, 20)
        Me.surname.TabIndex = 9
        Me.surname.Visible = False
        '
        'designation
        '
        Me.designation.Location = New System.Drawing.Point(102, 44)
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(100, 20)
        Me.designation.TabIndex = 10
        Me.designation.Visible = False
        '
        'account
        '
        Me.account.Location = New System.Drawing.Point(102, 44)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(100, 20)
        Me.account.TabIndex = 11
        Me.account.Visible = False
        '
        'login
        '
        Me.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login.Image = Global.srcregistrar.My.Resources.Resources.accept1
        Me.login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.login.Location = New System.Drawing.Point(21, 203)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(114, 44)
        Me.login.TabIndex = 4
        Me.login.Text = "LOGIN"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Image = Global.srcregistrar.My.Resources.Resources.cancel_icon
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(151, 203)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(117, 44)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'department
        '
        Me.department.Location = New System.Drawing.Point(102, 44)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(100, 20)
        Me.department.TabIndex = 12
        Me.department.Visible = False
        '
        'activesy
        '
        Me.activesy.Location = New System.Drawing.Point(102, 44)
        Me.activesy.Name = "activesy"
        Me.activesy.Size = New System.Drawing.Size(100, 20)
        Me.activesy.TabIndex = 13
        Me.activesy.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 32)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'host
        '
        Me.host.AutoSize = True
        Me.host.Location = New System.Drawing.Point(270, 63)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(27, 13)
        Me.host.TabIndex = 15
        Me.host.Text = "host"
        Me.host.Visible = False
        '
        'ip
        '
        Me.ip.AutoSize = True
        Me.ip.Location = New System.Drawing.Point(270, 75)
        Me.ip.Name = "ip"
        Me.ip.Size = New System.Drawing.Size(15, 13)
        Me.ip.TabIndex = 16
        Me.ip.Text = "ip"
        Me.ip.Visible = False
        '
        'domain
        '
        Me.domain.AutoSize = True
        Me.domain.Location = New System.Drawing.Point(268, 88)
        Me.domain.Name = "domain"
        Me.domain.Size = New System.Drawing.Size(41, 13)
        Me.domain.TabIndex = 17
        Me.domain.Text = "domain"
        Me.domain.Visible = False
        '
        'PCuser
        '
        Me.PCuser.AutoSize = True
        Me.PCuser.Location = New System.Drawing.Point(267, 101)
        Me.PCuser.Name = "PCuser"
        Me.PCuser.Size = New System.Drawing.Size(41, 13)
        Me.PCuser.TabIndex = 18
        Me.PCuser.Text = "PCuser"
        Me.PCuser.UseWaitCursor = True
        Me.PCuser.Visible = False
        '
        'sysID
        '
        Me.sysID.AutoSize = True
        Me.sysID.Location = New System.Drawing.Point(269, 122)
        Me.sysID.Name = "sysID"
        Me.sysID.Size = New System.Drawing.Size(33, 13)
        Me.sysID.TabIndex = 19
        Me.sysID.Text = "sysID"
        Me.sysID.UseWaitCursor = True
        Me.sysID.Visible = False
        '
        'dateandtime
        '
        Me.dateandtime.AutoSize = True
        Me.dateandtime.Location = New System.Drawing.Point(269, 47)
        Me.dateandtime.Name = "dateandtime"
        Me.dateandtime.Size = New System.Drawing.Size(52, 13)
        Me.dateandtime.TabIndex = 20
        Me.dateandtime.Text = "date/time"
        Me.dateandtime.Visible = False
        '
        'sessionid
        '
        Me.sessionid.AutoSize = True
        Me.sessionid.Location = New System.Drawing.Point(267, 138)
        Me.sessionid.Name = "sessionid"
        Me.sessionid.Size = New System.Drawing.Size(50, 13)
        Me.sessionid.TabIndex = 21
        Me.sessionid.Text = "sessionid"
        Me.sessionid.UseWaitCursor = True
        Me.sessionid.Visible = False
        '
        'empid
        '
        Me.empid.AutoSize = True
        Me.empid.Location = New System.Drawing.Point(300, 154)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(35, 13)
        Me.empid.TabIndex = 22
        Me.empid.Text = "empid"
        Me.empid.UseWaitCursor = True
        Me.empid.Visible = False
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(102, 40)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(100, 20)
        Me.mname.TabIndex = 23
        Me.mname.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Account Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAccounttype
        '
        Me.cmbAccounttype.FormattingEnabled = True
        Me.cmbAccounttype.Location = New System.Drawing.Point(24, 166)
        Me.cmbAccounttype.Name = "cmbAccounttype"
        Me.cmbAccounttype.Size = New System.Drawing.Size(216, 21)
        Me.cmbAccounttype.TabIndex = 25
        '
        'mainlogin
        '
        Me.AcceptButton = Me.login
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(367, 260)
        Me.Controls.Add(Me.cmbAccounttype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.empid)
        Me.Controls.Add(Me.sessionid)
        Me.Controls.Add(Me.dateandtime)
        Me.Controls.Add(Me.sysID)
        Me.Controls.Add(Me.PCuser)
        Me.Controls.Add(Me.domain)
        Me.Controls.Add(Me.ip)
        Me.Controls.Add(Me.host)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.activesy)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.account)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.verifypassword)
        Me.Controls.Add(Me.verifyusername)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainlogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents verifyusername As System.Windows.Forms.TextBox
    Friend WithEvents verifypassword As System.Windows.Forms.TextBox
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents designation As System.Windows.Forms.TextBox
    Friend WithEvents account As System.Windows.Forms.TextBox
    Friend WithEvents department As System.Windows.Forms.TextBox
    Friend WithEvents activesy As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents host As System.Windows.Forms.Label
    Friend WithEvents ip As System.Windows.Forms.Label
    Friend WithEvents domain As System.Windows.Forms.Label
    Friend WithEvents PCuser As System.Windows.Forms.Label
    Friend WithEvents sysID As System.Windows.Forms.Label
    Friend WithEvents dateandtime As System.Windows.Forms.Label
    Friend WithEvents sessionid As System.Windows.Forms.Label
    Friend WithEvents empid As System.Windows.Forms.Label
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAccounttype As ComboBox
End Class
