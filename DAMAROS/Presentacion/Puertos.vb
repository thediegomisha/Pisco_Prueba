Imports System.IO.Ports
Imports System.Windows.Forms.VisualStyles

Public Class Puertos

    Private Sub Puertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSerialPortNames()

        ' VARIABLES PARA LA BALANZA XORELLA
        If My.Settings.checked_bal1 = True Then
            chk_xorella.Checked = True
            CBParidadX.Text = Nothing

        ElseIf My.Settings.checked_bal1 = False Then
            chk_xorella.Checked = False

            If My.Settings.ParidadG = "0" Then
                CBParidadX.Text = "Ninguno"
            ElseIf My.Settings.ParidadG = "1" Then
                CBParidadX.Text = "Impar"
            ElseIf My.Settings.ParidadG = "2" Then
                CBParidadX.Text = "Par"
            End If

            CBXORELLA.Text = My.Settings.select_bal1.ToString()
            CBBaudioX.Text = My.Settings.BaudioG.ToString()
            CBDatosX.Text = My.Settings.bitdatosG.ToString()
            CBParidadX.Text = My.Settings.ParidadG.ToString()
            CBParadaX.Text = My.Settings.ParadaG.ToString()
        End If


        ' VARIABLES PARA LA BALANZA ALMACEN
        If My.Settings.checked_bal2 = True Then
            chk_almacen.Checked = True
            CBParidadA.Text = Nothing

        ElseIf My.Settings.checked_bal2 = False Then
            chk_almacen.Checked = False

            If My.Settings.ParidadA = "0" Then
                CBParidadA.Text = "Ninguno"
            ElseIf My.Settings.ParidadA = "1" Then
                CBParidadA.Text = "Impar"
            ElseIf My.Settings.ParidadA = "2" Then
                CBParidadA.Text = "Par"
            End If

            CBALMACEN.Text = My.Settings.select_bal2.ToString()
            CBBaudiosA.Text = My.Settings.BaudiosA.ToString()
            CBDatosA.Text = My.Settings.bitdatosA.ToString()
            CBParidadA.Text = My.Settings.ParidadA.ToString()
            CBParadaA.Text = My.Settings.ParadaA.ToString()

        End If

        ' VARIABLES PARA LA BALANZA HILANDERIA
        If My.Settings.checked_bal3 = True Then
            chk_hilanderia.Checked = True
            CBParidadH.Text = Nothing

        ElseIf My.Settings.checked_bal3 = False Then
            chk_almacen.Checked = False

            If My.Settings.ParidadH = "0" Then
                CBParidadH.Text = "Ninguno"
            ElseIf My.Settings.ParidadH = "1" Then
                CBParidadH.Text = "Impar"
            ElseIf My.Settings.ParidadH = "2" Then
                CBParidadH.Text = "Par"
            End If

            CBHILANDERIA.Text = My.Settings.select_bal3.ToString()
            CBBaudiosH.Text = My.Settings.BaudiosH.ToString()
            CBDatosH.Text = My.Settings.bitdatosH.ToString()
            CBParidadH.Text = My.Settings.ParidadH.ToString()
            CBParadaH.Text = My.Settings.ParadaH.ToString()

        End If
    End Sub
    Private Sub F_PortCom_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If chk_xorella.Checked = True Then
            My.Settings.checked_bal1 = True
        ElseIf chk_xorella.Checked = False Then
            My.Settings.checked_bal1 = False
        End If

        Dim codigoparidadG As Integer = 0

        If CBParidadX.Text = "Ninguno" Then
            codigoparidadG = Parity.None
        ElseIf CBParidadX.Text = "Impar" Then
            codigoparidadG = Parity.Odd
        ElseIf CBParidadX.Text = "Par" Then
            codigoparidadG = Parity.Even
        End If

        Dim codigoparadaG As Integer = 0

        If CBParadaX.Text = "1" Then
            codigoparadaG = StopBits.One
        ElseIf CBParadaX.Text = "2" Then
            codigoparadaG = StopBits.Two
        ElseIf CBParadaX.Text = "1.5" Then
            codigoparadaG = StopBits.OnePointFive
        ElseIf CBParadaX.Text = "0" Then
            codigoparadaG = StopBits.None
        End If

        My.Settings.select_bal1 = CBXORELLA.Text
        My.Settings.BaudioG = CBBaudioX.Text
        My.Settings.bitdatosG = CBDatosX.Text
        My.Settings.ParidadG = codigoparidadG
        My.Settings.ParadaG = codigoparadaG

        If chk_almacen.Checked = True Then
            My.Settings.checked_bal2 = True
        ElseIf chk_almacen.Checked = False Then
            My.Settings.checked_bal2 = False
        End If

        Dim codigoparidad As Integer = 0

        If CBParidadA.Text = "Ninguno" Then
            codigoparidad = Parity.None
        ElseIf CBParidadA.Text = "Impar" Then
            codigoparidad = Parity.Odd
        ElseIf CBParidadA.Text = "Par" Then
            codigoparidad = Parity.Even
        End If

        Dim codigoparada As Integer = 0

        If CBParadaA.Text = "1" Then
            codigoparada = StopBits.One
        ElseIf CBParadaA.Text = "2" Then
            codigoparada = StopBits.Two
        ElseIf CBParadaA.Text = "1.5" Then
            codigoparada = StopBits.OnePointFive
        ElseIf CBParadaA.Text = "0" Then
            codigoparada = StopBits.None
        End If

        My.Settings.select_bal2 = CBALMACEN.Text
        My.Settings.BaudiosA = CBBaudiosA.Text
        My.Settings.bitdatosA = CBDatosA.Text
        My.Settings.ParidadA = codigoparidad
        My.Settings.ParadaA = codigoparada

        ' GUARDAR CAMBIOS PARA BALANZA HILANDERIA
        If chk_hilanderia.Checked = True Then
            My.Settings.checked_bal3 = True
        ElseIf chk_hilanderia.Checked = False Then
            My.Settings.checked_bal3 = False
        End If

        Dim codigoparidad_h As Integer = 0

        If CBParidadH.Text = "Ninguno" Then
            codigoparidad_h = Parity.None
        ElseIf CBParidadH.Text = "Impar" Then
            codigoparidad_h = Parity.Odd
        ElseIf CBParidadH.Text = "Par" Then
            codigoparidad_h = Parity.Even
        End If

        Dim codigoparadaH As Integer = 0

        If CBParadaH.Text = "1" Then
            codigoparadaH = StopBits.One
        ElseIf CBParadaH.Text = "2" Then
            codigoparadaH = StopBits.Two
        ElseIf CBParadaH.Text = "1.5" Then
            codigoparadaH = StopBits.OnePointFive
        ElseIf CBParadaH.Text = "0" Then
            codigoparadaH = StopBits.None
        End If

        My.Settings.select_bal3 = CBHILANDERIA.Text
        My.Settings.BaudiosH = CBBaudiosH.Text
        My.Settings.bitdatosH = CBDatosH.Text
        My.Settings.ParidadH = codigoparidad_h
        My.Settings.ParadaH = codigoparadaH

        My.Settings.Save()
    End Sub

    Sub GetSerialPortNames()
        ' Muestra todos los puertos COM disponibles del Sistema.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CBXORELLA.Items.Add(sp)
            CBALMACEN.Items.Add(sp)
            CBHILANDERIA.Items.Add(sp)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Try

        If CBXORELLA.Text <> Nothing Or CBALMACEN.Text <> Nothing Or CBHILANDERIA.Text <> Nothing Then

            'If CBXORELLA.Text <> CBALMACEN.Text And CBXORELLA.Text <> CBHILANDERIA.Text Then
            If CBXORELLA.SelectedItem <> CBALMACEN.SelectedItem And CBXORELLA.SelectedItem <> CBHILANDERIA.SelectedItem Then
                MsgBox("Sin Problemas")
            Else
                MsgBox("Error, no puede seleccionar el mismo puerto COM")
            End If
        Else
            MsgBox("Tiene que Seleccionar Puertos Disponibles")
        End If

        '   Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub chk_Bal1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_xorella.CheckedChanged
        Try
            If chk_xorella.Checked = True Then
                CBXORELLA.Enabled = False
                CBXORELLA.SelectedIndex = -1
                CBDatosX.Enabled = False
                CBDatosX.SelectedIndex = -1
                CBParidadX.Enabled = False
                CBParidadX.SelectedIndex = -1
                CBParidadX.Text = Nothing
                CBParadaX.Enabled = False
                CBParadaX.SelectedIndex = -1
                CBBaudioX.Enabled = False
                CBBaudioX.SelectedIndex = -1
            Else
                CBXORELLA.Enabled = True
                CBDatosX.Enabled = True
                CBParidadX.Enabled = True
                CBParadaX.Enabled = True
                CBBaudioX.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_Bal2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_almacen.CheckedChanged
        Try
            If chk_almacen.Checked = True Then
                CBALMACEN.Enabled = False
                CBALMACEN.SelectedIndex = -1
                CBBaudiosA.Enabled = False
                CBBaudiosA.SelectedIndex = -1
                CBParadaA.Enabled = False
                CBParadaA.SelectedIndex = -1
                CBParidadA.Enabled = False
                CBParidadA.SelectedIndex = -1
                CBDatosA.Enabled = False
                CBDatosA.SelectedIndex = -1
            Else
                CBALMACEN.Enabled = True
                CBBaudiosA.Enabled = True
                CBParadaA.Enabled = True
                CBParidadA.Enabled = True
                CBDatosA.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chk_hilanderia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_hilanderia.CheckedChanged
        Try
            If chk_hilanderia.Checked = True Then
                CBHILANDERIA.Enabled = False
                CBHILANDERIA.SelectedIndex = -1
                CBBaudiosH.Enabled = False
                CBBaudiosH.SelectedIndex = -1
                CBParadaH.Enabled = False
                CBParadaH.SelectedIndex = -1
                CBParidadH.Enabled = False
                CBParidadH.SelectedIndex = -1
                CBDatosH.Enabled = False
                CBDatosH.SelectedIndex = -1
            Else
                CBHILANDERIA.Enabled = True
                CBBaudiosH.Enabled = True
                CBParadaH.Enabled = True
                CBParidadH.Enabled = True
                CBDatosH.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class