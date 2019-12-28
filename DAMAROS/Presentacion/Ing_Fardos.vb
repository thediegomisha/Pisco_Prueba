Imports Devart.Data.MySql
Imports System.Text.RegularExpressions

Public Class Ing_Fardos

    'Dim consultaL As String
    'Dim comandoL As New MySqlCommand
    'Dim adaptadorL As MySqlDataAdapter
    'Dim datosL As New DataTable

    Private Sub Ing_Fardos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlote()
        mostrarcompra()
    End Sub
    Private Sub mostrarlote()
        Try
            Dim consultaL As String = "select idlote, CONCAT_WS(' ' , nombre)AS nombres from lote WHERE estado='A' ORDER BY idlote DESC"
            Dim adaptadorL = New MySqlDataAdapter(consultaL, conexion)
            Dim datosL = New DataTable
            adaptadorL.Fill(datosL)

            With cbolote

                If datosL.Rows.Count <> 0 Then
                    Dim dr As DataRow = datosL.NewRow()
                    dr("idlote") = 0
                    dr("nombres") = "Nuevo ..."
                    datosL.Rows.InsertAt(dr, 0)

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

    Private Sub mostrarcompra()
        Try
            Dim consultaTC As String = "select idtipocompra, nombre from tipocompra ORDER BY idtipocompra DESC"
            Dim adaptadorTC = New MySqlDataAdapter(consultaTC, conexion)
            Dim datosTC = New DataTable
            adaptadorTC.Fill(datosTC)

            With cbotcompra

                If datosTC.Rows.Count <> 0 Then
                    Dim dr As DataRow = datosTC.NewRow()
                    dr("idtipocompra") = 0
                    dr("nombre") = "Nuevo ..."
                    datosTC.Rows.InsertAt(dr, 0)

                    .DataSource = datosTC
                    .DisplayMember = "nombre"
                    .ValueMember = "idtipocompra"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbolote_DropDownClosed(sender As Object, e As EventArgs) Handles cbolote.DropDownClosed
        Try
            If cbolote.Text = "Nuevo ..." Then
                MantoLote.ShowDialog()
                'LLENARCOMBOLOTE()
                'Form_Crear_lote.combocliente.Text = combocliente.Text
                mostrarlote()
                cbolote.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbotcompra_DropDownClosed(sender As Object, e As EventArgs) Handles cbotcompra.DropDownClosed
        Try
            If cbotcompra.Text = "Nuevo ..." Then
                MantoTCompra.ShowDialog()
                'LLENARCOMBOLOTE()
                'Form_Crear_lote.combocliente.Text = combocliente.Text
                mostrarcompra()
                cbotcompra.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mostrarresultado()
        Dim producto As String = Nothing
        Dim lote As String = Nothing
        Dim proceso As String = Nothing
        Dim variedad As String = Nothing
        Dim turno As Integer = Nothing

        Try
            ''Dim cadena As String = cboproducto.Text
            ''Split con expresión regular
            'Dim regex As Regex = New Regex(" ")
            'Dim vectoraux() As String
            'vectoraux = regex.Split(cadena)

            'If chkproducto.Checked = True And chklote.Checked = True Then
            '    producto = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"
            '    lote = " and LOTE='" & cbolote.Text.ToString & "'"

            'ElseIf chkproducto.Checked = True Then
            '    producto = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"

            'ElseIf chklote.Checked = True Then
            '    lote = "WHERE LOTE='" & cbolote.Text.ToString & "'"

            'End If

            'Dim consultar As String = "SELECT  tk.correlativo AS Id , CONCAT_WS(' ', tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO, " &
            '           " l.nombre AS LOTE, c.numconera AS CONERA, tk.fpesaje, c1.numconos AS CANT, tk.ptara AS TARA, tk.pbruto AS BRUTO, tk.pneto AS NETO FROM tckxorella tk" &
            '           " INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad" &
            '           " INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras" &
            '           " INNER JOIN  conos c1 ON tk.conos=c1.idconos " & producto + lote & ""

            Dim consultar As String = "SELECT l.nombre AS LOTE, tf.fecha AS FECHA, tf.proveedor AS PROVEEDOR, tc.nombre AS T_COMPRA, " &
                                      " tf.totalfardos AS T_FARDO, tf.tara AS TARA, tf.pesoproveedor AS P_PRO, tf.pesoneto AS P_NETO, tf.pesoapagar AS P_PAGAR" &
                                      " FROM tckfardo tf INNER JOIN lote l ON tf.lote=l.idlote " &
                                      "INNER JOIN tipocompra tc ON tf.tipocompra=tc.idtipocompra"

            Dim adaptadorr = New MySqlDataAdapter(consultar, conexion)
            Dim datosr = New DataTable
            adaptadorr.Fill(datosr)
            dgvresultado.DataSource = datosr
            contar()
            sumatodos()
            'sumaneto()
            ' ocultarcolumnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarresultado()
    End Sub
    Sub ocultarcolumnas()
        dgvresultado.Columns(0).Visible = False
        '    DataGridView1.Columns(2).Visible = False
    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If cbolote.Text = Nothing Then
                MsgBox("TIENE QUE SELECCIONAR UN LOTE !!!")
            Else

                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If

                If cbolote.ValueMember <> Nothing Then

                    Dim comando = New MySqlCommand("INSERT INTO tckfardo(lote, fecha,  tipocompra, totalfardos, tara, pesoproveedor, pesoneto, pesoapagar)" & Chr(13) &
                                               "VALUES(@lote, @fecha, @tipocompra, @totalfardos, @tara, @pesoproveedor, @pesoneto, @pesoapagar)", conexion)

                    'Dim comando = New MySqlCommand("INSERT INTO tckfardo(lote, fecha, proveedor, tipocompra, totalfardos, tara, pesoproveedor, pesoneto, pesoapagar)" & Chr(13) &
                    '                                               "VALUES(@lote, @fecha, @proveedor, @tipocompra, @totalfardos, @tara, @pesoproveedor, @pesoneto, @pesoapagar)", conexion)

                    comando.Parameters.AddWithValue("@lote", CInt(cbolote.SelectedValue))
                    comando.Parameters.AddWithValue("@fecha", CDate(DateTimePicker1.Text))
                    'If cboproveedor.Text <> Nothing Then
                    '    comando.Parameters.AddWithValue("@proveedor", CInt(cboproveedor.SelectedValue))
                    'Else
                    '    comando.Parameters.AddWithValue("@proveedor", 0)
                    'End If

                    comando.Parameters.AddWithValue("@tipocompra", CInt(cbotcompra.SelectedValue))
                    comando.Parameters.AddWithValue("@totalfardos", CDbl(txttotalfardo.Text))
                    comando.Parameters.AddWithValue("@tara", CDbl(txttara.Text))
                    comando.Parameters.AddWithValue("@pesoproveedor", CDbl(txtpesoproveedor.Text))
                    comando.Parameters.AddWithValue("@pesoneto", CDbl(txtpesoneto.Text))
                    comando.Parameters.AddWithValue("@pesoapagar", CDbl(txtpesopagar.Text))

                    comando.ExecuteNonQuery()
                    mostrarresultado()
                    'recuperacorrelativo()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim i As Integer
            i = dgvresultado.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Dim comando = New MySqlCommand("delete from tckfardo WHERE idtckfardo='" & dgvresultado.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarresultado()

        Catch ex As Exception

        End Try
    End Sub
    Sub contar()
        Dim contarfila As Integer = dgvresultado.RowCount - 1
        Dim contador As Integer = 0
        While (contarfila >= 0)
            contador = contador + 1
            contarfila = contarfila - 1
        End While
        LBLCONTAR.Text = contador
    End Sub
    Sub sumatodos()
        Try
            lblpesoapagar.Text = (From row As DataGridViewRow In dgvresultado.Rows _
                           Where row.Cells(8).FormattedValue.ToString() _
                           <> String.Empty Select Convert.ToSingle(row.Cells(8).FormattedValue)).Sum().ToString()

            lblpesoneto.Text = (From row As DataGridViewRow In dgvresultado.Rows _
                           Where row.Cells(7).FormattedValue.ToString() _
                           <> String.Empty Select Convert.ToSingle(row.Cells(7).FormattedValue)).Sum().ToString()

            lbltotalfardos.Text = (From row As DataGridViewRow In dgvresultado.Rows _
                           Where row.Cells(4).FormattedValue.ToString() _
                           <> String.Empty Select Convert.ToSingle(row.Cells(4).FormattedValue)).Sum().ToString()

            lblpesoapagar.Text = (lblpesoapagar.Text)
            lblpesoneto.Text = (lblpesoneto.Text)
            lbltotalfardos.Text = (lbltotalfardos.Text)
            lbltotalkilos.Text = FormatNumber(CDbl(lblpesoneto.Text) * 46, 2) + " KG "


        Catch ex As Exception
        End Try
    End Sub
End Class