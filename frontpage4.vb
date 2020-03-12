
Public Class frontpage4
    Dim frontpage4 As New mainclass0
    Private Sub frontpage4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamcellbdDataSet1.hall_information' table. You can move, or remove it, as needed.
        Me.Hall_informationTableAdapter.Fill(Me.ExamcellbdDataSet1.hall_information)
        frontpage4.connect()
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter
        Label9.BackColor = Color.Red
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.BackColor = Color.Empty
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles insertbtn.Click
        Dim sql As String
        sql = "insert into hall_information values('" + classtextbx.Text + "','" + blockcombo.SelectedItem.ToString + "','" + benchcombo.SelectedItem.ToString + "')"
        If classtextbx.Text.Trim().Equals("") Then
            MsgBox("You are missed some where in the form", MsgBoxStyle.RetryCancel, MsgBoxStyle.Critical)
        Else
            MsgBox("New Hall was comfortably added", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        End If
        frontpage4.insert(sql)
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim sql As String
        sql = "delete from hall_information where class ='" + classtextbx.Text + "'"
        frontpage4.delete(sql)

        MsgBox("Data has been deleted Successfully", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        classtextbx.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        classtextbx.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        blockcombo.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        benchcombo.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub blockcombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles blockcombo.SelectedIndexChanged

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim sql As String
        sql = "update hall_information set block ='" + blockcombo.SelectedItem.ToString + "',benches='" + benchcombo.SelectedItem.ToString + "' where class ='" + classtextbx.Text + "'"
        frontpage4.update(sql)

        MsgBox("your Information is updated", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Dim fp2 As New frontpage2
        Me.Hide()
        fp2.Show()
    End Sub
End Class