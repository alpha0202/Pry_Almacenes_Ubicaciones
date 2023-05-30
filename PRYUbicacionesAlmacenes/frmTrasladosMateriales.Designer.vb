<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladosMateriales_Ubicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrasladosMateriales_Ubicacion))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnBuscarUbicacion = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUbicacionDestino = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNroDocto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoDoct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaProceso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCO = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoDoc = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidadMovimiento = New System.Windows.Forms.TextBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantidadDisponible = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SerialMaterial = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_SerialMat = New DevExpress.XtraEditors.LabelControl()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUbicacionOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarUbiOrigen = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnEliminarMovimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtUbicacionDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDoct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtCantidadDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerialMaterial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacionOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(843, 448)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnBuscarUbicacion)
        Me.XtraTabPage1.Controls.Add(Me.btnCerrar)
        Me.XtraTabPage1.Controls.Add(Me.btnEditar)
        Me.XtraTabPage1.Controls.Add(Me.btnNuevo)
        Me.XtraTabPage1.Controls.Add(Me.txtUbicacionDestino)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.txtEstado)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.txtNroDocto)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.txtTipoDoct)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtFechaProceso)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.txtCO)
        Me.XtraTabPage1.Controls.Add(Me.lblTipoDoc)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(841, 423)
        Me.XtraTabPage1.Text = "Encabezado"
        '
        'btnBuscarUbicacion
        '
        Me.btnBuscarUbicacion.ImageOptions.Image = CType(resources.GetObject("btnBuscarUbicacion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscarUbicacion.Location = New System.Drawing.Point(340, 185)
        Me.btnBuscarUbicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarUbicacion.Name = "btnBuscarUbicacion"
        Me.btnBuscarUbicacion.Size = New System.Drawing.Size(21, 23)
        Me.btnBuscarUbicacion.TabIndex = 76
        '
        'btnCerrar
        '
        Me.btnCerrar.ImageOptions.SvgImage = CType(resources.GetObject("btnCerrar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCerrar.Location = New System.Drawing.Point(224, 238)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(137, 47)
        Me.btnCerrar.TabIndex = 74
        Me.btnCerrar.Text = "Cerrar Documento"
        '
        'btnEditar
        '
        Me.btnEditar.ImageOptions.SvgImage = CType(resources.GetObject("btnEditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEditar.Location = New System.Drawing.Point(118, 238)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(88, 47)
        Me.btnEditar.TabIndex = 73
        Me.btnEditar.Text = "Editar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageOptions.SvgImage = CType(resources.GetObject("btnNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnNuevo.Location = New System.Drawing.Point(6, 238)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 47)
        Me.btnNuevo.TabIndex = 72
        Me.btnNuevo.Text = "Nuevo"
        '
        'txtUbicacionDestino
        '
        Me.txtUbicacionDestino.Location = New System.Drawing.Point(118, 187)
        Me.txtUbicacionDestino.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUbicacionDestino.Name = "txtUbicacionDestino"
        Me.txtUbicacionDestino.Properties.ReadOnly = True
        Me.txtUbicacionDestino.Size = New System.Drawing.Size(206, 20)
        Me.txtUbicacionDestino.TabIndex = 71
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(6, 188)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 16)
        Me.LabelControl2.TabIndex = 70
        Me.LabelControl2.Text = "Ubicación Destino:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(118, 152)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(47, 20)
        Me.txtEstado.TabIndex = 69
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(6, 153)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl6.TabIndex = 68
        Me.LabelControl6.Text = "Estado:"
        '
        'txtNroDocto
        '
        Me.txtNroDocto.Location = New System.Drawing.Point(118, 116)
        Me.txtNroDocto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNroDocto.Name = "txtNroDocto"
        Me.txtNroDocto.Properties.ReadOnly = True
        Me.txtNroDocto.Size = New System.Drawing.Size(47, 20)
        Me.txtNroDocto.TabIndex = 67
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(6, 117)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl5.TabIndex = 66
        Me.LabelControl5.Text = "Nro Docto:"
        '
        'txtTipoDoct
        '
        Me.txtTipoDoct.Location = New System.Drawing.Point(118, 80)
        Me.txtTipoDoct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoDoct.Name = "txtTipoDoct"
        Me.txtTipoDoct.Properties.ReadOnly = True
        Me.txtTipoDoct.Size = New System.Drawing.Size(47, 20)
        Me.txtTipoDoct.TabIndex = 65
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(6, 81)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl4.TabIndex = 64
        Me.LabelControl4.Text = "Tipo Docto:"
        '
        'txtFechaProceso
        '
        Me.txtFechaProceso.Location = New System.Drawing.Point(118, 47)
        Me.txtFechaProceso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaProceso.Name = "txtFechaProceso"
        Me.txtFechaProceso.Properties.ReadOnly = True
        Me.txtFechaProceso.Size = New System.Drawing.Size(88, 20)
        Me.txtFechaProceso.TabIndex = 57
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(6, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "Fecha Proceso:"
        '
        'txtCO
        '
        Me.txtCO.Location = New System.Drawing.Point(118, 15)
        Me.txtCO.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCO.Name = "txtCO"
        Me.txtCO.Properties.ReadOnly = True
        Me.txtCO.Size = New System.Drawing.Size(206, 20)
        Me.txtCO.TabIndex = 55
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTipoDoc.Appearance.Options.UseFont = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(6, 16)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(96, 16)
        Me.lblTipoDoc.TabIndex = 54
        Me.lblTipoDoc.Text = "Centro Logístico:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.lblMensaje)
        Me.XtraTabPage2.Controls.Add(Me.btnGuardar)
        Me.XtraTabPage2.Controls.Add(Me.txtCantidadMovimiento)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtCantidadDisponible)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.txt_SerialMaterial)
        Me.XtraTabPage2.Controls.Add(Me.lbl_SerialMat)
        Me.XtraTabPage2.Controls.Add(Me.cboMateriales)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.cboLote)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.txtUbicacionOrigen)
        Me.XtraTabPage2.Controls.Add(Me.btnBuscarUbiOrigen)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageEnabled = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(841, 423)
        Me.XtraTabPage2.Text = "Movimiento"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Green
        Me.lblMensaje.Location = New System.Drawing.Point(17, 316)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 19)
        Me.lblMensaje.TabIndex = 96
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(21, 261)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(179, 43)
        Me.btnGuardar.TabIndex = 95
        Me.btnGuardar.Text = "Guardar Movimiento"
        '
        'txtCantidadMovimiento
        '
        Me.txtCantidadMovimiento.BackColor = System.Drawing.Color.White
        Me.txtCantidadMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadMovimiento.Location = New System.Drawing.Point(153, 211)
        Me.txtCantidadMovimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadMovimiento.Name = "txtCantidadMovimiento"
        Me.txtCantidadMovimiento.Size = New System.Drawing.Size(49, 14)
        Me.txtCantidadMovimiento.TabIndex = 94
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(21, 212)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(117, 14)
        Me.LabelControl8.TabIndex = 93
        Me.LabelControl8.Text = "Cantidad Movimiento:"
        '
        'txtCantidadDisponible
        '
        Me.txtCantidadDisponible.Location = New System.Drawing.Point(153, 171)
        Me.txtCantidadDisponible.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadDisponible.Name = "txtCantidadDisponible"
        Me.txtCantidadDisponible.Properties.ReadOnly = True
        Me.txtCantidadDisponible.Size = New System.Drawing.Size(47, 20)
        Me.txtCantidadDisponible.TabIndex = 92
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(21, 173)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(109, 14)
        Me.LabelControl7.TabIndex = 91
        Me.LabelControl7.Text = "Cantidad Disponible:"
        '
        'txt_SerialMaterial
        '
        Me.txt_SerialMaterial.Enabled = False
        Me.txt_SerialMaterial.Location = New System.Drawing.Point(451, 82)
        Me.txt_SerialMaterial.Name = "txt_SerialMaterial"
        Me.txt_SerialMaterial.Size = New System.Drawing.Size(280, 20)
        Me.txt_SerialMaterial.TabIndex = 90
        Me.txt_SerialMaterial.Visible = False
        '
        'lbl_SerialMat
        '
        Me.lbl_SerialMat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SerialMat.Appearance.Options.UseFont = True
        Me.lbl_SerialMat.Location = New System.Drawing.Point(413, 84)
        Me.lbl_SerialMat.Name = "lbl_SerialMat"
        Me.lbl_SerialMat.Size = New System.Drawing.Size(32, 14)
        Me.lbl_SerialMat.TabIndex = 89
        Me.lbl_SerialMat.Text = "Serial:"
        Me.lbl_SerialMat.Visible = False
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Location = New System.Drawing.Point(121, 81)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(280, 21)
        Me.cboMateriales.TabIndex = 88
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(19, 83)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(45, 14)
        Me.LabelControl11.TabIndex = 87
        Me.LabelControl11.Text = "Material:"
        '
        'cboLote
        '
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(121, 114)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(280, 21)
        Me.cboLote.TabIndex = 86
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(19, 119)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl10.TabIndex = 85
        Me.LabelControl10.Text = "Lote:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(21, 30)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 14)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "Ubicación Origen:"
        '
        'txtUbicacionOrigen
        '
        Me.txtUbicacionOrigen.Location = New System.Drawing.Point(121, 27)
        Me.txtUbicacionOrigen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUbicacionOrigen.Name = "txtUbicacionOrigen"
        Me.txtUbicacionOrigen.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUbicacionOrigen.Properties.Appearance.Options.UseBackColor = True
        Me.txtUbicacionOrigen.Properties.ReadOnly = True
        Me.txtUbicacionOrigen.Size = New System.Drawing.Size(280, 20)
        Me.txtUbicacionOrigen.TabIndex = 78
        '
        'btnBuscarUbiOrigen
        '
        Me.btnBuscarUbiOrigen.ImageOptions.Image = CType(resources.GetObject("btnBuscarUbiOrigen.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscarUbiOrigen.Location = New System.Drawing.Point(411, 25)
        Me.btnBuscarUbiOrigen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarUbiOrigen.Name = "btnBuscarUbiOrigen"
        Me.btnBuscarUbiOrigen.Size = New System.Drawing.Size(21, 23)
        Me.btnBuscarUbiOrigen.TabIndex = 77
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.btnEliminarMovimientos)
        Me.XtraTabPage4.Controls.Add(Me.gcDetalle)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.PageEnabled = False
        Me.XtraTabPage4.Size = New System.Drawing.Size(841, 423)
        Me.XtraTabPage4.Text = "Detalle"
        '
        'btnEliminarMovimientos
        '
        Me.btnEliminarMovimientos.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.btnEliminarMovimientos.ImageOptions.SvgImage = CType(resources.GetObject("btnEliminarMovimientos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEliminarMovimientos.Location = New System.Drawing.Point(11, 303)
        Me.btnEliminarMovimientos.Name = "btnEliminarMovimientos"
        Me.btnEliminarMovimientos.Size = New System.Drawing.Size(155, 37)
        Me.btnEliminarMovimientos.TabIndex = 187
        Me.btnEliminarMovimientos.Text = "Eliminar Movimientos"
        '
        'gcDetalle
        '
        Me.gcDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDetalle.Location = New System.Drawing.Point(10, 15)
        Me.gcDetalle.MainView = Me.gvDetalle
        Me.gcDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(821, 274)
        Me.gcDetalle.TabIndex = 186
        Me.gcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn10, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvDetalle.DetailHeight = 239
        Me.gvDetalle.FixedLineWidth = 1
        Me.gvDetalle.GridControl = Me.gcDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetalle.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDetalle.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvDetalle.OptionsSelection.MultiSelect = True
        Me.gvDetalle.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ROWID"
        Me.GridColumn1.FieldName = "f301_RowID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "MATERIAL"
        Me.GridColumn2.FieldName = "f301_Referencia"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "SERIAL "
        Me.GridColumn9.FieldName = "f301_SerialMaterial"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "DESCRIPCIÓN"
        Me.GridColumn3.FieldName = "f106_Descripcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 79
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "CANTIDAD"
        Me.GridColumn4.FieldName = "f301_Cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "UBICACION ORIGEN"
        Me.GridColumn5.FieldName = "f301_UbicacionOrigen"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsFilter.AllowFilter = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        Me.GridColumn5.Width = 109
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "UBICACION DESTINO"
        Me.GridColumn10.FieldName = "f301_UbicacionDestino"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 114
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "USUARIO MOVIMIENTO"
        Me.GridColumn6.FieldName = "f301_UsuarioMov"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 8
        Me.GridColumn6.Width = 124
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "FECHA/HORA MOVIMIENTO"
        Me.GridColumn7.FieldName = "f301_FechaHoraMov"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 9
        Me.GridColumn7.Width = 144
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "LOTE"
        Me.GridColumn8.FieldName = "f301_Lote"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        '
        'frmTrasladosMateriales_Ubicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 448)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmTrasladosMateriales_Ubicacion.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Name = "frmTrasladosMateriales_Ubicacion"
        Me.Text = "Traslado por Ubicación"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtUbicacionDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDoct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtCantidadDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerialMaterial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacionOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtFechaProceso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTipoDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUbicacionDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNroDocto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoDoct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarUbicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarUbiOrigen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUbicacionOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SerialMaterial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_SerialMat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLote As ComboBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidadMovimiento As TextBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidadDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminarMovimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMensaje As Label
End Class
