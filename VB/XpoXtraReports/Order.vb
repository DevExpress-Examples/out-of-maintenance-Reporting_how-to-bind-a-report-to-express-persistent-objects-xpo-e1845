Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace XpoXtraReports

	Public Class Order
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
			Me.Date = DateTime.Now
		End Sub

		#Region "Properties"
		Private _Date As DateTime
		Private _Id As Integer
		Public Property [Date]() As DateTime
			Get
				Return Me._Date
			End Get
			Set(ByVal value As DateTime)
				SetPropertyValue(Of DateTime)("Date", Me._Date, value)
			End Set
		End Property
		Public Property Id() As Integer
			Get
				Return Me._Id
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("Id", Me._Id, value)
			End Set
		End Property
		#End Region 

		#Region "Property Lines (XPCollection)"
		<Association("Order-Lines", GetType(OrderLine)), Aggregated> _
		Public ReadOnly Property Lines() As XPCollection(Of OrderLine)
			Get
				Return GetCollection(Of OrderLine)("Lines")
			End Get
		End Property
		#End Region


	End Class
End Namespace