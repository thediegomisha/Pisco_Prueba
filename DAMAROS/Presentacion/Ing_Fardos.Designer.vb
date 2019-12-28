<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ing_Fardos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbolote = New System.Windows.Forms.ComboBox()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.cbotcompra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalfardo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttara = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpesoproveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpesoneto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpesopagar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvresultado = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcontar = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbltotalfardos = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblpesoneto = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblpesoapagar = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltotalkilos = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbolote
        '
        Me.cbolote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolote.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolote.FormattingEnabled = True
        Me.cbolote.Location = New System.Drawing.Point(47, 50)
        Me.cbolote.Name = "cbolote"
        Me.cbolote.Size = New System.Drawing.Size(89, 26)
        Me.cbolote.TabIndex = 9
        '
        'cboproveedor
        '
        Me.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproveedor.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(355, 51)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(174, 26)
        Me.cboproveedor.TabIndex = 11
        '
        'cbotcompra
        '
        Me.cbotcompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotcompra.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotcompra.FormattingEnabled = True
        Me.cbotcompra.Location = New System.Drawing.Point(594, 53)
        Me.cbotcompra.Name = "cbotcompra"
        Me.cbotcompra.Size = New System.Drawing.Size(144, 26)
        Me.cbotcompra.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PROVEEDOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TIPO DE COMPRA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TOTAL FARDOS"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 26)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(227, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "FECHA"
        '
        'txttotalfardo
        '
        Me.txttotalfardo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalfardo.Location = New System.Drawing.Point(47, 119)
        Me.txttotalfardo.Name = "txttotalfardo"
        Me.txttotalfardo.Size = New System.Drawing.Size(80, 26)
        Me.txttotalfardo.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TARA QQ"
        '
        'txttara
        '
        Me.txttara.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttara.Location = New System.Drawing.Point(168, 119)
        Me.txttara.Name = "txttara"
        Me.txttara.Size = New System.Drawing.Size(80, 26)
        Me.txttara.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PESO PROVEEDOR"
        '
        'txtpesoproveedor
        '
        Me.txtpesoproveedor.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesoproveedor.Location = New System.Drawing.Point(296, 119)
        Me.txtpesoproveedor.Name = "txtpesoproveedor"
        Me.txtpesoproveedor.Size = New System.Drawing.Size(80, 26)
        Me.txtpesoproveedor.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PESO NETO QQ"
        '
        'txtpesoneto
        '
        Me.txtpesoneto.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesoneto.Location = New System.Drawing.Point(425, 119)
        Me.txtpesoneto.Name = "txtpesoneto"
        Me.txtpesoneto.Size = New System.Drawing.Size(80, 26)
        Me.txtpesoneto.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(552, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PESO POR PAGAR"
        '
        'txtpesopagar
        '
        Me.txtpesopagar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpesopagar.Location = New System.Drawing.Point(555, 119)
        Me.txtpesopagar.Name = "txtpesopagar"
        Me.txtpesopagar.Size = New System.Drawing.Size(80, 26)
        Me.txtpesopagar.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvresultado)
        Me.Panel1.Location = New System.Drawing.Point(12, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 284)
        Me.Panel1.TabIndex = 66
        '
        'dgvresultado
        '
        Me.dgvresultado.AllowUserToAddRows = False
        Me.dgvresultado.AllowUserToDeleteRows = False
        Me.dgvresultado.AllowUserToResizeColumns = False
        Me.dgvresultado.AllowUserToResizeRows = False
        Me.dgvresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvresultado.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvresultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvresultado.Location = New System.Drawing.Point(0, 0)
        Me.dgvresultado.Name = "dgvresultado"
        Me.dgvresultado.ReadOnly = True
        Me.dgvresultado.RowHeadersVisible = False
        Me.dgvresultado.Size = New System.Drawing.Size(869, 284)
        Me.dgvresultado.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "ITEMS :"
        '
        'lblcontar
        '
        Me.lblcontar.AutoSize = True
        Me.lblcontar.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontar.ForeColor = System.Drawing.Color.Red
        Me.lblcontar.Location = New System.Drawing.Point(73, 466)
        Me.lblcontar.Name = "lblcontar"
        Me.lblcontar.Size = New System.Drawing.Size(87, 22)
        Me.lblcontar.TabIndex = 68
        Me.lblcontar.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(227, 470)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "TOTAL FARDOS :"
        '
        'lbltotalfardos
        '
        Me.lbltotalfardos.AutoSize = True
        Me.lbltotalfardos.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalfardos.ForeColor = System.Drawing.Color.Red
        Me.lbltotalfardos.Location = New System.Drawing.Point(353, 465)
        Me.lbltotalfardos.Name = "lbltotalfardos"
        Me.lbltotalfardos.Size = New System.Drawing.Size(87, 22)
        Me.lbltotalfardos.TabIndex = 70
        Me.lbltotalfardos.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(471, 469)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "PESO NETO QQ :"
        '
        'lblpesoneto
        '
        Me.lblpesoneto.AutoSize = True
        Me.lblpesoneto.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesoneto.ForeColor = System.Drawing.Color.Red
        Me.lblpesoneto.Location = New System.Drawing.Point(591, 465)
        Me.lblpesoneto.Name = "lblpesoneto"
        Me.lblpesoneto.Size = New System.Drawing.Size(87, 22)
        Me.lblpesoneto.TabIndex = 72
        Me.lblpesoneto.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(689, 469)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 16)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "PESO POR PAGAR :"
        '
        'lblpesoapagar
        '
        Me.lblpesoapagar.AutoSize = True
        Me.lblpesoapagar.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesoapagar.ForeColor = System.Drawing.Color.Red
        Me.lblpesoapagar.Location = New System.Drawing.Point(821, 465)
        Me.lblpesoapagar.Name = "lblpesoapagar"
        Me.lblpesoapagar.Size = New System.Drawing.Size(87, 22)
        Me.lblpesoapagar.TabIndex = 74
        Me.lblpesoapagar.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(680, 125)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "Label18"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(886, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 46)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(886, 166)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 38)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(790, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 79
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(886, 222)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 38)
        Me.btnGrabar.TabIndex = 18
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(891, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 81
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(264, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(422, 25)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "REGISTRO DE FARDOS DE ALGODON"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(293, 501)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 16)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "TOTAL KILOS FIBRA:"
        '
        'lbltotalkilos
        '
        Me.lbltotalkilos.AutoSize = True
        Me.lbltotalkilos.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalkilos.ForeColor = System.Drawing.Color.Red
        Me.lbltotalkilos.Location = New System.Drawing.Point(447, 498)
        Me.lbltotalkilos.Name = "lbltotalkilos"
        Me.lbltotalkilos.Size = New System.Drawing.Size(87, 22)
        Me.lbltotalkilos.TabIndex = 70
        Me.lbltotalkilos.Text = "Label13"
        '
        'Ing_Fardos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 526)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblpesoapagar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblpesoneto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbltotalkilos)
        Me.Controls.Add(Me.lbltotalfardos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblcontar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpesopagar)
        Me.Controls.Add(Me.txtpesoneto)
        Me.Controls.Add(Me.txtpesoproveedor)
        Me.Controls.Add(Me.txttara)
        Me.Controls.Add(Me.txttotalfardo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbotcompra)
        Me.Controls.Add(Me.cboproveedor)
        Me.Controls.Add(Me.cbolote)
        Me.Name = "Ing_Fardos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvresultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbolote As System.Windows.Forms.ComboBox
    Friend WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbotcompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotalfardo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttara As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpesoproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpesoneto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtpesopagar As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvresultado As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblcontar As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbltotalfardos As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblpesoneto As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblpesoapagar As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbltotalkilos As System.Windows.Forms.Label
End Class
