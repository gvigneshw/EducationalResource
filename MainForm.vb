Imports System.Windows.Forms

Public Class MainForm
    Private currentUser As String

    Public Sub New(username As String)
        currentUser = username
        InitializeComponent()
        Dim student = Auth.GetCurrentStudent(username)
        If student IsNot Nothing Then
            lblWelcome.Text = String.Format("Welcome, {0}!", student.FullName)
        Else
            lblWelcome.Text = "Welcome, " & currentUser
        End If
        
        ' Display app info from AppSettings singleton
        lblAppInfo.Text = AppSettings.Instance.GetAppInfo()
        
        ' Add initial notification about login
        Dim loginMsg = String.Format("{0} - Logged in as {1}", DateTime.Now.ToString("HH:mm:ss"), username)
        lstNotifications.Items.Insert(0, loginMsg)
    End Sub

    Private Sub btnBrowseSubjects_Click(sender As Object, e As EventArgs) Handles btnBrowseSubjects.Click
        Dim subjForm = New SubjectsForm()
        AddHandler subjForm.SubjectSelected, AddressOf OnSubjectSelected
        subjForm.Show()
    End Sub

    ' Event handler - called when a subject is selected
    Private Sub OnSubjectSelected(subjectId As String)
        Dim subj = DataStore.GetSubjectById(subjectId)
        If subj IsNot Nothing Then
            Dim msg = String.Format("{0} - Opened: {1}", DateTime.Now.ToString("HH:mm:ss"), subj.SubjectName)
            lstNotifications.Items.Insert(0, msg)
        End If
    End Sub
    
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim profileForm = New ProfileForm(currentUser)
        profileForm.ShowDialog()
    End Sub
    
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If result = DialogResult.Yes Then
            ' Clear session in AppSettings singleton
            AppSettings.Instance.ClearSession()
            
            ' Add logout notification
            Dim logoutMsg = String.Format("{0} - User logged out", DateTime.Now.ToString("HH:mm:ss"))
            lstNotifications.Items.Insert(0, logoutMsg)
            
            ' Show login form and close main form
            Dim loginForm = New Form1()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

End Class
