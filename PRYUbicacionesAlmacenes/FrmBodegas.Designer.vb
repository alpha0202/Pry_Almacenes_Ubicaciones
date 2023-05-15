<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBodegas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBodegas))
        Me.pnlBodega = New System.Windows.Forms.Panel()
        Me.tablaContenedora = New System.Windows.Forms.TableLayoutPanel()
        Me.flpFilas = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkRestablece = New System.Windows.Forms.CheckBox()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMateriales = New System.Windows.Forms.ComboBox()
        Me.txtCentroOpe = New System.Windows.Forms.TextBox()
        Me.cboCentroOpe = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtBodega = New System.Windows.Forms.TextBox()
        Me.cboBodega = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flpColumnas = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpGrupoCeldas = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlBodega.SuspendLayout()
        Me.tablaContenedora.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBodega
        '
        Me.pnlBodega.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlBodega.Controls.Add(Me.tablaContenedora)
        Me.pnlBodega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBodega.Location = New System.Drawing.Point(0, 0)
        Me.pnlBodega.Name = "pnlBodega"
        Me.pnlBodega.Size = New System.Drawing.Size(1754, 835)
        Me.pnlBodega.TabIndex = 0
        '
        'tablaContenedora
        '
        Me.tablaContenedora.ColumnCount = 2
        Me.tablaContenedora.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tablaContenedora.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablaContenedora.Controls.Add(Me.flpFilas, 0, 2)
        Me.tablaContenedora.Controls.Add(Me.Panel1, 1, 0)
        Me.tablaContenedora.Controls.Add(Me.flpColumnas, 1, 1)
        Me.tablaContenedora.Controls.Add(Me.flpGrupoCeldas, 1, 2)
        Me.tablaContenedora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablaContenedora.Location = New System.Drawing.Point(0, 0)
        Me.tablaContenedora.Name = "tablaContenedora"
        Me.tablaContenedora.RowCount = 3
        Me.tablaContenedora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.tablaContenedora.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablaContenedora.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablaContenedora.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tablaContenedora.Size = New System.Drawing.Size(1754, 835)
        Me.tablaContenedora.TabIndex = 0
        '
        'flpFilas
        '
        Me.flpFilas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpFilas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpFilas.Location = New System.Drawing.Point(3, 168)
        Me.flpFilas.Name = "flpFilas"
        Me.flpFilas.Size = New System.Drawing.Size(34, 664)
        Me.flpFilas.TabIndex = 1
        Me.flpFilas.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.chkRestablece)
        Me.Panel1.Controls.Add(Me.btnRestablecer)
        Me.Panel1.Controls.Add(Me.txtMaterial)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboMateriales)
        Me.Panel1.Controls.Add(Me.txtCentroOpe)
        Me.Panel1.Controls.Add(Me.cboCentroOpe)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(43, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1710, 109)
        Me.Panel1.TabIndex = 3
        '
        'chkRestablece
        '
        Me.chkRestablece.AutoSize = True
        Me.chkRestablece.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRestablece.Location = New System.Drawing.Point(1455, 58)
        Me.chkRestablece.Name = "chkRestablece"
        Me.chkRestablece.Size = New System.Drawing.Size(145, 17)
        Me.chkRestablece.TabIndex = 12
        Me.chkRestablece.Text = "Restablecer Ubicaciones"
        Me.chkRestablece.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRestablece.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.SystemColors.Control
        Me.btnRestablecer.Enabled = False
        Me.btnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRestablecer.FlatAppearance.BorderSize = 2
        Me.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRestablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestablecer.Location = New System.Drawing.Point(1494, 78)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(106, 28)
        Me.btnRestablecer.TabIndex = 11
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        Me.btnRestablecer.Visible = False
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(575, 73)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(38, 20)
        Me.txtMaterial.TabIndex = 8
        Me.txtMaterial.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Materiales"
        '
        'cboMateriales
        '
        Me.cboMateriales.FormattingEnabled = True
        Me.cboMateriales.Location = New System.Drawing.Point(136, 72)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(433, 21)
        Me.cboMateriales.TabIndex = 6
        '
        'txtCentroOpe
        '
        Me.txtCentroOpe.Location = New System.Drawing.Point(261, 24)
        Me.txtCentroOpe.Name = "txtCentroOpe"
        Me.txtCentroOpe.Size = New System.Drawing.Size(308, 20)
        Me.txtCentroOpe.TabIndex = 4
        '
        'cboCentroOpe
        '
        Me.cboCentroOpe.FormattingEnabled = True
        Me.cboCentroOpe.Location = New System.Drawing.Point(136, 24)
        Me.cboCentroOpe.Name = "cboCentroOpe"
        Me.cboCentroOpe.Size = New System.Drawing.Size(121, 21)
        Me.cboCentroOpe.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro Logístico"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.txtBodega)
        Me.GroupBox1.Controls.Add(Me.cboBodega)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1605, 49)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnFiltrar.Enabled = False
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnFiltrar.FlatAppearance.BorderSize = 2
        Me.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(1490, 9)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(107, 34)
        Me.btnFiltrar.TabIndex = 9
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtBodega
        '
        Me.txtBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBodega.Location = New System.Drawing.Point(1042, 16)
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(378, 20)
        Me.txtBodega.TabIndex = 5
        '
        'cboBodega
        '
        Me.cboBodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBodega.FormattingEnabled = True
        Me.cboBodega.Location = New System.Drawing.Point(859, 15)
        Me.cboBodega.Name = "cboBodega"
        Me.cboBodega.Size = New System.Drawing.Size(163, 21)
        Me.cboBodega.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(787, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Almacén:"
        '
        'flpColumnas
        '
        Me.flpColumnas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpColumnas.Location = New System.Drawing.Point(43, 118)
        Me.flpColumnas.Name = "flpColumnas"
        Me.flpColumnas.Size = New System.Drawing.Size(1710, 44)
        Me.flpColumnas.TabIndex = 0
        '
        'flpGrupoCeldas
        '
        Me.flpGrupoCeldas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.flpGrupoCeldas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpGrupoCeldas.Location = New System.Drawing.Point(43, 168)
        Me.flpGrupoCeldas.Name = "flpGrupoCeldas"
        Me.flpGrupoCeldas.Size = New System.Drawing.Size(1708, 664)
        Me.flpGrupoCeldas.TabIndex = 2
        '
        'FrmBodegas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1754, 835)
        Me.Controls.Add(Me.pnlBodega)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBodegas"
        Me.Text = "Mapa de Ubicaciones"
        Me.pnlBodega.ResumeLayout(False)
        Me.tablaContenedora.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBodega As Panel
    Friend WithEvents tablaContenedora As TableLayoutPanel
    Friend WithEvents flpFilas As FlowLayoutPanel
    Friend WithEvents flpGrupoCeldas As FlowLayoutPanel
    Friend WithEvents flpColumnas As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkRestablece As CheckBox
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboMateriales As ComboBox
    Friend WithEvents txtBodega As TextBox
    Friend WithEvents txtCentroOpe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboBodega As ComboBox
    Friend WithEvents cboCentroOpe As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFiltrar As Button
End Class
