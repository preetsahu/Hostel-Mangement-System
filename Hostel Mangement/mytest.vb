Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class mytest
    ' Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hms\hms\Database1.accdb")
    Dim cmd As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim query As String
        Dim conn As New OleDbConnection
        conn = connect()
        Try
            conn.Open()
            MsgBox("connected")
            Dim myfile As New FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read)
            Dim myFilereader As New BinaryReader(myfile)
            Dim mybyteImage(myfile.Length) As Byte
            myFilereader.Read(mybyteImage, 0, myfile.Length)
            myFilereader.Close()
            myfile.Close()
            query = "insert into PICTEST (USER_ID,PHOTO) VALUES (@id,@pic)"
            cmd.CommandText = query
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@id", Val(TextBox1.Text))
            cmd.Parameters.AddWithValue("@pic", mybyteImage)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully inserted")
            conn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub mytest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        testpic2.Show()
    End Sub
End Class