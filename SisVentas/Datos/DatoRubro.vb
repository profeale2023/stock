
Imports System.Data
Imports Logica
Imports MySql.Data.MySqlClient


Public Class DatoRubro
    Inherits Conexion
    Dim cmd As New MySqlCommand

    Public Function mostrar() As DataTable
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM RUBRO ORDER BY IdRubro DESC"
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

    Public Function insertar(ByVal dts As LogicaRubro) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into RUBRO (descripcion) values ('" + dts._descripcion + "')"
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

    Public Function modificar(ByVal dts As LogicaRubro) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE RUBRO SET descripcion='" + dts._descripcion + "' WHERE IdRubro=" & dts._idrubro
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


    Public Function eliminar(ByVal dts As LogicaRubro) As Boolean
        Try
            Conectado()
            cmd = New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM RUBRO WHERE IdRubro=" & dts._idrubro
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
