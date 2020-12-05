using System;
using System.Data;

namespace WindowsFormsApplication1.Prints
{
    public partial class BOXLABEL : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet ds { get; set; }
        public BOXLABEL()
        {
            InitializeComponent();
        }

        private void BOXLABEL_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrAccName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
            xrCTName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString() + " - ZIP: " + ds.Tables[0].Rows[0]["AccZipCode"].ToString();
            xrSIDPONO.Text = ds.Tables[0].Rows[0]["SIDPONO"].ToString();
            object sumTotal;
            sumTotal = ds.Tables[0].Compute("Sum(SIDSCANQTY)", "");
            XRQTY.Text = Convert.ToDecimal(sumTotal).ToString("0.00") + " PCS";

        }
    }
}
