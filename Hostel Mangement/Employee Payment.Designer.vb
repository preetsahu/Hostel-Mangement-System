<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Payment
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReport = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboPayMode = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpBankDetails = New System.Windows.Forms.GroupBox()
        Me.txtACno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtIFSCcode = New System.Windows.Forms.TextBox()
        Me.cboEmpName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmpID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRemainingFees = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtP1 = New System.Windows.Forms.DateTimePicker()
        Me.cboWorkAs = New System.Windows.Forms.ComboBox()
        Me.txtPaidAmount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPayingAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAbsentdasy = New System.Windows.Forms.TextBox()
        Me.txtAllotedLeave = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboMonthIndex = New System.Windows.Forms.ComboBox()
        Me.txtwORKdAYS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpBankDetails.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox2.Controls.Add(Me.btnReport)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 430)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnReport.Location = New System.Drawing.Point(361, 32)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(112, 40)
        Me.btnReport.TabIndex = 13
        Me.btnReport.Text = "Print Report"
        Me.btnReport.UseSelectable = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.GhostWhite
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnClear.FlatAppearance.BorderSize = 5
        Me.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(55, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 41)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "New Payment"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnSave.FlatAppearance.BorderSize = 5
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(213, 30)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 42)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Pay Now"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(523, 31)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 40)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox4.Controls.Add(Me.cboPayMode)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.grpBankDetails)
        Me.GroupBox4.Controls.Add(Me.cboEmpName)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtsalary)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cboEmpID)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtRemainingFees)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.DtP1)
        Me.GroupBox4.Controls.Add(Me.cboWorkAs)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(380, 355)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment"
        '
        'cboPayMode
        '
        Me.cboPayMode.FormattingEnabled = True
        Me.cboPayMode.Location = New System.Drawing.Point(180, 154)
        Me.cboPayMode.Name = "cboPayMode"
        Me.cboPayMode.Size = New System.Drawing.Size(168, 24)
        Me.cboPayMode.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Payment Mode"
        '
        'grpBankDetails
        '
        Me.grpBankDetails.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.grpBankDetails.Controls.Add(Me.txtACno)
        Me.grpBankDetails.Controls.Add(Me.Label13)
        Me.grpBankDetails.Controls.Add(Me.Label14)
        Me.grpBankDetails.Controls.Add(Me.txtIFSCcode)
        Me.grpBankDetails.Enabled = False
        Me.grpBankDetails.Location = New System.Drawing.Point(16, 184)
        Me.grpBankDetails.Name = "grpBankDetails"
        Me.grpBankDetails.Size = New System.Drawing.Size(338, 75)
        Me.grpBankDetails.TabIndex = 0
        Me.grpBankDetails.TabStop = False
        Me.grpBankDetails.Text = "Bank Details"
        '
        'txtACno
        '
        Me.txtACno.Location = New System.Drawing.Point(164, 11)
        Me.txtACno.Name = "txtACno"
        Me.txtACno.Size = New System.Drawing.Size(168, 22)
        Me.txtACno.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "IFSC code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Bank A/C Number"
        '
        'txtIFSCcode
        '
        Me.txtIFSCcode.Location = New System.Drawing.Point(164, 46)
        Me.txtIFSCcode.Name = "txtIFSCcode"
        Me.txtIFSCcode.Size = New System.Drawing.Size(168, 22)
        Me.txtIFSCcode.TabIndex = 17
        '
        'cboEmpName
        '
        Me.cboEmpName.FormattingEnabled = True
        Me.cboEmpName.Location = New System.Drawing.Point(180, 49)
        Me.cboEmpName.Name = "cboEmpName"
        Me.cboEmpName.Size = New System.Drawing.Size(168, 24)
        Me.cboEmpName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(180, 123)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(168, 22)
        Me.txtsalary.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Employee Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remaining Payment"
        '
        'cboEmpID
        '
        Me.cboEmpID.FormattingEnabled = True
        Me.cboEmpID.Location = New System.Drawing.Point(180, 85)
        Me.cboEmpID.Name = "cboEmpID"
        Me.cboEmpID.Size = New System.Drawing.Size(168, 24)
        Me.cboEmpID.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Employee Name"
        '
        'txtRemainingFees
        '
        Me.txtRemainingFees.Location = New System.Drawing.Point(180, 313)
        Me.txtRemainingFees.Name = "txtRemainingFees"
        Me.txtRemainingFees.Size = New System.Drawing.Size(168, 22)
        Me.txtRemainingFees.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Work As"
        '
        'DtP1
        '
        Me.DtP1.CustomFormat = "dd/MM/yyyy"
        Me.DtP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtP1.Location = New System.Drawing.Point(180, 282)
        Me.DtP1.Name = "DtP1"
        Me.DtP1.Size = New System.Drawing.Size(168, 22)
        Me.DtP1.TabIndex = 7
        '
        'cboWorkAs
        '
        Me.cboWorkAs.FormattingEnabled = True
        Me.cboWorkAs.Location = New System.Drawing.Point(180, 15)
        Me.cboWorkAs.Name = "cboWorkAs"
        Me.cboWorkAs.Size = New System.Drawing.Size(168, 24)
        Me.cboWorkAs.TabIndex = 8
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.AcceptsReturn = True
        Me.txtPaidAmount.Enabled = False
        Me.txtPaidAmount.Location = New System.Drawing.Point(153, 154)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(88, 22)
        Me.txtPaidAmount.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Paid Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paying Amount"
        '
        'txtPayingAmount
        '
        Me.txtPayingAmount.AcceptsReturn = True
        Me.txtPayingAmount.Location = New System.Drawing.Point(153, 192)
        Me.txtPayingAmount.Name = "txtPayingAmount"
        Me.txtPayingAmount.Size = New System.Drawing.Size(92, 22)
        Me.txtPayingAmount.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtPaidAmount)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtAbsentdasy)
        Me.GroupBox3.Controls.Add(Me.txtPayingAmount)
        Me.GroupBox3.Controls.Add(Me.txtAllotedLeave)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtPayment)
        Me.GroupBox3.Controls.Add(Me.btnCal)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(401, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 260)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Month Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Absent Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Alloted Leave Days"
        '
        'txtAbsentdasy
        '
        Me.txtAbsentdasy.Enabled = False
        Me.txtAbsentdasy.Location = New System.Drawing.Point(154, 72)
        Me.txtAbsentdasy.Name = "txtAbsentdasy"
        Me.txtAbsentdasy.Size = New System.Drawing.Size(91, 22)
        Me.txtAbsentdasy.TabIndex = 38
        '
        'txtAllotedLeave
        '
        Me.txtAllotedLeave.Enabled = False
        Me.txtAllotedLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllotedLeave.Location = New System.Drawing.Point(154, 38)
        Me.txtAllotedLeave.Name = "txtAllotedLeave"
        Me.txtAllotedLeave.Size = New System.Drawing.Size(91, 22)
        Me.txtAllotedLeave.TabIndex = 4
        '
        'txtPayment
        '
        Me.txtPayment.AcceptsReturn = True
        Me.txtPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(154, 110)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(91, 22)
        Me.txtPayment.TabIndex = 34
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCal.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnCal.FlatAppearance.BorderSize = 5
        Me.btnCal.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(28, 110)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(105, 31)
        Me.btnCal.TabIndex = 36
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightCyan
        Me.GroupBox5.Controls.Add(Me.cboMonth)
        Me.GroupBox5.Controls.Add(Me.cboMonthIndex)
        Me.GroupBox5.Controls.Add(Me.txtwORKdAYS)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(401, 66)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 89)
        Me.GroupBox5.TabIndex = 37
        Me.GroupBox5.TabStop = False
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(153, 27)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(100, 24)
        Me.cboMonth.TabIndex = 41
        '
        'cboMonthIndex
        '
        Me.cboMonthIndex.FormattingEnabled = True
        Me.cboMonthIndex.Location = New System.Drawing.Point(167, 27)
        Me.cboMonthIndex.Name = "cboMonthIndex"
        Me.cboMonthIndex.Size = New System.Drawing.Size(74, 24)
        Me.cboMonthIndex.TabIndex = 40
        '
        'txtwORKdAYS
        '
        Me.txtwORKdAYS.Enabled = False
        Me.txtwORKdAYS.Location = New System.Drawing.Point(153, 53)
        Me.txtwORKdAYS.Name = "txtwORKdAYS"
        Me.txtwORKdAYS.Size = New System.Drawing.Size(100, 22)
        Me.txtwORKdAYS.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Work Days"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Month"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(671, 67)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(699, 458)
        Me.ReportViewer1.TabIndex = 38
        '
        'Employee_Payment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "Employee_Payment"
        Me.ShowIcon = False
        Me.Text = "Employee_Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpBankDetails.ResumeLayout(False)
        Me.grpBankDetails.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboEmpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboEmpID As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPayingAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtRemainingFees As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboWorkAs As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAbsentdasy As System.Windows.Forms.TextBox
    Friend WithEvents txtAllotedLeave As System.Windows.Forms.TextBox
    Private WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtwORKdAYS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents grpBankDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cboPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtACno As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtIFSCcode As System.Windows.Forms.TextBox
    Friend WithEvents cboMonthIndex As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As MetroFramework.Controls.MetroButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
