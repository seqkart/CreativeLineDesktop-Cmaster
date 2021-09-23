using System;
namespace WindowsFormsApplication1
{
    public partial class Rpt_POORDER : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_POORDER()
        {
            InitializeComponent();
        }

        private void Rpt_ListofIndent_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          //  xrLabel1.Text = GlobalVariables.CompanyName;
           // xrLabel2.Text = String.Format("{0} {1} {2}", GlobalVariables.CAddress1, GlobalVariables.CAddress2, GlobalVariables.CAddress3);
        }
    }
}
