<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.lblConfirmPassword)
        Me.Panel1.Controls.Add(Me.tbConfirmPassword)
        Me.Panel1.Controls.Add(Me.tbUsername)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lblNewPassword)
        Me.Panel1.Controls.Add(Me.tbNewPassword)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(14, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 300)
        Me.Panel1.TabIndex = 9
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.Lavender
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(28, 148)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.lblConfirmPassword.Size = New System.Drawing.Size(216, 35)
        Me.lblConfirmPassword.TabIndex = 7
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.BackColor = System.Drawing.Color.Lavender
        Me.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPassword.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbConfirmPassword.Location = New System.Drawing.Point(265, 148)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.Size = New System.Drawing.Size(314, 35)
        Me.tbConfirmPassword.TabIndex = 8
        Me.tbConfirmPassword.Text = "Input confirm password"
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.Lavender
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbUsername.Location = New System.Drawing.Point(265, 38)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.ReadOnly = True
        Me.tbUsername.Size = New System.Drawing.Size(314, 35)
        Me.tbUsername.TabIndex = 3
        Me.tbUsername.Text = "Username"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Lavender
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(461, 228)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 49)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Lavender
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUsername.Location = New System.Drawing.Point(28, 38)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Padding = New System.Windows.Forms.Padding(3)
        Me.lblUsername.Size = New System.Drawing.Size(216, 35)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lavender
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(328, 228)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(118, 49)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.BackColor = System.Drawing.Color.Lavender
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.Location = New System.Drawing.Point(28, 94)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.lblNewPassword.Size = New System.Drawing.Size(216, 35)
        Me.lblNewPassword.TabIndex = 2
        Me.lblNewPassword.Text = "New Password"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.BackColor = System.Drawing.Color.Lavender
        Me.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewPassword.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbNewPassword.Location = New System.Drawing.Point(265, 94)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(314, 35)
        Me.tbNewPassword.TabIndex = 4
        Me.tbNewPassword.Text = "Input new password"
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.GhostWhite
        Me.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblLogin.Location = New System.Drawing.Point(12, 12)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(3)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.lblLogin.Size = New System.Drawing.Size(604, 50)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "EDIT PROFILE"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(628, 394)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLogin)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Profile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents tbConfirmPassword As TextBox
End Class
