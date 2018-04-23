Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace XpoXtraReports

	Public Class OrderLine
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
			' This constructor is used when an object is loaded from a persistent storage.
			' Do not place any code here.
		End Sub

		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
			' Place here your initialization code.
		End Sub


		#Region "Property Order"
		Private _Order As Order
		<Association("Order-Lines", GetType(OrderLine))> _
		Public Property Order() As Order
			Get
				Return Me._Order
			End Get
			Set(ByVal value As Order)
				SetPropertyValue(Of Order)("Order", Me._Order, value)
			End Set
		End Property
		#End Region 


		#Region "Properties"
		Private _Item As String
		Private _Cost As Decimal
		Public Property Item() As String
			Get
				Return Me._Item
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Item", Me._Item, value)
			End Set
		End Property
		Public Property Cost() As Decimal
			Get
				Return Me._Cost
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("Cost", Me._Cost, value)
			End Set
		End Property
		#End Region         
	End Class
End Namespace