<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookEventPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookEventPayment))
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_Cash = New System.Windows.Forms.PictureBox()
        Me.lbl_PaymentMethod1 = New System.Windows.Forms.Label()
        Me.radio_Cash = New System.Windows.Forms.RadioButton()
        Me.lbl_AmountList = New System.Windows.Forms.Label()
        Me.lbl_ChangeList = New System.Windows.Forms.Label()
        Me.pbox_Amount = New System.Windows.Forms.PictureBox()
        Me.pbox_Change = New System.Windows.Forms.PictureBox()
        Me.pbox_Card = New System.Windows.Forms.PictureBox()
        Me.radio_Card = New System.Windows.Forms.RadioButton()
        Me.lbl_PaymentMethod2 = New System.Windows.Forms.Label()
        Me.lbl_CardHolderName = New System.Windows.Forms.Label()
        Me.pbox_CardHolderName = New System.Windows.Forms.PictureBox()
        Me.pbox_CardNumber = New System.Windows.Forms.PictureBox()
        Me.lbl_CardNumber = New System.Windows.Forms.Label()
        Me.pbox_ExpiryDate = New System.Windows.Forms.PictureBox()
        Me.lbl_ExpiryDateList = New System.Windows.Forms.Label()
        Me.lbl_CVCCVVList = New System.Windows.Forms.Label()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.pbox_CVCCCV = New System.Windows.Forms.PictureBox()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.txtbox_Amount = New System.Windows.Forms.TextBox()
        Me.txtbox_Change = New System.Windows.Forms.TextBox()
        Me.txtbox_CardHolderName = New System.Windows.Forms.TextBox()
        Me.txtbox_CardNumber = New System.Windows.Forms.TextBox()
        Me.txtbox_ExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtbox_CVCCVV = New System.Windows.Forms.TextBox()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Venue = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Amount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Change, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Card, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_CardHolderName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_CardNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_ExpiryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_CVCCCV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_Title.Size = New System.Drawing.Size(554, 37)
        Me.lbl_Title.TabIndex = 33
        Me.lbl_Title.Text = "BOOK EVENT - PAYMENT AND BILLING"
        '
        'pbox_Cash
        '
        Me.pbox_Cash.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_Cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Cash.Location = New System.Drawing.Point(103, 90)
        Me.pbox_Cash.Name = "pbox_Cash"
        Me.pbox_Cash.Size = New System.Drawing.Size(338, 358)
        Me.pbox_Cash.TabIndex = 43
        Me.pbox_Cash.TabStop = False
        '
        'lbl_PaymentMethod1
        '
        Me.lbl_PaymentMethod1.AutoSize = True
        Me.lbl_PaymentMethod1.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_PaymentMethod1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMethod1.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PaymentMethod1.Location = New System.Drawing.Point(131, 102)
        Me.lbl_PaymentMethod1.Name = "lbl_PaymentMethod1"
        Me.lbl_PaymentMethod1.Size = New System.Drawing.Size(281, 37)
        Me.lbl_PaymentMethod1.TabIndex = 96
        Me.lbl_PaymentMethod1.Text = "Payment Method :"
        '
        'radio_Cash
        '
        Me.radio_Cash.AutoSize = True
        Me.radio_Cash.BackColor = System.Drawing.Color.SeaShell
        Me.radio_Cash.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Cash.ForeColor = System.Drawing.Color.Chocolate
        Me.radio_Cash.Location = New System.Drawing.Point(226, 156)
        Me.radio_Cash.Name = "radio_Cash"
        Me.radio_Cash.Size = New System.Drawing.Size(96, 31)
        Me.radio_Cash.TabIndex = 97
        Me.radio_Cash.TabStop = True
        Me.radio_Cash.Text = "CASH"
        Me.radio_Cash.UseVisualStyleBackColor = False
        '
        'lbl_AmountList
        '
        Me.lbl_AmountList.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_AmountList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountList.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_AmountList.Location = New System.Drawing.Point(129, 269)
        Me.lbl_AmountList.Name = "lbl_AmountList"
        Me.lbl_AmountList.Size = New System.Drawing.Size(155, 27)
        Me.lbl_AmountList.TabIndex = 134
        Me.lbl_AmountList.Text = "AMOUNT :"
        Me.lbl_AmountList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_ChangeList
        '
        Me.lbl_ChangeList.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_ChangeList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ChangeList.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_ChangeList.Location = New System.Drawing.Point(129, 321)
        Me.lbl_ChangeList.Name = "lbl_ChangeList"
        Me.lbl_ChangeList.Size = New System.Drawing.Size(160, 27)
        Me.lbl_ChangeList.TabIndex = 135
        Me.lbl_ChangeList.Text = "CHANGE :"
        Me.lbl_ChangeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbox_Amount
        '
        Me.pbox_Amount.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Amount.Location = New System.Drawing.Point(266, 266)
        Me.pbox_Amount.Name = "pbox_Amount"
        Me.pbox_Amount.Size = New System.Drawing.Size(146, 37)
        Me.pbox_Amount.TabIndex = 136
        Me.pbox_Amount.TabStop = False
        '
        'pbox_Change
        '
        Me.pbox_Change.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Change.Location = New System.Drawing.Point(266, 315)
        Me.pbox_Change.Name = "pbox_Change"
        Me.pbox_Change.Size = New System.Drawing.Size(146, 37)
        Me.pbox_Change.TabIndex = 138
        Me.pbox_Change.TabStop = False
        '
        'pbox_Card
        '
        Me.pbox_Card.BackColor = System.Drawing.Color.SeaShell
        Me.pbox_Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Card.Location = New System.Drawing.Point(479, 90)
        Me.pbox_Card.Name = "pbox_Card"
        Me.pbox_Card.Size = New System.Drawing.Size(457, 358)
        Me.pbox_Card.TabIndex = 140
        Me.pbox_Card.TabStop = False
        '
        'radio_Card
        '
        Me.radio_Card.AutoSize = True
        Me.radio_Card.BackColor = System.Drawing.Color.SeaShell
        Me.radio_Card.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_Card.ForeColor = System.Drawing.Color.Chocolate
        Me.radio_Card.Location = New System.Drawing.Point(667, 156)
        Me.radio_Card.Name = "radio_Card"
        Me.radio_Card.Size = New System.Drawing.Size(97, 31)
        Me.radio_Card.TabIndex = 141
        Me.radio_Card.TabStop = True
        Me.radio_Card.Text = "CARD"
        Me.radio_Card.UseVisualStyleBackColor = False
        '
        'lbl_PaymentMethod2
        '
        Me.lbl_PaymentMethod2.AutoSize = True
        Me.lbl_PaymentMethod2.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_PaymentMethod2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMethod2.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_PaymentMethod2.Location = New System.Drawing.Point(571, 102)
        Me.lbl_PaymentMethod2.Name = "lbl_PaymentMethod2"
        Me.lbl_PaymentMethod2.Size = New System.Drawing.Size(281, 37)
        Me.lbl_PaymentMethod2.TabIndex = 142
        Me.lbl_PaymentMethod2.Text = "Payment Method :"
        '
        'lbl_CardHolderName
        '
        Me.lbl_CardHolderName.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_CardHolderName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CardHolderName.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_CardHolderName.Location = New System.Drawing.Point(508, 202)
        Me.lbl_CardHolderName.Name = "lbl_CardHolderName"
        Me.lbl_CardHolderName.Size = New System.Drawing.Size(268, 27)
        Me.lbl_CardHolderName.TabIndex = 144
        Me.lbl_CardHolderName.Text = "CARD HOLDER NAME :"
        Me.lbl_CardHolderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbox_CardHolderName
        '
        Me.pbox_CardHolderName.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_CardHolderName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_CardHolderName.Location = New System.Drawing.Point(513, 232)
        Me.pbox_CardHolderName.Name = "pbox_CardHolderName"
        Me.pbox_CardHolderName.Size = New System.Drawing.Size(394, 37)
        Me.pbox_CardHolderName.TabIndex = 145
        Me.pbox_CardHolderName.TabStop = False
        '
        'pbox_CardNumber
        '
        Me.pbox_CardNumber.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_CardNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_CardNumber.Location = New System.Drawing.Point(513, 309)
        Me.pbox_CardNumber.Name = "pbox_CardNumber"
        Me.pbox_CardNumber.Size = New System.Drawing.Size(394, 37)
        Me.pbox_CardNumber.TabIndex = 148
        Me.pbox_CardNumber.TabStop = False
        '
        'lbl_CardNumber
        '
        Me.lbl_CardNumber.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_CardNumber.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CardNumber.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_CardNumber.Location = New System.Drawing.Point(508, 279)
        Me.lbl_CardNumber.Name = "lbl_CardNumber"
        Me.lbl_CardNumber.Size = New System.Drawing.Size(254, 27)
        Me.lbl_CardNumber.TabIndex = 147
        Me.lbl_CardNumber.Text = "CARD NUMBER :"
        Me.lbl_CardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbox_ExpiryDate
        '
        Me.pbox_ExpiryDate.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_ExpiryDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_ExpiryDate.Location = New System.Drawing.Point(513, 388)
        Me.pbox_ExpiryDate.Name = "pbox_ExpiryDate"
        Me.pbox_ExpiryDate.Size = New System.Drawing.Size(182, 37)
        Me.pbox_ExpiryDate.TabIndex = 151
        Me.pbox_ExpiryDate.TabStop = False
        '
        'lbl_ExpiryDateList
        '
        Me.lbl_ExpiryDateList.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_ExpiryDateList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ExpiryDateList.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_ExpiryDateList.Location = New System.Drawing.Point(508, 358)
        Me.lbl_ExpiryDateList.Name = "lbl_ExpiryDateList"
        Me.lbl_ExpiryDateList.Size = New System.Drawing.Size(180, 27)
        Me.lbl_ExpiryDateList.TabIndex = 150
        Me.lbl_ExpiryDateList.Text = "EXPIRY DATE :"
        Me.lbl_ExpiryDateList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_CVCCVVList
        '
        Me.lbl_CVCCVVList.BackColor = System.Drawing.Color.SeaShell
        Me.lbl_CVCCVVList.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CVCCVVList.ForeColor = System.Drawing.Color.Chocolate
        Me.lbl_CVCCVVList.Location = New System.Drawing.Point(720, 358)
        Me.lbl_CVCCVVList.Name = "lbl_CVCCVVList"
        Me.lbl_CVCCVVList.Size = New System.Drawing.Size(159, 27)
        Me.lbl_CVCCVVList.TabIndex = 153
        Me.lbl_CVCCVVList.Text = "CVC / CVV :"
        Me.lbl_CVCCVVList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Pay
        '
        Me.btn_Pay.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pay.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pay.ForeColor = System.Drawing.Color.White
        Me.btn_Pay.Location = New System.Drawing.Point(216, 467)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(278, 53)
        Me.btn_Pay.TabIndex = 155
        Me.btn_Pay.Text = "Pay"
        Me.btn_Pay.UseVisualStyleBackColor = False
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
        Me.btn_Back.TabIndex = 154
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'pbox_CVCCCV
        '
        Me.pbox_CVCCCV.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_CVCCCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_CVCCCV.Location = New System.Drawing.Point(725, 388)
        Me.pbox_CVCCCV.Name = "pbox_CVCCCV"
        Me.pbox_CVCCCV.Size = New System.Drawing.Size(182, 37)
        Me.pbox_CVCCCV.TabIndex = 156
        Me.pbox_CVCCCV.TabStop = False
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
        Me.btn_Minimize.TabIndex = 159
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
        Me.btn_Close.TabIndex = 158
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'txtbox_Amount
        '
        Me.txtbox_Amount.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_Amount.Enabled = False
        Me.txtbox_Amount.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Amount.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_Amount.Location = New System.Drawing.Point(272, 270)
        Me.txtbox_Amount.MaxLength = 200
        Me.txtbox_Amount.Name = "txtbox_Amount"
        Me.txtbox_Amount.Size = New System.Drawing.Size(134, 29)
        Me.txtbox_Amount.TabIndex = 160
        '
        'txtbox_Change
        '
        Me.txtbox_Change.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_Change.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_Change.Enabled = False
        Me.txtbox_Change.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_Change.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_Change.Location = New System.Drawing.Point(272, 319)
        Me.txtbox_Change.MaxLength = 200
        Me.txtbox_Change.Name = "txtbox_Change"
        Me.txtbox_Change.Size = New System.Drawing.Size(134, 29)
        Me.txtbox_Change.TabIndex = 161
        '
        'txtbox_CardHolderName
        '
        Me.txtbox_CardHolderName.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_CardHolderName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_CardHolderName.Enabled = False
        Me.txtbox_CardHolderName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_CardHolderName.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_CardHolderName.Location = New System.Drawing.Point(519, 236)
        Me.txtbox_CardHolderName.MaxLength = 200
        Me.txtbox_CardHolderName.Name = "txtbox_CardHolderName"
        Me.txtbox_CardHolderName.Size = New System.Drawing.Size(383, 29)
        Me.txtbox_CardHolderName.TabIndex = 162
        '
        'txtbox_CardNumber
        '
        Me.txtbox_CardNumber.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_CardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_CardNumber.Enabled = False
        Me.txtbox_CardNumber.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_CardNumber.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_CardNumber.Location = New System.Drawing.Point(519, 313)
        Me.txtbox_CardNumber.MaxLength = 200
        Me.txtbox_CardNumber.Name = "txtbox_CardNumber"
        Me.txtbox_CardNumber.Size = New System.Drawing.Size(383, 29)
        Me.txtbox_CardNumber.TabIndex = 163
        '
        'txtbox_ExpiryDate
        '
        Me.txtbox_ExpiryDate.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_ExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_ExpiryDate.Enabled = False
        Me.txtbox_ExpiryDate.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_ExpiryDate.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_ExpiryDate.Location = New System.Drawing.Point(521, 392)
        Me.txtbox_ExpiryDate.MaxLength = 200
        Me.txtbox_ExpiryDate.Name = "txtbox_ExpiryDate"
        Me.txtbox_ExpiryDate.Size = New System.Drawing.Size(167, 29)
        Me.txtbox_ExpiryDate.TabIndex = 164
        Me.txtbox_ExpiryDate.Text = "MM-dd-yyyy"
        '
        'txtbox_CVCCVV
        '
        Me.txtbox_CVCCVV.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtbox_CVCCVV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_CVCCVV.Enabled = False
        Me.txtbox_CVCCVV.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_CVCCVV.ForeColor = System.Drawing.Color.Chocolate
        Me.txtbox_CVCCVV.Location = New System.Drawing.Point(733, 392)
        Me.txtbox_CVCCVV.MaxLength = 200
        Me.txtbox_CVCCVV.Name = "txtbox_CVCCVV"
        Me.txtbox_CVCCVV.Size = New System.Drawing.Size(167, 29)
        Me.txtbox_CVCCVV.TabIndex = 165
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
        Me.pbox_Home.TabIndex = 168
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
        Me.pbox_Venue.TabIndex = 167
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
        Me.pbox_Account.TabIndex = 166
        Me.pbox_Account.TabStop = False
        '
        'BookEventPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalCustomerBooking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.pbox_Venue)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.txtbox_CVCCVV)
        Me.Controls.Add(Me.txtbox_ExpiryDate)
        Me.Controls.Add(Me.txtbox_CardNumber)
        Me.Controls.Add(Me.txtbox_CardHolderName)
        Me.Controls.Add(Me.txtbox_Change)
        Me.Controls.Add(Me.txtbox_Amount)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.pbox_CVCCCV)
        Me.Controls.Add(Me.btn_Pay)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.lbl_CVCCVVList)
        Me.Controls.Add(Me.pbox_ExpiryDate)
        Me.Controls.Add(Me.lbl_ExpiryDateList)
        Me.Controls.Add(Me.pbox_CardNumber)
        Me.Controls.Add(Me.lbl_CardNumber)
        Me.Controls.Add(Me.pbox_CardHolderName)
        Me.Controls.Add(Me.lbl_CardHolderName)
        Me.Controls.Add(Me.lbl_PaymentMethod2)
        Me.Controls.Add(Me.radio_Card)
        Me.Controls.Add(Me.pbox_Card)
        Me.Controls.Add(Me.pbox_Change)
        Me.Controls.Add(Me.pbox_Amount)
        Me.Controls.Add(Me.lbl_ChangeList)
        Me.Controls.Add(Me.lbl_AmountList)
        Me.Controls.Add(Me.radio_Cash)
        Me.Controls.Add(Me.lbl_PaymentMethod1)
        Me.Controls.Add(Me.pbox_Cash)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookEventPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Amount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Change, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Card, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_CardHolderName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_CardNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_ExpiryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_CVCCCV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_Cash As PictureBox
    Friend WithEvents lbl_PaymentMethod1 As Label
    Friend WithEvents radio_Cash As RadioButton
    Friend WithEvents lbl_AmountList As Label
    Friend WithEvents lbl_ChangeList As Label
    Friend WithEvents pbox_Amount As PictureBox
    Friend WithEvents pbox_Change As PictureBox
    Friend WithEvents pbox_Card As PictureBox
    Friend WithEvents radio_Card As RadioButton
    Friend WithEvents lbl_PaymentMethod2 As Label
    Friend WithEvents lbl_CardHolderName As Label
    Friend WithEvents pbox_CardHolderName As PictureBox
    Friend WithEvents pbox_CardNumber As PictureBox
    Friend WithEvents lbl_CardNumber As Label
    Friend WithEvents pbox_ExpiryDate As PictureBox
    Friend WithEvents lbl_ExpiryDateList As Label
    Friend WithEvents lbl_CVCCVVList As Label
    Friend WithEvents btn_Pay As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents pbox_CVCCCV As PictureBox
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents txtbox_Amount As TextBox
    Friend WithEvents txtbox_Change As TextBox
    Friend WithEvents txtbox_CardHolderName As TextBox
    Friend WithEvents txtbox_CardNumber As TextBox
    Friend WithEvents txtbox_ExpiryDate As TextBox
    Friend WithEvents txtbox_CVCCVV As TextBox
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Venue As PictureBox
    Friend WithEvents pbox_Account As PictureBox
End Class
