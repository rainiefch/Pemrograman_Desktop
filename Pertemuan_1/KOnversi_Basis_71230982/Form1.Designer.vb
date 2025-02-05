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
        txtDecimal = New TextBox()
        txtBinary = New TextBox()
        txtOctal = New TextBox()
        txtHexadecimal = New TextBox()
        lblDecimal = New Label()
        lblBinary = New Label()
        lblOctal = New Label()
        lblHexadecimal = New Label()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(441, 29)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(112, 34)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(570, 29)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtDecimal
        ' 
        txtDecimal.Location = New Point(150, 29)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(150, 31)
        txtDecimal.TabIndex = 2
        ' 
        ' txtBinary
        ' 
        txtBinary.Location = New Point(150, 92)
        txtBinary.Name = "txtBinary"
        txtBinary.Size = New Size(150, 31)
        txtBinary.TabIndex = 3
        ' 
        ' txtOctal
        ' 
        txtOctal.Location = New Point(150, 139)
        txtOctal.Name = "txtOctal"
        txtOctal.Size = New Size(150, 31)
        txtOctal.TabIndex = 4
        ' 
        ' txtHexadecimal
        ' 
        txtHexadecimal.Location = New Point(150, 184)
        txtHexadecimal.Name = "txtHexadecimal"
        txtHexadecimal.Size = New Size(150, 31)
        txtHexadecimal.TabIndex = 5
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.Location = New Point(37, 29)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(75, 25)
        lblDecimal.TabIndex = 6
        lblDecimal.Text = "Decimal"
        ' 
        ' lblBinary
        ' 
        lblBinary.AutoSize = True
        lblBinary.Location = New Point(37, 92)
        lblBinary.Name = "lblBinary"
        lblBinary.Size = New Size(60, 25)
        lblBinary.TabIndex = 7
        lblBinary.Text = "Binary"
        ' 
        ' lblOctal
        ' 
        lblOctal.AutoSize = True
        lblOctal.Location = New Point(37, 139)
        lblOctal.Name = "lblOctal"
        lblOctal.Size = New Size(53, 25)
        lblOctal.TabIndex = 8
        lblOctal.Text = "Octal"
        ' 
        ' lblHexadecimal
        ' 
        lblHexadecimal.AutoSize = True
        lblHexadecimal.Location = New Point(37, 184)
        lblHexadecimal.Name = "lblHexadecimal"
        lblHexadecimal.Size = New Size(112, 25)
        lblHexadecimal.TabIndex = 9
        lblHexadecimal.Text = "Hexadecimal"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 241)
        Controls.Add(lblHexadecimal)
        Controls.Add(lblOctal)
        Controls.Add(lblBinary)
        Controls.Add(lblDecimal)
        Controls.Add(txtHexadecimal)
        Controls.Add(txtOctal)
        Controls.Add(txtBinary)
        Controls.Add(txtDecimal)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents txtBinary As TextBox
    Friend WithEvents txtOctal As TextBox
    Friend WithEvents txtHexadecimal As TextBox
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblBinary As Label
    Friend WithEvents lblOctal As Label
    Friend WithEvents lblHexadecimal As Label

End Class
