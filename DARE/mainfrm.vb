Public Class mainfrm

    Private Sub mainfrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mainfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ExitApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Login.Show()
        Login.userbox.Text = ""
        Login.PasswordTextBox.Text = ""

    End Sub

    Private Sub ChangeUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUsernameToolStripMenuItem.Click
        changeusername.Show()


    End Sub

    Private Sub MarkHolidayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakHolidayToolStripMenuItem.Click
        holiday.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        changepass.Show()

    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMemberToolStripMenuItem.Click
        Newmembers.Show()
    End Sub

    Private Sub ViewWeeklyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewWeeklyToolStripMenuItem.Click
        'MonthlyReport.Show()
    End Sub

    Private Sub EditMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMemberToolStripMenuItem.Click
        'Editmembers.Show()
    End Sub

    Private Sub RemoveMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveMemberToolStripMenuItem.Click
        deletemembers.Show()
    End Sub

    Private Sub ByRollNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByRollNumberToolStripMenuItem.Click
        Byroll.Show()
    End Sub

    Private Sub ByDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDepartmentToolStripMenuItem.Click
        bydept.Show()
    End Sub

    Private Sub WorkingDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkingDayToolStripMenuItem.Click
        Mark.Show()
    End Sub

    Private Sub HolidayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayToolStripMenuItem.Click
        'editatten.Show()
    End Sub

    Private Sub ViewMonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewMonthlyToolStripMenuItem.Click
        'DailyReport.Show()
    End Sub

    Private Sub ShowAllAttendanceDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllAttendanceDataToolStripMenuItem.Click
        'AttenData.Show()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllToolStripMenuItem.Click
        showall.Show()
    End Sub
End Class
