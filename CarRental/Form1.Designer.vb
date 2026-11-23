<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        btnCloseApp = New Button()
        btnMaintenanceHistory = New Button()
        btnPaymentHistory = New Button()
        btnRentalHistory = New Button()
        lblHistory = New Label()
        btnEmployee = New Button()
        btnCategory = New Button()
        btnVehicle = New Button()
        btnCustomer = New Button()
        lblMaintenance = New Label()
        btnPayment = New Button()
        btnReturn = New Button()
        btnRental = New Button()
        lblTransactions = New Label()
        btnDashboard = New Button()
        lblAppTitle = New Label()
        pnlContent = New Panel()
        pnlDashboard = New Panel()
        pnlGrid = New Panel()
        dgvDashboard = New DataGridView()
        pnlRecentHeader = New Panel()
        lblRecentRentals = New Label()
        pnlStats = New Panel()
        pnlCardCustomers = New Panel()
        lblCustomersCount = New Label()
        lblCustomersTitle = New Label()
        pnlCardMaintenance = New Panel()
        lblMaintenanceCount = New Label()
        lblMaintenanceTitle = New Label()
        pnlCardRented = New Panel()
        lblRentedCount = New Label()
        lblRentedTitle = New Label()
        pnlCardAvailable = New Panel()
        lblAvailableCount = New Label()
        lblAvailableTitle = New Label()
        pnlCardTotalVehicles = New Panel()
        lblTotalVehiclesCount = New Label()
        lblTotalVehiclesTitle = New Label()
        pnlDashboardHeader = New Panel()
        lblDashboardTitle = New Label()
        lblAppTitle2 = New Label()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlDashboard.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvDashboard, ComponentModel.ISupportInitialize).BeginInit()
        pnlRecentHeader.SuspendLayout()
        pnlStats.SuspendLayout()
        pnlCardCustomers.SuspendLayout()
        pnlCardMaintenance.SuspendLayout()
        pnlCardRented.SuspendLayout()
        pnlCardAvailable.SuspendLayout()
        pnlCardTotalVehicles.SuspendLayout()
        pnlDashboardHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(26), CByte(58), CByte(107))
        pnlSidebar.Controls.Add(lblAppTitle2)
        pnlSidebar.Controls.Add(btnCloseApp)
        pnlSidebar.Controls.Add(btnMaintenanceHistory)
        pnlSidebar.Controls.Add(btnPaymentHistory)
        pnlSidebar.Controls.Add(btnRentalHistory)
        pnlSidebar.Controls.Add(lblHistory)
        pnlSidebar.Controls.Add(btnEmployee)
        pnlSidebar.Controls.Add(btnCategory)
        pnlSidebar.Controls.Add(btnVehicle)
        pnlSidebar.Controls.Add(btnCustomer)
        pnlSidebar.Controls.Add(lblMaintenance)
        pnlSidebar.Controls.Add(btnPayment)
        pnlSidebar.Controls.Add(btnReturn)
        pnlSidebar.Controls.Add(btnRental)
        pnlSidebar.Controls.Add(lblTransactions)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(lblAppTitle)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 734)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnCloseApp
        ' 
        btnCloseApp.BackColor = Color.DarkRed
        btnCloseApp.Dock = DockStyle.Bottom
        btnCloseApp.FlatStyle = FlatStyle.Flat
        btnCloseApp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseApp.ForeColor = Color.White
        btnCloseApp.Location = New Point(0, 689)
        btnCloseApp.Name = "btnCloseApp"
        btnCloseApp.Padding = New Padding(10, 0, 0, 0)
        btnCloseApp.Size = New Size(220, 45)
        btnCloseApp.TabIndex = 15
        btnCloseApp.Text = "🚪  Close App"
        btnCloseApp.TextAlign = ContentAlignment.MiddleLeft
        btnCloseApp.UseVisualStyleBackColor = False
        ' 
        ' btnMaintenanceHistory
        ' 
        btnMaintenanceHistory.Dock = DockStyle.Top
        btnMaintenanceHistory.FlatStyle = FlatStyle.Flat
        btnMaintenanceHistory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMaintenanceHistory.ForeColor = Color.White
        btnMaintenanceHistory.Location = New Point(0, 600)
        btnMaintenanceHistory.Name = "btnMaintenanceHistory"
        btnMaintenanceHistory.Padding = New Padding(10, 0, 0, 0)
        btnMaintenanceHistory.Size = New Size(220, 45)
        btnMaintenanceHistory.TabIndex = 14
        btnMaintenanceHistory.Text = "🔧  Maintenance"
        btnMaintenanceHistory.TextAlign = ContentAlignment.MiddleLeft
        btnMaintenanceHistory.UseVisualStyleBackColor = True
        ' 
        ' btnPaymentHistory
        ' 
        btnPaymentHistory.Dock = DockStyle.Top
        btnPaymentHistory.FlatStyle = FlatStyle.Flat
        btnPaymentHistory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPaymentHistory.ForeColor = Color.White
        btnPaymentHistory.Location = New Point(0, 555)
        btnPaymentHistory.Name = "btnPaymentHistory"
        btnPaymentHistory.Padding = New Padding(10, 0, 0, 0)
        btnPaymentHistory.Size = New Size(220, 45)
        btnPaymentHistory.TabIndex = 13
        btnPaymentHistory.Text = "💰  Payment"
        btnPaymentHistory.TextAlign = ContentAlignment.MiddleLeft
        btnPaymentHistory.UseVisualStyleBackColor = True
        ' 
        ' btnRentalHistory
        ' 
        btnRentalHistory.Dock = DockStyle.Top
        btnRentalHistory.FlatStyle = FlatStyle.Flat
        btnRentalHistory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRentalHistory.ForeColor = Color.White
        btnRentalHistory.Location = New Point(0, 510)
        btnRentalHistory.Name = "btnRentalHistory"
        btnRentalHistory.Padding = New Padding(10, 0, 0, 0)
        btnRentalHistory.Size = New Size(220, 45)
        btnRentalHistory.TabIndex = 12
        btnRentalHistory.Text = "📜  Rental"
        btnRentalHistory.TextAlign = ContentAlignment.MiddleLeft
        btnRentalHistory.UseVisualStyleBackColor = True
        ' 
        ' lblHistory
        ' 
        lblHistory.Dock = DockStyle.Top
        lblHistory.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHistory.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblHistory.Location = New Point(0, 480)
        lblHistory.Name = "lblHistory"
        lblHistory.Padding = New Padding(12, 0, 0, 0)
        lblHistory.Size = New Size(220, 30)
        lblHistory.TabIndex = 11
        lblHistory.Text = "HISTORY"
        lblHistory.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnEmployee
        ' 
        btnEmployee.Dock = DockStyle.Top
        btnEmployee.FlatStyle = FlatStyle.Flat
        btnEmployee.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEmployee.ForeColor = Color.White
        btnEmployee.Location = New Point(0, 435)
        btnEmployee.Name = "btnEmployee"
        btnEmployee.Padding = New Padding(10, 0, 0, 0)
        btnEmployee.Size = New Size(220, 45)
        btnEmployee.TabIndex = 10
        btnEmployee.Text = "👥  Employee"
        btnEmployee.TextAlign = ContentAlignment.MiddleLeft
        btnEmployee.UseVisualStyleBackColor = True
        ' 
        ' btnCategory
        ' 
        btnCategory.Dock = DockStyle.Top
        btnCategory.FlatStyle = FlatStyle.Flat
        btnCategory.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCategory.ForeColor = Color.White
        btnCategory.Location = New Point(0, 390)
        btnCategory.Name = "btnCategory"
        btnCategory.Padding = New Padding(10, 0, 0, 0)
        btnCategory.Size = New Size(220, 45)
        btnCategory.TabIndex = 9
        btnCategory.Text = "📋  Category"
        btnCategory.TextAlign = ContentAlignment.MiddleLeft
        btnCategory.UseVisualStyleBackColor = True
        ' 
        ' btnVehicle
        ' 
        btnVehicle.Dock = DockStyle.Top
        btnVehicle.FlatStyle = FlatStyle.Flat
        btnVehicle.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVehicle.ForeColor = Color.White
        btnVehicle.Location = New Point(0, 345)
        btnVehicle.Name = "btnVehicle"
        btnVehicle.Padding = New Padding(10, 0, 0, 0)
        btnVehicle.Size = New Size(220, 45)
        btnVehicle.TabIndex = 8
        btnVehicle.Text = "🚙  Vehicle"
        btnVehicle.TextAlign = ContentAlignment.MiddleLeft
        btnVehicle.UseVisualStyleBackColor = True
        ' 
        ' btnCustomer
        ' 
        btnCustomer.Dock = DockStyle.Top
        btnCustomer.FlatStyle = FlatStyle.Flat
        btnCustomer.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCustomer.ForeColor = Color.White
        btnCustomer.Location = New Point(0, 300)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Padding = New Padding(10, 0, 0, 0)
        btnCustomer.Size = New Size(220, 45)
        btnCustomer.TabIndex = 7
        btnCustomer.Text = "👤  Customer"
        btnCustomer.TextAlign = ContentAlignment.MiddleLeft
        btnCustomer.UseVisualStyleBackColor = True
        ' 
        ' lblMaintenance
        ' 
        lblMaintenance.Dock = DockStyle.Top
        lblMaintenance.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaintenance.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblMaintenance.Location = New Point(0, 270)
        lblMaintenance.Name = "lblMaintenance"
        lblMaintenance.Padding = New Padding(12, 0, 0, 0)
        lblMaintenance.Size = New Size(220, 30)
        lblMaintenance.TabIndex = 6
        lblMaintenance.Text = "INFORMATION"
        lblMaintenance.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnPayment
        ' 
        btnPayment.Dock = DockStyle.Top
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPayment.ForeColor = Color.White
        btnPayment.Location = New Point(0, 225)
        btnPayment.Name = "btnPayment"
        btnPayment.Padding = New Padding(10, 0, 0, 0)
        btnPayment.Size = New Size(220, 45)
        btnPayment.TabIndex = 5
        btnPayment.Text = "💳  Payment"
        btnPayment.TextAlign = ContentAlignment.MiddleLeft
        btnPayment.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.Dock = DockStyle.Top
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReturn.ForeColor = Color.White
        btnReturn.ImageAlign = ContentAlignment.MiddleLeft
        btnReturn.Location = New Point(0, 180)
        btnReturn.Name = "btnReturn"
        btnReturn.Padding = New Padding(10, 0, 0, 0)
        btnReturn.Size = New Size(220, 45)
        btnReturn.TabIndex = 4
        btnReturn.Text = "↩️  Return"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' btnRental
        ' 
        btnRental.Dock = DockStyle.Top
        btnRental.FlatStyle = FlatStyle.Flat
        btnRental.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRental.ForeColor = Color.White
        btnRental.Location = New Point(0, 135)
        btnRental.Name = "btnRental"
        btnRental.Padding = New Padding(10, 0, 0, 0)
        btnRental.Size = New Size(220, 45)
        btnRental.TabIndex = 3
        btnRental.Text = "🚗  Rental"
        btnRental.TextAlign = ContentAlignment.MiddleLeft
        btnRental.UseVisualStyleBackColor = True
        ' 
        ' lblTransactions
        ' 
        lblTransactions.Dock = DockStyle.Top
        lblTransactions.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactions.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblTransactions.Location = New Point(0, 105)
        lblTransactions.Name = "lblTransactions"
        lblTransactions.Padding = New Padding(12, 0, 0, 0)
        lblTransactions.Size = New Size(220, 30)
        lblTransactions.TabIndex = 2
        lblTransactions.Text = "TRANSACTIONS"
        lblTransactions.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(0, 60)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 0, 0)
        btnDashboard.Size = New Size(220, 45)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "📊  Overview"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblAppTitle
        ' 
        lblAppTitle.BackColor = Color.FromArgb(CByte(31), CByte(56), CByte(100))
        lblAppTitle.Dock = DockStyle.Top
        lblAppTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblAppTitle.Location = New Point(0, 0)
        lblAppTitle.Name = "lblAppTitle"
        lblAppTitle.Padding = New Padding(50, 0, 0, 10)
        lblAppTitle.Size = New Size(220, 60)
        lblAppTitle.TabIndex = 0
        lblAppTitle.Text = "Car Rental System"
        lblAppTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.WhiteSmoke
        pnlContent.Controls.Add(pnlDashboard)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(220, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(998, 734)
        pnlContent.TabIndex = 0
        ' 
        ' pnlDashboard
        ' 
        pnlDashboard.BackColor = Color.WhiteSmoke
        pnlDashboard.Controls.Add(pnlGrid)
        pnlDashboard.Controls.Add(pnlRecentHeader)
        pnlDashboard.Controls.Add(pnlStats)
        pnlDashboard.Controls.Add(pnlDashboardHeader)
        pnlDashboard.Dock = DockStyle.Fill
        pnlDashboard.Location = New Point(0, 0)
        pnlDashboard.Name = "pnlDashboard"
        pnlDashboard.Size = New Size(998, 734)
        pnlDashboard.TabIndex = 0
        ' 
        ' pnlGrid
        ' 
        pnlGrid.Controls.Add(dgvDashboard)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(0, 220)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(15, 0, 15, 15)
        pnlGrid.Size = New Size(998, 514)
        pnlGrid.TabIndex = 3
        ' 
        ' dgvDashboard
        ' 
        dgvDashboard.AllowUserToAddRows = False
        dgvDashboard.AllowUserToDeleteRows = False
        dgvDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDashboard.BackgroundColor = Color.White
        dgvDashboard.BorderStyle = BorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvDashboard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvDashboard.DefaultCellStyle = DataGridViewCellStyle5
        dgvDashboard.Dock = DockStyle.Fill
        dgvDashboard.Location = New Point(15, 0)
        dgvDashboard.Name = "dgvDashboard"
        dgvDashboard.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvDashboard.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvDashboard.RowHeadersVisible = False
        dgvDashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDashboard.Size = New Size(968, 499)
        dgvDashboard.TabIndex = 0
        ' 
        ' pnlRecentHeader
        ' 
        pnlRecentHeader.Controls.Add(lblRecentRentals)
        pnlRecentHeader.Dock = DockStyle.Top
        pnlRecentHeader.Location = New Point(0, 180)
        pnlRecentHeader.Name = "pnlRecentHeader"
        pnlRecentHeader.Padding = New Padding(15, 0, 0, 0)
        pnlRecentHeader.Size = New Size(998, 40)
        pnlRecentHeader.TabIndex = 2
        ' 
        ' lblRecentRentals
        ' 
        lblRecentRentals.AutoSize = True
        lblRecentRentals.Dock = DockStyle.Fill
        lblRecentRentals.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentRentals.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblRecentRentals.Location = New Point(15, 0)
        lblRecentRentals.Name = "lblRecentRentals"
        lblRecentRentals.Size = New Size(198, 20)
        lblRecentRentals.TabIndex = 0
        lblRecentRentals.Text = "Recent Rental Transactions"
        lblRecentRentals.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlStats
        ' 
        pnlStats.Controls.Add(pnlCardCustomers)
        pnlStats.Controls.Add(pnlCardMaintenance)
        pnlStats.Controls.Add(pnlCardRented)
        pnlStats.Controls.Add(pnlCardAvailable)
        pnlStats.Controls.Add(pnlCardTotalVehicles)
        pnlStats.Dock = DockStyle.Top
        pnlStats.Location = New Point(0, 60)
        pnlStats.Name = "pnlStats"
        pnlStats.Padding = New Padding(15, 15, 15, 0)
        pnlStats.Size = New Size(998, 120)
        pnlStats.TabIndex = 1
        ' 
        ' pnlCardCustomers
        ' 
        pnlCardCustomers.BackColor = Color.White
        pnlCardCustomers.Controls.Add(lblCustomersCount)
        pnlCardCustomers.Controls.Add(lblCustomersTitle)
        pnlCardCustomers.Location = New Point(715, 15)
        pnlCardCustomers.Name = "pnlCardCustomers"
        pnlCardCustomers.Size = New Size(160, 80)
        pnlCardCustomers.TabIndex = 4
        ' 
        ' lblCustomersCount
        ' 
        lblCustomersCount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomersCount.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblCustomersCount.Location = New Point(10, 32)
        lblCustomersCount.Name = "lblCustomersCount"
        lblCustomersCount.Size = New Size(140, 38)
        lblCustomersCount.TabIndex = 1
        lblCustomersCount.Text = "0"
        ' 
        ' lblCustomersTitle
        ' 
        lblCustomersTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomersTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblCustomersTitle.Location = New Point(10, 10)
        lblCustomersTitle.Name = "lblCustomersTitle"
        lblCustomersTitle.Size = New Size(140, 20)
        lblCustomersTitle.TabIndex = 0
        lblCustomersTitle.Text = "Total Customers"
        ' 
        ' pnlCardMaintenance
        ' 
        pnlCardMaintenance.BackColor = Color.White
        pnlCardMaintenance.Controls.Add(lblMaintenanceCount)
        pnlCardMaintenance.Controls.Add(lblMaintenanceTitle)
        pnlCardMaintenance.Location = New Point(540, 15)
        pnlCardMaintenance.Name = "pnlCardMaintenance"
        pnlCardMaintenance.Size = New Size(160, 80)
        pnlCardMaintenance.TabIndex = 3
        ' 
        ' lblMaintenanceCount
        ' 
        lblMaintenanceCount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMaintenanceCount.ForeColor = Color.FromArgb(CByte(133), CByte(79), CByte(11))
        lblMaintenanceCount.Location = New Point(10, 32)
        lblMaintenanceCount.Name = "lblMaintenanceCount"
        lblMaintenanceCount.Size = New Size(140, 38)
        lblMaintenanceCount.TabIndex = 1
        lblMaintenanceCount.Text = "0"
        ' 
        ' lblMaintenanceTitle
        ' 
        lblMaintenanceTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaintenanceTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblMaintenanceTitle.Location = New Point(10, 10)
        lblMaintenanceTitle.Name = "lblMaintenanceTitle"
        lblMaintenanceTitle.Size = New Size(140, 20)
        lblMaintenanceTitle.TabIndex = 0
        lblMaintenanceTitle.Text = "Under Maintenance"
        ' 
        ' pnlCardRented
        ' 
        pnlCardRented.BackColor = Color.White
        pnlCardRented.Controls.Add(lblRentedCount)
        pnlCardRented.Controls.Add(lblRentedTitle)
        pnlCardRented.Location = New Point(365, 15)
        pnlCardRented.Name = "pnlCardRented"
        pnlCardRented.Size = New Size(160, 80)
        pnlCardRented.TabIndex = 2
        ' 
        ' lblRentedCount
        ' 
        lblRentedCount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentedCount.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblRentedCount.Location = New Point(10, 32)
        lblRentedCount.Name = "lblRentedCount"
        lblRentedCount.Size = New Size(140, 38)
        lblRentedCount.TabIndex = 1
        lblRentedCount.Text = "0"
        ' 
        ' lblRentedTitle
        ' 
        lblRentedTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRentedTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblRentedTitle.Location = New Point(10, 10)
        lblRentedTitle.Name = "lblRentedTitle"
        lblRentedTitle.Size = New Size(140, 20)
        lblRentedTitle.TabIndex = 0
        lblRentedTitle.Text = "Currently Rented"
        ' 
        ' pnlCardAvailable
        ' 
        pnlCardAvailable.BackColor = Color.White
        pnlCardAvailable.Controls.Add(lblAvailableCount)
        pnlCardAvailable.Controls.Add(lblAvailableTitle)
        pnlCardAvailable.Location = New Point(190, 15)
        pnlCardAvailable.Name = "pnlCardAvailable"
        pnlCardAvailable.Size = New Size(160, 80)
        pnlCardAvailable.TabIndex = 1
        ' 
        ' lblAvailableCount
        ' 
        lblAvailableCount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvailableCount.ForeColor = Color.FromArgb(CByte(39), CByte(80), CByte(10))
        lblAvailableCount.Location = New Point(10, 32)
        lblAvailableCount.Name = "lblAvailableCount"
        lblAvailableCount.Size = New Size(140, 38)
        lblAvailableCount.TabIndex = 1
        lblAvailableCount.Text = "0"
        ' 
        ' lblAvailableTitle
        ' 
        lblAvailableTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAvailableTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblAvailableTitle.Location = New Point(10, 10)
        lblAvailableTitle.Name = "lblAvailableTitle"
        lblAvailableTitle.Size = New Size(140, 20)
        lblAvailableTitle.TabIndex = 0
        lblAvailableTitle.Text = "Available"
        ' 
        ' pnlCardTotalVehicles
        ' 
        pnlCardTotalVehicles.BackColor = Color.White
        pnlCardTotalVehicles.Controls.Add(lblTotalVehiclesCount)
        pnlCardTotalVehicles.Controls.Add(lblTotalVehiclesTitle)
        pnlCardTotalVehicles.Location = New Point(15, 15)
        pnlCardTotalVehicles.Name = "pnlCardTotalVehicles"
        pnlCardTotalVehicles.Size = New Size(160, 80)
        pnlCardTotalVehicles.TabIndex = 0
        ' 
        ' lblTotalVehiclesCount
        ' 
        lblTotalVehiclesCount.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalVehiclesCount.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblTotalVehiclesCount.Location = New Point(10, 32)
        lblTotalVehiclesCount.Name = "lblTotalVehiclesCount"
        lblTotalVehiclesCount.Size = New Size(140, 38)
        lblTotalVehiclesCount.TabIndex = 1
        lblTotalVehiclesCount.Text = "0"
        ' 
        ' lblTotalVehiclesTitle
        ' 
        lblTotalVehiclesTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalVehiclesTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalVehiclesTitle.Location = New Point(10, 10)
        lblTotalVehiclesTitle.Name = "lblTotalVehiclesTitle"
        lblTotalVehiclesTitle.Size = New Size(140, 20)
        lblTotalVehiclesTitle.TabIndex = 0
        lblTotalVehiclesTitle.Text = "Total Vehicles"
        ' 
        ' pnlDashboardHeader
        ' 
        pnlDashboardHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlDashboardHeader.Controls.Add(lblDashboardTitle)
        pnlDashboardHeader.Dock = DockStyle.Top
        pnlDashboardHeader.Location = New Point(0, 0)
        pnlDashboardHeader.Name = "pnlDashboardHeader"
        pnlDashboardHeader.Size = New Size(998, 60)
        pnlDashboardHeader.TabIndex = 0
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.Dock = DockStyle.Fill
        lblDashboardTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboardTitle.ForeColor = Color.White
        lblDashboardTitle.Location = New Point(0, 0)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Padding = New Padding(15, 0, 0, 0)
        lblDashboardTitle.Size = New Size(998, 60)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = "Dashboard Overview"
        lblDashboardTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblAppTitle2
        ' 
        lblAppTitle2.AutoSize = True
        lblAppTitle2.BackColor = Color.FromArgb(CByte(31), CByte(56), CByte(100))
        lblAppTitle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppTitle2.ForeColor = Color.White
        lblAppTitle2.Location = New Point(45, 9)
        lblAppTitle2.Name = "lblAppTitle2"
        lblAppTitle2.Size = New Size(106, 25)
        lblAppTitle2.TabIndex = 16
        lblAppTitle2.Text = "WheelDeal"
        lblAppTitle2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1218, 734)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Car Rental System"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlDashboard.ResumeLayout(False)
        pnlGrid.ResumeLayout(False)
        CType(dgvDashboard, ComponentModel.ISupportInitialize).EndInit()
        pnlRecentHeader.ResumeLayout(False)
        pnlRecentHeader.PerformLayout()
        pnlStats.ResumeLayout(False)
        pnlCardCustomers.ResumeLayout(False)
        pnlCardMaintenance.ResumeLayout(False)
        pnlCardRented.ResumeLayout(False)
        pnlCardAvailable.ResumeLayout(False)
        pnlCardTotalVehicles.ResumeLayout(False)
        pnlDashboardHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRental As Button
    Friend WithEvents lblTransactions As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents lblMaintenance As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnVehicle As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnCloseApp As Button
    Friend WithEvents btnMaintenanceHistory As Button
    Friend WithEvents btnPaymentHistory As Button
    Friend WithEvents btnRentalHistory As Button
    Friend WithEvents lblHistory As Label
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlDashboardHeader As Panel
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents pnlStats As Panel
    Friend WithEvents pnlCardTotalVehicles As Panel
    Friend WithEvents lblTotalVehiclesCount As Label
    Friend WithEvents lblTotalVehiclesTitle As Label
    Friend WithEvents pnlCardAvailable As Panel
    Friend WithEvents lblAvailableCount As Label
    Friend WithEvents lblAvailableTitle As Label
    Friend WithEvents pnlCardRented As Panel
    Friend WithEvents lblRentedCount As Label
    Friend WithEvents lblRentedTitle As Label
    Friend WithEvents pnlCardMaintenance As Panel
    Friend WithEvents lblMaintenanceCount As Label
    Friend WithEvents lblMaintenanceTitle As Label
    Friend WithEvents pnlCardCustomers As Panel
    Friend WithEvents lblCustomersCount As Label
    Friend WithEvents lblCustomersTitle As Label
    Friend WithEvents pnlRecentHeader As Panel
    Friend WithEvents lblRecentRentals As Label
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvDashboard As DataGridView
    Friend WithEvents lblAppTitle2 As Label

End Class
