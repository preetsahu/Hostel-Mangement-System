<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dynamiceDemo
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
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnpdate = New System.Windows.Forms.Button()
        Me.dtPickerAttend = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnAttendance
        '
        Me.btnAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.Location = New System.Drawing.Point(12, 332)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(128, 32)
        Me.btnAttendance.TabIndex = 0
        Me.btnAttendance.Text = "btnAttend"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'btnpdate
        '
        Me.btnpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpdate.Location = New System.Drawing.Point(189, 332)
        Me.btnpdate.Name = "btnpdate"
        Me.btnpdate.Size = New System.Drawing.Size(128, 32)
        Me.btnpdate.TabIndex = 1
        Me.btnpdate.Text = "update"
        Me.btnpdate.UseVisualStyleBackColor = True
        '
        'dtPickerAttend
        '
        Me.dtPickerAttend.Location = New System.Drawing.Point(267, 12)
        Me.dtPickerAttend.Name = "dtPickerAttend"
        Me.dtPickerAttend.Size = New System.Drawing.Size(207, 20)
        Me.dtPickerAttend.TabIndex = 2
        '
        'dynamiceDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 376)
        Me.Controls.Add(Me.dtPickerAttend)
        Me.Controls.Add(Me.btnpdate)
        Me.Controls.Add(Me.btnAttendance)
        Me.Name = "dynamiceDemo"
        Me.Text = "dynamiceDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnpdate As System.Windows.Forms.Button
    Friend WithEvents dtPickerAttend As System.Windows.Forms.DateTimePicker
End Class
