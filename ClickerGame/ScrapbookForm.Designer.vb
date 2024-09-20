<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScrapbookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScrapbookForm))
        Me.btnRight = New System.Windows.Forms.Button()
        Me.tltGlag = New System.Windows.Forms.ToolTip(Me.components)
        Me.picScrapbook = New System.Windows.Forms.PictureBox()
        CType(Me.picScrapbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(4, 323)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(424, 59)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "&Flip to a terribly random page"
        Me.tltGlag.SetToolTip(Me.btnRight, "By the way, YOU CAN FAIL TO FLIP TO A PAGE AT ALL LMAOOOOOOO XD")
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'tltGlag
        '
        Me.tltGlag.AutomaticDelay = 0
        Me.tltGlag.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.tltGlag.ToolTipTitle = "Glag Says:"
        '
        'picScrapbook
        '
        Me.picScrapbook.Image = Global.ClickerGame.My.Resources.Resources.book_icon
        Me.picScrapbook.Location = New System.Drawing.Point(4, -1)
        Me.picScrapbook.Name = "picScrapbook"
        Me.picScrapbook.Size = New System.Drawing.Size(424, 325)
        Me.picScrapbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picScrapbook.TabIndex = 2
        Me.picScrapbook.TabStop = False
        '
        'ScrapbookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 387)
        Me.Controls.Add(Me.picScrapbook)
        Me.Controls.Add(Me.btnRight)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(454, 426)
        Me.MinimumSize = New System.Drawing.Size(454, 426)
        Me.Name = "ScrapbookForm"
        Me.Text = "Gigglr's Scrapbook :)"
        CType(Me.picScrapbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRight As Button
    Friend WithEvents picScrapbook As PictureBox
    Friend WithEvents tltGlag As ToolTip
End Class
