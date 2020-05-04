Imports System.Data
Imports System.Drawing
Imports System.Data.OleDb
Public Class dynamiceDemo
    Dim query As String
    Dim i As Integer
    Private Sub dynamiceDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddElement()
    End Sub
    Private Sub AddElement()
        Dim line As Integer = 1
        Dim con As New OleDbConnection
        '    con = connecToAttendance()
        Try
            con.Open()
            query = "select * from student"
            Dim cmd As New OleDbCommand(query, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader
            i = 1
            'Dim grpBox As New GroupBox
            'Me.Controls.Add(grpBox)
            'grpBox.Size = New Size(300, 200)
            'grpBox.Text = "Take attendance"
            While reader.Read
                Dim lbl As New Label
                lbl.AutoSize = New AutoSizeMode()
                lbl.Location = New System.Drawing.Point(50, line * 25)
                lbl.Text = reader(1).ToString
                lbl.Name = reader(0).ToString
                Me.Controls.Add(lbl)
                ' grpBox.Controls.Add(lbl)

                Dim CHK As New CheckBox
                CHK.Location = New System.Drawing.Point(200, line * 25)
                CHK.Size = New Size(150, 20)
                CHK.Name = reader(0).ToString
                Me.Controls.Add(CHK)
                '  grpBox.Controls.Add(CHK)
                'AddHandler CHK.CheckStateChanged, AddressOf checkbox_checked
                'AddHandler CHK.CheckStateChanged, AddressOf btnAttendance_Click
                i = i + 1
                line = line + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub checkbox_checked(ByVal sender As Object, ByVal e As Object)
        Dim mycheck As CheckBox = TryCast(sender, CheckBox)
    End Sub
    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendance.Click
        Dim con As New OleDbConnection
        '      con = connecToAttendance()
        Try
            con.Open()
            For Each mycheck In Me.Controls.OfType(Of CheckBox)()
                If mycheck.Checked = True Then
                    query = "insert into SATTENDANCE (S_ID,ATTENDANCE,A_DATE) values (?,?,?)"
                    Dim cmd As New OleDbCommand(query, con)
                    cmd.Parameters.AddWithValue("@SID", mycheck.Name)
                    cmd.Parameters.AddWithValue("@ATTEND", "present")
                    cmd.Parameters.AddWithValue("@ADATE", dtPickerAttend.Value)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MessageBox.Show(mycheck.Name + "present")
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class