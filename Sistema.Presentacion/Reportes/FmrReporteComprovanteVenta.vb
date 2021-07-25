Public Class FmrReporteComprovanteVenta
    Private Sub FmrReporteComprovanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsSistema.venta_comprobante' table. You can move, or remove it, as needed.
        Me.venta_comprobanteTableAdapter.Fill(Me.DsSistema.venta_comprobante, Variables.IdVdenta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class