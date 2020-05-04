Public Class rptClassWiseStudentView

    Private Sub rptClassWiseStudentView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.RoomAllotment' table. You can move, or remove it, as needed.
        Me.RoomAllotmentTableAdapter.Fill(Me.DataSet2.RoomAllotment)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class