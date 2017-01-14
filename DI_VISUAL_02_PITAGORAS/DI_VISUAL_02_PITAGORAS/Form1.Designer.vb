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
        Me.GroupPita = New System.Windows.Forms.GroupBox()
        Me.radCatGr = New System.Windows.Forms.RadioButton()
        Me.radCatPq = New System.Windows.Forms.RadioButton()
        Me.radHipo = New System.Windows.Forms.RadioButton()
        Me.lblHipo = New System.Windows.Forms.Label()
        Me.lblCatPq = New System.Windows.Forms.Label()
        Me.lblCatGr = New System.Windows.Forms.Label()
        Me.txtHipo = New System.Windows.Forms.TextBox()
        Me.txtCatGr = New System.Windows.Forms.TextBox()
        Me.txtCatPq = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.GroupPita.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPita
        '
        Me.GroupPita.Controls.Add(Me.radCatGr)
        Me.GroupPita.Controls.Add(Me.radCatPq)
        Me.GroupPita.Controls.Add(Me.radHipo)
        Me.GroupPita.Location = New System.Drawing.Point(15, 12)
        Me.GroupPita.Name = "GroupPita"
        Me.GroupPita.Size = New System.Drawing.Size(114, 106)
        Me.GroupPita.TabIndex = 0
        Me.GroupPita.TabStop = False
        Me.GroupPita.Text = "Elige resultado:"
        '
        'radCatGr
        '
        Me.radCatGr.AutoSize = True
        Me.radCatGr.Location = New System.Drawing.Point(14, 52)
        Me.radCatGr.Name = "radCatGr"
        Me.radCatGr.Size = New System.Drawing.Size(87, 17)
        Me.radCatGr.TabIndex = 2
        Me.radCatGr.TabStop = True
        Me.radCatGr.Text = "Cateto mayor"
        Me.radCatGr.UseVisualStyleBackColor = True
        '
        'radCatPq
        '
        Me.radCatPq.AutoSize = True
        Me.radCatPq.Location = New System.Drawing.Point(14, 75)
        Me.radCatPq.Name = "radCatPq"
        Me.radCatPq.Size = New System.Drawing.Size(88, 17)
        Me.radCatPq.TabIndex = 1
        Me.radCatPq.TabStop = True
        Me.radCatPq.Text = "Cateto menor"
        Me.radCatPq.UseVisualStyleBackColor = True
        '
        'radHipo
        '
        Me.radHipo.AutoSize = True
        Me.radHipo.Location = New System.Drawing.Point(14, 29)
        Me.radHipo.Name = "radHipo"
        Me.radHipo.Size = New System.Drawing.Size(79, 17)
        Me.radHipo.TabIndex = 0
        Me.radHipo.TabStop = True
        Me.radHipo.Text = "Hipotenusa"
        Me.radHipo.UseVisualStyleBackColor = True
        '
        'lblHipo
        '
        Me.lblHipo.AutoSize = True
        Me.lblHipo.Location = New System.Drawing.Point(150, 43)
        Me.lblHipo.Name = "lblHipo"
        Me.lblHipo.Size = New System.Drawing.Size(61, 13)
        Me.lblHipo.TabIndex = 1
        Me.lblHipo.Text = "Hipotenusa"
        '
        'lblCatPq
        '
        Me.lblCatPq.AutoSize = True
        Me.lblCatPq.Location = New System.Drawing.Point(149, 89)
        Me.lblCatPq.Name = "lblCatPq"
        Me.lblCatPq.Size = New System.Drawing.Size(70, 13)
        Me.lblCatPq.TabIndex = 2
        Me.lblCatPq.Text = "Cateto menor"
        '
        'lblCatGr
        '
        Me.lblCatGr.AutoSize = True
        Me.lblCatGr.Location = New System.Drawing.Point(150, 66)
        Me.lblCatGr.Name = "lblCatGr"
        Me.lblCatGr.Size = New System.Drawing.Size(69, 13)
        Me.lblCatGr.TabIndex = 3
        Me.lblCatGr.Text = "Cateto mayor"
        '
        'txtHipo
        '
        Me.txtHipo.Location = New System.Drawing.Point(236, 40)
        Me.txtHipo.Name = "txtHipo"
        Me.txtHipo.Size = New System.Drawing.Size(100, 20)
        Me.txtHipo.TabIndex = 4
        '
        'txtCatGr
        '
        Me.txtCatGr.Location = New System.Drawing.Point(236, 63)
        Me.txtCatGr.Name = "txtCatGr"
        Me.txtCatGr.Size = New System.Drawing.Size(100, 20)
        Me.txtCatGr.TabIndex = 5
        '
        'txtCatPq
        '
        Me.txtCatPq.Location = New System.Drawing.Point(236, 86)
        Me.txtCatPq.Name = "txtCatPq"
        Me.txtCatPq.Size = New System.Drawing.Size(100, 20)
        Me.txtCatPq.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(17, 124)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(268, 29)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "CALCULAR"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Location = New System.Drawing.Point(291, 124)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(44, 28)
        Me.btnClean.TabIndex = 8
        Me.btnClean.Text = "limpiar"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 163)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtCatPq)
        Me.Controls.Add(Me.txtCatGr)
        Me.Controls.Add(Me.txtHipo)
        Me.Controls.Add(Me.lblCatGr)
        Me.Controls.Add(Me.lblCatPq)
        Me.Controls.Add(Me.lblHipo)
        Me.Controls.Add(Me.GroupPita)
        Me.Name = "Form1"
        Me.Text = "DI 02 - MASIMEON"
        Me.GroupPita.ResumeLayout(False)
        Me.GroupPita.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupPita As GroupBox
    Friend WithEvents radCatGr As RadioButton
    Friend WithEvents radCatPq As RadioButton
    Friend WithEvents radHipo As RadioButton
    Friend WithEvents lblHipo As Label
    Friend WithEvents lblCatPq As Label
    Friend WithEvents lblCatGr As Label
    Friend WithEvents txtHipo As TextBox
    Friend WithEvents txtCatGr As TextBox
    Friend WithEvents txtCatPq As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClean As Button
End Class
