using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using System.Reflection;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.XtraReports.UserDesigner;
using System.ComponentModel.Design;

namespace XpoXtraReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.CreateData();
        }
        private void CreateData() {
            Random rnd = new Random();
            using (UnitOfWork uow = new UnitOfWork()) {
                for (int i = 0; i < 5; i++) {
                    Order ord = new Order(uow);
                    ord.Date = DateTime.Now.AddDays(rnd.Next(1, 10));
                    ord.Id = i;
                    for (int j = 0; j < 4; j++) {
                        OrderLine ol = new OrderLine(uow);
                        ol.Item = string.Format("Item # {0}", j + 1);
                        ol.Cost = Convert.ToDecimal(rnd.NextDouble() * 100);
                        ord.Lines.Add(ol);
                    }
                }
                uow.CommitChanges();
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            OrderDocument od = new OrderDocument();
            od.SaveLayout("Report.repx");
        }
        private void btnSave_Click(object sender, EventArgs e) {
            OrderDocument od = new OrderDocument();
            od.SaveLayout("Report.repx");
        }
        private void btnDesign_Click(object sender, EventArgs e) {
            if (File.Exists("Report.repx")) {
                XtraReport report = XtraReport.FromFile("Report.repx", true);
                XRDesignRibbonFormEx designer = new XRDesignRibbonFormEx();
                designer.DesignPanel.Activated += new EventHandler(DesignPanel_Activated);
                designer.OpenReport(report);
                designer.Show();
            }
        }
        private void btnPreview_Click(object sender, EventArgs e) {
            if (File.Exists("Report.repx")) {
                XtraReport report = XtraReport.FromFile("Report.repx", true);
                report.ShowPreview();
            }
        }
        void DesignPanel_Activated(object sender, EventArgs e) {
            XtraReport report = ((XRDesignPanel)sender).Report;
            if (report is XpoBaseReport) {
                IComponentChangeService svc = ((XRDesignPanel)sender).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
                svc.OnComponentChanged(report, null, null, null);
            }
        }
    }
}
