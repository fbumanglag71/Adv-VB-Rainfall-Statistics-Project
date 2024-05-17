<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lstBoxYears = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblYearRainfall = New Label()
        Button1 = New Button()
        lblAverageRainfall = New Label()
        lblRainiestYear = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstBoxYears
        ' 
        lstBoxYears.FormattingEnabled = True
        lstBoxYears.ItemHeight = 15
        lstBoxYears.Location = New Point(334, 168)
        lstBoxYears.Name = "lstBoxYears"
        lstBoxYears.Size = New Size(153, 34)
        lstBoxYears.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(334, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 37)
        Label1.TabIndex = 1
        Label1.Text = "RAINFALL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(334, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 37)
        Label2.TabIndex = 2
        Label2.Text = "Statistics"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Label3.Location = New Point(334, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 30)
        Label3.TabIndex = 3
        Label3.Text = "2000 - 2021"
        ' 
        ' lblYearRainfall
        ' 
        lblYearRainfall.AutoSize = True
        lblYearRainfall.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
        lblYearRainfall.Location = New Point(72, 228)
        lblYearRainfall.Name = "lblYearRainfall"
        lblYearRainfall.Size = New Size(0, 16)
        lblYearRainfall.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
        Button1.Location = New Point(72, 263)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 37)
        Button1.TabIndex = 5
        Button1.Text = "Display Statistics"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblAverageRainfall
        ' 
        lblAverageRainfall.AutoSize = True
        lblAverageRainfall.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
        lblAverageRainfall.Location = New Point(72, 316)
        lblAverageRainfall.Name = "lblAverageRainfall"
        lblAverageRainfall.Size = New Size(0, 16)
        lblAverageRainfall.TabIndex = 6
        ' 
        ' lblRainiestYear
        ' 
        lblRainiestYear.AutoSize = True
        lblRainiestYear.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold)
        lblRainiestYear.Location = New Point(72, 357)
        lblRainiestYear.Name = "lblRainiestYear"
        lblRainiestYear.Size = New Size(0, 16)
        lblRainiestYear.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 167)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 384)
        Controls.Add(PictureBox1)
        Controls.Add(lblRainiestYear)
        Controls.Add(lblAverageRainfall)
        Controls.Add(Button1)
        Controls.Add(lblYearRainfall)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstBoxYears)
        Name = "Form1"
        Text = "SEATTLE RAINFALL STATISTICS"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstBoxYears As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblYearRainfall As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAverageRainfall As Label
    Friend WithEvents lblRainiestYear As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
