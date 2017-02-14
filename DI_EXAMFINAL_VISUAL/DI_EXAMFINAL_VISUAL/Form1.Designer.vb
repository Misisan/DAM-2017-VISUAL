<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Colores = New System.Windows.Forms.GroupBox()
        Me.rdAmarillo = New System.Windows.Forms.RadioButton()
        Me.rdVerde = New System.Windows.Forms.RadioButton()
        Me.rdRojo = New System.Windows.Forms.RadioButton()
        Me.rdAzul = New System.Windows.Forms.RadioButton()
        Me.Posiciones = New System.Windows.Forms.GroupBox()
        Me.rdDer = New System.Windows.Forms.RadioButton()
        Me.rdIzq = New System.Windows.Forms.RadioButton()
        Me.rdAbajo = New System.Windows.Forms.RadioButton()
        Me.rdArriba = New System.Windows.Forms.RadioButton()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Colores.SuspendLayout()
        Me.Posiciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Colores
        '
        Me.Colores.Controls.Add(Me.rdAmarillo)
        Me.Colores.Controls.Add(Me.rdVerde)
        Me.Colores.Controls.Add(Me.rdRojo)
        Me.Colores.Controls.Add(Me.rdAzul)
        Me.Colores.Location = New System.Drawing.Point(25, 20)
        Me.Colores.Name = "Colores"
        Me.Colores.Size = New System.Drawing.Size(138, 126)
        Me.Colores.TabIndex = 0
        Me.Colores.TabStop = False
        Me.Colores.Text = "Colores"
        '
        'rdAmarillo
        '
        Me.rdAmarillo.AutoSize = True
        Me.rdAmarillo.Location = New System.Drawing.Point(20, 95)
        Me.rdAmarillo.Name = "rdAmarillo"
        Me.rdAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.rdAmarillo.TabIndex = 3
        Me.rdAmarillo.TabStop = True
        Me.rdAmarillo.Text = "Amarillo"
        Me.rdAmarillo.UseVisualStyleBackColor = True
        '
        'rdVerde
        '
        Me.rdVerde.AutoSize = True
        Me.rdVerde.Location = New System.Drawing.Point(20, 72)
        Me.rdVerde.Name = "rdVerde"
        Me.rdVerde.Size = New System.Drawing.Size(53, 17)
        Me.rdVerde.TabIndex = 2
        Me.rdVerde.TabStop = True
        Me.rdVerde.Text = "Verde"
        Me.rdVerde.UseVisualStyleBackColor = True
        '
        'rdRojo
        '
        Me.rdRojo.AutoSize = True
        Me.rdRojo.Location = New System.Drawing.Point(20, 49)
        Me.rdRojo.Name = "rdRojo"
        Me.rdRojo.Size = New System.Drawing.Size(47, 17)
        Me.rdRojo.TabIndex = 1
        Me.rdRojo.TabStop = True
        Me.rdRojo.Text = "Rojo"
        Me.rdRojo.UseVisualStyleBackColor = True
        '
        'rdAzul
        '
        Me.rdAzul.AutoSize = True
        Me.rdAzul.Location = New System.Drawing.Point(20, 26)
        Me.rdAzul.Name = "rdAzul"
        Me.rdAzul.Size = New System.Drawing.Size(45, 17)
        Me.rdAzul.TabIndex = 0
        Me.rdAzul.TabStop = True
        Me.rdAzul.Text = "Azul"
        Me.rdAzul.UseVisualStyleBackColor = True
        '
        'Posiciones
        '
        Me.Posiciones.Controls.Add(Me.rdDer)
        Me.Posiciones.Controls.Add(Me.rdIzq)
        Me.Posiciones.Controls.Add(Me.rdAbajo)
        Me.Posiciones.Controls.Add(Me.rdArriba)
        Me.Posiciones.Location = New System.Drawing.Point(25, 152)
        Me.Posiciones.Name = "Posiciones"
        Me.Posiciones.Size = New System.Drawing.Size(138, 126)
        Me.Posiciones.TabIndex = 4
        Me.Posiciones.TabStop = False
        Me.Posiciones.Text = "Posiciones"
        '
        'rdDer
        '
        Me.rdDer.AutoSize = True
        Me.rdDer.Location = New System.Drawing.Point(20, 95)
        Me.rdDer.Name = "rdDer"
        Me.rdDer.Size = New System.Drawing.Size(66, 17)
        Me.rdDer.TabIndex = 3
        Me.rdDer.TabStop = True
        Me.rdDer.Text = "Derecha"
        Me.rdDer.UseVisualStyleBackColor = True
        '
        'rdIzq
        '
        Me.rdIzq.AutoSize = True
        Me.rdIzq.Location = New System.Drawing.Point(20, 72)
        Me.rdIzq.Name = "rdIzq"
        Me.rdIzq.Size = New System.Drawing.Size(68, 17)
        Me.rdIzq.TabIndex = 2
        Me.rdIzq.TabStop = True
        Me.rdIzq.Text = "Izquierda"
        Me.rdIzq.UseVisualStyleBackColor = True
        '
        'rdAbajo
        '
        Me.rdAbajo.AutoSize = True
        Me.rdAbajo.Location = New System.Drawing.Point(20, 49)
        Me.rdAbajo.Name = "rdAbajo"
        Me.rdAbajo.Size = New System.Drawing.Size(52, 17)
        Me.rdAbajo.TabIndex = 1
        Me.rdAbajo.TabStop = True
        Me.rdAbajo.Text = "Abajo"
        Me.rdAbajo.UseVisualStyleBackColor = True
        '
        'rdArriba
        '
        Me.rdArriba.AutoSize = True
        Me.rdArriba.Location = New System.Drawing.Point(20, 26)
        Me.rdArriba.Name = "rdArriba"
        Me.rdArriba.Size = New System.Drawing.Size(52, 17)
        Me.rdArriba.TabIndex = 0
        Me.rdArriba.TabStop = True
        Me.rdArriba.Text = "Arriba"
        Me.rdArriba.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(27, 296)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(102, 31)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(186, 30)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(386, 39)
        Me.txt.TabIndex = 6
        Me.txt.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 362)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Posiciones)
        Me.Controls.Add(Me.Colores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Colores.ResumeLayout(False)
        Me.Colores.PerformLayout()
        Me.Posiciones.ResumeLayout(False)
        Me.Posiciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Colores As GroupBox
    Friend WithEvents rdAmarillo As RadioButton
    Friend WithEvents rdVerde As RadioButton
    Friend WithEvents rdRojo As RadioButton
    Friend WithEvents rdAzul As RadioButton
    Friend WithEvents Posiciones As GroupBox
    Friend WithEvents rdDer As RadioButton
    Friend WithEvents rdIzq As RadioButton
    Friend WithEvents rdAbajo As RadioButton
    Friend WithEvents rdArriba As RadioButton
    Friend WithEvents btn_salir As Button
    Friend WithEvents txt As TextBox
End Class
