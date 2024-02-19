<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaCliente
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
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.btnAceptarCliente = New System.Windows.Forms.Button()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(203, 45)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCliente.TabIndex = 0
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(203, 93)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(203, 139)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 2
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(80, 48)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreCliente.TabIndex = 3
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(80, 100)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 4
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(80, 146)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 5
        Me.lblCorreo.Text = "Correo:"
        '
        'btnAceptarCliente
        '
        Me.btnAceptarCliente.Location = New System.Drawing.Point(63, 202)
        Me.btnAceptarCliente.Name = "btnAceptarCliente"
        Me.btnAceptarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarCliente.TabIndex = 6
        Me.btnAceptarCliente.Text = "Aceptar"
        Me.btnAceptarCliente.UseVisualStyleBackColor = True
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Location = New System.Drawing.Point(218, 202)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarCliente.TabIndex = 7
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'FormAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 275)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.btnAceptarCliente)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Name = "FormAltaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents btnAceptarCliente As Button
    Friend WithEvents btnCancelarCliente As Button
End Class
