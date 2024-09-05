Public Class frmClicker
    Dim clicks As Integer = 1
    Dim modifier As Integer = 0
    Dim decormod As Integer = 0
    Dim message As String = "&Upgrade: "
    Dim message2 As String = " clicks"
    Dim message3 As String = "&Random Decor: "
    Dim tempmessage As String = "temp"
    Dim bool As Boolean = True
    Dim Black As Color = Color.FromArgb(255, 50, 50, 50)
    Dim Control As Color = Color.FromArgb(255, 233, 233, 233)
    Dim Transparent As Color = Color.FromArgb(0, 0, 0, 0)
    ' tempmessage = (CInt(message) + 1 + CInt(message2)).ToString

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Label1.Text + clicks
        pgbDecor1.Value = pgbDecor1.Value + 1
        If pgbDecor1.Value = 100 Then
            pgbDecor1.Value = 0
        End If
    End Sub

    Private Sub btnUpgrade1_Click(sender As Object, e As EventArgs) Handles btnUpgrade1.Click
        If Label1.Text >= 100 + modifier Then
            Label1.Text = Label1.Text - (100 + modifier)
            clicks = clicks + 1
            modifier = modifier + 50
            tempmessage = (message + CStr(100 + modifier) + message2).ToString
            btnUpgrade1.Text = tempmessage
            tempmessage = (message3 + CStr(1000 + modifier) + message2).ToString
            btnRandom.Text = tempmessage
            pgbDecor1.Value = pgbDecor1.Value + 1
            If pgbDecor1.Value = 100 Then
                pgbDecor1.Value = 0
            End If
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        If Label1.Text >= 1000 + (modifier) Then
            Label1.Text = Label1.Text - (1000 + modifier)
            Dim randomnumber As Integer
            randomnumber = Int((4 * Rnd()) + 1)
            If randomnumber = 1 Then
                If pgbDecor1.Visible = False Then
                    pgbDecor1.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a progressbar :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate :("
                End If
            ElseIf randomnumber = 2 Then
                If dtpDecor2.Visible = False Then
                    dtpDecor2.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a date-time picker :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate :("
                End If
            ElseIf randomnumber = 3 Then
                If chtDecor3.Visible = False Then
                    chtDecor3.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a... SILLY CHART???? :O"
                Else
                    lblDecor.Text = "Aw, it was a duplicate :("
                End If
            ElseIf randomnumber = 4 Then
                If rbtDecor4.Visible = False Then
                    rbtDecor4.Visible = True
                    rbtDecor42.Visible = True
                    rbtDecor43.Visible = True
                    lblDecor.Visible = True
                    lblDecor.Text = "You got a background changer :)"
                Else
                    lblDecor.Text = "Aw, it was a duplicate :("
                End If
            End If
            modifier = modifier + 10
            tempmessage = (message3 + CStr(1000 + modifier) + message2).ToString
            btnRandom.Text = tempmessage
            tempmessage = (message + CStr(100 + modifier) + message2).ToString
            btnUpgrade1.Text = tempmessage
        End If
        pgbDecor1.Value = pgbDecor1.Value + 1
        If pgbDecor1.Value = 100 Then
            pgbDecor1.Value = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        clicks = 1000
        Label1.Text = Label1.Text + clicks
    End Sub



    Private Sub rbtDecor4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor4.CheckedChanged

        Me.BackColor = Black
        Me.Opacity = 1
    End Sub

    Private Sub rbtDecor42_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor42.CheckedChanged
        Me.BackColor = Control
        Me.Opacity = 1
    End Sub

    Private Sub rbtDecor43_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDecor43.CheckedChanged
        Me.Opacity = 0.5
    End Sub
End Class
