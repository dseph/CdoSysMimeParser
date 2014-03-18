' CdoSys Mime Parser
' 5/2/08 
' http://www.codeplex.com/CDOSYSMimeParser
' This program will parse mime from a file, break-down the body parts and 
' display it its contents in a fairly developer friendly format.
' It also allows you to save off the content of body parts in various formats.
'
' This code is provided as is and is for learning purposes only on a test system.

Imports System.IO.Stream
Imports System.IO

Public Class Form1
    Dim objCDOMsg As CDO.Message
    Dim bLoaded As Boolean = False
    Dim m_MessageMime As String = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub



    Public Property MessageMime() As String
        Get
            Return m_MessageMime
        End Get
        Set(ByVal Value As String)
            m_MessageMime = Value
            LoadMimeString(m_MessageMime)
        End Set
    End Property


    Public Function LoadMimeString(ByVal sMime As String) As Boolean
        Dim bRet As Boolean
        txtFileName.Text = ""
        txtFileName.Enabled = False
        cmdBrowse.Visible = False
        cmdLoad.Visible = False
        bRet = LoadMessage("string", sMime)
        If bRet = True Then
            StatusBar1.Text = "Loaded"
        End If
        Return bRet
    End Function

    Public Function LoadMimeString(ByVal sMime As String, ByVal sRefPath As String) As Boolean
        Dim bRet As Boolean
        txtFileName.Text = sRefPath
        txtFileName.Enabled = False
        cmdBrowse.Visible = False
        cmdLoad.Visible = False

        bRet = LoadMessage("string", sMime)
        If bRet = True Then
            StatusBar1.Text = "Loaded"
        End If
        Return bRet
    End Function

    Public Function LoadMimeFile(ByVal sFile As String) As Boolean
        Dim bRet As Boolean
        txtFileName.Text = sFile
        txtFileName.Enabled = True
        cmdBrowse.Visible = True
        cmdLoad.Visible = True
        bRet = LoadMessage("file", sFile)
        If bRet = True Then
            StatusBar1.Text = "Loaded"
        End If
        Return bRet
    End Function


    Private Function LoadMessage(ByRef sLoadType As String, ByVal sMessage As String) As Boolean
        Dim objMsgStream As New ADODB.Stream
        Dim sFileName As String = ""
        objCDOMsg = Nothing
        objCDOMsg = New CDO.Message
        bLoaded = False

        Try
            Me.Cursor = Cursors.WaitCursor


            ' First Get the Raw Mime and display it.
            Dim sFileText As String
            If sLoadType = "file" Then
                Dim xObj As New MyApp.AppUtil
                sFileName = txtFileName.Text.Trim
                sFileText = xObj.GetFileAsString(sFileName)
                txtMime.Text = sFileText
                xObj = Nothing

                ' Now Lets read this thing
                objMsgStream.Open()
                objMsgStream.LoadFromFile(sFileName)
                objCDOMsg.BodyPart.DataSource.OpenObject(objMsgStream, "IStream")
                m_MessageMime = sFileText
            Else
                sFileName = Path.GetTempFileName
                txtMime.Text = sMessage

                Dim xObj As New MyApp.AppUtil
                xObj.SaveStringAsFile(sMessage, sFileName)
                xObj = Nothing
                ' Ran into problems writing mime text to a message, working around by using a temp file
                objMsgStream.Open()
                objMsgStream.LoadFromFile(sFileName) ' Read temp file

                objCDOMsg.BodyPart.DataSource.OpenObject(objMsgStream, "IStream") ' read it
                File.Delete(sFileName) ' Get rid of temp file
                m_MessageMime = sMessage
            End If

            LoadMessageFields()
            LoadAttachemntsFields()
            ExtractBodyPart(objCDOMsg.BodyPart) ' Messag Body

        Catch ex As Exception
            bLoaded = False
            MsgBox("Error Loading File: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

        Try
            Dim pNode As New System.Windows.Forms.TreeNode
            TreeView1.Nodes.Clear()
            pNode = TreeView1.Nodes.Add("Root") ' m_BaseURI
            pNode.Tag = objCDOMsg.BodyPart

            Dim objBodypart As CDO.IBodyPart = Nothing
            Dim objBodypart2 As CDO.IBodyPart = Nothing
            Dim objBodypart3 As CDO.IBodyPart = Nothing
            Dim objBodypart4 As CDO.IBodyPart = Nothing
            Dim objBodypart5 As CDO.IBodyPart = Nothing
            Dim objBodypart6 As CDO.IBodyPart = Nothing
            Dim objBodypart7 As CDO.IBodyPart = Nothing

            Dim iBodyPartCount As Integer = 1
            Dim iBodyPartCount2 As Integer = 1
            Dim iBodyPartCount3 As Integer = 1
            Dim iBodyPartCount4 As Integer = 1
            Dim iBodyPartCount5 As Integer = 1
            Dim iBodyPartCount6 As Integer = 1
            Dim iBodyPartCount7 As Integer = 1

            Dim aNode As System.Windows.Forms.TreeNode = Nothing
            Dim aNode2 As System.Windows.Forms.TreeNode = Nothing
            Dim aNode3 As System.Windows.Forms.TreeNode = Nothing
            Dim aNode4 As System.Windows.Forms.TreeNode = Nothing
            Dim aNode5 As System.Windows.Forms.TreeNode = Nothing
            Dim aNode6 As System.Windows.Forms.TreeNode = Nothing
            Dim aNode7 As System.Windows.Forms.TreeNode = Nothing

            iBodyPartCount = 1
            ' Note: I'm using this big loop because i want to be able to see things better
            ' as this code loops through each body part.  Using a recursive call to a method
            ' just makes the debugging process more difficult.
            For Each objBodypart In objCDOMsg.BodyPart.BodyParts
                AddNode(objBodypart, pNode, aNode, iBodyPartCount)

                iBodyPartCount2 = 1
                For Each objBodypart2 In objBodypart.BodyParts
                    AddNode(objBodypart2, aNode, aNode2, iBodyPartCount2)
                    iBodyPartCount3 = 1
                    For Each objBodypart3 In objBodypart2.BodyParts
                        AddNode(objBodypart3, aNode2, aNode3, iBodyPartCount3)
                        iBodyPartCount4 = 1
                        For Each objBodypart4 In objBodypart3.BodyParts
                            AddNode(objBodypart4, aNode3, aNode4, iBodyPartCount4)
                            iBodyPartCount5 = 1
                            For Each objBodypart5 In objBodypart4.BodyParts
                                AddNode(objBodypart5, aNode4, aNode5, iBodyPartCount5)
                                iBodyPartCount6 = 1
                                For Each objBodypart6 In objBodypart5.BodyParts
                                    AddNode(objBodypart6, aNode5, aNode6, iBodyPartCount6)
                                    iBodyPartCount7 = 1
                                    For Each objBodypart7 In objBodypart6.BodyParts
                                        AddNode(objBodypart7, aNode6, aNode7, iBodyPartCount7)
                                        iBodyPartCount7 += 1
                                    Next
                                    iBodyPartCount6 += 1
                                Next
                                iBodyPartCount5 += 1
                            Next
                            iBodyPartCount4 += 1
                        Next
                        iBodyPartCount3 += 1
                    Next
                    iBodyPartCount2 += 1
                Next
                iBodyPartCount += 1
            Next
            pNode.ExpandAll()

            bLoaded = True
        Catch ex As Exception
            bLoaded = False
            MsgBox("Error Loading Message Body Parts: " & ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try

        objMsgStream = Nothing
        Cursor = Cursors.Default
        Return bLoaded
    End Function

    Private Function AddNode( _
            ByRef aBodyPart As CDO.IBodyPart, _
            ByRef pNode As System.Windows.Forms.TreeNode, _
            ByRef aNewNode As System.Windows.Forms.TreeNode, _
            ByVal iCount As Integer) _
            As Boolean
        Dim bReturn As Boolean = False
        aNewNode = New System.Windows.Forms.TreeNode
        Dim sText As String = ""

        If aBodyPart.FileName.ToString <> "" Then
            sText = "(" & aBodyPart.FileName.ToString & ")"
        End If

        aNewNode.Text = (sText & "" & pNode.Text & "." & iCount.ToString & "")
        aNewNode.Tag = aBodyPart

        aNewNode.ImageIndex = 0
        aNewNode.SelectedImageIndex = 0

        pNode.Nodes.Add(aNewNode)
        Return bReturn

    End Function


    Private Sub LoadMessageFields()
        Dim objField As ADODB.Field
        Dim aListItem As ListViewItem
        ListView1.Items.Clear()
        ListView1.View = View.Details   ' Set the view to show details.
        ListView1.GridLines = True      ' Display grid lines.
        Dim sValue As String

        For Each objField In objCDOMsg.Fields

            aListItem = New ListViewItem(objField.Name)
            'aListItem.Tag = anInstance.href
            Try
                sValue = objField.Value
                aListItem.SubItems.Add(sValue)
            Catch ex As Exception
                sValue = "(Cannot Extract - may not be set)"
                aListItem.SubItems.Add(sValue)
            End Try

            ListView1.Items.AddRange(New ListViewItem() {aListItem})
            aListItem = Nothing
        Next
    End Sub

    'LoadMessageEnvelopeFields()
    'lvAttachments
    Private Sub LoadAttachemntsFields()
        Dim iBP As CDO.IBodyPart
        Dim aListItem As ListViewItem
        lvAttachments.Items.Clear()
        lvAttachments.View = View.Details   ' Set the view to show details.
        lvAttachments.GridLines = True      ' Display grid lines.
        'Dim sValue As String

        For Each iBP In objCDOMsg.Attachments

            aListItem = New ListViewItem(iBP.FileName)

            If iBP.ContentMediaType <> Nothing Then
                aListItem.SubItems.Add(iBP.ContentMediaType)
            Else
                aListItem.SubItems.Add("")
            End If
            If iBP.ContentTransferEncoding <> Nothing Then
                aListItem.SubItems.Add(iBP.ContentTransferEncoding)
            Else
                aListItem.SubItems.Add("")
            End If
            If iBP.Charset <> Nothing Then
                aListItem.SubItems.Add(iBP.Charset)
            Else
                aListItem.SubItems.Add("")
            End If
            If iBP.ContentClass <> Nothing Then
                aListItem.SubItems.Add(iBP.ContentClass)
            Else
                aListItem.SubItems.Add("")
            End If
            If iBP.ContentClass <> Nothing Then
                aListItem.SubItems.Add(iBP.ContentClassName)
            Else
                aListItem.SubItems.Add("")
            End If


            lvAttachments.Items.AddRange(New ListViewItem() {aListItem})
            aListItem = Nothing
        Next
    End Sub
    Private Sub ExtractBodyPart(ByRef iBP As CDO.IBodyPart)
        Dim sText As String
        Dim aStream As ADODB.Stream

        ' Get Encoded Stream
        Try
            aStream = iBP.GetEncodedContentStream()
            sText = aStream.ReadText()
            aStream.Close()
            txtEncoded.Text = sText
            txtStream.BackColor = Drawing.Color.White
        Catch ex As Exception
            txtEncoded.Text = ""
            txtStream.BackColor = Drawing.Color.Gray
        End Try

        ' Get Decoded Stream
        Try
            aStream = iBP.GetDecodedContentStream()
            sText = aStream.ReadText()
            aStream.Close()
            txtDecoded.Text = sText
            txtStream.BackColor = Drawing.Color.White
        Catch ex As Exception
            txtDecoded.Text = ""
            txtStream.BackColor = Drawing.Color.Gray
        End Try

        ' Get Stream
        Try
            aStream = iBP.GetStream
            sText = aStream.ReadText()
            aStream.Close()
            txtStream.Text = sText
            txtStream.BackColor = Drawing.Color.White
        Catch ex As Exception
            txtStream.Text = ""
            txtStream.BackColor = Drawing.Color.Gray
        End Try

        Dim aListItem As ListViewItem
        ListView1.Items.Clear()
        ListView1.View = View.Details   ' Set the view to show details.
        ListView1.GridLines = True      ' Display grid lines.
        Dim sValue As String

        ' Extract Bodypart Fields
        Dim objField As ADODB.Field
        For Each objField In iBP.Fields
            aListItem = New ListViewItem(objField.Name)
            'aListItem.Tag = anInstance.href
            Try
                sValue = objField.Value
                aListItem.SubItems.Add(sValue)
            Catch ex As Exception
                sValue = "(Cannot Extract - may not be set)"
                aListItem.SubItems.Add(sValue)
            End Try
            ListView1.Items.AddRange(New ListViewItem() {aListItem})
            aListItem = Nothing
        Next

        ' ---- Body Part Properties --------------------------------
        ListView2.Items.Clear()
        ListView2.View = View.Details   ' Set the view to show details.
        ListView2.GridLines = True      ' Display grid lines.
        If iBP.Charset <> Nothing Then
            AddLvItem(ListView2, "Charset", iBP.Charset)
        End If
        If iBP.ContentClass <> Nothing Then
            AddLvItem(ListView2, "ContentClass", iBP.ContentClass)
        End If
        If iBP.ContentMediaType <> Nothing Then
            AddLvItem(ListView2, "ContentMediaType", iBP.ContentMediaType)
        End If
        If iBP.ContentTransferEncoding <> Nothing Then
            AddLvItem(ListView2, "ContentTransferEncoding", iBP.ContentTransferEncoding)
        End If
        If iBP.FileName <> Nothing Then
            AddLvItem(ListView2, "FileName", iBP.FileName)
        End If
        AddLvItem(ListView2, "BodyParts.Count", iBP.BodyParts.Count)
        aStream = Nothing
    End Sub



    Private Sub AddLvItem(ByRef aListView As ListView, ByVal sName As String, ByVal sValue As String)
        Dim aListItem As ListViewItem

        aListItem = New ListViewItem(sName)
        sValue = sValue
        aListItem.SubItems.Add(sValue)
        aListView.Items.AddRange(New ListViewItem() {aListItem})

    End Sub

    Private Function SaveBodyPart(ByVal aStream As ADODB.Stream, ByVal sFileName As String) As Boolean

        'Dim sr As StreamWriter
        'Dim sFileBody As String
        Dim sDataPath As String = "c:\"
        Dim sUseFilename As String
        Dim saveFileDialog1 As SaveFileDialog
        saveFileDialog1 = New SaveFileDialog
        saveFileDialog1.InitialDirectory = sDataPath
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = False

        saveFileDialog1.FileName = sFileName
        If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            sUseFilename = saveFileDialog1.FileName
            saveFileDialog1 = Nothing

            Try
                Cursor = Cursors.WaitCursor
                aStream.SaveToFile(sUseFilename)
                Cursor = Cursors.Default
            Catch ex As Exception
                MsgBox("Cannot write to file.", MsgBoxStyle.Exclamation, "Error")
            End Try

        End If
    End Function

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Dim bRet As Boolean = False
        If (File.Exists(txtFileName.Text.Trim) = False) Then
            MsgBox("The file does not exist.", MsgBoxStyle.Exclamation, "Error")
        Else
            StatusBar1.Text = "Not Loaded"
            bRet = LoadMessage("file", txtFileName.Text.Trim)
            If bRet = True Then
                StatusBar1.Text = "Loaded"
            End If
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If bLoaded = True Then
            Cursor = Cursors.WaitCursor
            If Not (e.Node.Tag Is Nothing) Then

                Dim aBP As CDO.IBodyPart
                aBP = CType(e.Node.Tag, CDO.IBodyPart)
                If aBP Is Nothing Then
                    ExtractBodyPart(objCDOMsg.BodyPart) ' Messag Body
                Else
                    ExtractBodyPart(aBP) ' Body Part
                End If
            Else
                StatusBar1.Panels(0).Text = " "
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub mnuSaveBodyPartToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveBodyPartToFile.Click
        If Not (TreeView1.SelectedNode Is Nothing) Then
            Dim aBP As CDO.IBodyPart
            aBP = CType(TreeView1.SelectedNode.Tag, CDO.IBodyPart)

            'Dim aStream As ADODB.Stream
            Dim sFilename As String
            Dim sUseFilename As String = ""
            Dim sDatapath As String = "c:\"

            Dim saveFileDialog1 As SaveFileDialog
            saveFileDialog1 = New SaveFileDialog
            saveFileDialog1.InitialDirectory = sDatapath
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"


            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = False

            sFilename = aBP.FileName
            If sFilename = "" Then
                sFilename = "BodyPart (" & TreeView1.SelectedNode.Text & ").txt"
            Else
                sFilename = "BodyPart - " & sFilename
            End If

            saveFileDialog1.FileName = sFilename
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                sUseFilename = saveFileDialog1.FileName
                saveFileDialog1 = Nothing
                Try
                    Cursor = Cursors.WaitCursor
                    aBP.SaveToFile(sUseFilename)
                    Cursor = Cursors.Default
                Catch ex As Exception
                    MsgBox("Error Saving Bodypart " & ex.ToString)
                End Try
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuSaveBodyPartStreamToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveBodyPartStreamToFile.Click

        If Not (TreeView1.SelectedNode Is Nothing) Then
            Dim aBP As CDO.IBodyPart
            Cursor = Cursors.WaitCursor
            aBP = CType(TreeView1.SelectedNode.Tag, CDO.IBodyPart)

            Dim aStream As ADODB.Stream
            Dim sFilename As String
            Dim bGotStream As Boolean = False
            aStream = New ADODB.Stream
            Try
                aStream = aBP.GetStream
                bGotStream = True
            Catch ex As Exception
                MsgBox("Error Extracting stream: " & ex.Message)
            End Try
            If bGotStream = True Then
                sFilename = aBP.FileName
                If sFilename = "" Then
                    sFilename = "BodyPartStream (" & TreeView1.SelectedNode.Text & ").txt"
                Else
                    sFilename = "BodyPartStream - " & sFilename
                End If
                Cursor = Cursors.WaitCursor
                SaveBodyPart(aStream, sFilename)
                Cursor = Cursors.Default
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub mnuSaveEncodedBodyPartToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveEncodedBodyPartToFile.Click
        If Not (TreeView1.SelectedNode Is Nothing) Then
            Dim aBP As CDO.IBodyPart
            Cursor = Cursors.WaitCursor
            aBP = CType(TreeView1.SelectedNode.Tag, CDO.IBodyPart)

            Dim aStream As ADODB.Stream
            Dim sFilename As String
            Dim bGotStream As Boolean = False
            aStream = New ADODB.Stream
            Try
                aStream = aBP.GetEncodedContentStream
                bGotStream = True
            Catch ex As Exception
                MsgBox("Error Extracting stream: " & ex.Message)
            End Try
            If bGotStream = True Then
                sFilename = aBP.FileName
                If sFilename = "" Then
                    sFilename = "EncodedBodyPart (" & TreeView1.SelectedNode.Text & ").txt"
                Else
                    sFilename = "EncodedBodyPart - " & sFilename
                End If
                SaveBodyPart(aStream, sFilename)
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub mnuSaveDecodedBodyPartToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaveDecodedBodyPartToFile.Click
        If Not (TreeView1.SelectedNode Is Nothing) Then
            Dim aBP As CDO.IBodyPart
            Cursor = Cursors.WaitCursor
            aBP = CType(TreeView1.SelectedNode.Tag, CDO.IBodyPart)

            Dim aStream As ADODB.Stream
            Dim sFilename As String
            Dim bGotStream As Boolean = False
            aStream = New ADODB.Stream
            Try
                aStream = aBP.GetDecodedContentStream
                bGotStream = True
            Catch ex As Exception
                MsgBox("Error Extracting stream: " & ex.Message)
            End Try
            If bGotStream = True Then
                sFilename = aBP.FileName
                If sFilename = "" Then
                    sFilename = "DecodedBodyPart (" & TreeView1.SelectedNode.Text & ").txt"
                Else
                    sFilename = "DecodedBodyPart - " & sFilename
                End If
                SaveBodyPart(aStream, sFilename)
            End If
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        'Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog
        Dim sText As String = ""

        Dim sDataPath As String
        sDataPath = txtFileName.Text.ToString   'Application.LocalUserAppDataPath() & "\Data"


        openFileDialog1.InitialDirectory = sDataPath
        openFileDialog1.Filter = "eml files (*.eml)|*.eml |txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'openFileDialog1.Filter = "txt files (*.txt)|*.txt |All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 3

        bLoaded = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Insert code to read the stream here.
            txtFileName.Text = openFileDialog1.FileName
            bLoaded = True

        End If
    End Sub

    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Me.ListView1.ListViewItemSorter = New MyApp.ListViewItemComparer(e.Column)
        ListView1.Sort()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub lvAttachments_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAttachments.Click

    End Sub

    Private Sub lvAttachments_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvAttachments.ColumnClick
        Me.lvAttachments.ListViewItemSorter = New MyApp.ListViewItemComparer(e.Column)
        lvAttachments.Sort()
    End Sub

    Private Sub lvAttachments_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAttachments.SelectedIndexChanged

    End Sub

    Private Sub ListView2_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView2.ColumnClick
        Me.ListView2.ListViewItemSorter = New MyApp.ListViewItemComparer(e.Column)
        ListView2.Sort()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub cmsMime_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMime_Copy.Click
        MyApp.TextEdit.RichText.CopySelection(txtMime)
    End Sub

    Private Sub cmsMime_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyApp.TextEdit.RichText.Undo(txtMime)
    End Sub

    Private Sub cmsMime_Paste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyApp.TextEdit.RichText.PasteSelection(txtMime)
    End Sub

    Private Sub cmsMime_Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyApp.TextEdit.RichText.CutSelection(txtMime)
    End Sub

    Private Sub cmsMime_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMime_SelectAll.Click
        txtMime.SelectAll()
    End Sub

    Private Sub cmsBPStream_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPStream_SelectAll.Click
        txtStream.SelectAll()
    End Sub

    Private Sub cmsBPStream_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPStream_Copy.Click
        MyApp.TextEdit.RichText.CopySelection(txtStream)
    End Sub

    Private Sub cmsBPEncStream_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPEncStream_Copy.Click
        MyApp.TextEdit.RichText.CopySelection(txtEncoded)
    End Sub

    Private Sub cmsBPEncStream_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPEncStream_SelectAll.Click
        txtEncoded.SelectAll()
    End Sub

    Private Sub cmsBPDecStream_Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPDecStream_Copy.Click
        MyApp.TextEdit.RichText.CopySelection(txtDecoded)
    End Sub

    Private Sub cmsBPDecStream_SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBPDecStream_SelectAll.Click
        txtDecoded.SelectAll()
    End Sub
End Class