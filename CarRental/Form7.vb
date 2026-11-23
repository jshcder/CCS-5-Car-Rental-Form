Imports MySql.Data.MySqlClient
Public Class frmCategoryDesign
    Dim MyConnection As MySqlConnection
    Dim MyConnectionString As String = "datasource=localhost;username=root;password=;database=carrentaldb"
    Dim categoryDA As New MySqlDataAdapter
    Dim categoryDS As New DataSet()
    Dim categorySQLQuery As String
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

    Private Sub txtCategorySearch_Enter(sender As Object, e As EventArgs) Handles txtCategorySearch.Enter
        ClearPlaceholder(txtCategorySearch, "Search by Category Name or Description...")
    End Sub

    Private Sub txtCategorySearch_Leave(sender As Object, e As EventArgs) Handles txtCategorySearch.Leave
        SetPlaceholder(txtCategorySearch, "Search by Category Name or Description...")
    End Sub

    Private Sub txtCategoryID_Enter(sender As Object, e As EventArgs) Handles txtCategoryID.Enter
        ClearPlaceholder(txtCategoryID, "e.g. 3004")
    End Sub

    Private Sub txtCategoryID_Leave(sender As Object, e As EventArgs) Handles txtCategoryID.Leave
        SetPlaceholder(txtCategoryID, "e.g. 3004")
    End Sub

    Private Sub txtCategoryName_Enter(sender As Object, e As EventArgs) Handles txtCategoryName.Enter
        ClearPlaceholder(txtCategoryName, "e.g. Sedan")
    End Sub

    Private Sub txtCategoryName_Leave(sender As Object, e As EventArgs) Handles txtCategoryName.Leave
        SetPlaceholder(txtCategoryName, "e.g. Sedan")
    End Sub

    Private Sub txtCategoryDescription_Enter(sender As Object, e As EventArgs) Handles txtCategoryDescription.Enter
        ClearPlaceholder(txtCategoryDescription, "e.g. Economy cars for city driving")
    End Sub

    Private Sub txtCategoryDescription_Leave(sender As Object, e As EventArgs) Handles txtCategoryDescription.Leave
        SetPlaceholder(txtCategoryDescription, "e.g. Economy cars for city driving")
    End Sub

    Private Sub txtRatePerDay_Enter(sender As Object, e As EventArgs) Handles txtRatePerDay.Enter
        ClearPlaceholder(txtRatePerDay, "e.g. 1500.00")
    End Sub

    Private Sub txtRatePerDay_Leave(sender As Object, e As EventArgs) Handles txtRatePerDay.Leave
        SetPlaceholder(txtRatePerDay, "e.g. 1500.00")
    End Sub

    Private Sub LoadCategoryData()
        Try
            dgvCategory.DataSource = Nothing
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()

            categorySQLQuery = "SELECT CategoryID, CategoryName, Description, RatePerDay " &
                               "FROM category ORDER BY CategoryID ASC"

            categoryDA = New MySqlDataAdapter(categorySQLQuery, MyConnection)
            categoryDS = New DataSet()
            Dim cb As New MySqlCommandBuilder(categoryDA)
            categoryDA.Fill(categoryDS, "category")

            dgvCategory.DataSource = categoryDS.Tables("category")

            If dgvCategory.Columns.Count = 0 Then Exit Sub

            If dgvCategory.Columns.Contains("CategoryID") Then
                dgvCategory.Columns("CategoryID").HeaderText = "Category ID"
            End If

            If dgvCategory.Columns.Contains("CategoryName") Then
                dgvCategory.Columns("CategoryName").HeaderText = "Category Name"
            End If

            If dgvCategory.Columns.Contains("Description") Then
                dgvCategory.Columns("Description").HeaderText = "Description"
            End If

            If dgvCategory.Columns.Contains("RatePerDay") Then
                dgvCategory.Columns("RatePerDay").HeaderText = "Rate Per Day"
            End If

            dgvCategory.AutoResizeColumns()
            dgvCategory.AutoResizeColumns()

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub

    Private Sub ClearCategoryFields()
        txtCategoryID.Text = ""
        SetPlaceholder(txtCategoryID, "e.g. 3004")
        txtCategoryName.Text = ""
        SetPlaceholder(txtCategoryName, "e.g. Sedan")
        txtCategoryDescription.Text = ""
        SetPlaceholder(txtCategoryDescription, "e.g. Economy cars for city driving")
        txtRatePerDay.Text = ""
        SetPlaceholder(txtRatePerDay, "e.g. 1500.00")
        txtCategoryID.Focus()
        btnAddCategory.Enabled = True
        btnUpdateCategory.Enabled = False
        btnDeleteCategory.Enabled = False
        txtCategoryID.Enabled = True
    End Sub

    Private Sub frmCategoryDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoryData()
        btnUpdateCategory.Enabled = False
        btnDeleteCategory.Enabled = False
        SetPlaceholder(txtCategorySearch, "Search by Category Name or Description...")
        SetPlaceholder(txtCategoryID, "e.g. 3004")
        SetPlaceholder(txtCategoryName, "e.g. Sedan")
        SetPlaceholder(txtCategoryDescription, "e.g. Economy cars for city driving")
        SetPlaceholder(txtRatePerDay, "e.g. 1500.00")
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        If txtCategoryID.Text = "" OrElse txtCategoryID.Text = "e.g. 3004" OrElse
           txtCategoryName.Text = "" OrElse txtCategoryName.Text = "e.g. Sedan" OrElse
           txtRatePerDay.Text = "" OrElse txtRatePerDay.Text = "e.g. 1500.00" Then
            MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation, "Incomplete Fields")
            Exit Sub
        End If
        Try
            Dim dt As DataTable = categoryDS.Tables("category")
            Dim newRow As DataRow = dt.NewRow()
            newRow("CategoryID") = txtCategoryID.Text
            newRow("CategoryName") = txtCategoryName.Text
            newRow("Description") = If(txtCategoryDescription.Text = "e.g. Economy cars for city driving", "", txtCategoryDescription.Text)
            newRow("RatePerDay") = txtRatePerDay.Text
            dt.Rows.Add(newRow)
            categoryDA.Update(categoryDS, "category")
            MsgBox("Category record successfully added!", MsgBoxStyle.Information, "Success")
            ClearCategoryFields()
            LoadCategoryData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdateCategory_Click(sender As Object, e As EventArgs) Handles btnUpdateCategory.Click
        Try
            Dim dt As DataTable = categoryDS.Tables("category")
            dt.Rows(row)("CategoryName") = txtCategoryName.Text
            dt.Rows(row)("Description") = If(txtCategoryDescription.Text = "e.g. Economy cars for city driving", "", txtCategoryDescription.Text)
            dt.Rows(row)("RatePerDay") = txtRatePerDay.Text
            categoryDA.Update(categoryDS, "category")
            MsgBox("Category record successfully updated!", MsgBoxStyle.Information, "Success")
            ClearCategoryFields()
            LoadCategoryData()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Dim result = MsgBox("Are you sure you want to delete this category record?",
                            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")
        If result = MsgBoxResult.Yes Then
            Try
                Dim dt As DataTable = categoryDS.Tables("category")
                dt.Rows(row).Delete()
                categoryDA.Update(categoryDS, "category")
                MsgBox("Category record successfully deleted!", MsgBoxStyle.Information, "Success")
                ClearCategoryFields()
                LoadCategoryData()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnClearCategory_Click(sender As Object, e As EventArgs) Handles btnClearCategory.Click
        ClearCategoryFields()
    End Sub

    Private Sub btnCloseCategory_Click(sender As Object, e As EventArgs) Handles btnCloseCategory.Click
        Me.Close()
    End Sub

    Private Sub btnRefreshCategory_Click(sender As Object, e As EventArgs) Handles btnRefreshCategory.Click
        LoadCategoryData()
    End Sub

    Private Sub dgvCategory_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvCategory.MouseUp
        Try
            txtCategoryID.Text = dgvCategory.CurrentRow.Cells(0).Value.ToString
            txtCategoryName.Text = dgvCategory.CurrentRow.Cells(1).Value.ToString
            txtCategoryDescription.Text = dgvCategory.CurrentRow.Cells(2).Value.ToString
            txtRatePerDay.Text = dgvCategory.CurrentRow.Cells(3).Value.ToString
            row = dgvCategory.CurrentRow.Index

            txtCategoryID.ForeColor = Color.Black
            txtCategoryName.ForeColor = Color.Black
            txtCategoryDescription.ForeColor = Color.Black
            txtRatePerDay.ForeColor = Color.Black

            btnAddCategory.Enabled = False
            btnUpdateCategory.Enabled = True
            btnDeleteCategory.Enabled = True
            txtCategoryID.Enabled = False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtCategorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtCategorySearch.TextChanged
        If txtCategorySearch.Text = "" OrElse txtCategorySearch.Text = "Search by Category Name or Description..." Then
            LoadCategoryData()
            Return
        End If
        Try
            Dim searchQuery As String = "SELECT CategoryID, CategoryName, Description, RatePerDay " &
                                        "FROM category " &
                                        "WHERE CategoryName LIKE '%" & txtCategorySearch.Text & "%' " &
                                        "OR Description LIKE '%" & txtCategorySearch.Text & "%' " &
                                        "ORDER BY CategoryID ASC"
            MyConnection = New MySqlConnection(MyConnectionString)
            MyConnection.Open()
            Dim searchDA As New MySqlDataAdapter(searchQuery, MyConnection)
            Dim searchDS As New DataSet()
            searchDA.Fill(searchDS, "category")
            dgvCategory.DataSource = searchDS.Tables("category")
            dgvCategory.Columns(0).HeaderText = "Category ID"
            dgvCategory.Columns(1).HeaderText = "Category Name"
            dgvCategory.Columns(2).HeaderText = "Description"
            dgvCategory.Columns(3).HeaderText = "Rate Per Day"
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        Finally
            MyConnection.Close()
        End Try
    End Sub
End Class