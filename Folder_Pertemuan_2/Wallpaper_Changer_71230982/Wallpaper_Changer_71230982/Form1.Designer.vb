<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        lblPath = New Label()
        txtPath = New TextBox()
        TimerWall = New Timer(components)
        timerElapsed = New Timer(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Label3 = New Label()
        btnBrowse = New Button()
        btnRun = New Button()
        PictureBox1 = New PictureBox()
        clbWallpaper = New CheckedListBox()
        cbInterval = New ComboBox()
        lblInterval = New Label()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(885, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(149, 34)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(149, 34)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(164, 34)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(164, 34)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 1
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(24, 55)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(105, 25)
        lblPath.TabIndex = 2
        lblPath.Text = "Folder Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(135, 57)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(616, 31)
        txtPath.TabIndex = 3
        ' 
        ' TimerWall
        ' 
        ' 
        ' timerElapsed
        ' 
        timerElapsed.Interval = 1000
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 512)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(885, 32)
        StatusStrip1.TabIndex = 4
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(60, 25)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(208, 25)
        ToolStripStatusCurrent.Text = "Current Wallpaper : none"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(326, 25)
        Label3.TabIndex = 5
        Label3.Text = "Please select one or more picture below"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(757, 55)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(77, 34)
        btnBrowse.TabIndex = 6
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(747, 469)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(112, 34)
        btnRun.TabIndex = 7
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(17, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 259)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(24, 149)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(380, 340)
        clbWallpaper.TabIndex = 10
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10 secs", "20 secs", "30 secs", "1 minute"})
        cbInterval.Location = New Point(499, 464)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(182, 33)
        cbInterval.TabIndex = 11
        cbInterval.Text = "Select First"
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(423, 464)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(70, 25)
        lblInterval.TabIndex = 12
        lblInterval.Text = "Interval"
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.BackColor = SystemColors.Control
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(439, 131)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(153, 29)
        cbPreview.TabIndex = 13
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(450, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(384, 284)
        Panel1.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(885, 544)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(lblInterval)
        Controls.Add(cbInterval)
        Controls.Add(clbWallpaper)
        Controls.Add(btnRun)
        Controls.Add(btnBrowse)
        Controls.Add(Label3)
        Controls.Add(StatusStrip1)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents TimerWall As Timer
    Friend WithEvents timerElapsed As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel

End Class
