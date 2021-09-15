using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Forms_Master
{
    public partial class frmEmployeeSalaryMst : DevExpress.XtraEditors.XtraForm
    {

        public frmEmployeeSalaryMst()
        {
            InitializeComponent();
        }



        private void SetMyControls()
        {
            //panelControl1.Location = new Point(ClientSize.Width / 2 - panelControl1.Size.Width / 2, ClientSize.Height / 2 - panelControl1.Size.Height / 2);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
            //ProjectFunctions.GroupCtrlVisualize(panelControl1);
            ProjectFunctions.XtraFormVisualize(this);

            ProjectFunctions.GirdViewVisualize(EmployeeGridView);

            MainFormButtons.Roles(GlobalVariables.ProgCode, GlobalVariables.CurrentUser, btnAdd, btnEdit);
            /*
            var Query4Controls = String.Format("SELECT     ProgAdd_F, ProgUpd_F, ProgDel_F, ProgRep_p, ReportHardcopy,ProgData_Up  FROM         UserProgAccess  WHERE     (ProgActive = 'Y') AND (ProgCode = N'" + GlobalVariables.ProgCode + "') AND (UserName = N'{0}'); ", GlobalVariables.CurrentUser);
            using (var Tempds = ProjectFunctions.GetDataSet(Query4Controls))
            {
                if (Tempds != null)
                {
                    if (Tempds.Tables[0].Rows.Count > 0)
                    {
                        if (Tempds.Tables[0].Rows[0]["ProgAdd_F"].ToString().Trim() == "-1")
                        {
                            btnAdd.Enabled = true;
                        }
                        else
                        {
                            btnAdd.Enabled = false;
                        }
                        if (Tempds.Tables[0].Rows[0]["ProgUpd_F"].ToString().Trim() == "-1")
                        {
                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            btnEdit.Enabled = false;
                        }
                    }
                }
            }
            */
        }
        private void FillGrid()
        {
            try
            {
                //DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                //SplashScreenManager.Default.SetWaitFormDescription("Fetching Data");
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadEmpMst ");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    EmployeeGrid.DataSource = ds.Tables[0];
                    EmployeeGridView.BestFitColumns();
                }
                else
                {
                    EmployeeGrid.DataSource = null;
                }
                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Trim());
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void EmployeeGrid_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(null, e);
        }

        private void FrmEmployeeSalaryMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            FillGrid();
        }

        private void EmployeeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEdit_Click(null, e);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {
                var row = EmployeeGridView.GetDataRow(EmployeeGridView.FocusedRowHandle);
                var frm = new FrmEmployeeSalaryMstEdit();
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                frm.Text = "Employee Salary Addition";
                frm.S1 = btnAdd.Text;
                frm.Empcode = row["EmpCode"].ToString();
                frm.ShowDialog();
                FillGrid();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                var row = EmployeeGridView.GetDataRow(EmployeeGridView.FocusedRowHandle);
                var frm = new FrmEmployeeSalaryMstEdit();
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                frm.Text = "Employee Salary Editing";
                frm.Empcode = row["EmpCode"].ToString();
                frm.S1 = btnEdit.Text;
                frm.ShowDialog();
                FillGrid();
            }
        }
    }
}
