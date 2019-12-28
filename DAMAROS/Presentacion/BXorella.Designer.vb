<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BXorella
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
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.cbolote = New System.Windows.Forms.ComboBox()
        Me.cboconos = New System.Windows.Forms.ComboBox()
        Me.cboconera = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.cbturno = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TURNO = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkcapturapeso = New System.Windows.Forms.CheckBox()
        Me.rbcplastico = New System.Windows.Forms.RadioButton()
        Me.rbccarton = New System.Windows.Forms.RadioButton()
        Me.rbpaleta = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblpeso = New System.Windows.Forms.Label()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblpesotara = New System.Windows.Forms.Label()
        Me.lblpesobruto = New System.Windows.Forms.Label()
        Me.lblpesoneto = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblcorrelativo = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboproducto
        '
        Me.cboproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproducto.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(38, 48)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(294, 26)
        Me.cboproducto.TabIndex = 0
        '
        'cbolote
        '
        Me.cbolote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolote.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolote.FormattingEnabled = True
        Me.cbolote.Location = New System.Drawing.Point(38, 111)
        Me.cbolote.Name = "cbolote"
        Me.cbolote.Size = New System.Drawing.Size(121, 26)
        Me.cbolote.TabIndex = 1
        '
        'cboconos
        '
        Me.cboconos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboconos.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconos.FormattingEnabled = True
        Me.cboconos.Location = New System.Drawing.Point(38, 176)
        Me.cboconos.Name = "cboconos"
        Me.cboconos.Size = New System.Drawing.Size(121, 26)
        Me.cboconos.TabIndex = 2
        '
        'cboconera
        '
        Me.cboconera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboconera.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconera.FormattingEnabled = True
        Me.cboconera.Location = New System.Drawing.Point(38, 258)
        Me.cboconera.Name = "cboconera"
        Me.cboconera.Size = New System.Drawing.Size(121, 26)
        Me.cboconera.TabIndex = 3
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(657, 103)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox5.TabIndex = 4
        '
        'cbturno
        '
        Me.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbturno.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbturno.FormattingEnabled = True
        Me.cbturno.Location = New System.Drawing.Point(407, 111)
        Me.cbturno.Name = "cbturno"
        Me.cbturno.Size = New System.Drawing.Size(105, 26)
        Me.cbturno.TabIndex = 5
        '
        'ComboBox7
        '
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(657, 152)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox7.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "LOTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CONOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CONERA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(404, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FECHA PESAJE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PESO TARA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(404, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "PESO BRUTO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(680, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "PESO NETO"
        '
        'TURNO
        '
        Me.TURNO.AutoSize = True
        Me.TURNO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TURNO.Location = New System.Drawing.Point(404, 90)
        Me.TURNO.Name = "TURNO"
        Me.TURNO.Size = New System.Drawing.Size(58, 18)
        Me.TURNO.TabIndex = 15
        Me.TURNO.Text = "TURNO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(407, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 26)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnimprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(949, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(97, 536)
        Me.Panel1.TabIndex = 17
        '
        'chkcapturapeso
        '
        Me.chkcapturapeso.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkcapturapeso.AutoSize = True
        Me.chkcapturapeso.Location = New System.Drawing.Point(518, 304)
        Me.chkcapturapeso.Name = "chkcapturapeso"
        Me.chkcapturapeso.Size = New System.Drawing.Size(72, 23)
        Me.chkcapturapeso.TabIndex = 18
        Me.chkcapturapeso.Text = "CheckBox1"
        Me.chkcapturapeso.UseVisualStyleBackColor = True
        '
        'rbcplastico
        '
        Me.rbcplastico.AutoSize = True
        Me.rbcplastico.Location = New System.Drawing.Point(278, 258)
        Me.rbcplastico.Name = "rbcplastico"
        Me.rbcplastico.Size = New System.Drawing.Size(111, 17)
        Me.rbcplastico.TabIndex = 19
        Me.rbcplastico.TabStop = True
        Me.rbcplastico.Text = "CONO PLASTICO"
        Me.rbcplastico.UseVisualStyleBackColor = True
        '
        'rbccarton
        '
        Me.rbccarton.AutoSize = True
        Me.rbccarton.Location = New System.Drawing.Point(278, 281)
        Me.rbccarton.Name = "rbccarton"
        Me.rbccarton.Size = New System.Drawing.Size(104, 17)
        Me.rbccarton.TabIndex = 20
        Me.rbccarton.TabStop = True
        Me.rbccarton.Text = "CONO CARTON"
        Me.rbccarton.UseVisualStyleBackColor = True
        '
        'rbpaleta
        '
        Me.rbpaleta.AutoSize = True
        Me.rbpaleta.Location = New System.Drawing.Point(278, 304)
        Me.rbpaleta.Name = "rbpaleta"
        Me.rbpaleta.Size = New System.Drawing.Size(66, 17)
        Me.rbpaleta.TabIndex = 21
        Me.rbpaleta.TabStop = True
        Me.rbpaleta.Text = "PALETA"
        Me.rbpaleta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblpeso)
        Me.GroupBox3.Location = New System.Drawing.Point(374, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(558, 148)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(66, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 27)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "US"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(20, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 27)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "ST"
        '
        'lblpeso
        '
        Me.lblpeso.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 84.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpeso.ForeColor = System.Drawing.Color.Lime
        Me.lblpeso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblpeso.Location = New System.Drawing.Point(3, 16)
        Me.lblpeso.Name = "lblpeso"
        Me.lblpeso.Size = New System.Drawing.Size(552, 129)
        Me.lblpeso.TabIndex = 44
        Me.lblpeso.Text = "+00000.0"
        Me.lblpeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sppuerto
        '
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(538, 9)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(50, 13)
        Me.lblestado.TabIndex = 50
        Me.lblestado.Text = "STATUS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(61, 376)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Label9"
        '
        'lblpesotara
        '
        Me.lblpesotara.AutoSize = True
        Me.lblpesotara.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesotara.Location = New System.Drawing.Point(61, 337)
        Me.lblpesotara.Name = "lblpesotara"
        Me.lblpesotara.Size = New System.Drawing.Size(38, 18)
        Me.lblpesotara.TabIndex = 15
        Me.lblpesotara.Text = "0.0"
        '
        'lblpesobruto
        '
        Me.lblpesobruto.AutoSize = True
        Me.lblpesobruto.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesobruto.Location = New System.Drawing.Point(404, 337)
        Me.lblpesobruto.Name = "lblpesobruto"
        Me.lblpesobruto.Size = New System.Drawing.Size(38, 18)
        Me.lblpesobruto.TabIndex = 15
        Me.lblpesobruto.Text = "0.0"
        '
        'lblpesoneto
        '
        Me.lblpesoneto.AutoSize = True
        Me.lblpesoneto.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesoneto.Location = New System.Drawing.Point(680, 337)
        Me.lblpesoneto.Name = "lblpesoneto"
        Me.lblpesoneto.Size = New System.Drawing.Size(18, 18)
        Me.lblpesoneto.TabIndex = 15
        Me.lblpesoneto.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 431)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Label9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(404, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 18)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "ID :"
        '
        'lblcorrelativo
        '
        Me.lblcorrelativo.AutoSize = True
        Me.lblcorrelativo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrelativo.Location = New System.Drawing.Point(485, 160)
        Me.lblcorrelativo.Name = "lblcorrelativo"
        Me.lblcorrelativo.Size = New System.Drawing.Size(28, 18)
        Me.lblcorrelativo.TabIndex = 15
        Me.lblcorrelativo.Text = "00"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.Location = New System.Drawing.Point(0, 281)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(96, 83)
        Me.btn_cancelar.TabIndex = 91
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnguardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = Global.DAMARIS.My.Resources.Resources.Save_as_37111_1_
        Me.btnguardar.Location = New System.Drawing.Point(0, 53)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 84)
        Me.btnguardar.TabIndex = 89
        Me.btnguardar.Text = "GRABAR"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.Image = Global.DAMARIS.My.Resources.Resources.printerprint_9416_1_
        Me.btnimprimir.Location = New System.Drawing.Point(1, 161)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(96, 84)
        Me.btnimprimir.TabIndex = 90
        Me.btnimprimir.Text = "IMPRIMIR"
        Me.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(669, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(669, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Label14"
        '
        'BXorella
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 536)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.rbpaleta)
        Me.Controls.Add(Me.rbccarton)
        Me.Controls.Add(Me.rbcplastico)
        Me.Controls.Add(Me.chkcapturapeso)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblpesoneto)
        Me.Controls.Add(Me.lblpesobruto)
        Me.Controls.Add(Me.lblpesotara)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblcorrelativo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TURNO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.cbturno)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.cboconera)
        Me.Controls.Add(Me.cboconos)
        Me.Controls.Add(Me.cbolote)
        Me.Controls.Add(Me.cboproducto)
        Me.KeyPreview = True
        Me.Name = "BXorella"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BXorella"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboproducto As System.Windows.Forms.ComboBox
    Friend WithEvents cbolote As System.Windows.Forms.ComboBox
    Friend WithEvents cboconos As System.Windows.Forms.ComboBox
    Friend WithEvents cboconera As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbturno As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TURNO As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkcapturapeso As System.Windows.Forms.CheckBox
    Friend WithEvents rbcplastico As System.Windows.Forms.RadioButton
    Friend WithEvents rbccarton As System.Windows.Forms.RadioButton
    Friend WithEvents rbpaleta As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpeso As System.Windows.Forms.Label
    Friend WithEvents sppuerto As System.IO.Ports.SerialPort
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblpesotara As System.Windows.Forms.Label
    Friend WithEvents lblpesobruto As System.Windows.Forms.Label
    Friend WithEvents lblpesoneto As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblcorrelativo As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
