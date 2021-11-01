using System.Data;


namespace DevExpress.XtraReports.Import.Import.PRINTS
{
    public partial class Challanoutward : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet Ds { get; set; }
        public Challanoutward()
        {
            InitializeComponent();
        }

        private void CHODMAINREM1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void CHODKGSTYPE1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void XrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void CHODARTNO1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void CHODDESC1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void CHODITEMN1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void Challanoutward_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtMainRemarks.Text = Ds.Tables[0].Rows[0]["MAINREMARKS"].ToString();
        }
    }
}
