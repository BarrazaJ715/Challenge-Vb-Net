Imports System.Data.SqlClient
Imports System.Configuration
Public Class AccesoDatos
    Private conexion As SqlConnection
    Private comando As SqlCommand
    Private _lector As SqlDataReader

    Public ReadOnly Property Lector() As SqlDataReader
        Get
            Return _lector
        End Get
    End Property

    Public Sub New()
        Dim DBConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
        conexion = DBConnection
        comando = New SqlCommand()
    End Sub

    Public Sub setearConsulta(ByVal consulta As String)
        comando.CommandType = System.Data.CommandType.Text
        comando.CommandText = consulta
    End Sub

    Public Sub ejecutarLectura()
        comando.Connection = conexion
        Try
            conexion.Open()
            _lector = comando.ExecuteReader()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ejecutarAccion()
        comando.Connection = conexion
        Try
            conexion.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub cerrarConexion()
        If _lector IsNot Nothing Then
            _lector.Close()
        End If
        conexion.Close()
    End Sub

End Class
