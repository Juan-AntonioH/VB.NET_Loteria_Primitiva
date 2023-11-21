Public Class Form2
    Public Property miPrimitiva As ArrayList
    Public Property sorteo As ArrayList
    Private aciertos As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = miPrimitiva(0)
        Label4.Text = miPrimitiva(1)
        Label5.Text = miPrimitiva(2)
        Label6.Text = miPrimitiva(3)
        Label7.Text = miPrimitiva(4)
        Label8.Text = miPrimitiva(5)
        Label10.Text = miPrimitiva(6)

        Label11.Text = sorteo(0)
        Label12.Text = sorteo(1)
        Label13.Text = sorteo(2)
        Label14.Text = sorteo(3)
        Label15.Text = sorteo(4)
        Label16.Text = sorteo(5)
        Label18.Text = sorteo(6)
        For Each numero As Integer In miPrimitiva
            If sorteo.Contains(numero) Then
                aciertos += 1
            End If
        Next
        Label19.Text &= " " & aciertos

    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' e.Cancel = True ' Cancela el cierre del formulario
        ' Me.Hide() ' Oculta el formulario en lugar de cerrarlo
        Form1.Borrar_todo()
    End Sub

End Class