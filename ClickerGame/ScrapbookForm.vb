Public Class ScrapbookForm

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        Dim randomnumber As Integer ' make a variable
        Dim lastnumber As Integer
        randomnumber = Int((15 * Rnd()) + 1)
        If Not randomnumber = lastnumber Then
            If randomnumber = 1 Then 'there is a better way to do this but i dont careeeee
                picScrapbook.Image = My.Resources.scpArtsisnotokay
            ElseIf randomnumber = 2 Then
                picScrapbook.Image = My.Resources.scpBean
            ElseIf randomnumber = 3 Then
                picScrapbook.Image = My.Resources.scpBlu
            ElseIf randomnumber = 4 Then
                picScrapbook.Image = My.Resources.scpCantaloupe
            ElseIf randomnumber = 5 Then
                picScrapbook.Image = My.Resources.scpCantaloupoxian
            ElseIf randomnumber = 6 Then
                picScrapbook.Image = My.Resources.scpFIREINTHEHOLE
            ElseIf randomnumber = 7 Then
                picScrapbook.Image = My.Resources.scpOermer
            ElseIf randomnumber = 8 Then
                picScrapbook.Image = My.Resources.scpProtip
            ElseIf randomnumber = 9 Then
                picScrapbook.Image = My.Resources.scpSwag
            ElseIf randomnumber = 10 Then
                picScrapbook.Image = My.Resources.scpTalkingArts
            ElseIf randomnumber = 11 Then
                picScrapbook.Image = My.Resources.scpUnnamed
            ElseIf randomnumber = 12 Then
                picScrapbook.Image = My.Resources.spcDuckn_t
            ElseIf randomnumber = 13 Then
                picScrapbook.Image = My.Resources.pagenotfound
            ElseIf randomnumber = 14 Then
                picScrapbook.Image = My.Resources.scpPicture1
            ElseIf randomnumber = 15 Then
                picScrapbook.Image = My.Resources.scpPicture2
            End If
            lastnumber = randomnumber
        End If

    End Sub
End Class