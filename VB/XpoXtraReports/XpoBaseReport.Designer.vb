Imports Microsoft.VisualBasic
Imports System
Namespace XpoXtraReports
	Partial Public Class XpoBaseReport
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' XpoBaseReport
			' 
			Me.Version = "9.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
	End Class
End Namespace
