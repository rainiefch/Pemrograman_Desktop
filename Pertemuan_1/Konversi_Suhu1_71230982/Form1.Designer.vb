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
        txtCelcius = New TextBox()
        lblCelcius = New Label()
        btnConvert = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(112, 21)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 0
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(27, 21)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 1
        lblCelcius.Text = "Celcius"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(284, 21)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(414, 21)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 76)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Controls.Add(lblCelcius)
        Controls.Add(txtCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents lblCelcius As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button

End Class
