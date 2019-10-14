Public Class Form1


    Dim operacion As String
    Dim resultado As Nullable(Of Double) = Nothing
    Dim n1 As Nullable(Of Double) = Nothing
    Dim bandera As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        borrar()
        TextBox1.Text &= "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        borrar()
        TextBox1.Text &= "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        borrar()
        TextBox1.Text &= "3"

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        borrar()
        TextBox1.Text &= "4"

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        borrar()
        TextBox1.Text &= "5"

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        borrar()
        TextBox1.Text &= "6"

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        borrar()
        TextBox1.Text &= "7"

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        borrar()
        TextBox1.Text &= "8"

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        borrar()
        TextBox1.Text &= "8"

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        OperacionesCalcular()
        operacion = "+"

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        OperacionesCalcular()
        operacion = "*"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        OperacionesCalcular()
        operacion = "-"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        OperacionesCalcular()
        operacion = "/"

    End Sub

    Private Sub Butto11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OperacionesCalcular()

        operacion = ""

    End Sub

    Public Sub OperacionesCalcular()

        n1 = TextBox1.Text

        bandera = True
        n1 = Val(TextBox1.Text)
        If resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    resultado = resultado + n1
                Case "-"
                    resultado = resultado - n1
                Case "*"
                    resultado = resultado * n1
                Case "/"
                    resultado = resultado / n1
            End Select
            TextBox1.Text = resultado
        Else
            resultado = n1

        End If



    End Sub

    Public Sub borrar()
        If bandera = True Then
            TextBox1.Text = ""
            bandera = False

        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        TextBox1.Text = "0"
        resultado = Nothing
        n1 = Nothing

    End Sub


End Class
