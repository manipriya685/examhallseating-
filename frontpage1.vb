Imports System.Data.SqlClient
Public Class frontpage1
    Dim frontpage1 As New mainclass0
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frontpage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frontpage1.connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button.Click
        Try
            Dim sql As String = "select * from login_table where Usertype ='" + Cmblogin.SelectedItem.ToString + "'"
            frontpage1.read(sql)
            While frontpage1.dr.Read

                If frontpage1.dr(0).ToString.Equals(usernametextBox.Text) And frontpage1.dr(1).ToString.Equals(passwordtextBox.Text) Then
                    MsgBox("logged in as admin", MsgBoxStyle.Information, "welcome admin ")
                    Dim fp2 As New frontpage2
                    Me.Hide()
                    fp2.Show()
                Else

                    MsgBox("logged in as user", MsgBoxStyle.Exclamation, "welcome all")
                    Dim fp5 As New Frontpage5
                    Me.Hide()
                    fp5.Show()

                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Button.MouseEnter
        Button.BackColor = Color.Indigo
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button.MouseLeave
        Button.BackColor = Color.Empty
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.BackColor = Color.Red
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.Empty
    End Sub
End Class