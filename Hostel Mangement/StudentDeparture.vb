Imports System.Data.OleDb
Public Class StudentDeparture
    Dim query As String
    Private Sub StudentDeparture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            query = "select distinct[COURSE_NAME] from CourseDetails"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboClass.DataSource = dt
            cboClass.DisplayMember = "COURSE_NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboClass.Text = ""
        cboYear.Text = ""
    End Sub
    Public Sub MydataGridRefresh()
        'Dim con As New OleDbConnection
        'con = connectTOhms()
        'Try
        '    con.Open()
        '    query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME=?"
        '    Dim cmd As New OleDbCommand(query, con)
        '    cmd.Parameters.AddWithValue("?", cboClass.Text)
        '    Dim adptr As New OleDbDataAdapter(query, con)
        '    Dim dt As New DataTable
        '    adptr.Fill(dt)
        '    cboYear.DataSource = dt
        '    cboYear.DisplayMember = "COURSE_NAME"
        '    adptr.Dispose()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'Finally
        '    con.Close()
        'End Try
    End Sub
    '--------------------------------------------- join 1--------------------------------------------------------------------------------
    Private Sub JoinRooomAllotAndnewRoomDetail()
        Dim con As New OleDbConnection()
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT ra.S_ID,ra.NAME,ra.BED_ID,ra.ROOM_ID FROM newRoomDetail nrd INNER JOIN RoomAllotment ra ON (ra.BED_ID = nrd.BED_ID) AND (nrd.ROOM_ID = ra.ROOM_ID) WHERE RA.NAME='" + cboStudentName.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                TXTsid.Text = reader(0).ToString
                txtBedID.Text = reader(2).ToString
                txtRoomID.Text = reader(3).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        txtBedID.Text = ""
        txtRoomID.Text = ""
        TXTsid.Text = ""
        txtRoomID.Text = ""
        txtBedID.Text = ""
        cboStudentName.Text = ""
        viewStudent()
    End Sub
    Private Sub viewStudent()
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where CLASS like '" + cboClass.Text + "' and COURSE_YEAR like '" + cboYear.Text + "' and ROOM_ID <> '' AND BED_ID <> '' "
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboStudentName.DataSource = dt
            cboStudentName.DisplayMember = "NAME"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub cboClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClass.SelectedIndexChanged
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "SELECT CD.COURSE_ID,CD.COURSE_NAME,CS.COURSE_SPECIFICATION FROM CourseDetails CD INNER JOIN CourseSpecification CS ON CD.COURSE_ID =CS.COURSE_ID WHERE CD.COURSE_NAME='" + cboClass.Text + "'"
            Dim adptr As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adptr.Fill(dt)
            cboYear.DataSource = dt
            cboYear.DisplayMember = "COURSE_SPECIFICATION"
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()
        End Try
        cboYear.Text = ""
        cboStudentName.Text = ""
        txtBedID.Text = ""
        txtRoomID.Text = ""
        TXTsid.Text = ""
    End Sub

    Private Sub cboStudentName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStudentName.SelectedIndexChanged
        txtBedID.Text = ""
        txtRoomID.Text = ""
        TXTsid.Text = ""
        Dim con As New OleDbConnection
        con = connectTOhms()
        Try
            con.Open()
            query = "select * from RoomAllotment where NAME like '" + cboStudentName.Text + "'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            While reader.Read
                txtBedID.Text = reader(16).ToString
                txtRoomID.Text = reader(15).ToString
                TXTsid.Text = reader(0).ToString
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeparture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeparture.Click
        Dim con As New OleDbConnection()
        con = connectTOhms()
        Dim response = MsgBox("Are you want to depatch the student", vbYesNo)
        If response = vbNo Then
        ElseIf response = vbYes Then
            Try
                con.Open()
                query = "update RoomAllotment set ROOM_ID='' ,BED_ID ='' ,Depatcher_Date=? where S_ID like ?"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", dtDepartDate.Text)
                cmd.Parameters.AddWithValue("?", Val(TXTsid.Text))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Student : " + cboStudentName.Text + "left the room : " + txtRoomID.Text + " from bed id :" + txtBedID.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

            Try
                con.Open()
                query = "update newRoomDetail set AVAIL=? where ROOM_ID like ? and BED_ID like ?"
                Dim cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", "YES")
                cmd.Parameters.AddWithValue("?", txtRoomID.Text)
                cmd.Parameters.AddWithValue("?", txtBedID.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox(" Student :" + cboStudentName.Text + " has been check out from Room :" + txtRoomID.Text + " and bed id : " + txtBedID.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
        viewStudent()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ViewStudentDetails.Show()
        ViewStudentDetails.MdiParent = Hostel_Management_System
        ViewStudentDetails.Dock = DockStyle.Fill
    End Sub
End Class