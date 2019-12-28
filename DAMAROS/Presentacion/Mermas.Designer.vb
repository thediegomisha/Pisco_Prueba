<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mermas
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
        Me.cbomermas = New System.Windows.Forms.ComboBox()
        Me.cbovariedad = New System.Windows.Forms.ComboBox()
        Me.cboturno = New System.Windows.Forms.ComboBox()
        Me.cbolote = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblpeso = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.lblestado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbomermas
        '
        Me.cbomermas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomermas.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomermas.FormattingEnabled = True
        Me.cbomermas.Location = New System.Drawing.Point(35, 50)
        Me.cbomermas.Name = "cbomermas"
        Me.cbomermas.Size = New System.Drawing.Size(176, 30)
        Me.cbomermas.TabIndex = 0
        '
        'cbovariedad
        '
        Me.cbovariedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovariedad.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovariedad.FormattingEnabled = True
        Me.cbovariedad.Location = New System.Drawing.Point(268, 50)
        Me.cbovariedad.Name = "cbovariedad"
        Me.cbovariedad.Size = New System.Drawing.Size(176, 30)
        Me.cbovariedad.TabIndex = 0
        '
        'cboturno
        '
        Me.cboturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboturno.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboturno.FormattingEnabled = True
        Me.cboturno.Location = New System.Drawing.Point(35, 114)
        Me.cboturno.Name = "cboturno"
        Me.cboturno.Size = New System.Drawing.Size(176, 30)
        Me.cboturno.TabIndex = 0
        '
        'cbolote
        '
        Me.cbolote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolote.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolote.FormattingEnabled = True
        Me.cbolote.Location = New System.Drawing.Point(268, 114)
        Me.cbolote.Name = "cbolote"
        Me.cbolote.Size = New System.Drawing.Size(176, 30)
        Me.cbolote.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(508, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 26)
        Me.DateTimePicker1.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(507, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "FECHA PESADO"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.lblpeso)
        Me.GroupBox3.Location = New System.Drawing.Point(65, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(581, 190)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Aqua
        Me.Label14.Location = New System.Drawing.Point(60, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 31)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "US"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(18, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 31)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "ST"
        '
        'lblpeso
        '
        Me.lblpeso.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpeso.ForeColor = System.Drawing.Color.Lime
        Me.lblpeso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblpeso.Location = New System.Drawing.Point(3, 16)
        Me.lblpeso.Name = "lblpeso"
        Me.lblpeso.Size = New System.Drawing.Size(575, 171)
        Me.lblpeso.TabIndex = 44
        Me.lblpeso.Text = "000000.0"
        Me.lblpeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(793, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 492)
        Me.Panel1.TabIndex = 64
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(11, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 53)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "LIMPIAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.DAMARIS.My.Resources.Resources.Save_as_37111_1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(13, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 73)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "GRABAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'sppuerto
        '
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(416, 9)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(39, 13)
        Me.lblestado.TabIndex = 65
        Me.lblestado.Text = "Label6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "TIPO DE MERMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "VARIEDAD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "LOTE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(99, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "TURNO"
        '
        'Mermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 492)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbolote)
        Me.Controls.Add(Me.cboturno)
        Me.Controls.Add(Me.cbovariedad)
        Me.Controls.Add(Me.cbomermas)
        Me.Name = "Mermas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mermas"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbomermas As System.Windows.Forms.ComboBox
    Friend WithEvents cbovariedad As System.Windows.Forms.ComboBox
    Friend WithEvents cboturno As System.Windows.Forms.ComboBox
    Friend WithEvents cbolote As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblpeso As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents sppuerto As System.IO.Ports.SerialPort
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
