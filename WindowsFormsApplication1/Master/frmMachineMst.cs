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
    public partial class frmMachineMst : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String MachineCode { get; set; }
        public frmMachineMst()
        {
            InitializeComponent();
        }

        private void txtTypeCode_EditValueChanged(object sender, EventArgs e)
        {
            txtTypeDesc.Text = String.Empty;
        }

        private void txtBrandCode_EditValueChanged(object sender, EventArgs e)
        {
            txtBrandDesc.Text = String.Empty;
        }

        private void txtTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select TypeCode,TypeDesc from MachineTypeMst", " Where TypeCode", txtTypeCode, txtTypeDesc, txtBrandCode, HelpGrid, HelpGridView, e);
        }

        private void txtBrandCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select BrandCode,BrandDesc from MachineBrandMst", " Where BrandCode", txtBrandCode, txtBrandDesc, txtGauge, HelpGrid, HelpGridView, e);
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtTypeCode")
            {
                txtTypeCode.Text = row["TypeCode"].ToString();
                txtTypeDesc.Text = row["TypeDesc"].ToString();
                HelpGrid.Visible = false;
                txtBrandCode.Focus();
            }
            if (HelpGrid.Text == "txtBrandCode")
            {
                txtBrandCode.Text = row["BrandCode"].ToString();
                txtBrandDesc.Text = row["BrandDesc"].ToString();
                HelpGrid.Visible = false;
                txtGauge.Focus();
            }
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

            txtGauge.Properties.MaxLength = 6;

            txtMachineCode.Enabled = false;
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
        private string GetNewMachineCode()
        {

            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(MachineCode as int)),0000) from MachineMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;

        }
        private bool ValidateData()
        {
            if (txtMachineCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Machine Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtMachineCode.Focus();
                return false;
            }
            if (txtTypeCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid MAchine Type ", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtTypeDesc.Focus();
                return false;
            }
            if (txtTypeDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Machine Type Description ", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtTypeDesc.Focus();
                return false;
            }
            if (txtGauge.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Machine Gauge ", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtGauge.Focus();
                return false;
            }
            return true;
        }
        private void frmMachineMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (s1 == "&Add")
            {
                txtTypeCode.Focus();
                txtMachineCode.Text = GetNewMachineCode().PadLeft(4, '0');
            }
            if (s1 == "Edit")
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadMachineMstFEdit '" + MachineCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtBrandCode.Text = ds.Tables[0].Rows[0]["MachineBrandCode"].ToString();
                    txtBrandDesc.Text = ds.Tables[0].Rows[0]["BrandDesc"].ToString();
                    txtMachineCode.Text = ds.Tables[0].Rows[0]["MachineCode"].ToString();
                    txtTypeCode.Text = ds.Tables[0].Rows[0]["MachineTypeCode"].ToString();
                    txtTypeDesc.Text = ds.Tables[0].Rows[0]["TypeDesc"].ToString();
                    txtGauge.Text = ds.Tables[0].Rows[0]["MachineGauge"].ToString();
                    txtTypeCode.Focus();
                }
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
                                                    + " Insert into MachineMst"
                                                    + " (MachineCode,MachineTypeCode,MachineBrandCode,MachineGauge)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(MachineCode as int)),0)+1 AS VARCHAR(4)),4)from MachineMst),@MachineTypeCode,@MachineBrandCode,@MachineGauge)"
                                                    + " Commit ";
                        }
                        if (s1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE MachineMst SET "
                                                + " MachineTypeCode=@MachineTypeCode,MachineBrandCode=@MachineBrandCode,MachineGauge=@MachineGauge"
                                                + " Where MachineCode=@MachineCode";

                        }
                        sqlcom.Parameters.AddWithValue("@MachineCode", txtMachineCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@MachineTypeCode", txtTypeCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@MachineBrandCode", txtBrandCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@MachineGauge", txtGauge.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Data Saved Successfully");



                        Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Something Wrong. \n I am going to Roll Back." + ex.Message, ex.GetType().ToString());
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            XtraMessageBox.Show("Something Wrong. \n Roll Back Failed." + ex2.Message, ex2.GetType().ToString());
                        }
                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}