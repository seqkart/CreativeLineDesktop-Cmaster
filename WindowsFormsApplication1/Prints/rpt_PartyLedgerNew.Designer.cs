
namespace WindowsFormsApplication1.Prints
{
    partial class rpt_PartyLedgerNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_PartyLedgerNew));
            this.Area4 = new DevExpress.XtraReports.UI.DetailBand();
            this.txtVno = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_dr_show_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_cr_show_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_run_bal_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_date_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_Show_DRCR_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Field1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Field12 = new DevExpress.XtraReports.UI.XRLabel();
            this.Area2 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Text1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text3 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text2 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDateRange = new DevExpress.XtraReports.UI.XRLabel();
            this.Text7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Field18 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.txtCurentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.txtReportDate = new DevExpress.XtraReports.UI.XRLabel();
            this.Line1 = new DevExpress.XtraReports.UI.XRLine();
            this.Line2 = new DevExpress.XtraReports.UI.XRLine();
            this.Text4 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtReportName = new DevExpress.XtraReports.UI.XRLabel();
            this.prt_dr_show = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_cr_show = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_op_dr_bal = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_op_cr_bal = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_run_bal = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_sum_dr = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_sum_cr = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_net_bal = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_date = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_Show_DRCR = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_net_bal_DrCr = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_naration = new DevExpress.XtraReports.UI.CalculatedField();
            this.op_RuningBal = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_op_DrCr = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_line = new DevExpress.XtraReports.UI.CalculatedField();
            this.prt_OpBalText = new DevExpress.XtraReports.UI.CalculatedField();
            this.rpt_Total_text = new DevExpress.XtraReports.UI.CalculatedField();
            this.gSumAmt = new DevExpress.XtraReports.UI.CalculatedField();
            this.gSumAmtPrt = new DevExpress.XtraReports.UI.CalculatedField();
            this.gSumAmtFanda = new DevExpress.XtraReports.UI.CalculatedField();
            this.gSumAmtPrtDrCr = new DevExpress.XtraReports.UI.CalculatedField();
            this.cr_sDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Area4
            // 
            this.Area4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtVno,
            this.prt_dr_show_1,
            this.prt_cr_show_1,
            this.prt_run_bal_1,
            this.prt_date_1,
            this.prt_Show_DRCR_1,
            this.Field1,
            this.Field12});
            this.Area4.HeightF = 32.66668F;
            this.Area4.KeepTogether = true;
            this.Area4.Name = "Area4";
            this.Area4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Area4.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Table.LedgerPartyName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Area4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtVno
            // 
            this.txtVno.BackColor = System.Drawing.Color.Transparent;
            this.txtVno.BorderColor = System.Drawing.Color.Black;
            this.txtVno.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtVno.BorderWidth = 1F;
            this.txtVno.CanGrow = false;
            this.txtVno.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[VutNo]")});
            this.txtVno.Font = new System.Drawing.Font("Arial", 8F);
            this.txtVno.ForeColor = System.Drawing.Color.Black;
            this.txtVno.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
            this.txtVno.Name = "txtVno";
            this.txtVno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtVno.SizeF = new System.Drawing.SizeF(50F, 16.66667F);
            this.txtVno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // prt_dr_show_1
            // 
            this.prt_dr_show_1.BackColor = System.Drawing.Color.Transparent;
            this.prt_dr_show_1.BorderColor = System.Drawing.Color.Silver;
            this.prt_dr_show_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.prt_dr_show_1.BorderWidth = 1F;
            this.prt_dr_show_1.CanGrow = false;
            this.prt_dr_show_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[Debit]")});
            this.prt_dr_show_1.Font = new System.Drawing.Font("Arial", 8F);
            this.prt_dr_show_1.ForeColor = System.Drawing.Color.Black;
            this.prt_dr_show_1.LocationFloat = new DevExpress.Utils.PointFloat(416.6667F, 0F);
            this.prt_dr_show_1.Name = "prt_dr_show_1";
            this.prt_dr_show_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.prt_dr_show_1.SizeF = new System.Drawing.SizeF(83.33334F, 16.66667F);
            this.prt_dr_show_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // prt_cr_show_1
            // 
            this.prt_cr_show_1.BackColor = System.Drawing.Color.Transparent;
            this.prt_cr_show_1.BorderColor = System.Drawing.Color.Silver;
            this.prt_cr_show_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.prt_cr_show_1.BorderWidth = 1F;
            this.prt_cr_show_1.CanGrow = false;
            this.prt_cr_show_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[Credit]")});
            this.prt_cr_show_1.Font = new System.Drawing.Font("Arial", 8F);
            this.prt_cr_show_1.ForeColor = System.Drawing.Color.Black;
            this.prt_cr_show_1.LocationFloat = new DevExpress.Utils.PointFloat(508.3333F, 0F);
            this.prt_cr_show_1.Name = "prt_cr_show_1";
            this.prt_cr_show_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.prt_cr_show_1.SizeF = new System.Drawing.SizeF(100F, 16.66667F);
            this.prt_cr_show_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // prt_run_bal_1
            // 
            this.prt_run_bal_1.BackColor = System.Drawing.Color.Transparent;
            this.prt_run_bal_1.BorderColor = System.Drawing.Color.Silver;
            this.prt_run_bal_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.prt_run_bal_1.BorderWidth = 1F;
            this.prt_run_bal_1.CanGrow = false;
            this.prt_run_bal_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[Balance]")});
            this.prt_run_bal_1.Font = new System.Drawing.Font("Arial", 8F);
            this.prt_run_bal_1.ForeColor = System.Drawing.Color.Black;
            this.prt_run_bal_1.LocationFloat = new DevExpress.Utils.PointFloat(616.6667F, 0F);
            this.prt_run_bal_1.Name = "prt_run_bal_1";
            this.prt_run_bal_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.prt_run_bal_1.SizeF = new System.Drawing.SizeF(100F, 16.66667F);
            this.prt_run_bal_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // prt_date_1
            // 
            this.prt_date_1.BackColor = System.Drawing.Color.Transparent;
            this.prt_date_1.BorderColor = System.Drawing.Color.Black;
            this.prt_date_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.prt_date_1.BorderWidth = 1F;
            this.prt_date_1.CanGrow = false;
            this.prt_date_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[VutDate]")});
            this.prt_date_1.Font = new System.Drawing.Font("Arial", 8F);
            this.prt_date_1.ForeColor = System.Drawing.Color.Black;
            this.prt_date_1.LocationFloat = new DevExpress.Utils.PointFloat(0.6944444F, 0F);
            this.prt_date_1.Name = "prt_date_1";
            this.prt_date_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.prt_date_1.SizeF = new System.Drawing.SizeF(65.97222F, 16.66667F);
            this.prt_date_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // prt_Show_DRCR_1
            // 
            this.prt_Show_DRCR_1.BackColor = System.Drawing.Color.Transparent;
            this.prt_Show_DRCR_1.BorderColor = System.Drawing.Color.Black;
            this.prt_Show_DRCR_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.prt_Show_DRCR_1.BorderWidth = 1F;
            this.prt_Show_DRCR_1.CanGrow = false;
            this.prt_Show_DRCR_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[CRDR]")});
            this.prt_Show_DRCR_1.Font = new System.Drawing.Font("Arial", 8F);
            this.prt_Show_DRCR_1.ForeColor = System.Drawing.Color.Black;
            this.prt_Show_DRCR_1.LocationFloat = new DevExpress.Utils.PointFloat(725F, 0F);
            this.prt_Show_DRCR_1.Name = "prt_Show_DRCR_1";
            this.prt_Show_DRCR_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.prt_Show_DRCR_1.SizeF = new System.Drawing.SizeF(25F, 16.66667F);
            this.prt_Show_DRCR_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Field1
            // 
            this.Field1.BackColor = System.Drawing.Color.Transparent;
            this.Field1.BorderColor = System.Drawing.Color.Black;
            this.Field1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Field1.BorderWidth = 1F;
            this.Field1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[VutNart]")});
            this.Field1.Font = new System.Drawing.Font("Arial", 8F);
            this.Field1.ForeColor = System.Drawing.Color.Black;
            this.Field1.LocationFloat = new DevExpress.Utils.PointFloat(159.375F, 0F);
            this.Field1.Name = "Field1";
            this.Field1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Field1.SizeF = new System.Drawing.SizeF(254.5139F, 16.66667F);
            this.Field1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Field12
            // 
            this.Field12.BackColor = System.Drawing.Color.Transparent;
            this.Field12.BorderColor = System.Drawing.Color.Black;
            this.Field12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Field12.BorderWidth = 1F;
            this.Field12.CanGrow = false;
            this.Field12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[VutType]")});
            this.Field12.Font = new System.Drawing.Font("Arial", 8F);
            this.Field12.ForeColor = System.Drawing.Color.Black;
            this.Field12.LocationFloat = new DevExpress.Utils.PointFloat(66.66666F, 0F);
            this.Field12.Name = "Field12";
            this.Field12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Field12.SizeF = new System.Drawing.SizeF(25F, 16.66667F);
            this.Field12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Area2
            // 
            this.Area2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtCompanyName,
            this.Text1,
            this.Text3,
            this.Text2,
            this.Text5,
            this.txtDateRange,
            this.Text7,
            this.Field18,
            this.txtCurentDate,
            this.txtReportDate,
            this.Line1,
            this.Line2,
            this.Text4,
            this.txtReportName});
            this.Area2.HeightF = 151F;
            this.Area2.Name = "Area2";
            this.Area2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.BorderColor = System.Drawing.Color.Black;
            this.Text1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text1.BorderWidth = 1F;
            this.Text1.CanGrow = false;
            this.Text1.Font = new System.Drawing.Font("Arial", 10F);
            this.Text1.ForeColor = System.Drawing.Color.Black;
            this.Text1.LocationFloat = new DevExpress.Utils.PointFloat(425F, 125F);
            this.Text1.Name = "Text1";
            this.Text1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text1.SizeF = new System.Drawing.SizeF(75F, 15.97222F);
            this.Text1.Text = "Debit";
            this.Text1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.Transparent;
            this.Text3.BorderColor = System.Drawing.Color.Black;
            this.Text3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text3.BorderWidth = 1F;
            this.Text3.CanGrow = false;
            this.Text3.Font = new System.Drawing.Font("Arial", 10F);
            this.Text3.ForeColor = System.Drawing.Color.Black;
            this.Text3.LocationFloat = new DevExpress.Utils.PointFloat(516.6667F, 125F);
            this.Text3.Name = "Text3";
            this.Text3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text3.SizeF = new System.Drawing.SizeF(91.66666F, 15.97222F);
            this.Text3.Text = "Credit";
            this.Text3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Transparent;
            this.Text2.BorderColor = System.Drawing.Color.Black;
            this.Text2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text2.BorderWidth = 1F;
            this.Text2.CanGrow = false;
            this.Text2.Font = new System.Drawing.Font("Arial", 10F);
            this.Text2.ForeColor = System.Drawing.Color.Black;
            this.Text2.LocationFloat = new DevExpress.Utils.PointFloat(158.3333F, 125F);
            this.Text2.Name = "Text2";
            this.Text2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text2.SizeF = new System.Drawing.SizeF(91.66666F, 15.97222F);
            this.Text2.Text = "Narration";
            this.Text2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text5
            // 
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.BorderColor = System.Drawing.Color.Black;
            this.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text5.BorderWidth = 1F;
            this.Text5.CanGrow = false;
            this.Text5.Font = new System.Drawing.Font("Arial", 10F);
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 125F);
            this.Text5.Name = "Text5";
            this.Text5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text5.SizeF = new System.Drawing.SizeF(47.22222F, 15.97222F);
            this.Text5.Text = "Date";
            this.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCompanyName.BorderColor = System.Drawing.Color.Black;
            this.txtCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtCompanyName.BorderWidth = 1F;
            this.txtCompanyName.CanGrow = false;
            this.txtCompanyName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(71.16666F, 4.166667F);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCompanyName.SizeF = new System.Drawing.SizeF(641.6667F, 25F);
            this.txtCompanyName.Text = "Company Name";
            this.txtCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // txtDateRange
            // 
            this.txtDateRange.BackColor = System.Drawing.Color.Transparent;
            this.txtDateRange.BorderColor = System.Drawing.Color.Black;
            this.txtDateRange.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtDateRange.BorderWidth = 1F;
            this.txtDateRange.CanGrow = false;
            this.txtDateRange.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtDateRange.ForeColor = System.Drawing.Color.Black;
            this.txtDateRange.LocationFloat = new DevExpress.Utils.PointFloat(184.1875F, 75F);
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtDateRange.SizeF = new System.Drawing.SizeF(415.6251F, 17.70833F);
            this.txtDateRange.Text = "Date Range of Report...";
            this.txtDateRange.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Text7
            // 
            this.Text7.BackColor = System.Drawing.Color.Transparent;
            this.Text7.BorderColor = System.Drawing.Color.Black;
            this.Text7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text7.BorderWidth = 1F;
            this.Text7.CanGrow = false;
            this.Text7.Font = new System.Drawing.Font("Arial", 10F);
            this.Text7.ForeColor = System.Drawing.Color.Black;
            this.Text7.LocationFloat = new DevExpress.Utils.PointFloat(616.6667F, 125F);
            this.Text7.Name = "Text7";
            this.Text7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text7.SizeF = new System.Drawing.SizeF(100F, 15.97222F);
            this.Text7.Text = "Balance";
            this.Text7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Field18
            // 
            this.Field18.BackColor = System.Drawing.Color.Transparent;
            this.Field18.BorderColor = System.Drawing.Color.Black;
            this.Field18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Field18.BorderWidth = 1F;
            this.Field18.Font = new System.Drawing.Font("Arial", 10F);
            this.Field18.ForeColor = System.Drawing.Color.Black;
            this.Field18.LocationFloat = new DevExpress.Utils.PointFloat(632.2917F, 91.66666F);
            this.Field18.Name = "Field18";
            this.Field18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Field18.SizeF = new System.Drawing.SizeF(100F, 15.69444F);
            this.Field18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // txtCurentDate
            // 
            this.txtCurentDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCurentDate.BorderColor = System.Drawing.Color.Black;
            this.txtCurentDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtCurentDate.BorderWidth = 1F;
            this.txtCurentDate.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCurentDate.ForeColor = System.Drawing.Color.Black;
            this.txtCurentDate.LocationFloat = new DevExpress.Utils.PointFloat(75F, 92.22222F);
            this.txtCurentDate.Name = "txtCurentDate";
            this.txtCurentDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtCurentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.txtCurentDate.SizeF = new System.Drawing.SizeF(66.66666F, 14.58333F);
            this.txtCurentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // txtReportDate
            // 
            this.txtReportDate.BackColor = System.Drawing.Color.Transparent;
            this.txtReportDate.BorderColor = System.Drawing.Color.Black;
            this.txtReportDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtReportDate.BorderWidth = 1F;
            this.txtReportDate.CanGrow = false;
            this.txtReportDate.Font = new System.Drawing.Font("Arial", 9F);
            this.txtReportDate.ForeColor = System.Drawing.Color.Black;
            this.txtReportDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 91.52778F);
            this.txtReportDate.Name = "txtReportDate";
            this.txtReportDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtReportDate.SizeF = new System.Drawing.SizeF(66.66666F, 15.97222F);
            this.txtReportDate.Text = "Report Dt:";
            this.txtReportDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Transparent;
            this.Line1.BorderColor = System.Drawing.Color.Black;
            this.Line1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line1.BorderWidth = 1F;
            this.Line1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Line1.ForeColor = System.Drawing.Color.Black;
            this.Line1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 114.5833F);
            this.Line1.Name = "Line1";
            this.Line1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Line1.SizeF = new System.Drawing.SizeF(783F, 4.125023F);
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            this.Line2.BorderColor = System.Drawing.Color.Black;
            this.Line2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line2.BorderWidth = 1F;
            this.Line2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Line2.ForeColor = System.Drawing.Color.Black;
            this.Line2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 146.875F);
            this.Line2.Name = "Line2";
            this.Line2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Line2.SizeF = new System.Drawing.SizeF(783F, 4.125015F);
            // 
            // Text4
            // 
            this.Text4.BackColor = System.Drawing.Color.Transparent;
            this.Text4.BorderColor = System.Drawing.Color.Black;
            this.Text4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text4.BorderWidth = 1F;
            this.Text4.CanGrow = false;
            this.Text4.Font = new System.Drawing.Font("Arial", 10F);
            this.Text4.ForeColor = System.Drawing.Color.Black;
            this.Text4.LocationFloat = new DevExpress.Utils.PointFloat(66.66666F, 125F);
            this.Text4.Name = "Text4";
            this.Text4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Text4.SizeF = new System.Drawing.SizeF(83.33334F, 15.97222F);
            this.Text4.Text = "V.Type & No.";
            this.Text4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.Text4.Visible = false;
            // 
            // txtReportName
            // 
            this.txtReportName.BackColor = System.Drawing.Color.Transparent;
            this.txtReportName.BorderColor = System.Drawing.Color.Black;
            this.txtReportName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.txtReportName.BorderWidth = 1F;
            this.txtReportName.CanGrow = false;
            this.txtReportName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtReportName.ForeColor = System.Drawing.Color.Black;
            this.txtReportName.LocationFloat = new DevExpress.Utils.PointFloat(71.16666F, 29.16667F);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.txtReportName.SizeF = new System.Drawing.SizeF(641.6667F, 17.70833F);
            this.txtReportName.Text = "Header of Report";
            this.txtReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // prt_dr_show
            // 
            this.prt_dr_show.DataMember = "ado";
            this.prt_dr_show.Expression = "Iif([VutAmt] > 0, [VutAmt], null)";
            this.prt_dr_show.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_dr_show.Name = "prt_dr_show";
            // 
            // prt_cr_show
            // 
            this.prt_cr_show.DataMember = "ado";
            this.prt_cr_show.Expression = "Iif([VutAmt] < 0, Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([ado.VutAmt])\'), null)";
            this.prt_cr_show.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_cr_show.Name = "prt_cr_show";
            // 
            // prt_op_dr_bal
            // 
            this.prt_op_dr_bal.DataMember = "ado";
            this.prt_op_dr_bal.Expression = "Iif([opbal] > 0, [opbal], 0)";
            this.prt_op_dr_bal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_op_dr_bal.Name = "prt_op_dr_bal";
            // 
            // prt_op_cr_bal
            // 
            this.prt_op_cr_bal.DataMember = "ado";
            this.prt_op_cr_bal.Expression = "Iif([opbal] < 0, Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([ado.opbal])\'), null)";
            this.prt_op_cr_bal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_op_cr_bal.Name = "prt_op_cr_bal";
            // 
            // prt_run_bal
            // 
            this.prt_run_bal.DataMember = "ado";
            this.prt_run_bal.Expression = "Iif([opbal] Is Null, Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([#RTotal0])\'), True, \'#N" +
    "OT_SUPPORTED#\', \'[abs]([#RTotal0] + [ado.opbal])\')";
            this.prt_run_bal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_run_bal.Name = "prt_run_bal";
            // 
            // prt_sum_dr
            // 
            this.prt_sum_dr.DataMember = "ado";
            this.prt_sum_dr.Expression = "Iif([prt_op_dr_bal] Is Null, [][[AccName] = [^.ado.AccName]].Sum([prt_dr_show]), " +
    "[][[AccName] = [^.ado.AccName]].Sum([prt_dr_show]) + [prt_op_dr_bal])";
            this.prt_sum_dr.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_sum_dr.Name = "prt_sum_dr";
            // 
            // prt_sum_cr
            // 
            this.prt_sum_cr.DataMember = "ado";
            this.prt_sum_cr.Expression = "Iif([prt_op_cr_bal] Is Null, [][[AccName] = [^.ado.AccName]].Sum([prt_cr_show]), " +
    "[][[AccName] = [^.ado.AccName]].Sum([prt_cr_show]) + [prt_op_cr_bal])";
            this.prt_sum_cr.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_sum_cr.Name = "prt_sum_cr";
            // 
            // prt_net_bal
            // 
            this.prt_net_bal.DataMember = "ado";
            this.prt_net_bal.Expression = "Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([][[ado.AccName] = [^.ado.AccName]].Sum([prt_" +
    "dr_show]) - [][[ado.AccName] = [^.ado.AccName]].Sum([prt_cr_show]))\')";
            this.prt_net_bal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.prt_net_bal.Name = "prt_net_bal";
            // 
            // prt_date
            // 
            this.prt_date.DataMember = "ado";
            this.prt_date.Expression = "VutDate";
            this.prt_date.FieldType = DevExpress.XtraReports.UI.FieldType.DateTime;
            this.prt_date.Name = "prt_date";
            // 
            // prt_Show_DRCR
            // 
            this.prt_Show_DRCR.DataMember = "ado";
            this.prt_Show_DRCR.Expression = "Iif([#RTotal0] + [opbal] > 0, \'Dr\', [#RTotal0] + [opbal] < 0, \'Cr\', [#RTotal0] + " +
    "[opbal] = 0, \'Nil\', null)";
            this.prt_Show_DRCR.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_Show_DRCR.Name = "prt_Show_DRCR";
            // 
            // prt_net_bal_DrCr
            // 
            this.prt_net_bal_DrCr.DataMember = "ado";
            this.prt_net_bal_DrCr.Expression = resources.GetString("prt_net_bal_DrCr.Expression");
            this.prt_net_bal_DrCr.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_net_bal_DrCr.Name = "prt_net_bal_DrCr";
            // 
            // prt_naration
            // 
            this.prt_naration.DataMember = "ado";
            this.prt_naration.Expression = "Trim([VutNart])";
            this.prt_naration.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_naration.Name = "prt_naration";
            // 
            // op_RuningBal
            // 
            this.op_RuningBal.DataMember = "ado";
            this.op_RuningBal.Expression = "Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([ado.opbal])\')";
            this.op_RuningBal.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.op_RuningBal.Name = "op_RuningBal";
            // 
            // prt_op_DrCr
            // 
            this.prt_op_DrCr.DataMember = "ado";
            this.prt_op_DrCr.Expression = "Iif([opbal] > 0, \'Dr\', [opbal] < 0, \'Cr\', null)";
            this.prt_op_DrCr.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_op_DrCr.Name = "prt_op_DrCr";
            // 
            // prt_line
            // 
            this.prt_line.DataMember = "ado";
            this.prt_line.Expression = resources.GetString("prt_line.Expression");
            this.prt_line.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_line.Name = "prt_line";
            // 
            // prt_OpBalText
            // 
            this.prt_OpBalText.DataMember = "ado";
            this.prt_OpBalText.Expression = "Iif(Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([ado.opbal])\') > 0, \'Op. BALANCE..\', null" +
    ")";
            this.prt_OpBalText.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.prt_OpBalText.Name = "prt_OpBalText";
            // 
            // rpt_Total_text
            // 
            this.rpt_Total_text.DataMember = "ado";
            this.rpt_Total_text.Expression = "Iif(Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([prt_sum_dr])\') > 0 Or Iif(True, \'#NOT_SU" +
    "PPORTED#\', \'[abs]([prt_sum_cr])\') > 0, \'Total\', null)";
            this.rpt_Total_text.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.rpt_Total_text.Name = "rpt_Total_text";
            // 
            // gSumAmt
            // 
            this.gSumAmt.DataMember = "ado";
            this.gSumAmt.Expression = "Iif(True, \'#NOT_SUPPORTED#\', \'numberVar gTotal := gTotal+(Sum ({@prt_dr_show}, {a" +
    "do.AccName}))-(Sum ({@prt_cr_show}, {ado.AccName}));\')";
            this.gSumAmt.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.gSumAmt.Name = "gSumAmt";
            // 
            // gSumAmtPrt
            // 
            this.gSumAmtPrt.DataMember = "ado";
            this.gSumAmtPrt.Expression = "Iif(True, \'#NOT_SUPPORTED#\', \'[abs]([gSumAmt] - [gSumAmtFanda])\')";
            this.gSumAmtPrt.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.gSumAmtPrt.Name = "gSumAmtPrt";
            // 
            // gSumAmtFanda
            // 
            this.gSumAmtFanda.DataMember = "ado";
            this.gSumAmtFanda.Expression = "Iif(True, \'#NOT_SUPPORTED#\', \'numberVar fTotal := (Sum ({@prt_dr_show}, {ado.AccN" +
    "ame}))-(Sum ({@prt_cr_show}, {ado.AccName}));\')";
            this.gSumAmtFanda.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.gSumAmtFanda.Name = "gSumAmtFanda";
            // 
            // gSumAmtPrtDrCr
            // 
            this.gSumAmtPrtDrCr.DataMember = "ado";
            this.gSumAmtPrtDrCr.Expression = "Iif([gSumAmt] - [gSumAmtFanda] < 0, \'Cr\', [gSumAmt] - [gSumAmtFanda] > 0, \'Dr\', \'" +
    " \')";
            this.gSumAmtPrtDrCr.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.gSumAmtPrtDrCr.Name = "gSumAmtPrtDrCr";
            // 
            // cr_sDate
            // 
            this.cr_sDate.Description = null;
            this.cr_sDate.Name = "cr_sDate";
            this.cr_sDate.Type = typeof(System.DateTime);
            this.cr_sDate.Visible = false;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 17F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel44});
            this.bottomMarginBand1.HeightF = 17.00002F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.GroupHeader1.HeightF = 25.33333F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table].[LedgerPartyName]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(265F, 23F);
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel44
            // 
            this.xrLabel44.CanGrow = false;
            this.xrLabel44.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(533.1772F, 0F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(250.8227F, 17.00002F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "Powered by SEQKART SOLUTIONS";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel44.WordWrap = false;
            // 
            // rpt_PartyLedgerNew
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Area4,
            this.Area2,
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.prt_dr_show,
            this.prt_cr_show,
            this.prt_op_dr_bal,
            this.prt_op_cr_bal,
            this.prt_run_bal,
            this.prt_sum_dr,
            this.prt_sum_cr,
            this.prt_net_bal,
            this.prt_date,
            this.prt_Show_DRCR,
            this.prt_net_bal_DrCr,
            this.prt_naration,
            this.op_RuningBal,
            this.prt_op_DrCr,
            this.prt_line,
            this.prt_OpBalText,
            this.rpt_Total_text,
            this.gSumAmt,
            this.gSumAmtPrt,
            this.gSumAmtFanda,
            this.gSumAmtPrtDrCr});
            this.DataSourceSchema = resources.GetString("$this.DataSourceSchema");
            this.Margins = new System.Drawing.Printing.Margins(18, 25, 17, 17);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.cr_sDate});
            this.Version = "21.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Area4;
        private DevExpress.XtraReports.UI.XRLabel txtVno;
        private DevExpress.XtraReports.UI.XRLabel prt_dr_show_1;
        private DevExpress.XtraReports.UI.XRLabel prt_cr_show_1;
        private DevExpress.XtraReports.UI.XRLabel prt_run_bal_1;
        private DevExpress.XtraReports.UI.XRLabel prt_date_1;
        private DevExpress.XtraReports.UI.XRLabel prt_Show_DRCR_1;
        private DevExpress.XtraReports.UI.XRLabel Field1;
        private DevExpress.XtraReports.UI.XRLabel Field12;
        private DevExpress.XtraReports.UI.PageHeaderBand Area2;
        private DevExpress.XtraReports.UI.XRLabel Text1;
        private DevExpress.XtraReports.UI.XRLabel Text3;
        private DevExpress.XtraReports.UI.XRLabel Text2;
        private DevExpress.XtraReports.UI.XRLabel Text5;
        private DevExpress.XtraReports.UI.XRLabel Text7;
        private DevExpress.XtraReports.UI.XRPageInfo Field18;
        private DevExpress.XtraReports.UI.XRPageInfo txtCurentDate;
        private DevExpress.XtraReports.UI.XRLabel txtReportDate;
        private DevExpress.XtraReports.UI.XRLine Line1;
        private DevExpress.XtraReports.UI.XRLine Line2;
        private DevExpress.XtraReports.UI.XRLabel Text4;
        private DevExpress.XtraReports.UI.CalculatedField prt_dr_show;
        private DevExpress.XtraReports.UI.CalculatedField prt_cr_show;
        private DevExpress.XtraReports.UI.CalculatedField prt_op_dr_bal;
        private DevExpress.XtraReports.UI.CalculatedField prt_op_cr_bal;
        private DevExpress.XtraReports.UI.CalculatedField prt_run_bal;
        private DevExpress.XtraReports.UI.CalculatedField prt_sum_dr;
        private DevExpress.XtraReports.UI.CalculatedField prt_sum_cr;
        private DevExpress.XtraReports.UI.CalculatedField prt_net_bal;
        private DevExpress.XtraReports.UI.CalculatedField prt_date;
        private DevExpress.XtraReports.UI.CalculatedField prt_Show_DRCR;
        private DevExpress.XtraReports.UI.CalculatedField prt_net_bal_DrCr;
        private DevExpress.XtraReports.UI.CalculatedField prt_naration;
        private DevExpress.XtraReports.UI.CalculatedField op_RuningBal;
        private DevExpress.XtraReports.UI.CalculatedField prt_op_DrCr;
        private DevExpress.XtraReports.UI.CalculatedField prt_line;
        private DevExpress.XtraReports.UI.CalculatedField prt_OpBalText;
        private DevExpress.XtraReports.UI.CalculatedField rpt_Total_text;
        private DevExpress.XtraReports.UI.CalculatedField gSumAmt;
        private DevExpress.XtraReports.UI.CalculatedField gSumAmtPrt;
        private DevExpress.XtraReports.UI.CalculatedField gSumAmtFanda;
        private DevExpress.XtraReports.UI.CalculatedField gSumAmtPrtDrCr;
        private DevExpress.XtraReports.Parameters.Parameter cr_sDate;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        public DevExpress.XtraReports.UI.XRLabel txtCompanyName;
        public DevExpress.XtraReports.UI.XRLabel txtDateRange;
        public DevExpress.XtraReports.UI.XRLabel txtReportName;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
    }
}
