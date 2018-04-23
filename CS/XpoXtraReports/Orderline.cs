using System;
using DevExpress.Xpo;

namespace XpoXtraReports
{

    public class OrderLine : XPObject
    {
        public OrderLine(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }


        #region Property Order
        private Order _Order;
        [Association("Order-Lines", typeof(OrderLine))]
        public Order Order
        {
            get { return this._Order; }
            set { SetPropertyValue<Order>("Order", ref this._Order, value); }
        }
        #endregion 
        

        #region Properties
        private string _Item;
        private decimal _Cost;
        public string Item{
            get { return this._Item; }
            set { SetPropertyValue<string>("Item", ref this._Item, value); }
        }
        public decimal Cost {
            get { return this._Cost; }
            set { SetPropertyValue<decimal>("Cost", ref this._Cost, value); }
        }
        #endregion         
    }
}