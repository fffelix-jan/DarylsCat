' Daryl's Cat 1.1.0
' Copyright (c) 2020 Félix An
' Licensed under the MIT License: https://opensource.org/licenses/MIT

Public Class Form1
    Shared Rand As New Random()

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label2.Text = My.Settings.FoodAmount
        If My.Settings.PoopPresent Then
            PoopBox.Show()
            PoopLabel.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles MeowButton.Click
        My.Computer.Audio.Play(My.Resources.Meow, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BarkButton.Click
        My.Computer.Audio.Play(My.Resources.Bark, AudioPlayMode.Background)
        If Rand.Next(1, 100) = 5 Then
            MessageBox.Show("MEOW! Why are you playing the dog sound so much? I don't like dogs! Play the 'meow' a few times too!", "HEY!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MooButton_Click(sender As System.Object, e As System.EventArgs) Handles MooButton.Click
        My.Computer.Audio.Play(My.Resources.Moo, AudioPlayMode.Background)
    End Sub

    Private Sub FoxButton_Click(sender As System.Object, e As System.EventArgs) Handles FoxButton.Click
        Select Case Rand.Next(0, 3)
            Case 0
                My.Computer.Audio.Play(My.Resources.FoxGeringDing, AudioPlayMode.Background)
                MessageBox.Show("What does the fox say?" & vbCrLf & "'Ring-ding-ding-ding-dingeringeding!'", "What does the FOX say?")
            Case 1
                My.Computer.Audio.Play(My.Resources.FoxWaPaPow, AudioPlayMode.Background)
                MessageBox.Show("What does the fox say?" & vbCrLf & "'Wa-pa-pa-pa-pa-pa-pow!'", "What does the FOX say?")
            Case 2
                My.Computer.Audio.Play(My.Resources.FoxHaTeHo, AudioPlayMode.Background)
                MessageBox.Show("What does the fox say?" & vbCrLf & "'Hatee-hatee-hatee-ho!'", "What does the FOX say?")
        End Select
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles FeedButton.Click
        Try
            My.Settings.FoodAmount += Rand.Next(1, 100)
            Label2.Text = My.Settings.FoodAmount
            My.Computer.Audio.Play(My.Resources.PourFood, AudioPlayMode.Background)
        Catch
            MessageBox.Show("MEOW! My plate is overflowing! Perhaps you should let me eat first?", "Too Much Food!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub EatButton_Click(sender As System.Object, e As System.EventArgs) Handles EatButton.Click
        Dim toEat As Integer
        toEat = Rand.Next(1, 101)

        If My.Settings.FoodAmount = 0 Then
            MessageBox.Show("MEOW! I don't have enough food to eat! Perhaps you should add some food first?", "Not Enough Food!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If toEat >= My.Settings.FoodAmount Then
            My.Settings.FoodAmount = 0
        Else
            My.Settings.FoodAmount -= toEat
        End If

        My.Computer.Audio.Play(My.Resources.Eat, AudioPlayMode.Background)
        Label2.Text = My.Settings.FoodAmount

        If Rand.Next(1, 16) = 8 Then
            PoopTimer.Stop()
            PoopTimer.Start()
        End If

        MessageBox.Show(StringBank.EatingMessages(Rand.Next(0, StringBank.EatingMessages.Length)), "Thanks for the food!")
    End Sub

    Private Sub AboutLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AboutLink.LinkClicked
        MessageBox.Show("Daryl's Cat 1.1.0" & vbCrLf & "https://github.com/fffelix-jan/DarylsCat" & vbCrLf & vbCrLf & "Copyright © 2020-2021 Félix An" & vbCrLf & "Licensed under the MIT License" & vbCrLf & "Dedicated to Neekon, Kristen, Vivian, Jeremiah and all the wonderful members of the PlayerFront Paradise", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub JokeButton_Click(sender As System.Object, e As System.EventArgs) Handles JokeButton.Click
        My.Computer.Audio.Play(My.Resources.Laughing, AudioPlayMode.Background)
        MsgBox(StringBank.CatJokes(Rand.Next(0, StringBank.CatJokes.Length)), MsgBoxStyle.OkOnly, "A cat joke for you!")
    End Sub

    Private Sub ShowPoop()
        My.Computer.Audio.Play(My.Resources.Fart, AudioPlayMode.Background)
        My.Settings.PoopPresent = True
        PoopBox.Show()
        PoopLabel.Show()
    End Sub

    Private Sub HidePoop()
        My.Settings.PoopPresent = False
        PoopBox.Hide()
        PoopLabel.Hide()
    End Sub

    Private Sub PoopTimer_Tick(sender As Object, e As System.EventArgs) Handles PoopTimer.Tick
        PoopTimer.Stop()
        ShowPoop()
    End Sub

    Private Sub PoopBox_Click(sender As Object, e As System.EventArgs) Handles PoopBox.Click
        HidePoop()
    End Sub
End Class
