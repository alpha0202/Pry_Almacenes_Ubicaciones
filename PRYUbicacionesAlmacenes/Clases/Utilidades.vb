Imports System.Windows
Imports DevExpress.XtraEditors
Imports SAP.Middleware.Connector

Public Class Utilidades

    Public Shared Sub Numeros(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Shared Sub CargarCombo(ByRef control As Forms.ComboBox, ByVal items As Dictionary(Of Object, Object), ByVal itemTodos As Boolean, Optional ByVal texto As String = "-TOD@S-")
        Dim objDatatable As New DataTable()
        Dim objRow As DataRow
        objDatatable.Columns.Add("key")
        objDatatable.Columns.Add("item")
        objRow = objDatatable.NewRow
        If itemTodos Then
            objRow = objDatatable.NewRow
            objRow.Item(0) = "0"
            objRow.Item(1) = texto
            objDatatable.Rows.InsertAt(objRow, 0)
        End If

        For Each item As KeyValuePair(Of Object, Object) In items
            Dim objArray() As Object = {item.Key, item.Value}
            objDatatable.Rows.Add(objArray)
        Next

        control.DisplayMember = "item"
        control.ValueMember = "key"
        control.DataSource = objDatatable

    End Sub
    Public Shared Function getUsuario() As String
        Return My.User.Name.ToUpper.Replace("ALIAR\", "")
    End Function
    Public Shared Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Shared Function ConvertToDotNetTable(ByVal RFCTable As IRfcTable) As DataTable
        Dim dtTable As DataTable = New DataTable()

        For item As Integer = 0 To RFCTable.ElementCount - 1
            Dim metadata As RfcElementMetadata = RFCTable.GetElementMetadata(item)
            dtTable.Columns.Add(metadata.Name)
        Next

        For Each row As IRfcStructure In RFCTable
            Dim dr As DataRow = dtTable.NewRow()

            For item As Integer = 0 To RFCTable.ElementCount - 1
                Dim metadata As RfcElementMetadata = RFCTable.GetElementMetadata(item)

                If metadata.DataType = RfcDataType.BCD AndAlso metadata.Name = "ABC" Then
                    dr(item) = row.GetInt(metadata.Name)
                Else
                    dr(item) = row.GetString(metadata.Name)
                End If
            Next

            dtTable.Rows.Add(dr)
        Next

        Return dtTable
    End Function

    'determinar si un formulario ya se encuetra abierto.
    Public Function IsFormOpen(ByVal formName As String) As Boolean

        ' Recorremos la colección de formularios
        ' actualmente abiertos.
        '
        For Each frm As Form In My.Application.OpenForms

            If (frm.Name.ToLower() = formName.ToLower()) Then

                frm.Dispose()
                Return True
            End If

        Next

        Return False

    End Function

    'Private Sub IdentificarFormLLamado(sender As Object)

    '    If TypeOf sender Is frmRecepcion Then

    '        frmRecepcion.RecibirUbicacion(posicion.Nombre)

    '    ElseIf TypeOf sender Is frmDevoluciones Then



    '    End If

    'End Sub


    Public Shared Function BuscarUbicacion(ByVal tipoTraslado As String)


        Dim frmBodegasUbicaciones As FrmBodegas = New FrmBodegas()
        frmBodegasUbicaciones.Solicitud_Ubicacion = True
        frmBodegasUbicaciones.form_solicita = tipoTraslado.Trim()
        frmBodegasUbicaciones.ShowDialog()
        frmBodegasUbicaciones.Dispose()

    End Function


    Public Shared Function ExisteUbicacionSeleccionada(ubicacion As String) As String
        Dim respuesta As String

        Try

            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()

            LstParametros.Add(New Parametros("@ubicacion", ubicacion, SqlDbType.VarChar))

            Dim dt As New DataTable
            Dim res As DataRow
            dt = conexion.SPObtenerDataTable("SP_GetUbicacion", LstParametros)
            res = dt.Rows(0)
            respuesta = res("RESPUESTA").ToString()


        Catch ex As Exception
            'Return "0"
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return respuesta
    End Function


End Class
