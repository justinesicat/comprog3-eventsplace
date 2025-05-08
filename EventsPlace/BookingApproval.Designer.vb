<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookingApproval
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingApproval))
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_EditVenues = New System.Windows.Forms.PictureBox()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.lbl_Second = New System.Windows.Forms.Label()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.lbl_Day = New System.Windows.Forms.Label()
        Me.lbl_Year = New System.Windows.Forms.Label()
        Me.lbl_Month = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_Minimize.TabIndex = 172
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
        Me.btn_Close.TabIndex = 171
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
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
        Me.lbl_Title.Size = New System.Drawing.Size(326, 37)
        Me.lbl_Title.TabIndex = 173
        Me.lbl_Title.Text = "BOOKING APPROVAL"
        '
        'pbox_EditVenues
        '
        Me.pbox_EditVenues.BackColor = System.Drawing.Color.Transparent
        Me.pbox_EditVenues.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_EditVenues.ErrorImage = Nothing
        Me.pbox_EditVenues.Location = New System.Drawing.Point(0, 139)
        Me.pbox_EditVenues.Name = "pbox_EditVenues"
        Me.pbox_EditVenues.Size = New System.Drawing.Size(68, 68)
        Me.pbox_EditVenues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_EditVenues.TabIndex = 175
        Me.pbox_EditVenues.TabStop = False
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
        Me.pbox_Home.TabIndex = 174
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
        Me.pbox_Account.TabIndex = 176
        Me.pbox_Account.TabStop = False
        '
        'lbl_Second
        '
        Me.lbl_Second.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Second.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Second.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Second.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Second.Location = New System.Drawing.Point(850, 156)
        Me.lbl_Second.Name = "lbl_Second"
        Me.lbl_Second.Size = New System.Drawing.Size(94, 39)
        Me.lbl_Second.TabIndex = 181
        Me.lbl_Second.Text = ":00"
        Me.lbl_Second.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Time
        '
        Me.lbl_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Time.Font = New System.Drawing.Font("Century Gothic", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Time.Location = New System.Drawing.Point(571, 79)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(383, 83)
        Me.lbl_Time.TabIndex = 180
        Me.lbl_Time.Text = "00:00 AM"
        Me.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Day
        '
        Me.lbl_Day.AutoSize = True
        Me.lbl_Day.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Day.Font = New System.Drawing.Font("Century Gothic", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Day.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Day.Location = New System.Drawing.Point(87, 79)
        Me.lbl_Day.Name = "lbl_Day"
        Me.lbl_Day.Size = New System.Drawing.Size(113, 83)
        Me.lbl_Day.TabIndex = 179
        Me.lbl_Day.Text = "00"
        '
        'lbl_Year
        '
        Me.lbl_Year.AutoSize = True
        Me.lbl_Year.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Year.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Year.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Year.Location = New System.Drawing.Point(98, 156)
        Me.lbl_Year.Name = "lbl_Year"
        Me.lbl_Year.Size = New System.Drawing.Size(89, 39)
        Me.lbl_Year.TabIndex = 178
        Me.lbl_Year.Text = "2025"
        '
        'lbl_Month
        '
        Me.lbl_Month.AutoSize = True
        Me.lbl_Month.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Month.Font = New System.Drawing.Font("Century Gothic", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Month.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Month.Location = New System.Drawing.Point(194, 79)
        Me.lbl_Month.Name = "lbl_Month"
        Me.lbl_Month.Size = New System.Drawing.Size(286, 83)
        Me.lbl_Month.TabIndex = 177
        Me.lbl_Month.Text = "MONTH"
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
        Me.btn_Back.TabIndex = 183
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'BookingApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.AdminBookingApproval
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.lbl_Second)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.lbl_Day)
        Me.Controls.Add(Me.lbl_Year)
        Me.Controls.Add(Me.lbl_Month)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pbox_EditVenues)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookingApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_EditVenues As PictureBox
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents lbl_Second As Label
    Friend WithEvents lbl_Time As Label
    Friend WithEvents lbl_Day As Label
    Friend WithEvents lbl_Year As Label
    Friend WithEvents lbl_Month As Label
    Friend WithEvents btn_Back As Button
    Friend WithEvents Timer As Timer
End Class
