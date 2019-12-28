Imports Devart.Data.MySql

Public Class Mermas

    '  Dim Recordar, Colocar, Escalar, colocando As String
    Dim strBufferEntrada As String

    Dim salidabalanza As String
    Dim stringinicio As String
    Dim mostrarcaracter As String
    Dim salidacontrol As String

    Dim POSICION_INICIAL As String

    Dim comando As New MySqlCommand

    Dim correlativo As Integer = 0
    Dim a, b, c, d As Integer

    Dim STX As String = Chr(&H2)
    Dim ETX As String = Chr(&H3)

    Dim S As String = Chr(&H53)  'HEXADECIMAL
    Dim T As String = Chr(&H54)  'HEXADECIMAL
    Dim U As String = Chr(&H55)
    Dim CR As String = Chr(&HD)
    Dim LF As String = Chr(&HA)
    Dim PUNTO As String = Chr(&H2E)
    Dim MAS As String = Chr(&H2B)


    Private Delegate Sub DelegadoAcceso(ByVal Adicionartexto As String)

    Private Sub Mermas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarserial()
        mostrarmerma()
        mostrarvariedad()
        mostrarlote()
    End Sub
    Private Sub AccesoFromPrincipal(ByVal TextoForm As String)
        '--------------------------------
        '--------------------------------
        '' ''CADENA A ANALIZAR POR CORREGIR SECUENCIA
        '' '' ASCII     :    US,GS    84.4,kg
        '' '' ASCII     :    U   S  ,  G  S               8  4  .  4    k  g CR LF
        '' '' HEX       :    55 53 2C 47 53 20 20 20 31 30 37 2E 32 2C 6B 67 0D 0A
        Try
            If TextoForm <> Nothing Then
                POSICION_INICIAL = (InStr(TextoForm, PUNTO))
                stringinicio = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 6), 18)
                If stringinicio.StartsWith(S + T) Then
                    Dim textoini As String = Nothing
                    textoini = Microsoft.VisualBasic.Left(stringinicio, 2)
                    If textoini = S + T Then
                        Label13.Visible = True
                        Label14.Visible = False
                        Label13.Text = "ST"
                        mostrarcaracter = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 12), 8)
                        lblpeso.Text = mostrarcaracter.Replace("+", " ") ' funcion REPLACE, REEMPLAZA EL SIGNO + POR UN ESPACIO EN BLANCO 05/12/19
                    End If

                ElseIf stringinicio.StartsWith(U + S) Then
                    Dim textoini As String = Nothing
                    textoini = Microsoft.VisualBasic.Left(stringinicio, 2)
                    If textoini = U + S Then
                        Label13.Visible = False
                        Label14.Visible = True
                        Label14.Text = "US"

                        mostrarcaracter = Microsoft.VisualBasic.Mid(TextoForm, (POSICION_INICIAL + 12), 8)
                        lblpeso.Text = mostrarcaracter.Replace("+", " ")
                    End If

                    ' ENVIA LA SALIDA A LBLTODO SI ES DIFERENTE DE VACIO
                Else
                    sppuerto.DiscardInBuffer()
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
    Sub conectarserial()
        Try
            Dim nompuerto As String = My.Settings.select_bal2
            Dim baudios As String = My.Settings.BaudiosA
            Dim bit_datos As String = My.Settings.bitdatosA
            Dim paridad As String = My.Settings.ParidadA
            Dim bit_parada As String = My.Settings.ParadaA

            With sppuerto
                .PortName = nompuerto
                .BaudRate = baudios
                .DataBits = bit_datos
                .Parity = paridad
                .StopBits = bit_parada
                .DiscardNull = True
                .ReceivedBytesThreshold = 36
                .ReadBufferSize = 48
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
            MsgBox("AUN NO SE HA CONFIGURADO EL PUERTO SERIE", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BalanzaHilo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sppuerto.IsOpen Then
            sppuerto.Close()
            Me.Close()
        End If
    End Sub
    Private Sub mostrarmerma()
        Try
            Dim consulta As String = "select idmerma, nombre  from merma ORDER BY 1 asc"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cbomermas

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "nombre"
                    .ValueMember = "idmerma"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarvariedad()
        Try
            Dim consulta As String = "select idvariedad, nombre  from variedad ORDER BY 1 asc"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
            adaptador.Fill(datos)

            With cbovariedad

                If datos.Rows.Count <> 0 Then
                    .DataSource = datos
                    .DisplayMember = "nombre"
                    .ValueMember = "idvariedad"
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
                    'Dim dr As DataRow = datosL.NewRow()
                    'dr("idlote") = 0
                    'dr("nombres") = "Nuevo ..."
                    'datosL.Rows.InsertAt(dr, 0)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If cbomermas.Text = Nothing Then
                MsgBox("TIENE QUE SELECCIONAR UN PRODUCTO !!!")
            Else

                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If

                If cbomermas.ValueMember <> Nothing Then

                    Dim comando = New MySqlCommand("INSERT INTO tckmerma (nombre, variedad, fechapesaje, fechaproducido, turno, lote, operario, usuario, pbruto, ptara, pneto)" & Chr(13) &
                                               "VALUES(@nombre, @variedad, @fechapesaje, @fechaproducido, @turno, @lote, @operario, @usuario, @pbruto, @ptara, @pneto )", conexion)

                    comando.Parameters.AddWithValue("@producto", CInt(cbomermas.SelectedValue))
                    comando.Parameters.AddWithValue("@variedad", CInt(cbolote.SelectedValue))
                    comando.Parameters.AddWithValue("@fechapesaje", CDate(DateTimePicker1.Text))
                    comando.Parameters.AddWithValue("@fechaproducido", CDate(DateTimePicker1.Text))
                    comando.Parameters.AddWithValue("@turno", CInt(cboturno.SelectedValue))
                    comando.Parameters.AddWithValue("@lote", CInt(cbolote.SelectedValue))
                    comando.Parameters.AddWithValue("@operario", CInt(cbolote.SelectedValue)) 'por revisar
                    comando.Parameters.AddWithValue("@usuario", CInt(cbolote.SelectedValue))  'por revisar

                    If lblpeso.Text > 0 Then
                        comando.Parameters.AddWithValue("@pbruto", CDbl(lblpeso.Text))
                        comando.Parameters.AddWithValue("@ptara", CInt(0.03))
                        comando.Parameters.AddWithValue("@pneto", (Convert.ToDouble(lblpeso.Text) - (Convert.ToDouble(0.03))))

                    End If

                    comando.ExecuteNonQuery()
                    '  mostrarproductos()
                    '    recuperacorrelativo()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub
End Class