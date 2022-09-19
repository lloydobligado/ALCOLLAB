Public Class LoadingForm

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If ProgressBar1.Value = 100 Then
            Me.Close()
            MainForm.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


End Class
