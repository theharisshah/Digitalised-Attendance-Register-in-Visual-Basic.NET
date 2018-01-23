Public Class changeusername

    Private Sub chngbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chngbtn.Click
        If olduser.Text = My.Settings.Userid Then
            My.Settings.Userid = newuser.Text
            My.Settings.Save()
            If MessageBox.Show("Username changed Sucessfully", "Success!", MessageBoxButtons.OK) = DialogResult.OK Then
                Me.Hide()
            End If
        End If
        If olduser.Text = My.Settings.generalid Then
            My.Settings.generalid = newuser.Text
            My.Settings.Save()
            If MessageBox.Show("Username changed Sucessfully", "Success!", MessageBoxButtons.OK) = DialogResult.OK Then
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub changeusername_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        olduser.Items.Add(My.Settings.Userid)
        olduser.Items.Add(My.Settings.generalid)
    End Sub

    Private Sub cnclbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cnclbtn.Click
        Me.Hide()
    End Sub
End Class