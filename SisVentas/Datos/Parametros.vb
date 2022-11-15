Public Class Parametros
    Private sConexion As String

    Public Property Conexion() As String
        Get
            Return sConexion
        End Get
        Set(value As String)
            sConexion = value
        End Set
    End Property
End Class
