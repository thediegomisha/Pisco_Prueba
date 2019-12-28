Imports Devart.Data.MySql

Public Class MantoTCompra

    Dim correlativo As Integer = 0
    Dim fecha As String
    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

    Private Sub MantoTCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub MantoTCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlistado()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtcompra.Text <> Nothing Then
            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                comando = New MySqlCommand("INSERT INTO tipocompra (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)

                comando.Parameters.AddWithValue("@nombre", txtcompra.Text)

                comando.ExecuteNonQuery()
                mostrarlistado()
                'MsgBox("DATOS GUARDADOS SATISFACTORIAMENTE")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("INGRESE DATOS")
        End If
    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from tipocompra ORDER BY 1 desc"
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
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("delete from tipocomra WHERE idtipocompra='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub
End Class