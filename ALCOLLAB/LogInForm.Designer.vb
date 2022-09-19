<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        Me.TUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.time1 = New System.Windows.Forms.Label()
        Me.timerone = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PBOHIDE = New ns1.BunifuImageButton()
        Me.PBOMATA = New ns1.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOHIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOMATA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TUSERNAME
        '
        Me.TUSERNAME.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TUSERNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TUSERNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TUSERNAME.Location = New System.Drawing.Point(846, 392)
        Me.TUSERNAME.Multiline = True
        Me.TUSERNAME.Name = "TUSERNAME"
        Me.TUSERNAME.Size = New System.Drawing.Size(272, 46)
        Me.TUSERNAME.TabIndex = 5
        Me.TUSERNAME.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(873, 612)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DOESN'T HAVE AN ACCOUNT? CREATE ONE"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(836, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(295, 63)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tpass
        '
        Me.tpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tpass.Location = New System.Drawing.Point(846, 464)
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(217, 42)
        Me.tpass.TabIndex = 6
        Me.tpass.Text = "Password"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'time1
        '
        Me.time1.AutoSize = True
        Me.time1.BackColor = System.Drawing.Color.Gray
        Me.time1.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.ForeColor = System.Drawing.Color.White
        Me.time1.Location = New System.Drawing.Point(1083, 672)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(94, 19)
        Me.time1.TabIndex = 25
        Me.time1.Text = "hh: mm tt"
        '
        'timerone
        '
        Me.timerone.Enabled = True
        Me.timerone.Interval = 1000
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.ALCOLLAB.My.Resources.Resources.REDDOT
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1193, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(23, 21)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 21
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.ALCOLLAB.My.Resources.Resources.unangslide
        Me.PictureBox2.Location = New System.Drawing.Point(78, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.PictureBox2.Size = New System.Drawing.Size(651, 346)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PBOHIDE
        '
        Me.PBOHIDE.BackColor = System.Drawing.Color.White
        Me.PBOHIDE.Image = Global.ALCOLLAB.My.Resources.Resources.hide
        Me.PBOHIDE.ImageActive = Nothing
        Me.PBOHIDE.Location = New System.Drawing.Point(1069, 464)
        Me.PBOHIDE.Name = "PBOHIDE"
        Me.PBOHIDE.Size = New System.Drawing.Size(49, 46)
        Me.PBOHIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBOHIDE.TabIndex = 15
        Me.PBOHIDE.TabStop = False
        Me.PBOHIDE.Zoom = 10
        '
        'PBOMATA
        '
        Me.PBOMATA.BackColor = System.Drawing.Color.White
        Me.PBOMATA.Image = Global.ALCOLLAB.My.Resources.Resources.eye
        Me.PBOMATA.ImageActive = Nothing
        Me.PBOMATA.Location = New System.Drawing.Point(1069, 464)
        Me.PBOMATA.Name = "PBOMATA"
        Me.PBOMATA.Size = New System.Drawing.Size(49, 46)
        Me.PBOMATA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBOMATA.TabIndex = 14
        Me.PBOMATA.TabStop = False
        Me.PBOMATA.Visible = False
        Me.PBOMATA.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ALCOLLAB.My.Resources.Resources.L0GIN
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1225, 694)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'LogInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1235, 704)
        Me.Controls.Add(Me.time1)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBOHIDE)
        Me.Controls.Add(Me.PBOMATA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TUSERNAME)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "LogInForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOHIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOMATA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TUSERNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PBOHIDE As ns1.BunifuImageButton
    Friend WithEvents PBOMATA As ns1.BunifuImageButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tpass As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents time1 As System.Windows.Forms.Label
    Friend WithEvents timerone As System.Windows.Forms.Timer
End Class
