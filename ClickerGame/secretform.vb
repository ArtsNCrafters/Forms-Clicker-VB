Public Class SecretForm
    Dim thesave As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Saving is in the works!")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim save As System.IO.StreamWriter
        thesave = txtpluh.Text


        My.Computer.FileSystem.OpenTextFileWriter("C:\ClickerData\DataDONOTEDITPLEASE.txt", True)

        save.WriteLine(thesave)

        save.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim fileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\ClickerData\DataDONOTEDITPLEASE.txt")

    End Sub
End Class