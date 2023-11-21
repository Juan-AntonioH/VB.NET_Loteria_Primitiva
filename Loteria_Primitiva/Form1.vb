Public Class Form1
    Dim miPrimitiva = New ArrayList()
    Dim sorteo = New ArrayList()
    Dim Contador As Integer
    Dim random As New Random()

    Private Sub Check_Box_Click(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox7.CheckedChanged, CheckBox6.CheckedChanged, CheckBox5.CheckedChanged, CheckBox49.CheckedChanged, CheckBox48.CheckedChanged, CheckBox47.CheckedChanged, CheckBox46.CheckedChanged, CheckBox45.CheckedChanged, CheckBox44.CheckedChanged, CheckBox43.CheckedChanged, CheckBox42.CheckedChanged, CheckBox41.CheckedChanged, CheckBox40.CheckedChanged, CheckBox4.CheckedChanged, CheckBox39.CheckedChanged, CheckBox38.CheckedChanged, CheckBox37.CheckedChanged, CheckBox36.CheckedChanged, CheckBox35.CheckedChanged, CheckBox34.CheckedChanged, CheckBox33.CheckedChanged, CheckBox32.CheckedChanged, CheckBox31.CheckedChanged, CheckBox30.CheckedChanged, CheckBox3.CheckedChanged, CheckBox29.CheckedChanged, CheckBox28.CheckedChanged, CheckBox27.CheckedChanged, CheckBox26.CheckedChanged, CheckBox25.CheckedChanged, CheckBox24.CheckedChanged, CheckBox23.CheckedChanged, CheckBox22.CheckedChanged, CheckBox21.CheckedChanged, CheckBox20.CheckedChanged, CheckBox2.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox17.CheckedChanged, CheckBox16.CheckedChanged, CheckBox15.CheckedChanged, CheckBox14.CheckedChanged, CheckBox13.CheckedChanged, CheckBox12.CheckedChanged, CheckBox11.CheckedChanged, CheckBox10.CheckedChanged, CheckBox1.CheckedChanged
        Dim check As CheckBox = DirectCast(sender, CheckBox)
        Dim numero As String = Val(check.Text.Replace(":", ""))
        Comprobacion(check, numero)


    End Sub



    Private Sub Comprobacion(check As CheckBox, numero As Integer)
        If check.Checked Then
            If miPrimitiva.Count >= 6 Then
                check.Checked = False
                MsgBox("Solo se pueden seleccionar hasta 6 números.", MsgBoxStyle.Exclamation, "Warning")
            Else
                miPrimitiva.Add(numero)
            End If
        Else
            miPrimitiva.Remove(numero)
        End If
    End Sub
    Private Sub Manual_Click(sender As Object, e As EventArgs) Handles Manual.Click
        Mostrar_resultados_sorteo(1)
    End Sub

    Private Sub Automatica_Click(sender As Object, e As EventArgs) Handles Automatica.Click
        Mostrar_resultados_sorteo(2)
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Borrar_todo()
    End Sub
    Public Sub Borrar_todo()
        miPrimitiva.Clear()
        sorteo.Clear()
        TextBox1.Text = 0
        For Each control As Control In Panel.Controls
            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                checkBox.Checked = False
            End If
        Next
    End Sub
    Private Sub Mostrar_resultados_sorteo(numero As Integer)
        Dim form2 As New Form2()
        If numero = 1 Then
            If miPrimitiva.Count < 6 Then
                MsgBox("Por favor, seleccione primero 6 números con los que quieras jugar.", MsgBoxStyle.Exclamation, "Warning")
            Else
                repetido(numero)
                Form2.miPrimitiva = miPrimitiva
                Form2.sorteo = sorteo
                Form2.Show()
            End If
        Else
            repetido(numero)
            Form2.miPrimitiva = miPrimitiva
            Form2.sorteo = sorteo
            Form2.Show()
        End If

    End Sub

    Private Sub repetido(numero As Integer)
        Dim aleatorio As Integer
        If numero = 1 Then
            miPrimitiva.Sort()
            aleatorio = random.Next(0, 10)
            miPrimitiva.Add(aleatorio)
            TextBox1.Text = aleatorio
            NumerosAutomaticos(numero)
        Else
            NumerosAutomaticos(numero)
        End If
    End Sub
    Private Sub NumerosAutomaticos(numero As Integer)
        Dim aleatorio As Integer
        If numero = 1 Then
            sorteo.Clear()
            While sorteo.Count < 6
                aleatorio = random.Next(1, 50)
                If Not sorteo.Contains(aleatorio) Then
                    sorteo.Add(aleatorio)
                End If
            End While
            sorteo.Sort()
            aleatorio = random.Next(0, 10)
            sorteo.Add(aleatorio)
        Else
            miPrimitiva.Clear()
            While miPrimitiva.Count < 6
                aleatorio = random.Next(1, 50)
                If Not miPrimitiva.Contains(aleatorio) Then
                    miPrimitiva.Add(aleatorio)
                End If
            End While
            miPrimitiva.Sort()
            aleatorio = random.Next(0, 10)
            miPrimitiva.Add(aleatorio)
            TextBox1.Text = aleatorio
            NumerosAutomaticos(1)
        End If
    End Sub
End Class
