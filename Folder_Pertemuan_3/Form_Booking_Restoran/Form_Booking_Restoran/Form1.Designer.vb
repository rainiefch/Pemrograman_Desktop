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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbSeat = New System.Windows.Forms.ComboBox()
        Me.mtxtHour = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.numGuest = New System.Windows.Forms.NumericUpDown()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTable = New System.Windows.Forms.ComboBox()
        CType(Me.numGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Booking Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Booking Hour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Seats"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(188, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 6
        '
        'cbSeat
        '
        Me.cbSeat.FormattingEnabled = True
        Me.cbSeat.Items.AddRange(New Object() {"2 Seats", "4 Seats", "6 Seats", "8 Seats", "10 Seats"})
        Me.cbSeat.Location = New System.Drawing.Point(188, 158)
        Me.cbSeat.Name = "cbSeat"
        Me.cbSeat.Size = New System.Drawing.Size(200, 28)
        Me.cbSeat.TabIndex = 7
        '
        'mtxtHour
        '
        Me.mtxtHour.Location = New System.Drawing.Point(188, 113)
        Me.mtxtHour.Mask = "00:00"
        Me.mtxtHour.Name = "mtxtHour"
        Me.mtxtHour.Size = New System.Drawing.Size(200, 26)
        Me.mtxtHour.TabIndex = 8
        Me.mtxtHour.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Guests"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnConfirm
        '
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnConfirm.Location = New System.Drawing.Point(313, 307)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 34)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'numGuest
        '
        Me.numGuest.Location = New System.Drawing.Point(188, 212)
        Me.numGuest.Name = "numGuest"
        Me.numGuest.Size = New System.Drawing.Size(200, 26)
        Me.numGuest.TabIndex = 13
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(188, 67)
        Me.dtpDate.MinDate = New Date(2025, 2, 18, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 26)
        Me.dtpDate.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Table Number"
        '
        'cbTable
        '
        Me.cbTable.FormattingEnabled = True
        Me.cbTable.Items.AddRange(New Object() {"2 Seats", "4 Seats", "6 Seats", "8 Seats", "10 Seats"})
        Me.cbTable.Location = New System.Drawing.Point(188, 260)
        Me.cbTable.Name = "cbTable"
        Me.cbTable.Size = New System.Drawing.Size(200, 28)
        Me.cbTable.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(423, 386)
        Me.Controls.Add(Me.cbTable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.numGuest)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mtxtHour)
        Me.Controls.Add(Me.cbSeat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Booking Details"
        CType(Me.numGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbSeat As ComboBox
    Friend WithEvents mtxtHour As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnConfirm As Button
    Friend WithEvents numGuest As NumericUpDown
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cbTable As ComboBox
End Class
