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
        Me.txt_origen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_destino = New System.Windows.Forms.TextBox()
        Me.ori_dec = New System.Windows.Forms.RadioButton()
        Me.ori_bin = New System.Windows.Forms.RadioButton()
        Me.ori_hexa = New System.Windows.Forms.RadioButton()
        Me.des_hexa = New System.Windows.Forms.RadioButton()
        Me.des_bin = New System.Windows.Forms.RadioButton()
        Me.des_dec = New System.Windows.Forms.RadioButton()
        Me.group_ori = New System.Windows.Forms.GroupBox()
        Me.group_dest = New System.Windows.Forms.GroupBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.group_ori.SuspendLayout()
        Me.group_dest.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'txt_origen
        '
        Me.txt_origen.Location = New System.Drawing.Point(79, 35)
        Me.txt_origen.Name = "txt_origen"
        Me.txt_origen.Size = New System.Drawing.Size(100, 20)
        Me.txt_origen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Destino"
        '
        'txt_destino
        '
        Me.txt_destino.Location = New System.Drawing.Point(254, 35)
        Me.txt_destino.Name = "txt_destino"
        Me.txt_destino.ReadOnly = True
        Me.txt_destino.Size = New System.Drawing.Size(100, 20)
        Me.txt_destino.TabIndex = 3
        '
        'ori_dec
        '
        Me.ori_dec.AutoSize = True
        Me.ori_dec.Location = New System.Drawing.Point(19, 24)
        Me.ori_dec.Name = "ori_dec"
        Me.ori_dec.Size = New System.Drawing.Size(63, 17)
        Me.ori_dec.TabIndex = 4
        Me.ori_dec.TabStop = True
        Me.ori_dec.Text = "Decimal"
        Me.ori_dec.UseVisualStyleBackColor = True
        '
        'ori_bin
        '
        Me.ori_bin.AutoSize = True
        Me.ori_bin.Location = New System.Drawing.Point(19, 47)
        Me.ori_bin.Name = "ori_bin"
        Me.ori_bin.Size = New System.Drawing.Size(57, 17)
        Me.ori_bin.TabIndex = 5
        Me.ori_bin.TabStop = True
        Me.ori_bin.Text = "Binario"
        Me.ori_bin.UseVisualStyleBackColor = True
        '
        'ori_hexa
        '
        Me.ori_hexa.AutoSize = True
        Me.ori_hexa.Location = New System.Drawing.Point(19, 70)
        Me.ori_hexa.Name = "ori_hexa"
        Me.ori_hexa.Size = New System.Drawing.Size(86, 17)
        Me.ori_hexa.TabIndex = 6
        Me.ori_hexa.TabStop = True
        Me.ori_hexa.Text = "Hexadecimal"
        Me.ori_hexa.UseVisualStyleBackColor = True
        '
        'des_hexa
        '
        Me.des_hexa.AutoSize = True
        Me.des_hexa.Location = New System.Drawing.Point(21, 68)
        Me.des_hexa.Name = "des_hexa"
        Me.des_hexa.Size = New System.Drawing.Size(86, 17)
        Me.des_hexa.TabIndex = 9
        Me.des_hexa.TabStop = True
        Me.des_hexa.Text = "Hexadecimal"
        Me.des_hexa.UseVisualStyleBackColor = True
        '
        'des_bin
        '
        Me.des_bin.AutoSize = True
        Me.des_bin.Location = New System.Drawing.Point(21, 45)
        Me.des_bin.Name = "des_bin"
        Me.des_bin.Size = New System.Drawing.Size(57, 17)
        Me.des_bin.TabIndex = 8
        Me.des_bin.TabStop = True
        Me.des_bin.Text = "Binario"
        Me.des_bin.UseVisualStyleBackColor = True
        '
        'des_dec
        '
        Me.des_dec.AutoSize = True
        Me.des_dec.Location = New System.Drawing.Point(21, 22)
        Me.des_dec.Name = "des_dec"
        Me.des_dec.Size = New System.Drawing.Size(63, 17)
        Me.des_dec.TabIndex = 7
        Me.des_dec.TabStop = True
        Me.des_dec.Text = "Decimal"
        Me.des_dec.UseVisualStyleBackColor = True
        '
        'group_ori
        '
        Me.group_ori.Controls.Add(Me.ori_hexa)
        Me.group_ori.Controls.Add(Me.ori_dec)
        Me.group_ori.Controls.Add(Me.ori_bin)
        Me.group_ori.Location = New System.Drawing.Point(38, 85)
        Me.group_ori.Name = "group_ori"
        Me.group_ori.Size = New System.Drawing.Size(141, 98)
        Me.group_ori.TabIndex = 10
        Me.group_ori.TabStop = False
        Me.group_ori.Text = "Sistema Origen"
        '
        'group_dest
        '
        Me.group_dest.Controls.Add(Me.des_bin)
        Me.group_dest.Controls.Add(Me.des_dec)
        Me.group_dest.Controls.Add(Me.des_hexa)
        Me.group_dest.Location = New System.Drawing.Point(214, 87)
        Me.group_dest.Name = "group_dest"
        Me.group_dest.Size = New System.Drawing.Size(140, 96)
        Me.group_dest.TabIndex = 11
        Me.group_dest.TabStop = False
        Me.group_dest.Text = "Sistema Destino"
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(38, 200)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(315, 30)
        Me.btn_calc.TabIndex = 12
        Me.btn_calc.Text = "CALCULAR"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(166, 236)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(63, 24)
        Me.btn_limpiar.TabIndex = 13
        Me.btn_limpiar.Text = "limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 272)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.group_dest)
        Me.Controls.Add(Me.group_ori)
        Me.Controls.Add(Me.txt_destino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_origen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.group_ori.ResumeLayout(False)
        Me.group_ori.PerformLayout()
        Me.group_dest.ResumeLayout(False)
        Me.group_dest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_origen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ori_dec As RadioButton
    Friend WithEvents ori_bin As RadioButton
    Friend WithEvents ori_hexa As RadioButton
    Friend WithEvents des_hexa As RadioButton
    Friend WithEvents des_bin As RadioButton
    Friend WithEvents des_dec As RadioButton
    Friend WithEvents group_ori As GroupBox
    Friend WithEvents group_dest As GroupBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_limpiar As Button
    Public WithEvents txt_destino As TextBox
End Class
