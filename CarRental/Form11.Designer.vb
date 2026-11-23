<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenanceHistory
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
        pnlMaintenanceHistoryHeader = New Panel()
        lblMaintenanceHistoryTitle = New Label()
        pnlMaintenanceHistoryStats = New Panel()
        pnlCardTotalServices = New Panel()
        lblTotalServicesTitle = New Label()
        lblTotalServicesCount = New Label()
        pnlCardOilChange = New Panel()
        lblOilChangeCount = New Label()
        lblOilChangeTitle = New Label()
        pnlCardTireRotation = New Panel()
        lblTireRotationCount = New Label()
        lblTireRotationTitle = New Label()
        pnlCardTotalCost = New Panel()
        lblTotalCostValue = New Label()
        lblTotalCostTitle = New Label()
        pnlMaintenanceHistorySearch = New Panel()
        txtMaintenanceHistorySearch = New TextBox()
        btnRefreshMaintenanceHistory = New Button()
        btnCloseMaintenanceHistory = New Button()
        pnlMaintenanceHistoryGrid = New Panel()
        dgvMaintenanceHistory = New DataGridView()
        pnlMaintenanceHistoryHeader.SuspendLayout()
        pnlMaintenanceHistoryStats.SuspendLayout()
        pnlCardTotalServices.SuspendLayout()
        pnlCardOilChange.SuspendLayout()
        pnlCardTireRotation.SuspendLayout()
        pnlCardTotalCost.SuspendLayout()
        pnlMaintenanceHistorySearch.SuspendLayout()
        pnlMaintenanceHistoryGrid.SuspendLayout()
        CType(dgvMaintenanceHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMaintenanceHistoryHeader
        ' 
        pnlMaintenanceHistoryHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlMaintenanceHistoryHeader.Controls.Add(lblMaintenanceHistoryTitle)
        pnlMaintenanceHistoryHeader.Dock = DockStyle.Top
        pnlMaintenanceHistoryHeader.Location = New Point(0, 0)
        pnlMaintenanceHistoryHeader.Name = "pnlMaintenanceHistoryHeader"
        pnlMaintenanceHistoryHeader.Size = New Size(968, 60)
        pnlMaintenanceHistoryHeader.TabIndex = 0
        ' 
        ' lblMaintenanceHistoryTitle
        ' 
        lblMaintenanceHistoryTitle.AutoSize = True
        lblMaintenanceHistoryTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMaintenanceHistoryTitle.ForeColor = Color.White
        lblMaintenanceHistoryTitle.Location = New Point(0, 16)
        lblMaintenanceHistoryTitle.Name = "lblMaintenanceHistoryTitle"
        lblMaintenanceHistoryTitle.Padding = New Padding(15, 0, 0, 0)
        lblMaintenanceHistoryTitle.Size = New Size(213, 25)
        lblMaintenanceHistoryTitle.TabIndex = 0
        lblMaintenanceHistoryTitle.Text = "Maintenance History"
        lblMaintenanceHistoryTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlMaintenanceHistoryStats
        ' 
        pnlMaintenanceHistoryStats.Controls.Add(pnlCardTotalCost)
        pnlMaintenanceHistoryStats.Controls.Add(pnlCardTireRotation)
        pnlMaintenanceHistoryStats.Controls.Add(pnlCardOilChange)
        pnlMaintenanceHistoryStats.Controls.Add(pnlCardTotalServices)
        pnlMaintenanceHistoryStats.Dock = DockStyle.Top
        pnlMaintenanceHistoryStats.Location = New Point(0, 60)
        pnlMaintenanceHistoryStats.Name = "pnlMaintenanceHistoryStats"
        pnlMaintenanceHistoryStats.Padding = New Padding(15, 15, 15, 0)
        pnlMaintenanceHistoryStats.Size = New Size(968, 100)
        pnlMaintenanceHistoryStats.TabIndex = 1
        ' 
        ' pnlCardTotalServices
        ' 
        pnlCardTotalServices.Controls.Add(lblTotalServicesCount)
        pnlCardTotalServices.Controls.Add(lblTotalServicesTitle)
        pnlCardTotalServices.Location = New Point(15, 15)
        pnlCardTotalServices.Name = "pnlCardTotalServices"
        pnlCardTotalServices.Size = New Size(160, 70)
        pnlCardTotalServices.TabIndex = 0
        ' 
        ' lblTotalServicesTitle
        ' 
        lblTotalServicesTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalServicesTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalServicesTitle.Location = New Point(10, 8)
        lblTotalServicesTitle.Name = "lblTotalServicesTitle"
        lblTotalServicesTitle.Size = New Size(140, 20)
        lblTotalServicesTitle.TabIndex = 0
        lblTotalServicesTitle.Text = "Total Services"
        ' 
        ' lblTotalServicesCount
        ' 
        lblTotalServicesCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalServicesCount.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblTotalServicesCount.Location = New Point(10, 30)
        lblTotalServicesCount.Name = "lblTotalServicesCount"
        lblTotalServicesCount.Size = New Size(140, 32)
        lblTotalServicesCount.TabIndex = 1
        lblTotalServicesCount.Text = "0"
        ' 
        ' pnlCardOilChange
        ' 
        pnlCardOilChange.Controls.Add(lblOilChangeCount)
        pnlCardOilChange.Controls.Add(lblOilChangeTitle)
        pnlCardOilChange.Location = New Point(190, 15)
        pnlCardOilChange.Name = "pnlCardOilChange"
        pnlCardOilChange.Size = New Size(160, 70)
        pnlCardOilChange.TabIndex = 1
        ' 
        ' lblOilChangeCount
        ' 
        lblOilChangeCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOilChangeCount.ForeColor = Color.FromArgb(CByte(133), CByte(79), CByte(11))
        lblOilChangeCount.Location = New Point(10, 30)
        lblOilChangeCount.Name = "lblOilChangeCount"
        lblOilChangeCount.Size = New Size(140, 32)
        lblOilChangeCount.TabIndex = 1
        lblOilChangeCount.Text = "0"
        ' 
        ' lblOilChangeTitle
        ' 
        lblOilChangeTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOilChangeTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblOilChangeTitle.Location = New Point(10, 8)
        lblOilChangeTitle.Name = "lblOilChangeTitle"
        lblOilChangeTitle.Size = New Size(140, 20)
        lblOilChangeTitle.TabIndex = 0
        lblOilChangeTitle.Text = "Oil Changes"
        ' 
        ' pnlCardTireRotation
        ' 
        pnlCardTireRotation.Controls.Add(lblTireRotationCount)
        pnlCardTireRotation.Controls.Add(lblTireRotationTitle)
        pnlCardTireRotation.Location = New Point(365, 15)
        pnlCardTireRotation.Name = "pnlCardTireRotation"
        pnlCardTireRotation.Size = New Size(160, 70)
        pnlCardTireRotation.TabIndex = 2
        ' 
        ' lblTireRotationCount
        ' 
        lblTireRotationCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTireRotationCount.ForeColor = Color.FromArgb(CByte(39), CByte(80), CByte(10))
        lblTireRotationCount.Location = New Point(10, 30)
        lblTireRotationCount.Name = "lblTireRotationCount"
        lblTireRotationCount.Size = New Size(140, 32)
        lblTireRotationCount.TabIndex = 1
        lblTireRotationCount.Text = "0"
        ' 
        ' lblTireRotationTitle
        ' 
        lblTireRotationTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTireRotationTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTireRotationTitle.Location = New Point(10, 8)
        lblTireRotationTitle.Name = "lblTireRotationTitle"
        lblTireRotationTitle.Size = New Size(140, 20)
        lblTireRotationTitle.TabIndex = 0
        lblTireRotationTitle.Text = "Tire Rotations"
        ' 
        ' pnlCardTotalCost
        ' 
        pnlCardTotalCost.Controls.Add(lblTotalCostValue)
        pnlCardTotalCost.Controls.Add(lblTotalCostTitle)
        pnlCardTotalCost.Location = New Point(540, 15)
        pnlCardTotalCost.Name = "pnlCardTotalCost"
        pnlCardTotalCost.Size = New Size(200, 70)
        pnlCardTotalCost.TabIndex = 3
        ' 
        ' lblTotalCostValue
        ' 
        lblTotalCostValue.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCostValue.ForeColor = Color.FromArgb(CByte(163), CByte(45), CByte(45))
        lblTotalCostValue.Location = New Point(10, 30)
        lblTotalCostValue.Name = "lblTotalCostValue"
        lblTotalCostValue.Size = New Size(180, 32)
        lblTotalCostValue.TabIndex = 1
        lblTotalCostValue.Text = "0.00"
        ' 
        ' lblTotalCostTitle
        ' 
        lblTotalCostTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalCostTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalCostTitle.Location = New Point(10, 8)
        lblTotalCostTitle.Name = "lblTotalCostTitle"
        lblTotalCostTitle.Size = New Size(180, 20)
        lblTotalCostTitle.TabIndex = 0
        lblTotalCostTitle.Text = "Total Cost"
        ' 
        ' pnlMaintenanceHistorySearch
        ' 
        pnlMaintenanceHistorySearch.Controls.Add(btnCloseMaintenanceHistory)
        pnlMaintenanceHistorySearch.Controls.Add(btnRefreshMaintenanceHistory)
        pnlMaintenanceHistorySearch.Controls.Add(txtMaintenanceHistorySearch)
        pnlMaintenanceHistorySearch.Dock = DockStyle.Top
        pnlMaintenanceHistorySearch.Location = New Point(0, 160)
        pnlMaintenanceHistorySearch.Name = "pnlMaintenanceHistorySearch"
        pnlMaintenanceHistorySearch.Padding = New Padding(12, 0, 12, 0)
        pnlMaintenanceHistorySearch.Size = New Size(968, 48)
        pnlMaintenanceHistorySearch.TabIndex = 2
        ' 
        ' txtMaintenanceHistorySearch
        ' 
        txtMaintenanceHistorySearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtMaintenanceHistorySearch.Location = New Point(12, 8)
        txtMaintenanceHistorySearch.Name = "txtMaintenanceHistorySearch"
        txtMaintenanceHistorySearch.Size = New Size(350, 25)
        txtMaintenanceHistorySearch.TabIndex = 0
        txtMaintenanceHistorySearch.Text = "Search by Vehicle, Type, or Technician..."
        ' 
        ' btnRefreshMaintenanceHistory
        ' 
        btnRefreshMaintenanceHistory.Cursor = Cursors.Hand
        btnRefreshMaintenanceHistory.FlatStyle = FlatStyle.Flat
        btnRefreshMaintenanceHistory.Location = New Point(370, 5)
        btnRefreshMaintenanceHistory.Name = "btnRefreshMaintenanceHistory"
        btnRefreshMaintenanceHistory.Size = New Size(100, 35)
        btnRefreshMaintenanceHistory.TabIndex = 1
        btnRefreshMaintenanceHistory.Text = "🔄 Refresh"
        btnRefreshMaintenanceHistory.UseVisualStyleBackColor = True
        ' 
        ' btnCloseMaintenanceHistory
        ' 
        btnCloseMaintenanceHistory.BackColor = Color.DarkRed
        btnCloseMaintenanceHistory.Cursor = Cursors.Hand
        btnCloseMaintenanceHistory.FlatStyle = FlatStyle.Flat
        btnCloseMaintenanceHistory.ForeColor = Color.White
        btnCloseMaintenanceHistory.Location = New Point(478, 5)
        btnCloseMaintenanceHistory.Name = "btnCloseMaintenanceHistory"
        btnCloseMaintenanceHistory.Size = New Size(80, 35)
        btnCloseMaintenanceHistory.TabIndex = 2
        btnCloseMaintenanceHistory.Text = "🚪 Close"
        btnCloseMaintenanceHistory.UseVisualStyleBackColor = False
        ' 
        ' pnlMaintenanceHistoryGrid
        ' 
        pnlMaintenanceHistoryGrid.Controls.Add(dgvMaintenanceHistory)
        pnlMaintenanceHistoryGrid.Dock = DockStyle.Fill
        pnlMaintenanceHistoryGrid.Location = New Point(0, 208)
        pnlMaintenanceHistoryGrid.Name = "pnlMaintenanceHistoryGrid"
        pnlMaintenanceHistoryGrid.Padding = New Padding(12, 8, 12, 12)
        pnlMaintenanceHistoryGrid.Size = New Size(968, 396)
        pnlMaintenanceHistoryGrid.TabIndex = 3
        ' 
        ' dgvMaintenanceHistory
        ' 
        dgvMaintenanceHistory.AllowUserToAddRows = False
        dgvMaintenanceHistory.AllowUserToDeleteRows = False
        dgvMaintenanceHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMaintenanceHistory.BackgroundColor = Color.White
        dgvMaintenanceHistory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMaintenanceHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMaintenanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvMaintenanceHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvMaintenanceHistory.Dock = DockStyle.Fill
        dgvMaintenanceHistory.Location = New Point(12, 8)
        dgvMaintenanceHistory.Name = "dgvMaintenanceHistory"
        dgvMaintenanceHistory.ReadOnly = True
        dgvMaintenanceHistory.RowHeadersVisible = False
        dgvMaintenanceHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMaintenanceHistory.Size = New Size(944, 376)
        dgvMaintenanceHistory.TabIndex = 0
        ' 
        ' frmMaintenanceHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(968, 604)
        Controls.Add(pnlMaintenanceHistoryGrid)
        Controls.Add(pnlMaintenanceHistorySearch)
        Controls.Add(pnlMaintenanceHistoryStats)
        Controls.Add(pnlMaintenanceHistoryHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmMaintenanceHistory"
        Text = "Maintenance History"
        WindowState = FormWindowState.Maximized
        pnlMaintenanceHistoryHeader.ResumeLayout(False)
        pnlMaintenanceHistoryHeader.PerformLayout()
        pnlMaintenanceHistoryStats.ResumeLayout(False)
        pnlCardTotalServices.ResumeLayout(False)
        pnlCardOilChange.ResumeLayout(False)
        pnlCardTireRotation.ResumeLayout(False)
        pnlCardTotalCost.ResumeLayout(False)
        pnlMaintenanceHistorySearch.ResumeLayout(False)
        pnlMaintenanceHistorySearch.PerformLayout()
        pnlMaintenanceHistoryGrid.ResumeLayout(False)
        CType(dgvMaintenanceHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMaintenanceHistoryHeader As Panel
    Friend WithEvents lblMaintenanceHistoryTitle As Label
    Friend WithEvents pnlMaintenanceHistoryStats As Panel
    Friend WithEvents pnlCardTotalServices As Panel
    Friend WithEvents lblTotalServicesTitle As Label
    Friend WithEvents lblTotalServicesCount As Label
    Friend WithEvents pnlCardOilChange As Panel
    Friend WithEvents lblOilChangeCount As Label
    Friend WithEvents lblOilChangeTitle As Label
    Friend WithEvents pnlCardTireRotation As Panel
    Friend WithEvents lblTireRotationCount As Label
    Friend WithEvents lblTireRotationTitle As Label
    Friend WithEvents pnlCardTotalCost As Panel
    Friend WithEvents lblTotalCostValue As Label
    Friend WithEvents lblTotalCostTitle As Label
    Friend WithEvents pnlMaintenanceHistorySearch As Panel
    Friend WithEvents txtMaintenanceHistorySearch As TextBox
    Friend WithEvents btnRefreshMaintenanceHistory As Button
    Friend WithEvents btnCloseMaintenanceHistory As Button
    Friend WithEvents pnlMaintenanceHistoryGrid As Panel
    Friend WithEvents dgvMaintenanceHistory As DataGridView
End Class
