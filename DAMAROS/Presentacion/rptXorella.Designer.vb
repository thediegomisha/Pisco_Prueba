<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptXorella
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvresultado = New System.Windows.Forms.DataGridView()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.cbolote = New System.Windows.Forms.ComboBox()
        Me.cboproceso = New System.Windows.Forms.ComboBox()
        Me.cbovariedad = New System.Windows.Forms.ComboBox()
        Me.cboturno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chktodos = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chklote = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.chkproducto = New System.Windows.Forms.CheckBox()
        Me.LBLCONTAR = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.totalconos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsumaseleccion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.totalneto = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvresultado)
        Me.Panel1.Location = New System.Drawing.Point(359, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 386)
        Me.Panel1.TabIndex = 0
        '
        'dgvresultado
        '
        Me.dgvresultado.AllowUserToAddRows = False
        Me.dgvresultado.AllowUserToDeleteRows = False
        Me.dgvresultado.AllowUserToResizeColumns = False
        Me.dgvresultado.AllowUserToResizeRows = False
        Me.dgvresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvresultado.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvresultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvresultado.Location = New System.Drawing.Point(0, 0)
        Me.dgvresultado.Name = "dgvresultado"
        Me.dgvresultado.ReadOnly = True
        Me.dgvresultado.RowHeadersVisible = False
        Me.dgvresultado.Size = New System.Drawing.Size(839, 386)
        Me.dgvresultado.TabIndex = 0
        '
        'cboproducto
        '
        Me.cboproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(29, 35)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(212, 24)
        Me.cboproducto.TabIndex = 1
        '
        'cbolote
        '
        Me.cbolote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolote.FormattingEnabled = True
        Me.cbolote.Location = New System.Drawing.Point(29, 85)
        Me.cbolote.Name = "cbolote"
        Me.cbolote.Size = New System.Drawing.Size(121, 24)
        Me.cbolote.TabIndex = 2
        '
        'cboproceso
        '
        Me.cboproceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproceso.FormattingEnabled = True
        Me.cboproceso.Location = New System.Drawing.Point(29, 130)
        Me.cboproceso.Name = "cboproceso"
        Me.cboproceso.Size = New System.Drawing.Size(121, 24)
        Me.cboproceso.TabIndex = 3
        '
        'cbovariedad
        '
        Me.cbovariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovariedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovariedad.FormattingEnabled = True
        Me.cbovariedad.Location = New System.Drawing.Point(29, 176)
        Me.cbovariedad.Name = "cbovariedad"
        Me.cbovariedad.Size = New System.Drawing.Size(121, 24)
        Me.cbovariedad.TabIndex = 4
        '
        'cboturno
        '
        Me.cboturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboturno.FormattingEnabled = True
        Me.cboturno.Location = New System.Drawing.Point(29, 232)
        Me.cboturno.Name = "cboturno"
        Me.cboturno.Size = New System.Drawing.Size(121, 24)
        Me.cboturno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "LOTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PROCESO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "VARIEDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TURNO"
        '
        'chktodos
        '
        Me.chktodos.AutoSize = True
        Me.chktodos.Location = New System.Drawing.Point(407, 5)
        Me.chktodos.Name = "chktodos"
        Me.chktodos.Size = New System.Drawing.Size(89, 17)
        Me.chktodos.TabIndex = 11
        Me.chktodos.Text = "VER TODOS"
        Me.chktodos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(44, 294)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(166, 294)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chklote
        '
        Me.chklote.AutoSize = True
        Me.chklote.Location = New System.Drawing.Point(173, 85)
        Me.chklote.Name = "chklote"
        Me.chklote.Size = New System.Drawing.Size(101, 17)
        Me.chklote.TabIndex = 14
        Me.chklote.Text = "SELECCIONAR"
        Me.chklote.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(174, 131)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "SELECCIONAR"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(173, 178)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "SELECCIONAR"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(173, 239)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox4.TabIndex = 17
        Me.CheckBox4.Text = "SELECCIONAR"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'chkproducto
        '
        Me.chkproducto.AutoSize = True
        Me.chkproducto.Location = New System.Drawing.Point(252, 35)
        Me.chkproducto.Name = "chkproducto"
        Me.chkproducto.Size = New System.Drawing.Size(101, 17)
        Me.chkproducto.TabIndex = 18
        Me.chkproducto.Text = "SELECCIONAR"
        Me.chkproducto.UseVisualStyleBackColor = True
        '
        'LBLCONTAR
        '
        Me.LBLCONTAR.AutoSize = True
        Me.LBLCONTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCONTAR.Location = New System.Drawing.Point(503, 429)
        Me.LBLCONTAR.Name = "LBLCONTAR"
        Me.LBLCONTAR.Size = New System.Drawing.Size(21, 24)
        Me.LBLCONTAR.TabIndex = 19
        Me.LBLCONTAR.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(403, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Resultado : "
        '
        'totalconos
        '
        Me.totalconos.AutoSize = True
        Me.totalconos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalconos.Location = New System.Drawing.Point(759, 429)
        Me.totalconos.Name = "totalconos"
        Me.totalconos.Size = New System.Drawing.Size(21, 24)
        Me.totalconos.TabIndex = 21
        Me.totalconos.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(651, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Total Conos: "
        '
        'lblsumaseleccion
        '
        Me.lblsumaseleccion.AutoSize = True
        Me.lblsumaseleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsumaseleccion.Location = New System.Drawing.Point(129, 425)
        Me.lblsumaseleccion.Name = "lblsumaseleccion"
        Me.lblsumaseleccion.Size = New System.Drawing.Size(21, 24)
        Me.lblsumaseleccion.TabIndex = 23
        Me.lblsumaseleccion.Text = "0"
        '
        'Timer1
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Label10"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(207, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Label11"
        '
        'totalneto
        '
        Me.totalneto.AutoSize = True
        Me.totalneto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalneto.Location = New System.Drawing.Point(986, 424)
        Me.totalneto.Name = "totalneto"
        Me.totalneto.Size = New System.Drawing.Size(21, 24)
        Me.totalneto.TabIndex = 28
        Me.totalneto.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(867, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Total P. Neto"
        '
        'rptXorella
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 458)
        Me.Controls.Add(Me.totalneto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblsumaseleccion)
        Me.Controls.Add(Me.totalconos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLCONTAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkproducto)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.chklote)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.chktodos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboturno)
        Me.Controls.Add(Me.cbovariedad)
        Me.Controls.Add(Me.cboproceso)
        Me.Controls.Add(Me.cbolote)
        Me.Controls.Add(Me.cboproducto)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "rptXorella"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptXorella"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvresultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvresultado As System.Windows.Forms.DataGridView
    Friend WithEvents cboproducto As System.Windows.Forms.ComboBox
    Friend WithEvents cbolote As System.Windows.Forms.ComboBox
    Friend WithEvents cboproceso As System.Windows.Forms.ComboBox
    Friend WithEvents cbovariedad As System.Windows.Forms.ComboBox
    Friend WithEvents cboturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chktodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chklote As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkproducto As System.Windows.Forms.CheckBox
    Friend WithEvents LBLCONTAR As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents totalconos As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblsumaseleccion As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents totalneto As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
