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
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        txtReamur = New TextBox()
        txtKelvin = New TextBox()
        btnConvert = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(36, 30)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(137, 30)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 1
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(36, 99)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 2
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(241, 99)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(150, 31)
        txtReamur.TabIndex = 3
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(446, 99)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(150, 31)
        txtKelvin.TabIndex = 4
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(344, 30)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 5
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(484, 30)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 162)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Controls.Add(txtKelvin)
        Controls.Add(txtReamur)
        Controls.Add(txtFahrenheit)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtReamur As TextBox
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button

End Class
