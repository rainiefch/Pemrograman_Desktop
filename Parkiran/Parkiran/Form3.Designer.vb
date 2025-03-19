<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubscribedVehicleList = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dgvSubscribedVehicleList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblValidUntil = New System.Windows.Forms.Label()
        Me.lblSubscriptionFee = New System.Windows.Forms.Label()
        Me.tbSubsFee = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblPlateNumber = New System.Windows.Forms.Label()
        Me.tbPlateNumber = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSubscribedVehicleList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.lblSubscribedVehicleList)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.dgvSubscribedVehicleList)
        Me.Panel1.Controls.Add(Me.cbType)
        Me.Panel1.Controls.Add(Me.lblIDNumber)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblValidUntil)
        Me.Panel1.Controls.Add(Me.lblSubscriptionFee)
        Me.Panel1.Controls.Add(Me.tbSubsFee)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.lblPlateNumber)
        Me.Panel1.Controls.Add(Me.tbPlateNumber)
        Me.Panel1.Controls.Add(Me.lblType)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(14, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 555)
        Me.Panel1.TabIndex = 11
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Lavender
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(832, 204)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 49)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblSubscribedVehicleList
        '
        Me.lblSubscribedVehicleList.BackColor = System.Drawing.Color.Lavender
        Me.lblSubscribedVehicleList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscribedVehicleList.Location = New System.Drawing.Point(28, 267)
        Me.lblSubscribedVehicleList.Name = "lblSubscribedVehicleList"
        Me.lblSubscribedVehicleList.Padding = New System.Windows.Forms.Padding(3)
        Me.lblSubscribedVehicleList.Size = New System.Drawing.Size(909, 35)
        Me.lblSubscribedVehicleList.TabIndex = 18
        Me.lblSubscribedVehicleList.Text = "Subscribed Vehicle List:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Lavender
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(832, 148)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(105, 49)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Lavender
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(695, 204)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(105, 49)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'dgvSubscribedVehicleList
        '
        Me.dgvSubscribedVehicleList.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvSubscribedVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubscribedVehicleList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvSubscribedVehicleList.Location = New System.Drawing.Point(33, 321)
        Me.dgvSubscribedVehicleList.Name = "dgvSubscribedVehicleList"
        Me.dgvSubscribedVehicleList.RowHeadersWidth = 62
        Me.dgvSubscribedVehicleList.RowTemplate.Height = 28
        Me.dgvSubscribedVehicleList.Size = New System.Drawing.Size(904, 150)
        Me.dgvSubscribedVehicleList.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "No PLat"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama Pemilik"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Biaya"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jenis"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Expired"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Motorcycle", "Car", "Taxi", "Bicycle", "Bus/Truck"})
        Me.cbType.Location = New System.Drawing.Point(779, 96)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(158, 28)
        Me.cbType.TabIndex = 13
        '
        'lblIDNumber
        '
        Me.lblIDNumber.BackColor = System.Drawing.Color.Lavender
        Me.lblIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblIDNumber.Location = New System.Drawing.Point(690, 38)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Padding = New System.Windows.Forms.Padding(3)
        Me.lblIDNumber.Size = New System.Drawing.Size(247, 35)
        Me.lblIDNumber.TabIndex = 12
        Me.lblIDNumber.Text = "ID Number"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkBlue
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.GhostWhite
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Lavender
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkBlue
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.SlateBlue
        Me.DateTimePicker1.Location = New System.Drawing.Point(246, 204)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(314, 26)
        Me.DateTimePicker1.TabIndex = 11
        '
        'lblValidUntil
        '
        Me.lblValidUntil.BackColor = System.Drawing.Color.Lavender
        Me.lblValidUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidUntil.Location = New System.Drawing.Point(28, 202)
        Me.lblValidUntil.Name = "lblValidUntil"
        Me.lblValidUntil.Padding = New System.Windows.Forms.Padding(3)
        Me.lblValidUntil.Size = New System.Drawing.Size(202, 35)
        Me.lblValidUntil.TabIndex = 9
        Me.lblValidUntil.Text = "Valid Until"
        '
        'lblSubscriptionFee
        '
        Me.lblSubscriptionFee.AutoSize = True
        Me.lblSubscriptionFee.BackColor = System.Drawing.Color.Lavender
        Me.lblSubscriptionFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubscriptionFee.Location = New System.Drawing.Point(28, 148)
        Me.lblSubscriptionFee.Name = "lblSubscriptionFee"
        Me.lblSubscriptionFee.Padding = New System.Windows.Forms.Padding(3)
        Me.lblSubscriptionFee.Size = New System.Drawing.Size(202, 35)
        Me.lblSubscriptionFee.TabIndex = 7
        Me.lblSubscriptionFee.Text = "Subscription Fee"
        '
        'tbSubsFee
        '
        Me.tbSubsFee.BackColor = System.Drawing.Color.Lavender
        Me.tbSubsFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSubsFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubsFee.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbSubsFee.Location = New System.Drawing.Point(246, 148)
        Me.tbSubsFee.Name = "tbSubsFee"
        Me.tbSubsFee.Size = New System.Drawing.Size(314, 35)
        Me.tbSubsFee.TabIndex = 8
        '
        'tbName
        '
        Me.tbName.BackColor = System.Drawing.Color.Lavender
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbName.Location = New System.Drawing.Point(246, 38)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(406, 35)
        Me.tbName.TabIndex = 3
        Me.tbName.Text = "Input name"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Lavender
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(819, 487)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 49)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Lavender
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblName.Location = New System.Drawing.Point(28, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Padding = New System.Windows.Forms.Padding(3)
        Me.lblName.Size = New System.Drawing.Size(202, 35)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Lavender
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(695, 148)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 49)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblPlateNumber
        '
        Me.lblPlateNumber.BackColor = System.Drawing.Color.Lavender
        Me.lblPlateNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNumber.Location = New System.Drawing.Point(28, 94)
        Me.lblPlateNumber.Name = "lblPlateNumber"
        Me.lblPlateNumber.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPlateNumber.Size = New System.Drawing.Size(202, 35)
        Me.lblPlateNumber.TabIndex = 2
        Me.lblPlateNumber.Text = "Plate Number"
        '
        'tbPlateNumber
        '
        Me.tbPlateNumber.BackColor = System.Drawing.Color.Lavender
        Me.tbPlateNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPlateNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPlateNumber.ForeColor = System.Drawing.Color.SlateBlue
        Me.tbPlateNumber.Location = New System.Drawing.Point(246, 94)
        Me.tbPlateNumber.Name = "tbPlateNumber"
        Me.tbPlateNumber.Size = New System.Drawing.Size(314, 35)
        Me.tbPlateNumber.TabIndex = 4
        Me.tbPlateNumber.Text = "Input plate number"
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Lavender
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblType.Location = New System.Drawing.Point(695, 92)
        Me.lblType.Name = "lblType"
        Me.lblType.Padding = New System.Windows.Forms.Padding(3)
        Me.lblType.Size = New System.Drawing.Size(242, 35)
        Me.lblType.TabIndex = 14
        Me.lblType.Text = "Type"
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
        Me.lblLogin.Size = New System.Drawing.Size(974, 50)
        Me.lblLogin.TabIndex = 10
        Me.lblLogin.Text = "SUBSCRIPTION"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(998, 649)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblLogin)
        Me.KeyPreview = True
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subscription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSubscribedVehicleList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSubscriptionFee As Label
    Friend WithEvents tbSubsFee As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblPlateNumber As Label
    Friend WithEvents tbPlateNumber As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblValidUntil As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblIDNumber As Label
    Friend WithEvents cbType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents dgvSubscribedVehicleList As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblSubscribedVehicleList As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
