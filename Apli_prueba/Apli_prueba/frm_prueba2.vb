Public Class frm_prueba2

    Private Sub btn_Total_Click(sender As Object, e As EventArgs) Handles btn_Total.Click
        Dim num1, num2, tot As Integer
        Dim mensaje As String

        num1 = Val(Me.txt_num1.Text)
        num2 = Val(Me.txt_num2.Text)

        If num2 > 0 Then
            tot = num1 + num2
        Else
            MsgBox("No se puede ejecutar la operacion,faltan argumentos")
        End If

        Me.txt_Total.Text = tot

        mensaje = "La Suma Total es: " & tot

        Me.txt_Total.Text = mensaje

        'txt_Total.Text = Val(txt_num1.Text) + Val(txt_num2.Text)'
    End Sub

    Private Sub bln_salir_Click(sender As Object, e As EventArgs) Handles bln_salir.Click
        End
    End Sub

    Private Sub txt_num1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num1.KeyPress
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = True
        'Else
        '    e.Handled = True
        'End If
        If (((Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57)) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8)) Then

            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.txt_num2.Focus()
            End If

        End If
    End Sub

    Private Sub txt_num2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num2.KeyPress
        If (((Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57)) Or ((Asc(e.KeyChar)) = 46 Or (Asc(e.KeyChar) = 8)) Then

            e.Handled = False
        Else
            e.Handled = True
            If ((Asc(e.KeyChar)) = 13) Then
                Me.btn_Total.Focus()
            End If
        End If
    End Sub

    Private Sub frm_prueba2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_num1_TextChanged(sender As Object, e As EventArgs) Handles txt_num1.TextChanged

    End Sub

    Private Sub txt_num2_TextChanged(sender As Object, e As EventArgs) Handles txt_num2.TextChanged

    End Sub

    Private Sub txt_n1_Click(sender As Object, e As EventArgs) Handles txt_n1.Click

    End Sub
End Class