Imports BussinessLogicLayer

Public Class FormAltaCliente
    Private Cli As New Clientes()

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(modificar As Clientes)
        InitializeComponent()
        Me.Cli = modificar
        Text = "Modificar Cliente"
    End Sub
    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        Me.Close()
    End Sub

    Private Sub btnAceptarCliente_Click(sender As Object, e As EventArgs) Handles btnAceptarCliente.Click


        Dim nuevoClientes As New ServicioCliente()

        Try
            Dim esCreacion As Boolean = Cli.Id = 0
            If esCreacion Then

                Cli = New Clientes()

                SetClient()
                nuevoClientes.agregarCliente(Cli)
                MessageBox.Show("Agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                SetClient()

                nuevoClientes.modificarClientes(Cli)
                MessageBox.Show("Modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub SetClient()
        Cli.Cliente = txtNombreCliente.Text
        Cli.Telefono = txtTelefono.Text
        Cli.Correo = txtCorreo.Text

    End Sub

    Private Sub FormAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Cli IsNot Nothing Then
            txtNombreCliente.Text = Cli.Cliente
            txtTelefono.Text = Cli.Telefono
            txtCorreo.Text = Cli.Correo
        End If
    End Sub
End Class