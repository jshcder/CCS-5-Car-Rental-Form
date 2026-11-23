<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnDesign
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
        pnlReturnHeader = New Panel()
        lblReturnTitle = New Label()
        pnlReturnBody = New Panel()
        pnlReturnRight = New Panel()
        pnlReturnGrid = New Panel()
        dgvReturn = New DataGridView()
        pnlReturnInfo = New Panel()
        pnlVehicleInfoReturn = New Panel()
        txtVehicleInfoReturn = New TextBox()
        lblVehicleInfoReturnTitle = New Label()
        pnlRentalInfoReturn = New Panel()
        txtRentalInfoReturn = New TextBox()
        lblRentalInfoReturnTitle = New Label()
        pnlReturnSearch = New Panel()
        btnRefreshReturn = New Button()
        txtReturnSearch = New TextBox()
        pnlReturnInput = New Panel()
        pnlReturnButtons = New Panel()
        btnCloseReturn = New Button()
        btnClearReturn = New Button()
        btnDeleteReturn = New Button()
        btnUpdateReturn = New Button()
        btnAddReturn = New Button()
        txtReturnClerkName = New TextBox()
        Label8 = New Label()
        txtReturnEmployeeID = New TextBox()
        Label7 = New Label()
        lblGroupReturnProcessedBy = New Label()
        txtReturnNotes = New TextBox()
        Label6 = New Label()
        cbVehicleCondition = New ComboBox()
        Label5 = New Label()
        txtMileageUponReturn = New TextBox()
        Label4 = New Label()
        dtpActualReturnDate = New DateTimePicker()
        Label3 = New Label()
        txtReturnNo = New TextBox()
        Label2 = New Label()
        txtReturnRentalID = New TextBox()
        Label1 = New Label()
        lblGroupReturnInfo = New Label()
        pnlReturnHeader.SuspendLayout()
        pnlReturnBody.SuspendLayout()
        pnlReturnRight.SuspendLayout()
        pnlReturnGrid.SuspendLayout()
        CType(dgvReturn, ComponentModel.ISupportInitialize).BeginInit()
        pnlReturnInfo.SuspendLayout()
        pnlVehicleInfoReturn.SuspendLayout()
        pnlRentalInfoReturn.SuspendLayout()
        pnlReturnSearch.SuspendLayout()
        pnlReturnInput.SuspendLayout()
        pnlReturnButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlReturnHeader
        ' 
        pnlReturnHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlReturnHeader.Controls.Add(lblReturnTitle)
        pnlReturnHeader.Dock = DockStyle.Top
        pnlReturnHeader.Location = New Point(0, 0)
        pnlReturnHeader.Name = "pnlReturnHeader"
        pnlReturnHeader.Size = New Size(1247, 60)
        pnlReturnHeader.TabIndex = 0
        ' 
        ' lblReturnTitle
        ' 
        lblReturnTitle.AutoSize = True
        lblReturnTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnTitle.ForeColor = Color.White
        lblReturnTitle.Location = New Point(3, 18)
        lblReturnTitle.Name = "lblReturnTitle"
        lblReturnTitle.Padding = New Padding(15, 0, 0, 0)
        lblReturnTitle.Size = New Size(196, 25)
        lblReturnTitle.TabIndex = 0
        lblReturnTitle.Text = "Return Transaction"
        lblReturnTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlReturnBody
        ' 
        pnlReturnBody.Controls.Add(pnlReturnRight)
        pnlReturnBody.Controls.Add(pnlReturnInput)
        pnlReturnBody.Dock = DockStyle.Fill
        pnlReturnBody.Location = New Point(0, 60)
        pnlReturnBody.Name = "pnlReturnBody"
        pnlReturnBody.Size = New Size(1247, 880)
        pnlReturnBody.TabIndex = 1
        ' 
        ' pnlReturnRight
        ' 
        pnlReturnRight.Controls.Add(pnlReturnGrid)
        pnlReturnRight.Controls.Add(pnlReturnInfo)
        pnlReturnRight.Controls.Add(pnlReturnSearch)
        pnlReturnRight.Dock = DockStyle.Fill
        pnlReturnRight.Location = New Point(300, 0)
        pnlReturnRight.Name = "pnlReturnRight"
        pnlReturnRight.Padding = New Padding(12)
        pnlReturnRight.Size = New Size(947, 880)
        pnlReturnRight.TabIndex = 1
        ' 
        ' pnlReturnGrid
        ' 
        pnlReturnGrid.Controls.Add(dgvReturn)
        pnlReturnGrid.Dock = DockStyle.Fill
        pnlReturnGrid.Location = New Point(12, 60)
        pnlReturnGrid.Name = "pnlReturnGrid"
        pnlReturnGrid.Size = New Size(923, 688)
        pnlReturnGrid.TabIndex = 2
        ' 
        ' dgvReturn
        ' 
        dgvReturn.AllowUserToAddRows = False
        dgvReturn.AllowUserToDeleteRows = False
        dgvReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReturn.BackgroundColor = Color.White
        dgvReturn.BorderStyle = BorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvReturn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Window
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvReturn.DefaultCellStyle = DataGridViewCellStyle4
        dgvReturn.Dock = DockStyle.Fill
        dgvReturn.Location = New Point(0, 0)
        dgvReturn.Name = "dgvReturn"
        dgvReturn.ReadOnly = True
        dgvReturn.RowHeadersVisible = False
        dgvReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReturn.Size = New Size(923, 688)
        dgvReturn.TabIndex = 0
        ' 
        ' pnlReturnInfo
        ' 
        pnlReturnInfo.Controls.Add(pnlVehicleInfoReturn)
        pnlReturnInfo.Controls.Add(pnlRentalInfoReturn)
        pnlReturnInfo.Dock = DockStyle.Bottom
        pnlReturnInfo.Location = New Point(12, 748)
        pnlReturnInfo.Name = "pnlReturnInfo"
        pnlReturnInfo.Padding = New Padding(0, 8, 0, 0)
        pnlReturnInfo.Size = New Size(923, 120)
        pnlReturnInfo.TabIndex = 1
        ' 
        ' pnlVehicleInfoReturn
        ' 
        pnlVehicleInfoReturn.BackColor = Color.White
        pnlVehicleInfoReturn.Controls.Add(txtVehicleInfoReturn)
        pnlVehicleInfoReturn.Controls.Add(lblVehicleInfoReturnTitle)
        pnlVehicleInfoReturn.Dock = DockStyle.Fill
        pnlVehicleInfoReturn.Location = New Point(400, 8)
        pnlVehicleInfoReturn.Name = "pnlVehicleInfoReturn"
        pnlVehicleInfoReturn.Padding = New Padding(8)
        pnlVehicleInfoReturn.Size = New Size(523, 112)
        pnlVehicleInfoReturn.TabIndex = 1
        ' 
        ' txtVehicleInfoReturn
        ' 
        txtVehicleInfoReturn.BackColor = Color.White
        txtVehicleInfoReturn.BorderStyle = BorderStyle.None
        txtVehicleInfoReturn.Dock = DockStyle.Fill
        txtVehicleInfoReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtVehicleInfoReturn.Location = New Point(8, 28)
        txtVehicleInfoReturn.Multiline = True
        txtVehicleInfoReturn.Name = "txtVehicleInfoReturn"
        txtVehicleInfoReturn.ReadOnly = True
        txtVehicleInfoReturn.ScrollBars = ScrollBars.Vertical
        txtVehicleInfoReturn.Size = New Size(507, 76)
        txtVehicleInfoReturn.TabIndex = 3
        ' 
        ' lblVehicleInfoReturnTitle
        ' 
        lblVehicleInfoReturnTitle.Dock = DockStyle.Top
        lblVehicleInfoReturnTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVehicleInfoReturnTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblVehicleInfoReturnTitle.Location = New Point(8, 8)
        lblVehicleInfoReturnTitle.Name = "lblVehicleInfoReturnTitle"
        lblVehicleInfoReturnTitle.Size = New Size(507, 20)
        lblVehicleInfoReturnTitle.TabIndex = 2
        lblVehicleInfoReturnTitle.Text = "VEHICLE INFO"
        ' 
        ' pnlRentalInfoReturn
        ' 
        pnlRentalInfoReturn.BackColor = Color.White
        pnlRentalInfoReturn.Controls.Add(txtRentalInfoReturn)
        pnlRentalInfoReturn.Controls.Add(lblRentalInfoReturnTitle)
        pnlRentalInfoReturn.Dock = DockStyle.Left
        pnlRentalInfoReturn.Location = New Point(0, 8)
        pnlRentalInfoReturn.Name = "pnlRentalInfoReturn"
        pnlRentalInfoReturn.Padding = New Padding(8)
        pnlRentalInfoReturn.Size = New Size(400, 112)
        pnlRentalInfoReturn.TabIndex = 0
        ' 
        ' txtRentalInfoReturn
        ' 
        txtRentalInfoReturn.BackColor = Color.White
        txtRentalInfoReturn.BorderStyle = BorderStyle.None
        txtRentalInfoReturn.Dock = DockStyle.Fill
        txtRentalInfoReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtRentalInfoReturn.Location = New Point(8, 28)
        txtRentalInfoReturn.Multiline = True
        txtRentalInfoReturn.Name = "txtRentalInfoReturn"
        txtRentalInfoReturn.ReadOnly = True
        txtRentalInfoReturn.ScrollBars = ScrollBars.Vertical
        txtRentalInfoReturn.Size = New Size(384, 76)
        txtRentalInfoReturn.TabIndex = 1
        ' 
        ' lblRentalInfoReturnTitle
        ' 
        lblRentalInfoReturnTitle.Dock = DockStyle.Top
        lblRentalInfoReturnTitle.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalInfoReturnTitle.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblRentalInfoReturnTitle.Location = New Point(8, 8)
        lblRentalInfoReturnTitle.Name = "lblRentalInfoReturnTitle"
        lblRentalInfoReturnTitle.Size = New Size(384, 20)
        lblRentalInfoReturnTitle.TabIndex = 0
        lblRentalInfoReturnTitle.Text = "RENTAL INFO"
        ' 
        ' pnlReturnSearch
        ' 
        pnlReturnSearch.Controls.Add(btnRefreshReturn)
        pnlReturnSearch.Controls.Add(txtReturnSearch)
        pnlReturnSearch.Dock = DockStyle.Top
        pnlReturnSearch.Location = New Point(12, 12)
        pnlReturnSearch.Name = "pnlReturnSearch"
        pnlReturnSearch.Size = New Size(923, 48)
        pnlReturnSearch.TabIndex = 0
        ' 
        ' btnRefreshReturn
        ' 
        btnRefreshReturn.Cursor = Cursors.Hand
        btnRefreshReturn.FlatStyle = FlatStyle.Flat
        btnRefreshReturn.Location = New Point(360, 5)
        btnRefreshReturn.Name = "btnRefreshReturn"
        btnRefreshReturn.Size = New Size(100, 35)
        btnRefreshReturn.TabIndex = 1
        btnRefreshReturn.Text = "🔄 Refresh"
        btnRefreshReturn.UseVisualStyleBackColor = True
        ' 
        ' txtReturnSearch
        ' 
        txtReturnSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtReturnSearch.Location = New Point(0, 8)
        txtReturnSearch.Name = "txtReturnSearch"
        txtReturnSearch.Size = New Size(350, 25)
        txtReturnSearch.TabIndex = 0
        txtReturnSearch.Text = "Search by Rental ID, Condition, or Clerk..."
        ' 
        ' pnlReturnInput
        ' 
        pnlReturnInput.BackColor = Color.White
        pnlReturnInput.Controls.Add(pnlReturnButtons)
        pnlReturnInput.Controls.Add(txtReturnClerkName)
        pnlReturnInput.Controls.Add(Label8)
        pnlReturnInput.Controls.Add(txtReturnEmployeeID)
        pnlReturnInput.Controls.Add(Label7)
        pnlReturnInput.Controls.Add(lblGroupReturnProcessedBy)
        pnlReturnInput.Controls.Add(txtReturnNotes)
        pnlReturnInput.Controls.Add(Label6)
        pnlReturnInput.Controls.Add(cbVehicleCondition)
        pnlReturnInput.Controls.Add(Label5)
        pnlReturnInput.Controls.Add(txtMileageUponReturn)
        pnlReturnInput.Controls.Add(Label4)
        pnlReturnInput.Controls.Add(dtpActualReturnDate)
        pnlReturnInput.Controls.Add(Label3)
        pnlReturnInput.Controls.Add(txtReturnNo)
        pnlReturnInput.Controls.Add(Label2)
        pnlReturnInput.Controls.Add(txtReturnRentalID)
        pnlReturnInput.Controls.Add(Label1)
        pnlReturnInput.Controls.Add(lblGroupReturnInfo)
        pnlReturnInput.Dock = DockStyle.Left
        pnlReturnInput.Location = New Point(0, 0)
        pnlReturnInput.Name = "pnlReturnInput"
        pnlReturnInput.Padding = New Padding(12)
        pnlReturnInput.Size = New Size(300, 880)
        pnlReturnInput.TabIndex = 0
        ' 
        ' pnlReturnButtons
        ' 
        pnlReturnButtons.Controls.Add(btnCloseReturn)
        pnlReturnButtons.Controls.Add(btnClearReturn)
        pnlReturnButtons.Controls.Add(btnDeleteReturn)
        pnlReturnButtons.Controls.Add(btnUpdateReturn)
        pnlReturnButtons.Controls.Add(btnAddReturn)
        pnlReturnButtons.Dock = DockStyle.Bottom
        pnlReturnButtons.Location = New Point(12, 768)
        pnlReturnButtons.Name = "pnlReturnButtons"
        pnlReturnButtons.Size = New Size(276, 100)
        pnlReturnButtons.TabIndex = 27
        ' 
        ' btnCloseReturn
        ' 
        btnCloseReturn.BackColor = Color.DarkRed
        btnCloseReturn.Cursor = Cursors.Hand
        btnCloseReturn.FlatStyle = FlatStyle.Flat
        btnCloseReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseReturn.ForeColor = Color.White
        btnCloseReturn.Location = New Point(133, 52)
        btnCloseReturn.Name = "btnCloseReturn"
        btnCloseReturn.Size = New Size(80, 38)
        btnCloseReturn.TabIndex = 5
        btnCloseReturn.Text = "🚪 Close"
        btnCloseReturn.UseVisualStyleBackColor = False
        ' 
        ' btnClearReturn
        ' 
        btnClearReturn.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearReturn.Cursor = Cursors.Hand
        btnClearReturn.FlatStyle = FlatStyle.Flat
        btnClearReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearReturn.ForeColor = Color.White
        btnClearReturn.Location = New Point(45, 52)
        btnClearReturn.Name = "btnClearReturn"
        btnClearReturn.Size = New Size(80, 38)
        btnClearReturn.TabIndex = 4
        btnClearReturn.Text = "✖️ Clear"
        btnClearReturn.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteReturn
        ' 
        btnDeleteReturn.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteReturn.Cursor = Cursors.Hand
        btnDeleteReturn.FlatStyle = FlatStyle.Flat
        btnDeleteReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteReturn.ForeColor = Color.White
        btnDeleteReturn.Location = New Point(175, 8)
        btnDeleteReturn.Name = "btnDeleteReturn"
        btnDeleteReturn.Size = New Size(80, 38)
        btnDeleteReturn.TabIndex = 2
        btnDeleteReturn.Text = "🗑️ Delete"
        btnDeleteReturn.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateReturn
        ' 
        btnUpdateReturn.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateReturn.Cursor = Cursors.Hand
        btnUpdateReturn.FlatStyle = FlatStyle.Flat
        btnUpdateReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateReturn.ForeColor = Color.White
        btnUpdateReturn.Location = New Point(90, 8)
        btnUpdateReturn.Name = "btnUpdateReturn"
        btnUpdateReturn.Size = New Size(80, 38)
        btnUpdateReturn.TabIndex = 1
        btnUpdateReturn.Text = "✏️ Update"
        btnUpdateReturn.UseVisualStyleBackColor = False
        ' 
        ' btnAddReturn
        ' 
        btnAddReturn.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddReturn.Cursor = Cursors.Hand
        btnAddReturn.FlatStyle = FlatStyle.Flat
        btnAddReturn.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddReturn.ForeColor = Color.White
        btnAddReturn.Location = New Point(5, 8)
        btnAddReturn.Name = "btnAddReturn"
        btnAddReturn.Size = New Size(80, 38)
        btnAddReturn.TabIndex = 0
        btnAddReturn.Text = "➕ Add"
        btnAddReturn.UseVisualStyleBackColor = False
        ' 
        ' txtReturnClerkName
        ' 
        txtReturnClerkName.BackColor = SystemColors.ButtonFace
        txtReturnClerkName.Location = New Point(12, 521)
        txtReturnClerkName.Name = "txtReturnClerkName"
        txtReturnClerkName.ReadOnly = True
        txtReturnClerkName.Size = New Size(265, 25)
        txtReturnClerkName.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 503)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 17)
        Label8.TabIndex = 16
        Label8.Text = "Clerk Name:"
        ' 
        ' txtReturnEmployeeID
        ' 
        txtReturnEmployeeID.Location = New Point(12, 463)
        txtReturnEmployeeID.Name = "txtReturnEmployeeID"
        txtReturnEmployeeID.Size = New Size(265, 25)
        txtReturnEmployeeID.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 445)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 17)
        Label7.TabIndex = 14
        Label7.Text = "Employee ID:"
        ' 
        ' lblGroupReturnProcessedBy
        ' 
        lblGroupReturnProcessedBy.AutoSize = True
        lblGroupReturnProcessedBy.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupReturnProcessedBy.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupReturnProcessedBy.Location = New Point(12, 425)
        lblGroupReturnProcessedBy.Name = "lblGroupReturnProcessedBy"
        lblGroupReturnProcessedBy.Size = New Size(85, 13)
        lblGroupReturnProcessedBy.TabIndex = 13
        lblGroupReturnProcessedBy.Text = "PROCESSED BY"
        ' 
        ' txtReturnNotes
        ' 
        txtReturnNotes.Location = New Point(12, 348)
        txtReturnNotes.Multiline = True
        txtReturnNotes.Name = "txtReturnNotes"
        txtReturnNotes.ScrollBars = ScrollBars.Vertical
        txtReturnNotes.Size = New Size(265, 60)
        txtReturnNotes.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 17)
        Label6.TabIndex = 11
        Label6.Text = "Notes:"
        ' 
        ' cbVehicleCondition
        ' 
        cbVehicleCondition.DropDownStyle = ComboBoxStyle.DropDownList
        cbVehicleCondition.FormattingEnabled = True
        cbVehicleCondition.Items.AddRange(New Object() {"Good", "Damaged"})
        cbVehicleCondition.Location = New Point(12, 290)
        cbVehicleCondition.Name = "cbVehicleCondition"
        cbVehicleCondition.Size = New Size(265, 25)
        cbVehicleCondition.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 17)
        Label5.TabIndex = 9
        Label5.Text = "Vehicle Condition:"
        ' 
        ' txtMileageUponReturn
        ' 
        txtMileageUponReturn.Location = New Point(12, 232)
        txtMileageUponReturn.Name = "txtMileageUponReturn"
        txtMileageUponReturn.Size = New Size(265, 25)
        txtMileageUponReturn.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 17)
        Label4.TabIndex = 7
        Label4.Text = "Mileage Upon Return:"
        ' 
        ' dtpActualReturnDate
        ' 
        dtpActualReturnDate.Format = DateTimePickerFormat.Short
        dtpActualReturnDate.Location = New Point(12, 174)
        dtpActualReturnDate.Name = "dtpActualReturnDate"
        dtpActualReturnDate.Size = New Size(265, 25)
        dtpActualReturnDate.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 17)
        Label3.TabIndex = 5
        Label3.Text = "Actual Return Date:"
        ' 
        ' txtReturnNo
        ' 
        txtReturnNo.Location = New Point(12, 116)
        txtReturnNo.Name = "txtReturnNo"
        txtReturnNo.Size = New Size(265, 25)
        txtReturnNo.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 17)
        Label2.TabIndex = 3
        Label2.Text = "Return No:"
        ' 
        ' txtReturnRentalID
        ' 
        txtReturnRentalID.Location = New Point(12, 58)
        txtReturnRentalID.Name = "txtReturnRentalID"
        txtReturnRentalID.Size = New Size(265, 25)
        txtReturnRentalID.TabIndex = 2
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
        ' lblGroupReturnInfo
        ' 
        lblGroupReturnInfo.AutoSize = True
        lblGroupReturnInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupReturnInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupReturnInfo.Location = New Point(12, 15)
        lblGroupReturnInfo.Name = "lblGroupReturnInfo"
        lblGroupReturnInfo.Size = New Size(79, 13)
        lblGroupReturnInfo.TabIndex = 0
        lblGroupReturnInfo.Text = "RETURN INFO"
        ' 
        ' frmReturnDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1247, 940)
        Controls.Add(pnlReturnBody)
        Controls.Add(pnlReturnHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmReturnDesign"
        Text = "Return Transaction"
        WindowState = FormWindowState.Maximized
        pnlReturnHeader.ResumeLayout(False)
        pnlReturnHeader.PerformLayout()
        pnlReturnBody.ResumeLayout(False)
        pnlReturnRight.ResumeLayout(False)
        pnlReturnGrid.ResumeLayout(False)
        CType(dgvReturn, ComponentModel.ISupportInitialize).EndInit()
        pnlReturnInfo.ResumeLayout(False)
        pnlVehicleInfoReturn.ResumeLayout(False)
        pnlVehicleInfoReturn.PerformLayout()
        pnlRentalInfoReturn.ResumeLayout(False)
        pnlRentalInfoReturn.PerformLayout()
        pnlReturnSearch.ResumeLayout(False)
        pnlReturnSearch.PerformLayout()
        pnlReturnInput.ResumeLayout(False)
        pnlReturnInput.PerformLayout()
        pnlReturnButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlReturnHeader As Panel
    Friend WithEvents lblReturnTitle As Label
    Friend WithEvents pnlReturnBody As Panel
    Friend WithEvents pnlReturnInput As Panel
    Friend WithEvents cbVehicleCondition As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMileageUponReturn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpActualReturnDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReturnNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReturnRentalID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGroupReturnInfo As Label
    Friend WithEvents txtReturnNotes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReturnEmployeeID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGroupReturnProcessedBy As Label
    Friend WithEvents txtReturnClerkName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pnlReturnButtons As Panel
    Friend WithEvents btnCloseReturn As Button
    Friend WithEvents btnClearReturn As Button
    Friend WithEvents btnDeleteReturn As Button
    Friend WithEvents btnUpdateReturn As Button
    Friend WithEvents btnAddReturn As Button
    Friend WithEvents pnlReturnRight As Panel
    Friend WithEvents pnlReturnInfo As Panel
    Friend WithEvents pnlRentalInfoReturn As Panel
    Friend WithEvents lblRentalInfoReturnTitle As Label
    Friend WithEvents pnlReturnSearch As Panel
    Friend WithEvents btnRefreshReturn As Button
    Friend WithEvents txtReturnSearch As TextBox
    Friend WithEvents txtRentalInfoReturn As TextBox
    Friend WithEvents pnlReturnGrid As Panel
    Friend WithEvents dgvReturn As DataGridView
    Friend WithEvents pnlVehicleInfoReturn As Panel
    Friend WithEvents txtVehicleInfoReturn As TextBox
    Friend WithEvents lblVehicleInfoReturnTitle As Label
End Class
