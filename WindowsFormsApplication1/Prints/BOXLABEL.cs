using System;
using System.Data;

namespace WindowsFormsApplication1.Prints
{
    public partial class BOXLABEL : DevExpress.XtraReports.UI.XtraReport
    {
        public DataSet Ds { get; set; }
        public BOXLABEL()
        {
            InitializeComponent();
        }

        private void BOXLABEL_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrAccName.Text = Ds.Tables[0].Rows[0]["AccName"].ToString();
            xrCTName.Text = Ds.Tables[0].Rows[0]["CTNAME"].ToString() + " - ZIP: " + Ds.Tables[0].Rows[0]["AccZipCode"].ToString();
            xrSIDPONO.Text = Ds.Tables[0].Rows[0]["SIDPONO"].ToString();
            object sumTotal;
            sumTotal = Ds.Tables[0].Compute("Sum(SIDSCANQTY)", string.Empty);
            XRQTY.Text = Convert.ToDecimal(sumTotal).ToString("0.00") + " PCS";

        }
    }
}
