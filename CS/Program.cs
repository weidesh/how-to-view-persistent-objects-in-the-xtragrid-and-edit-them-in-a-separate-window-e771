using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace XpoEditForm {
    static class Program {
        [STAThread]
        static void Main() {
            InitDAL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormViewOrders());
        }

        private static void InitDAL() {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                                                   @"XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=E771",
                                                   DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema);
            XpoDefault.Session = null;
        }

    }
}