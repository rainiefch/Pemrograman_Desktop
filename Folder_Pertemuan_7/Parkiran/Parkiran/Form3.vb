Imports MySql.Data.MySqlClient
Public Class Form3
    Private Sub RefreshGrid()
        Dim i
        i = 0
        dgvSubscribedVehicleList.Rows.Clear()
        Dim sql As String = "select * from tbllangganan"
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
                dgvSubscribedVehicleList.Rows.Add()
                dgvSubscribedVehicleList.Item(0, i).Value = myDataReader("id")
                dgvSubscribedVehicleList.Item(1, i).Value = myDataReader("no_plat")
                dgvSubscribedVehicleList.Item(2, i).Value = myDataReader("nama")
                dgvSubscribedVehicleList.Item(3, i).Value = myDataReader("biaya")
                dgvSubscribedVehicleList.Item(4, i).Value = myDataReader("jenis")
                dgvSubscribedVehicleList.Item(5, i).Value = myDataReader("expired")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub frmLangganan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubscribedVehicleList.CellClick
        Dim idx As String = dgvSubscribedVehicleList.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim sql As String = "select * from tbllangganan where id=" & idx
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
                lblIDNumber.Text = myDataReader("id")
                tbPlateNumber.Text = myDataReader("no_plat")
                tbName.Text = myDataReader("nama")
                tbSubsFee.Text = myDataReader("biaya")
                cbType.Text = myDataReader("jenis")
                DateTimePicker1.Text = myDataReader("expired")

            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()

        End If
    End Sub

    'Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
    '    If btnAdd.Text = "Tambah" Then
    '        btnAdd.Text = "Simpan"
    '        tbPlateNumber.Enabled = True
    '        tbName.Enabled = True
    '        tbSubsFee.Enabled = True
    '        cbType.Enabled = True
    '        DateTimePicker1.Enabled = True
    '        btnCancel.Visible = True
    '        btnEdit.Enabled = False
    '        btnDelete.Enabled = False
    '        tbPlateNumber.Clear()
    '        tbName.Clear()
    '        tbSubsFee.Clear()
    '        cbType.Text = ""
    '    ElseIf btnAdd.Text = "Simpan" Then
    '        Dim hasil As DateTime = DateTimePicker1.Value
    '        Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & "16:00:00"
    '        Dim sql As String = "insert into tbllangganan(no_plat,nama,jenis,biaya,expired) values ('" & tbPlateNumber.Text & "','" &
    '        tbName.Text & "','" & cbType.Text & "'," & tbSubsFee.Text & ",'" & waktu & "')"
    '        If myConn.State = ConnectionState.Closed Then
    '            myConn.Open()
    '        End If
    '        If myCommand Is Nothing Then
    '            myCommand = New MySqlCommand(sql, myConn)
    '        Else
    '            myCommand.CommandText = sql
    '        End If
    '        myCommand.ExecuteNonQuery()
    '        btnAdd.Text = "Tambah"
    '        tbPlateNumber.Enabled = False
    '        tbName.Enabled = False
    '        tbSubsFee.Enabled = False
    '        cbType.Enabled = False
    '        DateTimePicker1.Enabled = False
    '        btnCancel.Visible = False
    '        btnEdit.Enabled = True
    '        btnDelete.Enabled = True
    '        RefreshGrid()
    '    End If
    'End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Tambah" Then
            btnAdd.Text = "Simpan"
            tbPlateNumber.Enabled = True
            tbName.Enabled = True
            tbSubsFee.Enabled = True
            cbType.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            tbPlateNumber.Clear()
            tbName.Clear()
            tbSubsFee.Clear()
            cbType.Text = ""
        ElseIf btnAdd.Text = "Simpan" Then
            ' Pastikan biaya tidak kosong atau null
            Dim biaya As Integer
            If Integer.TryParse(tbSubsFee.Text, biaya) = False Then
                biaya = 0
            End If

            ' Format tanggal sesuai SQL (YYYY-MM-DD HH:MM:SS)
            Dim waktu As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")

            ' Buat query insert
            Dim sql As String = "INSERT INTO tbllangganan(no_plat, nama, jenis, biaya, expired) " &
                            "VALUES ('" & tbPlateNumber.Text & "','" & tbName.Text & "','" & cbType.Text & "'," & biaya & ",'" & waktu & "')"

            ' Debugging: tampilkan query sebelum dieksekusi
            MsgBox("Query yang akan dieksekusi: " & sql)

            ' Pastikan koneksi terbuka
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            ' Eksekusi query dalam Try-Catch untuk menangkap error
            Try
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(sql, myConn)
                Else
                    myCommand.CommandText = sql
                End If

                myCommand.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!") ' Konfirmasi jika berhasil

            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message) ' Menampilkan error jika ada
            End Try

            ' Reset form setelah insert
            btnAdd.Text = "Tambah"
            tbPlateNumber.Enabled = False
            tbName.Enabled = False
            tbSubsFee.Enabled = False
            cbType.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            RefreshGrid()
        End If
    End Sub




    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvSubscribedVehicleList.CurrentRow.Cells(0).Value.ToString <> "" Then
            If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "delete from tbllangganan where id=" & dgvSubscribedVehicleList.CurrentRow.Cells(0).Value.ToString
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

                End If
            Else
            End If
        End If
    End Sub
    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            tbPlateNumber.Enabled = True
            tbName.Enabled = True
            tbSubsFee.Enabled = True
            cbType.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnAdd.Enabled = False
            btnDelete.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Dim hasil As DateTime = DateTimePicker1.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & " 00:00:00"
            Dim sql As String = "update tbllangganan set no_plat = '" & tbPlateNumber.Text & "',nama = '" & tbName.Text & "',jenis = '" & cbType.Text & "',biaya = '" & tbSubsFee.Text & "',expired = '" & waktu & "' where id = " & lblIDNumber.Text
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else myCommand.CommandText = sql
            End If
            Dim hsl As Integer = myCommand.ExecuteNonQuery
            If hsl = 1 Then
                MsgBox("Update success!")
                RefreshGrid()
            End If
            btnEdit.Text = "Edit"
            tbPlateNumber.Enabled = False
            tbName.Enabled = False
            tbSubsFee.Enabled = False
            cbType.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnAdd.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        If btnAdd.Text = "Simpan" Then
            btnAdd.Text = "Tambah"
            tbPlateNumber.Enabled = False
            tbName.Enabled = False
            tbSubsFee.Enabled = False
            cbType.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        ElseIf btnEdit.Text = "Simpan" Then
            btnEdit.Text = "Edit"
            tbPlateNumber.Enabled = False
            tbName.Enabled = False
            tbSubsFee.Enabled = False
            cbType.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnAdd.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub
End Class