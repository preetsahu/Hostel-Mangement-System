Imports System.Data.OleDb
Imports System.IO
Public Class ViewStudentDetails
    Dim query As String
    Dim ds As New DataSet
    Dim querycomplete As String
    Dim cmd As OleDbCommand

    '''''''''''''''''''''''''''''''''''''''''''''''' cell click '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub SubroutineCellClick()
        Try
            If dtGridViewStudentDetail.RowCount >= 0 Then
                Dim myimagebyte() As Byte = dtGridViewStudentDetail.Item(4, dtGridViewStudentDetail.CurrentRow.Index).Value
                Dim memStream As New MemoryStream(myimagebyte)
                PictureBox1.Image = Image.FromStream(memStream)            'load picture for memory stream
            End If

            Dim row As DataGridViewRow = dtGridViewStudentDetail.CurrentRow
            txtstudentid.Text = row.Cells("S_ID").Value.ToString
            txtstudentname.Text = row.Cells("NAME").Value.ToString
            dtPickerDOB.Value = row.Cells("DOB").Value
            txtstudentcontact.Text = row.Cells("CONTACT").Value.ToString
            cboclass.Text = row.Cells("CLASS").Value.ToString
            cboyear.Text = row.Cells("COURSE_YEAR").Value.ToString
            txtRoomID.Text = row.Cells("ROOM_ID").Value.ToString
            txtbedid.Text = row.Cells("BED_ID").Value.ToString
            txtbusid.Text = row.Cells("BUS_ID").Value.ToString
            txtrouteid.Text = row.Cells("ROUTE_ID").Value.ToString
            txtfathername.Text = row.Cells("FATHERS_NAME").Value.ToString
            txtfathercontact.Text = row.Cells("FATHERS_CONTACT").Value.ToString
            txtmothername.Text = row.Cells("MOTHERS_NAME").Value.ToString
            txtmothercontact.Text = row.Cells("MOTHERS_CONTACT").Value.ToString
            richTxtpermanentaddress.Text = row.Cells("PERMANENT_ADDRESS").Value.ToString
            txtlocalguardian.Text = row.Cells("LOCAL_GAURDIAN").Value.ToString
            txtlocalguardiancontact.Text = row.Cells("LOCAL_GAURDIAN_CONTACT").Value.ToString
            richTxtLocalAddress.Text = row.Cells("LOCAL_GAURDIAN_ADDRESS").Value.ToString
            DateTimePicker1.Text = row.Cells("Depatcher_Date").Value.ToString
            DtcurrentDate.Text = row.Cells("REGISTRATION_DATE").Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ' MessageBox.Show("Photograph not available")
        End Try
    End Sub
    ''''''''''''''''''''''''''''''''''''' update datagrid updation ''''''''''''''''''''''''''''''''''''''''
    Private Sub dtgridviewRefresh()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT * FROM RoomAllotment WHERE BED_ID <> '' AND ROOM_ID <> '' ;"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridViewStudentDetail.DataSource = dt
            dtGridViewStudentDetail.Sort(dtGridViewStudentDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''' grid format ;;'''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub gridFormat()
        dtGridViewStudentDetail.GridColor = Color.Aqua
        dtGridViewStudentDetail.BackgroundColor = Color.LightGray
        dtGridViewStudentDetail.CellBorderStyle = DataGridViewCellBorderStyle.None
        dtGridViewStudentDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect         'formatting datagrid
        dtGridViewStudentDetail.DefaultCellStyle.SelectionBackColor = Color.Cyan
        dtGridViewStudentDetail.DefaultCellStyle.SelectionForeColor = Color.DarkBlue
        dtGridViewStudentDetail.RowsDefaultCellStyle.BackColor = Color.Bisque
        dtGridViewStudentDetail.AllowUserToResizeRows = False
        dtGridViewStudentDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub
    ' --------------------------------------------------- load -----------------------------------------------------
    Private Sub ViewStudentDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        cboSelected.Text = ""
        dtgridviewRefresh()
        gridFormat()
        DateTimePicker1.Visible = True
        '''''''''''''''''''''''''''''''''''''''' LOADING COMBO DISTICT VALUSE '''''''''''''''''''''''''''''''''''''
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails "
            Dim adptr As New OleDbDataAdapter(query, CON)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboclass.DataSource = dt
            cboclass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try

 
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''' cell enter '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cellenter()
        Dim currRoW As DataGridViewRow = dtGridViewStudentDetail.CurrentRow
        txtstudentid.Text = currRoW.Cells("S_ID").Value.ToString
        txtstudentname.Text = currRoW.Cells("NAME").Value.ToString
        dtPickerDOB.Value = currRoW.Cells("DOB").Value
        txtstudentcontact.Text = currRoW.Cells("CONTACT").Value.ToString
        cboclass.Text = currRoW.Cells("CLASS").Value.ToString
        cboyear.Text = currRoW.Cells("COURSE_YEAR").Value.ToString
        txtRoomID.Text = currRoW.Cells("ROOM_ID").Value.ToString
        txtbedid.Text = currRoW.Cells("BED_ID").Value.ToString
        txtbusid.Text = currRoW.Cells("BUS_ID").Value.ToString
        txtrouteid.Text = currRoW.Cells("ROUTE_ID").Value.ToString
        txtfathername.Text = currRoW.Cells("FATHERS_NAME").Value.ToString
        txtfathercontact.Text = currRoW.Cells("FATHERS_CONTACT").Value.ToString
        txtmothername.Text = currRoW.Cells("MOTHERS_NAME").Value.ToString
        txtmothercontact.Text = currRoW.Cells("MOTHERS_CONTACT").Value.ToString
        richTxtpermanentaddress.Text = currRoW.Cells("PERMANENT_ADDRESS").Value.ToString
        txtlocalguardian.Text = currRoW.Cells("LOCAL_GAURDIAN").Value.ToString
        txtlocalguardiancontact.Text = currRoW.Cells("LOCAL_GAURDIAN_CONTACT").Value.ToString
        richTxtLocalAddress.Text = currRoW.Cells("LOCAL_GAURDIAN_ADDRESS").Value.ToString
    End Sub

    ' ------------------------------------------------- cell click ---------------------------------------------------------------
    Private Sub dtGridViewStudentDetail_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridViewStudentDetail.CellClick, dtGridViewStudentDetail.CellClick
        PictureBox1.Image = Nothing
        Try
            If dtGridViewStudentDetail.RowCount >= 0 Then
                Dim myimagebyte() As Byte = dtGridViewStudentDetail.Item(4, dtGridViewStudentDetail.CurrentRow.Index).Value
                If IsDBNull(myimagebyte) Then
                    PictureBox1.Image = Image.FromFile("C:\Hostel Mangement 13-FEB-17\Hostel Mangement\nv.jpg")
                Else
                    Dim memStream As New MemoryStream(myimagebyte)
                    PictureBox1.Image = Image.FromStream(memStream) 'load picture for memory stream
                End If
            End If
            Dim i As Integer
            With dtGridViewStudentDetail
                If e.RowIndex >= 0 Then
                    i = .CurrentRow.Index
                    txtstudentid.Text = .Rows(i).Cells("S_ID").Value.ToString
                    txtstudentname.Text = .Rows(i).Cells("NAME").Value.ToString
                    dtPickerDOB.Value = .Rows(i).Cells("DOB").Value
                    txtstudentcontact.Text = .Rows(i).Cells("CONTACT").Value.ToString
                    cboclass.Text = .Rows(i).Cells("CLASS").Value.ToString
                    cboyear.Text = .Rows(i).Cells("COURSE_YEAR").Value.ToString
                    txtRoomID.Text = .Rows(i).Cells("ROOM_ID").Value.ToString
                    txtbedid.Text = .Rows(i).Cells("BED_ID").Value.ToString
                    txtbusid.Text = .Rows(i).Cells("BUS_ID").Value.ToString
                    txtrouteid.Text = .Rows(i).Cells("ROUTE_ID").Value.ToString
                    txtfathername.Text = .Rows(i).Cells("FATHERS_NAME").Value.ToString
                    txtfathercontact.Text = .Rows(i).Cells("FATHERS_CONTACT").Value.ToString
                    txtmothername.Text = .Rows(i).Cells("MOTHERS_NAME").Value.ToString
                    txtmothercontact.Text = .Rows(i).Cells("MOTHERS_CONTACT").Value.ToString
                    richTxtpermanentaddress.Text = .Rows(i).Cells("PERMANENT_ADDRESS").Value.ToString
                    txtlocalguardian.Text = .Rows(i).Cells("LOCAL_GAURDIAN").Value.ToString
                    txtlocalguardiancontact.Text = .Rows(i).Cells("LOCAL_GAURDIAN_CONTACT").Value.ToString
                    richTxtLocalAddress.Text = .Rows(i).Cells("LOCAL_GAURDIAN_ADDRESS").Value.ToString
                    DtcurrentDate.Text = .Rows(i).Cells("REGISTRATION_DATE").Value.ToString
                    DateTimePicker1.Text = .Rows(i).Cells("Depatcher_Date").Value.ToString
                End If
            End With
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
            ' MessageBox.Show("Photograph not available")
        End Try
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        If txtstudentcontact.TextLength <> 10 Then
            MsgBox("enter your correct mobile number", MsgBoxStyle.Information)
        ElseIf txtfathercontact.TextLength <> 10 Then
            MsgBox("enter father's correct mobile number", MsgBoxStyle.Information)
        ElseIf txtmothercontact.TextLength <> 10 Then
            MsgBox("enter mother's correct mobile number", MsgBoxStyle.Information)
        Else
            '      MsgBox(OpenFileDialog1.FileName + " ")
            Try
                con.Open()
                '  If PictureBox1.Image Is Nothing Then
                If OpenFileDialog1.FileName.Contains("OpenFileDialog1") Then
                    MsgBox("already have image")
                    query = "update RoomAllotment set DOB = ? , NAME = ? , CONTACT = ?  , FATHERS_NAME = ? , FATHERS_CONTACT = ? , MOTHERS_NAME = ? , MOTHERS_CONTACT = ? , PERMANENT_ADDRESS = ? , LOCAL_GAURDIAN = ? , LOCAL_GAURDIAN_CONTACT = ? , LOCAL_GAURDIAN_ADDRESS = ? , CLASS = ? , COURSE_YEAR = ? , ROOM_ID = ? , BED_ID = ? , BUS_ID = ? , ROUTE_ID = ? where S_ID=? "
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtPickerDOB.Text))
                    cmd.Parameters.AddWithValue("?", txtstudentname.Text)
                    cmd.Parameters.AddWithValue("?", txtstudentcontact.Text)
                    cmd.Parameters.AddWithValue("?", txtfathername.Text)
                    cmd.Parameters.AddWithValue("?", txtfathercontact.Text)
                    cmd.Parameters.AddWithValue("?", txtmothername.Text)
                    cmd.Parameters.AddWithValue("?", txtmothercontact.Text)
                    cmd.Parameters.AddWithValue("?", richTxtpermanentaddress.Text)
                    cmd.Parameters.AddWithValue("?", txtlocalguardian.Text)
                    cmd.Parameters.AddWithValue("?", txtlocalguardiancontact.Text)
                    cmd.Parameters.AddWithValue("?", richTxtLocalAddress.Text)
                    cmd.Parameters.AddWithValue("?", cboclass.Text)
                    cmd.Parameters.AddWithValue("?", cboyear.Text)
                    cmd.Parameters.AddWithValue("?", txtRoomID.Text)
                    cmd.Parameters.AddWithValue("?", txtbedid.Text)
                    cmd.Parameters.AddWithValue("?", txtbusid.Text)
                    cmd.Parameters.AddWithValue("?", txtrouteid.Text)
                    cmd.Parameters.AddWithValue("?", Val(txtstudentid.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Record of " + txtstudentname.Text + " is successfully updated")
                    dtgridviewRefresh()
                    clear()
                Else
                    MsgBox("upload image")
                    Dim myfile As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                    Dim myFilereader As New BinaryReader(myfile)
                    Dim mybyteImage(myfile.Length) As Byte
                    myFilereader.Read(mybyteImage, 0, myfile.Length)
                    myFilereader.Close()
                    myfile.Close()
                    query = "update RoomAllotment set DOB = ? , NAME = ? , CONTACT = ? , PHOTO = ? , FATHERS_NAME = ? , FATHERS_CONTACT = ? , MOTHERS_NAME = ? , MOTHERS_CONTACT = ? , PERMANENT_ADDRESS = ? , LOCAL_GAURDIAN = ? , LOCAL_GAURDIAN_CONTACT = ? , LOCAL_GAURDIAN_ADDRESS = ? , CLASS = ? , COURSE_YEAR = ? , ROOM_ID = ? , BED_ID = ? , BUS_ID = ? , ROUTE_ID = ? where S_ID=? "
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtPickerDOB.Text))
                    cmd.Parameters.AddWithValue("?", txtstudentname.Text)
                    cmd.Parameters.AddWithValue("?", txtstudentcontact.Text)
                    cmd.Parameters.AddWithValue("?", mybyteImage)
                    cmd.Parameters.AddWithValue("?", txtfathername.Text)
                    cmd.Parameters.AddWithValue("?", txtfathercontact.Text)
                    cmd.Parameters.AddWithValue("?", txtmothername.Text)
                    cmd.Parameters.AddWithValue("?", txtmothercontact.Text)
                    cmd.Parameters.AddWithValue("?", dtGridViewStudentDetail.Text)
                    cmd.Parameters.AddWithValue("?", txtlocalguardian.Text)
                    cmd.Parameters.AddWithValue("?", txtlocalguardiancontact.Text)
                    cmd.Parameters.AddWithValue("?", richTxtLocalAddress.Text)
                    cmd.Parameters.AddWithValue("?", cboclass.Text)
                    cmd.Parameters.AddWithValue("?", cboyear.Text)
                    cmd.Parameters.AddWithValue("?", txtRoomID.Text)
                    cmd.Parameters.AddWithValue("?", txtbedid.Text)
                    cmd.Parameters.AddWithValue("?", Val(txtbusid.Text))
                    cmd.Parameters.AddWithValue("?", Val(txtrouteid.Text))
                    cmd.Parameters.AddWithValue("?", Val(txtstudentid.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show("Record of " + txtstudentname.Text + " is successfully updated")
                    dtgridviewRefresh()
                    clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClickView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClickView.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If cboSearchBy.SelectedIndex = 0 Then
            Label2.Text = "Select Class"
            querycomplete = " where  CLASS = '" + cboSelected.Text + "' AND COURSE_YEAR='" + cboSearchYear.Text + "' and ROOM_ID <>'' and BED_ID <>'';"
        ElseIf cboSearchBy.SelectedIndex = 1 Then
            Label2.Text = "Select Student Name"
            querycomplete = " where  NAME = '" + cboSelected.Text + "' and ROOM_ID <>'' and BED_ID <>'';"
        ElseIf cboSearchBy.SelectedIndex = 2 Then
            Label2.Text = "Select Student ID"
            querycomplete = "where S_ID like '" + Trim(cboSelected.Text) + "' and ROOM_ID <>'' and BED_ID <>''"
        ElseIf cboSearchBy.SelectedIndex = 3 Then
            querycomplete = "where ROOM_ID <> '' AND BED_ID <>''"
        End If

        Try
            con.Open()
            query = "select * from RoomAllotment " + querycomplete
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridViewStudentDetail.DataSource = dt
            dtGridViewStudentDetail.Sort(dtGridViewStudentDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            adptr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
        SubroutineCellClick()
    End Sub
    Private Sub clear()
        dtGridViewStudentDetail.ClearSelection()
        txtstudentid.Text = ""
        txtstudentname.Text = ""
        txtstudentcontact.Text = ""
        PictureBox1.Image = Nothing
        txtfathername.Text = ""
        txtfathercontact.Text = ""
        dtGridViewStudentDetail.Text = ""
        txtmothername.Text = ""
        txtmothercontact.Text = ""
        txtlocalguardian.Text = ""
        txtlocalguardiancontact.Text = ""
        richTxtLocalAddress.Text = ""
        cboclass.Text = ""
        cboyear.Text = ""
        txtRoomID.Text = ""
        txtbedid.Text = ""
        txtbusid.Text = ""
        txtrouteid.Text = ""
        richTxtpermanentaddress.Text = ""
        DtcurrentDate.Text = Nothing
        dtPickerDOB.Text = Nothing
    End Sub
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        StudentDeparture.Show()
        StudentDeparture.MdiParent = Hostel_Management_System
        StudentDeparture.Dock = DockStyle.Fill
    End Sub

    Private Sub txtfathercontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfathercontact.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("enter digits only")
            e.Handled = True
        End If
    End Sub

    Private Sub txtstudentcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudentcontact.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("enter digits only")
            e.Handled = True
        End If
    End Sub

    Private Sub txtmothercontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmothercontact.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("enter digits only")
            e.Handled = True
        End If
    End Sub

    Private Sub txtlocalguardiancontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocalguardiancontact.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("enter digits only")
            e.Handled = True
        End If
    End Sub
    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        If cboSearchBy.SelectedIndex = 0 Then
            cboSearchYear.Visible = True
            Label24.Visible = False
            Try
                con.Open()
                query = "select distinct[COURSE_NAME] from CourseDetails"
                Dim adptr1 As New OleDbDataAdapter(query, con)
                Dim dt1 As New DataTable
                adptr1.Fill(dt1)
                cboSelected.DataSource = dt1
                cboSelected.DisplayMember = "COURSE_NAME"
                adptr1.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
        If cboSearchBy.SelectedIndex = 1 Or cboSearchBy.SelectedIndex = 2 Or cboSearchBy.SelectedIndex = 3 Then
            cboSearchYear.Visible = False
            Label24.Visible = False
        End If
        Try
            If cboSearchBy.SelectedIndex = 1 Then
                Try
                    con.Open()
                    query = "select DISTINCT[NAME] from RoomAllotment where ROOM_ID <> ''"
                    Dim adptr As New OleDbDataAdapter(query, con)
                    Dim dt As New DataTable
                    adptr.Fill(dt)
                    cboSelected.DataSource = dt
                    cboSelected.DisplayMember = "NAME"
                    adptr.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            ElseIf cboSearchBy.SelectedIndex = 2 Then
                Try
                    con.Open()
                    query = "select DISTINCT[S_ID] from RoomAllotment where ROOM_ID <> ''"
                    Dim adptr As New OleDbDataAdapter(query, con)
                    Dim dt As New DataTable
                    adptr.Fill(dt)
                    cboSelected.DataSource = dt
                    cboSelected.DisplayMember = "S_ID"
                    adptr.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            ElseIf cboSearchBy.SelectedIndex = 3 Then
                Try
                    con.Open()
                    query = "SELECT * FROM RoomAllotment WHERE BED_ID <> '' AND ROOM_ID <> '' ;"
                    Dim adptr As New OleDbDataAdapter(query, con)
                    Dim dt As New DataTable
                    adptr.Fill(dt)
                    dtGridViewStudentDetail.DataSource = dt
                    dtGridViewStudentDetail.Sort(dtGridViewStudentDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                    adptr.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                cboSelected.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' con.Close()
        End Try
    End Sub
    Private Sub cboSelected_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSelected.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            If cboSearchBy.SelectedIndex = 1 Then
                query = "select * from RoomAllotment where NAME like '" + cboSelected.Text + "';"
                Dim adptr As New OleDbDataAdapter(query, con)
                Dim dt As New DataTable
                adptr.Fill(dt)
                Dim rowc As Integer = dt.Rows.Count - 1
                Dim cmd As New OleDbCommand(query, con)
                Dim reader As OleDbDataReader = cmd.ExecuteReader
                cmd.Dispose()
                cboSearchYear.Text = ""
                cboSearchYear.Visible = False
                Label24.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '''''''''''''''''''''''' course year'''''''''''''''''''''''''''
        Try
            con.Open()
            If cboSearchBy.SelectedIndex = 0 Then
                cboSearchYear.Visible = True
                Label24.Visible = False
                query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboSelected.Text + "'"
                Dim adptr1 As New OleDbDataAdapter(query, con)
                Dim dt1 As New DataTable
                adptr1.Fill(dt1)
                cboSearchYear.DataSource = dt1
                cboSearchYear.DisplayMember = "COURSE_SPECIFICATION"
                adptr1.Dispose()
            End If
            ' cboSearchYear.Text = ""
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        StudentRoomAllotment.Show()
        StudentRoomAllotment.MdiParent = Hostel_Management_System
        StudentRoomAllotment.Dock = DockStyle.Fill
    End Sub

    Private Sub dtGridViewStudentDetail_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridViewStudentDetail.CellEnter, dtGridViewStudentDetail.CellEnter
        cellenter()
    End Sub

    Private Sub rdoCuurentStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoCuurentStudent.CheckedChanged
        If rdoCuurentStudent.Checked = True Then
            DateTimePicker1.Visible = False
            radioCurrentView()
        ElseIf rdoCuurentStudent.Checked = False Then
            DateTimePicker1.Visible = False
        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''' view Current Living Student only '''''''''''''''''''''''''''''''''''''''''''''
    Private Sub radioCurrentView()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT * FROM RoomAllotment WHERE BED_ID <> '' AND ROOM_ID <> '' ;"
            'Dim cmd As New OleDbCommand(query, con)
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridViewStudentDetail.DataSource = dt
            dtGridViewStudentDetail.Sort(dtGridViewStudentDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''' view previous Living Student only '''''''''''''''''''''''''''''''''''''''''''''
    Private Sub radioPreviousView()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT * FROM RoomAllotment WHERE BED_ID = '' AND ROOM_ID = '' ;"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridViewStudentDetail.DataSource = dt
            dtGridViewStudentDetail.Sort(dtGridViewStudentDetail.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub rdoPreviousStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPreviousStudent.CheckedChanged
        If rdoPreviousStudent.Checked = True Then
            DateTimePicker1.Visible = True
            radioPreviousView()
        ElseIf rdoPreviousStudent.Checked = False Then
            DateTimePicker1.Visible = False
        End If
    End Sub

    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        rptIndividualStudentDetails.Show()
        rptIndividualStudentDetails.MdiParent = Hostel_Management_System
        rptIndividualStudentDetails.Dock = DockStyle.Fill
    End Sub

    Private Sub dtGridViewStudentDetail_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridViewStudentDetail.CellContentClick

    End Sub

    Private Sub dtGridViewStudentDetail_CellContextMenuStripChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridViewStudentDetail.CellContextMenuStripChanged

    End Sub

    Private Sub dtGridViewStudentDetail_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridViewStudentDetail.CellContentDoubleClick

    End Sub
End Class