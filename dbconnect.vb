Imports System.Data.SqlClient

Module dbconnect
    Public path As String = "H:\Mes Documents\PPE\produits\"
    Public cnn As SqlConnection = New SqlConnection(connectionString)
    ' Data Source=PCX\SQLEXPRESS;Integrated Security=True;Initial Catalog= bdd_monin;
    'Data Source=172.30.0.115;Initial Catalog= MONIN_2018; User ID=PPESLAM1;Password=ppeslam1mdp'
    Public connectionString As String = "Data Source=172.30.0.115;Initial Catalog= MONIN_2018; User ID=PPESLAM1;Password=ppeslam1mdp"
    Public cmd As SqlCommand
    Public reader As SqlDataReader
    Public Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New System.Text.RegularExpressions.Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function
End Module
