<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentosRecepcion
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
        Me.gcDocumentos = New DevExpress.XtraGrid.GridControl()
        Me.gvDocumentos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnseleccionar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcDocumentos
        '
        Me.gcDocumentos.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDocumentos.Location = New System.Drawing.Point(8, 8)
        Me.gcDocumentos.MainView = Me.gvDocumentos
        Me.gcDocumentos.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDocumentos.Name = "gcDocumentos"
        Me.gcDocumentos.Size = New System.Drawing.Size(827, 236)
        Me.gcDocumentos.TabIndex = 0
        Me.gcDocumentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDocumentos})
        '
        'gvDocumentos
        '
        Me.gvDocumentos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.gvDocumentos.DetailHeight = 239
        Me.gvDocumentos.FixedLineWidth = 1
        Me.gvDocumentos.GridControl = Me.gcDocumentos
        Me.gvDocumentos.Name = "gvDocumentos"
        Me.gvDocumentos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDocumentos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDocumentos.OptionsBehavior.Editable = False
        Me.gvDocumentos.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ROWID"
        Me.GridColumn1.FieldName = "f300_RowID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "TIPO DOCT"
        Me.GridColumn2.FieldName = "f300_TipoDocumento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "NRO DOCTO"
        Me.GridColumn3.FieldName = "f300_NroDocumento"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "FECHA"
        Me.GridColumn4.FieldName = "f300_FechaDocumento"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ALM ORIGEN"
        Me.GridColumn5.FieldName = "f300_AlmacenOrigen"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ALM DESTINO"
        Me.GridColumn6.FieldName = "f300_AlmacenDestino"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "ESTADO"
        Me.GridColumn7.FieldName = "f300_EstadoDoc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "USUARIO CREACION"
        Me.GridColumn8.FieldName = "f300_UsuarioCreacion"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "FECHA/HORA"
        Me.GridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "f300_FechaHoraCreacion"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        '
        'btnseleccionar
        '
        Me.btnseleccionar.Location = New System.Drawing.Point(331, 263)
        Me.btnseleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(164, 23)
        Me.btnseleccionar.TabIndex = 1
        Me.btnseleccionar.Text = "Seleccionar"
        '
        'frmDocumentosRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 321)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.gcDocumentos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDocumentosRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDocumentosRecepcion"
        CType(Me.gcDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcDocumentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDocumentos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnseleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
End Class
