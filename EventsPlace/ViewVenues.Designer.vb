<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewVenues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewVenues))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.pbox_Booking = New System.Windows.Forms.PictureBox()
        Me.lbl_Price = New System.Windows.Forms.Label()
        Me.lbl_Capacity = New System.Windows.Forms.Label()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.lbl_NoImage = New System.Windows.Forms.Label()
        Me.pbox_VenuePic = New System.Windows.Forms.PictureBox()
        Me.lbl_Features = New System.Windows.Forms.Label()
        Me.cbox_Lightings = New System.Windows.Forms.CheckBox()
        Me.cbox_Stage = New System.Windows.Forms.CheckBox()
        Me.cbox_WiFi = New System.Windows.Forms.CheckBox()
        Me.cbox_Projector = New System.Windows.Forms.CheckBox()
        Me.cbox_SS = New System.Windows.Forms.CheckBox()
        Me.cbox_AC = New System.Windows.Forms.CheckBox()
        Me.pbox_VenueInfo2 = New System.Windows.Forms.PictureBox()
        Me.txtb_Price = New System.Windows.Forms.TextBox()
        Me.pbox_Price = New System.Windows.Forms.PictureBox()
        Me.txtb_Capacity = New System.Windows.Forms.TextBox()
        Me.pbox_Capacity = New System.Windows.Forms.PictureBox()
        Me.txtb_Type = New System.Windows.Forms.TextBox()
        Me.pbox_Username = New System.Windows.Forms.PictureBox()
        Me.VenueTable = New System.Windows.Forms.DataGridView()
        Me.pbox_VenueInfo1 = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_VenueType = New System.Windows.Forms.Label()
        Me.pbox_VenueType = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Price, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Capacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Title
        '
        Me.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Title.Location = New System.Drawing.Point(95, 18)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(207, 37)
        Me.lbl_Title.TabIndex = 24
        Me.lbl_Title.Text = "VIEW VENUES"
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
        Me.btn_Minimize.TabIndex = 31
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
        Me.btn_Close.TabIndex = 30
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
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
        Me.pbox_Home.TabIndex = 35
        Me.pbox_Home.TabStop = False
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
        Me.pbox_Account.TabIndex = 36
        Me.pbox_Account.TabStop = False
        '
        'pbox_Booking
        '
        Me.pbox_Booking.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Booking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_Booking.ErrorImage = Nothing
        Me.pbox_Booking.Location = New System.Drawing.Point(0, 139)
        Me.pbox_Booking.Name = "pbox_Booking"
        Me.pbox_Booking.Size = New System.Drawing.Size(68, 68)
        Me.pbox_Booking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Booking.TabIndex = 37
        Me.pbox_Booking.TabStop = False
        '
        'lbl_Price
        '
        Me.lbl_Price.AutoSize = True
        Me.lbl_Price.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Price.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Price.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Price.Location = New System.Drawing.Point(173, 373)
        Me.lbl_Price.Name = "lbl_Price"
        Me.lbl_Price.Size = New System.Drawing.Size(141, 23)
        Me.lbl_Price.TabIndex = 135
        Me.lbl_Price.Text = "Price per Day"
        '
        'lbl_Capacity
        '
        Me.lbl_Capacity.AutoSize = True
        Me.lbl_Capacity.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Capacity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Capacity.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Capacity.Location = New System.Drawing.Point(173, 299)
        Me.lbl_Capacity.Name = "lbl_Capacity"
        Me.lbl_Capacity.Size = New System.Drawing.Size(101, 23)
        Me.lbl_Capacity.TabIndex = 134
        Me.lbl_Capacity.Text = "Capacity"
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Type.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Type.Location = New System.Drawing.Point(173, 225)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(56, 23)
        Me.lbl_Type.TabIndex = 133
        Me.lbl_Type.Text = "Type"
        '
        'lbl_NoImage
        '
        Me.lbl_NoImage.AutoSize = True
        Me.lbl_NoImage.BackColor = System.Drawing.Color.White
        Me.lbl_NoImage.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoImage.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_NoImage.Location = New System.Drawing.Point(728, 221)
        Me.lbl_NoImage.Name = "lbl_NoImage"
        Me.lbl_NoImage.Size = New System.Drawing.Size(75, 37)
        Me.lbl_NoImage.TabIndex = 131
        Me.lbl_NoImage.Text = "N/A"
        '
        'pbox_VenuePic
        '
        Me.pbox_VenuePic.BackColor = System.Drawing.Color.White
        Me.pbox_VenuePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenuePic.Location = New System.Drawing.Point(601, 165)
        Me.pbox_VenuePic.Name = "pbox_VenuePic"
        Me.pbox_VenuePic.Size = New System.Drawing.Size(321, 148)
        Me.pbox_VenuePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_VenuePic.TabIndex = 129
        Me.pbox_VenuePic.TabStop = False
        '
        'lbl_Features
        '
        Me.lbl_Features.AutoSize = True
        Me.lbl_Features.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Features.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Features.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Features.Location = New System.Drawing.Point(594, 316)
        Me.lbl_Features.Name = "lbl_Features"
        Me.lbl_Features.Size = New System.Drawing.Size(166, 37)
        Me.lbl_Features.TabIndex = 128
        Me.lbl_Features.Text = "FEATURES :"
        '
        'cbox_Lightings
        '
        Me.cbox_Lightings.AutoSize = True
        Me.cbox_Lightings.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_Lightings.Enabled = False
        Me.cbox_Lightings.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Lightings.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Lightings.Location = New System.Drawing.Point(806, 409)
        Me.cbox_Lightings.Name = "cbox_Lightings"
        Me.cbox_Lightings.Size = New System.Drawing.Size(116, 27)
        Me.cbox_Lightings.TabIndex = 127
        Me.cbox_Lightings.Text = "Lightings"
        Me.cbox_Lightings.UseVisualStyleBackColor = False
        '
        'cbox_Stage
        '
        Me.cbox_Stage.AutoSize = True
        Me.cbox_Stage.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_Stage.Enabled = False
        Me.cbox_Stage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Stage.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Stage.Location = New System.Drawing.Point(806, 383)
        Me.cbox_Stage.Name = "cbox_Stage"
        Me.cbox_Stage.Size = New System.Drawing.Size(87, 27)
        Me.cbox_Stage.TabIndex = 126
        Me.cbox_Stage.Text = "Stage"
        Me.cbox_Stage.UseVisualStyleBackColor = False
        '
        'cbox_WiFi
        '
        Me.cbox_WiFi.AutoSize = True
        Me.cbox_WiFi.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_WiFi.Enabled = False
        Me.cbox_WiFi.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_WiFi.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_WiFi.Location = New System.Drawing.Point(806, 356)
        Me.cbox_WiFi.Name = "cbox_WiFi"
        Me.cbox_WiFi.Size = New System.Drawing.Size(78, 27)
        Me.cbox_WiFi.TabIndex = 125
        Me.cbox_WiFi.Text = "Wi-Fi"
        Me.cbox_WiFi.UseVisualStyleBackColor = False
        '
        'cbox_Projector
        '
        Me.cbox_Projector.AutoSize = True
        Me.cbox_Projector.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_Projector.Enabled = False
        Me.cbox_Projector.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Projector.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Projector.Location = New System.Drawing.Point(601, 409)
        Me.cbox_Projector.Name = "cbox_Projector"
        Me.cbox_Projector.Size = New System.Drawing.Size(118, 27)
        Me.cbox_Projector.TabIndex = 124
        Me.cbox_Projector.Text = "Projector"
        Me.cbox_Projector.UseVisualStyleBackColor = False
        '
        'cbox_SS
        '
        Me.cbox_SS.AutoSize = True
        Me.cbox_SS.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_SS.Enabled = False
        Me.cbox_SS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_SS.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_SS.Location = New System.Drawing.Point(601, 383)
        Me.cbox_SS.Name = "cbox_SS"
        Me.cbox_SS.Size = New System.Drawing.Size(167, 27)
        Me.cbox_SS.TabIndex = 123
        Me.cbox_SS.Text = "Sound System"
        Me.cbox_SS.UseVisualStyleBackColor = False
        '
        'cbox_AC
        '
        Me.cbox_AC.AutoSize = True
        Me.cbox_AC.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_AC.Enabled = False
        Me.cbox_AC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_AC.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_AC.Location = New System.Drawing.Point(601, 356)
        Me.cbox_AC.Name = "cbox_AC"
        Me.cbox_AC.Size = New System.Drawing.Size(189, 27)
        Me.cbox_AC.TabIndex = 122
        Me.cbox_AC.Text = "Air Conditioning"
        Me.cbox_AC.UseVisualStyleBackColor = False
        '
        'pbox_VenueInfo2
        '
        Me.pbox_VenueInfo2.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_VenueInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueInfo2.Location = New System.Drawing.Point(586, 90)
        Me.pbox_VenueInfo2.Name = "pbox_VenueInfo2"
        Me.pbox_VenueInfo2.Size = New System.Drawing.Size(350, 358)
        Me.pbox_VenueInfo2.TabIndex = 121
        Me.pbox_VenueInfo2.TabStop = False
        '
        'txtb_Price
        '
        Me.txtb_Price.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Price.Enabled = False
        Me.txtb_Price.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Price.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Price.Location = New System.Drawing.Point(177, 399)
        Me.txtb_Price.MaxLength = 16
        Me.txtb_Price.Name = "txtb_Price"
        Me.txtb_Price.Size = New System.Drawing.Size(320, 29)
        Me.txtb_Price.TabIndex = 120
        '
        'pbox_Price
        '
        Me.pbox_Price.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Price.Location = New System.Drawing.Point(166, 370)
        Me.pbox_Price.Name = "pbox_Price"
        Me.pbox_Price.Size = New System.Drawing.Size(342, 66)
        Me.pbox_Price.TabIndex = 119
        Me.pbox_Price.TabStop = False
        '
        'txtb_Capacity
        '
        Me.txtb_Capacity.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Capacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Capacity.Enabled = False
        Me.txtb_Capacity.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Capacity.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Capacity.Location = New System.Drawing.Point(177, 325)
        Me.txtb_Capacity.MaxLength = 4
        Me.txtb_Capacity.Name = "txtb_Capacity"
        Me.txtb_Capacity.Size = New System.Drawing.Size(320, 29)
        Me.txtb_Capacity.TabIndex = 118
        '
        'pbox_Capacity
        '
        Me.pbox_Capacity.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Capacity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Capacity.Location = New System.Drawing.Point(166, 296)
        Me.pbox_Capacity.Name = "pbox_Capacity"
        Me.pbox_Capacity.Size = New System.Drawing.Size(342, 66)
        Me.pbox_Capacity.TabIndex = 117
        Me.pbox_Capacity.TabStop = False
        '
        'txtb_Type
        '
        Me.txtb_Type.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Type.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Type.Enabled = False
        Me.txtb_Type.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Type.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Type.Location = New System.Drawing.Point(177, 251)
        Me.txtb_Type.MaxLength = 16
        Me.txtb_Type.Name = "txtb_Type"
        Me.txtb_Type.Size = New System.Drawing.Size(320, 29)
        Me.txtb_Type.TabIndex = 116
        '
        'pbox_Username
        '
        Me.pbox_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Username.Location = New System.Drawing.Point(166, 222)
        Me.pbox_Username.Name = "pbox_Username"
        Me.pbox_Username.Size = New System.Drawing.Size(342, 66)
        Me.pbox_Username.TabIndex = 115
        Me.pbox_Username.TabStop = False
        '
        'VenueTable
        '
        Me.VenueTable.AllowUserToAddRows = False
        Me.VenueTable.AllowUserToDeleteRows = False
        Me.VenueTable.AllowUserToResizeColumns = False
        Me.VenueTable.AllowUserToResizeRows = False
        Me.VenueTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VenueTable.Location = New System.Drawing.Point(166, 103)
        Me.VenueTable.Name = "VenueTable"
        Me.VenueTable.ReadOnly = True
        Me.VenueTable.RowHeadersWidth = 51
        Me.VenueTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.VenueTable.RowTemplate.Height = 24
        Me.VenueTable.Size = New System.Drawing.Size(342, 110)
        Me.VenueTable.TabIndex = 114
        '
        'pbox_VenueInfo1
        '
        Me.pbox_VenueInfo1.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_VenueInfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueInfo1.Location = New System.Drawing.Point(103, 90)
        Me.pbox_VenueInfo1.Name = "pbox_VenueInfo1"
        Me.pbox_VenueInfo1.Size = New System.Drawing.Size(468, 358)
        Me.pbox_VenueInfo1.TabIndex = 113
        Me.pbox_VenueInfo1.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(376, 467)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(278, 53)
        Me.btn_Back.TabIndex = 109
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_VenueType
        '
        Me.lbl_VenueType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_VenueType.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_VenueType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VenueType.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_VenueType.Location = New System.Drawing.Point(601, 109)
        Me.lbl_VenueType.Name = "lbl_VenueType"
        Me.lbl_VenueType.Size = New System.Drawing.Size(321, 37)
        Me.lbl_VenueType.TabIndex = 137
        Me.lbl_VenueType.Text = "Venue"
        Me.lbl_VenueType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbox_VenueType
        '
        Me.pbox_VenueType.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_VenueType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueType.Location = New System.Drawing.Point(601, 103)
        Me.pbox_VenueType.Name = "pbox_VenueType"
        Me.pbox_VenueType.Size = New System.Drawing.Size(321, 50)
        Me.pbox_VenueType.TabIndex = 136
        Me.pbox_VenueType.TabStop = False
        '
        'ViewVenues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalCustomerViewVenues
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.lbl_VenueType)
        Me.Controls.Add(Me.pbox_VenueType)
        Me.Controls.Add(Me.lbl_Price)
        Me.Controls.Add(Me.lbl_Capacity)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.lbl_NoImage)
        Me.Controls.Add(Me.pbox_VenuePic)
        Me.Controls.Add(Me.lbl_Features)
        Me.Controls.Add(Me.cbox_Lightings)
        Me.Controls.Add(Me.cbox_Stage)
        Me.Controls.Add(Me.cbox_WiFi)
        Me.Controls.Add(Me.cbox_Projector)
        Me.Controls.Add(Me.cbox_SS)
        Me.Controls.Add(Me.cbox_AC)
        Me.Controls.Add(Me.pbox_VenueInfo2)
        Me.Controls.Add(Me.txtb_Price)
        Me.Controls.Add(Me.pbox_Price)
        Me.Controls.Add(Me.txtb_Capacity)
        Me.Controls.Add(Me.pbox_Capacity)
        Me.Controls.Add(Me.txtb_Type)
        Me.Controls.Add(Me.pbox_Username)
        Me.Controls.Add(Me.VenueTable)
        Me.Controls.Add(Me.pbox_VenueInfo1)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.pbox_Booking)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewVenues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Price, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Capacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents pbox_Booking As PictureBox
    Friend WithEvents lbl_Price As Label
    Friend WithEvents lbl_Capacity As Label
    Friend WithEvents lbl_Type As Label
    Friend WithEvents lbl_NoImage As Label
    Friend WithEvents pbox_VenuePic As PictureBox
    Friend WithEvents lbl_Features As Label
    Friend WithEvents cbox_Lightings As CheckBox
    Friend WithEvents cbox_Stage As CheckBox
    Friend WithEvents cbox_WiFi As CheckBox
    Friend WithEvents cbox_Projector As CheckBox
    Friend WithEvents cbox_SS As CheckBox
    Friend WithEvents cbox_AC As CheckBox
    Friend WithEvents pbox_VenueInfo2 As PictureBox
    Friend WithEvents txtb_Price As TextBox
    Friend WithEvents pbox_Price As PictureBox
    Friend WithEvents txtb_Capacity As TextBox
    Friend WithEvents pbox_Capacity As PictureBox
    Friend WithEvents txtb_Type As TextBox
    Friend WithEvents pbox_Username As PictureBox
    Friend WithEvents VenueTable As DataGridView
    Friend WithEvents pbox_VenueInfo1 As PictureBox
    Friend WithEvents btn_Back As Button
    Friend WithEvents lbl_VenueType As Label
    Friend WithEvents pbox_VenueType As PictureBox
End Class
