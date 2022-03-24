Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_St_Paul_Children_s_HomeDataSet.Children' table. You can move, or remove it, as needed.
        Me.ChildrenTableAdapter.Fill(Me._St_Paul_Children_s_HomeDataSet.Children)
        'TODO: This line of code loads data into the '_St_Paul_Children_s_HomeDataSet.Children' table. You can move, or remove it, as needed.
        Me.ChildrenTableAdapter.Fill(Me._St_Paul_Children_s_HomeDataSet.Children)
        homeBtn.Enabled = False
        childBtn.Enabled = False
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

    Private Sub ChildrenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ChildrenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._St_Paul_Children_s_HomeDataSet)

    End Sub

    Private Sub ChildrenBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ChildrenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ChildrenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._St_Paul_Children_s_HomeDataSet)

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ChildrenBindingSource.AddNew()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ChildrenBindingSource.RemoveCurrent()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        cExit1.ExitSystem()
    End Sub

    Private Sub staffBtn_Click(sender As Object, e As EventArgs) Handles staffBtn.Click
        Dim StaffForm As Form3 = New Form3
        StaffForm.Show()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If searchTxt.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            ChildrenBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & searchTxt.Text & "')" & _
                "OR (Name LIKE '" & searchTxt.Text & "')"
            If ChildrenBindingSource.Count <> 0 Then
                With ChildrenDataGridView
                    .DataSource = ChildrenBindingSource

                End With
            Else
                MsgBox("The search item was not found")
                ChildrenBindingSource.Filter = Nothing
            End If
        End If
    End Sub

    Private Sub notFound()

    End Sub
End Class