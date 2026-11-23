<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentDesign
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblPaymentTitle = New Label()
        pnlPaymentHeader = New Panel()
        pnlPaymentBody = New Panel()
        pnlPaymentGrid = New Panel()
        dgvPayment = New DataGridView()
        pnlPaymentInfo = New Panel()
        pnlCustomerInfoPayment = New Panel()
        txtCustomerInfoPayment = New TextBox()
        lblCustomerInfoPaymentTitle = New Label()
        pnlRentalInfoPayment = New Panel()
        txtRentalInfoPayment = New TextBox()
        lblRentalInfoPaymentTitle = New Label()
        pnlPaymentSearch = New Panel()
        btnRefreshPayment = New Button()
        txtPaymentSearch = New TextBox()
        pnlPaymentInput = New Panel()
        pnlPaymentButtons = New Panel()
        btnClosePayment = New Button()
        btnClearPayment = New Button()
        btnDeletePayment = New Button()
        btnUpdatePayment = New Button()
        btnAddPayment = New Button()
        txtPaymentClerkName = New TextBox()
        Label8 = New Label()
        txtPaymentEmployeeID = New TextBox()
        Label9 = New Label()
        lblGroupPaymentProcessedBy = New Label()
        cbPaymentStatus = New ComboBox()
        Label7 = New Label()
        cbPaymentMethod = New ComboBox()
        Label6 = New Label()
        txtReceiptNo = New TextBox()
        Label5 = New Label()
        txtAmountPaid = New TextBox()
        Label4 = New Label()
        dtpPaymentDate = New DateTimePicker()
        Label3 = New Label()
        txtPaymentNo = New TextBox()
        Label2 = New Label()
        txtPaymentRentalID = New TextBox()
        Label1 = New Label()
        lblGroupPaymentInfo = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        pnlPaymentHeader.SuspendLayout()
        pnlPaymentBody.SuspendLayout()
        pnlPaymentGrid.SuspendLayout()
        CType(dgvPayment, ComponentModel.ISupportInitialize).BeginInit()
        pnlPaymentInfo.SuspendLayout()
        pnlCustomerInfoPayment.SuspendLayout()
        pnlRentalInfoPayment.SuspendLayout()
        pnlPaymentSearch.SuspendLayout()
        pnlPaymentInput.SuspendLayout()
        pnlPaymentButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPaymentTitle
        ' 
        lblPaymentTitle.AutoSize = True
        lblPaymentTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentTitle.ForeColor = Color.White
        lblPaymentTitle.Location = New Point(3, 18)
        lblPaymentTitle.Name = "lblPaymentTitle"
        lblPaymentTitle.Padding = New Padding(15, 0, 0, 0)
        lblPaymentTitle.Size = New Size(213, 25)
        lblPaymentTitle.TabIndex = 0
        lblPaymentTitle.Text = "Payment Transaction"
        lblPaymentTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlPaymentHeader
        ' 
        pnlPaymentHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlPaymentHeader.Controls.Add(lblPaymentTitle)
        pnlPaymentHeader.Dock = DockStyle.Top
        pnlPaymentHeader.Location = New Point(0, 0)
        pnlPaymentHeader.Name = "pnlPaymentHeader"
        pnlPaymentHeader.Size = New Size(1113, 60)
        pnlPaymentHeader.TabIndex = 1
        ' 
        ' pnlPaymentBody
        ' 
        pnlPaymentBody.Controls.Add(pnlPaymentGrid)
        pnlPaymentBody.Controls.Add(pnlPaymentInfo)
        pnlPaymentBody.Controls.Add(pnlPaymentSearch)
        pnlPaymentBody.Controls.Add(pnlPaymentInput)
        pnlPaymentBody.Dock = DockStyle.Fill
        pnlPaymentBody.Location = New Point(0, 60)
        pnlPaymentBody.Name = "pnlPaymentBody"
        pnlPaymentBody.Size = New Size(1113, 769)
        pnlPaymentBody.TabIndex = 2
        ' 
        ' pnlPaymentGrid
        ' 
        pnlPaymentGrid.Controls.Add(dgvPayment)
        pnlPaymentGrid.Dock = DockStyle.Fill
        pnlPaymentGrid.Location = New Point(300, 48)
        pnlPaymentGrid.Name = "pnlPaymentGrid"
        pnlPaymentGrid.Padding = New Padding(12)
        pnlPaymentGrid.Size = New Size(813, 601)
        pnlPaymentGrid.TabIndex = 3
        ' 
        ' dgvPayment
        ' 
        dgvPayment.AllowUserToAddRows = False
        dgvPayment.AllowUserToDeleteRows = False
        dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPayment.BackgroundColor = Color.White
        dgvPayment.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvPayment.DefaultCellStyle = DataGridViewCellStyle4
        dgvPayment.Dock = DockStyle.Fill
        dgvPayment.Location = New Point(12, 12)
        dgvPayment.Name = "dgvPayment"
        dgvPayment.ReadOnly = True
        dgvPayment.RowHeadersVisible = False
        dgvPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPayment.Size = New Size(789, 577)
        dgvPayment.TabIndex = 1
        ' 
        ' pnlPaymentInfo
        ' 
        pnlPaymentInfo.Controls.Add(pnlCustomerInfoPayment)
        pnlPaymentInfo.Controls.Add(pnlRentalInfoPayment)
        pnlPaymentInfo.Dock = DockStyle.Bottom
        pnlPaymentInfo.Location = New Point(300, 649)
        pnlPaymentInfo.Name = "pnlPaymentInfo"
        pnlPaymentInfo.Padding = New Padding(0, 8, 0, 0)
        pnlPaymentInfo.Size = New Size(813, 120)
        pnlPaymentInfo.TabIndex = 2
        ' 
        ' pnlCustomerInfoPayment
        ' 
        pnlCustomerInfoPayment.BackColor = Color.White
        pnlCustomerInfoPayment.Controls.Add(txtCustomerInfoPayment)
        pnlCustomerInfoPayment.Controls.Add(lblCustomerInfoPaymentTitle)
        pnlCustomerInfoPayment.Dock = DockStyle.Fill
        pnlCustomerInfoPayment.Location = New Point(400, 8)
        pnlCustomerInfoPayment.Name = "pnlCustomerInfoPayment"
        pnlCustomerInfoPayment.Padding = New Padding(8)
        pnlCustomerInfoPayment.Size = New Size(413, 112)
        pnlCustomerInfoPayment.TabIndex = 1
        ' 
        ' txtCustomerInfoPayment
        ' 
        txtCustomerInfoPayment.BackColor = Color.White
        txtCustomerInfoPayment.BorderStyle = BorderStyle.None
        txtCustomerInfoPayment.Dock = DockStyle.Fill
        txtCustomerInfoPayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCustomerInfoPayment.Location = New Point(8, 28)
        txtCustomerInfoPayment.Multiline = True
        txtCustomerInfoPayment.Name = "txtCustomerInfoPayment"
        txtCustomerInfoPayment.ReadOnly = True
        txtCustomerInfoPayment.ScrollBars = ScrollBars.Vertical
        txtCustomerInfoPayment.Size = New Size(397, 76)
        txtCustomerInfoPayment.TabIndex = 3
        ' 
        ' lblCustomerInfoPaymentTitle
        ' 
        lblCustomerInfoPaymentTitle.Dock = DockStyle.Top
        lblCustomerInfoPaymentTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerInfoPaymentTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblCustomerInfoPaymentTitle.Location = New Point(8, 8)
        lblCustomerInfoPaymentTitle.Name = "lblCustomerInfoPaymentTitle"
        lblCustomerInfoPaymentTitle.Size = New Size(397, 20)
        lblCustomerInfoPaymentTitle.TabIndex = 2
        lblCustomerInfoPaymentTitle.Text = "CUSTOMER INFO"
        ' 
        ' pnlRentalInfoPayment
        ' 
        pnlRentalInfoPayment.BackColor = Color.White
        pnlRentalInfoPayment.Controls.Add(txtRentalInfoPayment)
        pnlRentalInfoPayment.Controls.Add(lblRentalInfoPaymentTitle)
        pnlRentalInfoPayment.Dock = DockStyle.Left
        pnlRentalInfoPayment.Location = New Point(0, 8)
        pnlRentalInfoPayment.Name = "pnlRentalInfoPayment"
        pnlRentalInfoPayment.Padding = New Padding(8)
        pnlRentalInfoPayment.Size = New Size(400, 112)
        pnlRentalInfoPayment.TabIndex = 0
        ' 
        ' txtRentalInfoPayment
        ' 
        txtRentalInfoPayment.BackColor = Color.White
        txtRentalInfoPayment.BorderStyle = BorderStyle.None
        txtRentalInfoPayment.Dock = DockStyle.Fill
        txtRentalInfoPayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRentalInfoPayment.Location = New Point(8, 28)
        txtRentalInfoPayment.Multiline = True
        txtRentalInfoPayment.Name = "txtRentalInfoPayment"
        txtRentalInfoPayment.ReadOnly = True
        txtRentalInfoPayment.ScrollBars = ScrollBars.Vertical
        txtRentalInfoPayment.Size = New Size(384, 76)
        txtRentalInfoPayment.TabIndex = 1
        ' 
        ' lblRentalInfoPaymentTitle
        ' 
        lblRentalInfoPaymentTitle.Dock = DockStyle.Top
        lblRentalInfoPaymentTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalInfoPaymentTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblRentalInfoPaymentTitle.Location = New Point(8, 8)
        lblRentalInfoPaymentTitle.Name = "lblRentalInfoPaymentTitle"
        lblRentalInfoPaymentTitle.Size = New Size(384, 20)
        lblRentalInfoPaymentTitle.TabIndex = 0
        lblRentalInfoPaymentTitle.Text = "RENTAL INFO"
        ' 
        ' pnlPaymentSearch
        ' 
        pnlPaymentSearch.Controls.Add(btnRefreshPayment)
        pnlPaymentSearch.Controls.Add(txtPaymentSearch)
        pnlPaymentSearch.Dock = DockStyle.Top
        pnlPaymentSearch.Location = New Point(300, 0)
        pnlPaymentSearch.Name = "pnlPaymentSearch"
        pnlPaymentSearch.Size = New Size(813, 48)
        pnlPaymentSearch.TabIndex = 1
        ' 
        ' btnRefreshPayment
        ' 
        btnRefreshPayment.Cursor = Cursors.Hand
        btnRefreshPayment.FlatStyle = FlatStyle.Flat
        btnRefreshPayment.Location = New Point(360, 5)
        btnRefreshPayment.Name = "btnRefreshPayment"
        btnRefreshPayment.Size = New Size(100, 35)
        btnRefreshPayment.TabIndex = 1
        btnRefreshPayment.Text = "🔄 Refresh"
        btnRefreshPayment.UseVisualStyleBackColor = True
        ' 
        ' txtPaymentSearch
        ' 
        txtPaymentSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtPaymentSearch.Location = New Point(0, 8)
        txtPaymentSearch.Name = "txtPaymentSearch"
        txtPaymentSearch.Size = New Size(350, 25)
        txtPaymentSearch.TabIndex = 0
        txtPaymentSearch.Text = "Search by Rental ID, Receipt No, or Status..."
        ' 
        ' pnlPaymentInput
        ' 
        pnlPaymentInput.BackColor = Color.White
        pnlPaymentInput.Controls.Add(pnlPaymentButtons)
        pnlPaymentInput.Controls.Add(txtPaymentClerkName)
        pnlPaymentInput.Controls.Add(Label8)
        pnlPaymentInput.Controls.Add(txtPaymentEmployeeID)
        pnlPaymentInput.Controls.Add(Label9)
        pnlPaymentInput.Controls.Add(lblGroupPaymentProcessedBy)
        pnlPaymentInput.Controls.Add(cbPaymentStatus)
        pnlPaymentInput.Controls.Add(Label7)
        pnlPaymentInput.Controls.Add(cbPaymentMethod)
        pnlPaymentInput.Controls.Add(Label6)
        pnlPaymentInput.Controls.Add(txtReceiptNo)
        pnlPaymentInput.Controls.Add(Label5)
        pnlPaymentInput.Controls.Add(txtAmountPaid)
        pnlPaymentInput.Controls.Add(Label4)
        pnlPaymentInput.Controls.Add(dtpPaymentDate)
        pnlPaymentInput.Controls.Add(Label3)
        pnlPaymentInput.Controls.Add(txtPaymentNo)
        pnlPaymentInput.Controls.Add(Label2)
        pnlPaymentInput.Controls.Add(txtPaymentRentalID)
        pnlPaymentInput.Controls.Add(Label1)
        pnlPaymentInput.Controls.Add(lblGroupPaymentInfo)
        pnlPaymentInput.Dock = DockStyle.Left
        pnlPaymentInput.Location = New Point(0, 0)
        pnlPaymentInput.Name = "pnlPaymentInput"
        pnlPaymentInput.Padding = New Padding(12)
        pnlPaymentInput.Size = New Size(300, 769)
        pnlPaymentInput.TabIndex = 0
        ' 
        ' pnlPaymentButtons
        ' 
        pnlPaymentButtons.Controls.Add(btnClosePayment)
        pnlPaymentButtons.Controls.Add(btnClearPayment)
        pnlPaymentButtons.Controls.Add(btnDeletePayment)
        pnlPaymentButtons.Controls.Add(btnUpdatePayment)
        pnlPaymentButtons.Controls.Add(btnAddPayment)
        pnlPaymentButtons.Dock = DockStyle.Bottom
        pnlPaymentButtons.Location = New Point(12, 657)
        pnlPaymentButtons.Name = "pnlPaymentButtons"
        pnlPaymentButtons.Size = New Size(276, 100)
        pnlPaymentButtons.TabIndex = 28
        ' 
        ' btnClosePayment
        ' 
        btnClosePayment.BackColor = Color.DarkRed
        btnClosePayment.Cursor = Cursors.Hand
        btnClosePayment.FlatStyle = FlatStyle.Flat
        btnClosePayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClosePayment.ForeColor = Color.White
        btnClosePayment.Location = New Point(133, 52)
        btnClosePayment.Name = "btnClosePayment"
        btnClosePayment.Size = New Size(80, 38)
        btnClosePayment.TabIndex = 5
        btnClosePayment.Text = "🚪 Close"
        btnClosePayment.UseVisualStyleBackColor = False
        ' 
        ' btnClearPayment
        ' 
        btnClearPayment.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearPayment.Cursor = Cursors.Hand
        btnClearPayment.FlatStyle = FlatStyle.Flat
        btnClearPayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearPayment.ForeColor = Color.White
        btnClearPayment.Location = New Point(45, 52)
        btnClearPayment.Name = "btnClearPayment"
        btnClearPayment.Size = New Size(80, 38)
        btnClearPayment.TabIndex = 4
        btnClearPayment.Text = "✖️ Clear"
        btnClearPayment.UseVisualStyleBackColor = False
        ' 
        ' btnDeletePayment
        ' 
        btnDeletePayment.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeletePayment.Cursor = Cursors.Hand
        btnDeletePayment.FlatStyle = FlatStyle.Flat
        btnDeletePayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeletePayment.ForeColor = Color.White
        btnDeletePayment.Location = New Point(175, 8)
        btnDeletePayment.Name = "btnDeletePayment"
        btnDeletePayment.Size = New Size(80, 38)
        btnDeletePayment.TabIndex = 2
        btnDeletePayment.Text = "🗑️ Delete"
        btnDeletePayment.UseVisualStyleBackColor = False
        ' 
        ' btnUpdatePayment
        ' 
        btnUpdatePayment.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdatePayment.Cursor = Cursors.Hand
        btnUpdatePayment.FlatStyle = FlatStyle.Flat
        btnUpdatePayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdatePayment.ForeColor = Color.White
        btnUpdatePayment.Location = New Point(90, 8)
        btnUpdatePayment.Name = "btnUpdatePayment"
        btnUpdatePayment.Size = New Size(80, 38)
        btnUpdatePayment.TabIndex = 1
        btnUpdatePayment.Text = "✏️ Update"
        btnUpdatePayment.UseVisualStyleBackColor = False
        ' 
        ' btnAddPayment
        ' 
        btnAddPayment.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddPayment.Cursor = Cursors.Hand
        btnAddPayment.FlatStyle = FlatStyle.Flat
        btnAddPayment.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddPayment.ForeColor = Color.White
        btnAddPayment.Location = New Point(5, 8)
        btnAddPayment.Name = "btnAddPayment"
        btnAddPayment.Size = New Size(80, 38)
        btnAddPayment.TabIndex = 0
        btnAddPayment.Text = "➕ Add"
        btnAddPayment.UseVisualStyleBackColor = False
        ' 
        ' txtPaymentClerkName
        ' 
        txtPaymentClerkName.BackColor = SystemColors.ButtonFace
        txtPaymentClerkName.Location = New Point(12, 546)
        txtPaymentClerkName.Name = "txtPaymentClerkName"
        txtPaymentClerkName.ReadOnly = True
        txtPaymentClerkName.Size = New Size(265, 25)
        txtPaymentClerkName.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 528)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 17)
        Label8.TabIndex = 21
        Label8.Text = "Clerk Name:"
        ' 
        ' txtPaymentEmployeeID
        ' 
        txtPaymentEmployeeID.Location = New Point(12, 488)
        txtPaymentEmployeeID.Name = "txtPaymentEmployeeID"
        txtPaymentEmployeeID.Size = New Size(265, 25)
        txtPaymentEmployeeID.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 470)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 17)
        Label9.TabIndex = 19
        Label9.Text = "Employee ID:"
        ' 
        ' lblGroupPaymentProcessedBy
        ' 
        lblGroupPaymentProcessedBy.AutoSize = True
        lblGroupPaymentProcessedBy.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupPaymentProcessedBy.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupPaymentProcessedBy.Location = New Point(12, 450)
        lblGroupPaymentProcessedBy.Name = "lblGroupPaymentProcessedBy"
        lblGroupPaymentProcessedBy.Size = New Size(85, 13)
        lblGroupPaymentProcessedBy.TabIndex = 18
        lblGroupPaymentProcessedBy.Text = "PROCESSED BY"
        ' 
        ' cbPaymentStatus
        ' 
        cbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbPaymentStatus.FormattingEnabled = True
        cbPaymentStatus.Items.AddRange(New Object() {"Partial", "Full"})
        cbPaymentStatus.Location = New Point(12, 406)
        cbPaymentStatus.Name = "cbPaymentStatus"
        cbPaymentStatus.Size = New Size(265, 25)
        cbPaymentStatus.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 388)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 15
        Label7.Text = "Payment Status:"
        ' 
        ' cbPaymentMethod
        ' 
        cbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList
        cbPaymentMethod.FormattingEnabled = True
        cbPaymentMethod.Items.AddRange(New Object() {"Cash", "Card", "GCash"})
        cbPaymentMethod.Location = New Point(12, 348)
        cbPaymentMethod.Name = "cbPaymentMethod"
        cbPaymentMethod.Size = New Size(265, 25)
        cbPaymentMethod.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 17)
        Label6.TabIndex = 13
        Label6.Text = "Payment Method:"
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.Location = New Point(12, 290)
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.Size = New Size(265, 25)
        txtReceiptNo.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 17)
        Label5.TabIndex = 11
        Label5.Text = "Receipt No:"
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Location = New Point(12, 232)
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.Size = New Size(265, 25)
        txtAmountPaid.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 17)
        Label4.TabIndex = 9
        Label4.Text = "Amount Paid:"
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Format = DateTimePickerFormat.Short
        dtpPaymentDate.Location = New Point(12, 174)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(265, 25)
        dtpPaymentDate.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 7
        Label3.Text = "Payment Date:"
        ' 
        ' txtPaymentNo
        ' 
        txtPaymentNo.Location = New Point(12, 116)
        txtPaymentNo.Name = "txtPaymentNo"
        txtPaymentNo.Size = New Size(265, 25)
        txtPaymentNo.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 17)
        Label2.TabIndex = 5
        Label2.Text = "Payment No:"
        ' 
        ' txtPaymentRentalID
        ' 
        txtPaymentRentalID.Location = New Point(12, 58)
        txtPaymentRentalID.Name = "txtPaymentRentalID"
        txtPaymentRentalID.Size = New Size(265, 25)
        txtPaymentRentalID.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 17)
        Label1.TabIndex = 3
        Label1.Text = "Rental ID:"
        ' 
        ' lblGroupPaymentInfo
        ' 
        lblGroupPaymentInfo.AutoSize = True
        lblGroupPaymentInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupPaymentInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupPaymentInfo.Location = New Point(12, 15)
        lblGroupPaymentInfo.Name = "lblGroupPaymentInfo"
        lblGroupPaymentInfo.Size = New Size(88, 13)
        lblGroupPaymentInfo.TabIndex = 1
        lblGroupPaymentInfo.Text = "PAYMENT INFO"
        ' 
        ' frmPaymentDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1113, 829)
        Controls.Add(pnlPaymentBody)
        Controls.Add(pnlPaymentHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmPaymentDesign"
        Text = "Payment Transaction"
        WindowState = FormWindowState.Maximized
        pnlPaymentHeader.ResumeLayout(False)
        pnlPaymentHeader.PerformLayout()
        pnlPaymentBody.ResumeLayout(False)
        pnlPaymentGrid.ResumeLayout(False)
        CType(dgvPayment, ComponentModel.ISupportInitialize).EndInit()
        pnlPaymentInfo.ResumeLayout(False)
        pnlCustomerInfoPayment.ResumeLayout(False)
        pnlCustomerInfoPayment.PerformLayout()
        pnlRentalInfoPayment.ResumeLayout(False)
        pnlRentalInfoPayment.PerformLayout()
        pnlPaymentSearch.ResumeLayout(False)
        pnlPaymentSearch.PerformLayout()
        pnlPaymentInput.ResumeLayout(False)
        pnlPaymentInput.PerformLayout()
        pnlPaymentButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblPaymentTitle As Label
    Friend WithEvents pnlPaymentHeader As Panel
    Friend WithEvents pnlPaymentBody As Panel
    Friend WithEvents pnlPaymentInput As Panel
    Friend WithEvents lblGroupPaymentInfo As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPaymentNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPaymentRentalID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPaymentMethod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbPaymentStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPaymentClerkName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPaymentEmployeeID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGroupPaymentProcessedBy As Label
    Friend WithEvents pnlPaymentButtons As Panel
    Friend WithEvents btnClosePayment As Button
    Friend WithEvents btnClearPayment As Button
    Friend WithEvents btnDeletePayment As Button
    Friend WithEvents btnUpdatePayment As Button
    Friend WithEvents btnAddPayment As Button
    Friend WithEvents pnlPaymentSearch As Panel
    Friend WithEvents btnRefreshPayment As Button
    Friend WithEvents txtPaymentSearch As TextBox
    Friend WithEvents pnlPaymentInfo As Panel
    Friend WithEvents pnlCustomerInfoPayment As Panel
    Friend WithEvents txtCustomerInfoPayment As TextBox
    Friend WithEvents lblCustomerInfoPaymentTitle As Label
    Friend WithEvents pnlRentalInfoPayment As Panel
    Friend WithEvents txtRentalInfoPayment As TextBox
    Friend WithEvents lblRentalInfoPaymentTitle As Label
    Friend WithEvents pnlPaymentGrid As Panel
    Friend WithEvents dgvPayment As DataGridView
End Class
