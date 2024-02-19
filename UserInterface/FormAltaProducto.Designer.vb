<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaProducto
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.lblPrecioProducto = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(65, 197)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(228, 197)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = True
        Me.lblNombreProducto.Location = New System.Drawing.Point(75, 48)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblNombreProducto.TabIndex = 2
        Me.lblNombreProducto.Text = "Producto:"
        '
        'lblPrecioProducto
        '
        Me.lblPrecioProducto.AutoSize = True
        Me.lblPrecioProducto.Location = New System.Drawing.Point(88, 97)
        Me.lblPrecioProducto.Name = "lblPrecioProducto"
        Me.lblPrecioProducto.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecioProducto.TabIndex = 3
        Me.lblPrecioProducto.Text = "Precio:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(75, 145)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(55, 13)
        Me.lblCategoria.TabIndex = 4
        Me.lblCategoria.Text = "Categoria:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(203, 41)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(203, 90)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(203, 138)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoria.TabIndex = 7
        '
        'frmAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 274)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblPrecioProducto)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmAltaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblPrecioProducto As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
End Class
