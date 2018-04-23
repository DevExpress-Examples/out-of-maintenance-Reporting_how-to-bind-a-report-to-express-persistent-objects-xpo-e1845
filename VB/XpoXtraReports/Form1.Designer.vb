Imports Microsoft.VisualBasic
Imports System
Namespace XpoXtraReports
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnSave = New System.Windows.Forms.Button()
			Me.btnDesign = New System.Windows.Forms.Button()
			Me.btnPreview = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnSave
			' 
			Me.btnSave.Location = New System.Drawing.Point(12, 12)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New System.Drawing.Size(160, 42)
			Me.btnSave.TabIndex = 0
			Me.btnSave.Text = "Save report"
			Me.btnSave.UseVisualStyleBackColor = True
'			Me.btnSave.Click += New System.EventHandler(Me.btnSave_Click);
			' 
			' btnDesign
			' 
			Me.btnDesign.Location = New System.Drawing.Point(12, 73)
			Me.btnDesign.Name = "btnDesign"
			Me.btnDesign.Size = New System.Drawing.Size(160, 38)
			Me.btnDesign.TabIndex = 1
			Me.btnDesign.Text = "Show designer"
			Me.btnDesign.UseVisualStyleBackColor = True
'			Me.btnDesign.Click += New System.EventHandler(Me.btnDesign_Click);
			' 
			' btnPreview
			' 
			Me.btnPreview.Location = New System.Drawing.Point(12, 128)
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.Size = New System.Drawing.Size(160, 39)
			Me.btnPreview.TabIndex = 2
			Me.btnPreview.Text = "Show preview"
			Me.btnPreview.UseVisualStyleBackColor = True
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(185, 186)
			Me.Controls.Add(Me.btnPreview)
			Me.Controls.Add(Me.btnDesign)
			Me.Controls.Add(Me.btnSave)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnSave As System.Windows.Forms.Button
		Private WithEvents btnDesign As System.Windows.Forms.Button
		Private WithEvents btnPreview As System.Windows.Forms.Button

	End Class
End Namespace

