
Imports System.Configuration
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Conexion
    Protected cnn As New MySqlConnection
    Public idusuario As Integer

    Function Conectado()
        Try
            Dim oParametros As New Datos.Parametros()
            oParametros.Conexion = ConfigurationManager.AppSettings("StringConexion")
            cnn = New MySqlConnection(oParametros.Conexion)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
