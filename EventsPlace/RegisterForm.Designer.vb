<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_ReEnter = New System.Windows.Forms.Label()
        Me.btn_Register = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.pbox_UserName = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtb_UserName = New System.Windows.Forms.TextBox()
        Me.txtb_Password = New System.Windows.Forms.TextBox()
        Me.txtb_ReEnter = New System.Windows.Forms.TextBox()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        CType(Me.pbox_UserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Password.Location = New System.Drawing.Point(536, 200)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(115, 27)
        Me.lbl_Password.TabIndex = 11
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Username.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Username.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Username.Location = New System.Drawing.Point(536, 119)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(125, 27)
        Me.lbl_Username.TabIndex = 10
        Me.lbl_Username.Text = "Username"
        '
        'lbl_ReEnter
        '
        Me.lbl_ReEnter.AutoSize = True
        Me.lbl_ReEnter.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReEnter.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReEnter.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_ReEnter.Location = New System.Drawing.Point(536, 283)
        Me.lbl_ReEnter.Name = "lbl_ReEnter"
        Me.lbl_ReEnter.Size = New System.Drawing.Size(217, 27)
        Me.lbl_ReEnter.TabIndex = 14
        Me.lbl_ReEnter.Text = "Re-enter Password"
        '
        'btn_Register
        '
        Me.btn_Register.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Register.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Register.ForeColor = System.Drawing.Color.White
        Me.btn_Register.Location = New System.Drawing.Point(598, 388)
        Me.btn_Register.Name = "btn_Register"
        Me.btn_Register.Size = New System.Drawing.Size(278, 53)
        Me.btn_Register.TabIndex = 16
        Me.btn_Register.Text = "REGISTER"
        Me.btn_Register.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Back.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(598, 452)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(278, 53)
        Me.btn_Back.TabIndex = 17
        Me.btn_Back.Text = "BACK"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'lbl_Title
        '
        Me.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.Color.DarkOrange
        Me.lbl_Title.Location = New System.Drawing.Point(546, 53)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(375, 50)
        Me.lbl_Title.TabIndex = 18
        Me.lbl_Title.Text = "CREATE ACCOUNT"
        '
        'pbox_UserName
        '
        Me.pbox_UserName.BackColor = System.Drawing.Color.PapayaWhip
        Me.pbox_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbox_UserName.Location = New System.Drawing.Point(541, 149)
        Me.pbox_UserName.Name = "pbox_UserName"
        Me.pbox_UserName.Size = New System.Drawing.Size(385, 50)
        Me.pbox_UserName.TabIndex = 19
        Me.pbox_UserName.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(541, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 50)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Location = New System.Drawing.Point(541, 313)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(385, 50)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'txtb_UserName
        '
        Me.txtb_UserName.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_UserName.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_UserName.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_UserName.Location = New System.Drawing.Point(555, 160)
        Me.txtb_UserName.Name = "txtb_UserName"
        Me.txtb_UserName.Size = New System.Drawing.Size(358, 29)
        Me.txtb_UserName.TabIndex = 23
        '
        'txtb_Password
        '
        Me.txtb_Password.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_Password.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_Password.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_Password.Location = New System.Drawing.Point(555, 241)
        Me.txtb_Password.Name = "txtb_Password"
        Me.txtb_Password.Size = New System.Drawing.Size(358, 29)
        Me.txtb_Password.TabIndex = 24
        Me.txtb_Password.UseSystemPasswordChar = True
        '
        'txtb_ReEnter
        '
        Me.txtb_ReEnter.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtb_ReEnter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtb_ReEnter.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_ReEnter.ForeColor = System.Drawing.Color.Chocolate
        Me.txtb_ReEnter.Location = New System.Drawing.Point(555, 324)
        Me.txtb_ReEnter.Name = "txtb_ReEnter"
        Me.txtb_ReEnter.Size = New System.Drawing.Size(358, 29)
        Me.txtb_ReEnter.TabIndex = 25
        Me.txtb_ReEnter.UseSystemPasswordChar = True
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
        Me.btn_Minimize.TabIndex = 27
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
        Me.btn_Close.TabIndex = 26
        Me.btn_Close.Text = "x"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EventsPlace.My.Resources.Resources.FinalLogoSignUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 547)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.txtb_ReEnter)
        Me.Controls.Add(Me.txtb_Password)
        Me.Controls.Add(Me.txtb_UserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbox_UserName)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Register)
        Me.Controls.Add(Me.lbl_ReEnter)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbox_UserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Password As Label
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_ReEnter As Label
    Friend WithEvents btn_Register As Button
    Friend WithEvents btn_Back As Button
    Friend WithEvents lbl_Title As Label
    Friend WithEvents pbox_UserName As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtb_UserName As TextBox
    Friend WithEvents txtb_Password As TextBox
    Friend WithEvents txtb_ReEnter As TextBox
    Friend WithEvents btn_Minimize As Button
    Friend WithEvents btn_Close As Button
End Class
