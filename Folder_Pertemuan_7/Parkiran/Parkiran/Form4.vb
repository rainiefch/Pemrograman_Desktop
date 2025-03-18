﻿Imports MySql.Data.MySqlClient
Public Class Form4
    Sub RefreshGrid()
        Dim i
        i = 0
        dgvVehicleList.Rows.Clear()
        Dim sql As String = "select * from tblparkir where DATE(`waktu_masuk`) = CURDATE()"
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
            While myDataReader.Read()
                dgvVehicleList.Rows.Add()
                dgvVehicleList.Item(0, i).Value = myDataReader("no_plat")
                dgvVehicleList.Item(1, i).Value = myDataReader("waktu_masuk")
                dgvVehicleList.Item(2, i).Value = myDataReader("waktu_keluar")
                dgvVehicleList.Item(3, i).Value = myDataReader("harga")
                dgvVehicleList.Item(4, i).Value = myDataReader("jenis")
                dgvVehicleList.Item(5, i).Value = myDataReader("id")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub



    Sub HitungJumlah()
        Dim sql As String = "select jenis,count(*) as jml," & bts & "-count(*) as sisa from tblparkir where DATE(`waktu_masuk`) = CURDATE() and waktu_keluar is null group by(jenis)"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        Dim hsl As String = "Jumlah "
        If myDataReader.HasRows Then
            While myDataReader.Read()
                hsl = hsl & myDataReader("jenis").ToString & " = " & myDataReader("jml").ToString & ", "
            End While
            lblTotalVehicle.Text = hsl
        Else
            lblTotalVehicle.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim sql As String
        Dim harga As Integer = 0
        Dim nomor As String = String.Empty
        pengguna = "anton"
        If e.KeyCode = Keys.F1 Then
            jns = "Motor"
        ElseIf e.KeyCode = Keys.F2 Then

            jns = "Mobil"
        ElseIf e.KeyCode = Keys.F3 Then
            jns = "Taksi/Umum"
        ElseIf e.KeyCode = Keys.F4 Then
            jns = "Sepeda"
        ElseIf e.KeyCode = Keys.F5 Then
            jns = "Bus/Truk"
        End If
        ComboBox1.Text = jns
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If e.KeyCode = Keys.Return Then
            ' Pastikan koneksi terbuka
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            ' Periksa apakah kendaraan adalah langganan
            sql = "SELECT COUNT(*) FROM tbllangganan WHERE no_plat = '" & tbPlate.Text.ToUpper & "'"
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hasil As Integer = Convert.ToInt32(myCommand.ExecuteScalar())

            ' Tampilkan hasil debug
            MsgBox("Jumlah kendaraan langganan ditemukan: " & hasil)

            If hasil > 0 Then
                ' Jika kendaraan langganan, biaya parkir = 0
                sql = "INSERT INTO tblparkir(no_plat, jenis, user, harga) VALUES ('" & tbPlate.Text.ToUpper & "','" & lblInformation.Text & "','" & pengguna & "', 0)"
            Else
                ' Jika kendaraan biasa, biayanya dihitung saat keluar
                sql = "INSERT INTO tblparkir(no_plat, jenis, user) VALUES ('" & tbPlate.Text.ToUpper & "','" & lblInformation.Text & "','" & pengguna & "')"
            End If

            ' Debug query sebelum dieksekusi
            MsgBox("Query yang akan dieksekusi: " & sql)

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            ' Eksekusi query
            Try
                myCommand.ExecuteNonQuery()
                MsgBox("Data berhasil dimasukkan!")
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message)
            End Try



            'If myCommand Is Nothing Then
            '    myCommand = New MySqlCommand(sql, myConn)
            'Else
            '    myCommand.CommandText = sql
            'End If
            'myCommand.ExecuteNonQuery()

            'If myCommand Is Nothing Then
            '    myCommand = New MySqlCommand(sql, myConn)
            'Else
            '    myCommand.CommandText = sql
            'End If
            Dim hasil1 As MySqlDataReader = myCommand.ExecuteReader()
            If hasil1.HasRows Then 'kalau sudah ada, update jadi keluar
                If MessageBox.Show("Keluar dari Parkir?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    hasil1.Read()

                    jns = hasil1("jenis").ToString
                    nomor = hasil1("id").ToString
                    If jns = "Motor" Then
                        harga = 2000
                    ElseIf jns = "Mobil" Or jns = "Taksi/Umum" Then
                        harga = 3000
                    ElseIf jns = "Sepeda" Then
                        harga = 1000
                    ElseIf jns = "Bus/Truk" Then
                        harga = 4000
                    End If

                    If hasil1.IsClosed = False Then

                        hasil1.Close()
                    End If

                    sql = "update tblparkir set waktu_keluar = CURRENT_TIMESTAMP(),
harga = IF(ceil((UNIX_TIMESTAMP(waktu_keluar) -
UNIX_TIMESTAMP(waktu_masuk))/60/60)>1,ceil((UNIX_TIMESTAMP(waktu_keluar) -
UNIX_TIMESTAMP(waktu_masuk))/60/60)*" & Str(harga) & "," & Str(harga) & ") where id =
" & nomor
                    myCommand.CommandText = sql
                    myCommand.ExecuteNonQuery()
                    sql = "select * from tblparkir where id = " & nomor

                    myCommand.CommandText = sql
                    hasil1 = myCommand.ExecuteReader
                    hasil1.Read()
                    lblParkingFee.Text = "Rp. " & hasil1("harga").ToString

                    If hasil1.IsClosed = False Then
                        hasil1.Close()
                    End If

                    MsgBox("Sukses Keluar!")
                    jns = String.Empty

                End If

            Else 'kalau belum ada masukkan baru
                If jns = String.Empty Then
                    MsgBox("Masukan jenis kendaraan berikut:" & vbCrLf & ComboBox1.Text)
                    hasil1.Close()
                    Exit Sub
                End If
                sql = "insert into tblparkir(no_plat,jenis,user) values ('" &
                tbPlate.Text.ToUpper & "','" & lblInformation.Text & "','" & pengguna & "')"
                If hasil1.IsClosed = False Then
                    hasil1.Close()
                End If

                myCommand.CommandText = sql
                myCommand.ExecuteNonQuery()
                jns = String.Empty
            End If
            tbPlate.Text = TextBox1.Text.ToUpper
        End If
        RefreshGrid()
        HitungJumlah()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub

    Private Sub LaporanPendapatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        Dim sql As String = "select sum(harga) from tblparkir where DATE(waktu_masuk) = CURDATE() and DATE(waktu_keluar) = CURDATE()"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        Dim hasil As Object = myCommand.ExecuteScalar
        Dim total As String = ""
        If hasil.Equals(DBNull.Value) Then
            total = "0"
        Else
            total = hasil.ToString
        End If
        MsgBox("Total Pendapatan hari ini: Rp. " & total)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
    End Sub



    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Form1.tbUsername.Clear()
        Form1.tbPassword.Clear()
        Form1.tbUsername.Focus()
        Form1.ShowDialog()
    End Sub

    Private Sub EditProfileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProfileToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub DaftarKendaraanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubscriberToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) =
        Windows.Forms.DialogResult.Yes Then
            Dim sql As String = "delete from tblparkir where id=" & dgvVehicleList.CurrentRow.Cells(5).Value.ToString
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql

            End If
            Dim hasil As Integer = myCommand.ExecuteNonQuery
            If hasil = 1 Then
                MsgBox("Delete success!")
                RefreshGrid()
                HitungJumlah()
            End If
        Else
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVehicleList.CellEnter
        tbPlate.Text = dgvVehicleList.Rows(e.RowIndex).Cells(0).Value
    End Sub

End Class