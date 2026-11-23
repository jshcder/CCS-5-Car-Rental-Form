Imports MySql.Data.MySqlClient
Public Class frmPaymentHistory
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"

    Private Sub SetPlaceholder(tb As TextBox, placeholder As String)
        If tb.Text = "" Then
            tb.Text = placeholder
            tb.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ClearPlaceholder(tb As TextBox, placeholder As String)
        If tb.Text = placeholder Then
            tb.Text = ""
            tb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPaymentHistorySearch_Enter(sender As Object, e As EventArgs) Handles txtPaymentHistorySearch.Enter
        ClearPlaceholder(txtPaymentHistorySearch, "Search by Receipt No, Method, or Status...")
    End Sub

    Private Sub txtPaymentHistorySearch_Leave(sender As Object, e As EventArgs) Handles txtPaymentHistorySearch.Leave
        SetPlaceholder(txtPaymentHistorySearch, "Search by Receipt No, Method, or Status...")
    End Sub

    Private Sub LoadPaymentHistory()
        Try
            dgvPaymentHistory.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim query As String = "SELECT p.RentalID, p.PaymentNo, " &
                                  "p.PaymentDate, p.AmountPaid, p.ReceiptNo, " &
                                  "p.PaymentMethod, p.PaymentStatus, " &
                                  "p.EmployeeID, " &
                                  "CONCAT(e.EFirstName, ' ', e.ELastName) AS Clerk " &
                                  "FROM payment p " &
                                  "JOIN employee e ON p.EmployeeID = e.EmployeeID " &
                                  "ORDER BY p.RentalID DESC"

            Dim da As New MySqlDataAdapter(query, MyConnection)
            Dim ds As New DataSet()
            da.Fill(ds, "payment")

            dgvPaymentHistory.DataSource = ds.Tables("payment")

            If dgvPaymentHistory.Columns.Count = 0 Then Exit Sub

            If dgvPaymentHistory.Columns.Contains("RentalID") Then
                dgvPaymentHistory.Columns("RentalID").HeaderText = "Rental ID"
            End If

            If dgvPaymentHistory.Columns.Contains("PaymentNo") Then
                dgvPaymentHistory.Columns("PaymentNo").HeaderText = "Payment No"
            End If

            If dgvPaymentHistory.Columns.Contains("PaymentDate") Then
                dgvPaymentHistory.Columns("PaymentDate").HeaderText = "Payment Date"
            End If

            If dgvPaymentHistory.Columns.Contains("AmountPaid") Then
                dgvPaymentHistory.Columns("AmountPaid").HeaderText = "Amount Paid"
            End If

            If dgvPaymentHistory.Columns.Contains("ReceiptNo") Then
                dgvPaymentHistory.Columns("ReceiptNo").HeaderText = "Receipt No"
            End If

            If dgvPaymentHistory.Columns.Contains("PaymentMethod") Then
                dgvPaymentHistory.Columns("PaymentMethod").HeaderText = "Payment Method"
            End If

            If dgvPaymentHistory.Columns.Contains("PaymentStatus") Then
                dgvPaymentHistory.Columns("PaymentStatus").HeaderText = "Payment Status"
            End If

            If dgvPaymentHistory.Columns.Contains("EmployeeID") Then
                dgvPaymentHistory.Columns("EmployeeID").Visible = False
            End If

            If dgvPaymentHistory.Columns.Contains("ClerkName") Then
                dgvPaymentHistory.Columns("ClerkName").HeaderText = "Clerk"
            End If

            dgvPaymentHistory.AutoResizeColumns()

            LoadPaymentStats()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub LoadPaymentStats()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM payment", MyConnection)
            lblTotalPaymentsCount.Text = cmdTotal.ExecuteScalar().ToString()

            Dim cmdFull As New MySqlCommand("SELECT COUNT(*) FROM payment WHERE PaymentStatus = 'Full'", MyConnection)
            lblFullPaymentsCount.Text = cmdFull.ExecuteScalar().ToString()

            Dim cmdPartial As New MySqlCommand("SELECT COUNT(*) FROM payment WHERE PaymentStatus = 'Partial'", MyConnection)
            lblPartialPaymentsCount.Text = cmdPartial.ExecuteScalar().ToString()

            Dim cmdAmount As New MySqlCommand("SELECT SUM(AmountPaid) FROM payment", MyConnection)
            Dim totalAmount = cmdAmount.ExecuteScalar()
            lblTotalAmountValue.Text = "₱" & If(IsDBNull(totalAmount), "0.00", Convert.ToDecimal(totalAmount).ToString("N2"))

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub frmPaymentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentHistory()
        SetPlaceholder(txtPaymentHistorySearch, "Search by Receipt No, Method, or Status...")
    End Sub

    Private Sub btnRefreshPaymentHistory_Click(sender As Object, e As EventArgs) Handles btnRefreshPaymentHistory.Click
        LoadPaymentHistory()
    End Sub

    Private Sub btnClosePaymentHistory_Click(sender As Object, e As EventArgs) Handles btnClosePaymentHistory.Click
        Me.Close()
    End Sub

    Private Sub txtPaymentHistorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentHistorySearch.TextChanged
        If txtPaymentHistorySearch.Text = "" OrElse txtPaymentHistorySearch.Text = "Search by Receipt No, Method, or Status..." Then
            LoadPaymentHistory()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT p.RentalID, p.PaymentNo, " &
                                        "p.PaymentDate, p.AmountPaid, p.ReceiptNo, " &
                                        "p.PaymentMethod, p.PaymentStatus, " &
                                        "p.EmployeeID, " &
                                        "CONCAT(e.EFirstName, ' ', e.ELastName) AS Clerk " &
                                        "FROM payment p " &
                                        "JOIN employee e ON p.EmployeeID = e.EmployeeID " &
                                        "WHERE p.ReceiptNo LIKE '%" & txtPaymentHistorySearch.Text & "%' " &
                                        "OR p.PaymentMethod LIKE '%" & txtPaymentHistorySearch.Text & "%' " &
                                        "OR p.PaymentStatus LIKE '%" & txtPaymentHistorySearch.Text & "%' " &
                                        "ORDER BY p.RentalID DESC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "payment")
            dgvPaymentHistory.DataSource = searchDS.Tables("payment")
            dgvPaymentHistory.Columns(0).HeaderText = "Rental ID"
            dgvPaymentHistory.Columns(1).HeaderText = "Payment No"
            dgvPaymentHistory.Columns(2).HeaderText = "Payment Date"
            dgvPaymentHistory.Columns(3).HeaderText = "Amount Paid"
            dgvPaymentHistory.Columns(4).HeaderText = "Receipt No"
            dgvPaymentHistory.Columns(5).HeaderText = "Payment Method"
            dgvPaymentHistory.Columns(6).HeaderText = "Payment Status"
            dgvPaymentHistory.Columns(7).Visible = False
            dgvPaymentHistory.Columns(8).HeaderText = "Clerk"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class