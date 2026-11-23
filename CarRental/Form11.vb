Imports MySql.Data.MySqlClient
Public Class frmMaintenanceHistory
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

    Private Sub txtMaintenanceHistorySearch_Enter(sender As Object, e As EventArgs) Handles txtMaintenanceHistorySearch.Enter
        ClearPlaceholder(txtMaintenanceHistorySearch, "Search by Vehicle, Type, or Technician...")
    End Sub

    Private Sub txtMaintenanceHistorySearch_Leave(sender As Object, e As EventArgs) Handles txtMaintenanceHistorySearch.Leave
        SetPlaceholder(txtMaintenanceHistorySearch, "Search by Vehicle, Type, or Technician...")
    End Sub

    Private Sub LoadMaintenanceHistory()
        Try
            dgvMaintenanceHistory.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim query As String = "SELECT m.MaintenanceID, m.MaintenanceDate, " &
                                  "m.MaintenanceType, m.Description, m.Cost, " &
                                  "m.MileageAtService, m.VehicleID, " &
                                  "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                                  "v.PlateNo, m.EmployeeID, " &
                                  "CONCAT(e.EFirstName, ' ', e.ELastName) AS Technician " &
                                  "FROM maintenance m " &
                                  "JOIN vehicle v ON m.VehicleID = v.VehicleID " &
                                  "JOIN employee e ON m.EmployeeID = e.EmployeeID " &
                                  "ORDER BY m.MaintenanceID DESC"

            Dim da As New MySqlDataAdapter(query, MyConnection)
            Dim ds As New DataSet()
            da.Fill(ds, "maintenance")

            dgvMaintenanceHistory.DataSource = ds.Tables("maintenance")

            If dgvMaintenanceHistory.Columns.Count = 0 Then Exit Sub

            If dgvMaintenanceHistory.Columns.Contains("MaintenanceID") Then
                dgvMaintenanceHistory.Columns("MaintenanceID").HeaderText = "Maintenance ID"
            End If

            If dgvMaintenanceHistory.Columns.Contains("MaintenanceDate") Then
                dgvMaintenanceHistory.Columns("MaintenanceDate").HeaderText = "Date"
            End If

            If dgvMaintenanceHistory.Columns.Contains("MaintenanceType") Then
                dgvMaintenanceHistory.Columns("MaintenanceType").HeaderText = "Type"
            End If

            If dgvMaintenanceHistory.Columns.Contains("Description") Then
                dgvMaintenanceHistory.Columns("Description").HeaderText = "Description"
            End If

            If dgvMaintenanceHistory.Columns.Contains("Cost") Then
                dgvMaintenanceHistory.Columns("Cost").HeaderText = "Cost"
            End If

            If dgvMaintenanceHistory.Columns.Contains("MileageAtService") Then
                dgvMaintenanceHistory.Columns("MileageAtService").HeaderText = "Mileage At Service"
            End If

            If dgvMaintenanceHistory.Columns.Contains("VehicleID") Then
                dgvMaintenanceHistory.Columns("VehicleID").Visible = False
            End If

            If dgvMaintenanceHistory.Columns.Contains("Vehicle") Then
                dgvMaintenanceHistory.Columns("Vehicle").HeaderText = "Vehicle"
            End If

            If dgvMaintenanceHistory.Columns.Contains("PlateNo") Then
                dgvMaintenanceHistory.Columns("PlateNo").HeaderText = "Plate No"
            End If

            If dgvMaintenanceHistory.Columns.Contains("EmployeeID") Then
                dgvMaintenanceHistory.Columns("EmployeeID").Visible = False
            End If

            If dgvMaintenanceHistory.Columns.Contains("TechnicianName") Then
                dgvMaintenanceHistory.Columns("TechnicianName").HeaderText = "Technician"
            End If

            dgvMaintenanceHistory.AutoResizeColumns()

            LoadMaintenanceStats()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub LoadMaintenanceStats()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM maintenance", MyConnection)
            lblTotalServicesCount.Text = cmdTotal.ExecuteScalar().ToString()

            Dim cmdOil As New MySqlCommand("SELECT COUNT(*) FROM maintenance WHERE MaintenanceType = 'Oil Change'", MyConnection)
            lblOilChangeCount.Text = cmdOil.ExecuteScalar().ToString()

            Dim cmdTire As New MySqlCommand("SELECT COUNT(*) FROM maintenance WHERE MaintenanceType = 'Tire Rotation'", MyConnection)
            lblTireRotationCount.Text = cmdTire.ExecuteScalar().ToString()

            Dim cmdCost As New MySqlCommand("SELECT SUM(Cost) FROM maintenance", MyConnection)
            Dim totalCost = cmdCost.ExecuteScalar()
            lblTotalCostValue.Text = "₱" & If(IsDBNull(totalCost), "0.00", Convert.ToDecimal(totalCost).ToString("N2"))

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub frmMaintenanceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaintenanceHistory()
        SetPlaceholder(txtMaintenanceHistorySearch, "Search by Vehicle, Type, or Technician...")
    End Sub

    Private Sub btnRefreshMaintenanceHistory_Click(sender As Object, e As EventArgs) Handles btnRefreshMaintenanceHistory.Click
        LoadMaintenanceHistory()
    End Sub

    Private Sub btnCloseMaintenanceHistory_Click(sender As Object, e As EventArgs) Handles btnCloseMaintenanceHistory.Click
        Me.Close()
    End Sub

    Private Sub txtMaintenanceHistorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtMaintenanceHistorySearch.TextChanged
        If txtMaintenanceHistorySearch.Text = "" OrElse txtMaintenanceHistorySearch.Text = "Search by Vehicle, Type, or Technician..." Then
            LoadMaintenanceHistory()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT m.MaintenanceID, m.MaintenanceDate, " &
                                        "m.MaintenanceType, m.Description, m.Cost, " &
                                        "m.MileageAtService, m.VehicleID, " &
                                        "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                                        "v.PlateNo, m.EmployeeID, " &
                                        "CONCAT(e.EFirstName, ' ', e.ELastName) AS Technician " &
                                        "FROM maintenance m " &
                                        "JOIN vehicle v ON m.VehicleID = v.VehicleID " &
                                        "JOIN employee e ON m.EmployeeID = e.EmployeeID " &
                                        "WHERE CONCAT(v.Brand, ' ', v.Model) LIKE '%" & txtMaintenanceHistorySearch.Text & "%' " &
                                        "OR v.PlateNo LIKE '%" & txtMaintenanceHistorySearch.Text & "%' " &
                                        "OR m.MaintenanceType LIKE '%" & txtMaintenanceHistorySearch.Text & "%' " &
                                        "OR CONCAT(e.EFirstName, ' ', e.ELastName) LIKE '%" & txtMaintenanceHistorySearch.Text & "%' " &
                                        "ORDER BY m.MaintenanceID DESC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "maintenance")
            dgvMaintenanceHistory.DataSource = searchDS.Tables("maintenance")
            dgvMaintenanceHistory.Columns(0).HeaderText = "Maintenance ID"
            dgvMaintenanceHistory.Columns(1).HeaderText = "Date"
            dgvMaintenanceHistory.Columns(2).HeaderText = "Type"
            dgvMaintenanceHistory.Columns(3).HeaderText = "Description"
            dgvMaintenanceHistory.Columns(4).HeaderText = "Cost"
            dgvMaintenanceHistory.Columns(5).HeaderText = "Mileage At Service"
            dgvMaintenanceHistory.Columns(6).Visible = False
            dgvMaintenanceHistory.Columns(7).HeaderText = "Vehicle"
            dgvMaintenanceHistory.Columns(8).HeaderText = "Plate No"
            dgvMaintenanceHistory.Columns(9).Visible = False
            dgvMaintenanceHistory.Columns(10).HeaderText = "Technician"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class