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
        Me.components = New System.ComponentModel.Container()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.TablaInnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BibliotecaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BibliotecaDataSet = New DI_VISUAL_04.bibliotecaDataSet()
        Me.TablaInnerTableAdapter = New DI_VISUAL_04.bibliotecaDataSetTableAdapters.TablaInnerTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearBornDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recuento = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaInnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.AutoGenerateColumns = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.YearBornDataGridViewTextBoxColumn})
        Me.grid.DataSource = Me.TablaInnerBindingSource
        Me.grid.Location = New System.Drawing.Point(12, 12)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(644, 365)
        Me.grid.TabIndex = 0
        '
        'TablaInnerBindingSource
        '
        Me.TablaInnerBindingSource.DataMember = "TablaInner"
        Me.TablaInnerBindingSource.DataSource = Me.BibliotecaDataSetBindingSource
        '
        'BibliotecaDataSetBindingSource
        '
        Me.BibliotecaDataSetBindingSource.DataSource = Me.BibliotecaDataSet
        Me.BibliotecaDataSetBindingSource.Position = 0
        '
        'BibliotecaDataSet
        '
        Me.BibliotecaDataSet.DataSetName = "bibliotecaDataSet"
        Me.BibliotecaDataSet.EnforceConstraints = False
        Me.BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaInnerTableAdapter
        '
        Me.TablaInnerTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Year_Published"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Año Publicación"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Título"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Author"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'YearBornDataGridViewTextBoxColumn
        '
        Me.YearBornDataGridViewTextBoxColumn.DataPropertyName = "Year_Born"
        Me.YearBornDataGridViewTextBoxColumn.HeaderText = "Año nacimiento"
        Me.YearBornDataGridViewTextBoxColumn.Name = "YearBornDataGridViewTextBoxColumn"
        Me.YearBornDataGridViewTextBoxColumn.ReadOnly = True
        '
        'recuento
        '
        Me.recuento.AutoSize = True
        Me.recuento.Location = New System.Drawing.Point(15, 391)
        Me.recuento.Name = "recuento"
        Me.recuento.Size = New System.Drawing.Size(39, 13)
        Me.recuento.TabIndex = 1
        Me.recuento.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 414)
        Me.Controls.Add(Me.recuento)
        Me.Controls.Add(Me.grid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaInnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents BibliotecaDataSetBindingSource As BindingSource
    Friend WithEvents BibliotecaDataSet As bibliotecaDataSet
    Friend WithEvents TablaInnerBindingSource As BindingSource
    Friend WithEvents TablaInnerTableAdapter As bibliotecaDataSetTableAdapters.TablaInnerTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearPublishedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents YearBornDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents recuento As Label
End Class
