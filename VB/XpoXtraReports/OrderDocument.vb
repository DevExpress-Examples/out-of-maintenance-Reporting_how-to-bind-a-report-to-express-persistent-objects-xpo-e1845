Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo

Namespace XpoXtraReports
	'[Report("0001","Order document",2)]
	Partial Public Class OrderDocument
		Inherits XpoXtraReports.XpoBaseReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xpCollection1_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles xpCollection1.ResolveSession
			If e.Session Is Nothing Then
				e.Session = New UnitOfWork()
			End If
		End Sub

	End Class
End Namespace
