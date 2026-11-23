<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoryDesign
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
        pnlCategoryHeader = New Panel()
        lblCategoryTitle = New Label()
        pnlCategoryBody = New Panel()
        pnlCategoryInput = New Panel()
        lblGroupCategoryInfo = New Label()
        Label1 = New Label()
        txtCategoryID = New TextBox()
        txtCategoryName = New TextBox()
        Label2 = New Label()
        txtCategoryDescription = New TextBox()
        Label3 = New Label()
        txtRatePerDay = New TextBox()
        Label4 = New Label()
        pnlCategoryBtns = New Panel()
        btnAddCategory = New Button()
        btnUpdateCategory = New Button()
        btnDeleteCategory = New Button()
        btnClearCategory = New Button()
        btnCloseCategory = New Button()
        pnlCategoryRight = New Panel()
        pnlCategorySearch = New Panel()
        txtCategorySearch = New TextBox()
        btnRefreshCategory = New Button()
        pnlCategoryGrid = New Panel()
        dgvCategory = New DataGridView()
        pnlCategoryHeader.SuspendLayout()
        pnlCategoryBody.SuspendLayout()
        pnlCategoryInput.SuspendLayout()
        pnlCategoryBtns.SuspendLayout()
        pnlCategoryRight.SuspendLayout()
        pnlCategorySearch.SuspendLayout()
        pnlCategoryGrid.SuspendLayout()
        CType(dgvCategory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCategoryHeader
        ' 
        pnlCategoryHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlCategoryHeader.Controls.Add(lblCategoryTitle)
        pnlCategoryHeader.Dock = DockStyle.Top
        pnlCategoryHeader.Location = New Point(0, 0)
        pnlCategoryHeader.Name = "pnlCategoryHeader"
        pnlCategoryHeader.Size = New Size(915, 60)
        pnlCategoryHeader.TabIndex = 0
        ' 
        ' lblCategoryTitle
        ' 
        lblCategoryTitle.AutoSize = True
        lblCategoryTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCategoryTitle.ForeColor = Color.White
        lblCategoryTitle.Location = New Point(0, 15)
        lblCategoryTitle.Name = "lblCategoryTitle"
        lblCategoryTitle.Padding = New Padding(15, 0, 0, 0)
        lblCategoryTitle.Size = New Size(222, 25)
        lblCategoryTitle.TabIndex = 0
        lblCategoryTitle.Text = "Category Information"
        lblCategoryTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlCategoryBody
        ' 
        pnlCategoryBody.Controls.Add(pnlCategoryRight)
        pnlCategoryBody.Controls.Add(pnlCategoryInput)
        pnlCategoryBody.Dock = DockStyle.Fill
        pnlCategoryBody.Location = New Point(0, 60)
        pnlCategoryBody.Name = "pnlCategoryBody"
        pnlCategoryBody.Size = New Size(915, 543)
        pnlCategoryBody.TabIndex = 1
        ' 
        ' pnlCategoryInput
        ' 
        pnlCategoryInput.BackColor = Color.White
        pnlCategoryInput.Controls.Add(pnlCategoryBtns)
        pnlCategoryInput.Controls.Add(txtRatePerDay)
        pnlCategoryInput.Controls.Add(Label4)
        pnlCategoryInput.Controls.Add(txtCategoryDescription)
        pnlCategoryInput.Controls.Add(Label3)
        pnlCategoryInput.Controls.Add(txtCategoryName)
        pnlCategoryInput.Controls.Add(Label2)
        pnlCategoryInput.Controls.Add(txtCategoryID)
        pnlCategoryInput.Controls.Add(Label1)
        pnlCategoryInput.Controls.Add(lblGroupCategoryInfo)
        pnlCategoryInput.Dock = DockStyle.Left
        pnlCategoryInput.Location = New Point(0, 0)
        pnlCategoryInput.Name = "pnlCategoryInput"
        pnlCategoryInput.Padding = New Padding(12)
        pnlCategoryInput.Size = New Size(300, 543)
        pnlCategoryInput.TabIndex = 0
        ' 
        ' lblGroupCategoryInfo
        ' 
        lblGroupCategoryInfo.AutoSize = True
        lblGroupCategoryInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGroupCategoryInfo.ForeColor = Color.FromArgb(CByte(136), CByte(153), CByte(187))
        lblGroupCategoryInfo.Location = New Point(12, 15)
        lblGroupCategoryInfo.Name = "lblGroupCategoryInfo"
        lblGroupCategoryInfo.Size = New Size(92, 13)
        lblGroupCategoryInfo.TabIndex = 0
        lblGroupCategoryInfo.Text = "CATEGORY INFO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 17)
        Label1.TabIndex = 1
        Label1.Text = "Category ID:"
        ' 
        ' txtCategoryID
        ' 
        txtCategoryID.Location = New Point(12, 58)
        txtCategoryID.Name = "txtCategoryID"
        txtCategoryID.Size = New Size(265, 25)
        txtCategoryID.TabIndex = 2
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Location = New Point(12, 116)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(265, 25)
        txtCategoryName.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 17)
        Label2.TabIndex = 3
        Label2.Text = "Category Name:"
        ' 
        ' txtCategoryDescription
        ' 
        txtCategoryDescription.Location = New Point(12, 174)
        txtCategoryDescription.Name = "txtCategoryDescription"
        txtCategoryDescription.Size = New Size(265, 25)
        txtCategoryDescription.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 5
        Label3.Text = "Description:"
        ' 
        ' txtRatePerDay
        ' 
        txtRatePerDay.Location = New Point(12, 268)
        txtRatePerDay.Name = "txtRatePerDay"
        txtRatePerDay.Size = New Size(265, 25)
        txtRatePerDay.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 17)
        Label4.TabIndex = 7
        Label4.Text = "Rate Per Day:"
        ' 
        ' pnlCategoryBtns
        ' 
        pnlCategoryBtns.Controls.Add(btnCloseCategory)
        pnlCategoryBtns.Controls.Add(btnClearCategory)
        pnlCategoryBtns.Controls.Add(btnDeleteCategory)
        pnlCategoryBtns.Controls.Add(btnUpdateCategory)
        pnlCategoryBtns.Controls.Add(btnAddCategory)
        pnlCategoryBtns.Dock = DockStyle.Bottom
        pnlCategoryBtns.Location = New Point(12, 431)
        pnlCategoryBtns.Name = "pnlCategoryBtns"
        pnlCategoryBtns.Size = New Size(276, 100)
        pnlCategoryBtns.TabIndex = 9
        ' 
        ' btnAddCategory
        ' 
        btnAddCategory.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        btnAddCategory.Cursor = Cursors.Hand
        btnAddCategory.FlatStyle = FlatStyle.Flat
        btnAddCategory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCategory.ForeColor = Color.White
        btnAddCategory.Location = New Point(5, 8)
        btnAddCategory.Name = "btnAddCategory"
        btnAddCategory.Size = New Size(80, 38)
        btnAddCategory.TabIndex = 0
        btnAddCategory.Text = "➕ Add"
        btnAddCategory.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCategory
        ' 
        btnUpdateCategory.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(0))
        btnUpdateCategory.Cursor = Cursors.Hand
        btnUpdateCategory.FlatStyle = FlatStyle.Flat
        btnUpdateCategory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpdateCategory.ForeColor = Color.White
        btnUpdateCategory.Location = New Point(90, 8)
        btnUpdateCategory.Name = "btnUpdateCategory"
        btnUpdateCategory.Size = New Size(80, 38)
        btnUpdateCategory.TabIndex = 1
        btnUpdateCategory.Text = "✏️ Update"
        btnUpdateCategory.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCategory
        ' 
        btnDeleteCategory.BackColor = Color.FromArgb(CByte(204), CByte(0), CByte(0))
        btnDeleteCategory.Cursor = Cursors.Hand
        btnDeleteCategory.FlatStyle = FlatStyle.Flat
        btnDeleteCategory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDeleteCategory.ForeColor = Color.White
        btnDeleteCategory.Location = New Point(175, 8)
        btnDeleteCategory.Name = "btnDeleteCategory"
        btnDeleteCategory.Size = New Size(80, 38)
        btnDeleteCategory.TabIndex = 2
        btnDeleteCategory.Text = "🗑️ Delete"
        btnDeleteCategory.UseVisualStyleBackColor = False
        ' 
        ' btnClearCategory
        ' 
        btnClearCategory.BackColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
        btnClearCategory.Cursor = Cursors.Hand
        btnClearCategory.FlatStyle = FlatStyle.Flat
        btnClearCategory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearCategory.ForeColor = Color.White
        btnClearCategory.Location = New Point(45, 52)
        btnClearCategory.Name = "btnClearCategory"
        btnClearCategory.Size = New Size(80, 38)
        btnClearCategory.TabIndex = 3
        btnClearCategory.Text = "✖️ Clear"
        btnClearCategory.UseVisualStyleBackColor = False
        ' 
        ' btnCloseCategory
        ' 
        btnCloseCategory.BackColor = Color.DarkRed
        btnCloseCategory.Cursor = Cursors.Hand
        btnCloseCategory.FlatStyle = FlatStyle.Flat
        btnCloseCategory.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseCategory.ForeColor = Color.White
        btnCloseCategory.Location = New Point(131, 52)
        btnCloseCategory.Name = "btnCloseCategory"
        btnCloseCategory.Size = New Size(80, 38)
        btnCloseCategory.TabIndex = 4
        btnCloseCategory.Text = "🚪 Close"
        btnCloseCategory.UseVisualStyleBackColor = False
        ' 
        ' pnlCategoryRight
        ' 
        pnlCategoryRight.Controls.Add(pnlCategoryGrid)
        pnlCategoryRight.Controls.Add(pnlCategorySearch)
        pnlCategoryRight.Dock = DockStyle.Fill
        pnlCategoryRight.Location = New Point(300, 0)
        pnlCategoryRight.Name = "pnlCategoryRight"
        pnlCategoryRight.Padding = New Padding(12)
        pnlCategoryRight.Size = New Size(615, 543)
        pnlCategoryRight.TabIndex = 1
        ' 
        ' pnlCategorySearch
        ' 
        pnlCategorySearch.Controls.Add(btnRefreshCategory)
        pnlCategorySearch.Controls.Add(txtCategorySearch)
        pnlCategorySearch.Dock = DockStyle.Top
        pnlCategorySearch.Location = New Point(12, 12)
        pnlCategorySearch.Name = "pnlCategorySearch"
        pnlCategorySearch.Size = New Size(591, 48)
        pnlCategorySearch.TabIndex = 0
        ' 
        ' txtCategorySearch
        ' 
        txtCategorySearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtCategorySearch.Location = New Point(0, 8)
        txtCategorySearch.Name = "txtCategorySearch"
        txtCategorySearch.Size = New Size(350, 25)
        txtCategorySearch.TabIndex = 0
        txtCategorySearch.Text = "Search by Category Name or Description..."
        ' 
        ' btnRefreshCategory
        ' 
        btnRefreshCategory.Cursor = Cursors.Hand
        btnRefreshCategory.FlatStyle = FlatStyle.Flat
        btnRefreshCategory.Location = New Point(360, 5)
        btnRefreshCategory.Name = "btnRefreshCategory"
        btnRefreshCategory.Size = New Size(100, 35)
        btnRefreshCategory.TabIndex = 1
        btnRefreshCategory.Text = "🔄 Refresh"
        btnRefreshCategory.UseVisualStyleBackColor = True
        ' 
        ' pnlCategoryGrid
        ' 
        pnlCategoryGrid.Controls.Add(dgvCategory)
        pnlCategoryGrid.Dock = DockStyle.Fill
        pnlCategoryGrid.Location = New Point(12, 60)
        pnlCategoryGrid.Name = "pnlCategoryGrid"
        pnlCategoryGrid.Size = New Size(591, 471)
        pnlCategoryGrid.TabIndex = 1
        ' 
        ' dgvCategory
        ' 
        dgvCategory.AllowUserToAddRows = False
        dgvCategory.AllowUserToDeleteRows = False
        dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCategory.BackgroundColor = Color.White
        dgvCategory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCategory.DefaultCellStyle = DataGridViewCellStyle2
        dgvCategory.Dock = DockStyle.Fill
        dgvCategory.Location = New Point(0, 0)
        dgvCategory.Name = "dgvCategory"
        dgvCategory.ReadOnly = True
        dgvCategory.RowHeadersVisible = False
        dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategory.Size = New Size(591, 471)
        dgvCategory.TabIndex = 0
        ' 
        ' frmCategoryDesign
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(915, 603)
        Controls.Add(pnlCategoryBody)
        Controls.Add(pnlCategoryHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmCategoryDesign"
        Text = "Vehicle Category Information"
        WindowState = FormWindowState.Maximized
        pnlCategoryHeader.ResumeLayout(False)
        pnlCategoryHeader.PerformLayout()
        pnlCategoryBody.ResumeLayout(False)
        pnlCategoryInput.ResumeLayout(False)
        pnlCategoryInput.PerformLayout()
        pnlCategoryBtns.ResumeLayout(False)
        pnlCategoryRight.ResumeLayout(False)
        pnlCategorySearch.ResumeLayout(False)
        pnlCategorySearch.PerformLayout()
        pnlCategoryGrid.ResumeLayout(False)
        CType(dgvCategory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCategoryHeader As Panel
    Friend WithEvents lblCategoryTitle As Label
    Friend WithEvents pnlCategoryBody As Panel
    Friend WithEvents pnlCategoryInput As Panel
    Friend WithEvents lblGroupCategoryInfo As Label
    Friend WithEvents txtRatePerDay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCategoryDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlCategoryBtns As Panel
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents btnClearCategory As Button
    Friend WithEvents btnDeleteCategory As Button
    Friend WithEvents btnUpdateCategory As Button
    Friend WithEvents btnCloseCategory As Button
    Friend WithEvents pnlCategoryRight As Panel
    Friend WithEvents pnlCategorySearch As Panel
    Friend WithEvents btnRefreshCategory As Button
    Friend WithEvents txtCategorySearch As TextBox
    Friend WithEvents pnlCategoryGrid As Panel
    Friend WithEvents dgvCategory As DataGridView
End Class
