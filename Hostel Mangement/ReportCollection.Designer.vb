<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCollection
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnReportView = New MetroFramework.Controls.MetroButton()
        Me.cboYear = New MetroFramework.Controls.MetroComboBox()
        Me.cboClass = New MetroFramework.Controls.MetroComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnViewClassWiseStudnet = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cboyearWisestudent = New MetroFramework.Controls.MetroComboBox()
        Me.cboClassWise = New MetroFramework.Controls.MetroComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboEmpID = New System.Windows.Forms.ComboBox()
        Me.btnViewEmpDateWiseAttendance = New MetroFramework.Controls.MetroButton()
        Me.ReportViewerEmpAttendance = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cboEmpName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboWorkAs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptOvrallHostelStudents1 = New Hostel_Mangement.rptOvrallHostelStudents()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportViewerRemainingStudents = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnRemaingView = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cboYearStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.CboClassStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rptViewerWentStudentList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1245, 540)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroLabel2)
        Me.TabPage1.Controls.Add(Me.MetroLabel1)
        Me.TabPage1.Controls.Add(Me.btnReportView)
        Me.TabPage1.Controls.Add(Me.cboYear)
        Me.TabPage1.Controls.Add(Me.cboClass)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1237, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View DueFess Student Classwise List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(118, 18)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Class"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Location = New System.Drawing.Point(341, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(58, 23)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Year"
        '
        'btnReportView
        '
        Me.btnReportView.Location = New System.Drawing.Point(599, 14)
        Me.btnReportView.Name = "btnReportView"
        Me.btnReportView.Size = New System.Drawing.Size(109, 25)
        Me.btnReportView.TabIndex = 3
        Me.btnReportView.Text = "View Report"
        Me.btnReportView.UseSelectable = True
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.ItemHeight = 23
        Me.cboYear.Location = New System.Drawing.Point(419, 14)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(127, 29)
        Me.cboYear.TabIndex = 2
        Me.cboYear.UseSelectable = True
        '
        'cboClass
        '
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.ItemHeight = 23
        Me.cboClass.Location = New System.Drawing.Point(180, 14)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(127, 29)
        Me.cboClass.TabIndex = 1
        Me.cboClass.UseSelectable = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 54)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(936, 334)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Controls.Add(Me.btnViewClassWiseStudnet)
        Me.TabPage2.Controls.Add(Me.MetroLabel3)
        Me.TabPage2.Controls.Add(Me.MetroLabel4)
        Me.TabPage2.Controls.Add(Me.cboyearWisestudent)
        Me.TabPage2.Controls.Add(Me.cboClassWise)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1237, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Class Wise Student List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Location = New System.Drawing.Point(6, 65)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1308, 438)
        Me.ReportViewer2.TabIndex = 11
        '
        'btnViewClassWiseStudnet
        '
        Me.btnViewClassWiseStudnet.Location = New System.Drawing.Point(652, 18)
        Me.btnViewClassWiseStudnet.Name = "btnViewClassWiseStudnet"
        Me.btnViewClassWiseStudnet.Size = New System.Drawing.Size(109, 28)
        Me.btnViewClassWiseStudnet.TabIndex = 10
        Me.btnViewClassWiseStudnet.Text = "View Report"
        Me.btnViewClassWiseStudnet.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(200, 19)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "Class"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Location = New System.Drawing.Point(427, 18)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Year"
        '
        'cboyearWisestudent
        '
        Me.cboyearWisestudent.FormattingEnabled = True
        Me.cboyearWisestudent.ItemHeight = 23
        Me.cboyearWisestudent.Location = New System.Drawing.Point(491, 18)
        Me.cboyearWisestudent.Name = "cboyearWisestudent"
        Me.cboyearWisestudent.Size = New System.Drawing.Size(127, 29)
        Me.cboyearWisestudent.TabIndex = 7
        Me.cboyearWisestudent.UseSelectable = True
        '
        'cboClassWise
        '
        Me.cboClassWise.FormattingEnabled = True
        Me.cboClassWise.ItemHeight = 23
        Me.cboClassWise.Location = New System.Drawing.Point(262, 18)
        Me.cboClassWise.Name = "cboClassWise"
        Me.cboClassWise.Size = New System.Drawing.Size(127, 29)
        Me.cboClassWise.TabIndex = 6
        Me.cboClassWise.UseSelectable = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.cboEmpID)
        Me.TabPage3.Controls.Add(Me.btnViewEmpDateWiseAttendance)
        Me.TabPage3.Controls.Add(Me.ReportViewerEmpAttendance)
        Me.TabPage3.Controls.Add(Me.cboEmpName)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.cboWorkAs)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.dtp2)
        Me.TabPage3.Controls.Add(Me.dtp1)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1237, 499)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DateWise Attendance View of Employee"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Employee Name"
        '
        'cboEmpID
        '
        Me.cboEmpID.FormattingEnabled = True
        Me.cboEmpID.Location = New System.Drawing.Point(251, 51)
        Me.cboEmpID.Name = "cboEmpID"
        Me.cboEmpID.Size = New System.Drawing.Size(168, 21)
        Me.cboEmpID.TabIndex = 19
        '
        'btnViewEmpDateWiseAttendance
        '
        Me.btnViewEmpDateWiseAttendance.Location = New System.Drawing.Point(681, 58)
        Me.btnViewEmpDateWiseAttendance.Name = "btnViewEmpDateWiseAttendance"
        Me.btnViewEmpDateWiseAttendance.Size = New System.Drawing.Size(109, 28)
        Me.btnViewEmpDateWiseAttendance.TabIndex = 17
        Me.btnViewEmpDateWiseAttendance.Text = "View Report"
        Me.btnViewEmpDateWiseAttendance.UseSelectable = True
        '
        'ReportViewerEmpAttendance
        '
        Me.ReportViewerEmpAttendance.AutoSize = True
        Me.ReportViewerEmpAttendance.Location = New System.Drawing.Point(58, 101)
        Me.ReportViewerEmpAttendance.Name = "ReportViewerEmpAttendance"
        Me.ReportViewerEmpAttendance.Size = New System.Drawing.Size(969, 395)
        Me.ReportViewerEmpAttendance.TabIndex = 16
        '
        'cboEmpName
        '
        Me.cboEmpName.FormattingEnabled = True
        Me.cboEmpName.Location = New System.Drawing.Point(251, 51)
        Me.cboEmpName.Name = "cboEmpName"
        Me.cboEmpName.Size = New System.Drawing.Size(168, 21)
        Me.cboEmpName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Work As"
        '
        'cboWorkAs
        '
        Me.cboWorkAs.FormattingEnabled = True
        Me.cboWorkAs.Location = New System.Drawing.Point(251, 16)
        Me.cboWorkAs.Name = "cboWorkAs"
        Me.cboWorkAs.Size = New System.Drawing.Size(168, 21)
        Me.cboWorkAs.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(761, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(805, 20)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(124, 20)
        Me.dtp2.TabIndex = 2
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(590, 20)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(124, 20)
        Me.dtp1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Employee ID"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1237, 514)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Overall Hostel Student List"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.AutoSize = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(24, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.rptOvrallHostelStudents1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1390, 536)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewerRemainingStudents)
        Me.TabPage4.Controls.Add(Me.btnRemaingView)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.dtp3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1237, 514)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Student Remaining in Hostel"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewerRemainingStudents
        '
        Me.ReportViewerRemainingStudents.Location = New System.Drawing.Point(153, 89)
        Me.ReportViewerRemainingStudents.Name = "ReportViewerRemainingStudents"
        Me.ReportViewerRemainingStudents.Size = New System.Drawing.Size(659, 407)
        Me.ReportViewerRemainingStudents.TabIndex = 21
        '
        'btnRemaingView
        '
        Me.btnRemaingView.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnRemaingView.Location = New System.Drawing.Point(379, 49)
        Me.btnRemaingView.Name = "btnRemaingView"
        Me.btnRemaingView.Size = New System.Drawing.Size(109, 28)
        Me.btnRemaingView.TabIndex = 20
        Me.btnRemaingView.Text = "View Report"
        Me.btnRemaingView.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Select Date"
        '
        'dtp3
        '
        Me.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp3.Location = New System.Drawing.Point(442, 15)
        Me.dtp3.Name = "dtp3"
        Me.dtp3.Size = New System.Drawing.Size(124, 20)
        Me.dtp3.TabIndex = 18
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.MetroRadioButton2)
        Me.TabPage6.Controls.Add(Me.MetroRadioButton1)
        Me.TabPage6.Controls.Add(Me.MetroLabel5)
        Me.TabPage6.Controls.Add(Me.MetroLabel6)
        Me.TabPage6.Controls.Add(Me.cboYearStudentWent)
        Me.TabPage6.Controls.Add(Me.CboClassStudentWent)
        Me.TabPage6.Controls.Add(Me.MetroButton2)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.DateTimePicker1)
        Me.TabPage6.Controls.Add(Me.rptViewerWentStudentList)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1237, 514)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Student Went To College and remaining In Hostel "
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton2.Location = New System.Drawing.Point(585, 10)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(257, 29)
        Me.MetroRadioButton2.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroRadioButton2.TabIndex = 29
        Me.MetroRadioButton2.Text = "List Of Students Wents to College"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton1.Location = New System.Drawing.Point(356, 9)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(196, 26)
        Me.MetroRadioButton1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroRadioButton1.TabIndex = 28
        Me.MetroRadioButton1.Text = "List of Remaining Student"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(147, 42)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 27
        Me.MetroLabel5.Text = "Class"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(372, 45)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel6.TabIndex = 26
        Me.MetroLabel6.Text = "Year"
        '
        'cboYearStudentWent
        '
        Me.cboYearStudentWent.FormattingEnabled = True
        Me.cboYearStudentWent.ItemHeight = 23
        Me.cboYearStudentWent.Location = New System.Drawing.Point(436, 41)
        Me.cboYearStudentWent.Name = "cboYearStudentWent"
        Me.cboYearStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.cboYearStudentWent.TabIndex = 25
        Me.cboYearStudentWent.UseSelectable = True
        '
        'CboClassStudentWent
        '
        Me.CboClassStudentWent.FormattingEnabled = True
        Me.CboClassStudentWent.ItemHeight = 23
        Me.CboClassStudentWent.Location = New System.Drawing.Point(209, 41)
        Me.CboClassStudentWent.Name = "CboClassStudentWent"
        Me.CboClassStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.CboClassStudentWent.TabIndex = 24
        Me.CboClassStudentWent.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.Location = New System.Drawing.Point(867, 42)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(109, 28)
        Me.MetroButton2.TabIndex = 23
        Me.MetroButton2.Text = "View Report"
        Me.MetroButton2.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(604, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Select Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(699, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'rptViewerWentStudentList
        '
        Me.rptViewerWentStudentList.Location = New System.Drawing.Point(206, 98)
        Me.rptViewerWentStudentList.Name = "rptViewerWentStudentList"
        Me.rptViewerWentStudentList.Size = New System.Drawing.Size(607, 332)
        Me.rptViewerWentStudentList.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1237, 499)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Student Attendance "
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ReportCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1260, 564)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReportCollection"
        Me.Text = "ReportCollection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cboYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboClass As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnReportView As MetroFramework.Controls.MetroButton
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnViewClassWiseStudnet As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboyearWisestudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboClassWise As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEmpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboWorkAs As System.Windows.Forms.ComboBox
    Friend WithEvents ReportViewerEmpAttendance As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnViewEmpDateWiseAttendance As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEmpID As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemaingView As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewerRemainingStudents As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptOvrallHostelStudents1 As Hostel_Mangement.rptOvrallHostelStudents
    Friend WithEvents rptViewerWentStudentList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboYearStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CboClassStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
End Class
