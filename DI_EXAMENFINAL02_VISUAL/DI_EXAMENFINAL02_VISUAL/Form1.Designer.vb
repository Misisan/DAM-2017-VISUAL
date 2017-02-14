<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trackC = New System.Windows.Forms.TrackBar()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.trackF = New System.Windows.Forms.TrackBar()
        Me.trackK = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.trackC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celsius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fahrenheit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kelvin"
        '
        'trackC
        '
        Me.trackC.Location = New System.Drawing.Point(39, 50)
        Me.trackC.Maximum = 100
        Me.trackC.Minimum = -273
        Me.trackC.Name = "trackC"
        Me.trackC.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackC.Size = New System.Drawing.Size(45, 283)
        Me.trackC.TabIndex = 3
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(25, 339)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(66, 20)
        Me.txtC.TabIndex = 4
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(251, 339)
        Me.txtK.Name = "txtK"
        Me.txtK.ReadOnly = True
        Me.txtK.Size = New System.Drawing.Size(66, 20)
        Me.txtK.TabIndex = 5
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(141, 339)
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(66, 20)
        Me.txtF.TabIndex = 6
        '
        'trackF
        '
        Me.trackF.Location = New System.Drawing.Point(151, 50)
        Me.trackF.Maximum = 212
        Me.trackF.Minimum = -460
        Me.trackF.Name = "trackF"
        Me.trackF.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackF.Size = New System.Drawing.Size(45, 283)
        Me.trackF.TabIndex = 7
        '
        'trackK
        '
        Me.trackK.Location = New System.Drawing.Point(262, 50)
        Me.trackK.Maximum = 373
        Me.trackK.Name = "trackK"
        Me.trackK.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackK.Size = New System.Drawing.Size(45, 283)
        Me.trackK.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "373 ºK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "0 ºK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "-460 ºF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "212 ºF"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "-273 ºC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "100 ºC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 389)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trackK)
        Me.Controls.Add(Me.trackF)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtK)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.trackC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trackC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents trackC As TrackBar
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtK As TextBox
    Friend WithEvents txtF As TextBox
    Friend WithEvents trackF As TrackBar
    Friend WithEvents trackK As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
