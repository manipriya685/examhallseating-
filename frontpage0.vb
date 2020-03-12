Public Class frontpage0
    Dim frontpage0 As New mainclass0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_Mouseclick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim a As New frontpage1
        Me.Hide()
        a.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frontpage0.connect()
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        Dim a As New frontpage1
        Me.Hide()
        a.Show()
    End Sub

    Private Sub frontpage0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
