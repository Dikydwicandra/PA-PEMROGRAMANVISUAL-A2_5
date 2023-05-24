Public Class menubaru
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlapangan.Click
        Me.Hide()
        MenuLap.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub menubaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class