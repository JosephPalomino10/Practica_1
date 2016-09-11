Public Class MainForm

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        lblprecio.Text = "120"
        pbCover.Image = ImageList1.Images.Item(0)


    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        lblprecio.Text = "240"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblprecio.Text = "160"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblprecio.Text = "70"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.ForeColor = Color.Green


    End Sub

End Class