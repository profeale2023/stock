Imports Datos
Imports Logica

Public Class frmCliente
    Private dt As New DataTable
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub Mostrar()
        Try
            Dim funcion As New DatoCliente
            dt = funcion.mostrar
            DataGridView1.Columns.Item("Eliminar").Visible = False
            If dt.Rows.Count <> 0 Then


                Me.DataGridView1.DataSource = dt
                'TxtBuscar.Enabled = True
                DataGridView1.ColumnHeadersVisible = True
                'LnkInexistente.visible = False
            Else
                DataGridView1.DataSource = Nothing
                'TxtBuscar.Enabled = False
                DataGridView1.ColumnHeadersVisible = False
                'LnkInexistente.visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BtnNuevo.Visible = True
        'BtnEditar.Visible = False
    End Sub


    Public Sub LimpiarDatos()
        Me.BtnGuardar.Visible = True
        Me.BtnEditar.Visible = False
        Me.TxtCliente.Text = ""
        Me.TxtCorreo.Text = ""
        Me.TxtTelefono.Text = ""

    End Sub

    Private Sub TxtCliente_Validating(sender As Object, e As EventArgs) Handles TxtCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un dato, no puede estar vacio")
        End If
    End Sub

    Private Sub TxtTelefono_Validating(sender As Object, e As EventArgs) Handles TxtTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un dato, no puede estar vacio")
        End If
    End Sub

    Private Sub TxtCorreo_Validating(sender As Object, e As EventArgs) Handles TxtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese un dato, no puede estar vacio")
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And Me.TxtCliente.Text <> "" And Me.TxtTelefono.Text <> "" And Me.TxtCorreo.Text <> "" Then
            Try
                Dim dts As New LogicaCliente
                Dim frmCliente As New DatoCliente

                dts._cliente = Me.TxtCliente.Text
                dts._telefono = Me.TxtTelefono.Text
                dts._correo = Me.TxtCorreo.Text
                If frmCliente.insertar(dts) Then
                    MessageBox.Show("Cliente Registrado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Cliente NO Registrado", "Guardando Datos ", MessageBoxButtons.OK)
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
            Dim dts As New LogicaCliente
            Dim frmCliente As New DatoCliente
            Dim respuesta As New DialogResult
            dts._idcliente = Me.TxtIdCliente.Text
            dts._cliente = Me.TxtCliente.Text
            dts._telefono = Me.TxtTelefono.Text
            dts._correo = Me.TxtCorreo.Text

            respuesta = MessageBox.Show("Desea modificar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (respuesta = DialogResult.Yes) Then
                If frmCliente.modificar(dts) Then
                    MessageBox.Show("Cliente Modificado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Cliente NO Modificado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim FilaActual As Integer
        FilaActual = DataGridView1.CurrentRow.Index
        Me.BtnGuardar.Visible = False
        Me.BtnEditar.Visible = True
        TxtIdCliente.Text = DataGridView1.Rows(FilaActual).Cells(1).Value
        TxtCliente.Text = DataGridView1.Rows(FilaActual).Cells(2).Value
        TxtTelefono.Text = DataGridView1.Rows(FilaActual).Cells(3).Value
        TxtCorreo.Text = DataGridView1.Rows(FilaActual).Cells(4).Value
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim dts As New LogicaCliente
            Dim frmCliente As New DatoCliente
            Dim respuesta As New DialogResult
            dts._idcliente = Me.TxtIdCliente.Text


            respuesta = MessageBox.Show("Desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (respuesta = DialogResult.Yes) Then
                If frmCliente.eliminar(dts) Then
                    MessageBox.Show("Cliente Eliminado", "Guardando Datos ", MessageBoxButtons.OK)
                    Mostrar()
                    LimpiarDatos()
                Else
                    MessageBox.Show("Cliente NO Eliminado", "Guardando Datos ", MessageBoxButtons.OK)
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

    Private Sub BtnIR_Click(sender As Object, e As EventArgs) Handles BtnIR.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        End
    End Sub

    Private Sub BtnRubros_Click(sender As Object, e As EventArgs)
        frmRubro.Show()
    End Sub
End Class