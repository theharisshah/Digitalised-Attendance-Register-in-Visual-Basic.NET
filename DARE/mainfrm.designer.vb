<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainfrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByRollNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAttendanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkingDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakHolidayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMonthlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewWeeklyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllAttendanceDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Azure
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.MarkAttendanceToolStripMenuItem, Me.ReportGenerationToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 25)
        Me.MenuStrip1.TabIndex = 0
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMemberToolStripMenuItem, Me.RemoveMemberToolStripMenuItem, Me.EditMemberToolStripMenuItem, Me.SearchMemberToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitApplicationToolStripMenuItem, Me.ToolStripSeparator1})
        Me.ManageToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        '
        'RemoveMemberToolStripMenuItem
        '
        Me.RemoveMemberToolStripMenuItem.Name = "RemoveMemberToolStripMenuItem"
        Me.RemoveMemberToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RemoveMemberToolStripMenuItem.Text = "Remove Member"
        '
        'EditMemberToolStripMenuItem
        '
        Me.EditMemberToolStripMenuItem.Name = "EditMemberToolStripMenuItem"
        Me.EditMemberToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EditMemberToolStripMenuItem.Text = "Edit Member"
        '
        'SearchMemberToolStripMenuItem
        '
        Me.SearchMemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByRollNumberToolStripMenuItem, Me.ByDepartmentToolStripMenuItem, Me.ViewAllToolStripMenuItem})
        Me.SearchMemberToolStripMenuItem.Name = "SearchMemberToolStripMenuItem"
        Me.SearchMemberToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SearchMemberToolStripMenuItem.Text = "Search Member"
        '
        'ByRollNumberToolStripMenuItem
        '
        Me.ByRollNumberToolStripMenuItem.Name = "ByRollNumberToolStripMenuItem"
        Me.ByRollNumberToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ByRollNumberToolStripMenuItem.Text = "by Roll Number"
        '
        'ByDepartmentToolStripMenuItem
        '
        Me.ByDepartmentToolStripMenuItem.Name = "ByDepartmentToolStripMenuItem"
        Me.ByDepartmentToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ByDepartmentToolStripMenuItem.Text = "by Department"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ExitApplicationToolStripMenuItem.Text = "Exit Application"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'MarkAttendanceToolStripMenuItem
        '
        Me.MarkAttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkAttendanceToolStripMenuItem1, Me.MakHolidayToolStripMenuItem})
        Me.MarkAttendanceToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkAttendanceToolStripMenuItem.Name = "MarkAttendanceToolStripMenuItem"
        Me.MarkAttendanceToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.MarkAttendanceToolStripMenuItem.Text = "Mark Attendance"
        '
        'MarkAttendanceToolStripMenuItem1
        '
        Me.MarkAttendanceToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkingDayToolStripMenuItem, Me.HolidayToolStripMenuItem})
        Me.MarkAttendanceToolStripMenuItem1.Name = "MarkAttendanceToolStripMenuItem1"
        Me.MarkAttendanceToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.MarkAttendanceToolStripMenuItem1.Text = "Mark Attendance"
        '
        'WorkingDayToolStripMenuItem
        '
        Me.WorkingDayToolStripMenuItem.Name = "WorkingDayToolStripMenuItem"
        Me.WorkingDayToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.WorkingDayToolStripMenuItem.Text = "Mark"
        '
        'HolidayToolStripMenuItem
        '
        Me.HolidayToolStripMenuItem.Name = "HolidayToolStripMenuItem"
        Me.HolidayToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HolidayToolStripMenuItem.Text = "Edit"
        '
        'MakHolidayToolStripMenuItem
        '
        Me.MakHolidayToolStripMenuItem.Name = "MakHolidayToolStripMenuItem"
        Me.MakHolidayToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.MakHolidayToolStripMenuItem.Text = "Mark Holiday"
        '
        'ReportGenerationToolStripMenuItem
        '
        Me.ReportGenerationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewMonthlyToolStripMenuItem, Me.ViewWeeklyToolStripMenuItem, Me.ShowAllAttendanceDataToolStripMenuItem})
        Me.ReportGenerationToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportGenerationToolStripMenuItem.Name = "ReportGenerationToolStripMenuItem"
        Me.ReportGenerationToolStripMenuItem.Size = New System.Drawing.Size(140, 21)
        Me.ReportGenerationToolStripMenuItem.Text = "Report Generation"
        '
        'ViewMonthlyToolStripMenuItem
        '
        Me.ViewMonthlyToolStripMenuItem.Name = "ViewMonthlyToolStripMenuItem"
        Me.ViewMonthlyToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ViewMonthlyToolStripMenuItem.Text = "Daily Report"
        '
        'ViewWeeklyToolStripMenuItem
        '
        Me.ViewWeeklyToolStripMenuItem.Name = "ViewWeeklyToolStripMenuItem"
        Me.ViewWeeklyToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ViewWeeklyToolStripMenuItem.Text = "Monthly Report"
        '
        'ShowAllAttendanceDataToolStripMenuItem
        '
        Me.ShowAllAttendanceDataToolStripMenuItem.Name = "ShowAllAttendanceDataToolStripMenuItem"
        Me.ShowAllAttendanceDataToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ShowAllAttendanceDataToolStripMenuItem.Text = "Show All Attendance Data"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeUsernameToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangeUsernameToolStripMenuItem
        '
        Me.ChangeUsernameToolStripMenuItem.Name = "ChangeUsernameToolStripMenuItem"
        Me.ChangeUsernameToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ChangeUsernameToolStripMenuItem.Text = "Change Username"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.AboutApplicationToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'AboutApplicationToolStripMenuItem
        '
        Me.AboutApplicationToolStripMenuItem.Name = "AboutApplicationToolStripMenuItem"
        Me.AboutApplicationToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AboutApplicationToolStripMenuItem.Text = "About Application"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 334)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "mainfrm"
        Me.Text = "Welcome to Digitalized Attendance Register Environment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkAttendanceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MakHolidayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportGenerationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMonthlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewWeeklyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeUsernameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ByRollNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkingDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllAttendanceDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
