Public Class AlmacenUbicaciones

    Private COAlmacen As String
    Private almacenUbic As String
    Private descAlmacen As String
    Private EstadoAlmacen As String
    Private Ubicacion As String
    Private DescUbicacion As String
    Private EstadoUbicacion As String


    Public Property _COAlmacen() As String
        Get
            Return COAlmacen
        End Get
        Set(ByVal value As String)
            COAlmacen = value
        End Set
    End Property
    Public Property _almacenUbic() As String
        Get
            Return almacenUbic
        End Get
        Set(ByVal value As String)
            almacenUbic = value
        End Set
    End Property
    Public Property _descAlmacen() As String
        Get
            Return descAlmacen
        End Get
        Set(ByVal value As String)
            descAlmacen = value
        End Set
    End Property

    Public Property _EstadoAlmacen() As String
        Get
            Return EstadoAlmacen
        End Get
        Set(ByVal value As String)
            EstadoAlmacen = value
        End Set
    End Property
    Public Property _Ubicacion() As String
        Get
            Return Ubicacion
        End Get
        Set(ByVal value As String)
            Ubicacion = value
        End Set
    End Property
    Public Property _DescUbicacion() As String
        Get
            Return DescUbicacion
        End Get
        Set(ByVal value As String)
            DescUbicacion = value
        End Set
    End Property
    Public Property _EstadoUbicacion() As String
        Get
            Return EstadoUbicacion
        End Get
        Set(ByVal value As String)
            EstadoUbicacion = value
        End Set
    End Property



    Public Shared Function GetAlmacen_ByUbicacion(ByVal ubicacion As String) As AlmacenUbicaciones
        Dim almUbi As New AlmacenUbicaciones()
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()

        Dim dt As New DataTable()
        LstParametros.Add(New Parametros("@ubicacion", ubicacion.Trim(), SqlDbType.VarChar))
        dt = conexion.SPObtenerDataTable("SP_GetAlmacen_byUbicacion", LstParametros)

        If dt.Rows.Count = 0 Then
            Throw New ArgumentException("Almacén no encontrado.")
        End If
        Dim dr As DataRow = dt.Rows(0)



        almUbi.COAlmacen = dr("f105_CO").ToString()
        almUbi.almacenUbic = dr("f105_Almacen").ToString()
        almUbi.descAlmacen = dr("f104_Descripcion").ToString()
        almUbi.EstadoAlmacen = dr("f104_Estado").ToString()
        almUbi.Ubicacion = dr("f105_Ubicaciones").ToString()
        almUbi.DescUbicacion = dr("f105_Descripcion").ToString()
        almUbi.EstadoUbicacion = dr("f105_Estado").ToString()

        If (almUbi.EstadoAlmacen <> "A") Then
            Throw New ArgumentException("El almacen está inactivo")
        End If

        Return almUbi
    End Function


End Class
