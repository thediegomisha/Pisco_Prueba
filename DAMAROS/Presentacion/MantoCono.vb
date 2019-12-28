Imports Devart.Data.MySql

Public Class MantoCono
    Dim consulta As String
    Dim comando As New MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim datos As New DataTable

 

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtnumcono.Text <> Nothing And txtdescripcion.Text <> Nothing Then
            Try
                If conexion.State = ConnectionState.Closed Then
                    conexion.Open()
                End If
                comando = New MySqlCommand("INSERT INTO conos (numconos, detalle)" & Chr(13) & "VALUES(@numconos, @detalle)", conexion)

                comando.Parameters.AddWithValue("@numconos", txtnumcono.Text)
                comando.Parameters.AddWithValue("@detalle", txtdescripcion.Text)

                comando.ExecuteNonQuery()
                mostrarlistado()

                'MsgBox("DATOS GUARDADOS SATISFACTORIAMENTE")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("INGRESE DATOS")
        End If



        '   Label2.Text = txtnumcono.Text + " " + txtdescripcion.Text
    End Sub

    Private Sub MantoCono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarlistado()
    End Sub
    Sub mostrarlistado()
        Try
            consulta = "select *  from conos"
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
        '    DataGridView1.Columns(2).Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class