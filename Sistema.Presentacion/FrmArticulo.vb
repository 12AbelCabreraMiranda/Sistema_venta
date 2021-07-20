Imports System.IO

Public Class FrmArticulo
    Private RutaOrigen As String
    Private RutaDestino As String
    Private Directorio As String = "C:\sistema\"

    'METODO ANCHO DE COLUMNAS
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100

        'DESACTIVA LOS BOTONES
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChkSeleccionar.CheckState = False
    End Sub

    'METODO LISTA LOS REGISTRO EN EL FORMULARIO
    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NArticulo
            DgvListado.DataSource = Neg.Listar()
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODO BUSCAR ARTICULO
    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NArticulo
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODO LIMPIAR
    Private Sub Limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtId.Text = ""
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecioVenta.Text = ""
        TxtStock.Text = ""
        txtImagen.Text = ""
        PicImagen.Image = Nothing
        TxtDescripcion.Text = ""
        RutaOrigen = "" 'LIMPIA LA RUTA DE LA IMAGEN
    End Sub

    'METODO SELECCIONAR CATEGORIA EN COMBOBOX
    Private Sub CargarCategoria()
        Try
            Dim Neg As New Negocio.NCategoria
            CboCategoria.DataSource = Neg.Seleccionar()
            CboCategoria.ValueMember = "idcategoria"
            CboCategoria.DisplayMember = "nombre"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODO PRINCIPAL DEL FORMULARIO
    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarCategoria()
    End Sub

    'METODO EVENTO BUSCAR ARTICULO
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    'METODO EVENTO CARGAR IMAGEN
    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim File As New OpenFileDialog
        File.Filter = "Image File (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"

        If File.ShowDialog() = DialogResult.OK Then
            PicImagen.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            txtImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\") + 1) 'OBTENER NOMBRE DE LA IMAGEN
        End If
    End Sub

    'METODO EVENTO INSERTAR
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Try
            'DIFERENTE A VACÍO
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = txtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Insertar(Obj)) Then 'SI DEVEUELVE TRUE, MUESTRA Msg insertado
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")

                    If (txtImagen.Text <> "") Then
                        RutaDestino = Directorio & txtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If

                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'METODO EVENTO CANCELAR
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0

    End Sub

    'METODO EVENTO SELECCIONAR CELDA PARA ACTUALIZARLO
    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            TxtId.Text = DgvListado.SelectedCells.Item(1).Value
            CboCategoria.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtCodigo.Text = DgvListado.SelectedCells.Item(4).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(5).Value
            TxtPrecioVenta.Text = DgvListado.SelectedCells.Item(6).Value
            TxtStock.Text = DgvListado.SelectedCells.Item(7).Value
            TxtDescripcion.Text = DgvListado.SelectedCells.Item(8).Value

            'MOSTRAR IMAGEN
            Dim Imagen As String
            Imagen = DgvListado.SelectedCells.Item(9).Value

            'VERIFICAR SI CONTIENE IMAGEN
            If (Imagen <> "") Then
                PicImagen.Image = Image.FromFile(Directorio & Imagen)
                txtImagen.Text = Imagen
            Else
                PicImagen.Image = Nothing
                txtImagen.Text = ""
            End If
            'HABILITAR Y DESABILITAR BOTONES
            BtnInsertar.Visible = False
            BtnActualizar.Visible = True
            TabGeneral.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODO EVENTO ACTUALIZAR
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            'DIFERENTE A VACÍO
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" And TxtId.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.NArticulo

                Obj.IdArticulo = TxtId.Text
                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = txtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Actualizar(Obj)) Then 'SI DEVEUELVE TRUE, MUESTRA Msg insertado
                    MsgBox("Se ha Actualizado correctamente", vbOKOnly + vbInformation, "Actualización correcta")
                    'CARGA NUEVAS IMAGENES
                    If (txtImagen.Text <> "" And RutaOrigen <> "") Then
                        RutaDestino = Directorio & txtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If

                    Me.Listar()
                Else
                    MsgBox("No se ha podido actualizar", vbOKOnly + vbCritical, "Actualización incorrecta")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'METODO EVENTO SELECCIONAR SELDA DE CONTENIDO
    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    'BOTON EVENTO CHECK Y ACTIVA Y DESACTIVA BOTONES
    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True
        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False
        End If
    End Sub

    'METODO EVENTO ELIMINAR REGISTROS SELECCIONADOS
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Estás seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim Imagen As String = Convert.ToString(row.Cells("Imagen").Value) 'ELIMINAR IMAGEN DEL DIRECTORIO
                        Neg.Eliminar(OneKey)
                        File.Delete(Directorio & Imagen) 'ELIMINAR IMAGEN DEL DIRECTORIO
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'METODO EVENTO ACTIVAR
    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Estás seguro de Activar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Activar(OneKey)

                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'METODO EVENTO DESACTIVAR
    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Estás seguro de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulo
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Desactivar(OneKey)

                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        FrmReporteArticulos.ShowDialog()
    End Sub
End Class