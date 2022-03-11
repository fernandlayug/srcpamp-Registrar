<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequest
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
        Me.requestername = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.activity = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.loc_room = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dateusestart = New System.Windows.Forms.MaskedTextBox
        Me.timestart = New System.Windows.Forms.MaskedTextBox
        Me.timeend = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.others = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.systemunit = New System.Windows.Forms.CheckBox
        Me.extensioncord = New System.Windows.Forms.CheckBox
        Me.speaker = New System.Windows.Forms.CheckBox
        Me.wirelessmic = New System.Windows.Forms.CheckBox
        Me.audiojack = New System.Windows.Forms.CheckBox
        Me.whitescreen = New System.Windows.Forms.CheckBox
        Me.dvdplayer = New System.Windows.Forms.CheckBox
        Me.systemunit1 = New System.Windows.Forms.TextBox
        Me.extensioncord1 = New System.Windows.Forms.TextBox
        Me.speaker1 = New System.Windows.Forms.TextBox
        Me.wirelessmic1 = New System.Windows.Forms.TextBox
        Me.audiojack1 = New System.Windows.Forms.TextBox
        Me.whitescreen1 = New System.Windows.Forms.TextBox
        Me.dvdplayer1 = New System.Windows.Forms.TextBox
        Me.department = New System.Windows.Forms.ComboBox
        Me.id = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dateuseend = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.facility = New System.Windows.Forms.ComboBox
        Me.stats = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.today = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.reqID = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.firstname = New System.Windows.Forms.TextBox
        Me.mname = New System.Windows.Forms.TextBox
        Me.surname = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'requestername
        '
        Me.requestername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.requestername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.requestername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestername.Location = New System.Drawing.Point(407, 145)
        Me.requestername.Name = "requestername"
        Me.requestername.Size = New System.Drawing.Size(357, 22)
        Me.requestername.TabIndex = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Requester Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Activity"
        '
        'activity
        '
        Me.activity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.activity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.activity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activity.Location = New System.Drawing.Point(145, 180)
        Me.activity.Name = "activity"
        Me.activity.Size = New System.Drawing.Size(227, 22)
        Me.activity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Room/Location"
        '
        'loc_room
        '
        Me.loc_room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.loc_room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.loc_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loc_room.Location = New System.Drawing.Point(499, 177)
        Me.loc_room.Name = "loc_room"
        Me.loc_room.Size = New System.Drawing.Size(265, 22)
        Me.loc_room.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Use"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Time of Use:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(533, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Start"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(660, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "End"
        '
        'dateusestart
        '
        Me.dateusestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateusestart.Location = New System.Drawing.Point(178, 244)
        Me.dateusestart.Mask = "00/00/0000"
        Me.dateusestart.Name = "dateusestart"
        Me.dateusestart.Size = New System.Drawing.Size(100, 22)
        Me.dateusestart.TabIndex = 4
        Me.dateusestart.ValidatingType = GetType(Date)
        '
        'timestart
        '
        Me.timestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timestart.Location = New System.Drawing.Point(574, 240)
        Me.timestart.Mask = "90:00 "
        Me.timestart.Name = "timestart"
        Me.timestart.Size = New System.Drawing.Size(80, 22)
        Me.timestart.TabIndex = 6
        '
        'timeend
        '
        Me.timeend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeend.Location = New System.Drawing.Point(698, 241)
        Me.timeend.Mask = "00:00"
        Me.timeend.Name = "timeend"
        Me.timeend.Size = New System.Drawing.Size(86, 22)
        Me.timeend.TabIndex = 7
        Me.timeend.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Facility"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Others. Please Specify"
        '
        'others
        '
        Me.others.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.others.Location = New System.Drawing.Point(167, 51)
        Me.others.Name = "others"
        Me.others.Size = New System.Drawing.Size(568, 22)
        Me.others.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(555, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 43)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(686, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 43)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(206, 31)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Request Form"
        '
        'systemunit
        '
        Me.systemunit.AutoSize = True
        Me.systemunit.Location = New System.Drawing.Point(20, 23)
        Me.systemunit.Name = "systemunit"
        Me.systemunit.Size = New System.Drawing.Size(82, 17)
        Me.systemunit.TabIndex = 9
        Me.systemunit.Text = "System Unit"
        Me.systemunit.UseVisualStyleBackColor = True
        '
        'extensioncord
        '
        Me.extensioncord.AutoSize = True
        Me.extensioncord.Location = New System.Drawing.Point(112, 23)
        Me.extensioncord.Name = "extensioncord"
        Me.extensioncord.Size = New System.Drawing.Size(97, 17)
        Me.extensioncord.TabIndex = 10
        Me.extensioncord.Text = "Extension Cord"
        Me.extensioncord.UseVisualStyleBackColor = True
        '
        'speaker
        '
        Me.speaker.AutoSize = True
        Me.speaker.Location = New System.Drawing.Point(215, 23)
        Me.speaker.Name = "speaker"
        Me.speaker.Size = New System.Drawing.Size(66, 17)
        Me.speaker.TabIndex = 12
        Me.speaker.Text = "Speaker"
        Me.speaker.UseVisualStyleBackColor = True
        '
        'wirelessmic
        '
        Me.wirelessmic.AutoSize = True
        Me.wirelessmic.Location = New System.Drawing.Point(313, 23)
        Me.wirelessmic.Name = "wirelessmic"
        Me.wirelessmic.Size = New System.Drawing.Size(86, 17)
        Me.wirelessmic.TabIndex = 13
        Me.wirelessmic.Text = "Wireless Mic"
        Me.wirelessmic.UseVisualStyleBackColor = True
        '
        'audiojack
        '
        Me.audiojack.AutoSize = True
        Me.audiojack.Location = New System.Drawing.Point(422, 23)
        Me.audiojack.Name = "audiojack"
        Me.audiojack.Size = New System.Drawing.Size(79, 17)
        Me.audiojack.TabIndex = 14
        Me.audiojack.Text = "Audio Jack"
        Me.audiojack.UseVisualStyleBackColor = True
        '
        'whitescreen
        '
        Me.whitescreen.AutoSize = True
        Me.whitescreen.Location = New System.Drawing.Point(526, 23)
        Me.whitescreen.Name = "whitescreen"
        Me.whitescreen.Size = New System.Drawing.Size(91, 17)
        Me.whitescreen.TabIndex = 15
        Me.whitescreen.Text = "White Screen"
        Me.whitescreen.UseVisualStyleBackColor = True
        '
        'dvdplayer
        '
        Me.dvdplayer.AutoSize = True
        Me.dvdplayer.Location = New System.Drawing.Point(657, 23)
        Me.dvdplayer.Name = "dvdplayer"
        Me.dvdplayer.Size = New System.Drawing.Size(78, 17)
        Me.dvdplayer.TabIndex = 16
        Me.dvdplayer.Text = "Dvd Player"
        Me.dvdplayer.UseVisualStyleBackColor = True
        '
        'systemunit1
        '
        Me.systemunit1.Location = New System.Drawing.Point(138, 428)
        Me.systemunit1.Name = "systemunit1"
        Me.systemunit1.Size = New System.Drawing.Size(100, 20)
        Me.systemunit1.TabIndex = 33
        Me.systemunit1.Visible = False
        '
        'extensioncord1
        '
        Me.extensioncord1.Location = New System.Drawing.Point(147, 428)
        Me.extensioncord1.Name = "extensioncord1"
        Me.extensioncord1.Size = New System.Drawing.Size(100, 20)
        Me.extensioncord1.TabIndex = 34
        Me.extensioncord1.Visible = False
        '
        'speaker1
        '
        Me.speaker1.Location = New System.Drawing.Point(138, 428)
        Me.speaker1.Name = "speaker1"
        Me.speaker1.Size = New System.Drawing.Size(100, 20)
        Me.speaker1.TabIndex = 35
        Me.speaker1.Visible = False
        '
        'wirelessmic1
        '
        Me.wirelessmic1.Location = New System.Drawing.Point(137, 428)
        Me.wirelessmic1.Name = "wirelessmic1"
        Me.wirelessmic1.Size = New System.Drawing.Size(100, 20)
        Me.wirelessmic1.TabIndex = 36
        Me.wirelessmic1.Visible = False
        '
        'audiojack1
        '
        Me.audiojack1.Location = New System.Drawing.Point(137, 428)
        Me.audiojack1.Name = "audiojack1"
        Me.audiojack1.Size = New System.Drawing.Size(100, 20)
        Me.audiojack1.TabIndex = 37
        Me.audiojack1.Visible = False
        '
        'whitescreen1
        '
        Me.whitescreen1.Location = New System.Drawing.Point(137, 428)
        Me.whitescreen1.Name = "whitescreen1"
        Me.whitescreen1.Size = New System.Drawing.Size(100, 20)
        Me.whitescreen1.TabIndex = 38
        Me.whitescreen1.Visible = False
        '
        'dvdplayer1
        '
        Me.dvdplayer1.Location = New System.Drawing.Point(138, 428)
        Me.dvdplayer1.Name = "dvdplayer1"
        Me.dvdplayer1.Size = New System.Drawing.Size(100, 20)
        Me.dvdplayer1.TabIndex = 39
        Me.dvdplayer1.Visible = False
        '
        'department
        '
        Me.department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.department.FormattingEnabled = True
        Me.department.Items.AddRange(New Object() {"Grade School", "HighSchool", "College"})
        Me.department.Location = New System.Drawing.Point(145, 212)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(297, 21)
        Me.department.TabIndex = 3
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(146, 97)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(296, 40)
        Me.id.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Your Request ID is"
        '
        'dateuseend
        '
        Me.dateuseend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateuseend.Location = New System.Drawing.Point(342, 244)
        Me.dateuseend.Mask = "00/00/0000"
        Me.dateuseend.Name = "dateuseend"
        Me.dateuseend.Size = New System.Drawing.Size(100, 22)
        Me.dateuseend.TabIndex = 5
        Me.dateuseend.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(136, 247)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Start"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(298, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "End"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 43)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "View Request Facility"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'facility
        '
        Me.facility.FormattingEnabled = True
        Me.facility.Location = New System.Drawing.Point(145, 281)
        Me.facility.Name = "facility"
        Me.facility.Size = New System.Drawing.Size(293, 21)
        Me.facility.TabIndex = 8
        '
        'stats
        '
        Me.stats.Location = New System.Drawing.Point(31, 430)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(100, 20)
        Me.stats.TabIndex = 48
        Me.stats.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(578, 263)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "hh:mm 23:20"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(701, 263)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "hh:mm 23:20"
        '
        'today
        '
        Me.today.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.today.Location = New System.Drawing.Point(146, 63)
        Me.today.Name = "today"
        Me.today.Size = New System.Drawing.Size(132, 20)
        Me.today.TabIndex = 51
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 16)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Date Requested"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 16)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Requester ID"
        '
        'reqID
        '
        Me.reqID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.reqID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.reqID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reqID.Location = New System.Drawing.Point(145, 148)
        Me.reqID.Name = "reqID"
        Me.reqID.Size = New System.Drawing.Size(132, 22)
        Me.reqID.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(19, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 40)
        Me.Panel1.TabIndex = 55
        '
        'firstname
        '
        Me.firstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.firstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(468, 59)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(173, 22)
        Me.firstname.TabIndex = 56
        Me.firstname.Visible = False
        '
        'mname
        '
        Me.mname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.mname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.mname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.Location = New System.Drawing.Point(289, 59)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(173, 22)
        Me.mname.TabIndex = 57
        Me.mname.Visible = False
        '
        'surname
        '
        Me.surname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.surname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surname.Location = New System.Drawing.Point(647, 59)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(134, 22)
        Me.surname.TabIndex = 58
        Me.surname.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.systemunit)
        Me.GroupBox1.Controls.Add(Me.extensioncord)
        Me.GroupBox1.Controls.Add(Me.speaker)
        Me.GroupBox1.Controls.Add(Me.wirelessmic)
        Me.GroupBox1.Controls.Add(Me.audiojack)
        Me.GroupBox1.Controls.Add(Me.whitescreen)
        Me.GroupBox1.Controls.Add(Me.dvdplayer)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.others)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 86)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supporting Materials"
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.reqID)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.today)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.stats)
        Me.Controls.Add(Me.facility)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dateuseend)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.dvdplayer1)
        Me.Controls.Add(Me.whitescreen1)
        Me.Controls.Add(Me.audiojack1)
        Me.Controls.Add(Me.wirelessmic1)
        Me.Controls.Add(Me.speaker1)
        Me.Controls.Add(Me.extensioncord1)
        Me.Controls.Add(Me.systemunit1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.timeend)
        Me.Controls.Add(Me.timestart)
        Me.Controls.Add(Me.dateusestart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loc_room)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.activity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.requestername)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmRequest"
        Me.Text = "Request"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents requestername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents activity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents loc_room As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dateusestart As System.Windows.Forms.MaskedTextBox
    Friend WithEvents timestart As System.Windows.Forms.MaskedTextBox
    Friend WithEvents timeend As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents others As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents systemunit As System.Windows.Forms.CheckBox
    Friend WithEvents extensioncord As System.Windows.Forms.CheckBox
    Friend WithEvents speaker As System.Windows.Forms.CheckBox
    Friend WithEvents wirelessmic As System.Windows.Forms.CheckBox
    Friend WithEvents audiojack As System.Windows.Forms.CheckBox
    Friend WithEvents whitescreen As System.Windows.Forms.CheckBox
    Friend WithEvents dvdplayer As System.Windows.Forms.CheckBox
    Friend WithEvents systemunit1 As System.Windows.Forms.TextBox
    Friend WithEvents extensioncord1 As System.Windows.Forms.TextBox
    Friend WithEvents speaker1 As System.Windows.Forms.TextBox
    Friend WithEvents wirelessmic1 As System.Windows.Forms.TextBox
    Friend WithEvents audiojack1 As System.Windows.Forms.TextBox
    Friend WithEvents whitescreen1 As System.Windows.Forms.TextBox
    Friend WithEvents dvdplayer1 As System.Windows.Forms.TextBox
    Friend WithEvents department As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dateuseend As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents facility As System.Windows.Forms.ComboBox
    Friend WithEvents stats As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents today As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents reqID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
