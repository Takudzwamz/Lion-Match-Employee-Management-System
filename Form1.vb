Imports System.Data.SqlClient

Public Class Form1

    'Dim con As SqlConnection = New SqlConnection("server=DESKTOP-FSIIDVA\SQLEXPRESS; database=LionMatch; user id=DESKTOP-FSIIDVA\zhout ; password = """)
    'Public con As New SqlConnection With {.ConnectionString = "Server=DESKTOP-FSIIDVA\SQLEXPRESS;Database=LionMatch;Trusted_Connection=True;"}
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim username, password As String
    Dim sql As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = txtusername.Text
        password = txtpassword.Text

        If (username = "" And password = "") Then
            MessageBox.Show("Enter the username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ConnDb()
            con.Open()
            sql = "select * from login where username = '" & username & "' and password = '" & password & "'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then
                Dim f2 As Main = New Main
                f2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Failed !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            con.Close()

        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
