Public Class Form1

    Dim namafile As String

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files(*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files(*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
            ElseIf saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub Property_Click(sender As Object, e As EventArgs) Handles PropertyToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub Grayscale_Click(sender As Object, e As EventArgs) Handles GrayscaleToolStripMenuItem.Click

        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Lighten_Click(sender As Object, e As EventArgs) Handles LightenToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = Math.Min(bmp.GetPixel(kol, bar).R + 10, 255)
                g = Math.Min(bmp.GetPixel(kol, bar).G + 10, 255)
                b = Math.Min(bmp.GetPixel(kol, bar).B + 10, 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Darken_Click(sender As Object, e As EventArgs) Handles DarkenToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = Math.Max(bmp.GetPixel(kol, bar).R - 10, 0)
                g = Math.Max(bmp.GetPixel(kol, bar).G - 10, 0)
                b = Math.Max(bmp.GetPixel(kol, bar).B - 10, 0)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub AddContrast_Click(sender As Object, e As EventArgs) Handles AddContrastToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = Math.Clamp(Math.Round(128 + 1.1 * (bmp.GetPixel(kol, bar).R - 128)), 0, 255)
                g = Math.Clamp(Math.Round(128 + 1.1 * (bmp.GetPixel(kol, bar).G - 128)), 0, 255)
                b = Math.Clamp(Math.Round(128 + 1.1 * (bmp.GetPixel(kol, bar).B - 128)), 0, 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ReduceContrast_Click(sender As Object, e As EventArgs) Handles ReduceContrastToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To bmp.Height - 1
            For kol As Integer = 0 To bmp.Width - 1
                r = Math.Clamp(Math.Round(128 + 0.90909 * (bmp.GetPixel(kol, bar).R - 128)), 0, 255)
                g = Math.Clamp(Math.Round(128 + 0.90909 * (bmp.GetPixel(kol, bar).G - 128)), 0, 255)
                b = Math.Clamp(Math.Round(128 + 0.90909 * (bmp.GetPixel(kol, bar).B - 128)), 0, 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        PictureBox1.Image = Image.FromFile(namafile)
    End Sub

    Private Sub ShowHistogram_Click(sender As Object, e As EventArgs) Handles ShowHistrogramToolStripMenuItem.Click
        FrmHistogram.ShowDialog()
    End Sub

    Private Sub Sharpen_Click(sender As Object, e As EventArgs) Handles SharpenToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        ApplyConvolution(bmp, kernel, 3)
    End Sub

    Private Sub Blur_Click(sender As Object, e As EventArgs) Handles BlurToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        ApplyConvolution(bmp, kernel, 9)
    End Sub

    Private Sub Rotate90_Click(sender As Object, e As EventArgs) Handles Rotate90ToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontal_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipVertical_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub


    Private Sub LightSharpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightSharpenToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim r, g, b As Integer
        Dim kernel As Integer() = {0, -1, 0, -1, 5, -1, 0, -1, 0}

        For bar As Integer = 1 To bmp.Height - 2
            For kol As Integer = 1 To bmp.Width - 2
                r = 0 : g = 0 : b = 0
                For i As Integer = 0 To 8
                    Dim px = bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3))
                    r += kernel(i) * px.R
                    g += kernel(i) * px.G
                    b += kernel(i) * px.B
                Next
                r = Math.Min(Math.Max(r, 0), 255)
                g = Math.Min(Math.Max(g, 0), 255)
                b = Math.Min(Math.Max(b, 0), 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub


    Private Sub GaussianBlurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GaussianBlurToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim r, g, b As Integer
        Dim kernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}
        Dim weightSum As Integer = 16

        For bar As Integer = 1 To bmp.Height - 2
            For kol As Integer = 1 To bmp.Width - 2
                r = 0 : g = 0 : b = 0
                For i As Integer = 0 To 8
                    Dim px = bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3))
                    r += kernel(i) * px.R
                    g += kernel(i) * px.G
                    b += kernel(i) * px.B
                Next
                r = Math.Min(Math.Max(r \ weightSum, 0), 255)
                g = Math.Min(Math.Max(g \ weightSum, 0), 255)
                b = Math.Min(Math.Max(b \ weightSum, 0), 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub


    Private Sub ApplyConvolution(bmp As Bitmap, kernel As Integer(), divider As Integer)
        Dim r, g, b As Integer
        For bar As Integer = 1 To bmp.Height - 2
            For kol As Integer = 1 To bmp.Width - 2
                r = 0 : g = 0 : b = 0
                For i As Integer = 0 To 8
                    Dim px = bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3))
                    r += kernel(i) * px.R
                    g += kernel(i) * px.G
                    b += kernel(i) * px.B
                Next
                r = Math.Clamp(r \ divider, 0, 255)
                g = Math.Clamp(g \ divider, 0, 255)
                b = Math.Clamp(b \ divider, 0, 255)
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EmbossToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbossToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Harap buka gambar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim bmp As New Bitmap(PictureBox1.Image)
        Dim width As Integer = bmp.Width
        Dim height As Integer = bmp.Height
        Dim result As New Bitmap(width, height)

        Dim kernel(,) As Integer = {
            {-2, -1, 0},
            {-1, 1, 1},
            {0, 1, 2}
        }

        For y As Integer = 1 To height - 2
            For x As Integer = 1 To width - 2
                Dim r, g, b As Integer
                r = 0 : g = 0 : b = 0

                ' Konvolusi 3x3
                For ky As Integer = -1 To 1
                    For kx As Integer = -1 To 1
                        Dim pixel As Color = bmp.GetPixel(x + kx, y + ky)
                        r += pixel.R * kernel(ky + 1, kx + 1)
                        g += pixel.G * kernel(ky + 1, kx + 1)
                        b += pixel.B * kernel(ky + 1, kx + 1)
                    Next
                Next

                ' Tambahkan offset agar hasil tidak negatif
                r = Math.Min(255, Math.Max(0, r + 128))
                g = Math.Min(255, Math.Max(0, g + 128))
                b = Math.Min(255, Math.Max(0, b + 128))

                result.SetPixel(x, y, Color.FromArgb(r, g, b))
            Next
        Next

        PictureBox1.Image = result
    End Sub
End Class
