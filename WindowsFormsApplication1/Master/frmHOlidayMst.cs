using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmHOlidayMst : DevExpress.XtraEditors.XtraForm
    {
        public string s1 { get; set; }
        public string HolidaySysID { get; set; }
        public frmHOlidayMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                txtHolidayName.Properties.MaxLength = 55;

                txtSysID.Enabled = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateData()
        {
            try
            {
                if (txtHolidayDate.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Holiday Date");
                    txtHolidayDate.Focus();
                    return false;
                }
                if (txtHolidayName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Holiday Name");
                    txtHolidayName.Focus();
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

        private void frmHOlidayMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (s1 == "&Add")
                {
                    txtHolidayDate.Focus();
                }
                if (s1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT * FROM HolidaysMaster Where serial_id='" + HolidaySysID + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtSysID.Text = ds.Tables[0].Rows[0]["serial_id"].ToString();
                        txtHolidayDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["holiday_date"]);
                        txtHolidayName.Text = ds.Tables[0].Rows[0]["holiday_name"].ToString();
                        txtHolidayDate.Focus();
                    }
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
                            sqlcom.CommandText = " Insert into HolidaysMaster"
                                                    + " (holiday_date,holiday_name)values(@holiday_date,@holiday_name)";

                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE HolidaysMaster SET "
                                                + " holiday_date=@holiday_date,holiday_name=@holiday_name"
                                                + " Where serial_id=@serial_id";
                            sqlcom.Parameters.AddWithValue("@serial_id", txtSysID.Text.Trim());

                        }
                        sqlcom.Parameters.AddWithValue("@holiday_date", Convert.ToDateTime(txtHolidayDate.Text).ToString("yyyy-MM-dd"));
                        sqlcom.Parameters.AddWithValue("@holiday_name", txtHolidayName.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError(" Data Saved Successfully");
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