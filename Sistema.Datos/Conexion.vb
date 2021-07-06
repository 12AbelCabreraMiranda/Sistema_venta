Imports System.Data.SqlClient

Public Class Conexion
    Public conn As SqlConnection

    'CONSTRUCTOR
    Public Sub New()
        Me.conn = New SqlConnection("Data Source=DESKTOP-6D474CP\SQLEXPRESS;Initial Catalog=dbsistema;Integrated Security=True")
    End Sub

End Class
