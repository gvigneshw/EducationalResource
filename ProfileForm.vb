Imports System.Windows.Forms

Public Class ProfileForm
    Private currentUsername As String
    
    Public Sub New(username As String)
        InitializeComponent()
        currentUsername = username
    End Sub
    
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim student = Auth.GetCurrentStudent(currentUsername)
        If student IsNot Nothing Then
            txtUsername.Text = student.Username
            txtFullName.Text = student.FullName
            txtEmail.Text = student.Email
            txtUniversity.Text = student.University
        Else
            txtUsername.Text = currentUsername
            txtFullName.Text = "N/A"
            txtEmail.Text = "N/A"
            txtUniversity.Text = AppSettings.Instance.University
        End If
        
        ' Display session info from AppSettings singleton
        If AppSettings.Instance.IsLoggedIn Then
            Dim sessionDuration = AppSettings.Instance.GetSessionDuration()
            lblSessionInfo.Text = String.Format("Session: {0} minutes ({1})", 
                sessionDuration, 
                AppSettings.Instance.LoginTime.ToString("HH:mm:ss"))
        End If
    End Sub
    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
