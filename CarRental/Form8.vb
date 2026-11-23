Imports MySql.Data.MySqlClient
Public Class frmEmployeeDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim employeeDA As New MySqlDataAdapter
    Dim employeeDS As New DataSet()
    Dim employeeSQLQuery As String
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

    Private Sub txtEmployeeSearch_Enter(sender As Object, e As EventArgs) Handles txtEmployeeSearch.Enter
        ClearPlaceholder(txtEmployeeSearch, "Search by Name or Employee Type...")
    End Sub

    Private Sub txtEmployeeSearch_Leave(sender As Object, e As EventArgs) Handles txtEmployeeSearch.Leave
        SetPlaceholder(txtEmployeeSearch, "Search by Name or Employee Type...")
    End Sub

    Private Sub txtEmployeeID_Enter(sender As Object, e As EventArgs) Handles txtEmployeeID.Enter
        ClearPlaceholder(txtEmployeeID, "e.g. 1007")
    End Sub

    Private Sub txtEmployeeID_Leave(sender As Object, e As EventArgs) Handles txtEmployeeID.Leave
        SetPlaceholder(txtEmployeeID, "e.g. 1007")
    End Sub

    Private Sub txtELastName_Enter(sender As Object, e As EventArgs) Handles txtELastName.Enter
        ClearPlaceholder(txtELastName, "e.g. Dela Cruz")
    End Sub

    Private Sub txtELastName_Leave(sender As Object, e As EventArgs) Handles txtELastName.Leave
        SetPlaceholder(txtELastName, "e.g. Dela Cruz")
    End Sub

    Private Sub txtEFirstName_Enter(sender As Object, e As EventArgs) Handles txtEFirstName.Enter
        ClearPlaceholder(txtEFirstName, "e.g. Juan")
    End Sub

    Private Sub txtEFirstName_Leave(sender As Object, e As EventArgs) Handles txtEFirstName.Leave
        SetPlaceholder(txtEFirstName, "e.g. Juan")
    End Sub

    Private Sub txtEMiddleName_Enter(sender As Object, e As EventArgs) Handles txtEMiddleName.Enter
        ClearPlaceholder(txtEMiddleName, "e.g. Santos")
    End Sub

    Private Sub txtEMiddleName_Leave(sender As Object, e As EventArgs) Handles txtEMiddleName.Leave
        SetPlaceholder(txtEMiddleName, "e.g. Santos")
    End Sub

    Private Sub txtEContactNo_Enter(sender As Object, e As EventArgs) Handles txtEContactNo.Enter
        ClearPlaceholder(txtEContactNo, "e.g. 09171234567")
    End Sub

    Private Sub txtEContactNo_Leave(sender As Object, e As EventArgs) Handles txtEContactNo.Leave
        SetPlaceholder(txtEContactNo, "e.g. 09171234567")
    End Sub

    Private Sub LoadEmployeeData()
        Try
            dgvEmployee.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            employeeSQLQuery = "SELECT e.EmployeeID, e.ELastName, e.EFirstName, e.EMiddleName, " &
                               "e.EContactNo, " &
                               "CASE WHEN c.EmployeeID IS NOT NULL THEN 'Clerk' " &
                               "WHEN t.EmployeeID IS NOT NULL THEN 'Technician' " &
                               "ELSE 'Unknown' END AS EmployeeType " &
                               "FROM employee e " &
                               "LEFT JOIN clerk c ON e.EmployeeID = c.EmployeeID " &
                               "LEFT JOIN technician t ON e.EmployeeID = t.EmployeeID " &
                               "ORDER BY e.EmployeeID ASC"

            employeeDA = New MySqlDataAdapter(employeeSQLQuery, MyConnection)
            employeeDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(employeeDA)
            employeeDA.Fill(employeeDS, "employee")

            dgvEmployee.DataSource = employeeDS.Tables("employee")

            If dgvEmployee.Columns.Count = 0 Then Exit Sub

            If dgvEmployee.Columns.Contains("EmployeeID") Then
                dgvEmployee.Columns("EmployeeID").HeaderText = "Employee ID"
            End If

            If dgvEmployee.Columns.Contains("ELastName") Then
                dgvEmployee.Columns("ELastName").HeaderText = "Last Name"
            End If

            If dgvEmployee.Columns.Contains("EFirstName") Then
                dgvEmployee.Columns("EFirstName").HeaderText = "First Name"
            End If

            If dgvEmployee.Columns.Contains("EMiddleName") Then
                dgvEmployee.Columns("EMiddleName").HeaderText = "Middle Name"
            End If

            If dgvEmployee.Columns.Contains("EContactNo") Then
                dgvEmployee.Columns("EContactNo").HeaderText = "Contact No"
            End If

            If dgvEmployee.Columns.Contains("EType") Then
                dgvEmployee.Columns("EType").HeaderText = "Type"
            End If

            dgvEmployee.AutoResizeColumns()
            dgvEmployee.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ClearEmployeeFields()
        txtEmployeeID.Text = ""
        SetPlaceholder(txtEmployeeID, "e.g. 1007")
        txtELastName.Text = ""
        SetPlaceholder(txtELastName, "e.g. Dela Cruz")
        txtEFirstName.Text = ""
        SetPlaceholder(txtEFirstName, "e.g. Juan")
        txtEMiddleName.Text = ""
        SetPlaceholder(txtEMiddleName, "e.g. Santos")
        txtEContactNo.Text = ""
        SetPlaceholder(txtEContactNo, "e.g. 09171234567")
        cbEmployeeType.SelectedIndex = -1
        txtEmployeeID.Focus()
        btnAddEmployee.Enabled = True
        btnUpdateEmployee.Enabled = False
        btnDeleteEmployee.Enabled = False
        txtEmployeeID.Enabled = True
    End Sub

    Private Sub frmEmployeeDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
        btnUpdateEmployee.Enabled = False
        btnDeleteEmployee.Enabled = False
        SetPlaceholder(txtEmployeeSearch, "Search by Name or Employee Type...")
        SetPlaceholder(txtEmployeeID, "e.g. 1007")
        SetPlaceholder(txtELastName, "e.g. Dela Cruz")
        SetPlaceholder(txtEFirstName, "e.g. Juan")
        SetPlaceholder(txtEMiddleName, "e.g. Santos")
        SetPlaceholder(txtEContactNo, "e.g. 09171234567")
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If txtEmployeeID.Text = "" OrElse txtEmployeeID.Text = "e.g. 1007" OrElse
           txtELastName.Text = "" OrElse txtELastName.Text = "e.g. Dela Cruz" OrElse
           txtEFirstName.Text = "" OrElse txtEFirstName.Text = "e.g. Juan" OrElse
           txtEContactNo.Text = "" OrElse txtEContactNo.Text = "e.g. 09171234567" OrElse
           cbEmployeeType.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            'Insert into employee table
            Dim cmdEmployee As New MySqlCommand(
                "INSERT INTO employee (EmployeeID, ELastName, EFirstName, EMiddleName, EContactNo) " &
                "VALUES (" & txtEmployeeID.Text & ", '" & txtELastName.Text & "', '" &
                txtEFirstName.Text & "', '" &
                If(txtEMiddleName.Text = "e.g. Santos", "", txtEMiddleName.Text) & "', '" &
                txtEContactNo.Text & "')", MyConnection)
            cmdEmployee.ExecuteNonQuery()

            'Insert into clerk or technician based on type
            If cbEmployeeType.Text = "Clerk" Then
                Dim cmdClerk As New MySqlCommand(
                    "INSERT INTO clerk (EmployeeID) VALUES (" & txtEmployeeID.Text & ")", MyConnection)
                cmdClerk.ExecuteNonQuery()
            ElseIf cbEmployeeType.Text = "Technician" Then
                Dim cmdTech As New MySqlCommand(
                    "INSERT INTO technician (EmployeeID) VALUES (" & txtEmployeeID.Text & ")", MyConnection)
                cmdTech.ExecuteNonQuery()
            End If

            MyConnection.Close()
            MsgBox("Employee record successfully added!", MsgBoxStyle.Information, "Success")
            ClearEmployeeFields()
            LoadEmployeeData()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Try
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            Dim cmdUpdate As New MySqlCommand(
                "UPDATE employee SET ELastName = '" & txtELastName.Text & "', " &
                "EFirstName = '" & txtEFirstName.Text & "', " &
                "EMiddleName = '" & If(txtEMiddleName.Text = "e.g. Santos", "", txtEMiddleName.Text) & "', " &
                "EContactNo = '" & txtEContactNo.Text & "' " &
                "WHERE EmployeeID = " & txtEmployeeID.Text, MyConnection)
            cmdUpdate.ExecuteNonQuery()
            MyConnection.Close()

            MsgBox("Employee record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearEmployeeFields()
            LoadEmployeeData()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        Dim result = MsgBox("Are you sure you want to delete this employee record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                MyConnection = New MySqlConnection(MyConnectionString)
                MyConnection.Open()

                'Delete from clerk or technician first due to FK constraint
                Dim cmdClerk As New MySqlCommand(
                    "DELETE FROM clerk WHERE EmployeeID = " & txtEmployeeID.Text, MyConnection)
                cmdClerk.ExecuteNonQuery()

                Dim cmdTech As New MySqlCommand(
                    "DELETE FROM technician WHERE EmployeeID = " & txtEmployeeID.Text, MyConnection)
                cmdTech.ExecuteNonQuery()

                'Then delete from employee
                Dim cmdEmployee As New MySqlCommand(
                    "DELETE FROM employee WHERE EmployeeID = " & txtEmployeeID.Text, MyConnection)
                cmdEmployee.ExecuteNonQuery()

                MyConnection.Close()
                MsgBox("Employee record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearEmployeeFields()
                LoadEmployeeData()

            Catch ex As MySqlException
                MsgBox(ex.ToString)
            Finally
                MyConnection.Close()
            End Try
        End If
    End Sub

    Private Sub btnClearEmployee_Click(sender As Object, e As EventArgs) Handles btnClearEmployee.Click
        ClearEmployeeFields()
    End Sub

    Private Sub btnCloseEmployee_Click(sender As Object, e As EventArgs) Handles btnCloseEmployee.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshEmployee_Click(sender As Object, e As EventArgs) Handles btnRefreshEmployee.Click
        LoadEmployeeData()
    End Sub

    Private Sub dgvEmployee_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvEmployee.MouseUp
        Try
            txtEmployeeID.Text = dgvEmployee.CurrentRow.Cells(0).Value.ToString
            txtELastName.Text = dgvEmployee.CurrentRow.Cells(1).Value.ToString
            txtEFirstName.Text = dgvEmployee.CurrentRow.Cells(2).Value.ToString
            txtEMiddleName.Text = dgvEmployee.CurrentRow.Cells(3).Value.ToString
            txtEContactNo.Text = dgvEmployee.CurrentRow.Cells(4).Value.ToString
            cbEmployeeType.Text = dgvEmployee.CurrentRow.Cells(5).Value.ToString
            row = dgvEmployee.CurrentRow.Index

            txtEmployeeID.ForeColor = Color.Black
            txtELastName.ForeColor = Color.Black
            txtEFirstName.ForeColor = Color.Black
            txtEMiddleName.ForeColor = Color.Black
            txtEContactNo.ForeColor = Color.Black

            btnAddEmployee.Enabled = False
            btnUpdateEmployee.Enabled = True
            btnDeleteEmployee.Enabled = True
            txtEmployeeID.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtEmployeeSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeSearch.TextChanged
        If txtEmployeeSearch.Text = "" OrElse txtEmployeeSearch.Text = "Search by Name or Employee Type..." Then
            LoadEmployeeData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT e.EmployeeID, e.ELastName, e.EFirstName, e.EMiddleName, " &
                                        "e.EContactNo, " &
                                        "CASE WHEN c.EmployeeID IS NOT NULL THEN 'Clerk' " &
                                        "WHEN t.EmployeeID IS NOT NULL THEN 'Technician' " &
                                        "ELSE 'Unknown' END AS EmployeeType " &
                                        "FROM employee e " &
                                        "LEFT JOIN clerk c ON e.EmployeeID = c.EmployeeID " &
                                        "LEFT JOIN technician t ON e.EmployeeID = t.EmployeeID " &
                                        "WHERE e.ELastName LIKE '%" & txtEmployeeSearch.Text & "%' " &
                                        "OR e.EFirstName LIKE '%" & txtEmployeeSearch.Text & "%' " &
                                        "OR (CASE WHEN c.EmployeeID IS NOT NULL THEN 'Clerk' " &
                                        "WHEN t.EmployeeID IS NOT NULL THEN 'Technician' " &
                                        "ELSE 'Unknown' END) LIKE '%" & txtEmployeeSearch.Text & "%' " &
                                        "ORDER BY e.EmployeeID ASC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "employee")
            dgvEmployee.DataSource = searchDS.Tables("employee")
            dgvEmployee.Columns(0).HeaderText = "Employee ID"
            dgvEmployee.Columns(1).HeaderText = "Last Name"
            dgvEmployee.Columns(2).HeaderText = "First Name"
            dgvEmployee.Columns(3).HeaderText = "Middle Name"
            dgvEmployee.Columns(4).HeaderText = "Contact No"
            dgvEmployee.Columns(5).HeaderText = "Type"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class