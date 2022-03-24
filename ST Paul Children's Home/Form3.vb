Public Class Form3
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        StaffBindingSource.AddNew()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        StaffBindingSource.RemoveCurrent()
    End Sub

    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Dim headShot As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        With OpenFileDialog1
            .Filter = "jpg, jpeg Image|*.jpg, jpeg|PNG Image|*.png|BMP Image|*.bmp|" & "All Files (*.*)|*.*"
            .Title = "Choose the image ....."
            .FilterIndex = 1
            .Multiselect = False
            .ValidateNames = True
            .InitialDirectory = "MyPictures"
            .RestoreDirectory = True

            If (.ShowDialog = DialogResult.OK) Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            Else
                Return
            End If
        End With
    End Sub

    Private Sub childBtn_Click(sender As Object, e As EventArgs) Handles childBtn.Click
        Dim ChildForm As Form2 = New Form2
        ChildForm.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homeBtn.Enabled = False
        staffBtn.Enabled = False
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If searchTxt.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            StaffBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & searchTxt.Text & "')" &
                "OR (Name LIKE '" & searchTxt.Text & "')"
            If StaffBindingSource.Count <> 0 Then
                With StaffDataGridView
                    .DataSource = StaffBindingSource

                End With
            Else
                MsgBox("The search item was not found")
                StaffBindingSource.Filter = Nothing
            End If
        End If
    End Sub

    Private Sub notFound()

    End Sub
End Class