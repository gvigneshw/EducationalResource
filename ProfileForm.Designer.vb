<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfileForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblUniversity As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUniversity As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblSessionInfo As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUniversity = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUniversity = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSessionInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.lblTitle.Location = New System.Drawing.Point(150, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "User Profile"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUsername.Location = New System.Drawing.Point(50, 80)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 19)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFullName.Location = New System.Drawing.Point(50, 120)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(71, 19)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(50, 160)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 19)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'lblUniversity
        '
        Me.lblUniversity.AutoSize = True
        Me.lblUniversity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUniversity.Location = New System.Drawing.Point(50, 200)
        Me.lblUniversity.Name = "lblUniversity"
        Me.lblUniversity.Size = New System.Drawing.Size(70, 19)
        Me.lblUniversity.TabIndex = 4
        Me.lblUniversity.Text = "University"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUsername.Location = New System.Drawing.Point(180, 77)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(220, 25)
        Me.txtUsername.TabIndex = 5
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullName.Location = New System.Drawing.Point(180, 117)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(220, 25)
        Me.txtFullName.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(180, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(220, 25)
        Me.txtEmail.TabIndex = 7
        '
        'txtUniversity
        '
        Me.txtUniversity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUniversity.Location = New System.Drawing.Point(180, 197)
        Me.txtUniversity.Name = "txtUniversity"
        Me.txtUniversity.ReadOnly = True
        Me.txtUniversity.Size = New System.Drawing.Size(220, 25)
        Me.txtUniversity.TabIndex = 8
        '
        'lblSessionInfo
        '
        Me.lblSessionInfo.AutoSize = True
        Me.lblSessionInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSessionInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblSessionInfo.Location = New System.Drawing.Point(50, 240)
        Me.lblSessionInfo.Name = "lblSessionInfo"
        Me.lblSessionInfo.Size = New System.Drawing.Size(150, 15)
        Me.lblSessionInfo.TabIndex = 9
        Me.lblSessionInfo.Text = "Session: 0 minutes"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(128, 128, 128)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(300, 270)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(450, 330)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSessionInfo)
        Me.Controls.Add(Me.txtUniversity)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUniversity)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ProfileForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Profile - CHRIST University"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class
