Imports BussinessLogicLayer

Public Class frmAltaProducto

    Private Prod As New Productos
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(modificar As Productos)
        InitializeComponent()
        Me.Prod = modificar
        Text = "Modificar Producto"
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim nuevoProducto As New ServicioProductos()
        Try
            Dim esCreacion As Boolean = Prod.Id = 0
            If esCreacion Then
                Prod = New Productos()
                SetProducto()
                nuevoProducto.agregarProducto(Prod)
                MessageBox.Show("Agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                SetProducto()
                nuevoProducto.modificarProducto(Prod)
                MessageBox.Show("Modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try



    End Sub

    Private Sub SetProducto()
        Prod.Nombre = txtProducto.Text
        Prod.Precio = Integer.Parse(txtPrecio.Text)
        Prod.Categoria = Integer.Parse(txtCategoria.Text)
    End Sub

    Private Sub frmAltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Prod IsNot Nothing Then
            txtProducto.Text = Prod.Nombre
            txtPrecio.Text = Prod.Precio.ToString()
            txtCategoria.Text = Prod.Categoria.ToString()
        End If


    End Sub
End Class