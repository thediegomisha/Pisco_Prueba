Public Class vtitulo
    Dim _idtitulo As Integer
    Dim _nombre As String
    Dim _descripcion As String

    Public Property gidtitulo
        Get
            Return _idtitulo
        End Get
        Set(ByVal value)
            _idtitulo = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return _nombre
        End Get
        Set(ByVal value)
            _nombre = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return _descripcion
        End Get
        Set(ByVal value)
            _descripcion = value
        End Set
    End Property

    'CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(ByVal _idtitulo As Integer, ByVal _nombre As String, ByVal _descripcion As String)
        gidtitulo = _idtitulo
        gnombre = _nombre
        gdescripcion = _descripcion
    End Sub
End Class
