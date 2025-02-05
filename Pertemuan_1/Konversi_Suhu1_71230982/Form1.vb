Public Class Form1
    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        MsgBox("Fahrenheit = " & fahrenheit & vbCrLf & "Reamur = " & reamur & vbCrLf & "Kelvin = " & kelvin)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
