using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmAddressBookGroup : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string AddressBookGroupCode { get; set; }
        public FrmAddressBookGroup()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtGroupDesc.Properties.MaxLength = 100;

                txtGroupCode.Enabled = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidateData()
        {
            if (txtGroupDesc.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Address Book Group Desc");
                txtGroupDesc.Focus();
                return false;
            }
            return true;
        }
        private void FrmAddressBookGroup_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (S1 == "&Add")
                {
                    txtGroupDesc.Focus();
                }
                if (S1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT AddressBookGroupCode,AddressBookGroupDesc FROM AddressBookGroup Where AddressBookGroupCode='" + AddressBookGroupCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtGroupCode.Text = ds.Tables[0].Rows[0]["AddressBookGroupCode"].ToString();
                        txtGroupDesc.Text = ds.Tables[0].Rows[0]["AddressBookGroupDesc"].ToString();
                        txtGroupDesc.Focus();
                    }
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
                        if (S1 == "&Add")
                        {
                            sqlcom.CommandText = " Insert into AddressBookGroup"
                                                    + " (AddressBookGroupDesc)values(@AddressBookGroupDesc)";

                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE AddressBookGroup SET "
                                                + " AddressBookGroupDesc=@AddressBookGroupDesc"
                                                + " Where AddressBookGroupCode=@AddressBookGroupCode";
                            sqlcom.Parameters.AddWithValue("@AddressBookGroupCode", txtGroupCode.Text.Trim());

                        }

                        sqlcom.Parameters.AddWithValue("@AddressBookGroupDesc", txtGroupDesc.Text.Trim());
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

        private void FrmAddressBookGroup_KeyDown(object sender, KeyEventArgs e)
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