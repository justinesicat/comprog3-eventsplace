<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_Username = New System.Windows.Forms.PictureBox()
        Me.txtb_Username = New System.Windows.Forms.TextBox()
        Me.pbox_Password = New System.Windows.Forms.PictureBox()
        Me.txtb_Password = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.pbox_viewPassword = New System.Windows.Forms.PictureBox()
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_viewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Login
        '
        Me.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Login.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Login.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.Location = New System.Drawing.Point(598, 388)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(278, 53)
        Me.btn_Login.TabIndex = 7
        Me.btn_Login.Text = "SIGN IN"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'lbl_Password
        '
        Me.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Password.Location = New System.Drawing.Point(536, 245)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(115, 27)
        Me.lbl_Password.TabIndex = 6
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Username.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Username.Location = New System.Drawing.Point(536, 146)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(125, 27)
        Me.lbl_Username.TabIndex = 5
        Me.lbl_Username.Text = "Username"
        '
        'btn_Register
        '
        Me.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Register.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Register.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.ForeColor = System.Drawing.Color.White
        Me.btn_Register.Location = New System.Drawing.Point(598, 452)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(278, 53)
        Me.btn_Register.TabIndex = 10
        Me.btn_Register.Text = "CREATE ACCOUNT"
        Me.btn_Register.UseVisualStyleBackColor = False
        '
        'lbl_Title
        '
        Me.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Title.Location = New System.Drawing.Point(652, 53)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(170, 50)
        Me.lbl_Title.TabIndex = 11
        Me.lbl_Title.Text = "SIGN IN"
        '
        'pbox_Username
        '
        Me.pbox_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Username.Location = New System.Drawing.Point(541, 179)
        Me.pbox_Username.Name = "pbox_Username"
        Me.pbox_Username.Size = New System.Drawing.Size(385, 50)
        Me.pbox_Username.TabIndex = 12
        Me.pbox_Username.TabStop = False
        '
        'txtb_Username
        '
        Me.txtb_Username.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtb_Username.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Username.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Username.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Username.Location = New System.Drawing.Point(555, 190)
        Me.txtb_Username.Name = "txtb_Username"
        Me.txtb_Username.Size = New System.Drawing.Size(358, 29)
        Me.txtb_Username.TabIndex = 13
        '
        'pbox_Password
        '
        Me.pbox_Password.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_Password.Location = New System.Drawing.Point(541, 278)
        Me.pbox_Password.Name = "pbox_Password"
        Me.pbox_Password.Size = New System.Drawing.Size(385, 50)
        Me.pbox_Password.TabIndex = 14
        Me.pbox_Password.TabStop = False
        '
        'txtb_Password
        '
        Me.txtb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtb_Password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Password.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Password.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Password.Location = New System.Drawing.Point(555, 289)
        Me.txtb_Password.Name = "txtb_Password"
        Me.txtb_Password.Size = New System.Drawing.Size(358, 29)
        Me.txtb_Password.TabIndex = 15
        Me.txtb_Password.UseSystemPasswordChar = True
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
        Me.btn_Close.TabIndex = 16
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
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
        Me.btn_Minimize.TabIndex = 17
        Me.btn_Minimize.Text = "━"
        Me.btn_Minimize.UseVisualStyleBackColor = False
        '
        'pbox_viewPassword
        '
        Me.pbox_viewPassword.BackColor = System.Drawing.Color.Transparent
        Me.pbox_viewPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbox_viewPassword.Image = CType(resources.GetObject("pbox_viewPassword.Image"), System.Drawing.Image)
        Me.pbox_viewPassword.Location = New System.Drawing.Point(882, 245)
        Me.pbox_viewPassword.Name = "pbox_viewPassword"
        Me.pbox_viewPassword.Size = New System.Drawing.Size(51, 33)
        Me.pbox_viewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbox_viewPassword.TabIndex = 18
        Me.pbox_viewPassword.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.pbox_viewPassword)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.txtb_Password)
        Me.Controls.Add(Me.pbox_Password)
        Me.Controls.Add(Me.txtb_Username)
        Me.Controls.Add(Me.pbox_Username)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_viewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Login As Button
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents btn_Register As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_Username As PictureBox
    Friend WithEvents txtb_Username As TextBox
    Friend WithEvents pbox_Password As PictureBox
    Friend WithEvents txtb_Password As TextBox
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents pbox_viewPassword As PictureBox
End Class
