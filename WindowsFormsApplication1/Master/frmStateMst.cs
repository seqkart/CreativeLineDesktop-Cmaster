using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmStateMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string StateCode { get; set; }
        public frmStateMst()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtStateName.Properties.MaxLength = 55;

                txtStateCode.Enabled = false;


                try
                {
                    DataSet dsCountry = ProjectFunctions.GetDataSet("Select Distinct UNDERRG from STATEMASTER");
                    if (dsCountry.Tables[0].Rows.Count > 0)
                    {
                        txtCountry.Properties.Items.Clear();
                        foreach (DataRow dr in dsCountry.Tables[0].Rows)
                        {
                            txtCountry.Properties.Items.Add(dr["UNDERRG"]);
                        }


                    }



                }
                catch (Exception ex)
                {
                    ProjectFunctions.SpeakError(ex.Message);
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void FrmStateMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (S1 == "&Add")
                {
                    txtStateName.Focus();
                }
                if (S1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT * FROM STATEMASTER Where STSYSID='" + StateCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtStateCode.Text = ds.Tables[0].Rows[0]["STSYSID"].ToString();
                        txtStateName.Text = ds.Tables[0].Rows[0]["STNAME"].ToString();
                        txtCountry.Text = ds.Tables[0].Rows[0]["UNDERRG"].ToString();
                        txtStateName.Focus();
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
                if (txtStateName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid State Name");
                    txtStateName.Focus();
                    return false;
                }
                if (txtCountry.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Country Name");
                    txtCountry.Focus();
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
                            sqlcom.CommandText = " Insert into STATEMASTER"
                                                    + " (STNAME,UNDERRG)values(@STNAME,@UNDERRG)";

                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE STATEMASTER SET "
                                                + " STNAME=@STNAME,UNDERRG=@UNDERRG"
                                                + " Where STSYSID=@STSYSID";
                            sqlcom.Parameters.AddWithValue("@STSYSID", txtStateCode.Text.Trim());

                        }
                        sqlcom.Parameters.AddWithValue("@STNAME", txtStateName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNDERRG", txtCountry.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        //ProjectFunctions.SpeakError("Data Saved Successfully");
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

        private void FrmStateMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}