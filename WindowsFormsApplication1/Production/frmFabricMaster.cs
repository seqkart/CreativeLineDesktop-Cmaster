using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Production
{
    public partial class FrmFabricMaster : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string FabricCode { get; set; }
        public FrmFabricMaster()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtFabricContent.Properties.MaxLength = 100;
            txtFabricLotNo.Properties.MaxLength = 100;
            txtFabricCode.Enabled = false;
        }

        private string GetNewFabricCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(FabricCode as int)),000000) from FabricMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private bool ValidateData()
        {
            if (txtFabricCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricCode.Focus();
                return false;
            }
            if (txtFabricContent.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Content", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricContent.Focus();
                return false;
            }
            if (txtFabricLotNo.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Lot No", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricLotNo.Focus();
                return false;
            }
            if (txtFabricTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Type", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricTypeCode.Focus();
                return false;
            }
            if (txtFabricTypeDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Type", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricTypeDesc.Focus();
                return false;
            }
            if (txtColorCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Color Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtColorCode.Focus();
                return false;
            }
            if (txtColorName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Color Name", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtColorName.Focus();
                return false;
            }

            return true;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtYarnTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            txtFabricTypeDesc.Text = String.Empty;
        }

        private void TxtYarnTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select FabricTypeCode,FabricTypeName from FabricTypeMst", " Where FabricTypeCode", txtFabricTypeCode, txtFabricTypeDesc, txtFabricContent, HelpGrid, HelpGridView, e);
        }

        private void TxtColorCode_EditValueChanged(object sender, EventArgs e)
        {
            txtColorName.Text = string.Empty;

        }

        private void TxtColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("select COLSYSID,COLNAME from COLOURS", " Where COLSYSID", txtColorCode, txtColorName, txtColorCode, HelpGrid, HelpGridView, e);
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtFabricTypeCode")
            {
                txtFabricTypeCode.Text = row["FabricTypeCode"].ToString();
                txtFabricTypeDesc.Text = row["FabricTypeName"].ToString();
                HelpGrid.Visible = false;
                txtFabricContent.Focus();
            }
            if (HelpGrid.Text == "txtColorCode")
            {
                txtColorCode.Text = row["COLSYSID"].ToString();
                txtColorName.Text = row["COLNAME"].ToString();
                HelpGrid.Visible = false;
                txtColorCode.Focus();
            }
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                HelpGrid.Visible = false;
            }
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    var transaction = sqlcon.BeginTransaction("SaveTransaction");
                    sqlcom.Connection = sqlcon;
                    sqlcom.Transaction = transaction;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        if (S1 == "&Add")
                        {
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into FabricMst"
                                                    + " (FabricCode,FabricContent,FabricTypeCode,FabricLotNo,FabricColorID)"
                                                    + " values((SELECT RIGHT('000000'+ CAST( ISNULL( max(Cast(FabricCode as int)),0)+1 AS VARCHAR(6)),6)from FabricMst),@FabricContent,@FabricTypeCode,@FabricLotNo,@FabricColorID )"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE FabricMst SET "
                                                + " FabricContent=@FabricContent,FabricTypeCode=@FabricTypeCode, FabricLotNo=@FabricLotNo,FabricColorID=@FabricColorID"
                                                + " Where FabricCode=@FabricCode";

                        }
                        sqlcom.Parameters.AddWithValue("@FabricCode", txtFabricCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricContent", txtFabricContent.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricTypeCode", txtFabricTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricLotNo", txtFabricLotNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricColorID", txtColorCode.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        XtraMessageBox.Show("Data Saved Successfully");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Something Wrong. \n I am going to Roll Back." + ex.Message, ex.GetType().ToString());
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            XtraMessageBox.Show("Something Wrong. \n Roll Back Failed." + ex2.Message, ex2.GetType().ToString());
                        }
                    }
                }
            }
        }

        private void FrmYarnMaster_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtFabricContent.Focus();
                txtFabricCode.Text = GetNewFabricCode().PadLeft(6, '0');
            }
            if (S1 == "Edit")
            {
                txtFabricContent.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadFabricMstFEdit '" + FabricCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtFabricCode.Text = ds.Tables[0].Rows[0]["FabricCode"].ToString();
                    txtFabricContent.Text = ds.Tables[0].Rows[0]["FabricContent"].ToString();
                    txtFabricTypeCode.Text = ds.Tables[0].Rows[0]["FabricTypeCode"].ToString();
                    txtFabricTypeDesc.Text = ds.Tables[0].Rows[0]["FabricTypeName"].ToString();
                    txtFabricLotNo.Text = ds.Tables[0].Rows[0]["FabricLotNo"].ToString();
                    txtColorCode.Text = ds.Tables[0].Rows[0]["FabricColorID"].ToString();
                    txtColorName.Text = ds.Tables[0].Rows[0]["COLNAME"].ToString();

                    txtFabricTypeCode.Focus();
                }
            }
        }
    }
}