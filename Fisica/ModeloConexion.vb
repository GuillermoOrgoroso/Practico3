Imports System.Data.Odbc
Public MustInherit Class ModeloConexion

    Public DbDriver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public DbUser As String = "root"
    Public DbPassword As String = "Tooroot123654"
    Public DbPort As String = "3307"
    Public DbName As String = "prueba"
    Public DbHost As String = "localhost"



    Public Conexion As New OdbcConnection("DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost)

    Public comando As New OdbcCommand
    Public Reader As New OdbcDataReader

    Public Sub New()
        Me.Conexion.Open()
        Me.Comando.Conecction = Me.Conexion

    End Sub


End Class
