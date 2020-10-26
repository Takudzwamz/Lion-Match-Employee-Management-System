Imports System.Data.SqlClient
Imports System.IO


Public Class Employees

    Dim ds As DataSet
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand


    Private Sub binding()
        ConnDb()


        da = New SqlDataAdapter("select * from employee_details2", con)
        ds = New DataSet
        da.Fill(ds, "employee_details2")
        dv = New DataView(ds.Tables("employee_details2"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)

        empno.DataBindings.Clear()
        empfirstname.DataBindings.Clear()
        emplastname.DataBindings.Clear()
        empaddress.DataBindings.Clear()
        empgender.DataBindings.Clear()
        empphoneno.DataBindings.Clear()
        txtDob.DataBindings.Clear()
        empcategory.DataBindings.Clear()
        txtDoj.DataBindings.Clear()
        empdepartment.DataBindings.Clear()
        empsalary.DataBindings.Clear()


        empno.DataBindings.Add("Text", dv, "empno")
        empfirstname.DataBindings.Add("Text", dv, "Firstname")
        emplastname.DataBindings.Add("Text", dv, "lastname")
        empaddress.DataBindings.Add("Text", dv, "address")
        empgender.DataBindings.Add("Text", dv, "gender")
        empphoneno.DataBindings.Add("Text", dv, "phoneno")
        txtDob.DataBindings.Add("Text", dv, "dateofbirth")
        empcategory.DataBindings.Add("Text", dv, "category")
        txtDoj.DataBindings.Add("Text", dv, "dateofjoin")
        empdepartment.DataBindings.Add("Text", dv, "department")
        empsalary.DataBindings.Add("Text", dv, "salary")
    End Sub

    Private Sub ShowPosition()
        Label14.Text = cm.Position + 1 & " of " & cm.Count
        Dim arrPicture() As Byte = CType(ds.Tables(0).Rows(cm.Position)("photo"), Byte())

        Dim ms As New MemoryStream(arrPicture)
        With empphoto
            .Image = Image.FromStream(ms)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .BorderStyle = BorderStyle.Fixed3D
        End With
        ms.Close()


    End Sub


    Private Sub Edit()
        Try
            Dim ms As New MemoryStream
            empphoto.Image.Save(ms, empphoto.Image.RawFormat)
            Dim arrImage() As Byte = ms.GetBuffer
            ms.Close()
            ConnDb()

            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = " update employee_details2 set firstname = @firstname, lastname = @lastname, address = @address, gender = @gender, phoneno = @phoneno, dateofbirth = @dateofbirth, category = @category, dateofjoin = @dateofjoin, department = @department, salary = @salary, photo = @photo where empno = @empno"
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@empno", empno.Text)
            cmd.Parameters.Add("@firstname", empfirstname.Text)
            cmd.Parameters.Add("@lastname", emplastname.Text)
            cmd.Parameters.Add("@address", empaddress.Text)
            cmd.Parameters.Add("@gender", empgender.Text)
            cmd.Parameters.Add("@phoneno", empphoneno.Text)
            cmd.Parameters.Add("@dateofbirth", txtDob.Value)
            cmd.Parameters.Add("@category", empcategory.Text)
            cmd.Parameters.Add("@dateofjoin", txtDoj.Value)
            cmd.Parameters.Add("@department", empdepartment.Text)
            cmd.Parameters.Add("@salary", empsalary.Text)
            cmd.Parameters.Add("@photo", arrImage)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record updated")
            binding()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Delete()

        Try
            Dim a As String
            a = MessageBox.Show("Are you sure you want to  delete the record?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (a = MsgBoxResult.No) Then

                Exit Sub

            Else
                Dim intpos As Integer
                intpos = Me.BindingContext(dv).Position - 1

                If (intpos < 0) Then
                    intpos = 0
                End If

                ConnDb()

                cmd = New SqlCommand
                cmd.Connection = con
                cmd.CommandText = " delete from employee_details2 where empno = @empno "

                cmd.Parameters.Add("@empno", empno.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Deleted")
                binding()
                Me.BindingContext(dv).Position = intpos
                con.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub employeeEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binding()
        ShowPosition()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cm.Position = 0
        ShowPosition()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cm.Position += 1
        ShowPosition()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cm.Position -= 1
        ShowPosition()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cm.Position = cm.Count - 1
        ShowPosition()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Edit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With OpenFileDialog1
            .InitialDirectory = "C:\"
            .Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 2
        End With

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With empphoto
                .Image = Image.FromFile(OpenFileDialog1.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Delete()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class