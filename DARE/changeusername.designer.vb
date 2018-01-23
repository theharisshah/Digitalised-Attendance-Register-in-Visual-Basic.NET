<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeusername
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
        Me.chngbtn = New System.Windows.Forms.Button()
        Me.cnclbtn = New System.Windows.Forms.Button()
        Me.olduser = New System.Windows.Forms.ComboBox()
        Me.newuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chngbtn
        '
        Me.chngbtn.Location = New System.Drawing.Point(118, 147)
        Me.chngbtn.Name = "chngbtn"
        Me.chngbtn.Size = New System.Drawing.Size(75, 23)
        Me.chngbtn.TabIndex = 0
        Me.chngbtn.Text = "&Change"
        Me.chngbtn.UseVisualStyleBackColor = True
        '
        'cnclbtn
        '
        Me.cnclbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cnclbtn.Location = New System.Drawing.Point(233, 147)
        Me.cnclbtn.Name = "cnclbtn"
        Me.cnclbtn.Size = New System.Drawing.Size(75, 23)
        Me.cnclbtn.TabIndex = 1
        Me.cnclbtn.Text = "Cancel"
        Me.cnclbtn.UseVisualStyleBackColor = True
        '
        'olduser
        '
        Me.olduser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.olduser.FormattingEnabled = True
        Me.olduser.Location = New System.Drawing.Point(135, 23)
        Me.olduser.Name = "olduser"
        Me.olduser.Size = New System.Drawing.Size(173, 21)
        Me.olduser.TabIndex = 2
        '
        'newuser
        '
        Me.newuser.Location = New System.Drawing.Point(135, 82)
        Me.newuser.Name = "newuser"
        Me.newuser.Size = New System.Drawing.Size(173, 20)
        Me.newuser.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Current Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New Username"
        '
        'changeusername
        '
        Me.AcceptButton = Me.chngbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cnclbtn
        Me.ClientSize = New System.Drawing.Size(350, 182)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newuser)
        Me.Controls.Add(Me.olduser)
        Me.Controls.Add(Me.cnclbtn)
        Me.Controls.Add(Me.chngbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "changeusername"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "changeusername"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chngbtn As System.Windows.Forms.Button
    Friend WithEvents cnclbtn As System.Windows.Forms.Button
    Friend WithEvents olduser As System.Windows.Forms.ComboBox
    Friend WithEvents newuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
