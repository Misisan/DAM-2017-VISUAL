Public Class Form1

    'Variables
    Dim numeroInicial As Double = 0
    Dim signo As Boolean = True
    Dim dec As Boolean = True
    Dim primernumero As Boolean = True
    Dim primeraOpe As Boolean = True
    'Variables para la memoria
    Dim memo As String
    'Variables opración activa
    Dim operacion As String = ""
    'Variables para identificar las operaciones
    Dim suma As String = "ope_suma"
    Dim resta As String = "ope_resta"
    Dim multi As String = "ope_multiplicar"
    Dim div As String = "ope_dividir"
    Dim pot As String = "ope_potencia"
    Dim raiz As String = "ope_raiz"
    Dim seno As String = "ope_seno"
    Dim coseno As String = "ope_coseno"


    'Eventos para los botones de los números
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        clickNumero(CStr(1))
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        clickNumero(CStr(2))
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        clickNumero(CStr(3))
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        clickNumero(CStr(4))
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        clickNumero(CStr(5))
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        clickNumero(CStr(6))
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        clickNumero(CStr(7))
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        clickNumero(CStr(8))
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        clickNumero(CStr(9))
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        clickNumero(CStr(0))
    End Sub

    'Acción de los botones de los números
    Private Sub clickNumero(num As String)
        If primernumero = True Then
            pantalla.Text = num
        Else
            pantalla.Text = pantalla.Text & num
        End If

        primernumero = False
    End Sub

    'Eventos para el botón de cambio de signo
    Private Sub btnsigno_Click(sender As Object, e As EventArgs) Handles btnsigno.Click

        'Si es positivo pasa a negativo y se añade el -
        'Si es negativo pasa a positivo y se corta de la cadena el -
        If signo = True Then
            pantalla.Text = "-" & pantalla.Text
            signo = False
        Else
            pantalla.Text = Mid(pantalla.Text, 2, 100)
            signo = True
        End If
    End Sub

    'Eventos para el botón de decimal
    Private Sub btndec_Click(sender As Object, e As EventArgs) Handles btndec.Click

        'Si aún no hay un número introducido no se pone una coma (salimos del subproceso)
        If primernumero = True Then
            Exit Sub
        End If

        If dec = True Then
            pantalla.Text = pantalla.Text & ","
            dec = False
        End If
    End Sub

    'Evento botón reiniciar
    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        reiniciar()
    End Sub

    'Reiniciar todo
    Private Sub reiniciar()
        'Reiniciamos las variables
        numeroInicial = 0
        operacion = ""
        signo = True
        dec = True
        primernumero = True
        primeraOpe = True

        'Borramos la pantalla
        pantalla.Text = ""
    End Sub

    'Botón de guardar en memoria
    Private Sub btnMemoIn_Click(sender As Object, e As EventArgs) Handles btnMemoIn.Click
        memo = pantalla.Text
    End Sub

    'Botón de sacar de la memoria
    Private Sub btnMemoOut_Click(sender As Object, e As EventArgs) Handles btnMemoOut.Click
        pantalla.Text = memo
    End Sub

    'Evento botón Sumar +
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        cambioOpe(suma)
        calculo()
    End Sub

    'Evento botón restar -
    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        cambioOpe(resta)
        calculo()
    End Sub

    'Evento botón multiplicar x
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        cambioOpe(multi)
        calculo()
    End Sub
    'Evento botón dividir /
    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        cambioOpe(div)
        calculo()
    End Sub

    'Evento botón elevar a potencia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPot.Click
        cambioOpe(pot)
        calculo()
    End Sub

    'Evento botón raiz
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        cambioOpe(raiz)
        calculo()
    End Sub

    'Evento botón seno
    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        cambioOpe(seno)
        calculo()
    End Sub

    'Evento botón coseno
    Private Sub BtnCoseno_Click(sender As Object, e As EventArgs) Handles BtnCoseno.Click
        cambioOpe(coseno)
        calculo()
    End Sub

    'Cambiar tipo de operación activa
    Private Sub cambioOpe(opeSelecc As String)
        'Si no hay nada en pantalla sale del subproceso
        If Not Len(pantalla.Text) > 0 Then
            Exit Sub
        End If

        'Si no es un número sale del subproceso
        'Evitamos que haga nada si hay solo un -
        If Not IsNumeric(pantalla.Text) Then
            Exit Sub
        End If

        operacion = opeSelecc
        dec = True
        primernumero = True
        signo = True
    End Sub

    'Evento botón igual =
    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        calculo()
        'Reiniciamos las variables
        numeroInicial = 0
        operacion = ""
        signo = True
        dec = True
        primernumero = True
        primeraOpe = True
    End Sub

    'Cálculo
    Private Sub calculo()
        Dim numeroSegundo As Double
        Dim resultado As Double

        'Si no hay nada en pantalla sale del subproceso
        If Not Len(pantalla.Text) > 0 Then
            Exit Sub
        End If

        'Si no es un número sale del subproceso
        'Evitamos que haga nada si hay solo un -
        If Not IsNumeric(pantalla.Text) Then
            Exit Sub
        End If

        resultado = numeroInicial
        numeroSegundo = CDbl(pantalla.Text)

        'Según el tipo de operación utilizamos un tipo de cálculo
        Select Case operacion
            Case suma
                resultado = numeroInicial + numeroSegundo
            Case resta
                resultado = numeroInicial - numeroSegundo
            Case multi
                resultado = numeroInicial * numeroSegundo
            Case div
                If numeroSegundo = 0 Then
                    MsgBox("Número indeterminado")
                    reiniciar()
                    Exit Sub
                Else
                    resultado = numeroInicial / numeroSegundo
                End If
            Case pot
                resultado = numeroInicial ^ 2
            Case raiz
                resultado = numeroInicial ^ (1 / 2)
            Case seno
                resultado = Math.Sin(numeroSegundo)
            Case coseno
                resultado = Math.Cos(numeroSegundo)
        End Select

        If primeraOpe And Not (operacion = seno Or operacion = coseno) Then
            resultado = numeroSegundo
        End If

        pantalla.Text = CStr(resultado)
        numeroInicial = resultado
        primeraOpe = False
    End Sub

    'Botón C de borrado de pantalla
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnC.Click
        pantalla.Text = ""
        primernumero = True
    End Sub


End Class
