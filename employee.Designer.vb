<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.empno = New System.Windows.Forms.TextBox()
        Me.empfirstname = New System.Windows.Forms.TextBox()
        Me.emplastname = New System.Windows.Forms.TextBox()
        Me.empaddress = New System.Windows.Forms.TextBox()
        Me.empphoneno = New System.Windows.Forms.TextBox()
        Me.empdepartment = New System.Windows.Forms.TextBox()
        Me.empsalary = New System.Windows.Forms.TextBox()
        Me.empphoto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.empgender = New System.Windows.Forms.ComboBox()
        Me.empcategory = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.txtDoj = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(34, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EmpNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(34, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(34, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(34, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(34, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Phone No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(34, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(37, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Join"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(34, 539)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Department"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(34, 584)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Salary"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(34, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "First Name"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(848, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Photo"
        '
        'empno
        '
        Me.empno.Location = New System.Drawing.Point(119, 153)
        Me.empno.Name = "empno"
        Me.empno.Size = New System.Drawing.Size(190, 20)
        Me.empno.TabIndex = 11
        '
        'empfirstname
        '
        Me.empfirstname.Location = New System.Drawing.Point(119, 188)
        Me.empfirstname.Name = "empfirstname"
        Me.empfirstname.Size = New System.Drawing.Size(190, 20)
        Me.empfirstname.TabIndex = 12
        '
        'emplastname
        '
        Me.emplastname.Location = New System.Drawing.Point(119, 224)
        Me.emplastname.Name = "emplastname"
        Me.emplastname.Size = New System.Drawing.Size(190, 20)
        Me.emplastname.TabIndex = 13
        '
        'empaddress
        '
        Me.empaddress.Location = New System.Drawing.Point(119, 264)
        Me.empaddress.Multiline = True
        Me.empaddress.Name = "empaddress"
        Me.empaddress.Size = New System.Drawing.Size(190, 56)
        Me.empaddress.TabIndex = 14
        '
        'empphoneno
        '
        Me.empphoneno.Location = New System.Drawing.Point(119, 376)
        Me.empphoneno.Name = "empphoneno"
        Me.empphoneno.Size = New System.Drawing.Size(190, 20)
        Me.empphoneno.TabIndex = 15
        '
        'empdepartment
        '
        Me.empdepartment.Location = New System.Drawing.Point(119, 532)
        Me.empdepartment.Name = "empdepartment"
        Me.empdepartment.Size = New System.Drawing.Size(190, 20)
        Me.empdepartment.TabIndex = 19
        '
        'empsalary
        '
        Me.empsalary.Location = New System.Drawing.Point(119, 577)
        Me.empsalary.Name = "empsalary"
        Me.empsalary.Size = New System.Drawing.Size(190, 20)
        Me.empsalary.TabIndex = 21
        '
        'empphoto
        '
        Me.empphoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.empphoto.BackColor = System.Drawing.Color.Gainsboro
        Me.empphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.empphoto.Location = New System.Drawing.Point(788, 141)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(153, 193)
        Me.empphoto.TabIndex = 22
        Me.empphoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(771, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(866, 553)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'empgender
        '
        Me.empgender.FormattingEnabled = True
        Me.empgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.empgender.Location = New System.Drawing.Point(119, 341)
        Me.empgender.Name = "empgender"
        Me.empgender.Size = New System.Drawing.Size(190, 21)
        Me.empgender.TabIndex = 26
        '
        'empcategory
        '
        Me.empcategory.Location = New System.Drawing.Point(119, 454)
        Me.empcategory.Name = "empcategory"
        Me.empcategory.Size = New System.Drawing.Size(190, 20)
        Me.empcategory.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(37, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(119, 409)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(190, 20)
        Me.txtDob.TabIndex = 30
        '
        'txtDoj
        '
        Me.txtDoj.Location = New System.Drawing.Point(119, 495)
        Me.txtDoj.Name = "txtDoj"
        Me.txtDoj.Size = New System.Drawing.Size(190, 20)
        Me.txtDoj.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(835, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1029, 659)
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
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Registration"
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents empno As TextBox
    Friend WithEvents empfirstname As TextBox
    Friend WithEvents emplastname As TextBox
    Friend WithEvents empaddress As TextBox
    Friend WithEvents empphoneno As TextBox
    Friend WithEvents empdepartment As TextBox
    Friend WithEvents empsalary As TextBox
    Friend WithEvents empphoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents empgender As ComboBox
    Friend WithEvents empcategory As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDob As DateTimePicker
    Friend WithEvents txtDoj As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
