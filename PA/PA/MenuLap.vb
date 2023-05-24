Public Class MenuLap
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Me.Hide()
        MenuLaporan.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnX.Click
        End
    End Sub

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
            Me.Opacity = 0.9
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Opacity = 1
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles gmbrfutsal.Click
        Me.Hide()
        SewaFutsal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Hide()
        menubaru.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles gmbrminisoccer.Click
        Me.Hide()
        SewaMinisoccer.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub MenuLap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class