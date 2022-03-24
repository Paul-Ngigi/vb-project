Imports System.Data.OleDb

Module connection
    Public conn As OleDbConnection

    Public connStr As String = System.Environment.CurrentDirectory.ToString & "\homedatabase.accdb"

    Public Sub ConB()
        Try
            conn = New OleDbConnection("Microsoft.ACE.OLEDB.12.0; Data Source = " & connStr & "")
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
