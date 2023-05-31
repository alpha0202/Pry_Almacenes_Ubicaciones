Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen

Public Class frmTrasladosMateriales_Ubicacion

    Private CO As String
    Private ubicacionDestino As Boolean = False
    Private ubicacionOrigen As Boolean = False
    Private ALMACEN As String
    Private ALMRECEPCION As String
    Private ROWID As String = String.Empty
    Private tieneSerial As Boolean = False

    Private Sub frmTrasladosMateriales_Ubicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim user As New Usuarios()
            user = Usuarios.GetUsuario(My.User.Name.ToUpper.Replace("ALIAR\", ""))

            If (user._estado <> "A") Then
                Throw New ArgumentException("Usuario Inactivo")
            End If

            ALMACEN = user._almacen

            txtCO.Text = user._co + "-" + user._desCo
            CO = user._co
            txtFechaProceso.Text = user._fechaProceso.ToString("dd/MM/yyyy")

            ''consultar almacen de recepcion
            Dim a = New Almacenes()
            a = Almacenes.GetAlmacenRecepcion(ALMACEN)

        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try




    End Sub


    Public Sub RecibirUbicacion(ubicacionSelected As String)

        If ubicacionDestino Then

            If String.IsNullOrEmpty(txtUbicacionDestino.Text) Then
                txtUbicacionDestino.Text = ubicacionSelected.Trim()
                CargarMaterialesUbicacion(ubicacionSelected)
                ubicacionDestino = False
            Else


                If XtraMessageBox.Show($"Ya se encuentra una ubicación Destino seleccionada, ¿Desea cambiarla?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    txtUbicacionDestino.Text = ubicacionSelected.Trim()
                    ubicacionDestino = False
                End If
            End If


        ElseIf ubicacionOrigen Then
            Dim iguales As Boolean

            If String.IsNullOrEmpty(txtUbicacionOrigen.Text) Then
                txtUbicacionOrigen.Text = ubicacionSelected.Trim()
                CargarMaterialesUbicacion(ubicacionSelected)
                ubicacionOrigen = False

                iguales = txtUbicacionDestino.Text.Trim().Equals(txtUbicacionOrigen.Text.Trim())
                If iguales Then
                    XtraMessageBox.Show("La ubicación de destino y origen, no pueden se iguales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUbicacionOrigen.Text = ""

                    'Else
                    '    txtUbicacionOrigen.Text = ubicacionSelected.Trim()
                    '    ubicacionOrigen = False

                End If


            Else

                If XtraMessageBox.Show($"Ya se encuentra una ubicación Origen seleccionada, ¿Desea cambiarla?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    txtUbicacionDestino.Text = ubicacionSelected.Trim()
                    ubicacionOrigen = False
                End If


            End If
        End If




    End Sub


    Private Sub CargarMaterialesUbicacion(ubicacion As String)  'método para llenar el combo de materiales.
        'cboBodega.DataSource = Nothing

        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()

            LstParametros.Add(New Parametros("@ubicacion", ubicacion, SqlDbType.VarChar))

            Dim dt As New DataTable
            dt = conexion.SPObtenerDataTable("SP_GetMaterialesxUbicacion", LstParametros)

            Dim valoresCombo As New Dictionary(Of Object, Object)
            For Each drCombo As DataRow In dt.Rows
                valoresCombo.Add(drCombo("f302_Material").ToString(), drCombo("f302_Material").ToString() + "-" + drCombo("f106_Descripcion").ToString())
            Next
            Utilidades.CargarCombo(cboMateriales, valoresCombo, True, "---")


        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConsultarLotes(ubicacion As String)


        txtCantidadDisponible.Text = ""
        txtCantidadMovimiento.Text = ""

        If cboMateriales.SelectedValue.ToString <> Nothing Then

            Dim valoresCombo As New Dictionary(Of Object, Object)
            valoresCombo.Add("", "")
            Utilidades.CargarCombo(cboLote, valoresCombo, False, "----")
            cboLote.SelectedIndex = 0

            If cboMateriales.SelectedValue.ToString() <> "0" Then
                Dim conexion As clsConexionNew = New clsConexionNew()
                Dim sql As String = "select distinct f302_Lote from t302_Saldos
                    where f302_Lote <> '' AND f302_Ubicacion = '" + ubicacion.Trim() + "' and f302_Material = '" + cboMateriales.SelectedValue.ToString() + "'"


                '****sección, verificar si existe serial del material
                Dim sql2 As String
                sql2 = "select f302_SerialMaterial  from t302_Saldos
                        where   f302_SerialMaterial <> '' and f302_Ubicacion = '" + ubicacion.Trim() + "' and f302_Material = '" + cboMateriales.SelectedValue.ToString() + "'"

                'Dim serialMat As String = conexion.GetEscalar(sql2).ToString()
                Dim serialMat As DataTable = conexion.ObtenerDataTable(sql2)
                If serialMat.Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = serialMat.Rows(0)
                    Dim campoSerial = dr.ToString()
                    If campoSerial <> "" Then

                        tieneSerial = True

                        txt_SerialMaterial.Enabled = True
                        txt_SerialMaterial.Visible = True
                        lbl_SerialMat.Visible = True
                        txt_SerialMaterial.Text = String.Empty ' serialMaterial
                        cboLote.SelectedIndex = 0
                    End If


                End If
                '****end seccion


                valoresCombo = New Dictionary(Of Object, Object)
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
                        where  f302_Ubicacion = '" + ubicacion.Trim() + "' and f302_Material = '" + material + "' and f302_Cantidad - f302_CantMvtos > 0"


                    Dim respuesta As String
                    Dim cantidad As Double = 0
                    Try
                        respuesta = conexion.GetEscalar(sql).ToString()
                        cantidad = CDbl(respuesta)

                    Catch ex As Exception
                        respuesta = "0"
                    End Try


                    txtCantidadDisponible.Text = cantidad.ToString()
                    txtCantidadMovimiento.Text = cantidad.ToString()

                    txtCantidadMovimiento.Select()

                End If


            End If


        End If






    End Sub


    Private Sub CargaData_lotesEncontrados(ubicacion As String)
        If cboLote.SelectedValue.ToString() <> Nothing Then

            If tieneSerial = False Then

                If cboLote.SelectedValue.ToString() <> "" And cboLote.SelectedValue.ToString() <> "0" Then
                    Dim loteSelect As String = cboLote.SelectedValue.ToString()
                    Dim material = cboMateriales.SelectedValue.ToString()

                    Dim sql As String = "select f302_Cantidad - f302_CantMvtos from t302_Saldos
                     where f302_Ubicacion = '" + ubicacion.Trim() + "' and f302_Material = '" + material + "' and f302_Cantidad - f302_CantMvtos > 0"


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

                If txt_SerialMaterial.Text = "" Then
                    XtraMessageBox.Show("El MATERIAL EXIGE DIGITAR EL SERIAL PARA CONSULTAR EL SALDO DENTRO DEL LOTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    txt_SerialMaterial.Text = String.Concat("0000000000", txt_SerialMaterial.Text.Trim())
                    ConsultarSaldo_bySerial(ubicacion.Trim(), txt_SerialMaterial.Text)
                End If


            End If



        End If
    End Sub

    Private Sub ConsultarSaldo_bySerial(ubicacion As Object, getSerial As Object)
        'Dim serial_dvp As String
        ' Dim sql2 As String

        Try
            If cboLote.SelectedValue.ToString() <> "" And cboLote.SelectedValue.ToString() <> "0" Then
                Dim loteSelect As String = cboLote.SelectedValue.ToString()
                Dim material = cboMateriales.SelectedValue.ToString()

                If getSerial Is String.Empty Then
                    Throw New ArgumentException("Debe digitar el serial para realizar consulta.")
                End If

                SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

                Dim sql As String = "select f302_Cantidad - f302_CantMvtos from t302_Saldos
                 where f302_Ubicacion = '" + ubicacion.ToString() + "' and f302_Material = '" + material + "' and f302_SerialMaterial = '" + getSerial.ToString() + "' and f302_Cantidad - f302_CantMvtos > 0"


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
                    'XtraMessageBox.Show("SERIAL SIN SALDO O NO ENCONTRADO.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Throw New ArgumentException("SERIAL SIN SALDO O NO ENCONTRADO.")

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
                    txt_SerialMaterial.Text = String.Empty
                End If

                SplashScreenManager.CloseForm(False)
            End If

        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub GuardarMovimientoTRU()

        'lblMensaje.Text = ""
        Try
            'cboLote.DataSource = Nothing
            'cboLote.Items.Clear()
            Dim serialMat_digitado As String

            If String.IsNullOrEmpty(txtUbicacionOrigen.Text) Then
                Throw New ArgumentException("digite la ubicacion origen")
            End If


            If String.IsNullOrEmpty(txtUbicacionDestino.Text) Then
                Throw New ArgumentException("digite la ubicacion destino")
            End If

            If cboMateriales.SelectedValue.ToString() = "0" Then
                Throw New ArgumentException("Seleccione el material")
            End If

            If tieneSerial Then
                If String.IsNullOrEmpty(txt_SerialMaterial.Text) Then
                    Throw New ArgumentException("Debe digitar el serial para guardar la operación.")
                Else
                    serialMat_digitado = String.Concat("0000000000", txt_SerialMaterial.Text)
                End If
            Else
                serialMat_digitado = ""
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
                Throw New ArgumentException("Cantidad movimiento no valida")
            End If


            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@co", CO, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@usuario", My.User.Name.ToUpper.Replace("ALIAR\", ""), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@RowId", IIf(ROWID = String.Empty, DBNull.Value, ROWID), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@cantidad", CDbl(txtCantidadMovimiento.Text), SqlDbType.Decimal))
            LstParametros.Add(New Parametros("@material", cboMateriales.SelectedValue.ToString(), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@serialMaterial", txt_SerialMaterial.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@almacenOrigen", ALMACEN, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@almacenDestino", ALMACEN, SqlDbType.VarChar)) 'almacen de origen y destino deben ser el mismo por tratarse de un traslado de ubicación
            LstParametros.Add(New Parametros("@ubicacionOrigen", txtUbicacionOrigen.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@ubicacionDestino", txtUbicacionDestino.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@lote", cboLote.Text, SqlDbType.VarChar))
            Dim dt As New DataTable
            dt = conexion.SPObtenerDataTable("SP_GuardarMovimientoTRU", LstParametros)
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

            lblMensaje.Text = "Procesado Correctamente"
            lblMensaje.Font = New Font("Tahoma", 13, FontStyle.Bold)
            cboMateriales.SelectedIndex = 0
            txt_SerialMaterial.Text = ""
            txt_SerialMaterial.Enabled = False
            txt_SerialMaterial.Visible = False
            lbl_SerialMat.Visible = False
            txtUbicacionDestino.Text = ""
            txtUbicacionOrigen.Text = ""
            txtCantidadDisponible.Text = ""
            txtCantidadMovimiento.Text = ""


            Dim valoresCombo As New Dictionary(Of Object, Object)
            valoresCombo.Add("", "")
            Utilidades.CargarCombo(cboLote, valoresCombo, False, "---")
            cboLote.SelectedIndex = 0

            SplashScreenManager.CloseForm(False)

        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try






    End Sub

    Private Sub CerrarMovimientoTRU()
        If String.IsNullOrEmpty(ROWID) Then
            XtraMessageBox.Show("Error: " + "Ningun documento cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If XtraMessageBox.Show("¿Esta seguro de cerrar el documento?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Dim respuesta As String
            respuesta = EncabezadoMovimiento.CerrarMovimientoTRU(ROWID)
            SplashScreenManager.CloseForm(False)
            If String.IsNullOrEmpty(respuesta) Then

                XtraTabPage2.PageEnabled = False
                XtraTabPage4.PageEnabled = False
                lblMensaje.Text = ""
                txtUbicacionDestino.Text = ""
                txtUbicacionOrigen.Text = ""
                txtCantidadDisponible.Text = ""
                txtCantidadMovimiento.Text = ""
                txt_SerialMaterial.Text = ""
                txt_SerialMaterial.Enabled = False
                txt_SerialMaterial.Visible = False
                lblMensaje.Visible = False


                ROWID = ""
                txtTipoDoct.Text = ""
                txtNroDocto.Text = ""
                txtEstado.Text = ""
                gcDetalle.DataSource = Nothing
                XtraMessageBox.Show("Se proceso correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                XtraMessageBox.Show("Error: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If
    End Sub


    Private Sub EliminarMovimiento()
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
                    Dim respuesta As String = CStr(conexion.SPGetEscalar("SP_EliminarMovimientosTRU", LstParametros))
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

    Private Sub btnBuscarUbicacion_Click(sender As Object, e As EventArgs) Handles btnBuscarUbicacion.Click

        ubicacionDestino = True
        Utilidades.BuscarUbicacion("TRU")

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        If String.IsNullOrEmpty(txtUbicacionDestino.Text) Then
            XtraMessageBox.Show("Se debe selecciona una ubicación de destino.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            XtraTabPage2.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            Me.XtraTabControl1.SelectedTabPage = XtraTabPage2

        End If



    End Sub

    Private Sub btnBuscarUbiOrigen_Click(sender As Object, e As EventArgs) Handles btnBuscarUbiOrigen.Click
        ubicacionOrigen = True
        Utilidades.BuscarUbicacion("TRU")
        'Utilidades.ExisteUbicacionSeleccionada(txtUbicacionOrigen.Text.Trim())

    End Sub


    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateriales.SelectedIndexChanged
        ConsultarLotes(txtUbicacionOrigen.Text)
    End Sub

    Private Sub cboLote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLote.SelectedIndexChanged
        ConsultarSaldo_bySerial(txtUbicacionOrigen, txt_SerialMaterial.Text.Trim())
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarMovimientoTRU()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim f As New frmDocumentosTrasladosUbicaciones(CO, ALMACEN)
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
                XtraTabPage4.PageEnabled = True
                If encabezado.f300_EstadoDoc = "A" Then
                    Me.XtraTabControl1.SelectedTabPage = XtraTabPage2
                End If
            End If



        Catch ex As Exception
            XtraTabPage2.PageEnabled = False
            XtraTabPage4.PageEnabled = False
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        CerrarMovimientoTRU()
    End Sub

    Private Sub btnEliminarMovimientos_Click(sender As Object, e As EventArgs) Handles btnEliminarMovimientos.Click
        EliminarMovimiento()
    End Sub

    'Private Sub txtUbicacionOrigen_Leave(sender As Object, e As EventArgs) Handles txtUbicacionOrigen.Leave
    '    If String.IsNullOrEmpty(txtUbicacionOrigen.Text) Then
    '        XtraMessageBox.Show("El campo está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        txtUbicacionOrigen.Select()
    '    Else
    '        Utilidades.ExisteUbicacionSeleccionada(txtUbicacionOrigen.Text.Trim())
    '    End If
    'End Sub

    'Private Sub txtUbicacionOrigen_Leave(sender As Object, e As EventArgs)
    '    CargarMaterialesUbicacion(txtUbicacionOrigen.Text)
    'End Sub
End Class