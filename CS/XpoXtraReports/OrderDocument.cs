using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;

namespace XpoXtraReports
{
    //[Report("0001","Order document",2)]
    public partial class OrderDocument : XpoXtraReports.XpoBaseReport
    {
        public OrderDocument()
        {
            InitializeComponent();
        }

        private void xpCollection1_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e) {
            if (e.Session == null)
                e.Session = new UnitOfWork();
        }

    }
}
