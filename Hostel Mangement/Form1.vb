Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection
        conn = connect()
        Try
            conn.Open()
            Dim myquery As String
            myquery = "select * from personal_info where class_name like '" + ComboBox1.Text + "'"
            Dim adptr As New OleDbDataAdapter(myquery, conn)
            Dim dt As New DataTable
            adptr.Fill(dt)
            DataGridView1.DataSource = dt
            adptr.Dispose()
            MsgBox("successfully done")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class