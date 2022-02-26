using DevExpress.XtraEditors;
using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Master
{
    public partial class FrmDesignationAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string DesgCode { get; set; }
        public FrmDesignationAddEdit()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtDesc.Properties.MaxLength = 100;

            txtDesgCode.Enabled = false;
        }
        private void FrmDesignationAddEdit_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtDesc.Focus();
                txtDesgCode.Text = ProjectFunctionsUtils.GetNewDesgCode();
            }
            if (S1 == "Edit")
            {

                DataSet ds = ProjectFunctions.GetDataSet("SELECT DesgCode, DesgDesc FROM DesgMst Where DesgCode='" + DesgCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDesgCode.Text = ds.Tables[0].Rows[0]["DesgCode"].ToString();
                    txtDesc.Text = ds.Tables[0].Rows[0]["DesgDesc"].ToString();
                    txtDesc.Focus();
                }
            }
        }
        private bool ValidateData()
        {
            if (txtDesgCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesgCode.Focus();
                return false;
            }
            if (txtDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesc.Focus();
                return false;
            }

            return true;
        }

        private void FrmDesignationAddEdit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnSave_Click(null, e);
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave_Data();
        }

        private void BtnSave_Data()
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
                                                    + " Insert into DesgMst"
                                                    + " (DesgCode,DesgDesc)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(DesgCode as int)),0)+1 AS VARCHAR(4)),4)from DesgMst),@DesgDesc)"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE DesgMst SET "
                                                + " DesgDesc=@DesgDesc "
                                                + " Where DesgCode=@DesgCode";

                        }
                        sqlcom.Parameters.AddWithValue("@DesgCode", txtDesgCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@DesgDesc", txtDesc.Text.Trim());

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