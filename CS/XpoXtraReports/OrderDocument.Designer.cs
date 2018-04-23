namespace XpoXtraReports
{
    partial class OrderDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.Add5Days = new DevExpress.XtraReports.UI.CalculatedField();
            this.Add3Days = new DevExpress.XtraReports.UI.CalculatedField();
            this.Subtract1Day = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2});
            this.Detail.Height = 44;
            this.Detail.Name = "Detail";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Date", "")});
            this.xrLabel1.Location = new System.Drawing.Point(17, 0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(100, 25);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Id", "")});
            this.xrLabel2.Location = new System.Drawing.Point(167, 0);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(100, 25);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(XpoXtraReports.Order);
            this.xpCollection1.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.xpCollection1_ResolveSession);
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "Lines";
            this.DetailReport.DataSource = this.xpCollection1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4});
            this.Detail1.Height = 45;
            this.Detail1.Name = "Detail1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Lines.Item", "")});
            this.xrLabel3.Location = new System.Drawing.Point(92, 8);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(100, 25);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Lines.Cost", "")});
            this.xrLabel4.Location = new System.Drawing.Point(225, 8);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.Size = new System.Drawing.Size(100, 25);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // Add5Days
            // 
            this.Add5Days.DataSource = this.xpCollection1;
            this.Add5Days.Expression = "AddDays([Date],5 )";
            this.Add5Days.Name = "Add5Days";
            // 
            // Add3Days
            // 
            this.Add3Days.DataSource = this.xpCollection1;
            this.Add3Days.Expression = "AddDays([Date],3 )";
            this.Add3Days.Name = "Add3Days";
            // 
            // Subtract1Day
            // 
            this.Subtract1Day.DataSource = this.xpCollection1;
            this.Subtract1Day.Expression = "AddDays([Date],-1 )";
            this.Subtract1Day.Name = "Subtract1Day";
            // 
            // OrderDocument
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.DetailReport});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Add5Days,
            this.Add3Days,
            this.Subtract1Day});
            this.DataSource = this.xpCollection1;
            this.Version = "9.2";
            this.XpoClassName = "XpoXtraReports.Order";
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.CalculatedField Add5Days;
        private DevExpress.XtraReports.UI.CalculatedField Add3Days;
        private DevExpress.XtraReports.UI.CalculatedField Subtract1Day;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    }
}
