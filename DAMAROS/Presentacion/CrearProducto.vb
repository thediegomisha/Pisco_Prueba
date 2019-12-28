Imports Devart.Data.MySql

Public Class CrearProducto
    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

    Dim consultaP As String
    Dim comandoP As New MySqlCommand
    Dim adaptadorP As MySqlDataAdapter
    Dim datosP As New DataTable

    Dim consultaV As String
    Dim comandoV As New MySqlCommand
    Dim adaptadorV As MySqlDataAdapter
    Dim datosV As New DataTable

    Dim consultaTP As String
    Dim comandoTP As New MySqlCommand
    Dim adaptadorTP As MySqlDataAdapter
    Dim datosTP As New DataTable

    Dim titulo As String
    Dim variedad As String
    Dim tipoproceso As String

    Dim variable1 As String
    Dim variable2 As String
    Dim variable3 As String

    Private Sub CrearProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrartitulos()
        mostrarvariedad()
        mostrartipoproceso()
        mostrarproductos()
    End Sub

    Private Sub mostrartitulos()
        Try
            consulta = "select idtitulo, concat_ws (' ', nombre)as titulo from titulo ORDER BY idtitulo asc"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
            adaptador.Fill(datos)

            With cbotitulo

                If datos.Rows.Count <> 0 Then

                    Dim dr As DataRow = datos.NewRow()
                    dr("idtitulo") = 0
                    dr("titulo") = "Nuevo ..."
                    datos.Rows.InsertAt(dr, 0)

                    .DataSource = datos
                    .DisplayMember = "titulo"
                    .ValueMember = "idtitulo"
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
            consultaV = "select idvariedad, nombre from variedad ORDER BY idvariedad asc"
            adaptadorV = New MySqlDataAdapter(consultaV, conexion)
            datosV = New DataTable
            adaptadorV.Fill(datosV)

            With cbovariedad

                If datosV.Rows.Count <> 0 Then
                    .DataSource = datosV
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
    Private Sub mostrartipoproceso()
        Try
            'consultaTP = "select idtipoproceso, nombre from tipoproceso ORDER BY idtipoproceso asc"
            consultaTP = "select idtipoproceso, concat_ws (' ' , nombre)as proceso from tipoproceso ORDER BY idtipoproceso asc"
            adaptadorTP = New MySqlDataAdapter(consultaTP, conexion)
            datosTP = New DataTable
            adaptadorTP.Fill(datosTP)

            With cbotipoproceso

                If datosTP.Rows.Count <> 0 Then
                    .DataSource = datosTP
                    .DisplayMember = "proceso"
                    .ValueMember = "idtipoproceso"
                    .SelectedIndex = -1
                Else
                    .DataSource = Nothing
                End If

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbotitulo_DropDownClosed(sender As Object, e As EventArgs) Handles cbotitulo.DropDownClosed
        Try
            If cbotitulo.Text = "Nuevo ..." Then
                MantoTitulo.ShowDialog()
                'LLENARCOMBOLOTE()
                'Form_Crear_lote.combocliente.Text = combocliente.Text
                mostrarproductos()
                cbotitulo.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotitulo.SelectedIndexChanged
        Try
            If cbotitulo.Text <> Nothing And cbotitulo.ValueMember <> Nothing Then
                titulo = cbotitulo.Text
                Label4.Text = titulo
                variable1 = cbotitulo.SelectedValue
                Label5.Text = variable1.ToString


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbovariedad.SelectedIndexChanged
        Try
            If cbovariedad.Text <> Nothing And cbovariedad.ValueMember <> Nothing Then
                variedad = cbovariedad.Text
                Label4.Text = titulo + " " + variedad
                variable2 = cbovariedad.SelectedValue
                Label5.Text = variable1.ToString + " " + variable2.ToString

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotipoproceso.SelectedIndexChanged
        Try
            If cbotipoproceso.Text <> Nothing And cbotipoproceso.ValueMember <> Nothing Then
                tipoproceso = cbotipoproceso.Text
                variable3 = cbotipoproceso.SelectedValue
                Label4.Text = titulo + " " + variedad + " " + tipoproceso
                Label5.Text = variable1.ToString + " " + variable2.ToString + " " + variable3.ToString

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("INSERT INTO producto (titulo, variedad, tipoproceso)" & Chr(13) &
                                       "VALUES(@titulo, @variedad, @tipoproceso)", conexion)
            comando.Parameters.AddWithValue("@titulo", CInt(variable1))
            comando.Parameters.AddWithValue("@variedad", CInt(variable2))
            comando.Parameters.AddWithValue("@tipoproceso", CInt(variable3))
            comando.ExecuteNonQuery()
            mostrarproductos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub mostrarproductos()
        Try
            consultaP = "select t.nombre, v.nombre, tp.nombre from producto p inner join titulo t on t.idtitulo=p.titulo inner join variedad v on p.variedad=v.idvariedad inner join tipoproceso tp on p.tipoproceso=tp.idtipoproceso"
            adaptadorP = New MySqlDataAdapter(consultaP, conexion)
            datosP = New DataTable
            adaptadorP.Fill(datosP)
            DataGridView1.DataSource = datosP
            'ocultarcolumnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub CrearProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class