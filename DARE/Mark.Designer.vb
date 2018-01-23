<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mark
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtdepid = New System.Windows.Forms.TextBox
        Me.txtempid = New System.Windows.Forms.TextBox
        Me.txtname1 = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.exitbutton = New System.Windows.Forms.Button
        Me.txtdepname = New System.Windows.Forms.TextBox
        Me.clear = New System.Windows.Forms.Button
        Me.txtname2 = New System.Windows.Forms.TextBox
        Me.go = New System.Windows.Forms.Button
        Me.txtdates = New System.Windows.Forms.TextBox
        Me.ok = New System.Windows.Forms.Button
        Me.combo1 = New System.Windows.Forms.TextBox
        Me.combo2 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtemployee = New System.Windows.Forms.TextBox
        Me.txti = New System.Windows.Forms.TextBox
        Me.mark = New System.Windows.Forms.Button
        Me.txtfirst = New System.Windows.Forms.TextBox
        Me.txtlast = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(438, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(438, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Employee ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter Today's Date (ddmmyyyy):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Attendance Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(136, 491)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Attendance Value"
        '
        'txtdepid
        '
        Me.txtdepid.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepid.Location = New System.Drawing.Point(634, 151)
        Me.txtdepid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdepid.Name = "txtdepid"
        Me.txtdepid.ReadOnly = True
        Me.txtdepid.Size = New System.Drawing.Size(180, 25)
        Me.txtdepid.TabIndex = 9
        '
        'txtempid
        '
        Me.txtempid.Location = New System.Drawing.Point(33, 163)
        Me.txtempid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtempid.Name = "txtempid"
        Me.txtempid.Size = New System.Drawing.Size(133, 25)
        Me.txtempid.TabIndex = 10
        '
        'txtname1
        '
        Me.txtname1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname1.Location = New System.Drawing.Point(634, 14)
        Me.txtname1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.ReadOnly = True
        Me.txtname1.Size = New System.Drawing.Size(180, 25)
        Me.txtname1.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(360, 381)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(310, 25)
        Me.DateTimePicker1.TabIndex = 13
        '
        'exitbutton
        '
        Me.exitbutton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbutton.ForeColor = System.Drawing.Color.Red
        Me.exitbutton.Location = New System.Drawing.Point(183, 327)
        Me.exitbutton.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(96, 38)
        Me.exitbutton.TabIndex = 17
        Me.exitbutton.Text = "EXIT"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'txtdepname
        '
        Me.txtdepname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepname.Location = New System.Drawing.Point(634, 97)
        Me.txtdepname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdepname.Name = "txtdepname"
        Me.txtdepname.ReadOnly = True
        Me.txtdepname.Size = New System.Drawing.Size(180, 25)
        Me.txtdepname.TabIndex = 19
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.Purple
        Me.clear.Image = Global.DARE.My.Resources.Resources.EESTD
        Me.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clear.Location = New System.Drawing.Point(91, 243)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(86, 68)
        Me.clear.TabIndex = 20
        Me.clear.Text = "CLEAR"
        Me.clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clear.UseVisualStyleBackColor = True
        '
        'txtname2
        '
        Me.txtname2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname2.Location = New System.Drawing.Point(634, 43)
        Me.txtname2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.ReadOnly = True
        Me.txtname2.Size = New System.Drawing.Size(180, 25)
        Me.txtname2.TabIndex = 21
        '
        'go
        '
        Me.go.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.go.Location = New System.Drawing.Point(217, 159)
        Me.go.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(96, 33)
        Me.go.TabIndex = 22
        Me.go.Text = "Go"
        Me.go.UseVisualStyleBackColor = True
        '
        'txtdates
        '
        Me.txtdates.Location = New System.Drawing.Point(33, 56)
        Me.txtdates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdates.MaxLength = 8
        Me.txtdates.Name = "txtdates"
        Me.txtdates.Size = New System.Drawing.Size(133, 25)
        Me.txtdates.TabIndex = 23
        '
        'ok
        '
        Me.ok.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ok.Location = New System.Drawing.Point(217, 49)
        Me.ok.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(96, 30)
        Me.ok.TabIndex = 24
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = True
        '
        'combo1
        '
        Me.combo1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo1.Location = New System.Drawing.Point(634, 205)
        Me.combo1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.combo1.Name = "combo1"
        Me.combo1.ReadOnly = True
        Me.combo1.Size = New System.Drawing.Size(180, 25)
        Me.combo1.TabIndex = 25
        '
        'combo2
        '
        Me.combo2.Location = New System.Drawing.Point(332, 494)
        Me.combo2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.combo2.Name = "combo2"
        Me.combo2.ReadOnly = True
        Me.combo2.Size = New System.Drawing.Size(233, 25)
        Me.combo2.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.go)
        Me.GroupBox1.Controls.Add(Me.txtdates)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtempid)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 214)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter These Values"
        '
        'txtemployee
        '
        Me.txtemployee.Location = New System.Drawing.Point(769, 382)
        Me.txtemployee.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtemployee.Name = "txtemployee"
        Me.txtemployee.Size = New System.Drawing.Size(36, 25)
        Me.txtemployee.TabIndex = 28
        Me.txtemployee.Visible = False
        '
        'txti
        '
        Me.txti.Location = New System.Drawing.Point(813, 382)
        Me.txti.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txti.Name = "txti"
        Me.txti.Size = New System.Drawing.Size(34, 25)
        Me.txti.TabIndex = 29
        Me.txti.Visible = False
        '
        'mark
        '
        Me.mark.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mark.ForeColor = System.Drawing.Color.Green
        Me.mark.Image = Global.DARE.My.Resources.Resources.DISK101
        Me.mark.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mark.Location = New System.Drawing.Point(275, 243)
        Me.mark.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mark.Name = "mark"
        Me.mark.Size = New System.Drawing.Size(86, 68)
        Me.mark.TabIndex = 16
        Me.mark.Text = "MARK"
        Me.mark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mark.UseVisualStyleBackColor = True
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(677, 382)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(37, 25)
        Me.txtfirst.TabIndex = 30
        Me.txtfirst.Visible = False
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(720, 382)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(30, 25)
        Me.txtlast.TabIndex = 31
        Me.txtlast.Visible = False
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(860, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtlast)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.txti)
        Me.Controls.Add(Me.txtemployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.combo2)
        Me.Controls.Add(Me.combo1)
        Me.Controls.Add(Me.txtname2)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.txtdepname)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.mark)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtname1)
        Me.Controls.Add(Me.txtdepid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mark Attendance Manually"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdepid As System.Windows.Forms.TextBox
    Friend WithEvents txtempid As System.Windows.Forms.TextBox
    Friend WithEvents txtname1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents mark As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents txtdepname As System.Windows.Forms.TextBox
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents txtname2 As System.Windows.Forms.TextBox
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents txtdates As System.Windows.Forms.TextBox
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents combo1 As System.Windows.Forms.TextBox
    Friend WithEvents combo2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtemployee As System.Windows.Forms.TextBox
    Friend WithEvents txti As System.Windows.Forms.TextBox
    Friend WithEvents txtfirst As System.Windows.Forms.TextBox
    Friend WithEvents txtlast As System.Windows.Forms.TextBox
End Class
