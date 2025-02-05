Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCelcius.Click

    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        lblFahrenheit.Text = CStr(fahrenheit)
        lblReamur.Text = CStr(reamur)
        lblKelvin.Text = CStr(kelvin)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
