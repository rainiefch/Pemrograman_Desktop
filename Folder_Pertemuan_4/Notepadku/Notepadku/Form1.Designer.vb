<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.pageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.findToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.findNextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.replaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.goToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.insertDateTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.formatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.wordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutNotepadkuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatusReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatusLine = New System.Windows.Forms.ToolStripStatusLabel()
        Me.insertStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.capsStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.numStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.printDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtNotepad = New System.Windows.Forms.TextBox()
        Me.menuStrip1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.formatToolStripMenuItem, Me.viewToolStripMenuItem, Me.aboutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "MenuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.pageSetupToolStripMenuItem, Me.printToolStripMenuItem, Me.ToolStripSeparator2, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.newToolStripMenuItem.Text = "New"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.openToolStripMenuItem.Text = "Open"
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.saveToolStripMenuItem.Text = "Save"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.saveAsToolStripMenuItem.Text = "Save as"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(267, 6)
        '
        'pageSetupToolStripMenuItem
        '
        Me.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem"
        Me.pageSetupToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.pageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.printToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(267, 6)
        '
        'closeToolStripMenuItem
        '
        Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
        Me.closeToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.closeToolStripMenuItem.Text = "Close"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripSeparator3, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.ToolStripSeparator4, Me.findToolStripMenuItem, Me.findNextToolStripMenuItem, Me.replaceToolStripMenuItem, Me.goToToolStripMenuItem, Me.ToolStripSeparator5, Me.selectAllToolStripMenuItem, Me.insertDateTimeToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.editToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(240, 6)
        '
        'cutToolStripMenuItem
        '
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.cutToolStripMenuItem.Text = "Cut"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.copyToolStripMenuItem.Text = "Copy"
        '
        'pasteToolStripMenuItem
        '
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.pasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(240, 6)
        '
        'findToolStripMenuItem
        '
        Me.findToolStripMenuItem.Name = "findToolStripMenuItem"
        Me.findToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.findToolStripMenuItem.Text = "Find"
        '
        'findNextToolStripMenuItem
        '
        Me.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem"
        Me.findNextToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.findNextToolStripMenuItem.Text = "Find Next"
        '
        'replaceToolStripMenuItem
        '
        Me.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem"
        Me.replaceToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.replaceToolStripMenuItem.Text = "Replace..."
        '
        'goToToolStripMenuItem
        '
        Me.goToToolStripMenuItem.Name = "goToToolStripMenuItem"
        Me.goToToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.goToToolStripMenuItem.Text = "Go To..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(240, 6)
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.selectAllToolStripMenuItem.Text = "Select All"
        '
        'insertDateTimeToolStripMenuItem
        '
        Me.insertDateTimeToolStripMenuItem.Name = "insertDateTimeToolStripMenuItem"
        Me.insertDateTimeToolStripMenuItem.Size = New System.Drawing.Size(243, 34)
        Me.insertDateTimeToolStripMenuItem.Text = "Insert Date Time"
        '
        'formatToolStripMenuItem
        '
        Me.formatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.wordWrapToolStripMenuItem, Me.fontToolStripMenuItem})
        Me.formatToolStripMenuItem.Name = "formatToolStripMenuItem"
        Me.formatToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.formatToolStripMenuItem.Text = "Format"
        '
        'wordWrapToolStripMenuItem
        '
        Me.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem"
        Me.wordWrapToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.wordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'fontToolStripMenuItem
        '
        Me.fontToolStripMenuItem.Name = "fontToolStripMenuItem"
        Me.fontToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.fontToolStripMenuItem.Text = "Font"
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusBarToolStripMenuItem})
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.viewToolStripMenuItem.Text = "View"
        '
        'statusBarToolStripMenuItem
        '
        Me.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem"
        Me.statusBarToolStripMenuItem.Size = New System.Drawing.Size(192, 34)
        Me.statusBarToolStripMenuItem.Text = "Status Bar"
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.helpToolStripMenuItem, Me.ToolStripSeparator6, Me.aboutNotepadkuToolStripMenuItem})
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(258, 34)
        Me.helpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(255, 6)
        '
        'aboutNotepadkuToolStripMenuItem
        '
        Me.aboutNotepadkuToolStripMenuItem.Name = "aboutNotepadkuToolStripMenuItem"
        Me.aboutNotepadkuToolStripMenuItem.Size = New System.Drawing.Size(258, 34)
        Me.aboutNotepadkuToolStripMenuItem.Text = "About Notepadku"
        '
        'statusStrip1
        '
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusReady, Me.toolStripStatusLine, Me.insertStripStatus, Me.capsStripStatus, Me.numStripStatus})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(800, 36)
        Me.statusStrip1.TabIndex = 1
        Me.statusStrip1.Text = "StatusStrip1"
        '
        'toolStripStatusReady
        '
        Me.toolStripStatusReady.Name = "toolStripStatusReady"
        Me.toolStripStatusReady.Size = New System.Drawing.Size(64, 29)
        Me.toolStripStatusReady.Text = "Ready."
        '
        'toolStripStatusLine
        '
        Me.toolStripStatusLine.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.toolStripStatusLine.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.toolStripStatusLine.Name = "toolStripStatusLine"
        Me.toolStripStatusLine.Size = New System.Drawing.Size(66, 29)
        Me.toolStripStatusLine.Text = "Line: 1"
        '
        'insertStripStatus
        '
        Me.insertStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.insertStripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.insertStripStatus.Enabled = False
        Me.insertStripStatus.Name = "insertStripStatus"
        Me.insertStripStatus.Size = New System.Drawing.Size(44, 29)
        Me.insertStripStatus.Text = "INS"
        '
        'capsStripStatus
        '
        Me.capsStripStatus.Name = "capsStripStatus"
        Me.capsStripStatus.Size = New System.Drawing.Size(55, 29)
        Me.capsStripStatus.Text = "CAPS"
        '
        'numStripStatus
        '
        Me.numStripStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.numStripStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.numStripStatus.Enabled = False
        Me.numStripStatus.Name = "numStripStatus"
        Me.numStripStatus.Size = New System.Drawing.Size(57, 29)
        Me.numStripStatus.Text = "NUM"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "*.txt"
        Me.openFileDialog1.FileName = "Untitled"
        Me.openFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        Me.openFileDialog1.Title = "Open File Text"
        '
        'printDialog1
        '
        Me.printDialog1.UseEXDialog = True
        '
        'pageSetupDialog1
        '
        Me.pageSetupDialog1.EnableMetric = True
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "*.txt"
        Me.saveFileDialog1.FileName = "Untitled.txt"
        Me.saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        Me.saveFileDialog1.Title = "Save File Text as"
        '
        'txtNotepad
        '
        Me.txtNotepad.AcceptsReturn = True
        Me.txtNotepad.AcceptsTab = True
        Me.txtNotepad.AllowDrop = True
        Me.txtNotepad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotepad.Location = New System.Drawing.Point(0, 33)
        Me.txtNotepad.Multiline = True
        Me.txtNotepad.Name = "txtNotepad"
        Me.txtNotepad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotepad.Size = New System.Drawing.Size(800, 381)
        Me.txtNotepad.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtNotepad)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.Text = "Notepadku"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents editToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents formatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents viewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents openFileDialog1 As OpenFileDialog
    Friend WithEvents fontDialog1 As FontDialog
    Friend WithEvents printDialog1 As PrintDialog
    Friend WithEvents pageSetupDialog1 As PageSetupDialog
    Friend WithEvents saveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtNotepad As TextBox
    Friend WithEvents newToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents printToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents closeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents pasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents findToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents findNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents replaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents goToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents selectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents insertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents wordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents fontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents aboutNotepadkuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveToolStripMenuItem As ToolStripMenuItem
End Class
