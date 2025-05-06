Public Class FrmHistogram
    Private Sub FrmHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim bmp = New Bitmap(Form1.PictureBox1.Image)
        Dim frekR(255), frekG(255), frekB(255) As Integer

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim px = bmp.GetPixel(x, y)
                frekR(px.R) += 1
                frekG(px.G) += 1
                frekB(px.B) += 1
            Next
        Next
        For i As Integer = 0 To 255
            If frekR(i) > max Then max = frekR(i)
            If frekG(i) > max Then max = frekG(i)
            If frekB(i) > max Then max = frekB(i)
        Next

        Dim histWidth As Integer = PictureBox1.Width
        Dim histHeight As Integer = PictureBox1.Height
        Dim histo As New Bitmap(histWidth, histHeight)
        Dim gCanvas As Graphics = Graphics.FromImage(histo)
        gCanvas.Clear(Color.White)

        Dim barWidth As Single = histWidth / 256.0F

        For i As Integer = 0 To 255
            Dim rHeight = CSng(frekR(i)) / max * histHeight
            Dim gHeight = CSng(frekG(i)) / max * histHeight
            Dim bHeight = CSng(frekB(i)) / max * histHeight

            gCanvas.DrawLine(Pens.Red, i * barWidth, histHeight, i * barWidth, histHeight - rHeight)
            gCanvas.DrawLine(Pens.Green, i * barWidth + 1, histHeight, i * barWidth + 1, histHeight - gHeight)
            gCanvas.DrawLine(Pens.Blue, i * barWidth + 2, histHeight, i * barWidth + 2, histHeight - bHeight)
        Next

        PictureBox1.Image = histo
        gCanvas.Dispose()
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class