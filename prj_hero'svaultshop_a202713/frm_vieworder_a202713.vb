Public Class frm_vieworder_a202713
    Dim current_id As String
    Dim price As Integer = 0
    Private Sub frm_vieworder_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_grdorder()

    End Sub
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        load_grddetails()

    End Sub

    Private Sub grd_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_order.CellClick
        get_current_id()
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_order.CurrentRow.Index
        current_id = grd_order(0, current_row).Value

    End Sub

    Private Sub load_grdorder()
        grd_order.DataSource = run_sql_query("SELECT * FROM TBL_ORDER_A202713")

        If grd_order.Rows.Count > 0 Then
            grd_order.Rows(0).Selected = True
            get_current_id()
        End If
    End Sub

    Private Sub load_grddetails()
        Try
            ' Ensure a valid current_id is selected
            If String.IsNullOrEmpty(current_id) Then
                MessageBox.Show("Please select an order first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim mysql2 As String = "SELECT * FROM TBL_ORDER_A202713 WHERE fld_order_id = '" & current_id & "'"
            Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
            Dim dt As New DataTable
            ' Fill the DataTable with data

            myreader2.Fill(dt)

            ' Check if the DataTable has rows
            If dt.Rows.Count > 0 Then

                With grd_orderdetails
                    .Columns.Clear()
                    .Columns.Add("Product ID", "Product ID")
                    .Columns.Add("Quantity", "Quantity")
                    .Columns.Add("UnitPrice", "Price Per Unit")
                    .Columns.Add("TotalPrice", "Total Price")

                    .Columns("TotalPrice").ReadOnly = True

                    ' Format the price columns (optional)
                    .Columns("UnitPrice").DefaultCellStyle.Format = "C2"
                    .Columns("TotalPrice").DefaultCellStyle.Format = "C2"
                End With
                ' Get the prices after filling the DataTable
                Dim totalPrice As Decimal = Convert.ToDecimal(dt.Rows(0)("FLD_ORDER_TPRICE"))
                Dim taxPrice As Decimal = Convert.ToDecimal(dt.Rows(0)("FLD_PRICETAX"))
                Dim totalWithTax As Decimal = totalPrice + taxPrice

                txt_ID.Text = current_id
                Dim orderDate As Date = dt.Rows(0)("fld_order_date")
                txt_date.Text = orderDate.ToString("dd-MM-yyyy") ' Format as needed

                ' Query to get the order details
                Dim mysql As String = "SELECT fld_product_id, fld_product_qty, fld_pricepprod, FLD_SUBTOTAL FROM tbl_orderdetails_a202713 WHERE fld_order_id= '" & current_id & "'"
                Dim mydatatable As New DataTable
                Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

                myreader.Fill(mydatatable)

                If mydatatable.Rows.Count > 0 Then
                    For Each row As DataRow In mydatatable.Rows
                        Dim product_id As String = Convert.ToString(row("fld_product_id"))
                        Dim qty As Decimal = Convert.ToDecimal(row("fld_product_qty"))
                        Dim pricepprod As Decimal = Convert.ToDecimal(row("fld_pricepprod"))
                        Dim subtotal As Decimal = Convert.ToDecimal(row("fld_subtotal"))

                        grd_orderdetails.Rows.Add(product_id, qty, pricepprod.ToString("C2"), subtotal.ToString("C2"))
                    Next
                End If

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
                    .Cells(2).Value = "Total Price"
                    .Cells(3).Value = totalPrice.ToString("C2")
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
                    .Cells(2).Value = "Tax (6%)"
                    .Cells(3).Value = taxPrice.ToString("C2")
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
                    .Cells(2).Value = "Total with Tax"
                    .Cells(3).Value = totalWithTax.ToString("C2")
                    .DefaultCellStyle.Font = New Font(grd_orderdetails.Font, FontStyle.Bold)
                    .DefaultCellStyle.ForeColor = Color.DarkBlue
                    .Tag = "Summary"
                End With
                grd_orderdetails.Rows.Add(totalWithTaxRow)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu_a202713.Show()
        Me.Hide()
    End Sub
End Class