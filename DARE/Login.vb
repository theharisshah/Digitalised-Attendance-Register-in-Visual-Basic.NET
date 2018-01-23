

Public Class Login
    

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        
        If Userbox.Text = My.Settings.Userid Or Userbox.Text = My.Settings.generalid Then
            If PasswordTextBox.Text = My.Settings.Passid Or PasswordTextBox.Text = My.Settings.generalpass Then
                mainfrm.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password!Please enter valid password", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Incorrect Username!Please enter a valid username", MsgBoxStyle.Critical)
        End If
        If Userbox.Text = My.Settings.generalid And PasswordTextBox.Text = My.Settings.generalpass Then
            mainfrm.EditMemberToolStripMenuItem.Enabled = False
            mainfrm.AddMemberToolStripMenuItem.Enabled = False
            mainfrm.RemoveMemberToolStripMenuItem.Enabled = False
            mainfrm.MarkAttendanceToolStripMenuItem.Enabled = False
            mainfrm.SettingsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'userbox.Items.Add(My.Settings.Userid)
        'userbox.Items.Add(My.Settings.generalid)
        My.Settings.Reload()
    End Sub


    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub Userbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
