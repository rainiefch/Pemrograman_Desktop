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
        lblFahrenheit = New Label()
        lblReamur = New Label()
        lblKelvin = New Label()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(116, 23)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 0
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(23, 23)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 1
        lblCelcius.Text = "Celcius"
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(299, 23)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(439, 23)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(50, 84)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(93, 25)
        lblFahrenheit.TabIndex = 4
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(247, 84)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(72, 25)
        lblReamur.TabIndex = 5
        lblReamur.Text = "Reamur"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(453, 84)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(58, 25)
        lblKelvin.TabIndex = 6
        lblKelvin.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 127)
        Controls.Add(lblKelvin)
        Controls.Add(lblReamur)
        Controls.Add(lblFahrenheit)
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
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblKelvin As Label

End Class
