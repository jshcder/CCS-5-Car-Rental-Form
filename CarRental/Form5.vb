Imports MySql.Data.MySqlClient
Public Class frmCustomerDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim customerDA As New MySqlDataAdapter
    Dim customerDS As New DataSet()
    Dim customerSQLQuery As String
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
    Private Sub txtCustomerSearch_Enter(sender As Object, e As EventArgs) Handles txtCustomerSearch.Enter
        ClearPlaceholder(txtCustomerSearch, "Search by Name, City, or License No...")
    End Sub

    Private Sub txtCustomerSearch_Leave(sender As Object, e As EventArgs) Handles txtCustomerSearch.Leave
        SetPlaceholder(txtCustomerSearch, "Search by Name, City, or License No...")
    End Sub

    Private Sub txtCustomerID_Enter(sender As Object, e As EventArgs) Handles txtCustomerID.Enter
        ClearPlaceholder(txtCustomerID, "e.g. 2004")
    End Sub

    Private Sub txtCustomerID_Leave(sender As Object, e As EventArgs) Handles txtCustomerID.Leave
        SetPlaceholder(txtCustomerID, "e.g. 2004")
    End Sub

    Private Sub txtCLastName_Enter(sender As Object, e As EventArgs) Handles txtCLastName.Enter
        ClearPlaceholder(txtCLastName, "e.g. Dela Cruz")
    End Sub

    Private Sub txtCLastName_Leave(sender As Object, e As EventArgs) Handles txtCLastName.Leave
        SetPlaceholder(txtCLastName, "e.g. Dela Cruz")
    End Sub

    Private Sub txtCFirstName_Enter(sender As Object, e As EventArgs) Handles txtCFirstName.Enter
        ClearPlaceholder(txtCFirstName, "e.g. Juan")
    End Sub

    Private Sub txtCFirstName_Leave(sender As Object, e As EventArgs) Handles txtCFirstName.Leave
        SetPlaceholder(txtCFirstName, "e.g. Juan")
    End Sub

    Private Sub txtCMiddleName_Enter(sender As Object, e As EventArgs) Handles txtCMiddleName.Enter
        ClearPlaceholder(txtCMiddleName, "e.g. Santos")
    End Sub

    Private Sub txtCMiddleName_Leave(sender As Object, e As EventArgs) Handles txtCMiddleName.Leave
        SetPlaceholder(txtCMiddleName, "e.g. Santos")
    End Sub

    Private Sub txtCStreet_Enter(sender As Object, e As EventArgs) Handles txtCStreet.Enter
        ClearPlaceholder(txtCStreet, "e.g. 123 Rizal St")
    End Sub

    Private Sub txtCStreet_Leave(sender As Object, e As EventArgs) Handles txtCStreet.Leave
        SetPlaceholder(txtCStreet, "e.g. 123 Rizal St")
    End Sub

    Private Sub txtCCity_Enter(sender As Object, e As EventArgs) Handles txtCCity.Enter
        ClearPlaceholder(txtCCity, "e.g. Bacolod City")
    End Sub

    Private Sub txtCCity_Leave(sender As Object, e As EventArgs) Handles txtCCity.Leave
        SetPlaceholder(txtCCity, "e.g. Bacolod City")
    End Sub

    Private Sub txtCState_Enter(sender As Object, e As EventArgs) Handles txtCState.Enter
        ClearPlaceholder(txtCState, "e.g. Negros Occidental")
    End Sub

    Private Sub txtCState_Leave(sender As Object, e As EventArgs) Handles txtCState.Leave
        SetPlaceholder(txtCState, "e.g. Negros Occidental")
    End Sub

    Private Sub txtCZipCode_Enter(sender As Object, e As EventArgs) Handles txtCZipCode.Enter
        ClearPlaceholder(txtCZipCode, "e.g. 6100")
    End Sub

    Private Sub txtCZipCode_Leave(sender As Object, e As EventArgs) Handles txtCZipCode.Leave
        SetPlaceholder(txtCZipCode, "e.g. 6100")
    End Sub

    Private Sub txtCContactNo_Enter(sender As Object, e As EventArgs) Handles txtCContactNo.Enter
        ClearPlaceholder(txtCContactNo, "e.g. 09171234567")
    End Sub

    Private Sub txtCContactNo_Leave(sender As Object, e As EventArgs) Handles txtCContactNo.Leave
        SetPlaceholder(txtCContactNo, "e.g. 09171234567")
    End Sub

    Private Sub txtCEmail_Enter(sender As Object, e As EventArgs) Handles txtCEmail.Enter
        ClearPlaceholder(txtCEmail, "e.g. juan@email.com")
    End Sub

    Private Sub txtCEmail_Leave(sender As Object, e As EventArgs) Handles txtCEmail.Leave
        SetPlaceholder(txtCEmail, "e.g. juan@email.com")
    End Sub

    Private Sub txtCDriverLicenseNo_Enter(sender As Object, e As EventArgs) Handles txtCDriverLicenseNo.Enter
        ClearPlaceholder(txtCDriverLicenseNo, "e.g. N01-23-456789")
    End Sub

    Private Sub txtCDriverLicenseNo_Leave(sender As Object, e As EventArgs) Handles txtCDriverLicenseNo.Leave
        SetPlaceholder(txtCDriverLicenseNo, "e.g. N01-23-456789")
    End Sub
    Private Sub LoadCustomerData()
        Try
            dgvCustomer.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            customerSQLQuery = "SELECT CustomerID, CLastName, CFirstName, CMiddleName, " &
                               "CStreet, CCity, CState, CZipCode, " &
                               "CContactNo, CEmail, CDriverLicenseNo " &
                               "FROM customer " &
                               "ORDER BY CLastName ASC"

            customerDA = New MySqlDataAdapter(customerSQLQuery, MyConnection)
            customerDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(customerDA)
            customerDA.Fill(customerDS, "customer")

            dgvCustomer.DataSource = customerDS.Tables("customer")

            If dgvCustomer.Columns.Contains("CustomerID") Then
                dgvCustomer.Columns("CustomerID").HeaderText = "Customer ID"
            End If

            If dgvCustomer.Columns.Contains("CLastName") Then
                dgvCustomer.Columns("CLastName").HeaderText = "Last Name"
            End If

            If dgvCustomer.Columns.Contains("CFirstName") Then
                dgvCustomer.Columns("CFirstName").HeaderText = "First Name"
            End If

            If dgvCustomer.Columns.Contains("CMiddleName") Then
                dgvCustomer.Columns("CMiddleName").HeaderText = "Middle Name"
            End If

            If dgvCustomer.Columns.Contains("CStreet") Then
                dgvCustomer.Columns("CStreet").HeaderText = "Street"
            End If

            If dgvCustomer.Columns.Contains("CCity") Then
                dgvCustomer.Columns("CCity").HeaderText = "City"
            End If

            If dgvCustomer.Columns.Contains("CState") Then
                dgvCustomer.Columns("CState").HeaderText = "State"
            End If

            If dgvCustomer.Columns.Contains("CZipCode") Then
                dgvCustomer.Columns("CZipCode").HeaderText = "Zip Code"
            End If

            If dgvCustomer.Columns.Contains("CContactNo") Then
                dgvCustomer.Columns("CContactNo").HeaderText = "Contact No"
            End If

            If dgvCustomer.Columns.Contains("CEmail") Then
                dgvCustomer.Columns("CEmail").HeaderText = "Email"
            End If

            If dgvCustomer.Columns.Contains("CDriverLicenseNo") Then
                dgvCustomer.Columns("CDriverLicenseNo").HeaderText = "Driver License No"
            End If
            dgvCustomer.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub ClearCustomerFields()
        txtCustomerID.Text = ""
        SetPlaceholder(txtCustomerID, "e.g. 2004")
        txtCLastName.Text = ""
        SetPlaceholder(txtCLastName, "e.g. Dela Cruz")
        txtCFirstName.Text = ""
        SetPlaceholder(txtCFirstName, "e.g. Juan")
        txtCMiddleName.Text = ""
        SetPlaceholder(txtCMiddleName, "e.g. Santos")
        txtCStreet.Text = ""
        SetPlaceholder(txtCStreet, "e.g. 123 Rizal St")
        txtCCity.Text = ""
        SetPlaceholder(txtCCity, "e.g. Bacolod City")
        txtCState.Text = ""
        SetPlaceholder(txtCState, "e.g. Negros Occidental")
        txtCZipCode.Text = ""
        SetPlaceholder(txtCZipCode, "e.g. 6100")
        txtCContactNo.Text = ""
        SetPlaceholder(txtCContactNo, "e.g. 09171234567")
        txtCEmail.Text = ""
        SetPlaceholder(txtCEmail, "e.g. juan@email.com")
        txtCDriverLicenseNo.Text = ""
        SetPlaceholder(txtCDriverLicenseNo, "e.g. N01-23-456789")
        txtCustomerID.Focus()
        btnAddCustomer.Enabled = True
        btnUpdateCustomer.Enabled = False
        btnDeleteCustomer.Enabled = False
        txtCustomerID.Enabled = True
    End Sub
    Private Sub frmCustomerDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerData()
        btnUpdateCustomer.Enabled = False
        btnDeleteCustomer.Enabled = False
        SetPlaceholder(txtCustomerSearch, "Search by Name, City, or License No...")
        SetPlaceholder(txtCustomerID, "e.g. 2004")
        SetPlaceholder(txtCLastName, "e.g. Dela Cruz")
        SetPlaceholder(txtCFirstName, "e.g. Juan")
        SetPlaceholder(txtCMiddleName, "e.g. Santos")
        SetPlaceholder(txtCStreet, "e.g. 123 Rizal St")
        SetPlaceholder(txtCCity, "e.g. Bacolod City")
        SetPlaceholder(txtCState, "e.g. Negros Occidental")
        SetPlaceholder(txtCZipCode, "e.g. 6100")
        SetPlaceholder(txtCContactNo, "e.g. 09171234567")
        SetPlaceholder(txtCEmail, "e.g. juan@email.com")
        SetPlaceholder(txtCDriverLicenseNo, "e.g. N01-23-456789")
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If txtCustomerID.Text = "" OrElse txtCustomerID.Text = "e.g. 2004" OrElse
           txtCLastName.Text = "" OrElse txtCLastName.Text = "e.g. Dela Cruz" OrElse
           txtCFirstName.Text = "" OrElse txtCFirstName.Text = "e.g. Juan" OrElse
           txtCStreet.Text = "" OrElse txtCStreet.Text = "e.g. 123 Rizal St" OrElse
           txtCCity.Text = "" OrElse txtCCity.Text = "e.g. Bacolod City" OrElse
           txtCState.Text = "" OrElse txtCState.Text = "e.g. Negros Occidental" OrElse
           txtCZipCode.Text = "" OrElse txtCZipCode.Text = "e.g. 6100" OrElse
           txtCContactNo.Text = "" OrElse txtCContactNo.Text = "e.g. 09171234567" OrElse
           txtCDriverLicenseNo.Text = "" OrElse txtCDriverLicenseNo.Text = "e.g. N01-23-456789" Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = customerDS.Tables("customer")
            Dim newRow As DataRow = dt.NewRow()
            newRow("CustomerID") = txtCustomerID.Text
            newRow("CLastName") = txtCLastName.Text
            newRow("CFirstName") = txtCFirstName.Text
            newRow("CMiddleName") = If(txtCMiddleName.Text = "e.g. Santos", "", txtCMiddleName.Text)
            newRow("CStreet") = txtCStreet.Text
            newRow("CCity") = txtCCity.Text
            newRow("CState") = txtCState.Text
            newRow("CZipCode") = txtCZipCode.Text
            newRow("CContactNo") = txtCContactNo.Text
            newRow("CEmail") = If(txtCEmail.Text = "e.g. juan@email.com", "", txtCEmail.Text)
            newRow("CDriverLicenseNo") = txtCDriverLicenseNo.Text
            dt.Rows.Add(newRow)
            customerDA.Update(customerDS, "customer")
            MsgBox("Customer record successfully added!", MsgBoxStyle.Information, "Success")
            ClearCustomerFields()
            LoadCustomerData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Try
            Dim dt As DataTable = customerDS.Tables("customer")
            dt.Rows(row)("CLastName") = txtCLastName.Text
            dt.Rows(row)("CFirstName") = txtCFirstName.Text
            dt.Rows(row)("CMiddleName") = If(txtCMiddleName.Text = "e.g. Santos", "", txtCMiddleName.Text)
            dt.Rows(row)("CStreet") = txtCStreet.Text
            dt.Rows(row)("CCity") = txtCCity.Text
            dt.Rows(row)("CState") = txtCState.Text
            dt.Rows(row)("CZipCode") = txtCZipCode.Text
            dt.Rows(row)("CContactNo") = txtCContactNo.Text
            dt.Rows(row)("CEmail") = If(txtCEmail.Text = "e.g. juan@email.com", "", txtCEmail.Text)
            dt.Rows(row)("CDriverLicenseNo") = txtCDriverLicenseNo.Text
            customerDA.Update(customerDS, "customer")
            MsgBox("Customer record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearCustomerFields()
            LoadCustomerData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Dim result = MsgBox("Are you sure you want to delete this customer record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = customerDS.Tables("customer")
                dt.Rows(row).Delete()
                customerDA.Update(customerDS, "customer")
                MsgBox("Customer record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearCustomerFields()
                LoadCustomerData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnClearCustomer_Click(sender As Object, e As EventArgs) Handles btnClearCustomer.Click
        ClearCustomerFields()
    End Sub

    Private Sub btnCloseCustomer_Click(sender As Object, e As EventArgs) Handles btnCloseCustomer.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshCustomer_Click(sender As Object, e As EventArgs) Handles btnRefreshCustomer.Click
        LoadCustomerData()
    End Sub
    Private Sub dgvCustomer_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvCustomer.MouseUp
        Try
            txtCustomerID.Text = dgvCustomer.CurrentRow.Cells(0).Value.ToString
            txtCLastName.Text = dgvCustomer.CurrentRow.Cells(1).Value.ToString
            txtCFirstName.Text = dgvCustomer.CurrentRow.Cells(2).Value.ToString
            txtCMiddleName.Text = dgvCustomer.CurrentRow.Cells(3).Value.ToString
            txtCStreet.Text = dgvCustomer.CurrentRow.Cells(4).Value.ToString
            txtCCity.Text = dgvCustomer.CurrentRow.Cells(5).Value.ToString
            txtCState.Text = dgvCustomer.CurrentRow.Cells(6).Value.ToString
            txtCZipCode.Text = dgvCustomer.CurrentRow.Cells(7).Value.ToString
            txtCContactNo.Text = dgvCustomer.CurrentRow.Cells(8).Value.ToString
            txtCEmail.Text = dgvCustomer.CurrentRow.Cells(9).Value.ToString
            txtCDriverLicenseNo.Text = dgvCustomer.CurrentRow.Cells(10).Value.ToString
            row = dgvCustomer.CurrentRow.Index

            txtCustomerID.ForeColor = Color.Black
            txtCLastName.ForeColor = Color.Black
            txtCFirstName.ForeColor = Color.Black
            txtCMiddleName.ForeColor = Color.Black
            txtCStreet.ForeColor = Color.Black
            txtCCity.ForeColor = Color.Black
            txtCState.ForeColor = Color.Black
            txtCZipCode.ForeColor = Color.Black
            txtCContactNo.ForeColor = Color.Black
            txtCEmail.ForeColor = Color.Black
            txtCDriverLicenseNo.ForeColor = Color.Black

            btnAddCustomer.Enabled = False
            btnUpdateCustomer.Enabled = True
            btnDeleteCustomer.Enabled = True
            txtCustomerID.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txtCustomerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerSearch.TextChanged
        If txtCustomerSearch.Text = "" OrElse txtCustomerSearch.Text = "Search by Name, City, or License No..." Then
            LoadCustomerData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT CustomerID, CLastName, CFirstName, CMiddleName, " &
                                        "CStreet, CCity, CState, CZipCode, " &
                                        "CContactNo, CEmail, CDriverLicenseNo " &
                                        "FROM customer " &
                                        "WHERE CLastName LIKE '%" & txtCustomerSearch.Text & "%' " &
                                        "OR CFirstName LIKE '%" & txtCustomerSearch.Text & "%' " &
                                        "OR CCity LIKE '%" & txtCustomerSearch.Text & "%' " &
                                        "OR CDriverLicenseNo LIKE '%" & txtCustomerSearch.Text & "%' " &
                                        "ORDER BY CLastName ASC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "customer")
            dgvCustomer.DataSource = searchDS.Tables("customer")
            dgvCustomer.Columns(0).HeaderText = "Customer ID"
            dgvCustomer.Columns(1).HeaderText = "Last Name"
            dgvCustomer.Columns(2).HeaderText = "First Name"
            dgvCustomer.Columns(3).HeaderText = "Middle Name"
            dgvCustomer.Columns(4).HeaderText = "Street"
            dgvCustomer.Columns(5).HeaderText = "City"
            dgvCustomer.Columns(6).HeaderText = "State"
            dgvCustomer.Columns(7).HeaderText = "Zip Code"
            dgvCustomer.Columns(8).HeaderText = "Contact No"
            dgvCustomer.Columns(9).HeaderText = "Email"
            dgvCustomer.Columns(10).HeaderText = "Driver License No"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

End Class