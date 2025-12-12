<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents pnlRegister As System.Windows.Forms.Panel
    Friend WithEvents lblRegisterMode As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCaptcha As System.Windows.Forms.Label
    Friend WithEvents txtCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents btnRefreshCaptcha As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.lblRegisterMode = New System.Windows.Forms.LinkLabel()
        Me.lblCaptcha = New System.Windows.Forms.Label()
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.btnRefreshCaptcha = New System.Windows.Forms.Button()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(107, 37)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(393, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resource Sharing Platform"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.lblSubtitle.Location = New System.Drawing.Point(213, 80)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(145, 23)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "CHRIST University"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUser.Location = New System.Drawing.Point(107, 148)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(87, 23)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPass.Location = New System.Drawing.Point(107, 197)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(80, 23)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblFullName.Location = New System.Drawing.Point(107, 12)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(87, 23)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.Location = New System.Drawing.Point(107, 62)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 23)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUser.Location = New System.Drawing.Point(267, 144)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(292, 30)
        Me.txtUser.TabIndex = 4
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPass.Location = New System.Drawing.Point(267, 193)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(292, 30)
        Me.txtPass.TabIndex = 5
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFullName.Location = New System.Drawing.Point(267, 9)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(292, 30)
        Me.txtFullName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(267, 58)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 30)
        Me.txtEmail.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(267, 308)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(133, 43)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(427, 418)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(133, 43)
        Me.btnRegister.TabIndex = 8
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        Me.btnRegister.Visible = False
        '
        'pnlRegister
        '
        Me.pnlRegister.Controls.Add(Me.lblFullName)
        Me.pnlRegister.Controls.Add(Me.txtFullName)
        Me.pnlRegister.Controls.Add(Me.lblEmail)
        Me.pnlRegister.Controls.Add(Me.txtEmail)
        Me.pnlRegister.Location = New System.Drawing.Point(0, 234)
        Me.pnlRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(667, 111)
        Me.pnlRegister.TabIndex = 6
        Me.pnlRegister.Visible = False
        '
        'lblRegisterMode
        '
        Me.lblRegisterMode.AutoSize = True
        Me.lblRegisterMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRegisterMode.LinkColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblRegisterMode.Location = New System.Drawing.Point(247, 369)
        Me.lblRegisterMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegisterMode.Name = "lblRegisterMode"
        Me.lblRegisterMode.Size = New System.Drawing.Size(186, 20)
        Me.lblRegisterMode.TabIndex = 9
        Me.lblRegisterMode.TabStop = True
        Me.lblRegisterMode.Text = "Need an account? Register"
        '
        'lblCaptcha
        '
        Me.lblCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCaptcha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCaptcha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblCaptcha.Location = New System.Drawing.Point(107, 246)
        Me.lblCaptcha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaptcha.Name = "lblCaptcha"
        Me.lblCaptcha.Size = New System.Drawing.Size(199, 43)
        Me.lblCaptcha.TabIndex = 10
        Me.lblCaptcha.Text = "5 + 3 = ?"
        Me.lblCaptcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCaptcha
        '
        Me.txtCaptcha.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCaptcha.Location = New System.Drawing.Point(320, 252)
        Me.txtCaptcha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(132, 30)
        Me.txtCaptcha.TabIndex = 11
        '
        'btnRefreshCaptcha
        '
        Me.btnRefreshCaptcha.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefreshCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshCaptcha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefreshCaptcha.ForeColor = System.Drawing.Color.White
        Me.btnRefreshCaptcha.Location = New System.Drawing.Point(467, 252)
        Me.btnRefreshCaptcha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefreshCaptcha.Name = "btnRefreshCaptcha"
        Me.btnRefreshCaptcha.Size = New System.Drawing.Size(93, 31)
        Me.btnRefreshCaptcha.TabIndex = 12
        Me.btnRefreshCaptcha.Text = "Refresh"
        Me.btnRefreshCaptcha.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 406)
        Me.Controls.Add(Me.btnRefreshCaptcha)
        Me.Controls.Add(Me.txtCaptcha)
        Me.Controls.Add(Me.lblCaptcha)
        Me.Controls.Add(Me.lblRegisterMode)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - CHRIST University Resource Sharing"
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
