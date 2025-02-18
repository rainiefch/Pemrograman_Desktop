Public Class Form2
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        MessageBox.Show("Booking Completed!")
        For Each frm As Form In Application.OpenForms
            frm.Close()
        Next
    End Sub
End Class