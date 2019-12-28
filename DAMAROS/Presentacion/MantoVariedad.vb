Imports Devart.Data.MySql

Public Class MantoVariedad
    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

    Dim i As Integer


    Private Sub MantoVariedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtvariedad.Text = Nothing
        mostrarlistado()


    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from variedad"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataTable
            adaptador.Fill(datos)
            DataGridView1.DataSource = datos
            ocultarcolumnas()
            txtvariedad.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ocultarcolumnas()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtvariedad.Text <> Nothing Then
            Try
                conectar()
                comando = New MySqlCommand("INSERT INTO variedad (nombre)" & Chr(13) & "VALUES(@nombre)", conexion)
                comando.Parameters.AddWithValue("@nombre", txtvariedad.Text)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index

            conectar()
            comando = New MySqlCommand("delete from variedad WHERE idvariedad='" & DataGridView1.Item(0, i).Value & "' ", conexion)
            comando.ExecuteNonQuery()
            mostrarlistado()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            i = DataGridView1.CurrentRow.Index
            txtvariedad.Text = DataGridView1.Item(1, i).Value

        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
           
            i = DataGridView1.CurrentRow.Index
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            If txtvariedad.Text <> Nothing Then

                comando = New MySqlCommand("UPDATE variedad SET nombre=@nombre WHERE idvariedad='" & DataGridView1.Item(0, i).Value & "' ", conexion)

                comando.Parameters.AddWithValue("@nombre", txtvariedad.Text)

                comando.ExecuteNonQuery()
                mostrarlistado()
            Else
                MsgBox("DEBE INGRESAR UN VARIEDAD ¡")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            desconectar()
        End Try

    End Sub

    'Sub cuentacorrelativo()
    '    Try
    '        If lblcorrelativo2.Text <> Nothing Then
    '            If IsDBNull(lblcorrelativo2.Text) Then
    '                lblcorrelativo2.Text = 1
    '            Else
    '                correlativo = Val(lblcorrelativo2.Text) + 1
    '                lblcorrelativo2.Text = String.Format("{0:0000}", correlativo)
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
  
    Private Sub btnUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnUpdate.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class