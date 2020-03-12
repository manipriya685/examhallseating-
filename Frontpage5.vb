Imports System.Data.SqlClient
Public Class Frontpage5
    Dim conn As New SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Public dr As SqlDataReader
    Public dr1 As SqlDataReader
    Private dg As DataGridView
    Dim i As Integer


    Private Sub Frontpage5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamcellbdDataSet5.class_table' table. You can move, or remove it, as needed.
        Me.Class_tableTableAdapter.Fill(Me.ExamcellbdDataSet5.class_table)
        conn.ConnectionString = "data source = bmw-groups\sqlexpress;initial catalog = examcellbd;integrated security = true"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cls As String
        cls = ListBox1.SelectedItem.ToString

        ListBox2.Items.Add(ListBox1.SelectedItem.ToString)
        ListBox1.Items.Remove(ListBox1.SelectedItem)

        Try
            Dim sql As String = "select strength from strength where Class ='" + cls + "'"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                ListBox3.Items.Add(dr.Item(0))
            End While
            dr.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim j As Integer
        Dim sum As Integer
        For j = 0 To ListBox2.Items.Count - 1
            sum += Val(ListBox3.Items(j))
        Next
        TextBox1.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(ListBox2.SelectedItem.ToString)
        ListBox2.Items.Remove(ListBox2.SelectedItem)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.AddRange(ListBox2.Items)
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim noofhalls As Integer
        Dim n As Integer
        Dim m As Integer
        Dim k As Integer
        Dim h As Integer
        Dim count As Integer

        noofhalls = Val(TextBox1.Text) / 15
        If noofhalls > 1 Then
            For n = 1 To noofhalls - 1
                TabControl2.TabPages.Add("Hall" & n + 1)
            Next
        End If

        For n = 0 To noofhalls - 1
            dg = New DataGridView
            dg.Size = New System.Drawing.Size(500, 500)
            dg.RowCount = 15
            dg.ColumnCount = 4
            dg.Columns(0).Name = "Seat No."
            dg.Columns(1).Name = "Reg. No."
            dg.Columns(2).Name = "Seat No."
            dg.Columns(3).Name = "Reg. No."

            For k = 0 To 14
                dg.Rows(k).Cells(0).Value = k + 1
            Next
            h = 0
            For k = 16 To 30
                dg.Rows(h).Cells(2).Value = k
                h += 1
            Next
            TabControl2.TabPages(n).Controls.Add(dg)

        Next
        count = 0
        Dim x, y As Integer
        For Each Str1 In ListBox2.Items
            Dim sql1 As String = "select count(regd_no) from class_table where class ='" + Str1 + "'"
            Dim sql As String = "select regd_no from class_table where class ='" + Str1 + "'"
            cmd1 = New SqlCommand(sql, conn)
            cmd = New SqlCommand(sql1, conn)
            count = Convert.ToInt16(cmd.ExecuteScalar)
            dr = cmd1.ExecuteReader()
            x = 1
            y = 1
            If count <= 15 Then
                While dr.Read And x <= 30

                    If x <= 15 Then
                        dg.Rows(x - 1).Cells(1).Value = dr(0).ToString
                        x += 2
                    End If
                    If x > 15 Then
                        dg.Rows(y - 1).Cells(3).Value = dr(0).ToString
                        y += 2
                    End If

                End While

            End If
                    dr.Close()
        Next

    End Sub
End Class