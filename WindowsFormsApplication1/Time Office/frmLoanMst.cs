using DevExpress.XtraEditors;
using SeqKartLibrary;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms_Master
{
    public partial class FrmLoanMst : DevExpress.XtraEditors.XtraForm
    {

        public string _s1 = null;
        public string _empcode = null;
        public string S1
        {
            get => _s1;
            set => _s1 = value;
        }
        public string Empcode
        {
            get => _empcode;
            set => _empcode = value;
        }
        public FrmLoanMst()
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
            //ProjectFunctions.ButtonVisualize(panelControl1);
            ProjectFunctions.XtraFormVisualize(this);

            ProjectFunctions.GirdViewVisualize(gridView3);

            MainFormButtons.Roles(
                GlobalVariables.ProgCode,
                GlobalVariables.CurrentUser,
                btnAdd, btnEdit, btnDelete, btnPrint);
        }
        private void FillGrid()
        {
            try
            {
                //DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                //SplashScreenManager.Default.SetWaitFormDescription("Fetching Data");
                var ds = new DataSet();
                var strsql = string.Empty;
                strsql = strsql + "sp_LoadLoanMst  '" + DtStartDate.DateTime.Date.ToString("yyyy-MM-dd") + "' , '" + DtEndDate.DateTime.Date.ToString("yyyy-MM-dd") + "'";
                ds = ProjectFunctionsUtils.GetDataSet(strsql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    EmployeeGrid.DataSource = ds.Tables[0];

                    btnView.Visible = false;
                    btnView.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnPrint.Enabled = true;
                    //btnView.ForeColor = Color.White;//.FromArgb(255, 255, 255);

                }
                else
                {
                    btnView.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnPrint.Enabled = false;
                    //btnView.ForeColor = Color.WhiteSmoke;//.FromArgb(235, 236, 239);
                }

                //SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Trim());
            }
        }
        private void FrmLoanMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            DtEndDate.EditValue = DateTime.Now.Date;
            DtStartDate.EditValue = DateTime.Now.AddYears(-1).Date;
            FillGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {
                try
                {
                    var frm = new FrmLoanMstAddEdit();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    S1 = btnAdd.Text.ToString().Trim();
                    frm.S1 = S1;
                    frm.Text = "Loan Addition";
                    frm.ShowDialog();
                    FillGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                try
                {
                    var row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                    var ds = ProjectFunctions.GetDataSet(string.Format(" select LoanPassedBy from LoanMst Where LoanANo='" + row["LoanANo"].ToString() + "'"));
                    if (ds.Tables[0].Rows[0]["LoanPassedBy"].ToString() == string.Empty)
                    {
                        var frm = new FrmLoanMstAddEdit() { LoanNo = row["LoanANo"].ToString(), LoanADate = row["LoanADate"].ToString() };
                        var P = ProjectFunctions.GetPositionInForm(this);
                        frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                        S1 = btnEdit.Text.ToString().Trim();
                        frm.S1 = S1;
                        frm.Text = "Loan Editing";
                        frm.Empcode = row["EmpCode"].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Please UnPass first to perform editing");
                    }
                    FillGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EmployeeGrid_DoubleClick(object sender, EventArgs e)
        {
            BtnEdit_Click(null, e);
        }

        private void EmployeeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEdit_Click(null, e);
            }
        }
        private void Btn_RefreshGridData_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {

            try
            {
                var row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                var ds = ProjectFunctions.GetDataSet(string.Format(" select LoanPassedBy from LoanMst Where LoanANo='" + row["LoanANo"].ToString() + "'"));

                var frm = new FrmLoanMstAddEdit() { LoanNo = row["LoanANo"].ToString(), LoanADate = row["LoanADate"].ToString() };
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                S1 = btnView.Text.ToString().Trim();
                frm.S1 = S1;
                frm.Text = "Loan View";
                frm.Empcode = row["EmpCode"].ToString();
                frm.ShowDialog();

                FillGrid();
            }
            catch (Exception ex)
            {
                PrintLogWin.PrintLog(ex);

            }
        }

        private void GridView3_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var confirmResult = XtraMessageBox.Show("Are you sure you want to close ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var row = gridView3.GetDataRow(gridView3.FocusedRowHandle);
                ProjectFunctions.GetDataSet("update LoanMst Set LoanCloseTag='Y' from LoanMst Where LoanANo ='" + row["LoanANo"].ToString() + "'");
                FillGrid();

            }
        }
    }
}


