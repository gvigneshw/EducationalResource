<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubjectsForm
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lstSubjects As System.Windows.Forms.ListBox
    Friend WithEvents btnViewResources As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstSubjects = New System.Windows.Forms.ListBox()
        Me.btnViewResources = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Available Subjects"
        '
        'lstSubjects
        '
        Me.lstSubjects.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lstSubjects.FormattingEnabled = True
        Me.lstSubjects.ItemHeight = 17
        Me.lstSubjects.Location = New System.Drawing.Point(25, 60)
        Me.lstSubjects.Name = "lstSubjects"
        Me.lstSubjects.Size = New System.Drawing.Size(550, 344)
        Me.lstSubjects.TabIndex = 1
        '
        'btnViewResources
        '
        Me.btnViewResources.BackColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.btnViewResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewResources.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewResources.ForeColor = System.Drawing.Color.White
        Me.btnViewResources.Location = New System.Drawing.Point(25, 420)
        Me.btnViewResources.Name = "btnViewResources"
        Me.btnViewResources.Size = New System.Drawing.Size(150, 35)
        Me.btnViewResources.TabIndex = 2
        Me.btnViewResources.Text = "View Resources"
        Me.btnViewResources.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(425, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'SubjectsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 475)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewResources)
        Me.Controls.Add(Me.lstSubjects)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SubjectsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subjects - CHRIST University"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
