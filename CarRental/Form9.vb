Imports MySql.Data.MySqlClient
Public Class frmRentalHistory
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

    Private Sub txtRentalHistorySearch_Enter(sender As Object, e As EventArgs) Handles txtRentalHistorySearch.Enter
        ClearPlaceholder(txtRentalHistorySearch, "Search by Customer, Vehicle, or Status...")
    End Sub

    Private Sub txtRentalHistorySearch_Leave(sender As Object, e As EventArgs) Handles txtRentalHistorySearch.Leave
        SetPlaceholder(txtRentalHistorySearch, "Search by Customer, Vehicle, or Status...")
    End Sub

    Private Sub LoadRentalHistory()
        Try
            dgvRentalHistory.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim query As String = "SELECT r.RentalID, r.DateRented, r.DateDueReturn, " &
                                  "r.RentalStatus, r.CustomerID, " &
                                  "CONCAT(c.CFirstName, ' ', c.CLastName) AS Customer, " &
                                  "r.VehicleID, " &
                                  "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                                  "r.EmployeeID, " &
                                  "CONCAT(e.EFirstName, ' ', e.ELastName) AS Clerk " &
                                  "FROM rental r " &
                                  "JOIN customer c ON r.CustomerID = c.CustomerID " &
                                  "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                                  "JOIN employee e ON r.EmployeeID = e.EmployeeID " &
                                  "ORDER BY r.RentalID DESC"

            Dim da As New MySqlDataAdapter(query, MyConnection)
            Dim ds As New DataSet()
            da.Fill(ds, "rental")

            dgvRentalHistory.DataSource = ds.Tables("rental")

            If dgvRentalHistory.Columns.Count = 0 Then Exit Sub

            If dgvRentalHistory.Columns.Contains("RentalID") Then
                dgvRentalHistory.Columns("RentalID").HeaderText = "Rental ID"
            End If

            If dgvRentalHistory.Columns.Contains("DateRented") Then
                dgvRentalHistory.Columns("DateRented").HeaderText = "Date Rented"
            End If

            If dgvRentalHistory.Columns.Contains("DateDueReturn") Then
                dgvRentalHistory.Columns("DateDueReturn").HeaderText = "Date Due Return"
            End If

            If dgvRentalHistory.Columns.Contains("RentalStatus") Then
                dgvRentalHistory.Columns("RentalStatus").HeaderText = "Status"
            End If

            If dgvRentalHistory.Columns.Contains("CustomerID") Then
                dgvRentalHistory.Columns("CustomerID").Visible = False
            End If

            If dgvRentalHistory.Columns.Contains("Customer") Then
                dgvRentalHistory.Columns("Customer").HeaderText = "Customer"
            End If

            If dgvRentalHistory.Columns.Contains("VehicleID") Then
                dgvRentalHistory.Columns("VehicleID").Visible = False
            End If

            If dgvRentalHistory.Columns.Contains("Vehicle") Then
                dgvRentalHistory.Columns("Vehicle").HeaderText = "Vehicle"
            End If

            If dgvRentalHistory.Columns.Contains("EmployeeID") Then
                dgvRentalHistory.Columns("EmployeeID").Visible = False
            End If

            If dgvRentalHistory.Columns.Contains("ClerkName") Then
                dgvRentalHistory.Columns("ClerkName").HeaderText = "Clerk"
            End If

            dgvRentalHistory.AutoResizeColumns()

            LoadRentalStats()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub LoadRentalStats()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM rental", MyConnection)
            lblTotalRentalsCount.Text = cmdTotal.ExecuteScalar().ToString()

            Dim cmdReturned As New MySqlCommand("SELECT COUNT(*) FROM rental WHERE RentalStatus = 'Returned'", MyConnection)
            lblReturnedCount.Text = cmdReturned.ExecuteScalar().ToString()

            Dim cmdActive As New MySqlCommand("SELECT COUNT(*) FROM rental WHERE RentalStatus = 'Active'", MyConnection)
            lblActiveCount.Text = cmdActive.ExecuteScalar().ToString()

            Dim cmdCancelled As New MySqlCommand("SELECT COUNT(*) FROM rental WHERE RentalStatus = 'Cancelled'", MyConnection)
            lblCancelledCount.Text = cmdCancelled.ExecuteScalar().ToString()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub frmRentalHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentalHistory()
        SetPlaceholder(txtRentalHistorySearch, "Search by Customer, Vehicle, or Status...")
    End Sub

    Private Sub btnRefreshRentalHistory_Click(sender As Object, e As EventArgs) Handles btnRefreshRentalHistory.Click
        LoadRentalHistory()
    End Sub

    Private Sub btnCloseRentalHistory_Click(sender As Object, e As EventArgs) Handles btnCloseRentalHistory.Click
        Me.Close()
    End Sub

    Private Sub txtRentalHistorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtRentalHistorySearch.TextChanged
        If txtRentalHistorySearch.Text = "" OrElse txtRentalHistorySearch.Text = "Search by Customer, Vehicle, or Status..." Then
            LoadRentalHistory()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT r.RentalID, r.DateRented, r.DateDueReturn, " &
                                        "r.RentalStatus, r.CustomerID, " &
                                        "CONCAT(c.CFirstName, ' ', c.CLastName) AS Customer, " &
                                        "r.VehicleID, " &
                                        "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                                        "r.EmployeeID, " &
                                        "CONCAT(e.EFirstName, ' ', e.ELastName) AS Clerk " &
                                        "FROM rental r " &
                                        "JOIN customer c ON r.CustomerID = c.CustomerID " &
                                        "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                                        "JOIN employee e ON r.EmployeeID = e.EmployeeID " &
                                        "WHERE CONCAT(c.CFirstName, ' ', c.CLastName) LIKE '%" & txtRentalHistorySearch.Text & "%' " &
                                        "OR CONCAT(v.Brand, ' ', v.Model) LIKE '%" & txtRentalHistorySearch.Text & "%' " &
                                        "OR r.RentalStatus LIKE '%" & txtRentalHistorySearch.Text & "%' " &
                                        "ORDER BY r.RentalID DESC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "rental")
            dgvRentalHistory.DataSource = searchDS.Tables("rental")
            dgvRentalHistory.Columns(0).HeaderText = "Rental ID"
            dgvRentalHistory.Columns(1).HeaderText = "Date Rented"
            dgvRentalHistory.Columns(2).HeaderText = "Date Due Return"
            dgvRentalHistory.Columns(3).HeaderText = "Status"
            dgvRentalHistory.Columns(4).Visible = False
            dgvRentalHistory.Columns(5).HeaderText = "Customer"
            dgvRentalHistory.Columns(6).Visible = False
            dgvRentalHistory.Columns(7).HeaderText = "Vehicle"
            dgvRentalHistory.Columns(8).Visible = False
            dgvRentalHistory.Columns(9).HeaderText = "Clerk"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class