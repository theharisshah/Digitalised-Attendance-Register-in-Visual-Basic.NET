Public Class changepass

    Private Sub changepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Private Sub Change_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Change.Click
        While current.Text = My.Settings.Passid Or current.Text = My.Settings.Passid
            If current.Text = My.Settings.Passid Then
                If newpass.Text = confirmpass.Text Then
                    My.Settings.Passid = newpass.Text
                    My.Settings.Save()
                    If MessageBox.Show("Password changed Sucessfully", "Success!", MessageBoxButtons.OK) = DialogResult.OK Then
                        Me.Hide()
                        current.Text = ""
                        newpass.Text = ""
                        confirmpass.Text = ""
                    End If
                End If
            End If
            If current.Text = My.Settings.generalpass Then
                If newpass.Text = confirmpass.Text Then
                    My.Settings.generalpass = newpass.Text
                    My.Settings.Save()
                    If MessageBox.Show("Password changed Sucessfully", "Success!", MessageBoxButtons.OK) = DialogResult.OK Then
                        Me.Hide()
                        current.Text = ""
                        newpass.Text = ""
                        confirmpass.Text = ""
                    End If
                End If
            End If
        End While
        MsgBox("Incorrect Password!Please Provide Valid Password", "Error!", MsgBoxStyle.Critical)
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        current.Text = ""
        newpass.Text = ""
        confirmpass.Text = ""
    End Sub
End Class