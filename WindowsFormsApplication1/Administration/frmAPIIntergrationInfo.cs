using System;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.Administration
{
    public partial class frmAPIIntegrationInfo : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string TransId { get; set; }
        public frmAPIIntegrationInfo()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            try
            {
                //ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);


                txtTransId.Enabled = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private bool ValidateData()
        {
            try
            {
                if (txtASPNetUser.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid ASPNetUser ");
                    txtASPNetUser.Focus();
                    return false;
                }
                if (txtASPPassword.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid ASPPassword ");
                    txtASPPassword.Focus();
                    return false;
                }
                if (txtBaseUrl.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Base Url ");
                    txtBaseUrl.Focus();
                    return false;
                }
                if (txtEWBGSTIN.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid EWBGSTIN ");
                    txtEWBGSTIN.Focus();
                    return false;
                }
                if (txtEWBPassword.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid EWB Password ");
                    txtEWBPassword.Focus();
                    return false;
                }
                if (txtEWBUserID.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid EWB User ID ");
                    txtEWBUserID.Focus();
                    return false;
                }
                if (txtGSPName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid GSP Name");
                    txtGSPName.Focus();
                    return false;
                }
                if (txtGSPName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid GSP Name");
                    txtGSPName.Focus();
                    return false;
                }
                if (txtstatusTag.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Status Tag");
                    txtstatusTag.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
                return false;
            }
        }
        private void FrmAPIIntergrationInfo_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();

                txtTransId.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("SELECT * FROM APIIntegrationSetting Where TransId='" + TransId + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtGSPName.Text = ds.Tables[0].Rows[0]["GSPName"].ToString();
                    txtASPNetUser.Text = ds.Tables[0].Rows[0]["ASPNetUser"].ToString();
                    txtASPPassword.Text = ds.Tables[0].Rows[0]["ASPPassword"].ToString();
                    txtBaseUrl.Text = ds.Tables[0].Rows[0]["BaseUrl"].ToString();
                    txtEWBGSTIN.Text = ds.Tables[0].Rows[0]["EWBGSTIN"].ToString();
                    txtEWBUserID.Text = ds.Tables[0].Rows[0]["EWBUserID"].ToString();
                    txtEWBPassword.Text = ds.Tables[0].Rows[0]["EWBPassword"].ToString();
                    txtstatusTag.Text = ds.Tables[0].Rows[0]["Active"].ToString();
                    txtTransId.Text = ds.Tables[0].Rows[0]["TransId"].ToString();
                    txtGSPName.Focus();
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
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
                        sqlcom.CommandText = " UPDATE APIIntegrationSetting SET "
                                            + " GSPName=@GSPName,ASPNetUser=@ASPNetUser,ASPPassword=@ASPPassword,BaseUrl=@BaseUrl,"
                                            + " EWBGSTIN=@EWBGSTIN,EWBUserID=@EWBUserID,"
                                            + " EWBPassword=@EWBPassword "
                                            + " Where TransId=@TransId ";
                        sqlcom.Parameters.AddWithValue("@TransId", txtTransId.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@GSPName", txtGSPName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ASPNetUser", txtASPNetUser.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ASPPassword", txtASPPassword.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@BaseUrl", txtBaseUrl.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EWBGSTIN", txtEWBGSTIN.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EWBUserID", txtEWBUserID.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EWBPassword", txtEWBPassword.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        ProjectFunctions.SpeakError("Something Wrong. \n I am going to Roll Back." + ex.Message);
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            ProjectFunctions.SpeakError("Something Wrong. \n Roll Back Failed." + ex2.Message);
                        }
                    }
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}