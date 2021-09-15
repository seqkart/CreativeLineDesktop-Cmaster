using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmProcessMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string ProcessCode { get; set; }
        public FrmProcessMst()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize
                (Menu_ToolStrip);

            txtProcessCode.Enabled = false;
        }
        private string GetNewProcessCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(ProcessCode as int)),0000) from ProcessMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private bool ValidateData()
        {
            if (txtProcessCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Process", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtProcessCode.Focus();
                return false;
            }
            if (txtProcessName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Process", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtProcessName.Focus();
                return false;
            }
            if (txtProcessRate.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Process Rate", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtProcessRate.Focus();
                return false;
            }


            return true;
        }

        private void FrmProcessMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtProcessName.Focus();
                txtProcessCode.Text = GetNewProcessCode().PadLeft(4, '0');
            }
            if (S1 == "Edit")
            {
                txtProcessName.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("Select * from ProcessMst Where ProcessCode = '" + ProcessCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtProcessCode.Text = ds.Tables[0].Rows[0]["ProcessCode"].ToString();
                    txtProcessName.Text = ds.Tables[0].Rows[0]["ProcessName"].ToString();
                    txtProcessRate.Text = ds.Tables[0].Rows[0]["ProcessRate"].ToString();

                    txtProcessRate.Focus();
                }
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
                                                    + " Insert into ProcessMst"
                                                    + " (ProcessCode,ProcessName,ProcessRate)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(ProcessCode as int)),0)+1 AS VARCHAR(4)),4)from ProcessMst),@ProcessName,@ProcessRate )"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE ProcessMst SET "
                                                + " ProcessName=@ProcessName,ProcessRate=@ProcessRate "
                                                + " Where ProcessCode=@ProcessCode";

                        }
                        sqlcom.Parameters.AddWithValue("@ProcessCode", txtProcessCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ProcessName", txtProcessName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ProcessRate", Convert.ToDecimal(txtProcessRate.Text));
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

        private void TxtProcessRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }
    }
}
