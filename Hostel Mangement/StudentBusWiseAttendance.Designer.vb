<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentBusWiseAttendance
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
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.btnView = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCheckMode = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboBusID = New MetroFramework.Controls.MetroComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.rptViewerWentStudentList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cboYearStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.CboClassStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.btnWent = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnRemain = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cboYearRemainStudent = New MetroFramework.Controls.MetroComboBox()
        Me.cboClassRemainStudent = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1023, 572)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroButton2)
        Me.TabPage1.Controls.Add(Me.btnView)
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cboCheckMode)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboBusID)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daily Student Attendance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MetroButton2
        '
        Me.MetroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroButton2.Location = New System.Drawing.Point(765, 117)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(115, 32)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "close"
        Me.MetroButton2.UseSelectable = True
        '
        'btnView
        '
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnView.Location = New System.Drawing.Point(481, 16)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(95, 32)
        Me.btnView.TabIndex = 3
        Me.btnView.Text = "View Student"
        Me.btnView.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MetroButton1.Location = New System.Drawing.Point(765, 62)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(115, 32)
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Take Attendance"
        Me.MetroButton1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(683, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Check Mode"
        '
        'cboCheckMode
        '
        Me.cboCheckMode.FormattingEnabled = True
        Me.cboCheckMode.ItemHeight = 23
        Me.cboCheckMode.Items.AddRange(New Object() {"Check in", "Check out"})
        Me.cboCheckMode.Location = New System.Drawing.Point(765, 16)
        Me.cboCheckMode.Name = "cboCheckMode"
        Me.cboCheckMode.Size = New System.Drawing.Size(115, 29)
        Me.cboCheckMode.TabIndex = 4
        Me.cboCheckMode.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bus Number"
        '
        'cboBusID
        '
        Me.cboBusID.FormattingEnabled = True
        Me.cboBusID.ItemHeight = 23
        Me.cboBusID.Location = New System.Drawing.Point(312, 16)
        Me.cboBusID.Name = "cboBusID"
        Me.cboBusID.Size = New System.Drawing.Size(115, 29)
        Me.cboBusID.TabIndex = 2
        Me.cboBusID.UseSelectable = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(20, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 386)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Students"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MetroLabel5)
        Me.TabPage2.Controls.Add(Me.MetroTile1)
        Me.TabPage2.Controls.Add(Me.rptViewerWentStudentList)
        Me.TabPage2.Controls.Add(Me.MetroLabel6)
        Me.TabPage2.Controls.Add(Me.cboYearStudentWent)
        Me.TabPage2.Controls.Add(Me.CboClassStudentWent)
        Me.TabPage2.Controls.Add(Me.btnWent)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report of Students went to college"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(92, 95)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 45
        Me.MetroLabel5.Text = "Class"
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MetroTile1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MetroTile1.Location = New System.Drawing.Point(322, 31)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(456, 41)
        Me.MetroTile1.TabIndex = 44
        Me.MetroTile1.Text = "Classwise Report of students went to college"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'rptViewerWentStudentList
        '
        Me.rptViewerWentStudentList.Location = New System.Drawing.Point(162, 159)
        Me.rptViewerWentStudentList.Name = "rptViewerWentStudentList"
        Me.rptViewerWentStudentList.Size = New System.Drawing.Size(636, 362)
        Me.rptViewerWentStudentList.TabIndex = 43
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(297, 95)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel6.TabIndex = 42
        Me.MetroLabel6.Text = "Year"
        '
        'cboYearStudentWent
        '
        Me.cboYearStudentWent.FormattingEnabled = True
        Me.cboYearStudentWent.ItemHeight = 23
        Me.cboYearStudentWent.Location = New System.Drawing.Point(361, 91)
        Me.cboYearStudentWent.Name = "cboYearStudentWent"
        Me.cboYearStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.cboYearStudentWent.TabIndex = 41
        Me.cboYearStudentWent.UseSelectable = True
        '
        'CboClassStudentWent
        '
        Me.CboClassStudentWent.FormattingEnabled = True
        Me.CboClassStudentWent.ItemHeight = 23
        Me.CboClassStudentWent.Location = New System.Drawing.Point(153, 91)
        Me.CboClassStudentWent.Name = "CboClassStudentWent"
        Me.CboClassStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.CboClassStudentWent.TabIndex = 40
        Me.CboClassStudentWent.UseSelectable = True
        '
        'btnWent
        '
        Me.btnWent.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnWent.Location = New System.Drawing.Point(796, 91)
        Me.btnWent.Name = "btnWent"
        Me.btnWent.Size = New System.Drawing.Size(109, 28)
        Me.btnWent.TabIndex = 39
        Me.btnWent.Text = "View Report"
        Me.btnWent.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Select Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(624, 95)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 21)
        Me.DateTimePicker2.TabIndex = 37
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnRemain)
        Me.TabPage3.Controls.Add(Me.MetroLabel1)
        Me.TabPage3.Controls.Add(Me.MetroTile2)
        Me.TabPage3.Controls.Add(Me.MetroLabel2)
        Me.TabPage3.Controls.Add(Me.cboYearRemainStudent)
        Me.TabPage3.Controls.Add(Me.cboClassRemainStudent)
        Me.TabPage3.Controls.Add(Me.MetroButton4)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.DateTimePicker3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report of Students remaining in hostel"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnRemain
        '
        Me.btnRemain.Location = New System.Drawing.Point(195, 128)
        Me.btnRemain.Name = "btnRemain"
        Me.btnRemain.Size = New System.Drawing.Size(636, 362)
        Me.btnRemain.TabIndex = 54
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(99, 79)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel1.TabIndex = 53
        Me.MetroLabel1.Text = "Class"
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MetroTile2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MetroTile2.Location = New System.Drawing.Point(329, 15)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(456, 41)
        Me.MetroTile2.TabIndex = 52
        Me.MetroTile2.Text = "Classwise Report of students remaining in Hostel"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseCustomForeColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(304, 79)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel2.TabIndex = 51
        Me.MetroLabel2.Text = "Year"
        '
        'cboYearRemainStudent
        '
        Me.cboYearRemainStudent.FormattingEnabled = True
        Me.cboYearRemainStudent.ItemHeight = 23
        Me.cboYearRemainStudent.Location = New System.Drawing.Point(368, 75)
        Me.cboYearRemainStudent.Name = "cboYearRemainStudent"
        Me.cboYearRemainStudent.Size = New System.Drawing.Size(127, 29)
        Me.cboYearRemainStudent.TabIndex = 50
        Me.cboYearRemainStudent.UseSelectable = True
        '
        'cboClassRemainStudent
        '
        Me.cboClassRemainStudent.FormattingEnabled = True
        Me.cboClassRemainStudent.ItemHeight = 23
        Me.cboClassRemainStudent.Location = New System.Drawing.Point(156, 74)
        Me.cboClassRemainStudent.Name = "cboClassRemainStudent"
        Me.cboClassRemainStudent.Size = New System.Drawing.Size(127, 29)
        Me.cboClassRemainStudent.TabIndex = 49
        Me.cboClassRemainStudent.UseSelectable = True
        '
        'MetroButton4
        '
        Me.MetroButton4.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton4.Location = New System.Drawing.Point(803, 75)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(109, 28)
        Me.MetroButton4.TabIndex = 48
        Me.MetroButton4.Text = "View Report"
        Me.MetroButton4.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Select Date"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(631, 79)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(124, 21)
        Me.DateTimePicker3.TabIndex = 46
        '
        'StudentBusWiseAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MetroButton2
        Me.ClientSize = New System.Drawing.Size(1047, 606)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "StudentBusWiseAttendance"
        Me.ShowIcon = False
        Me.Text = "Student BusWise Attendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCheckMode As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboBusID As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnView As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents rptViewerWentStudentList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboYearStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CboClassStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnWent As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboYearRemainStudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboClassRemainStudent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRemain As Microsoft.Reporting.WinForms.ReportViewer
End Class
