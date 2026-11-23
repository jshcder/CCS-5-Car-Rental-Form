<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentHistory
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
        pnlPaymentHistoryHeader = New Panel()
        lblPaymentHistoryTitle = New Label()
        pnlPaymentHistoryStats = New Panel()
        pnlCardTotalPayments = New Panel()
        lblTotalPaymentsTitle = New Label()
        lblTotalPaymentsCount = New Label()
        pnlCardFullPayments = New Panel()
        lblFullPaymentsCount = New Label()
        lblFullPaymentsTitle = New Label()
        pnlCardPartialPayments = New Panel()
        lblPartialPaymentsCount = New Label()
        lblPartialPaymentsTitle = New Label()
        pnlCardTotalAmount = New Panel()
        lblTotalAmountValue = New Label()
        lblTotalAmountTitle = New Label()
        pnlPaymentHistorySearch = New Panel()
        txtPaymentHistorySearch = New TextBox()
        btnRefreshPaymentHistory = New Button()
        btnClosePaymentHistory = New Button()
        pnlPaymentHistoryGrid = New Panel()
        dgvPaymentHistory = New DataGridView()
        pnlPaymentHistoryHeader.SuspendLayout()
        pnlPaymentHistoryStats.SuspendLayout()
        pnlCardTotalPayments.SuspendLayout()
        pnlCardFullPayments.SuspendLayout()
        pnlCardPartialPayments.SuspendLayout()
        pnlCardTotalAmount.SuspendLayout()
        pnlPaymentHistorySearch.SuspendLayout()
        pnlPaymentHistoryGrid.SuspendLayout()
        CType(dgvPaymentHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlPaymentHistoryHeader
        ' 
        pnlPaymentHistoryHeader.BackColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        pnlPaymentHistoryHeader.Controls.Add(lblPaymentHistoryTitle)
        pnlPaymentHistoryHeader.Dock = DockStyle.Top
        pnlPaymentHistoryHeader.Location = New Point(0, 0)
        pnlPaymentHistoryHeader.Name = "pnlPaymentHistoryHeader"
        pnlPaymentHistoryHeader.Size = New Size(998, 60)
        pnlPaymentHistoryHeader.TabIndex = 0
        ' 
        ' lblPaymentHistoryTitle
        ' 
        lblPaymentHistoryTitle.AutoSize = True
        lblPaymentHistoryTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPaymentHistoryTitle.ForeColor = Color.White
        lblPaymentHistoryTitle.Location = New Point(0, 17)
        lblPaymentHistoryTitle.Name = "lblPaymentHistoryTitle"
        lblPaymentHistoryTitle.Padding = New Padding(15, 0, 0, 0)
        lblPaymentHistoryTitle.Size = New Size(176, 25)
        lblPaymentHistoryTitle.TabIndex = 0
        lblPaymentHistoryTitle.Text = "Payment History"
        lblPaymentHistoryTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlPaymentHistoryStats
        ' 
        pnlPaymentHistoryStats.Controls.Add(pnlCardTotalAmount)
        pnlPaymentHistoryStats.Controls.Add(pnlCardPartialPayments)
        pnlPaymentHistoryStats.Controls.Add(pnlCardFullPayments)
        pnlPaymentHistoryStats.Controls.Add(pnlCardTotalPayments)
        pnlPaymentHistoryStats.Dock = DockStyle.Top
        pnlPaymentHistoryStats.Location = New Point(0, 60)
        pnlPaymentHistoryStats.Name = "pnlPaymentHistoryStats"
        pnlPaymentHistoryStats.Padding = New Padding(15, 15, 15, 0)
        pnlPaymentHistoryStats.Size = New Size(998, 100)
        pnlPaymentHistoryStats.TabIndex = 1
        ' 
        ' pnlCardTotalPayments
        ' 
        pnlCardTotalPayments.Controls.Add(lblTotalPaymentsCount)
        pnlCardTotalPayments.Controls.Add(lblTotalPaymentsTitle)
        pnlCardTotalPayments.Location = New Point(15, 15)
        pnlCardTotalPayments.Name = "pnlCardTotalPayments"
        pnlCardTotalPayments.Size = New Size(160, 70)
        pnlCardTotalPayments.TabIndex = 0
        ' 
        ' lblTotalPaymentsTitle
        ' 
        lblTotalPaymentsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPaymentsTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalPaymentsTitle.Location = New Point(10, 8)
        lblTotalPaymentsTitle.Name = "lblTotalPaymentsTitle"
        lblTotalPaymentsTitle.Size = New Size(140, 20)
        lblTotalPaymentsTitle.TabIndex = 0
        lblTotalPaymentsTitle.Text = "Total Payments"
        ' 
        ' lblTotalPaymentsCount
        ' 
        lblTotalPaymentsCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPaymentsCount.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblTotalPaymentsCount.Location = New Point(10, 30)
        lblTotalPaymentsCount.Name = "lblTotalPaymentsCount"
        lblTotalPaymentsCount.Size = New Size(140, 32)
        lblTotalPaymentsCount.TabIndex = 1
        lblTotalPaymentsCount.Text = "0"
        ' 
        ' pnlCardFullPayments
        ' 
        pnlCardFullPayments.Controls.Add(lblFullPaymentsCount)
        pnlCardFullPayments.Controls.Add(lblFullPaymentsTitle)
        pnlCardFullPayments.Location = New Point(190, 15)
        pnlCardFullPayments.Name = "pnlCardFullPayments"
        pnlCardFullPayments.Size = New Size(160, 70)
        pnlCardFullPayments.TabIndex = 2
        ' 
        ' lblFullPaymentsCount
        ' 
        lblFullPaymentsCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFullPaymentsCount.ForeColor = Color.FromArgb(CByte(39), CByte(80), CByte(10))
        lblFullPaymentsCount.Location = New Point(10, 30)
        lblFullPaymentsCount.Name = "lblFullPaymentsCount"
        lblFullPaymentsCount.Size = New Size(140, 32)
        lblFullPaymentsCount.TabIndex = 1
        lblFullPaymentsCount.Text = "0"
        ' 
        ' lblFullPaymentsTitle
        ' 
        lblFullPaymentsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFullPaymentsTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblFullPaymentsTitle.Location = New Point(10, 8)
        lblFullPaymentsTitle.Name = "lblFullPaymentsTitle"
        lblFullPaymentsTitle.Size = New Size(140, 20)
        lblFullPaymentsTitle.TabIndex = 0
        lblFullPaymentsTitle.Text = "Full Payments"
        ' 
        ' pnlCardPartialPayments
        ' 
        pnlCardPartialPayments.Controls.Add(lblPartialPaymentsCount)
        pnlCardPartialPayments.Controls.Add(lblPartialPaymentsTitle)
        pnlCardPartialPayments.Location = New Point(366, 15)
        pnlCardPartialPayments.Name = "pnlCardPartialPayments"
        pnlCardPartialPayments.Size = New Size(160, 70)
        pnlCardPartialPayments.TabIndex = 3
        ' 
        ' lblPartialPaymentsCount
        ' 
        lblPartialPaymentsCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPartialPaymentsCount.ForeColor = Color.FromArgb(CByte(133), CByte(79), CByte(11))
        lblPartialPaymentsCount.Location = New Point(10, 30)
        lblPartialPaymentsCount.Name = "lblPartialPaymentsCount"
        lblPartialPaymentsCount.Size = New Size(140, 32)
        lblPartialPaymentsCount.TabIndex = 1
        lblPartialPaymentsCount.Text = "0"
        ' 
        ' lblPartialPaymentsTitle
        ' 
        lblPartialPaymentsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPartialPaymentsTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblPartialPaymentsTitle.Location = New Point(10, 8)
        lblPartialPaymentsTitle.Name = "lblPartialPaymentsTitle"
        lblPartialPaymentsTitle.Size = New Size(140, 20)
        lblPartialPaymentsTitle.TabIndex = 0
        lblPartialPaymentsTitle.Text = "Partial Payments"
        ' 
        ' pnlCardTotalAmount
        ' 
        pnlCardTotalAmount.Controls.Add(lblTotalAmountValue)
        pnlCardTotalAmount.Controls.Add(lblTotalAmountTitle)
        pnlCardTotalAmount.Location = New Point(540, 15)
        pnlCardTotalAmount.Name = "pnlCardTotalAmount"
        pnlCardTotalAmount.Size = New Size(200, 70)
        pnlCardTotalAmount.TabIndex = 4
        ' 
        ' lblTotalAmountValue
        ' 
        lblTotalAmountValue.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAmountValue.ForeColor = Color.FromArgb(CByte(46), CByte(84), CByte(150))
        lblTotalAmountValue.Location = New Point(10, 30)
        lblTotalAmountValue.Name = "lblTotalAmountValue"
        lblTotalAmountValue.Size = New Size(180, 32)
        lblTotalAmountValue.TabIndex = 1
        lblTotalAmountValue.Text = "0.00"
        ' 
        ' lblTotalAmountTitle
        ' 
        lblTotalAmountTitle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalAmountTitle.ForeColor = Color.FromArgb(CByte(102), CByte(102), CByte(102))
        lblTotalAmountTitle.Location = New Point(10, 8)
        lblTotalAmountTitle.Name = "lblTotalAmountTitle"
        lblTotalAmountTitle.Size = New Size(180, 20)
        lblTotalAmountTitle.TabIndex = 0
        lblTotalAmountTitle.Text = "Total Collected"
        ' 
        ' pnlPaymentHistorySearch
        ' 
        pnlPaymentHistorySearch.Controls.Add(btnClosePaymentHistory)
        pnlPaymentHistorySearch.Controls.Add(btnRefreshPaymentHistory)
        pnlPaymentHistorySearch.Controls.Add(txtPaymentHistorySearch)
        pnlPaymentHistorySearch.Dock = DockStyle.Top
        pnlPaymentHistorySearch.Location = New Point(0, 160)
        pnlPaymentHistorySearch.Name = "pnlPaymentHistorySearch"
        pnlPaymentHistorySearch.Padding = New Padding(12, 0, 12, 0)
        pnlPaymentHistorySearch.Size = New Size(998, 48)
        pnlPaymentHistorySearch.TabIndex = 2
        ' 
        ' txtPaymentHistorySearch
        ' 
        txtPaymentHistorySearch.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtPaymentHistorySearch.Location = New Point(12, 8)
        txtPaymentHistorySearch.Name = "txtPaymentHistorySearch"
        txtPaymentHistorySearch.Size = New Size(350, 25)
        txtPaymentHistorySearch.TabIndex = 0
        txtPaymentHistorySearch.Text = "Search by Receipt No, Method, or Status..."
        ' 
        ' btnRefreshPaymentHistory
        ' 
        btnRefreshPaymentHistory.Cursor = Cursors.Hand
        btnRefreshPaymentHistory.FlatStyle = FlatStyle.Flat
        btnRefreshPaymentHistory.Location = New Point(370, 5)
        btnRefreshPaymentHistory.Name = "btnRefreshPaymentHistory"
        btnRefreshPaymentHistory.Size = New Size(100, 35)
        btnRefreshPaymentHistory.TabIndex = 1
        btnRefreshPaymentHistory.Text = "🔄 Refresh"
        btnRefreshPaymentHistory.UseVisualStyleBackColor = True
        ' 
        ' btnClosePaymentHistory
        ' 
        btnClosePaymentHistory.BackColor = Color.DarkRed
        btnClosePaymentHistory.Cursor = Cursors.Hand
        btnClosePaymentHistory.FlatStyle = FlatStyle.Flat
        btnClosePaymentHistory.ForeColor = Color.White
        btnClosePaymentHistory.Location = New Point(478, 5)
        btnClosePaymentHistory.Name = "btnClosePaymentHistory"
        btnClosePaymentHistory.Size = New Size(80, 35)
        btnClosePaymentHistory.TabIndex = 2
        btnClosePaymentHistory.Text = "🚪 Close"
        btnClosePaymentHistory.UseVisualStyleBackColor = False
        ' 
        ' pnlPaymentHistoryGrid
        ' 
        pnlPaymentHistoryGrid.Controls.Add(dgvPaymentHistory)
        pnlPaymentHistoryGrid.Dock = DockStyle.Fill
        pnlPaymentHistoryGrid.Location = New Point(0, 208)
        pnlPaymentHistoryGrid.Name = "pnlPaymentHistoryGrid"
        pnlPaymentHistoryGrid.Padding = New Padding(12, 8, 12, 12)
        pnlPaymentHistoryGrid.Size = New Size(998, 353)
        pnlPaymentHistoryGrid.TabIndex = 3
        ' 
        ' dgvPaymentHistory
        ' 
        dgvPaymentHistory.AllowUserToAddRows = False
        dgvPaymentHistory.AllowUserToDeleteRows = False
        dgvPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPaymentHistory.BackgroundColor = Color.White
        dgvPaymentHistory.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPaymentHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPaymentHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvPaymentHistory.Dock = DockStyle.Fill
        dgvPaymentHistory.Location = New Point(12, 8)
        dgvPaymentHistory.Name = "dgvPaymentHistory"
        dgvPaymentHistory.ReadOnly = True
        dgvPaymentHistory.RowHeadersVisible = False
        dgvPaymentHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPaymentHistory.Size = New Size(974, 333)
        dgvPaymentHistory.TabIndex = 0
        ' 
        ' frmPaymentHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(998, 561)
        Controls.Add(pnlPaymentHistoryGrid)
        Controls.Add(pnlPaymentHistorySearch)
        Controls.Add(pnlPaymentHistoryStats)
        Controls.Add(pnlPaymentHistoryHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmPaymentHistory"
        Text = "Payment History"
        WindowState = FormWindowState.Maximized
        pnlPaymentHistoryHeader.ResumeLayout(False)
        pnlPaymentHistoryHeader.PerformLayout()
        pnlPaymentHistoryStats.ResumeLayout(False)
        pnlCardTotalPayments.ResumeLayout(False)
        pnlCardFullPayments.ResumeLayout(False)
        pnlCardPartialPayments.ResumeLayout(False)
        pnlCardTotalAmount.ResumeLayout(False)
        pnlPaymentHistorySearch.ResumeLayout(False)
        pnlPaymentHistorySearch.PerformLayout()
        pnlPaymentHistoryGrid.ResumeLayout(False)
        CType(dgvPaymentHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlPaymentHistoryHeader As Panel
    Friend WithEvents lblPaymentHistoryTitle As Label
    Friend WithEvents pnlPaymentHistoryStats As Panel
    Friend WithEvents pnlCardTotalPayments As Panel
    Friend WithEvents lblTotalPaymentsTitle As Label
    Friend WithEvents lblTotalPaymentsCount As Label
    Friend WithEvents pnlCardFullPayments As Panel
    Friend WithEvents lblFullPaymentsCount As Label
    Friend WithEvents lblFullPaymentsTitle As Label
    Friend WithEvents pnlCardPartialPayments As Panel
    Friend WithEvents lblPartialPaymentsCount As Label
    Friend WithEvents lblPartialPaymentsTitle As Label
    Friend WithEvents pnlCardTotalAmount As Panel
    Friend WithEvents lblTotalAmountValue As Label
    Friend WithEvents lblTotalAmountTitle As Label
    Friend WithEvents pnlPaymentHistorySearch As Panel
    Friend WithEvents txtPaymentHistorySearch As TextBox
    Friend WithEvents btnRefreshPaymentHistory As Button
    Friend WithEvents btnClosePaymentHistory As Button
    Friend WithEvents pnlPaymentHistoryGrid As Panel
    Friend WithEvents dgvPaymentHistory As DataGridView
End Class
