Imports System.Data.OleDb
Imports System.Data
Imports System.Net.Mail
Public Class ChangePassword
    Dim query As String
    Dim count As Integer
    Dim uname As String
    Dim UPASS As String
    Private Sub btnAutheticateAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
 
    Dim Querycomplete As String
    Private Sub cboAdduserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub cboNUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub cboNId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnShowPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtConfirmPassword.PasswordChar = "*"
        txtNpassword.PasswordChar = "*"
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If CurrUserOldPass.Text = " " Or CurrUserPassConfirm.Text = "" Then
            MsgBox("empty password")
        Else
            Dim p1 As String = CurrUserPassConfirm.Text
            Dim cp1 As String = CurrUserOldPass.Text
            Dim cunewP As String = txtCurrentUNewPass.Text
            CurrUserOldPass.PasswordChar = ""
            CurrUserOldPass.Text = cp1
            CurrUserPassConfirm.PasswordChar = ""
            CurrUserPassConfirm.Text = p1
            txtCurrentUNewPass.PasswordChar = ""
            txtCurrentUNewPass.Text = cunewP
        End If
    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        txtCurrentUsername.Text = Hostel_Management_System.StatusStrip1.Items(1).Text
        MetroCboQue.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser" ' where USER_NAME like '" + cboSelectUser.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboSelectUser.DataSource = dt
            cboSelectUser.DisplayMember = "USER_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '--''''''''''''''''''''''''''''''''''''''' Load Security Question ''''''''''''''''''''''''''''''''''''
        Try
            con.Open()
            query = "select * from LoginQuestion"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            MetroCboQueID.DataSource = dt
            MetroCboQueID.DisplayMember = "question_id"
            MetroCboQue.DataSource = dt
            MetroCboQue.DisplayMember = "question"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Dim CurrentUserOLDPass As String
    Dim CurrentUserName As String
    Dim CurrentUserType As String
    Dim CurrentUserEmail As String
    Dim CurrentUserID As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If CurrUserPassConfirm.Text = txtCurrentUNewPass.Text Then
            Try
                con.Open()
                query = "select * from LoginUser where USER_NAME='" + txtCurrentUsername.Text + "'"
                Dim CMD As New OleDbCommand(query, con)
                Dim READER As OleDbDataReader = CMD.ExecuteReader
                While READER.Read
                    CurrentUserID = READER(0)
                    CurrentUserType = READER(1).ToString
                    CurrentUserName = READER(2).ToString
                    CurrentUserOLDPass = READER(3).ToString
                    CurrentUserEmail = READER(4).ToString
                End While
                '  MsgBox(READER(0))
                CMD.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            If CurrUserOldPass.Text <> CurrentUserOLDPass Then
                MsgBox("you enterd a Incorrect OLD Password")
            ElseIf CurrentUserOLDPass = CurrUserOldPass.Text Then
                Try
                    con.Open()
                    query = "update LoginUser set uPASSWORD=? ,uEMAIL_ID=?,question_id=?,question_ans=? where USER_NAME like '" + txtCurrentUsername.Text + "' and USER_ID LIKE ?"
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", txtCurrentUNewPass.Text)
                    cmd.Parameters.AddWithValue("?", currUserEmail.Text)
                    cmd.Parameters.AddWithValue("?", MetroCboQueID.Text)
                    cmd.Parameters.AddWithValue("?", txtQueAns.Text)
                    cmd.Parameters.AddWithValue("?", CurrentUserID)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("User Name : " + txtCurrentUsername.Text + " of type : " + CurrentUserType + " password has been  sucessfully updated ")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        Else
            MsgBox("please does not matched ,please recheck password ")
        End If
    End Sub

    Private Sub Button3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.LostFocus
        CurrUserOldPass.PasswordChar = "*"
        CurrUserPassConfirm.PasswordChar = "*"
        txtCurrentUNewPass.PasswordChar = "*"
    End Sub

    Private Sub cboSelectUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelectUser.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser where USER_NAME like '" + cboSelectUser.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtReceiverEmail.Text = reader(4).ToString
                lblSelectUserContact.Text = reader(5).ToString
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSendMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMail.Click
        Try
            Dim smtpserver As New SmtpClient
            Dim email As New MailMessage
            smtpserver.Credentials = New Net.NetworkCredential(txtSenderEmaiL.Text, txtSenderEmailpass.Text) ''''email id of sender and his password
            smtpserver.Port = 587
            smtpserver.EnableSsl = True
            smtpserver.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress(txtSenderEmaiL.Text, "Admin :Preet Sahu")
            email.To.Add(txtReceiverEmail.Text)
            email.Subject = "hi"
            email.Body = RichTxtSubject.Text
            smtpserver.Send(email)
            MessageBox.Show("Email Sent")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub MetroCboQueID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroCboQueID.SelectedIndexChanged
       
    End Sub

    Private Sub MetroCboQue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroCboQue.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from LoginUser where question_id=? and USER_NAME=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", MetroCboQueID.Text)
            cmd.Parameters.AddWithValue("?", txtCurrentUsername.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtQueAns.Text = reader(7).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class