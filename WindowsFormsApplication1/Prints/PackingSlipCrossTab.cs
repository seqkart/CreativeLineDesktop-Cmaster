using System;
using System.Data;

namespace WindowsFormsApplication1.Prints
{
    public partial class PackingSlipCrossTab : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet  ds { get; set; }
        public PackingSlipCrossTab()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrAccName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
            xrCTName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
            xrSIDPONO.Text = ds.Tables[0].Rows[0]["SIDPONO"].ToString();
        }
    }
}
