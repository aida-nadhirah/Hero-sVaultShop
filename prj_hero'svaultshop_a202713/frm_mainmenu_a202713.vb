Public Class frm_mainmenu_a202713

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a202713.Show()
        Me.Hide()

    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        frm_cust_a202713.Show()
        Me.Hide()

    End Sub

    Private Sub btn_place_Click(sender As Object, e As EventArgs) Handles btn_place.Click
        frm_makeorder_a202713.Show()
        Me.Hide()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        frm_vieworder_a202713.Show()
        Me.Hide()
    End Sub
End Class
