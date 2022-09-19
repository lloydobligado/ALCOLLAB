Imports System.Data.OleDb
Public Class RegisterForm

    Private Sub TFIRSTNAME_Click(sender As Object, e As EventArgs) Handles TFIRSTNAME.Click
        TFIRSTNAME.Text = ""
    End Sub

    Private Sub TLASTNAME_Click(sender As Object, e As EventArgs) Handles TLASTNAME.Click
        TLASTNAME.Text = ""
    End Sub

    Private Sub TUSERN_Click(sender As Object, e As EventArgs) Handles TUSERN.Click
        TUSERN.Text = ""
    End Sub

    Private Sub TEMAIL_Click(sender As Object, e As EventArgs) Handles TEMAIL.Click
        TEMAIL.Text = ""
    End Sub

    Private Sub TPASS_Click(sender As Object, e As EventArgs) Handles TPASS.Click
        TPASS.Text = ""
        TPASS.UseSystemPasswordChar = True
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles Tconpass.Click
        Tconpass.Text = ""
        Tconpass.UseSystemPasswordChar = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TUSERN.Text = "" Or TUSERN.Text = "Username" Then
            MsgBox("PLEASE FILL USERNAME", MsgBoxStyle.Exclamation, "NOTICE")
        ElseIf TPASS.Text = "" Or TPASS.Text = "Password" Then
            MsgBox("PLEASE FILL PASSWORD", MsgBoxStyle.Exclamation, "NOTICE")
        Else
            Try
                'note: pag lilipat gawa ka sariling database using access 2013!
                'then palitan mo ung Data Source = address ng database.
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\FuzzyCat\Documents\HospitalLogin.accdb;")
                Dim insert As String = "Insert into Table1 values('" & TFIRSTNAME.Text & "','" & TLASTNAME.Text & "','" & TUSERN.Text & "','" & TPASS.Text & "','" & TEMAIL.Text & "','" & Tconpass.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("CREATE ACCOUNT SUCCESSFULLY", MsgBoxStyle.Information, "INFORMATION")
                Me.Hide()
                LogInForm.Show()
            Catch ex As Exception
                MsgBox("PLEASE FILL ALL THE TEXT", MsgBoxStyle.Critical, "NOTICE")
            End Try
        End If


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        LoadingForm.Close()
        LogInForm.Close()
        MainForm.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time2.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class