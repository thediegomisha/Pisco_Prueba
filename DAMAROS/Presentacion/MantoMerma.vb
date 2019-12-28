Imports Devart.Data.MySql

Public Class MantoMerma


    Private Sub MantoMerma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlistado()
    End Sub
    Sub mostrarlistado()
        Try
            Dim consulta As String = "select *  from merma ORDER BY 1 desc"
            Dim adaptador = New MySqlDataAdapter(consulta, conexion)
            Dim datos = New DataTable
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub MantoMerma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
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
            Dim comando = New MySqlCommand("delete from merma WHERE idmerma='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtmerma.Text <> Nothing Then
            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                Dim comando = New MySqlCommand("INSERT INTO merma (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)

                comando.Parameters.AddWithValue("@nombre", txtmerma.Text)
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
End Class