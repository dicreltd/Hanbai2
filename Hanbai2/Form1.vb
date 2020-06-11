Imports MySql.Data.MySqlClient

Public Class Form1
    Dim adp As MySqlDataAdapter
    Dim table As New DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New MySqlConnection("userid=root;password=;database=hanbai;Host=localhost")
        adp = New MySqlDataAdapter("SELECT * FROM shouhin", cn)
        adp.Fill(table)
        DataGridView1.DataSource = table
        Dim bld = New MySqlCommandBuilder(adp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim index = DataGridView1.CurrentCell.RowIndex
        Dim row = table.NewRow()
        row("sname") = TextBox1.Text
        'row("tanka") = Integer.Parse(TextBox2.Text)
        row("tanka") = TextBox2.Text
        table.Rows.Add(row)

        adp.Update(table)
        table.Clear()
        adp.Fill(table)
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index = DataGridView1.CurrentCell.RowIndex
        Dim row = table.Rows(index)
        row.Delete()

        adp.Update(table)
        table.Clear()
        adp.Fill(table)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index = DataGridView1.CurrentCell.RowIndex
        Dim row = table.Rows(index)
        TextBox1.Text = row("sname").ToString()
        TextBox2.Text = row("tanka").ToString()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim index = DataGridView1.CurrentCell.RowIndex
        Dim row = table.Rows(index)
        TextBox1.Text = row("sname").ToString()
        TextBox2.Text = row("tanka").ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim index = DataGridView1.CurrentCell.RowIndex
        Dim row = table.Rows(index)
        row("sname") = TextBox1.Text
        row("tanka") = TextBox2.Text

        adp.Update(table)
        table.Clear()
        adp.Fill(table)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
