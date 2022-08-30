using DevExpress.XtraReports.UI;
using System;
namespace WindowsFormsApplication1.FormReports
{
    public partial class PrintReportViewer : DevExpress.XtraEditors.XtraForm
    {

        public string PkInstalledPrinters { get; set; }
        public PrintReportViewer()
        {
            InitializeComponent();
        }

        private void PrintReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                PkInstalledPrinters = ProjectFunctions.GetDataSet("Select ProgPrinterName from ProgramMaster Where ProgCode='" + GlobalVariables.ProgCode + "'").Tables[0].Rows[0]["ProgPrinterName"].ToString();
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void PrintPreviewBarItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnPrint_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XtraReport rpt = new XtraReport();
                rpt = (XtraReport)documentViewer1.DocumentSource;
                rpt.SaveLayoutToXml("C:\\Temp\\abc1.xml");
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                printTool.Print(PkInstalledPrinters);
                Close();
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void PrintPreviewBarItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}