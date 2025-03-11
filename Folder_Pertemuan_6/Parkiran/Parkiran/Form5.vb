Public Class Form5
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim HomePage As New Form4
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class