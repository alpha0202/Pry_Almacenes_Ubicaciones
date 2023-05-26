Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports Newtonsoft.Json
Imports SAP.Middleware.Connector

Public Class frmRecepcion
    Private CO As String
    Private ALMACEN As String
    Private ALMRECEPCION As String
    Private ROWID As String = String.Empty
    Dim utilities As Utilidades = New Utilidades()




    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        'evita problemas para abrir y cerrar el llamado del formulario  captura de pesos.
        'If frmBodegasUbicaciones Is Nothing Then
        '    frmBodegasUbicaciones = New FrmBodegas()
        'ElseIf Not frmBodegasUbicaciones.IsHandleCreated Then
        '    frmBodegasUbicaciones = New FrmBodegas()
        'End If


    End Sub
    Private Function CargarDataTable() As DataTable
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim sql As String = "SELECT  f106_Material, f106_Descripcion FROM t106_Materiales where f106_Descripcion LIKE '%" + txt_Referencia.Text + "%' "
        Dim dt As DataTable
        dt = conexion.ObtenerDataTable(sql)
        Return dt
    End Function

    Private Function CargarDataTable2() As DataTable
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim sql As String = "SELECT f106_Material, f106_Descripcion  FROM t106_Materiales where  f106_Material LIKE '%" + txt_Cod_Ref.Text + "%' "
        Dim dt As DataTable
        dt = conexion.ObtenerDataTable(sql)
        'If dt.Rows.Count > 0 Then
        '    ' txtproducto.Text = dt.Rows(0).Item(0).ToString
        '    txt_Referencia.Text = dt.Rows(0).Item(1).ToString
        'Else
        '    txt_Cod_Ref.Text = ""
        '    txt_DescRef.Text = ""
        'End If
        Return dt
    End Function

    Private Function CargarAutoCompletar() As AutoCompleteStringCollection
        Dim dt As DataTable = CargarDataTable()
        Dim Variable As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            Variable.Add(Convert.ToString(row("f106_Descripcion")))
            'txt_Cod_Ref.Text = dt.Rows(0).Item(0).ToString
        Next

        Return Variable
    End Function
    Dim dtLotes As DataTable
    Dim drSeriales As DataRow
    Dim serial As String
    Dim serialDigitado As String
    Sub cargarSaldos()
        txtCantidadDisponible.Text = String.Empty
        txtCantidadMovimiento.Text = String.Empty
        txtUnidadMedida.Text = String.Empty
        txt_RecepSerial.Text = String.Empty




        dtLotes = New DataTable()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Dim material = txt_Cod_Ref.Text

        Dim prd = RfcDestinationManager.GetDestination("SE37")
        Dim repo As RfcRepository = prd.Repository
        Dim soBapi As IRfcFunction = repo.CreateFunction("Z_MDFN_SALDOS")
        soBapi.SetValue("P_WERKS", CO)
        soBapi.SetValue("P_LGORT", ALMRECEPCION) ''modificar
        soBapi.SetValue("P_MATNR", Format(CDec(material), "000000000000000000"))
        soBapi.Invoke(prd)
        Dim IT_KNA1 As IRfcTable = soBapi.GetTable("IT_SALDOS")
        Dim dt As New DataTable()
        dt = Utilidades.ConvertToDotNetTable(IT_KNA1)
        Dim valoresCombo As New System.Collections.Generic.Dictionary(Of Object, Object)
        ''MessageBox.Show(Format(CDec(material), "000000000000000000"))
        If dt.Rows.Count > 0 Then

            drSeriales = dt.Rows(0)
            serial = drSeriales("SERNR").ToString()


            If dt.Rows.Count > 1 Then

                '****llenar combo de lotes***** 

                Dim LotesCombo As New Dictionary(Of String, String)

                Dim lotes As List(Of String) = dt.AsEnumerable() _
                                               .Select(Function(r) r.Field(Of String)(4)) _
                                               .Distinct() _
                                               .ToList()

                For Each lsCombo As String In lotes

                    LotesCombo.Add(lsCombo.ToString(), lsCombo.ToString())

                Next

                Dim lstToObject As Dictionary(Of Object, Object) = LotesCombo.ToDictionary(Function(k) DirectCast(k.Key, Object), Function(v) DirectCast(v.Value, Object))
                Utilidades.CargarCombo(cboLote, lstToObject, True, "--Seleccionar Uno--")

                '****fin de llenado combo lotes*****


                'For Each drCombo As DataRow In dtLotes.Rows

                '    valoresCombo.Add(drCombo("CHARG").ToString(), drCombo("CHARG").ToString())
                'Next
                'Utilidades.CargarCombo(cboLote, valoresCombo, True, "--Seleccione Uno--")

                dtLotes = dt
                If Not String.IsNullOrEmpty(serial) Then

                    lbl_Serial.Visible = True
                    txt_RecepSerial.Enabled = True
                    txt_RecepSerial.Visible = True


                End If


            Else

                Dim dr As DataRow
                dr = dt.Rows(0)
                Dim cantidad As Double = CDbl(dr("LABST").ToString())
                Dim unidad As String = dr("MEINS").ToString()
                Dim lote As String = dr("CHARG").ToString()

                If (Not String.IsNullOrEmpty(lote)) Then
                    valoresCombo.Add(lote, lote)
                    Utilidades.CargarCombo(cboLote, valoresCombo, False, "--Seleccione Uno--")
                End If


                ''buscar disponible restando cantidad en estado A
                Dim sql As String = "select SUM(f301_Cantidad) from t300_EncMovimientos
                inner join t301_DetMovimientos on f301_RowIDDocumento = f300_RowID
                where f300_TipoDocumento = 'RCP' and f300_EstadoDoc = 'A' and f301_EstadoMov = 'A'
                and f300_AlmacenOrigen = '" + ALMRECEPCION + "'
                and f301_Referencia = '" + material + "' and f301_Lote = '" + lote + "'"
                Dim cantMovimiento As String
                Dim conexion As clsConexionNew = New clsConexionNew()
                cantMovimiento = conexion.GetEscalar(sql).ToString()

                If Not String.IsNullOrEmpty(cantMovimiento) Then
                    cantidad = cantidad - CDbl(cantMovimiento)
                End If

                txtCantidadDisponible.Text = cantidad.ToString()
                txtCantidadMovimiento.Text = cantidad.ToString()
                txtUnidadMedida.Text = unidad
                txtCantidadMovimiento.Select()




            End If

            SplashScreenManager.CloseForm(False)
        Else
            txtCantidadDisponible.Text = "0"
            txtCantidadMovimiento.Text = "0"
            txtUnidadMedida.Text = ""
            txtCantidadMovimiento.Select()
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + "Material sin cantidad disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Function CargarAutoCompletar2() As AutoCompleteStringCollection
        Dim dt As DataTable = CargarDataTable2()
        Dim Variable As New AutoCompleteStringCollection()

        For Each row As DataRow In dt.Rows
            Variable.Add(RTrim(Convert.ToString(row("f106_Material"))))
            ' txt_Referencia.Text = dt.Rows(0).Item(1).ToString
        Next

        Return Variable
    End Function



    Private Sub frmRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try





            ''RfcDestinationManager.RegisterDestinationConfiguration(New rfc_Connector())

            txt_Cod_Ref.AutoCompleteCustomSource = CargarAutoCompletar2()
            txt_Cod_Ref.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Cod_Ref.AutoCompleteSource = AutoCompleteSource.CustomSource


            txt_Referencia.AutoCompleteCustomSource = CargarAutoCompletar()
            txt_Referencia.AutoCompleteMode = AutoCompleteMode.Suggest
            txt_Referencia.AutoCompleteSource = AutoCompleteSource.CustomSource


            Dim user As New Usuarios()
            user = Usuarios.GetUsuario(My.User.Name.ToUpper.Replace("ALIAR\", ""))

            If (user._estado <> "A") Then
                Throw New ArgumentException("Usuario Inactivo")
            End If

            txtAlmacenDestino.Text = user._almacen + "-" + user._desAlmacen
            ALMACEN = user._almacen

            txtCO.Text = user._co + "-" + user._desCo
            CO = user._co
            txtFechaProceso.Text = user._fechaProceso.ToString("dd/MM/yyyy")

            ''consultar almacen de recepcion
            Dim a = New Almacenes()
            a = Almacenes.GetAlmacenRecepcion(ALMACEN)

            txtAlmacenR.Text = a._almacen + "-" + a._descripcion
            ALMRECEPCION = a._almacen


        Catch ex As Exception

            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        XtraTabPage2.PageEnabled = True
        XtraTabPage3.PageEnabled = True
        Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
        txt_Cod_Ref.Select()
        lblMensaje.Text = ""

        txt_Cod_Ref.Text = ""
        txt_Referencia.Text = ""
        txtCantidadDisponible.Text = ""
        txtCantidadMovimiento.Text = ""
        txt_RecepSerial.Text = ""
        txtUnidadMedida.Text = ""
        ROWID = ""
        txtTipoDoct.Text = ""
        txtNroDocto.Text = ""
        txtEstado.Text = ""
        gcDetalle.DataSource = Nothing


    End Sub

    Private Sub txt_Cod_Ref_Leave(sender As Object, e As EventArgs) Handles txt_Cod_Ref.Leave
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim sql As String = "SELECT f106_Descripcion FROM t106_Materiales  where f106_Material ='" + txt_Cod_Ref.Text + "'"
            Dim dt As DataTable
            dt = conexion.ObtenerDataTable(sql)
            If dt.Rows.Count > 0 Then
                ' txtproducto.Text = dt.Rows(0).Item(0).ToString
                txt_Referencia.Text = dt.Rows(0).Item(0).ToString
                cargarSaldos()
            Else
                txt_Cod_Ref.Text = ""
                '  txt_DescRef.Text = ""
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_Referencia_Leave(sender As Object, e As EventArgs) Handles txt_Referencia.Leave
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim sql As String = "SELECT f106_Material FROM t106_Materiales  where f106_Descripcion='" + txt_Referencia.Text + "'"
            Dim dt As DataTable
            dt = conexion.ObtenerDataTable(sql)
            If dt.Rows.Count > 0 Then
                ' txtproducto.Text = dt.Rows(0).Item(0).ToString
                txt_Cod_Ref.Text = RTrim(dt.Rows(0).Item(0).ToString)
                cargarSaldos()
            Else
                txt_Cod_Ref.Text = ""
                ' txt_DescRef.Text = ""
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtCantidadMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadMovimiento.KeyPress
        Utilidades.NumerosyDecimal(txtCantidadMovimiento, e)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        lblMensaje.Text = ""
        Try
            'cboLote.DataSource = Nothing
            'cboLote.Items.Clear()
            Dim serialMat_Digitado As String

            If String.IsNullOrEmpty(txt_Cod_Ref.Text) Then
                Throw New ArgumentException("Seleccione la referencia")
            End If

            If Not String.IsNullOrEmpty(serial) Then

                If String.IsNullOrEmpty(txt_RecepSerial.Text) Then
                    Throw New ArgumentException("Falta serial del material")
                Else
                    serialMat_Digitado = String.Concat("0000000000", txt_RecepSerial.Text)

                End If
            Else
                serialMat_Digitado = ""
            End If




            If CDbl(txtCantidadDisponible.Text) <= 0 Then
                Throw New ArgumentException("Sin cantidad disponible")
            End If

            If String.IsNullOrEmpty(txtCantidadMovimiento.Text) Then
                Throw New ArgumentException("digite la cantidad a mover")
            End If

            If CDbl(txtCantidadMovimiento.Text) <= 0 Then
                Throw New ArgumentException("Sin cantidad movimiento no valida")
            End If

            If String.IsNullOrEmpty(txtUbicacion.Text) Then
                Throw New ArgumentException("digite la ubicacion destino")
            End If
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@co", CO, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@usuario", My.User.Name.ToUpper.Replace("ALIAR\", ""), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@RowId", IIf(ROWID = String.Empty, DBNull.Value, ROWID), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@cantidad", CDbl(txtCantidadMovimiento.Text), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@material", txt_Cod_Ref.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@serialMaterial", serialMat_Digitado, SqlDbType.VarChar)) 'serial material
            LstParametros.Add(New Parametros("@almacenOrigen", ALMRECEPCION, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@almacenDestino", ALMACEN, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@ubicacion", txtUbicacion.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@lote", cboLote.Text, SqlDbType.VarChar))
            Dim dt As New DataTable
            dt = conexion.SPObtenerDataTable("SP_GuardarMovimientoRCP", LstParametros)
            Dim dr As DataRow
            dr = dt.Rows(0)
            If dr(0).ToString = "" Then
                ROWID = dr(1).ToString
                Dim encabezado As New EncabezadoMovimiento()
                encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(ROWID)
                txtTipoDoct.Text = encabezado.f300_TipoDocumento
                txtNroDocto.Text = encabezado.f300_NroDocumento.ToString()
                txtEstado.Text = encabezado.f300_EstadoDoc

                gcDetalle.DataSource = encabezado.listDetalleMovimiento
                gvDetalle.BestFitColumns()

            Else
                Throw New ArgumentException(dr(0).ToString)
            End If

            lblMensaje.Text = "Se Proceso Correctamente"
            txt_Cod_Ref.Text = ""
            txt_Referencia.Text = ""
            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""
            txt_RecepSerial.Text = ""
            txt_RecepSerial.Enabled = False
            txt_RecepSerial.Visible = False
            lbl_Serial.Visible = False
            txtUbicacion.Text = ""
            txtCantidadMovimiento.Enabled = True
            txtUnidadMedida.Text = ""
            txt_Cod_Ref.Select()

            Dim valoresCombo As New System.Collections.Generic.Dictionary(Of Object, Object)
            valoresCombo.Add("", "")
            Utilidades.CargarCombo(cboLote, valoresCombo, False, "--Seleccione Uno--")
            cboLote.SelectedIndex = 0

            SplashScreenManager.CloseForm(False)

        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim f As New frmDocumentosRecepcion(CO, ALMACEN)
            f.ShowDialog()
            ROWID = f.rowid
            f.Dispose()
            If Not String.IsNullOrEmpty(ROWID) Then
                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                Dim encabezado As New EncabezadoMovimiento()
                encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(ROWID)
                txtTipoDoct.Text = encabezado.f300_TipoDocumento
                txtNroDocto.Text = encabezado.f300_NroDocumento.ToString()
                txtEstado.Text = encabezado.f300_EstadoDoc
                'Dim res As String = JsonConvert.SerializeObject(encabezado)
                'MessageBox.Show(res)

                gcDetalle.DataSource = encabezado.listDetalleMovimiento
                gvDetalle.BestFitColumns()

                SplashScreenManager.CloseForm(False)
                txt_Cod_Ref.Text = ""
                txt_Referencia.Text = ""
                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""
                txtUnidadMedida.Text = ""
                XtraTabPage2.PageEnabled = True
                XtraTabPage3.PageEnabled = True
                If encabezado.f300_EstadoDoc = "A" Then
                    Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
                    txt_Cod_Ref.Select()
                End If
            End If



        Catch ex As Exception
            XtraTabPage2.PageEnabled = False
            XtraTabPage3.PageEnabled = False
            SplashScreenManager.CloseForm(False)
            txt_Cod_Ref.Text = ""
            txt_Referencia.Text = ""
            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""
            txtUnidadMedida.Text = ""
            ROWID = ""
            txtTipoDoct.Text = ""
            txtNroDocto.Text = ""
            txtEstado.Text = ""
        End Try



    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If String.IsNullOrEmpty(ROWID) Then
            XtraMessageBox.Show("Error: " + "Ningun documento cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If XtraMessageBox.Show("¿Esta seguro de cerrar el documento?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Dim respuesta As String
            respuesta = EncabezadoMovimiento.CerrarMovimientoTRA(ROWID)
            SplashScreenManager.CloseForm(False)
            If String.IsNullOrEmpty(respuesta) Then

                XtraTabPage2.PageEnabled = False
                XtraTabPage3.PageEnabled = False
                lblMensaje.Text = ""
                txt_Cod_Ref.Text = ""
                txt_Referencia.Text = ""
                txt_RecepSerial.Text = ""
                txt_RecepSerial.Visible = False
                txt_RecepSerial.Enabled = False
                lbl_Serial.Visible = False
                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""
                txtUnidadMedida.Text = ""
                txtUbicacion.Text = ""
                ROWID = ""
                txtTipoDoct.Text = ""
                txtNroDocto.Text = ""
                txtEstado.Text = ""
                gcDetalle.DataSource = Nothing
                XtraMessageBox.Show("Se proceso correctamente", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub

    Private Sub txtCantidadMovimiento_Leave(sender As Object, e As EventArgs) Handles txtCantidadMovimiento.Leave
        txtUbicacion.Select()
    End Sub

    Private Sub btnEliminarMovimientos_Click(sender As Object, e As EventArgs) Handles btnEliminarMovimientos.Click
        Try
            'ValidarEstadoAlistamiento(txtTipoDocBase.Text, txtNroDocumentoBase.Text, txtCodigoCentroO.Text)
            Dim DatosSelect As New List(Of DetalleMovimiento)
            ' agrega a la lista las filas seleccionadas
            Dim I As Integer
            For I = 0 To gvDetalle.SelectedRowsCount() - 1
                If (gvDetalle.GetSelectedRows()(I) >= 0) Then
                    Dim view As GridView = gvDetalle
                    DatosSelect.Add(CType(view.GetRow(gvDetalle.GetSelectedRows()(I)), DetalleMovimiento))
                End If
            Next

            If DatosSelect.Count > 0 Then
                If XtraMessageBox.Show("¿Esta seguro de eliminar?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
                    Dim arrayMoviminetos As New ArrayList()
                    Dim SQL As String = ""
                    For I = 0 To DatosSelect.Count - 1
                        Dim Row As DetalleMovimiento = CType(DatosSelect(I), DetalleMovimiento)
                        arrayMoviminetos.Add(Row.f301_RowID.ToString)
                    Next
                    Dim conexion As clsConexionNew = New clsConexionNew()
                    Dim LstParametros As New List(Of Parametros)()
                    LstParametros.Add(New Parametros("@usuario", Utilidades.getUsuario(), SqlDbType.VarChar))
                    LstParametros.Add(New Parametros("@rowPedidos", String.Join(";", CType(arrayMoviminetos.ToArray(Type.GetType("System.String")), String())), SqlDbType.VarChar))
                    LstParametros.Add(New Parametros("@rowIdDocumento", ROWID, SqlDbType.VarChar))
                    Dim respuesta As String = CStr(conexion.SPGetEscalar("SP_EliminarMovimientosRCP", LstParametros))
                    If respuesta = "" Then
                        Dim encabezado As New EncabezadoMovimiento()
                        encabezado = EncabezadoMovimiento.GetEncabezadoMovimiento(ROWID)
                        txtTipoDoct.Text = encabezado.f300_TipoDocumento
                        txtNroDocto.Text = encabezado.f300_NroDocumento.ToString()
                        txtEstado.Text = encabezado.f300_EstadoDoc

                        gcDetalle.DataSource = encabezado.listDetalleMovimiento
                        gvDetalle.BestFitColumns()
                        SplashScreenManager.CloseForm(False)
                    Else
                        SplashScreenManager.CloseForm(False)
                        XtraMessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                SplashScreenManager.CloseForm(False)
                XtraMessageBox.Show("Nada Seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLote.SelectedIndexChanged

        If cboLote.SelectedValue.ToString() <> Nothing Then
            Dim loteSelect As String = cboLote.SelectedValue.ToString()
            Dim material = txt_Cod_Ref.Text
            Dim cantMovimiento As String
            Dim sql As String
            Dim conexion As clsConexionNew = New clsConexionNew()
            If loteSelect <> "0" Then

                Dim drResult As DataRow() = dtLotes.Select("  CHARG = '" + loteSelect + "'")

                Dim dr As DataRow = drResult(0)

                Dim cantidad As Double = CDbl(dr("LABST").ToString())
                Dim unidad As String = dr("MEINS").ToString()
                Dim lote As String = dr("CHARG").ToString()
                Dim serial As String = dr("SERNR").ToString()


                '***verificar si maneja serial el material. De ser así, se procede como se hace con los demás materiales.
                If Not String.IsNullOrEmpty(serial) Then
                    Dim equal As Boolean
                    serialDigitado = txt_RecepSerial.Text
                    'serialDigitado = String.Concat("0000000000", serialDigitado)

                    If serialDigitado = "" Then
                        XtraMessageBox.Show("Nota: " + "Debe digitar el serial del material", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If


                    equal = serial.Trim().Equals(String.Concat("0000000000", serialDigitado).Trim())

                    If equal = True Then

                        sql = "select SUM(f301_Cantidad) from t300_EncMovimientos
                        inner join t301_DetMovimientos on f301_RowIDDocumento = f300_RowID
                        where f300_TipoDocumento = 'RCP' and f300_EstadoDoc = 'A' and f301_EstadoMov = 'A'
                        and f300_AlmacenOrigen = '" + ALMRECEPCION + "'
                        and f301_Referencia = '" + material + "' and f301_Lote = '" + lote + "'"


                        cantMovimiento = conexion.GetEscalar(sql).ToString()

                        If Not String.IsNullOrEmpty(cantMovimiento) Then
                            cantidad = cantidad - CDbl(cantMovimiento)
                        End If

                        txtCantidadDisponible.Text = cantidad.ToString()
                        txtCantidadMovimiento.Text = cantidad.ToString()
                        txtUnidadMedida.Text = unidad
                        txtCantidadMovimiento.Enabled = False
                        txtUbicacion.Select()
                        'txtCantidadMovimiento.Select()


                    Else

                        txtCantidadDisponible.Text = String.Empty
                        txtCantidadMovimiento.Text = String.Empty
                        txtUnidadMedida.Text = String.Empty

                    End If
                    Return

                Else
                    '******


                    sql = "select SUM(f301_Cantidad) from t300_EncMovimientos
                    inner join t301_DetMovimientos on f301_RowIDDocumento = f300_RowID
                    where f300_TipoDocumento = 'RCP' and f300_EstadoDoc = 'A' and f301_EstadoMov = 'A'
                    and f300_AlmacenOrigen = '" + ALMRECEPCION + "'
                    and f301_Referencia = '" + material + "' and f301_Lote = '" + lote + "'"

                    cantMovimiento = conexion.GetEscalar(sql).ToString()

                    If Not String.IsNullOrEmpty(cantMovimiento) Then
                        cantidad = cantidad - CDbl(cantMovimiento)
                    End If

                    txtCantidadDisponible.Text = cantidad.ToString()
                    txtCantidadMovimiento.Text = cantidad.ToString()
                    txtUnidadMedida.Text = unidad
                    txtCantidadMovimiento.Select()
                End If
            Else
                txtCantidadDisponible.Text = String.Empty
                txtCantidadMovimiento.Text = String.Empty
                txtUnidadMedida.Text = String.Empty
            End If
        End If

    End Sub



    Public Sub RecibirUbicacion(ubicacionSelected As String)

        If String.IsNullOrEmpty(txtUbicacion.Text) Then
            txtUbicacion.Text = ubicacionSelected.Trim()

        Else

            If XtraMessageBox.Show("Ya se encuentra una ubicación de destino seleccionada, ¿Desea cambiarla?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                txtUbicacion.Text = ubicacionSelected.Trim()
            End If
        End If




    End Sub




End Class