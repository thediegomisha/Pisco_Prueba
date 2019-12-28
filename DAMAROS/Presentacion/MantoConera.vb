Imports Devart.Data.MySql

Public Class MantoConera

    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable
    Dim correlativo As Integer = 0


    Private Sub MantoConera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recuperacorrelativo()
        mostrarlistado()
    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from coneras"
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
        If txtconera.Text <> Nothing Then

            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                comando = New MySqlCommand("INSERT INTO coneras (numconera)" & Chr(13) & "VALUES(@numconera)", conexion)

                comando.Parameters.AddWithValue("@numconera", txtconera.Text)

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
    Sub recuperacorrelativo()
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("SELECT CASE WHEN MAX(numconera) IS NULL THEN '00' ELSE MAX(numconera) END AS coneras from coneras", conexion)

            If txtconera.Text = Nothing Or txtconera.Text <> Nothing Then
                If comando.ExecuteScalar > -1 Then
                    correlativo = Val(comando.ExecuteScalar)
                    txtconera.Text = String.Format("{0:00}", correlativo + 1)
                End If
            End If

            ' MsgBox("DATOS recuperado SATISFACTORIAMENTE")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            Label2.Text = DataGridView1.Item(0, i).Value
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            comando = New MySqlCommand("delete from coneras WHERE idconeras='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()
            recuperacorrelativo()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class