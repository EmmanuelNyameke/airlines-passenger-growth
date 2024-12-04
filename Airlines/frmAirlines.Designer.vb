<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirlines
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
        Panel1 = New Panel()
        btnClear = New Button()
        btnCalculate = New Button()
        lstYears = New ListBox()
        txtYear = New TextBox()
        lblYear = New Label()
        lblHeading = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnCalculate)
        Panel1.Controls.Add(lstYears)
        Panel1.Controls.Add(txtYear)
        Panel1.Controls.Add(lblYear)
        Panel1.Controls.Add(lblHeading)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(340, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(460, 450)
        Panel1.TabIndex = 0
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.IndianRed
        btnClear.Font = New Font("Verdana", 15.75F)
        btnClear.Location = New Point(275, 406)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(131, 41)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.IndianRed
        btnCalculate.Font = New Font("Verdana", 15.75F)
        btnCalculate.Location = New Point(55, 406)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(131, 41)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' lstYears
        ' 
        lstYears.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstYears.FormattingEnabled = True
        lstYears.ItemHeight = 23
        lstYears.Location = New Point(3, 142)
        lstYears.Name = "lstYears"
        lstYears.Size = New Size(457, 234)
        lstYears.TabIndex = 3
        ' 
        ' txtYear
        ' 
        txtYear.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYear.Location = New Point(374, 95)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(74, 37)
        txtYear.TabIndex = 2
        txtYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Font = New Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblYear.Location = New Point(34, 98)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(306, 29)
        lblYear.TabIndex = 1
        lblYear.Text = "Enter a Year From 2018:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(33, 30)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(394, 35)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Airlines Passenger Growth"
        ' 
        ' frmAirlines
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.airlines
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmAirlines"
        Text = "Airlines Passenger Growth"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lstYears As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button

End Class
