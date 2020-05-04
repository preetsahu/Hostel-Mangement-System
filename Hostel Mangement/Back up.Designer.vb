<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Back_up
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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.mtSource = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.mTdes = New MetroFramework.Controls.MetroTextBox()
        Me.mTfile = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(73, 49)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(117, 26)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Select Source"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(73, 91)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(117, 26)
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "select destination"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton3.Location = New System.Drawing.Point(147, 190)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(117, 26)
        Me.MetroButton3.TabIndex = 6
        Me.MetroButton3.Text = "Take Backup"
        Me.MetroButton3.UseSelectable = True
        '
        'mtSource
        '
        '
        '
        '
        Me.mtSource.CustomButton.Image = Nothing
        Me.mtSource.CustomButton.Location = New System.Drawing.Point(131, 1)
        Me.mtSource.CustomButton.Name = ""
        Me.mtSource.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtSource.CustomButton.TabIndex = 1
        Me.mtSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtSource.CustomButton.UseSelectable = True
        Me.mtSource.CustomButton.Visible = False
        Me.mtSource.Lines = New String(-1) {}
        Me.mtSource.Location = New System.Drawing.Point(206, 49)
        Me.mtSource.MaxLength = 32767
        Me.mtSource.Name = "mtSource"
        Me.mtSource.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtSource.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtSource.SelectedText = ""
        Me.mtSource.SelectionLength = 0
        Me.mtSource.SelectionStart = 0
        Me.mtSource.Size = New System.Drawing.Size(153, 23)
        Me.mtSource.TabIndex = 2
        Me.mtSource.UseSelectable = True
        Me.mtSource.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtSource.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(-3, 2)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(432, 24)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile1.TabIndex = 6
        Me.MetroTile1.Text = "Create Back-Up of Database"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseCustomForeColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'mTdes
        '
        '
        '
        '
        Me.mTdes.CustomButton.Image = Nothing
        Me.mTdes.CustomButton.Location = New System.Drawing.Point(131, 1)
        Me.mTdes.CustomButton.Name = ""
        Me.mTdes.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mTdes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mTdes.CustomButton.TabIndex = 1
        Me.mTdes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mTdes.CustomButton.UseSelectable = True
        Me.mTdes.CustomButton.Visible = False
        Me.mTdes.Lines = New String(-1) {}
        Me.mTdes.Location = New System.Drawing.Point(206, 91)
        Me.mTdes.MaxLength = 32767
        Me.mTdes.Name = "mTdes"
        Me.mTdes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mTdes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mTdes.SelectedText = ""
        Me.mTdes.SelectionLength = 0
        Me.mTdes.SelectionStart = 0
        Me.mTdes.Size = New System.Drawing.Size(153, 23)
        Me.mTdes.TabIndex = 4
        Me.mTdes.UseSelectable = True
        Me.mTdes.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mTdes.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mTfile
        '
        '
        '
        '
        Me.mTfile.CustomButton.Image = Nothing
        Me.mTfile.CustomButton.Location = New System.Drawing.Point(131, 1)
        Me.mTfile.CustomButton.Name = ""
        Me.mTfile.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mTfile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mTfile.CustomButton.TabIndex = 1
        Me.mTfile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mTfile.CustomButton.UseSelectable = True
        Me.mTfile.CustomButton.Visible = False
        Me.mTfile.Lines = New String(-1) {}
        Me.mTfile.Location = New System.Drawing.Point(207, 131)
        Me.mTfile.MaxLength = 32767
        Me.mTfile.Name = "mTfile"
        Me.mTfile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mTfile.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mTfile.SelectedText = ""
        Me.mTfile.SelectionLength = 0
        Me.mTfile.SelectionStart = 0
        Me.mTfile.Size = New System.Drawing.Size(153, 23)
        Me.mTfile.TabIndex = 5
        Me.mTfile.UseSelectable = True
        Me.mTfile.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mTfile.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MetroTile4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTile4.Location = New System.Drawing.Point(73, 133)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(117, 23)
        Me.MetroTile4.TabIndex = 13
        Me.MetroTile4.Text = "Enter File Name"
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseCustomForeColor = True
        Me.MetroTile4.UseSelectable = True
        '
        'Back_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 243)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.mTfile)
        Me.Controls.Add(Me.mTdes)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.mtSource)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Back_up"
        Me.Text = "Back_up"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents mtSource As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents mTdes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mTfile As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
End Class
