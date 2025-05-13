Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Form1
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim freeFormLines As New List(Of String) ' To store free-form drawing lines temporarily

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub RadioBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RadioGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RadioKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RadioElips_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RadioKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RadioElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        tepi.Width = NumericUpDown1.Value
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True

        ' Start a new free-form drawing action
        If modegambar = "bebas" Then
            freeFormLines.Clear()
            freeFormLines.Add("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString)
            freeFormLines.Add("o tebaltepi " + tepi.Width.ToString)
            freeFormLines.Add("o bebas") ' Mark the start of a free-form action
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()

                    ' Add each line segment to the temporary list
                    freeFormLines.Add("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "bebas"
                ' Complete the free-form action
                If freeFormLines.Count > 0 Then
                    freeFormLines.Add("o action_end") ' Mark the end of a free-form action
                    ' Add all lines to the textbox at once
                    For Each line As String In freeFormLines
                        TextBox1.AppendText(line & vbNewLine)
                    Next
                    freeFormLines.Clear()
                End If

            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
                TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                TextBox1.AppendText("o tebaltepi " + tepi.Width.ToString & vbNewLine)

            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
                TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                TextBox1.AppendText("o tebaltepi " + tepi.Width.ToString & vbNewLine)

            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
                TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                TextBox1.AppendText("o tebaltepi " + tepi.Width.ToString & vbNewLine)

            Case "kotakisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillRectangle(isian, rect)
                End Using
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
                TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                TextBox1.AppendText("o tebaltepi " + tepi.Width.ToString & vbNewLine)

            Case "elipsisi"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillEllipse(isian, rect)
                End Using
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
                TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & vbNewLine)
                TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & vbNewLine)
                TextBox1.AppendText("o tebaltepi " + tepi.Width.ToString & vbNewLine)
        End Select
        PictureBox1.Invalidate()
        dipencet = False
    End Sub

    Private Sub Warna1_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(sender As Object, e As MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Dim baris As List(Of String) = TextBox1.Lines.ToList()
        If baris.Count = 0 Then Return

        ' Find the start of the previous action
        Dim actionStartIndex As Integer = -1
        For i As Integer = baris.Count - 1 To 0 Step -1
            If baris(i).StartsWith("o action_start") OrElse
               baris(i).StartsWith("o garis ") OrElse
               baris(i).StartsWith("o kotak ") OrElse
               baris(i).StartsWith("o elips ") OrElse
               baris(i).StartsWith("o kotakisi ") OrElse
               baris(i).StartsWith("o elipsisi ") OrElse
               baris(i).StartsWith("o clear") OrElse
               baris(i).StartsWith("o bebas") Then
                actionStartIndex = i
                Exit For
            End If
        Next

        If actionStartIndex >= 0 Then
            ' Find all lines belonging to this action
            Dim actionEndIndex As Integer = baris.Count - 1
            For i As Integer = actionStartIndex To baris.Count - 1
                If baris(i).StartsWith("o action_end") Then
                    actionEndIndex = i
                    Exit For
                End If
            Next

            ' Remove all lines of this action
            baris.RemoveRange(actionStartIndex, actionEndIndex - actionStartIndex + 1)
            TextBox1.Lines = baris.ToArray()
            btnGbrUlang.PerformClick()
        End If
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
        TextBox1.AppendText("o clear" & vbNewLine) ' Add clear action to history
    End Sub

    Private Sub btnGbrUlang_Click(sender As Object, e As EventArgs) Handles btnGbrUlang.Click
        btnBersihkan.PerformClick()
        Dim a As Integer = TextBox1.Lines.Count - 1 ' Adjust for zero-based index
        For i As Integer = 0 To a
            Dim teksbaris As String = TextBox1.Lines(i)
            If String.IsNullOrWhiteSpace(teksbaris) Then Continue For

            Dim pecah() As String = teksbaris.Split(" "c)
            If pecah.Length < 2 Then Continue For

            On Error Resume Next
            pecah(1) = pecah(1).Trim(" "c)

            Select Case pecah(1)
                Case "warnatepi"
                    warnatepi = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    tepi.Color = warnatepi
                Case "warnaisian"
                    warnaisian = Color.FromArgb(CByte(pecah(2)), CByte(pecah(3)), CByte(pecah(4)))
                    isian.Color = warnaisian
                Case "garis"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, CInt(pecah(2)), CInt(pecah(3)), CInt(pecah(4)), CInt(pecah(5)))
                    End Using
                Case "kotak"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                                           CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elips"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                                           CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "kotakisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                                           CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillRectangle(isian, rect)
                        g.DrawRectangle(tepi, rect)
                    End Using
                Case "elipsisi"
                    Dim rect As New Rectangle(CInt(pecah(2)), CInt(pecah(3)),
                                           CInt(pecah(4)) - CInt(pecah(2)), CInt(pecah(5)) - CInt(pecah(3)))
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.FillEllipse(isian, rect)
                        g.DrawEllipse(tepi, rect)
                    End Using
                Case "tebaltepi"
                    tepi.Width = CInt(pecah(2))
                Case "clear"
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.Clear(Color.White)
                    End Using
                Case "action_start", "action_end"
                    ' These are just markers, no action needed
            End Select
        Next
        PictureBox1.Invalidate()
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog Then
            TextBox1.Clear()
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            btnBersihkan.PerformClick()
            btnGbrUlang.PerformClick()
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class