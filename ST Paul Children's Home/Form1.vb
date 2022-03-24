Public Class Form1
    Private Sub childBtn_Click(sender As Object, e As EventArgs) Handles childBtn.Click
        Dim ChildForm As Form2 = New Form2
        ChildForm.Show()
    End Sub

    Private Sub staffBtn_Click(sender As Object, e As EventArgs) Handles staffBtn.Click
        Dim StaffForm As Form3 = New Form3
        StaffForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'St_Paul_LoginDataSet.Authentication' table. You can move, or remove it, as needed.
        Me.AuthenticationTableAdapter.Fill(Me.St_Paul_LoginDataSet.Authentication)
        staffBtn.Enabled = False
        childBtn.Enabled = False
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        cExit1.ExitSystem()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim log = Me.AuthenticationTableAdapter.userdetails(Me.usrnameTxt.Text, Me.usrnameTxt.Text)

        If log Is Nothing Then
            usrnameTxt.Clear()
            usrnameTxt.Clear()
            MessageBox.Show("Invalid details entered", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            usrnameTxt.Focus()
        Else
            MessageBox.Show("Welcome", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
            childBtn.Enabled = True
            staffBtn.Enabled = True
        End If
    End Sub

    Private Sub AuthenticationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthenticationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AuthenticationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.St_Paul_LoginDataSet)

    End Sub
End Class
