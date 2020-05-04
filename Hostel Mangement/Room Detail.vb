Imports System.Data.OleDb
Imports System.Data
Public Class Room_Detail
    Dim query As String
    Dim qc As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    '------------------------------------------------------- save -----------------------------------------------------
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        con = connectTOhms()

        '------------------------------------------------------- INSERT -----------------------------------------------------
        Try
            con.Open()
            If ListBox1.Items.Count > 0 Then
                For i As Integer = 0 To ListBox1.Items.Count
                    query = "insert into newRoomDetail(ROOM_ID,BED_ID,AVAIL) values (?,?,?)"
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("?", UCase(cboRoomID.Text))
                    cmd.Parameters.AddWithValue("?", ListBox1.Items(i).ToString)
                    cmd.Parameters.AddWithValue("?", "YES")
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Next
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Information)
            ' MsgBox("The ID alredy exist please insert another Room ID")
            cboRoomID.Focus()
        Finally
            con.Close()
        End Try

        '-'''''''''''''''''''''''''''''''''''''''''''''''''' ----------------------------'''''''''''''''''''''''''''''''''''''''''''''
        Try
            con.Open()
            query = "insert into newRoomSpecification (ROOM_ID,Specification) values (?,?)"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", cboRoomID.Text)
            cmd.Parameters.AddWithValue("?", RichtXTrEMARKS.Text)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try


        '----------------------------------------------------- update Room Specification ---------------------------------------------
        Try
            con.Open()
            query = "update newRoomSpecification set Specification=? where ROOM_ID=? "
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", RichtXTrEMARKS.Text)
            cmd.Parameters.AddWithValue("?", UCase(cboRoomID.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            ' MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        DatagridLoad()
        comboFill()
    End Sub
    '------------------''''''''''''''''''''''''''''''''''''''''' CLEAR ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub CLEAR()
        cboAssignedBedID.Text = ""
        txtAvailStatus.Text = ""
        RichtXTrEMARKS.Text = ""
        cboRoomID.Text = ""
        cboBedID.Text = ""
    End Sub
    Private Sub DatagridLoad()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT nrs.ROOM_ID,nrd.BED_ID as BedNumber,nrd.AVAIL as Available,nrs.Specification as 'Room Specification' FROM newRoomDetail nrd INNER JOIN newRoomSpecification nrs ON nrd.ROOM_ID = nrs.ROOM_ID where nrs.ROOM_ID ='" + cboRoomID.Text + "';"
            ' query = "Select * from newRoomDetail where ROOM_ID like '" + cboRoomID.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridRoomSpecifications.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    '------------------------------------------------------------ combo fill ---------------------------------------------------------
    Private Sub comboFill()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT DISTINCT[ROOM_ID] FROM newRoomSpecification;"
            ' query = "SELECT DISTINCT[nr.ROOM_ID] FROM newRoomDetail nr INNER JOIN newRoomSpecification nrs ON nr.ROOM_ID = nrs.ROOM_ID;"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboRoomID.DataSource = dt
            cboRoomID.DisplayMember = "ROOM_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    '------------------------------------------------------------- load ---------------------------------------------------------
    Private Sub Room_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

        comboFill()
        txtAvailStatus.Text = ""
        RichtXTrEMARKS.Text = ""
        cboAssignedBedID.Text = ""
    End Sub
    Private Sub dtGridRoomSpecifications_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGridRoomSpecifications.CellClick
        'dtGridRoomSpecifications.Update()
        'Dim row As DataGridViewRow = dtGridRoomSpecifications.CurrentRow
        'cboRoomID.Text = row.Cells(0).Value.ToString
        'cboBedID.Text = row.Cells(2).Value.ToString
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "update ROOM set TOTAL_BED_ID = ? , AVAILABLE_BEDS = ? , REMARKS = ? where ROOM_ID= ? "
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", UCase(cboBedID.Text))
            cmd.Parameters.AddWithValue("?", txtAvailStatus.Text)
            cmd.Parameters.AddWithValue("?", RichtXTrEMARKS.Text)
            cmd.Parameters.AddWithValue("?", UCase(cboRoomID.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("record of Room ID :" + " is scuceesfully updated")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        DatagridLoad()
        comboFill()
    End Sub

    Private Sub cboRoomID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoomID.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT nr.BED_ID FROM newRoomDetail nr INNER JOIN newRoomSpecification nrs ON nr.ROOM_ID = nrs.ROOM_ID where nr.ROOM_ID like '" + cboRoomID.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboBedID.DataSource = dt
            cboBedID.DisplayMember = "BED_ID"
            'ListBox1.DataSource = dt
            'ListBox1.DisplayMember = "BED_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        
        'Try
        '    con.Open()
        '    query = "SELECT count(BED_ID) FROM newRoomDetail where ROOM_ID='" + cboRoomID.Text + "';"
        '    Dim cmd As New OleDbCommand(query, con)
        '    Dim reader As OleDbDataReader = cmd.ExecuteReader
        '    While reader.Read
        '        '  txtNumberOFbeds.Text = reader(0).ToString
        '    End While
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'Finally
        '    con.Close()
        'End Try

        Try
            con.Open()
            query = "SELECT Specification FROM newRoomSpecification where ROOM_ID='" + cboRoomID.Text + "';"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                RichtXTrEMARKS.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try

        Try
            con.Open()
            query = "SELECT * FROM  newRoomDetail where ROOM_ID ='" + cboRoomID.Text + "' AND AVAIL='NO';"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboAssignedBedID.DataSource = dt
            cboAssignedBedID.DisplayMember = "BED_ID"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        ''''' '''''''''''''''''''''''''''''''' function call ''''''''''''''''''''''''''''''''
        DatagridLoad()

        txtAvailStatus.Text = ""
        cboAssignedBedID.Text = ""
        cboRoomID.Text = ""
        cboBedID.Text = ""
        ' RichtXTrEMARKS.Text = ""
        MetroLabel1.Text = ""
    End Sub

    Private Sub cboBedID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBedID.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT * FROM newRoomDetail where ROOM_ID='" + cboRoomID.Text + "' AND BED_ID='" + cboBedID.Text + "';"
            Dim cmd As New OleDbCommand(query, con)
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtAvailStatus.Text = reader(2).ToString
                MetroLabel1.Text = reader(2).ToString
            End While
            Dim dt As New DataTable
            adptr.Fill(dt)
            dtGridRoomSpecifications.DataSource = dt
            adptr.Dispose()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Dim i As Integer = 0
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ListBox1.SelectionMode = SelectionMode.MultiExtended

        If Not ListBox1.Items.Contains(ListBox2.Text) Then
            ListBox1.Items.Add(ListBox2.Text)
        End If

        Dim i As Integer = ListBox1.Items.Count
        'ListBox1.Items.Add(ListBox2.Items.Item(3))

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If cboAssignedBedID.Text = "" Then
            Try
                con.Open()
                query = "delete from newRoomDetail where ROOM_ID='" + cboRoomID.Text + "'"
                Dim cmd As New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Records of Room Number:" + cboRoomID.Text + " is removed")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
            Try
                con.Open()
                query = "delete from newRoomSpecification where ROOM_ID='" + cboRoomID.Text + "'"
                Dim cmd As New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
            comboFill()
            DatagridLoad()
        Else
            MsgBox("Room Has already assigned to some students ,please shift them to another room first")
            Dim res = MsgBox("Are you want to further proceed", vbYesNo)
            If res = vbYes Then
                Me.Close()
                StudentDeparture.Show()
                StudentDeparture.MdiParent = Hostel_Management_System
            ElseIf res = vbNo Then
                Me.Show()
            End If
        End If
       
    End Sub

    Private Sub Button2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        con = connectTOhms()
        If cboBedID.Text = "" Then
            Try
                con.Open()
                query = "delete from newRoomDetail where ROOM_ID='" + cboRoomID.Text + "' and BED_ID='" + cboBedID.Text + "'"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        Else
            MsgBox("please select bed to be removed")
            cboBedID.Focus()
        End If
       
    End Sub
End Class