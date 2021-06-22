using System.Data;

namespace WindowsFormsApplication1.Prints
{
    public partial class PackingSlipCrossTab : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet Ds { get; set; }
        public PackingSlipCrossTab()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrAccName.Text = Ds.Tables[0].Rows[0]["AccName"].ToString();
            xrCTName.Text = Ds.Tables[0].Rows[0]["CTNAME"].ToString();
            xrSIDPONO.Text = Ds.Tables[0].Rows[0]["SIDPONO"].ToString();
        }
    }
}
