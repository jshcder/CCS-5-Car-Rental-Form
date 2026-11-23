Imports MySql.Data.MySqlClient
Public Class frmMainMenu
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
    End Sub
    Private Sub LoadDashboard()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            'Total Vehicles
            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM vehicle", MyConnection)
            lblTotalVehiclesCount.Text = cmdTotal.ExecuteScalar().ToString()

            'Available Vehicles
            Dim cmdAvailable As New MySqlCommand("SELECT COUNT(*) FROM vehicle WHERE VStatus = 'Available'", MyConnection)
            lblAvailableCount.Text = cmdAvailable.ExecuteScalar().ToString()

            'Currently Rented
            Dim cmdRented As New MySqlCommand("SELECT COUNT(*) FROM vehicle WHERE VStatus = 'Rented'", MyConnection)
            lblRentedCount.Text = cmdRented.ExecuteScalar().ToString()

            'Under Maintenance
            Dim cmdMaintenance As New MySqlCommand("SELECT COUNT(*) FROM vehicle WHERE VStatus = 'Under Maintenance'", MyConnection)
            lblMaintenanceCount.Text = cmdMaintenance.ExecuteScalar().ToString()

            'Total Customers
            Dim cmdCustomers As New MySqlCommand("SELECT COUNT(*) FROM customer", MyConnection)
            lblCustomersCount.Text = cmdCustomers.ExecuteScalar().ToString()

            'Recent Rental Transactions - DataGridView
            Dim rentalQuery As String = "SELECT " &
                            "r.RentalID AS RentalID, " &
                            "r.DateRented AS DateRented, " &
                            "r.DateDueReturn AS DateDueReturn, " &
                            "r.RentalStatus AS RentalStatus, " &
                            "CONCAT(c.CFirstName, ' ', c.CLastName) AS Customer, " &
                            "CONCAT(v.Brand, ' ', v.Model) AS Vehicle " &
                            "FROM rental r " &
                            "JOIN customer c ON r.CustomerID = c.CustomerID " &
                            "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                            "ORDER BY r.RentalID DESC"

            Dim rentalDA As New MySqlDataAdapter(rentalQuery, MyConnection)
            Dim rentalDS As New DataSet()
            rentalDA.Fill(rentalDS, "rental")

            dgvDashboard.DataSource = rentalDS.Tables("rental")
            dgvDashboard.Font = New Font("Segoe UI", 10)
            dgvDashboard.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10)
            dgvDashboard.AutoResizeColumns()

            'Set column headers
            dgvDashboard.Columns("RentalID").HeaderText = "Rental ID"
            dgvDashboard.Columns("DateRented").HeaderText = "Date Rented"
            dgvDashboard.Columns("DateDueReturn").HeaderText = "Date Due Return"
            dgvDashboard.Columns("RentalStatus").HeaderText = "Status"
            dgvDashboard.Columns("Customer").HeaderText = "Customer"
            dgvDashboard.Columns("Vehicle").HeaderText = "Vehicle"

            MyConnection.Close()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btnCloseApp_Click(sender As Object, e As EventArgs) Handles btnCloseApp.Click
        Dim result = MsgBox("Are you sure you want to close the application?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close Application")
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ShowPanel(pnlDashboard)
        LoadDashboard()
    End Sub
    Private Sub ShowPanel(panel As Panel)
        pnlDashboard.Visible = False
        panel.Visible = True
    End Sub

    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        Dim rentalForm As New frmRentalDesign()
        rentalForm.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New frmReturnDesign()
        returnForm.Show()
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim paymentForm As New frmPaymentDesign()
        paymentForm.Show()
    End Sub
    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim customerForm As New frmCustomerDesign()
        customerForm.Show()
    End Sub
    Private Sub btnVehicle_Click(sender As Object, e As EventArgs) Handles btnVehicle.Click
        Dim vehicleForm As New frmVehicleDesign()
        vehicleForm.Show()
    End Sub
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim categoryForm As New frmCategoryDesign()
        categoryForm.Show()
    End Sub
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim employeeForm As New frmEmployeeDesign()
        employeeForm.Show()
    End Sub
    Private Sub btnRentalHistory_Click(sender As Object, e As EventArgs) Handles btnRentalHistory.Click
        Dim rentalHistoryForm As New frmRentalHistory()
        rentalHistoryForm.Show()
    End Sub
    Private Sub btnPaymentHistory_Click(sender As Object, e As EventArgs) Handles btnPaymentHistory.Click
        Dim paymentHistoryForm As New frmPaymentHistory()
        paymentHistoryForm.Show()
    End Sub
    Private Sub btnMaintenanceHistory_Click(sender As Object, e As EventArgs) Handles btnMaintenanceHistory.Click
        Dim maintenanceHistoryForm As New frmMaintenanceHistory()
        maintenanceHistoryForm.Show()
    End Sub
End Class
