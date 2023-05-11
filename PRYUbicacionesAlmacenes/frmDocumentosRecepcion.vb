Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmDocumentosRecepcion
    Public rowid As String
    Public Sub New(ByVal co As String, ByVal almacen As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim encabezado As New List(Of EncabezadoMovimiento)
        encabezado = EncabezadoMovimiento.ListEncabezadoMovimiento(co, almacen)
        gcDocumentos.DataSource = encabezado
        gvDocumentos.BestFitColumns()
    End Sub
    Private Sub frmDocumentosRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Try
            rowid = CDec(gvDocumentos.GetRowCellDisplayText(gvDocumentos.FocusedRowHandle, gvDocumentos.Columns(0)))
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvDocumentos_DoubleClick(sender As Object, e As EventArgs) Handles gvDocumentos.DoubleClick
        Try
            Dim view As GridView = CType(sender, GridView)
            Dim pt As Point = view.GridControl.PointToClient(Control.MousePosition)
            Dim info As GridHitInfo = view.CalcHitInfo(pt)
            Dim row As EncabezadoMovimiento = CType(view.GetRow(info.RowHandle), EncabezadoMovimiento)
            rowid = row.f300_RowID.ToString()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class