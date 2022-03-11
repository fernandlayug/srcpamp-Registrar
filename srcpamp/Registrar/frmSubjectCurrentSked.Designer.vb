<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubjectCurrentSked
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtPrint = New System.Windows.Forms.DataGridView()
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.sy = New System.Windows.Forms.TextBox()
        Me.term = New System.Windows.Forms.TextBox()
        Me.classscheduleid = New System.Windows.Forms.TextBox()
        Me.btnapply = New System.Windows.Forms.Button()
        CType(Me.dtPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtPrint
        '
        Me.dtPrint.AllowUserToAddRows = False
        Me.dtPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtPrint.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtPrint.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtPrint.Location = New System.Drawing.Point(23, 12)
        Me.dtPrint.Name = "dtPrint"
        Me.dtPrint.Size = New System.Drawing.Size(946, 483)
        Me.dtPrint.TabIndex = 0
        '
        'txtSubjectID
        '
        Me.txtSubjectID.Location = New System.Drawing.Point(23, 12)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(100, 20)
        Me.txtSubjectID.TabIndex = 1
        Me.txtSubjectID.Visible = False
        '
        'sy
        '
        Me.sy.Location = New System.Drawing.Point(167, 12)
        Me.sy.Name = "sy"
        Me.sy.Size = New System.Drawing.Size(100, 20)
        Me.sy.TabIndex = 2
        Me.sy.Visible = False
        '
        'term
        '
        Me.term.Location = New System.Drawing.Point(297, 12)
        Me.term.Name = "term"
        Me.term.Size = New System.Drawing.Size(100, 20)
        Me.term.TabIndex = 3
        Me.term.Visible = False
        '
        'classscheduleid
        '
        Me.classscheduleid.Location = New System.Drawing.Point(424, 12)
        Me.classscheduleid.Name = "classscheduleid"
        Me.classscheduleid.Size = New System.Drawing.Size(100, 20)
        Me.classscheduleid.TabIndex = 4
        Me.classscheduleid.Visible = False
        '
        'btnapply
        '
        Me.btnapply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnapply.Enabled = False
        Me.btnapply.Location = New System.Drawing.Point(825, 502)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.Size = New System.Drawing.Size(144, 35)
        Me.btnapply.TabIndex = 5
        Me.btnapply.Text = "Apply and Close"
        Me.btnapply.UseVisualStyleBackColor = True
        '
        'frmSubjectCurrentSked
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(981, 549)
        Me.Controls.Add(Me.btnapply)
        Me.Controls.Add(Me.classscheduleid)
        Me.Controls.Add(Me.term)
        Me.Controls.Add(Me.sy)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.dtPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubjectCurrentSked"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Schedule"
        CType(Me.dtPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtPrint As System.Windows.Forms.DataGridView
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents sy As System.Windows.Forms.TextBox
    Friend WithEvents term As System.Windows.Forms.TextBox
    Friend WithEvents classscheduleid As System.Windows.Forms.TextBox
    Friend WithEvents btnapply As System.Windows.Forms.Button
End Class
