Public Class Menu
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        frmCliente.Show()
        Me.Hide()
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        frmProveedor.Show()
        Me.Hide()

    End Sub

    Private Sub BtnRubros_Click(sender As Object, e As EventArgs) Handles BtnRubros.Click
        frmRubro.Show()
        Me.Hide()
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        End
    End Sub
End Class