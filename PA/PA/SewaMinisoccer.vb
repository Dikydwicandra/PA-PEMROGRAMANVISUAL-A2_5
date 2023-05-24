

Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class SewaMinisoccer
    Inherits Form
    Dim nama, id, nohp, harga, jam, hari, totaljam, jumlah As String
    Public Sub New()

        MyBase.New()
        InitializeComponent()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Hide()
        menubaru.Show()
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MenuLap.Show()
    End Sub

    Private Sub btnlapangan_Click(sender As Object, e As EventArgs) Handles btnlapangan.Click
        Me.Hide()
        MenuLap.Show()
    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Me.Hide()
        koneksi()
        MenuLaporan.tampil()
        MenuLaporan.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub txtnohp_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SewaMinisoccer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        AturGrid()
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            AddHandler cb.CheckedChanged, AddressOf hitungjam
        Next

        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            AddHandler cb.CheckedChanged, AddressOf hitungharga
        Next
        no()

    End Sub
    Sub hitungjam()
        Dim jumlah As Integer
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            If cb.Checked = True Then
                jumlah += 1
            End If
        Next
        txtjam.Text = jumlah
    End Sub

    Sub hitungharga()
        Dim harga As Integer
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            If cb.Checked = True Then
                If cb.Text >= 8 And cb.Text <= 17 Then
                    harga += 30000
                Else
                    harga += 50000
                End If

            End If
        Next
        txtharga.Text = harga
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Dim namesbox As String = ""
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            If cb.Checked Then
                namesbox &= cb.Text & " "
            End If
        Next

        If txtnama.Text = "" Or txtharga.Text = "" Or txtjam.Text = "" Or txtnohp.Text = "" Or Cbhari.Text = "" Or gbJam.Text = "" Then
            MsgBox("Data Belum Lengkap!!!")
            txtnama.Focus()
        Else
            CMD = New MySqlCommand("Select * From tbminisoccer where nama='" & txtnama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()
            If Not RD.HasRows Then
                Dim save As String = "insert into 
                tbminisoccer(id,nama,nohp,totaljam,hari,jam,totalharga)values 
                 ('" & txtid.Text & "'
                 ,'" & txtnama.Text & "',
                 '" & txtnohp.Text & "',
                 '" & txtjam.Text & "',
                 '" & Cbhari.Text & "',
                 '" & namesbox & "',
                 '" & txtharga.Text & "')"
                CMD = New MySqlCommand(save, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Perhatian")
                bersih()
                tampil()
            End If
        End If
        Call no()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim namesbox As String = ""
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            If cb.Checked Then
                namesbox &= cb.Text & " "
            End If
        Next
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtid.Text = .Cells(0).Value
            Me.txtnama.Text = .Cells(1).Value
            Me.txtnohp.Text = .Cells(2).Value
            Me.txtjam.Text = .Cells(3).Value
            Me.Cbhari.Text = .Cells(4).Value
            'DISINI KURANG CHECKBOX DIAMBIL DARI CELLS 5 
            Me.txtharga.Text = .Cells(6).Value

            DataGridView1.Rows(i).Cells(5).Value = namesbox
        End With
    End Sub

    Sub no()
        Dim getID As String = "SELECT max(id) FROM tbminisoccer"
        CMD = New MySqlCommand(getID, CONN)
        Dim RD As MySqlDataReader
        RD = CMD.ExecuteReader
        If RD.Read Then
            If IsDBNull(RD.Item(0)) Then
                txtid.Text = "001"
            Else
                txtid.Text = RD.GetString(0) + 1
            End If
            RD.Close()
        End If
    End Sub

    Sub AturGrid()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "NAMA"
        DataGridView1.Columns(2).HeaderText = "NO TELPON"
        DataGridView1.Columns(3).HeaderText = "TOTAL JAM"
        DataGridView1.Columns(4).HeaderText = "HARI"
        DataGridView1.Columns(5).HeaderText = "JAM"
        DataGridView1.Columns(6).HeaderText = "HARGA"

    End Sub
    Sub tampil()
        DA = New MySqlDataAdapter("Select * From tbminisoccer", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbminisoccer")
        DataGridView1.DataSource = DS.Tables("tbminisoccer")
        DataGridView1.Refresh()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim namesbox As String = ""
        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            If cb.Checked Then
                namesbox &= cb.Text & " "
            End If
        Next
        If txtnama.Text = "" Or txtnohp.Text = "" Or txtjam.Text = "" Or Cbhari.Text = "" Or txtharga.Text = "" Then
            MsgBox("Lengkapi Pengisian Data!")
            txtnama.Focus()
        Else
            Dim Ubah As String = "UPDATE tbminisoccer SET nama = '" & txtnama.Text & "',
                                nohp = '" & txtnohp.Text & "', 
                                totaljam = '" & txtjam.Text & "', 
                                hari = '" & Cbhari.Text & "', 
                                jam = '" & namesbox & "', 
                                totalharga = '" & txtharga.Text & "' 
                                WHERE id = '" & txtid.Text & "'"
            CMD = New MySqlCommand(Ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Diubah")
            tampil()
            bersih()
        End If
        Call no()

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        nama = txtnama.Text
        id = txtid.Text
        nohp = txtnohp.Text
        harga = txtharga.Text
        totaljam = txtjam.Text
        hari = Cbhari.Text



        Me.PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = Me.DataGridView1.CurrentRow.Index
        With DataGridView1.Rows.Item(i)
            Me.txtid.Text = .Cells(0).Value
            Me.txtnama.Text = .Cells(1).Value
            Me.txtnohp.Text = .Cells(2).Value
            Me.Cbhari.Text = .Cells(4).Value
        End With
    End Sub

    Sub bersih()

        txtnama.Clear()
        txtnohp.Clear()
        txtjam.Clear()
        Cbhari.Text = ""
        txtharga.Clear()

        For Each cb In gbJam.Controls.OfType(Of CheckBox)()
            cb.Checked = False
        Next
    End Sub

    Private Sub btnkosong_Click(sender As Object, e As EventArgs) 
        Call bersih()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtnama.Text = "" Then
            MsgBox("Nama belum ada")
            txtnama.Focus()
        Else
            If MessageBox.Show("Apakah anda ingin menghapus data ini ? " &
                txtnama.Text &
                 " ?", " ", MessageBoxButtons.YesNo) =
                   Windows.Forms.DialogResult.Yes Then

                CMD = New MySqlCommand("Delete From tbminisoccer Where nama = '" & txtnama.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                Call bersih()
                Call tampil()
            Else
                Call bersih()
            End If
        End If
        Call no()
    End Sub
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbminisoccer where id like '%" & txtCari.Text & "%' or nama like'%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbminisoccer where id like  '%" & txtCari.Text & "%' or nama like'%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        nama = txtnama.Text
        id = txtid.Text
        nohp = txtnohp.Text
        harga = txtharga.Text
        totaljam = txtjam.Text
        hari = Cbhari.Text



        Me.PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        Dim Image As New Bitmap(Me.PictureBox1.Width, Me.PictureBox1.Height)
        Dim f As Font = New Font("Calbiri", 15)

        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis kotak

        PictureBox1.DrawToBitmap(Image, New Rectangle(0, 0, Me.PictureBox1.Width, Me.PictureBox1.Height))


        e.Graphics.DrawString("--------------------------------------------------------------", f, br, 170, 80)
        e.Graphics.DrawString("Tanggal", f, br, 170, 110)
        e.Graphics.DrawString("22 Mei 2023", f, br, 400, 110)
        e.Graphics.DrawString("Kasir", f, br, 170, 140)
        e.Graphics.DrawString("Admin", f, br, 400, 140)
        e.Graphics.DrawString("--------------------------------------------------------------", f, br, 170, 170)
        e.Graphics.DrawString("Sewa Lapangan Mini soccer", f, br, 300, 200)
        e.Graphics.DrawString("--------------------------------------------------------------", f, br, 170, 230)
        e.Graphics.DrawString("Atas Nama               :", f, br, 170, 270)
        e.Graphics.DrawString(nama, f, br, 400, 270)
        e.Graphics.DrawString("ID                            :", f, br, 170, 300)
        e.Graphics.DrawString(id, f, br, 400, 300)
        e.Graphics.DrawString("Total Jam               :", f, br, 170, 330)
        e.Graphics.DrawString(totaljam, f, br, 400, 330)
        e.Graphics.DrawString("Hari                        :", f, br, 170, 360)
        e.Graphics.DrawString(hari, f, br, 400, 360)
        e.Graphics.DrawString("No HP / Whatsapp :", f, br, 170, 390)
        e.Graphics.DrawString(nohp, f, br, 400, 390)
        e.Graphics.DrawString("--------------------------------------------------------------", f, br, 170, 420)
        e.Graphics.DrawString("--------------------------------------------------------------", f, br, 170, 480)
        e.Graphics.DrawString("Total Harga :", f, br, 170, 450)
        e.Graphics.DrawString(harga, f, br, 400, 450)

        e.Graphics.DrawRectangle(p, 50, 50, 700, 500)

    End Sub
End Class
