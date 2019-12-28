Imports Devart.Data.MySql
Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Public Class BXorella

    Dim contador As Integer = 0
    Dim correlativo As Integer = 0
    Dim aux As Integer

    Dim Recordar, Colocar, Escalar As String
    Dim strBufferEntrada As String

    Dim HORA1, HORA2, HORA3 As DateTime
    Dim HORA, DIFERENCIA, TIEMPOT As TimeSpan

    Dim a1, b1, c1, d1, e2, f1, g1, h1 As Integer

    Dim a, b, c, d As Integer

    Dim POSICION_INICIAL As String
    Dim stringinicio As String
    Dim mostrarcaracter As String
    Dim salidacontrol As String

    Dim S As String = Chr(&H53)  'HEXADECIMAL
    Dim T As String = Chr(&H54)  'HEXADECIMAL
    Dim U As String = Chr(&H55)
    Dim CR As String = Chr(&HD)
    Dim LF As String = Chr(&HA)
    Dim PUNTO As String = Chr(&H2E)
    Dim MAS As String = Chr(&H2B)

    Dim CONOPLASTICO As Double = 0.06
    Dim CONOCARTON As Double = 0.03
    Dim BOLSAPLASTICA As Double = 0.2

    Private Delegate Sub DelegadoAcceso(ByVal Adicionartexto As String)
    Private Sub AccesoFromPrincipal(ByVal TextoForm As String)
        '--------------------------------
        '--------------------------------
        '' ''CADENA A ANALIZAR POR CORREGIR SECUENCIA
        '' '' ASCII     :    US,GS    84.4,kg
        '' '' ASCII     :    U   S  ,  G  S               8  4  .  4    k  g CR LF
        '' '' HEX       :    55 53 2C 47 53 20 20 20 31 30 37 2E 32 2C 6B 67 0D 0A
        '' '' CANTIDAD  :    01 02 03 04 05 06 07 08 09 10 11 12 13 14 15 16 17 18
        Try
            If TextoForm <> Nothing Then
                POSICION_INICIAL = (InStr(TextoForm, PUNTO))
                stringinicio = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 7), 18)
                If stringinicio.StartsWith(S + T) Then
                    Dim textoini As String = Nothing
                    textoini = Microsoft.VisualBasic.Left(stringinicio, 2)
                    If textoini = S + T Then
                        Label10.Visible = True
                        Label11.Visible = False
                        Label10.Text = "ST"

                        Label12.Text = TextoForm
                        mostrarcaracter = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 12), 8)
                        lblpeso.Text = mostrarcaracter.Replace("+", " ") ' funcion REPLACE, REEMPLAZA EL SIGNO + POR UN ESPACIO EN BLANCO 05/12/19

                        '' ''If rbpaleta.Checked = True And cboconos.Text = "192" Then
                        '' ''    Dim sumapaleta As Double = CInt(cboconos.Text) * CONOPLASTICO
                        '' ''    lblpesotara.Text = CDbl(sumapaleta) + CDbl(lblpeso.Text)
                        '' ''End If

                        '' ''If chkcapturapeso.Checked = True Then
                        '' ''    lblpesobruto.Text = lblpeso.Text
                        '' ''    lblpesoneto.Text = CDbl(lblpesobruto.Text) - CDbl(lblpesotara.Text)
                        '' ''End If

                        If cboconos.Text <> Nothing And rbpaleta.Checked = True Then
                            If rbpaleta.Checked = True And cboconos.Text = "192" And chkcapturapeso.Checked = False Then
                                Dim sumapaleta As Double = CInt(cboconos.Text) * CONOPLASTICO
                                lblpesotara.Text = CDbl(sumapaleta) + CDbl(lblpeso.Text)
                            Else
                                lblpesobruto.Text = lblpeso.Text
                                lblpesoneto.Text = CDbl(lblpesobruto.Text) - CDbl(lblpesotara.Text)
                            End If
                        ElseIf cboconos.Text <> Nothing And rbcplastico.Checked = True Then
                            If rbcplastico.Checked = True And cboconos.Text <> "192" Then
                                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOPLASTICO)
                            End If
                        ElseIf cboconos.Text <> Nothing And rbccarton.Checked = True Then
                            If rbccarton.Checked = True And cboconos.Text <> "192" Then
                                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOCARTON)
                            End If

                        End If
                        
                    End If

                ElseIf stringinicio.StartsWith(U + S) Then
                    Dim textoini As String = Nothing
                    textoini = Microsoft.VisualBasic.Left(stringinicio, 2)
                    If textoini = U + S Then
                        Label10.Visible = False
                        Label11.Visible = True
                        Label11.Text = "US"

                        Label12.Text = TextoForm
                        mostrarcaracter = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 12), 8)
                        lblpeso.Text = mostrarcaracter.Replace("+", " ")





                        If cboconos.Text <> Nothing And rbpaleta.Checked = True Then
                            If rbpaleta.Checked = True And cboconos.Text = "192" And chkcapturapeso.Checked = False Then
                                Dim sumapaleta As Double = CInt(cboconos.Text) * CONOPLASTICO
                                lblpesotara.Text = CDbl(sumapaleta) + CDbl(lblpeso.Text)
                            Else
                                lblpesobruto.Text = lblpeso.Text
                                lblpesoneto.Text = CDbl(lblpesobruto.Text) - CDbl(lblpesotara.Text)
                            End If
                        ElseIf cboconos.Text <> Nothing And rbcplastico.Checked = True Then
                            If rbcplastico.Checked = True And cboconos.Text <> "192" Then
                                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOPLASTICO)
                            End If
                        ElseIf cboconos.Text <> Nothing And rbccarton.Checked = True Then
                            If rbccarton.Checked = True And cboconos.Text <> "192" Then
                                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOCARTON)
                            End If

                        End If





                    End If

                    ' ENVIA LA SALIDA A LBLTODO SI ES DIFERENTE DE VACIO
                Else
                    sppuerto.DiscardInBuffer()
                    Label9.Text = TextoForm
                End If
            Else
                lblpeso.Text = ("REVISE CONEXION")
            End If
            '--------------------------------
            '--------------------------------
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PuertaAccesoInterrupcion(ByVal BufferIn As String)
        Dim TextoInterrupcion() As Object = {BufferIn}
        Dim DelegadoInterrupcion As DelegadoAcceso
        DelegadoInterrupcion = New DelegadoAcceso(AddressOf AccesoFromPrincipal)
        MyBase.BeginInvoke(DelegadoInterrupcion, TextoInterrupcion)
    End Sub
    Private Sub DatosRecibidos(ByVal sender As Object, ByVal e As IO.Ports.SerialDataReceivedEventArgs) Handles sppuerto.DataReceived
        Dim DatoInterrupcion As String
        Try
            DatoInterrupcion = sppuerto.ReadExisting
            PuertaAccesoInterrupcion(DatoInterrupcion)
        Catch ex As Exception
            MsgBox("ERROR DATOS INTERRUPCION")
        End Try
    End Sub
    Private Sub BXorella_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If sppuerto.IsOpen Then
            sppuerto.Close()
            Me.Close()
        End If
    End Sub

    Private Sub BXorella_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub BXorella_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarserial()
        mostrarproducto()
        mostrarlote()
        mostrarconos()
        mostrarconera()
        mostrarturno()
    End Sub

    Sub conectarserial()
        Try
            Dim nompuerto As String = My.Settings.select_bal1
            Dim baudios As String = My.Settings.BaudioG
            Dim bit_datos As String = My.Settings.bitdatosG
            Dim paridad As String = My.Settings.ParidadG
            Dim bit_parada As String = My.Settings.ParadaG

            With sppuerto
                .PortName = nompuerto
                .BaudRate = baudios
                .DataBits = bit_datos
                .Parity = paridad
                .StopBits = bit_parada
                .DiscardNull = True
                .ReceivedBytesThreshold = 36
                .ReadBufferSize = 36
                '   .ReadTimeout = 500
                .Open()
                If .IsOpen Then
                    lblestado.Text = "CONECTADO A LA BALANZA SATISFACTORIAMENTE !!!"
                Else
                    MsgBox("CONEXION FALLIDA!", MsgBoxStyle.Critical)
                    .Close()
                End If
            End With
        Catch ex As Exception
            MsgBox("AUN NO SE HA CONFIGURADO EL PUERTO SERIE !!!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mostrarconera()
        Try
            Dim consulta As String = "select idconeras, numconera  from coneras ORDER BY 1 asc"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cboconera

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "numconera"
                    .ValueMember = "idconeras"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarRegistro()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Dim comando = New MySqlCommand("INSERT INTO tckxorella (producto, lote, conera, fpesaje, correlativo, turno, conos, ptara, pbruto, pneto)" & Chr(13) &
                                       "VALUES(@producto, @lote, @conera, @fpesaje, @correlativo, @turno, @conos, @ptara, @pbruto, @pneto)", conexion)

            comando.Parameters.AddWithValue("@producto", cboproducto.DisplayMember)
            comando.Parameters.AddWithValue("@lote", cbolote.SelectedValue)
            comando.Parameters.AddWithValue("@conera", cboconera.SelectedValue)
            comando.Parameters.AddWithValue("@fpesaje", CDate(DateTimePicker1.Text))

            comando.Parameters.AddWithValue("@correlativo", lblcorrelativo.Text)
            comando.Parameters.AddWithValue("@turno", cbturno.SelectedValue)
            comando.Parameters.AddWithValue("@conos", cboconos.SelectedValue)
            comando.Parameters.AddWithValue("@ptara", CDbl(lblpesotara.Text))

            comando.Parameters.AddWithValue("@pbruto", lblpesobruto.Text)
            comando.Parameters.AddWithValue("@pneto", lblpesoneto.Text)

            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'cuentacorrelativo_BG()
    End Sub


    Private Sub mostrarturno()
        Try
            Dim consulta As String = "SELECT idturno, nombre FROM turno"

            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cbturno

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "nombre"
                    .ValueMember = "idturno"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarproducto()
        Try
            Dim consulta As String = "SELECT DISTINCT tit.idtitulo,  CONCAT_WS(' ',tit.nombre, v.nombre, tp.nombre)NOMBRE_PRODUCTO " &
                                     " FROM tckxorella tk INNER JOIN producto p ON tk.producto=p.idproducto " &
                                     " INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad" &
                                     " INNER JOIN tipoproceso tp ON p.tipoproceso=tp.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote" &
                                     " INNER JOIN coneras c ON tk.conera=c.idconeras "

            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cboproducto

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "NOMBRE_PRODUCTO"
                    .ValueMember = "tit.idtitulo"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarconos()
        Try
            Dim consulta As String = "select idconos, numconos  from conos ORDER BY 1 asc"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cboconos

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "numconos"
                    .ValueMember = "idconos"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mostrarlote()
        Try
            Dim consultaL As String = "select idlote, CONCAT_WS(' ' , nombre)AS nombres from lote WHERE estado='A' ORDER BY idlote DESC"
            Dim adaptadorL = New MySqlDataAdapter(consultaL, conexion)
            Dim datosL = New DataTable
            adaptadorL.Fill(datosL)

            With cbolote

                If datosL.Rows.Count <> 0 Then
                    .DataSource = datosL
                    .DisplayMember = "nombres"
                    .ValueMember = "idlote"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub rbcplastico_CheckedChanged(sender As Object, e As EventArgs) Handles rbcplastico.CheckedChanged
        Try
            If rbcplastico.Checked = True Then
                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOPLASTICO)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rbccarton_CheckedChanged(sender As Object, e As EventArgs) Handles rbccarton.CheckedChanged
        Try
            If rbccarton.Checked = True Then
                lblpesotara.Text = BOLSAPLASTICA + (CInt(cboconos.Text) * CONOCARTON)
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub chkcapturapeso_CheckedChanged(sender As Object, e As EventArgs) Handles chkcapturapeso.CheckedChanged
        Try
            If chkcapturapeso.Checked = True Then
                chkcapturapeso.Text = "CAPTURANDO ..."
                lblpesobruto.Text = lblpeso.Text
                lblpesoneto.Text = CDbl(lblpesobruto.Text) - CDbl(lblpesotara.Text)
            Else
                chkcapturapeso.Text = "PESO"
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub rbpaleta_CheckedChanged(sender As Object, e As EventArgs) Handles rbpaleta.CheckedChanged
        ' Try
        If rbpaleta.Checked = True And cboconos.Text = "192" And chkcapturapeso.Checked = False Then
            If CDbl(lblpeso.Text) > 0 Then
                Dim sumapaleta As Double = CInt(cboconos.Text) * CONOPLASTICO
                lblpesotara.Text = CDbl(sumapaleta) + CDbl(lblpeso.Text)
            End If

        End If
        ' Catch ex As Exception

        ' End Try

    End Sub

    Private Sub cboconos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboconos.SelectedIndexChanged
        If cboconos.Text = "192" Then
            rbpaleta.Enabled = True
            rbccarton.Enabled = False
            rbccarton.Checked = False
            rbcplastico.Enabled = False
            rbcplastico.Checked = False
        Else
            rbpaleta.Enabled = False
            rbpaleta.Checked = False
            rbccarton.Enabled = True
            rbcplastico.Enabled = True
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        InsertarRegistro()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click, Label15.Click

    End Sub

    Private Sub cboproducto_DropDownClosed(sender As Object, e As EventArgs) Handles cboproducto.DropDownClosed
        '  Label14.Text = cboproducto.SelectedValue.ToString
        ' Label15.Text = cboproducto.SelectedText


    End Sub

End Class