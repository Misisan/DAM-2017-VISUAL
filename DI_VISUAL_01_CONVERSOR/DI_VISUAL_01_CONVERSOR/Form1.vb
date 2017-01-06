Public Class Form1
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        ori_bin.Checked = False
        ori_dec.Checked = False
        ori_hexa.Checked = False
        des_bin.Checked = False
        des_dec.Checked = False
        des_hexa.Checked = False
        txt_destino.Text = ""
        txt_origen.Text = ""
    End Sub

    Private Sub txt_origen_TextChanged(sender As Object, e As EventArgs) Handles txt_origen.TextChanged

        If Not IsNumeric(txt_origen.Text) And ori_hexa.Checked = False Then

        End If
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click

        'Decimal
        If ori_dec.Checked Then
            If IsNumeric(txt_origen.Text) Then


                If des_dec.Checked Then         'Decimal -> Decimal
                    txt_destino.Text = txt_origen.Text


                ElseIf des_bin.Checked Then     'Decimal -> Binario
                    Dim resto As String
                    Dim num As Long = Val(txt_origen.Text)
                    Dim res As String = ""

                    Do
                        resto = num Mod 2
                        res = res & Trim(Str(resto))
                        num = Int(num / 2)
                    Loop Until num < 2

                    If (num = 1) Then
                        res = "1" & StrReverse(res)
                    Else
                        res = StrReverse(res)
                    End If

                    txt_destino.Text = res

                ElseIf des_hexa.Checked Then        'Decimal -> Hexadecimal
                    txt_destino.Text = Hex(CInt(txt_origen.Text))
                Else
                    MsgBox("Debes seleccionar alguna opción de conversión en destino")
                End If
            Else
                MsgBox("Debes introducir únicamente dígitos")
                txt_origen.Text = ""
            End If

            'Binario
        ElseIf ori_bin.Checked Then
            If IsNumeric(txt_origen.Text) Then
                If des_dec.Checked Then             'Binario -> Decimal

                    Dim binario As String = StrReverse(txt_origen.Text)
                    Dim res As Integer = 0
                    Dim multiplicador As Integer = 1
                    Dim caracter As String

                    For i = 1 To Len(binario)
                        caracter = Mid(binario, i, 1)
                        res = res + (multiplicador * CInt(caracter))
                        multiplicador = multiplicador * 2
                    Next i

                    txt_destino.Text = CStr(res)

                ElseIf des_bin.Checked Then         'Binario -> Binario
                    txt_destino.Text = txt_origen.Text

                ElseIf des_hexa.Checked Then        'Binario -> Hexadecimal
                    Dim binario As String = StrReverse(txt_origen.Text)
                    Dim res As Integer = 0
                    Dim multiplicador As Integer = 1
                    Dim caracter As String

                    For i = 1 To Len(binario)
                        caracter = Mid(binario, i, 1)
                        res = res + (multiplicador * CInt(caracter))
                        multiplicador = multiplicador * 2
                    Next i

                    txt_destino.Text = Hex(CStr(res))
                Else
                    MsgBox("Debes seleccionar alguna opción de conversión en destino")
                End If
            Else
                MsgBox("Debes introducir únicamente 0 y 1")
                txt_origen.Text = ""
            End If

            'Hexadecimal
        ElseIf ori_hexa.Checked Then

            If des_dec.Checked Then             'Hexadecimal -> Decimal
                txt_destino.Text = CStr(Convert.ToInt32(txt_origen.Text, 16))

            ElseIf des_bin.Checked Then         'Hexadecimal -> Binario
                Dim resto As String
                Dim num As Long = Val(Convert.ToInt32(txt_origen.Text, 16))
                Dim res As String = ""

                Do
                    resto = num Mod 2
                    res = res & Trim(Str(resto))
                    num = Int(num / 2)
                Loop Until num < 2

                If (num = 1) Then
                    res = "1" & StrReverse(res)
                Else
                    res = StrReverse(res)
                End If

                txt_destino.Text = res

            ElseIf des_hexa.Checked Then        'Hexadecimal -> Hexadecimal
                txt_destino.Text = txt_origen.Text
            Else
                MsgBox("Debes seleccionar alguna opción de conversión en destino")
            End If
        Else
            MsgBox("Debes seleccionar alguna opción de conversión en origen")
        End If

    End Sub

End Class
