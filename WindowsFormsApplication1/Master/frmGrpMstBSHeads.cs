using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmGrpMstBSHeads : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string GrpCode { get; set; }
        public string SubGrpCode { get; set; }
        public FrmGrpMstBSHeads()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.XtraFormVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }
        private string GetNewGroupCode()
        {
            var s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet(" select isnull(max(cast(GrpCode as int)),0000) from BSHeadGrpMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }
            return s2;
        }
        private string GetNewSubGroupCode()
        {
            var s2 = string.Empty;

            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(cast(GrpSubCode as int)),0000) from BSHeadGrpMst where GrpCode='" + txtGrpCode.Text.Trim().PadLeft(4, '0') + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }

            return s2;
        }
        private void FrmGrpMstBSHeads_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtGrpCode.Focus();
                txtGrpDesc.Enabled = false;
                txtSGrpCode.Enabled = false;
                txtSGrpDesc.Enabled = false;
                txtGrpCode.Text = GetNewGroupCode().PadLeft(4, '0');
            }
            if (S1 == "Edit")
            {
                if (SubGrpCode == string.Empty)
                {
                    txtGrpCode.Enabled = false;
                    txtGrpDesc.Enabled = true;
                    txtSGrpCode.Enabled = false;
                    txtSGrpDesc.Enabled = false;
                    txtGrpDesc.Focus();
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT GrpCode,GrpDesc FROM BSHeadGrpMst where GrpCode ='" + GrpCode + "'");
                    txtGrpCode.Text = ds.Tables[0].Rows[0]["GrpCode"].ToString();
                    txtGrpDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                }
                if (SubGrpCode != string.Empty)
                {
                    txtGrpCode.Enabled = false;
                    txtGrpDesc.Enabled = false;
                    txtSGrpCode.Enabled = false;
                    txtSGrpDesc.Enabled = true;
                    txtSGrpDesc.Focus();
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT GrpCode,GrpDesc,GrpSubCode,GrpSubDesc FROM BSHeadGrpMst where GrpCode ='" + GrpCode + "' And  GrpSubCode='" + SubGrpCode + "'");
                    txtGrpCode.Text = ds.Tables[0].Rows[0]["GrpCode"].ToString();
                    txtGrpDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                    txtSGrpCode.Text = ds.Tables[0].Rows[0]["GrpSubCode"].ToString();
                    txtSGrpDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();

                }
            }
        }
        private bool ValidateSubGrpData()
        {
            if (txtGrpCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Group Code");

                txtGrpCode.Focus();
                return false;
            }
            if (txtSGrpCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid SubGroup Desc");

                txtSGrpCode.Focus();
                return false;
            }
            if (txtGrpDesc.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Group Desc");

                txtGrpDesc.Focus();
                return false;
            }
            if (txtSGrpDesc.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Sub Group Desc");

                txtSGrpDesc.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateGrpData()
        {
            if (txtGrpCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Group Code");

                txtGrpCode.Focus();
                return false;
            }
            if (txtGrpDesc.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Group Desc");

                txtGrpDesc.Focus();
                return false;
            }
            return true;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtGrpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (S1 == "&Add")
                {
                    if (Convert.ToInt32(txtGrpCode.Text) < Convert.ToInt32(GetNewGroupCode()))
                    {
                        txtGrpCode.Enabled = false;
                        txtSGrpDesc.Enabled = true;
                        txtSGrpDesc.Focus();
                        txtGrpDesc.Enabled = false;
                        DataSet ds = ProjectFunctions.GetDataSet("Select GrpDesc from BSHeadGrpMst Where GrpCode='" + txtGrpCode.Text.Trim().PadLeft(4, '0') + "'");
                        txtGrpDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString().Trim();
                        txtSGrpCode.Text = GetNewSubGroupCode().PadLeft(4, '0');
                    }
                    if (Convert.ToInt32(txtGrpCode.Text) == Convert.ToInt32(GetNewGroupCode()))
                    {
                        txtGrpDesc.Focus();
                        txtGrpDesc.Enabled = true;
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (S1 == "&Add")
            {
                if (txtSGrpDesc.Enabled == false)
                {
                    if (ValidateGrpData())
                    {
                        var strQry = string.Empty;
                        strQry = " Insert into BSHeadGrpMst(GrpCode,GrpDesc)values(";
                        strQry = strQry + "'" + GetNewGroupCode().PadLeft(4, '0') + "',";
                        strQry = strQry + "'" + txtGrpDesc.Text.Trim() + "')";

                        using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(strQry, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcon.Close();
                            ProjectFunctions.SpeakError("Data Saved Successfully");
                        }
                    }
                }
                if (txtSGrpDesc.Enabled == true)
                {
                    if (ValidateSubGrpData())
                    {
                        var strQry = string.Empty;
                        strQry = " Insert into BSHeadGrpMst(GrpCode,GrpSubCode,GrpDesc,GrpSubDesc)values(";
                        strQry = strQry + "'" + txtGrpCode.Text.Trim().PadLeft(4, '0') + "',";
                        strQry = strQry + "'" + GetNewSubGroupCode().PadLeft(4, '0') + "',";
                        strQry = strQry + "'" + txtGrpDesc.Text.Trim() + "',";
                        strQry = strQry + "'" + txtSGrpDesc.Text.Trim() + "')";
                        using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(strQry, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcon.Close();
                            ProjectFunctions.SpeakError("Data Saved Successfully");
                        }
                    }
                }
            }
            if (S1 == "Edit")
            {
                if (txtSGrpDesc.Enabled == false)
                {
                    if (ValidateGrpData())
                    {
                        var strQry = string.Empty;
                        strQry = " UPDATE BSHeadGrpMst SET";
                        strQry = strQry + " GrpDesc ='" + txtGrpDesc.Text.ToString().Trim() + "'";
                        strQry = strQry + " Where GrpCode='" + GrpCode + "'";
                        using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(strQry, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcon.Close();
                            ProjectFunctions.SpeakError("Data Saved Successfully");
                        }
                    }
                }
                if (txtSGrpDesc.Enabled == true)
                {
                    if (ValidateSubGrpData())
                    {
                        var strQry = string.Empty;
                        strQry = " UPDATE BSHeadGrpMst SET";
                        strQry = strQry + " GrpSubDesc ='" + txtSGrpDesc.Text.Trim() + "'";


                        strQry = strQry + " Where GrpCode='" + GrpCode + "'";
                        strQry = strQry + " AND  GrpSubCode='" + SubGrpCode + "'";
                        using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(strQry, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcon.Close();
                            ProjectFunctions.SpeakError("Data Saved Successfully");
                        }
                    }
                }
            }
            Close();
        }

        private void TxtGrpCode_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(txtGrpCode.Text) > Convert.ToInt32(GetNewGroupCode()))
            {
                txtGrpCode.Text = GetNewGroupCode().PadLeft(4, '0');
                txtGrpDesc.Focus();
            }
        }

        private void FrmGrpMstBSHeads_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtGrpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.TextOnly(e);
        }

        private void TxtSGrpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.TextOnly(e);
        }

        private void TxtGrpDesc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtGrpCode.Focus();
            }
        }

        private void TxtSGrpDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.TextOnly(e);
        }
    }
}