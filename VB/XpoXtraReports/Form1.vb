Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports System.Reflection
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports DevExpress.XtraReports.UserDesigner
Imports System.ComponentModel.Design

Namespace XpoXtraReports
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			AddHandler Load, AddressOf Form1_Load
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.CreateData()
		End Sub
		Private Sub CreateData()
			Dim rnd As New Random()
			Using uow As New UnitOfWork()
				For i As Integer = 0 To 4
					Dim ord As New Order(uow)
					ord.Date = DateTime.Now.AddDays(rnd.Next(1, 10))
					ord.Id = i
					For j As Integer = 0 To 3
						Dim ol As New OrderLine(uow)
						ol.Item = String.Format("Item # {0}", j + 1)
						ol.Cost = Convert.ToDecimal(rnd.NextDouble() * 100)
						ord.Lines.Add(ol)
					Next j
				Next i
				uow.CommitChanges()
			End Using
		End Sub

		Private Sub btnExecute_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim od As New OrderDocument()
			od.SaveLayout("Report.repx")
		End Sub
		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
			Dim od As New OrderDocument()
			od.SaveLayout("Report.repx")
		End Sub
		Private Sub btnDesign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDesign.Click
			If File.Exists("Report.repx") Then
				Dim report As XtraReport = XtraReport.FromFile("Report.repx", True)
				Dim designer As New XRDesignRibbonFormEx()
				AddHandler designer.DesignPanel.Activated, AddressOf DesignPanel_Activated
				designer.OpenReport(report)
				designer.Show()
			End If
		End Sub
		Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
			If File.Exists("Report.repx") Then
				Dim report As XtraReport = XtraReport.FromFile("Report.repx", True)
				report.ShowPreview()
			End If
		End Sub
		Private Sub DesignPanel_Activated(ByVal sender As Object, ByVal e As EventArgs)
			Dim report As XtraReport = (CType(sender, XRDesignPanel)).Report
			If TypeOf report Is XpoBaseReport Then
				Dim svc As IComponentChangeService = TryCast((CType(sender, XRDesignPanel)).GetService(GetType(IComponentChangeService)), IComponentChangeService)
				svc.OnComponentChanged(report, Nothing, Nothing, Nothing)
			End If
		End Sub
	End Class
End Namespace
