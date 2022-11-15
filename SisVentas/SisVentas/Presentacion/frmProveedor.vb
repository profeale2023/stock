Imports Datos
Imports Logica

Public Class frmProveedor
    Private dt As New DataTable
    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funcion As New DatoProveedor
            dt = funcion.mostrar
            DataGridView1.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then

                Me.DataGridView1.DataSource = dt
                DataGridView1.ColumnHeadersVisible = True

            Else
                DataGridView1.DataSource = Nothing
                DataGridView1.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnNuevo.Visible = True
    End Sub


    Public Sub LimpiarDatos()
        Me.BtnGuardar.Visible = True
        Me.BtnEditar.Visible = False
        Me.TxTNombre.Text = ""
        Me.TxtIdProveedor.Text = ""

    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As EventArgs) Handles TxTNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un dato, no puede estar vacio")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        Me.BtnGuardar.Visible = False
        Me.BtnEditar.Visible = True
        TxtIdProveedor.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        TxTNombre.Text = DataGridView1.Rows(FilaActual).Cells(2).Value

    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And Me.TxTNombre.Text <> "" Then
            Try
                Dim dts As New LogicaProveedor
                Dim frmCliente As New DatoProveedor

                dts._nombre = Me.TxTNombre.Text

                If frmCliente.insertar(dts) Then
                    MessageBox.Show("Proveedor Registrado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Proveedor NO Registrado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan Datos", "Guardando Datos ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim dts As New LogicaProveedor
            Dim frmCliente As New DatoProveedor
            Dim respuesta As New DialogResult
            dts._idproveedor = Me.TxtIdProveedor.Text
            dts._nombre = Me.TxTNombre.Text


            respuesta = MessageBox.Show("Desea modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (respuesta = DialogResult.Yes) Then
                If frmCliente.modificar(dts) Then
                    MessageBox.Show("Proveedor Modificado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Proveedor NO Modificado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim dts As New LogicaProveedor
            Dim frmProveedor As New DatoProveedor
            Dim respuesta As New DialogResult
            dts._idproveedor = Me.TxtIdProveedor.Text


            respuesta = MessageBox.Show("Desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (respuesta = DialogResult.Yes) Then
                If frmProveedor.Eliminar(dts) Then
                    MessageBox.Show("Proveedor Eliminado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Proveedor NO Eliminado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarDatos()
        Mostrar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnIR_Click(sender As Object, e As EventArgs) Handles BtnIR.Click
        Menu.Show()
        Me.Hide()

    End Sub

    Private Sub BtnNombre_Click(sender As Object, e As EventArgs) Handles BtnNombre.Click

    End Sub
End Class