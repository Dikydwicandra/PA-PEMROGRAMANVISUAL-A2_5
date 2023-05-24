Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnLogin_KeyPress(sender As Object, e As EventArgs) Handles btnLogin.KeyPress
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbakun where nama='" &
       txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False

            menubaru.Show()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If

    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Tutup As String
        Tutup = MessageBox.Show("Apakah anda ingin keluar aplikasi ? ", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call koneksi()
        CMD = New MySqlCommand("Select * From tbakun where nama='" &
       txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Me.Visible = False

            menubaru.Show()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub
End Class
