<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroCboQueID = New MetroFramework.Controls.MetroComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCurrentUNewPass = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.currUserEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CurrUserPassConfirm = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CurrUserOldPass = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCurrentUsername = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpUserInfo = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboNId = New System.Windows.Forms.ComboBox()
        Me.cboAdduserType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboNUserName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.txtEmailId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNUserID = New System.Windows.Forms.TextBox()
        Me.txtNuserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpAdminAuthetication = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdminUser = New System.Windows.Forms.TextBox()
        Me.txtAdminPass = New System.Windows.Forms.TextBox()
        Me.btnAutheticateAdmin = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSelectUserContact = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSenderEmailpass = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSenderEmaiL = New System.Windows.Forms.TextBox()
        Me.cboSelectUser = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RichTxtSubject = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtReceiverEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQueAns = New System.Windows.Forms.TextBox()
        Me.MetroCboQue = New MetroFramework.Controls.MetroComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        Me.grpAdminAuthetication.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 310)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(692, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change Your Password"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MetroCboQue)
        Me.GroupBox1.Controls.Add(Me.txtQueAns)
        Me.GroupBox1.Controls.Add(Me.MetroCboQueID)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtCurrentUNewPass)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.currUserEmail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.CurrUserPassConfirm)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.CurrUserOldPass)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCurrentUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 267)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Updation"
        '
        'MetroCboQueID
        '
        Me.MetroCboQueID.FormattingEnabled = True
        Me.MetroCboQueID.ItemHeight = 23
        Me.MetroCboQueID.Location = New System.Drawing.Point(200, 189)
        Me.MetroCboQueID.Name = "MetroCboQueID"
        Me.MetroCboQueID.Size = New System.Drawing.Size(69, 29)
        Me.MetroCboQueID.TabIndex = 34
        Me.MetroCboQueID.UseSelectable = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(54, 199)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 16)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Security Question"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(54, 231)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 16)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Question Response"
        '
        'txtCurrentUNewPass
        '
        Me.txtCurrentUNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentUNewPass.Location = New System.Drawing.Point(200, 87)
        Me.txtCurrentUNewPass.MaxLength = 18
        Me.txtCurrentUNewPass.Name = "txtCurrentUNewPass"
        Me.txtCurrentUNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentUNewPass.Size = New System.Drawing.Size(201, 22)
        Me.txtCurrentUNewPass.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(54, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "New Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Email ID"
        '
        'currUserEmail
        '
        Me.currUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currUserEmail.Location = New System.Drawing.Point(200, 157)
        Me.currUserEmail.MaxLength = 50
        Me.currUserEmail.Name = "currUserEmail"
        Me.currUserEmail.Size = New System.Drawing.Size(201, 22)
        Me.currUserEmail.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Confirm"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(427, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CurrUserPassConfirm
        '
        Me.CurrUserPassConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrUserPassConfirm.Location = New System.Drawing.Point(200, 123)
        Me.CurrUserPassConfirm.MaxLength = 18
        Me.CurrUserPassConfirm.Name = "CurrUserPassConfirm"
        Me.CurrUserPassConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrUserPassConfirm.Size = New System.Drawing.Size(201, 22)
        Me.CurrUserPassConfirm.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(424, 51)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 55)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "View Password"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CurrUserOldPass
        '
        Me.CurrUserOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrUserOldPass.Location = New System.Drawing.Point(200, 51)
        Me.CurrUserOldPass.MaxLength = 18
        Me.CurrUserOldPass.Name = "CurrUserOldPass"
        Me.CurrUserOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrUserOldPass.Size = New System.Drawing.Size(201, 22)
        Me.CurrUserOldPass.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Old Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "User Name"
        '
        'txtCurrentUsername
        '
        Me.txtCurrentUsername.Enabled = False
        Me.txtCurrentUsername.Location = New System.Drawing.Point(200, 18)
        Me.txtCurrentUsername.Name = "txtCurrentUsername"
        Me.txtCurrentUsername.Size = New System.Drawing.Size(201, 22)
        Me.txtCurrentUsername.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpUserInfo)
        Me.TabPage2.Controls.Add(Me.grpAdminAuthetication)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(692, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admin"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpUserInfo
        '
        Me.grpUserInfo.BackColor = System.Drawing.Color.GhostWhite
        Me.grpUserInfo.Controls.Add(Me.Button1)
        Me.grpUserInfo.Controls.Add(Me.cboNId)
        Me.grpUserInfo.Controls.Add(Me.cboAdduserType)
        Me.grpUserInfo.Controls.Add(Me.Label9)
        Me.grpUserInfo.Controls.Add(Me.btnUpdate)
        Me.grpUserInfo.Controls.Add(Me.btnSave)
        Me.grpUserInfo.Controls.Add(Me.cboNUserName)
        Me.grpUserInfo.Controls.Add(Me.Label5)
        Me.grpUserInfo.Controls.Add(Me.txtConfirmPassword)
        Me.grpUserInfo.Controls.Add(Me.btnShowPassword)
        Me.grpUserInfo.Controls.Add(Me.txtEmailId)
        Me.grpUserInfo.Controls.Add(Me.Label4)
        Me.grpUserInfo.Controls.Add(Me.txtNpassword)
        Me.grpUserInfo.Controls.Add(Me.Label3)
        Me.grpUserInfo.Controls.Add(Me.txtNUserID)
        Me.grpUserInfo.Controls.Add(Me.txtNuserName)
        Me.grpUserInfo.Controls.Add(Me.Label2)
        Me.grpUserInfo.Controls.Add(Me.Label1)
        Me.grpUserInfo.Enabled = False
        Me.grpUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(230, 6)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(427, 272)
        Me.grpUserInfo.TabIndex = 17
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "View and Update User Info"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(265, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 26)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Delete User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboNId
        '
        Me.cboNId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNId.FormattingEnabled = True
        Me.cboNId.Location = New System.Drawing.Point(288, 56)
        Me.cboNId.Name = "cboNId"
        Me.cboNId.Size = New System.Drawing.Size(99, 24)
        Me.cboNId.TabIndex = 26
        '
        'cboAdduserType
        '
        Me.cboAdduserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdduserType.FormattingEnabled = True
        Me.cboAdduserType.Items.AddRange(New Object() {"ADMIN", "LOCAL"})
        Me.cboAdduserType.Location = New System.Drawing.Point(171, 23)
        Me.cboAdduserType.Name = "cboAdduserType"
        Me.cboAdduserType.Size = New System.Drawing.Size(93, 24)
        Me.cboAdduserType.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "User Type"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(157, 223)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 26)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(54, 223)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 26)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboNUserName
        '
        Me.cboNUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNUserName.FormattingEnabled = True
        Me.cboNUserName.Location = New System.Drawing.Point(288, 23)
        Me.cboNUserName.Name = "cboNUserName"
        Me.cboNUserName.Size = New System.Drawing.Size(99, 24)
        Me.cboNUserName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Confirm"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(171, 154)
        Me.txtConfirmPassword.MaxLength = 18
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(127, 22)
        Me.txtConfirmPassword.TabIndex = 9
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.Location = New System.Drawing.Point(304, 121)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(83, 49)
        Me.btnShowPassword.TabIndex = 10
        Me.btnShowPassword.Text = "View Password"
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'txtEmailId
        '
        Me.txtEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailId.Location = New System.Drawing.Point(171, 186)
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(216, 22)
        Me.txtEmailId.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email ID"
        '
        'txtNpassword
        '
        Me.txtNpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNpassword.Location = New System.Drawing.Point(171, 121)
        Me.txtNpassword.MaxLength = 18
        Me.txtNpassword.Name = "txtNpassword"
        Me.txtNpassword.Size = New System.Drawing.Size(127, 22)
        Me.txtNpassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password"
        '
        'txtNUserID
        '
        Me.txtNUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUserID.Location = New System.Drawing.Point(171, 56)
        Me.txtNUserID.Name = "txtNUserID"
        Me.txtNUserID.Size = New System.Drawing.Size(93, 22)
        Me.txtNUserID.TabIndex = 5
        '
        'txtNuserName
        '
        Me.txtNuserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuserName.Location = New System.Drawing.Point(171, 89)
        Me.txtNuserName.Name = "txtNuserName"
        Me.txtNuserName.Size = New System.Drawing.Size(216, 22)
        Me.txtNuserName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "User Name"
        '
        'grpAdminAuthetication
        '
        Me.grpAdminAuthetication.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpAdminAuthetication.Controls.Add(Me.Label8)
        Me.grpAdminAuthetication.Controls.Add(Me.Label7)
        Me.grpAdminAuthetication.Controls.Add(Me.txtAdminUser)
        Me.grpAdminAuthetication.Controls.Add(Me.txtAdminPass)
        Me.grpAdminAuthetication.Controls.Add(Me.btnAutheticateAdmin)
        Me.grpAdminAuthetication.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdminAuthetication.Location = New System.Drawing.Point(9, 9)
        Me.grpAdminAuthetication.Name = "grpAdminAuthetication"
        Me.grpAdminAuthetication.Size = New System.Drawing.Size(215, 269)
        Me.grpAdminAuthetication.TabIndex = 16
        Me.grpAdminAuthetication.TabStop = False
        Me.grpAdminAuthetication.Text = "Admin Authentication"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "User Name"
        '
        'txtAdminUser
        '
        Me.txtAdminUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUser.Location = New System.Drawing.Point(88, 39)
        Me.txtAdminUser.Name = "txtAdminUser"
        Me.txtAdminUser.Size = New System.Drawing.Size(121, 22)
        Me.txtAdminUser.TabIndex = 1
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.Location = New System.Drawing.Point(88, 78)
        Me.txtAdminPass.MaxLength = 18
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPass.Size = New System.Drawing.Size(121, 22)
        Me.txtAdminPass.TabIndex = 2
        '
        'btnAutheticateAdmin
        '
        Me.btnAutheticateAdmin.Location = New System.Drawing.Point(21, 124)
        Me.btnAutheticateAdmin.Name = "btnAutheticateAdmin"
        Me.btnAutheticateAdmin.Size = New System.Drawing.Size(168, 54)
        Me.btnAutheticateAdmin.TabIndex = 3
        Me.btnAutheticateAdmin.Text = "click me to further process"
        Me.btnAutheticateAdmin.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(692, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Send Mail"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(354, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(303, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Admin Mail id:- preeetsahu17@gmail.com contact:8827276370"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSelectUserContact)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.cboSelectUser)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.btnSendMail)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.RichTxtSubject)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtReceiverEmail)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(669, 257)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Send Login Details"
        '
        'lblSelectUserContact
        '
        Me.lblSelectUserContact.AutoSize = True
        Me.lblSelectUserContact.Location = New System.Drawing.Point(138, 191)
        Me.lblSelectUserContact.Name = "lblSelectUserContact"
        Me.lblSelectUserContact.Size = New System.Drawing.Size(20, 16)
        Me.lblSelectUserContact.TabIndex = 49
        Me.lblSelectUserContact.Text = "...."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtSenderEmailpass)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtSenderEmaiL)
        Me.GroupBox3.Location = New System.Drawing.Point(381, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 100)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mail Sender"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 16)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Password"
        '
        'txtSenderEmailpass
        '
        Me.txtSenderEmailpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenderEmailpass.Location = New System.Drawing.Point(92, 56)
        Me.txtSenderEmailpass.MaxLength = 18
        Me.txtSenderEmailpass.Name = "txtSenderEmailpass"
        Me.txtSenderEmailpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenderEmailpass.Size = New System.Drawing.Size(184, 22)
        Me.txtSenderEmailpass.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 16)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Email From"
        '
        'txtSenderEmaiL
        '
        Me.txtSenderEmaiL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenderEmaiL.Location = New System.Drawing.Point(92, 21)
        Me.txtSenderEmaiL.MaxLength = 50
        Me.txtSenderEmaiL.Name = "txtSenderEmaiL"
        Me.txtSenderEmaiL.Size = New System.Drawing.Size(184, 21)
        Me.txtSenderEmaiL.TabIndex = 52
        Me.txtSenderEmaiL.Text = "pkseduction2016@gmail.com"
        '
        'cboSelectUser
        '
        Me.cboSelectUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectUser.FormattingEnabled = True
        Me.cboSelectUser.Location = New System.Drawing.Point(141, 35)
        Me.cboSelectUser.Name = "cboSelectUser"
        Me.cboSelectUser.Size = New System.Drawing.Size(192, 23)
        Me.cboSelectUser.TabIndex = 47
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 16)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Contact"
        '
        'btnSendMail
        '
        Me.btnSendMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendMail.Location = New System.Drawing.Point(381, 130)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(126, 31)
        Me.btnSendMail.TabIndex = 44
        Me.btnSendMail.Text = "Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Subject"
        '
        'RichTxtSubject
        '
        Me.RichTxtSubject.Location = New System.Drawing.Point(141, 111)
        Me.RichTxtSubject.Name = "RichTxtSubject"
        Me.RichTxtSubject.Size = New System.Drawing.Size(192, 71)
        Me.RichTxtSubject.TabIndex = 42
        Me.RichTxtSubject.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Reciever Email ID"
        '
        'txtReceiverEmail
        '
        Me.txtReceiverEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiverEmail.Location = New System.Drawing.Point(141, 71)
        Me.txtReceiverEmail.MaxLength = 50
        Me.txtReceiverEmail.Name = "txtReceiverEmail"
        Me.txtReceiverEmail.Size = New System.Drawing.Size(192, 21)
        Me.txtReceiverEmail.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "User Name"
        '
        'txtQueAns
        '
        Me.txtQueAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQueAns.Location = New System.Drawing.Point(200, 228)
        Me.txtQueAns.MaxLength = 50
        Me.txtQueAns.Name = "txtQueAns"
        Me.txtQueAns.Size = New System.Drawing.Size(201, 22)
        Me.txtQueAns.TabIndex = 35
        '
        'MetroCboQue
        '
        Me.MetroCboQue.FormattingEnabled = True
        Me.MetroCboQue.ItemHeight = 23
        Me.MetroCboQue.Location = New System.Drawing.Point(200, 189)
        Me.MetroCboQue.Name = "MetroCboQue"
        Me.MetroCboQue.Size = New System.Drawing.Size(201, 29)
        Me.MetroCboQue.TabIndex = 36
        Me.MetroCboQue.UseSelectable = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangePassword"
        Me.ShowIcon = False
        Me.Text = "ChangePassword"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        Me.grpAdminAuthetication.ResumeLayout(False)
        Me.grpAdminAuthetication.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboNId As System.Windows.Forms.ComboBox
    Friend WithEvents cboAdduserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboNUserName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnShowPassword As System.Windows.Forms.Button
    Friend WithEvents txtEmailId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtNuserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpAdminAuthetication As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdminUser As System.Windows.Forms.TextBox
    Friend WithEvents txtAdminPass As System.Windows.Forms.TextBox
    Friend WithEvents btnAutheticateAdmin As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CurrUserPassConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CurrUserOldPass As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents currUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentUNewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnSendMail As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents RichTxtSubject As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtReceiverEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboSelectUser As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSenderEmailpass As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSenderEmaiL As System.Windows.Forms.TextBox
    Friend WithEvents lblSelectUserContact As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents MetroCboQueID As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtQueAns As System.Windows.Forms.TextBox
    Friend WithEvents MetroCboQue As MetroFramework.Controls.MetroComboBox
End Class
