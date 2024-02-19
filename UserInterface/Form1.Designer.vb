<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TacticaSoft
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.lblParaProducto = New System.Windows.Forms.Label()
        Me.lblParaClientes = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.lblTituloClientes = New System.Windows.Forms.Label()
        Me.lblTituloProductos = New System.Windows.Forms.Label()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.txtFiltroProductos = New System.Windows.Forms.TextBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.lblFiltroClientes = New System.Windows.Forms.Label()
        Me.txtFiltroClientes = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(133, 252)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(441, 274)
        Me.dgvClientes.TabIndex = 0
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(799, 176)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarProducto.TabIndex = 1
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Location = New System.Drawing.Point(907, 176)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarProducto.TabIndex = 2
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.Location = New System.Drawing.Point(668, 252)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(442, 274)
        Me.dgvProductos.TabIndex = 3
        '
        'lblParaProducto
        '
        Me.lblParaProducto.AutoSize = True
        Me.lblParaProducto.Location = New System.Drawing.Point(699, 181)
        Me.lblParaProducto.Name = "lblParaProducto"
        Me.lblParaProducto.Size = New System.Drawing.Size(78, 13)
        Me.lblParaProducto.TabIndex = 4
        Me.lblParaProducto.Text = "PRODUCTOS:"
        '
        'lblParaClientes
        '
        Me.lblParaClientes.AutoSize = True
        Me.lblParaClientes.Location = New System.Drawing.Point(170, 181)
        Me.lblParaClientes.Name = "lblParaClientes"
        Me.lblParaClientes.Size = New System.Drawing.Size(62, 13)
        Me.lblParaClientes.TabIndex = 5
        Me.lblParaClientes.Text = "CLIENTES:"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(250, 176)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCliente.TabIndex = 6
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(360, 176)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarCliente.TabIndex = 7
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'lblTituloClientes
        '
        Me.lblTituloClientes.AutoSize = True
        Me.lblTituloClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloClientes.Location = New System.Drawing.Point(287, 218)
        Me.lblTituloClientes.Name = "lblTituloClientes"
        Me.lblTituloClientes.Size = New System.Drawing.Size(148, 31)
        Me.lblTituloClientes.TabIndex = 8
        Me.lblTituloClientes.Text = "CLIENTES"
        '
        'lblTituloProductos
        '
        Me.lblTituloProductos.AutoSize = True
        Me.lblTituloProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloProductos.Location = New System.Drawing.Point(803, 218)
        Me.lblTituloProductos.Name = "lblTituloProductos"
        Me.lblTituloProductos.Size = New System.Drawing.Size(189, 31)
        Me.lblTituloProductos.TabIndex = 9
        Me.lblTituloProductos.Text = "PRODUCTOS"
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Location = New System.Drawing.Point(1011, 176)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarProducto.TabIndex = 10
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(468, 176)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarCliente.TabIndex = 11
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'txtFiltroProductos
        '
        Me.txtFiltroProductos.Location = New System.Drawing.Point(799, 114)
        Me.txtFiltroProductos.Name = "txtFiltroProductos"
        Me.txtFiltroProductos.Size = New System.Drawing.Size(236, 20)
        Me.txtFiltroProductos.TabIndex = 12
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(665, 115)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(103, 16)
        Me.lblFiltro.TabIndex = 14
        Me.lblFiltro.Text = "Filtro productos:"
        '
        'lblFiltroClientes
        '
        Me.lblFiltroClientes.AutoSize = True
        Me.lblFiltroClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltroClientes.Location = New System.Drawing.Point(170, 114)
        Me.lblFiltroClientes.Name = "lblFiltroClientes"
        Me.lblFiltroClientes.Size = New System.Drawing.Size(89, 16)
        Me.lblFiltroClientes.TabIndex = 16
        Me.lblFiltroClientes.Text = "Filtro clientes:"
        '
        'txtFiltroClientes
        '
        Me.txtFiltroClientes.Location = New System.Drawing.Point(304, 113)
        Me.txtFiltroClientes.Name = "txtFiltroClientes"
        Me.txtFiltroClientes.Size = New System.Drawing.Size(236, 20)
        Me.txtFiltroClientes.TabIndex = 15
        '
        'TacticaSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 599)
        Me.Controls.Add(Me.lblFiltroClientes)
        Me.Controls.Add(Me.txtFiltroClientes)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtFiltroProductos)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.lblTituloProductos)
        Me.Controls.Add(Me.lblTituloClientes)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.lblParaClientes)
        Me.Controls.Add(Me.lblParaProducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnModificarProducto)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "TacticaSoft"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tactica Soft"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnModificarProducto As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblParaProducto As Label
    Friend WithEvents lblParaClientes As Label
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents lblTituloClientes As Label
    Friend WithEvents lblTituloProductos As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents txtFiltroProductos As TextBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents lblFiltroClientes As Label
    Friend WithEvents txtFiltroClientes As TextBox
End Class
