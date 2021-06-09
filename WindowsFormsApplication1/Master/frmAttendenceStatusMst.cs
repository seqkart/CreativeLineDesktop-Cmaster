using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Master
{
    public partial class frmAttendenceStatusMst : DevExpress.XtraEditors.XtraForm
    {
        public string s1 { get; set; }
        public string StatusID { get; set; }
        public frmAttendenceStatusMst()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtStatusCode.Properties.MaxLength = 100;
                txtStatusDesc.Properties.MaxLength = 100;
                txtStatusID.Enabled = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void frmAttendenceStatusMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (s1 == "&Add")
                {
                    txtStatusCode.Focus();
                }
                if (s1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT * FROM AttendanceStatus Where status_id='" + StatusID + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtStatusID.Text = ds.Tables[0].Rows[0]["status_id"].ToString();
                        txtStatusCode.Text = ds.Tables[0].Rows[0]["status_code"].ToString();
                        txtStatusDesc.Text = ds.Tables[0].Rows[0]["status"].ToString();
                        txtStatusDesc.Focus();
                    }
                }
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
                if (txtStatusCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Status Code");
                    txtStatusCode.Focus();
                    return false;
                }
                if (txtStatusDesc.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Status Desc");
                    txtStatusDesc.Focus();
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

        private void Menu_ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
                            sqlcom.CommandText = " Insert into AttendanceStatus"
                                                    + " (status_code,status)values(@status_code,@status)";

                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE AttendanceStatus SET "
                                                + " status_code=@status_code,status=@status"
                                                + " Where status_id=@status_id";
                            sqlcom.Parameters.AddWithValue("@status_id", txtStatusID.Text.Trim());

                        }
                        sqlcom.Parameters.AddWithValue("@status_code", txtStatusCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@status", txtStatusDesc.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Brand Data Saved Successfully");
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
    }
}