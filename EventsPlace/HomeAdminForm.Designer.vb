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
        Me.btn_ViewReservations = New System.Windows.Forms.Button()
        Me.btn_EditVenues = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pb_Display = New System.Windows.Forms.PictureBox()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.pbox_EditVenues = New System.Windows.Forms.PictureBox()
        Me.pbox_Account = New System.Windows.Forms.PictureBox()
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ViewReservations
        '
        Me.btn_ViewReservations.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_ViewReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewReservations.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewReservations.ForeColor = System.Drawing.Color.White
        Me.btn_ViewReservations.Location = New System.Drawing.Point(216, 467)
        Me.btn_ViewReservations.Name = "btn_ViewReservations"
        Me.btn_ViewReservations.Size = New System.Drawing.Size(278, 53)
        Me.btn_ViewReservations.TabIndex = 18
        Me.btn_ViewReservations.Text = "View Reservations"
        Me.btn_ViewReservations.UseVisualStyleBackColor = False
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
        'pb_Display
        '
        Me.pb_Display.Location = New System.Drawing.Point(102, 153)
        Me.pb_Display.Name = "pb_Display"
        Me.pb_Display.Size = New System.Drawing.Size(833, 292)
        Me.pb_Display.TabIndex = 32
        Me.pb_Display.TabStop = False
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
        Me.pbox_Account.Location = New System.Drawing.Point(0, 413)
        Me.pbox_Account.Name = "pbox_Account"
        Me.pbox_Account.Size = New System.Drawing.Size(68, 68)
        Me.pbox_Account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_Account.TabIndex = 36
        Me.pbox_Account.TabStop = False
        '
        'HomeAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.AdminHome1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_Account)
        Me.Controls.Add(Me.pbox_EditVenues)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.pb_Display)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_EditVenues)
        Me.Controls.Add(Me.btn_ViewReservations)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeAdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_EditVenues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ViewReservations As Button
    Friend WithEvents btn_EditVenues As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pb_Display As PictureBox
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents pbox_EditVenues As PictureBox
    Friend WithEvents pbox_Account As PictureBox
End Class
