<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label8 = New System.Windows.Forms.Label
        Me.lvAttachments = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.cmsBPEncStream_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBPEncStream_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.Label7 = New System.Windows.Forms.Label
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.txtStream = New System.Windows.Forms.RichTextBox
        Me.cmsBPStream = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBPStream_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBPStream_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsBPEncStream = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtEncoded = New System.Windows.Forms.RichTextBox
        Me.txtDecoded = New System.Windows.Forms.RichTextBox
        Me.cmsBPDecStream = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBPDecStream_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsBPDecStream_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsMime_Copy = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsMime = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmsMime_SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.txtMime = New System.Windows.Forms.RichTextBox
        Me.mnuSaveBodyPartToFile = New System.Windows.Forms.MenuItem
        Me.CmBpTree = New System.Windows.Forms.ContextMenu
        Me.mnuSaveEncodedBodyPartToFile = New System.Windows.Forms.MenuItem
        Me.mnuSaveDecodedBodyPartToFile = New System.Windows.Forms.MenuItem
        Me.mnuSaveBodyPartStreamToFile = New System.Windows.Forms.MenuItem
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColValue = New System.Windows.Forms.ColumnHeader
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.cmsBPStream.SuspendLayout()
        Me.cmsBPEncStream.SuspendLayout()
        Me.cmsBPDecStream.SuspendLayout()
        Me.cmsMime.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label8.Location = New System.Drawing.Point(252, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Attachments"
        '
        'lvAttachments
        '
        Me.lvAttachments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAttachments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader8, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvAttachments.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvAttachments.FullRowSelect = True
        Me.lvAttachments.HideSelection = False
        Me.lvAttachments.LabelWrap = False
        Me.lvAttachments.Location = New System.Drawing.Point(252, 185)
        Me.lvAttachments.Name = "lvAttachments"
        Me.lvAttachments.Size = New System.Drawing.Size(648, 104)
        Me.lvAttachments.TabIndex = 28
        Me.lvAttachments.UseCompatibleStateImageBehavior = False
        Me.lvAttachments.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Content Media Type"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Content Transfer Encoding"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Charset"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Content Class"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Content Class Name"
        Me.ColumnHeader6.Width = 90
        '
        'cmsBPEncStream_Copy
        '
        Me.cmsBPEncStream_Copy.Name = "cmsBPEncStream_Copy"
        Me.cmsBPEncStream_Copy.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPEncStream_Copy.Text = "Copy"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(114, 6)
        '
        'cmsBPEncStream_SelectAll
        '
        Me.cmsBPEncStream_SelectAll.Name = "cmsBPEncStream_SelectAll"
        Me.cmsBPEncStream_SelectAll.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPEncStream_SelectAll.Text = "Select All"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Location = New System.Drawing.Point(452, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Bodypart Stream"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(114, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(114, 6)
        '
        'txtStream
        '
        Me.txtStream.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStream.ContextMenuStrip = Me.cmsBPStream
        Me.txtStream.HideSelection = False
        Me.txtStream.Location = New System.Drawing.Point(452, 305)
        Me.txtStream.Name = "txtStream"
        Me.txtStream.Size = New System.Drawing.Size(448, 72)
        Me.txtStream.TabIndex = 34
        Me.txtStream.Text = ""
        '
        'cmsBPStream
        '
        Me.cmsBPStream.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.cmsBPStream_Copy, Me.ToolStripSeparator4, Me.cmsBPStream_SelectAll})
        Me.cmsBPStream.Name = "cmsRequest"
        Me.cmsBPStream.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsBPStream.ShowCheckMargin = True
        Me.cmsBPStream.ShowImageMargin = False
        Me.cmsBPStream.Size = New System.Drawing.Size(118, 60)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(114, 6)
        '
        'cmsBPStream_Copy
        '
        Me.cmsBPStream_Copy.Name = "cmsBPStream_Copy"
        Me.cmsBPStream_Copy.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPStream_Copy.Text = "Copy"
        '
        'cmsBPStream_SelectAll
        '
        Me.cmsBPStream_SelectAll.Name = "cmsBPStream_SelectAll"
        Me.cmsBPStream_SelectAll.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPStream_SelectAll.Text = "Select All"
        '
        'cmsBPEncStream
        '
        Me.cmsBPEncStream.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.cmsBPEncStream_Copy, Me.ToolStripSeparator6, Me.cmsBPEncStream_SelectAll})
        Me.cmsBPEncStream.Name = "cmsRequest"
        Me.cmsBPEncStream.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsBPEncStream.ShowCheckMargin = True
        Me.cmsBPEncStream.ShowImageMargin = False
        Me.cmsBPEncStream.Size = New System.Drawing.Size(118, 60)
        '
        'txtEncoded
        '
        Me.txtEncoded.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEncoded.ContextMenuStrip = Me.cmsBPEncStream
        Me.txtEncoded.HideSelection = False
        Me.txtEncoded.Location = New System.Drawing.Point(452, 393)
        Me.txtEncoded.Name = "txtEncoded"
        Me.txtEncoded.Size = New System.Drawing.Size(448, 72)
        Me.txtEncoded.TabIndex = 36
        Me.txtEncoded.Text = ""
        '
        'txtDecoded
        '
        Me.txtDecoded.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDecoded.ContextMenuStrip = Me.cmsBPDecStream
        Me.txtDecoded.HideSelection = False
        Me.txtDecoded.Location = New System.Drawing.Point(452, 481)
        Me.txtDecoded.Name = "txtDecoded"
        Me.txtDecoded.Size = New System.Drawing.Size(448, 72)
        Me.txtDecoded.TabIndex = 38
        Me.txtDecoded.Text = ""
        '
        'cmsBPDecStream
        '
        Me.cmsBPDecStream.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.cmsBPDecStream_Copy, Me.ToolStripSeparator8, Me.cmsBPDecStream_SelectAll})
        Me.cmsBPDecStream.Name = "cmsRequest"
        Me.cmsBPDecStream.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsBPDecStream.ShowCheckMargin = True
        Me.cmsBPDecStream.ShowImageMargin = False
        Me.cmsBPDecStream.Size = New System.Drawing.Size(118, 60)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(114, 6)
        '
        'cmsBPDecStream_Copy
        '
        Me.cmsBPDecStream_Copy.Name = "cmsBPDecStream_Copy"
        Me.cmsBPDecStream_Copy.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPDecStream_Copy.Text = "Copy"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(114, 6)
        '
        'cmsBPDecStream_SelectAll
        '
        Me.cmsBPDecStream_SelectAll.Name = "cmsBPDecStream_SelectAll"
        Me.cmsBPDecStream_SelectAll.Size = New System.Drawing.Size(152, 22)
        Me.cmsBPDecStream_SelectAll.Text = "Select All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'cmsMime_Copy
        '
        Me.cmsMime_Copy.Name = "cmsMime_Copy"
        Me.cmsMime_Copy.Size = New System.Drawing.Size(152, 22)
        Me.cmsMime_Copy.Text = "Copy"
        '
        'cmsMime
        '
        Me.cmsMime.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmsMime_Copy, Me.ToolStripSeparator2, Me.cmsMime_SelectAll})
        Me.cmsMime.Name = "cmsRequest"
        Me.cmsMime.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsMime.ShowCheckMargin = True
        Me.cmsMime.ShowImageMargin = False
        Me.cmsMime.Size = New System.Drawing.Size(118, 60)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'cmsMime_SelectAll
        '
        Me.cmsMime_SelectAll.Name = "cmsMime_SelectAll"
        Me.cmsMime_SelectAll.Size = New System.Drawing.Size(152, 22)
        Me.cmsMime_SelectAll.Text = "Select All"
        '
        'txtMime
        '
        Me.txtMime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMime.ContextMenuStrip = Me.cmsMime
        Me.txtMime.HideSelection = False
        Me.txtMime.Location = New System.Drawing.Point(252, 41)
        Me.txtMime.Name = "txtMime"
        Me.txtMime.Size = New System.Drawing.Size(648, 128)
        Me.txtMime.TabIndex = 26
        Me.txtMime.Text = ""
        '
        'mnuSaveBodyPartToFile
        '
        Me.mnuSaveBodyPartToFile.Index = 0
        Me.mnuSaveBodyPartToFile.Text = "Save Bodypart To File"
        '
        'CmBpTree
        '
        Me.CmBpTree.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSaveBodyPartToFile, Me.mnuSaveEncodedBodyPartToFile, Me.mnuSaveDecodedBodyPartToFile, Me.mnuSaveBodyPartStreamToFile})
        '
        'mnuSaveEncodedBodyPartToFile
        '
        Me.mnuSaveEncodedBodyPartToFile.Index = 1
        Me.mnuSaveEncodedBodyPartToFile.Text = "Save Encoded Bodypart Stream To File"
        '
        'mnuSaveDecodedBodyPartToFile
        '
        Me.mnuSaveDecodedBodyPartToFile.Index = 2
        Me.mnuSaveDecodedBodyPartToFile.Text = "Save Decoded Bodypart Stream To File"
        '
        'mnuSaveBodyPartStreamToFile
        '
        Me.mnuSaveBodyPartStreamToFile.Index = 3
        Me.mnuSaveBodyPartStreamToFile.Text = "Save Bodypart Stream To File"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.HideSelection = False
        Me.txtFileName.Location = New System.Drawing.Point(12, 1)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(771, 20)
        Me.txtFileName.TabIndex = 20
        Me.txtFileName.Text = "C:\"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Location = New System.Drawing.Point(452, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Bodypart Encoded Content Stream"
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 212
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(252, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Raw Message Mime"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(12, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Bodypart Fields"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 569)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(912, 16)
        Me.StatusBar1.TabIndex = 39
        Me.StatusBar1.Text = "Not Loaded"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.ContextMenu = Me.CmBpTree
        Me.TreeView1.HideSelection = False
        Me.TreeView1.Location = New System.Drawing.Point(12, 41)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(232, 248)
        Me.TreeView1.TabIndex = 24
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.ColValue})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(12, 305)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(432, 120)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColValue
        '
        Me.ColValue.Text = "Value"
        Me.ColValue.Width = 487
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdLoad.Location = New System.Drawing.Point(789, 1)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(48, 21)
        Me.cmdLoad.TabIndex = 22
        Me.cmdLoad.Text = "Load"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Location = New System.Drawing.Point(452, 465)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Bodypart Decoded Content Stream"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Location = New System.Drawing.Point(12, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Bodypart Properties"
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HideSelection = False
        Me.ListView2.LabelWrap = False
        Me.ListView2.Location = New System.Drawing.Point(12, 441)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(432, 112)
        Me.ListView2.TabIndex = 32
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 212
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 487
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Location = New System.Drawing.Point(12, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Body Parts"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdBrowse.Location = New System.Drawing.Point(843, 2)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(57, 20)
        Me.cmdBrowse.TabIndex = 21
        Me.cmdBrowse.Text = "Browse. . ."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 585)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lvAttachments)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStream)
        Me.Controls.Add(Me.txtEncoded)
        Me.Controls.Add(Me.txtDecoded)
        Me.Controls.Add(Me.txtMime)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Name = "Form1"
        Me.Text = "CdoSys Mime Parser"
        Me.cmsBPStream.ResumeLayout(False)
        Me.cmsBPEncStream.ResumeLayout(False)
        Me.cmsBPDecStream.ResumeLayout(False)
        Me.cmsMime.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lvAttachments As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmsBPEncStream_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBPEncStream_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtStream As System.Windows.Forms.RichTextBox
    Friend WithEvents cmsBPStream As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBPStream_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBPStream_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBPEncStream As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtEncoded As System.Windows.Forms.RichTextBox
    Friend WithEvents txtDecoded As System.Windows.Forms.RichTextBox
    Friend WithEvents cmsBPDecStream As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBPDecStream_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsBPDecStream_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsMime_Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsMime As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmsMime_SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMime As System.Windows.Forms.RichTextBox
    Friend WithEvents mnuSaveBodyPartToFile As System.Windows.Forms.MenuItem
    Friend WithEvents CmBpTree As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuSaveEncodedBodyPartToFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSaveDecodedBodyPartToFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSaveBodyPartStreamToFile As System.Windows.Forms.MenuItem
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
End Class
