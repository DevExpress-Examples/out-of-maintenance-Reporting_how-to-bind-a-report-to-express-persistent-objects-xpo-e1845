using System;
using DevExpress.Xpo;

namespace XpoXtraReports
{

    public class Order : XPObject
    {
        public Order(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
            this.Date = DateTime.Now;
        }

        #region Properties
        private DateTime _Date;
        private int _Id;
        public DateTime Date{
            get { return this._Date; }
            set { SetPropertyValue<DateTime>("Date", ref this._Date, value); }
        }
        public int Id {
            get { return this._Id; }
            set { SetPropertyValue<int>("Id", ref this._Id, value); }
        }
        #endregion 

        #region Property Lines (XPCollection)
        [Association("Order-Lines", typeof(OrderLine)), Aggregated]
        public XPCollection<OrderLine> Lines
        {
            get { return GetCollection<OrderLine>("Lines"); }
        }
        #endregion
        
        
    }
}