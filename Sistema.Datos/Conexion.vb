Imports System.Data.SqlClient

Public Class Conexion
    Public conn As SqlConnection

    'CONSTRUCTOR
    Public Sub New()
        Me.conn = New SqlConnection("Data Source=LAPTOP-8F5D0JQM\SQLEXPRESS;Initial Catalog=dbsistema;Integrated Security=True")
    End Sub

End Class
