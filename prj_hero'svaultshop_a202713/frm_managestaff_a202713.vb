Public Class frm_managestaff_a202713

    Dim current_id As String
    Private Sub frm_insertstaff_a202713_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        clear_fields()
    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A202713")
    End Sub

    Private Sub clear_fields()

        txt_id.Text = generate_id()
        txt_name.Text = ""
        txt_Pid.Text = ""

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A202713").Rows(0).Item("LASTID")

        Dim newid As String = "S" & Mid(lastid, 2) + 1

        Return newid
    End Function

    Private Sub get_current_id()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_id = grd_staff(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_staff(1, current_row).Value
        txt_Pid.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A202713 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_Pid.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim rowsAffected As Integer = run_sql_command("UPDATE TBL_STAFF_A202713 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_POSITION_CODE='" & txt_Pid.Text & "' WHERE FLD_STAFF_ID='" & current_id & "'")

        If rowsAffected > 0 Then
            ' Success: Show success message and refresh UI
            Beep()
            MsgBox("You have successfully updated the staff information """ & current_id & """.")
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

            run_sql_command("DELETE FROM TBL_STAFF_A202713 WHERE FLD_STAFF_ID='" & current_id & "'")

            Beep()
            MsgBox("The STAFF """ & current_id & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_id()

        End If
    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick
        get_current_id()
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        frm_staff_a202713.Show()
        Me.Hide()
    End Sub
End Class