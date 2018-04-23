Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo

Namespace XpoXtraReports
	Partial Public Class XpoBaseReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal session As Session)
			Me.New()
			_XpoSession = session
		End Sub

		Private Sub CreateDataSource()
			If XpoSession IsNot Nothing Then
				Dim xpoType As Type = Type.GetType(XpoClassName, True)
				Me.DataSource = New XPCollection(XpoSession, XpoSession.GetClassInfo(xpoType))
			End If
		End Sub

		Private _XpoSession As Session
		<Browsable(False)> _
		Public Property XpoSession() As Session
			Get
				Return _XpoSession
			End Get
			Set(ByVal value As Session)
				Me._XpoSession = value
				Me.CreateDataSource()
			End Set
		End Property

		<Browsable(False)> _
		Public ReadOnly Property Collection() As XPBaseCollection
			Get
				Return TryCast(Me.DataSource, XPBaseCollection)
			End Get
		End Property

		Private _XpoClassName As String
		Public Property XpoClassName() As String
			Get
				Return _XpoClassName
			End Get
			Set(ByVal value As String)
				If Me._XpoClassName <> value Then
					Me._XpoClassName = value
					Me.CreateDataSource()
				End If
			End Set
		End Property

		Protected Overrides Sub SerializeProperties(ByVal serializer As DevExpress.XtraReports.Serialization.XRSerializer)
			MyBase.SerializeProperties(serializer)
			serializer.SerializeString("XpoClassName", Me.XpoClassName)
		End Sub
		Protected Overrides Sub DeserializeProperties(ByVal serializer As DevExpress.XtraReports.Serialization.XRSerializer)
			MyBase.DeserializeProperties(serializer)
			Me.XpoClassName = serializer.DeserializeString("XpoClassName", "")
		End Sub
	End Class
End Namespace
