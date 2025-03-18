﻿Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class Form1
    Public myConn As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;database=parkiran;")
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()

    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String = "select username,password from " & tbluser & " where username='" & tbUsername.Text & "' and password='" & tbPassword.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = tbUsername.Text
            password = tbPassword.Text
            Form4.lblInformation.Text = "Informasi - (User: " & pengguna & ")"
            Form4.lblDate.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
            Form4.RefreshGrid()
            Form4.HitungJumlah()
            Form4.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub

End Class
