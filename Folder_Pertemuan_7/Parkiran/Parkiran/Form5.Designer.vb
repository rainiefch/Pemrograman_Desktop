<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbYear = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblLogin.Size = New System.Drawing.Size(776, 50)
        Me.lblLogin.TabIndex = 11
        Me.lblLogin.Text = "INCOME REPORT"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.tbYear)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.dgvReport)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Controls.Add(Me.lblReport)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.lblPeriod)
        Me.Panel1.Location = New System.Drawing.Point(18, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 451)
        Me.Panel1.TabIndex = 12
        '
        'tbYear
        '
        Me.tbYear.BackColor = System.Drawing.Color.Lavender
        Me.tbYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbYear.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbYear.Location = New System.Drawing.Point(353, 20)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.ReadOnly = True
        Me.tbYear.Size = New System.Drawing.Size(134, 35)
        Me.tbYear.TabIndex = 24
        Me.tbYear.Text = "Year"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Lavender
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(626, 384)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 49)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvReport
        '
        Me.dgvReport.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(23, 125)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersWidth = 62
        Me.dgvReport.RowTemplate.Height = 28
        Me.dgvReport.Size = New System.Drawing.Size(721, 244)
        Me.dgvReport.TabIndex = 22
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Lavender
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(626, 60)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(118, 49)
        Me.btnShow.TabIndex = 20
        Me.btnShow.Text = "Show!"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.BackColor = System.Drawing.Color.GhostWhite
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblReport.Location = New System.Drawing.Point(18, 74)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Padding = New System.Windows.Forms.Padding(3)
        Me.lblReport.Size = New System.Drawing.Size(294, 35)
        Me.lblReport.TabIndex = 19
        Me.lblReport.Text = "Report:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(219, 28)
        Me.ComboBox1.TabIndex = 17
        '
        'lblPeriod
        '
        Me.lblPeriod.BackColor = System.Drawing.Color.Lavender
        Me.lblPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPeriod.Location = New System.Drawing.Point(18, 20)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPeriod.Size = New System.Drawing.Size(329, 35)
        Me.lblPeriod.TabIndex = 18
        Me.lblPeriod.Text = "Period"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 542)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "Form5"
        Me.Text = "Income Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblReport As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents btnShow As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents tbYear As TextBox
End Class
