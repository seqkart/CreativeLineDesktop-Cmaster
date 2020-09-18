using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmFYCreation : DevExpress.XtraEditors.XtraForm
    {
        public string s1 { get; set; }
        public int TransId { get; set; }
        public frmFYCreation()
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
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ButtonVisualize(this);
                ProjectFunctions.XtraFormVisualize(this);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private bool ValidateData()
        {
            if (cmbFY.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Select Financial Year First");
                cmbFY.Focus();
                return false;
            }
            if (DtFrom.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Financial Year Star Date");
                DtFrom.Focus();
                return false;
            }
            if (DtEnd.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Financial Year End Date");
                DtFrom.Focus();
                return false;
            }
            return true;
        }
        private void frmFYCreation_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (s1 == "&Add")
            {
                cmbFY.Focus();

            }
            if (s1 == "Edit")
            {
                cmbFY.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("SELECT *  FROM FNYear Where TransID='" + TransId + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbFY.SelectedItem = ds.Tables[0].Rows[0]["FNYearCode"].ToString();
                    DtFrom.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["FNStartDate"]);
                    DtFrom.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["FNEndDate"]);
                    txtStatusTag.SelectedItem = ds.Tables[0].Rows[0]["Active"].ToString();
                    txtStatusTag.Focus();
                }
            }

        }


        private void cmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFY.SelectedIndex > 0)
            {
                DtFrom.EditValue = Convert.ToDateTime(cmbFY.SelectedItem.ToString().Substring(0, 4) + "-04-01");
                DtEnd.EditValue = Convert.ToDateTime(cmbFY.SelectedItem.ToString().Substring(5, 4) + "-03-31");
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
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into FNYear"
                                                    + " (FNYearCode,FNStartDate,FNEndDate,Active)"
                                                    + " values(@FNYearCode,@FNStartDate,@FNEndDate,@Active)"
                                                    + " Commit ";
                            sqlcom.Parameters.AddWithValue("@FNYearCode", cmbFY.SelectedItem.ToString());
                            sqlcom.Parameters.AddWithValue("@FNStartDate", Convert.ToDateTime(DtFrom.Text).ToString("yyyy-MM-dd"));
                            sqlcom.Parameters.AddWithValue("@FNEndDate", Convert.ToDateTime(DtEnd.Text).ToString("yyyy-MM-dd"));
                            sqlcom.Parameters.AddWithValue("@Active", txtStatusTag.SelectedItem.ToString());
                            sqlcom.ExecuteNonQuery();
                            transaction.Commit();
                            sqlcon.Close();
                            this.Close();
                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE FNYear SET "
                                                + " Active=@Active"
                                                + " Where TransID=@TransID";
                            sqlcom.Parameters.AddWithValue("@Active", txtStatusTag.SelectedItem.ToString());
                            sqlcom.Parameters.AddWithValue("@TransID", TransId);
                            sqlcom.ExecuteNonQuery();
                            transaction.Commit();
                            sqlcon.Close();
                            this.Close();

                        }

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