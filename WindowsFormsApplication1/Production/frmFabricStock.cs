using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Production
{
    public partial class frmFabricStock : DevExpress.XtraEditors.XtraForm
    {
        public string s1 { get; set; }
        public string FabricCode { get; set; }
        public frmFabricStock()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtFabricContent.Properties.MaxLength = 100;
            txtFabricLotNo.Properties.MaxLength = 100;
            txtFabricCode.Enabled = true;
            txtQty.Enabled = true;

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtYarnCode_EditValueChanged(object sender, EventArgs e)
        {
            txtFabricContent.Text = string.Empty;
            txtFabricLotNo.Text = string.Empty;
            txtFabricTypeCode.Text = string.Empty;
            txtFabricTypeDesc.Text = string.Empty;
            txtColorCode.Text = string.Empty;
            txtColorName.Text = string.Empty;
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
            if (txtQty.Text.Trim().Length == 0)
            {
                txtQty.Text = "0";
            }
            return true;
        }
        private void frmYarnStock_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (s1 == "&Add")
            {
                txtFabricCode.Focus();

            }
            if (s1 == "Edit")
            {
                txtFabricCode.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadFabricStockDataFEdit '" + FabricCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtFabricCode.Text = ds.Tables[0].Rows[0]["FabricCode"].ToString();
                    txtFabricContent.Text = ds.Tables[0].Rows[0]["FabricContent"].ToString();
                    txtFabricTypeCode.Text = ds.Tables[0].Rows[0]["FabricTypeCode"].ToString();
                    txtFabricTypeDesc.Text = ds.Tables[0].Rows[0]["FabricTypeName"].ToString();
                    txtFabricLotNo.Text = ds.Tables[0].Rows[0]["FabricLotNo"].ToString();
                    txtColorCode.Text = ds.Tables[0].Rows[0]["FabricColorID"].ToString();
                    txtColorName.Text = ds.Tables[0].Rows[0]["COLNAME"].ToString();
                    txtQty.Text = ds.Tables[0].Rows[0]["FabricStockQty"].ToString();

                    txtQty.Focus();

                }
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

        private void BtnSave_Click(object sender, EventArgs e)
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
                        if (s1 == "&Add")
                        {
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into FabricStockMst"
                                                    + " (FabricCode,FabricStockQty)"
                                                    + " values( @FabricCode,@FabricStockQty)"
                                                    + " Commit ";
                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE FabricStockMst SET "
                                                + " FabricStockQty=@FabricStockQty"
                                                + " Where FabricCode=@FabricCode";

                        }
                        sqlcom.Parameters.AddWithValue("@FabricCode", txtFabricCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricStockQty", Convert.ToDecimal(txtQty.Text));

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

        private void txtYarnCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadFabricMstFHelp");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    HelpGridView.Columns.Clear();
                    HelpGrid.DataSource = ds.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Show();
                    HelpGrid.Visible = true;
                    HelpGrid.Focus();
                }
            }
            e.Handled = true;
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

            txtFabricCode.Text = row["FabricCode"].ToString();
            txtFabricContent.Text = row["FabricContent"].ToString();
            txtFabricTypeCode.Text = row["FabricTypeCode"].ToString();
            txtFabricTypeDesc.Text = row["FabricTypeName"].ToString();
            txtFabricLotNo.Text = row["FabricLotNo"].ToString();
            txtColorCode.Text = row["FabricColorID"].ToString();
            txtColorName.Text = row["COLNAME"].ToString();
            HelpGrid.Visible = false;
            txtQty.Focus();

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }
    }
}