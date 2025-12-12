Imports System.Collections.Generic

' Data models for the application
Public Class Student
    Public Property Username As String
    Public Property FullName As String
    Public Property Email As String
    Public Property University As String = "CHRIST University"
    Public Property EnrolledSubjects As New List(Of String)()
End Class

Public Class Subject
    Public Property SubjectId As String
    Public Property SubjectName As String
    Public Property SubjectCode As String
    Public Property Department As String
    Public Property ResourceCount As Integer
End Class

Public Class Resource
    Public Property ResourceId As String
    Public Property Title As String
    Public Property Description As String
    Public Property Type As ResourceType
    Public Property SubjectId As String
    Public Property UploadedBy As String
    Public Property UploadDate As DateTime
    Public Property Content As String ' For text content or file path
    Public Property Url As String ' For links
End Class

Public Enum ResourceType
    Text
    PDF
    Image
    Link
End Enum

' Static data store
Public Module DataStore
    Public Users As New Dictionary(Of String, String)() ' username -> password
    Public Students As New Dictionary(Of String, Student)() ' username -> Student
    Public Subjects As New List(Of Subject)()
    Public Resources As New List(Of Resource)()
    
    Sub New()
        ' Initialize with default user
        Users("student") = "pass"
        Students("student") = New Student With {
            .Username = "student",
            .FullName = "G Vignesh",
            .Email = "g.vignesh@christuniversity.in",
            .University = "CHRIST University"
        }

        ' Add some default subjects
        Subjects.Add(New Subject With {
            .SubjectId = "CS101",
            .SubjectName = "Data Structures",
            .SubjectCode = "CS101",
            .Department = "Computer Science",
            .ResourceCount = 1
        })
        Subjects.Add(New Subject With {
            .SubjectId = "CS102",
            .SubjectName = "Database Management Systems",
            .SubjectCode = "CS102",
            .Department = "Computer Science",
            .ResourceCount = 0
        })
        Subjects.Add(New Subject With {
            .SubjectId = "CS103",
            .SubjectName = "Operating Systems",
            .SubjectCode = "CS103",
            .Department = "Computer Science",
            .ResourceCount = 0
        })
        Subjects.Add(New Subject With {
            .SubjectId = "MTH101",
            .SubjectName = "Discrete Mathematics",
            .SubjectCode = "MTH101",
            .Department = "Mathematics",
            .ResourceCount = 0
        })
        
        ' Add sample text resource for demonstration
        Resources.Add(New Resource With {
            .ResourceId = "R001",
            .Title = "Introduction to Arrays",
            .Description = "Basic concepts of arrays in data structures",
            .Type = ResourceType.Text,
            .SubjectId = "CS101",
            .UploadedBy = "student",
            .UploadDate = DateTime.Now.AddDays(-5),
            .Content = "Arrays are fundamental data structures that store elements in contiguous memory locations." & vbCrLf & vbCrLf &
                      "Key Concepts:" & vbCrLf &
                      "1. Fixed size collection" & vbCrLf &
                      "2. Elements accessed by index" & vbCrLf &
                      "3. O(1) time complexity for access" & vbCrLf & vbCrLf &
                      "Example: int[] arr = new int[5];" & vbCrLf & vbCrLf &
                      "Arrays are efficient for accessing elements but costly for insertions and deletions."
        })
    End Sub
    
    Public Function GetResourcesBySubject(subjectId As String) As List(Of Resource)
        Return Resources.Where(Function(r) r.SubjectId = subjectId).ToList()
    End Function
    
    Public Function GetSubjectById(subjectId As String) As Subject
        Return Subjects.FirstOrDefault(Function(s) s.SubjectId = subjectId)
    End Function
End Module
