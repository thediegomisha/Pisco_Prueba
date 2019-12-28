Imports Devart.Data.MySql

Public Class MantoProceso

    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

    Private Sub MantoProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtproceso.Text = Nothing
        mostrarlistado()
    End Sub

    Sub mostrarlistado()
        Try
            consulta = "select *  from tipoproceso"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            ocultarcolumnas()
            txtproceso.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ocultarcolumnas()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtproceso.Text <> Nothing Then
            Try
                conectar()
                comando = New MySqlCommand("INSERT INTO tipoproceso (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)
                comando.Parameters.AddWithValue("@nombre", txtproceso.Text)
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            conectar()
            comando = New MySqlCommand("delete from tipoproceso WHERE idtipoproceso='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub
End Class