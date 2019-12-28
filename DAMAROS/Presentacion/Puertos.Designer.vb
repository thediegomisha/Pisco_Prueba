<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puertos
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
        Me.CBBaudiosA = New System.Windows.Forms.ComboBox()
        Me.CBParadaA = New System.Windows.Forms.ComboBox()
        Me.CBParidadA = New System.Windows.Forms.ComboBox()
        Me.CBDatosA = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBBaudioX = New System.Windows.Forms.ComboBox()
        Me.CBParadaX = New System.Windows.Forms.ComboBox()
        Me.CBParidadX = New System.Windows.Forms.ComboBox()
        Me.CBDatosX = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chk_xorella = New System.Windows.Forms.CheckBox()
        Me.chk_almacen = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBALMACEN = New System.Windows.Forms.ComboBox()
        Me.CBXORELLA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBHILANDERIA = New System.Windows.Forms.ComboBox()
        Me.chk_hilanderia = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CBDatosH = New System.Windows.Forms.ComboBox()
        Me.CBParidadH = New System.Windows.Forms.ComboBox()
        Me.CBParadaH = New System.Windows.Forms.ComboBox()
        Me.CBBaudiosH = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBBaudiosA
        '
        Me.CBBaudiosA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBaudiosA.FormattingEnabled = True
        Me.CBBaudiosA.Items.AddRange(New Object() {"1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me.CBBaudiosA.Location = New System.Drawing.Point(98, 240)
        Me.CBBaudiosA.Name = "CBBaudiosA"
        Me.CBBaudiosA.Size = New System.Drawing.Size(68, 21)
        Me.CBBaudiosA.TabIndex = 59
        '
        'CBParadaA
        '
        Me.CBParadaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParadaA.FormattingEnabled = True
        Me.CBParadaA.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.CBParadaA.Location = New System.Drawing.Point(267, 267)
        Me.CBParadaA.Name = "CBParadaA"
        Me.CBParadaA.Size = New System.Drawing.Size(46, 21)
        Me.CBParadaA.TabIndex = 58
        '
        'CBParidadA
        '
        Me.CBParidadA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParidadA.FormattingEnabled = True
        Me.CBParidadA.Items.AddRange(New Object() {"Par", "Impar", "Ninguno"})
        Me.CBParidadA.Location = New System.Drawing.Point(98, 267)
        Me.CBParidadA.Name = "CBParidadA"
        Me.CBParidadA.Size = New System.Drawing.Size(68, 21)
        Me.CBParidadA.TabIndex = 57
        '
        'CBDatosA
        '
        Me.CBDatosA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDatosA.FormattingEnabled = True
        Me.CBDatosA.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.CBDatosA.Location = New System.Drawing.Point(267, 240)
        Me.CBDatosA.Name = "CBDatosA"
        Me.CBDatosA.Size = New System.Drawing.Size(46, 21)
        Me.CBDatosA.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(187, 270)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Bit de Parada"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Paridad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(189, 246)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Bit de Datos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 246)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Baudios"
        '
        'CBBaudioX
        '
        Me.CBBaudioX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBaudioX.FormattingEnabled = True
        Me.CBBaudioX.Items.AddRange(New Object() {"1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me.CBBaudioX.Location = New System.Drawing.Point(98, 137)
        Me.CBBaudioX.Name = "CBBaudioX"
        Me.CBBaudioX.Size = New System.Drawing.Size(68, 21)
        Me.CBBaudioX.TabIndex = 51
        '
        'CBParadaX
        '
        Me.CBParadaX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParadaX.FormattingEnabled = True
        Me.CBParadaX.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.CBParadaX.Location = New System.Drawing.Point(267, 164)
        Me.CBParadaX.Name = "CBParadaX"
        Me.CBParadaX.Size = New System.Drawing.Size(46, 21)
        Me.CBParadaX.TabIndex = 50
        '
        'CBParidadX
        '
        Me.CBParidadX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParidadX.FormattingEnabled = True
        Me.CBParidadX.Items.AddRange(New Object() {"Par", "Impar", "Ninguno"})
        Me.CBParidadX.Location = New System.Drawing.Point(98, 164)
        Me.CBParidadX.Name = "CBParidadX"
        Me.CBParidadX.Size = New System.Drawing.Size(68, 21)
        Me.CBParidadX.TabIndex = 49
        '
        'CBDatosX
        '
        Me.CBDatosX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDatosX.FormattingEnabled = True
        Me.CBDatosX.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.CBDatosX.Location = New System.Drawing.Point(267, 137)
        Me.CBDatosX.Name = "CBDatosX"
        Me.CBDatosX.Size = New System.Drawing.Size(46, 21)
        Me.CBDatosX.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(187, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Bit de Parada"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Paridad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Bit de Datos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Baudios"
        '
        'chk_xorella
        '
        Me.chk_xorella.AutoSize = True
        Me.chk_xorella.Location = New System.Drawing.Point(304, 114)
        Me.chk_xorella.Name = "chk_xorella"
        Me.chk_xorella.Size = New System.Drawing.Size(15, 14)
        Me.chk_xorella.TabIndex = 42
        Me.chk_xorella.UseVisualStyleBackColor = True
        '
        'chk_almacen
        '
        Me.chk_almacen.AutoSize = True
        Me.chk_almacen.Location = New System.Drawing.Point(307, 210)
        Me.chk_almacen.Name = "chk_almacen"
        Me.chk_almacen.Size = New System.Drawing.Size(15, 14)
        Me.chk_almacen.TabIndex = 41
        Me.chk_almacen.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(137, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(221, 75)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Esta Ventana permite configurar los Puertos Serie de su sistema, Proceda con prec" & _
    "aucion, podría dejar el sistema inutilizable"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "&Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBALMACEN
        '
        Me.CBALMACEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBALMACEN.FormattingEnabled = True
        Me.CBALMACEN.Location = New System.Drawing.Point(171, 207)
        Me.CBALMACEN.Name = "CBALMACEN"
        Me.CBALMACEN.Size = New System.Drawing.Size(121, 21)
        Me.CBALMACEN.TabIndex = 35
        '
        'CBXORELLA
        '
        Me.CBXORELLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBXORELLA.FormattingEnabled = True
        Me.CBXORELLA.Location = New System.Drawing.Point(171, 110)
        Me.CBXORELLA.Name = "CBXORELLA"
        Me.CBXORELLA.Size = New System.Drawing.Size(121, 21)
        Me.CBXORELLA.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "BALANZA ALMACEN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BALANZA XORELLA"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(25, 406)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(319, 44)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Los cambios surtiran efecto, luego reiniciar la aplicacion. Cierre el Sistema y v" & _
    "uelva a ingresar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DAMARIS.My.Resources.Resources.ICUSB2322F_C
        Me.PictureBox1.Location = New System.Drawing.Point(26, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(23, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "BALANZA HILANDERIA"
        '
        'CBHILANDERIA
        '
        Me.CBHILANDERIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBHILANDERIA.FormattingEnabled = True
        Me.CBHILANDERIA.Location = New System.Drawing.Point(171, 309)
        Me.CBHILANDERIA.Name = "CBHILANDERIA"
        Me.CBHILANDERIA.Size = New System.Drawing.Size(121, 21)
        Me.CBHILANDERIA.TabIndex = 35
        '
        'chk_hilanderia
        '
        Me.chk_hilanderia.AutoSize = True
        Me.chk_hilanderia.Location = New System.Drawing.Point(307, 312)
        Me.chk_hilanderia.Name = "chk_hilanderia"
        Me.chk_hilanderia.Size = New System.Drawing.Size(15, 14)
        Me.chk_hilanderia.TabIndex = 41
        Me.chk_hilanderia.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 348)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Baudios"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(189, 348)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Bit de Datos"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 374)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Paridad"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(187, 372)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 55
        Me.Label21.Text = "Bit de Parada"
        '
        'CBDatosH
        '
        Me.CBDatosH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDatosH.FormattingEnabled = True
        Me.CBDatosH.Items.AddRange(New Object() {"4", "5", "6", "7", "8"})
        Me.CBDatosH.Location = New System.Drawing.Point(267, 342)
        Me.CBDatosH.Name = "CBDatosH"
        Me.CBDatosH.Size = New System.Drawing.Size(46, 21)
        Me.CBDatosH.TabIndex = 56
        '
        'CBParidadH
        '
        Me.CBParidadH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParidadH.FormattingEnabled = True
        Me.CBParidadH.Items.AddRange(New Object() {"Par", "Impar", "Ninguno"})
        Me.CBParidadH.Location = New System.Drawing.Point(98, 369)
        Me.CBParidadH.Name = "CBParidadH"
        Me.CBParidadH.Size = New System.Drawing.Size(68, 21)
        Me.CBParidadH.TabIndex = 57
        '
        'CBParadaH
        '
        Me.CBParadaH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBParadaH.FormattingEnabled = True
        Me.CBParadaH.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.CBParadaH.Location = New System.Drawing.Point(267, 369)
        Me.CBParadaH.Name = "CBParadaH"
        Me.CBParadaH.Size = New System.Drawing.Size(46, 21)
        Me.CBParadaH.TabIndex = 58
        '
        'CBBaudiosH
        '
        Me.CBBaudiosH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBaudiosH.FormattingEnabled = True
        Me.CBBaudiosH.Items.AddRange(New Object() {"1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000"})
        Me.CBBaudiosH.Location = New System.Drawing.Point(98, 342)
        Me.CBBaudiosH.Name = "CBBaudiosH"
        Me.CBBaudiosH.Size = New System.Drawing.Size(68, 21)
        Me.CBBaudiosH.TabIndex = 59
        '
        'Puertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 485)
        Me.Controls.Add(Me.CBBaudiosH)
        Me.Controls.Add(Me.CBBaudiosA)
        Me.Controls.Add(Me.CBParadaH)
        Me.Controls.Add(Me.CBParadaA)
        Me.Controls.Add(Me.CBParidadH)
        Me.Controls.Add(Me.CBParidadA)
        Me.Controls.Add(Me.CBDatosH)
        Me.Controls.Add(Me.CBDatosA)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CBBaudioX)
        Me.Controls.Add(Me.CBParadaX)
        Me.Controls.Add(Me.CBParidadX)
        Me.Controls.Add(Me.CBDatosX)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chk_xorella)
        Me.Controls.Add(Me.chk_hilanderia)
        Me.Controls.Add(Me.chk_almacen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBHILANDERIA)
        Me.Controls.Add(Me.CBALMACEN)
        Me.Controls.Add(Me.CBXORELLA)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Puertos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puertos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBBaudiosA As System.Windows.Forms.ComboBox
    Friend WithEvents CBParadaA As System.Windows.Forms.ComboBox
    Friend WithEvents CBParidadA As System.Windows.Forms.ComboBox
    Friend WithEvents CBDatosA As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBBaudioX As System.Windows.Forms.ComboBox
    Friend WithEvents CBParadaX As System.Windows.Forms.ComboBox
    Friend WithEvents CBParidadX As System.Windows.Forms.ComboBox
    Friend WithEvents CBDatosX As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_xorella As System.Windows.Forms.CheckBox
    Friend WithEvents chk_almacen As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CBALMACEN As System.Windows.Forms.ComboBox
    Friend WithEvents CBXORELLA As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBHILANDERIA As System.Windows.Forms.ComboBox
    Friend WithEvents chk_hilanderia As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBDatosH As System.Windows.Forms.ComboBox
    Friend WithEvents CBParidadH As System.Windows.Forms.ComboBox
    Friend WithEvents CBParadaH As System.Windows.Forms.ComboBox
    Friend WithEvents CBBaudiosH As System.Windows.Forms.ComboBox
End Class
