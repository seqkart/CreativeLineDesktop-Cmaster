using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmSubProcessMst : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String SubProcessCode { get; set; }
        public frmSubProcessMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtSubProcessName.Properties.MaxLength = 100;

            txtSubProcessCode.Enabled = false;

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtProcessCode_EditValueChanged(object sender, EventArgs e)
        {
            txtProcessName.Text = string.Empty;
        }
        private bool ValidateData()
        {
            if (txtSubProcessCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Sub Process Code");
                txtSubProcessCode.Focus();
                return false;
            }
            if (txtSubProcessName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Sub Process Name");
                txtSubProcessName.Focus();
                return false;
            }
            if (txtProcessCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid  Process Name");
                txtProcessCode.Focus();
                return false;
            }
            if (txtProcessName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid  Process Name");
                txtProcessCode.Focus();
                return false;
            }


            return true;
        }
        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtProcessCode")
            {
                txtProcessCode.Text = row["ProcessCode"].ToString();
                txtProcessName.Text = row["ProcessName"].ToString();
                HelpGrid.Visible = false;
                txtProcessCode.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                            sqlcom.CommandText = " Insert into SubProcessMst"
                                                 + " (SubProcessCode,SubProcessName, ProcessCode)"
                                                 + " values(@SubProcessCode,@SubProcessName, @ProcessCode)";
                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE SubProcessMst SET "
                                                + " SubProcessName=@SubProcessName,ProcessCode=@ProcessCode "
                                                + " Where SubProcessCode=@SubProcessCode";

                        }
                        sqlcom.Parameters.AddWithValue("@SubProcessCode", txtSubProcessCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@SubProcessName", txtSubProcessName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ProcessCode", txtProcessCode.Text.Trim());


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

        private void txtProcessCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select ProcessCode,ProcessName from ProcessMst", " Where ProcessCode", txtProcessCode, txtProcessName, txtProcessCode, HelpGrid, HelpGridView, e);
        }
        private string GetNewSubProcessCode()
        {

            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(SubProcessCode as int)),0000) from SubProcessMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;

        }
        private void frmSubProcessMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (s1 == "&Add")
            {
                txtSubProcessName.Select();
                txtSubProcessCode.Text = GetNewSubProcessCode().PadLeft(4, '0');
            }
            if (s1 == "Edit")
            {
                txtSubProcessCode.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadSubProcessMstFEdit '" + SubProcessCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtSubProcessCode.Text = ds.Tables[0].Rows[0]["SubProcessCode"].ToString();
                    txtSubProcessName.Text = ds.Tables[0].Rows[0]["SubProcessName"].ToString();
                    txtProcessCode.Text = ds.Tables[0].Rows[0]["ProcessCode"].ToString();
                    txtProcessName.Text = ds.Tables[0].Rows[0]["ProcessName"].ToString();


                }
                txtSubProcessName.Select();
            }
        }
    }
}