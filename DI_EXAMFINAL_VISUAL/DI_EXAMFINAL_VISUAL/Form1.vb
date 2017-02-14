Public Class Form1

    Private Sub rdAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rdAzul.CheckedChanged
        txt.Visible = True
        txt.BackColor = Color.Blue
    End Sub

    Private Sub rdRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rdRojo.CheckedChanged
        txt.Visible = True
        txt.BackColor = Color.Red
    End Sub

    Private Sub rdVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rdVerde.CheckedChanged
        txt.Visible = True
        txt.BackColor = Color.Green
    End Sub

    Private Sub rdAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rdAmarillo.CheckedChanged
        txt.Visible = True
        txt.BackColor = Color.Yellow
    End Sub

    Private Sub rdArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rdArriba.CheckedChanged
        txt.SetBounds(186, 30, 386, 40)
        txt.Visible = True
    End Sub

    Private Sub rdAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rdAbajo.CheckedChanged
        txt.SetBounds(186, 258, 386, 40)
        txt.Visible = True
    End Sub

    Private Sub rdIzq_CheckedChanged(sender As Object, e As EventArgs) Handles rdIzq.CheckedChanged
        txt.SetBounds(186, 30, 40, 248)
        txt.Visible = True
    End Sub

    Private Sub rdDer_CheckedChanged(sender As Object, e As EventArgs) Handles rdDer.CheckedChanged
        txt.SetBounds(552, 30, 40, 248)
        txt.Visible = True
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt.SetBounds(0, 0, 0, 0)
        txt.Visible = False
    End Sub
End Class
