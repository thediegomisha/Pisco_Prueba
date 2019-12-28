Imports Devart.Data.MySql
Module ConexionGral
    Public conexion As New MysqlConnection
    Public Sub conectar()
        Try
            conexion.Close()
            '  conexion.ConnectionString = My.Settings.ConecctionString
            conexion.ConnectionString = "server=192.0.0.63;Port=3306;user=root; password='nanayis';database=ALCIDES;Connect Timeout=60;"
            'conexion.ConnectionString = "server=192.168.8.14;Port=3306;user=root; password='nanayis';database=ALCIDES;Connect Timeout=60;"
            '    conexion.ConnectionString = "server=192.168.0.112;Port=3306;user=root; password='nanayis';database=ALCIDES;Connect Timeout=60;"
            '   conexion.ConnectionString = "server=localhost;Port=3306;user=root; password='';database=desmotadora;Connect Timeout=60;"
            '''' conexion.ConnectionString = "server=192.168.56.1;Port=3306;user=root; password='';database=desmotadora;Connect Timeout=60;"

            conexion.Open()
            '   MessageBox.Show("Conectado al Server Damaris Satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Return
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
    End Sub

End Module
