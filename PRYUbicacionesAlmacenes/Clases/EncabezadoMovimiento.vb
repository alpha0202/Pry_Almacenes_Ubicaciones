Imports SAP.Middleware.Connector

Public Class EncabezadoMovimiento

    Private _f300_RowID As Decimal
    Public Property f300_RowID() As Decimal
        Get
            Return _f300_RowID
        End Get

        Set(ByVal value As Decimal)
            _f300_RowID = value
        End Set
    End Property

    Private _f300_CO As String
    Public Property f300_CO() As String
        Get
            Return _f300_CO
        End Get

        Set(ByVal value As String)
            _f300_CO = value
        End Set
    End Property

    Private _f300_TipoDocumento As String
    Public Property f300_TipoDocumento() As String
        Get
            Return _f300_TipoDocumento
        End Get

        Set(ByVal value As String)
            _f300_TipoDocumento = value
        End Set
    End Property

    Private _f300_NroDocumento As Decimal
    Public Property f300_NroDocumento() As Decimal
        Get
            Return _f300_NroDocumento
        End Get

        Set(ByVal value As Decimal)
            _f300_NroDocumento = value
        End Set
    End Property

    Private _f300_FechaDocumento As DateTime
    Public Property f300_FechaDocumento() As DateTime
        Get
            Return _f300_FechaDocumento
        End Get

        Set(ByVal value As DateTime)
            _f300_FechaDocumento = value
        End Set
    End Property

    Private _f300_DocumentoBase As String
    Public Property f300_DocumentoBase() As String
        Get
            Return _f300_DocumentoBase
        End Get

        Set(ByVal value As String)
            _f300_DocumentoBase = value
        End Set
    End Property

    Private _f300_NroDocumentoBase As Decimal
    Public Property f300_NroDocumentoBase() As Decimal
        Get
            Return _f300_NroDocumentoBase
        End Get

        Set(ByVal value As Decimal)
            _f300_NroDocumentoBase = value
        End Set
    End Property

    Private _f300_AlmacenOrigen As String
    Public Property f300_AlmacenOrigen() As String
        Get
            Return _f300_AlmacenOrigen
        End Get

        Set(ByVal value As String)
            _f300_AlmacenOrigen = value
        End Set
    End Property

    Private _f300_AlmacenDestino As String
    Public Property f300_AlmacenDestino() As String
        Get
            Return _f300_AlmacenDestino
        End Get

        Set(ByVal value As String)
            _f300_AlmacenDestino = value
        End Set
    End Property

    Private _f300_EstadoDoc As String
    Public Property f300_EstadoDoc() As String
        Get
            Return _f300_EstadoDoc
        End Get

        Set(ByVal value As String)
            _f300_EstadoDoc = value
        End Set
    End Property

    Private _f300_TipoDocInterface As String
    Public Property f300_TipoDocInterface() As String
        Get
            Return _f300_TipoDocInterface
        End Get

        Set(ByVal value As String)
            _f300_TipoDocInterface = value
        End Set
    End Property

    Private _f300_NroDocInterface As Decimal
    Public Property f300_NroDocInterface() As Decimal
        Get
            Return _f300_NroDocInterface
        End Get

        Set(ByVal value As Decimal)
            _f300_NroDocInterface = value
        End Set
    End Property

    Private _f300_UsuarioCreacion As String
    Public Property f300_UsuarioCreacion() As String
        Get
            Return _f300_UsuarioCreacion
        End Get

        Set(ByVal value As String)
            _f300_UsuarioCreacion = value
        End Set
    End Property

    Private _f300_FechaHoraCreacion As DateTime
    Public Property f300_FechaHoraCreacion() As DateTime
        Get
            Return _f300_FechaHoraCreacion
        End Get

        Set(ByVal value As DateTime)
            _f300_FechaHoraCreacion = value
        End Set
    End Property

    Private _f300_UsuarioActualizacion As String
    Public Property f300_UsuarioActualizacion() As String
        Get
            Return _f300_UsuarioActualizacion
        End Get

        Set(ByVal value As String)
            _f300_UsuarioActualizacion = value
        End Set
    End Property

    Private _f300_FechaHoraActualizacion As DateTime
    Public Property f300_FechaHoraActualizacion() As DateTime
        Get
            Return _f300_FechaHoraActualizacion
        End Get

        Set(ByVal value As DateTime)
            _f300_FechaHoraActualizacion = value
        End Set
    End Property

    Private _f300_UsuarioCierre As String
    Public Property f300_UsuarioCierre() As String
        Get
            Return _f300_UsuarioCierre
        End Get

        Set(ByVal value As String)
            _f300_UsuarioCierre = value
        End Set
    End Property

    Private _f300_FechaHoraCierre As DateTime
    Public Property f300_FechaHoraCierre() As DateTime
        Get
            Return _f300_FechaHoraCierre
        End Get

        Set(ByVal value As DateTime)
            _f300_FechaHoraCierre = value
        End Set
    End Property

    Private _f300_UsuarioAnulacion As String
    Public Property f300_UsuarioAnulacion() As String
        Get
            Return _f300_UsuarioAnulacion
        End Get

        Set(ByVal value As String)
            _f300_UsuarioAnulacion = value
        End Set
    End Property

    Private _f300_FechaHoraAnulacion As DateTime
    Public Property f300_FechaHoraAnulacion() As DateTime
        Get
            Return _f300_FechaHoraAnulacion
        End Get

        Set(ByVal value As DateTime)
            _f300_FechaHoraAnulacion = value
        End Set
    End Property

    Private _listDetalleMovimiento As List(Of DetalleMovimiento)
    Public Property listDetalleMovimiento() As List(Of DetalleMovimiento)
        Get
            Return _listDetalleMovimiento
        End Get
        Set(ByVal value As List(Of DetalleMovimiento))
            _listDetalleMovimiento = value
        End Set
    End Property

    Public Shared Function ListEncabezadoMovimiento(ByVal co As String, ByVal almacen As String) As List(Of EncabezadoMovimiento)


        Dim listEncabezado As New List(Of EncabezadoMovimiento)
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@co", co, SqlDbType.VarChar))
        LstParametros.Add(New Parametros("@almacen", almacen, SqlDbType.VarChar))
        Dim dt As New DataTable
        dt = conexion.SPObtenerDataTable("SP_GetListEncMovimientosRecepcion", LstParametros)

        For Each dr As DataRow In dt.Rows
            Dim encabezado As New EncabezadoMovimiento()

            encabezado.f300_RowID = CDec(dr("f300_RowID").ToString())
            encabezado.f300_CO = dr("f300_CO").ToString()
            encabezado.f300_TipoDocumento = dr("f300_TipoDocumento").ToString()
            encabezado.f300_NroDocumento = CDec(dr("f300_NroDocumento").ToString())
            encabezado.f300_FechaDocumento = CDate(dr("f300_FechaDocumento").ToString())
            encabezado.f300_DocumentoBase = dr("f300_DocumentoBase").ToString()
            'encabezado.f300_NroDocumentoBase = CDec(dr("f300_NroDocumentoBase").ToString())
            encabezado.f300_AlmacenOrigen = dr("f300_AlmacenOrigen").ToString()
            encabezado.f300_AlmacenDestino = dr("f300_AlmacenDestino").ToString()
            encabezado.f300_EstadoDoc = dr("f300_EstadoDoc").ToString()
            encabezado.f300_TipoDocInterface = dr("f300_TipoDocInterface").ToString()
            'encabezado.f300_NroDocInterface = dr("f300_NroDocInterface").ToString()
            encabezado.f300_UsuarioCreacion = dr("f300_UsuarioCreacion").ToString()
            encabezado.f300_FechaHoraCreacion = CDate(dr("f300_FechaHoraCreacion").ToString())
            encabezado.f300_UsuarioActualizacion = dr("f300_UsuarioActualizacion").ToString()
            encabezado.f300_FechaHoraActualizacion = CDate(dr("f300_FechaHoraActualizacion").ToString())
            'encabezado.f300_UsuarioCierre = dr("f300_UsuarioCierre").ToString()
            'encabezado.f300_FechaHoraCierre = dr("f300_FechaHoraCierre").ToString()
            'encabezado.f300_UsuarioAnulacion = dr("f300_UsuarioAnulacion").ToString()
            'encabezado.f300_FechaHoraAnulacion = dr("f300_FechaHoraAnulacion").ToString()

            listEncabezado.Add(encabezado)
        Next

        Return listEncabezado
    End Function


    Public Shared Function ListEncabezadoMovimientoDVP(ByVal co As String, ByVal almacen As String) As List(Of EncabezadoMovimiento)


        Dim listEncabezado As New List(Of EncabezadoMovimiento)
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@co", co, SqlDbType.VarChar))
        LstParametros.Add(New Parametros("@almacen", almacen, SqlDbType.VarChar))
        Dim dt As New DataTable
        dt = conexion.SPObtenerDataTable("SP_GetListEncMovimientosDevolucion", LstParametros)

        For Each dr As DataRow In dt.Rows
            Dim encabezado As New EncabezadoMovimiento()

            encabezado.f300_RowID = CDec(dr("f300_RowID").ToString())
            encabezado.f300_CO = dr("f300_CO").ToString()
            encabezado.f300_TipoDocumento = dr("f300_TipoDocumento").ToString()
            encabezado.f300_NroDocumento = CDec(dr("f300_NroDocumento").ToString())
            encabezado.f300_FechaDocumento = CDate(dr("f300_FechaDocumento").ToString())
            encabezado.f300_DocumentoBase = dr("f300_DocumentoBase").ToString()
            'encabezado.f300_NroDocumentoBase = CDec(dr("f300_NroDocumentoBase").ToString())
            encabezado.f300_AlmacenOrigen = dr("f300_AlmacenOrigen").ToString()
            encabezado.f300_AlmacenDestino = dr("f300_AlmacenDestino").ToString()
            encabezado.f300_EstadoDoc = dr("f300_EstadoDoc").ToString()
            encabezado.f300_TipoDocInterface = dr("f300_TipoDocInterface").ToString()
            'encabezado.f300_NroDocInterface = dr("f300_NroDocInterface").ToString()
            encabezado.f300_UsuarioCreacion = dr("f300_UsuarioCreacion").ToString()
            encabezado.f300_FechaHoraCreacion = CDate(dr("f300_FechaHoraCreacion").ToString())
            encabezado.f300_UsuarioActualizacion = dr("f300_UsuarioActualizacion").ToString()
            encabezado.f300_FechaHoraActualizacion = CDate(dr("f300_FechaHoraActualizacion").ToString())
            'encabezado.f300_UsuarioCierre = dr("f300_UsuarioCierre").ToString()
            encabezado.f300_FechaHoraCierre = CDate(dr("f300_FechaHoraCierre").ToString())
            'encabezado.f300_UsuarioAnulacion = dr("f300_UsuarioAnulacion").ToString()
            'encabezado.f300_FechaHoraAnulacion = dr("f300_FechaHoraAnulacion").ToString()

            listEncabezado.Add(encabezado)
        Next

        Return listEncabezado
    End Function

    Public Shared Function ListEncabezadoMovimientoTRU(ByVal co As String, ByVal almacen As String) As List(Of EncabezadoMovimiento)


        Dim listEncabezado As New List(Of EncabezadoMovimiento)
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@co", co, SqlDbType.VarChar))
        LstParametros.Add(New Parametros("@almacen", almacen, SqlDbType.VarChar))
        Dim dt As New DataTable
        dt = conexion.SPObtenerDataTable("SP_GetListEncMovimientosTrasladosUbicacion", LstParametros)

        For Each dr As DataRow In dt.Rows
            Dim encabezado As New EncabezadoMovimiento()

            encabezado.f300_RowID = CDec(dr("f300_RowID").ToString())
            encabezado.f300_CO = dr("f300_CO").ToString()
            encabezado.f300_TipoDocumento = dr("f300_TipoDocumento").ToString()
            encabezado.f300_NroDocumento = CDec(dr("f300_NroDocumento").ToString())
            encabezado.f300_FechaDocumento = CDate(dr("f300_FechaDocumento").ToString())
            encabezado.f300_DocumentoBase = dr("f300_DocumentoBase").ToString()
            'encabezado.f300_NroDocumentoBase = CDec(dr("f300_NroDocumentoBase").ToString())
            encabezado.f300_AlmacenOrigen = dr("f300_AlmacenOrigen").ToString()
            encabezado.f300_AlmacenDestino = dr("f300_AlmacenDestino").ToString()
            encabezado.f300_EstadoDoc = dr("f300_EstadoDoc").ToString()
            encabezado.f300_TipoDocInterface = dr("f300_TipoDocInterface").ToString()
            'encabezado.f300_NroDocInterface = dr("f300_NroDocInterface").ToString()
            encabezado.f300_UsuarioCreacion = dr("f300_UsuarioCreacion").ToString()
            encabezado.f300_FechaHoraCreacion = CDate(dr("f300_FechaHoraCreacion").ToString())
            encabezado.f300_UsuarioActualizacion = dr("f300_UsuarioActualizacion").ToString()
            'encabezado.f300_FechaHoraActualizacion = CDate(dr("f300_FechaHoraActualizacion").ToString())
            'encabezado.f300_UsuarioCierre = dr("f300_UsuarioCierre").ToString()
            'encabezado.f300_FechaHoraCierre = CDate(dr("f300_FechaHoraCierre").ToString())
            'encabezado.f300_UsuarioAnulacion = dr("f300_UsuarioAnulacion").ToString()
            'encabezado.f300_FechaHoraAnulacion = dr("f300_FechaHoraAnulacion").ToString()

            listEncabezado.Add(encabezado)
        Next

        Return listEncabezado
    End Function


    Public Shared Function ListEncabezadoMovimientoTRA(ByVal co As String, ByVal almacen As String) As List(Of EncabezadoMovimiento)


        Dim listEncabezado As New List(Of EncabezadoMovimiento)
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@co", co, SqlDbType.VarChar))
        LstParametros.Add(New Parametros("@almacen", almacen, SqlDbType.VarChar))
        Dim dt As New DataTable
        dt = conexion.SPObtenerDataTable("SP_GetListEncMovimientosTrasladosAlmacenes", LstParametros)

        For Each dr As DataRow In dt.Rows
            Dim encabezado As New EncabezadoMovimiento()

            encabezado.f300_RowID = CDec(dr("f300_RowID").ToString())
            encabezado.f300_CO = dr("f300_CO").ToString()
            encabezado.f300_TipoDocumento = dr("f300_TipoDocumento").ToString()
            encabezado.f300_NroDocumento = CDec(dr("f300_NroDocumento").ToString())
            encabezado.f300_FechaDocumento = CDate(dr("f300_FechaDocumento").ToString())
            encabezado.f300_DocumentoBase = dr("f300_DocumentoBase").ToString()
            'encabezado.f300_NroDocumentoBase = CDec(dr("f300_NroDocumentoBase").ToString())
            encabezado.f300_AlmacenOrigen = dr("f300_AlmacenOrigen").ToString()
            encabezado.f300_AlmacenDestino = dr("f300_AlmacenDestino").ToString()
            encabezado.f300_EstadoDoc = dr("f300_EstadoDoc").ToString()
            encabezado.f300_TipoDocInterface = dr("f300_TipoDocInterface").ToString()
            'encabezado.f300_NroDocInterface = dr("f300_NroDocInterface").ToString()
            encabezado.f300_UsuarioCreacion = dr("f300_UsuarioCreacion").ToString()
            encabezado.f300_FechaHoraCreacion = CDate(dr("f300_FechaHoraCreacion").ToString())
            encabezado.f300_UsuarioActualizacion = dr("f300_UsuarioActualizacion").ToString()
            'encabezado.f300_FechaHoraActualizacion = CDate(dr("f300_FechaHoraActualizacion").ToString())
            'encabezado.f300_UsuarioCierre = dr("f300_UsuarioCierre").ToString()
            'encabezado.f300_FechaHoraCierre = CDate(dr("f300_FechaHoraCierre").ToString())
            'encabezado.f300_UsuarioAnulacion = dr("f300_UsuarioAnulacion").ToString()
            'encabezado.f300_FechaHoraAnulacion = dr("f300_FechaHoraAnulacion").ToString()

            listEncabezado.Add(encabezado)
        Next

        Return listEncabezado
    End Function



    Public Shared Function GetEncabezadoMovimiento(ByVal rowId As String) As EncabezadoMovimiento
        Dim encabezado As New EncabezadoMovimiento()
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        LstParametros.Add(New Parametros("@rowid", rowId, SqlDbType.VarChar))
        Dim ds As New DataSet()
        ds = conexion.SPGetDataSet("SP_GetEncabezadoMovimiento", LstParametros)

        Dim dr As DataRow = ds.Tables(0).Rows(0)
        encabezado.f300_RowID = CDec(dr("f300_RowID").ToString())
        encabezado.f300_CO = dr("f300_CO").ToString()
        encabezado.f300_TipoDocumento = dr("f300_TipoDocumento").ToString()
        encabezado.f300_NroDocumento = CDec(dr("f300_NroDocumento").ToString())
        encabezado.f300_FechaDocumento = CDate(dr("f300_FechaDocumento").ToString())
        encabezado.f300_DocumentoBase = dr("f300_DocumentoBase").ToString()
        'encabezado.f300_NroDocumentoBase = CDec(dr("f300_NroDocumentoBase").ToString())
        encabezado.f300_AlmacenOrigen = dr("f300_AlmacenOrigen").ToString()
        encabezado.f300_AlmacenDestino = dr("f300_AlmacenDestino").ToString()
        encabezado.f300_EstadoDoc = dr("f300_EstadoDoc").ToString()
        encabezado.f300_TipoDocInterface = dr("f300_TipoDocInterface").ToString()
        'encabezado.f300_NroDocInterface = dr("f300_NroDocInterface").ToString()
        'encabezado.f300_UsuarioCreacion = dr("f300_UsuarioCreacion").ToString()
        encabezado.f300_FechaHoraCreacion = CDate(dr("f300_FechaHoraCreacion").ToString())
        encabezado.f300_UsuarioActualizacion = dr("f300_UsuarioActualizacion").ToString()
        encabezado.f300_FechaHoraActualizacion = CDate(dr("f300_FechaHoraActualizacion").ToString())
        'encabezado.f300_UsuarioCierre = dr("f300_UsuarioCierre").ToString()
        'encabezado.f300_FechaHoraCierre = CDate(dr("f300_FechaHoraCierre").ToString())
        'encabezado.f300_UsuarioAnulacion = dr("f300_UsuarioAnulacion").ToString()
        'encabezado.f300_FechaHoraAnulacion = dr("f300_FechaHoraAnulacion").ToString()

        Dim detalle As New List(Of DetalleMovimiento)
        For Each row As DataRow In ds.Tables(1).Rows
            Dim d As New DetalleMovimiento
            d.f301_RowID = CDec(row("f301_RowID").ToString())
            d.f301_RowIDDocumento = CDec(row("f301_RowIDDocumento").ToString())
            d.f301_Referencia = row("f301_Referencia").ToString()
            d.f301_SerialMaterial = row("f301_SerialMaterial").ToString()
            d.f301_UbicacionLeida = row("f301_UbicacionLeida").ToString()
            d.f301_Cantidad = CDec(row("f301_Cantidad").ToString())
            d.f301_UbicacionOrigen = row("f301_UbicacionOrigen").ToString()
            d.f301_UbicacionDestino = row("f301_UbicacionDestino").ToString()
            d.f301_EstadoMov = row("f301_EstadoMov").ToString()
            d.f301_FechaHoraMov = DateTime.Parse(row("f301_FechaHoraMov").ToString())
            d.f301_UsuarioMov = row("f301_UsuarioMov").ToString()
            'd.f301_FechaHoraElim = dr("f301_FechaHoraElim").ToString()
            'd.f301_UsuarioElim = dr("f301_UsuarioElim").ToString()
            d.f106_Descripcion = row("f106_Descripcion").ToString()
            d.f301_Lote = row("f301_Lote").ToString()
            detalle.Add(d)
        Next
        encabezado.listDetalleMovimiento = detalle
        Return encabezado
    End Function


    Public Shared Function CerrarMovimientoTRA(ByVal rowId As String) As String
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            ''CONSULTAR ESTADO MOVIMIENTO
            Dim sql As String = "Select f300_EstadoDoc from t300_EncMovimientos where f300_RowID = " + rowId
            Dim estado As String = conexion.GetEscalar(sql).ToString

            Dim encabezado As New EncabezadoMovimiento()
            encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(rowId)

            If estado = "A" Then

                Dim mensaje As String

                Dim LstParametros As New List(Of Parametros)()
                LstParametros.Add(New Parametros("@usuario", Utilidades.getUsuario(), SqlDbType.VarChar))
                LstParametros.Add(New Parametros("@RowIdMovimiento", rowId, SqlDbType.VarChar))
                mensaje = conexion.SPGetEscalar("SP_CerrarMovimientoRCPrecepcion", LstParametros).ToString
                If mensaje <> "" Then
                    Return mensaje
                Else
                    estado = "X"
                End If

            End If

            If estado = "X" Then
                Dim LstParametros As New List(Of Parametros)()
                Dim respuesta As New DataTable
                Dim prd = RfcDestinationManager.GetDestination("SE37")
                Dim repo As RfcRepository = prd.Repository
                Dim soBapi As IRfcFunction = repo.CreateFunction("Z_MDFN_MIGO")
                soBapi.SetValue("O_WERKS", encabezado.f300_CO)
                soBapi.SetValue("O_LGORT", encabezado.f300_AlmacenOrigen)
                soBapi.SetValue("D_WERKS", encabezado.f300_CO)
                soBapi.SetValue("D_LGORT", encabezado.f300_AlmacenDestino)
                soBapi.SetValue("D_FECHA", encabezado.f300_FechaHoraCreacion)
                soBapi.SetValue("ALIAR", encabezado.f300_TipoDocumento + encabezado.f300_NroDocumento.ToString())

                Dim sqlDetalle As String
                sqlDetalle = "SELECT f301_Referencia as MATNR,f301_Cantidad as MENGE, f301_Lote, f301_SerialMaterial  FROM t301_DetMovimientos WHERE f301_RowIDDocumento = " + rowId + " AND f301_EstadoMov = 'C'"
                Dim dtDetalle As New DataTable
                dtDetalle = conexion.ObtenerDataTable(sqlDetalle)

                Dim tablaEntrada As IRfcTable = soBapi.GetTable("IT_MAT")
                'Dim stru As RfcStructureMetadata = repo.GetStructureMetadata("ZTBAPIMIGOTRAS")
                For Each dr As DataRow In dtDetalle.Rows
                    'Dim datos As IRfcStructure = stru.CreateStructure()
                    tablaEntrada.Append()
                    tablaEntrada.SetValue("MATNR", Format(CDec(dr("MATNR").ToString()), "000000000000000000"))
                    tablaEntrada.SetValue("MENGE", dr("MENGE").ToString())
                    tablaEntrada.SetValue("CHARG", dr("f301_Lote").ToString())
                    tablaEntrada.SetValue("SERNR", dr("f301_SerialMaterial").ToString()) 'SERIAL MATERIAL

                Next

                soBapi.SetValue("IT_MAT", tablaEntrada)

                soBapi.Invoke(prd)
                Dim IT_KNA1 As IRfcTable = soBapi.GetTable("IT_OUT")

                respuesta = Utilidades.ConvertToDotNetTable(IT_KNA1)

                If respuesta.Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = respuesta.Rows(0)
                    Dim mensaje As String = dr(4).ToString()
                    If Not String.IsNullOrEmpty(mensaje) Then
                        Throw New ArgumentException(mensaje)
                    End If
                    Dim NroDocto As String = dr(1).ToString()
                    Dim tipoDocto As String = dr(2).ToString()
                    'actualizar la interzase
                    sql = "update t300_EncMovimientos set f300_EstadoDoc = 'C', f300_TipoDocInterface = '" + tipoDocto + "', f300_NroDocInterface = " + NroDocto + " where f300_RowID = " + rowId
                    conexion.GetEscalar(sql)

                Else
                    Throw New ArgumentException("error SAP al enviar el documento")
                End If

                Return ""
            End If


            If estado = "C" Then
                Return "El documento ha cambiado de estado"
            End If


            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function CerrarMovimientoDVP(ByVal rowId As String) As String
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            ''CONSULTAR ESTADO MOVIMIENTO
            Dim sql As String = "Select f300_EstadoDoc from t300_EncMovimientos where f300_RowID = " + rowId
            Dim estado As String = conexion.GetEscalar(sql).ToString

            Dim encabezado As New EncabezadoMovimiento()
            encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(rowId)

            If estado = "A" Then

                Dim mensaje As String

                Dim LstParametros As New List(Of Parametros)()
                LstParametros.Add(New Parametros("@usuario", Utilidades.getUsuario(), SqlDbType.VarChar))
                LstParametros.Add(New Parametros("@RowIdMovimiento", rowId, SqlDbType.VarChar))
                mensaje = conexion.SPGetEscalar("SP_CerrarMovimientoDVP", LstParametros).ToString
                If mensaje <> "" Then
                    Return mensaje
                Else
                    estado = "X"
                End If

            End If

            If estado = "X" Then
                Dim LstParametros As New List(Of Parametros)()
                Dim respuesta As New DataTable
                Dim prd = RfcDestinationManager.GetDestination("SE37")
                Dim repo As RfcRepository = prd.Repository
                Dim soBapi As IRfcFunction = repo.CreateFunction("Z_MDFN_MIGO")
                soBapi.SetValue("O_WERKS", encabezado.f300_CO)
                soBapi.SetValue("O_LGORT", encabezado.f300_AlmacenOrigen)
                soBapi.SetValue("D_WERKS", encabezado.f300_CO)
                soBapi.SetValue("D_LGORT", encabezado.f300_AlmacenDestino)
                soBapi.SetValue("D_FECHA", encabezado.f300_FechaHoraCreacion)
                soBapi.SetValue("ALIAR", encabezado.f300_TipoDocumento + encabezado.f300_NroDocumento.ToString())

                Dim sqlDetalle As String
                sqlDetalle = "SELECT f301_Referencia as MATNR,f301_Cantidad as MENGE, f301_Lote, f301_SerialMaterial  FROM t301_DetMovimientos WHERE f301_RowIDDocumento = " + rowId + " AND f301_EstadoMov = 'C'"
                Dim dtDetalle As New DataTable
                dtDetalle = conexion.ObtenerDataTable(sqlDetalle)

                Dim tablaEntrada As IRfcTable = soBapi.GetTable("IT_MAT")
                'Dim stru As RfcStructureMetadata = repo.GetStructureMetadata("ZTBAPIMIGOTRAS")
                For Each dr As DataRow In dtDetalle.Rows
                    'Dim datos As IRfcStructure = stru.CreateStructure()
                    tablaEntrada.Append()
                    tablaEntrada.SetValue("MATNR", Format(CDec(dr("MATNR").ToString()), "000000000000000000"))
                    tablaEntrada.SetValue("MENGE", dr("MENGE").ToString())
                    tablaEntrada.SetValue("CHARG", dr("f301_Lote").ToString())
                    tablaEntrada.SetValue("SERNR", dr("f301_SerialMaterial").ToString()) 'SERIAL MATERIAL

                Next

                soBapi.SetValue("IT_MAT", tablaEntrada)

                soBapi.Invoke(prd)
                Dim IT_KNA1 As IRfcTable = soBapi.GetTable("IT_OUT")

                respuesta = Utilidades.ConvertToDotNetTable(IT_KNA1)

                If respuesta.Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = respuesta.Rows(0)
                    Dim mensaje As String = dr(4).ToString()
                    If Not String.IsNullOrEmpty(mensaje) Then
                        Throw New ArgumentException(mensaje)
                    End If
                    Dim NroDocto As String = dr(1).ToString()
                    Dim tipoDocto As String = dr(2).ToString()
                    'actualizar la interzase
                    sql = "update t300_EncMovimientos set f300_EstadoDoc = 'C', f300_TipoDocInterface = '" + tipoDocto + "', f300_NroDocInterface = " + NroDocto + " where f300_RowID = " + rowId
                    conexion.GetEscalar(sql)

                Else
                    Throw New ArgumentException("error SAP al enviar el documento")
                End If

                Return ""
            End If


            If estado = "C" Then
                Return "El documento ha cambiado de estado"
            End If


            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Shared Function CerrarMovimientoTRU(ByVal rowId As String) As String
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            ''CONSULTAR ESTADO MOVIMIENTO
            Dim sql As String = "Select f300_EstadoDoc from t300_EncMovimientos where f300_RowID = " + rowId
            Dim estado As String = conexion.GetEscalar(sql).ToString

            Dim encabezado As New EncabezadoMovimiento()
            encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(rowId)

            If estado = "A" Then

                Dim mensaje As String

                Dim LstParametros As New List(Of Parametros)()
                LstParametros.Add(New Parametros("@usuario", Utilidades.getUsuario(), SqlDbType.VarChar))
                LstParametros.Add(New Parametros("@RowIdMovimiento", rowId, SqlDbType.VarChar))
                mensaje = conexion.SPGetEscalar("SP_CerrarMovimientoTRU", LstParametros).ToString

                If mensaje <> "" Then
                    Throw New Exception($"Error cerrando movimiento TRU. {mensaje}")

                End If

            End If


            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Public Shared Function CerrarMovimientoTrasladoTRA(ByVal rowId As String) As String
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            ''CONSULTAR ESTADO MOVIMIENTO
            Dim sql As String = "Select f300_EstadoDoc from t300_EncMovimientos where f300_RowID = " + rowId
            Dim estado As String = conexion.GetEscalar(sql).ToString

            Dim encabezado As New EncabezadoMovimiento()
            encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(rowId)

            If estado = "A" Then

                Dim mensaje As String

                Dim LstParametros As New List(Of Parametros)()
                LstParametros.Add(New Parametros("@usuario", Utilidades.getUsuario(), SqlDbType.VarChar))
                LstParametros.Add(New Parametros("@RowIdMovimiento", rowId, SqlDbType.VarChar))
                mensaje = conexion.SPGetEscalar("SP_CerrarMovimientoTRA", LstParametros).ToString

                If mensaje <> "" Then
                    Return mensaje
                Else
                    estado = "X"
                End If

            End If


            'SE UTILIZA MIGO, PORQUE ES UN TRASLADO ENTRE ALMACENES.
            If estado = "X" Then
                Dim LstParametros As New List(Of Parametros)()
                Dim respuesta As New DataTable
                Dim prd = RfcDestinationManager.GetDestination("SE37")
                Dim repo As RfcRepository = prd.Repository
                Dim soBapi As IRfcFunction = repo.CreateFunction("Z_MDFN_MIGO")
                soBapi.SetValue("O_WERKS", encabezado.f300_CO)
                soBapi.SetValue("O_LGORT", encabezado.f300_AlmacenOrigen)
                soBapi.SetValue("D_WERKS", encabezado.f300_CO)
                soBapi.SetValue("D_LGORT", encabezado.f300_AlmacenDestino)
                soBapi.SetValue("D_FECHA", encabezado.f300_FechaHoraCreacion)
                soBapi.SetValue("ALIAR", encabezado.f300_TipoDocumento + encabezado.f300_NroDocumento.ToString())

                Dim sqlDetalle As String
                sqlDetalle = "SELECT f301_Referencia as MATNR,f301_Cantidad as MENGE, f301_Lote, f301_SerialMaterial  FROM t301_DetMovimientos WHERE f301_RowIDDocumento = " + rowId + " AND f301_EstadoMov = 'C'"
                Dim dtDetalle As New DataTable
                dtDetalle = conexion.ObtenerDataTable(sqlDetalle)

                Dim tablaEntrada As IRfcTable = soBapi.GetTable("IT_MAT")
                'Dim stru As RfcStructureMetadata = repo.GetStructureMetadata("ZTBAPIMIGOTRAS")
                For Each dr As DataRow In dtDetalle.Rows
                    'Dim datos As IRfcStructure = stru.CreateStructure()
                    tablaEntrada.Append()
                    tablaEntrada.SetValue("MATNR", Format(CDec(dr("MATNR").ToString()), "000000000000000000"))
                    tablaEntrada.SetValue("MENGE", dr("MENGE").ToString())
                    tablaEntrada.SetValue("CHARG", dr("f301_Lote").ToString())
                    tablaEntrada.SetValue("SERNR", dr("f301_SerialMaterial").ToString()) 'SERIAL MATERIAL

                Next

                soBapi.SetValue("IT_MAT", tablaEntrada)

                soBapi.Invoke(prd)
                Dim IT_KNA1 As IRfcTable = soBapi.GetTable("IT_OUT")

                respuesta = Utilidades.ConvertToDotNetTable(IT_KNA1)

                If respuesta.Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = respuesta.Rows(0)
                    Dim mensaje As String = dr(4).ToString()
                    If Not String.IsNullOrEmpty(mensaje) Then
                        Throw New ArgumentException(mensaje)
                    End If
                    Dim NroDocto As String = dr(1).ToString()
                    Dim tipoDocto As String = dr(2).ToString()
                    'actualizar la interzase
                    sql = "update t300_EncMovimientos set f300_EstadoDoc = 'C', f300_TipoDocInterface = '" + tipoDocto + "', f300_NroDocInterface = " + NroDocto + " where f300_RowID = " + rowId
                    conexion.GetEscalar(sql)

                Else
                    Throw New ArgumentException("error SAP al enviar el documento")
                End If

                Return ""
            End If


            If estado = "C" Then
                Return "El documento ha cambiado de estado"
            End If


            Return ""
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
