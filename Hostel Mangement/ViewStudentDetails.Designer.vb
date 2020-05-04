<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStudentDetails
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtGridViewStudentDetail = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClickView = New System.Windows.Forms.Button()
        Me.dtPickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtlocalguardiancontact = New System.Windows.Forms.TextBox()
        Me.txtlocalguardian = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmothercontact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfathercontact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmothername = New System.Windows.Forms.TextBox()
        Me.txtstudentcontact = New System.Windows.Forms.TextBox()
        Me.txtfathername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstudentname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtstudentid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtrouteid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbedid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.cboclass = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbusid = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboSelected = New System.Windows.Forms.ComboBox()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.richTxtpermanentaddress = New System.Windows.Forms.RichTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.richTxtLocalAddress = New System.Windows.Forms.RichTextBox()
        Me.DtcurrentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rdoCuurentStudent = New System.Windows.Forms.RadioButton()
        Me.rdoPreviousStudent = New System.Windows.Forms.RadioButton()
        Me.btnPrintReport = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboSearchYear = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.dtGridViewStudentDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtGridViewStudentDetail
        '
        Me.dtGridViewStudentDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.dtGridViewStudentDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridViewStudentDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtGridViewStudentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtGridViewStudentDetail.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtGridViewStudentDetail.Location = New System.Drawing.Point(21, 359)
        Me.dtGridViewStudentDetail.Name = "dtGridViewStudentDetail"
        Me.dtGridViewStudentDetail.Size = New System.Drawing.Size(1286, 286)
        Me.dtGridViewStudentDetail.StandardTab = True
        Me.dtGridViewStudentDetail.TabIndex = 0
        Me.dtGridViewStudentDetail.VirtualMode = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search By"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter Detail"
        '
        'btnClickView
        '
        Me.btnClickView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClickView.Location = New System.Drawing.Point(6, 112)
        Me.btnClickView.Name = "btnClickView"
        Me.btnClickView.Size = New System.Drawing.Size(217, 29)
        Me.btnClickView.TabIndex = 5
        Me.btnClickView.Text = "Click to View"
        Me.btnClickView.UseVisualStyleBackColor = True
        '
        'dtPickerDOB
        '
        Me.dtPickerDOB.CustomFormat = "dd-MM-yyyy"
        Me.dtPickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPickerDOB.Location = New System.Drawing.Point(281, 22)
        Me.dtPickerDOB.Name = "dtPickerDOB"
        Me.dtPickerDOB.Size = New System.Drawing.Size(100, 21)
        Me.dtPickerDOB.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(37, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 15)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(232, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "D.O.B"
        '
        'txtlocalguardiancontact
        '
        Me.txtlocalguardiancontact.Location = New System.Drawing.Point(552, 238)
        Me.txtlocalguardiancontact.MaxLength = 10
        Me.txtlocalguardiancontact.Name = "txtlocalguardiancontact"
        Me.txtlocalguardiancontact.Size = New System.Drawing.Size(200, 21)
        Me.txtlocalguardiancontact.TabIndex = 16
        '
        'txtlocalguardian
        '
        Me.txtlocalguardian.Location = New System.Drawing.Point(171, 237)
        Me.txtlocalguardian.Multiline = True
        Me.txtlocalguardian.Name = "txtlocalguardian"
        Me.txtlocalguardian.Size = New System.Drawing.Size(210, 20)
        Me.txtlocalguardian.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(415, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Contact Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Local Guardian"
        '
        'txtmothercontact
        '
        Me.txtmothercontact.Location = New System.Drawing.Point(551, 203)
        Me.txtmothercontact.MaxLength = 10
        Me.txtmothercontact.Name = "txtmothercontact"
        Me.txtmothercontact.Size = New System.Drawing.Size(201, 21)
        Me.txtmothercontact.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Postal Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Contact Number"
        '
        'txtfathercontact
        '
        Me.txtfathercontact.Location = New System.Drawing.Point(551, 170)
        Me.txtfathercontact.MaxLength = 10
        Me.txtfathercontact.Name = "txtfathercontact"
        Me.txtfathercontact.Size = New System.Drawing.Size(201, 21)
        Me.txtfathercontact.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(414, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Contact Number"
        '
        'txtmothername
        '
        Me.txtmothername.Location = New System.Drawing.Point(171, 205)
        Me.txtmothername.Name = "txtmothername"
        Me.txtmothername.Size = New System.Drawing.Size(210, 21)
        Me.txtmothername.TabIndex = 13
        '
        'txtstudentcontact
        '
        Me.txtstudentcontact.Location = New System.Drawing.Point(553, 58)
        Me.txtstudentcontact.Name = "txtstudentcontact"
        Me.txtstudentcontact.Size = New System.Drawing.Size(200, 21)
        Me.txtstudentcontact.TabIndex = 4
        '
        'txtfathername
        '
        Me.txtfathername.Location = New System.Drawing.Point(171, 172)
        Me.txtfathername.Name = "txtfathername"
        Me.txtfathername.Size = New System.Drawing.Size(210, 21)
        Me.txtfathername.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Mothers Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Contact Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fathers Name"
        '
        'txtstudentname
        '
        Me.txtstudentname.Location = New System.Drawing.Point(171, 57)
        Me.txtstudentname.Name = "txtstudentname"
        Me.txtstudentname.Size = New System.Drawing.Size(210, 21)
        Me.txtstudentname.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Name"
        '
        'txtstudentid
        '
        Me.txtstudentid.Enabled = False
        Me.txtstudentid.Location = New System.Drawing.Point(171, 22)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(55, 21)
        Me.txtstudentid.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Student ID"
        '
        'txtrouteid
        '
        Me.txtrouteid.Location = New System.Drawing.Point(688, 120)
        Me.txtrouteid.Name = "txtrouteid"
        Me.txtrouteid.Size = New System.Drawing.Size(64, 21)
        Me.txtrouteid.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(633, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Route ID"
        '
        'txtbedid
        '
        Me.txtbedid.Location = New System.Drawing.Point(688, 88)
        Me.txtbedid.Name = "txtbedid"
        Me.txtbedid.Size = New System.Drawing.Size(64, 21)
        Me.txtbedid.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(637, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Bed ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(251, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 15)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Year"
        '
        'cboyear
        '
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"I-Year", "II-Year", "III-Year", "I-Semester", "II-Semester", "III-Semester", "IV-Semester"})
        Me.cboyear.Location = New System.Drawing.Point(301, 87)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(80, 23)
        Me.cboyear.TabIndex = 6
        '
        'cboclass
        '
        Me.cboclass.FormattingEnabled = True
        Me.cboclass.Location = New System.Drawing.Point(171, 88)
        Me.cboclass.Name = "cboclass"
        Me.cboclass.Size = New System.Drawing.Size(64, 23)
        Me.cboclass.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 15)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Class"
        '
        'txtbusid
        '
        Me.txtbusid.Location = New System.Drawing.Point(553, 120)
        Me.txtbusid.Name = "txtbusid"
        Me.txtbusid.Size = New System.Drawing.Size(78, 21)
        Me.txtbusid.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(415, 124)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Bus Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSearchYear)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cboSelected)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSearchBy)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClickView)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 149)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Student Details"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(31, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 18)
        Me.Label21.TabIndex = 47
        '
        'cboSelected
        '
        Me.cboSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelected.FormattingEnabled = True
        Me.cboSelected.Location = New System.Drawing.Point(129, 56)
        Me.cboSelected.Name = "cboSelected"
        Me.cboSelected.Size = New System.Drawing.Size(97, 23)
        Me.cboSelected.TabIndex = 6
        '
        'cboSearchBy
        '
        Me.cboSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Classwise", "Student Name", "Student ID", "View All Record"})
        Me.cboSearchBy.Location = New System.Drawing.Point(129, 26)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(97, 23)
        Me.cboSearchBy.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.richTxtpermanentaddress)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.richTxtLocalAddress)
        Me.GroupBox2.Controls.Add(Me.DtcurrentDate)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtRoomID)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtfathercontact)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtbusid)
        Me.GroupBox2.Controls.Add(Me.txtstudentid)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtrouteid)
        Me.GroupBox2.Controls.Add(Me.txtstudentname)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtPickerDOB)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtbedid)
        Me.GroupBox2.Controls.Add(Me.txtfathername)
        Me.GroupBox2.Controls.Add(Me.txtstudentcontact)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtmothername)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtlocalguardiancontact)
        Me.GroupBox2.Controls.Add(Me.txtmothercontact)
        Me.GroupBox2.Controls.Add(Me.cboyear)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboclass)
        Me.GroupBox2.Controls.Add(Me.txtlocalguardian)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(282, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 320)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'richTxtpermanentaddress
        '
        Me.richTxtpermanentaddress.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.richTxtpermanentaddress.Location = New System.Drawing.Point(171, 125)
        Me.richTxtpermanentaddress.Name = "richTxtpermanentaddress"
        Me.richTxtpermanentaddress.Size = New System.Drawing.Size(210, 40)
        Me.richTxtpermanentaddress.TabIndex = 62
        Me.richTxtpermanentaddress.Text = ""
        '
        'Label23
        '
        Me.Label23.AllowDrop = True
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(415, 272)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 15)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Depatched Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(551, 275)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 21)
        Me.DateTimePicker1.TabIndex = 60
        '
        'richTxtLocalAddress
        '
        Me.richTxtLocalAddress.Location = New System.Drawing.Point(171, 270)
        Me.richTxtLocalAddress.Name = "richTxtLocalAddress"
        Me.richTxtLocalAddress.Size = New System.Drawing.Size(210, 39)
        Me.richTxtLocalAddress.TabIndex = 48
        Me.richTxtLocalAddress.Text = ""
        '
        'DtcurrentDate
        '
        Me.DtcurrentDate.CustomFormat = "dd-MM-yy"
        Me.DtcurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtcurrentDate.Location = New System.Drawing.Point(553, 19)
        Me.DtcurrentDate.Name = "DtcurrentDate"
        Me.DtcurrentDate.Size = New System.Drawing.Size(120, 21)
        Me.DtcurrentDate.TabIndex = 46
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(414, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 15)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "*Registration Date"
        '
        'txtRoomID
        '
        Me.txtRoomID.Location = New System.Drawing.Point(553, 88)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.Size = New System.Drawing.Size(78, 21)
        Me.txtRoomID.TabIndex = 44
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(415, 91)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 15)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Room ID"
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleName = "btnUpdate"
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1074, 35)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(221, 48)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update Student Detals"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1074, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 47)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Delete This Student Detals"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(43, 323)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(142, 30)
        Me.btnBrowse.TabIndex = 49
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1074, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(221, 46)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear Data"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1074, 242)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(221, 50)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Back To Room Allotment forn"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'rdoCuurentStudent
        '
        Me.rdoCuurentStudent.AutoSize = True
        Me.rdoCuurentStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCuurentStudent.Location = New System.Drawing.Point(393, 2)
        Me.rdoCuurentStudent.Name = "rdoCuurentStudent"
        Me.rdoCuurentStudent.Size = New System.Drawing.Size(172, 20)
        Me.rdoCuurentStudent.TabIndex = 55
        Me.rdoCuurentStudent.TabStop = True
        Me.rdoCuurentStudent.Text = "Current living Student"
        Me.rdoCuurentStudent.UseVisualStyleBackColor = True
        '
        'rdoPreviousStudent
        '
        Me.rdoPreviousStudent.AutoSize = True
        Me.rdoPreviousStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPreviousStudent.Location = New System.Drawing.Point(596, 2)
        Me.rdoPreviousStudent.Name = "rdoPreviousStudent"
        Me.rdoPreviousStudent.Size = New System.Drawing.Size(158, 20)
        Me.rdoPreviousStudent.TabIndex = 59
        Me.rdoPreviousStudent.TabStop = True
        Me.rdoPreviousStudent.Text = "Depatched Student"
        Me.rdoPreviousStudent.UseVisualStyleBackColor = True
        '
        'btnPrintReport
        '
        Me.btnPrintReport.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnPrintReport.Location = New System.Drawing.Point(1074, 308)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(221, 44)
        Me.btnPrintReport.TabIndex = 60
        Me.btnPrintReport.Text = "Print Report"
        Me.btnPrintReport.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.Image = Global.Hostel_Mangement.My.Resources.Resources.nv
        Me.PictureBox1.Location = New System.Drawing.Point(43, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'cboSearchYear
        '
        Me.cboSearchYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchYear.FormattingEnabled = True
        Me.cboSearchYear.Location = New System.Drawing.Point(129, 85)
        Me.cboSearchYear.Name = "cboSearchYear"
        Me.cboSearchYear.Size = New System.Drawing.Size(97, 21)
        Me.cboSearchYear.TabIndex = 49
        Me.cboSearchYear.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(67, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 15)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "Year"
        Me.Label24.Visible = False
        '
        'ViewStudentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 652)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.rdoPreviousStudent)
        Me.Controls.Add(Me.rdoCuurentStudent)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtGridViewStudentDetail)
        Me.Name = "ViewStudentDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ViewStudentDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtGridViewStudentDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtGridViewStudentDetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClickView As System.Windows.Forms.Button
    Friend WithEvents dtPickerDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtlocalguardiancontact As System.Windows.Forms.TextBox
    Friend WithEvents txtlocalguardian As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmothercontact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfathercontact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmothername As System.Windows.Forms.TextBox
    Friend WithEvents txtstudentcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtfathername As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtstudentname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtstudentid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtrouteid As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtbedid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents cboclass As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtbusid As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cboSelected As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoomID As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DtcurrentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdoCuurentStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPreviousStudent As System.Windows.Forms.RadioButton
    Friend WithEvents richTxtLocalAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents richTxtpermanentaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents btnPrintReport As MetroFramework.Controls.MetroButton
    Friend WithEvents cboSearchYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
