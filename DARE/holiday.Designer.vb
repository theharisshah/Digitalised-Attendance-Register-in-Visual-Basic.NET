<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class holiday
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
        Me.yyyy = New System.Windows.Forms.ComboBox()
        Me.mm = New System.Windows.Forms.ComboBox()
        Me.dd = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sure = New System.Windows.Forms.Label()
        Me.yes = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.Button()
        Me.rollnum = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.txtlast = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'yyyy
        '
        Me.yyyy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.yyyy.FormattingEnabled = True
        Me.yyyy.Items.AddRange(New Object() {"2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.yyyy.Location = New System.Drawing.Point(167, 79)
        Me.yyyy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yyyy.Name = "yyyy"
        Me.yyyy.Size = New System.Drawing.Size(64, 21)
        Me.yyyy.TabIndex = 61
        '
        'mm
        '
        Me.mm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.mm.FormattingEnabled = True
        Me.mm.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.mm.Location = New System.Drawing.Point(105, 79)
        Me.mm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(58, 21)
        Me.mm.TabIndex = 60
        '
        'dd
        '
        Me.dd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.dd.FormattingEnabled = True
        Me.dd.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.dd.Location = New System.Drawing.Point(46, 79)
        Me.dd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(54, 21)
        Me.dd.TabIndex = 59
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dd)
        Me.GroupBox1.Controls.Add(Me.yyyy)
        Me.GroupBox1.Controls.Add(Me.mm)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(445, 130)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(357, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "O.K."
        '
        'ok
        '
        Me.ok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ok.Image = Global.DARE.My.Resources.Resources.Honda
        Me.ok.Location = New System.Drawing.Point(287, 63)
        Me.ok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(64, 43)
        Me.ok.TabIndex = 66
        Me.ok.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ok.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(43, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Enter The Date Which Is To Be Marked As A Holiday :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Month"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Day"
        '
        'sure
        '
        Me.sure.AutoSize = True
        Me.sure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sure.ForeColor = System.Drawing.Color.Red
        Me.sure.Location = New System.Drawing.Point(216, 157)
        Me.sure.Name = "sure"
        Me.sure.Size = New System.Drawing.Size(98, 15)
        Me.sure.TabIndex = 63
        Me.sure.Text = "ARE YOU SURE ?"
        '
        'yes
        '
        Me.yes.Location = New System.Drawing.Point(183, 174)
        Me.yes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(64, 24)
        Me.yes.TabIndex = 64
        Me.yes.Text = "YES"
        Me.yes.UseVisualStyleBackColor = True
        '
        'no
        '
        Me.no.Location = New System.Drawing.Point(292, 174)
        Me.no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(64, 24)
        Me.no.TabIndex = 65
        Me.no.Text = "NO"
        Me.no.UseVisualStyleBackColor = True
        '
        'rollnum
        '
        Me.rollnum.Location = New System.Drawing.Point(458, 157)
        Me.rollnum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rollnum.Name = "rollnum"
        Me.rollnum.Size = New System.Drawing.Size(86, 20)
        Me.rollnum.TabIndex = 66
        Me.rollnum.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 201)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 20)
        Me.DateTimePicker1.TabIndex = 67
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(458, 179)
        Me.txtfirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(86, 20)
        Me.txtfirst.TabIndex = 68
        Me.txtfirst.Visible = False
        '
        'txtlast
        '
        Me.txtlast.Location = New System.Drawing.Point(458, 201)
        Me.txtlast.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtlast.Name = "txtlast"
        Me.txtlast.Size = New System.Drawing.Size(86, 20)
        Me.txtlast.TabIndex = 69
        Me.txtlast.Visible = False
        '
        'holiday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 225)
        Me.Controls.Add(Me.txtlast)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rollnum)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.sure)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "holiday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mark A Holiday"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents yyyy As System.Windows.Forms.ComboBox
    Friend WithEvents mm As System.Windows.Forms.ComboBox
    Friend WithEvents dd As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ok As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sure As System.Windows.Forms.Label
    Friend WithEvents yes As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.Button
    Friend WithEvents rollnum As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfirst As System.Windows.Forms.TextBox
    Friend WithEvents txtlast As System.Windows.Forms.TextBox
End Class
