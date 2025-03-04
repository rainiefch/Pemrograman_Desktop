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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpFilename = New System.Windows.Forms.TabPage()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.tpExtension = New System.Windows.Forms.TabPage()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.lblWIthThisE = New System.Windows.Forms.Label()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.tpAutoNumber = New System.Windows.Forms.TabPage()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tpFilename.SuspendLayout()
        Me.tpExtension.SuspendLayout()
        Me.tpAutoNumber.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(29, 28)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(51, 20)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.Window
        Me.txtPath.Location = New System.Drawing.Point(86, 25)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(677, 26)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPath.Location = New System.Drawing.Point(775, 17)
        Me.btnPath.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(69, 34)
        Me.btnPath.TabIndex = 3
        Me.btnPath.Text = "..."
        Me.btnPath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPath.UseVisualStyleBackColor = False
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(864, 28)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(69, 20)
        Me.lblExt.TabIndex = 4
        Me.lblExt.Text = "File Ext"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(939, 25)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(111, 26)
        Me.txtExt.TabIndex = 5
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(29, 65)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(114, 20)
        Me.lblOri.TabIndex = 6
        Me.lblOri.Text = "Original File: "
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(544, 65)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(109, 20)
        Me.lblPreview.TabIndex = 7
        Me.lblPreview.Text = "Preview File:"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(33, 88)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(491, 350)
        Me.lvOri.TabIndex = 8
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        '
        'lvPreview
        '
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvPreview.GridLines = True
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(548, 88)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(502, 350)
        Me.lvPreview.TabIndex = 9
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extension"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attributes"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Created"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Accessed"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date Modified"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpFilename)
        Me.TabControl1.Controls.Add(Me.tpExtension)
        Me.TabControl1.Controls.Add(Me.tpAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(33, 444)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(877, 176)
        Me.TabControl1.TabIndex = 11
        '
        'tpFilename
        '
        Me.tpFilename.BackColor = System.Drawing.Color.White
        Me.tpFilename.Controls.Add(Me.cbCaseF)
        Me.tpFilename.Controls.Add(Me.txtWithThisF)
        Me.tpFilename.Controls.Add(Me.txtInsertAfterF)
        Me.tpFilename.Controls.Add(Me.txtRightCropNCharF)
        Me.tpFilename.Controls.Add(Me.txtLeftCropNCharF)
        Me.tpFilename.Controls.Add(Me.txtInsertBeforeF)
        Me.tpFilename.Controls.Add(Me.txtReplaceThisF)
        Me.tpFilename.Controls.Add(Me.txtReplaceWithF)
        Me.tpFilename.Controls.Add(Me.lblWithThisF)
        Me.tpFilename.Controls.Add(Me.lblCaseF)
        Me.tpFilename.Controls.Add(Me.rbRightCropNCharF)
        Me.tpFilename.Controls.Add(Me.rbLeftCropNCharF)
        Me.tpFilename.Controls.Add(Me.rbInsertAfterF)
        Me.tpFilename.Controls.Add(Me.rbInsertBeforeF)
        Me.tpFilename.Controls.Add(Me.rbReplaceThisF)
        Me.tpFilename.Controls.Add(Me.rbReplaceWithF)
        Me.tpFilename.Location = New System.Drawing.Point(4, 29)
        Me.tpFilename.Name = "tpFilename"
        Me.tpFilename.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFilename.Size = New System.Drawing.Size(869, 143)
        Me.tpFilename.TabIndex = 0
        Me.tpFilename.Text = "Filename"
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(645, 14)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(214, 28)
        Me.cbCaseF.TabIndex = 15
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(575, 44)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.Size = New System.Drawing.Size(284, 26)
        Me.txtWithThisF.TabIndex = 14
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(575, 76)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.Size = New System.Drawing.Size(284, 26)
        Me.txtInsertAfterF.TabIndex = 13
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(624, 105)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(194, 26)
        Me.txtRightCropNCharF.TabIndex = 12
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(176, 106)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(201, 26)
        Me.txtLeftCropNCharF.TabIndex = 11
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(176, 73)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(256, 26)
        Me.txtInsertBeforeF.TabIndex = 10
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(176, 41)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.Size = New System.Drawing.Size(311, 26)
        Me.txtReplaceThisF.TabIndex = 9
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(176, 9)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.Size = New System.Drawing.Size(393, 26)
        Me.txtReplaceWithF.TabIndex = 8
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(490, 47)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(79, 20)
        Me.lblWithThisF.TabIndex = 7
        Me.lblWithThisF.Text = "With this"
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(584, 17)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(55, 20)
        Me.lblCaseF.TabIndex = 6
        Me.lblCaseF.Text = "Case:"
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(443, 107)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(175, 24)
        Me.rbRightCropNCharF.TabIndex = 5
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right Crop n char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(6, 107)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(164, 24)
        Me.rbLeftCropNCharF.TabIndex = 4
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left Crop n char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertAfterF
        '
        Me.rbInsertAfterF.AutoSize = True
        Me.rbInsertAfterF.Location = New System.Drawing.Point(443, 75)
        Me.rbInsertAfterF.Name = "rbInsertAfterF"
        Me.rbInsertAfterF.Size = New System.Drawing.Size(126, 24)
        Me.rbInsertAfterF.TabIndex = 3
        Me.rbInsertAfterF.TabStop = True
        Me.rbInsertAfterF.Text = "Insert After"
        Me.rbInsertAfterF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(6, 77)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(140, 24)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.TabStop = True
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(6, 46)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(138, 24)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "Replace This"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.AutoSize = True
        Me.rbReplaceWithF.Location = New System.Drawing.Point(6, 15)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(146, 24)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace With:"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'tpExtension
        '
        Me.tpExtension.Controls.Add(Me.cbCaseE)
        Me.tpExtension.Controls.Add(Me.txtWithThisE)
        Me.tpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.tpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.tpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.tpExtension.Controls.Add(Me.lblWIthThisE)
        Me.tpExtension.Controls.Add(Me.lblCaseE)
        Me.tpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.tpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.tpExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.tpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.tpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.tpExtension.Location = New System.Drawing.Point(4, 29)
        Me.tpExtension.Name = "tpExtension"
        Me.tpExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.tpExtension.Size = New System.Drawing.Size(869, 143)
        Me.tpExtension.TabIndex = 1
        Me.tpExtension.Text = "Extension"
        Me.tpExtension.UseVisualStyleBackColor = True
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(647, 15)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(214, 28)
        Me.cbCaseE.TabIndex = 31
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(577, 45)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(284, 26)
        Me.txtWithThisE.TabIndex = 30
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(577, 77)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(284, 26)
        Me.txtInsertAfterE.TabIndex = 29
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(626, 106)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(194, 26)
        Me.txtRightCropNCharE.TabIndex = 28
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(178, 107)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(201, 26)
        Me.txtLeftCropNCharE.TabIndex = 27
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(178, 74)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(256, 26)
        Me.txtInsertBeforeE.TabIndex = 26
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(178, 42)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(311, 26)
        Me.txtReplaceThisE.TabIndex = 25
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(178, 10)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(393, 26)
        Me.txtReplaceWithE.TabIndex = 24
        '
        'lblWIthThisE
        '
        Me.lblWIthThisE.AutoSize = True
        Me.lblWIthThisE.Location = New System.Drawing.Point(492, 48)
        Me.lblWIthThisE.Name = "lblWIthThisE"
        Me.lblWIthThisE.Size = New System.Drawing.Size(79, 20)
        Me.lblWIthThisE.TabIndex = 23
        Me.lblWIthThisE.Text = "With this"
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(586, 18)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(55, 20)
        Me.lblCaseE.TabIndex = 22
        Me.lblCaseE.Text = "Case:"
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(445, 108)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(175, 24)
        Me.rbRightCropNCharE.TabIndex = 21
        Me.rbRightCropNCharE.TabStop = True
        Me.rbRightCropNCharE.Text = "Right Crop n char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(8, 108)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(164, 24)
        Me.rbLeftCropNCharE.TabIndex = 20
        Me.rbLeftCropNCharE.TabStop = True
        Me.rbLeftCropNCharE.Text = "Left Crop n char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(445, 76)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(126, 24)
        Me.rbInsertAfterE.TabIndex = 19
        Me.rbInsertAfterE.TabStop = True
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(8, 78)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(140, 24)
        Me.rbInsertBeforeE.TabIndex = 18
        Me.rbInsertBeforeE.TabStop = True
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(8, 47)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(138, 24)
        Me.rbReplaceThisE.TabIndex = 17
        Me.rbReplaceThisE.TabStop = True
        Me.rbReplaceThisE.Text = "Replace This"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(8, 16)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(146, 24)
        Me.rbReplaceWithE.TabIndex = 16
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With:"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'tpAutoNumber
        '
        Me.tpAutoNumber.Controls.Add(Me.gbWith)
        Me.tpAutoNumber.Controls.Add(Me.gbPlace)
        Me.tpAutoNumber.Location = New System.Drawing.Point(4, 29)
        Me.tpAutoNumber.Name = "tpAutoNumber"
        Me.tpAutoNumber.Size = New System.Drawing.Size(869, 143)
        Me.tpAutoNumber.TabIndex = 2
        Me.tpAutoNumber.Text = "Autonumber"
        Me.tpAutoNumber.UseVisualStyleBackColor = True
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lblIncrementBy)
        Me.gbWith.Controls.Add(Me.lblStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(270, 18)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Size = New System.Drawing.Size(346, 109)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With:"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(206, 66)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 26)
        Me.nudIncrementBy.TabIndex = 3
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(206, 32)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 26)
        Me.nudStartWithNumber.TabIndex = 2
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(21, 68)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(118, 20)
        Me.lblIncrementBy.TabIndex = 1
        Me.lblIncrementBy.Text = "Increment by:"
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(21, 34)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(156, 20)
        Me.lblStartWithNumber.TabIndex = 0
        Me.lblStartWithNumber.Text = "Start with number:"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(19, 18)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(227, 109)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place:"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(17, 66)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(151, 24)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before fileame"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(17, 32)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(147, 24)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(928, 474)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(122, 31)
        Me.btnPreview.TabIndex = 0
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(928, 511)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(122, 32)
        Me.btnRename.TabIndex = 12
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(928, 549)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(122, 32)
        Me.btnUndo.TabIndex = 13
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 632)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.lblExt)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabControl1.ResumeLayout(False)
        Me.tpFilename.ResumeLayout(False)
        Me.tpFilename.PerformLayout()
        Me.tpExtension.ResumeLayout(False)
        Me.tpExtension.PerformLayout()
        Me.tpAutoNumber.ResumeLayout(False)
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpFilename As TabPage
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents tpAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWIthThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents ImageList1 As ImageList
End Class
