Public Class LogicaRubro
    Private idrubro As Integer
    Private descripcion As String


    Public Property _idrubro
        Get
            Return idrubro
        End Get
        Set(value)
            idrubro = value
        End Set
    End Property
    Public Property _descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property



    Public Sub New()

    End Sub


    Public Sub New(ByVal idrubro As Integer)
        idrubro = idrubro

    End Sub
    Public Sub New(ByVal descripcion As String)
        _descripcion = descripcion

    End Sub
End Class
