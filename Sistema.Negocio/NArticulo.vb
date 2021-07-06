Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NArticulo
    'FUNCION LISTAR DATOS ARTICULO
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'FUNCION BUSCAR DATO  ARTICULO
    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DArticulo
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'FUNCION INSERTAR DATO ARTICULO
    Public Function Insertar(Obj As Articulo) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ACTUALIZAR DATO ARTICULO
    Public Function Actualizar(Obj As Articulo) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ELIMINAR DATO ARTICULO
    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION DESACTIVAR DATO ARTICULO
    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ACTIVAR DATO ARTICULO
    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulo
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
