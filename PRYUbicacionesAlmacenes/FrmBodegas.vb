Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports Newtonsoft.Json

Public Class FrmBodegas
    Dim conexion As clsConexionNew = New clsConexionNew()
    Dim dt As DataTable
    Dim ds As DataSet
    Dim dtColumnas As DataTable
    Dim dtFilas As DataTable
    Dim dtFilasUbicaciones As DataTable
    Dim dtCelda As DataTable
    Dim dtPosicion As DataTable
    Dim dtJCelda As DataTable
    Dim dtTotalOrdenCel As DataTable
    Private listaCeldas As List(Of FlowLayoutPanel) = New List(Of FlowLayoutPanel)
    Public Solicitud_Ubicacion As Boolean = False
    Public form_solicita As String = String.Empty

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
        'llenarCboCentroOper()
        'CargarMateriales()
        'Me.Solicitud_Ubicacion = solicitaUbi


    End Sub




    'Pintado completo de todas las ubicaciones con las diferentes columnas y filas.
    'Private Sub PintarBodega(celdas As List(Of Celdas), columnas As List(Of Columna), filas As List(Of Filas), totalFilas As Integer, dtColumna As DataTable, dtFila As DataTable, dtTotalOrdenCelda As DataTable)

    '    Dim nombreCol As String

    '    'Encabezados de las columnas
    '    For i = 0 To columnas.Count - 1

    '        nombreCol = CStr(dtColumna.Rows(i)("columnas"))

    '        Dim label As New Label With {
    '            .Text = nombreCol,
    '            .AutoSize = False,
    '            .Height = flpColumnas.Height,
    '            .Width = (flpGrupoCeldas.Width / columnas.Count) - 20,
    '            .TextAlign = ContentAlignment.MiddleCenter,
    '            .Font = New Font("Microsoft New Tai Lue", 13, FontStyle.Regular),
    '            .BackColor = Color.FromArgb(205, 205, 205)
    '        }

    '        flpColumnas.Controls.Add(label)
    '    Next

    '    'Encabezados de las filas
    '    For y = 0 To totalFilas - 1

    '        'nombreFila = CStr(dtFila.Rows(y)("fila"))
    '        Dim label As New Label With {
    '            .Text = y + 1,
    '            .AutoSize = False,
    '            .Height = 60,
    '            .Width = flpFilas.Width,
    '            .TextAlign = ContentAlignment.MiddleCenter,
    '            .Font = New Font("Microsoft New Tai Lue", 11, FontStyle.Regular),
    '            .BackColor = Color.FromArgb(205, 205, 205)
    '        }
    '        flpFilas.Controls.Add(label)
    '    Next


    '    'Celdas
    '    For j = 0 To totalFilas - 1


    '        Dim flpFila As New FlowLayoutPanel With {
    '            .Dock = DockStyle.None,
    '            .Width = flpGrupoCeldas.Width,
    '            .Height = 55
    '        }

    '        flpGrupoCeldas.Controls.Add(flpFila)

    '        For i = 0 To columnas.Count - 1
    '            nombreCol = CStr(dtColumna.Rows(i)("columnas"))
    '            'Agregamos la celda especifica
    '            Dim flpCell As New FlowLayoutPanel With {
    '                .Dock = DockStyle.None,
    '                .Width = (flpFila.Width / columnas.Count) - 20,
    '                .Height = 50,
    '                .BackColor = IIf(ExisteCelda(celdas, nombreCol, j + 1), IIf((i + j) Mod 2 = 0, Color.Transparent, Color.Transparent), Color.Transparent)
    '            }

    '            flpFila.Controls.Add(flpCell)
    '            listaCeldas.Add(flpCell)


    '            Dim celda As Celdas = GetCelda(celdas, nombreCol, j + 1)
    '            If celda IsNot Nothing Then
    '                'Agregar los botones
    '                'Dim totFilas As DataRow = dtFilas.Rows(dtFilas.Rows.Count - 1)
    '                'Dim totalFilaCel = totFilas.Field(Of Integer)(0)

    '                'Dim totalOrden = CInt(dtTotalOrdenCel.Rows(i)("total_orden"))
    '                ' k = 0 To totalOrden - 1
    '                For k = 0 To celda.CantidadPosiciones - 1

    '                    Dim posicion As Posiciones = celda.Posiciones.Find(Function(p) p.Orden = k + 1)
    '                    If posicion IsNot Nothing Then
    '                        'Se pinta el botón
    '                        Dim btn As New Button With {
    '                            .Text = posicion.Nombre,
    '                            .Height = flpCell.Height - 10,
    '                            .Width = (flpCell.Width / celda.CantidadPosiciones) - 30,
    '                            .TextAlign = ContentAlignment.MiddleCenter,
    '                            .BackColor = IIf(ExisteMaterial(posicion), Color.FromArgb(110, 155, 235), Color.FromArgb(200, 216, 228))
    '                        }
    '                        flpCell.Controls.Add(btn)
    '                        SetClickBotonPosicion(btn, Sub(sender, args)
    '                                                       'ClickBotonPosicion(posicion)
    '                                                       MostrarMaterial(sender, args, posicion)
    '                                                   End Sub)

    '                    Else
    '                        'Se deja el espacio
    '                        Dim label As New Label With {
    '                            .Text = "",
    '                            .BackColor = Color.Transparent,
    '                            .Height = flpCell.Height - 5,
    '                            .Width = (flpCell.Width / celda.CantidadPosiciones) - 10
    '                        }

    '                        flpCell.Controls.Add(label)
    '                    End If

    '                Next
    '            End If
    '        Next

    '    Next

    '    btnRestablecer.Visible = False
    '    btnRestablecer.Enabled = False
    '    chkRestablece.Checked = False


    'End Sub

    Private Sub SetClickBotonPosicion(boton As Button, eventoClick As Action(Of Object, EventArgs))
        If eventoClick IsNot Nothing Then
            AddHandler boton.Click, AddressOf eventoClick.Invoke

        End If
    End Sub

    Private Sub ClickBotonPosicion(posicion As Posiciones)
        MessageBox.Show(posicion.Nombre)

    End Sub

    Private Function ExisteCelda(celdas As List(Of Celdas), columna As String, fila As Integer) As Boolean
        Return GetCelda(celdas, columna, fila) IsNot Nothing
    End Function

    Private Function GetCelda(celdas As List(Of Celdas), columna As String, fila As Integer)
        Return celdas.Find(Function(c) c.Fila = fila And c.Columna = columna)
    End Function

    Private Function ExisteMaterial(posicion As Posiciones) As Boolean

        Dim ubicacion = posicion.Nombre.ToString()

        Dim LstParametros As New List(Of Parametros)()
        LstParametros.Add(New Parametros("@ubicacion", ubicacion, SqlDbType.VarChar))
        Dim dt As DataTable = New DataTable
        dt = conexion.SPObtenerDataTable("SP_GetMaterialesxUbicacion", LstParametros)
        Dim result = dt.Rows.Count

        Return result
    End Function


    Private Function GetPosiciones(columna As String, fila As Integer) As List(Of Posiciones)
        Dim listPos As List(Of Posiciones) = New List(Of Posiciones)()


        Dim dtFilteredTable As DataTable = dtCelda.AsEnumerable().Where(Function(a) Equals(Convert.ToString(a("f105_Columna")), columna) And Equals(Convert.ToInt32(a("f105_Fila")), fila)).CopyToDataTable()

        For pos As Integer = 0 To dtFilteredTable.Rows.Count - 1
            listPos.Add(New Posiciones With
            {.Columna = CStr(dtFilteredTable.Rows(pos)("f105_Columna")),
             .Fila = CInt(dtFilteredTable.Rows(pos)("f105_Fila")),
             .Orden = CInt(dtFilteredTable.Rows(pos)("f105_Posicion")),
             .Nombre = CStr(dtFilteredTable.Rows(pos)("f105_Ubicaciones")),
             .Descripcion = CStr(dtFilteredTable.Rows(pos)("f105_Descripcion")),
             .Co = CStr(dtFilteredTable.Rows(pos)("f105_Ubicaciones"))
            }
            )
        Next
        Return listPos



    End Function


    Private Sub FrmBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarCboCentroOper()
        CargarMateriales()
        chkRestablece.Visible = False
        ''CargueUbicaciones()


    End Sub



    Private Sub cboCentroOpe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCentroOpe.SelectedIndexChanged

        If cboCentroOpe.SelectedValue.ToString() <> "0" Then
            txtCentroOpe.Text = cboCentroOpe.SelectedValue.ToString()
            CargarAlmacen()
            cboBodega.Focus()
        End If


    End Sub

    Private Sub CargarAlmacen()
        cboBodega.DataSource = Nothing
        SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim sql As String = "select f104_Descripcion, f104_Almacen from t104_Almacenes where f104_CO = '" + cboCentroOpe.Text + "' and f104_Recepcion = 0 "
            conexion.CargarCombo(cboBodega, sql, True, "----")
            SplashScreenManager.CloseForm(False)
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBodega.SelectedIndexChanged
        If cboBodega.DataSource Is Nothing Then
            txtBodega.Text = ""
        ElseIf cboBodega.SelectedValue.ToString = "0" Then
            txtBodega.Text = ""
        Else
            txtBodega.Text = cboBodega.SelectedValue.ToString() 

            btnFiltrar.Enabled = True

        End If
    End Sub

    Private Sub llenarCboCentroOper() 'llenar combo de centro operativo 
        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim user As New Usuarios()
            user = Usuarios.GetUsuario(My.User.Name.ToUpper.Replace("ALIAR\", ""))
            Dim sql As String = "select pco.f103_DescripcionCO,f102_CO from t102_Usuarios inner join t103_ParametrosCO pco on pco.f103_CO = t102_Usuarios.f102_CO" +
                                " where f102_Usuario = '" + user._usuario + "' and f102_Estado = 'A'"
            conexion.CargarCombo(cboCentroOpe, sql, True, "----")
        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarMateriales()  'método para llenar el combo de materiales.
        'cboBodega.DataSource = Nothing

        Try
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim sql As String = "SELECT [f106_Material], [f106_Descripcion]  FROM [UBICACIONES].[dbo].[t106_Materiales] "
            conexion.CargarCombo(cboMateriales, sql, True, "----")



        Catch ex As Exception
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboMateriales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMateriales.SelectedIndexChanged

        Dim selectedMat As String
        Dim ds As DataSet

        If cboMateriales.DataSource Is Nothing Then

            txtMaterial.Text = ""


        ElseIf cboMateriales.SelectedValue.ToString() = "0" Then
            'LimpiarControles()
            'CargueUbicaciones()
            txtMaterial.Text = ""


        Else
            txtMaterial.Text = cboMateriales.SelectedValue.ToString()
            selectedMat = txtMaterial.Text
            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Material", selectedMat, SqlDbType.VarChar))
            ds = conexion.SPGetDataSet("SP_Buscar_Material_ubicaciones", LstParametros) 'buscar materiales entre las ubicaciones
            LimpiarControles()
            DiseñoAlmacenes(ds)
            txtCentroOpe.Text = ""
            'cboCentroOpe.SelectedIndex = 0
            'cboBodega.SelectedValue = 0


        End If

    End Sub


    Private Sub MostrarMaterial(sender As Object, e As System.EventArgs, posicion As Posiciones) 'Mostrar en formulario splash, el contenido de la ubicación.
        Try
            'SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Dim ubicacionName = posicion.Nombre
            Dim ubicacionDesc = posicion.Descripcion
            Dim form_Solicitante As String = ""

            If Not Solicitud_Ubicacion Then
                Dim conexion As New clsConexionNew()
                Dim LstParametros As New List(Of Parametros)()
                LstParametros.Add(New Parametros("@ubicacion", ubicacionName, SqlDbType.VarChar))
                Dim dt As New DataTable
                dt = conexion.SPObtenerDataTable("SP_GetMaterialesxUbicacion", LstParametros)


                SplashScreenManager.CloseForm(False)
                Dim f As frmProductosUbicacion = New frmProductosUbicacion(dt, ubicacionName, ubicacionDesc)
                f.ShowDialog()
                f.Dispose()

            Else
                'seleccionar la ubicación según el tipo de solicitud ( form, origen, destino)
                If form_solicita = "REC" Then
                    form_Solicitante = "Recepción"
                    frmRecepcion.RecibirUbicacion(posicion.Nombre)

                ElseIf form_solicita = "DEV" Then
                    form_Solicitante = "Devolución"
                    frmDevoluciones.RecibirUbicacion(posicion.Nombre)

                ElseIf form_solicita = "TRU" Then
                    form_Solicitante = "Traslado Ubicación"
                    frmTrasladosMateriales_Ubicacion.RecibirUbicacion(posicion.Nombre)

                ElseIf form_solicita = "TRA" Then
                    form_Solicitante = "Traslado Ubicación, otro almacen."
                    frmTrasladoAlmacenesDiferentes.RecibirUbicacion(posicion.Nombre)


                End If

                XtraMessageBox.Show($"Ubicación Seleccionada {posicion.Nombre}, solicitado por {form_Solicitante}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            End If


        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub




    Private Sub DiseñoAlmacenes(ds As DataSet)

        'verificar si la consulta de elementos para diseñar, no tiene registros.
        'dt = ds.Tables(0)
        'If (dt.Rows.Count = 0) Then
        '    MessageBox.Show("No existe material en las ubicaciones para mostrar.", "Información")
        '    Return
        'End If

        'extracción de datos por cada datatable
        dtCelda = ds.Tables(0)
        dtPosicion = ds.Tables(1)
        dtColumnas = ds.Tables(2)
        dtFilas = ds.Tables(3)
        'dtTotalOrdenCel = ds.Tables(3)
        'dtFilasUbicaciones = ds.Tables(6)


        'columnas
        Dim listCol As List(Of Columna) = New List(Of Columna)()

        For col As Integer = 0 To dtColumnas.Rows.Count - 1
            listCol.Add(New Columna With
                {.Columnas = CStr(dtColumnas.Rows(col)("columnas"))
                })
        Next
        listCol.ToArray()
        Dim jsColumna = JsonConvert.SerializeObject(listCol)
        'Dim parsejson As JObject = JObject.Parse(jsColumna)
        Dim dsCol As List(Of Columna) = JsonConvert.DeserializeObject(Of List(Of Columna))(jsColumna)
        '-----

        'filas
        Dim totalFilas As Integer = CInt(dtFilas.Rows(0)(0).ToString())

        Dim listFila As List(Of Filas) = New List(Of Filas)()
        For row As Integer = 1 To totalFilas
            listFila.Add(New Filas With
                {.Filas = row
                })
        Next
        listFila.ToArray()
        Dim jsRows = JsonConvert.SerializeObject(listFila)
        Dim dsRows As List(Of Filas) = JsonConvert.DeserializeObject(Of List(Of Filas))(jsRows)
        '-------


        'celda
        Dim listCel As List(Of Celdas) = New List(Of Celdas)()
        For cel As Integer = 0 To dtPosicion.Rows.Count - 1
            listCel.Add(New Celdas With
                {
                 .Columna = CStr(dtPosicion.Rows(cel)("f105_Columna")),
                 .Fila = CInt(dtPosicion.Rows(cel)("f105_Fila")),
                 .CantidadPosiciones = CInt(dtPosicion.Rows(cel)("cantPosiciones")),
                 .Posiciones = GetPosiciones(CStr(dtPosicion.Rows(cel)("f105_Columna")), CInt(dtPosicion.Rows(cel)("f105_Fila")))
                }
                )
        Next
        Dim jsCel As String = JsonConvert.SerializeObject(listCel, Formatting.Indented)
        Dim dsCel As List(Of Celdas) = JsonConvert.DeserializeObject(Of List(Of Celdas))(jsCel)
        '-------

        ModelarUbicaciones(dsCel, dsCol, dsRows, totalFilas, dtColumnas, dtFilas, dtTotalOrdenCel)

    End Sub


    'Private Sub CargueUbicaciones()
    '    'cargue de entrada del formulario. Trae toda la información de ubicaciones
    '    ds = conexion.SPGetDataSet("SP_UBICACIONES")
    '    dtColumnas = ds.Tables(0)
    '    dtFilas = ds.Tables(1)
    '    dtCelda = ds.Tables(2)
    '    dtPosicion = ds.Tables(3)
    '    dtJCelda = ds.Tables(4)
    '    dtTotalOrdenCel = ds.Tables(5)

    '    ''tratamiento columnas *************************************
    '    ''pasar de datatable a array para las el campo columna
    '    'Dim allAutoCompletes = From row In dtColumnas.AsEnumerable()
    '    '                       Let autoComplete = row.Field(Of String)(0)
    '    '                       Select autoComplete
    '    'Dim arrayColumnas As String() = allAutoCompletes.ToArray()
    '    ''serializar el array
    '    'Dim jsonColumna = JsonConvert.SerializeObject(arrayColumnas)
    '    '' Dim columnas As List(Of Columnas) = JsonConvert.DeserializeObject(Of List(Of Columnas))(jsonColumna)
    '    'Dim resultCol = RegularExpressions.Regex.Unescape(jsonColumna)
    '    ''**********************************************************


    '    'columnas
    '    Dim listCol As List(Of Columna) = New List(Of Columna)()

    '    For col As Integer = 0 To dtColumnas.Rows.Count - 1
    '        listCol.Add(New Columna With
    '        {.Columnas = CStr(dtColumnas.Rows(col)("columnas"))
    '        }
    '        )
    '    Next
    '    listCol.ToArray()
    '    Dim jsColumna = JsonConvert.SerializeObject(listCol)
    '    'Dim parsejson As JObject = JObject.Parse(jsColumna)
    '    Dim dsCol As List(Of Columna) = JsonConvert.DeserializeObject(Of List(Of Columna))(jsColumna)


    '    'filas
    '    Dim jsonFila2 As DataRow = dtFilas.Rows(dtFilas.Rows.Count - 1)
    '    Dim totalFilas = jsonFila2.Field(Of Integer)(0)

    '    'filas class

    '    Dim listFila As List(Of Filas) = New List(Of Filas)()
    '    For row As Integer = 0 To dtFilas.Rows.Count - 1
    '        listFila.Add(New Filas With
    '            {.Filas = CInt(dtFilas.Rows(row)("filas"))
    '            })
    '    Next
    '    listFila.ToArray()
    '    Dim jsRows = JsonConvert.SerializeObject(listFila)
    '    Dim dsRows As List(Of Filas) = JsonConvert.DeserializeObject(Of List(Of Filas))(jsRows)



    '    'celda
    '    Dim listCel As List(Of Celdas) = New List(Of Celdas)()
    '    For cel As Integer = 0 To dtCelda.Rows.Count - 1
    '        listCel.Add(New Celdas With
    '        {
    '         .Columna = CStr(dtCelda.Rows(cel)("columna")),
    '         .Fila = CInt(dtCelda.Rows(cel)("fila")),
    '         .CantidadPosiciones = CInt(dtCelda.Rows(cel)("cantidad_posiciones")),
    '         .Posiciones = GetPosiciones(CStr(dtCelda.Rows(cel)("columna")), CInt(dtCelda.Rows(cel)("fila")))
    '        }
    '        )
    '    Next
    '    Dim jsCel As String = JsonConvert.SerializeObject(listCel, Formatting.Indented)
    '    Dim dsCel As List(Of Celdas) = JsonConvert.DeserializeObject(Of List(Of Celdas))(jsCel)



    '    'tratamiento filas    *************************************
    '    'pasar de datatable a array para las el campo columna
    '    'Dim allAutoCompletesRow = From row In dtFilas.AsEnumerable()
    '    '                          Let autoComplete = CStr(row.Field(Of Integer)(0))
    '    '                          Select autoComplete
    '    'Dim arrayFilas As String() = allAutoCompletesRow.ToArray()
    '    ''serializar el array
    '    'Dim jsonFilas = JsonConvert.SerializeObject(arrayFilas)
    '    '**********************************************************

    '    'tratamiento columnas *************************************
    '    'pasar de datatable a array para las el campo columna
    '    'Dim allAutoCompletesJCeldas = From row In dtJCelda.AsEnumerable()
    '    '                              Let autoComplete = row.Field(Of String)(0)
    '    '                              Select autoComplete
    '    'Dim arrayJCeldas As String() = allAutoCompletesJCeldas.ToArray()
    '    ''serializar el array
    '    'Dim jsonJCelda = JsonConvert.SerializeObject(arrayJCeldas)
    '    'jsonJCelda.Replace("\", "")
    '    'Dim jarregloFila = JArray.Parse(jsonJCelda)

    '    'Dim result = RegularExpressions.Regex.Unescape(jsonJCelda)
    '    'result.Remove(5, 2)


    '    'Dim totalColumnas = dtColumnas.Rows.Count()
    '    'Dim jsonFila As DataRow = dtFilas.Rows(dtFilas.Rows.Count - 1)
    '    'Dim totalFilas As Integer = dtFilas.Rows(dtFilas.Rows.Count - 1)
    '    'Dim jsonPosicion As String
    '    'Dim jsonCelda As String

    '    'Dim columnas As List(Of UbicacionesBodegas) = JsonConvert.DeserializeObject(Of List(Of UbicacionesBodegas))(jsonColumna)
    '    'Dim fila As UbicacionesBodegas = CType(JsonConvert.DeserializeObject(filaStr), UbicacionesBodegas)
    '    ' Dim columnas As List(Of Celdas) = JsonConvert.DeserializeObject(Of List(Of Celdas))(jsonColumna)

    '    'Dim posiciones As List(Of Posiciones) = JsonConvert.DeserializeObject(Of List(Of Posiciones))(jsonPosicion)
    '    'Dim dsUbicaciones As UbicacionesBodegas = JsonConvert.DeserializeObject(Of UbicacionesBodegas)(jsonColumna)

    '    'Ejecutamos Funcion
    '    PintarBodega(dsCel, dsCol, dsRows, totalFilas, dtColumnas, dtFilas, dtTotalOrdenCel)


    'End Sub





    'dibuja las ubicaciones a partir de los filtros. 
    Private Sub ModelarUbicaciones(celdas As List(Of Celdas), columnas As List(Of Columna), filas As List(Of Filas), totalFilas As Integer, dtColumna As DataTable, dtFila As DataTable, dtTotalOrdenCelda As DataTable)

        Dim nombreCol As String

        'Encabezados de las columnas
        For i = 0 To columnas.Count - 1

            nombreCol = CStr(dtColumna.Rows(i)("columnas"))

            Dim label As New Label With {
                .Text = nombreCol,
                .AutoSize = False,
                .Height = flpColumnas.Height,
                .Width = (flpGrupoCeldas.Width / columnas.Count) - 30,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Microsoft New Tai Lue", 13, FontStyle.Regular),
                .BackColor = Color.FromArgb(205, 205, 205)   'Color.FromArgb(52, 135, 99)
            }

            flpColumnas.Controls.Add(label)
        Next

        'Encabezados de las filas
        For y = 0 To totalFilas - 1

            Dim label As New Label With {
                .Text = y + 1,
                .AutoSize = False,
                .Height = 60,
                .Width = flpFilas.Width,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Microsoft New Tai Lue", 11, FontStyle.Regular),
                .BackColor = Color.FromArgb(205, 205, 205)  'Color.FromArgb(52, 135, 99)
            }
            flpFilas.Controls.Add(label)
        Next


        'Celdas

        For j = 0 To totalFilas - 1

            Dim flpFila As New FlowLayoutPanel With {
                .Dock = DockStyle.None,
                .Width = (flpGrupoCeldas.Width),
                .Height = 55
            }


            flpGrupoCeldas.Controls.Add(flpFila)

            For i = 0 To columnas.Count - 1
                nombreCol = CStr(dtColumna.Rows(i)("columnas"))
                'Agregamos la celda especifica
                Dim flpCell As New FlowLayoutPanel With {
                    .Dock = DockStyle.None,
                    .Width = (flpFila.Width / columnas.Count) - 30,
                    .Height = 50,
                    .BackColor = IIf(ExisteCelda(celdas, nombreCol, j + 1), IIf((i + j) Mod 2 = 0, Color.Transparent, Color.Transparent), Color.Transparent)
                }

                flpFila.Controls.Add(flpCell)
                listaCeldas.Add(flpCell)


                Dim celda As Celdas = CType(GetCelda(celdas, nombreCol, j + 1), Celdas)
                If celda IsNot Nothing Then
                    'Agregar los botones
                    Dim po As Posiciones = celda.Posiciones.FirstOrDefault


                    Dim iteradorCantidadPosiciones As Integer = po.Orden
                    If iteradorCantidadPosiciones > celda.CantidadPosiciones Then

                        celda.CantidadPosiciones = iteradorCantidadPosiciones

                    End If




                    For k = 0 To celda.CantidadPosiciones - 1

                            Dim itera As Integer = k
                            Dim posicion As Posiciones = celda.Posiciones.Find(Function(p) p.Orden = itera + 1)
                            If posicion IsNot Nothing Then
                                'Se pinta el botón
                                Dim btn As New Button With {
                                .Text = posicion.Nombre,
                                .Height = flpCell.Height - 5,
                                .Width = IIf(celda.CantidadPosiciones > 1, (flpCell.Width / celda.CantidadPosiciones) - 10, (flpCell.Width / celda.CantidadPosiciones) - 30),
                                .TextAlign = ContentAlignment.MiddleCenter,
                                .BackColor = IIf(ExisteMaterial(posicion), Color.FromArgb(110, 155, 235), Color.FromArgb(200, 216, 228))
                            }
                                flpCell.Controls.Add(btn)
                                SetClickBotonPosicion(btn, Sub(sender, args)
                                                               'ClickBotonPosicion(posicion)
                                                               MostrarMaterial(sender, args, posicion)
                                                           End Sub)

                            Else
                                'Se deja el espacio
                                Dim label As New Label With {
                                .Text = "",
                                .BackColor = Color.Transparent,
                                .Height = flpCell.Height - 5,
                                .Width = (flpCell.Width / celda.CantidadPosiciones) - 30
                            }

                                flpCell.Controls.Add(label)
                            End If

                        Next
                    End If
            Next

        Next




    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click


        If (txtBodega.Text = "" Or txtCentroOpe.Text = "") Then
            MessageBox.Show("Debe seleccionar Centro Logístico y Almacén para realizar el filtrado", "Información")
            Return
        End If


        Dim dsfilter As DataSet

        Dim selectedCO = cboCentroOpe.Text.ToString()
        Dim selectedAlm = cboBodega.Text.ToString()
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros As New List(Of Parametros)()
        LstParametros.Add(New Parametros("@Almacen", selectedAlm, SqlDbType.VarChar))
        LstParametros.Add(New Parametros("@CO", selectedCO, SqlDbType.VarChar))
        dsfilter = conexion.SPGetDataSet("SP_FilterUbicaciones_CO_Almacen", LstParametros)
        LimpiarControles()
        'cboCentroOpe.SelectedIndex = 0
        'cboBodega.SelectedIndex = 0
        'txtCentroOpe.Text = ""
        cboMateriales.SelectedIndex = 0
        btnFiltrar.Enabled = False
        DiseñoAlmacenes(dsfilter)



    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click

        btnFiltrar.Enabled = False
        'txtCentroOpe.Text = ""
        'txtBodega.Text = ""
        'cboMateriales.SelectedIndex = 0
        'cboCentroOpe.SelectedIndex = 0
        'cboBodega.SelectedValue = 0
        'LimpiarControles()
        'CargueUbicaciones()
        'chkRestablece.Checked = False
    End Sub

    Private Sub chkRestablece_CheckedChanged(sender As Object, e As EventArgs) Handles chkRestablece.CheckedChanged
        If (chkRestablece.Checked) Then
            btnRestablecer.Visible = True
            btnRestablecer.Enabled = True
        Else
            btnRestablecer.Visible = False
            btnRestablecer.Enabled = False
        End If

    End Sub

    Private Sub FrmBodegas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LimpiarControles()
    End Sub

    Private Sub LimpiarControles()
        flpColumnas.Controls.Clear()
        flpFilas.Controls.Clear()
        flpGrupoCeldas.Controls.Clear()
        'cboMateriales.SelectedIndex = 0
        'cboCentroOpe.SelectedIndex = 0
        'cboBodega.SelectedValue = 0

    End Sub



End Class
