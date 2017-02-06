Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.TablaInner' Puede moverla o quitarla según sea necesario.
        Me.TablaInnerTableAdapter.Fill(Me.BibliotecaDataSet.TablaInner)

        recuento.Text = "Hay un total de: " & CStr(grid.RowCount) & " registros."
    End Sub

End Class
