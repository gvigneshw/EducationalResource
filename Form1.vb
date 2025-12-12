Imports System.Windows.Forms

Public Class Form1
    Private isRegisterMode As Boolean = False
    Private captchaAnswer As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUIMode()
        GenerateCaptcha()
    End Sub

    Private Sub GenerateCaptcha()
        Dim rnd As New Random()
        Dim num1 As Integer = rnd.Next(1, 10)
        Dim num2 As Integer = rnd.Next(1, 10)
        captchaAnswer = num1 + num2
        lblCaptcha.Text = $"{num1} + {num2} = ?"
        txtCaptcha.Clear()
    End Sub

    Private Function ValidateCaptcha() As Boolean
        Dim userAnswer As Integer
        If Integer.TryParse(txtCaptcha.Text.Trim(), userAnswer) Then
            Return userAnswer = captchaAnswer
        End If
        Return False
    End Function

    Private Sub btnRefreshCaptcha_Click(sender As Object, e As EventArgs) Handles btnRefreshCaptcha.Click
        GenerateCaptcha()
    End Sub

    Private Sub lblRegisterMode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegisterMode.LinkClicked
        isRegisterMode = Not isRegisterMode
        UpdateUIMode()
        GenerateCaptcha()
    End Sub

    Private Sub UpdateUIMode()
        If isRegisterMode Then
            lblRegisterMode.Text = "Already have an account? Login"
            pnlRegister.Visible = True
            btnRegister.Visible = True
            btnLogin.Visible = False
            Me.ClientSize = New System.Drawing.Size(500, 420)
            lblRegisterMode.Location = New System.Drawing.Point(145, 390)
        Else
            lblRegisterMode.Text = "Need an account? Register"
            pnlRegister.Visible = False
            btnRegister.Visible = False
            btnLogin.Visible = True
            Me.ClientSize = New System.Drawing.Size(500, 330)
            lblRegisterMode.Location = New System.Drawing.Point(185, 300)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not ValidateCaptcha() Then
            MessageBox.Show("Incorrect captcha answer. Please try again.", "Captcha Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GenerateCaptcha()
            Return
        End If

        Dim user = txtUser.Text.Trim()
        Dim pass = txtPass.Text
        If Auth.Authenticate(user, pass) Then
            ' Set current user in AppSettings singleton
            AppSettings.Instance.SetCurrentUser(user)

            Dim mf = New MainForm(user)
            mf.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials. Try registering or use username 'student' and password 'pass'.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GenerateCaptcha()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not ValidateCaptcha() Then
            MessageBox.Show("Incorrect captcha answer. Please try again.", "Captcha Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GenerateCaptcha()
            Return
        End If

        Dim user = txtUser.Text.Trim()
        Dim pass = txtPass.Text
        Dim fullName = txtFullName.Text.Trim()
        Dim email = txtEmail.Text.Trim()

        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Enter both username and password to register.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If String.IsNullOrEmpty(fullName) Then
            MessageBox.Show("Please enter your full name.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If String.IsNullOrEmpty(email) OrElse Not email.Contains("@") Then
            MessageBox.Show("Please enter a valid email address.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If Auth.Register(user, pass, fullName, email) Then
            MessageBox.Show("Registration successful. You can now login.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
            isRegisterMode = False
            UpdateUIMode()
            txtUser.Clear()
            txtPass.Clear()
            txtFullName.Clear()
            txtEmail.Clear()
            GenerateCaptcha()
        Else
            MessageBox.Show("User already exists.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
