Imports System.Data.SqlClient


Public Class Allowance


    Dim da As SqlDataAdapter
    Dim da1 As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Dim ds As DataSet



    Private Sub Binding()
        ConnDb()
        da = New SqlDataAdapter("select * from employee_details2", con)
        da1 = New SqlDataAdapter("select * from allowance_details", con)
        ds = New DataSet

        da.Fill(ds, "employee_details2")
        da1.Fill(ds, "allowance_details")

        'fixed'
        Try
            Fixcombo.Items.Clear()
            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con

            cmd.CommandText = ("select distinct allowance_type from allowance_details")
            dread = cmd.ExecuteReader
            Do While dread.Read
                Fixcombo.Items.Add(dread.GetValue(0))
                depallo.Items.Add(dread.GetValue(0))
                catall.Items.Add(dread.GetValue(0))
                'txtinallo.Items.Add(dread.GetValue(0))



            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Department'

        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con

            cmd.CommandText = ("select distinct department from employee_details2")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtdept.Items.Add(dread.GetValue(0))
                txtcatdept.Items.Add(dread.GetValue(0))


            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'category'
        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con

            cmd.CommandText = ("select distinct department from employee_details2")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtcategory.Items.Add(dread.GetValue(0))
                'txtIncat.Items.Add(dread.GetValue(0))

            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'individuals'
        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con

            cmd.CommandText = ("select distinct empno from employee_details2")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtempid.Items.Add(dread.GetValue(0))

            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGridView1.DataSource = ds.Tables("allowance_details")
        DataGridView2.DataSource = ds.Tables("allowance_details")
        DataGridView3.DataSource = ds.Tables("allowance_details")
        DataGridView4.DataSource = ds.Tables("allowance_details")


    End Sub

    Private Sub allowance_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Binding()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim x As Integer

        For x = 0 To ds.Tables("employee_details2").Rows.Count - 1
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date)"
            cmd.Parameters.Add("@allowance_type", Fixcombo.Text)
            cmd.Parameters.Add("@amount", txtamount.Text)
            cmd.Parameters.Add("@empno", ds.Tables("employee_details2").Rows(x).Item(0))
            cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        MessageBox.Show("Allowance Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Fixcombo.Items.Clear()
        txtamount.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim x As Integer

        For x = 0 To ds.Tables("employee_details2").Rows.Count - 1

            If (txtdept.Text = ds.Tables("employee_details2").Rows(x).Item(9)) Then
                cmd = New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date)"
                cmd.Parameters.Add("@allowance_type", depallo.Text)
                cmd.Parameters.Add("@amount", txtdamo.Text)
                cmd.Parameters.Add("@empno", ds.Tables("employee_details2").Rows(x).Item(0))
                cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Next
        MessageBox.Show("Allowance Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        depallo.Items.Clear()
        txtdamo.Clear()
        txtdept.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Integer

        For x = 0 To ds.Tables("employee_details2").Rows.Count - 1

            If (txtcatdept.Text = ds.Tables("employee_details2").Rows(x).Item(9) And txtcategory.Text = ds.Tables("employee_details2").Rows(x).Item(7)) Then
                cmd = New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date)"
                cmd.Parameters.Add("@allowance_type", catall.Text)
                cmd.Parameters.Add("@amount", txtcatamo.Text)
                cmd.Parameters.Add("@empno", ds.Tables("employee_details2").Rows(x).Item(0))
                cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Next
        MessageBox.Show("Allowance Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()
    End Sub

    Private Sub txtempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempid.SelectedIndexChanged
        Try
            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "select firstname,category from employee_details2 where empno = '" & txtempid.Text & "'"
            dread = cmd.ExecuteReader
            Do While dread.Read

                txtempname.Text = dread.GetValue(0)
                txtIncat.Text = dread.GetValue(1)

            Loop
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date)"
            cmd.Parameters.Add("@allowance_type", txtinallo.Text)
            cmd.Parameters.Add("@amount", txtinamount.Text)
            cmd.Parameters.Add("@empno", txtempid.Text)
            cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Allowance Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Binding()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        catall.Items.Clear()
        txtcatdept.Items.Clear()
        txtcatamo.Clear()
        txtcategory.Items.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtempid.Items.Clear()
        txtinallo.Items.Clear()
        txtIncat.Clear()
        txtempname.Clear()
        txtinamount.Clear()
    End Sub
End Class