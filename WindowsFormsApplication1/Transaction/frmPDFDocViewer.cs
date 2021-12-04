using DevExpress.Pdf;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmPDFDocViewer : DevExpress.XtraEditors.XtraForm
    {
        public String DocType { get; set; }
        public String DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public frmPDFDocViewer()
        {
            InitializeComponent();
        }


        private void fillDocsGrid()
        {
            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument();
                DataSet ds = ProjectFunctions.GetDataSet("Select * from ImagesData Where DocNo='" + DocNo + "' And DocType= '" + DocType + "' And DocDate='" + DocDate.Date.ToString("yyyy-MM-dd") + "' order by transid desc");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (dr["DocPDF"].ToString().Trim().Length > 0)
                        {
                            Byte[] MyData = new byte[0];
                            MyData = (Byte[])dr["DocPDF"];
                            MemoryStream stream = new MemoryStream(MyData);
                            stream.Position = 0;
                            pdfDocumentProcessor.AppendDocument(stream);
                        }
                    }
                }
                pdfDocumentProcessor.SaveDocument("C:\\Temp\\abc.pdf");
                pdfDocumentProcessor.CloseDocument();
                pdfViewer1.LoadDocument("C:\\Temp\\abc.pdf");
            }
        }
        private void FrmPDFDocViewer_Load(object sender, EventArgs e)
        {
            fillDocsGrid();
        }

        private void FrmPDFDocViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfViewer1.CloseDocument();

        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pdfViewer1.CloseDocument();
            this.Close();
        }
    }
}