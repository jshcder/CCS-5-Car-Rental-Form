Imports MySql.Data.MySqlClient
Public Class frmPaymentDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim paymentDA As New MySqlDataAdapter
    Dim paymentDS As New DataSet()
    Dim paymentSQLQuery As String
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
    Private Sub txtPaymentSearch_Enter(sender As Object, e As EventArgs) Handles txtPaymentSearch.Enter
        ClearPlaceholder(txtPaymentSearch, "Search by Rental ID, Receipt No, or Status...")
    End Sub

    Private Sub txtPaymentSearch_Leave(sender As Object, e As EventArgs) Handles txtPaymentSearch.Leave
        SetPlaceholder(txtPaymentSearch, "Search by Rental ID, Receipt No, or Status...")
    End Sub

    Private Sub txtPaymentRentalID_Enter(sender As Object, e As EventArgs) Handles txtPaymentRentalID.Enter
        ClearPlaceholder(txtPaymentRentalID, "e.g. 5001")
    End Sub

    Private Sub txtPaymentRentalID_Leave(sender As Object, e As EventArgs) Handles txtPaymentRentalID.Leave
        SetPlaceholder(txtPaymentRentalID, "e.g. 5001")
        If txtPaymentRentalID.Text <> "e.g. 5001" AndAlso txtPaymentRentalID.Text <> "" Then
            AutoFillRentalInfoPayment()
        End If
    End Sub

    Private Sub txtPaymentNo_Enter(sender As Object, e As EventArgs) Handles txtPaymentNo.Enter
        ClearPlaceholder(txtPaymentNo, "e.g. 7004")
    End Sub

    Private Sub txtPaymentNo_Leave(sender As Object, e As EventArgs) Handles txtPaymentNo.Leave
        SetPlaceholder(txtPaymentNo, "e.g. 7004")
    End Sub

    Private Sub txtAmountPaid_Enter(sender As Object, e As EventArgs) Handles txtAmountPaid.Enter
        ClearPlaceholder(txtAmountPaid, "e.g. 1500.00")
    End Sub

    Private Sub txtAmountPaid_Leave(sender As Object, e As EventArgs) Handles txtAmountPaid.Leave
        SetPlaceholder(txtAmountPaid, "e.g. 1500.00")
    End Sub

    Private Sub txtReceiptNo_Enter(sender As Object, e As EventArgs) Handles txtReceiptNo.Enter
        ClearPlaceholder(txtReceiptNo, "e.g. OR-0004")
    End Sub

    Private Sub txtReceiptNo_Leave(sender As Object, e As EventArgs) Handles txtReceiptNo.Leave
        SetPlaceholder(txtReceiptNo, "e.g. OR-0004")
    End Sub

    Private Sub txtPaymentEmployeeID_Enter(sender As Object, e As EventArgs) Handles txtPaymentEmployeeID.Enter
        ClearPlaceholder(txtPaymentEmployeeID, "e.g. 1001")
    End Sub

    Private Sub txtPaymentEmployeeID_Leave(sender As Object, e As EventArgs) Handles txtPaymentEmployeeID.Leave
        SetPlaceholder(txtPaymentEmployeeID, "e.g. 1001")
        If txtPaymentEmployeeID.Text <> "e.g. 1001" AndAlso txtPaymentEmployeeID.Text <> "" Then
            AutoFillClerkInfoPayment()
        End If
    End Sub
    Private Sub AutoFillRentalInfoPayment()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand(
                "SELECT r.RentalID, r.DateRented, r.DateDueReturn, r.RentalStatus, " &
                "CONCAT(c.CFirstName, ' ', c.CLastName) AS CustomerName, " &
                "c.CContactNo, c.CEmail, " &
                "CONCAT(v.Brand, ' ', v.Model) AS Vehicle, " &
                "v.PlateNo " &
                "FROM rental r " &
                "JOIN customer c ON r.CustomerID = c.CustomerID " &
                "JOIN vehicle v ON r.VehicleID = v.VehicleID " &
                "WHERE r.RentalID = " & txtPaymentRentalID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtRentalInfoPayment.Text = "Rental ID    : " & reader("RentalID").ToString & vbNewLine &
                                           "Date Rented  : " & DateTime.Parse(reader("DateRented").ToString).ToString("MM/dd/yyyy") & vbNewLine &
                                           "Due Return   : " & DateTime.Parse(reader("DateDueReturn").ToString).ToString("MM/dd/yyyy") & vbNewLine &
                                           "Status       : " & reader("RentalStatus").ToString & vbNewLine &
                                           "Vehicle      : " & reader("Vehicle").ToString & vbNewLine &
                                           "Plate No     : " & reader("PlateNo").ToString
                txtCustomerInfoPayment.Text = "Customer     : " & reader("CustomerName").ToString & vbNewLine &
                                             "Contact      : " & reader("CContactNo").ToString & vbNewLine &
                                             "Email        : " & reader("CEmail").ToString
            Else
                txtRentalInfoPayment.Text = ""
                txtCustomerInfoPayment.Text = ""
                MsgBox("Rental ID not found.", MsgBoxStyle.Exclamation, "Rental Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub AutoFillClerkInfoPayment()
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim cmd As New MySqlCommand(
                "SELECT e.EFirstName, e.ELastName FROM employee e " &
                "INNER JOIN clerk c ON e.EmployeeID = c.EmployeeID " &
                "WHERE e.EmployeeID = " & txtPaymentEmployeeID.Text, MyConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtPaymentClerkName.Text = reader("EFirstName").ToString & " " & reader("ELastName").ToString
            Else
                txtPaymentClerkName.Text = "Not found"
                MsgBox("Employee ID not found or is not a Clerk.", MsgBoxStyle.Exclamation, "Employee Lookup")
            End If
            reader.Close()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub LoadPaymentData()
        Try
            dgvPayment.DataSource = Nothing

            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            paymentSQLQuery = "SELECT " &
                  "p.RentalID AS RentalID, " &
                  "p.PaymentNo AS PaymentNo, " &
                  "p.PaymentDate AS PaymentDate, " &
                  "p.AmountPaid AS AmountPaid, " &
                  "p.ReceiptNo AS ReceiptNo, " &
                  "p.PaymentMethod AS PaymentMethod, " &
                  "p.PaymentStatus AS PaymentStatus, " &
                  "p.EmployeeID AS EmployeeID, " &
                  "CONCAT(e.EFirstName, ' ', e.ELastName) AS ClerkName " &
                  "FROM payment p " &
                  "JOIN employee e ON p.EmployeeID = e.EmployeeID " &
                  "ORDER BY p.RentalID DESC"

            paymentDA = New MySqlDataAdapter(paymentSQLQuery, MyConnection)
            paymentDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(paymentDA)
            paymentDA.Fill(paymentDS, "payment")

            dgvPayment.DataSource = paymentDS.Tables("payment")

            If dgvPayment.Columns.Contains("RentalID") Then
                dgvPayment.Columns("RentalID").HeaderText = "Rental ID"
            End If

            If dgvPayment.Columns.Contains("PaymentNo") Then
                dgvPayment.Columns("PaymentNo").HeaderText = "Payment No"
            End If

            If dgvPayment.Columns.Contains("PaymentDate") Then
                dgvPayment.Columns("PaymentDate").HeaderText = "Payment Date"
            End If

            If dgvPayment.Columns.Contains("AmountPaid") Then
                dgvPayment.Columns("AmountPaid").HeaderText = "Amount Paid"
            End If

            If dgvPayment.Columns.Contains("ReceiptNo") Then
                dgvPayment.Columns("ReceiptNo").HeaderText = "Receipt No"
            End If

            If dgvPayment.Columns.Contains("PaymentMethod") Then
                dgvPayment.Columns("PaymentMethod").HeaderText = "Payment Method"
            End If

            If dgvPayment.Columns.Contains("PaymentStatus") Then
                dgvPayment.Columns("PaymentStatus").HeaderText = "Payment Status"
            End If

            If dgvPayment.Columns.Contains("EmployeeID") Then
                dgvPayment.Columns("EmployeeID").Visible = False
            End If

            If dgvPayment.Columns.Contains("ClerkName") Then
                dgvPayment.Columns("ClerkName").HeaderText = "Clerk"
            End If
            dgvPayment.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
    Private Sub ClearPaymentFields()
        txtPaymentRentalID.Text = ""
        SetPlaceholder(txtPaymentRentalID, "e.g. 5001")
        txtPaymentNo.Text = ""
        SetPlaceholder(txtPaymentNo, "e.g. 7004")
        txtAmountPaid.Text = ""
        SetPlaceholder(txtAmountPaid, "e.g. 1500.00")
        txtReceiptNo.Text = ""
        SetPlaceholder(txtReceiptNo, "e.g. OR-0004")
        txtPaymentEmployeeID.Text = ""
        SetPlaceholder(txtPaymentEmployeeID, "e.g. 1001")
        txtPaymentClerkName.Clear()
        txtRentalInfoPayment.Clear()
        txtCustomerInfoPayment.Clear()
        cbPaymentMethod.SelectedIndex = -1
        cbPaymentStatus.SelectedIndex = -1
        dtpPaymentDate.Value = DateTime.Now
        txtPaymentRentalID.Focus()
        btnAddPayment.Enabled = True
        btnUpdatePayment.Enabled = False
        btnDeletePayment.Enabled = False
        txtPaymentRentalID.Enabled = True
        txtPaymentNo.Enabled = True
    End Sub
    Private Sub frmPaymentDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentData()
        btnUpdatePayment.Enabled = False
        btnDeletePayment.Enabled = False
        SetPlaceholder(txtPaymentSearch, "Search by Rental ID, Receipt No, or Status...")
        SetPlaceholder(txtPaymentRentalID, "e.g. 5001")
        SetPlaceholder(txtPaymentNo, "e.g. 7004")
        SetPlaceholder(txtAmountPaid, "e.g. 1500.00")
        SetPlaceholder(txtReceiptNo, "e.g. OR-0004")
        SetPlaceholder(txtPaymentEmployeeID, "e.g. 1001")
    End Sub
    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        If txtPaymentRentalID.Text = "" OrElse txtPaymentRentalID.Text = "e.g. 5001" OrElse
           txtPaymentNo.Text = "" OrElse txtPaymentNo.Text = "e.g. 7004" OrElse
           txtAmountPaid.Text = "" OrElse txtAmountPaid.Text = "e.g. 1500.00" OrElse
           txtReceiptNo.Text = "" OrElse txtReceiptNo.Text = "e.g. OR-0004" OrElse
           txtPaymentEmployeeID.Text = "" OrElse txtPaymentEmployeeID.Text = "e.g. 1001" OrElse
           cbPaymentMethod.SelectedIndex = -1 OrElse cbPaymentStatus.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = paymentDS.Tables("payment")
            Dim newRow As DataRow = dt.NewRow()
            newRow("RentalID") = txtPaymentRentalID.Text
            newRow("PaymentNo") = txtPaymentNo.Text
            newRow("PaymentDate") = dtpPaymentDate.Value.ToString("yyyy-MM-dd")
            newRow("AmountPaid") = txtAmountPaid.Text
            newRow("ReceiptNo") = txtReceiptNo.Text
            newRow("PaymentMethod") = cbPaymentMethod.Text
            newRow("PaymentStatus") = cbPaymentStatus.Text
            newRow("EmployeeID") = txtPaymentEmployeeID.Text
            dt.Rows.Add(newRow)
            paymentDA.Update(paymentDS, "payment")
            MsgBox("Payment record successfully added!", MsgBoxStyle.Information, "Success")
            ClearPaymentFields()
            LoadPaymentData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdatePayment_Click(sender As Object, e As EventArgs) Handles btnUpdatePayment.Click
        Try
            Dim dt As DataTable = paymentDS.Tables("payment")
            dt.Rows(row)("PaymentDate") = dtpPaymentDate.Value.ToString("yyyy-MM-dd")
            dt.Rows(row)("AmountPaid") = txtAmountPaid.Text
            dt.Rows(row)("ReceiptNo") = txtReceiptNo.Text
            dt.Rows(row)("PaymentMethod") = cbPaymentMethod.Text
            dt.Rows(row)("PaymentStatus") = cbPaymentStatus.Text
            dt.Rows(row)("EmployeeID") = txtPaymentEmployeeID.Text
            paymentDA.Update(paymentDS, "payment")
            MsgBox("Payment record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearPaymentFields()
            LoadPaymentData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeletePayment_Click(sender As Object, e As EventArgs) Handles btnDeletePayment.Click
        Dim result = MsgBox("Are you sure you want to delete this payment record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = paymentDS.Tables("payment")
                dt.Rows(row).Delete()
                paymentDA.Update(paymentDS, "payment")
                MsgBox("Payment record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearPaymentFields()
                LoadPaymentData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnClearPayment_Click(sender As Object, e As EventArgs) Handles btnClearPayment.Click
        ClearPaymentFields()
    End Sub

    Private Sub btnClosePayment_Click(sender As Object, e As EventArgs) Handles btnClosePayment.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshPayment_Click(sender As Object, e As EventArgs) Handles btnRefreshPayment.Click
        LoadPaymentData()
    End Sub
    Private Sub dgvPayment_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvPayment.MouseUp
        Try
            txtPaymentRentalID.Text = dgvPayment.CurrentRow.Cells(0).Value.ToString
            txtPaymentNo.Text = dgvPayment.CurrentRow.Cells(1).Value.ToString
            dtpPaymentDate.Value = DateTime.Parse(dgvPayment.CurrentRow.Cells(2).Value.ToString)
            txtAmountPaid.Text = dgvPayment.CurrentRow.Cells(3).Value.ToString
            txtReceiptNo.Text = dgvPayment.CurrentRow.Cells(4).Value.ToString
            cbPaymentMethod.Text = dgvPayment.CurrentRow.Cells(5).Value.ToString
            cbPaymentStatus.Text = dgvPayment.CurrentRow.Cells(6).Value.ToString
            txtPaymentEmployeeID.Text = dgvPayment.CurrentRow.Cells(7).Value.ToString
            txtPaymentClerkName.Text = dgvPayment.CurrentRow.Cells(8).Value.ToString
            row = dgvPayment.CurrentRow.Index

            AutoFillRentalInfoPayment()

            txtPaymentRentalID.ForeColor = Color.Black
            txtPaymentNo.ForeColor = Color.Black
            txtAmountPaid.ForeColor = Color.Black
            txtReceiptNo.ForeColor = Color.Black
            txtPaymentEmployeeID.ForeColor = Color.Black

            btnAddPayment.Enabled = False
            btnUpdatePayment.Enabled = True
            btnDeletePayment.Enabled = True
            txtPaymentRentalID.Enabled = False
            txtPaymentNo.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txtPaymentSearch_TextChanged(sender As Object, e As EventArgs) Handles txtPaymentSearch.TextChanged
        If txtPaymentSearch.Text = "" OrElse txtPaymentSearch.Text = "Search by Rental ID, Receipt No, or Status..." Then
            LoadPaymentData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT p.RentalID, p.PaymentNo, " &
                                        "p.PaymentDate, p.AmountPaid, p.ReceiptNo, " &
                                        "p.PaymentMethod, p.PaymentStatus, " &
                                        "p.EmployeeID, " &
                                        "CONCAT(e.EFirstName, ' ', e.ELastName) AS ClerkName " &
                                        "FROM payment p " &
                                        "JOIN employee e ON p.EmployeeID = e.EmployeeID " &
                                        "WHERE CAST(p.RentalID AS CHAR) LIKE '%" & txtPaymentSearch.Text & "%' " &
                                        "OR p.ReceiptNo LIKE '%" & txtPaymentSearch.Text & "%' " &
                                        "OR p.PaymentStatus LIKE '%" & txtPaymentSearch.Text & "%' " &
                                        "OR p.PaymentMethod LIKE '%" & txtPaymentSearch.Text & "%' " &
                                        "ORDER BY p.RentalID DESC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "payment")
            dgvPayment.DataSource = searchDS.Tables("payment")
            dgvPayment.Columns(0).HeaderText = "Rental ID"
            dgvPayment.Columns(1).HeaderText = "Payment No"
            dgvPayment.Columns(2).HeaderText = "Payment Date"
            dgvPayment.Columns(3).HeaderText = "Amount Paid"
            dgvPayment.Columns(4).HeaderText = "Receipt No"
            dgvPayment.Columns(5).HeaderText = "Payment Method"
            dgvPayment.Columns(6).HeaderText = "Payment Status"
            dgvPayment.Columns(7).Visible = False
            dgvPayment.Columns(8).HeaderText = "Clerk"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

End Class