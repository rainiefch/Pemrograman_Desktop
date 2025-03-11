Public Class Form3
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim HomePage As New Form4
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class