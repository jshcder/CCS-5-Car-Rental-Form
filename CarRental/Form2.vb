Imports MySql.Data.MySqlClient
Public Class frmRentalDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim rentalDA As New MySqlDataAdapter
    Dim rentalDS As New DataSet()
    Dim rentalSQLQuery As String
    Dim row As Integer
    Private Sub LoadRentalData()
        Try
            dgvRental.DataSource = Nothing

            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            rentalSQLQuery = "SELECT r.RentalID, " &
                 "r.DateRented, r.DateDueReturn, r.RentalStatus, " &
                 "r.CustomerID, CONCAT(c.CFirstName, ' ', c.CLastName) AS CustomerName, " &
                 "r.VehicleID, CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                 "r.EmployeeID, CONCAT(e.EFirstName, ' ', e.ELastName) AS ClerkName " &
                 "FROM rental r " &
                 "JOIN customer c ON r.CustomerID = c.CustomerID " &
                 "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                 "JOIN employee e ON r.EmployeeID = e.EmployeeID " &
                 "ORDER BY r.RentalID DESC"

            rentalDA = New MySqlDataAdapter(rentalSQLQuery, MyConnection)
            rentalDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(rentalDA)
            rentalDA.Fill(rentalDS, "rental")

            dgvRental.DataSource = rentalDS.Tables("rental")

            dgvRental.Columns(0).HeaderText = "Rental ID"
            dgvRental.Columns(1).HeaderText = "Date Rented"
            dgvRental.Columns(2).HeaderText = "Date Due Return"
            dgvRental.Columns(3).HeaderText = "Status"
            dgvRental.Columns(4).Visible = False  'CustomerID hidden
            dgvRental.Columns(5).HeaderText = "Customer"
            dgvRental.Columns(6).Visible = False  'VehicleID hidden
            dgvRental.Columns(7).HeaderText = "Vehicle"
            dgvRental.Columns(8).Visible = False  'EmployeeID hidden
            dgvRental.Columns(9).HeaderText = "Clerk"
            dgvRental.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub frmRentalDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentalData()
        btnUpdateRental.Enabled = False
        btnDeleteRental.Enabled = False
        txtRentalSearch.Text = "Search by Customer, Vehicle, or Status..."
        txtRentalSearch.ForeColor = Color.Gray
    End Sub
    Private Sub txtCustomerID_Leave(sender As Object, e As EventArgs) Handles txtCustomerID.Leave
        If txtCustomerID.Text = "" Then
            txtCustomerName.Text = ""
            txtCustomerInfo.Text = ""
            Exit Sub
        End If
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand("SELECT CFirstName, CLastName, CContactNo, CEmail, CStreet, CCity, CState FROM customer WHERE CustomerID = " & txtCustomerID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtCustomerName.Text = reader("CFirstName").ToString & " " & reader("CLastName").ToString
                txtCustomerInfo.Text = "Name: " & reader("CFirstName").ToString & " " & reader("CLastName").ToString & vbNewLine &
                                       "Contact: " & reader("CContactNo").ToString & vbNewLine &
                                       "Email: " & reader("CEmail").ToString & vbNewLine &
                                       "Address: " & reader("CStreet").ToString & ", " & reader("CCity").ToString & ", " & reader("CState").ToString
            Else
                txtCustomerName.Text = "Not found"
                txtCustomerInfo.Text = ""
                MsgBox("Customer ID not found.", MsgBoxStyle.Exclamation, "Customer Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub txtVehicleID_Leave(sender As Object, e As EventArgs) Handles txtVehicleID.Leave
        If txtVehicleID.Text = "" Then
            txtPlateNo.Text = ""
            txtBrandModel.Text = ""
            txtVehicleInfo.Text = ""
            Exit Sub
        End If

        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM vehicle WHERE VehicleID = @id", MyConnection)
            cmd.Parameters.AddWithValue("@id", txtVehicleID.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtPlateNo.Text = reader("PlateNo").ToString
                txtBrandModel.Text = reader("Brand").ToString & " " & reader("Model").ToString

                txtVehicleInfo.Text =
                "Vehicle ID: " & reader("VehicleID").ToString & vbNewLine &
                "Brand: " & reader("Brand").ToString & vbNewLine &
                "Model: " & reader("Model").ToString & vbNewLine &
                "Year: " & reader("Year").ToString & vbNewLine &
                "Color: " & reader("Color").ToString & vbNewLine &
                "Fuel Type: " & reader("FuelType").ToString & vbNewLine &
                "Transmission: " & reader("Transmission").ToString & vbNewLine &
                "Mileage: " & reader("CurrentMileage").ToString & vbNewLine &
                "Plate No: " & reader("PlateNo").ToString & vbNewLine &
                "Status: " & reader("VStatus").ToString & vbNewLine &
                "Category ID: " & reader("CategoryID").ToString

                If reader("VStatus").ToString <> "Available" Then
                    MsgBox("Warning: This vehicle is currently " & reader("VStatus").ToString & " and may not be available for rental.", MsgBoxStyle.Exclamation, "Vehicle Status")
                End If

            Else
                txtPlateNo.Text = ""
                txtBrandModel.Text = ""
                txtVehicleInfo.Text = ""
                MsgBox("Vehicle ID not found.", MsgBoxStyle.Exclamation, "Vehicle Lookup")
            End If

            reader.Close()

        Catch ex As MySqlException
            MsgBox(ex.ToString)

        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub txtRentalEmployeeID_Leave(sender As Object, e As EventArgs) Handles txtRentalEmployeeID.Leave
        If txtRentalEmployeeID.Text = "" Then
            txtClerkName.Text = ""
            Exit Sub
        End If
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand("SELECT e.EFirstName, e.ELastName FROM employee e " &
                                       "INNER JOIN clerk c ON e.EmployeeID = c.EmployeeID " &
                                       "WHERE e.EmployeeID = " & txtRentalEmployeeID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtClerkName.Text = reader("EFirstName").ToString & " " & reader("ELastName").ToString
            Else
                txtClerkName.Text = "Not found"
                MsgBox("Employee ID not found or is not a Clerk.", MsgBoxStyle.Exclamation, "Employee Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btnAddRental_Click(sender As Object, e As EventArgs) Handles btnAddRental.Click
        If txtRentalID.Text = "" Or txtCustomerID.Text = "" Or txtVehicleID.Text = "" Or txtRentalEmployeeID.Text = "" Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = rentalDS.Tables("rental")
            Dim newRow As DataRow = dt.NewRow()
            newRow("RentalID") = txtRentalID.Text
            newRow("CustomerID") = txtCustomerID.Text
            newRow("VehicleID") = txtVehicleID.Text
            newRow("EmployeeID") = txtRentalEmployeeID.Text
            newRow("DateRented") = dtpDateRented.Value.ToString("yyyy-MM-dd")
            newRow("DateDueReturn") = dtpDateDueReturn.Value.ToString("yyyy-MM-dd")
            newRow("RentalStatus") = cbRentalStatus.Text
            dt.Rows.Add(newRow)
            rentalDA.Update(rentalDS, "rental")

            'Update vehicle status to Rented
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmdUpdate As New MySqlCommand("UPDATE vehicle SET VStatus = 'Rented' WHERE VehicleID = " & txtVehicleID.Text, MyConnection)
            cmdUpdate.ExecuteNonQuery()
            MyConnection.Close()

            MsgBox("Rental record successfully added!", MsgBoxStyle.Information, "Success")
            ClearRentalFields()
            rentalDS.Clear()
            LoadRentalData()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ClearRentalFields()
        txtRentalID.Clear()
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtVehicleID.Clear()
        txtPlateNo.Clear()
        txtBrandModel.Clear()
        txtRentalEmployeeID.Clear()
        txtClerkName.Clear()
        txtCustomerInfo.Clear()
        txtVehicleInfo.Clear()
        cbRentalStatus.SelectedIndex = -1
        dtpDateRented.Value = DateTime.Now
        dtpDateDueReturn.Value = DateTime.Now
        txtRentalID.Focus()
        btnAddRental.Enabled = True
        btnUpdateRental.Enabled = False
        btnDeleteRental.Enabled = False
        txtRentalID.Enabled = True
    End Sub
    Private Sub btnClearRental_Click(sender As Object, e As EventArgs) Handles btnClearRental.Click
        ClearRentalFields()
    End Sub
    Private Sub btnRefreshRental_Click(sender As Object, e As EventArgs) Handles btnRefreshRental.Click
        rentalDS.Clear()
        LoadRentalData()
    End Sub
    Private Sub dgvRental_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvRental.MouseUp
        Try
            txtRentalID.Text = dgvRental.CurrentRow.Cells(0).Value.ToString
            dtpDateRented.Value = DateTime.Parse(dgvRental.CurrentRow.Cells(1).Value.ToString)
            dtpDateDueReturn.Value = DateTime.Parse(dgvRental.CurrentRow.Cells(2).Value.ToString)
            cbRentalStatus.Text = dgvRental.CurrentRow.Cells(3).Value.ToString

            txtCustomerID.Text = dgvRental.CurrentRow.Cells(4).Value.ToString
            txtCustomerName.Text = dgvRental.CurrentRow.Cells(5).Value.ToString

            txtVehicleID.Text = dgvRental.CurrentRow.Cells(6).Value.ToString
            txtBrandModel.Text = dgvRental.CurrentRow.Cells(7).Value.ToString

            txtRentalEmployeeID.Text = dgvRental.CurrentRow.Cells(8).Value.ToString
            txtClerkName.Text = dgvRental.CurrentRow.Cells(9).Value.ToString
            row = dgvRental.CurrentRow.Index

            txtVehicleID_Leave(sender, e)
            txtRentalEmployeeID_Leave(sender, e)
            txtCustomerID_Leave(sender, e)

            btnAddRental.Enabled = False
            btnUpdateRental.Enabled = True
            btnDeleteRental.Enabled = True
            txtRentalID.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnUpdateRental_Click(sender As Object, e As EventArgs) Handles btnUpdateRental.Click
        Try
            Dim dt As DataTable = rentalDS.Tables("rental")
            dt.Rows(row)("CustomerID") = txtCustomerID.Text
            dt.Rows(row)("VehicleID") = txtVehicleID.Text
            dt.Rows(row)("EmployeeID") = txtRentalEmployeeID.Text
            dt.Rows(row)("DateRented") = dtpDateRented.Value.ToString("yyyy-MM-dd")
            dt.Rows(row)("DateDueReturn") = dtpDateDueReturn.Value.ToString("yyyy-MM-dd")
            dt.Rows(row)("RentalStatus") = cbRentalStatus.Text
            rentalDA.Update(rentalDS, "rental")
            MsgBox("Rental record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearRentalFields()
            txtRentalID.Enabled = True
            rentalDS.Clear()
            LoadRentalData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnDeleteRental_Click(sender As Object, e As EventArgs) Handles btnDeleteRental.Click
        Dim result = MsgBox("Are you sure you want to delete this rental record?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = rentalDS.Tables("rental")

                'Set vehicle back to Available
                MyConnection = New MySqlConnection(MyConnectionString)
                MyConnection.Open()
                Dim cmdUpdate As New MySqlCommand("UPDATE vehicle SET VStatus = 'Available' WHERE VehicleID = " & txtVehicleID.Text, MyConnection)
                cmdUpdate.ExecuteNonQuery()
                MyConnection.Close()

                dt.Rows(row).Delete()
                rentalDA.Update(rentalDS, "rental")
                MsgBox("Rental record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearRentalFields()
                txtRentalID.Enabled = True
                rentalDS.Clear()
                LoadRentalData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub txtRentalSearch_Enter(sender As Object, e As EventArgs) Handles txtRentalSearch.Enter
        If txtRentalSearch.Text = "Search by Customer, Vehicle, or Status..." Then
            txtRentalSearch.Text = ""
            txtRentalSearch.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtRentalSearch_Leave(sender As Object, e As EventArgs) Handles txtRentalSearch.Leave
        If txtRentalSearch.Text = "" Then
            txtRentalSearch.Text = "Search by Customer, Vehicle, or Status..."
            txtRentalSearch.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtRentalSearch_TextChanged(sender As Object, e As EventArgs) Handles txtRentalSearch.TextChanged

        If txtRentalSearch.Text = "" Or txtRentalSearch.Text = "Search by Customer, Vehicle, or Status..." Then
            dgvRental.DataSource = rentalDS.Tables("rental")
            Return
        End If

        Try
            Dim searchQuery As String = "SELECT r.RentalID, " &
                                    "CONCAT(c.CFirstName, ' ', c.CLastName) AS CustomerName, " &
                                    "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                                    "r.DateRented, r.DateDueReturn, r.RentalStatus, " &
                                    "r.CustomerID, r.VehicleID, r.EmployeeID " &
                                    "FROM rental r " &
                                    "JOIN customer c ON r.CustomerID = c.CustomerID " &
                                    "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                                    "WHERE CONCAT(c.CFirstName, ' ', c.CLastName) LIKE '%" & txtRentalSearch.Text & "%' " &
                                    "OR CONCAT(v.Brand, ' ', v.Model) LIKE '%" & txtRentalSearch.Text & "%' " &
                                    "OR r.RentalStatus LIKE '%" & txtRentalSearch.Text & "%' " &
                                    "ORDER BY r.RentalID DESC"

            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()

            searchDA.Fill(searchDS, "rental")

            dgvRental.DataSource = searchDS.Tables("rental")

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try

    End Sub
    Private Sub btnCloseRental_Click(sender As Object, e As EventArgs) Handles btnCloseRental.Click
        Me.Close()
    End Sub
End Class