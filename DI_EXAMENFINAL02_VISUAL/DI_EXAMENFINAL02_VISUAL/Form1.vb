Public Class Form1
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles trackC.Scroll
        txtC.Text = trackC.Value

        trackF.Value = (trackC.Value * (9 / 5)) + 32
        txtF.Text = trackF.Value

        trackK.Value = trackC.Value + 273
        txtK.Text = trackK.Value
    End Sub

    Private Sub trackF_Scroll(sender As Object, e As EventArgs) Handles trackF.Scroll
        txtF.Text = trackF.Value

        trackC.Value = (trackF.Value - 32) * (5 / 9)
        txtC.Text = trackC.Value

        trackK.Value = trackC.Value + 273
        txtK.Text = trackK.Value

    End Sub

    Private Sub trackK_Scroll(sender As Object, e As EventArgs) Handles trackK.Scroll
        txtK.Text = trackK.Value

        trackC.Value = trackK.Value - 273
        txtC.Text = trackC.Value

        trackF.Value = (trackC.Value * (9 / 5)) + 32
        txtF.Text = trackF.Value

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trackC.Value = 0
        txtC.Text = 0
        trackF.Value = 32
        txtF.Text = 32
        trackK.Value = 273
        txtK.Text = 273
    End Sub

End Class
