Imports Devart.Data.MySql
Public Class MantoTurno

    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable


    Private Sub mantoproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlistado()
    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from turno"
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtturno.Text <> Nothing Then

            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                comando = New MySqlCommand("INSERT INTO turno (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)

                comando.Parameters.AddWithValue("@nombre", txtturno.Text)

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            conectar()
            comando = New MySqlCommand("delete from turno WHERE idturno='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            Label2.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception

        End Try

    End Sub

End Class
