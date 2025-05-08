<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookEventPart1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookEventPart1))
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_DateDaysServices = New System.Windows.Forms.PictureBox()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.pbox_Day = New System.Windows.Forms.PictureBox()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.pbox_Month = New System.Windows.Forms.PictureBox()
        Me.lbl_Month = New System.Windows.Forms.Label()
        Me.pbox_Year = New System.Windows.Forms.PictureBox()
        Me.lbl_Year = New System.Windows.Forms.Label()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.pbox_VenueBox = New System.Windows.Forms.PictureBox()
        Me.pbox_VenuePic = New System.Windows.Forms.PictureBox()
        Me.pbox_VenueType = New System.Windows.Forms.PictureBox()
        Me.btn_Left = New System.Windows.Forms.Button()
        Me.btn_Right = New System.Windows.Forms.Button()
        Me.lbl_VenueType = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Venue = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.lbl_NoImage = New System.Windows.Forms.Label()
        Me.cbox_Lightings = New System.Windows.Forms.CheckBox()
        Me.cbox_Stage = New System.Windows.Forms.CheckBox()
        Me.cbox_WiFi = New System.Windows.Forms.CheckBox()
        Me.cbox_Projector = New System.Windows.Forms.CheckBox()
        Me.cbox_SS = New System.Windows.Forms.CheckBox()
        Me.cbox_AC = New System.Windows.Forms.CheckBox()
        Me.lbl_NoOfDays = New System.Windows.Forms.Label()
        Me.pbox_Days = New System.Windows.Forms.PictureBox()
        Me.txtbox_NoOfDays = New System.Windows.Forms.TextBox()
        Me.lbl_Services = New System.Windows.Forms.Label()
        Me.lbl_Days = New System.Windows.Forms.Label()
        Me.pbox_Services = New System.Windows.Forms.PictureBox()
        Me.cbox_Photography = New System.Windows.Forms.CheckBox()
        Me.cbox_Videoke = New System.Windows.Forms.CheckBox()
        Me.cbox_Dancer = New System.Windows.Forms.CheckBox()
        Me.cbox_Singer = New System.Windows.Forms.CheckBox()
        Me.cbox_Clown = New System.Windows.Forms.CheckBox()
        Me.cbox_Catering = New System.Windows.Forms.CheckBox()
        Me.lbl_Guests = New System.Windows.Forms.Label()
        Me.txtbox_NoOfGuests = New System.Windows.Forms.TextBox()
        Me.pbox_NoOfGuests = New System.Windows.Forms.PictureBox()
        Me.lbl_NoOfGuests = New System.Windows.Forms.Label()
        Me.lbl_MaxCapacity = New System.Windows.Forms.Label()
        Me.lbl_PricePerDay = New System.Windows.Forms.Label()
        CType(Me.pbox_DateDaysServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Day, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Days, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Services, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_NoOfGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_Back.TabIndex = 26
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
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
        Me.btn_Next.TabIndex = 28
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = False
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
        Me.lbl_Title.Size = New System.Drawing.Size(537, 37)
        Me.lbl_Title.TabIndex = 30
        Me.lbl_Title.Text = "BOOK EVENT - VENUE INFORMATION"
        '
        'pbox_DateDaysServices
        '
        Me.pbox_DateDaysServices.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_DateDaysServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_DateDaysServices.Location = New System.Drawing.Point(103, 90)
        Me.pbox_DateDaysServices.Name = "pbox_DateDaysServices"
        Me.pbox_DateDaysServices.Size = New System.Drawing.Size(468, 358)
        Me.pbox_DateDaysServices.TabIndex = 42
        Me.pbox_DateDaysServices.TabStop = False
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Date.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Date.Location = New System.Drawing.Point(131, 102)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(224, 37)
        Me.lbl_Date.TabIndex = 50
        Me.lbl_Date.Text = "Date of Event :"
        '
        'pbox_Day
        '
        Me.pbox_Day.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Day.Location = New System.Drawing.Point(138, 150)
        Me.pbox_Day.Name = "pbox_Day"
        Me.pbox_Day.Size = New System.Drawing.Size(91, 50)
        Me.pbox_Day.TabIndex = 54
        Me.pbox_Day.TabStop = False
        '
        'lbl_Day
        '
        Me.lbl_Day.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Day.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Day.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Day.Location = New System.Drawing.Point(145, 162)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(79, 27)
        Me.lbl_Day.TabIndex = 55
        Me.lbl_Day.Text = "DAY"
        Me.lbl_Day.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbox_Month
        '
        Me.pbox_Month.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Month.Location = New System.Drawing.Point(247, 150)
        Me.pbox_Month.Name = "pbox_Month"
        Me.pbox_Month.Size = New System.Drawing.Size(182, 50)
        Me.pbox_Month.TabIndex = 56
        Me.pbox_Month.TabStop = False
        '
        'lbl_Month
        '
        Me.lbl_Month.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Month.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Month.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Month.Location = New System.Drawing.Point(258, 162)
        Me.lbl_Month.Name = "lbl_Month"
        Me.lbl_Month.Size = New System.Drawing.Size(163, 27)
        Me.lbl_Month.TabIndex = 57
        Me.lbl_Month.Text = "MONTH"
        Me.lbl_Month.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pbox_Year
        '
        Me.pbox_Year.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Year.Location = New System.Drawing.Point(446, 150)
        Me.pbox_Year.Name = "pbox_Year"
        Me.pbox_Year.Size = New System.Drawing.Size(91, 50)
        Me.pbox_Year.TabIndex = 58
        Me.pbox_Year.TabStop = False
        '
        'lbl_Year
        '
        Me.lbl_Year.AutoEllipsis = True
        Me.lbl_Year.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_Year.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Year.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Year.Location = New System.Drawing.Point(453, 162)
        Me.lbl_Year.Name = "lbl_Year"
        Me.lbl_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_Year.Size = New System.Drawing.Size(81, 27)
        Me.lbl_Year.TabIndex = 59
        Me.lbl_Year.Text = "YEAR"
        Me.lbl_Year.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Calendar
        '
        Me.Calendar.Location = New System.Drawing.Point(-255, 539)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 27
        Me.Calendar.Visible = False
        '
        'pbox_VenueBox
        '
        Me.pbox_VenueBox.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_VenueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueBox.Location = New System.Drawing.Point(586, 90)
        Me.pbox_VenueBox.Name = "pbox_VenueBox"
        Me.pbox_VenueBox.Size = New System.Drawing.Size(350, 358)
        Me.pbox_VenueBox.TabIndex = 61
        Me.pbox_VenueBox.TabStop = False
        '
        'pbox_VenuePic
        '
        Me.pbox_VenuePic.BackColor = System.Drawing.Color.White
        Me.pbox_VenuePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenuePic.Location = New System.Drawing.Point(601, 163)
        Me.pbox_VenuePic.Name = "pbox_VenuePic"
        Me.pbox_VenuePic.Size = New System.Drawing.Size(321, 148)
        Me.pbox_VenuePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_VenuePic.TabIndex = 62
        Me.pbox_VenuePic.TabStop = False
        '
        'pbox_VenueType
        '
        Me.pbox_VenueType.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_VenueType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueType.Location = New System.Drawing.Point(658, 103)
        Me.pbox_VenueType.Name = "pbox_VenueType"
        Me.pbox_VenueType.Size = New System.Drawing.Size(207, 50)
        Me.pbox_VenueType.TabIndex = 64
        Me.pbox_VenueType.TabStop = False
        '
        'btn_Left
        '
        Me.btn_Left.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_Left.FlatAppearance.BorderSize = 0
        Me.btn_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Left.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Left.ForeColor = System.Drawing.Color.Chocolate
        Me.btn_Left.Location = New System.Drawing.Point(601, 103)
        Me.btn_Left.Name = "btn_Left"
        Me.btn_Left.Size = New System.Drawing.Size(50, 50)
        Me.btn_Left.TabIndex = 65
        Me.btn_Left.Text = "<"
        Me.btn_Left.UseVisualStyleBackColor = False
        '
        'btn_Right
        '
        Me.btn_Right.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn_Right.FlatAppearance.BorderSize = 0
        Me.btn_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Right.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Right.ForeColor = System.Drawing.Color.Chocolate
        Me.btn_Right.Location = New System.Drawing.Point(872, 103)
        Me.btn_Right.Name = "btn_Right"
        Me.btn_Right.Size = New System.Drawing.Size(50, 50)
        Me.btn_Right.TabIndex = 66
        Me.btn_Right.Text = ">"
        Me.btn_Right.UseVisualStyleBackColor = False
        '
        'lbl_VenueType
        '
        Me.lbl_VenueType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_VenueType.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_VenueType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_VenueType.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_VenueType.Location = New System.Drawing.Point(658, 109)
        Me.lbl_VenueType.Name = "lbl_VenueType"
        Me.lbl_VenueType.Size = New System.Drawing.Size(207, 37)
        Me.lbl_VenueType.TabIndex = 67
        Me.lbl_VenueType.Text = "Venue"
        Me.lbl_VenueType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_Minimize.TabIndex = 69
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
        Me.btn_Close.TabIndex = 68
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
        Me.pbox_Home.TabIndex = 72
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
        Me.pbox_Venue.TabIndex = 71
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
        Me.pbox_Account.TabIndex = 70
        Me.pbox_Account.TabStop = False
        '
        'lbl_NoImage
        '
        Me.lbl_NoImage.AutoSize = True
        Me.lbl_NoImage.BackColor = System.Drawing.Color.White
        Me.lbl_NoImage.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoImage.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_NoImage.Location = New System.Drawing.Point(728, 217)
        Me.lbl_NoImage.Name = "lbl_NoImage"
        Me.lbl_NoImage.Size = New System.Drawing.Size(75, 37)
        Me.lbl_NoImage.TabIndex = 104
        Me.lbl_NoImage.Text = "N/A"
        Me.lbl_NoImage.Visible = False
        '
        'cbox_Lightings
        '
        Me.cbox_Lightings.AutoSize = True
        Me.cbox_Lightings.BackColor = System.Drawing.Color.SeaShell
        Me.cbox_Lightings.Enabled = False
        Me.cbox_Lightings.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Lightings.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Lightings.Location = New System.Drawing.Point(806, 407)
        Me.cbox_Lightings.Name = "cbox_Lightings"
        Me.cbox_Lightings.Size = New System.Drawing.Size(116, 27)
        Me.cbox_Lightings.TabIndex = 110
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
        Me.cbox_Stage.Location = New System.Drawing.Point(806, 381)
        Me.cbox_Stage.Name = "cbox_Stage"
        Me.cbox_Stage.Size = New System.Drawing.Size(87, 27)
        Me.cbox_Stage.TabIndex = 109
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
        Me.cbox_WiFi.Location = New System.Drawing.Point(806, 354)
        Me.cbox_WiFi.Name = "cbox_WiFi"
        Me.cbox_WiFi.Size = New System.Drawing.Size(78, 27)
        Me.cbox_WiFi.TabIndex = 108
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
        Me.cbox_Projector.Location = New System.Drawing.Point(601, 407)
        Me.cbox_Projector.Name = "cbox_Projector"
        Me.cbox_Projector.Size = New System.Drawing.Size(118, 27)
        Me.cbox_Projector.TabIndex = 107
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
        Me.cbox_SS.Location = New System.Drawing.Point(601, 381)
        Me.cbox_SS.Name = "cbox_SS"
        Me.cbox_SS.Size = New System.Drawing.Size(167, 27)
        Me.cbox_SS.TabIndex = 106
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
        Me.cbox_AC.Location = New System.Drawing.Point(601, 354)
        Me.cbox_AC.Name = "cbox_AC"
        Me.cbox_AC.Size = New System.Drawing.Size(189, 27)
        Me.cbox_AC.TabIndex = 105
        Me.cbox_AC.Text = "Air Conditioning"
        Me.cbox_AC.UseVisualStyleBackColor = False
        '
        'lbl_NoOfDays
        '
        Me.lbl_NoOfDays.AutoSize = True
        Me.lbl_NoOfDays.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_NoOfDays.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoOfDays.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_NoOfDays.Location = New System.Drawing.Point(131, 209)
        Me.lbl_NoOfDays.Name = "lbl_NoOfDays"
        Me.lbl_NoOfDays.Size = New System.Drawing.Size(180, 37)
        Me.lbl_NoOfDays.TabIndex = 112
        Me.lbl_NoOfDays.Text = "No. of Days"
        '
        'pbox_Days
        '
        Me.pbox_Days.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Days.Location = New System.Drawing.Point(138, 254)
        Me.pbox_Days.Name = "pbox_Days"
        Me.pbox_Days.Size = New System.Drawing.Size(64, 50)
        Me.pbox_Days.TabIndex = 113
        Me.pbox_Days.TabStop = False
        '
        'txtbox_NoOfDays
        '
        Me.txtbox_NoOfDays.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_NoOfDays.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_NoOfDays.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_NoOfDays.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_NoOfDays.Location = New System.Drawing.Point(148, 265)
        Me.txtbox_NoOfDays.MaxLength = 2
        Me.txtbox_NoOfDays.Name = "txtbox_NoOfDays"
        Me.txtbox_NoOfDays.Size = New System.Drawing.Size(45, 29)
        Me.txtbox_NoOfDays.TabIndex = 114
        Me.txtbox_NoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Services
        '
        Me.lbl_Services.AutoSize = True
        Me.lbl_Services.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Services.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Services.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Services.Location = New System.Drawing.Point(131, 311)
        Me.lbl_Services.Name = "lbl_Services"
        Me.lbl_Services.Size = New System.Drawing.Size(153, 37)
        Me.lbl_Services.TabIndex = 115
        Me.lbl_Services.Text = "Services :"
        '
        'lbl_Days
        '
        Me.lbl_Days.AutoSize = True
        Me.lbl_Days.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Days.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Days.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Days.Location = New System.Drawing.Point(208, 267)
        Me.lbl_Days.Name = "lbl_Days"
        Me.lbl_Days.Size = New System.Drawing.Size(88, 27)
        Me.lbl_Days.TabIndex = 122
        Me.lbl_Days.Text = "day / s"
        '
        'pbox_Services
        '
        Me.pbox_Services.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Services.Location = New System.Drawing.Point(138, 354)
        Me.pbox_Services.Name = "pbox_Services"
        Me.pbox_Services.Size = New System.Drawing.Size(399, 75)
        Me.pbox_Services.TabIndex = 123
        Me.pbox_Services.TabStop = False
        '
        'cbox_Photography
        '
        Me.cbox_Photography.AutoSize = True
        Me.cbox_Photography.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Photography.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Photography.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Photography.Location = New System.Drawing.Point(149, 395)
        Me.cbox_Photography.Name = "cbox_Photography"
        Me.cbox_Photography.Size = New System.Drawing.Size(156, 27)
        Me.cbox_Photography.TabIndex = 129
        Me.cbox_Photography.Text = "Photography"
        Me.cbox_Photography.UseVisualStyleBackColor = False
        '
        'cbox_Videoke
        '
        Me.cbox_Videoke.AutoSize = True
        Me.cbox_Videoke.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Videoke.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Videoke.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Videoke.Location = New System.Drawing.Point(421, 362)
        Me.cbox_Videoke.Name = "cbox_Videoke"
        Me.cbox_Videoke.Size = New System.Drawing.Size(115, 27)
        Me.cbox_Videoke.TabIndex = 128
        Me.cbox_Videoke.Text = "Videoke"
        Me.cbox_Videoke.UseVisualStyleBackColor = False
        '
        'cbox_Dancer
        '
        Me.cbox_Dancer.AutoSize = True
        Me.cbox_Dancer.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Dancer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Dancer.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Dancer.Location = New System.Drawing.Point(311, 395)
        Me.cbox_Dancer.Name = "cbox_Dancer"
        Me.cbox_Dancer.Size = New System.Drawing.Size(103, 27)
        Me.cbox_Dancer.TabIndex = 127
        Me.cbox_Dancer.Text = "Dancer"
        Me.cbox_Dancer.UseVisualStyleBackColor = False
        '
        'cbox_Singer
        '
        Me.cbox_Singer.AutoSize = True
        Me.cbox_Singer.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Singer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Singer.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Singer.Location = New System.Drawing.Point(311, 362)
        Me.cbox_Singer.Name = "cbox_Singer"
        Me.cbox_Singer.Size = New System.Drawing.Size(91, 27)
        Me.cbox_Singer.TabIndex = 126
        Me.cbox_Singer.Text = "Singer"
        Me.cbox_Singer.UseVisualStyleBackColor = False
        '
        'cbox_Clown
        '
        Me.cbox_Clown.AutoSize = True
        Me.cbox_Clown.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Clown.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Clown.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Clown.Location = New System.Drawing.Point(421, 395)
        Me.cbox_Clown.Name = "cbox_Clown"
        Me.cbox_Clown.Size = New System.Drawing.Size(94, 27)
        Me.cbox_Clown.TabIndex = 125
        Me.cbox_Clown.Text = "Clown"
        Me.cbox_Clown.UseVisualStyleBackColor = False
        '
        'cbox_Catering
        '
        Me.cbox_Catering.AutoSize = True
        Me.cbox_Catering.BackColor = System.Drawing.Color.PapayaWhip
        Me.cbox_Catering.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_Catering.ForeColor = System.Drawing.Color.Chocolate
        Me.cbox_Catering.Location = New System.Drawing.Point(149, 362)
        Me.cbox_Catering.Name = "cbox_Catering"
        Me.cbox_Catering.Size = New System.Drawing.Size(116, 27)
        Me.cbox_Catering.TabIndex = 124
        Me.cbox_Catering.Text = "Catering"
        Me.cbox_Catering.UseVisualStyleBackColor = False
        '
        'lbl_Guests
        '
        Me.lbl_Guests.AutoSize = True
        Me.lbl_Guests.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Guests.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Guests.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_Guests.Location = New System.Drawing.Point(451, 267)
        Me.lbl_Guests.Name = "lbl_Guests"
        Me.lbl_Guests.Size = New System.Drawing.Size(55, 27)
        Me.lbl_Guests.TabIndex = 133
        Me.lbl_Guests.Text = "pax"
        '
        'txtbox_NoOfGuests
        '
        Me.txtbox_NoOfGuests.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_NoOfGuests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_NoOfGuests.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_NoOfGuests.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_NoOfGuests.Location = New System.Drawing.Point(362, 265)
        Me.txtbox_NoOfGuests.MaxLength = 5
        Me.txtbox_NoOfGuests.Name = "txtbox_NoOfGuests"
        Me.txtbox_NoOfGuests.Size = New System.Drawing.Size(74, 29)
        Me.txtbox_NoOfGuests.TabIndex = 132
        Me.txtbox_NoOfGuests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbox_NoOfGuests
        '
        Me.pbox_NoOfGuests.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_NoOfGuests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_NoOfGuests.Location = New System.Drawing.Point(352, 254)
        Me.pbox_NoOfGuests.Name = "pbox_NoOfGuests"
        Me.pbox_NoOfGuests.Size = New System.Drawing.Size(93, 50)
        Me.pbox_NoOfGuests.TabIndex = 131
        Me.pbox_NoOfGuests.TabStop = False
        '
        'lbl_NoOfGuests
        '
        Me.lbl_NoOfGuests.AutoSize = True
        Me.lbl_NoOfGuests.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_NoOfGuests.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoOfGuests.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_NoOfGuests.Location = New System.Drawing.Point(345, 209)
        Me.lbl_NoOfGuests.Name = "lbl_NoOfGuests"
        Me.lbl_NoOfGuests.Size = New System.Drawing.Size(206, 37)
        Me.lbl_NoOfGuests.TabIndex = 130
        Me.lbl_NoOfGuests.Text = "No. of Guests"
        '
        'lbl_MaxCapacity
        '
        Me.lbl_MaxCapacity.AutoSize = True
        Me.lbl_MaxCapacity.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_MaxCapacity.Font = New System.Drawing.Font("Century Gothic", 9.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_MaxCapacity.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_MaxCapacity.Location = New System.Drawing.Point(597, 312)
        Me.lbl_MaxCapacity.Name = "lbl_MaxCapacity"
        Me.lbl_MaxCapacity.Size = New System.Drawing.Size(158, 19)
        Me.lbl_MaxCapacity.TabIndex = 134
        Me.lbl_MaxCapacity.Text = "max capacity: pax"
        '
        'lbl_PricePerDay
        '
        Me.lbl_PricePerDay.AutoSize = True
        Me.lbl_PricePerDay.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_PricePerDay.Font = New System.Drawing.Font("Century Gothic", 9.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_PricePerDay.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_PricePerDay.Location = New System.Drawing.Point(597, 333)
        Me.lbl_PricePerDay.Name = "lbl_PricePerDay"
        Me.lbl_PricePerDay.Size = New System.Drawing.Size(141, 19)
        Me.lbl_PricePerDay.TabIndex = 135
        Me.lbl_PricePerDay.Text = "price per day : ₱ "
        '
        'BookEventPart1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalCustomerBooking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.lbl_PricePerDay)
        Me.Controls.Add(Me.lbl_MaxCapacity)
        Me.Controls.Add(Me.lbl_Guests)
        Me.Controls.Add(Me.txtbox_NoOfGuests)
        Me.Controls.Add(Me.pbox_NoOfGuests)
        Me.Controls.Add(Me.lbl_NoOfGuests)
        Me.Controls.Add(Me.cbox_Photography)
        Me.Controls.Add(Me.cbox_Videoke)
        Me.Controls.Add(Me.cbox_Dancer)
        Me.Controls.Add(Me.cbox_Singer)
        Me.Controls.Add(Me.cbox_Clown)
        Me.Controls.Add(Me.cbox_Catering)
        Me.Controls.Add(Me.pbox_Services)
        Me.Controls.Add(Me.lbl_Days)
        Me.Controls.Add(Me.lbl_Services)
        Me.Controls.Add(Me.txtbox_NoOfDays)
        Me.Controls.Add(Me.pbox_Days)
        Me.Controls.Add(Me.lbl_NoOfDays)
        Me.Controls.Add(Me.cbox_Lightings)
        Me.Controls.Add(Me.cbox_Stage)
        Me.Controls.Add(Me.cbox_WiFi)
        Me.Controls.Add(Me.cbox_Projector)
        Me.Controls.Add(Me.cbox_SS)
        Me.Controls.Add(Me.cbox_AC)
        Me.Controls.Add(Me.lbl_NoImage)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.pbox_Venue)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_VenueType)
        Me.Controls.Add(Me.btn_Right)
        Me.Controls.Add(Me.btn_Left)
        Me.Controls.Add(Me.pbox_VenueType)
        Me.Controls.Add(Me.pbox_VenuePic)
        Me.Controls.Add(Me.pbox_VenueBox)
        Me.Controls.Add(Me.lbl_Year)
        Me.Controls.Add(Me.pbox_Year)
        Me.Controls.Add(Me.lbl_Month)
        Me.Controls.Add(Me.pbox_Month)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.pbox_Day)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.pbox_DateDaysServices)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.btn_Back)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookEventPart1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_DateDaysServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Day, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Month, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Days, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Services, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_NoOfGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Next As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_DateDaysServices As PictureBox
    Friend WithEvents lbl_Date As Label
    Friend WithEvents pbox_Day As PictureBox
    Friend WithEvents lbl_Day As Label
    Friend WithEvents pbox_Month As PictureBox
    Friend WithEvents lbl_Month As Label
    Friend WithEvents pbox_Year As PictureBox
    Friend WithEvents lbl_Year As Label
    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents pbox_VenueBox As PictureBox
    Friend WithEvents pbox_VenuePic As PictureBox
    Friend WithEvents pbox_VenueType As PictureBox
    Friend WithEvents btn_Left As Button
    Friend WithEvents btn_Right As Button
    Friend WithEvents lbl_VenueType As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Venue As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents lbl_NoImage As Label
    Friend WithEvents cbox_Lightings As CheckBox
    Friend WithEvents cbox_Stage As CheckBox
    Friend WithEvents cbox_WiFi As CheckBox
    Friend WithEvents cbox_Projector As CheckBox
    Friend WithEvents cbox_SS As CheckBox
    Friend WithEvents cbox_AC As CheckBox
    Friend WithEvents lbl_NoOfDays As Label
    Friend WithEvents pbox_Days As PictureBox
    Friend WithEvents txtbox_NoOfDays As TextBox
    Friend WithEvents lbl_Services As Label
    Friend WithEvents lbl_Days As Label
    Friend WithEvents pbox_Services As PictureBox
    Friend WithEvents cbox_Photography As CheckBox
    Friend WithEvents cbox_Videoke As CheckBox
    Friend WithEvents cbox_Dancer As CheckBox
    Friend WithEvents cbox_Singer As CheckBox
    Friend WithEvents cbox_Clown As CheckBox
    Friend WithEvents cbox_Catering As CheckBox
    Friend WithEvents lbl_Guests As Label
    Friend WithEvents txtbox_NoOfGuests As TextBox
    Friend WithEvents pbox_NoOfGuests As PictureBox
    Friend WithEvents lbl_NoOfGuests As Label
    Friend WithEvents lbl_MaxCapacity As Label
    Friend WithEvents lbl_PricePerDay As Label
End Class
