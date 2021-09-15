using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Production
{
    public partial class FrmYarnStock : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string YarnCode { get; set; }
        public FrmYarnStock()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtYarnContent.Properties.MaxLength = 100;
            txtYarnLotNo.Properties.MaxLength = 100;
            txtYarnCode.Enabled = true;
            txtQty.Enabled = true;

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtYarnCode_EditValueChanged(object sender, EventArgs e)
        {
            txtYarnContent.Text = string.Empty;
            txtYarnLotNo.Text = string.Empty;
            txtYarnTypeCode.Text = string.Empty;
            txtYarnTypeDesc.Text = string.Empty;
            txtColorCode.Text = string.Empty;
            txtColorName.Text = string.Empty;
        }


        private bool ValidateData()
        {
            if (txtYarnCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnCode.Focus();
                return false;
            }
            if (txtYarnContent.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Content", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnContent.Focus();
                return false;
            }
            if (txtYarnLotNo.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Lot No", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnLotNo.Focus();
                return false;
            }
            if (txtYarnTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Type", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnTypeCode.Focus();
                return false;
            }
            if (txtYarnTypeDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Type", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnTypeDesc.Focus();
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
        private void FrmYarnStock_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtYarnCode.Focus();

            }
            if (S1 == "Edit")
            {
                txtYarnCode.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadYranStockDataFEdit '" + YarnCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtYarnCode.Text = ds.Tables[0].Rows[0]["YarnCode"].ToString();
                    txtYarnContent.Text = ds.Tables[0].Rows[0]["YarnContent"].ToString();
                    txtYarnTypeCode.Text = ds.Tables[0].Rows[0]["YarnTypeCode"].ToString();
                    txtYarnTypeDesc.Text = ds.Tables[0].Rows[0]["YarnTypeName"].ToString();
                    txtYarnLotNo.Text = ds.Tables[0].Rows[0]["YarnLotNo"].ToString();
                    txtColorCode.Text = ds.Tables[0].Rows[0]["YarnColorID"].ToString();
                    txtColorName.Text = ds.Tables[0].Rows[0]["COLNAME"].ToString();
                    txtQty.Text = ds.Tables[0].Rows[0]["YarnStockQty"].ToString();

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
                        if (S1 == "&Add")
                        {
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into YarnStockMst"
                                                    + " (YarnCode,YarnStockQty)"
                                                    + " values( @YarnCode,@YarnStockQty)"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE YarnStockMst SET "
                                                + " YarnStockQty=@YarnStockQty"
                                                + " Where YarnCode=@YarnCode";

                        }
                        sqlcom.Parameters.AddWithValue("@YarnCode", txtYarnCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnStockQty", Convert.ToDecimal(txtQty.Text));

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

        private void TxtYarnCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadYranMstFHelp");
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

            txtYarnCode.Text = row["YarnCode"].ToString();
            txtYarnContent.Text = row["YarnContent"].ToString();
            txtYarnTypeCode.Text = row["YarnTypeCode"].ToString();
            txtYarnTypeDesc.Text = row["YarnTypeName"].ToString();
            txtYarnLotNo.Text = row["YarnLotNo"].ToString();
            txtColorCode.Text = row["YarnColorID"].ToString();
            txtColorName.Text = row["COLNAME"].ToString();
            HelpGrid.Visible = false;
            txtQty.Focus();

        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }
    }
}