﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevoluciones))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNroDocto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoDoct = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAlmacenR = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAlmacenDestino = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaProceso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCO = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoDoc = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_SerialDevolucion = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_SerialDevo = New DevExpress.XtraEditors.LabelControl()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtCantidadMovimiento = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscarUbicacion = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUbicacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantidadDisponible = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcDetalle = New DevExpress.XtraGrid.GridControl()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminarMovimientos = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoDoct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacenR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlmacenDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txt_SerialDevolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1204, 659)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btnCerrar)
        Me.XtraTabPage1.Controls.Add(Me.btnEditar)
        Me.XtraTabPage1.Controls.Add(Me.btnNuevo)
        Me.XtraTabPage1.Controls.Add(Me.txtEstado)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.txtNroDocto)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.txtTipoDoct)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtAlmacenR)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.txtAlmacenDestino)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.txtFechaProceso)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.txtCO)
        Me.XtraTabPage1.Controls.Add(Me.lblTipoDoc)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1202, 634)
        Me.XtraTabPage1.Text = "Encabezado"
        '
        'btnCerrar
        '
        Me.btnCerrar.ImageOptions.SvgImage = CType(resources.GetObject("btnCerrar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnCerrar.Location = New System.Drawing.Point(257, 157)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(141, 43)
        Me.btnCerrar.TabIndex = 66
        Me.btnCerrar.Text = "Cerrar Documento"
        '
        'btnEditar
        '
        Me.btnEditar.ImageOptions.SvgImage = CType(resources.GetObject("btnEditar.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEditar.Location = New System.Drawing.Point(135, 157)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(107, 43)
        Me.btnEditar.TabIndex = 65
        Me.btnEditar.Text = "Editar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageOptions.SvgImage = CType(resources.GetObject("btnNuevo.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnNuevo.Location = New System.Drawing.Point(10, 157)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(111, 43)
        Me.btnNuevo.TabIndex = 64
        Me.btnNuevo.Text = "Nuevo"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(351, 97)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(47, 20)
        Me.txtEstado.TabIndex = 63
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(302, 100)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl6.TabIndex = 62
        Me.LabelControl6.Text = "Estado:"
        '
        'txtNroDocto
        '
        Me.txtNroDocto.Location = New System.Drawing.Point(219, 97)
        Me.txtNroDocto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNroDocto.Name = "txtNroDocto"
        Me.txtNroDocto.Properties.ReadOnly = True
        Me.txtNroDocto.Size = New System.Drawing.Size(47, 20)
        Me.txtNroDocto.TabIndex = 61
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(150, 100)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl5.TabIndex = 60
        Me.LabelControl5.Text = "Nro Docto:"
        '
        'txtTipoDoct
        '
        Me.txtTipoDoct.Location = New System.Drawing.Point(84, 97)
        Me.txtTipoDoct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoDoct.Name = "txtTipoDoct"
        Me.txtTipoDoct.Properties.ReadOnly = True
        Me.txtTipoDoct.Size = New System.Drawing.Size(47, 20)
        Me.txtTipoDoct.TabIndex = 59
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(10, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "Tipo Docto:"
        '
        'txtAlmacenR
        '
        Me.txtAlmacenR.Location = New System.Drawing.Point(113, 51)
        Me.txtAlmacenR.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlmacenR.Name = "txtAlmacenR"
        Me.txtAlmacenR.Properties.ReadOnly = True
        Me.txtAlmacenR.Size = New System.Drawing.Size(206, 20)
        Me.txtAlmacenR.TabIndex = 57
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(10, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Almacen Destino:"
        '
        'txtAlmacenDestino
        '
        Me.txtAlmacenDestino.Location = New System.Drawing.Point(453, 51)
        Me.txtAlmacenDestino.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlmacenDestino.Name = "txtAlmacenDestino"
        Me.txtAlmacenDestino.Properties.ReadOnly = True
        Me.txtAlmacenDestino.Size = New System.Drawing.Size(206, 20)
        Me.txtAlmacenDestino.TabIndex = 55
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(351, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl2.TabIndex = 54
        Me.LabelControl2.Text = "Almacen Origen:"
        '
        'txtFechaProceso
        '
        Me.txtFechaProceso.Location = New System.Drawing.Point(351, 12)
        Me.txtFechaProceso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaProceso.Name = "txtFechaProceso"
        Me.txtFechaProceso.Properties.ReadOnly = True
        Me.txtFechaProceso.Size = New System.Drawing.Size(88, 20)
        Me.txtFechaProceso.TabIndex = 53
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(257, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Fecha Proceso:"
        '
        'txtCO
        '
        Me.txtCO.Location = New System.Drawing.Point(35, 12)
        Me.txtCO.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCO.Name = "txtCO"
        Me.txtCO.Properties.ReadOnly = True
        Me.txtCO.Size = New System.Drawing.Size(206, 20)
        Me.txtCO.TabIndex = 51
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblTipoDoc.Appearance.Options.UseFont = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(8, 14)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(19, 16)
        Me.lblTipoDoc.TabIndex = 50
        Me.lblTipoDoc.Text = "CL:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txt_SerialDevolucion)
        Me.XtraTabPage2.Controls.Add(Me.lbl_SerialDevo)
        Me.XtraTabPage2.Controls.Add(Me.cboMateriales)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.cboLote)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.lblMensaje)
        Me.XtraTabPage2.Controls.Add(Me.txtCantidadMovimiento)
        Me.XtraTabPage2.Controls.Add(Me.btnGuardar)
        Me.XtraTabPage2.Controls.Add(Me.btnBuscarUbicacion)
        Me.XtraTabPage2.Controls.Add(Me.txtUbicacion)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtCantidadDisponible)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageEnabled = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(1202, 634)
        Me.XtraTabPage2.Text = "Movimientos"
        '
        'txt_SerialDevolucion
        '
        Me.txt_SerialDevolucion.Enabled = False
        Me.txt_SerialDevolucion.Location = New System.Drawing.Point(75, 87)
        Me.txt_SerialDevolucion.Name = "txt_SerialDevolucion"
        Me.txt_SerialDevolucion.Size = New System.Drawing.Size(280, 20)
        Me.txt_SerialDevolucion.TabIndex = 84
        Me.txt_SerialDevolucion.Visible = False
        '
        'lbl_SerialDevo
        '
        Me.lbl_SerialDevo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SerialDevo.Appearance.Options.UseFont = True
        Me.lbl_SerialDevo.Location = New System.Drawing.Point(17, 92)
        Me.lbl_SerialDevo.Name = "lbl_SerialDevo"
        Me.lbl_SerialDevo.Size = New System.Drawing.Size(38, 16)
        Me.lbl_SerialDevo.TabIndex = 83
        Me.lbl_SerialDevo.Text = "Serial:"
        Me.lbl_SerialDevo.Visible = False
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Location = New System.Drawing.Point(75, 50)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(280, 21)
        Me.cboMateriales.TabIndex = 82
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(17, 51)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl11.TabIndex = 81
        Me.LabelControl11.Text = "Material:"
        '
        'cboLote
        '
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(402, 50)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(121, 21)
        Me.cboLote.TabIndex = 80
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(367, 50)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl10.TabIndex = 79
        Me.LabelControl10.Text = "Lote:"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Green
        Me.lblMensaje.Location = New System.Drawing.Point(24, 205)
        Me.lblMensaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 19)
        Me.lblMensaje.TabIndex = 78
        '
        'txtCantidadMovimiento
        '
        Me.txtCantidadMovimiento.Location = New System.Drawing.Point(149, 166)
        Me.txtCantidadMovimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadMovimiento.Name = "txtCantidadMovimiento"
        Me.txtCantidadMovimiento.Size = New System.Drawing.Size(49, 21)
        Me.txtCantidadMovimiento.TabIndex = 77
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(17, 250)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 47)
        Me.btnGuardar.TabIndex = 76
        Me.btnGuardar.Text = "Guardar Movimiento"
        '
        'btnBuscarUbicacion
        '
        Me.btnBuscarUbicacion.ImageOptions.Image = CType(resources.GetObject("btnBuscarUbicacion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscarUbicacion.Location = New System.Drawing.Point(279, 11)
        Me.btnBuscarUbicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarUbicacion.Name = "btnBuscarUbicacion"
        Me.btnBuscarUbicacion.Size = New System.Drawing.Size(21, 23)
        Me.btnBuscarUbicacion.TabIndex = 75
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(133, 13)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(142, 20)
        Me.txtUbicacion.TabIndex = 74
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(17, 13)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl9.TabIndex = 73
        Me.LabelControl9.Text = "Ubicación Origen:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(17, 167)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(124, 16)
        Me.LabelControl8.TabIndex = 71
        Me.LabelControl8.Text = "Cantidad Movimiento:"
        '
        'txtCantidadDisponible
        '
        Me.txtCantidadDisponible.Location = New System.Drawing.Point(149, 126)
        Me.txtCantidadDisponible.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadDisponible.Name = "txtCantidadDisponible"
        Me.txtCantidadDisponible.Properties.ReadOnly = True
        Me.txtCantidadDisponible.Size = New System.Drawing.Size(47, 20)
        Me.txtCantidadDisponible.TabIndex = 69
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(17, 128)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(117, 16)
        Me.LabelControl7.TabIndex = 68
        Me.LabelControl7.Text = "Cantidad Disponible:"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.gcDetalle)
        Me.XtraTabPage3.Controls.Add(Me.btnEliminarMovimientos)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageEnabled = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(1202, 634)
        Me.XtraTabPage3.Text = "Detalle"
        '
        'gcDetalle
        '
        Me.gcDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDetalle.Location = New System.Drawing.Point(7, 8)
        Me.gcDetalle.MainView = Me.gvDetalle
        Me.gcDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(821, 274)
        Me.gcDetalle.TabIndex = 185
        Me.gcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
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
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 6
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "USUARIO MOVIMIENTO"
        Me.GridColumn6.FieldName = "f301_UsuarioMov"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 7
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "FECHA/HORA MOVIMIENTO"
        Me.GridColumn7.FieldName = "f301_FechaHoraMov"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 8
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "LOTE"
        Me.GridColumn8.FieldName = "f301_Lote"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        '
        'btnEliminarMovimientos
        '
        Me.btnEliminarMovimientos.ImageOptions.SvgImage = CType(resources.GetObject("btnEliminarMovimientos.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnEliminarMovimientos.Location = New System.Drawing.Point(8, 298)
        Me.btnEliminarMovimientos.Name = "btnEliminarMovimientos"
        Me.btnEliminarMovimientos.Size = New System.Drawing.Size(158, 46)
        Me.btnEliminarMovimientos.TabIndex = 184
        Me.btnEliminarMovimientos.Text = "Eliminar Movimientos"
        '
        'frmDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 659)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmDevoluciones.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDevoluciones"
        Me.Text = "Devoluciones"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoDoct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacenR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlmacenDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txt_SerialDevolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUbicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNroDocto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoDoct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlmacenR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAlmacenDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaProceso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTipoDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboLote As ComboBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMensaje As Label
    Friend WithEvents txtCantidadMovimiento As TextBox
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscarUbicacion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtUbicacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidadDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEliminarMovimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_SerialDevolucion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_SerialDevo As DevExpress.XtraEditors.LabelControl
End Class
