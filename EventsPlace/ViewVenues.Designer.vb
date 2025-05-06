<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewVenues
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
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.pbox_Booking = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ViewVenues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.CustomerVenue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Booking)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.lbl_Title)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ViewVenues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Title As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents pbox_Booking As PictureBox
End Class
