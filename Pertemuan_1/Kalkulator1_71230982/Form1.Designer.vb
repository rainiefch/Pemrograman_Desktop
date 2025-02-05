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
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        cmd0 = New Button()
        cmdAddition = New Button()
        cmdDecimal = New Button()
        cmdEqual = New Button()
        cmdSign = New Button()
        cmdSubstraction = New Button()
        cmd1 = New Button()
        cmdInverse = New Button()
        cmd3 = New Button()
        cmdMultiply = New Button()
        cmd2 = New Button()
        cmdSqrt = New Button()
        cmd4 = New Button()
        cmdDivision = New Button()
        cmd6 = New Button()
        cmdPowerOf = New Button()
        cmd5 = New Button()
        cmd7 = New Button()
        cmdCE = New Button()
        cmd9 = New Button()
        cmdC = New Button()
        cmd8 = New Button()
        cmdBackspace = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(362, 99)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 18F)
        txtInput.Location = New Point(18, 23)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(327, 55)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cmd0)
        Panel2.Controls.Add(cmdAddition)
        Panel2.Controls.Add(cmdDecimal)
        Panel2.Controls.Add(cmdEqual)
        Panel2.Controls.Add(cmdSign)
        Panel2.Controls.Add(cmdSubstraction)
        Panel2.Controls.Add(cmd1)
        Panel2.Controls.Add(cmdInverse)
        Panel2.Controls.Add(cmd3)
        Panel2.Controls.Add(cmdMultiply)
        Panel2.Controls.Add(cmd2)
        Panel2.Controls.Add(cmdSqrt)
        Panel2.Controls.Add(cmd4)
        Panel2.Controls.Add(cmdDivision)
        Panel2.Controls.Add(cmd6)
        Panel2.Controls.Add(cmdPowerOf)
        Panel2.Controls.Add(cmd5)
        Panel2.Controls.Add(cmd7)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmd9)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmd8)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(12, 117)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(362, 335)
        Panel2.TabIndex = 1
        ' 
        ' cmd0
        ' 
        cmd0.Location = New Point(18, 262)
        cmd0.Name = "cmd0"
        cmd0.Size = New Size(58, 52)
        cmd0.TabIndex = 21
        cmd0.Text = "0"
        cmd0.UseVisualStyleBackColor = True
        ' 
        ' cmdAddition
        ' 
        cmdAddition.Location = New Point(223, 262)
        cmdAddition.Name = "cmdAddition"
        cmdAddition.Size = New Size(58, 52)
        cmdAddition.TabIndex = 10
        cmdAddition.Text = "+"
        cmdAddition.UseVisualStyleBackColor = True
        ' 
        ' cmdDecimal
        ' 
        cmdDecimal.Location = New Point(146, 262)
        cmdDecimal.Name = "cmdDecimal"
        cmdDecimal.Size = New Size(58, 52)
        cmdDecimal.TabIndex = 22
        cmdDecimal.Text = "."
        cmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' cmdEqual
        ' 
        cmdEqual.Location = New Point(287, 262)
        cmdEqual.Name = "cmdEqual"
        cmdEqual.Size = New Size(58, 52)
        cmdEqual.TabIndex = 9
        cmdEqual.Text = "="
        cmdEqual.UseVisualStyleBackColor = True
        ' 
        ' cmdSign
        ' 
        cmdSign.Location = New Point(82, 262)
        cmdSign.Name = "cmdSign"
        cmdSign.Size = New Size(58, 52)
        cmdSign.TabIndex = 20
        cmdSign.Text = "+/-"
        cmdSign.UseVisualStyleBackColor = True
        ' 
        ' cmdSubstraction
        ' 
        cmdSubstraction.Location = New Point(223, 204)
        cmdSubstraction.Name = "cmdSubstraction"
        cmdSubstraction.Size = New Size(58, 52)
        cmdSubstraction.TabIndex = 8
        cmdSubstraction.Text = "-"
        cmdSubstraction.UseVisualStyleBackColor = True
        ' 
        ' cmd1
        ' 
        cmd1.Location = New Point(18, 204)
        cmd1.Name = "cmd1"
        cmd1.Size = New Size(58, 52)
        cmd1.TabIndex = 18
        cmd1.Text = "1"
        cmd1.UseVisualStyleBackColor = True
        ' 
        ' cmdInverse
        ' 
        cmdInverse.Location = New Point(287, 204)
        cmdInverse.Name = "cmdInverse"
        cmdInverse.Size = New Size(58, 52)
        cmdInverse.TabIndex = 7
        cmdInverse.Text = "1/X"
        cmdInverse.UseVisualStyleBackColor = True
        ' 
        ' cmd3
        ' 
        cmd3.Location = New Point(146, 204)
        cmd3.Name = "cmd3"
        cmd3.Size = New Size(58, 52)
        cmd3.TabIndex = 19
        cmd3.Text = "3"
        cmd3.UseVisualStyleBackColor = True
        ' 
        ' cmdMultiply
        ' 
        cmdMultiply.Location = New Point(223, 146)
        cmdMultiply.Name = "cmdMultiply"
        cmdMultiply.Size = New Size(58, 52)
        cmdMultiply.TabIndex = 6
        cmdMultiply.Text = "*"
        cmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' cmd2
        ' 
        cmd2.Location = New Point(82, 204)
        cmd2.Name = "cmd2"
        cmd2.Size = New Size(58, 52)
        cmd2.TabIndex = 17
        cmd2.Text = "2"
        cmd2.UseVisualStyleBackColor = True
        ' 
        ' cmdSqrt
        ' 
        cmdSqrt.Font = New Font("Microsoft Sans Serif", 6F)
        cmdSqrt.Location = New Point(287, 146)
        cmdSqrt.Name = "cmdSqrt"
        cmdSqrt.Size = New Size(58, 52)
        cmdSqrt.TabIndex = 5
        cmdSqrt.Text = "SQRT"
        cmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' cmd4
        ' 
        cmd4.Location = New Point(18, 146)
        cmd4.Name = "cmd4"
        cmd4.Size = New Size(58, 52)
        cmd4.TabIndex = 15
        cmd4.Text = "4"
        cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmdDivision
        ' 
        cmdDivision.Location = New Point(223, 88)
        cmdDivision.Name = "cmdDivision"
        cmdDivision.Size = New Size(58, 52)
        cmdDivision.TabIndex = 4
        cmdDivision.Text = "/"
        cmdDivision.UseVisualStyleBackColor = True
        ' 
        ' cmd6
        ' 
        cmd6.Location = New Point(146, 146)
        cmd6.Name = "cmd6"
        cmd6.Size = New Size(58, 52)
        cmd6.TabIndex = 16
        cmd6.Text = "6"
        cmd6.UseVisualStyleBackColor = True
        ' 
        ' cmdPowerOf
        ' 
        cmdPowerOf.Location = New Point(287, 88)
        cmdPowerOf.Name = "cmdPowerOf"
        cmdPowerOf.Size = New Size(58, 52)
        cmdPowerOf.TabIndex = 3
        cmdPowerOf.Text = "X^"
        cmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' cmd5
        ' 
        cmd5.Location = New Point(82, 146)
        cmd5.Name = "cmd5"
        cmd5.Size = New Size(58, 52)
        cmd5.TabIndex = 14
        cmd5.Text = "5"
        cmd5.UseVisualStyleBackColor = True
        ' 
        ' cmd7
        ' 
        cmd7.Location = New Point(18, 88)
        cmd7.Name = "cmd7"
        cmd7.Size = New Size(58, 52)
        cmd7.TabIndex = 12
        cmd7.Text = "7"
        cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(223, 30)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(58, 52)
        cmdCE.TabIndex = 2
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmd9
        ' 
        cmd9.Location = New Point(146, 88)
        cmd9.Name = "cmd9"
        cmd9.Size = New Size(58, 52)
        cmd9.TabIndex = 13
        cmd9.Text = "9"
        cmd9.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(287, 30)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(58, 52)
        cmdC.TabIndex = 1
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmd8
        ' 
        cmd8.Location = New Point(82, 88)
        cmd8.Name = "cmd8"
        cmd8.Size = New Size(58, 52)
        cmd8.TabIndex = 11
        cmd8.Text = "8"
        cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(18, 30)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(122, 52)
        cmdBackspace.TabIndex = 0
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(386, 470)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdAddition As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmdEqual As Button
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmdSubstraction As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmdInverse As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmdDivision As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmdPowerOf As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button

End Class
