Imports Devart.Data.MySql
Imports System.Text.RegularExpressions

Public Class RptGeneral

    'Dim consulta As String
    'Dim comando As New MySqlCommand
    ' Dim adaptador As MySqlDataAdapter
    'Dim datos As New DataTable

    Private Sub RptGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarproductos()
    End Sub
    Private Sub mostrarproductos()
        Try
            Dim consulta As String = "SELECT DISTINCT tit.idtitulo, CONCAT_WS(' ',tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO FROM tckxorella tk " &
                       "INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad " &
                       "INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras"
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
    Private Sub mostrarlotes()

        Dim cadena As String = cboproducto.Text
        'Split con expresión regular
        Dim regex As Regex = New Regex(" ")
        Dim vectoraux() As String
        vectoraux = regex.Split(cadena)


        Try
            If cboproducto.ValueMember.ToString <> Nothing Then

                Dim producto1 As String = "WHERE tit.nombre='" & vectoraux(0) + " " + vectoraux(1) & "' AND v.nombre='" & vectoraux(2) & "' AND t1.nombre='" & vectoraux(3) & "'"

                Dim consultal As String = "SELECT DISTINCT CONCAT_WS(' ',tit.nombre, v.nombre, t1.nombre)NOMBRE_PRODUCTO, l.nombre AS LOTE" &
                            " FROM tckxorella tk " &
                            " INNER JOIN producto p ON tk.producto=p.idproducto INNER JOIN titulo tit ON p.titulo=tit.idtitulo INNER JOIN variedad v ON p.variedad=v.idvariedad" &
                            " INNER JOIN tipoproceso t1 ON p.tipoproceso=t1.idtipoproceso INNER JOIN lote l ON  tk.lote=l.idlote INNER JOIN coneras c ON tk.conera=c.idconeras" &
                            " INNER JOIN conos c1 ON tk.conos=c1.idconos " & producto1 & ""


                Dim adaptadorl As MySqlDataAdapter = New MySqlDataAdapter(consultal, conexion)
                Dim datosl = New DataTable
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

    Private Sub cboproducto_TextChanged(sender As Object, e As EventArgs) Handles cboproducto.TextChanged
        If cboproducto.ValueMember.ToString <> Nothing And cboproducto.Text <> Nothing Then
            mostrarlotes()
        End If
    End Sub
End Class