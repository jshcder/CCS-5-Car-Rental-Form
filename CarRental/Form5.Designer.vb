<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDesign
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
        lblCustomerTitle = New Label()
        pnlCustomerHeader = New Panel()
        pnlCustomerBody = New Panel()
        pnlCustomerRight = New Panel()
        pnlCustomerGrid = New Panel()
        dgvCustomer = New DataGridView()
        pnlCustomerSearch = New Panel()
        btnRefreshCustomer = New Button()
        txtCustomerSearch = New TextBox()
        pnlCustomerInput = New Panel()
        txtCDriverLicenseNo = New TextBox()
        Label11 = New Label()
        txtCEmail = New TextBox()
        Label10 = New Label()
        txtCContactNo = New TextBox()
        lblGroupContact = New Label()
        txtCZipCode = New TextBox()
        txtCState = New TextBox()
        txtCFirstName = New TextBox()
        pnlCustomerButtons = New Panel()
        btnCloseCustomer = New Button()
        btnClearCustomer = New Button()
        btnDeleteCustomer = New Button()
        btnUpdateCustomer = New Button()
        btnAddCustomer = New Button()
        Label8 = New Label()
        txtCCity = New TextBox()
        Label9 = New Label()
        lblGroupAddress = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtCStreet = New TextBox()
        Label5 = New Label()
        txtCMiddleName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtCLastName = New TextBox()
        Label2 = New Label()
        txtCustomerID = New TextBox()
        Label1 = New Label()
        lblGroupCustomerInfo = New Label()
        pnlCustomerHeader.SuspendLayout()
        pnlCustomerBody.SuspendLayout()
        pnlCustomerRight.SuspendLayout()
        pnlCustomerGrid.SuspendLayout()
        CType(dgvCustomer, ComponentModel.ISupportInitialize).BeginInit()
        pnlCustomerSearch.SuspendLayout()
        pnlCustomerInput.SuspendLayout()
        pnlCustomerButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCustomerTitle
        ' 
        lblCustomerTitle.AutoSize = True
        lblCustomerTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerTitle.ForeColor = Color.White
        lblCustomerTitle.Location = New Point(3, 18)
        lblCustomerTitle.Name = "lblCustomerTitle"
        lblCustomerTitle.Padding = New Padding(15, 0, 0, 0)
        lblCustomerTitle.Size = New Size(159, 25)
        lblCustomerTitle.TabIndex = 0
        lblCustomerTitle.Text = "Customer Data"
        lblCustomerTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlCustomerHeader
        ' 
        pnlCustomerHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlCustomerHeader.Controls.Add(lblCustomerTitle)
        pnlCustomerHeader.Dock = DockStyle.Top
        pnlCustomerHeader.Location = New Point(0, 0)
        pnlCustomerHeader.Name = "pnlCustomerHeader"
        pnlCustomerHeader.Size = New Size(999, 60)
        pnlCustomerHeader.TabIndex = 2
        ' 
        ' pnlCustomerBody
        ' 
        pnlCustomerBody.Controls.Add(pnlCustomerRight)
        pnlCustomerBody.Controls.Add(pnlCustomerInput)
        pnlCustomerBody.Dock = DockStyle.Fill
        pnlCustomerBody.Location = New Point(0, 60)
        pnlCustomerBody.Name = "pnlCustomerBody"
        pnlCustomerBody.Size = New Size(999, 991)
        pnlCustomerBody.TabIndex = 3
        ' 
        ' pnlCustomerRight
        ' 
        pnlCustomerRight.Controls.Add(pnlCustomerGrid)
        pnlCustomerRight.Controls.Add(pnlCustomerSearch)
        pnlCustomerRight.Dock = DockStyle.Fill
        pnlCustomerRight.Location = New Point(300, 0)
        pnlCustomerRight.Name = "pnlCustomerRight"
        pnlCustomerRight.Padding = New Padding(12)
        pnlCustomerRight.Size = New Size(699, 991)
        pnlCustomerRight.TabIndex = 2
        ' 
        ' pnlCustomerGrid
        ' 
        pnlCustomerGrid.BackColor = Color.WhiteSmoke
        pnlCustomerGrid.Controls.Add(dgvCustomer)
        pnlCustomerGrid.Dock = DockStyle.Fill
        pnlCustomerGrid.Location = New Point(12, 60)
        pnlCustomerGrid.Name = "pnlCustomerGrid"
        pnlCustomerGrid.Size = New Size(675, 919)
        pnlCustomerGrid.TabIndex = 3
        ' 
        ' dgvCustomer
        ' 
        dgvCustomer.AllowUserToAddRows = False
        dgvCustomer.AllowUserToDeleteRows = False
        dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomer.BackgroundColor = Color.White
        dgvCustomer.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCustomer.DefaultCellStyle = DataGridViewCellStyle2
        dgvCustomer.Dock = DockStyle.Fill
        dgvCustomer.Location = New Point(0, 0)
        dgvCustomer.Name = "dgvCustomer"
        dgvCustomer.ReadOnly = True
        dgvCustomer.RowHeadersVisible = False
        dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomer.Size = New Size(675, 919)
        dgvCustomer.TabIndex = 0
        ' 
        ' pnlCustomerSearch
        ' 
        pnlCustomerSearch.Controls.Add(btnRefreshCustomer)
        pnlCustomerSearch.Controls.Add(txtCustomerSearch)
        pnlCustomerSearch.Dock = DockStyle.Top
        pnlCustomerSearch.Location = New Point(12, 12)
        pnlCustomerSearch.Name = "pnlCustomerSearch"
        pnlCustomerSearch.Size = New Size(675, 48)
        pnlCustomerSearch.TabIndex = 2
        ' 
        ' btnRefreshCustomer
        ' 
        btnRefreshCustomer.Cursor = Cursors.Hand
        btnRefreshCustomer.FlatStyle = FlatStyle.Flat
        btnRefreshCustomer.Location = New Point(360, 5)
        btnRefreshCustomer.Name = "btnRefreshCustomer"
        btnRefreshCustomer.Size = New Size(100, 35)
        btnRefreshCustomer.TabIndex = 1
        btnRefreshCustomer.Text = "🔄 Refresh"
        btnRefreshCustomer.UseVisualStyleBackColor = True
        ' 
        ' txtCustomerSearch
        ' 
        txtCustomerSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtCustomerSearch.Location = New Point(0, 8)
        txtCustomerSearch.Name = "txtCustomerSearch"
        txtCustomerSearch.Size = New Size(350, 25)
        txtCustomerSearch.TabIndex = 0
        txtCustomerSearch.Text = "Search by Name, City, or License No..."
        ' 
        ' pnlCustomerInput
        ' 
        pnlCustomerInput.BackColor = Color.White
        pnlCustomerInput.Controls.Add(txtCDriverLicenseNo)
        pnlCustomerInput.Controls.Add(Label11)
        pnlCustomerInput.Controls.Add(txtCEmail)
        pnlCustomerInput.Controls.Add(Label10)
        pnlCustomerInput.Controls.Add(txtCContactNo)
        pnlCustomerInput.Controls.Add(lblGroupContact)
        pnlCustomerInput.Controls.Add(txtCZipCode)
        pnlCustomerInput.Controls.Add(txtCState)
        pnlCustomerInput.Controls.Add(txtCFirstName)
        pnlCustomerInput.Controls.Add(pnlCustomerButtons)
        pnlCustomerInput.Controls.Add(Label8)
        pnlCustomerInput.Controls.Add(txtCCity)
        pnlCustomerInput.Controls.Add(Label9)
        pnlCustomerInput.Controls.Add(lblGroupAddress)
        pnlCustomerInput.Controls.Add(Label7)
        pnlCustomerInput.Controls.Add(Label6)
        pnlCustomerInput.Controls.Add(txtCStreet)
        pnlCustomerInput.Controls.Add(Label5)
        pnlCustomerInput.Controls.Add(txtCMiddleName)
        pnlCustomerInput.Controls.Add(Label4)
        pnlCustomerInput.Controls.Add(Label3)
        pnlCustomerInput.Controls.Add(txtCLastName)
        pnlCustomerInput.Controls.Add(Label2)
        pnlCustomerInput.Controls.Add(txtCustomerID)
        pnlCustomerInput.Controls.Add(Label1)
        pnlCustomerInput.Controls.Add(lblGroupCustomerInfo)
        pnlCustomerInput.Dock = DockStyle.Left
        pnlCustomerInput.Location = New Point(0, 0)
        pnlCustomerInput.Name = "pnlCustomerInput"
        pnlCustomerInput.Padding = New Padding(12)
        pnlCustomerInput.Size = New Size(300, 991)
        pnlCustomerInput.TabIndex = 1
        ' 
        ' txtCDriverLicenseNo
        ' 
        txtCDriverLicenseNo.Location = New Point(12, 684)
        txtCDriverLicenseNo.Name = "txtCDriverLicenseNo"
        txtCDriverLicenseNo.Size = New Size(265, 25)
        txtCDriverLicenseNo.TabIndex = 37
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 666)
        Label11.Name = "Label11"
        Label11.Size = New Size(114, 17)
        Label11.TabIndex = 36
        Label11.Text = "Driver License No:"
        ' 
        ' txtCEmail
        ' 
        txtCEmail.Location = New Point(12, 626)
        txtCEmail.Name = "txtCEmail"
        txtCEmail.Size = New Size(265, 25)
        txtCEmail.TabIndex = 35
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 608)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 17)
        Label10.TabIndex = 34
        Label10.Text = "Email:"
        ' 
        ' txtCContactNo
        ' 
        txtCContactNo.Location = New Point(12, 568)
        txtCContactNo.Name = "txtCContactNo"
        txtCContactNo.Size = New Size(265, 25)
        txtCContactNo.TabIndex = 33
        ' 
        ' lblGroupContact
        ' 
        lblGroupContact.AutoSize = True
        lblGroupContact.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupContact.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupContact.Location = New Point(12, 530)
        lblGroupContact.Name = "lblGroupContact"
        lblGroupContact.Size = New Size(57, 13)
        lblGroupContact.TabIndex = 32
        lblGroupContact.Text = "CONTACT"
        ' 
        ' txtCZipCode
        ' 
        txtCZipCode.Location = New Point(12, 487)
        txtCZipCode.Name = "txtCZipCode"
        txtCZipCode.Size = New Size(265, 25)
        txtCZipCode.TabIndex = 31
        ' 
        ' txtCState
        ' 
        txtCState.Location = New Point(12, 429)
        txtCState.Name = "txtCState"
        txtCState.Size = New Size(265, 25)
        txtCState.TabIndex = 30
        ' 
        ' txtCFirstName
        ' 
        txtCFirstName.Location = New Point(12, 174)
        txtCFirstName.Name = "txtCFirstName"
        txtCFirstName.Size = New Size(265, 25)
        txtCFirstName.TabIndex = 29
        ' 
        ' pnlCustomerButtons
        ' 
        pnlCustomerButtons.Controls.Add(btnCloseCustomer)
        pnlCustomerButtons.Controls.Add(btnClearCustomer)
        pnlCustomerButtons.Controls.Add(btnDeleteCustomer)
        pnlCustomerButtons.Controls.Add(btnUpdateCustomer)
        pnlCustomerButtons.Controls.Add(btnAddCustomer)
        pnlCustomerButtons.Dock = DockStyle.Bottom
        pnlCustomerButtons.Location = New Point(12, 879)
        pnlCustomerButtons.Name = "pnlCustomerButtons"
        pnlCustomerButtons.Size = New Size(276, 100)
        pnlCustomerButtons.TabIndex = 28
        ' 
        ' btnCloseCustomer
        ' 
        btnCloseCustomer.BackColor = Color.DarkRed
        btnCloseCustomer.Cursor = Cursors.Hand
        btnCloseCustomer.FlatStyle = FlatStyle.Flat
        btnCloseCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseCustomer.ForeColor = Color.White
        btnCloseCustomer.Location = New Point(133, 52)
        btnCloseCustomer.Name = "btnCloseCustomer"
        btnCloseCustomer.Size = New Size(80, 38)
        btnCloseCustomer.TabIndex = 5
        btnCloseCustomer.Text = "🚪 Close"
        btnCloseCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnClearCustomer
        ' 
        btnClearCustomer.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearCustomer.Cursor = Cursors.Hand
        btnClearCustomer.FlatStyle = FlatStyle.Flat
        btnClearCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearCustomer.ForeColor = Color.White
        btnClearCustomer.Location = New Point(45, 52)
        btnClearCustomer.Name = "btnClearCustomer"
        btnClearCustomer.Size = New Size(80, 38)
        btnClearCustomer.TabIndex = 4
        btnClearCustomer.Text = "✖️ Clear"
        btnClearCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCustomer
        ' 
        btnDeleteCustomer.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteCustomer.Cursor = Cursors.Hand
        btnDeleteCustomer.FlatStyle = FlatStyle.Flat
        btnDeleteCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteCustomer.ForeColor = Color.White
        btnDeleteCustomer.Location = New Point(175, 8)
        btnDeleteCustomer.Name = "btnDeleteCustomer"
        btnDeleteCustomer.Size = New Size(80, 38)
        btnDeleteCustomer.TabIndex = 2
        btnDeleteCustomer.Text = "🗑️ Delete"
        btnDeleteCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCustomer
        ' 
        btnUpdateCustomer.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateCustomer.Cursor = Cursors.Hand
        btnUpdateCustomer.FlatStyle = FlatStyle.Flat
        btnUpdateCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateCustomer.ForeColor = Color.White
        btnUpdateCustomer.Location = New Point(90, 8)
        btnUpdateCustomer.Name = "btnUpdateCustomer"
        btnUpdateCustomer.Size = New Size(80, 38)
        btnUpdateCustomer.TabIndex = 1
        btnUpdateCustomer.Text = "✏️ Update"
        btnUpdateCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddCustomer.Cursor = Cursors.Hand
        btnAddCustomer.FlatStyle = FlatStyle.Flat
        btnAddCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCustomer.ForeColor = Color.White
        btnAddCustomer.Location = New Point(5, 8)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(80, 38)
        btnAddCustomer.TabIndex = 0
        btnAddCustomer.Text = "➕ Add"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 550)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 21
        Label8.Text = "Contact No:"
        ' 
        ' txtCCity
        ' 
        txtCCity.Location = New Point(12, 371)
        txtCCity.Name = "txtCCity"
        txtCCity.Size = New Size(265, 25)
        txtCCity.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 469)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 17)
        Label9.TabIndex = 19
        Label9.Text = "Zip Code:"
        ' 
        ' lblGroupAddress
        ' 
        lblGroupAddress.AutoSize = True
        lblGroupAddress.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupAddress.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupAddress.Location = New Point(12, 275)
        lblGroupAddress.Name = "lblGroupAddress"
        lblGroupAddress.Size = New Size(56, 13)
        lblGroupAddress.TabIndex = 18
        lblGroupAddress.Text = "ADDRESS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 411)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 17)
        Label7.TabIndex = 15
        Label7.Text = "State:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 353)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 17)
        Label6.TabIndex = 13
        Label6.Text = "City:"
        ' 
        ' txtCStreet
        ' 
        txtCStreet.Location = New Point(12, 313)
        txtCStreet.Name = "txtCStreet"
        txtCStreet.Size = New Size(265, 25)
        txtCStreet.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 17)
        Label5.TabIndex = 11
        Label5.Text = "Street:"
        ' 
        ' txtCMiddleName
        ' 
        txtCMiddleName.Location = New Point(12, 232)
        txtCMiddleName.Name = "txtCMiddleName"
        txtCMiddleName.Size = New Size(265, 25)
        txtCMiddleName.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 17)
        Label4.TabIndex = 9
        Label4.Text = "Middle Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 17)
        Label3.TabIndex = 7
        Label3.Text = "First Name:"
        ' 
        ' txtCLastName
        ' 
        txtCLastName.Location = New Point(12, 116)
        txtCLastName.Name = "txtCLastName"
        txtCLastName.Size = New Size(265, 25)
        txtCLastName.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 17)
        Label2.TabIndex = 5
        Label2.Text = "Last Name:"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(12, 58)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(265, 25)
        txtCustomerID.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 17)
        Label1.TabIndex = 3
        Label1.Text = "Customer ID:"
        ' 
        ' lblGroupCustomerInfo
        ' 
        lblGroupCustomerInfo.AutoSize = True
        lblGroupCustomerInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupCustomerInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupCustomerInfo.Location = New Point(12, 15)
        lblGroupCustomerInfo.Name = "lblGroupCustomerInfo"
        lblGroupCustomerInfo.Size = New Size(95, 13)
        lblGroupCustomerInfo.TabIndex = 1
        lblGroupCustomerInfo.Text = "CUSTOMER INFO"
        ' 
        ' frmCustomerDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(999, 1051)
        Controls.Add(pnlCustomerBody)
        Controls.Add(pnlCustomerHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmCustomerDesign"
        Text = "Customer Information"
        WindowState = FormWindowState.Maximized
        pnlCustomerHeader.ResumeLayout(False)
        pnlCustomerHeader.PerformLayout()
        pnlCustomerBody.ResumeLayout(False)
        pnlCustomerRight.ResumeLayout(False)
        pnlCustomerGrid.ResumeLayout(False)
        CType(dgvCustomer, ComponentModel.ISupportInitialize).EndInit()
        pnlCustomerSearch.ResumeLayout(False)
        pnlCustomerSearch.PerformLayout()
        pnlCustomerInput.ResumeLayout(False)
        pnlCustomerInput.PerformLayout()
        pnlCustomerButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents pnlCustomerHeader As Panel
    Friend WithEvents pnlCustomerBody As Panel
    Friend WithEvents pnlCustomerInput As Panel
    Friend WithEvents pnlCustomerButtons As Panel
    Friend WithEvents btnCloseCustomer As Button
    Friend WithEvents btnClearCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCCity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGroupAddress As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCStreet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCMiddleName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGroupCustomerInfo As Label
    Friend WithEvents txtCFirstName As TextBox
    Friend WithEvents lblGroupContact As Label
    Friend WithEvents txtCZipCode As TextBox
    Friend WithEvents txtCState As TextBox
    Friend WithEvents txtCDriverLicenseNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCContactNo As TextBox
    Friend WithEvents pnlCustomerRight As Panel
    Friend WithEvents pnlCustomerGrid As Panel
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents pnlCustomerSearch As Panel
    Friend WithEvents btnRefreshCustomer As Button
    Friend WithEvents txtCustomerSearch As TextBox
End Class
