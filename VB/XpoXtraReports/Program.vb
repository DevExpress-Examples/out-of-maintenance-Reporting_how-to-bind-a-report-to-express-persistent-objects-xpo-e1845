Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo

Namespace XpoXtraReports
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			InitDAL()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		Public Shared Sub InitDAL()
			Dim [cstr] As String = AccessConnectionProvider.GetConnectionString("database.mdb")
			XpoDefault.DataLayer = XpoDefault.GetDataLayer([cstr], AutoCreateOption.DatabaseAndSchema)
			DevExpress.Xpo.XpoDefault.Session = Nothing
		End Sub

	End Class
End Namespace
