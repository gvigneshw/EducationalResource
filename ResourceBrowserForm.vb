Imports System.Windows.Forms

Public Class ResourceBrowserForm
    Private currentSubjectId As String
    Private currentUsername As String
    
    ' Event for notifying when a resource is added
    Public Event ResourceAdded(resourceTitle As String)
    
    Public Sub New(subjectId As String)
        InitializeComponent()
        currentSubjectId = subjectId
    End Sub
    
    Private Sub ResourceBrowserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim subj = DataStore.GetSubjectById(currentSubjectId)
        If subj IsNot Nothing Then
            Me.Text = String.Format("Resources - {0}", subj.SubjectName)
            lblSubjectTitle.Text = String.Format("{0} - {1}", subj.SubjectCode, subj.SubjectName)
        End If
        LoadResources()
    End Sub
    
    Private Sub LoadResources()
        lstResources.Items.Clear()
        Dim resources = DataStore.GetResourcesBySubject(currentSubjectId)
        
        If resources.Count = 0 Then
            lstResources.Items.Add("No resources available yet. Be the first to upload!")
        Else
            For Each res In resources
                Dim typeStr = res.Type.ToString()
                Dim display = String.Format("[{0}] {1} - by {2} on {3}", typeStr, res.Title, res.UploadedBy, res.UploadDate.ToString("MMM dd, yyyy"))
                lstResources.Items.Add(display)
            Next
        End If
    End Sub
    
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim uploadForm = New UploadResourceForm(currentSubjectId)
        AddHandler uploadForm.ResourceUploaded, AddressOf OnResourceUploaded
        uploadForm.ShowDialog()
    End Sub
    
    Private Sub OnResourceUploaded(title As String)
        LoadResources()
        ' Update subject resource count
        Dim subj = DataStore.GetSubjectById(currentSubjectId)
        If subj IsNot Nothing Then
            subj.ResourceCount = DataStore.GetResourcesBySubject(currentSubjectId).Count
        End If
        
        ' Raise event to notify parent forms
        RaiseEvent ResourceAdded(title)
    End Sub
    
    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If lstResources.SelectedIndex >= 0 Then
            Dim resources = DataStore.GetResourcesBySubject(currentSubjectId)
            If resources.Count > 0 AndAlso lstResources.SelectedIndex < resources.Count Then
                Dim res = resources(lstResources.SelectedIndex)
                Dim viewerForm = New ResourceViewerForm(res)
                viewerForm.ShowDialog()
            End If
        Else
            MessageBox.Show("Please select a resource to view details.", "View Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
