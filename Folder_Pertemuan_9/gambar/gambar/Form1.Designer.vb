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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        PropertyToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HistogramToolStripMenuItem = New ToolStripMenuItem()
        GrayscaleToolStripMenuItem = New ToolStripMenuItem()
        LightenToolStripMenuItem = New ToolStripMenuItem()
        DarkenToolStripMenuItem = New ToolStripMenuItem()
        AddContrastToolStripMenuItem = New ToolStripMenuItem()
        ReduceContrastToolStripMenuItem = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        ShowHistrogramToolStripMenuItem = New ToolStripMenuItem()
        EffectToolStripMenuItem = New ToolStripMenuItem()
        SharpenToolStripMenuItem = New ToolStripMenuItem()
        BlurToolStripMenuItem = New ToolStripMenuItem()
        Rotate90ToolStripMenuItem = New ToolStripMenuItem()
        FlipHorizontalToolStripMenuItem = New ToolStripMenuItem()
        FlipVertikalToolStripMenuItem = New ToolStripMenuItem()
        LightSharpenToolStripMenuItem = New ToolStripMenuItem()
        GaussianBlurToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        EmbossToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HistogramToolStripMenuItem, EffectToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, SaveToolStripMenuItem, PropertyToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(182, 34)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(182, 34)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' PropertyToolStripMenuItem
        ' 
        PropertyToolStripMenuItem.Name = "PropertyToolStripMenuItem"
        PropertyToolStripMenuItem.Size = New Size(182, 34)
        PropertyToolStripMenuItem.Text = "Property"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(182, 34)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HistogramToolStripMenuItem
        ' 
        HistogramToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GrayscaleToolStripMenuItem, LightenToolStripMenuItem, DarkenToolStripMenuItem, AddContrastToolStripMenuItem, ReduceContrastToolStripMenuItem, ResetToolStripMenuItem, ShowHistrogramToolStripMenuItem, EmbossToolStripMenuItem})
        HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        HistogramToolStripMenuItem.Size = New Size(112, 29)
        HistogramToolStripMenuItem.Text = "Histogram"
        ' 
        ' GrayscaleToolStripMenuItem
        ' 
        GrayscaleToolStripMenuItem.Name = "GrayscaleToolStripMenuItem"
        GrayscaleToolStripMenuItem.Size = New Size(270, 34)
        GrayscaleToolStripMenuItem.Text = "Grayscale"
        ' 
        ' LightenToolStripMenuItem
        ' 
        LightenToolStripMenuItem.Name = "LightenToolStripMenuItem"
        LightenToolStripMenuItem.Size = New Size(270, 34)
        LightenToolStripMenuItem.Text = "Lighten"
        ' 
        ' DarkenToolStripMenuItem
        ' 
        DarkenToolStripMenuItem.Name = "DarkenToolStripMenuItem"
        DarkenToolStripMenuItem.Size = New Size(270, 34)
        DarkenToolStripMenuItem.Text = "Darken"
        ' 
        ' AddContrastToolStripMenuItem
        ' 
        AddContrastToolStripMenuItem.Name = "AddContrastToolStripMenuItem"
        AddContrastToolStripMenuItem.Size = New Size(270, 34)
        AddContrastToolStripMenuItem.Text = "Add Contrast"
        ' 
        ' ReduceContrastToolStripMenuItem
        ' 
        ReduceContrastToolStripMenuItem.Name = "ReduceContrastToolStripMenuItem"
        ReduceContrastToolStripMenuItem.Size = New Size(270, 34)
        ReduceContrastToolStripMenuItem.Text = "Reduce Contrast"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(270, 34)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' ShowHistrogramToolStripMenuItem
        ' 
        ShowHistrogramToolStripMenuItem.Name = "ShowHistrogramToolStripMenuItem"
        ShowHistrogramToolStripMenuItem.Size = New Size(270, 34)
        ShowHistrogramToolStripMenuItem.Text = "Show Histrogram"
        ' 
        ' EffectToolStripMenuItem
        ' 
        EffectToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SharpenToolStripMenuItem, BlurToolStripMenuItem, Rotate90ToolStripMenuItem, FlipHorizontalToolStripMenuItem, FlipVertikalToolStripMenuItem, LightSharpenToolStripMenuItem, GaussianBlurToolStripMenuItem})
        EffectToolStripMenuItem.Name = "EffectToolStripMenuItem"
        EffectToolStripMenuItem.Size = New Size(72, 29)
        EffectToolStripMenuItem.Text = "Effect"
        ' 
        ' SharpenToolStripMenuItem
        ' 
        SharpenToolStripMenuItem.Name = "SharpenToolStripMenuItem"
        SharpenToolStripMenuItem.Size = New Size(270, 34)
        SharpenToolStripMenuItem.Text = "Sharpen"
        ' 
        ' BlurToolStripMenuItem
        ' 
        BlurToolStripMenuItem.Name = "BlurToolStripMenuItem"
        BlurToolStripMenuItem.Size = New Size(270, 34)
        BlurToolStripMenuItem.Text = "Blur"
        ' 
        ' Rotate90ToolStripMenuItem
        ' 
        Rotate90ToolStripMenuItem.Name = "Rotate90ToolStripMenuItem"
        Rotate90ToolStripMenuItem.Size = New Size(270, 34)
        Rotate90ToolStripMenuItem.Text = "Rotate 90"
        ' 
        ' FlipHorizontalToolStripMenuItem
        ' 
        FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        FlipHorizontalToolStripMenuItem.Size = New Size(270, 34)
        FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        ' 
        ' FlipVertikalToolStripMenuItem
        ' 
        FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        FlipVertikalToolStripMenuItem.Size = New Size(270, 34)
        FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        ' 
        ' LightSharpenToolStripMenuItem
        ' 
        LightSharpenToolStripMenuItem.Name = "LightSharpenToolStripMenuItem"
        LightSharpenToolStripMenuItem.Size = New Size(270, 34)
        LightSharpenToolStripMenuItem.Text = "Light Sharpen"
        ' 
        ' GaussianBlurToolStripMenuItem
        ' 
        GaussianBlurToolStripMenuItem.Name = "GaussianBlurToolStripMenuItem"
        GaussianBlurToolStripMenuItem.Size = New Size(270, 34)
        GaussianBlurToolStripMenuItem.Text = "Gaussian Blur"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 417)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' EmbossToolStripMenuItem
        ' 
        EmbossToolStripMenuItem.Name = "EmbossToolStripMenuItem"
        EmbossToolStripMenuItem.Size = New Size(270, 34)
        EmbossToolStripMenuItem.Text = "Emboss"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddContrastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReduceContrastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowHistrogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SharpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Rotate90ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightSharpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GaussianBlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmbossToolStripMenuItem As ToolStripMenuItem

End Class
