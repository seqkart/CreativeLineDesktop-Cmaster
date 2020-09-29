using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Master
{
    public partial class frmCityMst : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String CityCode { get; set; }
        public frmCityMst()
        {
            InitializeComponent();
        }

        private void txtStateCode_EditValueChanged(object sender, EventArgs e)
        {
            txtStateName.Text = String.Empty;

        }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtCItyName.Properties.MaxLength = 55;

                txtCityCode.Enabled = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void frmCityMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (s1 == "&Add")
                {
                    txtCItyName.Focus();
                }
                if (s1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadCityMstFEDIt '" + CityCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtCityCode.Text = ds.Tables[0].Rows[0]["CTSYSID"].ToString();
                        txtCItyName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                        txtStateCode.Text = ds.Tables[0].Rows[0]["UNDERSTID"].ToString();
                        txtStateName.Text = ds.Tables[0].Rows[0]["STNAME"].ToString();
                        txtCItyName.Focus();
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
                if (txtCItyName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid City Name");
                    txtCItyName.Focus();
                    return false;
                }
                if (txtStateCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid State Name");
                    txtStateCode.Focus();
                    return false;
                }
                if (txtStateName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid State Name");
                    txtStateCode.Focus();
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            sqlcom.CommandText = " Insert into CITYMASTER"
                                                    + " (CTNAME,UNDERSTID)values(@CTNAME,@UNDERSTID)";

                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE CITYMASTER SET "
                                                + " CTNAME=@CTNAME,UNDERSTID=@UNDERSTID"
                                                + " Where CTSYSID=@CTSYSID";
                            sqlcom.Parameters.AddWithValue("@CTSYSID", txtCityCode.Text.Trim());

                        }
                        sqlcom.Parameters.AddWithValue("@CTNAME", txtCItyName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNDERSTID", txtStateCode.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        //ProjectFunctions.SpeakError("Data Saved Successfully");
                        this.Close();
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

        private void frmCityMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtStateCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select STSYSID,STNAME from STATEMASTER", " Where STSYSID", txtStateCode, txtStateName, txtStateCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
                if (HelpGrid.Text == "txtStateCode")
                {
                    txtStateCode.Text = row["STSYSID"].ToString();
                    txtStateName.Text = row["STNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtStateCode.Focus();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
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
    }
}