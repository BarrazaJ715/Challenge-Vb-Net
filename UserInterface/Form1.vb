Imports BussinessLogicLayer

Public Class TacticaSoft
    Private Property listaProductos As List(Of Productos)
    Private Property listaClientes As List(Of Clientes)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarDgv()
    End Sub

    Private Sub refrescarDgv()

        Try

            Dim aux As New ServicioCliente()
            listaClientes = aux.listaCliente()
            dgvClientes.DataSource = listaClientes

            Dim aux2 As New ServicioProductos()
            listaProductos = aux2.ListaProductos
            dgvProductos.DataSource = listaProductos
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim alta As New frmAltaProducto()
        alta.ShowDialog()
        refrescarDgv()

    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim alta As New FormAltaCliente()
        alta.ShowDialog()
        refrescarDgv()
    End Sub

    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        Dim seleccionado As Productos
        seleccionado = DirectCast(dgvProductos.CurrentRow.DataBoundItem, Productos)
        Dim modificar As New frmAltaProducto(seleccionado)

        modificar.ShowDialog()
        refrescarDgv()
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Dim seleccionado As Clientes
        seleccionado = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Clientes)
        Dim modificar As New FormAltaCliente(seleccionado)

        modificar.ShowDialog()
        refrescarDgv()
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click


        Dim eliminado As New ServicioCliente
        Dim seleccionado As Clientes
        seleccionado = DirectCast(dgvClientes.CurrentRow.DataBoundItem, Clientes)

        Try
            Dim resultado As DialogResult = MessageBox.Show("Está por eliminar un registro. ¿Está de acuerdo?", "Confirmación", MessageBoxButtons.OKCancel)
            If resultado = DialogResult.OK Then

                eliminado.eliminarCliente(seleccionado.Id)
                refrescarDgv()
            Else
                Return
            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click

        Dim eliminado As New ServicioProductos
        Dim seleccionado As Productos
        seleccionado = DirectCast(dgvProductos.CurrentRow.DataBoundItem, Productos)

        Try
            Dim resultado As DialogResult = MessageBox.Show("Está por eliminar un registro. ¿Está de acuerdo?", "Confirmación", MessageBoxButtons.OKCancel)
            If resultado = DialogResult.OK Then

                eliminado.eliminarProductos(seleccionado.Id)
                refrescarDgv()
            Else
                Return
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroProductos.TextChanged

        Dim listaFiltrada As New List(Of Productos)()
        Dim Filtro As String = txtFiltroProductos.Text

        If Filtro.Length >= 2 Then
            listaFiltrada = listaProductos.FindAll(Function(variableFiltrada) variableFiltrada.Nombre.ToUpper().Contains(Filtro.ToUpper()))

            cargarListaProducto(listaFiltrada)

        Else

            refrescarDgv()
        End If
    End Sub

    Private Sub cargarListaProducto(listaFiltrada)
        dgvProductos.DataSource = Nothing
        dgvProductos.DataSource = listaFiltrada
    End Sub

    Private Sub cargarListaClientes(listaFiltrada)
        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = listaFiltrada
    End Sub

    Private Sub txtFiltroClientes_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroClientes.TextChanged

        Dim listaFiltrada As New List(Of Clientes)()
        Dim Filtro As String = txtFiltroClientes.Text

        If Filtro.Length >= 2 Then
            listaFiltrada = listaClientes.FindAll(Function(variableFiltrada) variableFiltrada.Cliente.ToUpper().Contains(Filtro.ToUpper()))

            cargarListaClientes(listaFiltrada)

        Else

            refrescarDgv()
        End If
    End Sub
End Class
