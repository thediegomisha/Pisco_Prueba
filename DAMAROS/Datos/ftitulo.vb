Imports Devart.Data.MySql

Public Class ftitulo
    ' Inherits ConexionGral
    Dim cmd As New MySqlCommand

    Public Function mostrar() As DataTable
        Try
            conectar()
            'cmd = New MySqlCommand("SELECT * FROM titulos")
            'cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = conexion
            cmd.CommandText = "SELECT * FROM titulos;"
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectar()

        End Try
    End Function

End Class
