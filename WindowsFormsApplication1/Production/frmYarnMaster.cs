using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Production
{
    public partial class FrmYarnMaster : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string YarnCode { get; set; }
        public FrmYarnMaster()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtYarnContent.Properties.MaxLength = 100;
            txtYarnLotNo.Properties.MaxLength = 100;
            txtYarnCode.Enabled = false;
        }

        private string GetNewYarnCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(YarnCode as int)),000000) from YarnMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
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

            return true;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtYarnTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            txtYarnTypeDesc.Text = String.Empty;
        }

        private void TxtYarnTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select YarnTypeCode,YarnTypeName from YarnTypeMst", " Where YarnTypeCode", txtYarnTypeCode, txtYarnTypeDesc, txtYarnContent, HelpGrid, HelpGridView, e);
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
            if (HelpGrid.Text == "txtYarnTypeCode")
            {
                txtYarnTypeCode.Text = row["YarnTypeCode"].ToString();
                txtYarnTypeDesc.Text = row["YarnTypeName"].ToString();
                HelpGrid.Visible = false;
                txtYarnContent.Focus();
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
                                                    + " Insert into YarnMst"
                                                    + " (YarnCode,YarnContent,YarnTypeCode,YarnLotNo,YarnColorID)"
                                                    + " values((SELECT RIGHT('000000'+ CAST( ISNULL( max(Cast(YarnCode as int)),0)+1 AS VARCHAR(6)),6)from YarnMst),@YarnContent,@YarnTypeCode,@YarnLotNo,@YarnColorID )"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE YarnMst SET "
                                                + " YarnContent=@YarnContent,YarnTypeCode=@YarnTypeCode, YarnLotNo=@YarnLotNo,YarnColorID=@YarnColorID"
                                                + " Where YarnCode=@YarnCode";

                        }
                        sqlcom.Parameters.AddWithValue("@YarnCode", txtYarnCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnContent", txtYarnContent.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnTypeCode", txtYarnTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnLotNo", txtYarnLotNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnColorID", txtColorCode.Text.Trim());
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
                txtYarnContent.Focus();
                txtYarnCode.Text = GetNewYarnCode().PadLeft(6, '0');
            }
            if (S1 == "Edit")
            {
                txtYarnContent.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadYarnMstFEdit '" + YarnCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtYarnCode.Text = ds.Tables[0].Rows[0]["YarnCode"].ToString();
                    txtYarnContent.Text = ds.Tables[0].Rows[0]["YarnContent"].ToString();
                    txtYarnTypeCode.Text = ds.Tables[0].Rows[0]["YarnTypeCode"].ToString();
                    txtYarnTypeDesc.Text = ds.Tables[0].Rows[0]["YarnTypeName"].ToString();
                    txtYarnLotNo.Text = ds.Tables[0].Rows[0]["YarnLotNo"].ToString();
                    txtColorCode.Text = ds.Tables[0].Rows[0]["YarnColorID"].ToString();
                    txtColorName.Text = ds.Tables[0].Rows[0]["COLNAME"].ToString();

                    txtYarnTypeCode.Focus();
                }
            }
        }
    }
}