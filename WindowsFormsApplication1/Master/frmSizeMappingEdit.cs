using System;
using System.Data;
using System.Linq;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmSizeMappingEdit : DevExpress.XtraEditors.XtraForm
    {
        public String Transid { get; set; }


        public FrmSizeMappingEdit()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSizeMappingEdit_Load(object sender, EventArgs e)
        {
            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadSizeMappingFEdit '" + Transid + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtGrpCode.Text = ds.Tables[0].Rows[0]["GrpCode"].ToString();
                txtSGrpCode.Text = ds.Tables[0].Rows[0]["GrpSubCode"].ToString();
                txtSizeID.Text = ds.Tables[0].Rows[0]["SizeId"].ToString();
                txtSizeDesc.Text = ds.Tables[0].Rows[0]["SZNAME"].ToString();
                txtGrpDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                txtSGrpDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();
                txtTempSizeDesc.Text = ds.Tables[0].Rows[0]["SizeDesc"].ToString();
                txtTransID.Text = ds.Tables[0].Rows[0]["transid"].ToString();
                txtTempSizeDesc.Focus();

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ProjectFunctions.GetDataSet("update SizeMapping set  SizeDesc='" + txtTempSizeDesc.Text + "' where transid='" + Transid + "'   ");
            this.Close();
        }
    }
}