using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmContractorMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string CNTSYSID { get; set; }
        public FrmContractorMst()
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
            txtContName.Properties.MaxLength = 150;
            txtIDNo.Properties.MaxLength = 150;
            txtIDType.Properties.MaxLength = 32;
            txtMobileNo.Properties.MaxLength = 12;
            txtOtherNo.Properties.MaxLength = 12;
            txtEMailId.Properties.MaxLength = 55;
            txtContCode.Enabled = false;

        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            sqlcom.CommandText = " Insert into CONTRACTOR"
                                                 + " (CNTSYSDATE,CNTNAME, CNTMOBNO,CNTALTMOBNO,CNTEMAILID,CNTIDTYPE,CNTIDNO)values("
                                                 + " @CNTSYSDATE,@CNTNAME, @CNTMOBNO,@CNTALTMOBNO,@CNTEMAILID,@CNTIDTYPE,@CNTIDNO)";




                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE CONTRACTOR SET "
                                                + " CNTNAME=@CNTNAME,CNTMOBNO=@CNTMOBNO,CNTALTMOBNO=@CNTALTMOBNO,CNTEMAILID=@CNTEMAILID,CNTIDTYPE=@CNTIDTYPE, "
                                                + " CNTIDNO=@CNTIDNO Where CNTSYSID=@CNTSYSID";
                            sqlcom.Parameters.AddWithValue("@CNTSYSID", txtContCode.Text.Trim());
                        }
                        sqlcom.Parameters.AddWithValue("@CNTSYSDATE", DateTime.Now.ToString("yyyy-MM-dd"));

                        sqlcom.Parameters.AddWithValue("@CNTNAME", txtContName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@CNTMOBNO", txtMobileNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@CNTALTMOBNO", txtOtherNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@CNTEMAILID", txtEMailId.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@CNTIDTYPE", txtIDType.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@CNTIDNO", txtIDNo.Text.Trim());



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

        private void FrmContractorMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtContName.Focus();
            }
            if (S1 == "Edit")
            {
                txtContName.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("Select * from CONTRACTOR Where CNTSYSID= '" + CNTSYSID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtContCode.Text = ds.Tables[0].Rows[0]["CNTSYSID"].ToString();
                    txtContName.Text = ds.Tables[0].Rows[0]["CNTNAME"].ToString();
                    txtEMailId.Text = ds.Tables[0].Rows[0]["CNTEMAILID"].ToString();
                    txtIDNo.Text = ds.Tables[0].Rows[0]["CNTIDNO"].ToString();
                    txtIDType.Text = ds.Tables[0].Rows[0]["CNTIDTYPE"].ToString();
                    txtMobileNo.Text = ds.Tables[0].Rows[0]["CNTMOBNO"].ToString();
                    txtOtherNo.Text = ds.Tables[0].Rows[0]["CNTALTMOBNO"].ToString();
                }
                txtContName.Focus();
            }
        }

        private bool ValidateData()
        {
            if (txtContName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Contractor Name");
                txtContName.Focus();
                return false;
            }

            if (txtMobileNo.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Mobile No ");
                txtMobileNo.Focus();
                return false;
            }
            if (txtIDType.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Id Type ");
                txtIDType.Focus();
                return false;
            }
            return true;
        }
    }
}