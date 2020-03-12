Public Class Frontpage3
    Dim frontpage3 As New mainclass0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btninsert.Click
        Dim sql As String
        sql = "insert into student_details values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
        If TextBox1.Text.Trim().Equals("") Or TextBox2.Text.Trim().Equals("") Or TextBox4.Text.Trim().Equals("") Then
            MsgBox("You are missed some where in the form", MsgBoxStyle.RetryCancel, MsgBoxStyle.Critical)
        Else
            MsgBox("New Student was comfortably added", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        End If
        frontpage3.insert(sql)

    End Sub


    Private Sub Frontpage3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamcellbdDataSet4.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter.Fill(Me.ExamcellbdDataSet4.student_details)
        'TODO: This line of code loads data into the 'ExamcellbdDataSet3.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter2.Fill(Me.ExamcellbdDataSet3.student_details)
        frontpage3.connect()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter
        Label8.BackColor = Color.Red
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave
        Label8.BackColor = Color.Empty
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click
        Dim sql As String
        sql = "update student_details set S_name='" + TextBox2.Text + "',S_cource='" + TextBox3.Text + "',S_dept='" + TextBox4.Text + "',S_year='" + TextBox5.Text + "' where S_ID='" + TextBox1.Text + "'"
        frontpage3.update(sql)

        MsgBox("your message is updated", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)


    End Sub



    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim sql As String
        sql = "delete from student_details where S_ID = '" + TextBox1.Text + "'"
        frontpage3.delete(sql)

        MsgBox("Data has been deleted Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Do You Want to Exit") Then

            Dim fp2 As New frontpage2
            Me.Hide()
            fp2.Show()
        End If
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim fp2 As New frontpage2
        fp2.Show()
        Me.Hide()
    End Sub
End Class