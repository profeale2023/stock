Public Class LogicaProveedor
    Private idproveedor As Integer
    Private nombre As String


    Public Property _idproveedor
        Get
            Return idproveedor
        End Get
        Set(value)
            idproveedor = value
        End Set
    End Property
    Public Property _nombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property



    Public Sub New()

    End Sub


    Public Sub New(ByVal idproveedor As Integer)
        idproveedor = idproveedor

    End Sub
    Public Sub New(ByVal cliente As String, ByVal telefono As String, ByVal correo As String)
        _nombre = nombre

    End Sub

End Class
