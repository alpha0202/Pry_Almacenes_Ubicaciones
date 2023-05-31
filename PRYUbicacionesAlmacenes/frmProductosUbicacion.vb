Imports DevExpress.XtraGrid.Views.Grid
Imports CediAliarDll

Public Class frmProductosUbicacion

    Public Sub New(ByVal dt As DataTable, ByVal name As String, ByVal descripcion As String)
        'Public Sub New(ByVal dt As DataTable, ByVal tag As String, ByVal bodega As String, ByVal co As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        lblUbicacionNombre.Text = "UBICACIÓN: " + name + " - " + descripcion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        gcPrincipal.DataSource = dt
        gvProductos.OptionsView.ColumnAutoWidth = False
        gvProductos.BestFitColumns()
        carga_totales()
        gcPrincipal.ForceInitialize()



    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub carga_totales()

        CType(gcPrincipal.MainView, GridView).Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum

        ' In the below line we have to define the field name on which we have to perform the operation
        CType(gcPrincipal.MainView, GridView).Columns(4).SummaryItem.FieldName = "cantidad"

        'in the below line we have to define the format of tect which will display on the footer. You can also round up the calcuations
        ' CType(gcPrincipal.MainView, GridView).Columns(5).SummaryItem.DisplayFormat = "Total.Medios= {0:F2}"
        CType(gcPrincipal.MainView, GridView).Columns(4).SummaryItem.DisplayFormat = "TOT= {0:F4}"

    End Sub

    Private Sub frmProductosUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmProductosUbicacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Dispose()
        End If
    End Sub


End Class