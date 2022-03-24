Public Class cExit1
    Public Shared Function ExitSystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit", "St Paul Children's Home Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Function
End Class
