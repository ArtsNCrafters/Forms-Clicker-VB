Public Class SecretForm
    Dim thesave As String
    Dim user As String = SystemInformation.UserName
    Dim filepath As String = "C:\Users\" & user & "\testdatasave.txt"
    Dim Swriter As System.IO.StreamWriter
    Dim Sreader As System.IO.StreamReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Saving is in the works!")
        If System.IO.File.Exists(filepath) Then
            Sreader = My.Computer.FileSystem.OpenTextFileReader(filepath)
            Dim lines As Integer
            Dim newline As String
            Dim reader As Integer
            txtpluh.Text = String.Empty
            Do While Sreader.EndOfStream = False
                newline = Sreader.ReadLine()
                reader += 1
                txtpluh.Text = txtpluh.Text & newline & ControlChars.NewLine
            Loop
            Sreader.Close()
        End If


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not System.IO.File.Exists(filepath) Then
            System.IO.File.Create(filepath).Dispose()
        End If
        Swriter = My.Computer.FileSystem.OpenTextFileWriter(filepath, True)
        'basically this part right here will tell you how the file is basically "encoded" or how to read it
        Swriter.WriteLine(txtpluh.Text)
        Swriter.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class