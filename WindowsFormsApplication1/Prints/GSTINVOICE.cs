using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1.Prints
{
    public partial class GSTINVOICE : DevExpress.XtraReports.UI.XtraReport
    {
        public string VehicleNo { get; set; }
        public int PageCount { get; }
        public GSTINVOICE()
        {
            InitializeComponent();
        }

        private void GSTINVOICE_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            txtVendorCode.Text = GlobalVariables.VendorCode;
            // txtvehicleNo.Text = VehicleNo;
          //  GSTINVOICE.PrintingSystem.ContinuousPageNumbering = false;


        }

        private void XrPageInfo2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
        //    if (e.PageIndex + 1 < e.PageCount)
        //        e.PageIndex = e.PageIndex - 1;
        //}
        //    void ToBeContinueLabel_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //    {
        //        if (e.PageIndex + 1 < e.PageCount)
        //            ((XRLabel)sender).Text = "To be continued...";
        //        else
        //            ((XRLabel)sender).Text = "Your text for the last page";
        //    }


        }
        //private void XrPageInfo2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        //{
        //    if (e.PageCount > 1)

        //        ((XRPageInfo)sender).Visible = false;
        //}
        //private void SubBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{

        //}
    }
}

