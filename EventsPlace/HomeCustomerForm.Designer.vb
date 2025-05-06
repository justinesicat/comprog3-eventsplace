<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeCustomerForm
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
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_ViewVenues = New System.Windows.Forms.Button()
        Me.btn_Bookings = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pb_Display = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.pbox_Venue = New System.Windows.Forms.PictureBox()
        Me.pbox_Booking = New System.Windows.Forms.PictureBox()
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Username.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Username.Location = New System.Drawing.Point(95, 95)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(271, 39)
        Me.lbl_Username.TabIndex = 18
        Me.lbl_Username.Text = "Welcome, USER!"
        '
        'btn_ViewVenues
        '
        Me.btn_ViewVenues.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_ViewVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewVenues.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewVenues.ForeColor = System.Drawing.Color.White
        Me.btn_ViewVenues.Location = New System.Drawing.Point(216, 467)
        Me.btn_ViewVenues.Name = "btn_ViewVenues"
        Me.btn_ViewVenues.Size = New System.Drawing.Size(278, 53)
        Me.btn_ViewVenues.TabIndex = 21
        Me.btn_ViewVenues.Text = "View Venues"
        Me.btn_ViewVenues.UseVisualStyleBackColor = False
        '
        'btn_Bookings
        '
        Me.btn_Bookings.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bookings.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Bookings.ForeColor = System.Drawing.Color.White
        Me.btn_Bookings.Location = New System.Drawing.Point(560, 467)
        Me.btn_Bookings.Name = "btn_Bookings"
        Me.btn_Bookings.Size = New System.Drawing.Size(278, 53)
        Me.btn_Bookings.TabIndex = 22
        Me.btn_Bookings.Text = "Bookings"
        Me.btn_Bookings.UseVisualStyleBackColor = False
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
        Me.lbl_Title.Size = New System.Drawing.Size(107, 37)
        Me.lbl_Title.TabIndex = 23
        Me.lbl_Title.Text = "HOME"
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
        Me.btn_Minimize.TabIndex = 29
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
        Me.btn_Close.TabIndex = 28
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'pb_Display
        '
        Me.pb_Display.Location = New System.Drawing.Point(102, 153)
        Me.pb_Display.Name = "pb_Display"
        Me.pb_Display.Size = New System.Drawing.Size(833, 292)
        Me.pb_Display.TabIndex = 30
        Me.pb_Display.TabStop = False
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
        Me.pbox_Account.TabIndex = 31
        Me.pbox_Account.TabStop = False
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
        Me.pbox_Venue.TabIndex = 32
        Me.pbox_Venue.TabStop = False
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
        Me.pbox_Booking.TabIndex = 33
        Me.pbox_Booking.TabStop = False
        '
        'HomeCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.CustomerView
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Booking)
        Me.Controls.Add(Me.pbox_Venue)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pb_Display)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Bookings)
        Me.Controls.Add(Me.btn_ViewVenues)
        Me.Controls.Add(Me.lbl_Username)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_ViewVenues As Button
    Friend WithEvents btn_Bookings As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pb_Display As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents pbox_Venue As PictureBox
    Friend WithEvents pbox_Booking As PictureBox
End Class
