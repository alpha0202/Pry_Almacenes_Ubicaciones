<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosUbicacion
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosUbicacion))
        Me.gcPrincipal = New DevExpress.XtraGrid.GridControl()
        Me.gvProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblUbicacionNombre = New System.Windows.Forms.Label()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcPrincipal
        '
        Me.gcPrincipal.Location = New System.Drawing.Point(31, 60)
        Me.gcPrincipal.MainView = Me.gvProductos
        Me.gcPrincipal.Name = "gcPrincipal"
        Me.gcPrincipal.Size = New System.Drawing.Size(608, 305)
        Me.gcPrincipal.TabIndex = 0
        Me.gcPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProductos})
        '
        'gvProductos
        '
        Me.gvProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn6, Me.GridColumn2, Me.GridColumn4, Me.GridColumn3})
        Me.gvProductos.GridControl = Me.gcPrincipal
        Me.gvProductos.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "medios", Nothing, "(# MEDIOS: SUMA={0:#.##})")})
        Me.gvProductos.Name = "gvProductos"
        Me.gvProductos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvProductos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvProductos.OptionsBehavior.Editable = False
        Me.gvProductos.OptionsView.ShowFooter = True
        Me.gvProductos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "MATERIAL"
        Me.GridColumn1.FieldName = "f302_Material"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 128
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SERIAL"
        Me.GridColumn5.FieldName = "f302_SerialMaterial"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn5.OptionsFilter.AllowFilter = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 66
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "DESCRIPCIÓN"
        Me.GridColumn2.FieldName = "f106_Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 179
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CANTIDAD"
        Me.GridColumn4.DisplayFormat.FormatString = "0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 144
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "#SALDO"
        Me.GridColumn3.FieldName = "saldo"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(31, 382)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        '
        'lblUbicacionNombre
        '
        Me.lblUbicacionNombre.AutoSize = True
        Me.lblUbicacionNombre.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblUbicacionNombre.Location = New System.Drawing.Point(30, 16)
        Me.lblUbicacionNombre.Name = "lblUbicacionNombre"
        Me.lblUbicacionNombre.Size = New System.Drawing.Size(0, 18)
        Me.lblUbicacionNombre.TabIndex = 2
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "LOTE"
        Me.GridColumn6.FieldName = "f302_Lote"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn6.OptionsFilter.AllowFilter = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 66
        '
        'frmProductosUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 429)
        Me.Controls.Add(Me.lblUbicacionNombre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gcPrincipal)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmProductosUbicacion.IconOptions.LargeImage"), System.Drawing.Image)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductosUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Ubicación"
        CType(Me.gcPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUbicacionNombre As System.Windows.Forms.Label
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
