﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        lblReamur = New Label()
        lblFahrenheit = New Label()
        lblKelvin = New Label()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(310, 25)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(439, 25)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(26, 25)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(66, 25)
        lblCelcius.TabIndex = 2
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(120, 25)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(150, 31)
        txtCelcius.TabIndex = 3
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(263, 91)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(72, 25)
        lblReamur.TabIndex = 4
        lblReamur.Text = "Reamur"
        lblReamur.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(26, 91)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(93, 25)
        lblFahrenheit.TabIndex = 5
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(493, 91)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(58, 25)
        lblKelvin.TabIndex = 6
        lblKelvin.Text = "Kelvin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 135)
        Controls.Add(lblKelvin)
        Controls.Add(lblFahrenheit)
        Controls.Add(lblReamur)
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
    Friend WithEvents lblReamur As Label
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblKelvin As Label

End Class
