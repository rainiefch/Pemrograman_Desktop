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
        btnConvert = New Button()
        btnExit = New Button()
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(326, 24)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(455, 24)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(29, 24)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 2
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(137, 24)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 3
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(29, 78)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        txtFahrenheit.Text = "Fahrenheit"
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(221, 78)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 5
        txtReamur.Text = "Reamur"
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(417, 78)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 6
        txtKelvin.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 142)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox

End Class
