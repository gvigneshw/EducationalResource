Module Auth
    Public Function Register(username As String, password As String, fullName As String, email As String) As Boolean
        If DataStore.Users.ContainsKey(username) Then
            Return False
        End If
        DataStore.Users(username) = password
        DataStore.Students(username) = New Student With {
            .Username = username,
            .FullName = fullName,
            .Email = email,
            .University = "CHRIST University"
        }
        Return True
    End Function

    Public Function Authenticate(username As String, password As String) As Boolean
        If String.IsNullOrEmpty(username) Then Return False
        If Not DataStore.Users.ContainsKey(username) Then Return False
        Return DataStore.Users(username) = password
    End Function
    
    Public Function GetCurrentStudent(username As String) As Student
        If DataStore.Students.ContainsKey(username) Then
            Return DataStore.Students(username)
        End If
        Return Nothing
    End Function
End Module
