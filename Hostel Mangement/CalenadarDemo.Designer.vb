<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalenadarDemo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalenadarDemo))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClick = New MetroFramework.Controls.MetroButton()
        Me.dtPickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSelected = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.MaxSelectionCount = 31
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Brown
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.Control
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnClick)
        Me.GroupBox1.Controls.Add(Me.dtPickerEnd)
        Me.GroupBox1.Controls.Add(Me.dtPickerStart)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'btnClick
        '
        Me.btnClick.FontSize = MetroFramework.MetroButtonSize.Medium
        resources.ApplyResources(Me.btnClick, "btnClick")
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Style = MetroFramework.MetroColorStyle.Orange
        Me.btnClick.UseSelectable = True
        '
        'dtPickerEnd
        '
        resources.ApplyResources(Me.dtPickerEnd, "dtPickerEnd")
        Me.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerEnd.Name = "dtPickerEnd"
        '
        'dtPickerStart
        '
        resources.ApplyResources(Me.dtPickerStart, "dtPickerStart")
        Me.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPickerStart.Name = "dtPickerStart"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboSelected)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboSearchBy)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Name = "Label3"
        '
        'cboSelected
        '
        Me.cboSelected.FormattingEnabled = True
        resources.ApplyResources(Me.cboSelected, "cboSelected")
        Me.cboSelected.Name = "cboSelected"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Name = "Label1"
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        resources.ApplyResources(Me.cboSearchBy, "cboSearchBy")
        Me.cboSearchBy.Name = "cboSearchBy"
        '
        'CalenadarDemo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "CalenadarDemo"
        Me.ShowIcon = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClick As MetroFramework.Controls.MetroButton
    Friend WithEvents dtPickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSelected As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
End Class
