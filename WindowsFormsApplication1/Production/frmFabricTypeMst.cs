using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Production
{
    public partial class frmFabricTypeMst : DevExpress.XtraEditors.XtraForm
    {
        public string s1 { get; set; }
        public string FabricTypeCode { get; set; }
        public frmFabricTypeMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

            txtFabricTypeCode.Enabled = false;
            txtFabricTypeDesc.Properties.MaxLength = 100;
        }
        private string GetNewYarnTypeCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(FabricTypeCode as int)),0000) from FabricTypeMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private bool ValidateData()
        {
            if (txtFabricTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Type Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricTypeCode.Focus();
                return false;
            }
            if (txtFabricTypeDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Fabric Type Desc", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFabricTypeDesc.Focus();
                return false;
            }



            return true;
        }

        private void frmLotTypeMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (s1 == "&Add")
            {
                txtFabricTypeDesc.Focus();
                txtFabricTypeCode.Text = GetNewYarnTypeCode().PadLeft(4, '0');
            }
            if (s1 == "Edit")
            {
                txtFabricTypeCode.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("Select * from FabricTypeMst Where FabricTypeCode = '" + FabricTypeCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtFabricTypeCode.Text = ds.Tables[0].Rows[0]["FabricTypeCode"].ToString();
                    txtFabricTypeDesc.Text = ds.Tables[0].Rows[0]["FabricTypeName"].ToString();

                    txtFabricTypeDesc.Focus();
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
                        if (s1 == "&Add")
                        {
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into FabricTypeMst"
                                                    + " (FabricTypeCode,FabricTypeName)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(FabricTypeCode as int)),0)+1 AS VARCHAR(4)),4)from FabricTypeMst),@FabricTypeName )"
                                                    + " Commit ";
                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE FabricTypeMst SET "
                                                + " FabricTypeName=@FabricTypeName "
                                                + " Where FabricTypeCode=@FabricTypeCode";

                        }
                        sqlcom.Parameters.AddWithValue("@FabricTypeCode", txtFabricTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@FabricTypeName", txtFabricTypeDesc.Text.Trim());

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