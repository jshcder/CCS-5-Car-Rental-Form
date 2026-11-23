Imports MySql.Data.MySqlClient
Public Class frmVehicleDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim vehicleDA As New MySqlDataAdapter
    Dim vehicleDS As New DataSet()
    Dim vehicleSQLQuery As String
    Dim row As Integer

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

    Private Sub txtVehicleSearch_Enter(sender As Object, e As EventArgs) Handles txtVehicleSearch.Enter
        ClearPlaceholder(txtVehicleSearch, "Search by Brand, Model, Plate No, or Status...")
    End Sub

    Private Sub txtVehicleSearch_Leave(sender As Object, e As EventArgs) Handles txtVehicleSearch.Leave
        SetPlaceholder(txtVehicleSearch, "Search by Brand, Model, Plate No, or Status...")
    End Sub

    Private Sub txtVehicleID_Enter(sender As Object, e As EventArgs) Handles txtVehicleID.Enter
        ClearPlaceholder(txtVehicleID, "e.g. 4004")
    End Sub

    Private Sub txtVehicleID_Leave(sender As Object, e As EventArgs) Handles txtVehicleID.Leave
        SetPlaceholder(txtVehicleID, "e.g. 4004")
    End Sub

    Private Sub txtVehicleBrand_Enter(sender As Object, e As EventArgs) Handles txtVehicleBrand.Enter
        ClearPlaceholder(txtVehicleBrand, "e.g. Toyota")
    End Sub

    Private Sub txtVehicleBrand_Leave(sender As Object, e As EventArgs) Handles txtVehicleBrand.Leave
        SetPlaceholder(txtVehicleBrand, "e.g. Toyota")
    End Sub

    Private Sub txtVehicleModel_Enter(sender As Object, e As EventArgs) Handles txtVehicleModel.Enter
        ClearPlaceholder(txtVehicleModel, "e.g. Vios")
    End Sub

    Private Sub txtVehicleModel_Leave(sender As Object, e As EventArgs) Handles txtVehicleModel.Leave
        SetPlaceholder(txtVehicleModel, "e.g. Vios")
    End Sub

    Private Sub txtVehicleYear_Enter(sender As Object, e As EventArgs) Handles txtVehicleYear.Enter
        ClearPlaceholder(txtVehicleYear, "e.g. 2023")
    End Sub

    Private Sub txtVehicleYear_Leave(sender As Object, e As EventArgs) Handles txtVehicleYear.Leave
        SetPlaceholder(txtVehicleYear, "e.g. 2023")
    End Sub

    Private Sub txtVehicleColor_Enter(sender As Object, e As EventArgs) Handles txtVehicleColor.Enter
        ClearPlaceholder(txtVehicleColor, "e.g. White")
    End Sub

    Private Sub txtVehicleColor_Leave(sender As Object, e As EventArgs) Handles txtVehicleColor.Leave
        SetPlaceholder(txtVehicleColor, "e.g. White")
    End Sub

    Private Sub txtVehicleMileage_Enter(sender As Object, e As EventArgs) Handles txtVehicleMileage.Enter
        ClearPlaceholder(txtVehicleMileage, "e.g. 0.00")
    End Sub

    Private Sub txtVehicleMileage_Leave(sender As Object, e As EventArgs) Handles txtVehicleMileage.Leave
        SetPlaceholder(txtVehicleMileage, "e.g. 0.00")
    End Sub

    Private Sub txtVehiclePlateNo_Enter(sender As Object, e As EventArgs) Handles txtVehiclePlateNo.Enter
        ClearPlaceholder(txtVehiclePlateNo, "e.g. ABC 1234")
    End Sub

    Private Sub txtVehiclePlateNo_Leave(sender As Object, e As EventArgs) Handles txtVehiclePlateNo.Leave
        SetPlaceholder(txtVehiclePlateNo, "e.g. ABC 1234")
    End Sub

    Private Sub txtVehicleCategoryID_Enter(sender As Object, e As EventArgs) Handles txtVehicleCategoryID.Enter
        ClearPlaceholder(txtVehicleCategoryID, "e.g. 3001")
    End Sub

    Private Sub txtVehicleCategoryID_Leave(sender As Object, e As EventArgs) Handles txtVehicleCategoryID.Leave
        SetPlaceholder(txtVehicleCategoryID, "e.g. 3001")
        If txtVehicleCategoryID.Text <> "e.g. 3001" AndAlso txtVehicleCategoryID.Text <> "" Then
            AutoFillCategoryName()
        End If
    End Sub

    Private Sub AutoFillCategoryName()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand(
                "SELECT CategoryName FROM category WHERE CategoryID = " & txtVehicleCategoryID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtVehicleCategoryName.Text = reader("CategoryName").ToString
            Else
                txtVehicleCategoryName.Text = "Not found"
                MsgBox("Category ID not found.", MsgBoxStyle.Exclamation, "Category Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub LoadVehicleData()
        Try
            dgvVehicle.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            vehicleSQLQuery = "SELECT v.VehicleID, v.Brand, v.Model, v.Year, v.Color, " &
                              "v.FuelType, v.Transmission, v.CurrentMileage, v.PlateNo, " &
                              "v.VStatus, v.CategoryID, c.CategoryName " &
                              "FROM vehicle v " &
                              "JOIN category c ON v.CategoryID = c.CategoryID " &
                              "ORDER BY v.VehicleID ASC"

            vehicleDA = New MySqlDataAdapter(vehicleSQLQuery, MyConnection)
            vehicleDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(vehicleDA)
            vehicleDA.Fill(vehicleDS, "vehicle")

            dgvVehicle.DataSource = vehicleDS.Tables("vehicle")

            If dgvVehicle.Columns.Contains("VehicleID") Then
                dgvVehicle.Columns("VehicleID").HeaderText = "Vehicle ID"
            End If

            If dgvVehicle.Columns.Contains("Brand") Then
                dgvVehicle.Columns("Brand").HeaderText = "Brand"
            End If

            If dgvVehicle.Columns.Contains("Model") Then
                dgvVehicle.Columns("Model").HeaderText = "Model"
            End If

            If dgvVehicle.Columns.Contains("Year") Then
                dgvVehicle.Columns("Year").HeaderText = "Year"
            End If

            If dgvVehicle.Columns.Contains("Color") Then
                dgvVehicle.Columns("Color").HeaderText = "Color"
            End If

            If dgvVehicle.Columns.Contains("FuelType") Then
                dgvVehicle.Columns("FuelType").HeaderText = "Fuel Type"
            End If

            If dgvVehicle.Columns.Contains("Transmission") Then
                dgvVehicle.Columns("Transmission").HeaderText = "Transmission"
            End If

            If dgvVehicle.Columns.Contains("CurrentMileage") Then
                dgvVehicle.Columns("CurrentMileage").HeaderText = "Current Mileage"
            End If

            If dgvVehicle.Columns.Contains("PlateNo") Then
                dgvVehicle.Columns("PlateNo").HeaderText = "Plate No"
            End If

            If dgvVehicle.Columns.Contains("VStatus") Then
                dgvVehicle.Columns("VStatus").HeaderText = "Status"
            End If

            If dgvVehicle.Columns.Contains("CategoryID") Then
                dgvVehicle.Columns("CategoryID").Visible = False
            End If

            If dgvVehicle.Columns.Contains("CategoryName") Then
                dgvVehicle.Columns("CategoryName").HeaderText = "Category"
            End If
            dgvVehicle.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ClearVehicleFields()
        txtVehicleID.Text = ""
        SetPlaceholder(txtVehicleID, "e.g. 4004")
        txtVehicleBrand.Text = ""
        SetPlaceholder(txtVehicleBrand, "e.g. Toyota")
        txtVehicleModel.Text = ""
        SetPlaceholder(txtVehicleModel, "e.g. Vios")
        txtVehicleYear.Text = ""
        SetPlaceholder(txtVehicleYear, "e.g. 2023")
        txtVehicleColor.Text = ""
        SetPlaceholder(txtVehicleColor, "e.g. White")
        txtVehicleMileage.Text = ""
        SetPlaceholder(txtVehicleMileage, "e.g. 0.00")
        txtVehiclePlateNo.Text = ""
        SetPlaceholder(txtVehiclePlateNo, "e.g. ABC 1234")
        txtVehicleCategoryID.Text = ""
        SetPlaceholder(txtVehicleCategoryID, "e.g. 3001")
        txtVehicleCategoryName.Clear()
        cbVehicleFuelType.SelectedIndex = -1
        cbVehicleTransmission.SelectedIndex = -1
        cbVehicleStatus.SelectedIndex = -1
        txtVehicleID.Focus()
        btnAddVehicle.Enabled = True
        btnUpdateVehicle.Enabled = False
        btnDeleteVehicle.Enabled = False
        txtVehicleID.Enabled = True
    End Sub

    Private Sub frmVehicleDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVehicleData()
        btnUpdateVehicle.Enabled = False
        btnDeleteVehicle.Enabled = False
        SetPlaceholder(txtVehicleSearch, "Search by Brand, Model, Plate No, or Status...")
        SetPlaceholder(txtVehicleID, "e.g. 4004")
        SetPlaceholder(txtVehicleBrand, "e.g. Toyota")
        SetPlaceholder(txtVehicleModel, "e.g. Vios")
        SetPlaceholder(txtVehicleYear, "e.g. 2023")
        SetPlaceholder(txtVehicleColor, "e.g. White")
        SetPlaceholder(txtVehicleMileage, "e.g. 0.00")
        SetPlaceholder(txtVehiclePlateNo, "e.g. ABC 1234")
        SetPlaceholder(txtVehicleCategoryID, "e.g. 3001")
    End Sub

    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        If txtVehicleID.Text = "" OrElse txtVehicleID.Text = "e.g. 4004" OrElse
           txtVehicleBrand.Text = "" OrElse txtVehicleBrand.Text = "e.g. Toyota" OrElse
           txtVehicleModel.Text = "" OrElse txtVehicleModel.Text = "e.g. Vios" OrElse
           txtVehicleYear.Text = "" OrElse txtVehicleYear.Text = "e.g. 2023" OrElse
           txtVehicleColor.Text = "" OrElse txtVehicleColor.Text = "e.g. White" OrElse
           txtVehicleMileage.Text = "" OrElse txtVehicleMileage.Text = "e.g. 0.00" OrElse
           txtVehiclePlateNo.Text = "" OrElse txtVehiclePlateNo.Text = "e.g. ABC 1234" OrElse
           txtVehicleCategoryID.Text = "" OrElse txtVehicleCategoryID.Text = "e.g. 3001" OrElse
           cbVehicleFuelType.SelectedIndex = -1 OrElse
           cbVehicleTransmission.SelectedIndex = -1 OrElse
           cbVehicleStatus.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = vehicleDS.Tables("vehicle")
            Dim newRow As DataRow = dt.NewRow()
            newRow("VehicleID") = txtVehicleID.Text
            newRow("Brand") = txtVehicleBrand.Text
            newRow("Model") = txtVehicleModel.Text
            newRow("Year") = txtVehicleYear.Text
            newRow("Color") = txtVehicleColor.Text
            newRow("FuelType") = cbVehicleFuelType.Text
            newRow("Transmission") = cbVehicleTransmission.Text
            newRow("CurrentMileage") = txtVehicleMileage.Text
            newRow("PlateNo") = txtVehiclePlateNo.Text
            newRow("VStatus") = cbVehicleStatus.Text
            newRow("CategoryID") = txtVehicleCategoryID.Text
            dt.Rows.Add(newRow)
            vehicleDA.Update(vehicleDS, "vehicle")
            MsgBox("Vehicle record successfully added!", MsgBoxStyle.Information, "Success")
            ClearVehicleFields()
            LoadVehicleData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateVehicle_Click(sender As Object, e As EventArgs) Handles btnUpdateVehicle.Click
        Try
            Dim dt As DataTable = vehicleDS.Tables("vehicle")
            dt.Rows(row)("Brand") = txtVehicleBrand.Text
            dt.Rows(row)("Model") = txtVehicleModel.Text
            dt.Rows(row)("Year") = txtVehicleYear.Text
            dt.Rows(row)("Color") = txtVehicleColor.Text
            dt.Rows(row)("FuelType") = cbVehicleFuelType.Text
            dt.Rows(row)("Transmission") = cbVehicleTransmission.Text
            dt.Rows(row)("CurrentMileage") = txtVehicleMileage.Text
            dt.Rows(row)("PlateNo") = txtVehiclePlateNo.Text
            dt.Rows(row)("VStatus") = cbVehicleStatus.Text
            dt.Rows(row)("CategoryID") = txtVehicleCategoryID.Text
            vehicleDA.Update(vehicleDS, "vehicle")
            MsgBox("Vehicle record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearVehicleFields()
            LoadVehicleData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteVehicle_Click(sender As Object, e As EventArgs) Handles btnDeleteVehicle.Click
        Dim result = MsgBox("Are you sure you want to delete this vehicle record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = vehicleDS.Tables("vehicle")
                dt.Rows(row).Delete()
                vehicleDA.Update(vehicleDS, "vehicle")
                MsgBox("Vehicle record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearVehicleFields()
                LoadVehicleData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnClearVehicle_Click(sender As Object, e As EventArgs) Handles btnClearVehicle.Click
        ClearVehicleFields()
    End Sub

    Private Sub btnCloseVehicle_Click(sender As Object, e As EventArgs) Handles btnCloseVehicle.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshVehicle_Click(sender As Object, e As EventArgs) Handles btnRefreshVehicle.Click
        LoadVehicleData()
    End Sub

    Private Sub dgvVehicle_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvVehicle.MouseUp
        Try
            txtVehicleID.Text = dgvVehicle.CurrentRow.Cells(0).Value.ToString
            txtVehicleBrand.Text = dgvVehicle.CurrentRow.Cells(1).Value.ToString
            txtVehicleModel.Text = dgvVehicle.CurrentRow.Cells(2).Value.ToString
            txtVehicleYear.Text = dgvVehicle.CurrentRow.Cells(3).Value.ToString
            txtVehicleColor.Text = dgvVehicle.CurrentRow.Cells(4).Value.ToString
            cbVehicleFuelType.Text = dgvVehicle.CurrentRow.Cells(5).Value.ToString
            cbVehicleTransmission.Text = dgvVehicle.CurrentRow.Cells(6).Value.ToString
            txtVehicleMileage.Text = dgvVehicle.CurrentRow.Cells(7).Value.ToString
            txtVehiclePlateNo.Text = dgvVehicle.CurrentRow.Cells(8).Value.ToString
            cbVehicleStatus.Text = dgvVehicle.CurrentRow.Cells(9).Value.ToString
            txtVehicleCategoryID.Text = dgvVehicle.CurrentRow.Cells(10).Value.ToString
            txtVehicleCategoryName.Text = dgvVehicle.CurrentRow.Cells(11).Value.ToString
            row = dgvVehicle.CurrentRow.Index

            txtVehicleID.ForeColor = Color.Black
            txtVehicleBrand.ForeColor = Color.Black
            txtVehicleModel.ForeColor = Color.Black
            txtVehicleYear.ForeColor = Color.Black
            txtVehicleColor.ForeColor = Color.Black
            txtVehicleMileage.ForeColor = Color.Black
            txtVehiclePlateNo.ForeColor = Color.Black
            txtVehicleCategoryID.ForeColor = Color.Black

            btnAddVehicle.Enabled = False
            btnUpdateVehicle.Enabled = True
            btnDeleteVehicle.Enabled = True
            txtVehicleID.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtVehicleSearch_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleSearch.TextChanged
        If txtVehicleSearch.Text = "" OrElse txtVehicleSearch.Text = "Search by Brand, Model, Plate No, or Status..." Then
            LoadVehicleData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT v.VehicleID, v.Brand, v.Model, v.Year, v.Color, " &
                                        "v.FuelType, v.Transmission, v.CurrentMileage, v.PlateNo, " &
                                        "v.VStatus, v.CategoryID, c.CategoryName " &
                                        "FROM vehicle v " &
                                        "JOIN category c ON v.CategoryID = c.CategoryID " &
                                        "WHERE v.Brand LIKE '%" & txtVehicleSearch.Text & "%' " &
                                        "OR v.Model LIKE '%" & txtVehicleSearch.Text & "%' " &
                                        "OR v.PlateNo LIKE '%" & txtVehicleSearch.Text & "%' " &
                                        "OR v.VStatus LIKE '%" & txtVehicleSearch.Text & "%' " &
                                        "ORDER BY v.VehicleID ASC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "vehicle")
            dgvVehicle.DataSource = searchDS.Tables("vehicle")
            dgvVehicle.Columns(0).HeaderText = "Vehicle ID"
            dgvVehicle.Columns(1).HeaderText = "Brand"
            dgvVehicle.Columns(2).HeaderText = "Model"
            dgvVehicle.Columns(3).HeaderText = "Year"
            dgvVehicle.Columns(4).HeaderText = "Color"
            dgvVehicle.Columns(5).HeaderText = "Fuel Type"
            dgvVehicle.Columns(6).HeaderText = "Transmission"
            dgvVehicle.Columns(7).HeaderText = "Current Mileage"
            dgvVehicle.Columns(8).HeaderText = "Plate No"
            dgvVehicle.Columns(9).HeaderText = "Status"
            dgvVehicle.Columns(10).Visible = False
            dgvVehicle.Columns(11).HeaderText = "Category"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

End Class