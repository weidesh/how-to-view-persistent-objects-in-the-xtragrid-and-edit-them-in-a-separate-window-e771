using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace XpoEditForm {
    public partial class FormViewOrders : Form {
        public FormViewOrders() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // New
            EditOrder(null);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Edit
            EditOrder(gridView1.FocusedRowHandle);
        }

        private void EditOrder(int rowHandle) {
            if(rowHandle < 0) return;
            Order theOrder = (Order)gridView1.GetRow(rowHandle);
            EditOrder(theOrder);
        }

        private void EditOrder(Order theOrder) {
            using(FormEditOrder contactForm = new FormEditOrder(theOrder, xpCollection1)) {
                contactForm.ShowDialog(this);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Delete
            if(gridView1.FocusedRowHandle < 0) return;
            if(MessageBox.Show("Delete selected order?", "Confirm deletion", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                gridView1.DeleteSelectedRows();
                if(unitOfWork1.InTransaction)
                    unitOfWork1.CommitChanges();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e) {
            Point pt = gridControl1.PointToClient(MousePosition);
            GridHitInfo hitInfo = gridView1.CalcHitInfo(pt);
            if(hitInfo.InRow)
                EditOrder(hitInfo.RowHandle);
        }
    }
}