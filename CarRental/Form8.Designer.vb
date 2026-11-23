<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeDesign
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
        pnlEmployeeHeader = New Panel()
        lblEmployeeTitle = New Label()
        pnlEmployeeBody = New Panel()
        pnlEmployeeInput = New Panel()
        lblGroupEmployeeInfo = New Label()
        Label1 = New Label()
        txtEmployeeID = New TextBox()
        txtELastName = New TextBox()
        Label2 = New Label()
        txtEFirstName = New TextBox()
        Label3 = New Label()
        txtEMiddleName = New TextBox()
        Label4 = New Label()
        txtEContactNo = New TextBox()
        Label5 = New Label()
        lblGroupRole = New Label()
        Label7 = New Label()
        cbEmployeeType = New ComboBox()
        pnlEmployeeBtns = New Panel()
        btnAddEmployee = New Button()
        btnUpdateEmployee = New Button()
        btnDeleteEmployee = New Button()
        btnClearEmployee = New Button()
        btnCloseEmployee = New Button()
        pnlEmployeeRight = New Panel()
        pnlEmployeeSearch = New Panel()
        txtEmployeeSearch = New TextBox()
        btnRefreshEmployee = New Button()
        pnlEmployeeGrid = New Panel()
        dgvEmployee = New DataGridView()
        pnlEmployeeHeader.SuspendLayout()
        pnlEmployeeBody.SuspendLayout()
        pnlEmployeeInput.SuspendLayout()
        pnlEmployeeBtns.SuspendLayout()
        pnlEmployeeRight.SuspendLayout()
        pnlEmployeeSearch.SuspendLayout()
        pnlEmployeeGrid.SuspendLayout()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEmployeeHeader
        ' 
        pnlEmployeeHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlEmployeeHeader.Controls.Add(lblEmployeeTitle)
        pnlEmployeeHeader.Dock = DockStyle.Top
        pnlEmployeeHeader.Location = New Point(0, 0)
        pnlEmployeeHeader.Name = "pnlEmployeeHeader"
        pnlEmployeeHeader.Size = New Size(1247, 60)
        pnlEmployeeHeader.TabIndex = 0
        ' 
        ' lblEmployeeTitle
        ' 
        lblEmployeeTitle.AutoSize = True
        lblEmployeeTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmployeeTitle.ForeColor = Color.White
        lblEmployeeTitle.Location = New Point(0, 16)
        lblEmployeeTitle.Name = "lblEmployeeTitle"
        lblEmployeeTitle.Padding = New Padding(15, 0, 0, 0)
        lblEmployeeTitle.Size = New Size(226, 25)
        lblEmployeeTitle.TabIndex = 0
        lblEmployeeTitle.Text = "Employee Information"
        lblEmployeeTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlEmployeeBody
        ' 
        pnlEmployeeBody.Controls.Add(pnlEmployeeRight)
        pnlEmployeeBody.Controls.Add(pnlEmployeeInput)
        pnlEmployeeBody.Dock = DockStyle.Fill
        pnlEmployeeBody.Location = New Point(0, 60)
        pnlEmployeeBody.Name = "pnlEmployeeBody"
        pnlEmployeeBody.Size = New Size(1247, 933)
        pnlEmployeeBody.TabIndex = 1
        ' 
        ' pnlEmployeeInput
        ' 
        pnlEmployeeInput.BackColor = Color.White
        pnlEmployeeInput.Controls.Add(pnlEmployeeBtns)
        pnlEmployeeInput.Controls.Add(cbEmployeeType)
        pnlEmployeeInput.Controls.Add(Label7)
        pnlEmployeeInput.Controls.Add(lblGroupRole)
        pnlEmployeeInput.Controls.Add(txtEContactNo)
        pnlEmployeeInput.Controls.Add(Label5)
        pnlEmployeeInput.Controls.Add(txtEMiddleName)
        pnlEmployeeInput.Controls.Add(Label4)
        pnlEmployeeInput.Controls.Add(txtEFirstName)
        pnlEmployeeInput.Controls.Add(Label3)
        pnlEmployeeInput.Controls.Add(txtELastName)
        pnlEmployeeInput.Controls.Add(Label2)
        pnlEmployeeInput.Controls.Add(txtEmployeeID)
        pnlEmployeeInput.Controls.Add(Label1)
        pnlEmployeeInput.Controls.Add(lblGroupEmployeeInfo)
        pnlEmployeeInput.Dock = DockStyle.Left
        pnlEmployeeInput.Location = New Point(0, 0)
        pnlEmployeeInput.Name = "pnlEmployeeInput"
        pnlEmployeeInput.Padding = New Padding(12)
        pnlEmployeeInput.Size = New Size(300, 933)
        pnlEmployeeInput.TabIndex = 0
        ' 
        ' lblGroupEmployeeInfo
        ' 
        lblGroupEmployeeInfo.AutoSize = True
        lblGroupEmployeeInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupEmployeeInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupEmployeeInfo.Location = New Point(12, 15)
        lblGroupEmployeeInfo.Name = "lblGroupEmployeeInfo"
        lblGroupEmployeeInfo.Size = New Size(93, 13)
        lblGroupEmployeeInfo.TabIndex = 0
        lblGroupEmployeeInfo.Text = "EMPLOYEE INFO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 17)
        Label1.TabIndex = 1
        Label1.Text = "Employee ID:"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(12, 58)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(265, 25)
        txtEmployeeID.TabIndex = 2
        ' 
        ' txtELastName
        ' 
        txtELastName.Location = New Point(12, 116)
        txtELastName.Name = "txtELastName"
        txtELastName.Size = New Size(265, 25)
        txtELastName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 17)
        Label2.TabIndex = 3
        Label2.Text = "Last Name:"
        ' 
        ' txtEFirstName
        ' 
        txtEFirstName.Location = New Point(12, 174)
        txtEFirstName.Name = "txtEFirstName"
        txtEFirstName.Size = New Size(265, 25)
        txtEFirstName.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 17)
        Label3.TabIndex = 5
        Label3.Text = "First Name:"
        ' 
        ' txtEMiddleName
        ' 
        txtEMiddleName.Location = New Point(12, 232)
        txtEMiddleName.Name = "txtEMiddleName"
        txtEMiddleName.Size = New Size(265, 25)
        txtEMiddleName.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 17)
        Label4.TabIndex = 7
        Label4.Text = "Middle Name:"
        ' 
        ' txtEContactNo
        ' 
        txtEContactNo.Location = New Point(12, 290)
        txtEContactNo.Name = "txtEContactNo"
        txtEContactNo.Size = New Size(265, 25)
        txtEContactNo.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 17)
        Label5.TabIndex = 9
        Label5.Text = "Contact No:"
        ' 
        ' lblGroupRole
        ' 
        lblGroupRole.AutoSize = True
        lblGroupRole.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupRole.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupRole.Location = New Point(12, 335)
        lblGroupRole.Name = "lblGroupRole"
        lblGroupRole.Size = New Size(34, 13)
        lblGroupRole.TabIndex = 11
        lblGroupRole.Text = "ROLE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 355)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 12
        Label7.Text = "Employee Type:"
        ' 
        ' cbEmployeeType
        ' 
        cbEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList
        cbEmployeeType.FormattingEnabled = True
        cbEmployeeType.Items.AddRange(New Object() {"Clerk", "Technician"})
        cbEmployeeType.Location = New Point(12, 373)
        cbEmployeeType.Name = "cbEmployeeType"
        cbEmployeeType.Size = New Size(265, 25)
        cbEmployeeType.TabIndex = 13
        ' 
        ' pnlEmployeeBtns
        ' 
        pnlEmployeeBtns.Controls.Add(btnCloseEmployee)
        pnlEmployeeBtns.Controls.Add(btnClearEmployee)
        pnlEmployeeBtns.Controls.Add(btnDeleteEmployee)
        pnlEmployeeBtns.Controls.Add(btnUpdateEmployee)
        pnlEmployeeBtns.Controls.Add(btnAddEmployee)
        pnlEmployeeBtns.Dock = DockStyle.Bottom
        pnlEmployeeBtns.Location = New Point(12, 821)
        pnlEmployeeBtns.Name = "pnlEmployeeBtns"
        pnlEmployeeBtns.Size = New Size(276, 100)
        pnlEmployeeBtns.TabIndex = 14
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddEmployee.Cursor = Cursors.Hand
        btnAddEmployee.FlatStyle = FlatStyle.Flat
        btnAddEmployee.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddEmployee.ForeColor = Color.White
        btnAddEmployee.Location = New Point(5, 8)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(80, 38)
        btnAddEmployee.TabIndex = 0
        btnAddEmployee.Text = "➕ Add"
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateEmployee
        ' 
        btnUpdateEmployee.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateEmployee.Cursor = Cursors.Hand
        btnUpdateEmployee.FlatStyle = FlatStyle.Flat
        btnUpdateEmployee.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateEmployee.ForeColor = Color.White
        btnUpdateEmployee.Location = New Point(90, 8)
        btnUpdateEmployee.Name = "btnUpdateEmployee"
        btnUpdateEmployee.Size = New Size(80, 38)
        btnUpdateEmployee.TabIndex = 1
        btnUpdateEmployee.Text = "✏️ Update"
        btnUpdateEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteEmployee
        ' 
        btnDeleteEmployee.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteEmployee.Cursor = Cursors.Hand
        btnDeleteEmployee.FlatStyle = FlatStyle.Flat
        btnDeleteEmployee.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteEmployee.ForeColor = Color.White
        btnDeleteEmployee.Location = New Point(175, 8)
        btnDeleteEmployee.Name = "btnDeleteEmployee"
        btnDeleteEmployee.Size = New Size(80, 38)
        btnDeleteEmployee.TabIndex = 2
        btnDeleteEmployee.Text = "🗑️ Delete"
        btnDeleteEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnClearEmployee
        ' 
        btnClearEmployee.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearEmployee.Cursor = Cursors.Hand
        btnClearEmployee.FlatStyle = FlatStyle.Flat
        btnClearEmployee.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearEmployee.ForeColor = Color.White
        btnClearEmployee.Location = New Point(44, 52)
        btnClearEmployee.Name = "btnClearEmployee"
        btnClearEmployee.Size = New Size(80, 38)
        btnClearEmployee.TabIndex = 3
        btnClearEmployee.Text = "✖️ Clear"
        btnClearEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnCloseEmployee
        ' 
        btnCloseEmployee.BackColor = Color.DarkRed
        btnCloseEmployee.Cursor = Cursors.Hand
        btnCloseEmployee.FlatStyle = FlatStyle.Flat
        btnCloseEmployee.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseEmployee.ForeColor = Color.White
        btnCloseEmployee.Location = New Point(134, 52)
        btnCloseEmployee.Name = "btnCloseEmployee"
        btnCloseEmployee.Size = New Size(80, 38)
        btnCloseEmployee.TabIndex = 4
        btnCloseEmployee.Text = "🚪 Close"
        btnCloseEmployee.UseVisualStyleBackColor = False
        ' 
        ' pnlEmployeeRight
        ' 
        pnlEmployeeRight.Controls.Add(pnlEmployeeGrid)
        pnlEmployeeRight.Controls.Add(pnlEmployeeSearch)
        pnlEmployeeRight.Dock = DockStyle.Fill
        pnlEmployeeRight.Location = New Point(300, 0)
        pnlEmployeeRight.Name = "pnlEmployeeRight"
        pnlEmployeeRight.Padding = New Padding(12)
        pnlEmployeeRight.Size = New Size(947, 933)
        pnlEmployeeRight.TabIndex = 1
        ' 
        ' pnlEmployeeSearch
        ' 
        pnlEmployeeSearch.Controls.Add(btnRefreshEmployee)
        pnlEmployeeSearch.Controls.Add(txtEmployeeSearch)
        pnlEmployeeSearch.Dock = DockStyle.Top
        pnlEmployeeSearch.Location = New Point(12, 12)
        pnlEmployeeSearch.Name = "pnlEmployeeSearch"
        pnlEmployeeSearch.Size = New Size(923, 48)
        pnlEmployeeSearch.TabIndex = 0
        ' 
        ' txtEmployeeSearch
        ' 
        txtEmployeeSearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtEmployeeSearch.Location = New Point(0, 8)
        txtEmployeeSearch.Name = "txtEmployeeSearch"
        txtEmployeeSearch.Size = New Size(350, 25)
        txtEmployeeSearch.TabIndex = 0
        txtEmployeeSearch.Text = "Search by Name or Employee Type..."
        ' 
        ' btnRefreshEmployee
        ' 
        btnRefreshEmployee.Cursor = Cursors.Hand
        btnRefreshEmployee.FlatStyle = FlatStyle.Flat
        btnRefreshEmployee.Location = New Point(360, 5)
        btnRefreshEmployee.Name = "btnRefreshEmployee"
        btnRefreshEmployee.Size = New Size(100, 35)
        btnRefreshEmployee.TabIndex = 1
        btnRefreshEmployee.Text = "🔄 Refresh"
        btnRefreshEmployee.UseVisualStyleBackColor = True
        ' 
        ' pnlEmployeeGrid
        ' 
        pnlEmployeeGrid.BackColor = Color.WhiteSmoke
        pnlEmployeeGrid.Controls.Add(dgvEmployee)
        pnlEmployeeGrid.Dock = DockStyle.Fill
        pnlEmployeeGrid.Location = New Point(12, 60)
        pnlEmployeeGrid.Name = "pnlEmployeeGrid"
        pnlEmployeeGrid.Size = New Size(923, 861)
        pnlEmployeeGrid.TabIndex = 1
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AllowUserToAddRows = False
        dgvEmployee.AllowUserToDeleteRows = False
        dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvEmployee.BackgroundColor = Color.White
        dgvEmployee.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvEmployee.DefaultCellStyle = DataGridViewCellStyle2
        dgvEmployee.Dock = DockStyle.Fill
        dgvEmployee.Location = New Point(0, 0)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.ReadOnly = True
        dgvEmployee.RowHeadersVisible = False
        dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployee.Size = New Size(923, 861)
        dgvEmployee.TabIndex = 0
        ' 
        ' frmEmployeeDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1247, 993)
        Controls.Add(pnlEmployeeBody)
        Controls.Add(pnlEmployeeHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmEmployeeDesign"
        Text = "Employee Information"
        WindowState = FormWindowState.Maximized
        pnlEmployeeHeader.ResumeLayout(False)
        pnlEmployeeHeader.PerformLayout()
        pnlEmployeeBody.ResumeLayout(False)
        pnlEmployeeInput.ResumeLayout(False)
        pnlEmployeeInput.PerformLayout()
        pnlEmployeeBtns.ResumeLayout(False)
        pnlEmployeeRight.ResumeLayout(False)
        pnlEmployeeSearch.ResumeLayout(False)
        pnlEmployeeSearch.PerformLayout()
        pnlEmployeeGrid.ResumeLayout(False)
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEmployeeHeader As Panel
    Friend WithEvents lblEmployeeTitle As Label
    Friend WithEvents pnlEmployeeBody As Panel
    Friend WithEvents pnlEmployeeInput As Panel
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGroupEmployeeInfo As Label
    Friend WithEvents txtEMiddleName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtELastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGroupRole As Label
    Friend WithEvents txtEContactNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbEmployeeType As ComboBox
    Friend WithEvents pnlEmployeeBtns As Panel
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnCloseEmployee As Button
    Friend WithEvents btnClearEmployee As Button
    Friend WithEvents btnDeleteEmployee As Button
    Friend WithEvents btnUpdateEmployee As Button
    Friend WithEvents pnlEmployeeRight As Panel
    Friend WithEvents pnlEmployeeSearch As Panel
    Friend WithEvents txtEmployeeSearch As TextBox
    Friend WithEvents btnRefreshEmployee As Button
    Friend WithEvents pnlEmployeeGrid As Panel
    Friend WithEvents dgvEmployee As DataGridView
End Class
