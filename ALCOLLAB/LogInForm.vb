Imports System.Data.OleDb
Public Class LogInForm

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        LoadingForm.Close()
        RegisterForm.Close()
        MainForm.Close()
    End Sub


    Private Sub TUSERNAME_Click(sender As Object, e As EventArgs) Handles TUSERNAME.Click
        TUSERNAME.Text = ""
    End Sub


    Private Sub tpass_Leave(sender As Object, e As EventArgs) Handles tpass.Leave
        Dim PASS As String = tpass.Text
        If PASS.Trim().ToLower() = "password" Or PASS.Trim() = "" Then
            tpass.Text = "password"
            tpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub tpass_Enter(sender As Object, e As EventArgs) Handles tpass.Enter
        Dim PASS As String = tpass.Text
        If PASS.Trim().ToLower() = "password" Or PASS.Trim() = "" Then
            tpass.Text = ""
            tpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PBOHIDE_Click(sender As Object, e As EventArgs) Handles PBOHIDE.Click
        PBOHIDE.Visible = False
        PBOMATA.Visible = True
        tpass.UseSystemPasswordChar = False
    End Sub

    Private Sub PBOMATA_Click(sender As Object, e As EventArgs) Handles PBOMATA.Click
        PBOMATA.Visible = False
        PBOHIDE.Visible = True
        tpass.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      
        If TUSERNAME.Text = "" Or TUSERNAME.Text = "Username" Then
            MsgBox("PLEASE FILL USERNAME", MsgBoxStyle.Exclamation, "NOTICE")
        ElseIf tpass.Text = "" Or tpass.Text = "Password" Then
            MsgBox("PLEASE FILL PASSWORD", MsgBoxStyle.Exclamation, "NOTICE")
        Else
            Dim conn = New OleDbConnection
            Dim logincmd As OleDbCommand = New OleDbCommand("Select * from Table1 where [Username]='" & TUSERNAME.Text & "'and [Password]='" & tpass.Text & "'", conn)

            'note: pag lilipat gawa ka sariling database using access 2013!
            'then palitan mo ung Data Source = address ng database.
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FuzzyCat\Documents\HospitalLogin.accdb;")
            conn.Open()

            Dim loginrd As OleDbDataReader = logincmd.ExecuteReader

            Try
                logincmd.ExecuteReader()
            Catch ex As Exception

            End Try

            If (loginrd.Read() = True) Then
                MsgBox("SUCCESSFULLY LOGED IN!" & vbNewLine & "USERNAME: " & TUSERNAME.Text, MsgBoxStyle.Information, "INFORMATION")
                LoadingForm.Show()
                If LoadingForm.Visible Then
                    Me.Hide()

                    TUSERNAME.Text = "Username"
                    tpass.Text = "Password"
                    'filter
                    If tpass.Text = "Password" Then
                        tpass.UseSystemPasswordChar = False
                    End If
                End If
            Else
                MsgBox("INVALID USERNAME OR PASSWORD", MsgBoxStyle.Critical, "WARNING")
                TUSERNAME.Text = "Username"
                tpass.Text = "Password"
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        RegisterForm.Show()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles timerone.Tick
        time1.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time1.Parent = PictureBox1
        time1.BackColor = Color.Transparent
    End Sub
End Class