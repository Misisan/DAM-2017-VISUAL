Public Class Form1
    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        'Reseteamos todos los TextBox
        txtHipo.Text = ""
        txtCatGr.Text = ""
        txtCatPq.Text = ""
    End Sub

    Private Sub radHipo_CheckedChanged(sender As Object, e As EventArgs) Handles radHipo.CheckedChanged
        'Si se elige el check de hipotenusa la hacemos de solo lectura
        txtHipo.ReadOnly = True
        txtCatGr.ReadOnly = False
        txtCatPq.ReadOnly = False
        'y eliminamos su valor previo
        txtHipo.Text = ""
    End Sub

    Private Sub radCatGr_CheckedChanged(sender As Object, e As EventArgs) Handles radCatGr.CheckedChanged
        'Si se elige el check del cateto mayor la hacemos de solo lectura
        'He elegido la propiedad readonly y no la enabled que se sugeria por considerar que al mostrar
        'una mejor visualización del elemento podemos hacer lo solicitado de mejor forma para el usuario
        txtHipo.ReadOnly = False
        txtCatGr.ReadOnly = True
        txtCatPq.ReadOnly = False
        'y eliminamos su valor previo
        txtCatGr.Text = ""
    End Sub

    Private Sub radCatPq_CheckedChanged(sender As Object, e As EventArgs) Handles radCatPq.CheckedChanged
        'Si se elige el check del cateto mayor la hacemos de solo lectura
        txtHipo.ReadOnly = False
        txtCatGr.ReadOnly = False
        txtCatPq.ReadOnly = True
        'y eliminamos su valor previo
        txtCatPq.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Recogemos los valores introducidos
        Dim h As Decimal = 0
        Dim c1 As Decimal = 0
        Dim c2 As Decimal = 0

        If Len(txtHipo.Text) > 0 Then
            h = CDec(txtHipo.Text)
        End If
        If Len(txtCatGr.Text) > 0 Then
            c1 = CDec(txtCatGr.Text)
        End If
        If Len(txtCatPq.Text) > 0 Then
            c2 = CDec(txtCatPq.Text)
        End If

        'Realizamos el cálculo según el radio que esté activado
        If (radHipo.Checked) Then
            'Comprobamos que tenemos los valores necesarios
            If c1 = 0 Or c2 = 0 Then
                MsgBox("Debes introducir todos los valores, y los valores deben ser mayores a 0.")
                Exit Sub
            End If
            'Cálculo de la hipotenusa
            h = (c1 ^ 2 + c2 ^ 2) ^ (1 / 2)

        ElseIf (radCatGr.Checked) Then
            'Comprobamos que tenemos los valores necesarios
            If h = 0 Or c2 = 0 Then
                MsgBox("Debes introducir todos los valores, y los valores deben ser mayores a 0.")
                Exit Sub
            End If
            'Comprobamos que la hipotenusa sea mayor al cateto
            If h <= c2 Then
                MsgBox("La hipotenusa no puede ser menor o igual al cateto introducido.")
                Exit Sub
            End If
            'Cálcula del cateto mayor
            c1 = (h ^ 2 - c2 ^ 2) ^ (1 / 2)

        ElseIf (radCatPq.Checked) Then
            'Comprobamos que tenemos los valores necesarios
            If c1 = 0 Or h = 0 Then
                MsgBox("Debes introducir todos los valores, y los valores deben ser mayores a 0.")
                Exit Sub
            End If
            'Comprobamos que la hipotenusa sea mayor al cateto
            If h <= c1 Then
                MsgBox("La hipotenusa no puede ser menor o igual al cateto introducido.")
                Exit Sub
            End If
            'Cálculo del cateto menor
            c2 = (h ^ 2 - c1 ^ 2) ^ (1 / 2)

        End If

        'Colocamos el resultado
        txtHipo.Text = h
        txtCatGr.Text = c1
        txtCatPq.Text = c2
    End Sub

    'Comprobamos que los datos introducidos son numéricos (también evita introducir números negativos)
    Private Sub txtHipo_TextChanged(sender As Object, e As EventArgs) Handles txtHipo.TextChanged
        If Not IsNumeric(txtHipo.Text) Then
            txtHipo.Text = ""
        End If
    End Sub
    'Comprobamos que los datos introducidos son numéricos (también evita introducir números negativos)
    Private Sub txtCatGr_TextChanged(sender As Object, e As EventArgs) Handles txtCatGr.TextChanged
        If Not IsNumeric(txtCatGr.Text) Then
            txtCatGr.Text = ""
        End If
    End Sub
    'Comprobamos que los datos introducidos son numéricos (también evita introducir números negativos)
    Private Sub txtCatPq_TextChanged(sender As Object, e As EventArgs) Handles txtCatPq.TextChanged
        If Not IsNumeric(txtCatPq.Text) Then
            txtCatPq.Text = ""
        End If
    End Sub
End Class
