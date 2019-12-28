Imports Devart.Data.MySql

Public Class MantoLote

    Dim correlativo As Integer = 0
    Dim fecha As String
    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable
    Private Sub MantoLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recuperacorrelativo()
        formatofecha()
        mostrarlistado()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtnumlote.Text <> Nothing Then
            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                comando = New MySqlCommand("INSERT INTO lote (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)

                comando.Parameters.AddWithValue("@nombre", txtnumlote.Text + "-" + Microsoft.VisualBasic.Right(fecha, 2))

                comando.ExecuteNonQuery()
                mostrarlistado()
                recuperacorrelativo()
                'MsgBox("DATOS GUARDADOS SATISFACTORIAMENTE")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("INGRESE DATOS")
        End If


    End Sub
    Sub formatofecha()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy"
        fecha = DateTimePicker1.Text
    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from lote ORDER BY 1 desc"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            ocultarcolumnas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ocultarcolumnas()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(3).Visible = False
    End Sub
    Sub recuperacorrelativo()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("SELECT CASE WHEN MAX(idlote) IS NULL THEN '00' ELSE MAX(idlote) END AS cliente from lote", conexion)

            If txtnumlote.Text = Nothing Or txtnumlote.Text <> Nothing Then
                If comando.ExecuteScalar > -1 Then
                    correlativo = Val(comando.ExecuteScalar)
                    txtnumlote.Text = String.Format("{0:00}", correlativo + 1)
                End If
            End If

            ' MsgBox("DATOS recuperado SATISFACTORIAMENTE")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub MantoLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("delete from lote WHERE idlote='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

  
    Private Sub btnCerrarLote_Click(sender As Object, e As EventArgs) Handles btnCerrarLote.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("UPDATE lote SET estado='C' WHERE idlote='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub

  
    Private Sub btnAbrirLote_Click(sender As Object, e As EventArgs) Handles btnAbrirLote.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("UPDATE lote SET estado='A' WHERE idlote='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub
End Class