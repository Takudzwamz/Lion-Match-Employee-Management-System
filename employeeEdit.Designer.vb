<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDoj = New System.Windows.Forms.DateTimePicker()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.empcategory = New System.Windows.Forms.TextBox()
        Me.empgender = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.empphoto = New System.Windows.Forms.PictureBox()
        Me.empsalary = New System.Windows.Forms.TextBox()
        Me.empdepartment = New System.Windows.Forms.TextBox()
        Me.empphoneno = New System.Windows.Forms.TextBox()
        Me.empaddress = New System.Windows.Forms.TextBox()
        Me.emplastname = New System.Windows.Forms.TextBox()
        Me.empfirstname = New System.Windows.Forms.TextBox()
        Me.empno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(800, 298)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDoj
        '
        Me.txtDoj.Location = New System.Drawing.Point(162, 515)
        Me.txtDoj.Name = "txtDoj"
        Me.txtDoj.Size = New System.Drawing.Size(190, 20)
        Me.txtDoj.TabIndex = 59
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(162, 418)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(190, 20)
        Me.txtDob.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(58, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'empcategory
        '
        Me.empcategory.Location = New System.Drawing.Point(162, 465)
        Me.empcategory.Name = "empcategory"
        Me.empcategory.Size = New System.Drawing.Size(190, 20)
        Me.empcategory.TabIndex = 56
        '
        'empgender
        '
        Me.empgender.FormattingEnabled = True
        Me.empgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.empgender.Location = New System.Drawing.Point(162, 323)
        Me.empgender.Name = "empgender"
        Me.empgender.Size = New System.Drawing.Size(190, 21)
        Me.empgender.TabIndex = 55
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(763, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 49)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Button1.Location = New System.Drawing.Point(648, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 49)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'empphoto
        '
        Me.empphoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.empphoto.Location = New System.Drawing.Point(763, 99)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(153, 193)
        Me.empphoto.TabIndex = 51
        Me.empphoto.TabStop = False
        '
        'empsalary
        '
        Me.empsalary.Location = New System.Drawing.Point(162, 623)
        Me.empsalary.Name = "empsalary"
        Me.empsalary.Size = New System.Drawing.Size(190, 20)
        Me.empsalary.TabIndex = 50
        '
        'empdepartment
        '
        Me.empdepartment.Location = New System.Drawing.Point(162, 562)
        Me.empdepartment.Name = "empdepartment"
        Me.empdepartment.Size = New System.Drawing.Size(190, 20)
        Me.empdepartment.TabIndex = 49
        '
        'empphoneno
        '
        Me.empphoneno.Location = New System.Drawing.Point(162, 367)
        Me.empphoneno.Name = "empphoneno"
        Me.empphoneno.Size = New System.Drawing.Size(190, 20)
        Me.empphoneno.TabIndex = 48
        '
        'empaddress
        '
        Me.empaddress.Location = New System.Drawing.Point(162, 227)
        Me.empaddress.Multiline = True
        Me.empaddress.Name = "empaddress"
        Me.empaddress.Size = New System.Drawing.Size(190, 76)
        Me.empaddress.TabIndex = 47
        '
        'emplastname
        '
        Me.emplastname.Location = New System.Drawing.Point(162, 177)
        Me.emplastname.Name = "emplastname"
        Me.emplastname.Size = New System.Drawing.Size(190, 20)
        Me.emplastname.TabIndex = 46
        '
        'empfirstname
        '
        Me.empfirstname.Location = New System.Drawing.Point(162, 132)
        Me.empfirstname.Name = "empfirstname"
        Me.empfirstname.Size = New System.Drawing.Size(190, 20)
        Me.empfirstname.TabIndex = 45
        '
        'empno
        '
        Me.empno.Location = New System.Drawing.Point(162, 88)
        Me.empno.Name = "empno"
        Me.empno.Size = New System.Drawing.Size(190, 20)
        Me.empno.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(827, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Photo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(55, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(55, 627)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Salary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(55, 570)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Department"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(58, 523)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Date of Join"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(55, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(55, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Phone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(55, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(55, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(55, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(55, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "EmpNo"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(648, 396)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 19)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "First"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Location = New System.Drawing.Point(932, 396)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 19)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "Last"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Location = New System.Drawing.Point(843, 396)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 19)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "Prev"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Location = New System.Drawing.Point(748, 396)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 19)
        Me.Button7.TabIndex = 64
        Me.Button7.Text = "Next"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.Location = New System.Drawing.Point(892, 570)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 49)
        Me.Button8.TabIndex = 65
        Me.Button8.Text = "Cancel"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(795, 9)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 29)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "Label14"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1029, 659)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtDoj)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.empcategory)
        Me.Controls.Add(Me.empgender)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.empphoto)
        Me.Controls.Add(Me.empsalary)
        Me.Controls.Add(Me.empdepartment)
        Me.Controls.Add(Me.empphoneno)
        Me.Controls.Add(Me.empaddress)
        Me.Controls.Add(Me.emplastname)
        Me.Controls.Add(Me.empfirstname)
        Me.Controls.Add(Me.empno)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents txtDoj As DateTimePicker
    Friend WithEvents txtDob As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents empcategory As TextBox
    Friend WithEvents empgender As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents empphoto As PictureBox
    Friend WithEvents empsalary As TextBox
    Friend WithEvents empdepartment As TextBox
    Friend WithEvents empphoneno As TextBox
    Friend WithEvents empaddress As TextBox
    Friend WithEvents emplastname As TextBox
    Friend WithEvents empfirstname As TextBox
    Friend WithEvents empno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
