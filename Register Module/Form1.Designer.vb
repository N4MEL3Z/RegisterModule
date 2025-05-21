<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Register = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.studentNoTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.ContactTxt = New System.Windows.Forms.TextBox()
        Me.EmTxt = New System.Windows.Forms.TextBox()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EnrStatusTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PrvSchlTxt = New System.Windows.Forms.TextBox()
        Me.YrlvlTxt = New System.Windows.Forms.TextBox()
        Me.CourseTxt = New System.Windows.Forms.TextBox()
        Me.EnrDateTxt = New System.Windows.Forms.TextBox()
        Me.AcadTxt = New System.Windows.Forms.TextBox()
        Me.PaymentTxt = New System.Windows.Forms.TextBox()
        Me.Sub1Cmb = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ModeCMB = New System.Windows.Forms.ComboBox()
        Me.Sub3Cmb = New System.Windows.Forms.ComboBox()
        Me.Sub2Cmb = New System.Windows.Forms.ComboBox()
        Me.Sub4Cmb = New System.Windows.Forms.ComboBox()
        Me.Sub5Cmb = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Register)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 71)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.Register.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register.ForeColor = System.Drawing.Color.White
        Me.Register.Location = New System.Drawing.Point(453, 22)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(185, 37)
        Me.Register.TabIndex = 2
        Me.Register.Text = "REGISTER"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(703, 369)
        Me.DataGridView1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(726, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "StudentNO"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(726, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contact"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(726, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "EM Contact"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(726, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(726, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 28)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email"
        '
        'studentNoTxt
        '
        Me.studentNoTxt.BackColor = System.Drawing.Color.LightGray
        Me.studentNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentNoTxt.Location = New System.Drawing.Point(877, 120)
        Me.studentNoTxt.Multiline = True
        Me.studentNoTxt.Name = "studentNoTxt"
        Me.studentNoTxt.Size = New System.Drawing.Size(175, 29)
        Me.studentNoTxt.TabIndex = 8
        '
        'NameTxt
        '
        Me.NameTxt.BackColor = System.Drawing.Color.LightGray
        Me.NameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTxt.Location = New System.Drawing.Point(877, 162)
        Me.NameTxt.Multiline = True
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(175, 28)
        Me.NameTxt.TabIndex = 9
        '
        'ContactTxt
        '
        Me.ContactTxt.BackColor = System.Drawing.Color.LightGray
        Me.ContactTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactTxt.Location = New System.Drawing.Point(877, 329)
        Me.ContactTxt.Multiline = True
        Me.ContactTxt.Name = "ContactTxt"
        Me.ContactTxt.Size = New System.Drawing.Size(175, 28)
        Me.ContactTxt.TabIndex = 10
        '
        'EmTxt
        '
        Me.EmTxt.BackColor = System.Drawing.Color.LightGray
        Me.EmTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmTxt.Location = New System.Drawing.Point(877, 376)
        Me.EmTxt.Multiline = True
        Me.EmTxt.Name = "EmTxt"
        Me.EmTxt.Size = New System.Drawing.Size(175, 28)
        Me.EmTxt.TabIndex = 11
        '
        'EmailTxt
        '
        Me.EmailTxt.BackColor = System.Drawing.Color.LightGray
        Me.EmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTxt.Location = New System.Drawing.Point(877, 418)
        Me.EmailTxt.Multiline = True
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(175, 28)
        Me.EmailTxt.TabIndex = 12
        '
        'registerBtn
        '
        Me.registerBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerBtn.Location = New System.Drawing.Point(728, 650)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(114, 47)
        Me.registerBtn.TabIndex = 13
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(877, 650)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(114, 47)
        Me.ClearBtn.TabIndex = 14
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Academic Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GenderTxt
        '
        Me.GenderTxt.BackColor = System.Drawing.Color.LightGray
        Me.GenderTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GenderTxt.Location = New System.Drawing.Point(877, 201)
        Me.GenderTxt.Multiline = True
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(175, 28)
        Me.GenderTxt.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(726, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Gender"
        '
        'AgeTxt
        '
        Me.AgeTxt.BackColor = System.Drawing.Color.LightGray
        Me.AgeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AgeTxt.Location = New System.Drawing.Point(877, 240)
        Me.AgeTxt.Multiline = True
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.Size = New System.Drawing.Size(175, 28)
        Me.AgeTxt.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(726, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 28)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Age"
        '
        'AddressTxt
        '
        Me.AddressTxt.BackColor = System.Drawing.Color.LightGray
        Me.AddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddressTxt.Location = New System.Drawing.Point(877, 284)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(175, 28)
        Me.AddressTxt.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(726, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Address"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 492)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 21)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Course"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 547)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Yr Lvl"
        '
        'EnrStatusTxt
        '
        Me.EnrStatusTxt.BackColor = System.Drawing.Color.LightGray
        Me.EnrStatusTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnrStatusTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrStatusTxt.Location = New System.Drawing.Point(93, 593)
        Me.EnrStatusTxt.Multiline = True
        Me.EnrStatusTxt.Name = "EnrStatusTxt"
        Me.EnrStatusTxt.Size = New System.Drawing.Size(175, 33)
        Me.EnrStatusTxt.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 593)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 41)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Enrollment Status"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 648)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 34)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Previous School"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(811, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(201, 21)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Student Information"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(321, 648)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 34)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Payment Status"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(696, 476)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 21)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Subjects"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(320, 548)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 21)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Acad Yr"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(340, 449)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(196, 25)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Enrollment Information"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(321, 479)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 34)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Enrollment Date"
        '
        'PrvSchlTxt
        '
        Me.PrvSchlTxt.BackColor = System.Drawing.Color.LightGray
        Me.PrvSchlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrvSchlTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrvSchlTxt.Location = New System.Drawing.Point(93, 648)
        Me.PrvSchlTxt.Multiline = True
        Me.PrvSchlTxt.Name = "PrvSchlTxt"
        Me.PrvSchlTxt.Size = New System.Drawing.Size(175, 33)
        Me.PrvSchlTxt.TabIndex = 43
        '
        'YrlvlTxt
        '
        Me.YrlvlTxt.BackColor = System.Drawing.Color.LightGray
        Me.YrlvlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.YrlvlTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YrlvlTxt.Location = New System.Drawing.Point(93, 535)
        Me.YrlvlTxt.Multiline = True
        Me.YrlvlTxt.Name = "YrlvlTxt"
        Me.YrlvlTxt.Size = New System.Drawing.Size(175, 33)
        Me.YrlvlTxt.TabIndex = 44
        '
        'CourseTxt
        '
        Me.CourseTxt.BackColor = System.Drawing.Color.LightGray
        Me.CourseTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CourseTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseTxt.Location = New System.Drawing.Point(93, 480)
        Me.CourseTxt.Multiline = True
        Me.CourseTxt.Name = "CourseTxt"
        Me.CourseTxt.Size = New System.Drawing.Size(175, 33)
        Me.CourseTxt.TabIndex = 45
        '
        'EnrDateTxt
        '
        Me.EnrDateTxt.BackColor = System.Drawing.Color.LightGray
        Me.EnrDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnrDateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrDateTxt.Location = New System.Drawing.Point(422, 476)
        Me.EnrDateTxt.Multiline = True
        Me.EnrDateTxt.Name = "EnrDateTxt"
        Me.EnrDateTxt.Size = New System.Drawing.Size(175, 33)
        Me.EnrDateTxt.TabIndex = 46
        '
        'AcadTxt
        '
        Me.AcadTxt.BackColor = System.Drawing.Color.LightGray
        Me.AcadTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AcadTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcadTxt.Location = New System.Drawing.Point(422, 535)
        Me.AcadTxt.Multiline = True
        Me.AcadTxt.Name = "AcadTxt"
        Me.AcadTxt.Size = New System.Drawing.Size(175, 33)
        Me.AcadTxt.TabIndex = 47
        '
        'PaymentTxt
        '
        Me.PaymentTxt.BackColor = System.Drawing.Color.LightGray
        Me.PaymentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PaymentTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentTxt.Location = New System.Drawing.Point(422, 645)
        Me.PaymentTxt.Multiline = True
        Me.PaymentTxt.Name = "PaymentTxt"
        Me.PaymentTxt.Size = New System.Drawing.Size(175, 33)
        Me.PaymentTxt.TabIndex = 49
        '
        'Sub1Cmb
        '
        Me.Sub1Cmb.FormattingEnabled = True
        Me.Sub1Cmb.Location = New System.Drawing.Point(700, 500)
        Me.Sub1Cmb.Name = "Sub1Cmb"
        Me.Sub1Cmb.Size = New System.Drawing.Size(142, 21)
        Me.Sub1Cmb.TabIndex = 50
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(321, 593)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 42)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "Mode Of Learning"
        '
        'ModeCMB
        '
        Me.ModeCMB.FormattingEnabled = True
        Me.ModeCMB.Items.AddRange(New Object() {"F2F", "OC", "Hybrid"})
        Me.ModeCMB.Location = New System.Drawing.Point(422, 605)
        Me.ModeCMB.Name = "ModeCMB"
        Me.ModeCMB.Size = New System.Drawing.Size(175, 21)
        Me.ModeCMB.TabIndex = 52
        '
        'Sub3Cmb
        '
        Me.Sub3Cmb.FormattingEnabled = True
        Me.Sub3Cmb.Location = New System.Drawing.Point(700, 550)
        Me.Sub3Cmb.Name = "Sub3Cmb"
        Me.Sub3Cmb.Size = New System.Drawing.Size(142, 21)
        Me.Sub3Cmb.TabIndex = 53
        '
        'Sub2Cmb
        '
        Me.Sub2Cmb.FormattingEnabled = True
        Me.Sub2Cmb.Location = New System.Drawing.Point(877, 500)
        Me.Sub2Cmb.Name = "Sub2Cmb"
        Me.Sub2Cmb.Size = New System.Drawing.Size(142, 21)
        Me.Sub2Cmb.TabIndex = 54
        '
        'Sub4Cmb
        '
        Me.Sub4Cmb.FormattingEnabled = True
        Me.Sub4Cmb.Location = New System.Drawing.Point(877, 549)
        Me.Sub4Cmb.Name = "Sub4Cmb"
        Me.Sub4Cmb.Size = New System.Drawing.Size(142, 21)
        Me.Sub4Cmb.TabIndex = 55
        '
        'Sub5Cmb
        '
        Me.Sub5Cmb.FormattingEnabled = True
        Me.Sub5Cmb.Location = New System.Drawing.Point(790, 592)
        Me.Sub5Cmb.Name = "Sub5Cmb"
        Me.Sub5Cmb.Size = New System.Drawing.Size(142, 21)
        Me.Sub5Cmb.TabIndex = 56
        '
        'RegisterFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1076, 709)
        Me.Controls.Add(Me.Sub5Cmb)
        Me.Controls.Add(Me.Sub4Cmb)
        Me.Controls.Add(Me.Sub2Cmb)
        Me.Controls.Add(Me.Sub3Cmb)
        Me.Controls.Add(Me.ModeCMB)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Sub1Cmb)
        Me.Controls.Add(Me.PaymentTxt)
        Me.Controls.Add(Me.AcadTxt)
        Me.Controls.Add(Me.EnrDateTxt)
        Me.Controls.Add(Me.CourseTxt)
        Me.Controls.Add(Me.YrlvlTxt)
        Me.Controls.Add(Me.PrvSchlTxt)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.EnrStatusTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AgeTxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GenderTxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.EmailTxt)
        Me.Controls.Add(Me.EmTxt)
        Me.Controls.Add(Me.ContactTxt)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.studentNoTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "RegisterFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar DashBoard"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Register As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents studentNoTxt As TextBox
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents ContactTxt As TextBox
    Friend WithEvents EmTxt As TextBox
    Friend WithEvents EmailTxt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GenderTxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents AgeTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents AddressTxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EnrStatusTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PrvSchlTxt As TextBox
    Friend WithEvents YrlvlTxt As TextBox
    Friend WithEvents CourseTxt As TextBox
    Friend WithEvents EnrDateTxt As TextBox
    Friend WithEvents AcadTxt As TextBox
    Friend WithEvents PaymentTxt As TextBox
    Friend WithEvents Sub1Cmb As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ModeCMB As ComboBox
    Friend WithEvents Sub3Cmb As ComboBox
    Friend WithEvents Sub2Cmb As ComboBox
    Friend WithEvents Sub4Cmb As ComboBox
    Friend WithEvents Sub5Cmb As ComboBox
End Class
