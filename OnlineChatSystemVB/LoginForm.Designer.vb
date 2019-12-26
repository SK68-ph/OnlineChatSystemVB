<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pass :"
        '
        'txtbox_pass
        '
        Me.txtbox_pass.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_pass.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pass.ForeColor = System.Drawing.Color.Yellow
        Me.txtbox_pass.Location = New System.Drawing.Point(175, 195)
        Me.txtbox_pass.Multiline = True
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbox_pass.Size = New System.Drawing.Size(223, 43)
        Me.txtbox_pass.TabIndex = 11
        Me.txtbox_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.SystemColors.ControlText
        Me.btn_register.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.Location = New System.Drawing.Point(105, 281)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(123, 56)
        Me.btn_register.TabIndex = 10
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "User :"
        '
        'txtbox_user
        '
        Me.txtbox_user.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtbox_user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbox_user.Font = New System.Drawing.Font("Calisto MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_user.ForeColor = System.Drawing.Color.Yellow
        Me.txtbox_user.Location = New System.Drawing.Point(175, 120)
        Me.txtbox_user.Multiline = True
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbox_user.Size = New System.Drawing.Size(223, 42)
        Me.txtbox_user.TabIndex = 8
        Me.txtbox_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.ControlText
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(275, 281)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(123, 56)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Submit"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OnlineChatSystemVB.My.Resources.Resources.Untitled
        Me.PictureBox1.Location = New System.Drawing.Point(184, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OnlineChatSystemVB.My.Resources.Resources.X
        Me.PictureBox2.Location = New System.Drawing.Point(429, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(504, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox_pass)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_user)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_pass As TextBox
    Friend WithEvents btn_register As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_user As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
