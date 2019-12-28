Imports Devart.Data.MySql
Imports System.Text.RegularExpressions

Public Class rptXorella

    Dim fecha As String

    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

    Dim consultal As String
    Dim comandol As New MySqlCommand
    Dim adaptadorl As MySqlDataAdapter
    Dim datosl As New DataTable

    Dim consultap As String
    Dim comandop As New MySqlCommand
    Dim adaptadorp As MySqlDataAdapter
    Dim datosp As New DataTable

    Dim consultar As String
    Dim comandor As New MySqlCommand
    Dim adaptadorr As MySqlDataAdapter
    Dim datosr As New DataTable
    Private Sub rptXorella_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 120  ' Un segundo
        Timer1.Start()
        mostrarproductos()

        mostrarproceso()
        desactivarcombo()
    End Sub
    Sub mostrarconos()
        Try
            consulta = "select * from conos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
            adaptador.Fill(datos)
            dgvresultado.DataSource = datos
            ocultarcolumnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ocultarcolumnas()
        dgvresultado.Columns(0).Visible = False
        '    DataGridView1.Columns(2).Visible = False
    End Sub
    Private Sub mostrarproductos()
        Try
            consulta = "SELECT DISTINCT tit.idtitulo, CONCAT_WS(' ',tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO FROM tckxorella tk " &
                       "INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad " &
                       "INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
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
    Private Sub mostrarlotes()

        Dim cadena As String = cboproducto.Text
        'Split con expresión regular
        Dim regex As Regex = New Regex(" ")
        Dim vectoraux() As String
        vectoraux = regex.Split(cadena)


        Try
            If cboproducto.ValueMember.ToString <> Nothing Then

                Dim producto1 As String = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"

                consultal = "SELECT DISTINCT CONCAT_WS(' ',tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO, l.nombre AS LOTE" &
                            " FROM tckxorella tk " &
                            " INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad" &
                            " INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras" &
                            " INNER JOIN conos c1 ON tk.conos=c1.idconos " & producto1 & ""


                adaptadorl = New MySqlDataAdapter(consultal, conexion)
                datosl = New DataTable
                adaptadorl.Fill(datosl)

                With cbolote
                    If datosl.Rows.Count <> 0 Then
                        .DataSource = datosl
                        .DisplayMember = "LOTE"
                        '        .ValueMember = "l.idlote"
                        .SelectedIndex = -1

                    Else
                        .DataSource = Nothing
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarproceso()
        Try
            consultap = "SELECT tp.idtipoproceso, tp.nombre as PROCESO FROM tipoproceso tp"

            adaptadorp = New MySqlDataAdapter(consultap, conexion)
            datosp = New DataTable
            adaptadorp.Fill(datosp)

            With cboproceso
                If datosp.Rows.Count <> 0 Then
                    .DataSource = datosp
                    .DisplayMember = "PROCESO"
                    .ValueMember = "tp.idtipoproceso"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If
            End With
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
            Dim cadena As String = cboproducto.Text
            'Split con expresión regular
            Dim regex As Regex = New Regex(" ")
            Dim vectoraux() As String
            vectoraux = regex.Split(cadena)

            If chkproducto.Checked = True And chklote.Checked = True Then
                producto = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"
                lote = " and LOTE='" & cbolote.Text.ToString & "'"

            ElseIf chkproducto.Checked = True Then
                producto = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"

            ElseIf chklote.Checked = True Then
                lote = "WHERE LOTE='" & cbolote.Text.ToString & "'"

            End If

            consultar = "SELECT  tk.correlativo AS Id , CONCAT_WS(' ', tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO, " &
                       " l.nombre AS LOTE, c.numconera AS CONERA, tk.fpesaje, tk.correlativo AS CORRE, t.nombre AS TURNO, c1.numconos AS CANT, tk.ptara AS TARA, tk.pbruto AS BRUTO, tk.pneto AS NETO FROM tckxorella tk" &
                       " INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad" &
                       " INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras" &
                       " INNER JOIN  conos c1 ON tk.conos=c1.idconos  INNER JOIN turno t ON tk.turno = t.idturno " & producto + lote & ""

            adaptadorr = New MySqlDataAdapter(consultar, conexion)
            datosr = New DataTable
            adaptadorr.Fill(datosr)
            dgvresultado.DataSource = datosr
            contar()
            sumaconos()
            sumaneto()
            '   ocultarcolumnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub activarcombo()
        cboproducto.Enabled = True
        cbolote.Enabled = True
        cboproceso.Enabled = True
        cbovariedad.Enabled = True
        cboturno.Enabled = True
    End Sub
    Sub desactivarcombo()
        cboproducto.Enabled = False
        cbolote.Enabled = False
        cboproceso.Enabled = False
        cbovariedad.Enabled = False
        cboturno.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarresultado()
    End Sub
    Private Sub chkproducto_CheckStateChanged(sender As Object, e As EventArgs) Handles chkproducto.CheckStateChanged
        If chkproducto.Checked = True Then
            cboproducto.Enabled = True
            cboproducto.Text = Nothing
        Else
            cboproducto.Enabled = False
            cboproducto.Text = Nothing
        End If
    End Sub

    Private Sub chktodos_CheckedChanged(sender As Object, e As EventArgs) Handles chktodos.CheckedChanged
        If chktodos.Checked = True Then
            desactivarcombo()
        Else
            activarcombo()
        End If
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
    Sub sumaconos()
        Try
            totalconos.Text = (From row As DataGridViewRow In dgvresultado.Rows _
                           Where row.Cells(7).FormattedValue.ToString() _
                           <> String.Empty Select Convert.ToSingle(row.Cells(7).FormattedValue)).Sum().ToString()
            totalconos.Text = (totalconos.Text)
        Catch ex As Exception
        End Try
    End Sub
    Sub sumaneto()
        Try
            totalneto.Text = (From row As DataGridViewRow In dgvresultado.Rows _
                           Where row.Cells(10).FormattedValue.ToString() _
                           <> String.Empty Select Convert.ToSingle(row.Cells(10).FormattedValue)).Sum().ToString()
            totalneto.Text = FormatNumber(totalneto.Text, 2)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub sumaseleccion()
        ' añadir un contador para que autosume
        Try
            Dim suma As Double
            '   Dim num As Integer
            ' SOLO SUMARA SI SE SELECCIONA EN LA GRILLA SOLICITADA
            If dgvresultado.CurrentRow.Cells(7).Selected Or dgvresultado.CurrentRow.Cells(8).Selected _
                Or dgvresultado.CurrentRow.Cells(9).Selected Or dgvresultado.CurrentRow.Cells(10).Selected Then

                For Each celda As DataGridViewCell In dgvresultado.SelectedCells
                    suma = suma + Convert.ToDouble(celda.Value)
                Next
                lblsumaseleccion.Text = FormatNumber(suma.ToString, 2)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sumaseleccion()
    End Sub
    Private Sub cboproducto_TextChanged(sender As Object, e As EventArgs) Handles cboproducto.TextChanged
        If cboproducto.ValueMember.ToString <> Nothing And cboproducto.Text <> Nothing Then
            mostrarlotes()
        End If

    End Sub
End Class