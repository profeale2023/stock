Imports System.Data
Imports Logica
Imports MySql.Data.MySqlClient
Public Class DatoCliente
    Inherits Conexion
    Dim cmd As New MySqlCommand

    Public Function mostrar() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM CLIENTE ORDER BY IdCliente DESC"
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As LogicaCliente) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into cliente (cliente,telefono,correo) values ('" + dts._cliente + "','" + dts._telefono + "','" + dts._correo + "')"
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function

    Public Function modificar(ByVal dts As LogicaCliente) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE CLIENTE SET cliente='" + dts._cliente + "',telefono='" + dts._telefono + "',correo='" + dts._correo + "' WHERE IdCliente=" & dts._idcliente
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function


    Public Function eliminar(ByVal dts As LogicaCliente) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM CLIENTE WHERE IdCliente=" & dts._idcliente
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function




End Class


