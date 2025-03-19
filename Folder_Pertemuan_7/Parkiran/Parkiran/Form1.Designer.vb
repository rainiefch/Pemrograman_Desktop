<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.GhostWhite
        Me.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblLogin.Location = New System.Drawing.Point(14, 12)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(3)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.lblLogin.Size = New System.Drawing.Size(552, 81)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "WELCOME! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLEASE LOGIN TO PARKIRAN"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Lavender
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUsername.Location = New System.Drawing.Point(36, 38)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Padding = New System.Windows.Forms.Padding(3)
        Me.lblUsername.Size = New System.Drawing.Size(130, 35)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Lavender
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(36, 94)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPassword.Size = New System.Drawing.Size(130, 35)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.Lavender
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbUsername.Location = New System.Drawing.Point(197, 38)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(314, 35)
        Me.tbUsername.TabIndex = 3
        Me.tbUsername.Text = "Input username"
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.Lavender
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbPassword.Location = New System.Drawing.Point(197, 94)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(314, 35)
        Me.tbPassword.TabIndex = 4
        Me.tbPassword.Text = "Input password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Lavender
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(260, 178)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(118, 49)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Lavender
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(393, 178)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(118, 49)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.tbUsername)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.tbPassword)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(12, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 264)
        Me.Panel1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(578, 394)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbUsername As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel1 As Panel
End Class
