Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub txt_nproducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nproducto.KeyPress
        If (((Asc(e.KeyChar)) >= 65 And (Asc(e.KeyChar)) <= 90)) Or ((Asc(e.KeyChar)) >= 97 And (Asc(e.KeyChar) <= 122) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8))) Then
            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.txt_codigo.Focus()
            End If

        End If
    End Sub

    Private Sub txt_codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_codigo.KeyPress
        If (((Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57)) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8))) Then
            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.txt_precio.Focus()
            End If
        End If
    End Sub


    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If (((Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57)) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8))) Then
            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.btn_tot.Focus()
            End If
        End If
    End Sub

    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
        If (((Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57)) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8))) Then
            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.txt_cantidad.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_subtotal.KeyPress

    End Sub

    Private Sub btn_tot_Click(sender As Object, e As EventArgs) Handles btn_tot.Click
        Dim cantidad, precio, subtotal, iva, total As Double

        cantidad = Val(Me.txt_cantidad.Text)
        precio = Val(Me.txt_precio.Text)
        subtotal = Val(Me.txt_subtotal.Text)
        total = Val(Me.txt_total.Text)

        subtotal = cantidad * precio
        iva = subtotal * 0.12
        total = subtotal + iva

        Me.txt_subtotal.Text = subtotal
        Me.txt_iva.Text = iva
        Me.txt_total.Text = total

    End Sub


End Class
