Imports System.Data.OleDb
Imports System.IO
Public Class EmployeeDetailsView
    Dim query As String
    Dim rowcount As Integer
    Dim querycomplete As String
    Private Sub dtgridviewRefresh()           'function to call datgrid updation
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridEmployeeeDetails.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''' grid format ;;'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub gridFormat()
        dtGridEmployeeeDetails.GridColor = Color.Aqua
        dtGridEmployeeeDetails.BackgroundColor = Color.LightGray
        dtGridEmployeeeDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        dtGridEmployeeeDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        dtGridEmployeeeDetails.DefaultCellStyle.SelectionBackColor = Color.Cyan
        dtGridEmployeeeDetails.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        dtGridEmployeeeDetails.RowsDefaultCellStyle.BackColor = Color.Bisque
        dtGridEmployeeeDetails.AllowUserToResizeRows = False
        dtGridEmployeeeDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    Private Sub EmployeeDetailsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If loginAuthetication = 1 Then
        '    Me.Show()
        '    LoginForm.Hide()
        'ElseIf loginAuthetication = 0 Then
        '    LoginForm.Show()
        '    Me.Hide()
        'End If

        dtgridviewRefresh()
        gridFormat()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        If txtEcontact.TextLength <> 10 Then
            MsgBox("enter your correct mobile number", MsgBoxStyle.Information)
        ElseIf txtHcontact.TextLength <> 10 Then
            MsgBox("enter father's correct mobile number", MsgBoxStyle.Information)
        Else
            Try
                con.Open()
                '      If PictureBox1.Image Is Nothing Then
                If OpenFileDialog1.FileName.Contains("OpenFileDialog1") Then
                    MsgBox("already have image")
                    query = "update EmployeeDetails set EMPLOYEE_NAME = ? , EMPLOYEE_CONTACT = ? , JOINING_DATE = ? , FATHERS_NAME = ? , HOME_CONTACT = ? , PERMANENT_ADDRESS = ? , LOCAL_ADDRESS = ? , WORK_AS = ? , WORK_SHIFT = ? , SALARY = ? , BANK_AC_NO = ? , IFSC_CODE = ? , ID_PROOF = ? , ID_DETAILS = ? , ALLOTED_LEAVE = ? where EMPLOYEE_ID = ? "
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@ename", txtEname.Text)
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
                    cmd.Parameters.AddWithValue("@EmployeeID", Val(cboEID.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Employee record successful updated")
                    dtgridviewRefresh()
                Else
                    MsgBox("upload image")
                    Dim myfile As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                    Dim myFilereader As New BinaryReader(myfile)
                    Dim mybyteImage(myfile.Length) As Byte
                    myFilereader.Read(mybyteImage, 0, myfile.Length)
                    myFilereader.Close()
                    myfile.Close()
                    query = "update EmployeeDetails set EMPLOYEE_NAME = ? , PHOTO = ? , EMPLOYEE_CONTACT = ? , JOINING_DATE = ? , FATHERS_NAME = ? , HOME_CONTACT = ? , PERMANENT_ADDRESS = ? , LOCAL_ADDRESS = ? , WORK_AS = ? , WORK_SHIFT = ? , SALARY = ? , BANK_AC_NO = ? , IFSC_CODE = ? , ID_PROOF = ? , ID_DETAILS = ? , ALLOTED_LEAVE = ? where EMPLOYEE_ID = ? "
                    Dim cmd As New OleDbCommand(query, con)
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
                    cmd.Parameters.AddWithValue("@EmployeeID", Val(cboEID.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Employee record successful updated")
                    dtgridviewRefresh()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
        dtgridviewRefresh()
    End Sub
    Public Sub SubroutienCellClick()
        Try
            'If dtGridEmployeeeDetails.RowCount >= 0 Then
            '    Dim myimagebyte() As Byte
            '    myimagebyte = dtGridEmployeeeDetails.Item(2, dtGridEmployeeeDetails.CurrentRow.Index).Value
            '    'If IsDBNull(myimagebyte) Then
            '    '    PictureBox1.Image = Image.FromFile("C:\Hostel Mangement 13-FEB-17\Hostel Mangement\nv.jpg")
            '    'Else
            '    Dim memStream As New MemoryStream(myimagebyte)
            '    PictureBox1.Image = Image.FromStream(memStream)            'load picture for memory stream
            'End If
            '' End If
            Dim row As DataGridViewRow = dtGridEmployeeeDetails.CurrentRow
            cboEID.Text = row.Cells(0).Value.ToString
            txtEname.Text = row.Cells(1).Value.ToString
            txtEcontact.Text = row.Cells(3).Value.ToString
            DTpickerJOIN.Text = row.Cells(4).Value.ToString
            txtFname.Text = row.Cells(5).Value.ToString
            txtHcontact.Text = row.Cells(6).Value.ToString
            txtPaddress.Text = row.Cells(7).Value.ToString
            txtLaddress.Text = row.Cells(8).Value.ToString
            cboWorkAs.Text = row.Cells(9).Value.ToString
            txtWorkShift.Text = row.Cells(10).Value.ToString
            txtSalary.Text = row.Cells(11).Value.ToString
            txtACno.Text = row.Cells(12).Value.ToString
            txtIFSCcode.Text = row.Cells(13).Value.ToString
            cboIDProof.Text = row.Cells(14).Value.ToString
            txtEnterIDdetail.Text = row.Cells(15).Value.ToString
            txtAllotedLeave.Text = row.Cells(16).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub dtGridEmployeeeDetails_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridEmployeeeDetails.CellClick
        PictureBox1.Image = Nothing
        Try
            If dtGridEmployeeeDetails.RowCount >= 0 Then
                Dim myimagebyte() As Byte = dtGridEmployeeeDetails.Item(2, dtGridEmployeeeDetails.CurrentRow.Index).Value
                If IsDBNull(myimagebyte) Then
                    PictureBox1.Image = Image.FromFile("C:\Hostel Mangement 13-FEB-17\Hostel Mangement\nv.jpg") ' Nothing
                Else
                    Dim memStream As New MemoryStream(myimagebyte)
                    PictureBox1.Image = Image.FromStream(memStream)            'load picture for memory stream
                End If
            End If
            Dim i As Integer
            With dtGridEmployeeeDetails
                If e.RowIndex >= 0 Then
                    i = .CurrentRow.Index
                    cboEID.Text = .Rows(i).Cells(0).Value.ToString
                    txtEname.Text = .Rows(i).Cells(1).Value.ToString
                    txtEcontact.Text = .Rows(i).Cells(3).Value.ToString
                    DTpickerJOIN.Text = .Rows(i).Cells(4).Value.ToString
                    txtFname.Text = .Rows(i).Cells(5).Value.ToString
                    txtHcontact.Text = .Rows(i).Cells(6).Value.ToString
                    txtPaddress.Text = .Rows(i).Cells(7).Value.ToString
                    txtLaddress.Text = .Rows(i).Cells(8).Value.ToString
                    cboWorkAs.Text = .Rows(i).Cells(9).Value.ToString
                    txtWorkShift.Text = .Rows(i).Cells(10).Value.ToString
                    txtSalary.Text = .Rows(i).Cells(11).Value.ToString
                    txtACno.Text = .Rows(i).Cells(12).Value.ToString
                    txtIFSCcode.Text = .Rows(i).Cells(13).Value.ToString
                    cboIDProof.Text = .Rows(i).Cells(14).Value.ToString
                    txtEnterIDdetail.Text = .Rows(i).Cells(15).Value.ToString
                End If
            End With
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClickView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickView.Click
        If cboSearchBy.SelectedIndex = 1 Then
            Label2.Text = "Select Employee ID"
            querycomplete = " where EMPLOYEE_ID like '" + Trim(cboSelected.Text) + "';"
        ElseIf cboSearchBy.SelectedIndex = 0 Then
            Label2.Text = "Select Employee Name"
            querycomplete = " where EMPLOYEE_NAME like '" + Trim(cboSelected.Text) + "';"
        ElseIf cboSearchBy.SelectedIndex = 2 Then
            Label2.Text = "Select Employee Work description"
            Dim j As Integer = Val(cboSelected.Text)
            querycomplete = "where WORK_AS like '" + Trim(cboSelected.Text) + "';"
        ElseIf cboSearchBy.SelectedIndex = 3 Then
            querycomplete = ""
        End If

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails " + querycomplete
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridEmployeeeDetails.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        SubroutienCellClick()
    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from EmployeeDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            If cboSearchBy.SelectedIndex = 0 Then
                cboSelected.DataSource = dt
                cboSelected.DisplayMember = "EMPLOYEE_NAME"
            ElseIf cboSearchBy.SelectedIndex = 1 Then
                cboSelected.DataSource = dt
                cboSelected.DisplayMember = "EMPLOYEE_ID"
            ElseIf cboSearchBy.SelectedIndex = 2 Then
                Try
                    If Not con.State = ConnectionState.Open Then
                        con.Open()
                    End If
                    query = "select distinct[WORK_AS] from EmployeeDetails"
                    Dim adptr1 As New OleDbDataAdapter(query, con)
                    Dim dt1 As New DataTable
                    adptr1.Fill(dt1)
                    cboSelected.DataSource = dt1
                    cboSelected.DisplayMember = "WORK_AS"
                    adptr1.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                
            ElseIf cboSearchBy.SelectedIndex = 3 Then
                dtGridEmployeeeDetails.DataSource = dt
                dtGridEmployeeeDetails.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
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
        txtAllotedLeave.Text = ""
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        Employee.Show()
        Employee.MdiParent = Hostel_Management_System
        Employee.Dock = DockStyle.Fill
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim response As String
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            response = MsgBox("Are you want to delete the current Student Detail", vbYesNoCancel)
            If response = vbYes Then
                query = "delete from EmployeeDetails where EMPLOYEE_ID=?"
                Dim CMD As New OleDbCommand(query, CON)
                CMD.Parameters.AddWithValue("?", cboEID.Text)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MessageBox.Show("Current id has been deleted")
            ElseIf response = vbNo Then
                DeleteEmployeeDetails.Show()
            ElseIf response = vbCancel Then
                response = vbBack
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CON.Close()
        End Try
        dtgridviewRefresh()
    End Sub

    Private Sub txtACno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtACno.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtAllotedLeave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllotedLeave.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtEcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEcontact.KeyPress
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

    Private Sub cboEID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEID.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub
    Private Sub dtGridEmployeeeDetails_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridEmployeeeDetails.CellEnter
        Dim currRoW As DataGridViewRow = dtGridEmployeeeDetails.CurrentRow
        cboEID.Text = currRoW.Cells(0).Value.ToString
        txtEname.Text = currRoW.Cells(1).Value.ToString
        txtEcontact.Text = currRoW.Cells(3).Value
        DTpickerJOIN.Text = currRoW.Cells(4).Value.ToString
        txtFname.Text = currRoW.Cells(5).Value.ToString
        txtHcontact.Text = currRoW.Cells(6).Value.ToString
        txtPaddress.Text = currRoW.Cells(7).Value.ToString
        txtLaddress.Text = currRoW.Cells(8).Value.ToString
        cboWorkAs.Text = currRoW.Cells(9).Value.ToString
        txtWorkShift.Text = currRoW.Cells(10).Value.ToString
        txtSalary.Text = currRoW.Cells(11).Value.ToString
        txtACno.Text = currRoW.Cells(12).Value.ToString
        txtIFSCcode.Text = currRoW.Cells(13).Value.ToString
        cboIDProof.Text = currRoW.Cells(14).Value.ToString
        txtAllotedLeave.Text = currRoW.Cells(15).Value.ToString
    End Sub

    Private Sub dtGridEmployeeeDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridEmployeeeDetails.CellContentClick

    End Sub
End Class