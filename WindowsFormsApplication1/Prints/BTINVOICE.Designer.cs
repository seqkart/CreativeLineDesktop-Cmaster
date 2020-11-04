namespace WindowsFormsApplication1.Prints
{
    partial class BTINVOICE
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrCharacterComb1 = new DevExpress.XtraReports.UI.XRCharacterComb();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCharacterComb1,
            this.xrSubreport1});
            this.Detail.Name = "Detail";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(172F, 32.24999F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // xrCharacterComb1
            // 
            this.xrCharacterComb1.LocationFloat = new DevExpress.Utils.PointFloat(339.7083F, 19.79167F);
            this.xrCharacterComb1.Multiline = true;
            this.xrCharacterComb1.Name = "xrCharacterComb1";
            this.xrCharacterComb1.SizeF = new System.Drawing.SizeF(200F, 80F);
            this.xrCharacterComb1.Text = "xrCharacterComb1";
            // 
            // BTINVOICE
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.DrawGrid = false;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(28, 36, 100, 100);
            this.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None;
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCharacterComb xrCharacterComb1;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
    }
}
