﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HumanResourceManagementSystem;
using SeqKartLibrary;
using SeqKartLibrary.CrudTask;
using SeqKartLibrary.HelperClass;
using SeqKartLibrary.Models;
using System;
using System.Collections.Generic;
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

        private void SetMyControls1()
        {

            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);

            ProjectFunctions.XtraFormVisualize(this);
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGatePassLaoding_Load(object sender, EventArgs e)
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

        private void gridControl_AttendanceData_DoubleClick(object sender, EventArgs e)
        {
            gridView_AttendanceData.SetMasterRowExpanded(0, false);
            gridView_AttendanceData.SetMasterRowExpanded(1, true);
            DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(gridControl_AttendanceData, e).Handled = true;

            PrintLogWin.PrintLog("*[ gridControl_AttendanceData_DoubleClick ]*");

            OnClickRow();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenAttendanceForm(btnAdd.Text, string.Empty, DateTime.Now + string.Empty);


        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            AddAttendanceDetails addAttendanceDetails = new AddAttendanceDetails() { s1 = btnAdd2.Text, Text = "Add Addendance Details" }; ;
            addAttendanceDetails.StartPosition = FormStartPosition.CenterScreen;

            addAttendanceDetails.ShowDialog(Parent);

        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void txtEmpCode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpCode_KeyDown(object sender, KeyEventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SFeedingGrid.DataSource = null;
            dt.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
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



        private void gridControl_AttendanceData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("show");
        }


        private void gridControl_AttendanceData_Load(object sender, EventArgs e)
        {


        }

        private void SetMyControls2()
        {
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.GirdViewVisualize(gridView_AttendanceData);
            GridEvents();
        }
        private void FillDataToGrid()
        {
            PrintLogWin.PrintLog("FillGrid ******************** " + GlobalVariables.ProgCode);
            try
            {
                DataSet ds = ProjectFunctions.GetDataSet("Select ProgProcName,ProgDesc from ProgramMaster Where ProgCode='" + GlobalVariables.ProgCode + "'");
                string ProcedureName = ds.Tables[0].Rows[0]["ProgProcName"].ToString();

                PrintLogWin.PrintLog("FillGrid => ProcedureName ******************** " + ProcedureName);

                DataSet dsMaster = ProjectFunctionsUtils.GetDataSet(ProcedureName);
                FillTable(dsMaster);
                AddUnboundColumn();
                AddButtonToGrid();


            }
            catch (Exception ex)
            {
                MessageBox_Debug.ShowBox("frmMaster => FillGrid() => " + ex);
            }
        }

        private void FillTable(DataSet dsMaster)
        {
            gridView_AttendanceData.Columns.Clear();

            using (SEQKARTNewEntities db = new SEQKARTNewEntities())
            {
                BindingList<EmployeeAttendance> binding_list = new BindingList<EmployeeAttendance>();

                List<EmployeeAttendance> employeeAttendances_List = db.EmployeeAttendances.OrderByDescending(s => s.entry_date).ToList();
                gridControl_AttendanceData.DataSource = employeeAttendances_List;
                gridView_AttendanceData.BestFitColumns();

                foreach (var item in employeeAttendances_List)
                {
                    EmployeeAttendance employeeAttendance = new EmployeeAttendance
                    {
                        serial_id = item.serial_id,
                        shift_id = item.shift_id,
                        status_id = item.status_id,
                        employee_code = item.employee_code,
                        attendance_date = item.attendance_date,
                        attendance_in_first = item.attendance_in_first,
                        attendance_out_first = item.attendance_out_first,
                        attendance_source = item.attendance_source
                    };

                    employeeAttendances_List.Add(employeeAttendance);
                }
                gridControl_AttendanceData.DataSource = binding_list;

            }
        }

        private void AddUnboundColumn()
        {
            GridColumn unbColumn = gridView_AttendanceData.Columns.AddField("Action");
            unbColumn.VisibleIndex = gridView_AttendanceData.Columns.Count;
            unbColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
        }


        private void GridEvents()
        {
            PrintLogWin.PrintLog("*[ GridEvents ]*");



            gridView_AttendanceData.ShowingEditor += gridView_UserMaster_ShowingEditor;

            gridView_AttendanceData.DoubleClick += gridControl_AttendanceData_DoubleClick;


        }

        private void AddButtonToGrid()
        {
            PrintLogWin.PrintLog("*[ AddButtonToGrid ]*");


            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit
            {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            };
            edit.ButtonClick += edit_ButtonClick;
            edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;

            EditorButton button = edit.Buttons[0];

            button.ImageOptions.Image = WindowsFormsApplication1.Properties.Resources.Edit_16x16;
            button.ImageOptions.Location = ImageLocation.MiddleCenter;
            button.Caption = "Edit";
            button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;

            button.Appearance.BackColor = Color.Red;
            button.Appearance.Options.UseBackColor = true;
            button.Appearance.BorderColor = Color.Transparent;


            button.Appearance.Options.UseBackColor = true;
            button.Appearance.BackColor = Color.Transparent;

            GridColumn actionColumn = gridView_AttendanceData.Columns["Action"];
            actionColumn.ColumnEdit = edit;
            actionColumn.OptionsColumn.AllowEdit = true;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }

        //https://supportcenter.devexpress.com/ticket/details/a2934/how-to-handle-a-double-click-on-a-grid-row-or-cell
        void gridView_UserMaster_ShowingEditor(object sender, CancelEventArgs e)
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

        BaseEdit editor;
        private void gridView_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            editor = view.ActiveEditor;
            editor.DoubleClick += editor_DoubleClick;
        }

        void gridView_HiddenEditor(object sender, EventArgs e)
        {
            editor.DoubleClick -= editor_DoubleClick;
            editor = null;
        }

        void editor_DoubleClick(object sender, EventArgs e)
        {
            BaseEdit editor = (BaseEdit)sender;
            GridControl grid = editor.Parent as GridControl;
            GridView view = grid.FocusedView as GridView;
            Point pt = grid.PointToClient(Control.MousePosition);
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
            }
        }

        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PrintLogWin.PrintLog("*[ edit_ButtonClick ]*");
            OnClickRow();

        }

        private void btnLoad_Data_Click(object sender, EventArgs e)
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
