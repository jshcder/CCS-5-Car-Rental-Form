<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalHistory
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
        pnlRentalHistoryHeader = New Panel()
        lblRentalHistoryTitle = New Label()
        pnlRentalHistoryStats = New Panel()
        pnlCardTotalRentals = New Panel()
        lblTotalRentalsTitle = New Label()
        lblTotalRentalsCount = New Label()
        lblReturnedCount = New Label()
        lblReturnedTitle = New Label()
        pnlCardReturned = New Panel()
        pnlCardActive = New Panel()
        lblActiveCount = New Label()
        lblActiveTitle = New Label()
        lblCancelledTitle = New Label()
        pnlCardCancelled = New Panel()
        lblCancelledCount = New Label()
        pnlRentalHistorySearch = New Panel()
        txtRentalHistorySearch = New TextBox()
        btnRefreshRentalHistory = New Button()
        btnCloseRentalHistory = New Button()
        pnlRentalHistoryGrid = New Panel()
        dgvRentalHistory = New DataGridView()
        pnlRentalHistoryHeader.SuspendLayout()
        pnlRentalHistoryStats.SuspendLayout()
        pnlCardTotalRentals.SuspendLayout()
        pnlCardReturned.SuspendLayout()
        pnlCardActive.SuspendLayout()
        pnlCardCancelled.SuspendLayout()
        pnlRentalHistorySearch.SuspendLayout()
        pnlRentalHistoryGrid.SuspendLayout()
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlRentalHistoryHeader
        ' 
        pnlRentalHistoryHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlRentalHistoryHeader.Controls.Add(lblRentalHistoryTitle)
        pnlRentalHistoryHeader.Dock = DockStyle.Top
        pnlRentalHistoryHeader.Location = New Point(0, 0)
        pnlRentalHistoryHeader.Name = "pnlRentalHistoryHeader"
        pnlRentalHistoryHeader.Size = New Size(800, 60)
        pnlRentalHistoryHeader.TabIndex = 0
        ' 
        ' lblRentalHistoryTitle
        ' 
        lblRentalHistoryTitle.AutoSize = True
        lblRentalHistoryTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalHistoryTitle.ForeColor = Color.White
        lblRentalHistoryTitle.Location = New Point(0, 15)
        lblRentalHistoryTitle.Name = "lblRentalHistoryTitle"
        lblRentalHistoryTitle.Padding = New Padding(15, 0, 0, 0)
        lblRentalHistoryTitle.Size = New Size(154, 25)
        lblRentalHistoryTitle.TabIndex = 0
        lblRentalHistoryTitle.Text = "Rental History"
        lblRentalHistoryTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlRentalHistoryStats
        ' 
        pnlRentalHistoryStats.Controls.Add(pnlCardCancelled)
        pnlRentalHistoryStats.Controls.Add(pnlCardActive)
        pnlRentalHistoryStats.Controls.Add(pnlCardReturned)
        pnlRentalHistoryStats.Controls.Add(pnlCardTotalRentals)
        pnlRentalHistoryStats.Dock = DockStyle.Top
        pnlRentalHistoryStats.Location = New Point(0, 60)
        pnlRentalHistoryStats.Name = "pnlRentalHistoryStats"
        pnlRentalHistoryStats.Padding = New Padding(15, 15, 15, 0)
        pnlRentalHistoryStats.Size = New Size(800, 100)
        pnlRentalHistoryStats.TabIndex = 1
        ' 
        ' pnlCardTotalRentals
        ' 
        pnlCardTotalRentals.BackColor = Color.White
        pnlCardTotalRentals.Controls.Add(lblTotalRentalsCount)
        pnlCardTotalRentals.Controls.Add(lblTotalRentalsTitle)
        pnlCardTotalRentals.Location = New Point(15, 15)
        pnlCardTotalRentals.Name = "pnlCardTotalRentals"
        pnlCardTotalRentals.Size = New Size(160, 70)
        pnlCardTotalRentals.TabIndex = 0
        ' 
        ' lblTotalRentalsTitle
        ' 
        lblTotalRentalsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalRentalsTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalRentalsTitle.Location = New Point(10, 8)
        lblTotalRentalsTitle.Name = "lblTotalRentalsTitle"
        lblTotalRentalsTitle.Size = New Size(140, 20)
        lblTotalRentalsTitle.TabIndex = 0
        lblTotalRentalsTitle.Text = "Total Rentals"
        ' 
        ' lblTotalRentalsCount
        ' 
        lblTotalRentalsCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRentalsCount.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblTotalRentalsCount.Location = New Point(10, 30)
        lblTotalRentalsCount.Name = "lblTotalRentalsCount"
        lblTotalRentalsCount.Size = New Size(140, 32)
        lblTotalRentalsCount.TabIndex = 1
        lblTotalRentalsCount.Text = "0"
        ' 
        ' lblReturnedCount
        ' 
        lblReturnedCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReturnedCount.ForeColor = Color.FromArgb(CByte(39), CByte(80), CByte(10))
        lblReturnedCount.Location = New Point(10, 30)
        lblReturnedCount.Name = "lblReturnedCount"
        lblReturnedCount.Size = New Size(140, 32)
        lblReturnedCount.TabIndex = 1
        lblReturnedCount.Text = "0"
        ' 
        ' lblReturnedTitle
        ' 
        lblReturnedTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReturnedTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblReturnedTitle.Location = New Point(10, 8)
        lblReturnedTitle.Name = "lblReturnedTitle"
        lblReturnedTitle.Size = New Size(140, 20)
        lblReturnedTitle.TabIndex = 0
        lblReturnedTitle.Text = "Returned"
        ' 
        ' pnlCardReturned
        ' 
        pnlCardReturned.BackColor = Color.White
        pnlCardReturned.Controls.Add(lblReturnedCount)
        pnlCardReturned.Controls.Add(lblReturnedTitle)
        pnlCardReturned.Location = New Point(190, 15)
        pnlCardReturned.Name = "pnlCardReturned"
        pnlCardReturned.Size = New Size(160, 70)
        pnlCardReturned.TabIndex = 1
        ' 
        ' pnlCardActive
        ' 
        pnlCardActive.BackColor = Color.White
        pnlCardActive.Controls.Add(lblActiveCount)
        pnlCardActive.Controls.Add(lblActiveTitle)
        pnlCardActive.Location = New Point(365, 15)
        pnlCardActive.Name = "pnlCardActive"
        pnlCardActive.Size = New Size(160, 70)
        pnlCardActive.TabIndex = 2
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActiveCount.ForeColor = Color.FromArgb(CByte(12), CByte(68), CByte(124))
        lblActiveCount.Location = New Point(10, 30)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(140, 32)
        lblActiveCount.TabIndex = 1
        lblActiveCount.Text = "0"
        ' 
        ' lblActiveTitle
        ' 
        lblActiveTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblActiveTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblActiveTitle.Location = New Point(10, 8)
        lblActiveTitle.Name = "lblActiveTitle"
        lblActiveTitle.Size = New Size(140, 20)
        lblActiveTitle.TabIndex = 0
        lblActiveTitle.Text = "Active"
        ' 
        ' lblCancelledTitle
        ' 
        lblCancelledTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCancelledTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblCancelledTitle.Location = New Point(10, 8)
        lblCancelledTitle.Name = "lblCancelledTitle"
        lblCancelledTitle.Size = New Size(140, 20)
        lblCancelledTitle.TabIndex = 0
        lblCancelledTitle.Text = "Cancelled"
        ' 
        ' pnlCardCancelled
        ' 
        pnlCardCancelled.BackColor = Color.White
        pnlCardCancelled.Controls.Add(lblCancelledCount)
        pnlCardCancelled.Controls.Add(lblCancelledTitle)
        pnlCardCancelled.Location = New Point(540, 15)
        pnlCardCancelled.Name = "pnlCardCancelled"
        pnlCardCancelled.Size = New Size(160, 70)
        pnlCardCancelled.TabIndex = 3
        ' 
        ' lblCancelledCount
        ' 
        lblCancelledCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCancelledCount.ForeColor = Color.FromArgb(CByte(163), CByte(45), CByte(45))
        lblCancelledCount.Location = New Point(10, 30)
        lblCancelledCount.Name = "lblCancelledCount"
        lblCancelledCount.Size = New Size(140, 32)
        lblCancelledCount.TabIndex = 1
        lblCancelledCount.Text = "0"
        ' 
        ' pnlRentalHistorySearch
        ' 
        pnlRentalHistorySearch.Controls.Add(btnCloseRentalHistory)
        pnlRentalHistorySearch.Controls.Add(btnRefreshRentalHistory)
        pnlRentalHistorySearch.Controls.Add(txtRentalHistorySearch)
        pnlRentalHistorySearch.Dock = DockStyle.Top
        pnlRentalHistorySearch.Location = New Point(0, 160)
        pnlRentalHistorySearch.Name = "pnlRentalHistorySearch"
        pnlRentalHistorySearch.Padding = New Padding(12, 0, 12, 0)
        pnlRentalHistorySearch.Size = New Size(800, 48)
        pnlRentalHistorySearch.TabIndex = 2
        ' 
        ' txtRentalHistorySearch
        ' 
        txtRentalHistorySearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtRentalHistorySearch.Location = New Point(12, 8)
        txtRentalHistorySearch.Name = "txtRentalHistorySearch"
        txtRentalHistorySearch.Size = New Size(350, 25)
        txtRentalHistorySearch.TabIndex = 0
        txtRentalHistorySearch.Text = "Search by Customer, Vehicle, or Status..."
        ' 
        ' btnRefreshRentalHistory
        ' 
        btnRefreshRentalHistory.Cursor = Cursors.Hand
        btnRefreshRentalHistory.FlatStyle = FlatStyle.Flat
        btnRefreshRentalHistory.Location = New Point(370, 5)
        btnRefreshRentalHistory.Name = "btnRefreshRentalHistory"
        btnRefreshRentalHistory.Size = New Size(100, 35)
        btnRefreshRentalHistory.TabIndex = 1
        btnRefreshRentalHistory.Text = "🔄 Refresh"
        btnRefreshRentalHistory.UseVisualStyleBackColor = True
        ' 
        ' btnCloseRentalHistory
        ' 
        btnCloseRentalHistory.BackColor = Color.DarkRed
        btnCloseRentalHistory.Cursor = Cursors.Hand
        btnCloseRentalHistory.FlatStyle = FlatStyle.Flat
        btnCloseRentalHistory.ForeColor = Color.White
        btnCloseRentalHistory.Location = New Point(478, 5)
        btnCloseRentalHistory.Name = "btnCloseRentalHistory"
        btnCloseRentalHistory.Size = New Size(80, 35)
        btnCloseRentalHistory.TabIndex = 2
        btnCloseRentalHistory.Text = "🚪 Close"
        btnCloseRentalHistory.UseVisualStyleBackColor = False
        ' 
        ' pnlRentalHistoryGrid
        ' 
        pnlRentalHistoryGrid.Controls.Add(dgvRentalHistory)
        pnlRentalHistoryGrid.Dock = DockStyle.Fill
        pnlRentalHistoryGrid.Location = New Point(0, 208)
        pnlRentalHistoryGrid.Name = "pnlRentalHistoryGrid"
        pnlRentalHistoryGrid.Padding = New Padding(12, 8, 12, 12)
        pnlRentalHistoryGrid.Size = New Size(800, 302)
        pnlRentalHistoryGrid.TabIndex = 3
        ' 
        ' dgvRentalHistory
        ' 
        dgvRentalHistory.AllowUserToAddRows = False
        dgvRentalHistory.AllowUserToDeleteRows = False
        dgvRentalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRentalHistory.BackgroundColor = Color.White
        dgvRentalHistory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRentalHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRentalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvRentalHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvRentalHistory.Dock = DockStyle.Fill
        dgvRentalHistory.Location = New Point(12, 8)
        dgvRentalHistory.Name = "dgvRentalHistory"
        dgvRentalHistory.ReadOnly = True
        dgvRentalHistory.RowHeadersVisible = False
        dgvRentalHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRentalHistory.Size = New Size(776, 282)
        dgvRentalHistory.TabIndex = 0
        ' 
        ' frmRentalHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 510)
        Controls.Add(pnlRentalHistoryGrid)
        Controls.Add(pnlRentalHistorySearch)
        Controls.Add(pnlRentalHistoryStats)
        Controls.Add(pnlRentalHistoryHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmRentalHistory"
        Text = "Rental History"
        WindowState = FormWindowState.Maximized
        pnlRentalHistoryHeader.ResumeLayout(False)
        pnlRentalHistoryHeader.PerformLayout()
        pnlRentalHistoryStats.ResumeLayout(False)
        pnlCardTotalRentals.ResumeLayout(False)
        pnlCardReturned.ResumeLayout(False)
        pnlCardActive.ResumeLayout(False)
        pnlCardCancelled.ResumeLayout(False)
        pnlRentalHistorySearch.ResumeLayout(False)
        pnlRentalHistorySearch.PerformLayout()
        pnlRentalHistoryGrid.ResumeLayout(False)
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlRentalHistoryHeader As Panel
    Friend WithEvents lblRentalHistoryTitle As Label
    Friend WithEvents pnlRentalHistoryStats As Panel
    Friend WithEvents pnlCardTotalRentals As Panel
    Friend WithEvents lblTotalRentalsCount As Label
    Friend WithEvents lblTotalRentalsTitle As Label
    Friend WithEvents pnlCardReturned As Panel
    Friend WithEvents lblReturnedCount As Label
    Friend WithEvents lblReturnedTitle As Label
    Friend WithEvents pnlCardActive As Panel
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents lblActiveTitle As Label
    Friend WithEvents pnlCardCancelled As Panel
    Friend WithEvents lblCancelledCount As Label
    Friend WithEvents lblCancelledTitle As Label
    Friend WithEvents pnlRentalHistorySearch As Panel
    Friend WithEvents txtRentalHistorySearch As TextBox
    Friend WithEvents btnRefreshRentalHistory As Button
    Friend WithEvents btnCloseRentalHistory As Button
    Friend WithEvents pnlRentalHistoryGrid As Panel
    Friend WithEvents dgvRentalHistory As DataGridView
End Class
