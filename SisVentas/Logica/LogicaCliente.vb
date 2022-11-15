Public Class LogicaCliente
    Private idcliente As Integer
    Private cliente, telefono, correo As String


    Public Property _idcliente
        Get
            Return idcliente
        End Get
        Set(value)
            idcliente = value
        End Set
    End Property
    Public Property _cliente
        Get
            Return cliente
        End Get
        Set(value)
            cliente = value
        End Set
    End Property

    Public Property _telefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property _correo
        Get
            Return correo
        End Get
        Set(value)
            correo = value
        End Set
    End Property


    Public Sub New()

    End Sub


    Public Sub New(ByVal idcliente As Integer)
        idcliente = idcliente

    End Sub
    Public Sub New(ByVal cliente As String, ByVal telefono As String, ByVal correo As String)
        _cliente = cliente
        _telefono = telefono
        _correo = correo
    End Sub

End Class
