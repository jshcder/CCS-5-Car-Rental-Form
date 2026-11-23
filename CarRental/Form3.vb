Imports MySql.Data.MySqlClient
Public Class frmReturnDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim returnDA As New MySqlDataAdapter
    Dim returnDS As New DataSet()
    Dim returnSQLQuery As String
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
    Private Sub txtReturnSearch_Enter(sender As Object, e As EventArgs) Handles txtReturnSearch.Enter
        ClearPlaceholder(txtReturnSearch, "Search by Rental ID, Condition, or Clerk...")
    End Sub

    Private Sub txtReturnSearch_Leave(sender As Object, e As EventArgs) Handles txtReturnSearch.Leave
        SetPlaceholder(txtReturnSearch, "Search by Rental ID, Condition, or Clerk...")
    End Sub

    Private Sub txtReturnRentalID_Enter(sender As Object, e As EventArgs) Handles txtReturnRentalID.Enter
        ClearPlaceholder(txtReturnRentalID, "e.g. 5001")
    End Sub

    Private Sub txtReturnRentalID_Leave(sender As Object, e As EventArgs) Handles txtReturnRentalID.Leave
        SetPlaceholder(txtReturnRentalID, "e.g. 5001")
        If txtReturnRentalID.Text <> "e.g. 5001" AndAlso txtReturnRentalID.Text <> "" Then
            AutoFillRentalInfo()
        End If
    End Sub

    Private Sub txtReturnNo_Enter(sender As Object, e As EventArgs) Handles txtReturnNo.Enter
        ClearPlaceholder(txtReturnNo, "e.g. 6004")
    End Sub

    Private Sub txtReturnNo_Leave(sender As Object, e As EventArgs) Handles txtReturnNo.Leave
        SetPlaceholder(txtReturnNo, "e.g. 6004")
    End Sub

    Private Sub txtMileageUponReturn_Enter(sender As Object, e As EventArgs) Handles txtMileageUponReturn.Enter
        ClearPlaceholder(txtMileageUponReturn, "e.g. 15500.00")
    End Sub

    Private Sub txtMileageUponReturn_Leave(sender As Object, e As EventArgs) Handles txtMileageUponReturn.Leave
        SetPlaceholder(txtMileageUponReturn, "e.g. 15500.00")
    End Sub

    Private Sub txtReturnNotes_Enter(sender As Object, e As EventArgs) Handles txtReturnNotes.Enter
        ClearPlaceholder(txtReturnNotes, "Enter notes here...")
    End Sub

    Private Sub txtReturnNotes_Leave(sender As Object, e As EventArgs) Handles txtReturnNotes.Leave
        SetPlaceholder(txtReturnNotes, "Enter notes here...")
    End Sub

    Private Sub txtReturnEmployeeID_Enter(sender As Object, e As EventArgs) Handles txtReturnEmployeeID.Enter
        ClearPlaceholder(txtReturnEmployeeID, "e.g. 1001")
    End Sub

    Private Sub txtReturnEmployeeID_Leave(sender As Object, e As EventArgs) Handles txtReturnEmployeeID.Leave
        SetPlaceholder(txtReturnEmployeeID, "e.g. 1001")
        If txtReturnEmployeeID.Text <> "e.g. 1001" AndAlso txtReturnEmployeeID.Text <> "" Then
            AutoFillClerkInfo()
        End If
    End Sub
    Private Sub AutoFillRentalInfo()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand(
                "SELECT r.RentalID, r.DateRented, r.DateDueReturn, r.RentalStatus, " &
                "CONCAT(c.CFirstName, ' ', c.CLastName) AS CustomerName, " &
                "c.CContactNo, " &
                "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                "v.PlateNo, v.Color, v.FuelType, v.Transmission " &
                "FROM rental r " &
                "JOIN customer c ON r.CustomerID = c.CustomerID " &
                "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                "WHERE r.RentalID = " & txtReturnRentalID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtRentalInfoReturn.Text = "Rental ID    : " & reader("RentalID").ToString & vbNewLine &
                                          "Customer     : " & reader("CustomerName").ToString & vbNewLine &
                                          "Contact      : " & reader("CContactNo").ToString & vbNewLine &
                                          "Date Rented  : " & DateTime.Parse(reader("DateRented").ToString).ToString("MM/dd/yyyy") & vbNewLine &
                                          "Due Return   : " & DateTime.Parse(reader("DateDueReturn").ToString).ToString("MM/dd/yyyy") & vbNewLine &
                                          "Status       : " & reader("RentalStatus").ToString
                txtVehicleInfoReturn.Text = "Vehicle      : " & reader("Vehicle").ToString & vbNewLine &
                                           "Plate No     : " & reader("PlateNo").ToString & vbNewLine &
                                           "Color        : " & reader("Color").ToString & vbNewLine &
                                           "Fuel Type    : " & reader("FuelType").ToString & vbNewLine &
                                           "Transmission : " & reader("Transmission").ToString
            Else
                txtRentalInfoReturn.Text = ""
                txtVehicleInfoReturn.Text = ""
                MsgBox("Rental ID not found.", MsgBoxStyle.Exclamation, "Rental Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub AutoFillClerkInfo()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand(
                "SELECT e.EFirstName, e.ELastName FROM employee e " &
                "INNER JOIN clerk c ON e.EmployeeID = c.EmployeeID " &
                "WHERE e.EmployeeID = " & txtReturnEmployeeID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtReturnClerkName.Text = reader("EFirstName").ToString & " " & reader("ELastName").ToString
            Else
                txtReturnClerkName.Text = "Not found"
                MsgBox("Employee ID not found or is not a Clerk.", MsgBoxStyle.Exclamation, "Employee Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub LoadReturnData()
        Try
            dgvReturn.DataSource = Nothing

            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            returnSQLQuery = "SELECT rt.RentalID, rt.ReturnNo, " &
                             "rt.ActualReturnDate, rt.MileageUponReturn, " &
                             "rt.VehicleCondition, rt.Notes, " &
                             "rt.EmployeeID, " &
                             "CONCAT(e.EFirstName, ' ', e.ELastName) AS ClerkName " &
                             "FROM return_t rt " &
                             "JOIN employee e ON rt.EmployeeID = e.EmployeeID " &
                             "ORDER BY rt.RentalID DESC"

            returnDA = New MySqlDataAdapter(returnSQLQuery, MyConnection)
            returnDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(returnDA)
            returnDA.Fill(returnDS, "return_t")

            dgvReturn.DataSource = returnDS.Tables("return_t")

            Dim dt As DataTable = returnDS.Tables("return_t")

            dt.Columns(0).ColumnName = "RentalID"
            dt.Columns(1).ColumnName = "ReturnNo"
            dt.Columns(2).ColumnName = "ActualReturnDate"
            dt.Columns(3).ColumnName = "MileageUponReturn"
            dt.Columns(4).ColumnName = "VehicleCondition"
            dt.Columns(5).ColumnName = "Notes"
            dt.Columns(6).ColumnName = "EmployeeID"
            dt.Columns(7).ColumnName = "ClerkName"

            dgvReturn.DataSource = dt
            dgvReturn.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub ClearReturnFields()
        txtReturnRentalID.Text = ""
        SetPlaceholder(txtReturnRentalID, "e.g. 5001")

        txtReturnNo.Text = ""
        SetPlaceholder(txtReturnNo, "e.g. 6004")

        txtReturnRentalID.Enabled = True
        txtReturnNo.Enabled = True

        txtMileageUponReturn.Text = ""
        SetPlaceholder(txtMileageUponReturn, "e.g. 15500.00")

        txtReturnNotes.Text = ""
        SetPlaceholder(txtReturnNotes, "Enter notes here...")

        txtReturnEmployeeID.Text = ""
        SetPlaceholder(txtReturnEmployeeID, "e.g. 1001")

        txtReturnClerkName.Clear()
        txtRentalInfoReturn.Clear()
        txtVehicleInfoReturn.Clear()

        cbVehicleCondition.SelectedIndex = -1
        dtpActualReturnDate.Value = DateTime.Now

        txtReturnRentalID.Focus()

        btnAddReturn.Enabled = True
        btnUpdateReturn.Enabled = False
        btnDeleteReturn.Enabled = False
    End Sub
    Private Sub frmReturnDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturnData()
        btnUpdateReturn.Enabled = False
        btnDeleteReturn.Enabled = False
        SetPlaceholder(txtReturnSearch, "Search by Rental ID, Condition, or Clerk...")
        SetPlaceholder(txtReturnRentalID, "e.g. 5001")
        SetPlaceholder(txtReturnNo, "e.g. 6004")
        SetPlaceholder(txtMileageUponReturn, "e.g. 15500.00")
        SetPlaceholder(txtReturnNotes, "Enter notes here...")
        SetPlaceholder(txtReturnEmployeeID, "e.g. 1001")
    End Sub
    Private Sub btnAddReturn_Click(sender As Object, e As EventArgs) Handles btnAddReturn.Click
        If txtReturnRentalID.Text = "" OrElse txtReturnRentalID.Text = "e.g. 5001" OrElse
           txtReturnNo.Text = "" OrElse txtReturnNo.Text = "e.g. 6004" OrElse
           txtReturnEmployeeID.Text = "" OrElse txtReturnEmployeeID.Text = "e.g. 1001" OrElse
           txtMileageUponReturn.Text = "" OrElse txtMileageUponReturn.Text = "e.g. 15500.00" OrElse
           cbVehicleCondition.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = returnDS.Tables("return_t")
            Dim newRow As DataRow = dt.NewRow()
            newRow("RentalID") = txtReturnRentalID.Text
            newRow("ReturnNo") = txtReturnNo.Text
            newRow("ActualReturnDate") = dtpActualReturnDate.Value.ToString("yyyy-MM-dd")
            newRow("MileageUponReturn") = txtMileageUponReturn.Text
            newRow("VehicleCondition") = cbVehicleCondition.Text
            newRow("Notes") = If(txtReturnNotes.Text = "Enter notes here...", "", txtReturnNotes.Text)
            newRow("EmployeeID") = txtReturnEmployeeID.Text
            dt.Rows.Add(newRow)
            returnDA.Update(returnDS, "return_t")

            'Update rental status to Returned
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmdRental As New MySqlCommand(
                "UPDATE rental SET RentalStatus = 'Returned' WHERE RentalID = " & txtReturnRentalID.Text, MyConnection)
            cmdRental.ExecuteNonQuery()

            'Update vehicle status back to Available
            Dim cmdVehicle As New MySqlCommand(
                "UPDATE vehicle v JOIN rental r ON v.VehicleID = r.VehicleID " &
                "SET v.VStatus = 'Available' WHERE r.RentalID = " & txtReturnRentalID.Text, MyConnection)
            cmdVehicle.ExecuteNonQuery()
            MyConnection.Close()

            MsgBox("Return record successfully added!", MsgBoxStyle.Information, "Success")
            ClearReturnFields()
            LoadReturnData()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateReturn_Click(sender As Object, e As EventArgs) Handles btnUpdateReturn.Click
        Try
            Dim dt As DataTable = returnDS.Tables("return_t")
            dt.Rows(row)("ActualReturnDate") = dtpActualReturnDate.Value.ToString("yyyy-MM-dd")
            dt.Rows(row)("MileageUponReturn") = txtMileageUponReturn.Text
            dt.Rows(row)("VehicleCondition") = cbVehicleCondition.Text
            dt.Rows(row)("Notes") = If(txtReturnNotes.Text = "Enter notes here...", "", txtReturnNotes.Text)
            dt.Rows(row)("EmployeeID") = txtReturnEmployeeID.Text
            returnDA.Update(returnDS, "return_t")
            MsgBox("Return record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearReturnFields()
            LoadReturnData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteReturn_Click(sender As Object, e As EventArgs) Handles btnDeleteReturn.Click
        Dim result = MsgBox("Are you sure you want to delete this return record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = returnDS.Tables("return_t")
                dt.Rows(row).Delete()
                returnDA.Update(returnDS, "return_t")
                MsgBox("Return record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearReturnFields()
                LoadReturnData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnClearReturn_Click(sender As Object, e As EventArgs) Handles btnClearReturn.Click
        ClearReturnFields()
    End Sub

    Private Sub btnCloseReturn_Click(sender As Object, e As EventArgs) Handles btnCloseReturn.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshReturn_Click(sender As Object, e As EventArgs) Handles btnRefreshReturn.Click
        LoadReturnData()
    End Sub
    Private Sub dgvReturn_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvReturn.MouseUp
        Try
            txtReturnRentalID.Text = dgvReturn.CurrentRow.Cells(0).Value.ToString
            txtReturnNo.Text = dgvReturn.CurrentRow.Cells(1).Value.ToString
            dtpActualReturnDate.Value = DateTime.Parse(dgvReturn.CurrentRow.Cells(2).Value.ToString)
            txtMileageUponReturn.Text = dgvReturn.CurrentRow.Cells(3).Value.ToString
            cbVehicleCondition.Text = dgvReturn.CurrentRow.Cells(4).Value.ToString
            txtReturnNotes.Text = dgvReturn.CurrentRow.Cells(5).Value.ToString
            txtReturnEmployeeID.Text = dgvReturn.CurrentRow.Cells(6).Value.ToString
            txtReturnClerkName.Text = dgvReturn.CurrentRow.Cells(7).Value.ToString
            row = dgvReturn.CurrentRow.Index

            AutoFillRentalInfo()

            txtReturnRentalID.ForeColor = Color.Black
            txtReturnNo.ForeColor = Color.Black
            txtMileageUponReturn.ForeColor = Color.Black
            txtReturnNotes.ForeColor = Color.Black
            txtReturnEmployeeID.ForeColor = Color.Black

            btnAddReturn.Enabled = False
            btnUpdateReturn.Enabled = True
            btnDeleteReturn.Enabled = True
            txtReturnRentalID.Enabled = False
            txtReturnNo.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txtReturnSearch_TextChanged(sender As Object, e As EventArgs) Handles txtReturnSearch.TextChanged
        If txtReturnSearch.Text = "" OrElse txtReturnSearch.Text = "Search by Rental ID, Condition, or Clerk..." Then
            LoadReturnData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT rt.RentalID, rt.ReturnNo, " &
                                        "rt.ActualReturnDate, rt.MileageUponReturn, " &
                                        "rt.VehicleCondition, rt.Notes, " &
                                        "rt.EmployeeID, " &
                                        "CONCAT(e.EFirstName, ' ', e.ELastName) AS ClerkName " &
                                        "FROM return_t rt " &
                                        "JOIN employee e ON rt.EmployeeID = e.EmployeeID " &
                                        "WHERE CAST(rt.RentalID AS CHAR) LIKE '%" & txtReturnSearch.Text & "%' " &
                                        "OR rt.VehicleCondition LIKE '%" & txtReturnSearch.Text & "%' " &
                                        "OR CONCAT(e.EFirstName, ' ', e.ELastName) LIKE '%" & txtReturnSearch.Text & "%' " &
                                        "ORDER BY rt.RentalID DESC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "return_t")
            dgvReturn.DataSource = searchDS.Tables("return_t")
            dgvReturn.Columns(0).HeaderText = "Rental ID"
            dgvReturn.Columns(1).HeaderText = "Return No"
            dgvReturn.Columns(2).HeaderText = "Actual Return Date"
            dgvReturn.Columns(3).HeaderText = "Mileage Upon Return"
            dgvReturn.Columns(4).HeaderText = "Vehicle Condition"
            dgvReturn.Columns(5).HeaderText = "Notes"
            dgvReturn.Columns(6).Visible = False
            dgvReturn.Columns(7).HeaderText = "Clerk"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class