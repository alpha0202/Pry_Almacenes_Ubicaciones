Imports System.Data.SqlClient
Imports System.Windows
Imports System.Text

Public Class clsConexionNew
    'Public SqlConnectionString As String = SQLconexion
    Public SqlConnectionString As String = "Data Source= 10.252.0.158\ALIAR;Initial Catalog=UBICACIONES;User Id=sa;Password=0bleaconMora"

    'Public Sub clsConexionNew(ByVal CentroOperativo As String)

    'End Sub





#Region "PROCEDIMIENTOS ALMACENADO"
    ''' <summary>
    ''' Permite ejecutar procedimiento almacenado que devuelva una consulta
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <param name="Parametros"></param>
    ''' <returns>DataTable con el resultado de la consulta</returns>
    ''' <remarks></remarks>
    Public Function SPObtenerDataTable(Procedimiento As String, Parametros As List(Of Parametros)) As DataTable
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim CadenaSQL As New StringBuilder()
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000
            Dim ObjSqlParametro As SqlParameter

            For Each ObjSpParametro As Parametros In Parametros
                ObjSqlParametro = New SqlParameter()
                ObjSqlParametro.ParameterName = ObjSpParametro.Nombre
                ObjSqlParametro.SqlDbType = ObjSpParametro.Tipo
                ObjSqlParametro.Value = ObjSpParametro.Valor

                If ObjSpParametro.Tipo = SqlDbType.VarChar Then
                    ObjSqlParametro.Size = ObjSpParametro.Longitud
                End If

                CadenaSQL.Append(ObjSpParametro.Nombre)
                CadenaSQL.Append(" = ")
                CadenaSQL.Append(ObjSpParametro.Valor.ToString())
                CadenaSQL.Append(" | ")
                Comando.Parameters.Add(ObjSqlParametro)
            Next

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As New DataTable()
            Dim ObjDataAdapter As New SqlDataAdapter(Comando)
            ObjDataAdapter.Fill(DtResultado)

            Return DtResultado
        Catch ex As Exception
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Permite ejecutar procedimiento almacenado que devuelva una consulta sin mandar parametros
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SPObtenerDataTable(Procedimiento As String) As DataTable
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000
            Dim DtResultado As New DataTable()
            Dim ObjDataAdapter As New SqlDataAdapter(Comando)

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            ObjDataAdapter.Fill(DtResultado)
            Return DtResultado
        Catch ex As Exception
            'logErrores(Procedimiento, "Este procedimiento no tiene parámetros asociados", "GetDataTable", ex.Message.ToString())
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If
            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Permite ejecutar procedimiento almacenado que devuelve un DataSet
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <returns>Dataset con el resultado</returns>
    ''' <remarks></remarks>
    Public Function SPGetDataSet(Procedimiento As String) As DataSet
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000
            Dim DtResultado As New DataSet()

            Dim ObjDataAdapter As New SqlDataAdapter(Comando)

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            ObjDataAdapter.Fill(DtResultado)
            Return DtResultado
        Catch ex As Exception
            'logErrores(Procedimiento, "Este procedimiento no tiene parámetros asociados", "GetDataSet", ex.Message.ToString())
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Permite ejecutar procedimiento almacenado que devuelve un DataSet con lista de parametros
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <param name="Parametros"></param>
    ''' <returns>Dataset con el resultado</returns>
    ''' <remarks></remarks>
    Public Function SPGetDataSet(Procedimiento As String, Parametros As List(Of Parametros)) As DataSet
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim CadenaSQL As New StringBuilder()
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000

            Dim ObjSqlParametro As SqlParameter

            For Each ObjSpParametro As Parametros In Parametros
                ObjSqlParametro = New SqlParameter()
                ObjSqlParametro.ParameterName = ObjSpParametro.Nombre
                ObjSqlParametro.SqlDbType = ObjSpParametro.Tipo
                ObjSqlParametro.Value = ObjSpParametro.Valor

                If ObjSpParametro.Tipo = SqlDbType.VarChar Then
                    ObjSqlParametro.Size = ObjSpParametro.Longitud
                End If
                CadenaSQL.Append(ObjSpParametro.Nombre)
                CadenaSQL.Append(" = ")
                CadenaSQL.Append(ObjSpParametro.Valor.ToString())
                CadenaSQL.Append(" | ")


                Comando.Parameters.Add(ObjSqlParametro)
            Next

            Dim DtResultado As New DataSet()
            Dim ObjDataAdapter As New SqlDataAdapter(Comando)

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            ObjDataAdapter.Fill(DtResultado)

            Return DtResultado
        Catch ex As Exception
            'logErrores(Procedimiento, CadenaSQL.ToString(), "GetDataSet", ex.Message.ToString())
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta procediento que devuelve la consulta Escalar (un unico valor) con lista de parametros
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <param name="Parametros"></param>
    ''' <returns>objeto de la respuesta de la ejecucion</returns>
    ''' <remarks></remarks>
    Public Function SPGetEscalar(Procedimiento As String, Parametros As List(Of Parametros)) As [Object]
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim CadenaSQL As New StringBuilder()
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000

            Dim ObjSqlParametro As SqlParameter

            For Each ObjSpParametro As Parametros In Parametros
                ObjSqlParametro = New SqlParameter()
                ObjSqlParametro.ParameterName = ObjSpParametro.Nombre
                ObjSqlParametro.SqlDbType = ObjSpParametro.Tipo
                ObjSqlParametro.Value = ObjSpParametro.Valor

                ObjSqlParametro.Direction = ObjSpParametro.Direccion

                If ObjSpParametro.Tipo = SqlDbType.VarChar Then
                    ObjSqlParametro.Size = ObjSpParametro.Longitud
                End If
                CadenaSQL.Append(ObjSpParametro.Nombre)
                CadenaSQL.Append(" = ")
                CadenaSQL.Append(ObjSpParametro.Valor.ToString())
                CadenaSQL.Append(" | ")

                Comando.Parameters.Add(ObjSqlParametro)
            Next

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As [Object]
            DtResultado = Comando.ExecuteScalar()
            Return DtResultado
        Catch ex As Exception
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()

            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta procediento que devuelve la consulta Escalar (un unico valor)
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <returns>objeto de la respuesta de la ejecucion</returns>
    ''' <remarks></remarks>
    Public Function SPGetEscalar(Procedimiento As String) As [Object]
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As [Object]
            DtResultado = Comando.ExecuteScalar()

            Return DtResultado
        Catch ex As Exception

            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    ''' <summary>
    ''' Ejecuta procedimiento almacenado con lista de parametros
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <param name="Parametros"></param>
    ''' <remarks></remarks>
    Public Sub SPExecute(Procedimiento As String, Parametros As List(Of Parametros))
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim CadenaSQL As New StringBuilder()
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000

            Dim ObjSqlParametro As SqlParameter

            For Each ObjSpParametro As Parametros In Parametros
                ObjSqlParametro = New SqlParameter()
                ObjSqlParametro.ParameterName = ObjSpParametro.Nombre
                ObjSqlParametro.SqlDbType = ObjSpParametro.Tipo
                ObjSqlParametro.Value = ObjSpParametro.Valor

                ObjSqlParametro.Direction = ObjSpParametro.Direccion

                If ObjSpParametro.Tipo = SqlDbType.VarChar Then
                    ObjSqlParametro.Size = ObjSpParametro.Longitud
                End If
                CadenaSQL.Append(ObjSpParametro.Nombre)
                CadenaSQL.Append(" = ")
                CadenaSQL.Append(ObjSpParametro.Valor.ToString())
                CadenaSQL.Append(" | ")

                Comando.Parameters.Add(ObjSqlParametro)
            Next

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As [Object]
            DtResultado = Comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Sub

    ''' <summary>
    ''' Ejecuta procedimiento almacenado
    ''' </summary>
    ''' <param name="Procedimiento"></param>
    ''' <remarks></remarks>
    Public Sub SPExecute(Procedimiento As String)
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion

            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = Procedimiento
            Comando.CommandTimeout = 60000

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As [Object]
            DtResultado = Comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Sub
#End Region

#Region "SQL"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Sql"></param>
    ''' <returns></returns>
    Public Function ObtenerDataTable(Sql As String) As DataTable
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandText = Sql
            Comando.CommandTimeout = 60000
            Dim DtResultado As New DataTable()
            Dim ObjDataAdapter As New SqlDataAdapter(Comando)

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            ObjDataAdapter.Fill(DtResultado)
            Return DtResultado
        Catch ex As Exception
            'logErrores(Procedimiento, "Este procedimiento no tiene parámetros asociados", "GetDataTable", ex.Message.ToString())
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If
            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

    Public Sub Execute(Sql As String)
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandText = Sql
            Comando.CommandTimeout = 60000

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If


            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Sub
    Public Function GetEscalar(Sql As String) As [Object]
        Dim Conexion As New SqlConnection()
        Conexion.ConnectionString = SqlConnectionString
        Dim Comando As New SqlCommand()

        Try
            Comando.Connection = Conexion
            Comando.CommandText = Sql
            Comando.CommandTimeout = 60000

            If Conexion.State <> ConnectionState.Open Then
                Conexion.Open()
            End If

            Dim DtResultado As [Object]
            DtResultado = Comando.ExecuteScalar()

            Return DtResultado
        Catch ex As Exception

            Throw ex
        Finally
            If Conexion.State <> ConnectionState.Closed Then
                Conexion.Close()
            End If

            Comando.Parameters.Clear()
            Comando.Dispose()
        End Try
    End Function

#End Region

    ''' <summary>
    ''' Permite cargar el combo con una consulta sql, donde la primera columna es del value y la segunda la descripcion
    ''' </summary>
    ''' <param name="control">el control del combo a llenar</param>
    ''' <param name="strSql">la consulta sql a ejecutar</param>
    ''' <param name="itemTodos">si quiere que salga el primer item con la palabra todos y valor = 0</param>
    ''' <param name="texto">Si desea cambiar el primer mensaje que se muestra</param>
    Public Sub CargarCombo(ByRef control As Forms.ComboBox, ByVal strSql As String, ByVal itemTodos As Boolean, Optional ByVal texto As String = "-TOD@S-")
        Try
            Dim objDatatable As DataTable
            Dim objRow As DataRow
            control.DataSource = Nothing
            control.Items.Clear()
            If strSql <> "" Then
                objDatatable = ObtenerDataTable(strSql)
                If objDatatable.Rows.Count > 0 Then
                    If itemTodos Then
                        If Type.GetTypeCode(objDatatable.Columns(0).DataType) = TypeCode.String And Type.GetTypeCode(objDatatable.Columns(1).DataType) = TypeCode.String Then
                            objRow = objDatatable.NewRow
                            objRow.Item(0) = "0"
                            objRow.Item(1) = texto
                            objDatatable.Rows.InsertAt(objRow, 0)
                        End If
                    End If
                    control.ValueMember = objDatatable.Columns(0).ColumnName
                    control.DisplayMember = objDatatable.Columns(1).ColumnName
                    control.DataSource = objDatatable
                End If
            End If
        Catch ex As Exception
            Throw New ArgumentException(ex.Message)
        End Try
    End Sub
End Class
