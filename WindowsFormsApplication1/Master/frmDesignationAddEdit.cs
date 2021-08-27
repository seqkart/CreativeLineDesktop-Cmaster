using DevExpress.XtraEditors;
using SeqKartLibrary;
using SeqKartLibrary.CrudTask;
using System;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class FrmDesignationAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string DesgCode { get; set; }
        public FrmDesignationAddEdit()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtDesc.Properties.MaxLength = 100;

            txtDesgCode.Enabled = false;
        }
        private void FrmDesignationAddEdit_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtDesc.Focus();
                txtDesgCode.Text = ProjectFunctionsUtils.GetNewDesgCode();
            }
            if (S1 == "Edit")
            {

                DataSet ds = ProjectFunctions.GetDataSet("SELECT DesgCode, DesgDesc FROM DesgMst Where DesgCode='" + DesgCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDesgCode.Text = ds.Tables[0].Rows[0]["DesgCode"].ToString();
                    txtDesc.Text = ds.Tables[0].Rows[0]["DesgDesc"].ToString();
                    txtDesc.Focus();
                }
            }
        }
        private bool ValidateData()
        {
            if (txtDesgCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesgCode.Focus();
                return false;
            }
            if (txtDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesc.Focus();
                return false;
            }

            return true;
        }

        private void FrmDesignationAddEdit_KeyDown(object sender, KeyEventArgs e)
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

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BtnSave_Data();
        }

        private void BtnSave_Data()
        {
            if (ValidateData())
            {
                PrintLogWin.PrintLog("btnSave_Data : " + txtDesgCode.Text.Trim());
                PrintLogWin.PrintLog("btnSave_Data : " + txtDesc.Text.Trim());
                PrintLogWin.PrintLog("btnSave_Data : " + S1);

                DesignationData designationData = new DesignationData();
                string intResult = designationData.InsertUpdate(txtDesgCode.Text.Trim(), txtDesc.Text.Trim(), S1);
                if (intResult.Equals("0"))
                {
                    ProjectFunctions.SpeakError("Data Saved Successfully");
                }
                else
                {
                    ProjectFunctions.SpeakError("Some Error in Save Data");
                }
                Close();


            }
        }
    }
}