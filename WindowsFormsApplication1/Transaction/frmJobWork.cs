using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApplication1.Transaction
{
    public partial class frmJobWork : DevExpress.XtraEditors.XtraForm
    {
        public frmJobWork()
        {
            InitializeComponent();
        }

        private void btnRecalculate_Click(object sender, EventArgs e)
        {

        }

        private void LoadMeasurementDataAsPerGroup()
        {
            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadMeasurementDataAsPerGroup '0001'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MeasurementGird.DataSource = ds.Tables[0];
                MeasurementGirdView.BestFitColumns();
            }
            else
            {
                MeasurementGird.DataSource = null;
                MeasurementGirdView.BestFitColumns();
            }
        }

        private void txtPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtPartyName.Text = string.Empty;
        }

        private void txtArtNo_EditValueChanged(object sender, EventArgs e)
        {
            txtArtID.Text = string.Empty;
            txtArtDesc.Text = string.Empty;
        }

        private void frmJobWork_Load(object sender, EventArgs e)
        {
            LoadMeasurementDataAsPerGroup();
        }

        private void txtArtNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtArtNo";
                if (txtArtNo.Text.Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode ");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGridView.BestFitColumns();
                        HelpGrid.Show();
                        HelpGrid.Focus();
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode Where ARTICLE.ARTNO='" + txtArtNo.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtArtNo.Text = ds.Tables[0].Rows[0]["ARTNO"].ToString();
                        txtArtID.Text = ds.Tables[0].Rows[0]["ARTSYSID"].ToString();
                        txtArtDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();
                        txtSampleWeight.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode ");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds1.Tables[0];
                            HelpGridView.BestFitColumns();
                            HelpGrid.Show();
                            HelpGrid.Focus();
                        }
                    }
                }
            }
        }

        private void HelpGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode==System.Windows.Forms.Keys.Escape)
            {
                HelpGrid.Visible = false;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow currentrow = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtArtNo")
            {
                txtArtNo.Text = currentrow["ARTNO"].ToString();
                txtArtID.Text = currentrow["ARTSYSID"].ToString();
                txtArtDesc.Text = currentrow["GrpSubDesc"].ToString();
                txtSampleWeight.Focus();
            }
            if (HelpGrid.Text == "txtBrandCode")
            {
                txtBrandCode.Text = currentrow["BRSYSID"].ToString();
                txtBrandName.Text = currentrow["BRNAME"].ToString();
                txtSampleSize.Focus();
            }
        }

        private void txtBrandCode_EditValueChanged(object sender, EventArgs e)
        {
            txtBrandName.Text = string.Empty;
        }

        private void txtBrandCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("select BRSYSID,BRNAME from BRANDS", " Where BRSYSID", txtBrandCode, txtBrandName, txtBrandCode, HelpGrid, HelpGridView, e);
        }
    }
}