﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a language and I will say Good Morning."
        '
        'lblTranslation
        '
        Me.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslation.Location = New System.Drawing.Point(96, 37)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(100, 23)
        Me.lblTranslation.TabIndex = 1
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnItalian
        '
        Me.btnItalian.Location = New System.Drawing.Point(12, 91)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(75, 23)
        Me.btnItalian.TabIndex = 2
        Me.btnItalian.Text = "Italian"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.Location = New System.Drawing.Point(108, 91)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(75, 23)
        Me.btnSpanish.TabIndex = 3
        Me.btnSpanish.Text = "Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnGerman
        '
        Me.btnGerman.Location = New System.Drawing.Point(197, 91)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(75, 23)
        Me.btnGerman.TabIndex = 4
        Me.btnGerman.Text = "German"
        Me.btnGerman.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 136)
        Me.Controls.Add(Me.btnGerman)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Language Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblTranslation As Windows.Forms.Label
    Friend WithEvents btnItalian As Windows.Forms.Button
    Friend WithEvents btnSpanish As Windows.Forms.Button
    Friend WithEvents btnGerman As Windows.Forms.Button
End Class
