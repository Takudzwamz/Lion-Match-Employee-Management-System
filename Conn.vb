Imports System.Data.SqlClient
Module Conn


    Public con As SqlConnection

    Public Sub ConnDb()
        Try
            con = New SqlConnection("Server=DESKTOP-FSIIDVA\SQLEXPRESS;Database=LionMatch;Trusted_Connection=True;")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
