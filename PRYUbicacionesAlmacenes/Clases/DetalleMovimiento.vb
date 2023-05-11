Public Class DetalleMovimiento

    Private _f301_Lote As String
    Public Property f301_Lote() As String
        Get
            Return _f301_Lote
        End Get
        Set(ByVal value As String)
            _f301_Lote = value
        End Set
    End Property

    Private _f106_Descripcion As String
    Public Property f106_Descripcion() As String
        Get
            Return _f106_Descripcion
        End Get
        Set(ByVal value As String)
            _f106_Descripcion = value
        End Set
    End Property


    Private _f301_RowID As Decimal
    Public Property f301_RowID() As Decimal
        Get
            Return _f301_RowID
        End Get

        Set(ByVal value As Decimal)
            _f301_RowID = value
        End Set
    End Property

    Private _f301_RowIDDocumento As Decimal
    Public Property f301_RowIDDocumento() As Decimal
        Get
            Return _f301_RowIDDocumento
        End Get

        Set(ByVal value As Decimal)
            _f301_RowIDDocumento = value
        End Set
    End Property

    Private _f301_Referencia As String
    Public Property f301_Referencia() As String
        Get
            Return _f301_Referencia
        End Get

        Set(ByVal value As String)
            _f301_Referencia = value
        End Set
    End Property

    Private _f301_SerialMaterial As String
    Public Property f301_SerialMaterial() As String
        Get
            Return _f301_SerialMaterial
        End Get

        Set(ByVal value As String)
            _f301_SerialMaterial = value
        End Set
    End Property


    Private _f301_UbicacionLeida As String
    Public Property f301_UbicacionLeida() As String
        Get
            Return _f301_UbicacionLeida
        End Get

        Set(ByVal value As String)
            _f301_UbicacionLeida = value
        End Set
    End Property

    Private _f301_Cantidad As Decimal
    Public Property f301_Cantidad() As Decimal
        Get
            Return _f301_Cantidad
        End Get

        Set(ByVal value As Decimal)
            _f301_Cantidad = value
        End Set
    End Property

    Private _f301_UbicacionOrigen As String
    Public Property f301_UbicacionOrigen() As String
        Get
            Return _f301_UbicacionOrigen
        End Get

        Set(ByVal value As String)
            _f301_UbicacionOrigen = value
        End Set
    End Property

    Private _f301_UbicacionDestino As String
    Public Property f301_UbicacionDestino() As String
        Get
            Return _f301_UbicacionDestino
        End Get

        Set(ByVal value As String)
            _f301_UbicacionDestino = value
        End Set
    End Property

    Private _f301_EstadoMov As String
    Public Property f301_EstadoMov() As String
        Get
            Return _f301_EstadoMov
        End Get

        Set(ByVal value As String)
            _f301_EstadoMov = value
        End Set
    End Property

    Private _f301_FechaHoraMov As DateTime
    Public Property f301_FechaHoraMov() As DateTime
        Get
            Return _f301_FechaHoraMov
        End Get

        Set(ByVal value As DateTime)
            _f301_FechaHoraMov = value
        End Set
    End Property

    Private _f301_UsuarioMov As String
    Public Property f301_UsuarioMov() As String
        Get
            Return _f301_UsuarioMov
        End Get

        Set(ByVal value As String)
            _f301_UsuarioMov = value
        End Set
    End Property

    Private _f301_FechaHoraElim As DateTime
    Public Property f301_FechaHoraElim() As DateTime
        Get
            Return _f301_FechaHoraElim
        End Get

        Set(ByVal value As DateTime)
            _f301_FechaHoraElim = value
        End Set
    End Property

    Private _f301_UsuarioElim As String
    Public Property f301_UsuarioElim() As String
        Get
            Return _f301_UsuarioElim
        End Get

        Set(ByVal value As String)
            _f301_UsuarioElim = value
        End Set
    End Property
End Class
