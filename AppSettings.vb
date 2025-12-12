Imports System

' Singleton pattern for application-wide settings
Public NotInheritable Class AppSettings
    Private Shared ReadOnly _instance As New Lazy(Of AppSettings)(Function() New AppSettings())
    
    ' Private constructor to prevent external instantiation
    Private Sub New()
        ' Initialize default settings
        AppName = "Educational Resource Sharing Platform"
        University = "CHRIST University"
        Version = "1.0.0"
        MaxLoginAttempts = 3
        SessionTimeout = 30 ' minutes
        EnableNotifications = True
        Theme = "Light"
        DefaultResourcesPerPage = 20
    End Sub
    
    ' Public static property to access the singleton instance
    Public Shared ReadOnly Property Instance As AppSettings
        Get
            Return _instance.Value
        End Get
    End Property
    
    ' Application Settings Properties
    Public Property AppName As String
    Public Property University As String
    Public Property Version As String
    Public Property MaxLoginAttempts As Integer
    Public Property SessionTimeout As Integer
    Public Property EnableNotifications As Boolean
    Public Property Theme As String
    Public Property DefaultResourcesPerPage As Integer
    
    ' Current session information
    Public Property CurrentUsername As String
    Public Property LoginTime As DateTime
    Public Property IsLoggedIn As Boolean
    
    ' Method to set current user session
    Public Sub SetCurrentUser(username As String)
        CurrentUsername = username
        LoginTime = DateTime.Now
        IsLoggedIn = True
    End Sub
    
    ' Method to clear user session (logout)
    Public Sub ClearSession()
        CurrentUsername = Nothing
        LoginTime = DateTime.MinValue
        IsLoggedIn = False
    End Sub
    
    ' Get session duration in minutes
    Public Function GetSessionDuration() As Integer
        If IsLoggedIn Then
            Return CInt((DateTime.Now - LoginTime).TotalMinutes)
        End If
        Return 0
    End Function
    
    ' Check if session has timed out
    Public Function IsSessionExpired() As Boolean
        If IsLoggedIn Then
            Return GetSessionDuration() >= SessionTimeout
        End If
        Return True
    End Function
    
    ' Get formatted app info
    Public Function GetAppInfo() As String
        Return $"{AppName} v{Version} - {University}"
    End Function
End Class
