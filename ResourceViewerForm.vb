Imports System.Windows.Forms
Imports System.IO

Public Class ResourceViewerForm
    Private currentResource As Resource

    Public Sub New(resource As Resource)
        InitializeComponent()
        currentResource = resource
    End Sub

    Private Sub ResourceViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "View: " & currentResource.Title
        lblTitle.Text = currentResource.Title
        lblType.Text = "Type: " & currentResource.Type.ToString()

        ' Show appropriate viewer based on resource type
        Select Case currentResource.Type
            Case ResourceType.Text
                ShowTextViewer()
            Case ResourceType.Image
                ShowImageViewer()
            Case ResourceType.PDF
                ShowPdfViewer()
            Case ResourceType.Link
                ShowLinkViewer()
        End Select
    End Sub

    Private Sub ShowTextViewer()
        txtViewer.Visible = True
        txtViewer.Text = currentResource.Content
        txtViewer.ReadOnly = True
    End Sub

    Private Sub ShowImageViewer()
        picViewer.Visible = True
        Try
            If File.Exists(currentResource.Content) Then
                picViewer.Image = Image.FromFile(currentResource.Content)
                picViewer.SizeMode = PictureBoxSizeMode.Zoom
            Else
                MessageBox.Show("Image file not found: " & currentResource.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowPdfViewer()
        Try
            If File.Exists(currentResource.Content) Then
                ' Open PDF in default browser/PDF reader
                Process.Start(currentResource.Content)
                MessageBox.Show("Opening PDF in your default application...", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("PDF file not found: " & currentResource.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowLinkViewer()
        Try
            ' Open the URL in the default browser
            Process.Start(currentResource.Url)
            ' Close the viewer form since link opens externally
            MessageBox.Show("Opening link in your default browser...", "Link", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error opening URL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
