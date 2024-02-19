Imports DataAccessLayer

Public Class ServicioCliente
    Public Function listaCliente() As List(Of Clientes)
        Dim listaS As New List(Of Clientes)()
        Dim datos As New AccesoDatos()
        Try
            datos.setearConsulta("select Id, Cliente, Telefono, Correo from clientes")
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim aux As New Clientes()
                aux.Id = CInt(datos.Lector("Id"))
                aux.Cliente = CStr(datos.Lector("Cliente"))
                aux.Telefono = CStr(datos.Lector("Telefono"))
                aux.Correo = CStr(datos.Lector("Correo"))
                listaS.Add(aux)

            End While
            Return listaS
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function
    Public Function agregarCliente(nuevoCliente As Clientes)

        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("Insert into clientes (Cliente, Telefono, Correo) values ('" & nuevoCliente.Cliente & "', '" & nuevoCliente.Telefono & "', '" & nuevoCliente.Correo & "')")
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function
    Public Function modificarClientes(nuevoCliente As Clientes)

        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("update clientes set Cliente='" & nuevoCliente.Cliente & "', Telefono='" & nuevoCliente.Telefono & "', Correo='" & nuevoCliente.Correo & "' where id ='" & nuevoCliente.Id & "'")
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function eliminarCliente(delId As Integer)

        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("delete from clientes where id='" & delId & "'")
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

End Class



