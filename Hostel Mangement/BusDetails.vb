Imports System.Data
Imports System.Data.OleDb
Class BusDetails
    Dim query As String
    Private Sub courseNameload()
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select distinct[COURSE_NAME] from CourseDetails "
            Dim adptr As New OleDbDataAdapter(query, CON)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboClass.DataSource = dt
            cboClass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub
    Private Sub BusDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        courseNameload()
        grpBusDetails.Enabled = False

        Dim con As New OleDb.OleDbConnection
        con = connectTOhms()
        Try
            query = "select * from BusDetail"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboBusID.DataSource = dt
            cboBusID.DisplayMember = "BUS_ID"
            cboRoute.DataSource = dt
            cboRoute.ValueMember = "ROUTE_ID"
            cboBusNumber.DataSource = dt
            cboBusNumber.DisplayMember = "BUS_ID"
            
            adptr.Dispose()
            '=''''''''''''''''''''''''''
            cboBusID.Text = ""
            cboBusNumber.Text = ""
            cboDriverID.Text = ""
            cboRouteid.Text = ""
            cboRouteIDAdde.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        If grpBusDetails.Enabled = False Then
            For Each Ctrl In Me.grpBusDetails.Controls.OfType(Of ComboBox)()
                Ctrl.Text = ""
            Next
        End If
        
        Try
            con.Open()
            query = "select * from DriverDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboDriverID.DataSource = dt
            cboDriverID.ValueMember = "DRIVER_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "select ROUTE_ID from RouteDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboRouteIDAdde.DataSource = dt
            cboRouteIDAdde.DisplayMember = "ROUTE_ID"
            cboRouteid.DataSource = dt
            cboRouteid.DisplayMember = "ROUTE_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        tab0dynamicLabelHide()
        Dim LINE As Integer = 1
        Dim i As Integer = 1
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT BD.BUS_ID, RD.ROUTE_ID, BD.COLLEGE_ARRIVAL_TIME, BD.HOSTEL_ARRIVAL_TIME, RD.ROUTE_DESCRIPTION, DD.DRIVER_NAME,DD.LICENSE_NUMBER, DD.DRIVER_ID FROM (BusDetail AS BD INNER JOIN DriverDetails AS DD ON BD.DRIVER_ID =DD.DRIVER_ID) INNER JOIN RouteDetails AS RD ON BD.ROUTE_ID = RD.ROUTE_ID WHERE RD.ROUTE_ID='" + cboRoute.Text + "';"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim lblBus As New Label
                lblBus.Text = " Bus ID : " + reader(0).ToString
                lblBus.Name = "lbl" & i
                lblBus.Size = New Size(80, 30)
                ' lblBus.AutoSize = New AutoSizeMode()
                lblBus.Location = New Point(400, LINE * 80)
                lblBus.BackColor = Color.Cornsilk
                lblBus.ForeColor = Color.Black
                TabPage1.Controls.Add(lblBus)

                Dim lblDname As New Label
                lblDname.Text = "Driver Name : " + reader(5).ToString
                lblDname.Name = "lblDname" & i
                lblDname.Size = New Size(120, 30)
                '  lblDname.AutoSize = New AutoSizeMode()
                lblDname.Location = New Point(70, LINE * 120)
                lblDname.BackColor = Color.Cornsilk
                lblDname.ForeColor = Color.Brown
                TabPage1.Controls.Add(lblDname)

                Dim lblDlicense As New Label
                lblDlicense.Text = "Licence Number : " + reader(6).ToString
                '  lblDlicense.AutoSize = New AutoSizeMode()
                lblDlicense.Name = "lblDlicense" & i
                lblDlicense.Size = New Size(110, 30)
                lblDlicense.Location = New Point(190, LINE * 120)
                lblDlicense.BackColor = Color.Cornsilk
                lblDlicense.ForeColor = Color.Brown
                TabPage1.Controls.Add(lblDlicense)

                Dim lblClgsArrivalTime As New Label
                lblClgsArrivalTime.Text = "College Arrival Time :" + reader(2).ToString
                ' lblClgsArrivalTime.AutoSize = New AutoSizeMode()
                lblClgsArrivalTime.Name = "lblClgsArrivalTime" & i
                lblClgsArrivalTime.Size = New Size(125, 30)
                lblClgsArrivalTime.Location = New Point(300, LINE * 120)
                lblClgsArrivalTime.BackColor = Color.Cornsilk
                lblClgsArrivalTime.ForeColor = Color.Brown
                TabPage1.Controls.Add(lblClgsArrivalTime)

                Dim lblHosArrivalTime As New Label
                lblHosArrivalTime.Text = " Hostel Arrival Time : " + reader(3).ToString
                lblHosArrivalTime.AutoSize = New AutoSizeMode()
                ' lblHosArrivalTime.Name = "lblHosArrivalTime" & i
                lblHosArrivalTime.Size = New Size(120, 30)
                lblHosArrivalTime.Location = New Point(430, LINE * 120)
                lblHosArrivalTime.BackColor = Color.Cornsilk
                lblHosArrivalTime.ForeColor = Color.Brown
                TabPage1.Controls.Add(lblHosArrivalTime)

                Dim lblRouDescription As New Label
                lblRouDescription.Text = " Bus Passes Through : " + reader(4).ToString
                ' lblRouDescription.AutoSize = New AutoSizeMode()
                lblRouDescription.Name = "lblRouDescription" & i
                lblRouDescription.Size = New Size(180, 30)
                lblRouDescription.Location = New Point(560, LINE * 120)
                lblRouDescription.BackColor = Color.Cornsilk
                lblRouDescription.ForeColor = Color.Brown
                TabPage1.Controls.Add(lblRouDescription)

                Dim lblBusId As New Label



                i = i + 3
                LINE = LINE + 4
            End While
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub tab0dynamicLabelHide()
        For Each lbl In TabPage1.Controls.OfType(Of Label)()
            lbl.Hide()
        Next
    End Sub

    Private Sub chkBusDetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBusDetails.CheckedChanged
        If chkBusDetails.Checked = True Then
            grpBusDetails.Enabled = True
        ElseIf chkBusDetails.Checked = False Then
            grpBusDetails.Enabled = False
            cboBusID.Text = ""
            cboBusNumber.Text = ""
            cboDriverID.Text = ""
            cboRouteid.Text = ""

        End If

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    '------------------------------------------ FUCTION BUS ID REFRESH -------------------
    Private Sub ComboBusRefersh()
        Dim con As New OleDb.OleDbConnection
        con = connectTOhms()
        Try
            query = "select * from BusDetail"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboBusID.DataSource = dt
            cboBusID.DisplayMember = "BUS_ID"
            cboRoute.DataSource = dt
            cboRoute.ValueMember = "ROUTE_ID"
            cboBusNumber.DataSource = dt
            cboBusNumber.DisplayMember = "BUS_ID"

            adptr.Dispose()
            ''=''''''''''''''''''''''''''
            'cboBusID.Text = ""
            'cboBusNumber.Text = ""
            'cboDriverID.Text = ""
            'cboRouteid.Text = ""
            'cboRouteIDAdde.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSaveBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBus.Click

        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            If cboBusNumber.Text = "" Then
                MsgBox("please select Bus Number")
            ElseIf cboDriverID.Text = "" Then
                MsgBox("please select driver id")
            ElseIf cboRouteid.Text = "" Then
                MsgBox("plese select route id")
            Else
                con.Open()
                query = "insert into BusDetail (BUS_ID,ROUTE_ID,DRIVER_ID,COLLEGE_ARRIVAL_TIME,HOSTEL_ARRIVAL_TIME) values (?,?,?,?,?)"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", cboBusNumber.Text)
                cmd.Parameters.AddWithValue("?", cboRouteid.Text)
                cmd.Parameters.AddWithValue("?", cboDriverID.Text)
                cmd.Parameters.AddWithValue("?", Convert.ToDateTime(DTPickerClgTime.Value.ToLongTimeString))
                cmd.Parameters.AddWithValue("?", Convert.ToDateTime(dtPickerHosTime.Value.ToLongTimeString))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Record of Bus Number :" + cboBusNumber.Text + " is  Saved")
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        ComboBusRefersh()
    End Sub
    '----'''''''''''''''''''''''''''''''''''''' fuction for refresh combo box '''''''''''''''''''''''''''
    Private Sub refershCombo()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from DriverDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboDriverID.DataSource = dt
            cboDriverID.ValueMember = "DRIVER_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "select ROUTE_ID from RouteDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboRouteIDAdde.DataSource = dt
            cboRouteIDAdde.DisplayMember = "ROUTE_ID"
            cboRouteid.DataSource = dt
            cboRouteid.DisplayMember = "ROUTE_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnSaveDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDriver.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "insert into DriverDetails (DRIVER_ID,DRIVER_NAME,LICENSE_NUMBER,CONTACT_NO,BLOOD_GROUP,ID_PROOF_TYPE,ID_PROOF_DETAIL,DATE_OF_BIRTH) values (?,?,?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", txtDriverID.Text)
            cmd.Parameters.AddWithValue("?", txtDriverName.Text)
            cmd.Parameters.AddWithValue("?", txtLICnumber.Text)
            cmd.Parameters.AddWithValue("?", txtContact.Text)
            cmd.Parameters.AddWithValue("?", cboBlood.Text)
            cmd.Parameters.AddWithValue("?", cboIDType.Text)
            cmd.Parameters.AddWithValue("?", txtIDdetails.Text)
            cmd.Parameters.AddWithValue("?", dtPickerDOB.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        refershCombo()
    End Sub

    Private Sub btnUpdateBus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBus.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update BusDetail set DRIVER_ID=? ,COLLEGE_ARRIVAL_TIME=?,HOSTEL_ARRIVAL_TIME=?,ROUTE_ID=? where BUS_ID=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", cboDriverID.Text)
            cmd.Parameters.AddWithValue("?", DTPickerClgTime.Text)
            cmd.Parameters.AddWithValue("?", dtPickerHosTime.Text)
            cmd.Parameters.AddWithValue("?", cboRouteid.Text)
            cmd.Parameters.AddWithValue("?", cboBusNumber.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Bus Number: " + cboBusNumber.Text + " records edited and updated sucessfully ")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnUpdateDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDriver.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update DriverDetails set DRIVER_NAME=?,LICENSE_NUMBER=?,CONTACT_NO=?,DOB=?,BLOOD_GROUP=?,ID_PROOF_TYPE=?,ID_PROOF_DETAIL=? where DRIVER_ID=?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", txtDriverName.Text)
            cmd.Parameters.AddWithValue("?", txtLICnumber.Text)
            cmd.Parameters.AddWithValue("?", txtContact.Text)
            cmd.Parameters.AddWithValue("?", dtPickerDOB.Text)
            cmd.Parameters.AddWithValue("?", cboBlood.Text)
            cmd.Parameters.AddWithValue("?", cboIDType.Text)
            cmd.Parameters.AddWithValue("?", txtIDdetails.Text)
            cmd.Parameters.AddWithValue("?", txtDriverID.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Driver Name: " + txtDriverName.Text + " records edited and updated sucessfully ")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboRouteid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRouteid.KeyPress
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

    Private Sub cboRouteid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRouteid.Leave
        grpRouteDetails.Enabled = True
    End Sub

    Private Sub cboRouteid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRouteid.SelectedIndexChanged
        grpRouteDetails.Enabled = True
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select ROUTE_DESCRIPTION ,COLLEGE_DISTANCE, TRAVEL_TIME from RouteDetails where ROUTE_ID ='" + cboRouteid.Text + "'"
            Dim CMD As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = CMD.ExecuteReader
            While reader.Read
                MetroTile1.Text = reader(0).ToString
                MetroTile2.Text = reader(1)
                MetroTile3.Text = reader(2)
            End While
            CMD.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub lblDynamicHide()
        For Each Lbl In tab1.Controls.OfType(Of Label)()
            Lbl.Hide()
        Next
    End Sub

    Private Sub cboBusNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBusNumber.KeyPress
        ''If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
        ''    e.Handled = True
        ''    ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        ''End If
        'If Asc(e.KeyChar) < 47 Then
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) < 58 Then
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
        '    e.Handled = True
        'End If
    End Sub
    Private Sub cboBusNumber_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBusNumber.Leave
        lblDynamicHide()
        Dim LINE As Integer = 1
        Dim i As Integer = 1
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "Select BUS_ID from BusDetail where BUS_ID='" + cboBusID.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                Dim lblBusNum As New Label
                lblBusNum.Text = " Bus ID : " + reader(0).ToString
                lblBusNum.Name = "lbl" & i
                lblBusNum.Size = New Size(90, 40)
                ' lblBus.AutoSize = New AutoSizeMode()
                lblBusNum.Location = New Point(800, LINE * 5)
                lblBusNum.BackColor = Color.Cornsilk
                lblBusNum.ForeColor = Color.Black
                tab1.Controls.Add(lblBusNum)
                i = i + 3
                LINE = LINE + 4
            End While
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboBusNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBusNumber.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "Select * from BusDetail where BUS_ID='" + cboBusID.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                DTPickerClgTime.Text = reader(3).ToString
                dtPickerHosTime.Text = reader(4).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        ' cboBusNumber.Text = ""
        cboDriverID.Text = ""
    End Sub
    Private Sub Clear()
        txtDriverID.Text = ""
        cboBusNumber.Text = ""
        cboRouteid.Text = ""
        cboDriverID.Text = ""
        DTPickerClgTime.Text = Nothing
        dtPickerHosTime.Text = Nothing
        dname.Hide()
    End Sub


    Private Sub btnUpdateRouteDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateRouteDetails.Click
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "update RouteDetails set ROUTE_DESCRIPTION=?,COLLEGE_DISTANCE=?,TRAVEL_TIME=? where ROUTE_ID=?"
            Dim CMD As New OleDbCommand(query, CON)
            CMD.Parameters.AddWithValue("?", txtRouteDescription.Text)
            CMD.Parameters.AddWithValue("?", cboRouteIDAdde.Text)
            CMD.Parameters.AddWithValue("?", txtDistance.Text)
            CMD.Parameters.AddWithValue("?", txtTravelTime.Text)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Route Number :" + cboRouteid.Text + " records updated sucesfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub

    Private Sub btnSaveRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRoute.Click
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "insert into RouteDetails (ROUTE_ID,ROUTE_DESCRIPTION,COLLEGE_DISTANCE,TRAVEL_TIME) values (?,?,?,?)"
            Dim CMD As New OleDbCommand(query, CON)
            CMD.Parameters.AddWithValue("?", cboRouteIDAdde.Text)
            CMD.Parameters.AddWithValue("?", txtRouteDescription.Text)
            CMD.Parameters.AddWithValue("?", txtDistance.Text)
            CMD.Parameters.AddWithValue("?", txtTravelTime.Text)
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            MsgBox("Route Number :" + cboRouteid.Text + " records updated sucesfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub

    Private Sub chkDriverDetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDriverDetail.CheckedChanged
        If chkDriverDetail.Checked = True Then
            grpDriverDetail.Enabled = True
        ElseIf chkDriverDetail.Checked = False Then
            grpDriverDetail.Enabled = False
        End If
    End Sub
    Dim qc As String

    Dim StuID As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        Dim i As Integer = 0
        Dim LINE As Integer = 1
        Try
            con.Open()
            query = "select * from RoomAllotment where NAME LIKE '" + cboName.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                StuID = reader(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        LINE = 1
        Try
            con.Open()
            query = "SELECT ra.NAME, ra.BED_ID, ra.ROOM_ID, ra.CLASS, ra.CONTACT, bd.BUS_ID, bd.ROUTE_ID, bd.COLLEGE_ARRIVAL_TIME, bd.HOSTEL_ARRIVAL_TIME, dd.DRIVER_NAME, dd.CONTACT_NO, rd.ROUTE_DESCRIPTION, rd.COLLEGE_DISTANCE FROM ((BusDetail AS bd INNER JOIN DriverDetails AS dd ON bd.DRIVER_ID = dd.DRIVER_ID) INNER JOIN RoomAllotment AS ra ON bd.BUS_ID = ra.BUS_ID) INNER JOIN RouteDetails AS rd ON bd.ROUTE_ID = rd.ROUTE_ID WHERE S_ID LIKE ? ;"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", StuID)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            While reader.Read
                Dim lblSname As New Button
                lblSname.Name = "lbl" & i
                lblSname.Size = New Size(300, 30)
                lblSname.Location = New Point(70, LINE * 60)
                lblSname.Text = "Student Name :" + reader(0).ToString + "    Class : " + reader(3).ToString
                lblSname.BackColor = Color.Gold
                lblSname.ForeColor = Color.Black
                TabPage2.Controls.Add(lblSname)

                Dim lblStuRoomid As New Button
                lblStuRoomid.Name = "lbl" & i
                lblStuRoomid.Size = New Size(200, 30)
                lblStuRoomid.Location = New Point(400, LINE * 60)
                lblStuRoomid.Text = "Student Room Id And Bed ID:" + reader(2).ToString + "   " + reader(1).ToString
                lblStuRoomid.BackColor = Color.Gold
                lblStuRoomid.ForeColor = Color.Black
                TabPage2.Controls.Add(lblStuRoomid)

                Dim lblDname As New Button
                lblDname.Text = "Bus Driver Name : " + reader(9).ToString
                lblDname.Name = "lblDname" & i
                lblDname.Size = New Size(200, 30)
                lblDname.Location = New Point(80, LINE * 120)
                lblDname.BackColor = Color.Cornsilk
                lblDname.ForeColor = Color.Brown
                TabPage2.Controls.Add(lblDname)

                Dim lblClgsArrivalTime As New Label
                lblClgsArrivalTime.Text = "College Arrival Time :" + reader(7).ToString
                lblClgsArrivalTime.Name = "lblClgsArrivalTime" & i
                lblClgsArrivalTime.Size = New Size(125, 30)
                lblClgsArrivalTime.Location = New Point(300, LINE * 120)
                lblClgsArrivalTime.BackColor = Color.Cornsilk
                lblClgsArrivalTime.ForeColor = Color.Brown
                TabPage2.Controls.Add(lblClgsArrivalTime)

                Dim lblHosArrivalTime As New Label
                lblHosArrivalTime.Text = " Hostel Arrival Time : " + reader(8).ToString
                lblHosArrivalTime.AutoSize = New AutoSizeMode()
                lblHosArrivalTime.Size = New Size(120, 30)
                lblHosArrivalTime.Location = New Point(430, LINE * 120)
                lblHosArrivalTime.BackColor = Color.Cornsilk
                lblHosArrivalTime.ForeColor = Color.Brown
                TabPage2.Controls.Add(lblHosArrivalTime)

                Dim lblRouDescription As New Label
                lblRouDescription.Text = " Bus Passes Through : " + reader(11).ToString
                lblRouDescription.Name = "lblRouDescription" & i
                lblRouDescription.Size = New Size(180, 30)
                lblRouDescription.Location = New Point(560, LINE * 120)
                lblRouDescription.BackColor = Color.Cornsilk
                lblRouDescription.ForeColor = Color.Brown
                TabPage2.Controls.Add(lblRouDescription)

                Dim lblDcontact As New Label
                lblDcontact.Text = " Driver Contact : " + reader(10).ToString
                lblDcontact.Name = "lblRouDescription" & i
                lblDcontact.Size = New Size(180, 30)
                lblDcontact.Location = New Point(650, LINE * 120)
                lblDcontact.BackColor = Color.Cornsilk
                lblDcontact.ForeColor = Color.Brown
                TabPage2.Controls.Add(lblDcontact)

                i = i + 1
                LINE = LINE + 1
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If cboyear.SelectedIndex = 0 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 1 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 2 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 3 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 4 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 5 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        ElseIf cboyear.SelectedIndex = 6 Then
            qc = "where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboyear.Text + "'"
        End If
        Dim CON As New OleDbConnection
        CON = connectTOhms()
        Try
            CON.Open()
            query = "select * from RoomAllotment " + qc
            Dim adptr As New OleDbDataAdapter(query, CON)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboName.DataSource = dt
            cboName.DisplayMember = "NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub

    Private Sub cboClass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboClass.KeyPress
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

    Private Sub cboDriverID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDriverID.KeyPress
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

    Private Sub cboIDType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboIDType.KeyPress
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

    Private Sub cboRoute_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRoute.KeyPress
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

    Private Sub cboRouteIDAdde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRouteIDAdde.KeyPress
        'If Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 And Asc(e.KeyChar) = 32 Then
        '    e.Handled = True
        '    ' MsgBox("not possible to edit", MsgBoxStyle.Information)
        'End If
        'If Asc(e.KeyChar) < 47 Then
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) < 58 Then
        '    e.Handled = True
        'End If
        'If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 128 Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub cboDriverID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDriverID.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from DriverDetails where DRIVER_ID='" + cboDriverID.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            adptr.SelectCommand.ExecuteNonQuery()
            Dim reader As OleDbDataReader = adptr.SelectCommand.ExecuteReader
            While reader.Read
                dname.Text = reader(1).ToString
            End While
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cboRouteIDAdde.Text = ""
        txtRouteDescription.Text = ""
        txtTravelTime.Text = ""
        txtDistance.Text = ""
    End Sub

    Private Sub cboRouteIDAdde_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRouteIDAdde.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select ROUTE_DESCRIPTION ,COLLEGE_DISTANCE, TRAVEL_TIME from RouteDetails where ROUTE_ID ='" + cboRouteIDAdde.Text + "'"
            Dim CMD As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = CMD.ExecuteReader
            While reader.Read
                txtRouteDescription.Text = reader(0).ToString
                txtDistance.Text = reader(1)
                txtTravelTime.Text = reader(2)
            End While
            CMD.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            grpRouteDetails.Enabled = True
        ElseIf CheckBox1.Checked = False Then
            grpRouteDetails.Enabled = False
        End If
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtDriverID.Text = ""
        txtDriverName.Text = ""
        cboBlood.Text = ""
        txtLICnumber.Text = ""
        txtContact.Text = ""
        cboIDType.Text = ""
        txtIDdetails.Text = ""
    End Sub
End Class