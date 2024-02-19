Imports BussinessLogicLayer
Imports DataAccessLayer

Public Class ServicioProductos

    Public Function ListaProductos() As List(Of Productos)

        Dim listaP As New List(Of Productos)()
        Dim datos As New AccesoDatos()
        Try
            datos.setearConsulta("select Id, Nombre, Precio, Categoria from productos")
            datos.ejecutarLectura()

            While datos.Lector.Read()
                Dim aux2 As New Productos()
                aux2.Id = CInt(datos.Lector("Id"))
                aux2.Nombre = CStr(datos.Lector("Nombre"))
                aux2.Precio = CInt(datos.Lector("Precio"))
                aux2.Categoria = CInt(datos.Lector("Categoria"))
                listaP.Add(aux2)

            End While
            Return listaP
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function agregarProducto(nuevoProducto As Productos)

        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("Insert into productos (Nombre, Precio, Categoria) values ('" & nuevoProducto.Nombre & "', " & nuevoProducto.Precio & ", " & nuevoProducto.Categoria & ")")
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Function modificarProducto(nuevoProducto As Productos)

        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("update productos set Nombre= '" & nuevoProducto.Nombre & "', Precio= " & nuevoProducto.Precio & ", Categoria= " & nuevoProducto.Categoria & " where id = '" & nuevoProducto.Id & "'")
            datos.ejecutarAccion()
        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Function

    Public Sub eliminarProductos(delId As Integer)
        Dim datos As New AccesoDatos()

        Try
            datos.setearConsulta("delete from productos where id='" & delId & "'")
            datos.ejecutarAccion()

        Catch ex As Exception
            Throw ex
        Finally
            datos.cerrarConexion()
        End Try
    End Sub
End Class
