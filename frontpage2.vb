Public Class frontpage2
    Private Sub Labelstu_Click(sender As Object, e As EventArgs) Handles Labelstuform.Click
        Dim fp3 As New frontpage3
        frontpage3.Show()
    End Sub

    Private Sub Labelhall_Click(sender As Object, e As EventArgs) Handles Labelhallform.Click
        Dim fp4 As New frontpage4

        fp4.Show()
    End Sub

    Private Sub Labelstuform_MouseEnter(sender As Object, e As EventArgs) Handles Labelstuform.MouseEnter
        Labelstuform.ForeColor = Color.DarkViolet
    End Sub

    Private Sub Labelstuform_MouseLeave(sender As Object, e As EventArgs) Handles Labelstuform.MouseLeave
        Labelstuform.ForeColor = Color.Empty
    End Sub

    Private Sub Labelhallform_MouseEnter(sender As Object, e As EventArgs) Handles Labelhallform.MouseEnter
        Labelhallform.ForeColor = Color.DarkViolet
    End Sub

    Private Sub Labelhallform_MouseLeave(sender As Object, e As EventArgs) Handles Labelhallform.MouseLeave
        Labelhallform.ForeColor = Color.Empty
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        End
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.BackColor = Color.Red
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.Empty
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim frontpage1 As New frontpage1
        Me.Hide()
        frontpage1.Show()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.BackColor = Color.Green
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.Empty
    End Sub
End Class