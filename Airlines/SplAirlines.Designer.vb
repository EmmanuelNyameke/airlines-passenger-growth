﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplAirlines
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackgroundImage = My.Resources.Resources.airlines
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        MainLayoutPanel.Size = New Size(496, 303)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Location = New Point(246, 221)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(247, 79)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Version.ForeColor = Color.IndianRed
        Version.Location = New Point(3, 9)
        Version.Name = "Version"
        Version.Size = New Size(241, 20)
        Version.TabIndex = 1
        Version.Text = "Version 1.00"
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Copyright.ForeColor = Color.IndianRed
        Copyright.Location = New Point(3, 39)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(241, 40)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright 2024"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Verdana", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        ApplicationTitle.ForeColor = Color.IndianRed
        ApplicationTitle.Location = New Point(246, 3)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(247, 212)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Airlines" & vbCrLf
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' SplAirlines
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplAirlines"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

End Class
