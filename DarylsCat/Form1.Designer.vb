<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MeowButton = New System.Windows.Forms.Button()
        Me.BarkButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FoxButton = New System.Windows.Forms.Button()
        Me.MooButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EatButton = New System.Windows.Forms.Button()
        Me.FeedButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AboutLink = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JokeButton = New System.Windows.Forms.Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PoopLabel = New System.Windows.Forms.Label()
        Me.PoopBox = New System.Windows.Forms.PictureBox()
        Me.MainCatBox = New System.Windows.Forms.PictureBox()
        Me.PoopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PoopBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainCatBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MeowButton
        '
        Me.MeowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.MeowButton, "MeowButton")
        Me.MeowButton.ForeColor = System.Drawing.Color.White
        Me.MeowButton.Name = "MeowButton"
        Me.MeowButton.UseVisualStyleBackColor = False
        '
        'BarkButton
        '
        Me.BarkButton.BackColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.BarkButton, "BarkButton")
        Me.BarkButton.Name = "BarkButton"
        Me.BarkButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FoxButton)
        Me.GroupBox1.Controls.Add(Me.MooButton)
        Me.GroupBox1.Controls.Add(Me.MeowButton)
        Me.GroupBox1.Controls.Add(Me.BarkButton)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'FoxButton
        '
        Me.FoxButton.BackColor = System.Drawing.Color.PapayaWhip
        resources.ApplyResources(Me.FoxButton, "FoxButton")
        Me.FoxButton.Name = "FoxButton"
        Me.FoxButton.UseVisualStyleBackColor = False
        '
        'MooButton
        '
        Me.MooButton.BackColor = System.Drawing.Color.Snow
        resources.ApplyResources(Me.MooButton, "MooButton")
        Me.MooButton.Name = "MooButton"
        Me.MooButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.EatButton)
        Me.GroupBox2.Controls.Add(Me.FeedButton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'EatButton
        '
        Me.EatButton.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.EatButton, "EatButton")
        Me.EatButton.Name = "EatButton"
        Me.EatButton.UseVisualStyleBackColor = False
        '
        'FeedButton
        '
        Me.FeedButton.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.FeedButton, "FeedButton")
        Me.FeedButton.Name = "FeedButton"
        Me.FeedButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'AboutLink
        '
        resources.ApplyResources(Me.AboutLink, "AboutLink")
        Me.AboutLink.Name = "AboutLink"
        Me.AboutLink.TabStop = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'JokeButton
        '
        Me.JokeButton.BackColor = System.Drawing.SystemColors.ButtonFace
        resources.ApplyResources(Me.JokeButton, "JokeButton")
        Me.JokeButton.Name = "JokeButton"
        Me.JokeButton.UseVisualStyleBackColor = False
        '
        'VersionLabel
        '
        resources.ApplyResources(Me.VersionLabel, "VersionLabel")
        Me.VersionLabel.Name = "VersionLabel"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PoopLabel)
        Me.GroupBox3.Controls.Add(Me.PoopBox)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'PoopLabel
        '
        resources.ApplyResources(Me.PoopLabel, "PoopLabel")
        Me.PoopLabel.Name = "PoopLabel"
        '
        'PoopBox
        '
        Me.PoopBox.Image = Global.DarylsCat.My.Resources.Resources.Poo
        resources.ApplyResources(Me.PoopBox, "PoopBox")
        Me.PoopBox.Name = "PoopBox"
        Me.PoopBox.TabStop = False
        '
        'MainCatBox
        '
        Me.MainCatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainCatBox.Image = Global.DarylsCat.My.Resources.Resources.MainCat
        resources.ApplyResources(Me.MainCatBox, "MainCatBox")
        Me.MainCatBox.Name = "MainCatBox"
        Me.MainCatBox.TabStop = False
        '
        'PoopTimer
        '
        Me.PoopTimer.Interval = 1000
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.JokeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MainCatBox)
        Me.Controls.Add(Me.AboutLink)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PoopBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainCatBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MeowButton As System.Windows.Forms.Button
    Friend WithEvents BarkButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FeedButton As System.Windows.Forms.Button
    Friend WithEvents EatButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AboutLink As System.Windows.Forms.LinkLabel
    Friend WithEvents MainCatBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JokeButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MooButton As System.Windows.Forms.Button
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FoxButton As System.Windows.Forms.Button
    Friend WithEvents PoopLabel As System.Windows.Forms.Label
    Friend WithEvents PoopBox As System.Windows.Forms.PictureBox
    Friend WithEvents PoopTimer As System.Windows.Forms.Timer

End Class
