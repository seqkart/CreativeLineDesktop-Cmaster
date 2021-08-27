namespace WindowsFormsApplication1.Prints
{
    public partial class GSTINVOICE : DevExpress.XtraReports.UI.XtraReport
    {
        public string VehicleNo { get; set; }
        public GSTINVOICE()
        {
            InitializeComponent();
        }

        private void GSTINVOICE_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            txtVendorCode.Text = GlobalVariables.VendorCode;
            // txtvehicleNo.Text = VehicleNo;



        }
    }
}

