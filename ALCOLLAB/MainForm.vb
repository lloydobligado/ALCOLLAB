Public Class MainForm

    Private Sub lbltime_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        LoadingForm.Close()
        LogInForm.Close()
        RegisterForm.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Oras.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles HOMEBUTTON.Click
        PNLHOME.Visible = True
        PNLPINFO.Visible = False
        PNLMINVENT.Visible = False
        HOMEMAIN.Visible = True
        mainlabel.Text = "HOME"
        TRANSITION.HideSync(PNLMINVENT)
        TRANSITION.HideSync(PNLPINFO)
        TRANSITION.ShowSync(PNLHOME)
    End Sub

    Private Sub PINFOBUTTON_Click(sender As Object, e As EventArgs) Handles PINFOBUTTON.Click
        PNLHOME.Visible = False
        PNLPINFO.Visible = True
        PNLMINVENT.Visible = False
        PINFOMAIN.Visible = True
        HOMEMAIN.Visible = False
        MINVENTMAIN.Visible = False
        mainlabel.Text = "PATIENT INFORMATION"
        TRANSITION.HideSync(PNLMINVENT)
        TRANSITION.ShowSync(PNLPINFO)
        TRANSITION.HideSync(PNLHOME)
    End Sub

    Private Sub MINVENT_Click(sender As Object, e As EventArgs) Handles MINVENT.Click
        PNLHOME.Visible = False
        PNLPINFO.Visible = False
        PNLMINVENT.Visible = True
        MINVENTMAIN.Visible = True
        HOMEMAIN.Visible = False
        PINFOMAIN.Visible = False
        mainlabel.Text = "MEDICINE INVENTORY"
        TRANSITION.ShowSync(PNLMINVENT)
        TRANSITION.HideSync(PNLPINFO)
        TRANSITION.HideSync(PNLHOME)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MINVENTBACK.Click
        PNLHOME.Visible = True
        PNLPINFO.Visible = False
        PNLMINVENT.Visible = False
        HOMEMAIN.Visible = True
        PINFOMAIN.Visible = False
        MINVENTMAIN.Visible = False
        mainlabel.Text = "HOME"
        TRANSITION.HideSync(PNLMINVENT)
        TRANSITION.HideSync(PNLPINFO)
        TRANSITION.ShowSync(PNLHOME)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles PINFO.Click
        PNLHOME.Visible = True
        PNLPINFO.Visible = False
        PNLMINVENT.Visible = False
        HOMEMAIN.Visible = True
        PINFOMAIN.Visible = False
        MINVENTMAIN.Visible = False
        mainlabel.Text = "HOME"
        TRANSITION.HideSync(PNLMINVENT)
        TRANSITION.HideSync(PNLPINFO)
        TRANSITION.ShowSync(PNLHOME)

    End Sub

    Private Sub LOGOUTBUTTON_Click(sender As Object, e As EventArgs) Handles LOGOUTBUTTON.Click
        Me.Close()
        LogInForm.Show()



    End Sub

    Private Sub Welcome_Tick(sender As Object, e As EventArgs) Handles Welcome.Tick

        If LBLWELCOME.Location.X + LBLWELCOME.Width < 0 Then
            LBLWELCOME.Location = New Point(Me.Width, LBLWELCOME.Location.Y)
        Else
            LBLWELCOME.Location = New Point(LBLWELCOME.Location.X - 15, LBLWELCOME.Location.Y)
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PINFODataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.PINFODataSet.Table1)
        LBLWELCOME.Left = Me.Width
        Welcome.Start()
        lbltime.Parent = PictureBox1
        lbltime.BackColor = Color.Transparent

        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub SLIDESHOW_Tick(sender As Object, e As EventArgs) Handles SLIDESHOW.Tick
        If LBLDOT.Text = "." Then
            SLIDINGPHOTO.Image = My.Resources.ikalawangslide
            LBLDOT.Text = ".."
        ElseIf LBLDOT.Text = ".." Then
            SLIDINGPHOTO.Image = My.Resources.ikatlongslide
            LBLDOT.Text = "..."
        ElseIf LBLDOT.Text = "..." Then
            SLIDINGPHOTO.Image = My.Resources.unangslide
            LBLDOT.Text = "."
        End If
    End Sub
    'MAXIMIZED
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PINFODataSet)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox5.Load(Me.OpenFileDialog1.FileName)
        Else
            MsgBox("Please Choose Image")
        End If
    End Sub

    Dim i As Integer
    Private Sub ADDPATIENT_Click(sender As Object, e As EventArgs) Handles ADDPATIENT.Click
        i = 0
    End Sub
End Class