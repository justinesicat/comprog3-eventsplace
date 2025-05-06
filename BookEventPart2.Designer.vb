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
        Me.pbox_Time = New System.Windows.Forms.PictureBox()
        Me.lbl_TimeEnd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_TimeStart = New System.Windows.Forms.Label()
        Me.pbox_Username = New System.Windows.Forms.PictureBox()
        Me.lbl_End = New System.Windows.Forms.Label()
        Me.lbl_Start = New System.Windows.Forms.Label()
        Me.pbox_Date = New System.Windows.Forms.PictureBox()
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.pbox_Day = New System.Windows.Forms.PictureBox()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.pbox_Month = New System.Windows.Forms.PictureBox()
        Me.lbl_Month = New System.Windows.Forms.Label()
        Me.pbox_Year = New System.Windows.Forms.PictureBox()
        Me.lbl_Year = New System.Windows.Forms.Label()
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.panel_TimePicker = New System.Windows.Forms.Panel()
        Me.btn_EndSet = New System.Windows.Forms.Button()
        Me.btn_StartSet = New System.Windows.Forms.Button()
        Me.cmb_StartAMPM = New System.Windows.Forms.ComboBox()
        Me.cmb_StartMinute = New System.Windows.Forms.ComboBox()
        Me.cmb_StartHour = New System.Windows.Forms.ComboBox()
        Me.pbox_VenueBox = New System.Windows.Forms.PictureBox()
        Me.pbox_VenuePic = New System.Windows.Forms.PictureBox()
        Me.lbl_Venue = New System.Windows.Forms.Label()
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
        CType(Me.pbox_Time, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Day, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_TimePicker.SuspendLayout()
        CType(Me.pbox_VenueBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_Title.Size = New System.Drawing.Size(201, 37)
        Me.lbl_Title.TabIndex = 30
        Me.lbl_Title.Text = "BOOK EVENT"
        '
        'pbox_Time
        '
        Me.pbox_Time.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Time.Location = New System.Drawing.Point(102, 117)
        Me.pbox_Time.Name = "pbox_Time"
        Me.pbox_Time.Size = New System.Drawing.Size(443, 143)
        Me.pbox_Time.TabIndex = 42
        Me.pbox_Time.TabStop = False
        '
        'lbl_TimeEnd
        '
        Me.lbl_TimeEnd.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_TimeEnd.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TimeEnd.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_TimeEnd.Location = New System.Drawing.Point(354, 198)
        Me.lbl_TimeEnd.Name = "lbl_TimeEnd"
        Me.lbl_TimeEnd.Size = New System.Drawing.Size(159, 27)
        Me.lbl_TimeEnd.TabIndex = 48
        Me.lbl_TimeEnd.Text = "00:00 AM/PM"
        Me.lbl_TimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(341, 187)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 50)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'lbl_TimeStart
        '
        Me.lbl_TimeStart.BackColor = System.Drawing.Color.PapayaWhip
        Me.lbl_TimeStart.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TimeStart.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_TimeStart.Location = New System.Drawing.Point(136, 198)
        Me.lbl_TimeStart.Name = "lbl_TimeStart"
        Me.lbl_TimeStart.Size = New System.Drawing.Size(159, 27)
        Me.lbl_TimeStart.TabIndex = 46
        Me.lbl_TimeStart.Text = "00:00 AM/PM"
        Me.lbl_TimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbox_Username
        '
        Me.pbox_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Username.Location = New System.Drawing.Point(124, 187)
        Me.pbox_Username.Name = "pbox_Username"
        Me.pbox_Username.Size = New System.Drawing.Size(182, 50)
        Me.pbox_Username.TabIndex = 45
        Me.pbox_Username.TabStop = False
        '
        'lbl_End
        '
        Me.lbl_End.AutoSize = True
        Me.lbl_End.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_End.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_End.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_End.Location = New System.Drawing.Point(360, 135)
        Me.lbl_End.Name = "lbl_End"
        Me.lbl_End.Size = New System.Drawing.Size(146, 37)
        Me.lbl_End.TabIndex = 44
        Me.lbl_End.Text = "Time End"
        '
        'lbl_Start
        '
        Me.lbl_Start.AutoSize = True
        Me.lbl_Start.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Start.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Start.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Start.Location = New System.Drawing.Point(139, 135)
        Me.lbl_Start.Name = "lbl_Start"
        Me.lbl_Start.Size = New System.Drawing.Size(156, 37)
        Me.lbl_Start.TabIndex = 43
        Me.lbl_Start.Text = "Time Start"
        '
        'pbox_Date
        '
        Me.pbox_Date.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Date.Location = New System.Drawing.Point(102, 285)
        Me.pbox_Date.Name = "pbox_Date"
        Me.pbox_Date.Size = New System.Drawing.Size(443, 143)
        Me.pbox_Date.TabIndex = 49
        Me.pbox_Date.TabStop = False
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Date.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Date.Location = New System.Drawing.Point(221, 305)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(208, 37)
        Me.lbl_Date.TabIndex = 50
        Me.lbl_Date.Text = "Date of Event"
        '
        'pbox_Day
        '
        Me.pbox_Day.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Day.Location = New System.Drawing.Point(124, 357)
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
        Me.lbl_Day.Location = New System.Drawing.Point(130, 369)
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
        Me.pbox_Month.Location = New System.Drawing.Point(233, 357)
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
        Me.lbl_Month.Location = New System.Drawing.Point(242, 369)
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
        Me.pbox_Year.Location = New System.Drawing.Point(432, 357)
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
        Me.lbl_Year.Location = New System.Drawing.Point(439, 369)
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
        'panel_TimePicker
        '
        Me.panel_TimePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_TimePicker.Controls.Add(Me.btn_EndSet)
        Me.panel_TimePicker.Controls.Add(Me.btn_StartSet)
        Me.panel_TimePicker.Controls.Add(Me.cmb_StartAMPM)
        Me.panel_TimePicker.Controls.Add(Me.cmb_StartMinute)
        Me.panel_TimePicker.Controls.Add(Me.cmb_StartHour)
        Me.panel_TimePicker.Location = New System.Drawing.Point(966, 540)
        Me.panel_TimePicker.Name = "panel_TimePicker"
        Me.panel_TimePicker.Size = New System.Drawing.Size(319, 61)
        Me.panel_TimePicker.TabIndex = 60
        Me.panel_TimePicker.Visible = False
        '
        'btn_EndSet
        '
        Me.btn_EndSet.Location = New System.Drawing.Point(239, 10)
        Me.btn_EndSet.Name = "btn_EndSet"
        Me.btn_EndSet.Size = New System.Drawing.Size(65, 39)
        Me.btn_EndSet.TabIndex = 33
        Me.btn_EndSet.Text = "SET"
        Me.btn_EndSet.UseVisualStyleBackColor = True
        '
        'btn_StartSet
        '
        Me.btn_StartSet.Location = New System.Drawing.Point(239, 10)
        Me.btn_StartSet.Name = "btn_StartSet"
        Me.btn_StartSet.Size = New System.Drawing.Size(65, 39)
        Me.btn_StartSet.TabIndex = 30
        Me.btn_StartSet.Text = "SET"
        Me.btn_StartSet.UseVisualStyleBackColor = True
        '
        'cmb_StartAMPM
        '
        Me.cmb_StartAMPM.FormattingEnabled = True
        Me.cmb_StartAMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmb_StartAMPM.Location = New System.Drawing.Point(163, 17)
        Me.cmb_StartAMPM.Name = "cmb_StartAMPM"
        Me.cmb_StartAMPM.Size = New System.Drawing.Size(63, 27)
        Me.cmb_StartAMPM.TabIndex = 32
        '
        'cmb_StartMinute
        '
        Me.cmb_StartMinute.FormattingEnabled = True
        Me.cmb_StartMinute.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cmb_StartMinute.Location = New System.Drawing.Point(90, 17)
        Me.cmb_StartMinute.Name = "cmb_StartMinute"
        Me.cmb_StartMinute.Size = New System.Drawing.Size(63, 27)
        Me.cmb_StartMinute.TabIndex = 31
        '
        'cmb_StartHour
        '
        Me.cmb_StartHour.FormattingEnabled = True
        Me.cmb_StartHour.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmb_StartHour.Location = New System.Drawing.Point(17, 17)
        Me.cmb_StartHour.Name = "cmb_StartHour"
        Me.cmb_StartHour.Size = New System.Drawing.Size(63, 27)
        Me.cmb_StartHour.TabIndex = 30
        '
        'pbox_VenueBox
        '
        Me.pbox_VenueBox.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_VenueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueBox.Location = New System.Drawing.Point(571, 117)
        Me.pbox_VenueBox.Name = "pbox_VenueBox"
        Me.pbox_VenueBox.Size = New System.Drawing.Size(364, 311)
        Me.pbox_VenueBox.TabIndex = 61
        Me.pbox_VenueBox.TabStop = False
        '
        'pbox_VenuePic
        '
        Me.pbox_VenuePic.BackColor = System.Drawing.Color.White
        Me.pbox_VenuePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenuePic.Location = New System.Drawing.Point(593, 189)
        Me.pbox_VenuePic.Name = "pbox_VenuePic"
        Me.pbox_VenuePic.Size = New System.Drawing.Size(321, 148)
        Me.pbox_VenuePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_VenuePic.TabIndex = 62
        Me.pbox_VenuePic.TabStop = False
        '
        'lbl_Venue
        '
        Me.lbl_Venue.AutoSize = True
        Me.lbl_Venue.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_Venue.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Venue.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Venue.Location = New System.Drawing.Point(586, 135)
        Me.lbl_Venue.Name = "lbl_Venue"
        Me.lbl_Venue.Size = New System.Drawing.Size(112, 37)
        Me.lbl_Venue.TabIndex = 63
        Me.lbl_Venue.Text = "Venue"
        '
        'pbox_VenueType
        '
        Me.pbox_VenueType.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_VenueType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_VenueType.Location = New System.Drawing.Point(651, 357)
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
        Me.btn_Left.Location = New System.Drawing.Point(593, 357)
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
        Me.btn_Right.Location = New System.Drawing.Point(864, 357)
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
        Me.lbl_VenueType.Location = New System.Drawing.Point(651, 363)
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
        Me.lbl_NoImage.Location = New System.Drawing.Point(718, 242)
        Me.lbl_NoImage.Name = "lbl_NoImage"
        Me.lbl_NoImage.Size = New System.Drawing.Size(75, 37)
        Me.lbl_NoImage.TabIndex = 104
        Me.lbl_NoImage.Text = "N/A"
        Me.lbl_NoImage.Visible = False
        '
        'BookEventPart1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
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
        Me.Controls.Add(Me.lbl_Venue)
        Me.Controls.Add(Me.pbox_VenuePic)
        Me.Controls.Add(Me.pbox_VenueBox)
        Me.Controls.Add(Me.panel_TimePicker)
        Me.Controls.Add(Me.lbl_Year)
        Me.Controls.Add(Me.pbox_Year)
        Me.Controls.Add(Me.lbl_Month)
        Me.Controls.Add(Me.pbox_Month)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.pbox_Day)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.pbox_Date)
        Me.Controls.Add(Me.lbl_TimeEnd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_TimeStart)
        Me.Controls.Add(Me.pbox_Username)
        Me.Controls.Add(Me.lbl_End)
        Me.Controls.Add(Me.lbl_Start)
        Me.Controls.Add(Me.pbox_Time)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Next)
        Me.Controls.Add(Me.Calendar)
        Me.Controls.Add(Me.btn_Back)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookEventPart1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Time, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Day, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Month, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_TimePicker.ResumeLayout(False)
        CType(Me.pbox_VenueBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenuePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_VenueType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Next As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_Time As PictureBox
    Friend WithEvents lbl_TimeEnd As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_TimeStart As Label
    Friend WithEvents pbox_Username As PictureBox
    Friend WithEvents lbl_End As Label
    Friend WithEvents lbl_Start As Label
    Friend WithEvents pbox_Date As PictureBox
    Friend WithEvents lbl_Date As Label
    Friend WithEvents pbox_Day As PictureBox
    Friend WithEvents lbl_Day As Label
    Friend WithEvents pbox_Month As PictureBox
    Friend WithEvents lbl_Month As Label
    Friend WithEvents pbox_Year As PictureBox
    Friend WithEvents lbl_Year As Label
    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents panel_TimePicker As Panel
    Friend WithEvents btn_EndSet As Button
    Friend WithEvents btn_StartSet As Button
    Friend WithEvents cmb_StartAMPM As ComboBox
    Friend WithEvents cmb_StartMinute As ComboBox
    Friend WithEvents cmb_StartHour As ComboBox
    Friend WithEvents pbox_VenueBox As PictureBox
    Friend WithEvents pbox_VenuePic As PictureBox
    Friend WithEvents lbl_Venue As Label
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
End Class
