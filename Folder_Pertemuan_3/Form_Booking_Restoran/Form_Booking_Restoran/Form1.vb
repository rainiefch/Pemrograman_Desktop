Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim newForm As New Form2()
        newForm.Show()

    End Sub

    Private Sub cbSeat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSeat.SelectedIndexChanged
        If cbSeat.SelectedItem IsNot Nothing Then
            Dim seatVal As Integer = Convert.ToInt32(Regex.Match(cbSeat.SelectedItem.ToString(), "\d+").Value)
            numGuest.Maximum = seatVal
            If numGuest.Value > seatVal Then
                MessageBox.Show("Jumlah kursi kurang dari jumlah guest!")
            End If
            UpdateTableOptions(seatVal)
        End If
    End Sub

    Private Sub numGuest_ValueChanged(sender As Object, e As EventArgs) Handles numGuest.ValueChanged
        If numGuest.Value > numGuest.Maximum Then
            numGuest.Value = numGuest.Maximum
            MessageBox.Show("Jumlah guest melebihi jumlah kursi dipesan!")
        End If
    End Sub

    Private Sub UpdateTableOptions(seatVal As Integer)
        cbTable.Items.Clear()

        Select Case seatVal
            Case 2
                cbTable.Items.AddRange(New String() {"A1", "A2", "A3", "A4", "A5", "A6"})
            Case 4
                cbTable.Items.AddRange(New String() {"B1", "B2", "B3", "B4"})
            Case 6
                cbTable.Items.AddRange(New String() {"C1", "C2", "C3"})
            Case 8
                cbTable.Items.AddRange(New String() {"D1", "D2", "D3"})
            Case 10
                cbTable.Items.AddRange(New String() {"E1", "E2", "E3"})
            Case Else
                cbTable.Items.Add("No Table Available")
        End Select

        If cbTable.Items.Count > 0 Then
            cbTable.SelectedIndex = 0
        End If
    End Sub
End Class
