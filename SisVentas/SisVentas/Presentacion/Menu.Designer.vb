<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnRubros = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menú del Sistema "
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(77, 104)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(180, 39)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Location = New System.Drawing.Point(78, 154)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(175, 41)
        Me.BtnProveedores.TabIndex = 2
        Me.BtnProveedores.Text = "Proveedores"
        Me.BtnProveedores.UseVisualStyleBackColor = True
        '
        'BtnRubros
        '
        Me.BtnRubros.Location = New System.Drawing.Point(77, 211)
        Me.BtnRubros.Name = "BtnRubros"
        Me.BtnRubros.Size = New System.Drawing.Size(176, 39)
        Me.BtnRubros.TabIndex = 3
        Me.BtnRubros.Text = "Rubros"
        Me.BtnRubros.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(78, 266)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(176, 37)
        Me.BtnFinalizar.TabIndex = 4
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(324, 361)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.BtnRubros)
        Me.Controls.Add(Me.BtnProveedores)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents BtnRubros As Button
    Friend WithEvents BtnFinalizar As Button
End Class
