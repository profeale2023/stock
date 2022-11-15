
Imports System.Data
Imports Logica
Imports MySql.Data.MySqlClient

Public Class DatoProveedor
    Inherits Conexion
    Dim cmd As New MySqlCommand

    Public Function mostrar() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM PROVEEDOR ORDER BY IdProveedor DESC"
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

    Public Function insertar(ByVal dts As LogicaProveedor) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into proveedor (nombre) values ('" + dts._nombre + "')"
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

    Public Function modificar(ByVal dts As LogicaProveedor) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE PROVEEDOR SET nombre='" + dts._nombre + "' WHERE IdProveedor=" & dts._idproveedor
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


    Public Function eliminar(ByVal dts As LogicaProveedor) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM PROVEEDOR WHERE IdProveedor=" & dts._idproveedor
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
