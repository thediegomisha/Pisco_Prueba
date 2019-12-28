<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoMermaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONERAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XORELLAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALMACENGENERALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TEJEDURIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HILANDERIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCCIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarMermasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarFardosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.RegistroToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1035, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuertosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PuertosToolStripMenuItem
        '
        Me.PuertosToolStripMenuItem.Name = "PuertosToolStripMenuItem"
        Me.PuertosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.PuertosToolStripMenuItem.Text = "Puertos"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearProductoToolStripMenuItem, Me.CrearItemsToolStripMenuItem, Me.CrearProveedoresToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'CrearProductoToolStripMenuItem
        '
        Me.CrearProductoToolStripMenuItem.Name = "CrearProductoToolStripMenuItem"
        Me.CrearProductoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CrearProductoToolStripMenuItem.Text = "Crear Producto"
        '
        'CrearItemsToolStripMenuItem
        '
        Me.CrearItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.LoteToolStripMenuItem, Me.ConosToolStripMenuItem, Me.ProcesoToolStripMenuItem, Me.VariedadToolStripMenuItem, Me.TipoMermaToolStripMenuItem, Me.CompraToolStripMenuItem, Me.MaquinasToolStripMenuItem, Me.TurnoToolStripMenuItem})
        Me.CrearItemsToolStripMenuItem.Name = "CrearItemsToolStripMenuItem"
        Me.CrearItemsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CrearItemsToolStripMenuItem.Text = "Crear Items"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductoToolStripMenuItem.Text = "Titulo"
        '
        'LoteToolStripMenuItem
        '
        Me.LoteToolStripMenuItem.Name = "LoteToolStripMenuItem"
        Me.LoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoteToolStripMenuItem.Text = "Lote"
        '
        'ConosToolStripMenuItem
        '
        Me.ConosToolStripMenuItem.Name = "ConosToolStripMenuItem"
        Me.ConosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ConosToolStripMenuItem.Text = "Conos"
        '
        'ProcesoToolStripMenuItem
        '
        Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
        Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProcesoToolStripMenuItem.Text = "Proceso"
        '
        'VariedadToolStripMenuItem
        '
        Me.VariedadToolStripMenuItem.Name = "VariedadToolStripMenuItem"
        Me.VariedadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VariedadToolStripMenuItem.Text = "Variedad"
        '
        'TipoMermaToolStripMenuItem
        '
        Me.TipoMermaToolStripMenuItem.Name = "TipoMermaToolStripMenuItem"
        Me.TipoMermaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoMermaToolStripMenuItem.Text = "Tipo Merma"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'MaquinasToolStripMenuItem
        '
        Me.MaquinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONERAToolStripMenuItem, Me.CARDAToolStripMenuItem})
        Me.MaquinasToolStripMenuItem.Name = "MaquinasToolStripMenuItem"
        Me.MaquinasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MaquinasToolStripMenuItem.Text = "Maquinas"
        '
        'CONERAToolStripMenuItem
        '
        Me.CONERAToolStripMenuItem.Name = "CONERAToolStripMenuItem"
        Me.CONERAToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CONERAToolStripMenuItem.Text = "CONERA"
        '
        'CARDAToolStripMenuItem
        '
        Me.CARDAToolStripMenuItem.Name = "CARDAToolStripMenuItem"
        Me.CARDAToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.CARDAToolStripMenuItem.Text = "CARDA"
        '
        'CrearProveedoresToolStripMenuItem
        '
        Me.CrearProveedoresToolStripMenuItem.Name = "CrearProveedoresToolStripMenuItem"
        Me.CrearProveedoresToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CrearProveedoresToolStripMenuItem.Text = "Crear Proveedores"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XORELLAToolStripMenuItem, Me.ALMACENGENERALToolStripMenuItem, Me.TEJEDURIAToolStripMenuItem, Me.HILANDERIAToolStripMenuItem, Me.PRODUCCIONToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'XORELLAToolStripMenuItem
        '
        Me.XORELLAToolStripMenuItem.Name = "XORELLAToolStripMenuItem"
        Me.XORELLAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.XORELLAToolStripMenuItem.Text = "XORELLA"
        '
        'ALMACENGENERALToolStripMenuItem
        '
        Me.ALMACENGENERALToolStripMenuItem.Name = "ALMACENGENERALToolStripMenuItem"
        Me.ALMACENGENERALToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ALMACENGENERALToolStripMenuItem.Text = "ALMACEN GENERAL"
        '
        'TEJEDURIAToolStripMenuItem
        '
        Me.TEJEDURIAToolStripMenuItem.Name = "TEJEDURIAToolStripMenuItem"
        Me.TEJEDURIAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TEJEDURIAToolStripMenuItem.Text = "TEJEDURIA"
        '
        'HILANDERIAToolStripMenuItem
        '
        Me.HILANDERIAToolStripMenuItem.Name = "HILANDERIAToolStripMenuItem"
        Me.HILANDERIAToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.HILANDERIAToolStripMenuItem.Text = "HILANDERIA"
        '
        'PRODUCCIONToolStripMenuItem
        '
        Me.PRODUCCIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem})
        Me.PRODUCCIONToolStripMenuItem.Name = "PRODUCCIONToolStripMenuItem"
        Me.PRODUCCIONToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PRODUCCIONToolStripMenuItem.Text = "PRODUCCION"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarMermasToolStripMenuItem, Me.ToolStripMenuItem1, Me.RegistrarFardosToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'RegistrarMermasToolStripMenuItem
        '
        Me.RegistrarMermasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PESOSToolStripMenuItem})
        Me.RegistrarMermasToolStripMenuItem.Name = "RegistrarMermasToolStripMenuItem"
        Me.RegistrarMermasToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RegistrarMermasToolStripMenuItem.Text = "Registrar Mermas"
        '
        'PESOSToolStripMenuItem
        '
        Me.PESOSToolStripMenuItem.Name = "PESOSToolStripMenuItem"
        Me.PESOSToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PESOSToolStripMenuItem.Text = "PESOS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuItem1.Text = "BalanzaHilo"
        '
        'RegistrarFardosToolStripMenuItem
        '
        Me.RegistrarFardosToolStripMenuItem.Name = "RegistrarFardosToolStripMenuItem"
        Me.RegistrarFardosToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RegistrarFardosToolStripMenuItem.Text = "Registrar Fardos"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator2})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1035, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 444)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1035, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 466)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuertosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VariedadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaquinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONERAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CARDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XORELLAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALMACENGENERALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TEJEDURIAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HILANDERIAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCCIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarMermasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PESOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoMermaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarFardosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
