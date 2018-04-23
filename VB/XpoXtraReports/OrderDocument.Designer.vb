Imports Microsoft.VisualBasic
Imports System
Namespace XpoXtraReports
	Partial Public Class OrderDocument
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Add5Days = New DevExpress.XtraReports.UI.CalculatedField()
			Me.Add3Days = New DevExpress.XtraReports.UI.CalculatedField()
			Me.Subtract1Day = New DevExpress.XtraReports.UI.CalculatedField()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2})
			Me.Detail.Height = 44
			Me.Detail.Name = "Detail"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Date", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(17, 0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Id", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(167, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xpCollection1
			' 
			Me.xpCollection1.ObjectType = GetType(XpoXtraReports.Order)
'			Me.xpCollection1.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollection1_ResolveSession);
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "Lines"
			Me.DetailReport.DataSource = Me.xpCollection1
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel4})
			Me.Detail1.Height = 45
			Me.Detail1.Name = "Detail1"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Lines.Item", "")})
			Me.xrLabel3.Location = New System.Drawing.Point(92, 8)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Lines.Cost", "")})
			Me.xrLabel4.Location = New System.Drawing.Point(225, 8)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel4.Text = "xrLabel4"
			' 
			' Add5Days
			' 
			Me.Add5Days.DataSource = Me.xpCollection1
			Me.Add5Days.Expression = "AddDays([Date],5 )"
			Me.Add5Days.Name = "Add5Days"
			' 
			' Add3Days
			' 
			Me.Add3Days.DataSource = Me.xpCollection1
			Me.Add3Days.Expression = "AddDays([Date],3 )"
			Me.Add3Days.Name = "Add3Days"
			' 
			' Subtract1Day
			' 
			Me.Subtract1Day.DataSource = Me.xpCollection1
			Me.Subtract1Day.Expression = "AddDays([Date],-1 )"
			Me.Subtract1Day.Name = "Subtract1Day"
			' 
			' OrderDocument
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.DetailReport})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.Add5Days, Me.Add3Days, Me.Subtract1Day})
			Me.DataSource = Me.xpCollection1
			Me.Version = "9.2"
			Me.XpoClassName = "XpoXtraReports.Order"
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents xpCollection1 As DevExpress.Xpo.XPCollection
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private Add5Days As DevExpress.XtraReports.UI.CalculatedField
		Private Add3Days As DevExpress.XtraReports.UI.CalculatedField
		Private Subtract1Day As DevExpress.XtraReports.UI.CalculatedField
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
