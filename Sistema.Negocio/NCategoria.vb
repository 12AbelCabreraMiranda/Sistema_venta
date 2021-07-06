Imports Sistema.Datos
Imports Sistema.Entidades

Public Class NCategoria
    'FUNCION LISTAR DATOS CATEGORIA
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'FUNCION BUSCAR DATO  CATEGORIA
    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'FUNCION LISTAR CATEGORIA EN COMBOBOX
    Public Function Seleccionar() As DataTable
        Try
            Dim Datos As New DCategoria
            Dim Tabla As New DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'FUNCION INSERTAR DATO CATEGORIA
    Public Function Insertar(Obj As Categoria) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ACTUALIZAR DATO CATEGORIA
    Public Function Actualizar(Obj As Categoria) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ELIMINAR DATO CATEGORIA
    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION DESACTIVAR DATO CATEGORIA
    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'FUNCION ACTIVAR DATO CATEGORIA
    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DCategoria
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
