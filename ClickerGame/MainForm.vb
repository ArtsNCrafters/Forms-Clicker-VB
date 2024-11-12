' Pretty please leave comments so I can at least comprehend this =D (since I don't really know VB)
' - beese79
' Alright :) -Arts
Public Class frmClicker
    'Sets up variables for clicks, modifier, button text, and colors
    Dim clicks As Double = 1
    Dim modifier As Double = 0
    Dim decormod As Integer = 0
    Dim message As String = "&Upgrade: "
    Dim message2 As String = " clicks"
    Dim message3 As String = "&Random Decor: "
    Dim message4 As String = "current click modifier: "
    Dim message5 As String = "current autoclick modifier: "
    Dim tempmessage As String = "temp"
    Dim bool As Boolean = True 'this could probably be deleted ngl
    Dim Black As Color = Color.FromArgb(255, 50, 50, 50)
    Dim Control As Color = Color.FromArgb(255, 233, 233, 233)
    Dim Transparent As Color = Color.FromArgb(0, 0, 0, 0)
    Dim glagmessage As String = "Hello Guys"
    Dim hints As Boolean = False
    Dim progress As Integer = 0

    ' tempmessage = (CInt(message) + 1 + CInt(message2)).ToString
    ' the temp message is for combining strings and integers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' on click
        Label1.Text += clicks ' add the clicks value to the label (clicks can be changed by the upgrade)
        pgbDecor1.Value += 1 'the code below is for a dynamic decor
        If pgbDecor1.Value = 100 Then
            pgbDecor1.Value = 0
        End If
    End Sub

    Private Sub btnUpgrade1_Click(sender As Object, e As EventArgs) Handles btnUpgrade1.Click ' this is for upgrades
        If Label1.Text >= 100 + modifier Then ' if the label has a value greater than or equal to (100 + modifier) then
            Label1.Text -= (100 + modifier) ' remove (100 + modifier) from the label
            clicks += 1 ' change clicks abount by 1 (E.X. instead of clicking to get 1 point, you click to get 2)
            modifier += 50 ' make it more expensive to buy again
            tempmessage = message & (100 + modifier).ToString & message2 ' combine the messages to make a string that will match the price
            btnUpgrade1.Text = tempmessage ' set the text
            tempmessage = message3 & (1000 + modifier).ToString + message2 ' update the decor price (it's affected by the modifier)
            btnRandom.Text = tempmessage ' set the text
            tempmessage = message4 & clicks.ToString
            lblclicksamount.Text = tempmessage
            tempmessage = message5 & (clicks \ 2).ToString
            lblautclcmod.Text = tempmessage
            pgbDecor1.Value += 1 'the code below is for a dynamic decor
            If pgbDecor1.Value = 100 Then
                pgbDecor1.Value = 0
            End If
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click ' the random decor button
        If Label1.Text >= 1000 + (modifier) Then ' if its >= 1000 plus modifier

            Label1.Text -= (1000 + modifier) ' subtract it

            Dim randomnumber As Integer ' make a variable
            randomnumber = Int((5 - 1 + 1) * Rnd() + 1)
            'randomnumber = Int((5 * Rnd()) + 1)  make it pick from 1 to 5 (depricated maybe)

            If randomnumber = 1 Then 'if its 1 then

                If pgbDecor1.Visible = False Then ' if it isnt visible then

                    pgbDecor1.Visible = True ' show it

                    lblDecor.Visible = True ' this is just to show what you got

                    lblDecor.Text = "You got a progressbar :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate progress bar :("
                End If

            ElseIf randomnumber = 2 Then ' if its 2 then
                If dtpDecor2.Visible = False Then ' if its not visible then

                    dtpDecor2.Visible = True ' show it

                    lblDecor.Visible = True

                    lblDecor.Text = "You got a date-time picker :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate date-time picker :("
                End If

            ElseIf randomnumber = 3 Then ' if its 3 yada yada you probably get it

                If picGlag.Visible = False Then
                    picGlag.Visible = True
                    lblDecor.Visible = True
                    totGlag.Active = True
                    lblDecor.Text = "You got a... SILLY GLAGGLE???? :O"
                    progress = progress + 1
                Else
                    lblDecor.Text = "Aw, it was a duplicate glaggle :("
                End If

            ElseIf randomnumber = 4 Then ' this is a bit strange, i'm constantly changing this one

                If rbtDecor4.Visible = False Then
                    rbtDecor4.Visible = True
                    rbtDecor42.Visible = True
                    rbtDecor43.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a background changer :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate background changer :("
                End If

            ElseIf randomnumber = 5 Then ' funny
                If txtDecor5.Visible = False Then
                    txtDecor5.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a mysterious password :O"
                    progress = progress + 1
                Else
                    lblDecor.Text = "you got a duplicate. if you want some codes, gigglr has some."
                    If progress < 3 Then
                        hints = True
                    End If

                End If
            End If
            modifier += 10
            tempmessage = (message3 + CStr(1000 + modifier) + message2).ToString
            btnRandom.Text = tempmessage
            tempmessage = (message + CStr(100 + modifier) + message2).ToString
            btnUpgrade1.Text = tempmessage
        End If
        pgbDecor1.Value = pgbDecor1.Value + 1 'the code below is for a dynamic decor
        If pgbDecor1.Value = 100 Then
            pgbDecor1.Value = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' this was for the progress bar, i DONT know how it's moving. now its for changing the glaggle message
        Dim randomnumber As Integer ' make a variable
        Dim lastnumber As Integer
        Do Until lastnumber <> randomnumber
            If hints = False Then
                randomnumber = Int((11 - 1 + 1) * Rnd() + 1)
            Else
                randomnumber = Int((15 - 1 + 1) * Rnd() + 1)
            End If
        Loop

        Select Case randomnumber
            Case 1
                Dim myToolTipText = "hai!!!!!! :)"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 2
                Dim myToolTipText = "hello!!!!!! :]"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 3
                Dim myToolTipText = "that's some very nice clicking. I really like it :D"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 4
                Dim myToolTipText = "hi! how are you doing? Great? GREAT! THAT MAKES MY SO HAPPY :D :) :3 :O"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 5
                Dim myToolTipText = "glaggl"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 6
                Dim myToolTipText = "you should visit glaggleland. it's so fun and silly :))))"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 7
                Dim myToolTipText = "hi chat. today we are glaggling in this silly clicker game"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 8
                Dim myToolTipText = "HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 9
                Dim myToolTipText = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 10
                Dim myToolTipText = ":]"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 11
                randomnumber = Int((3 - 1 + 1) * Rnd() + 1)
                Dim myToolTipText = "This game is so boring, look what I can do !!!!"
                Select Case randomnumber
                    Case 1
                        picGlag.Image = My.Resources.gigglridle
                    Case 2
                        picGlag.Image = My.Resources.gigglrwave
                    Case 3
                        picGlag.Image = My.Resources.gigglr_prev_ui__1_
                End Select
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 12
                Dim myToolTipText = "You lookin for a password? It's REALLY easy."
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 13
                Dim myToolTipText = "This is such a cool CLICKER game i'm in, don't you think?"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
                myToolTipText = "dude. ITS ACTUALLY SO EASY JUST DO IT ALREADY"
                totGlag.SetToolTip(Me.txtDecor5, myToolTipText)
            Case 14
                Dim myToolTipText = "to be honest, you could so easily look in the source code to find anything. IT'S REALLY NOT THAT HARD!!!!"
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
            Case 15
                Dim myToolTipText = "..."
                totGlag.SetToolTip(Me.picGlag, myToolTipText)
        End Select

        lastnumber = randomnumber
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click ' ez dev button
        clicks += Label1.Text
        Label1.Text += clicks
        tempmessage = message4 & clicks.ToString
        lblclicksamount.Text = tempmessage
        tempmessage = message5 & (clicks \ 2).ToString
        lblautclcmod.Text = tempmessage
    End Sub



    Private Sub rbtDecor4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor4.CheckedChanged ' radio buttons for bg changer

        Me.BackColor = Black
        Me.Opacity = 1
        ScrapbookForm.Opacity = 1
        ScrapbookForm.BackColor = Black
    End Sub

    Private Sub rbtDecor42_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor42.CheckedChanged 
        Me.BackColor = Control
        Me.Opacity = 1
        ScrapbookForm.BackColor = Control
        ScrapbookForm.Opacity = 1
    End Sub

    Private Sub rbtDecor43_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor43.CheckedChanged ' makes the form transparent lol
        Me.Opacity = 0.5
        ScrapbookForm.Opacity = 0.5
    End Sub

    Private Sub mtbDecor5_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtDecor5_TextChanged(sender As Object, e As EventArgs) Handles txtDecor5.TextChanged ' JUST LOOK HERE!! ALL THE PASSWORDS ARE HERE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        If txtDecor5.Text = "clicker" Then
            txtDecor5.Text = ""
            picBook.Visible = True
            progress += 1
            hints = False
        End If
        If txtDecor5.Text = "upgrade" Then
            txtDecor5.Text = ""
            lblDecor.Text = " HEY! HEY! you know you can resize the page to the right, right? you should do that."
            piculcok.Visible = False
        End If
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        ScrapbookForm.Visible = True
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        Static AutoclickMultiplier As Double
        If Not Autoclick.Enabled = True Then
            If Label1.Text >= 50000 Then
                Autoclick.Enabled = True
                btnAuto.Text = "Upgrade Autoclicker: 100,000 clicks"
                btnAutoToggle.Visible = True
                Label1.Text -= 50000
            End If
        Else
            If Label1.Text >= 100000 + AutoclickMultiplier Then
                Autoclick.Enabled = True
                Label1.Text -= (100000 + AutoclickMultiplier)
                AutoclickMultiplier += 50000
                btnAuto.Text = "Upgrade Autoclicker: " & (100000 + AutoclickMultiplier).ToString & " clicks"

                Autoclick.Interval *= 0.9
            End If
        End If
        If AutoclickMultiplier >= 900000 Then
            btngaymermode.Enabled = True
            btngaymermode.Visible = True
        End If
    End Sub

    Private Sub Autoclick_Tick(sender As Object, e As EventArgs) Handles Autoclick.Tick
        Label1.Text = Label1.Text + (clicks \ 2)
    End Sub

    Private Sub btnAutoToggle_Click(sender As Object, e As EventArgs) Handles btnAutoToggle.Click
        If Autoclick.Enabled = True Then
            Autoclick.Enabled = False
        Else
            Autoclick.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Do While Label1.Text >= 100 + modifier
            If Label1.Text >= 100 + modifier Then ' if the label has a value greater than or equal to (100 + modifier) then
                Label1.Text -= (100 + modifier) ' remove (100 + modifier) from the label
                clicks += 1 ' change clicks abount by 1 (E.X. instead of clicking to get 1 point, you click to get 2)
                modifier += 50 ' make it more expensive to buy again

                pgbDecor1.Value += 1 'the code below is for a dynamic decor
                If pgbDecor1.Value = 100 Then
                    pgbDecor1.Value = 0
                End If
            End If
        Loop
        tempmessage = message & (100 + modifier).ToString & message2 ' combine the messages to make a string that will match the price
        btnUpgrade1.Text = tempmessage ' set the text
        tempmessage = message3 & (1000 + modifier).ToString + message2 ' update the decor price (it's affected by the modifier)
        btnRandom.Text = tempmessage ' set the text
        tempmessage = message4 & clicks.ToString
        lblclicksamount.Text = tempmessage
        tempmessage = message5 & (clicks \ 2).ToString
        lblautclcmod.Text = tempmessage
    End Sub
    Private funny As Integer
    Private Sub btngaymermode_Click(sender As Object, e As EventArgs) Handles btngaymermode.Click
        PictureBox1.Visible = True
        Me.ShowInTaskbar = False
        Me.Size = MinimumSize
        funny = 0
        animationtimer.Enabled = True

    End Sub

    Private Sub rbgtimertest_Tick(sender As Object, e As EventArgs) Handles animationtimer.Tick
        If funny < 5 Then
            funny += 1

        Else
            Me.Text = "Good Luck"
            Dim yes As Integer = 1
            Me.Icon = SecretForm.Icon

            Do Until yes = 0

            Loop
            Me.Close()
        End If
    End Sub

    Private Sub frmClicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnopensave_Click(sender As Object, e As EventArgs) Handles btnopensave.Click
        SecretForm.Visible = True
    End Sub
End Class
