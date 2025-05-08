<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeAdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeAdminForm))
        Me.btn_BookingApproval = New System.Windows.Forms.Button()
        Me.btn_EditVenues = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_Display = New System.Windows.Forms.PictureBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_EditVenues = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        Me.pbox_BookingApproval = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_BookingApproval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_BookingApproval
        '
        Me.btn_BookingApproval.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_BookingApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_BookingApproval.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BookingApproval.ForeColor = System.Drawing.Color.White
        Me.btn_BookingApproval.Location = New System.Drawing.Point(216, 467)
        Me.btn_BookingApproval.Name = "btn_BookingApproval"
        Me.btn_BookingApproval.Size = New System.Drawing.Size(278, 53)
        Me.btn_BookingApproval.TabIndex = 18
        Me.btn_BookingApproval.Text = "Booking Approval"
        Me.btn_BookingApproval.UseVisualStyleBackColor = False
        '
        'btn_EditVenues
        '
        Me.btn_EditVenues.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_EditVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EditVenues.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EditVenues.ForeColor = System.Drawing.Color.White
        Me.btn_EditVenues.Location = New System.Drawing.Point(560, 467)
        Me.btn_EditVenues.Name = "btn_EditVenues"
        Me.btn_EditVenues.Size = New System.Drawing.Size(278, 53)
        Me.btn_EditVenues.TabIndex = 19
        Me.btn_EditVenues.Text = "Edit Venues"
        Me.btn_EditVenues.UseVisualStyleBackColor = False
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
        Me.lbl_Title.TabIndex = 24
        Me.lbl_Title.Text = "HOME"
        '
        'pbox_Display
        '
        Me.pbox_Display.Location = New System.Drawing.Point(102, 153)
        Me.pbox_Display.Name = "pbox_Display"
        Me.pbox_Display.Size = New System.Drawing.Size(833, 292)
        Me.pbox_Display.TabIndex = 32
        Me.pbox_Display.TabStop = False
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
        Me.lbl_Username.TabIndex = 31
        Me.lbl_Username.Text = "Welcome, USER!"
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
        Me.btn_Minimize.TabIndex = 34
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
        Me.btn_Close.TabIndex = 33
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
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
        Me.pbox_EditVenues.TabIndex = 35
        Me.pbox_EditVenues.TabStop = False
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
        'pbox_BookingApproval
        '
        Me.pbox_BookingApproval.BackColor = System.Drawing.Color.Transparent
        Me.pbox_BookingApproval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_BookingApproval.ErrorImage = Nothing
        Me.pbox_BookingApproval.Location = New System.Drawing.Point(0, 68)
        Me.pbox_BookingApproval.Name = "pbox_BookingApproval"
        Me.pbox_BookingApproval.Size = New System.Drawing.Size(68, 68)
        Me.pbox_BookingApproval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_BookingApproval.TabIndex = 173
        Me.pbox_BookingApproval.TabStop = False
        '
        'HomeAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.AdminHome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_BookingApproval)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pbox_EditVenues)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.pbox_Display)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_EditVenues)
        Me.Controls.Add(Me.btn_BookingApproval)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeAdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_BookingApproval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_BookingApproval As Button
    Friend WithEvents btn_EditVenues As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_Display As PictureBox
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_EditVenues As PictureBox
    Friend WithEvents pbox_Account As PictureBox
    Friend WithEvents pbox_BookingApproval As PictureBox
End Class
