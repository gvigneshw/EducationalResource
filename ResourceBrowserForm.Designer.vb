<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResourceBrowserForm
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
    Friend WithEvents lblSubjectTitle As System.Windows.Forms.Label
    Friend WithEvents lstResources As System.Windows.Forms.ListBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSubjectTitle = New System.Windows.Forms.Label()
        Me.lstResources = New System.Windows.Forms.ListBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSubjectTitle
        '
        Me.lblSubjectTitle.AutoSize = True
        Me.lblSubjectTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubjectTitle.ForeColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.lblSubjectTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblSubjectTitle.Name = "lblSubjectTitle"
        Me.lblSubjectTitle.Size = New System.Drawing.Size(150, 25)
        Me.lblSubjectTitle.TabIndex = 0
        Me.lblSubjectTitle.Text = "Subject Resources"
        '
        'lstResources
        '
        Me.lstResources.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lstResources.FormattingEnabled = True
        Me.lstResources.ItemHeight = 17
        Me.lstResources.Location = New System.Drawing.Point(25, 60)
        Me.lstResources.Name = "lstResources"
        Me.lstResources.Size = New System.Drawing.Size(750, 378)
        Me.lstResources.TabIndex = 1
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(25, 455)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(180, 35)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload Resource"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewDetails.ForeColor = System.Drawing.Color.White
        Me.btnViewDetails.Location = New System.Drawing.Point(220, 455)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(180, 35)
        Me.btnViewDetails.TabIndex = 3
        Me.btnViewDetails.Text = "View Details"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(595, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(180, 35)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ResourceBrowserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.lstResources)
        Me.Controls.Add(Me.lblSubjectTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ResourceBrowserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resources"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
