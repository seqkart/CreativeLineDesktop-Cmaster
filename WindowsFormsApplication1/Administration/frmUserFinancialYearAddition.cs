using DevExpress.XtraEditors;
using System;
using System.Data;

namespace WindowsFormsApplication1.Administration
{
    public partial class FrmUserFinancialYearAddition : XtraForm
    {
        public string S1 { get; set; }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ButtonVisualize(this);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        public FrmUserFinancialYearAddition()
        {
            InitializeComponent();
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmUserFinancialYearAddition_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();

                cmbSelectUser.DataSource = ProjectFunctions.GetDataSet("Select Distinct  UserName from UserMaster").Tables[0];
                cmbSelectUser.DisplayMember = "UserName";
                cmbSelectFY.DataSource = ProjectFunctions.GetDataSet("select  distinct FNYearCode,TransID from FNYear").Tables[0];
                cmbSelectFY.DisplayMember = "FNYearCode";
                cmbSelectFY.ValueMember = "TransID";
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void CmbSelectFY_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (s1 == "aaaa")
            //{
            //    DataSet ds = ProjectFunctions.GetDataSet("Select Distinct GlobalVariables.FinYearStartDateing,GlobalVariables.FinYearEndDateing from UserCmpyAccess Where CFinYearCode='" + cmbSelectFY.Text + "'");
            //    txtSDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["GlobalVariables.FinYearStartDateing"]).ToString("dd-MM-yyyy");
            //    txtEDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["GlobalVariables.FinYearEndDateing"]).ToString("dd-MM-yyyy");
            //}
        }

        private bool ValidateData()
        {
            try
            {
                if (cmbSelectFY.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Financial Year");
                    cmbSelectFY.Focus();
                    return false;
                }
                if (cmbSelectUser.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid User Name");
                    cmbSelectUser.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }


            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveFY_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    DataSet ds = ProjectFunctions.GetDataSet("Select * from UserFNAccess Where UserName='" + cmbSelectUser.Text + "' And  FNTransID='" + cmbSelectFY.SelectedValue + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ProjectFunctions.SpeakError("Entry Already Exists For User (" + cmbSelectUser.Text + ") for FY (" + cmbSelectFY.Text + ")");
                        Close();
                    }
                    else
                    {
                        var Query = "Insert Into UserFNAccess(UserName,FNTransID)values(";
                        Query = Query + "'" + cmbSelectUser.Text.Trim() + "',";
                        Query = Query + "'" + cmbSelectFY.SelectedValue + "')";

                        ProjectFunctions.GetDataSet(Query);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
    }
}
