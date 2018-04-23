using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace XpoEditForm {
    public partial class FormEditOrder : Form {
        private Order sourceOrder, theOrder;
        private readonly XPCollection sourceCollection;

        public FormEditOrder(Order order, XPCollection collection) {
            sourceOrder = order;
            sourceCollection = collection;

            InitializeComponent();

            if(sourceOrder == null)
                theOrder = new Order(unitOfWork1);
            else
                theOrder = unitOfWork1.GetObjectByKey<Order>(sourceOrder.Oid);

            xpCollection1.Add(theOrder);
            gridControlOrderDetails.DataSource = theOrder.OrderDetails;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            gridView1.UpdateCurrentRow();
            BindingContext[xpCollection1].EndCurrentEdit();

            if(unitOfWork1.InTransaction) {
                unitOfWork1.CommitChanges();
                if(sourceOrder == null)
                    sourceCollection.Reload();
                else
                    sourceOrder.Reload();
            }
            Close();
        }
    }
}