Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBinary.ReadOnly = True
        txtOctal.ReadOnly = True
        txtHexadecimal.ReadOnly = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputDecimal As Integer = CInt(txtDecimal.Text)
        txtBinary.Text = ConvertBasis(inputDecimal, 2)
        txtOctal.Text = ConvertBasis(inputDecimal, 8)
        txtHexadecimal.Text = ConvertBasis(inputDecimal, 16).ToUpper()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function ConvertBasis(ByVal number As Integer, ByVal base As Integer) As String
        Dim result As String = ""
        Do While number > 0
            Dim remainder As Integer = number Mod base
            result = Karakter(remainder) & result
            number \= base
        Loop
        Return If(result = "", "0", result)
    End Function

    Private Function Karakter(ByVal value As Integer) As String
        Return If(value < 10, value.ToString(), Chr(Asc("A") + (value - 10)))
    End Function
End Class
