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
        Me.components = New System.ComponentModel.Container()
        Dim Codigo_CancionLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim DuracionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CancionesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CancionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MusicaDBDataSet = New Parcial_POO.MusicaDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancionesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Codigo_CancionTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.DuracionTextBox = New System.Windows.Forms.TextBox()
        Me.Btninsert = New System.Windows.Forms.Button()
        Me.Btnedit = New System.Windows.Forms.Button()
        Me.Btnborrar = New System.Windows.Forms.Button()
        Me.Btnsalir = New System.Windows.Forms.Button()
        Me.Btnbusc = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.CancionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CancionesTableAdapter = New Parcial_POO.MusicaDBDataSetTableAdapters.CancionesTableAdapter()
        Me.TableAdapterManager = New Parcial_POO.MusicaDBDataSetTableAdapters.TableAdapterManager()
        Codigo_CancionLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        DuracionLabel = New System.Windows.Forms.Label()
        CType(Me.CancionesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CancionesBindingNavigator.SuspendLayout()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MusicaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Codigo_CancionLabel
        '
        Codigo_CancionLabel.AutoSize = True
        Codigo_CancionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Codigo_CancionLabel.ForeColor = System.Drawing.Color.Black
        Codigo_CancionLabel.Location = New System.Drawing.Point(12, 44)
        Codigo_CancionLabel.Name = "Codigo_CancionLabel"
        Codigo_CancionLabel.Size = New System.Drawing.Size(132, 20)
        Codigo_CancionLabel.TabIndex = 2
        Codigo_CancionLabel.Text = "Codigo Cancion:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TituloLabel.ForeColor = System.Drawing.Color.Black
        TituloLabel.Location = New System.Drawing.Point(89, 94)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(55, 20)
        TituloLabel.TabIndex = 4
        TituloLabel.Text = "Titulo:"
        '
        'DuracionLabel
        '
        DuracionLabel.AutoSize = True
        DuracionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuracionLabel.ForeColor = System.Drawing.Color.Black
        DuracionLabel.Location = New System.Drawing.Point(62, 147)
        DuracionLabel.Name = "DuracionLabel"
        DuracionLabel.Size = New System.Drawing.Size(82, 20)
        DuracionLabel.TabIndex = 6
        DuracionLabel.Text = "Duracion:"
        '
        'CancionesBindingNavigator
        '
        Me.CancionesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CancionesBindingNavigator.BindingSource = Me.CancionesBindingSource
        Me.CancionesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CancionesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CancionesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CancionesBindingNavigatorSaveItem})
        Me.CancionesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CancionesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CancionesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CancionesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CancionesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CancionesBindingNavigator.Name = "CancionesBindingNavigator"
        Me.CancionesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CancionesBindingNavigator.Size = New System.Drawing.Size(834, 27)
        Me.CancionesBindingNavigator.TabIndex = 0
        Me.CancionesBindingNavigator.Text = "BindingNavigator1"
        Me.CancionesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'CancionesBindingSource
        '
        Me.CancionesBindingSource.DataMember = "Canciones"
        Me.CancionesBindingSource.DataSource = Me.MusicaDBDataSet
        '
        'MusicaDBDataSet
        '
        Me.MusicaDBDataSet.DataSetName = "MusicaDBDataSet"
        Me.MusicaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CancionesBindingNavigatorSaveItem
        '
        Me.CancionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancionesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CancionesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CancionesBindingNavigatorSaveItem.Name = "CancionesBindingNavigatorSaveItem"
        Me.CancionesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.CancionesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Codigo_CancionTextBox
        '
        Me.Codigo_CancionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Codigo_Cancion", True))
        Me.Codigo_CancionTextBox.Location = New System.Drawing.Point(171, 42)
        Me.Codigo_CancionTextBox.Name = "Codigo_CancionTextBox"
        Me.Codigo_CancionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Codigo_CancionTextBox.TabIndex = 3
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Titulo", True))
        Me.TituloTextBox.Location = New System.Drawing.Point(171, 94)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TituloTextBox.TabIndex = 5
        '
        'DuracionTextBox
        '
        Me.DuracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CancionesBindingSource, "Duracion", True))
        Me.DuracionTextBox.Location = New System.Drawing.Point(171, 147)
        Me.DuracionTextBox.Name = "DuracionTextBox"
        Me.DuracionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.DuracionTextBox.TabIndex = 7
        '
        'Btninsert
        '
        Me.Btninsert.BackColor = System.Drawing.Color.Thistle
        Me.Btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btninsert.Location = New System.Drawing.Point(539, 332)
        Me.Btninsert.Name = "Btninsert"
        Me.Btninsert.Size = New System.Drawing.Size(134, 41)
        Me.Btninsert.TabIndex = 8
        Me.Btninsert.Text = "Insertar"
        Me.Btninsert.UseVisualStyleBackColor = False
        '
        'Btnedit
        '
        Me.Btnedit.BackColor = System.Drawing.Color.Thistle
        Me.Btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnedit.Location = New System.Drawing.Point(679, 333)
        Me.Btnedit.Name = "Btnedit"
        Me.Btnedit.Size = New System.Drawing.Size(130, 41)
        Me.Btnedit.TabIndex = 9
        Me.Btnedit.Text = "Editar"
        Me.Btnedit.UseVisualStyleBackColor = False
        '
        'Btnborrar
        '
        Me.Btnborrar.BackColor = System.Drawing.Color.Thistle
        Me.Btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnborrar.Location = New System.Drawing.Point(815, 333)
        Me.Btnborrar.Name = "Btnborrar"
        Me.Btnborrar.Size = New System.Drawing.Size(121, 41)
        Me.Btnborrar.TabIndex = 10
        Me.Btnborrar.Text = "Borrar"
        Me.Btnborrar.UseVisualStyleBackColor = False
        '
        'Btnsalir
        '
        Me.Btnsalir.BackColor = System.Drawing.Color.Thistle
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.Location = New System.Drawing.Point(31, 333)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(95, 41)
        Me.Btnsalir.TabIndex = 11
        Me.Btnsalir.Text = "Salir"
        Me.Btnsalir.UseVisualStyleBackColor = False
        '
        'Btnbusc
        '
        Me.Btnbusc.BackColor = System.Drawing.Color.Thistle
        Me.Btnbusc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbusc.Location = New System.Drawing.Point(347, 79)
        Me.Btnbusc.Name = "Btnbusc"
        Me.Btnbusc.Size = New System.Drawing.Size(120, 35)
        Me.Btnbusc.TabIndex = 12
        Me.Btnbusc.Text = "Buscar"
        Me.Btnbusc.UseVisualStyleBackColor = False
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.BackColor = System.Drawing.Color.Thistle
        Me.Btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlimpiar.Location = New System.Drawing.Point(143, 223)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(141, 35)
        Me.Btnlimpiar.TabIndex = 13
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = False
        '
        'CancionesDataGridView
        '
        Me.CancionesDataGridView.AutoGenerateColumns = False
        Me.CancionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CancionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CancionesDataGridView.DataSource = Me.CancionesBindingSource
        Me.CancionesDataGridView.Location = New System.Drawing.Point(565, 44)
        Me.CancionesDataGridView.Name = "CancionesDataGridView"
        Me.CancionesDataGridView.RowTemplate.Height = 24
        Me.CancionesDataGridView.Size = New System.Drawing.Size(336, 220)
        Me.CancionesDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Cancion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo_Cancion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Titulo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Duracion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Duracion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CancionesTableAdapter
        '
        Me.CancionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CancionesTableAdapter = Me.CancionesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Parcial_POO.MusicaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(978, 433)
        Me.Controls.Add(Me.CancionesDataGridView)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.Btnbusc)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btnborrar)
        Me.Controls.Add(Me.Btnedit)
        Me.Controls.Add(Me.Btninsert)
        Me.Controls.Add(Codigo_CancionLabel)
        Me.Controls.Add(Me.Codigo_CancionTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(DuracionLabel)
        Me.Controls.Add(Me.DuracionTextBox)
        Me.Controls.Add(Me.CancionesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Musica"
        CType(Me.CancionesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CancionesBindingNavigator.ResumeLayout(False)
        Me.CancionesBindingNavigator.PerformLayout()
        CType(Me.CancionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MusicaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MusicaDBDataSet As Parcial_POO.MusicaDBDataSet
    Friend WithEvents CancionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CancionesTableAdapter As Parcial_POO.MusicaDBDataSetTableAdapters.CancionesTableAdapter
    Friend WithEvents TableAdapterManager As Parcial_POO.MusicaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CancionesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CancionesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Codigo_CancionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TituloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DuracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btninsert As System.Windows.Forms.Button
    Friend WithEvents Btnedit As System.Windows.Forms.Button
    Friend WithEvents Btnborrar As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents Btnbusc As System.Windows.Forms.Button
    Friend WithEvents Btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents CancionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
