Public Class Form1
    Dim inter As String = ""
    Dim player As New MediaPlayer.MediaPlayer
    Dim n As Integer = 0
    Dim copeurl As String = "http://c21livecdn002.cires21.com/playercope.mp3"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Pause" Then
            player.Pause()
            Button1.Text = "Play"
            retardo.Start()
        Else
            If Not (player.PlayState = 6 Or player.PlayState = 0) Then
                player.Play()
                Button1.Text = "Pause"
                retardo.Stop()
                inter = Label1.Text.Substring(10)
                Label2.Text = "Último:     " & inter
            Else
                player.FileName = copeurl
                player.Play()
                Button1.Text = "Pause"
                player.Volume = 0
            End If

        End If


    End Sub

    Private Sub retardo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retardo.Tick
        n = n + 1
        Label1.Text = "Retardo:  " & n & " Segundos"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        player.Stop()
        Button1.Text = "Play"
        Label1.Text = "Retardo:  0 Segundos"
        retardo.Stop()
        n = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

End Class
