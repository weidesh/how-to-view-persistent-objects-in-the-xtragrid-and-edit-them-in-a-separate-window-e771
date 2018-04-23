Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Friend Class Program

    <STAThread()> _
    Shared Sub Main()
        InitDAL()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FormViewOrders())
    End Sub

    Private Shared Sub InitDAL()
        Dim conn As String = AccessConnectionProvider.GetConnectionString("ApplicationData.mdb")
        XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema)
        XpoDefault.Session = Nothing
    End Sub

End Class