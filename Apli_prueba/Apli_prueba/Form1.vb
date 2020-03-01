Public Class fmr_prueba
    Private Sub fmr_prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nombre.Text = "Frank"
        txt_apellido.Text = "Zabala"
    End Sub
    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        lblmensaje2.Text = txt_nombre.Text & " " & txt_apellido.Text
    End Sub
End Class