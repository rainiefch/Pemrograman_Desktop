<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyFolderPathToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFind = New System.Windows.Forms.Label()
        Me.cbFind = New System.Windows.Forms.ComboBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.lvFile = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 418)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1171, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(681, 25)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Ready"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 24)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportFileToolStripMenuItem, Me.RefreshFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportFileToolStripMenuItem
        '
        Me.ExportFileToolStripMenuItem.Name = "ExportFileToolStripMenuItem"
        Me.ExportFileToolStripMenuItem.Size = New System.Drawing.Size(315, 34)
        Me.ExportFileToolStripMenuItem.Text = "Export File List to Text File"
        '
        'RefreshFolderToolStripMenuItem
        '
        Me.RefreshFolderToolStripMenuItem.Name = "RefreshFolderToolStripMenuItem"
        Me.RefreshFolderToolStripMenuItem.Size = New System.Drawing.Size(315, 34)
        Me.RefreshFolderToolStripMenuItem.Text = "Refresh Folder"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(312, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(315, 34)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(164, 34)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(161, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "drive.bmp")
        Me.ImageList1.Images.SetKeyName(1, "folder.bmp")
        Me.ImageList1.Images.SetKeyName(2, "file.bmp")
        Me.ImageList1.Images.SetKeyName(3, "exe.bmp")
        Me.ImageList1.Images.SetKeyName(4, "image.ico")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenFolderToolStripMenuItem, Me.CopyPathToolStripMenuItem1, Me.CopyFolderPathToClipboardToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(326, 164)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(325, 32)
        Me.OpenToolStripMenuItem.Text = "Open/Execute File"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(325, 32)
        Me.OpenFolderToolStripMenuItem.Text = "Open and Select File in Folder"
        '
        'CopyPathToolStripMenuItem1
        '
        Me.CopyPathToolStripMenuItem1.Name = "CopyPathToolStripMenuItem1"
        Me.CopyPathToolStripMenuItem1.Size = New System.Drawing.Size(325, 32)
        Me.CopyPathToolStripMenuItem1.Text = "Copy Folder Path to Clipboard"
        '
        'CopyFolderPathToClipboardToolStripMenuItem
        '
        Me.CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        Me.CopyFolderPathToClipboardToolStripMenuItem.Size = New System.Drawing.Size(325, 32)
        Me.CopyFolderPathToClipboardToolStripMenuItem.Text = "Open and Select File in Folder"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(325, 32)
        Me.ToolStripMenuItem3.Text = "Copy Full Path to Clipboard"
        '
        'CopyPathToolStripMenuItem
        '
        Me.CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        Me.CopyPathToolStripMenuItem.Size = New System.Drawing.Size(325, 32)
        Me.CopyPathToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(21, 13)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(44, 20)
        Me.lblFind.TabIndex = 3
        Me.lblFind.Text = "Find:"
        '
        'cbFind
        '
        Me.cbFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.cbFind.FormattingEnabled = True
        Me.cbFind.Location = New System.Drawing.Point(71, 13)
        Me.cbFind.Name = "cbFind"
        Me.cbFind.Size = New System.Drawing.Size(566, 28)
        Me.cbFind.TabIndex = 4
        '
        'txtExtension
        '
        Me.txtExtension.Location = New System.Drawing.Point(643, 15)
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(63, 26)
        Me.txtExtension.TabIndex = 5
        Me.txtExtension.Text = "*.*"
        '
        'btnSearch
        '
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.Location = New System.Drawing.Point(1096, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 385)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblFind)
        Me.Panel1.Controls.Add(Me.cbFind)
        Me.Panel1.Controls.Add(Me.txtExtension)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 61)
        Me.Panel1.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 94)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvFile)
        Me.SplitContainer1.Size = New System.Drawing.Size(1096, 324)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblInfo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 115)
        Me.Panel2.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(9, 10)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(171, 20)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Free Fixed Disk Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 0
        '
        'tvDrive
        '
        Me.tvDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.ImageList1
        Me.tvDrive.Location = New System.Drawing.Point(0, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(364, 205)
        Me.tvDrive.TabIndex = 0
        '
        'lvFile
        '
        Me.lvFile.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvFile.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvFile.GridLines = True
        Me.lvFile.HideSelection = False
        Me.lvFile.Location = New System.Drawing.Point(0, 0)
        Me.lvFile.Name = "lvFile"
        Me.lvFile.Size = New System.Drawing.Size(728, 324)
        Me.lvFile.SmallImageList = Me.ImageList1
        Me.lvFile.TabIndex = 0
        Me.lvFile.UseCompatibleStateImageBehavior = False
        Me.lvFile.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extension"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "File SIze"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Modified"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Last Accessed"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Create Date"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Attributes"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Full Path"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(364, 324)
        Me.SplitContainer2.SplitterDistance = 205
        Me.SplitContainer2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Finder"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblFind As Label
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lvFile As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel2 As Panel
End Class
