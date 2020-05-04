Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Public Class LoginForm
    Dim query As String
    Public loginAttempt As Integer
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If txtpassword.Text = "" And txtusername.Text = "" Then
            MsgBox("Authentication Failed,please enter your name with password", MsgBoxStyle.Exclamation)
        ElseIf txtusername.Text = "" Then
            MsgBox("user name  missing", MsgBoxStyle.Information)
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("please enter valid password", MsgBoxStyle.Information)
            txtpassword.Focus()
        Else
            Try
                con.Open()
                query = "SELECT * FROM LoginUser WHERE USER_NAME='" + UCase(txtusername.Text) + "' and uPASSWORD='" + txtpassword.Text + "'"
                Dim CMD As New OleDbCommand(query, con)
                Dim READER As OleDbDataReader = CMD.ExecuteReader
                If READER.Read = False Then
                    MsgBox("Login Failed!", vbCritical, "Note")
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    txtusername.Focus()
                    '  loginAuthetication = 0                  'variable used to show login authetication befor loading form

                    loginAttempt = loginAttempt + 1
                    If loginAttempt = 0 Then
                        MsgBox("sorry login failed")
                    Else
                        MsgBox(Convert.ToString(3 - loginAttempt) + " Remaining")
                    End If
                    If loginAttempt >= 3 Then
                        MsgBox("login failed")
                        Me.Close()
                    End If
                Else
                    MsgBox("login sucessful")
                    Dim uType As String = READER(1).ToString
                    If uType = "ADMIN" Then
                        Hostel_Management_System.StatusStrip1.Items(1).Text = Trim(UCase(txtusername.Text))
                        Dim datenow As Date = Now
                        Hostel_Management_System.StatusStrip1.Items(3).Text = "Date and Time: " & datenow.ToString("MMMM dd yyyy") & " " & TimeOfDay
                        con.Close()
                        loginAuthetication = 1
                        Hostel_Management_System.Show()
                        Me.Hide()
                    ElseIf uType = "LOCAL" Then
                        Gaurd_View.StatusStrip.Items(1).Text = Trim(UCase(txtusername.Text))
                        Dim datenow As Date = Now
                        Gaurd_View.StatusStrip.Items(3).Text = datenow.ToString("MMMM dd yyyy") & " " & TimeOfDay
                        con.Close()
                        loginAuthetication = 1                'variable used to show login authetication befor loading form
                        Gaurd_View.Show()
                        Me.Hide()
                    End If
                    End If
                    CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            txtusername.Text = ""
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim con As New OleDbConnection
        con = connectTOhms()
        grpVerification.Visible = True
        GroupBox1.Hide()
        txtusername.Text = ""
        txtpassword.Text = ""
        If txtusername.Text = "" Then
            'MsgBox("please enter user name")
            txtusername.Focus()
            'Else
            '    Dim getEmail As String                      '''''''''''''''''''''' get reciever email address
            '    getEmail = InputBox("enter your Email address:", "Email")

            '    Dim ipass As String = getRandom()       ''''''''''''''''''''''''''' get randomly password '''''''''''''''''''''''''''''
            '    MsgBox(ipass)

            '    '''''''''''''''''''''''''''''''''''''''' update password of user ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    Try
            '        con.Open()
            '        query = "update LoginUser set uPassword=? where USER_NAME=?"
            '        Dim CMD As New OleDbCommand(query, con)
            '        CMD.Parameters.AddWithValue("?", ipass)
            '        CMD.Parameters.AddWithValue("?", txtusername.Text)
            '        CMD.ExecuteNonQuery()
            '        MsgBox("your password has been Resetted,please check your mail")
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    Finally
            '        con.Close()
            '    End Try

            '    '''''''''''''''''''''''''''''' ''''''''''''''''''''' '''''''''''''''''''''''''''''''''''''''''''''''''''''
            '    Dim fupassword As String = ""
            '    Dim funame As String = ""
            '    Dim fuemail As String = ""
            '    Dim fuid As String = ""
            '    Dim fuContact As String = ""
            '    Dim fuserType As String = ""
            '    Try
            '        con.Open()
            '        query = "select * from LoginUser where USER_NAME like '" + txtusername.Text + "'"
            '        Dim cmd As New OleDbCommand(query, con)
            '        Dim reader As OleDbDataReader = cmd.ExecuteReader
            '        While reader.Read
            '            fuemail = reader(4).ToString
            '            fuContact = reader(5).ToString
            '            fuid = reader(0).ToString
            '            funame = reader(2).ToString
            '            fuserType = reader(1).ToString
            '            fupassword = reader(3).ToString
            '        End While
            '        cmd.Dispose()
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    Finally
            '        con.Close()
            '    End Try

            '    MsgBox(getEmail)
            '    '''''''''''''''''''''''''''''''''''''' mail to user email ''''''''''''''''''''''''''''''''''
            '    Try
            '        Dim smtpserver As New SmtpClient
            '        Dim email As New MailMessage
            '        smtpserver.Credentials = New Net.NetworkCredential("dcbca2@gmail.com", "finalnew")
            '        smtpserver.Port = 587
            '        smtpserver.EnableSsl = True
            '        smtpserver.Host = "smtp.gmail.com"
            '        email = New MailMessage
            '        email.From = New MailAddress("dcbca2@gmail.com", "Admin Disha Hostel Raipur")
            '        email.To.Add(Trim(getEmail))
            '        email.Subject = "Login Password info"
            '        email.Body = "Dear User your password has been changed" + "your password is : " + fupassword
            '        smtpserver.Send(email)
            '        MessageBox.Show("Email Sent to :" + getEmail)
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)
            '    Finally

            '    End Try
        End If
      
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''' random funcion predefined in Random class ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Shared random As New Random()
    Public Function getRandom()
        Dim i As Integer
        For i = 0 To 1
            i = random.Next(1, 1000000)              ' MsgBox(Convert.ToString(random.Next(1, 1000000)))
        Next
        Return i
    End Function
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getRandom()
        grpUserInfo.Enabled = False
        Me.SetDesktopLocation(500, 200)
        cboNUserName.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboNUserName.DataSource = dt
            cboNUserName.DisplayMember = "USER_ID"
            adptr.Dispose()
            txtNUserID.Text = dt.Rows(0)("USER_ID").ToString
            cboNUserName.Text = " "
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnShowPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPassword.Click
        If txtConfirmPassword.Text = " " Or txtNpassword.Text = "" Then
            MsgBox("empty password")
        Else
            Dim p As String = txtNpassword.Text
            Dim cp As String = txtConfirmPassword.Text
            txtNpassword.PasswordChar = ""
            txtNpassword.Text = p
            txtConfirmPassword.PasswordChar = ""
            txtConfirmPassword.Text = cp
        End If
    End Sub
    Private Sub btnShowPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowPassword.LostFocus
        txtConfirmPassword.PasswordChar = "*"
        txtNpassword.PasswordChar = "*"
    End Sub
    Dim uname As String
    Dim UPASS As String
    Dim count As Integer
    Dim Querycomplete As String
    Dim getQid As Integer = 0
    Private Sub btnAutheticateAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAutheticateAdmin.Click
        cboNUserName.Text = ""
        txtNUserID.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser where USER_TYPE='ADMIN'"
            '  query = "select * from LoginUser where USER_TYPE='ADMIN' and USER_NAME=? and PASSWORD=?"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            count = 0
            While reader.Read
                uname = reader("USER_NAME").ToString
                UPASS = reader("uPASSWORD").ToString
                If uname = txtAdminUser.Text And UPASS = txtAdminPass.Text Then
                    MsgBox("authentication is done")
                    grpUserInfo.Enabled = True
                Else
                    grpUserInfo.Enabled = False
                    '   MsgBox("Admin authetication failed")
                    'count = count + 1
                End If
            End While
            If count >= 3 Then
                MsgBox("not login attempt remaining,application is going to shut down")
                Me.Close()
            End If
            'MsgBox(uname)
            ' MsgBox(UPASS)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        txtNpassword.PasswordChar = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        If txtConfirmPassword.Text <> txtNpassword.Text Then
            MsgBox("Pleaste password doesn't match please chexk again")
            txtNpassword.Focus()
            txtConfirmPassword.Text = ""
        Else
            Try
                con.Open()
                query = "insert into LoginUser (USER_ID,USER_TYPE,USER_NAME,uPASSWORD,uEMAIL_ID) values (?,?,?,?,?)"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", txtNUserID.Text)
                cmd.Parameters.AddWithValue("?", cboAdduserType.Text)
                cmd.Parameters.AddWithValue("?", txtNuserName.Text)
                cmd.Parameters.AddWithValue("?", txtNpassword.Text)
                cmd.Parameters.AddWithValue("?", txtEmailId.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("VALUE SAVED")
            Catch ex As Exception
                ' MsgBox(ex.Message)
                MsgBox("The ID alredy exist please insert another Room ID")
                txtNUserID.Text = ""
                txtNUserID.Focus()
            Finally
                con.Close()
                'clear()
            End Try
            txtNpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub cboNUserID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNUserName.SelectedIndexChanged

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser where USER_NAME like ?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", cboNUserName.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                cboAdduserType.Text = reader("USER_TYPE").ToString
                txtEmailId.Text = reader("uEMAIL_ID").ToString
                txtNpassword.Text = reader("uPASSWORD").ToString
                txtNUserID.Text = reader("USER_ID").ToString
                txtNuserName.Text = reader("USER_NAME").ToString
            End While
            txtNpassword.PasswordChar = "*"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub clear()
        txtNpassword.Text = ""
        txtNUserID.Text = ""
        txtNuserName.Text = ""
        txtEmailId.Text = ""
        cboNId.Text = ""
        cboAdduserType.Text = ""
        cboNUserName.Text = ""
        txtConfirmPassword.Text = ""
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If txtConfirmPassword.Text <> txtNpassword.Text Then
            MsgBox("Password doesn't match please check again")
            txtNpassword.Focus()
            txtConfirmPassword.Text = ""
        Else
            Try
                con.Open()
                query = "update LoginUser set USER_NAME = ? , uEMAIL_ID = ? , uPASSWORD = ?, USER_TYPE =? where USER_ID = ?"
                Dim CMD As New OleDbCommand(query, con)
                CMD.Parameters.AddWithValue("?", txtNuserName.Text)
                CMD.Parameters.AddWithValue("?", txtEmailId.Text)
                CMD.Parameters.AddWithValue("?", txtNpassword.Text)
                CMD.Parameters.AddWithValue("?", cboAdduserType.Text)
                CMD.Parameters.AddWithValue("?", Val(cboNId.Text))
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox(cboNUserName.Text + "  records updated")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                clear()
            End Try
        End If
    End Sub

    Private Sub cboAdduserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdduserType.SelectedIndexChanged
        cboNId.Visible = True
        cboNUserName.Visible = True
        Dim con As New OleDbConnection
        con = connectTOhms()
        If cboAdduserType.SelectedIndex = 0 Then
            Querycomplete = "where USER_TYPE like '" + cboAdduserType.Text + "'"
        ElseIf cboAdduserType.SelectedIndex = 1 Then
            Querycomplete = "where USER_TYPE like '" + cboAdduserType.Text + "'"
        End If
        Try
            con.Open()
            query = "select * from LoginUser " + Querycomplete
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboNUserName.DataSource = dt
            cboNUserName.DisplayMember = "USER_NAME"
            cboNId.DataSource = dt
            cboNId.DisplayMember = "USER_ID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        grpUserInfo.Enabled = False
        clear()
        txtAdminPass.Text = ""
        txtAdminUser.Text = ""
    End Sub
    Dim QueAns As String
    Dim Que As String
    Dim QueId As Integer
    Dim ReUserID As Integer

    Dim fupassword As String
    Dim funame As String
    Dim fuemail As String
    Dim fuid As String
    Dim fuContact As String
    Dim fuserType As String
    
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update LoginUser set uPASSWORD = ? where USER_ID = ?"
            Dim CMD As New OleDbCommand(query, con)
            CMD.Parameters.AddWithValue("?", "")
            CMD.Parameters.AddWithValue("?", ReUserID)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox(txtVerifyUser.Text + "  Password Changed")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            clear()
        End Try
        GroupBox1.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '''''''''''''''''''''''''''''''''''''' mail to user email ''''''''''''''''''''''''''''''''''
        Try
            Dim smtpserver As New SmtpClient
            Dim email As New MailMessage
            smtpserver.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox3.Text)
            smtpserver.Port = 587
            smtpserver.EnableSsl = True
            smtpserver.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress("dcbca2@gmail.com", "Admin Disha Hostel Raipur")
            email.To.Add(TextBox2.Text)
            email.Subject = RichTextBox1.Text
            email.Body = TextBox4.Text
            smtpserver.Send(email)
            MessageBox.Show("Email Sent to :" + TextBox2.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        TextBox3.Text = ""
        TextBox3.PasswordChar = "*"
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.PasswordChar = ""
            TextBox3.Text = "password here"
        Else
            TextBox3.Text = TextBox3.Text
        End If
    End Sub

    Private Sub txtVerifyUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) < 47 Then
        '    'MsgBox("enter alphabet only")
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) < 58 Then
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
        '    e.Handled = False
        'End If
    End Sub


    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If Asc(e.KeyChar) < 47 Then
            'MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAdminUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdminUser.KeyPress
        If Asc(e.KeyChar) < 47 Then
            'MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtNUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNUserID.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboNId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboNId.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select max(USER_ID) from LoginUser"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtNUserID.Text = reader(0) + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        cboNId.Visible = False
        cboNUserName.Visible = False
        txtNpassword.Text = ""
        ' txtNUserID.Text = ""
        txtNuserName.Text = ""
        txtusername.Text = ""
        cboNUserName.Text = ""
        txtConfirmPassword.Text = ""
        cboNId.Text = ""
        txtEmailId.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Show()
        grpVerification.Hide()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If qid1.Checked = True Then
            getQid = 1
        ElseIf qid2.Checked = True Then
            getQid = 2
        ElseIf qid3.Checked = True Then
            getQid = 3
        ElseIf qid4.Checked = True Then
            getQid = 4
        ElseIf qid5.Checked = True Then
            getQid = 5
        Else
            getQid = 0
        End If

        If txtVerifyUser.Text = "" Or txtVerifyAns.Text = "" Then
            MsgBox("please re-enter user name and your Response")
            txtVerifyUser.Focus()
        ElseIf txtVerifyUser.Text <> "" Then
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For Each rdo In grpVerification.Controls.OfType(Of RadioButton)()
                If rdo.Checked = False Then
                    ' MsgBox("please select your question ,that you choose for verification last time")
                ElseIf rdo.Checked = True Then
                    Try
                        con.Open()
                        query = "SELECT lu.USER_ID, lu.USER_TYPE, lu.USER_NAME, lu.uEMAIL_ID, lu.question_id,lq.question, lu.question_ans FROM LoginQuestion lq INNER JOIN LoginUser lu ON lq.question_id =lu.question_id where lu.USER_NAME like '" + txtVerifyUser.Text + "'"
                        Dim cmd As New OleDbCommand(query, con)
                        'cmd.Parameters.AddWithValue("?", getQid)
                        Dim reader As OleDbDataReader = cmd.ExecuteReader
                        While reader.Read
                            ReUserID = reader(0)
                            QueId = reader(4)
                            Que = reader(5).ToString
                            QueAns = reader(6).ToString
                        End While
                        cmd.Dispose()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        con.Close()
                    End Try
                    '-------------------------------------------------------------------------------------------

                    If QueAns = txtVerifyAns.Text And QueId = getQid Then
                        MsgBox("User Verified")

                        Dim getEmail As String                      '''''''''''''''''''''' get reciever email address
                        getEmail = InputBox("enter your Email address:", "Email")

                        Dim ipass As String = getRandom()       ''''''''''''''''''''''''''' get randomly password '''''''''''''''''''''''''''''
                        '    MsgBox(ipass)

                        '''''''''''''''''''''''''''''''''''''''' update password of user ''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Try
                            con.Open()
                            query = "update LoginUser set uPassword=? where USER_NAME=? or uEMAIL_ID =?"
                            Dim CMD As New OleDbCommand(query, con)
                            CMD.Parameters.AddWithValue("?", ipass)
                            CMD.Parameters.AddWithValue("?", txtVerifyUser.Text)
                            CMD.Parameters.AddWithValue("?", txtVerifyUser.Text)
                            CMD.ExecuteNonQuery()
                            MsgBox("your password has been Resetted,please check your mail")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            con.Close()
                        End Try

                        '''''''''''''''''''''''''''''' ''''''''''''''''''''' '''''''''''''''''''''''''''''''''''''''''''''''''''''
                        Try
                            con.Open()
                            query = "select * from LoginUser where USER_NAME like ? or uEMAIL_ID like ?"
                            Dim cmd As New OleDbCommand(query, con)
                            cmd.Parameters.AddWithValue("?", txtVerifyUser.Text)
                            cmd.Parameters.AddWithValue("?", txtVerifyUser.Text)
                            Dim reader As OleDbDataReader = cmd.ExecuteReader
                            While reader.Read
                                fuemail = reader(4).ToString
                                fuContact = reader(5).ToString
                                fuid = reader(0).ToString
                                funame = reader(2).ToString
                                fuserType = reader(1).ToString
                                fupassword = reader(3).ToString
                            End While
                            cmd.Dispose()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            con.Close()
                        End Try
                        '  MsgBox(fupassword)
                        ' MsgBox(getEmail)
                        '''''''''''''''''''''''''''''''''''''' mail to user email ''''''''''''''''''''''''''''''''''
                        Try
                            Dim smtpserver As New SmtpClient
                            Dim email As New MailMessage
                            smtpserver.Credentials = New Net.NetworkCredential("dcbca2@gmail.com", "finalnew")
                            smtpserver.Port = 587
                            smtpserver.EnableSsl = True
                            smtpserver.Host = "smtp.gmail.com"
                            email = New MailMessage
                            email.From = New MailAddress("dcbca2@gmail.com", "Admin Disha Hostel Raipur")
                            email.To.Add(Trim(getEmail))
                            email.Subject = "Login Password info"
                            email.Body = "Dear User your password has been changed" + "your password is : " + fupassword
                            smtpserver.Send(email)
                            MessageBox.Show("Email Sent to :" + getEmail)
                            grpVerification.Visible = False
                            GroupBox1.Visible = True
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally

                        End Try
                    ElseIf QueAns <> txtVerifyAns.Text Or QueId <> getQid Then
                        MsgBox("Enterd Answer doesn't match, or you have selected wrong Question ..please contact Admin to for Password")
                    End If

                End If
            Next

        End If
        '  MsgBox(QueAns)

    End Sub
End Class
