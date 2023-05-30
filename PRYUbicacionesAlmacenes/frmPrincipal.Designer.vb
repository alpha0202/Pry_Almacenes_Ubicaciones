Partial Public Class frmPrincipal
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonTraslados = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonTrasladoAlmacenes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.BarVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.BarHeaderItem2 = New DevExpress.XtraBars.BarHeaderItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarSubItem1, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarSubItem2, Me.BarButtonTraslados, Me.BarButtonTrasladoAlmacenes, Me.BarHeaderItem1, Me.BarVersion, Me.BarHeaderItem2})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarAppearance.Normal.Options.UseImage = True
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me.Bar1.Text = "Herramientas"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Recepción"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Devoluciones"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Traslados"
        Me.BarSubItem2.Id = 6
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonTraslados), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonTrasladoAlmacenes)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonTraslados
        '
        Me.BarButtonTraslados.Caption = "Por Ubicación"
        Me.BarButtonTraslados.Id = 7
        Me.BarButtonTraslados.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonTraslados.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonTraslados.Name = "BarButtonTraslados"
        '
        'BarButtonTrasladoAlmacenes
        '
        Me.BarButtonTrasladoAlmacenes.Caption = "A Almacenes diferentes"
        Me.BarButtonTrasladoAlmacenes.Id = 8
        Me.BarButtonTrasladoAlmacenes.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonTrasladoAlmacenes.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonTrasladoAlmacenes.Name = "BarButtonTrasladoAlmacenes"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tablas Parametricas"
        Me.BarSubItem1.Id = 2
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Cargar Materiales"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Mapa de Ubicaciones"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarHeaderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarHeaderItem2)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BarHeaderItem1.Appearance.Options.UseBackColor = True
        Me.BarHeaderItem1.Caption = "Versión:"
        Me.BarHeaderItem1.Id = 9
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'BarVersion
        '
        Me.BarVersion.Id = 10
        Me.BarVersion.Name = "BarVersion"
        '
        'BarHeaderItem2
        '
        Me.BarHeaderItem2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.BarHeaderItem2.Appearance.Options.UseBackColor = True
        Me.BarHeaderItem2.Caption = "versión"
        Me.BarHeaderItem2.Id = 11
        Me.BarHeaderItem2.Name = "BarHeaderItem2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.barDockControlTop.Size = New System.Drawing.Size(855, 21)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 364)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.barDockControlBottom.Size = New System.Drawing.Size(855, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 21)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 343)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(855, 21)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(2)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 343)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Traslados"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 387)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmPrincipal.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonTraslados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonTrasladoAlmacenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents BarVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarHeaderItem2 As DevExpress.XtraBars.BarHeaderItem

#End Region

End Class
