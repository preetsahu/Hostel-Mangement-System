Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class StudentRoomAllotment
    Dim query As String
    Dim qc As String
    Dim str As String
    Dim query1 As String
    Dim query2 As String
    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        For Each ctrl In GroupBox2.Controls.OfType(Of TextBox)()
            If ctrl.Text = "" Then
                MsgBox("please fill up required fields")
                ctrl.Focus()
            End If
        Next
        If txtstudentname.Text = "" Then
            MsgBox("please fillup student's name")
            txtstudentname.Focus()
        ElseIf txtstudentcontact.Text = "" Then
            MsgBox("please fillup student's contact")
            txtstudentcontact.Focus()
        ElseIf txtfathername.Text = "" Then
            MsgBox("please fillup father's name")
            txtfathername.Focus()
        ElseIf txtfathercontact.Text = "" Then
            MsgBox("please fillup father's contact")
            txtfathercontact.Focus()
        ElseIf RichtTxtLaddress.Text = "" Then
            MsgBox("please fillup address ")
            RichtTxtLaddress.Focus()
        ElseIf txtmothername.Text = "" Then
            MsgBox("please fillup mother's contact")
            txtmothercontact.Focus()
        ElseIf txtmothercontact.Text = "" Then
            MsgBox("please enter mother's contact")
            txtmothercontact.Focus()
        ElseIf RichTxtPaddress.Text = "" Then
            MsgBox("please fillup permanent address")
            RichTxtPaddress.Focus()
        ElseIf txtlocalguardian.Text = "" Then
            MsgBox("please fillup local gaurdian's name")
            txtlocalguardian.Focus()
        ElseIf txtlocalguardiancontact.Text = "" Then
            MsgBox("please fillup local gaurdian's contact")
            txtlocalguardian.Focus()
        ElseIf RichtTxtLaddress.Text = "" Then
            MsgBox("please fillup local gaurdian's address")
            RichtTxtLaddress.Focus()
        ElseIf cboclass.Text = "" Then
            MsgBox("please select student class:")
            cboclass.Focus()
        ElseIf cboyear.Text = "" Then
            MsgBox("please select course year")
            cboyear.Focus()
        ElseIf cboRoomID.Text = "" Then
            MsgBox("please select room ")
            cboRoomID.Focus()
        ElseIf cboAllotBedID.Text = "" Then
            MsgBox("please assign a bed_id to student name")
            cboAllotBedID.Focus()
        ElseIf cboRouteID.Text = "" Then
            MsgBox("please select route of bus")
            cboRouteID.Focus()
        ElseIf txtbusid.Text = "" Then
            MsgBox("please fillup bus id")
            txtbusid.Focus()
        ElseIf cboRoomID.Text <> "" And cboAllotBedID.Text = "" Then
            MsgBox("please select another room ,their is no free bed")
            cboRoomID.Focus()
        ElseIf cboRoomID.Text = "" And cboAllotBedID.Text = "" Then
            MsgBox("please select room and bed")
            cboRoomID.Focus()
        ElseIf cboRoomID.Text = "" And cboAllotBedID.Text <> "" Then
            MsgBox("please select the room")
            cboRoomID.Focus()
        Else
            Try
                con.Open()
                If PictureBox1.Image Is Nothing Then
                    MsgBox("upload image")
                    Dim myfile As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                    Dim myFilereader As New BinaryReader(myfile)
                    Dim mybyteImage(myfile.Length) As Byte
                    myFilereader.Read(mybyteImage, 0, myfile.Length)
                    myFilereader.Close()
                    myfile.Close()
                    query = "insert into RoomAllotment (S_ID,DOB,NAME,CONTACT,PHOTO,FATHERS_NAME,FATHERS_CONTACT,MOTHERS_NAME,MOTHERS_CONTACT,PERMANENT_ADDRESS,LOCAL_GAURDIAN,LOCAL_GAURDIAN_CONTACT,LOCAL_GAURDIAN_ADDRESS,CLASS,COURSE_YEAR,ROOM_ID,BED_ID,BUS_ID,ROUTE_ID,REGISTRATION_DATE) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@sid", Val(txtstudentid.Text))
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTimePicker1.Text))
                    cmd.Parameters.AddWithValue("@name", txtstudentname.Text)
                    cmd.Parameters.AddWithValue("@Scontact", txtstudentcontact.Text)
                    cmd.Parameters.AddWithValue("@photo", mybyteImage)
                    cmd.Parameters.AddWithValue("@fathername", txtfathername.Text)
                    cmd.Parameters.AddWithValue("@Fcontact", txtfathercontact.Text)
                    cmd.Parameters.AddWithValue("@mothername", txtmothername.Text)
                    cmd.Parameters.AddWithValue("@Mcontact", txtmothercontact.Text)
                    cmd.Parameters.AddWithValue("@Padd", RichTxtPaddress.Text)
                    cmd.Parameters.AddWithValue("@localgaurdian", txtlocalguardian.Text)
                    cmd.Parameters.AddWithValue("@Lcontact", txtlocalguardiancontact.Text)
                    cmd.Parameters.AddWithValue("@Ladd", RichtTxtLaddress.Text)
                    cmd.Parameters.AddWithValue("@class", cboclass.Text)
                    cmd.Parameters.AddWithValue("@year", cboyear.Text)
                    cmd.Parameters.AddWithValue("@roomID", cboRoomID.Text)
                    cmd.Parameters.AddWithValue("@bedID", cboAllotBedID.Text)
                    cmd.Parameters.AddWithValue("@BusID", txtbusid.Text)
                    cmd.Parameters.AddWithValue("@routeID", cboRouteID.Text)
                    cmd.Parameters.AddWithValue("@RegDate", Convert.ToDateTime(DateTimePicker1.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Bed Number :" + cboAllotBedID.Text + " of Room Number :" + cboRoomID.Text + " is Alloted To Student :" + txtstudentname.Text)
                Else
                    MsgBox("upload without image")
                    query = "insert into RoomAllotment (S_ID,DOB,NAME,CONTACT,FATHERS_NAME,FATHERS_CONTACT,MOTHERS_NAME,MOTHERS_CONTACT,PERMANENT_ADDRESS,LOCAL_GAURDIAN,LOCAL_GAURDIAN_CONTACT,LOCAL_GAURDIAN_ADDRESS,CLASS,COURSE_YEAR,ROOM_ID,BED_ID,BUS_ID,ROUTE_ID,REGISTRATION_DATE) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@sid", Val(txtstudentid.Text))
                    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTimePicker1.Text))
                    cmd.Parameters.AddWithValue("@name", txtstudentname.Text)
                    cmd.Parameters.AddWithValue("@Scontact", txtstudentcontact.Text)
                    '   cmd.Parameters.AddWithValue("@photo", mybyteImage)
                    cmd.Parameters.AddWithValue("@fathername", txtfathername.Text)
                    cmd.Parameters.AddWithValue("@Fcontact", txtfathercontact.Text)
                    cmd.Parameters.AddWithValue("@mothername", txtmothername.Text)
                    cmd.Parameters.AddWithValue("@Mcontact", txtmothercontact.Text)
                    cmd.Parameters.AddWithValue("@Padd", RichTxtPaddress.Text)
                    cmd.Parameters.AddWithValue("@localgaurdian", txtlocalguardian.Text)
                    cmd.Parameters.AddWithValue("@Lcontact", txtlocalguardiancontact.Text)
                    cmd.Parameters.AddWithValue("@Ladd", RichtTxtLaddress.Text)
                    cmd.Parameters.AddWithValue("@class", cboclass.Text)
                    cmd.Parameters.AddWithValue("@year", cboyear.Text)
                    cmd.Parameters.AddWithValue("@roomID", cboRoomID.Text)
                    cmd.Parameters.AddWithValue("@bedID", cboAllotBedID.Text)
                    cmd.Parameters.AddWithValue("@BusID", txtbusid.Text)
                    cmd.Parameters.AddWithValue("@routeID", cboRouteID.Text)
                    cmd.Parameters.AddWithValue("@RegDate", Convert.ToDateTime(DateTimePicker1.Text))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Bed Number :" + cboAllotBedID.Text + " of Room Number :" + cboRoomID.Text + " is Alloted To Student :" + txtstudentname.Text)
                End If
            Catch ex As Exception
                MsgBox("The Student id must be unique,please click Add new Button for another Entry")
            Finally
                con.Close()
            End Try

            ''''''''''''''''''''''''''''''''''''''''''''''''''' update ROOM Details '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Try
                con.Open()
                query2 = "update newRoomDetail set AVAIL=? where ROOM_ID =? and BED_ID=?"
                Dim cmd As New OleDbCommand(query2, con)
                cmd.Parameters.AddWithValue("?", "NO")
                cmd.Parameters.AddWithValue("?", cboRoomID.Text)
                cmd.Parameters.AddWithValue("?", cboAllotBedID.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Room Number : " + cboRoomID.Text + " Bed ID :" + cboAllotBedID.Text + " available status is : No")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub allotment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '''''''''''''''''''''''''''''''''''''''''''''coding for autocompletion textbox from database''''''''''';'''''''''''''''
        txtstudentname.AutoCompleteMode = AutoCompleteMode.Suggest
        Dim datacollection As New AutoCompleteStringCollection()
        getdata(datacollection)
        txtstudentname.AutoCompleteCustomSource = datacollection

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
            query = "Select distinct[ROOM_ID] from newRoomDetail"
            adptr = New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboRoomID.DataSource = dt
            cboRoomID.DisplayMember = "ROOM_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboclass.DataSource = dt
            cboclass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboyear.Text = ""



        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''used to count number of records in roomallotment table for sid inputs
        Dim sid As Integer
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim dt1 As New DataTable
            Dim query As String
            query = "Select max(S_ID) from RoomAllotment "
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                sid = reader(0)
                txtstudentid.Text = sid + 1
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        '------------------------------------------- CboRouteID filling --------------------------------------------------------
        Try
            con.Open()
            query = "select distinct[ROUTE_ID] from RouteDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt2 As New DataTable
            adptr.Fill(dt2)
            cboRouteID.DataSource = dt2
            cboRouteID.DisplayMember = "ROUTE_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        cboRouteID.Text = ""
        cboRoomID.Text = ""
        txtbusid.Text = ""
        txtRichRouteDes.Text = ""
        cboAllotBedID.Text = ""
    End Sub

    Private Sub getdata(ByVal datacollection As AutoCompleteStringCollection)
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select DISTINCT[NAME] from RoomAllotment"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim ds As New DataSet
            adptr.Fill(ds)
            Dim i As Integer = 0
            For i = 0 To ds.Tables(0).Rows.Count - 1
                datacollection.Add(ds.Tables(0).Rows(i)("NAME").ToString())
            Next
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub Btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnew.Click
        txtstudentid.Text = Val(txtstudentid.Text) + 1
        txtstudentname.Text = ""
        txtstudentcontact.Text = ""
        PictureBox1.Image = Nothing
        txtfathername.Text = ""
        txtfathercontact.Text = ""
        txtmothername.Text = ""
        txtmothercontact.Text = ""
        txtlocalguardian.Text = ""
        RichTxtPaddress.Text = ""
        txtlocalguardiancontact.Text = ""
        RichtTxtLaddress.Text = ""
        cboclass.Text = ""
        cboyear.Text = ""
        cboRoomID.Text = ""
        cboAllotBedID.Text = ""
        txtbusid.Text = ""
        cboRouteID.Text = ""
        txtRichRouteDes.Text = ""
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        ViewStudentDetails.dtGridViewStudentDetail.Refresh()
        ViewStudentDetails.Show()
        ViewStudentDetails.MdiParent = Hostel_Management_System
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        ViewStudentDetails.Show()
        ViewStudentDetails.MdiParent = Hostel_Management_System
        Me.Hide()
        Me.Refresh()
    End Sub

    Private Sub txtfathercontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfathercontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtmothercontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmothercontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtstudentcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudentcontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtlocalguardiancontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocalguardiancontact.KeyPress
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboclass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboclass.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboyear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboyear.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbedid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtbusid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtrouteid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) < 47 Or Asc(e.KeyChar) > 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        End If
    End Sub

    Private Sub cboRoomID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            e.Handled = True
            MsgBox("not possible to edit", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtstudentname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstudentname.KeyPress
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

    Private Sub txtstudentname_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstudentname.MouseEnter
        txtstudentname.BackColor = Color.Cyan
        txtstudentname.ForeColor = Color.DeepPink
    End Sub

    Private Sub txtstudentname_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstudentname.MouseLeave
        txtstudentname.BackColor = Color.White
        txtstudentname.ForeColor = Color.Black
    End Sub

    Private Sub btnsave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.MouseEnter
        btnsave.BackColor = Color.CadetBlue
        btnsave.ForeColor = Color.Black
    End Sub

    Private Sub btnsave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsave.MouseLeave
        btnsave.BackColor = Color.White
        btnsave.ForeColor = Color.Black
    End Sub

    Private Sub Btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnclose.MouseEnter
        Btnclose.BackColor = Color.CadetBlue
        Btnclose.ForeColor = Color.Black
    End Sub

    Private Sub Btnclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btnclose.MouseLeave
        Btnclose.BackColor = Color.White
        Btnclose.ForeColor = Color.Black
    End Sub

    Private Sub txtfathername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfathername.KeyPress
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

    Private Sub txtmothername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmothername.KeyPress
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

    Private Sub txtlocalguardian_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocalguardian.KeyPress
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

    Private Sub cboRouteID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRouteID.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
            e.Handled = True
            ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        End If
        If Asc(e.KeyChar) < 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboRouteID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRouteID.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT BD.BUS_ID, BD.COLLEGE_ARRIVAL_TIME, BD.HOSTEL_ARRIVAL_TIME, RD.ROUTE_DESCRIPTION, DD.DRIVER_NAME, DD.DRIVER_ID FROM (BusDetail AS BD INNER JOIN DriverDetails AS DD ON BD.DRIVER_ID =DD.DRIVER_ID) INNER JOIN RouteDetails AS RD ON BD.ROUTE_ID = RD.ROUTE_ID WHERE RD.ROUTE_ID=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", cboRouteID.Text)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtbusid.Text = reader(0).ToString
                dtPickerACtime.Text = reader(1).ToString
                dtPickerAHtime.Text = reader(2).ToString
                txtRichRouteDes.Text = reader(3).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboRoomID_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRoomID.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
            e.Handled = True
            ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        End If
        If Asc(e.KeyChar) < 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboRoomID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRoomID.SelectedIndexChanged
        'cboAllotBedID.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from newRoomDetail where ROOM_ID like '" + cboRoomID.Text + "' and AVAIL='YES'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboAllotBedID.DataSource = dt
            cboAllotBedID.DisplayMember = "BED_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboAllotBedID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboAllotBedID.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
            e.Handled = True
            ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        End If
        If Asc(e.KeyChar) < 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRichRouteDes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRichRouteDes.KeyPress
        If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
            e.Handled = True
            ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        End If
        If Asc(e.KeyChar) < 47 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) < 58 Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboclass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboclass.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboclass.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboyear.DataSource = dt
            cboyear.DisplayMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboyear.Text = ""
    End Sub

    Private Sub txtstudentcontact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstudentcontact.TextChanged

    End Sub

    Private Sub txtfathername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfathername.TextChanged

    End Sub

    Private Sub cboAllotBedID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAllotBedID.SelectedIndexChanged
    End Sub
End Class