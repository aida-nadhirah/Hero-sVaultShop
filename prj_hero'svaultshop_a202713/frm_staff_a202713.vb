Public Class frm_staff_a202713
    Private Sub frm_staff_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_Hero'sVaultShop_A202713.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_Staff_A202713"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub btn_post_Click(sender As Object, e As EventArgs) Handles btn_post.Click
        frm_position_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_mng_Click(sender As Object, e As EventArgs) Handles btn_mng.Click
        frm_managestaff_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a202713.Show()
        Me.Hide()
    End Sub
End Class