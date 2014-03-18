Namespace MyApp

    Public Class TextEdit
        Public Class RichText
            Public Shared Sub CopySelection(ByRef oRichTextBox As System.Windows.Forms.RichTextBox)
                ' Ensure that text is selected in the text box.   
                If oRichTextBox.SelectionLength > 0 Then
                    ' Copy the selected text to the Clipboard.
                    oRichTextBox.Copy()
                End If
            End Sub

            Public Shared Sub CutSelection(ByRef oRichTextBox As System.Windows.Forms.RichTextBox)
                ' Ensure that text is currently selected in the text box.   
                If oRichTextBox.SelectedText <> "" Then
                    ' Cut the selected text in the control and paste it into the Clipboard.
                    oRichTextBox.Cut()
                End If
            End Sub

            Public Shared Sub PasteSelection(ByRef oRichTextBox As System.Windows.Forms.RichTextBox)
                ' Determine if there is any text in the Clipboard to paste into the text box.
                If Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) = True Then
                    ' Determine if any text is selected in the text box.
                    If oRichTextBox.SelectionLength > 0 Then
                        ' Ask user if they want to paste over currently selected text.
                        If MessageBox.Show("Do you want to paste over current selection?", _
                            "Cut Example", MessageBoxButtons.YesNo) = DialogResult.No Then
                            ' Move selection to the point after the current selection and paste.
                            oRichTextBox.SelectionStart = oRichTextBox.SelectionStart + _
                                oRichTextBox.SelectionLength
                        End If
                    End If
                    ' Paste current text in Clipboard into text box.
                    oRichTextBox.Paste()
                End If
            End Sub
            Public Shared Sub Undo(ByRef oRichTextBox As System.Windows.Forms.RichTextBox)

                ' Determine if last operation can be undone in text box.   
                If oRichTextBox.CanUndo = True Then
                    ' Undo the last operation.
                    oRichTextBox.Undo()
                    ' Clear the undo buffer to prevent last action from being redone.
                    oRichTextBox.ClearUndo()
                End If
            End Sub

            Public Shared Function GetRowColumnMouseDownFromRTFTextbox(ByRef aRTFTextbox As RichTextBox, ByVal e As System.Windows.Forms.MouseEventArgs) As String
                Dim iLine As Integer
                Dim iStartOfLine As Integer
                Dim iColumn As Integer
                Dim sPosition As String

                iLine = aRTFTextbox.GetLineFromCharIndex(aRTFTextbox.GetCharIndexFromPosition(New Point(e.X, e.Y))) + 1
                iStartOfLine = aRTFTextbox.GetFirstCharIndexOfCurrentLine
                iColumn = aRTFTextbox.GetCharIndexFromPosition(New Point(e.X, e.Y)) - iStartOfLine + 1
                sPosition = "Line: " & iLine.ToString & "  Column: " & iColumn.ToString
                Return sPosition
            End Function


        End Class
    End Class

End Namespace