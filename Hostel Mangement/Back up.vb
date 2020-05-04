Imports System.IO
Imports System.Data
Public Class Back_up
    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        Try
            Dim dlg As New OpenFileDialog
            dlg.InitialDirectory = Application.StartupPath
            'dlg.InitialDirectory = "C:\Program Files\Default Company Name\ePolitices"

            dlg.Filter = "Microsoft Access Database(2002-2003) (*.mdb)|*.mdb|Microsoft Access Database(2007-2009) (*.accdb)|*.accdb"
            ' If you want to keep default extensiion *.mdb then FilterIndex = 1 or if you want to keep default extension *.accdb then FilterIndex=2
            dlg.FilterIndex = 2

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                mtSource.Text = dlg.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Try
            Dim folder As New FolderBrowserDialog
            If folder.ShowDialog() = Windows.Forms.DialogResult.OK Then
                mTdes.Text = folder.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
        Try
            If mtSource.Text = "" Then
                MessageBox.Show("Please Select Database Source.")
                MetroButton1.Focus()
                Exit Sub
            End If
            If mTdes.Text = "" Then
                MessageBox.Show("Please Select Database Destination.")
                MetroButton2.Focus()
                Exit Sub
            End If
            If mTfile.Text = "" Then
                MessageBox.Show("Please Enter File Name.")
                mTdes.Focus()
                Exit Sub
            End If

            Dim ext As String
            ext = mtSource.Text.Substring(mtSource.Text.IndexOf(".") + 1)               ''''gets extension of file 
            File.Copy(mtSource.Text, mTdes.Text & "\" & mTfile.Text & "." & ext)            ''''copy the file to destination
            MessageBox.Show("Successfully Backup Database.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Back_up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If loginAuthetication = 1 Then
            Me.Show()
            LoginForm.Hide()
        ElseIf loginAuthetication = 0 Then
            LoginForm.Show()
            Me.Hide()
        End If

    End Sub

End Class