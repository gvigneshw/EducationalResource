<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents btnBrowseSubjects As System.Windows.Forms.Button
    Friend WithEvents lblNotifications As System.Windows.Forms.Label
    Friend WithEvents lstNotifications As System.Windows.Forms.ListBox
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblAppInfo As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBrowseSubjects = New System.Windows.Forms.Button()
        Me.lblNotifications = New System.Windows.Forms.Label()
        Me.lstNotifications = New System.Windows.Forms.ListBox()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAppInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.lblTitle.Location = New System.Drawing.Point(30, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resource Sharing Platform"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(32, 60)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(75, 21)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome"
        '
        'btnBrowseSubjects
        '
        Me.btnBrowseSubjects.BackColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.btnBrowseSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseSubjects.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowseSubjects.ForeColor = System.Drawing.Color.White
        Me.btnBrowseSubjects.Location = New System.Drawing.Point(35, 110)
        Me.btnBrowseSubjects.Name = "btnBrowseSubjects"
        Me.btnBrowseSubjects.Size = New System.Drawing.Size(200, 50)
        Me.btnBrowseSubjects.TabIndex = 2
        Me.btnBrowseSubjects.Text = "Browse Subjects"
        Me.btnBrowseSubjects.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(250, 110)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(200, 50)
        Me.btnProfile.TabIndex = 3
        Me.btnProfile.Text = "My Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(465, 110)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 50)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblNotifications
        '
        Me.lblNotifications.AutoSize = True
        Me.lblNotifications.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotifications.Location = New System.Drawing.Point(32, 185)
        Me.lblNotifications.Name = "lblNotifications"
        Me.lblNotifications.Size = New System.Drawing.Size(179, 21)
        Me.lblNotifications.TabIndex = 5
        Me.lblNotifications.Text = "Recent Notifications:"
        '
        'lstNotifications
        '
        Me.lstNotifications.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lstNotifications.FormattingEnabled = True
        Me.lstNotifications.ItemHeight = 17
        Me.lstNotifications.Location = New System.Drawing.Point(35, 220)
        Me.lstNotifications.Name = "lstNotifications"
        Me.lstNotifications.Size = New System.Drawing.Size(630, 208)
        Me.lstNotifications.TabIndex = 6
        '
        'lblAppInfo
        '
        Me.lblAppInfo.AutoSize = True
        Me.lblAppInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblAppInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblAppInfo.Location = New System.Drawing.Point(33, 445)
        Me.lblAppInfo.Name = "lblAppInfo"
        Me.lblAppInfo.Size = New System.Drawing.Size(250, 13)
        Me.lblAppInfo.TabIndex = 7
        Me.lblAppInfo.Text = "Educational Resource Sharing Platform v1.0.0"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 480)
        Me.Controls.Add(Me.lblAppInfo)
        Me.Controls.Add(Me.lstNotifications)
        Me.Controls.Add(Me.lblNotifications)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnBrowseSubjects)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHRIST University - Resource Sharing"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class
