Public Class Form1
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node3" Then
            RichTextBox1.Text = "On the Insert tab, the galleries include items that are designed"

        End If

        If e.Node.Name = "Node4" Then
            RichTextBox1.Text = "Both the Themes gallery and the Quick Styles gallery provide reset"
        End If

        If e.Node.Name = "Node5" Then
            RichTextBox1.Text = "To change th elooks avaible in the Quick Style gallery, use the Change Current Quick Style Set"
        End If

        If e.Node.Name = "Node6" Then
            RichTextBox1.Text = "To change th elooks avaible in the Quick Style gallery, use the Change Current Quick Style Set"
        End If

        If e.Node.Name = "Node7" Then
            RichTextBox1.Text = "To change th elooks avaible in the Quick Style gallery, use the Change Current Quick Style Set"
        End If

        If e.Node.Name = "Node8" Then
            RichTextBox1.Text = "To change th elooks avaible in the Quick Style gallery, use the Change Current Quick Style Set"
        End If

        If e.Node.Name = "Node9" Then
            Me.Hide()
        End If
    End Sub
End Class
