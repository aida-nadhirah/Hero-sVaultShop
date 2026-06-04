Public Class frm_orderdetail_a202713
    Private Sub frm_orderdetail_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Hero'sVaultShop_A202713.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_orderdetails_A202713"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orderdetail.DataSource = mydatatable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_order_a202713.Show()
        Me.Hide()
    End Sub
End Class