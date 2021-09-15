using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmMachineTypeMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string TypeCode { get; set; }
        public frmMachineTypeMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

            txtTypeName.Properties.MaxLength = 100;

            txtTypeCode.Enabled = false;
        }

        private string GetNewTypeCode()
        {

            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(TypeCode as int)),0000) from MachineTypeMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;

        }
        private bool ValidateData()
        {
            if (txtTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Machine Type Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtTypeCode.Focus();
                return false;
            }
            if (txtTypeName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Machine Type Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtTypeName.Focus();
                return false;
            }

            return true;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMachineTypeMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtTypeName.Focus();
                txtTypeCode.Text = GetNewTypeCode().PadLeft(4, '0');
            }
            if (S1 == "Edit")
            {
                //txtCatgDesc.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("SELECT TypeCode,TypeDesc FROM MachineTypeMst Where TypeCode='" + TypeCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtTypeCode.Text = ds.Tables[0].Rows[0]["TypeCode"].ToString();
                    txtTypeName.Text = ds.Tables[0].Rows[0]["TypeDesc"].ToString();
                    txtTypeName.Focus();
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
                                                    + " Insert into MachineTypeMst"
                                                    + " (TypeCode,TypeDesc)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(TypeCode as int)),0)+1 AS VARCHAR(4)),4)from MachineTypeMst),@TypeDesc)"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE MachineTypeMst SET "
                                                + " TypeDesc=@TypeDesc"
                                                + " Where TypeCode=@TypeCode";

                        }
                        sqlcom.Parameters.AddWithValue("@TypeCode", txtTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@TypeDesc", txtTypeName.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Data Saved Successfully");



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