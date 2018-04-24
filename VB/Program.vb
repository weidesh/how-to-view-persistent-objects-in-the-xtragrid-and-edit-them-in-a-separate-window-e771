Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace XpoEditForm
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        <STAThread> _
        Shared Sub Main()
            InitDAL()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New FormViewOrders())
        End Sub

        Private Shared Sub InitDAL()
            XpoDefault.DataLayer = XpoDefault.GetDataLayer("XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=E771", DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema)
            XpoDefault.Session = Nothing
        End Sub

    End Class
End Namespace