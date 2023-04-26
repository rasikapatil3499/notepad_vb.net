Imports System.Windows.Forms

Public Class MDIParent1
    Dim Filename As String

    Private Sub NEWTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWTool.Click
        RichTextBox1.Text = ""
    End Sub
    Private Sub OPENTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPENTool.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Exit Sub
        End If

        Dim Tmp As String
        Tmp = ""

        FileSystem.FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Do While Not FileSystem.EOF(1)
            Tmp=Tmp & FileSystem.LineInput(1)
            If Not FileSystem.EOF(1) Then
                Tmp = Tmp & Chr(13) & Chr(10)

                End
            End If
        Loop
    End Sub

    Private Sub SAVETool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVETool.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then
            Exit Sub
        End If

        FileSystem.FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        FileSystem.Print(1, RichTextBox1.Text)
        FileSystem.FileClose(1)

    End Sub
    
    Private Sub EXITTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITTool.Click
        Me.Hide()
    End Sub

    Private Sub CUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUTToolStripMenuItem.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
    End Sub
   

    Private Sub PASTEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASTEToolStripMenuItem1.Click
        RichTextBox1.SelectedText = Clipboard.GetText
    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
    End Sub
End Class
