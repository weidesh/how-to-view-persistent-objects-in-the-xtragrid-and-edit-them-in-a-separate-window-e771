using System;
using DevExpress.Xpo;

namespace XpoEditForm {
    public class Order : XPObject {
        public Order(Session session) : base(session) { }

        string fCustomer;
        public string Customer {
            get { return fCustomer; }
            set { SetPropertyValue("Customer", ref fCustomer, value); }
        }

        DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue("OrderDate", ref fOrderDate, value); }
        }

        [Association("Order-Details")]
        public XPCollection<OrderDetail> OrderDetails { get { return GetCollection<OrderDetail>("OrderDetails"); } }
    }

    public class OrderDetail : XPObject {
        public OrderDetail(Session session) : base(session) { }

        string fProductName;
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue("ProductName", ref fProductName, value); }
        }

        DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue("OrderDate", ref fOrderDate, value); }
        }

        int fQuantity;
        public int Quantity {
            get { return fQuantity; }
            set { SetPropertyValue("Quantity", ref fQuantity, value); }
        }

        decimal fPrice;
        public decimal Price {
            get { return fPrice; }
            set { SetPropertyValue("Price", ref fPrice, value); }
        }

        Order fOrder;
        [Association("Order-Details")]
        public Order Order {
            get { return fOrder; }
            set { SetPropertyValue("Order", ref fOrder, value); }
        }
    }
}
