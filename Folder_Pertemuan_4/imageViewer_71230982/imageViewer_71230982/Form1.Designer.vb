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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusReady = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusDimension = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusBIts = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusResolution = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusRawFormat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.lvImage = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainerUtama = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerBawah = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerBawah2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvExif = New System.Windows.Forms.ListView()
        Me.chProperty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerUtama.Panel1.SuspendLayout()
        Me.SplitContainerUtama.Panel2.SuspendLayout()
        Me.SplitContainerUtama.SuspendLayout()
        CType(Me.SplitContainerBawah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBawah.Panel1.SuspendLayout()
        Me.SplitContainerBawah.Panel2.SuspendLayout()
        Me.SplitContainerBawah.SuspendLayout()
        CType(Me.SplitContainerBawah2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBawah2.Panel1.SuspendLayout()
        Me.SplitContainerBawah2.Panel2.SuspendLayout()
        Me.SplitContainerBawah2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "211677_image_icon.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusReady, Me.ToolStripStatusDimension, Me.ToolStripStatusBIts, Me.ToolStripStatusResolution, Me.ToolStripStatusRawFormat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 414)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(819, 36)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusReady
        '
        Me.ToolStripStatusReady.Name = "ToolStripStatusReady"
        Me.ToolStripStatusReady.Size = New System.Drawing.Size(64, 29)
        Me.ToolStripStatusReady.Text = "Ready."
        '
        'ToolStripStatusDimension
        '
        Me.ToolStripStatusDimension.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusDimension.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusDimension.Name = "ToolStripStatusDimension"
        Me.ToolStripStatusDimension.Size = New System.Drawing.Size(109, 29)
        Me.ToolStripStatusDimension.Text = "Dimensions"
        '
        'ToolStripStatusBIts
        '
        Me.ToolStripStatusBIts.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusBIts.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusBIts.Name = "ToolStripStatusBIts"
        Me.ToolStripStatusBIts.Size = New System.Drawing.Size(83, 29)
        Me.ToolStripStatusBIts.Text = "# of bits"
        '
        'ToolStripStatusResolution
        '
        Me.ToolStripStatusResolution.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusResolution.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusResolution.Name = "ToolStripStatusResolution"
        Me.ToolStripStatusResolution.Size = New System.Drawing.Size(99, 29)
        Me.ToolStripStatusResolution.Text = "Resolution"
        '
        'ToolStripStatusRawFormat
        '
        Me.ToolStripStatusRawFormat.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusRawFormat.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.ToolStripStatusRawFormat.Name = "ToolStripStatusRawFormat"
        Me.ToolStripStatusRawFormat.Size = New System.Drawing.Size(111, 29)
        Me.ToolStripStatusRawFormat.Text = "Raw Format"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        '
        'tvDrive
        '
        Me.tvDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.imageList1
        Me.tvDrive.Location = New System.Drawing.Point(0, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(178, 414)
        Me.tvDrive.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tvDrive, "Please select drive/folder that contain one or more images")
        '
        'lvImage
        '
        Me.lvImage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chExtension, Me.chFileSize, Me.chLastModified, Me.chLastAccessed, Me.chCreatedDate, Me.chAttributes})
        Me.lvImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvImage.GridLines = True
        Me.lvImage.HideSelection = False
        Me.lvImage.Location = New System.Drawing.Point(0, 0)
        Me.lvImage.Name = "lvImage"
        Me.lvImage.Size = New System.Drawing.Size(637, 242)
        Me.lvImage.SmallImageList = Me.imageList1
        Me.lvImage.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lvImage, "Image file(s)")
        Me.lvImage.UseCompatibleStateImageBehavior = False
        Me.lvImage.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 287
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        Me.chExtension.Width = 111
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        Me.chFileSize.Width = 115
        '
        'chLastModified
        '
        Me.chLastModified.Text = "Last Modified"
        Me.chLastModified.Width = 125
        '
        'chLastAccessed
        '
        Me.chLastAccessed.Text = "Last Accessed"
        Me.chLastAccessed.Width = 133
        '
        'chCreatedDate
        '
        Me.chCreatedDate.Text = "Created Date"
        Me.chCreatedDate.Width = 129
        '
        'chAttributes
        '
        Me.chAttributes.Text = "Attributes"
        Me.chAttributes.Width = 184
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Double click to view this image in auto size mode!")
        '
        'SplitContainerUtama
        '
        Me.SplitContainerUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerUtama.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerUtama.Name = "SplitContainerUtama"
        '
        'SplitContainerUtama.Panel1
        '
        Me.SplitContainerUtama.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainerUtama.Panel2
        '
        Me.SplitContainerUtama.Panel2.Controls.Add(Me.SplitContainerBawah)
        Me.SplitContainerUtama.Size = New System.Drawing.Size(819, 414)
        Me.SplitContainerUtama.SplitterDistance = 178
        Me.SplitContainerUtama.TabIndex = 1
        '
        'SplitContainerBawah
        '
        Me.SplitContainerBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBawah.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBawah.Name = "SplitContainerBawah"
        Me.SplitContainerBawah.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerBawah.Panel1
        '
        Me.SplitContainerBawah.Panel1.Controls.Add(Me.lvImage)
        Me.SplitContainerBawah.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SplitContainerBawah.Panel2
        '
        Me.SplitContainerBawah.Panel2.Controls.Add(Me.SplitContainerBawah2)
        Me.SplitContainerBawah.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainerBawah.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainerBawah.Size = New System.Drawing.Size(637, 414)
        Me.SplitContainerBawah.SplitterDistance = 242
        Me.SplitContainerBawah.TabIndex = 0
        '
        'SplitContainerBawah2
        '
        Me.SplitContainerBawah2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBawah2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBawah2.Name = "SplitContainerBawah2"
        '
        'SplitContainerBawah2.Panel1
        '
        Me.SplitContainerBawah2.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainerBawah2.Panel2
        '
        Me.SplitContainerBawah2.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainerBawah2.Size = New System.Drawing.Size(637, 168)
        Me.SplitContainerBawah2.SplitterDistance = 210
        Me.SplitContainerBawah2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(210, 168)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PropertyGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(202, 135)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Properties"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(202, 135)
        Me.PropertyGrid1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvExif)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(202, 135)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "EXIV Metadata"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvExif
        '
        Me.lvExif.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProperty, Me.chValue})
        Me.lvExif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvExif.GridLines = True
        Me.lvExif.HideSelection = False
        Me.lvExif.Location = New System.Drawing.Point(0, 0)
        Me.lvExif.Name = "lvExif"
        Me.lvExif.Size = New System.Drawing.Size(202, 135)
        Me.lvExif.TabIndex = 0
        Me.lvExif.UseCompatibleStateImageBehavior = False
        Me.lvExif.View = System.Windows.Forms.View.Details
        '
        'chProperty
        '
        Me.chProperty.Text = "Property"
        '
        'chValue
        '
        Me.chValue.Text = "Value"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 450)
        Me.Controls.Add(Me.SplitContainerUtama)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUtama.Panel1.ResumeLayout(False)
        Me.SplitContainerUtama.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerUtama.ResumeLayout(False)
        Me.SplitContainerBawah.Panel1.ResumeLayout(False)
        Me.SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBawah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBawah.ResumeLayout(False)
        Me.SplitContainerBawah2.Panel1.ResumeLayout(False)
        Me.SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBawah2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBawah2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imageList1 As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusBIts As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainerUtama As SplitContainer
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents lvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PropertyGrid1 As PropertyGrid
End Class
