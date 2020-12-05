
namespace WindowsFormsApplication1.Prints
{
    partial class BOXLABEL
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOXLABEL));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.XRQTY = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCTName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSIDPONO = new DevExpress.XtraReports.UI.XRLabel();
            this.xrAccName = new DevExpress.XtraReports.UI.XRLabel();
            this.PSWSNO = new DevExpress.XtraReports.Parameters.Parameter();
            this.PSWSTOTBOXES = new DevExpress.XtraReports.Parameters.Parameter();
            this.FY = new DevExpress.XtraReports.Parameters.Parameter();
            this.UnitCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 7.833338F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 18F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1});
            this.ReportHeader.HeightF = 75.54164F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XRQTY
            // 
            this.XRQTY.CanGrow = false;
            this.XRQTY.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XRQTY.LocationFloat = new DevExpress.Utils.PointFloat(255.7917F, 194.8334F);
            this.XRQTY.Multiline = true;
            this.XRQTY.Name = "XRQTY";
            this.XRQTY.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XRQTY.SizeF = new System.Drawing.SizeF(196.875F, 45.91666F);
            this.XRQTY.StylePriority.UseFont = false;
            this.XRQTY.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrCTName
            // 
            this.xrCTName.CanGrow = false;
            this.xrCTName.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.xrCTName.LocationFloat = new DevExpress.Utils.PointFloat(3.833308F, 49.04162F);
            this.xrCTName.Multiline = true;
            this.xrCTName.Name = "xrCTName";
            this.xrCTName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCTName.SizeF = new System.Drawing.SizeF(583.5417F, 44.875F);
            this.xrCTName.StylePriority.UseFont = false;
            this.xrCTName.StylePriority.UseTextAlignment = false;
            this.xrCTName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrSIDPONO
            // 
            this.xrSIDPONO.CanGrow = false;
            this.xrSIDPONO.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrSIDPONO.LocationFloat = new DevExpress.Utils.PointFloat(211.1667F, 102.5F);
            this.xrSIDPONO.Multiline = true;
            this.xrSIDPONO.Name = "xrSIDPONO";
            this.xrSIDPONO.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrSIDPONO.SizeF = new System.Drawing.SizeF(340.625F, 40.70834F);
            this.xrSIDPONO.StylePriority.UseFont = false;
            // 
            // xrAccName
            // 
            this.xrAccName.CanGrow = false;
            this.xrAccName.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.xrAccName.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 3.54166F);
            this.xrAccName.Multiline = true;
            this.xrAccName.Name = "xrAccName";
            this.xrAccName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrAccName.SizeF = new System.Drawing.SizeF(587.5001F, 44.875F);
            this.xrAccName.StylePriority.UseFont = false;
            this.xrAccName.StylePriority.UseTextAlignment = false;
            this.xrAccName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PSWSNO
            // 
            this.PSWSNO.Name = "PSWSNO";
            // 
            // PSWSTOTBOXES
            // 
            this.PSWSTOTBOXES.Name = "PSWSTOTBOXES";
            this.PSWSTOTBOXES.Type = typeof(long);
            this.PSWSTOTBOXES.ValueInfo = "0";
            // 
            // FY
            // 
            this.FY.Name = "FY";
            // 
            // UnitCode
            // 
            this.UnitCode.Name = "UnitCode";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_SEQKARTNew_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_LoadPackingSLipPrint";
            queryParameter1.Name = "@PSWSNO";
            queryParameter1.Type = typeof(string);
            queryParameter2.Name = "@PSWSTOTBOXES";
            queryParameter2.Type = typeof(long);
            queryParameter2.ValueInfo = "0";
            queryParameter3.Name = "@FY";
            queryParameter3.Type = typeof(string);
            queryParameter4.Name = "@UnitCode";
            queryParameter4.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.StoredProcName = "sp_LoadPackingSLipPrint";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1,
            this.xrLabel3,
            this.xrLabel6,
            this.xrAccName,
            this.xrSIDPONO,
            this.xrCTName,
            this.XRQTY});
            this.PageHeader.HeightF = 249.4167F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(21.70834F, 5.124998F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(126.3334F, 32.375F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "PS No. :";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PSWSNO")});
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(156.75F, 5.124998F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(130.2084F, 32.375F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(24.08332F, 38.45833F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(123.9584F, 32.375F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "BOX No.:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PSWSTOTBOXES")});
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(156.75F, 38.45833F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(130.2084F, 32.375F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel6
            // 
            this.xrLabel6.CanGrow = false;
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(15.33333F, 102.5F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(127.0834F, 40.70834F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "PO No.:";
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(18.45833F, 194.8334F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(183.3334F, 45.91666F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "TOTAL QTY:";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReportItems.xrSIDPONO].[Text]")});
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(103.125F, 143.5834F);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 96F);
            this.xrBarCode1.ShowText = false;
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(369.7917F, 43.75F);
            this.xrBarCode1.Symbology = code128Generator1;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(291.5001F, 19.70833F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(123.9584F, 32.375F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "WEIGHT:";
            // 
            // BOXLABEL
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 8, 18);
            this.PageHeight = 400;
            this.PageWidth = 600;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "4*6";
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.PSWSNO,
            this.PSWSTOTBOXES,
            this.FY,
            this.UnitCode});
            this.PrinterName = "ZDesigner TLP 2844 (Copy 1) (redirected 1)";
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None;
            this.Version = "20.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.BOXLABEL_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrSIDPONO;
        private DevExpress.XtraReports.UI.XRLabel xrAccName;
        private DevExpress.XtraReports.UI.XRLabel xrCTName;
        private DevExpress.XtraReports.Parameters.Parameter PSWSNO;
        private DevExpress.XtraReports.Parameters.Parameter PSWSTOTBOXES;
        private DevExpress.XtraReports.Parameters.Parameter FY;
        private DevExpress.XtraReports.Parameters.Parameter UnitCode;
        private DevExpress.XtraReports.UI.XRLabel XRQTY;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    }
}
