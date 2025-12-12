<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResourceViewerForm
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
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtViewer As System.Windows.Forms.RichTextBox
    Friend WithEvents picViewer As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtViewer = New System.Windows.Forms.RichTextBox()
        Me.picViewer = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46, 84, 147)
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(760, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Resource Title"
        '
        'lblType
        '
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblType.ForeColor = System.Drawing.Color.Gray
        Me.lblType.Location = New System.Drawing.Point(20, 50)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(760, 20)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "Type: Text"
        '
        'txtViewer
        '
        Me.txtViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtViewer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtViewer.Location = New System.Drawing.Point(20, 80)
        Me.txtViewer.Name = "txtViewer"
        Me.txtViewer.Size = New System.Drawing.Size(760, 450)
        Me.txtViewer.TabIndex = 2
        Me.txtViewer.Text = ""
        Me.txtViewer.Visible = False
        '
        'picViewer
        '
        Me.picViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picViewer.Location = New System.Drawing.Point(20, 80)
        Me.picViewer.Name = "picViewer"
        Me.picViewer.Size = New System.Drawing.Size(760, 450)
        Me.picViewer.TabIndex = 3
        Me.picViewer.TabStop = False
        Me.picViewer.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(128, 128, 128)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(680, 545)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 35)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ResourceViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picViewer)
        Me.Controls.Add(Me.txtViewer)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ResourceViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resource Viewer"
        CType(Me.picViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

End Class
