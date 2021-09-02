using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SeqKartLibrary.CrudTask;
using SeqKartLibrary.HelperClass;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms_Master
{

    public partial class FrmGatePassLoading : XtraForm
    {
        private DataTable dt = new DataTable();
        public FrmGatePassLoading()
        {
            InitializeComponent();

            btnRefresh.Visible = false;
            btnLoad.Visible = false;
            btnSave.Visible = false;
            btnAdd2.Visible = false;
            btnQuit.Visible = false;
            toolStripButton1.Visible = false;

            gridView_AttendanceData.OptionsBehavior.Editable = false;

            dt.Columns.Add("MonthYear", typeof(string));
            dt.Columns.Add("EmpCode", typeof(string));
            dt.Columns.Add("EmpName", typeof(string));
            dt.Columns.Add("EmpDW", typeof(decimal));
            dt.Columns.Add("EmpPH", typeof(decimal));
            dt.Columns.Add("EmpEL", typeof(decimal));
            dt.Columns.Add("EmpCL", typeof(decimal));
            dt.Columns.Add("EmpSL", typeof(decimal));
            dt.Columns.Add("EmpPymtMode", typeof(string));
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGatePassLaoding_Load(object sender, EventArgs e)
        {
            PrintLogWin.PrintLog("*[ frmGatePassLaoding_Load ]*");

            SetMyControls2();

            LoadGatePassDataGrid(true);

        }

        public void LoadGatePassDataGrid(bool onFormLoad)
        {
            PrintLogWin.PrintLog("LoadGatePassDataGrid => GlobalVariables.ProgCode ******************** : " + GlobalVariables.ProgCode);
            try
            {
                gridView_AttendanceData.Columns.Clear();

                string _params = "'" + txtEmpCode.EditValue + "', '" + ConvertTo.DateTimeVal(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "'";
                DataSet ds = ProgramMasterData.GetData(GlobalVariables.ProgCode, _params);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    gridControl_AttendanceData.DataSource = ds.Tables[0];
                    gridView_AttendanceData.BestFitColumns();
                }
                else
                {
                    gridControl_AttendanceData.DataSource = null;

                    if (!onFormLoad)
                    {
                        ProjectFunctions.SpeakError("There is no data in this Query");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString().Trim());
            }
        }
        public void LoadGatePassDataGrid_Obsoulete()
        {


            PrintLogWin.PrintLog("LoadGatePassDataGrid => GlobalVariables.ProgCode ******************** " + GlobalVariables.ProgCode);


            gridView_AttendanceData.Columns.Clear();

            string _params = "'" + txtEmpCode.EditValue + "', '" + ConvertTo.DateTimeVal(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "'";
            DataSet att_ds = ProgramMasterData.GetData(GlobalVariables.ProgCode, _params);

            if (ComparisonUtils.IsNotNull_DataSet(att_ds))
            {
                gridControl_AttendanceData.DataSource = att_ds;

            }

        }

        private void OpenAttendanceForm(string _s1, string _employee_code, string _attendance_date)
        {
            if (btnAdd.Enabled)
            {
                try
                {
                    var frm = new Forms_Transaction.frmGatePassTimeAddEdit() { s1 = _s1, employee_code = _employee_code, attendance_date = _attendance_date };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.Text = "Gate Pass Entry";

                    frm.ShowDialog();

                    LoadGatePassDataGrid(onFormLoad: false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void OnClickRow()
        {

            int row = (gridControl_AttendanceData.FocusedView as ColumnView).FocusedRowHandle;
            ColumnView detailView = (ColumnView)gridControl_AttendanceData.FocusedView;

            string employee_code = detailView.GetFocusedRowCellValue("EmpCode").ToString();
            string gate_pass_date = detailView.GetFocusedRowCellValue("GatePassDate").ToString();

            PrintLogWin.PrintLog("%%%%%%%%%%%%%%%%" + row);

            PrintLogWin.PrintLog("%%%%%%%%%%%%%%%% employee_code " + employee_code);
            PrintLogWin.PrintLog("%%%%%%%%%%%%%%%% gate_pass_date " + gate_pass_date);




            OpenAttendanceForm("Edit", employee_code, gate_pass_date);
        }

        private void GridControl_AttendanceData_DoubleClick(object sender, EventArgs e)
        {
            gridView_AttendanceData.SetMasterRowExpanded(0, false);
            gridView_AttendanceData.SetMasterRowExpanded(1, true);
            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(gridControl_AttendanceData, e).Handled = true;

            PrintLogWin.PrintLog("*[ gridControl_AttendanceData_DoubleClick ]*");

            OnClickRow();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenAttendanceForm(btnAdd.Text, string.Empty, DateTime.Now + string.Empty);


        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {

            AddAttendanceDetails addAttendanceDetails = new AddAttendanceDetails() { s1 = btnAdd2.Text, Text = "Add Attendance Details" }; ;
            addAttendanceDetails.StartPosition = FormStartPosition.CenterScreen;

            addAttendanceDetails.ShowDialog(Parent);

        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void TxtEmpCode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "EmpCode";
                if (txtEmpCode.Text.Length == 0)
                {
                    var ds = ProjectFunctions.GetDataSet("SELECT     empmst.EmpCode, empmst.EmpName, DeptMst.DeptDesc FROM         empmst LEFT OUTER JOIN DeptMst ON empmst.EmpDeptCode = DeptMst.DeptCode ");
                    HelpGrid.DataSource = ds.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Show();
                    HelpGrid.Focus();
                }
                else
                {
                    var ds = ProjectFunctions.GetDataSet("SELECT     empmst.EmpCode, empmst.EmpName, DeptMst.DeptDesc FROM         empmst LEFT OUTER JOIN DeptMst ON empmst.EmpDeptCode = DeptMst.DeptCode Where EmpCode='" + txtEmpCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEmpCode.Text = ds.Tables[0].Rows[0]["EmpCode"].ToString();

                        btnLoad_Data.Focus();
                    }
                    else
                    {
                        var ds1 = ProjectFunctions.GetDataSet("SELECT  empmst.EmpCode, empmst.EmpName, DeptMst.DeptDesc FROM  empmst LEFT OUTER JOIN DeptMst ON empmst.EmpDeptCode = DeptMst.DeptCode");
                        HelpGrid.DataSource = ds1.Tables[0];
                        HelpGridView.BestFitColumns();
                        HelpGrid.Show();
                        HelpGrid.Focus();
                    }
                }
            }
            e.Handled = true;
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            var row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "EmpCode")
            {
                txtEmpCode.Text = row["EmpCode"].ToString();

                HelpGrid.Visible = false;
                btnLoad_Data.Focus();


            }


        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
        }

        private void HelpGrid_Click(object sender, EventArgs e)
        {
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            SFeedingGrid.DataSource = null;
            dt.Clear();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SFeedingGrid.Refresh();
            var xlConn = string.Empty;
            xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter("SELECT MonthYear,EmpCode,EmpName,EmpDW,EmpPH,EmpEL,EmpCL,EmpSL,EmpPymtMode FROM [Sheet1$]", xlConn))
            {
                myCommand.Fill(dt);
                SFeedingGrid.DataSource = dt;
                SFeedingGridView.BestFitColumns();
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            var ds1 = new DataSet();
            var ds2 = new DataSet();
#pragma warning disable CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'
            var MaxRow = ((SFeedingGrid.KeyboardFocusView as GridView).RowCount);
#pragma warning restore CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'
            for (var i = 0; i < MaxRow; i++)
            {
                var currentrow = SFeedingGridView.GetDataRow(i);
                var str1 = "Select EmpCode,EmpName from EmpMst where   EmpCode='" + currentrow["EmpCode"].ToString().PadLeft(5, '0') + "'";
                ds1 = ProjectFunctions.GetDataSet(str1);

                if (ds1.Tables[0].Rows.Count > 0)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpName"], ds1.Tables[0].Rows[0]["EmpName"].ToString());

                }
                else
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpCode"], "XXXXXXXXXXXXXXXXXXX");
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpName"], "XXXXXXXXXXXXXXXXXXX");
                    XtraMessageBox.Show("Invalid Dept ");
                }

            }
            SFeedingGridView.BestFitColumns();
        }

        private bool ValidateData()
        {
#pragma warning disable CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'
            var MaxRow = ((SFeedingGrid.KeyboardFocusView as GridView).RowCount);
#pragma warning restore CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'

            for (var i = 0; i < MaxRow; i++)
            {
                var currentrow = SFeedingGridView.GetDataRow(i);
                if (currentrow["EmpName"].ToString().Contains("x") || currentrow["EmpName"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Invalid Employee Name");
                    return false;
                }
                if (currentrow["EmpDW"].ToString() == string.Empty)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpDW"], "0");
                }
                if (currentrow["EmpPH"].ToString() == string.Empty)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpPH"], "0");
                }
                if (currentrow["EmpEL"].ToString() == string.Empty)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpEL"], "0");
                }
                if (currentrow["EmpCL"].ToString() == string.Empty)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpCL"], "0");
                }
                if (currentrow["EmpSL"].ToString() == string.Empty)
                {
                    SFeedingGridView.SetRowCellValue(i, SFeedingGridView.Columns["EmpSL"], "0");
                }

                if (currentrow["EmpPymtMode"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Invalid Payment Mode");
                    return false;
                }
                if (currentrow["MonthYear"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Invalid Month Year");
                    return false;
                }
            }
            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'
            var MaxRow = ((SFeedingGrid.KeyboardFocusView as GridView).RowCount);
#pragma warning restore CS0618 // 'GridControl.KeyboardFocusView' is obsolete: 'Use the FocusedView property instead.'
            if (ValidateData())
            {
                using (var con = new SqlConnection(ProjectFunctions.ConnectionString))
                {
                    con.Open();
                    var cmd = new SqlCommand
                    {
                        Connection = con
                    };

                    for (var i = 0; i < MaxRow; i++)
                    {
                        var currentrow = SFeedingGridView.GetDataRow(i);
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "Insert into AtnData(MonthYear,EmpCode,EmpDW,EmpPH,EmpEL,EmpCL,EmpSL,EmpPymtMode)values(@MonthYear,@EmpCode,@EmpDW,@EmpPH,@EmpEL,@EmpCL,@EmpSL,@EmpPymtMode)";
                        cmd.Parameters.Add("@MonthYear", SqlDbType.NVarChar).Value = currentrow["MonthYear"].ToString();
                        cmd.Parameters.Add("@EmpCode", SqlDbType.NVarChar).Value = currentrow["EmpCode"].ToString().PadLeft(5, '0');
                        cmd.Parameters.Add("@EmpDW", SqlDbType.NVarChar).Value = currentrow["EmpDW"].ToString();
                        cmd.Parameters.Add("@EmpPH", SqlDbType.NVarChar).Value = currentrow["EmpPH"].ToString();
                        cmd.Parameters.Add("@EmpEL", SqlDbType.NVarChar).Value = currentrow["EmpEL"].ToString();
                        cmd.Parameters.Add("@EmpCL", SqlDbType.NVarChar).Value = currentrow["EmpCL"].ToString();
                        cmd.Parameters.Add("@EmpSL", SqlDbType.NVarChar).Value = currentrow["EmpSL"].ToString();
                        cmd.Parameters.Add("@EmpPymtMode", SqlDbType.NVarChar).Value = currentrow["EmpPymtMode"].ToString();

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
            SFeedingGrid.DataSource = null;
        }

        private void SetMyControls2()
        {
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.GirdViewVisualize(gridView_AttendanceData);
            GridEvents();
        }


        private void GridEvents()
        {
            PrintLogWin.PrintLog("*[ GridEvents ]*");

            gridView_AttendanceData.ShowingEditor += GridView_UserMaster_ShowingEditor;

            gridView_AttendanceData.DoubleClick += GridControl_AttendanceData_DoubleClick;


        }

        //https://supportcenter.devexpress.com/ticket/details/a2934/how-to-handle-a-double-click-on-a-grid-row-or-cell
        void GridView_UserMaster_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView_AttendanceData.FocusedColumn == gridView_AttendanceData.Columns["Action"])
            {
                PrintLogWin.PrintLog("********************* A ");
                return;
            }
            if (gridView_AttendanceData.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                PrintLogWin.PrintLog("********************* B ");
                e.Cancel = false;
            }
            else
            {
                PrintLogWin.PrintLog("********************* C ");
                e.Cancel = true;
            }
        }

        private void BtnLoad_Data_Click(object sender, EventArgs e)
        {
            if (ValidateData_GridLoad())
            {
                LoadGatePassDataGrid(onFormLoad: false);
            }

        }

        private bool ValidateData_GridLoad()
        {
            if (txtEmpCode.Text.Trim().Length == 0)
            {

                ProjectFunctions.SpeakError("Enter Employee Code");
                txtEmpCode.Focus();
                return false;
            }
            return true;
        }
    }
}
