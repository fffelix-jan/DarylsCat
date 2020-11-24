' Daryl's Cat 1.0
' Copyright (c) 2020 Félix An
' Licensed under the MIT License: https://opensource.org/licenses/MIT

Public Class Form1
    Shared rand As New Random()
    Shared foodAmount As UInteger = 500
    Shared ReadOnly catJokes = New String() {"What do cats like to eat on a hot day? A mice-cream cone!", "Why do cats always get their way? They are very purr-suasive!", "How do two cats end a fight? They hiss and make up!", "What should you use to comb a cat? A catacomb!", "What is a cat's favorite movie? The Sound of Mewsic!", "How do you know a cat is agitated? He's having a hissy fit!", "What's a cat's favorite magazine? Good Mousekeeping!", "Why did the cat wear a fancy dress? She was feline fine!", "What's a cat's favorite color? Purr-ple!", "Why was the cat afraid of the tree? Because of its bark!", "What did the cat say when it was confused? 'I'm purr-plexed!'", "What's a cat's favorite dessert? Chocolate mouse!", "Where does a cat go when it loses its tail? The re-tail store!", "What do you call a cat who lives in an igloo? An eskimew!", "How do cats stop crimes? They call claw enforcement!", "Why was the cat so agitated? Because he was in a bad mewd!", "What do you call a cat who loves to bowl? An alley cat!", "What do cats love to do in the morning? Read the mewspaper!", "How is cat food sold? Usually, purr the can!", "What do baby cats always wear? Diapurrs!", "Why are cats great singers? Because they're very mewsical!", "Why can't cats play poker in the jungle? Too many cheetahs!", "What's another name for a cat's house? A scratch pad!", "What should you say to your cat when you leave the house? 'Have a mice day!'", "What do cats use to make coffee? A purr-colator!", "How does a cat decide what it wants from the store? It flips through the cat-alog!", "In what kind of weather is a vet the busiest? When it's raining cats and dogs!", "What do you call a cat wearing shoes? A puss in boots!", "What type of cat works for the Red Cross? A first aid cat!", "Why do cats always win video games? Because they have nine lives!", "What state has a lot of cats and dogs? Petsylvania!", "What's a cat's favorite game to play with a mouse? Catch!", "What do you call a pile of kittens? A meowntain!", "What do cats eat for breakfast? Mice Krispies!", "Where do cats always fly out of when they travel? Kitty Hawk!", "How does a cat sing scales? Do-re-mew!", "Why did the cat eat the lemons? He was a sourpuss!", "What's a cat's favorite subject in school? Hisss-tory!", "What types of cats purr the best? Purrr-sians!", "What sports do cats play? Hairball!", "Why are cats better than babies? Because you only have to change a litter box once a day.", "Who was the most powerful cat in China? Chairman Meow.", "What’s a cat’s favorite button on the TV remote? Paws."}
    Shared ReadOnly eatingMessages = New String() {"*crunch* *gulp* *lick* YUM!", "*loud chewing* Delicious!", "*munch* *slurp* BUUUUURP... excuse me!", "*gulp* *chew* *crunch* More, please!"}
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label2.Text = foodAmount
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles MeowButton.Click
        My.Computer.Audio.Play(My.Resources.meow, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BarkButton.Click
        My.Computer.Audio.Play(My.Resources.bark, AudioPlayMode.Background)
        If rand.Next(1, 100) = 5 Then
            MessageBox.Show("MEOW! Why are you playing the dog sound so much? I thought I was a cat! Play the 'meow' a few times too!", "HEY!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles FeedButton.Click
        Try
            foodAmount += rand.Next(1, 100)
            Label2.Text = foodAmount
            My.Computer.Audio.Play(My.Resources.pourfood, AudioPlayMode.Background)
        Catch
            MessageBox.Show("MEOW! My plate is overflowing! Perhaps you should let me eat first?", "Too Much Food!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub EatButton_Click(sender As System.Object, e As System.EventArgs) Handles EatButton.Click
        Try
            foodAmount -= rand.Next(1, 200)
            Label2.Text = foodAmount
            My.Computer.Audio.Play(My.Resources.eat, AudioPlayMode.Background)
            MsgBox(eatingMessages(rand.Next(0, eatingMessages.Length - 1)), MsgBoxStyle.OkOnly, "Thanks for the food!")
        Catch
            MessageBox.Show("MEOW! I don't have enough food to eat! Perhaps you should add some food first?", "Not Enough Food!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AboutLink.LinkClicked
        MessageBox.Show("Daryl's Cat 1.0" & vbCrLf & "Copyright © 2020 Félix An" & vbCrLf & "Licensed under the MIT License" & vbCrLf & "Dedicated to Neekon, Kristen, Vivian, Jeremiah and all the wonderful members of the PlayerFront Paradise", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub JokeButton_Click(sender As System.Object, e As System.EventArgs) Handles JokeButton.Click
        My.Computer.Audio.Play(My.Resources.laughing, AudioPlayMode.Background)
        MsgBox(catJokes(rand.Next(0, catJokes.Length - 1)), MsgBoxStyle.OkOnly, "A cat joke for you!")
    End Sub
End Class
