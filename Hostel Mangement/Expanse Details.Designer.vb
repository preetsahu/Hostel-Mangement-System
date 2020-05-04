<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expanse_Details
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExpDescription = New System.Windows.Forms.RichTextBox()
        Me.mtExpType = New MetroFramework.Controls.MetroComboBox()
        Me.txtBillno = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtExpanse = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.txtExpDescription)
        Me.GroupBox1.Controls.Add(Me.mtExpType)
        Me.GroupBox1.Controls.Add(Me.txtBillno)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.dtExpanse)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtExpDescription
        '
        Me.txtExpDescription.Location = New System.Drawing.Point(138, 120)
        Me.txtExpDescription.Name = "txtExpDescription"
        Me.txtExpDescription.Size = New System.Drawing.Size(188, 52)
        Me.txtExpDescription.TabIndex = 3
        Me.txtExpDescription.Text = ""
        '
        'mtExpType
        '
        Me.mtExpType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mtExpType.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.mtExpType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mtExpType.ItemHeight = 19
        Me.mtExpType.Items.AddRange(New Object() {"Mess", "Electricity Bill", "Purchase New Item", "Maintainance", "Security", "Other"})
        Me.mtExpType.Location = New System.Drawing.Point(139, 73)
        Me.mtExpType.Name = "mtExpType"
        Me.mtExpType.Size = New System.Drawing.Size(188, 25)
        Me.mtExpType.TabIndex = 2
        Me.mtExpType.UseSelectable = True
        '
        'txtBillno
        '
        Me.txtBillno.Location = New System.Drawing.Point(138, 223)
        Me.txtBillno.Name = "txtBillno"
        Me.txtBillno.Size = New System.Drawing.Size(189, 21)
        Me.txtBillno.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(138, 188)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(189, 21)
        Me.txtAmount.TabIndex = 4
        '
        'dtExpanse
        '
        Me.dtExpanse.CustomFormat = "MM-dd-yyyy"
        Me.dtExpanse.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpanse.Location = New System.Drawing.Point(139, 38)
        Me.dtExpanse.Name = "dtExpanse"
        Me.dtExpanse.Size = New System.Drawing.Size(187, 21)
        Me.dtExpanse.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bill Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.btnClose)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 76)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnClose.Location = New System.Drawing.Point(183, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 34)
        Me.btnClose.Style = MetroFramework.MetroColorStyle.Silver
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSave.Location = New System.Drawing.Point(32, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 34)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Silver
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save Expanse"
        Me.btnSave.UseSelectable = True
        '
        'Expanse_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 371)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Expanse_Details"
        Me.ShowIcon = False
        Me.Text = "Expanse_Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillno As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtExpanse As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents txtExpDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents mtExpType As MetroFramework.Controls.MetroComboBox
End Class
