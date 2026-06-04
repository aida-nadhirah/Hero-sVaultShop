Public Class frm_productdetails_a202713

    Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Hero'sVaultShop_A202713.accdb;Persist Security Info=False;"
    Private Sub frm_productdetails_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "Select fld_product_id from tbl_products_a202713"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_productid.DataSource = mydatatable
        lst_productid.DisplayMember = "Fld_product_id"

        refresh_text(lst_productid.Text)

    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_productid.MouseClick
        refresh_text(lst_productid.Text)
    End Sub

    Private Sub refresh_text(id As String)
        Dim mysql As String = "select * from tbl_products_a202713 where fld_product_id='" & id & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_name.Text = mydatatable.Rows(0).Item("fld_product_name")
        txt_price.Text = mydatatable.Rows(0).Item("fld_product_price")
        txt_category.Text = mydatatable.Rows(0).Item("fld_product_category")
        txt_condition.Text = mydatatable.Rows(0).Item("fld_product_condition")
        txt_manufacturer.Text = mydatatable.Rows(0).Item("fld_product_manufacturer")
        txt_brand.Text = mydatatable.Rows(0).Item("fld_product_brand")

        picproduct.BackgroundImage = Image.FromFile("pictures/" & id & ".jpg")

    End Sub

    Private Sub back_button_Click(sender As Object, e As EventArgs) Handles back_button.Click
        frm_product_a202713.Show()
        Me.Hide()
    End Sub

End Class