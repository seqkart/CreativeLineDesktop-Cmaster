using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmAttachmentViewer : DevExpress.XtraEditors.XtraForm
    {
        public Int64 TransID { get; set; }
        public frmAttachmentViewer()
        {
            InitializeComponent();
        }

        private void FrmAttachmentViewer_Load(object sender, EventArgs e)
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select * from ImagesData Where Transid='" + TransID + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Byte[] MyData = new byte[0];
                MyData = (Byte[])ds.Tables[0].Rows[0]["DocImage"];
                MemoryStream stream = new MemoryStream(MyData);
                stream.Position = 0;

                pictureEdit1.Image = Image.FromStream(stream);
            }
        }
    }
}