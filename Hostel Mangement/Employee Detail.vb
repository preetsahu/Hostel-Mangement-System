Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Employee
    Dim query As String
    Dim RowCount As Integer
    Private Sub Employee_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select max(EMPLOYEE_ID) from EmployeeDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            RowCount = dt.Rows.Count - 1
            'MsgBox(dt.Rows.Count)
            cboEID.Text = dt.Rows(RowCount).Item(0).ToString + 1
            'dtGridViewStudentDetail.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            Dim myfile As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim myFilereader As New BinaryReader(myfile)
            Dim mybyteImage(myfile.Length) As Byte
            myFilereader.Read(mybyteImage, 0, myfile.Length)
            myFilereader.Close()
            myfile.Close()
            con.Open()
            query = "insert into EmployeeDetails (EMPLOYEE_ID,EMPLOYEE_NAME,PHOTO,EMPLOYEE_CONTACT,JOINING_DATE,FATHERS_NAME,HOME_CONTACT,PERMANENT_ADDRESS,LOCAL_ADDRESS,WORK_AS,WORK_SHIFT,SALARY,BANK_AC_NO,IFSC_CODE,ID_PROOF,ID_DETAILS,ALLOTED_LEAVE) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@eid", cboEID.Text)
            cmd.Parameters.AddWithValue("@ename", txtEname.Text)
            cmd.Parameters.AddWithValue("@photo", mybyteImage)
            cmd.Parameters.AddWithValue("@eContact", txtEcontact.Text)
            cmd.Parameters.AddWithValue("@joinDate", DTpickerJOIN.Text)
            cmd.Parameters.AddWithValue("@Father'sName", txtFname.Text)
            cmd.Parameters.AddWithValue("@HOMEcontact", txtHcontact.Text)
            cmd.Parameters.AddWithValue("@PerAddress", txtPaddress.Text)
            cmd.Parameters.AddWithValue("@LocAddress", txtLaddress.Text)
            cmd.Parameters.AddWithValue("@Work_As", cboWorkAs.Text)
            cmd.Parameters.AddWithValue("@work_shift", txtWorkShift.Text)
            cmd.Parameters.AddWithValue("@salary", txtSalary.Text)
            cmd.Parameters.AddWithValue("@bank_a/c", txtACno.Text)
            cmd.Parameters.AddWithValue("@IFSC", txtIFSCcode.Text)
            cmd.Parameters.AddWithValue("@idproof", cboIDProof.Text)
            cmd.Parameters.AddWithValue("@idDetails", txtEnterIDdetail.Text)
            cmd.Parameters.AddWithValue("@AllotedLeave", txtAllotedLeave.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Employee Record Saved", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteEmployeeDetails.Show()
        DeleteEmployeeDetails.MdiParent = Me
        DeleteEmployeeDetails.Dock = DockStyle.Fill
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cboEID.Text = ""
        cboIDProof.Text = ""
        txtACno.Text = ""
        txtEcontact.Text = ""
        txtEname.Text = ""
        txtEnterIDdetail.Text = ""
        txtFname.Text = ""
        txtIFSCcode.Text = ""
        txtHcontact.Text = ""
        txtLaddress.Text = ""
        txtPaddress.Text = ""
        txtSalary.Text = ""
        cboWorkAs.Text = ""
        txtWorkShift.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        EmployeeDetailsView.Show()
        EmployeeDetailsView.MdiParent = Hostel_Management_System
        Me.Close()
        EmployeeDetailsView.Dock = DockStyle.Fill
    End Sub

    Private Sub txtEcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEcontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtHcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHcontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtSalary_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalary.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtEname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEname.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtACno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtACno.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtFname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFname.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtWorkAs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtWorkShift_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkShift.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboEID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEID.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboIDProof_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboIDProof.KeyPress

    End Sub

    Private Sub cboWorkAs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboWorkAs.KeyPress
        If Asc(e.KeyChar) < 47 Then
            ' MsgBox("enter alphabet only")
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAllotedLeave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllotedLeave.KeyPress

    End Sub
End Class