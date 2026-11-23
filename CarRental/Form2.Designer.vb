<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalDesign
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
        pnlRentalHeader = New Panel()
        lblRentalTitle = New Label()
        pnlRentalBody = New Panel()
        pnlRentalRight = New Panel()
        pnlRentalGrid = New Panel()
        dgvRental = New DataGridView()
        pnlRentalInfo = New Panel()
        pnlVehicleInfo = New Panel()
        txtVehicleInfo = New TextBox()
        lblVehicleInfoTitle = New Label()
        pnlCustomerInfo = New Panel()
        txtCustomerInfo = New TextBox()
        lblCustomerInfoTitle = New Label()
        pnlRentalSearch = New Panel()
        btnRefreshRental = New Button()
        txtRentalSearch = New TextBox()
        pnlRentalInput = New Panel()
        pnlRentalButtons = New Panel()
        btnCloseRental = New Button()
        btnClearRental = New Button()
        btnDeleteRental = New Button()
        btnUpdateRental = New Button()
        btnAddRental = New Button()
        txtClerkName = New TextBox()
        Label11 = New Label()
        txtRentalEmployeeID = New TextBox()
        Label10 = New Label()
        lblGroupProcessedBy = New Label()
        txtBrandModel = New TextBox()
        Label9 = New Label()
        txtPlateNo = New TextBox()
        Label8 = New Label()
        txtVehicleID = New TextBox()
        Label7 = New Label()
        lblGroupVehicle = New Label()
        txtCustomerName = New TextBox()
        txtCustomerID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        lblGroupCustomer = New Label()
        cbRentalStatus = New ComboBox()
        Label4 = New Label()
        dtpDateDueReturn = New DateTimePicker()
        Label3 = New Label()
        dtpDateRented = New DateTimePicker()
        Label2 = New Label()
        txtRentalID = New TextBox()
        Label1 = New Label()
        lblGroupRentalInfo = New Label()
        pnlRentalHeader.SuspendLayout()
        pnlRentalBody.SuspendLayout()
        pnlRentalRight.SuspendLayout()
        pnlRentalGrid.SuspendLayout()
        CType(dgvRental, ComponentModel.ISupportInitialize).BeginInit()
        pnlRentalInfo.SuspendLayout()
        pnlVehicleInfo.SuspendLayout()
        pnlCustomerInfo.SuspendLayout()
        pnlRentalSearch.SuspendLayout()
        pnlRentalInput.SuspendLayout()
        pnlRentalButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlRentalHeader
        ' 
        pnlRentalHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlRentalHeader.Controls.Add(lblRentalTitle)
        pnlRentalHeader.Dock = DockStyle.Top
        pnlRentalHeader.Location = New Point(0, 0)
        pnlRentalHeader.Name = "pnlRentalHeader"
        pnlRentalHeader.Size = New Size(1156, 60)
        pnlRentalHeader.TabIndex = 0
        ' 
        ' lblRentalTitle
        ' 
        lblRentalTitle.AutoSize = True
        lblRentalTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalTitle.ForeColor = Color.White
        lblRentalTitle.ImageAlign = ContentAlignment.MiddleLeft
        lblRentalTitle.Location = New Point(13, 18)
        lblRentalTitle.Name = "lblRentalTitle"
        lblRentalTitle.Padding = New Padding(15, 0, 0, 0)
        lblRentalTitle.Size = New Size(191, 25)
        lblRentalTitle.TabIndex = 0
        lblRentalTitle.Text = "Rental Transaction"
        lblRentalTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlRentalBody
        ' 
        pnlRentalBody.Controls.Add(pnlRentalRight)
        pnlRentalBody.Controls.Add(pnlRentalInput)
        pnlRentalBody.Dock = DockStyle.Fill
        pnlRentalBody.Location = New Point(0, 60)
        pnlRentalBody.Name = "pnlRentalBody"
        pnlRentalBody.Size = New Size(1156, 939)
        pnlRentalBody.TabIndex = 1
        ' 
        ' pnlRentalRight
        ' 
        pnlRentalRight.Controls.Add(pnlRentalGrid)
        pnlRentalRight.Controls.Add(pnlRentalInfo)
        pnlRentalRight.Controls.Add(pnlRentalSearch)
        pnlRentalRight.Dock = DockStyle.Fill
        pnlRentalRight.Location = New Point(300, 0)
        pnlRentalRight.Name = "pnlRentalRight"
        pnlRentalRight.Padding = New Padding(12)
        pnlRentalRight.Size = New Size(856, 939)
        pnlRentalRight.TabIndex = 1
        ' 
        ' pnlRentalGrid
        ' 
        pnlRentalGrid.Controls.Add(dgvRental)
        pnlRentalGrid.Dock = DockStyle.Fill
        pnlRentalGrid.Location = New Point(12, 60)
        pnlRentalGrid.Name = "pnlRentalGrid"
        pnlRentalGrid.Size = New Size(832, 747)
        pnlRentalGrid.TabIndex = 2
        ' 
        ' dgvRental
        ' 
        dgvRental.AllowUserToAddRows = False
        dgvRental.AllowUserToDeleteRows = False
        dgvRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRental.BackgroundColor = Color.White
        dgvRental.BorderStyle = BorderStyle.None
        dgvRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvRental.DefaultCellStyle = DataGridViewCellStyle1
        dgvRental.Dock = DockStyle.Fill
        dgvRental.Location = New Point(0, 0)
        dgvRental.Name = "dgvRental"
        dgvRental.ReadOnly = True
        dgvRental.RowHeadersVisible = False
        dgvRental.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRental.Size = New Size(832, 747)
        dgvRental.TabIndex = 0
        ' 
        ' pnlRentalInfo
        ' 
        pnlRentalInfo.Controls.Add(pnlVehicleInfo)
        pnlRentalInfo.Controls.Add(pnlCustomerInfo)
        pnlRentalInfo.Dock = DockStyle.Bottom
        pnlRentalInfo.Location = New Point(12, 807)
        pnlRentalInfo.Name = "pnlRentalInfo"
        pnlRentalInfo.Padding = New Padding(0, 8, 0, 0)
        pnlRentalInfo.Size = New Size(832, 120)
        pnlRentalInfo.TabIndex = 1
        ' 
        ' pnlVehicleInfo
        ' 
        pnlVehicleInfo.BackColor = Color.White
        pnlVehicleInfo.Controls.Add(txtVehicleInfo)
        pnlVehicleInfo.Controls.Add(lblVehicleInfoTitle)
        pnlVehicleInfo.Dock = DockStyle.Fill
        pnlVehicleInfo.Location = New Point(416, 8)
        pnlVehicleInfo.Name = "pnlVehicleInfo"
        pnlVehicleInfo.Padding = New Padding(8)
        pnlVehicleInfo.Size = New Size(416, 112)
        pnlVehicleInfo.TabIndex = 1
        ' 
        ' txtVehicleInfo
        ' 
        txtVehicleInfo.BackColor = Color.White
        txtVehicleInfo.BorderStyle = BorderStyle.None
        txtVehicleInfo.Dock = DockStyle.Fill
        txtVehicleInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVehicleInfo.Location = New Point(8, 28)
        txtVehicleInfo.Multiline = True
        txtVehicleInfo.Name = "txtVehicleInfo"
        txtVehicleInfo.ReadOnly = True
        txtVehicleInfo.ScrollBars = ScrollBars.Vertical
        txtVehicleInfo.Size = New Size(400, 76)
        txtVehicleInfo.TabIndex = 2
        ' 
        ' lblVehicleInfoTitle
        ' 
        lblVehicleInfoTitle.Dock = DockStyle.Top
        lblVehicleInfoTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVehicleInfoTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblVehicleInfoTitle.Location = New Point(8, 8)
        lblVehicleInfoTitle.Name = "lblVehicleInfoTitle"
        lblVehicleInfoTitle.Size = New Size(400, 20)
        lblVehicleInfoTitle.TabIndex = 1
        lblVehicleInfoTitle.Text = "VEHICLE INFO"
        ' 
        ' pnlCustomerInfo
        ' 
        pnlCustomerInfo.BackColor = Color.White
        pnlCustomerInfo.Controls.Add(txtCustomerInfo)
        pnlCustomerInfo.Controls.Add(lblCustomerInfoTitle)
        pnlCustomerInfo.Dock = DockStyle.Left
        pnlCustomerInfo.Location = New Point(0, 8)
        pnlCustomerInfo.Margin = New Padding(0, 0, 4, 0)
        pnlCustomerInfo.Name = "pnlCustomerInfo"
        pnlCustomerInfo.Padding = New Padding(8)
        pnlCustomerInfo.Size = New Size(416, 112)
        pnlCustomerInfo.TabIndex = 0
        ' 
        ' txtCustomerInfo
        ' 
        txtCustomerInfo.BackColor = Color.White
        txtCustomerInfo.BorderStyle = BorderStyle.None
        txtCustomerInfo.Dock = DockStyle.Fill
        txtCustomerInfo.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerInfo.Location = New Point(8, 28)
        txtCustomerInfo.Multiline = True
        txtCustomerInfo.Name = "txtCustomerInfo"
        txtCustomerInfo.ReadOnly = True
        txtCustomerInfo.ScrollBars = ScrollBars.Vertical
        txtCustomerInfo.Size = New Size(400, 76)
        txtCustomerInfo.TabIndex = 1
        ' 
        ' lblCustomerInfoTitle
        ' 
        lblCustomerInfoTitle.Dock = DockStyle.Top
        lblCustomerInfoTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerInfoTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblCustomerInfoTitle.Location = New Point(8, 8)
        lblCustomerInfoTitle.Name = "lblCustomerInfoTitle"
        lblCustomerInfoTitle.Size = New Size(400, 20)
        lblCustomerInfoTitle.TabIndex = 0
        lblCustomerInfoTitle.Text = "CUSTOMER INFO"
        ' 
        ' pnlRentalSearch
        ' 
        pnlRentalSearch.Controls.Add(btnRefreshRental)
        pnlRentalSearch.Controls.Add(txtRentalSearch)
        pnlRentalSearch.Dock = DockStyle.Top
        pnlRentalSearch.Location = New Point(12, 12)
        pnlRentalSearch.Name = "pnlRentalSearch"
        pnlRentalSearch.Size = New Size(832, 48)
        pnlRentalSearch.TabIndex = 0
        ' 
        ' btnRefreshRental
        ' 
        btnRefreshRental.Cursor = Cursors.Hand
        btnRefreshRental.FlatStyle = FlatStyle.Flat
        btnRefreshRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefreshRental.Location = New Point(360, 5)
        btnRefreshRental.Name = "btnRefreshRental"
        btnRefreshRental.Size = New Size(100, 35)
        btnRefreshRental.TabIndex = 1
        btnRefreshRental.Text = "🔄 Refresh"
        btnRefreshRental.UseVisualStyleBackColor = True
        ' 
        ' txtRentalSearch
        ' 
        txtRentalSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtRentalSearch.Location = New Point(0, 8)
        txtRentalSearch.Name = "txtRentalSearch"
        txtRentalSearch.Size = New Size(350, 25)
        txtRentalSearch.TabIndex = 0
        txtRentalSearch.Text = "Search by Customer, Vehicle, or Status..."
        ' 
        ' pnlRentalInput
        ' 
        pnlRentalInput.BackColor = Color.White
        pnlRentalInput.Controls.Add(pnlRentalButtons)
        pnlRentalInput.Controls.Add(txtClerkName)
        pnlRentalInput.Controls.Add(Label11)
        pnlRentalInput.Controls.Add(txtRentalEmployeeID)
        pnlRentalInput.Controls.Add(Label10)
        pnlRentalInput.Controls.Add(lblGroupProcessedBy)
        pnlRentalInput.Controls.Add(txtBrandModel)
        pnlRentalInput.Controls.Add(Label9)
        pnlRentalInput.Controls.Add(txtPlateNo)
        pnlRentalInput.Controls.Add(Label8)
        pnlRentalInput.Controls.Add(txtVehicleID)
        pnlRentalInput.Controls.Add(Label7)
        pnlRentalInput.Controls.Add(lblGroupVehicle)
        pnlRentalInput.Controls.Add(txtCustomerName)
        pnlRentalInput.Controls.Add(txtCustomerID)
        pnlRentalInput.Controls.Add(Label6)
        pnlRentalInput.Controls.Add(Label5)
        pnlRentalInput.Controls.Add(lblGroupCustomer)
        pnlRentalInput.Controls.Add(cbRentalStatus)
        pnlRentalInput.Controls.Add(Label4)
        pnlRentalInput.Controls.Add(dtpDateDueReturn)
        pnlRentalInput.Controls.Add(Label3)
        pnlRentalInput.Controls.Add(dtpDateRented)
        pnlRentalInput.Controls.Add(Label2)
        pnlRentalInput.Controls.Add(txtRentalID)
        pnlRentalInput.Controls.Add(Label1)
        pnlRentalInput.Controls.Add(lblGroupRentalInfo)
        pnlRentalInput.Dock = DockStyle.Left
        pnlRentalInput.Location = New Point(0, 0)
        pnlRentalInput.Name = "pnlRentalInput"
        pnlRentalInput.Padding = New Padding(12)
        pnlRentalInput.Size = New Size(300, 939)
        pnlRentalInput.TabIndex = 0
        ' 
        ' pnlRentalButtons
        ' 
        pnlRentalButtons.Controls.Add(btnCloseRental)
        pnlRentalButtons.Controls.Add(btnClearRental)
        pnlRentalButtons.Controls.Add(btnDeleteRental)
        pnlRentalButtons.Controls.Add(btnUpdateRental)
        pnlRentalButtons.Controls.Add(btnAddRental)
        pnlRentalButtons.Dock = DockStyle.Bottom
        pnlRentalButtons.Location = New Point(12, 827)
        pnlRentalButtons.Name = "pnlRentalButtons"
        pnlRentalButtons.Size = New Size(276, 100)
        pnlRentalButtons.TabIndex = 26
        ' 
        ' btnCloseRental
        ' 
        btnCloseRental.BackColor = Color.DarkRed
        btnCloseRental.Cursor = Cursors.Hand
        btnCloseRental.FlatStyle = FlatStyle.Flat
        btnCloseRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseRental.ForeColor = Color.White
        btnCloseRental.Location = New Point(133, 52)
        btnCloseRental.Name = "btnCloseRental"
        btnCloseRental.Size = New Size(80, 38)
        btnCloseRental.TabIndex = 5
        btnCloseRental.Text = "🚪 Close"
        btnCloseRental.UseVisualStyleBackColor = False
        ' 
        ' btnClearRental
        ' 
        btnClearRental.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearRental.Cursor = Cursors.Hand
        btnClearRental.FlatStyle = FlatStyle.Flat
        btnClearRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearRental.ForeColor = Color.White
        btnClearRental.Location = New Point(45, 52)
        btnClearRental.Name = "btnClearRental"
        btnClearRental.Size = New Size(80, 38)
        btnClearRental.TabIndex = 4
        btnClearRental.Text = "✖️ Clear"
        btnClearRental.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRental
        ' 
        btnDeleteRental.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteRental.Cursor = Cursors.Hand
        btnDeleteRental.FlatStyle = FlatStyle.Flat
        btnDeleteRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteRental.ForeColor = Color.White
        btnDeleteRental.Location = New Point(175, 8)
        btnDeleteRental.Name = "btnDeleteRental"
        btnDeleteRental.Size = New Size(80, 38)
        btnDeleteRental.TabIndex = 2
        btnDeleteRental.Text = "🗑️ Delete"
        btnDeleteRental.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRental
        ' 
        btnUpdateRental.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateRental.Cursor = Cursors.Hand
        btnUpdateRental.FlatStyle = FlatStyle.Flat
        btnUpdateRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateRental.ForeColor = Color.White
        btnUpdateRental.Location = New Point(90, 8)
        btnUpdateRental.Name = "btnUpdateRental"
        btnUpdateRental.Size = New Size(80, 38)
        btnUpdateRental.TabIndex = 1
        btnUpdateRental.Text = "✏️ Update"
        btnUpdateRental.UseVisualStyleBackColor = False
        ' 
        ' btnAddRental
        ' 
        btnAddRental.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddRental.Cursor = Cursors.Hand
        btnAddRental.FlatStyle = FlatStyle.Flat
        btnAddRental.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddRental.ForeColor = Color.White
        btnAddRental.Location = New Point(5, 8)
        btnAddRental.Name = "btnAddRental"
        btnAddRental.Size = New Size(80, 38)
        btnAddRental.TabIndex = 0
        btnAddRental.Text = "➕ Add"
        btnAddRental.UseVisualStyleBackColor = False
        ' 
        ' txtClerkName
        ' 
        txtClerkName.BackColor = SystemColors.ButtonFace
        txtClerkName.Location = New Point(13, 651)
        txtClerkName.Name = "txtClerkName"
        txtClerkName.ReadOnly = True
        txtClerkName.Size = New Size(265, 25)
        txtClerkName.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(13, 633)
        Label11.Name = "Label11"
        Label11.Size = New Size(79, 17)
        Label11.TabIndex = 24
        Label11.Text = "Clerk Name:"
        ' 
        ' txtRentalEmployeeID
        ' 
        txtRentalEmployeeID.Location = New Point(13, 593)
        txtRentalEmployeeID.Name = "txtRentalEmployeeID"
        txtRentalEmployeeID.Size = New Size(265, 25)
        txtRentalEmployeeID.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(13, 575)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 17)
        Label10.TabIndex = 22
        Label10.Text = "Employee ID:"
        ' 
        ' lblGroupProcessedBy
        ' 
        lblGroupProcessedBy.AutoSize = True
        lblGroupProcessedBy.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupProcessedBy.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupProcessedBy.Location = New Point(13, 555)
        lblGroupProcessedBy.Name = "lblGroupProcessedBy"
        lblGroupProcessedBy.Size = New Size(85, 13)
        lblGroupProcessedBy.TabIndex = 21
        lblGroupProcessedBy.Text = "PROCESSED BY"
        ' 
        ' txtBrandModel
        ' 
        txtBrandModel.BackColor = SystemColors.ButtonFace
        txtBrandModel.Location = New Point(145, 511)
        txtBrandModel.Name = "txtBrandModel"
        txtBrandModel.ReadOnly = True
        txtBrandModel.Size = New Size(132, 25)
        txtBrandModel.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(145, 493)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 17)
        Label9.TabIndex = 19
        Label9.Text = "Brand and Model:"
        ' 
        ' txtPlateNo
        ' 
        txtPlateNo.BackColor = SystemColors.ButtonFace
        txtPlateNo.Location = New Point(12, 511)
        txtPlateNo.Name = "txtPlateNo"
        txtPlateNo.ReadOnly = True
        txtPlateNo.Size = New Size(125, 25)
        txtPlateNo.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 493)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 17)
        Label8.TabIndex = 17
        Label8.Text = "Plate No:"
        ' 
        ' txtVehicleID
        ' 
        txtVehicleID.Location = New Point(12, 453)
        txtVehicleID.Name = "txtVehicleID"
        txtVehicleID.Size = New Size(265, 25)
        txtVehicleID.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 435)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 17)
        Label7.TabIndex = 15
        Label7.Text = "Vehicle ID:"
        ' 
        ' lblGroupVehicle
        ' 
        lblGroupVehicle.AutoSize = True
        lblGroupVehicle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupVehicle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupVehicle.Location = New Point(12, 415)
        lblGroupVehicle.Name = "lblGroupVehicle"
        lblGroupVehicle.Size = New Size(50, 13)
        lblGroupVehicle.TabIndex = 14
        lblGroupVehicle.Text = "VEHICLE"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = SystemColors.ButtonFace
        txtCustomerName.Location = New Point(12, 371)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(265, 25)
        txtCustomerName.TabIndex = 13
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(12, 313)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(265, 25)
        txtCustomerID.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 17)
        Label6.TabIndex = 11
        Label6.Text = "Customer ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 353)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 17)
        Label5.TabIndex = 10
        Label5.Text = "Customer Name:"
        ' 
        ' lblGroupCustomer
        ' 
        lblGroupCustomer.AutoSize = True
        lblGroupCustomer.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupCustomer.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupCustomer.Location = New Point(12, 275)
        lblGroupCustomer.Name = "lblGroupCustomer"
        lblGroupCustomer.Size = New Size(66, 13)
        lblGroupCustomer.TabIndex = 9
        lblGroupCustomer.Text = "CUSTOMER"
        ' 
        ' cbRentalStatus
        ' 
        cbRentalStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbRentalStatus.FormattingEnabled = True
        cbRentalStatus.Items.AddRange(New Object() {"Active", "Returned", "Cancelled"})
        cbRentalStatus.Location = New Point(12, 232)
        cbRentalStatus.Name = "cbRentalStatus"
        cbRentalStatus.Size = New Size(265, 25)
        cbRentalStatus.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 17)
        Label4.TabIndex = 7
        Label4.Text = "Rental Status:"
        ' 
        ' dtpDateDueReturn
        ' 
        dtpDateDueReturn.Format = DateTimePickerFormat.Short
        dtpDateDueReturn.Location = New Point(12, 174)
        dtpDateDueReturn.Name = "dtpDateDueReturn"
        dtpDateDueReturn.Size = New Size(265, 25)
        dtpDateDueReturn.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 17)
        Label3.TabIndex = 5
        Label3.Text = "Date Due Return:"
        ' 
        ' dtpDateRented
        ' 
        dtpDateRented.Format = DateTimePickerFormat.Short
        dtpDateRented.Location = New Point(12, 116)
        dtpDateRented.Name = "dtpDateRented"
        dtpDateRented.Size = New Size(265, 25)
        dtpDateRented.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 17)
        Label2.TabIndex = 3
        Label2.Text = "Date Rented:"
        ' 
        ' txtRentalID
        ' 
        txtRentalID.Location = New Point(12, 58)
        txtRentalID.Name = "txtRentalID"
        txtRentalID.Size = New Size(265, 25)
        txtRentalID.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 17)
        Label1.TabIndex = 1
        Label1.Text = "Rental ID:"
        ' 
        ' lblGroupRentalInfo
        ' 
        lblGroupRentalInfo.AutoSize = True
        lblGroupRentalInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupRentalInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupRentalInfo.Location = New Point(12, 15)
        lblGroupRentalInfo.Name = "lblGroupRentalInfo"
        lblGroupRentalInfo.Size = New Size(77, 13)
        lblGroupRentalInfo.TabIndex = 0
        lblGroupRentalInfo.Text = "RENTAL INFO"
        ' 
        ' frmRentalDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1156, 999)
        Controls.Add(pnlRentalBody)
        Controls.Add(pnlRentalHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmRentalDesign"
        Text = "Rental Transaction"
        WindowState = FormWindowState.Maximized
        pnlRentalHeader.ResumeLayout(False)
        pnlRentalHeader.PerformLayout()
        pnlRentalBody.ResumeLayout(False)
        pnlRentalRight.ResumeLayout(False)
        pnlRentalGrid.ResumeLayout(False)
        CType(dgvRental, ComponentModel.ISupportInitialize).EndInit()
        pnlRentalInfo.ResumeLayout(False)
        pnlVehicleInfo.ResumeLayout(False)
        pnlVehicleInfo.PerformLayout()
        pnlCustomerInfo.ResumeLayout(False)
        pnlCustomerInfo.PerformLayout()
        pnlRentalSearch.ResumeLayout(False)
        pnlRentalSearch.PerformLayout()
        pnlRentalInput.ResumeLayout(False)
        pnlRentalInput.PerformLayout()
        pnlRentalButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRentalHeader As Panel
    Friend WithEvents lblRentalTitle As Label
    Friend WithEvents pnlRentalBody As Panel
    Friend WithEvents pnlRentalInput As Panel
    Friend WithEvents dtpDateRented As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRentalID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGroupRentalInfo As Label
    Friend WithEvents cbRentalStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateDueReturn As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblGroupCustomer As Label
    Friend WithEvents txtPlateNo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGroupVehicle As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClerkName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRentalEmployeeID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblGroupProcessedBy As Label
    Friend WithEvents txtBrandModel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlRentalButtons As Panel
    Friend WithEvents btnDeleteRental As Button
    Friend WithEvents btnUpdateRental As Button
    Friend WithEvents btnAddRental As Button
    Friend WithEvents btnClearRental As Button
    Friend WithEvents pnlRentalRight As Panel
    Friend WithEvents pnlRentalSearch As Panel
    Friend WithEvents btnRefreshRental As Button
    Friend WithEvents txtRentalSearch As TextBox
    Friend WithEvents pnlRentalInfo As Panel
    Friend WithEvents pnlCustomerInfo As Panel
    Friend WithEvents pnlVehicleInfo As Panel
    Friend WithEvents txtVehicleInfo As TextBox
    Friend WithEvents lblVehicleInfoTitle As Label
    Friend WithEvents txtCustomerInfo As TextBox
    Friend WithEvents lblCustomerInfoTitle As Label
    Friend WithEvents pnlRentalGrid As Panel
    Friend WithEvents dgvRental As DataGridView
    Friend WithEvents btnCloseRental As Button
End Class
