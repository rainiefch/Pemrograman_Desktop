Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub frmProfil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbUsername.Text = pengguna
        tbNewPassword.Text = password
    End Sub

    Private Sub frmProfil_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If tbNewPassword.Text = tbConfirmPassword.Text Then
            Dim sql As String = "update users set password='" & tbNewPassword.Text & "'where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                Form1.tbPassword.Clear()
                Form1.tbUsername.Clear()
                Me.Close()
                Form4.Close()

                Form1.tbUsername.Focus()
                Form1.ShowDialog()
            End If
        ElseIf tbConfirmPassword.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class