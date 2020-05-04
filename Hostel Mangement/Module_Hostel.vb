Imports System.Data
Imports System.Data.OleDb

Module Module_Hostel
    Private myConnection As OleDb.OleDbConnection
    'Private myConnection2 As OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public adptr As OleDb.OleDbDataAdapter
    Dim reader As OleDb.OleDbDataReader                   'variable used to show login authetication befor loading form
    Public loginAuthetication As Integer = 0
    Public Function connect()
        myConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hms\hms\Database1.accdb")
        Return myConnection
    End Function
    Public Function connectTOhms()
        Dim myConnection2 As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\hms\hms.accdb")
        Return myConnection2
    End Function
    Public Function connectoattendance()
        Dim myconnection2 As New oledb.oledbconnection("provider=microsoft.ace.oledb.12.0;data source=e:\databse.accdb")
        Return myconnection2
    End Function
End Module


