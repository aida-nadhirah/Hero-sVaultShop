Public Class frm_product_a202713
    Private Sub frm_product_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Hero'sVaultShop_A202713.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_Products_A202713"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_product.DataSource = mydatatable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202713.Show()
        Me.Hide()

    End Sub

    Private Sub btn_mng_Click(sender As Object, e As EventArgs) Handles btn_mng.Click
        frm_manageproduct_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cat_Click(sender As Object, e As EventArgs) Handles btn_cat.Click
        frm_productdetails_a202713.Show()
        Me.Hide()
    End Sub
End Class