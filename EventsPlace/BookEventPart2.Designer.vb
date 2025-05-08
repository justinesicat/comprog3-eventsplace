<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookEventPart2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookEventPart2))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_CustomerInformation = New System.Windows.Forms.PictureBox()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_Name = New System.Windows.Forms.PictureBox()
        Me.lbl_Age = New System.Windows.Forms.Label()
        Me.lbl_Birthday = New System.Windows.Forms.Label()
        Me.lbl_Sex = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbox_Birthday = New System.Windows.Forms.PictureBox()
        Me.pbox_Age = New System.Windows.Forms.PictureBox()
        Me.pbox_Address = New System.Windows.Forms.PictureBox()
        Me.pbox_Sex = New System.Windows.Forms.PictureBox()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.txtbox_Name = New System.Windows.Forms.TextBox()
        Me.txtbox_Address = New System.Windows.Forms.TextBox()
        Me.lbl_BirthdayFill = New System.Windows.Forms.Label()
        Me.lbl_AgeFill = New System.Windows.Forms.Label()
        Me.cmb_Sex = New System.Windows.Forms.ComboBox()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Venue = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_CustomerInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Birthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Age, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Address, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Sex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Title.Location = New System.Drawing.Point(96, 18)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(563, 37)
        Me.lbl_Title.TabIndex = 31
        Me.lbl_Title.Text = "BOOK EVENT - BOOKER INFORMATION"
        '
        'pbox_CustomerInformation
        '
        Me.pbox_CustomerInformation.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_CustomerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_CustomerInformation.Location = New System.Drawing.Point(103, 90)
        Me.pbox_CustomerInformation.Name = "pbox_CustomerInformation"
        Me.pbox_CustomerInformation.Size = New System.Drawing.Size(833, 358)
        Me.pbox_CustomerInformation.TabIndex = 62
        Me.pbox_CustomerInformation.TabStop = False
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Name.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Name.Location = New System.Drawing.Point(144, 113)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(122, 37)
        Me.lbl_Name.TabIndex = 63
        Me.lbl_Name.Text = "Name :"
        '
        'btn_Minimize
        '
        Me.btn_Minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Font = New System.Drawing.Font("Helvetica Rounded", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Minimize.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_Minimize.Location = New System.Drawing.Point(874, 12)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(42, 42)
        Me.btn_Minimize.TabIndex = 71
        Me.btn_Minimize.Text = "━"
        Me.btn_Minimize.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Helvetica Rounded", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_Close.Location = New System.Drawing.Point(918, 12)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(42, 42)
        Me.btn_Close.TabIndex = 70
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'pbox_Name
        '
        Me.pbox_Name.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Name.Location = New System.Drawing.Point(151, 156)
        Me.pbox_Name.Name = "pbox_Name"
        Me.pbox_Name.Size = New System.Drawing.Size(738, 50)
        Me.pbox_Name.TabIndex = 72
        Me.pbox_Name.TabStop = False
        '
        'lbl_Age
        '
        Me.lbl_Age.AutoSize = True
        Me.lbl_Age.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Age.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Age.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Age.Location = New System.Drawing.Point(529, 324)
        Me.lbl_Age.Name = "lbl_Age"
        Me.lbl_Age.Size = New System.Drawing.Size(94, 37)
        Me.lbl_Age.TabIndex = 73
        Me.lbl_Age.Text = "Age :"
        '
        'lbl_Birthday
        '
        Me.lbl_Birthday.AutoSize = True
        Me.lbl_Birthday.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Birthday.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Birthday.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Birthday.Location = New System.Drawing.Point(142, 324)
        Me.lbl_Birthday.Name = "lbl_Birthday"
        Me.lbl_Birthday.Size = New System.Drawing.Size(151, 37)
        Me.lbl_Birthday.TabIndex = 74
        Me.lbl_Birthday.Text = "Birthday :"
        '
        'lbl_Sex
        '
        Me.lbl_Sex.AutoSize = True
        Me.lbl_Sex.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Sex.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sex.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Sex.Location = New System.Drawing.Point(652, 324)
        Me.lbl_Sex.Name = "lbl_Sex"
        Me.lbl_Sex.Size = New System.Drawing.Size(85, 37)
        Me.lbl_Sex.TabIndex = 75
        Me.lbl_Sex.Text = "Sex :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(144, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 37)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Address :"
        '
        'pbox_Birthday
        '
        Me.pbox_Birthday.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Birthday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Birthday.Location = New System.Drawing.Point(149, 367)
        Me.pbox_Birthday.Name = "pbox_Birthday"
        Me.pbox_Birthday.Size = New System.Drawing.Size(360, 50)
        Me.pbox_Birthday.TabIndex = 77
        Me.pbox_Birthday.TabStop = False
        '
        'pbox_Age
        '
        Me.pbox_Age.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Age.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Age.Location = New System.Drawing.Point(536, 367)
        Me.pbox_Age.Name = "pbox_Age"
        Me.pbox_Age.Size = New System.Drawing.Size(97, 50)
        Me.pbox_Age.TabIndex = 78
        Me.pbox_Age.TabStop = False
        '
        'pbox_Address
        '
        Me.pbox_Address.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Address.Location = New System.Drawing.Point(151, 263)
        Me.pbox_Address.Name = "pbox_Address"
        Me.pbox_Address.Size = New System.Drawing.Size(737, 50)
        Me.pbox_Address.TabIndex = 79
        Me.pbox_Address.TabStop = False
        '
        'pbox_Sex
        '
        Me.pbox_Sex.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Sex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Sex.Location = New System.Drawing.Point(659, 367)
        Me.pbox_Sex.Name = "pbox_Sex"
        Me.pbox_Sex.Size = New System.Drawing.Size(230, 50)
        Me.pbox_Sex.TabIndex = 80
        Me.pbox_Sex.TabStop = False
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Next.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.ForeColor = System.Drawing.Color.White
        Me.btn_Next.Location = New System.Drawing.Point(216, 467)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(278, 53)
        Me.btn_Next.TabIndex = 82
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(560, 467)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(278, 53)
        Me.btn_Back.TabIndex = 81
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'txtbox_Name
        '
        Me.txtbox_Name.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_Name.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Name.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_Name.Location = New System.Drawing.Point(164, 166)
        Me.txtbox_Name.MaxLength = 200
        Me.txtbox_Name.Name = "txtbox_Name"
        Me.txtbox_Name.Size = New System.Drawing.Size(712, 29)
        Me.txtbox_Name.TabIndex = 115
        '
        'txtbox_Address
        '
        Me.txtbox_Address.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_Address.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Address.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_Address.Location = New System.Drawing.Point(164, 273)
        Me.txtbox_Address.MaxLength = 200
        Me.txtbox_Address.Name = "txtbox_Address"
        Me.txtbox_Address.Size = New System.Drawing.Size(712, 29)
        Me.txtbox_Address.TabIndex = 116
        '
        'lbl_BirthdayFill
        '
        Me.lbl_BirthdayFill.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_BirthdayFill.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BirthdayFill.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_BirthdayFill.Location = New System.Drawing.Point(164, 379)
        Me.lbl_BirthdayFill.Name = "lbl_BirthdayFill"
        Me.lbl_BirthdayFill.Size = New System.Drawing.Size(329, 27)
        Me.lbl_BirthdayFill.TabIndex = 117
        Me.lbl_BirthdayFill.Text = "MM / DD / YYYY"
        Me.lbl_BirthdayFill.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_AgeFill
        '
        Me.lbl_AgeFill.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_AgeFill.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AgeFill.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_AgeFill.Location = New System.Drawing.Point(546, 379)
        Me.lbl_AgeFill.Name = "lbl_AgeFill"
        Me.lbl_AgeFill.Size = New System.Drawing.Size(78, 27)
        Me.lbl_AgeFill.TabIndex = 118
        Me.lbl_AgeFill.Text = "AGE"
        Me.lbl_AgeFill.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_Sex
        '
        Me.cmb_Sex.BackColor = System.Drawing.Color.White
        Me.cmb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_Sex.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sex.ForeColor = System.Drawing.Color.Chocolate
        Me.cmb_Sex.FormattingEnabled = True
        Me.cmb_Sex.Items.AddRange(New Object() {"Male", "Female", "Nonbinary", "Prefer not to say"})
        Me.cmb_Sex.Location = New System.Drawing.Point(669, 375)
        Me.cmb_Sex.Name = "cmb_Sex"
        Me.cmb_Sex.Size = New System.Drawing.Size(212, 35)
        Me.cmb_Sex.TabIndex = 119
        '
        'Calendar
        '
        Me.Calendar.Location = New System.Drawing.Point(-255, 539)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 120
        Me.Calendar.Visible = False
        '
        'pbox_Home
        '
        Me.pbox_Home.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_Home.ErrorImage = Nothing
        Me.pbox_Home.Location = New System.Drawing.Point(0, 0)
        Me.pbox_Home.Name = "pbox_Home"
        Me.pbox_Home.Size = New System.Drawing.Size(68, 68)
        Me.pbox_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Home.TabIndex = 171
        Me.pbox_Home.TabStop = False
        '
        'pbox_Venue
        '
        Me.pbox_Venue.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Venue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_Venue.ErrorImage = Nothing
        Me.pbox_Venue.Location = New System.Drawing.Point(0, 68)
        Me.pbox_Venue.Name = "pbox_Venue"
        Me.pbox_Venue.Size = New System.Drawing.Size(68, 68)
        Me.pbox_Venue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Venue.TabIndex = 170
        Me.pbox_Venue.TabStop = False
        '
        'pbox_Account
        '
        Me.pbox_Account.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Account.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_Account.ErrorImage = Nothing
        Me.pbox_Account.Location = New System.Drawing.Point(0, 410)
        Me.pbox_Account.Name = "pbox_Account"
        Me.pbox_Account.Size = New System.Drawing.Size(68, 68)
        Me.pbox_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Account.TabIndex = 169
        Me.pbox_Account.TabStop = False
        '
        'BookEventPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalCustomerBooking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.pbox_Venue)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.cmb_Sex)
        Me.Controls.Add(Me.lbl_AgeFill)
        Me.Controls.Add(Me.lbl_BirthdayFill)
        Me.Controls.Add(Me.txtbox_Address)
        Me.Controls.Add(Me.txtbox_Name)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.pbox_Sex)
        Me.Controls.Add(Me.pbox_Address)
        Me.Controls.Add(Me.pbox_Age)
        Me.Controls.Add(Me.pbox_Birthday)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Sex)
        Me.Controls.Add(Me.lbl_Birthday)
        Me.Controls.Add(Me.lbl_Age)
        Me.Controls.Add(Me.pbox_Name)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_Name)
        Me.Controls.Add(Me.pbox_CustomerInformation)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookEventPart2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_CustomerInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Birthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Age, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Address, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Sex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_CustomerInformation As PictureBox
    Friend WithEvents lbl_Name As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_Name As PictureBox
    Friend WithEvents lbl_Age As Label
    Friend WithEvents lbl_Birthday As Label
    Friend WithEvents lbl_Sex As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pbox_Birthday As PictureBox
    Friend WithEvents pbox_Age As PictureBox
    Friend WithEvents pbox_Address As PictureBox
    Friend WithEvents pbox_Sex As PictureBox
    Friend WithEvents btn_Next As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents txtbox_Name As TextBox
    Friend WithEvents txtbox_Address As TextBox
    Friend WithEvents lbl_BirthdayFill As Label
    Friend WithEvents lbl_AgeFill As Label
    Friend WithEvents cmb_Sex As ComboBox
    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Venue As PictureBox
    Friend WithEvents pbox_Account As PictureBox
End Class
