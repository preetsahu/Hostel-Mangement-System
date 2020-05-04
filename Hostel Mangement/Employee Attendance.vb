Public Class Employee_Attendance

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Employee_Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmsDataSet.EmployeeAttendence' table. You can move, or remove it, as needed.
        Me.EmployeeAttendenceTableAdapter.Fill(Me.HmsDataSet.EmployeeAttendence)

    End Sub
End Class