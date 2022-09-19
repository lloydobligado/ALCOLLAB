<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.TLASTNAME = New System.Windows.Forms.TextBox()
        Me.TUSERN = New System.Windows.Forms.TextBox()
        Me.TEMAIL = New System.Windows.Forms.TextBox()
        Me.TPASS = New System.Windows.Forms.TextBox()
        Me.Tconpass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.time2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TFIRSTNAME
        '
        Me.TFIRSTNAME.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TFIRSTNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TFIRSTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TFIRSTNAME.ForeColor = System.Drawing.Color.Gray
        Me.TFIRSTNAME.Location = New System.Drawing.Point(326, 374)
        Me.TFIRSTNAME.Multiline = True
        Me.TFIRSTNAME.Name = "TFIRSTNAME"
        Me.TFIRSTNAME.Size = New System.Drawing.Size(287, 46)
        Me.TFIRSTNAME.TabIndex = 6
        Me.TFIRSTNAME.Text = "First Name"
        Me.TFIRSTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TLASTNAME
        '
        Me.TLASTNAME.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TLASTNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TLASTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TLASTNAME.ForeColor = System.Drawing.Color.Gray
        Me.TLASTNAME.Location = New System.Drawing.Point(654, 375)
        Me.TLASTNAME.Multiline = True
        Me.TLASTNAME.Name = "TLASTNAME"
        Me.TLASTNAME.Size = New System.Drawing.Size(287, 46)
        Me.TLASTNAME.TabIndex = 7
        Me.TLASTNAME.Text = "Last Name"
        Me.TLASTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TUSERN
        '
        Me.TUSERN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TUSERN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TUSERN.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUSERN.ForeColor = System.Drawing.Color.Gray
        Me.TUSERN.Location = New System.Drawing.Point(326, 443)
        Me.TUSERN.Multiline = True
        Me.TUSERN.Name = "TUSERN"
        Me.TUSERN.Size = New System.Drawing.Size(287, 46)
        Me.TUSERN.TabIndex = 8
        Me.TUSERN.Text = "Username"
        Me.TUSERN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TEMAIL
        '
        Me.TEMAIL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TEMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEMAIL.ForeColor = System.Drawing.Color.Gray
        Me.TEMAIL.Location = New System.Drawing.Point(654, 443)
        Me.TEMAIL.Multiline = True
        Me.TEMAIL.Name = "TEMAIL"
        Me.TEMAIL.Size = New System.Drawing.Size(287, 46)
        Me.TEMAIL.TabIndex = 9
        Me.TEMAIL.Text = "Email"
        Me.TEMAIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPASS
        '
        Me.TPASS.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TPASS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPASS.ForeColor = System.Drawing.Color.Gray
        Me.TPASS.Location = New System.Drawing.Point(326, 514)
        Me.TPASS.Name = "TPASS"
        Me.TPASS.Size = New System.Drawing.Size(287, 42)
        Me.TPASS.TabIndex = 10
        Me.TPASS.Text = "Password"
        Me.TPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tconpass
        '
        Me.Tconpass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Tconpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tconpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tconpass.ForeColor = System.Drawing.Color.Gray
        Me.Tconpass.Location = New System.Drawing.Point(652, 514)
        Me.Tconpass.Name = "Tconpass"
        Me.Tconpass.Size = New System.Drawing.Size(287, 42)
        Me.Tconpass.TabIndex = 11
        Me.Tconpass.Text = "Confirm Pass"
        Me.Tconpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(492, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(283, 61)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'time2
        '
        Me.time2.AutoSize = True
        Me.time2.BackColor = System.Drawing.Color.Gray
        Me.time2.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time2.ForeColor = System.Drawing.Color.White
        Me.time2.Location = New System.Drawing.Point(1083, 675)
        Me.time2.Name = "time2"
        Me.time2.Size = New System.Drawing.Size(89, 19)
        Me.time2.TabIndex = 24
        Me.time2.Text = "hh:mm tt"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.ALCOLLAB.My.Resources.Resources.REDDOT
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1194, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(23, 21)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 23
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ALCOLLAB.My.Resources.Resources.REGISTER
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1225, 694)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1235, 704)
        Me.Controls.Add(Me.time2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tconpass)
        Me.Controls.Add(Me.TPASS)
        Me.Controls.Add(Me.TEMAIL)
        Me.Controls.Add(Me.TUSERN)
        Me.Controls.Add(Me.TLASTNAME)
        Me.Controls.Add(Me.TFIRSTNAME)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TFIRSTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TLASTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TUSERN As System.Windows.Forms.TextBox
    Friend WithEvents TEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents TPASS As System.Windows.Forms.TextBox
    Friend WithEvents Tconpass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents time2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
