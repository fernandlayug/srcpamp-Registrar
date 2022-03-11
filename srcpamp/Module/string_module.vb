Module string_module
    Public mos As String = "Monthly"
    Public down As String = "Downpayment"
    Public d_amt1 As Double
    Public d_amt2 As Double
    Public d_amt3 As Double
    Public d_amt4 As Double
    Public d_amt5 As Double
    Public d_amt6 As Double
    Public d_amt7 As Double
    Public d_amt8 As Double
    Public d_amt9 As Double
    Public d_amt10 As Double
    Public d_amt11 As Double
    Public d_amt12 As Double
    Public d_amt13 As Double
    Public d_amt14 As Double

    'String for categor for VOID Payment and Refund
    Public cat1 As String
    Public cat2 As String
    Public cat3 As String
    Public cat4 As String
    Public cat5 As String
    Public cat6 As String
    Public cat7 As String
    Public cat8 As String
    Public cat9 As String
    Public cat10 As String
    Public cat11 As String
    Public cat12 As String
    Public cat13 As String
    Public cat14 As String

    Public category1 As String
    Public category2 As String
    Public category3 As String
    Public category4 As String
    Public category5 As String
    Public category6 As String
    Public category7 As String
    Public category8 As String
    Public category9 As String
    Public category10 As String
    Public category11 As String
    Public category12 As String
    Public category13 As String
    Public category14 As String


    Public Sub logoff_status()
        Main.ChangeUsernameToolStripMenuItem.Enabled = False
        Main.ChangePasswordToolStripMenuItem.Enabled = False
        Main.CashierToolStripMenuItem.Visible = False
        Main.RegistrarToolStripMenuItem.Visible = False
        Main.HRToolStripMenuItem.Visible = False
        Main.AccountingToolStripMenuItem.Visible = False
        Main.ITToolStripMenuItem.Visible = False
        Main.MISToolStripMenuItem.Visible = False
        Main.LibrarianToolStripMenuItem.Visible = False
        Main.FacultyToolStripMenuItem.Visible = False
        Main.AdministratorToolStripMenuItem.Visible = False
        Main.registrationlink.Enabled = False
        Main.searchlink.Enabled = False
        Main.facultylink.Enabled = False
        Main.Vdtr.Enabled = False
        Main.Vpayslip.Enabled = False
        Main.empid.Text = ""
        Main.username.Text = ""
        Main.designation.Text = ""
        Main.dep.Text = ""
        Main.loguser.Text = ""
        Main.logas.Text = ""
        Main.sysID.Text = ""
        Main.mname.Text = "_"
        Main.surname.Text = "_"
        sqlconn.Close()
    End Sub
End Module
