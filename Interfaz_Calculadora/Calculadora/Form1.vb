Public Class frmPrincipal

    Dim operacion As String
    Dim resultado As Nullable(Of Double) = Nothing
    Dim numero2 As Nullable(Of Double) = Nothing
    Dim evaluaroperador As Boolean
    Private Sub Click_btns(sender As Button, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        lblAux.Text += sender.Text
        Total()
        txtbDisplay.Text += sender.Text
    End Sub
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "+"
    End Sub
    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "-"
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "*"
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "/"
    End Sub
    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "^"
    End Sub
    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        lblAux.Text += sender.Text
        Operaciones()
        operacion = "R"
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Operaciones()
        lblAux.Text = txtbDisplay.Text
        operacion = ""
    End Sub
    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        lblAux.Text += sender.Text
        If InStr(txtbDisplay.Text, ".", CompareMethod.Text) = 0 Then
            txtbDisplay.Text &= "."
        End If
    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblAux.Text = ""
        txtbDisplay.Text = "0"
        numero2 = Nothing
        resultado = Nothing
    End Sub

    Public Sub Operaciones()
        evaluaroperador = True
        numero2 = Val(txtbDisplay.Text)
        If resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    resultado = resultado + numero2
                Case "-"
                    resultado = resultado - numero2
                Case "*"
                    resultado = resultado * numero2
                Case "/"
                    resultado = resultado / numero2
                Case "^"
                    resultado = resultado ^ numero2
                Case "R"
                    resultado = Math.Sqrt(resultado)
            End Select
            txtbDisplay.Text = resultado
        Else
            resultado = numero2
        End If
    End Sub

    Public Sub Total()
        If evaluaroperador = True Then
            txtbDisplay.Text = ""
            evaluaroperador = False
        ElseIf txtbDisplay.Text = "0" Then
            txtbDisplay.Text = ""
        End If
    End Sub


End Class
