Imports MySql.Data.MySqlClient

Public Class MenuLaporan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        menubaru.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlapangan.Click
        Me.Hide()
        MenuLap.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Form1.Show()
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
    Sub AturGrid1()
        DataGridView2.Columns(0).Width = 50
        DataGridView2.Columns(0).HeaderText = "ID"
        DataGridView2.Columns(1).HeaderText = "NAMA"
        DataGridView2.Columns(2).HeaderText = "NO TELPON"
        DataGridView2.Columns(3).HeaderText = "TOTAL JAM"
        DataGridView2.Columns(4).HeaderText = "HARI"
        DataGridView2.Columns(5).HeaderText = "JAM"
        DataGridView2.Columns(6).HeaderText = "HARGA"

    End Sub

    Private Sub MenuLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        tampil1()
        AturGrid()
        AturGrid1()

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        End
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Sub tampil()
        DA = New MySqlDataAdapter("Select * From tbminisoccer", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbminisoccer")
        DataGridView1.DataSource = DS.Tables("tbminisoccer")
        DataGridView1.Refresh()
    End Sub

    Sub tampil1()
        DA = New MySqlDataAdapter("Select * From tbfutsal", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbfutsal")
        DataGridView2.DataSource = DS.Tables("tbfutsal")
        DataGridView2.Refresh()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

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
    Private Sub txtCari1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From tbfutsal where id like '%" & txtCari.Text & "%' or nama like'%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From tbfutsal where id like  '%" & txtCari.Text & "%' or nama like'%" & txtCari.Text & "%'", CONN)
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

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        tampil()
        tampil1()
    End Sub
End Class