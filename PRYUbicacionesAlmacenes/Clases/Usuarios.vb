Public Class Usuarios

    Private usuario As String
    Private co As String
    Private almacen As String
    Private fechaProceso As Date
    Private estado As String
    Private desCo As String
    Private desAlmacen As String

    Public Property _usuario() As String
        Get
            Return usuario
        End Get
        Set(ByVal value As String)
            usuario = value
        End Set
    End Property

    Public Property _co() As String
        Get
            Return co
        End Get
        Set(ByVal value As String)
            co = value
        End Set
    End Property

    Public Property _almacen() As String
        Get
            Return almacen
        End Get
        Set(ByVal value As String)
            almacen = value
        End Set
    End Property

    Public Property _estado() As String
        Get
            Return estado
        End Get
        Set(ByVal value As String)
            estado = value
        End Set
    End Property

    Public Property _fechaProceso() As Date
        Get
            Return fechaProceso
        End Get
        Set(ByVal value As Date)
            fechaProceso = value
        End Set
    End Property

    Public Property _desCo() As String
        Get
            Return desCo
        End Get
        Set(ByVal value As String)
            desCo = value
        End Set
    End Property
    Public Property _desAlmacen() As String
        Get
            Return desAlmacen
        End Get
        Set(ByVal value As String)
            desAlmacen = value
        End Set
    End Property

    Public Shared Function GetUsuario(ByVal usuario As String) As Usuarios
        Dim user As New Usuarios()
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@usuario", usuario, SqlDbType.VarChar))
        Dim dt As New DataTable()
        dt = conexion.SPObtenerDataTable("SP_GetUsuario", LstParametros)
        If dt.Rows.Count = 0 Then
            Throw New ArgumentException("Usuario no encontrado")
        End If

        Dim dr As DataRow = dt.Rows(0)
        user._usuario = dr("f102_Usuario").ToString()
        user._co = dr("f103_CO").ToString()
        user._almacen = dr("f104_Almacen").ToString()
        user._desCo = dr("f103_DescripcionCO").ToString()
        user._desAlmacen = dr("f104_Descripcion").ToString()
        user._estado = dr("f102_Estado").ToString()
        user._fechaProceso = CDate(dr("f104_FechaProceso").ToString())

        Return user
    End Function





End Class
