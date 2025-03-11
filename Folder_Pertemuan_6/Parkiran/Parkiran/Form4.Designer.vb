<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubscriberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbTaxi = New System.Windows.Forms.RadioButton()
        Me.rbBusTruck = New System.Windows.Forms.RadioButton()
        Me.rbCar = New System.Windows.Forms.RadioButton()
        Me.rbBicycle = New System.Windows.Forms.RadioButton()
        Me.lblType2 = New System.Windows.Forms.Label()
        Me.rbMotocycle = New System.Windows.Forms.RadioButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblParkingVehicleList = New System.Windows.Forms.Label()
        Me.dgvSubscribedVehicleList = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnOut = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblParkingFee = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPlateNumber = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSubscribedVehicleList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProfileToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(199, 34)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(199, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubscriberToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(81, 29)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'SubscriberToolStripMenuItem
        '
        Me.SubscriberToolStripMenuItem.Name = "SubscriberToolStripMenuItem"
        Me.SubscriberToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.SubscriberToolStripMenuItem.Text = "Subscriber"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(197, 34)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(164, 34)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'tbName
        '
        Me.tbName.BackColor = System.Drawing.Color.Lavender
        Me.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.Color.DarkBlue
        Me.tbName.Location = New System.Drawing.Point(19, 20)
        Me.tbName.Name = "tbName"
        Me.tbName.ReadOnly = True
        Me.tbName.Size = New System.Drawing.Size(784, 62)
        Me.tbName.TabIndex = 4
        Me.tbName.Text = "PLATE NUMBER"
        Me.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbName.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblParkingVehicleList)
        Me.Panel1.Controls.Add(Me.dgvSubscribedVehicleList)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.btnOut)
        Me.Panel1.Controls.Add(Me.btnEnter)
        Me.Panel1.Controls.Add(Me.lblParkingFee)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.lblType)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblPlateNumber)
        Me.Panel1.Controls.Add(Me.tbName)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 655)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbTaxi)
        Me.Panel2.Controls.Add(Me.rbBusTruck)
        Me.Panel2.Controls.Add(Me.rbCar)
        Me.Panel2.Controls.Add(Me.rbBicycle)
        Me.Panel2.Controls.Add(Me.lblType2)
        Me.Panel2.Controls.Add(Me.rbMotocycle)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.lblInformation)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Location = New System.Drawing.Point(19, 350)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 287)
        Me.Panel2.TabIndex = 25
        '
        'rbTaxi
        '
        Me.rbTaxi.BackColor = System.Drawing.Color.Lavender
        Me.rbTaxi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTaxi.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbTaxi.Location = New System.Drawing.Point(24, 234)
        Me.rbTaxi.Name = "rbTaxi"
        Me.rbTaxi.Size = New System.Drawing.Size(183, 33)
        Me.rbTaxi.TabIndex = 31
        Me.rbTaxi.TabStop = True
        Me.rbTaxi.Text = "Taxi"
        Me.rbTaxi.UseVisualStyleBackColor = False
        '
        'rbBusTruck
        '
        Me.rbBusTruck.BackColor = System.Drawing.Color.Lavender
        Me.rbBusTruck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBusTruck.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbBusTruck.Location = New System.Drawing.Point(259, 204)
        Me.rbBusTruck.Name = "rbBusTruck"
        Me.rbBusTruck.Size = New System.Drawing.Size(183, 33)
        Me.rbBusTruck.TabIndex = 30
        Me.rbBusTruck.TabStop = True
        Me.rbBusTruck.Text = "Bus/Truck"
        Me.rbBusTruck.UseVisualStyleBackColor = False
        '
        'rbCar
        '
        Me.rbCar.BackColor = System.Drawing.Color.Lavender
        Me.rbCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCar.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbCar.Location = New System.Drawing.Point(24, 195)
        Me.rbCar.Name = "rbCar"
        Me.rbCar.Size = New System.Drawing.Size(183, 33)
        Me.rbCar.TabIndex = 29
        Me.rbCar.TabStop = True
        Me.rbCar.Text = "Car"
        Me.rbCar.UseVisualStyleBackColor = False
        '
        'rbBicycle
        '
        Me.rbBicycle.BackColor = System.Drawing.Color.Lavender
        Me.rbBicycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBicycle.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbBicycle.Location = New System.Drawing.Point(259, 156)
        Me.rbBicycle.Name = "rbBicycle"
        Me.rbBicycle.Size = New System.Drawing.Size(183, 33)
        Me.rbBicycle.TabIndex = 28
        Me.rbBicycle.TabStop = True
        Me.rbBicycle.Text = "Bicycle"
        Me.rbBicycle.UseVisualStyleBackColor = False
        '
        'lblType2
        '
        Me.lblType2.BackColor = System.Drawing.Color.GhostWhite
        Me.lblType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType2.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblType2.Location = New System.Drawing.Point(16, 107)
        Me.lblType2.Name = "lblType2"
        Me.lblType2.Padding = New System.Windows.Forms.Padding(3)
        Me.lblType2.Size = New System.Drawing.Size(440, 35)
        Me.lblType2.TabIndex = 27
        Me.lblType2.Text = "Type"
        '
        'rbMotocycle
        '
        Me.rbMotocycle.BackColor = System.Drawing.Color.Lavender
        Me.rbMotocycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMotocycle.ForeColor = System.Drawing.Color.DarkBlue
        Me.rbMotocycle.Location = New System.Drawing.Point(24, 156)
        Me.rbMotocycle.Name = "rbMotocycle"
        Me.rbMotocycle.Size = New System.Drawing.Size(183, 33)
        Me.rbMotocycle.TabIndex = 26
        Me.rbMotocycle.TabStop = True
        Me.rbMotocycle.Text = "Motor Cycle"
        Me.rbMotocycle.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Lavender
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTime.Location = New System.Drawing.Point(242, 58)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTime.Size = New System.Drawing.Size(200, 35)
        Me.lblTime.TabIndex = 25
        Me.lblTime.Text = "Time: 00:00:00"
        '
        'lblInformation
        '
        Me.lblInformation.BackColor = System.Drawing.Color.GhostWhite
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblInformation.Location = New System.Drawing.Point(16, 12)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.lblInformation.Size = New System.Drawing.Size(440, 35)
        Me.lblInformation.TabIndex = 23
        Me.lblInformation.Text = "Information"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Lavender
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDate.Location = New System.Drawing.Point(16, 58)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Padding = New System.Windows.Forms.Padding(3)
        Me.lblDate.Size = New System.Drawing.Size(217, 35)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Date: 4-4-4444"
        '
        'lblParkingVehicleList
        '
        Me.lblParkingVehicleList.BackColor = System.Drawing.Color.Lavender
        Me.lblParkingVehicleList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParkingVehicleList.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblParkingVehicleList.Location = New System.Drawing.Point(500, 97)
        Me.lblParkingVehicleList.Name = "lblParkingVehicleList"
        Me.lblParkingVehicleList.Padding = New System.Windows.Forms.Padding(3)
        Me.lblParkingVehicleList.Size = New System.Drawing.Size(303, 35)
        Me.lblParkingVehicleList.TabIndex = 22
        Me.lblParkingVehicleList.Text = "Parking Vehicle List:"
        '
        'dgvSubscribedVehicleList
        '
        Me.dgvSubscribedVehicleList.BackgroundColor = System.Drawing.Color.Lavender
        Me.dgvSubscribedVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubscribedVehicleList.Location = New System.Drawing.Point(505, 151)
        Me.dgvSubscribedVehicleList.Name = "dgvSubscribedVehicleList"
        Me.dgvSubscribedVehicleList.RowHeadersWidth = 62
        Me.dgvSubscribedVehicleList.RowTemplate.Height = 28
        Me.dgvSubscribedVehicleList.Size = New System.Drawing.Size(298, 486)
        Me.dgvSubscribedVehicleList.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Lavender
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox2.Location = New System.Drawing.Point(196, 266)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(290, 62)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Rp. 30.000"
        Me.TextBox2.WordWrap = False
        '
        'btnOut
        '
        Me.btnOut.BackColor = System.Drawing.Color.Lavender
        Me.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOut.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnOut.Location = New System.Drawing.Point(381, 201)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.Size = New System.Drawing.Size(105, 49)
        Me.btnOut.TabIndex = 19
        Me.btnOut.Text = "Out"
        Me.btnOut.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Lavender
        Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnEnter.Location = New System.Drawing.Point(266, 201)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(105, 49)
        Me.btnEnter.TabIndex = 18
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lblParkingFee
        '
        Me.lblParkingFee.BackColor = System.Drawing.Color.Lavender
        Me.lblParkingFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParkingFee.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblParkingFee.Location = New System.Drawing.Point(14, 279)
        Me.lblParkingFee.Name = "lblParkingFee"
        Me.lblParkingFee.Padding = New System.Windows.Forms.Padding(3)
        Me.lblParkingFee.Size = New System.Drawing.Size(167, 35)
        Me.lblParkingFee.TabIndex = 17
        Me.lblParkingFee.Text = "Parking Fee"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Motorcycle", "Car", "Taxi", "Bicycle", "Bus/Truck"})
        Me.ComboBox1.Location = New System.Drawing.Point(196, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 28)
        Me.ComboBox1.TabIndex = 15
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Lavender
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblType.Location = New System.Drawing.Point(14, 158)
        Me.lblType.Name = "lblType"
        Me.lblType.Padding = New System.Windows.Forms.Padding(3)
        Me.lblType.Size = New System.Drawing.Size(167, 35)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "Type"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.SlateBlue
        Me.TextBox1.Location = New System.Drawing.Point(196, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(175, 35)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Plate number"
        '
        'lblPlateNumber
        '
        Me.lblPlateNumber.AutoSize = True
        Me.lblPlateNumber.BackColor = System.Drawing.Color.Lavender
        Me.lblPlateNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPlateNumber.Location = New System.Drawing.Point(14, 105)
        Me.lblPlateNumber.Name = "lblPlateNumber"
        Me.lblPlateNumber.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPlateNumber.Size = New System.Drawing.Size(167, 35)
        Me.lblPlateNumber.TabIndex = 5
        Me.lblPlateNumber.Text = "Plate Number"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(852, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvSubscribedVehicleList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubscriberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPlateNumber As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblParkingFee As Label
    Friend WithEvents btnOut As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblParkingVehicleList As Label
    Friend WithEvents dgvSubscribedVehicleList As DataGridView
    Friend WithEvents lblInformation As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents rbMotocycle As RadioButton
    Friend WithEvents lblType2 As Label
    Friend WithEvents rbBicycle As RadioButton
    Friend WithEvents rbTaxi As RadioButton
    Friend WithEvents rbBusTruck As RadioButton
    Friend WithEvents rbCar As RadioButton
End Class
