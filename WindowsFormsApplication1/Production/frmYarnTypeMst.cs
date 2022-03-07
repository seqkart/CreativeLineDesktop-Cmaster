using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Production
{
    public partial class FrmYarnTypeMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string YarnTypeCode { get; set; }
        public FrmYarnTypeMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

            txtYarnTypeCode.Enabled = false;
            txtYarnTypeDesc.Properties.MaxLength = 100;
        }
        private string GetNewYarnTypeCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(YarnTypeCode as int)),0000) from YarnTypeMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private bool ValidateData()
        {
            if (txtYarnTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Type Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnTypeCode.Focus();
                return false;
            }
            if (txtYarnTypeDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Yarn Type Desc", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtYarnTypeDesc.Focus();
                return false;
            }



            return true;
        }

        private void FrmLotTypeMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtYarnTypeDesc.Focus();
                txtYarnTypeCode.Text = GetNewYarnTypeCode().PadLeft(4, '0');
            }
            if (S1 == "Edit")
            {
                txtYarnTypeCode.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("Select * from YarnTypeMst Where YarnTypeCode = '" + YarnTypeCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtYarnTypeCode.Text = ds.Tables[0].Rows[0]["YarnTypeCode"].ToString();
                    txtYarnTypeDesc.Text = ds.Tables[0].Rows[0]["YarnTypeName"].ToString();

                    txtYarnTypeDesc.Focus();
                }
            }

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                                    + " Insert into YarnTypeMst"
                                                    + " (YarnTypeCode,YarnTypeName)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(YarnTypeCode as int)),0)+1 AS VARCHAR(4)),4)from YarnTypeMst),@YarnTypeName )"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE YarnTypeMst SET "
                                                + " YarnTypeName=@YarnTypeName "
                                                + " Where YarnTypeCode=@YarnTypeCode";

                        }
                        sqlcom.Parameters.AddWithValue("@YarnTypeCode", txtYarnTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@YarnTypeName", txtYarnTypeDesc.Text.Trim());

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
    }
}