Public Class frm_makeorder_a202713

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim price As Integer = 0
    Private current_order_id As String
    Private current_product_id As String
    Private Sub frm_makeorder_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_neworder()
        load_staff()
        load_cust()
        load_prod()
        InitializeOrderDetailsGrid()
    End Sub

    Private Sub refresh_grid()
        DateInput = DateInput
        cb_prod.Text = ""
        tb_qty.Text = ""
        PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub


    Private Sub load_staff()
        Try
            ' Fetch staff data
            Dim dt As DataTable = run_sql_query("SELECT FLD_STAFF_ID, FLD_STAFF_ID FROM TBL_STAFF_A202713")

            ' Bind data to ComboBox
            cb_staff.DataSource = dt
            cb_staff.DisplayMember = "FLD_STAFF_ID" ' What is displayed in the ComboBox
            cb_staff.ValueMember = "FLD_STAFF_ID"    ' Value behind each item

            ' Add a default blank item
            cb_staff.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error loading staff data: " & ex.Message)
        End Try
    End Sub

    Private Sub load_cust()
        Try
            ' Fetch customer data
            Dim dt As DataTable = run_sql_query("SELECT FLD_CUST_ID, FLD_CUST_PHONENUM FROM TBL_CUSTOMER_A202713")

            ' Bind data to ComboBox
            cb_cust.DataSource = dt
            cb_cust.DisplayMember = "FLD_CUST_PhoneNum"
            cb_cust.ValueMember = "FLD_CUST_ID"

            ' Add a default blank item
            cb_cust.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error loading customer data: " & ex.Message)
        End Try
    End Sub

    Private Sub load_prod()
        Try
            ' Fetch product data
            Dim dt As DataTable = run_sql_query("SELECT FLD_PRODUCT_ID, FLD_PRODUCT_NAME, FLD_PRODUCT_PRICE FROM TBL_PRODUCTS_A202713")

            ' Bind data to ComboBox
            cb_prod.DataSource = dt
            cb_prod.DisplayMember = "FLD_PRODUCT_NAME"
            cb_prod.ValueMember = "FLD_PRODUCT_ID"
            cb_prod.SelectedItem = "FLD_PRODUCT_PRICE"

            ' Add a default blank item
            cb_prod.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error loading product data: " & ex.Message)
        End Try
    End Sub

    Private Sub load_neworder()
        tb_order.Text = generate_id()
        DateInput = DateInput
        cb_staff.Text = ""
        cb_cust.Text = ""
        cb_prod.Text = ""
        tb_qty.Text = ""
        PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub InitializeOrderDetailsGrid()
        With grd_orderdetails
            .Columns.Clear()
            .Columns.Add("Product ID", "Product ID")
            .Columns.Add("ProductName", "Product Name")
            .Columns.Add("Quantity", "Quantity")
            .Columns.Add("UnitPrice", "Price Per Unit")
            .Columns.Add("TotalPrice", "Total Price")


            ' Set columns to read-only where necessary
            .Columns("ProductName").ReadOnly = True
            .Columns("TotalPrice").ReadOnly = True

            ' Format the price columns (optional)
            .Columns("UnitPrice").DefaultCellStyle.Format = "C2"
            .Columns("TotalPrice").DefaultCellStyle.Format = "C2"
        End With
    End Sub

    Private Sub AddToOrderDetailsGrid()
        Try
            ' Ensure a product is selected
            If cb_prod.SelectedIndex < 0 Then
                MsgBox("Please select a product.")
                Exit Sub
            End If

            ' Get the product name, quantity, and unit price
            Dim productName As String = cb_prod.Text
            Dim productID As String = cb_prod.SelectedValue.ToString()
            Dim quantity As Integer = CInt(tb_qty.Text)
            Dim unitPrice As Decimal = Convert.ToDecimal(DirectCast(cb_prod.SelectedItem, DataRowView)("FLD_PRODUCT_PRICE")) ' Example price per unit (fetch from database if needed)
            Dim totalPrice As Decimal = quantity * unitPrice

            ' Add the data to the DataGridView
            grd_orderdetails.Rows.Add(productID, productName, quantity, unitPrice, totalPrice)

            UpdateSummaryRow()

            ' Clear input fields for next entry
            cb_prod.SelectedIndex = -1
            tb_qty.Text = ""
            PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)


        Catch ex As Exception
            MsgBox("Error adding to order details: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateSummaryRow()
        ' Calculate tax and total with tax
        Dim taxRate As Decimal = 0.06D ' 6% tax
        Dim tax As Decimal = price * taxRate
        Dim totalWithTax As Decimal = price + tax

        ' Remove existing summary rows, if any
        For i As Integer = grd_orderdetails.Rows.Count - 1 To 0 Step -1
            If grd_orderdetails.Rows(i).Tag IsNot Nothing AndAlso grd_orderdetails.Rows(i).Tag.ToString() = "Summary" Then
                grd_orderdetails.Rows.RemoveAt(i)
            End If
        Next

        ' Add total price row
        Dim totalRow As DataGridViewRow = New DataGridViewRow()
        totalRow.CreateCells(grd_orderdetails)
        With totalRow
            .Cells(0).Value = ""
            .Cells(1).Value = ""
            .Cells(2).Value = ""
            .Cells(3).Value = "Total Price"
            .Cells(4).Value = price.ToString("C2")
            .DefaultCellStyle.Font = New Font(grd_orderdetails.Font, FontStyle.Bold)
            .Tag = "Summary"
        End With
        grd_orderdetails.Rows.Add(totalRow)

        ' Add tax row
        Dim taxRow As DataGridViewRow = New DataGridViewRow()
        taxRow.CreateCells(grd_orderdetails)
        With taxRow
            .Cells(0).Value = ""
            .Cells(1).Value = ""
            .Cells(2).Value = ""
            .Cells(3).Value = "Tax (6%)"
            .Cells(4).Value = tax.ToString("C2")
            .DefaultCellStyle.Font = New Font(grd_orderdetails.Font, FontStyle.Bold)
            .Tag = "Summary"
        End With
        grd_orderdetails.Rows.Add(taxRow)

        ' Add total with tax row
        Dim totalWithTaxRow As DataGridViewRow = New DataGridViewRow()
        totalWithTaxRow.CreateCells(grd_orderdetails)
        With totalWithTaxRow
            .Cells(0).Value = ""
            .Cells(1).Value = ""
            .Cells(2).Value = ""
            .Cells(3).Value = "Total with Tax"
            .Cells(4).Value = totalWithTax.ToString("C2")
            .DefaultCellStyle.Font = New Font(grd_orderdetails.Font, FontStyle.Bold)
            .DefaultCellStyle.ForeColor = Color.DarkBlue
            .Tag = "Summary"
        End With
        grd_orderdetails.Rows.Add(totalWithTaxRow)
    End Sub



    Private Function generate_id() As String
        Dim dt As DataTable = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A202713")
        Dim lastid As String = If(IsDBNull(dt.Rows(0).Item("LASTID")), "O000", dt.Rows(0).Item("LASTID").ToString())
        'check if the database is empty 

        Dim numericPart As Integer = CInt(Mid(lastid, 2))
        Dim newid As String = "O" & (numericPart + 1).ToString("000")


        Return newid

    End Function

    Private Sub cb_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_prod.SelectedIndexChanged
        Try
            If cb_prod.SelectedIndex >= 0 Then
                Dim prodID As String = cb_prod.SelectedValue.ToString()

                Dim imagePath As String = Application.StartupPath & "\pictures\" & prodID & ".jpg"

                ' Check if the file exists
                If IO.File.Exists(imagePath) Then
                    ' Load the product image
                    PictureBox1.BackgroundImage = Image.FromFile(imagePath)
                Else
                    ' Load the default "no photo" image if the file is missing
                    PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
                End If

            Else
                ' Clear the PictureBox if no product is selected
                PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
            End If
        Catch ex As Exception
            MsgBox("Error loading product image: " & ex.Message)
            ' Load default "no photo" image in case of an error
            PictureBox1.BackgroundImage = Image.FromFile(defaultpicture)
        End Try
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim mytransaction As OleDb.OleDbTransaction
        If String.IsNullOrWhiteSpace(tb_qty.Text) OrElse
            String.IsNullOrWhiteSpace(cb_cust.Text) OrElse
            String.IsNullOrWhiteSpace(cb_staff.Text) OrElse
            String.IsNullOrWhiteSpace(cb_prod.Text) Then
            MsgBox("Please fill in all required fields before placing the order.")
            Exit Sub
        End If


        Try
            ' Open the connection and start a transaction
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction()

            Dim orderID As String = tb_order.Text
            Dim orderDate As String = DateInput.Value.ToString("MM/dd/yyyy")
            Dim staffID As String = cb_staff.SelectedValue.ToString()
            Dim custID As String = cb_cust.SelectedValue.ToString()
            Dim prodID As String = cb_prod.SelectedValue.ToString() ' Product ID
            Dim quantity As Integer = Integer.Parse(tb_qty.Text)  ' Quantity
            Dim unitPrice As Decimal = Convert.ToDecimal(DirectCast(cb_prod.SelectedItem, DataRowView)("FLD_PRODUCT_PRICE")) 'product price
            Dim totalPrice As Decimal = quantity * unitPrice
            price += totalPrice

            ' Check if the order already exists in the database
            Dim dt As DataTable = run_sql_query("SELECT COUNT(*) AS OrderCount FROM TBL_ORDER_A202713 WHERE FLD_ORDER_ID = '" & orderID & "'")
            Dim exists As Boolean = CInt(dt.Rows(0)("OrderCount")) > 0

            If Not exists Then
                ' Insert the order if it does not exist
                Dim sqlOrder As String = "INSERT INTO TBL_ORDER_A202713 VALUES ('" & orderID & "', '" & totalPrice & "' , '" & orderDate & "', '" & staffID & "', '" & custID & "', '" & totalPrice * 0.06 & "')"
                Dim cmdOrder As New OleDb.OleDbCommand(sqlOrder, myconnection2, mytransaction)
                cmdOrder.ExecuteNonQuery()
            Else
                ' If the order exists, update the total price
                Dim sqlUpdateOrder As String = "UPDATE TBL_ORDER_A202713 SET FLD_ORDER_TPRICE = FLD_ORDER_TPRICE + " & totalPrice & ", FLD_PRICETAX = FLD_ORDER_TPRICE * 0.06 WHERE FLD_ORDER_ID = '" & orderID & "'"
                Dim cmdUpdateOrder As New OleDb.OleDbCommand(sqlUpdateOrder, myconnection2, mytransaction)
                cmdUpdateOrder.ExecuteNonQuery()
            End If

            ' Insert the order details
            Dim sqlOrderDetails As String = "INSERT INTO TBL_ORDERDETAILS_A202713 VALUES ('" & orderID & "', '" & prodID & "', " & quantity & ", " & unitPrice & ", " & totalPrice & ")"
            Dim cmdOrderDetails As New OleDb.OleDbCommand(sqlOrderDetails, myconnection2, mytransaction)
            cmdOrderDetails.ExecuteNonQuery()

            ' Commit the transaction
            mytransaction.Commit()
            MsgBox("Order and product saved successfully!")
            Beep()
            AddToOrderDetailsGrid()


        Catch ex As Exception

            MsgBox("Error saving order: " & ex.Message)
            Beep()

        Finally
            ' Ensure the connection is closed
            If myconnection2.State = ConnectionState.Open Then
                myconnection2.Close()
            End If
        End Try

        refresh_grid()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim mytransaction As OleDb.OleDbTransaction

        Try

            ' Open the connection and start a transaction
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction()

            'Dim sqlOrder As String = "UPDATE TBL_ORDER_A202713 SET FLD_ORDER_TPRICE='" & price & "', FLD_PRICETAX='" & price * 0.06 & "' WHERE FLD_ORDER_ID = '" & current_order_id & "'"
            'Dim cmdOrder As New OleDb.OleDbCommand(sqlOrder, myconnection2, mytransaction)
            'cmdOrder.ExecuteNonQuery()

            mytransaction.Commit()
            MsgBox("Order has been placed!")
            Beep()
            load_neworder()
            InitializeOrderDetailsGrid()


        Catch ex As Exception
            ' Rollback the transaction on error
            If mytransaction IsNot Nothing Then
                mytransaction.Rollback()
            End If
            MsgBox("Error saving order: " & ex.Message)
            Beep()

        Finally
            ' Ensure the connection is closed
            If myconnection2.State = ConnectionState.Open Then
                myconnection2.Close()
            End If
        End Try

    End Sub

    Private Sub grd_orderdetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_orderdetails.CellContentClick
        get_current_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim selectedRow As DataGridViewRow = grd_orderdetails.CurrentRow
        Dim productID As String = selectedRow.Cells("ProductName").Value.ToString()
        Dim totalPriceOfRow As Decimal = Convert.ToDecimal(selectedRow.Cells("TotalPrice").Value)

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_product_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_ORDERDETAILS_A202713 WHERE FLD_PRODUCT_ID='" & current_order_id & "' AND FLD_PRODUCT_ID = '" & current_product_id & "'")

            grd_orderdetails.Rows.Remove(selectedRow)

            ' Update the total price (subtract the deleted row's total price)
            price -= totalPriceOfRow

            ' Update the summary rows (Total, Tax, and Total with Tax)
            UpdateSummaryRow()

            Beep()
            MsgBox("The Product """ & current_product_id & """ has been successfully deleted.")

            refresh_grid()
            get_current_id()

        End If
    End Sub

    Private Sub get_current_id()
        Try
            ' Get the selected row index
            Dim current_row As Integer = grd_orderdetails.CurrentRow.Index

            ' Capture the OrderID and ProductID
            current_order_id = tb_order.Text ' Assuming tb_order holds the OrderID
            current_product_id = grd_orderdetails(0, current_row).Value.ToString() ' Assuming ProductID is in the first column
        Catch ex As Exception
            MsgBox("Error retrieving the selected product ID: " & ex.Message)
        End Try
    End Sub


End Class