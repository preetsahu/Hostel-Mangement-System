<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptStudentsWentToCollege
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
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cboYearStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.CboClassStudentWent = New MetroFramework.Controls.MetroComboBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rptViewerWentStudentList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(72, 69)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 34
        Me.MetroLabel5.Text = "Class"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Location = New System.Drawing.Point(297, 72)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(58, 20)
        Me.MetroLabel6.TabIndex = 33
        Me.MetroLabel6.Text = "Year"
        '
        'cboYearStudentWent
        '
        Me.cboYearStudentWent.FormattingEnabled = True
        Me.cboYearStudentWent.ItemHeight = 23
        Me.cboYearStudentWent.Location = New System.Drawing.Point(361, 68)
        Me.cboYearStudentWent.Name = "cboYearStudentWent"
        Me.cboYearStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.cboYearStudentWent.TabIndex = 32
        Me.cboYearStudentWent.UseSelectable = True
        '
        'CboClassStudentWent
        '
        Me.CboClassStudentWent.FormattingEnabled = True
        Me.CboClassStudentWent.ItemHeight = 23
        Me.CboClassStudentWent.Location = New System.Drawing.Point(134, 68)
        Me.CboClassStudentWent.Name = "CboClassStudentWent"
        Me.CboClassStudentWent.Size = New System.Drawing.Size(127, 29)
        Me.CboClassStudentWent.TabIndex = 31
        Me.CboClassStudentWent.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.Location = New System.Drawing.Point(792, 69)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(109, 28)
        Me.MetroButton2.TabIndex = 30
        Me.MetroButton2.Text = "View Report"
        Me.MetroButton2.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Select Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(624, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 28
        '
        'rptViewerWentStudentList
        '
        Me.rptViewerWentStudentList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rptViewerWentStudentList.Location = New System.Drawing.Point(0, 136)
        Me.rptViewerWentStudentList.Name = "rptViewerWentStudentList"
        Me.rptViewerWentStudentList.Size = New System.Drawing.Size(1016, 332)
        Me.rptViewerWentStudentList.TabIndex = 35
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MetroTile1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MetroTile1.Location = New System.Drawing.Point(342, 12)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(456, 41)
        Me.MetroTile1.TabIndex = 36
        Me.MetroTile1.Text = "Classwise Report of students went to college"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'rptStudentsWentToCollege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 468)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.rptViewerWentStudentList)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.cboYearStudentWent)
        Me.Controls.Add(Me.CboClassStudentWent)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "rptStudentsWentToCollege"
        Me.ShowIcon = False
        Me.Text = "List of Students went to college"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboYearStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CboClassStudentWent As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rptViewerWentStudentList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
End Class
