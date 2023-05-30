Public Class Almacenes
    Private almacen As String
    Private descripcion As String
    Private estado As String
    Private recepcion As Boolean
    Private nulos As Boolean
    Public Property _almacen() As String
        Get
            Return almacen
        End Get
        Set(ByVal value As String)
            almacen = value
        End Set
    End Property

    Public Property _descripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
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

    Public Property _recepcion() As Boolean
        Get
            Return recepcion
        End Get
        Set(ByVal value As Boolean)
            recepcion = value
        End Set
    End Property

    Public Property _nulos() As Boolean
        Get
            Return nulos
        End Get
        Set(ByVal value As Boolean)
            nulos = value
        End Set
    End Property



    Public Shared Function GetAlmacenRecepcion(ByVal almacen As String) As Almacenes
        Dim alm As New Almacenes()
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        Dim sql = "select f104_AlmacenRecepcion from [dbo].[t104_Almacenes] where f104_Almacen = '" + almacen + "'"
        Dim almRecepcion As String = conexion.GetEscalar(sql).ToString()
        If (String.IsNullOrEmpty(almRecepcion)) Then
            Throw New ArgumentException("El almacen no tiene configurado ningun almacen de recepción")
        End If


        Dim dt As New DataTable()
        LstParametros.Add(New Parametros("@almacen", almRecepcion, SqlDbType.VarChar))
        dt = conexion.SPObtenerDataTable("SP_GetAlmacen", LstParametros)

        If dt.Rows.Count = 0 Then
            Throw New ArgumentException("almacen recepcion no encontrado")
        End If
        Dim dr As DataRow = dt.Rows(0)

        alm.almacen = dr("f104_Almacen").ToString()
        alm.descripcion = dr("f104_Descripcion").ToString()
        alm.estado = dr("f104_Estado").ToString()
        alm.recepcion = CBool(dr("f104_Recepcion").ToString())
        alm.nulos = CBool(dr("f104_Nulos").ToString())

        If (alm.estado <> "A") Then
            Throw New ArgumentException("El almacen está inactivo")
        End If

        Return alm
    End Function





End Class

