<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptIndividualStudentDetails
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Cboclass = New MetroFramework.Controls.MetroComboBox()
        Me.cboYear = New MetroFramework.Controls.MetroComboBox()
        Me.cboSelected = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 132)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(863, 490)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Class"
        '
        'MetroButton1
        '
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton1.Location = New System.Drawing.Point(286, 87)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(125, 29)
        Me.MetroButton1.TabIndex = 39
        Me.MetroButton1.Text = "View Report"
        Me.MetroButton1.UseSelectable = True
        '
        'Cboclass
        '
        Me.Cboclass.FormattingEnabled = True
        Me.Cboclass.ItemHeight = 23
        Me.Cboclass.Location = New System.Drawing.Point(374, 14)
        Me.Cboclass.Name = "Cboclass"
        Me.Cboclass.Size = New System.Drawing.Size(75, 29)
        Me.Cboclass.TabIndex = 40
        Me.Cboclass.UseSelectable = True
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.ItemHeight = 23
        Me.cboYear.Location = New System.Drawing.Point(518, 14)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(75, 29)
        Me.cboYear.TabIndex = 40
        Me.cboYear.UseSelectable = True
        '
        'cboSelected
        '
        Me.cboSelected.FormattingEnabled = True
        Me.cboSelected.ItemHeight = 23
        Me.cboSelected.Location = New System.Drawing.Point(374, 49)
        Me.cboSelected.Name = "cboSelected"
        Me.cboSelected.Size = New System.Drawing.Size(219, 29)
        Me.cboSelected.TabIndex = 40
        Me.cboSelected.UseSelectable = True
        '
        'rptIndividualStudentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 634)
        Me.Controls.Add(Me.cboSelected)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Cboclass)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptIndividualStudentDetails"
        Me.ShowIcon = False
        Me.Text = "Report Student Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Cboclass As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboYear As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboSelected As MetroFramework.Controls.MetroComboBox
End Class
