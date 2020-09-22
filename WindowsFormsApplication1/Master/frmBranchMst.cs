using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmBranchMst : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String BranchCode { get; set; }
        public frmBranchMst()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStateCode_EditValueChanged(object sender, EventArgs e)
        {
            txtStateName.Text = String.Empty;
        }

        private void txtCityCode_EditValueChanged(object sender, EventArgs e)
        {
            txtCityName.Text = String.Empty;
        }

        private void txtAccCode_EditValueChanged(object sender, EventArgs e)
        {
            txtAccName.Text = String.Empty;
        }

        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtBranchName.Properties.MaxLength = 255;
                txtAddress1.Properties.MaxLength = 255;
                txtAddress2.Properties.MaxLength = 255;
                txtAddress3.Properties.MaxLength = 255;

                txtBranchCode.Enabled = false;
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
                if (txtBranchName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Branch Name");
                    txtBranchName.Focus();
                    return false;
                }
                if (txtAddress1.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Address1");
                    txtAddress1.Focus();
                    return false;
                }
                //if (txtAddress2.Text.Trim().Length == 0)
                //{
                //    ProjectFunctions.SpeakError("Invalid Address2");
                //    txtAddress2.Focus();
                //    return false;
                //}
                //if (txtAddress3.Text.Trim().Length == 0)
                //{
                //    ProjectFunctions.SpeakError("Invalid Address3");
                //    txtAddress3.Focus();
                //    return false;
                //}
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
                if (txtCityCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid City Name");
                    txtCityCode.Focus();
                    return false;
                }
                if (txtCityName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid City Name");
                    txtCityName.Focus();
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

        private void frmBranchMst_KeyDown(object sender, KeyEventArgs e)
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

        private void txtStateCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select STSYSID,STNAME from STATEMASTER", " Where STSYSID", txtStateCode, txtStateName, txtCityCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void txtCityCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select CTSYSID,CTNAME from CITYMASTER", " Where CTSYSID", txtCityCode, txtCityName, txtAccName, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void txtAccCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select AccCode,AccName from ActMst", " Where AccCode", txtAccCode, txtAccName, txtGSTNo, HelpGrid, HelpGridView, e);
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
                    txtCityCode.Focus();
                }
                if (HelpGrid.Text == "txtCityCode")
                {
                    txtCityCode.Text = row["CTSYSID"].ToString();
                    txtCityName.Text = row["CTNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtAccName.Focus();
                }
                if (HelpGrid.Text == "txtAccCode")
                {
                    txtAccCode.Text = row["AccCode"].ToString();
                    txtAccName.Text = row["AccName"].ToString();
                    HelpGrid.Visible = false;
                    txtGSTNo.Focus();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
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
                            sqlcom.CommandText = " Insert into UNITS"
                                                    + " (UNITNAME,UNITStateID,UNITCityID,UNITADDRESS,UNITADDRESS2,UNITADDRESS3,UNITLEDGCODE,UnitGSTNo)values(@UNITNAME,@UNITStateID,@UNITCityID,@UNITADDRESS,@UNITADDRESS2,@UNITADDRESS3,@UNITLEDGCODE,@UnitGSTNo)";

                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE UNITS SET "
                                                + " UNITNAME=@UNITNAME,UNITStateID=@UNITStateID,UNITCityID=@UNITCityID,UNITADDRESS=@UNITADDRESS,UNITADDRESS2=@UNITADDRESS2,UNITADDRESS3=@UNITADDRESS3,UNITLEDGCODE=@UNITLEDGCODE,UnitGSTNo=@UnitGSTNo "
                                                + " Where UNITID=@UNITID";
                            sqlcom.Parameters.AddWithValue("@UNITID", txtBranchCode.Text.Trim());

                        }
                        sqlcom.Parameters.AddWithValue("@UNITNAME", txtBranchName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITStateID", txtStateCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITCityID", txtCityCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITADDRESS", txtAddress1.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITADDRESS2", txtAddress2.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITADDRESS3", txtAddress3.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UNITLEDGCODE", txtAccCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UnitGSTNo", txtGSTNo.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
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

        private void frmBranchMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (s1 == "&Add")
                {
                    txtBranchCode.Focus();
                }
                if (s1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_BranchDataFEdit '" + BranchCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtBranchCode.Text = ds.Tables[0].Rows[0]["UNITID"].ToString();
                        txtBranchName.Text = ds.Tables[0].Rows[0]["UNITNAME"].ToString();
                        txtCityCode.Text = ds.Tables[0].Rows[0]["UNITCityID"].ToString();
                        txtCityName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                        txtStateCode.Text = ds.Tables[0].Rows[0]["UNITStateID"].ToString();
                        txtStateName.Text = ds.Tables[0].Rows[0]["STNAME"].ToString();
                        txtAccCode.Text = ds.Tables[0].Rows[0]["UNITLEDGCODE"].ToString();
                        txtAccName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                        txtAddress1.Text = ds.Tables[0].Rows[0]["UNITADDRESS"].ToString();
                        txtAddress2.Text = ds.Tables[0].Rows[0]["UNITADDRESS2"].ToString();
                        txtAddress3.Text = ds.Tables[0].Rows[0]["UNITADDRESS3"].ToString();
                        txtGSTNo.Text = ds.Tables[0].Rows[0]["UnitGSTNo"].ToString();
                        txtBranchName.Focus();
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