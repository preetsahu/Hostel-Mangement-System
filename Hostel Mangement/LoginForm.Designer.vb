<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpVerification = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnNext = New MetroFramework.Controls.MetroButton()
        Me.qid5 = New System.Windows.Forms.RadioButton()
        Me.txtVerifyAns = New System.Windows.Forms.TextBox()
        Me.qid4 = New System.Windows.Forms.RadioButton()
        Me.qid3 = New System.Windows.Forms.RadioButton()
        Me.qid2 = New System.Windows.Forms.RadioButton()
        Me.qid1 = New System.Windows.Forms.RadioButton()
        Me.txtVerifyUser = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpUserInfo = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpVerification.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpUserInfo.SuspendLayout()
        Me.grpAdminAuthetication.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-1, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(561, 243)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpVerification)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(553, 214)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Login"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpVerification
        '
        Me.grpVerification.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grpVerification.Controls.Add(Me.Button3)
        Me.grpVerification.Controls.Add(Me.btnNext)
        Me.grpVerification.Controls.Add(Me.qid5)
        Me.grpVerification.Controls.Add(Me.txtVerifyAns)
        Me.grpVerification.Controls.Add(Me.qid4)
        Me.grpVerification.Controls.Add(Me.qid3)
        Me.grpVerification.Controls.Add(Me.qid2)
        Me.grpVerification.Controls.Add(Me.qid1)
        Me.grpVerification.Controls.Add(Me.txtVerifyUser)
        Me.grpVerification.Controls.Add(Me.Label12)
        Me.grpVerification.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVerification.Location = New System.Drawing.Point(198, -3)
        Me.grpVerification.Name = "grpVerification"
        Me.grpVerification.Size = New System.Drawing.Size(356, 221)
        Me.grpVerification.TabIndex = 14
        Me.grpVerification.TabStop = False
        Me.grpVerification.Text = "Verfication "
        Me.grpVerification.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(142, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 27)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "<----"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnNext.Location = New System.Drawing.Point(199, 181)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(146, 25)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Verfiy And Reset"
        Me.btnNext.UseSelectable = True
        '
        'qid5
        '
        Me.qid5.AutoSize = True
        Me.qid5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid5.Location = New System.Drawing.Point(18, 156)
        Me.qid5.Name = "qid5"
        Me.qid5.Size = New System.Drawing.Size(129, 22)
        Me.qid5.TabIndex = 10
        Me.qid5.TabStop = True
        Me.qid5.Text = "Your Best Friend"
        Me.qid5.UseVisualStyleBackColor = True
        '
        'txtVerifyAns
        '
        Me.txtVerifyAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyAns.Location = New System.Drawing.Point(199, 151)
        Me.txtVerifyAns.Name = "txtVerifyAns"
        Me.txtVerifyAns.Size = New System.Drawing.Size(149, 22)
        Me.txtVerifyAns.TabIndex = 7
        '
        'qid4
        '
        Me.qid4.AutoSize = True
        Me.qid4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid4.Location = New System.Drawing.Point(18, 131)
        Me.qid4.Name = "qid4"
        Me.qid4.Size = New System.Drawing.Size(156, 22)
        Me.qid4.TabIndex = 8
        Me.qid4.TabStop = True
        Me.qid4.Text = "Your Favourite Noble"
        Me.qid4.UseVisualStyleBackColor = True
        '
        'qid3
        '
        Me.qid3.AutoSize = True
        Me.qid3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid3.Location = New System.Drawing.Point(18, 106)
        Me.qid3.Name = "qid3"
        Me.qid3.Size = New System.Drawing.Size(147, 22)
        Me.qid3.TabIndex = 7
        Me.qid3.TabStop = True
        Me.qid3.Text = "What is your Hobby"
        Me.qid3.UseVisualStyleBackColor = True
        '
        'qid2
        '
        Me.qid2.AutoSize = True
        Me.qid2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid2.Location = New System.Drawing.Point(18, 80)
        Me.qid2.Name = "qid2"
        Me.qid2.Size = New System.Drawing.Size(169, 22)
        Me.qid2.TabIndex = 6
        Me.qid2.TabStop = True
        Me.qid2.Text = "What is your Nick name"
        Me.qid2.UseVisualStyleBackColor = True
        '
        'qid1
        '
        Me.qid1.AutoSize = True
        Me.qid1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qid1.Location = New System.Drawing.Point(18, 56)
        Me.qid1.Name = "qid1"
        Me.qid1.Size = New System.Drawing.Size(205, 22)
        Me.qid1.TabIndex = 5
        Me.qid1.TabStop = True
        Me.qid1.Text = "What is your favourite colour"
        Me.qid1.UseVisualStyleBackColor = True
        '
        'txtVerifyUser
        '
        Me.txtVerifyUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyUser.Location = New System.Drawing.Point(197, 29)
        Me.txtVerifyUser.Name = "txtVerifyUser"
        Me.txtVerifyUser.Size = New System.Drawing.Size(149, 22)
        Me.txtVerifyUser.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Enter User Email or Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 218)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(195, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 213)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(60, 129)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(163, 27)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forget Password"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(156, 167)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(83, 39)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(65, 167)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 39)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&OK"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(65, 96)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(172, 30)
        Me.txtpassword.TabIndex = 2
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(65, 37)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(174, 30)
        Me.txtusername.TabIndex = 1
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(15, 70)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(101, 23)
        Me.PasswordLabel.TabIndex = 8
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(15, 11)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(120, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "User Name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.grpUserInfo)
        Me.TabPage2.Controls.Add(Me.grpAdminAuthetication)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(553, 214)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add and update User"
        '
        'grpUserInfo
        '
        Me.grpUserInfo.BackColor = System.Drawing.Color.GhostWhite
        Me.grpUserInfo.Controls.Add(Me.btnClear)
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
        Me.grpUserInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserInfo.Location = New System.Drawing.Point(195, 0)
        Me.grpUserInfo.Name = "grpUserInfo"
        Me.grpUserInfo.Size = New System.Drawing.Size(350, 221)
        Me.grpUserInfo.TabIndex = 14
        Me.grpUserInfo.TabStop = False
        Me.grpUserInfo.Text = "View and Update User Info"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(7, 187)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 26)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Tag = ""
        Me.btnClear.Text = "New"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(230, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 26)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Delete User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboNId
        '
        Me.cboNId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNId.FormattingEnabled = True
        Me.cboNId.Location = New System.Drawing.Point(242, 51)
        Me.cboNId.Name = "cboNId"
        Me.cboNId.Size = New System.Drawing.Size(93, 24)
        Me.cboNId.TabIndex = 26
        '
        'cboAdduserType
        '
        Me.cboAdduserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAdduserType.FormattingEnabled = True
        Me.cboAdduserType.Items.AddRange(New Object() {"ADMIN", "LOCAL"})
        Me.cboAdduserType.Location = New System.Drawing.Point(125, 21)
        Me.cboAdduserType.Name = "cboAdduserType"
        Me.cboAdduserType.Size = New System.Drawing.Size(85, 24)
        Me.cboAdduserType.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "User Type"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(152, 187)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(76, 26)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(79, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 26)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboNUserName
        '
        Me.cboNUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNUserName.FormattingEnabled = True
        Me.cboNUserName.Location = New System.Drawing.Point(242, 21)
        Me.cboNUserName.Name = "cboNUserName"
        Me.cboNUserName.Size = New System.Drawing.Size(93, 24)
        Me.cboNUserName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Confirm"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(125, 134)
        Me.txtConfirmPassword.MaxLength = 18
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(127, 22)
        Me.txtConfirmPassword.TabIndex = 9
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassword.Location = New System.Drawing.Point(258, 106)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(77, 49)
        Me.btnShowPassword.TabIndex = 10
        Me.btnShowPassword.Text = "View Password"
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'txtEmailId
        '
        Me.txtEmailId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailId.Location = New System.Drawing.Point(125, 163)
        Me.txtEmailId.Name = "txtEmailId"
        Me.txtEmailId.Size = New System.Drawing.Size(210, 22)
        Me.txtEmailId.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Email ID"
        '
        'txtNpassword
        '
        Me.txtNpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNpassword.Location = New System.Drawing.Point(125, 106)
        Me.txtNpassword.MaxLength = 18
        Me.txtNpassword.Name = "txtNpassword"
        Me.txtNpassword.Size = New System.Drawing.Size(127, 22)
        Me.txtNpassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password"
        '
        'txtNUserID
        '
        Me.txtNUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNUserID.Location = New System.Drawing.Point(125, 51)
        Me.txtNUserID.Name = "txtNUserID"
        Me.txtNUserID.Size = New System.Drawing.Size(85, 22)
        Me.txtNUserID.TabIndex = 5
        '
        'txtNuserName
        '
        Me.txtNuserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuserName.Location = New System.Drawing.Point(125, 79)
        Me.txtNuserName.Name = "txtNuserName"
        Me.txtNuserName.Size = New System.Drawing.Size(210, 22)
        Me.txtNuserName.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "User ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 83)
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
        Me.grpAdminAuthetication.Location = New System.Drawing.Point(9, 6)
        Me.grpAdminAuthetication.Name = "grpAdminAuthetication"
        Me.grpAdminAuthetication.Size = New System.Drawing.Size(180, 207)
        Me.grpAdminAuthetication.TabIndex = 13
        Me.grpAdminAuthetication.TabStop = False
        Me.grpAdminAuthetication.Text = "Admin Authentication"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "User Name"
        '
        'txtAdminUser
        '
        Me.txtAdminUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUser.Location = New System.Drawing.Point(88, 32)
        Me.txtAdminUser.Name = "txtAdminUser"
        Me.txtAdminUser.Size = New System.Drawing.Size(83, 22)
        Me.txtAdminUser.TabIndex = 1
        '
        'txtAdminPass
        '
        Me.txtAdminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPass.Location = New System.Drawing.Point(88, 71)
        Me.txtAdminPass.MaxLength = 18
        Me.txtAdminPass.Name = "txtAdminPass"
        Me.txtAdminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPass.Size = New System.Drawing.Size(83, 22)
        Me.txtAdminPass.TabIndex = 2
        '
        'btnAutheticateAdmin
        '
        Me.btnAutheticateAdmin.Location = New System.Drawing.Point(6, 109)
        Me.btnAutheticateAdmin.Name = "btnAutheticateAdmin"
        Me.btnAutheticateAdmin.Size = New System.Drawing.Size(168, 54)
        Me.btnAutheticateAdmin.TabIndex = 3
        Me.btnAutheticateAdmin.Text = "click me to further process"
        Me.btnAutheticateAdmin.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.RichTextBox1)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(553, 214)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Send Mail"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(45, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Email Body"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(209, 92)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 28)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(401, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 28)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "password here"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(416, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Send Mail"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(209, 135)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(178, 70)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(209, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 28)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "preetsahu17@gmail.com"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(209, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 28)
        Me.TextBox1.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Subject"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Receiver Mail Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Enter Your Email"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(561, 246)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hostel Management System Login"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpVerification.ResumeLayout(False)
        Me.grpVerification.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpUserInfo.ResumeLayout(False)
        Me.grpUserInfo.PerformLayout()
        Me.grpAdminAuthetication.ResumeLayout(False)
        Me.grpAdminAuthetication.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnShowPassword As System.Windows.Forms.Button
    Friend WithEvents grpAdminAuthetication As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdminUser As System.Windows.Forms.TextBox
    Friend WithEvents txtAdminPass As System.Windows.Forms.TextBox
    Friend WithEvents btnAutheticateAdmin As System.Windows.Forms.Button
    Friend WithEvents grpUserInfo As System.Windows.Forms.GroupBox
    Friend WithEvents cboNUserName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtNuserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboAdduserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboNId As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents grpVerification As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnNext As MetroFramework.Controls.MetroButton
    Friend WithEvents qid5 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVerifyAns As System.Windows.Forms.TextBox
    Friend WithEvents qid4 As System.Windows.Forms.RadioButton
    Friend WithEvents qid3 As System.Windows.Forms.RadioButton
    Friend WithEvents qid2 As System.Windows.Forms.RadioButton
    Friend WithEvents qid1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtVerifyUser As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
