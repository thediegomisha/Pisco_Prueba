Imports System.Windows.Forms

Public Class Principal



    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            desconectar()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub PuertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuertosToolStripMenuItem.Click
        Puertos.MdiParent = Me
        Puertos.Show()
    End Sub

    Private Sub BalanzaHiloToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '  BXorella.MdiParent = Me
        '  BXorella.Show()
    End Sub

    Private Sub CrearProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearProductoToolStripMenuItem.Click
        CrearProducto.MdiParent = Me
        CrearProducto.Show()

    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conexion.State = ConnectionState.Closed Then
                conectar()
            End If
        Catch ex As Exception
        Finally
            desconectar()
        End Try
    End Sub

   

    Private Sub ConosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ConosToolStripMenuItem.Click
        MantoCono.MdiParent = Me
        MantoCono.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        MantoTitulo.MdiParent = Me
        MantoTitulo.Show()
    End Sub

    Private Sub LoteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoteToolStripMenuItem.Click
        MantoLote.MdiParent = Me
        MantoLote.Show()
    End Sub

    Private Sub ProcesoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProcesoToolStripMenuItem.Click
        MantoProceso.MdiParent = Me
        MantoProceso.Show()
    End Sub

    Private Sub VariedadToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VariedadToolStripMenuItem.Click
        MantoVariedad.MdiParent = Me
        MantoVariedad.Show()
    End Sub

    Private Sub CONERAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONERAToolStripMenuItem.Click
        MantoConera.MdiParent = Me
        MantoConera.Show()
    End Sub

    Private Sub XORELLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XORELLAToolStripMenuItem.Click
        rptXorella.MdiParent = Me
        rptXorella.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        RptGeneral.MdiParent = Me
        RptGeneral.Show()
    End Sub

    Private Sub TipoMermaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoMermaToolStripMenuItem.Click
        MantoMerma.MdiParent = Me
        MantoMerma.Show()
    End Sub

    Private Sub PESOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PESOSToolStripMenuItem.Click
        Mermas.MdiParent = Me
        Mermas.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        BXorella.MdiParent = Me
        BXorella.Show()
    End Sub

    Private Sub CrearProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearProveedoresToolStripMenuItem.Click
        Proveedor.MdiParent = Me
        Proveedor.Show()
    End Sub

    Private Sub RegistrarFardosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarFardosToolStripMenuItem.Click
        Ing_Fardos.MdiParent = Me
        Ing_Fardos.Show()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
        MantoTCompra.MdiParent = Me
        MantoTCompra.Show()
    End Sub

    Private Sub TurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnoToolStripMenuItem.Click
        MantoTurno.MdiParent = Me
        MantoTurno.Show()
    End Sub
End Class
