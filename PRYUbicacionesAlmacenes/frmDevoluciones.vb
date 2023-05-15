Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmDevoluciones

    Private CO As String
    Private ALMACEN As String
    Private ALMRECEPCION As String
    Private ROWID As String = String.Empty
    Private tieneSerial As Boolean = False
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
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

                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""

                XtraTabPage2.PageEnabled = True
                XtraTabPage3.PageEnabled = True
                If encabezado.f300_EstadoDoc = "A" Then
                    Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
                End If
            End If



        Catch ex As Exception
            XtraTabPage2.PageEnabled = False
            XtraTabPage3.PageEnabled = False
            SplashScreenManager.CloseForm(False)

            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""

            ROWID = ""
            txtTipoDoct.Text = ""
            txtNroDocto.Text = ""
            txtEstado.Text = ""
        End Try
    End Sub


    Private Sub frmDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

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

    Private Sub txtCantidadMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadMovimiento.KeyPress
        Utilidades.NumerosyDecimal(txtCantidadMovimiento, e)
    End Sub

    Private Sub txtUbicacion_Leave(sender As Object, e As EventArgs) Handles txtUbicacion.Leave
        If txtUbicacion.Text <> "" Then
            Dim conexion As clsConexionNew = New clsConexionNew()

            Dim sql As String = "select distinct f302_Material,f106_Descripcion from t302_Saldos
                                inner join t106_Materiales on f106_Material = f302_Material
                                where f302_Almacen = '" + ALMACEN + "' and f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Cantidad - f302_CantMvtos > 0"


            Dim dt As New DataTable
            dt = conexion.ObtenerDataTable(sql)
            Dim valoresCombo As New System.Collections.Generic.Dictionary(Of Object, Object)
            For Each drCombo As DataRow In dt.Rows
                valoresCombo.Add(drCombo("f302_Material").ToString(), drCombo("f302_Material").ToString() + "-" + drCombo("f106_Descripcion").ToString())
            Next
            Utilidades.CargarCombo(cboMateriales, valoresCombo, True, "--Seleccione Uno--")



        End If

    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        XtraTabPage2.PageEnabled = True
        XtraTabPage3.PageEnabled = True
        Me.XtraTabControl1.SelectedTabPage = XtraTabPage2

        lblMensaje.Text = ""


        txtCantidadDisponible.Text = ""
        txtCantidadMovimiento.Text = ""
        txt_SerialDevolucion.Text = ""
        txt_SerialDevolucion.Enabled = False
        txt_SerialDevolucion.Visible = False
        lbl_SerialDevo.Visible = False

        ROWID = ""
        txtTipoDoct.Text = ""
        txtNroDocto.Text = ""
        txtEstado.Text = ""
        gcDetalle.DataSource = Nothing
    End Sub

    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateriales.SelectedIndexChanged

        txtCantidadDisponible.Text = ""
        txtCantidadMovimiento.Text = ""

        If cboMateriales.SelectedValue.ToString <> Nothing Then

            Dim valoresCombo As New System.Collections.Generic.Dictionary(Of Object, Object)
            valoresCombo.Add("", "")
            Utilidades.CargarCombo(cboLote, valoresCombo, False, "--Seleccione Uno--")
            cboLote.SelectedIndex = 0
            Dim serialDvp As String

            If cboMateriales.SelectedValue.ToString() <> "0" Then
                Dim conexion As clsConexionNew = New clsConexionNew()
                Dim sql As String = "select distinct f302_Lote from t302_Saldos
                    where f302_Lote <> '' AND f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Material = '" + cboMateriales.SelectedValue.ToString() + "'"


                '****sección, verificar si existe serial del material
                Dim sql2 As String
                sql2 = "select f302_SerialMaterial  from t302_Saldos
                        where f302_Almacen = '" + ALMACEN + "' and f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Material = '" + cboMateriales.SelectedValue.ToString() + "' and f302_Cantidad - f302_CantMvtos > 0"

                serialDvp = conexion.GetEscalar(sql2).ToString()
                If serialDvp <> "" Then
                    tieneSerial = True

                    txt_SerialDevolucion.Enabled = True
                    txt_SerialDevolucion.Visible = True
                    lbl_SerialDevo.Visible = True
                    txt_SerialDevolucion.Text = String.Empty ' serialDvp
                    cboLote.SelectedIndex = 0


                End If
                '****end seccion


                valoresCombo = New System.Collections.Generic.Dictionary(Of Object, Object)
                Dim dtLotes As New DataTable
                dtLotes = conexion.ObtenerDataTable(sql)
                If dtLotes.Rows.Count > 0 Then
                    For Each drCombo As DataRow In dtLotes.Rows
                        valoresCombo.Add(drCombo("f302_Lote").ToString(), drCombo("f302_Lote").ToString())
                    Next
                    Utilidades.CargarCombo(cboLote, valoresCombo, True, "--Seleccione Uno--")
                Else

                    Dim material = cboMateriales.SelectedValue.ToString()
                    sql = "select f302_Cantidad - f302_CantMvtos  from t302_Saldos
                        where f302_Almacen = '" + ALMACEN + "' and f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Material = '" + material + "' and f302_Cantidad - f302_CantMvtos > 0"


                    Dim respuesta As String
                    Dim cantidad As Double = 0
                    Try
                        respuesta = conexion.GetEscalar(sql).ToString()
                        cantidad = CDbl(respuesta)

                    Catch ex As Exception
                        respuesta = "0"
                    End Try

                    'sql = "select SUM(f301_Cantidad) from t300_EncMovimientos
                    '        inner join t301_DetMovimientos on f301_RowIDDocumento = f300_RowID
                    '        where f300_TipoDocumento = 'DVP' and f300_EstadoDoc = 'A' and f301_EstadoMov = 'A'
                    '        and f300_AlmacenOrigen = '" + ALMACEN + "'
                    '        and f301_Referencia = '" + material + "' and f301_Lote = ''"
                    'Dim cantMovimiento As String

                    'cantMovimiento = conexion.GetEscalar(sql).ToString()

                    'If Not String.IsNullOrEmpty(cantMovimiento) Then
                    '    cantidad = cantidad - CDbl(cantMovimiento)
                    'End If

                    txtCantidadDisponible.Text = cantidad.ToString()
                    txtCantidadMovimiento.Text = cantidad.ToString()

                    txtCantidadMovimiento.Select()

                End If


            End If


        End If

    End Sub

    Private Sub cboLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLote.SelectedIndexChanged
        If cboLote.SelectedValue.ToString() <> Nothing Then

            If tieneSerial = False Then

                If cboLote.SelectedValue.ToString() <> "" And cboLote.SelectedValue.ToString() <> "0" Then
                    Dim loteSelect As String = cboLote.SelectedValue.ToString()
                    Dim material = cboMateriales.SelectedValue.ToString()

                    Dim sql As String = "select f302_Cantidad - f302_CantMvtos from t302_Saldos
                     where f302_Almacen = '" + ALMACEN + "' and f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Material = '" + material + "' and f302_Cantidad - f302_CantMvtos > 0"


                    Dim conexion As clsConexionNew = New clsConexionNew()

                    If loteSelect <> "" And loteSelect <> "0" Then
                        'agregar a la consulta, el lote seleccionado
                        sql = sql + " and f302_Lote = '" + loteSelect + "'"


                    Else
                        loteSelect = ""
                    End If


                    Dim respuesta As String
                    Dim cantidad As Double = 0
                    Try
                        respuesta = conexion.GetEscalar(sql).ToString()


                    Catch ex As Exception
                        respuesta = "0"
                        XtraMessageBox.Show("REVISAR CANTIDAD DISPONIBLE DEL MATERIAL EN SALDOS.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End Try


                    If IsNumeric(respuesta) Then
                        cantidad = CDec(respuesta)
                    End If

                    If loteSelect <> "0" Then

                        '    sql = "select SUM(f301_Cantidad) from t300_EncMovimientos
                        'inner join t301_DetMovimientos on f301_RowIDDocumento = f300_RowID
                        'where f300_TipoDocumento = 'DVP' and f300_EstadoDoc = 'A' and f301_EstadoMov = 'A'
                        'and f300_AlmacenOrigen = '" + ALMACEN + "'
                        'and f301_Referencia = '" + material + "' and f301_Lote = '" + loteSelect + "'"
                        '    Dim cantMovimiento As String

                        '    cantMovimiento = conexion.GetEscalar(sql).ToString()

                        'If Not String.IsNullOrEmpty(cantMovimiento) Then
                        '    cantidad = cantidad - CDbl(cantMovimiento)
                        'End If


                        txtCantidadDisponible.Text = cantidad.ToString()
                        txtCantidadMovimiento.Text = cantidad.ToString()
                        txtCantidadMovimiento.Select()
                    Else
                        txtCantidadDisponible.Text = String.Empty
                        txtCantidadMovimiento.Text = String.Empty
                    End If
                End If


            Else

                If txt_SerialDevolucion.Text = "" Then
                    XtraMessageBox.Show("El MATERIAL EXIGE DIGITAR EL SERIAL PARA CONSULTAR EL SALDO DENTRO DEL LOTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else

                    ConsultarSaldo_bySerial(ALMACEN, txtUbicacion.Text, txt_SerialDevolucion.Text)
                End If


            End If



        End If
    End Sub

    Private Sub ConsultarSaldo_bySerial(almacen As String, ubicacion As Object, getSerial As Object)
        'Dim serial_dvp As String
        ' Dim sql2 As String
        If cboLote.SelectedValue.ToString() <> "" And cboLote.SelectedValue.ToString() <> "0" Then
            Dim loteSelect As String = cboLote.SelectedValue.ToString()
            Dim material = cboMateriales.SelectedValue.ToString()

            Dim sql As String = "select f302_Cantidad - f302_CantMvtos from t302_Saldos
                 where f302_Almacen = '" + almacen + "' and f302_Ubicacion = '" + ubicacion.ToString() + "' and f302_Material = '" + material + "' and f302_SerialMaterial = '" + getSerial.ToString() + "' and f302_Cantidad - f302_CantMvtos > 0"

            'sql2 = "select f302_SerialMaterial from t302_Saldos
            '     where f302_Almacen = '" + almacen + "' and f302_Ubicacion = '" + txtUbicacion.Text + "' and f302_Material = '" + material + "' and f302_Cantidad - f302_CantMvtos > 0"

            Dim conexion As clsConexionNew = New clsConexionNew()

            If loteSelect <> "" And loteSelect <> "0" Then
                'agregar a la consulta, el lote seleccionado
                sql = sql + " and f302_Lote = '" + loteSelect + "'"

            Else
                loteSelect = ""
            End If


            Dim respuesta As String
            Dim cantidad As Double = 0
            Try
                respuesta = conexion.GetEscalar(sql).ToString()
                'serial_dvp = conexion.GetEscalar(sql2).ToString()
                'If serial_dvp <> "" Then


                '    txt_SerialDevolucion.Enabled = True
                '    txt_SerialDevolucion.Visible = True
                '    lbl_SerialDevo.Visible = True
                '    txt_SerialDevolucion.Text = String.Empty  'serial_dvp
                '    ' cboLote.SelectedIndex = 0


                'End If

            Catch ex As Exception
                respuesta = "0"
                XtraMessageBox.Show("SERIAL SIN SALDO O NO ENCONTRADO.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try


            If IsNumeric(respuesta) Then
                cantidad = CDec(respuesta)
            End If

            If loteSelect <> "0" Then


                txtCantidadDisponible.Text = cantidad.ToString()
                txtCantidadMovimiento.Text = cantidad.ToString()
                txtCantidadMovimiento.Select()
                'txt_SerialDevolucion.Select()
                'cboLote.SelectedIndex = 0

            Else
                txtCantidadDisponible.Text = String.Empty
                txtCantidadMovimiento.Text = String.Empty
                txt_SerialDevolucion.Text = String.Empty
            End If
        End If


    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        lblMensaje.Text = ""
        Try
            'cboLote.DataSource = Nothing
            'cboLote.Items.Clear()

            If String.IsNullOrEmpty(txtUbicacion.Text) Then
                Throw New ArgumentException("digite la ubicacion origen")
            End If

            If cboMateriales.SelectedValue.ToString() = "0" Then
                Throw New ArgumentException("Seleccione la referencia")
            End If

            If tieneSerial Then
                If String.IsNullOrEmpty(txt_SerialDevolucion.Text) Then
                    Throw New ArgumentException("Debe digitar el serial para guardar operación.")
                End If
            End If

            If txtCantidadDisponible.Text = "" Then
                Throw New ArgumentException("Sin cantidad disponible")
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


            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@co", CO, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@usuario", My.User.Name.ToUpper.Replace("ALIAR\", ""), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@RowId", IIf(ROWID = String.Empty, DBNull.Value, ROWID), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@cantidad", CDbl(txtCantidadMovimiento.Text), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@material", cboMateriales.SelectedValue.ToString(), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@serialDvp", txt_SerialDevolucion.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@almacenOrigen", ALMACEN, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@almacenDestino", ALMRECEPCION, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@ubicacion", txtUbicacion.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@lote", cboLote.Text, SqlDbType.VarChar))
            Dim dt As New DataTable
            dt = conexion.SPObtenerDataTable("SP_GuardarMovimientoDVP", LstParametros)
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
            lblMensaje.Font = New Font("Tahoma", 13, FontStyle.Bold)
            cboMateriales.SelectedIndex = 0
            txt_SerialDevolucion.Text = ""
            txt_SerialDevolucion.Enabled = False
            txt_SerialDevolucion.Visible = False
            lbl_SerialDevo.Visible = False
            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""


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

    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim f As New frmDocumentosDevolucionesProduccion(CO, ALMACEN)
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
                'cboMateriales.SelectedIndex = 0
                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""
                XtraTabPage2.PageEnabled = True
                XtraTabPage3.PageEnabled = True
                If encabezado.f300_EstadoDoc = "A" Then
                    Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
                End If
            End If



        Catch ex As Exception
            XtraTabPage2.PageEnabled = False
            XtraTabPage3.PageEnabled = False
            SplashScreenManager.CloseForm(False)
            'cboMateriales.SelectedIndex = 0
            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""
            ROWID = ""
            txtTipoDoct.Text = ""
            txtNroDocto.Text = ""
            txtEstado.Text = ""
        End Try

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
                    Dim respuesta As String = CStr(conexion.SPGetEscalar("SP_EliminarMovimientosDVP", LstParametros))
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

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If String.IsNullOrEmpty(ROWID) Then
            XtraMessageBox.Show("Error: " + "Ningun documento cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If XtraMessageBox.Show("¿Esta seguro de cerrar el documento?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Dim respuesta As String
            respuesta = EncabezadoMovimiento.CerrarMovimientoDVP(ROWID)
            SplashScreenManager.CloseForm(False)
            If String.IsNullOrEmpty(respuesta) Then

                XtraTabPage2.PageEnabled = False
                XtraTabPage3.PageEnabled = False
                lblMensaje.Text = ""
                txtUbicacion.Text = ""
                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""
                txt_SerialDevolucion.Text = ""
                txt_SerialDevolucion.Enabled = False
                txt_SerialDevolucion.Visible = False
                lblMensaje.Visible = False


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

    Private Sub btnBuscarUbicacion_Click(sender As Object, e As EventArgs) Handles btnBuscarUbicacion.Click
        Dim frmBodegasUbicaciones As FrmBodegas = New FrmBodegas()
        frmBodegasUbicaciones.Solicitud_Ubicacion = True
        frmBodegasUbicaciones.form_solicita = "DEV"
        frmBodegasUbicaciones.ShowDialog()
        frmBodegasUbicaciones.Dispose()
    End Sub

    Public Sub RecibirUbicacion(ubicacionSelected As String)

        If String.IsNullOrEmpty(txtUbicacion.Text) Then
            txtUbicacion.Text = ubicacionSelected.Trim()

        Else

            If XtraMessageBox.Show("Ya se encuentra una ubicación de origen seleccionada, ¿Desea cambiarla?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                txtUbicacion.Text = ubicacionSelected.Trim()
            End If
        End If




    End Sub

End Class