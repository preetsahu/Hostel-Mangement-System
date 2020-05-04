Imports System.Data.OleDb
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Design.ToolboxItem
Public Class RoomView
    Dim i As Integer = 0
    Dim query As String
    Dim rname As String

    Private Sub RoomView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        courseNameload()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        Dim LINE As Integer = 1
        Try
            con.Open()
            query = "select * from newRoomDetail where AVAIL='YES'"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            Dim space As Integer
            space = 70
            While reader.Read
                If i Mod 3 = 1 Then
                    space = 30
                    LINE = LINE + 1
                ElseIf i Mod 3 = 2 Then
                    space = 350
                Else
                    space = 670
                End If
                Dim lblRoom As New MetroFramework.Controls.MetroButton
                lblRoom.Name = "lbl" & i
                lblRoom.Size = New Size(220, 25)
                ' lblRoom.AutoSize = New AutoSizeMode()
                lblRoom.Location = New Point(space, LINE * 30)
                lblRoom.Text = reader(0).ToString + " BED ID : " + reader(1).ToString + " Available Status : " + reader(2).ToString + " "
                lblRoom.BackColor = Color.Green
                lblRoom.ForeColor = Color.Yellow
                TabPage1.Controls.Add(lblRoom)
                i = i + 1
                ' MsgBox(reader(2).ToString)
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    ''-''''''''''''''''''''''''''''''''''''''''''''' clear controls in form -''''''''''''''''''''''''''''''''''
    Private Sub controlClear()
        For Each btn In TabPage3.Controls.OfType(Of MetroFramework.Controls.MetroButton)()
            btn.Hide()
        Next
    End Sub
    Private Sub btnClickme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClickme.Click
        Dim con As OleDbConnection
        con = connectTOhms()
        Dim LINE As Integer = 1
        Try
            con.Open()
            query = "SELECT ra.ROOM_ID,ra.NAME,ra.BED_ID,ra.CLASS,ra.COURSE_YEAR FROM RoomAllotment ra INNER JOIN newRoomDetail nrd ON (nrd.BED_ID = ra.BED_ID) AND (ra.ROOM_ID = nrd.ROOM_ID);"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            Dim space1 As Integer
            space1 = 70

            While reader.Read

                If i Mod 3 = 1 Then
                    space1 = 40
                    LINE = LINE + 1
                ElseIf i Mod 3 = 2 Then
                    space1 = 350
                Else
                    space1 = 670
                End If


                Dim lblStuAllotedRoom As New MetroFramework.Controls.MetroButton
                lblStuAllotedRoom.Name = "lbl" & i
                lblStuAllotedRoom.Size = New Size(100, 30)
                '  lblStuAllotedRoom.AutoSize = New AutoSizeMode()
                lblStuAllotedRoom.Location = New Point(space1 + 20, LINE * 50)
                lblStuAllotedRoom.Text = reader(0).ToString + " /BED_ID: " + reader(2).ToString '+ "|| Student Name :" + reader(1).ToString + " Class: " + reader(3).ToString
                lblStuAllotedRoom.BackColor = Color.Transparent
                lblStuAllotedRoom.ForeColor = Color.Red
                TabPage2.Controls.Add(lblStuAllotedRoom)
                ' MsgBox(reader(2).ToString)


                '-''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim lblStu1 As New MetroFramework.Controls.MetroButton
                lblStu1.Name = "lbl" & i
                lblStu1.Size = New Size(300, 30)
                'lblStu1.AutoSize = New AutoSizeMode()
                lblStu1.Location = New Point(space1, LINE * 70)
                lblStu1.Text = "|| Student Name :" + reader(1).ToString + " Class: " + reader(3).ToString
                lblStu1.BackColor = Color.Transparent
                lblStu1.ForeColor = Color.Red
                TabPage2.Controls.Add(lblStu1)

                i = i + 1
                '  LINE = LINE + 1


            End While
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
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
    Dim qc As String
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
    Dim StuID As Integer
    Dim LINE As Integer
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        controlClear()
        Dim con As OleDbConnection
        con = connectTOhms()
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
            query = "SELECT ra.ROOM_ID,ra.NAME,ra.BED_ID,ra.CLASS,ra.COURSE_YEAR FROM RoomAllotment ra INNER JOIN newRoomDetail nrd ON (nrd.BED_ID = ra.BED_ID) AND (ra.ROOM_ID = nrd.ROOM_ID) WHERE S_ID LIKE ? ;"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", StuID)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            While reader.Read
                Dim lblStuAllotedRoom As New MetroFramework.Controls.MetroButton
                lblStuAllotedRoom.Name = "lbl" & i
                lblStuAllotedRoom.Size = New Size(400, 30)
                ' lblStuAllotedRoom.AutoSize = New AutoSizeMode()
                lblStuAllotedRoom.Location = New Point(200, LINE * 100)
                lblStuAllotedRoom.Text = reader(0).ToString + " BED_ID: " + reader(2).ToString + " Student Name :" + reader(1).ToString + " Class: " + reader(3).ToString
                lblStuAllotedRoom.BackColor = Color.Gold
                lblStuAllotedRoom.ForeColor = Color.Black
                'lblStuAllotedRoom.Font.SizeInPoints = 10
                TabPage3.Controls.Add(lblStuAllotedRoom)
                i = i + 1
                LINE = LINE + 1
                ' MsgBox(reader(2).ToString)
            End While
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class