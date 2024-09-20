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
        Label1.Text = Label1.Text + clicks ' add the clicks value to the label (clicks can be changed by the upgrade)
        pgbDecor1.Value = pgbDecor1.Value + 1 'the code below is for a dynamic decor
        If pgbDecor1.Value = 100 Then
            pgbDecor1.Value = 0
        End If
    End Sub

    Private Sub btnUpgrade1_Click(sender As Object, e As EventArgs) Handles btnUpgrade1.Click ' this is for upgrades
        If Label1.Text >= 100 + modifier Then ' if the label has a value greater than or equal to (100 + modifier) then
            Label1.Text = Label1.Text - (100 + modifier) ' remove (100 + modifier) from the label
            clicks = clicks + 1 ' change clicks abount by 1 (E.X. instead of clicking to get 1 point, you click to get 2)
            modifier = modifier + 50 ' make it more expensive to buy again
            tempmessage = (message + CStr(100 + modifier) + message2).ToString ' combine the messages to make a string that will match the price
            btnUpgrade1.Text = tempmessage ' set the text
            tempmessage = (message3 + CStr(1000 + modifier) + message2).ToString ' update the decor price (it's affected by the modifier)
            btnRandom.Text = tempmessage ' set the text
            tempmessage = (message4 + CStr(clicks)).ToString
            lblclicksamount.Text = tempmessage
            tempmessage = (message5 + CStr((clicks \ 2))).ToString
            lblautclcmod.Text = tempmessage
            pgbDecor1.Value = pgbDecor1.Value + 1 'the code below is for a dynamic decor
            If pgbDecor1.Value = 100 Then
                pgbDecor1.Value = 0
            End If
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click ' the random decor button
        If Label1.Text >= 1000 + (modifier) Then ' if its >= 1000 plus modifier
            Label1.Text = Label1.Text - (1000 + modifier) ' subtract it
            Dim randomnumber As Integer ' make a variable
            randomnumber = Int((5 * Rnd()) + 1) ' make it pick from 1 to 4 (for some reason it isn't truly random yet)
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
            modifier = modifier + 10
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
        If hints = False Then
            randomnumber = Int((11 * Rnd()) + 1)
        Else
            randomnumber = Int((15 * Rnd()) + 1)
        End If


        If randomnumber = 1 Then
            Dim myToolTipText = "hai!!!!!! :)"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 2 Then
            Dim myToolTipText = "hello!!!!!! :]"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 3 Then
            Dim myToolTipText = "that's some very nice clicking. I really like it :D"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 4 Then
            Dim myToolTipText = "hi! how are you doing? Great? GREAT! THAT MAKES MY SO HAPPY :D :) :3 :O"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 5 Then
            Dim myToolTipText = "glaggl"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 6 Then
            Dim myToolTipText = "you should visit glaggleland. it's so fun and silly :))))"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 7 Then
            Dim myToolTipText = "hi chat. today we are glaggling in this silly clicker game"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 8 Then
            Dim myToolTipText = "HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 9 Then
            Dim myToolTipText = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 10 Then
            Dim myToolTipText = ":]"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 11 Then
            randomnumber = Int((3 * Rnd()) + 1)
            Dim myToolTipText = "This game is so boring, look what I can do !!!!" ' do not
            If randomnumber = 1 Then
                picGlag.Image = My.Resources.gigglridle
            ElseIf randomnumber = 2 Then
                picGlag.Image = My.Resources.gigglrwave
            ElseIf randomnumber = 3 Then
                picGlag.Image = My.Resources.gigglr_prev_ui__1_
            End If
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 12 Then
            Dim myToolTipText = "You lookin for a password? It's REALLY easy."
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 13 Then
            Dim myToolTipText = "This is such a cool CLICKER game i'm in, don't you think?"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
            myToolTipText = "dude. ITS ACTUALLY SO EASY JUST DO IT ALREADY"
            totGlag.SetToolTip(Me.txtDecor5, myToolTipText)
        ElseIf randomnumber = 14 Then
            Dim myToolTipText = "to be honest, you could so easily look in the source code to find anything. IT'S REALLY NOT THAT HARD!!!!"
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        ElseIf randomnumber = 15 Then
            Dim myToolTipText = "..."
            totGlag.SetToolTip(Me.picGlag, myToolTipText)
        End If
            lastnumber = randomnumber
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click ' ez dev button
        clicks = clicks + Label1.Text
        Label1.Text = Label1.Text + clicks
        tempmessage = (message4 + CStr(clicks)).ToString
        lblclicksamount.Text = tempmessage
        tempmessage = (message5 + CStr((clicks \ 2))).ToString
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
            progress = progress + 1
            hints = False
        End If
        If txtDecor5.Text = "upgrade" Then
            txtDecor5.Text = ""
            lblDecor.Text = "you know you can resize the page to the right, right? do that."
            piculcok.Visible = False
        End If
    End Sub

    Private Sub picBook_Click(sender As Object, e As EventArgs) Handles picBook.Click
        ScrapbookForm.Visible = True
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If Label1.Text >= 50000 Then
            Autoclick.Enabled = True
            btnAuto.Text = "Pay your respects: 50,000 clicks"
            Label1.Text = Label1.Text - 50000
        End If
    End Sub

    Private Sub Autoclick_Tick(sender As Object, e As EventArgs) Handles Autoclick.Tick
        Label1.Text = Label1.Text + (clicks \ 2)
    End Sub
End Class
