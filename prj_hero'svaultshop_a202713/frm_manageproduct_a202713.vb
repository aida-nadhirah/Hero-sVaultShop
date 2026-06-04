Imports System.IO

Public Class frm_manageproduct_a202713

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Dim current_id As String

    Private Sub frm_insertproduct_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        clear_fields()
    End Sub
    Private Sub refresh_grid()
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A202713")

    End Sub

    Private Sub clear_fields()
        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_price.Text = ""
        txt_cat.Text = ""
        txt_brand.Text = ""
        txt_cond.Text = ""
        txt_manu.Text = ""
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_product.CurrentRow.Index
        current_id = grd_product(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_cat.Text = grd_product(3, current_row).Value
        txt_brand.Text = grd_product(4, current_row).Value
        txt_cond.Text = grd_product(5, current_row).Value
        txt_manu.Text = grd_product(6, current_row).Value
        pic_product.BackgroundImage = Image.FromFile("pictures/" & current_id & ".jpg")

    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = " INSERT INTO TBL_PRODUCTS_A202713 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', 
                '" & txt_cat.Text & "','" & txt_brand.Text & "','" & txt_cond.Text & "','" & txt_manu.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            refresh_grid()
            clear_fields()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A202713").Rows(0).Item("LASTID")

        Dim newid As String = "P" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick
        get_current_id()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim rowsAffected As Integer = run_sql_command("UPDATE TBL_PRODUCTS_A202713 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRODUCT_PRICE='" & txt_price.Text & "', FLD_PRODUCT_CATEGORY='" &
                        txt_cat.Text & "', FLD_PRODUCT_BRAND='" & txt_brand.Text & "', FLD_PRODUCT_CONDITION='" & txt_cond.Text & "', FLD_PRODUCT_MANUFACTURER='" & txt_manu.Text & "'
                        WHERE FLD_PRODUCT_ID='" & current_id & "'")

        If rowsAffected > 0 Then
            ' Success: Show success message and refresh UI
            Beep()
            MsgBox("You have successfully updated the product information """ & current_id & """.")
            refresh_grid()
            clear_fields()
            get_current_id()
        Else
            ' Failure: Provide feedback if no rows were updated
            Beep()
            MsgBox("No records were updated. Please verify the entered data.")
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_PRODUCTS_A202713 WHERE FLD_PRODUCT_ID='" & current_id & "'")

            Dim picturePath As String = Application.StartupPath & "\pictures\" & current_id & ".jpg"

            If System.IO.File.Exists(picturePath) Then
                If pic_product.BackgroundImage IsNot Nothing Then
                    pic_product.BackgroundImage.Dispose()
                    pic_product.BackgroundImage = Nothing
                End If
                System.IO.File.Delete(picturePath)
            End If

            Beep()
            MsgBox("The product """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        frm_product_a202713.Show()
        Me.Hide()
    End Sub
End Class