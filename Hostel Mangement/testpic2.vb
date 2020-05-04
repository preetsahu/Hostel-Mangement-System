Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class testpic2
    '  Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=c:\hms\hms\database1.accdb")
    ' Dim cmd As New OleDb.OleDbCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPIC.Click
        If DataGridView1.RowCount >= 0 Then
            'data grid store first column then row i.e. [j,i] format
            'currentRow used to selcet the value of current clicked row
            Dim myimagebyte() As Byte = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
            Dim memStream As New MemoryStream(myimagebyte)
            PictureBox1.Image = Image.FromStream(memStream)            'load picture for memory stream
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
    End Sub

    Private Sub testpic2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection
        conn = connect()
        Try
            conn.Open()
            MsgBox("suceefull")
            Dim query As String
            query = "select * from PICTEST"
            Dim adptr As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable
            adptr.Fill(dt)
            Me.DataGridView1.DataSource = dt
            adptr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class