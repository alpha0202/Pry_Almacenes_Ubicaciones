Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports SAP.Middleware.Connector

Partial Public Class frmPrincipal
    Public Sub New()
        InitializeComponent()
        RfcDestinationManager.RegisterDestinationConfiguration(New rfc_Connector())
    End Sub

    Private Sub AbrirFormulario(ByVal titulo As String, ByVal formulario As Form)


        Dim child As Form = Nothing
        For Each f As Form In MdiChildren
            If f.Name = formulario.Name Then
                child = f
                Exit For
            End If
        Next f

        If child Is Nothing Then
            child = formulario
            child.Text = titulo
            child.MdiParent = Me
            child.Show()
        Else
            child.Activate()
        End If

    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        AbrirFormulario("Recepción", frmRecepcion)

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        AbrirFormulario("Devoluciones", frmDevoluciones)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            Dim user As New Usuarios()
            user = Usuarios.GetUsuario(My.User.Name.ToUpper.Replace("ALIAR\", ""))

            If (user._estado <> "A") Then
                Throw New ArgumentException("Usuario Inactivo")
            End If


            Me.Text = "Usuario: " + user._usuario + " - CL: " + user._co + " " + user._desCo + " - Almacen:" + user._almacen + " " + user._desAlmacen + " - Fecha Proceso: " + user._fechaProceso.ToString("dd/MM/yyyy")

            SplashScreenManager.CloseForm(False)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        'RfcDestinationManager.RegisterDestinationConfiguration(New rfc_Connector())
        Dim prd = RfcDestinationManager.GetDestination("SE37")
        Dim repo As RfcRepository = prd.Repository
        Dim soBapi As IRfcFunction = repo.CreateFunction("Z_MDFN_MATTALLER")
        'soBapi.SetValue("P_BUKRS", "1000")
        'soBapi.SetValue("P_YEAR", "2022")
        'soBapi.SetValue("P_MONTH", "11")
        soBapi.Invoke(prd)
        Dim IT_KNA1 As IRfcTable = soBapi.GetTable("IT_TALLER")
        Dim dt As New DataTable()
        dt = Utilidades.ConvertToDotNetTable(IT_KNA1)
        Dim sql As String = "delete t106_Materiales"
        Dim conexion As clsConexionNew = New clsConexionNew()
        Dim LstParametros = New List(Of Parametros)()
        conexion.GetEscalar(sql)
        For Each dr As DataRow In dt.Rows
            Dim materia As String = CDec(dr("MATNR").ToString()).ToString()
            Dim descripcion As String = dr("MAKTX").ToString().Replace("'", "")
            sql = "INSERT INTO [dbo].[t106_Materiales]
                       ([f106_Material]
                       ,[f106_Descripcion])
                 VALUES
                       ('" + materia + "'
                       ,'" + descripcion + "')"
            conexion.GetEscalar(sql)

        Next
        XtraMessageBox.Show("Se proceso Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        AbrirFormulario("Mapa de Bodegas", FrmBodegas)
    End Sub
End Class
