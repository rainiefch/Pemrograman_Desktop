Public Class Form2
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim HomePage As New Form4
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim HomePage As New Form4
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class