<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleDesign
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlVehicleHeader = New Panel()
        lblVehicleTitle = New Label()
        pnlVehicleBody = New Panel()
        pnlVehicleRight = New Panel()
        pnlVehicleGrid = New Panel()
        dgvVehicle = New DataGridView()
        pnlVehicleSearch = New Panel()
        btnRefreshVehicle = New Button()
        txtVehicleSearch = New TextBox()
        pnlVehicleInput = New Panel()
        pnlVehicleBtns = New Panel()
        btnCloseVehicle = New Button()
        btnClearVehicle = New Button()
        btnDeleteVehicle = New Button()
        btnUpdateVehicle = New Button()
        btnAddVehicle = New Button()
        txtVehicleCategoryName = New TextBox()
        Label11 = New Label()
        txtVehicleCategoryID = New TextBox()
        Label12 = New Label()
        lblGroupVehicleCategory = New Label()
        cbVehicleStatus = New ComboBox()
        Label10 = New Label()
        txtVehiclePlateNo = New TextBox()
        Label9 = New Label()
        txtVehicleMileage = New TextBox()
        Label8 = New Label()
        cbVehicleTransmission = New ComboBox()
        Label7 = New Label()
        cbVehicleFuelType = New ComboBox()
        Label6 = New Label()
        txtVehicleColor = New TextBox()
        Label5 = New Label()
        txtVehicleYear = New TextBox()
        Label4 = New Label()
        txtVehicleModel = New TextBox()
        Label3 = New Label()
        txtVehicleBrand = New TextBox()
        Label2 = New Label()
        txtVehicleID = New TextBox()
        Label1 = New Label()
        lblGroupVehicleInfo = New Label()
        pnlVehicleHeader.SuspendLayout()
        pnlVehicleBody.SuspendLayout()
        pnlVehicleRight.SuspendLayout()
        pnlVehicleGrid.SuspendLayout()
        CType(dgvVehicle, ComponentModel.ISupportInitialize).BeginInit()
        pnlVehicleSearch.SuspendLayout()
        pnlVehicleInput.SuspendLayout()
        pnlVehicleBtns.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlVehicleHeader
        ' 
        pnlVehicleHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlVehicleHeader.Controls.Add(lblVehicleTitle)
        pnlVehicleHeader.Dock = DockStyle.Top
        pnlVehicleHeader.Location = New Point(0, 0)
        pnlVehicleHeader.Name = "pnlVehicleHeader"
        pnlVehicleHeader.Size = New Size(1150, 68)
        pnlVehicleHeader.TabIndex = 0
        ' 
        ' lblVehicleTitle
        ' 
        lblVehicleTitle.AutoSize = True
        lblVehicleTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVehicleTitle.ForeColor = Color.White
        lblVehicleTitle.Location = New Point(3, 21)
        lblVehicleTitle.Name = "lblVehicleTitle"
        lblVehicleTitle.Padding = New Padding(15, 0, 0, 0)
        lblVehicleTitle.Size = New Size(135, 25)
        lblVehicleTitle.TabIndex = 0
        lblVehicleTitle.Text = "Vehicle Data"
        lblVehicleTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlVehicleBody
        ' 
        pnlVehicleBody.Controls.Add(pnlVehicleRight)
        pnlVehicleBody.Controls.Add(pnlVehicleInput)
        pnlVehicleBody.Dock = DockStyle.Fill
        pnlVehicleBody.Location = New Point(0, 68)
        pnlVehicleBody.Name = "pnlVehicleBody"
        pnlVehicleBody.Size = New Size(1150, 993)
        pnlVehicleBody.TabIndex = 1
        ' 
        ' pnlVehicleRight
        ' 
        pnlVehicleRight.Controls.Add(pnlVehicleGrid)
        pnlVehicleRight.Controls.Add(pnlVehicleSearch)
        pnlVehicleRight.Dock = DockStyle.Fill
        pnlVehicleRight.Location = New Point(300, 0)
        pnlVehicleRight.Name = "pnlVehicleRight"
        pnlVehicleRight.Padding = New Padding(12)
        pnlVehicleRight.Size = New Size(850, 993)
        pnlVehicleRight.TabIndex = 1
        ' 
        ' pnlVehicleGrid
        ' 
        pnlVehicleGrid.BackColor = Color.WhiteSmoke
        pnlVehicleGrid.Controls.Add(dgvVehicle)
        pnlVehicleGrid.Dock = DockStyle.Fill
        pnlVehicleGrid.Location = New Point(12, 60)
        pnlVehicleGrid.Name = "pnlVehicleGrid"
        pnlVehicleGrid.Size = New Size(826, 921)
        pnlVehicleGrid.TabIndex = 1
        ' 
        ' dgvVehicle
        ' 
        dgvVehicle.AllowUserToAddRows = False
        dgvVehicle.AllowUserToDeleteRows = False
        dgvVehicle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVehicle.BackgroundColor = Color.White
        dgvVehicle.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvVehicle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvVehicle.DefaultCellStyle = DataGridViewCellStyle2
        dgvVehicle.Dock = DockStyle.Fill
        dgvVehicle.Location = New Point(0, 0)
        dgvVehicle.Name = "dgvVehicle"
        dgvVehicle.ReadOnly = True
        dgvVehicle.RowHeadersVisible = False
        dgvVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVehicle.Size = New Size(826, 921)
        dgvVehicle.TabIndex = 0
        ' 
        ' pnlVehicleSearch
        ' 
        pnlVehicleSearch.Controls.Add(btnRefreshVehicle)
        pnlVehicleSearch.Controls.Add(txtVehicleSearch)
        pnlVehicleSearch.Dock = DockStyle.Top
        pnlVehicleSearch.Location = New Point(12, 12)
        pnlVehicleSearch.Name = "pnlVehicleSearch"
        pnlVehicleSearch.Size = New Size(826, 48)
        pnlVehicleSearch.TabIndex = 0
        ' 
        ' btnRefreshVehicle
        ' 
        btnRefreshVehicle.Cursor = Cursors.Hand
        btnRefreshVehicle.FlatStyle = FlatStyle.Flat
        btnRefreshVehicle.Location = New Point(360, 5)
        btnRefreshVehicle.Name = "btnRefreshVehicle"
        btnRefreshVehicle.Size = New Size(100, 35)
        btnRefreshVehicle.TabIndex = 1
        btnRefreshVehicle.Text = "🔄 Refresh"
        btnRefreshVehicle.UseVisualStyleBackColor = True
        ' 
        ' txtVehicleSearch
        ' 
        txtVehicleSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtVehicleSearch.Location = New Point(0, 8)
        txtVehicleSearch.Name = "txtVehicleSearch"
        txtVehicleSearch.Size = New Size(350, 25)
        txtVehicleSearch.TabIndex = 0
        txtVehicleSearch.Text = "Search by Brand, Model, Plate No, or Status..."
        ' 
        ' pnlVehicleInput
        ' 
        pnlVehicleInput.BackColor = Color.White
        pnlVehicleInput.Controls.Add(pnlVehicleBtns)
        pnlVehicleInput.Controls.Add(txtVehicleCategoryName)
        pnlVehicleInput.Controls.Add(Label11)
        pnlVehicleInput.Controls.Add(txtVehicleCategoryID)
        pnlVehicleInput.Controls.Add(Label12)
        pnlVehicleInput.Controls.Add(lblGroupVehicleCategory)
        pnlVehicleInput.Controls.Add(cbVehicleStatus)
        pnlVehicleInput.Controls.Add(Label10)
        pnlVehicleInput.Controls.Add(txtVehiclePlateNo)
        pnlVehicleInput.Controls.Add(Label9)
        pnlVehicleInput.Controls.Add(txtVehicleMileage)
        pnlVehicleInput.Controls.Add(Label8)
        pnlVehicleInput.Controls.Add(cbVehicleTransmission)
        pnlVehicleInput.Controls.Add(Label7)
        pnlVehicleInput.Controls.Add(cbVehicleFuelType)
        pnlVehicleInput.Controls.Add(Label6)
        pnlVehicleInput.Controls.Add(txtVehicleColor)
        pnlVehicleInput.Controls.Add(Label5)
        pnlVehicleInput.Controls.Add(txtVehicleYear)
        pnlVehicleInput.Controls.Add(Label4)
        pnlVehicleInput.Controls.Add(txtVehicleModel)
        pnlVehicleInput.Controls.Add(Label3)
        pnlVehicleInput.Controls.Add(txtVehicleBrand)
        pnlVehicleInput.Controls.Add(Label2)
        pnlVehicleInput.Controls.Add(txtVehicleID)
        pnlVehicleInput.Controls.Add(Label1)
        pnlVehicleInput.Controls.Add(lblGroupVehicleInfo)
        pnlVehicleInput.Dock = DockStyle.Left
        pnlVehicleInput.Location = New Point(0, 0)
        pnlVehicleInput.Name = "pnlVehicleInput"
        pnlVehicleInput.Padding = New Padding(12)
        pnlVehicleInput.Size = New Size(300, 993)
        pnlVehicleInput.TabIndex = 0
        ' 
        ' pnlVehicleBtns
        ' 
        pnlVehicleBtns.Controls.Add(btnCloseVehicle)
        pnlVehicleBtns.Controls.Add(btnClearVehicle)
        pnlVehicleBtns.Controls.Add(btnDeleteVehicle)
        pnlVehicleBtns.Controls.Add(btnUpdateVehicle)
        pnlVehicleBtns.Controls.Add(btnAddVehicle)
        pnlVehicleBtns.Dock = DockStyle.Bottom
        pnlVehicleBtns.Location = New Point(12, 881)
        pnlVehicleBtns.Name = "pnlVehicleBtns"
        pnlVehicleBtns.Size = New Size(276, 100)
        pnlVehicleBtns.TabIndex = 26
        ' 
        ' btnCloseVehicle
        ' 
        btnCloseVehicle.BackColor = Color.DarkRed
        btnCloseVehicle.Cursor = Cursors.Hand
        btnCloseVehicle.FlatStyle = FlatStyle.Flat
        btnCloseVehicle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseVehicle.ForeColor = Color.White
        btnCloseVehicle.Location = New Point(132, 52)
        btnCloseVehicle.Name = "btnCloseVehicle"
        btnCloseVehicle.Size = New Size(80, 38)
        btnCloseVehicle.TabIndex = 4
        btnCloseVehicle.Text = "🚪 Close"
        btnCloseVehicle.UseVisualStyleBackColor = False
        ' 
        ' btnClearVehicle
        ' 
        btnClearVehicle.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearVehicle.Cursor = Cursors.Hand
        btnClearVehicle.FlatStyle = FlatStyle.Flat
        btnClearVehicle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearVehicle.ForeColor = Color.White
        btnClearVehicle.Location = New Point(46, 52)
        btnClearVehicle.Name = "btnClearVehicle"
        btnClearVehicle.Size = New Size(80, 38)
        btnClearVehicle.TabIndex = 3
        btnClearVehicle.Text = "✖️ Clear"
        btnClearVehicle.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteVehicle
        ' 
        btnDeleteVehicle.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteVehicle.Cursor = Cursors.Hand
        btnDeleteVehicle.FlatStyle = FlatStyle.Flat
        btnDeleteVehicle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteVehicle.ForeColor = Color.White
        btnDeleteVehicle.Location = New Point(175, 8)
        btnDeleteVehicle.Name = "btnDeleteVehicle"
        btnDeleteVehicle.Size = New Size(80, 38)
        btnDeleteVehicle.TabIndex = 2
        btnDeleteVehicle.Text = "🗑️ Delete"
        btnDeleteVehicle.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateVehicle
        ' 
        btnUpdateVehicle.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateVehicle.Cursor = Cursors.Hand
        btnUpdateVehicle.FlatStyle = FlatStyle.Flat
        btnUpdateVehicle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateVehicle.ForeColor = Color.White
        btnUpdateVehicle.Location = New Point(90, 8)
        btnUpdateVehicle.Name = "btnUpdateVehicle"
        btnUpdateVehicle.Size = New Size(80, 38)
        btnUpdateVehicle.TabIndex = 1
        btnUpdateVehicle.Text = "✏️ Update"
        btnUpdateVehicle.UseVisualStyleBackColor = False
        ' 
        ' btnAddVehicle
        ' 
        btnAddVehicle.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddVehicle.Cursor = Cursors.Hand
        btnAddVehicle.FlatStyle = FlatStyle.Flat
        btnAddVehicle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddVehicle.ForeColor = Color.White
        btnAddVehicle.Location = New Point(5, 8)
        btnAddVehicle.Name = "btnAddVehicle"
        btnAddVehicle.Size = New Size(80, 38)
        btnAddVehicle.TabIndex = 0
        btnAddVehicle.Text = "➕ Add"
        btnAddVehicle.UseVisualStyleBackColor = False
        ' 
        ' txtVehicleCategoryName
        ' 
        txtVehicleCategoryName.BackColor = SystemColors.ButtonFace
        txtVehicleCategoryName.Location = New Point(12, 716)
        txtVehicleCategoryName.Name = "txtVehicleCategoryName"
        txtVehicleCategoryName.ReadOnly = True
        txtVehicleCategoryName.Size = New Size(265, 25)
        txtVehicleCategoryName.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 698)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 17)
        Label11.TabIndex = 24
        Label11.Text = "Category Name:"
        ' 
        ' txtVehicleCategoryID
        ' 
        txtVehicleCategoryID.Location = New Point(12, 658)
        txtVehicleCategoryID.Name = "txtVehicleCategoryID"
        txtVehicleCategoryID.Size = New Size(265, 25)
        txtVehicleCategoryID.TabIndex = 23
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(12, 640)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 17)
        Label12.TabIndex = 22
        Label12.Text = "Category ID:"
        ' 
        ' lblGroupVehicleCategory
        ' 
        lblGroupVehicleCategory.AutoSize = True
        lblGroupVehicleCategory.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupVehicleCategory.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupVehicleCategory.Location = New Point(12, 620)
        lblGroupVehicleCategory.Name = "lblGroupVehicleCategory"
        lblGroupVehicleCategory.Size = New Size(63, 13)
        lblGroupVehicleCategory.TabIndex = 21
        lblGroupVehicleCategory.Text = "CATEGORY"
        ' 
        ' cbVehicleStatus
        ' 
        cbVehicleStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbVehicleStatus.FormattingEnabled = True
        cbVehicleStatus.Items.AddRange(New Object() {"Available", "Rented", "Under Maintenance"})
        cbVehicleStatus.Location = New Point(12, 580)
        cbVehicleStatus.Name = "cbVehicleStatus"
        cbVehicleStatus.Size = New Size(265, 25)
        cbVehicleStatus.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 562)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 17)
        Label10.TabIndex = 19
        Label10.Text = "Vehicle Status:"
        ' 
        ' txtVehiclePlateNo
        ' 
        txtVehiclePlateNo.Location = New Point(12, 522)
        txtVehiclePlateNo.Name = "txtVehiclePlateNo"
        txtVehiclePlateNo.Size = New Size(265, 25)
        txtVehiclePlateNo.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 504)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 17)
        Label9.TabIndex = 17
        Label9.Text = "Plate No:"
        ' 
        ' txtVehicleMileage
        ' 
        txtVehicleMileage.Location = New Point(12, 464)
        txtVehicleMileage.Name = "txtVehicleMileage"
        txtVehicleMileage.Size = New Size(265, 25)
        txtVehicleMileage.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 446)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 17)
        Label8.TabIndex = 15
        Label8.Text = "Current Mileage:"
        ' 
        ' cbVehicleTransmission
        ' 
        cbVehicleTransmission.DropDownStyle = ComboBoxStyle.DropDownList
        cbVehicleTransmission.FormattingEnabled = True
        cbVehicleTransmission.Items.AddRange(New Object() {"Manual", "Automatic"})
        cbVehicleTransmission.Location = New Point(12, 406)
        cbVehicleTransmission.Name = "cbVehicleTransmission"
        cbVehicleTransmission.Size = New Size(265, 25)
        cbVehicleTransmission.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 388)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 17)
        Label7.TabIndex = 13
        Label7.Text = "Transmission:"
        ' 
        ' cbVehicleFuelType
        ' 
        cbVehicleFuelType.DropDownStyle = ComboBoxStyle.DropDownList
        cbVehicleFuelType.FormattingEnabled = True
        cbVehicleFuelType.Items.AddRange(New Object() {"Gasoline", "Diesel", "Electric"})
        cbVehicleFuelType.Location = New Point(12, 348)
        cbVehicleFuelType.Name = "cbVehicleFuelType"
        cbVehicleFuelType.Size = New Size(265, 25)
        cbVehicleFuelType.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 17)
        Label6.TabIndex = 11
        Label6.Text = "Fuel Type:"
        ' 
        ' txtVehicleColor
        ' 
        txtVehicleColor.Location = New Point(12, 290)
        txtVehicleColor.Name = "txtVehicleColor"
        txtVehicleColor.Size = New Size(265, 25)
        txtVehicleColor.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 17)
        Label5.TabIndex = 9
        Label5.Text = "Color:"
        ' 
        ' txtVehicleYear
        ' 
        txtVehicleYear.Location = New Point(12, 232)
        txtVehicleYear.Name = "txtVehicleYear"
        txtVehicleYear.Size = New Size(265, 25)
        txtVehicleYear.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 17)
        Label4.TabIndex = 7
        Label4.Text = "Year:"
        ' 
        ' txtVehicleModel
        ' 
        txtVehicleModel.Location = New Point(12, 174)
        txtVehicleModel.Name = "txtVehicleModel"
        txtVehicleModel.Size = New Size(265, 25)
        txtVehicleModel.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 17)
        Label3.TabIndex = 5
        Label3.Text = "Model:"
        ' 
        ' txtVehicleBrand
        ' 
        txtVehicleBrand.Location = New Point(12, 116)
        txtVehicleBrand.Name = "txtVehicleBrand"
        txtVehicleBrand.Size = New Size(265, 25)
        txtVehicleBrand.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 17)
        Label2.TabIndex = 3
        Label2.Text = "Brand:"
        ' 
        ' txtVehicleID
        ' 
        txtVehicleID.Location = New Point(12, 58)
        txtVehicleID.Name = "txtVehicleID"
        txtVehicleID.Size = New Size(265, 25)
        txtVehicleID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 17)
        Label1.TabIndex = 1
        Label1.Text = "Vehicle ID:"
        ' 
        ' lblGroupVehicleInfo
        ' 
        lblGroupVehicleInfo.AutoSize = True
        lblGroupVehicleInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupVehicleInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupVehicleInfo.Location = New Point(12, 15)
        lblGroupVehicleInfo.Name = "lblGroupVehicleInfo"
        lblGroupVehicleInfo.Size = New Size(79, 13)
        lblGroupVehicleInfo.TabIndex = 0
        lblGroupVehicleInfo.Text = "VEHICLE INFO"
        ' 
        ' frmVehicleDesign
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1150, 1061)
        Controls.Add(pnlVehicleBody)
        Controls.Add(pnlVehicleHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmVehicleDesign"
        Text = "Vehicle Information"
        WindowState = FormWindowState.Maximized
        pnlVehicleHeader.ResumeLayout(False)
        pnlVehicleHeader.PerformLayout()
        pnlVehicleBody.ResumeLayout(False)
        pnlVehicleRight.ResumeLayout(False)
        pnlVehicleGrid.ResumeLayout(False)
        CType(dgvVehicle, ComponentModel.ISupportInitialize).EndInit()
        pnlVehicleSearch.ResumeLayout(False)
        pnlVehicleSearch.PerformLayout()
        pnlVehicleInput.ResumeLayout(False)
        pnlVehicleInput.PerformLayout()
        pnlVehicleBtns.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlVehicleHeader As Panel
    Friend WithEvents lblVehicleTitle As Label
    Friend WithEvents pnlVehicleBody As Panel
    Friend WithEvents pnlVehicleInput As Panel
    Friend WithEvents lblGroupVehicleInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents txtVehicleYear As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVehicleModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVehicleBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbVehicleTransmission As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbVehicleFuelType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVehicleColor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbVehicleStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVehiclePlateNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVehicleMileage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVehicleCategoryName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtVehicleCategoryID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblGroupVehicleCategory As Label
    Friend WithEvents pnlVehicleBtns As Panel
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents btnUpdateVehicle As Button
    Friend WithEvents btnCloseVehicle As Button
    Friend WithEvents btnClearVehicle As Button
    Friend WithEvents btnDeleteVehicle As Button
    Friend WithEvents pnlVehicleRight As Panel
    Friend WithEvents pnlVehicleSearch As Panel
    Friend WithEvents btnRefreshVehicle As Button
    Friend WithEvents txtVehicleSearch As TextBox
    Friend WithEvents pnlVehicleGrid As Panel
    Friend WithEvents dgvVehicle As DataGridView
End Class
