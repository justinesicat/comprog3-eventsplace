﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountCustomer))
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        Me.pbox_Home = New System.Windows.Forms.PictureBox()
        Me.pbox_Picture = New System.Windows.Forms.PictureBox()
        Me.txtb_Username = New System.Windows.Forms.TextBox()
        Me.pbox_Username = New System.Windows.Forms.PictureBox()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.txtb_Password = New System.Windows.Forms.TextBox()
        Me.pbox_Password = New System.Windows.Forms.PictureBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.pbox_Booking = New System.Windows.Forms.PictureBox()
        Me.pbox_Venue = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbl_Title
        '
        Me.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Title.Location = New System.Drawing.Point(95, 18)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(169, 37)
        Me.lbl_Title.TabIndex = 32
        Me.lbl_Title.Text = "ACCOUNT"
        '
        'btn_LogOut
        '
        Me.btn_LogOut.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LogOut.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LogOut.ForeColor = System.Drawing.Color.White
        Me.btn_LogOut.Location = New System.Drawing.Point(560, 467)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(278, 53)
        Me.btn_LogOut.TabIndex = 33
        Me.btn_LogOut.Text = "Log Out"
        Me.btn_LogOut.UseVisualStyleBackColor = False
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
        Me.pbox_Home.TabIndex = 34
        Me.pbox_Home.TabStop = False
        '
        'pbox_Picture
        '
        Me.pbox_Picture.BackColor = System.Drawing.Color.Transparent
        Me.pbox_Picture.Image = Global.EventsPlace.My.Resources.Resources.CustomerIcon
        Me.pbox_Picture.Location = New System.Drawing.Point(457, 94)
        Me.pbox_Picture.Name = "pbox_Picture"
        Me.pbox_Picture.Size = New System.Drawing.Size(150, 150)
        Me.pbox_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Picture.TabIndex = 36
        Me.pbox_Picture.TabStop = False
        '
        'txtb_Username
        '
        Me.txtb_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtb_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Username.Enabled = False
        Me.txtb_Username.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Username.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Username.Location = New System.Drawing.Point(349, 314)
        Me.txtb_Username.Name = "txtb_Username"
        Me.txtb_Username.Size = New System.Drawing.Size(358, 29)
        Me.txtb_Username.TabIndex = 38
        Me.txtb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbox_Username
        '
        Me.pbox_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Username.Location = New System.Drawing.Point(335, 303)
        Me.pbox_Username.Name = "pbox_Username"
        Me.pbox_Username.Size = New System.Drawing.Size(385, 50)
        Me.pbox_Username.TabIndex = 37
        Me.pbox_Username.TabStop = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.ForeColor = System.Drawing.Color.White
        Me.btn_Edit.Location = New System.Drawing.Point(216, 467)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(278, 53)
        Me.btn_Edit.TabIndex = 39
        Me.btn_Edit.Text = "Edit"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'txtb_Password
        '
        Me.txtb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtb_Password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Password.Enabled = False
        Me.txtb_Password.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Password.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Password.Location = New System.Drawing.Point(349, 383)
        Me.txtb_Password.Name = "txtb_Password"
        Me.txtb_Password.Size = New System.Drawing.Size(358, 29)
        Me.txtb_Password.TabIndex = 41
        Me.txtb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtb_Password.UseSystemPasswordChar = True
        '
        'pbox_Password
        '
        Me.pbox_Password.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Password.Location = New System.Drawing.Point(335, 372)
        Me.pbox_Password.Name = "pbox_Password"
        Me.pbox_Password.Size = New System.Drawing.Size(385, 50)
        Me.pbox_Password.TabIndex = 40
        Me.pbox_Password.TabStop = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(216, 467)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(278, 53)
        Me.btn_Save.TabIndex = 42
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        Me.btn_Save.Visible = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.btn_Cancel.Location = New System.Drawing.Point(560, 467)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(278, 53)
        Me.btn_Cancel.TabIndex = 43
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        Me.btn_Cancel.Visible = False
        '
        'lbl_Status
        '
        Me.lbl_Status.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Status.Location = New System.Drawing.Point(447, 246)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(173, 37)
        Me.lbl_Status.TabIndex = 44
        Me.lbl_Status.Text = "CUSTOMER"
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
        Me.pbox_Booking.TabIndex = 46
        Me.pbox_Booking.TabStop = False
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
        Me.pbox_Venue.TabIndex = 45
        Me.pbox_Venue.TabStop = False
        '
        'AccountCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalCustomerAccount
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Booking)
        Me.Controls.Add(Me.pbox_Venue)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txtb_Password)
        Me.Controls.Add(Me.pbox_Password)
        Me.Controls.Add(Me.btn_Edit)
        Me.Controls.Add(Me.txtb_Username)
        Me.Controls.Add(Me.pbox_Username)
        Me.Controls.Add(Me.pbox_Picture)
        Me.Controls.Add(Me.pbox_Home)
        Me.Controls.Add(Me.btn_LogOut)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AccountCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Booking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Venue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents btn_LogOut As Button
    Friend WithEvents pbox_Home As PictureBox
    Friend WithEvents pbox_Picture As PictureBox
    Friend WithEvents txtb_Username As TextBox
    Friend WithEvents pbox_Username As PictureBox
    Friend WithEvents btn_Edit As Button
    Friend WithEvents txtb_Password As TextBox
    Friend WithEvents pbox_Password As PictureBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents lbl_Status As Label
    Friend WithEvents pbox_Booking As PictureBox
    Friend WithEvents pbox_Venue As PictureBox
End Class
