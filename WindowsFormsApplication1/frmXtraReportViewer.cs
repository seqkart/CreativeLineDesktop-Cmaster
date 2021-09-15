using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmXtraReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public FrmXtraReportViewer()
        {
            InitializeComponent();
        }

        private void PrintPreviewRibbonPageGroup2_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

        }

        private void PrintPreviewBarItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //printPreviewBarItem8.PerformClick();
            //this.Close();
        }

        private void FrmXtraReportViewer_Load(object sender, EventArgs e)
        {

            //this.Close();
        }

        private void FrmXtraReportViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //printPreviewBarItem8.PerformClick();
        }

        private void PrintPreviewBarItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}