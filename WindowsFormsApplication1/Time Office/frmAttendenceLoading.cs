﻿using Dapper;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using HumanResourceManagementSystem;
using SeqKartLibrary;
using SeqKartLibrary.CrudTask;
using SeqKartLibrary.HelperClass;
using SeqKartLibrary.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApplication1.Prints;
using WindowsFormsApplication1.Time_Office;

namespace WindowsFormsApplication1.Forms_Master
{

    public partial class frmAttendanceLoading : XtraForm
    {
        private DataTable dt = new DataTable();
        public frmAttendanceLoading()
        {
            InitializeComponent();

            btnRefresh.Visible = false;
            btnLoad.Visible = false;
            btnSave.Visible = false;
            btnAdd2.Visible = false;
            btnQuit.Visible = false;
            toolStripButton1.Visible = false;

            //gridView_AttendanceData.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
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
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmExcelDataLoading_Load(object sender, EventArgs e)
        {
            PrintLogWin.PrintLog("*[ frmExcelDataLoading_Load ]*");
            //SetMyControls();
            SetMyControls2();

            LoadAttendanceDataGrid();

        }


        public void LoadAttendanceDataGrid()
        {
            //ProgramMasterModel programMaster = ProgramMasterData.GetProgramMasterModel(GlobalVariables.ProgCode);

            //DataSet ds = ProjectFunctions.GetDataSet("Select ProgProcName,ProgDesc from ProgramMaster Where ProgCode='" + GlobalVariables.ProgCode + "'");
            //string ProcedureName = ds.Tables[0].Rows[0]["ProgProcName"].ToString();

            PrintLogWin.PrintLog("LoadAttendanceDataGrid => GlobalVariables.ProgCode ******************** " + GlobalVariables.ProgCode);
            //PrintLogWin.PrintLog("LoadAttendanceDataGrid => ProcedureName Dapper ******************** " + programMaster.ProgProcName);
            //PrintLogWin.PrintLog("LoadAttendanceDataGrid => ProcedureName B ******************** " + ProcedureName);


            //List<AttendanceModel> att = ProgramMasterData.GetData<AttendanceModel>(GlobalVariables.ProgCode);
            //PrintLogWin.PrintLog("LoadAttendanceDataGrid => att ******************** " + att.Count);


            gridView_AttendanceData.Columns.Clear();

            string _params = "'" + txtEmpCode.EditValue + "', '" + ConvertTo.DateTimeVal(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "'";
            DataSet att_ds = ProgramMasterData.GetData(GlobalVariables.ProgCode, _params, "_v2");

            if (ComparisonUtils.IsNotNull_DataSet(att_ds))
            {
                BindingList<object> binding_list = new BindingList<object>();

                foreach (DataRow dr in att_ds.Tables[0].Rows)

                {
                    var employeeAttendance = new
                    {
                        SerialId = dr[Col.EmployeeAttendance.serial_id],
                        //EntryDate = dr[Col.EmployeeAttendance.entry_date],
                        AttendanceDate = ConvertTo.DateFormatApp(dr[Col.EmployeeAttendance.attendance_date]),
                        EmployeeCode = dr[Col.EmployeeAttendance.employee_code],
                        //Shift = dr[Col.DailyShifts.shift_name],
                        Status = dr[Col.AttendanceStatus.status],
                        TimeIn_First = ConvertTo.TimeSpanString(dr[Col.EmployeeAttendance.attendance_in_first]),
                        TimeOut_First = ConvertTo.TimeSpanString(dr[Col.EmployeeAttendance.attendance_out_first]),
                        TimeIn_Last = ConvertTo.TimeSpanString(dr[Col.EmployeeAttendance.attendance_in_last]),
                        TimeOut_Last = ConvertTo.TimeSpanString(dr[Col.EmployeeAttendance.attendance_out_last]),
                        WorkingHours = dr[Col.EmployeeAttendance.working_hours],
                        OverTime = dr[Col.EmployeeAttendance.ot_deducton_time],
                        OverTime_1 = ConvertTo.IntVal(dr[Col.EmployeeAttendance.ot_deducton_time_1]),
                        GatePassTime = dr[Col.EmployeeAttendance.gate_pass_time],
                        Source = dr[Col.AttendanceSource.source_name],
                        RowStyle = dr[Col.GridStyle.Row_Style]
                    };
                    //ConvertTo.DateTimeVal(dr[Col.EmployeeAttendance.attendance_in_first]).ToString("hh:mm tt")

                    binding_list.Add(employeeAttendance);
                }

                gridControl_AttendanceData.DataSource = binding_list;
                if (gridView_AttendanceData.Columns["SerialId"] != null)
                {
                    gridView_AttendanceData.Columns["SerialId"].Visible = false;
                }
                if (gridView_AttendanceData.Columns["EmployeeCode"] != null)
                {
                    gridView_AttendanceData.Columns["EmployeeCode"].Visible = false;
                }
                if (gridView_AttendanceData.Columns["RowStyle"] != null)
                {
                    gridView_AttendanceData.Columns["RowStyle"].Visible = false;
                }
                if (gridView_AttendanceData.Columns["OverTime_1"] != null)
                {
                    gridView_AttendanceData.Columns["OverTime_1"].Visible = false;
                }

                if (binding_list.Count > 0)
                {
                    //GridColumnSummaryItem item1 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "GatePassTime", "MAX GatePassTime={0}");
                    //GridColumnSummaryItem item2 = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min, "GatePassTime", "MIN GatePassTime={0}");
                    //gridView_AttendanceData.Columns["GatePassTime"].Summary.Add(item1);
                    //gridView_AttendanceData.Columns["GatePassTime"].Summary.Add(item2);

                    //gridView_AttendanceData.Columns["WorkingHours"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "WorkingHours", "Avg={0:n2}");
                    //gridView_AttendanceData.Columns["WorkingHours"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "WorkingHours", "Sum={0}");
                    //GridColumnSummaryItem item = new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "WorkingHours", "Max={0}");
                    //gridView_AttendanceData.Columns["WorkingHours"].Summary.Add(item);

                    //gridView_AttendanceData.Columns["OverTime"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "OverTime_1", "Total OverTime={0}",);
                    /*
                                        GridColumnSummaryItem item = new GridColumnSummaryItem();
                                        item.SummaryType = DevExpress.Data.SummaryItemType.Custom;

                                        item.Tag = "OverTime_Summary";
                                        gridView_AttendanceData.Columns["OverTime"].Summary.Add(item);
                    */
                    //item = new GridColumnSummaryItem();
                    //item.SummaryType = DevExpress.Data.SummaryItemType.Custom;
                    //item.Tag = "2";
                    //gridView_AttendanceData.Columns["OverTime"].Summary.Add(item);

                    gridView_AttendanceData.Columns["OverTime_1"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "OverTime_1", string.Empty);
                    gridView_AttendanceData.Columns["OverTime"].Summary.Add(DevExpress.Data.SummaryItemType.Custom);

                    gridView_AttendanceData.UpdateTotalSummary();

                }

            }

        }

        private void gridView_AttendanceData_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.IsTotalSummary && (e.Item as GridSummaryItem).FieldName == "OverTime")
            {
                GridSummaryItem item = e.Item as GridSummaryItem;
                if (item.FieldName == "OverTime")
                {
                    e.TotalValue = ConvertTo.MinutesToHours(view.Columns["OverTime_1"].SummaryText);
                }
            }


        }
        bool IsInvalidValue(object value)
        {
            return true;
        }
        private void gridView_AttendanceData_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if (IsInvalidValue(e.Info.Value))
            {
                int dx = e.Bounds.Height;
                Brush brush = e.Cache.GetGradientBrush(e.Bounds, Color.Wheat, Color.FloralWhite, LinearGradientMode.Vertical);
                Rectangle r = e.Bounds;
                //Draw a 3D border
                BorderPainter painter = BorderHelper.GetPainter(DevExpress.XtraEditors.Controls.BorderStyles.Style3D);
                AppearanceObject borderAppearance = new AppearanceObject(e.Appearance)
                {
                    BorderColor = Color.DarkGray
                };
                painter.DrawObject(new BorderObjectInfoArgs(e.Cache, borderAppearance, r));
                //Fill the inner region of the cell
                r.Inflate(-1, -1);
                e.Cache.FillRectangle(brush, r);
                //Draw a summary value
                r.Inflate(-2, 0);
                e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r);
                //Prevent default drawing of the cell
                e.Handled = true;

                /*
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Near;
                Rectangle r = e.Bounds;
                r.Inflate(-2, 0);
                Font f = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);

                e.Appearance.BackColor = Color.FromArgb(50, 255, 0, 0);
                e.Appearance.DrawString(e.Cache, e.Info.DisplayText, r, f, format);
                */
                /*
                e.Appearance.BackColor = Color.FromArgb(50, 255, 0, 0);
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Info.AllowDrawBackground = false;
                */
            }
        }

        private void OpenAttendanceForm(int _serial_id, string _employee_code, string _attendance_date)
        {

            XtraForm_EmployeeAttendance xtraForm_EmployeeAttendence = new XtraForm_EmployeeAttendance(this, _serial_id, "frmAttendenceLoading => Add Button", _employee_code, _attendance_date)
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            xtraForm_EmployeeAttendence.ShowDialog(Parent);

            //xtraForm_EmployeeAttendence.ChildWantedSomething += ReloadDataGrid;
        }

        public void ReloadDataGrid(object sender, ThresholdReachedEventArgs e)
        {
            if (ConvertTo.DateTimeVal(DtStartDate.EditValue) == e.AttendanceDate && IsString.IsEqualTo(txtEmpCode.EditValue, e.EmpCode))
            {

            }
            else
            {
                DtStartDate.EditValue = e.AttendanceDate;
                txtEmpCode.EditValue = e.EmpCode;


                var ds = ProjectFunctions.GetDataSet("SELECT     empmst.EmpCode, empmst.EmpName, DeptMst.DeptDesc FROM         empmst LEFT OUTER JOIN DeptMst ON empmst.EmpDeptCode = DeptMst.DeptCode Where EmpCode='" + txtEmpCode.Text.Trim() + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtEmpCode.Text = ds.Tables[0].Rows[0]["EmpCode"].ToString();
                    txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();

                    lblemp.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();



                    //Thread.Sleep(1000);

                    btnLoad_Data.PerformClick();//.Focus();
                }
            }


            //LoadAttendanceDataGrid();
            PrintLogWin.PrintLog("---------------------------------");
        }

        private void OnClickRow()
        {
            try
            {
                //DataRow CurrentRow = gridView_AttendanceData.GetDataRow(gridView_AttendanceData.FocusedRowHandle);
                int row = (gridControl_AttendanceData.FocusedView as ColumnView).FocusedRowHandle;
                ColumnView detailView = (ColumnView)gridControl_AttendanceData.FocusedView;
                int cellValue_serial_id = ConvertTo.IntVal(detailView.GetFocusedRowCellValue("SerialId"));//.GetRowCellValue(row, "Edit_Link").ToString();
                                                                                                          //
                string employee_code = detailView.GetFocusedRowCellValue("EmployeeCode").ToString();
                string attendance_date = ConvertTo.DateFormatDb(detailView.GetFocusedRowCellValue("AttendanceDate").ToString());

                PrintLogWin.PrintLog("%%%%%%%%%%%%%%%%" + cellValue_serial_id);
                PrintLogWin.PrintLog("%%%%%%%%%%%%%%%%" + row);

                //MessageBox.Show(CurrentRow[0] + "");


                OpenAttendanceForm(cellValue_serial_id, employee_code, attendance_date);
            }
            catch (Exception ex)
            {
                PrintLogWin.PrintLog("%%%%%%%%%%%%%%%% => Exception : " + ex);
            }

        }

        private void gridControl_AttendanceData_DoubleClick(object sender, EventArgs e)
        {

            //gridView_AttendanceData.SetMasterRowExpanded(0, false);
            //gridView_AttendanceData.SetMasterRowExpanded(1, true);
            //DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(gridControl_AttendanceData, e).Handled = true;

            PrintLogWin.PrintLog("*[ gridControl_AttendanceData_DoubleClick ]*");

            OnClickRow();
        }

        private void gridView_AttendanceData_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                    GridColumn clumn = View.Columns["RowStyle"];
                    if (clumn != null)
                    {
                        string row_style = View.GetRowCellDisplayText(e.RowHandle, clumn);
                        if (ComparisonUtils.IsNotEmpty(row_style))
                        {
                            string[] arr = row_style.Split('-');

                            if (arr.Length == 1)
                            {
                                Color color_1 = System.Drawing.ColorTranslator.FromHtml(arr[0]);
                                e.Appearance.BackColor = color_1;
                            }
                            if (arr.Length == 2)
                            {
                                Color color_1 = System.Drawing.ColorTranslator.FromHtml(arr[0]);
                                Color color_2 = System.Drawing.ColorTranslator.FromHtml(arr[1]);

                                e.Appearance.BackColor = color_1;
                                e.Appearance.BackColor2 = color_2;
                            }

                            e.HighPriority = true;
                        }
                    }
                    //GridColumn clumn = View.Columns["Status"];
                    //if (clumn != null)
                    //{
                    //    string category = View.GetRowCellDisplayText(e.RowHandle, clumn);
                    //    if (category == "RR - Sunday")
                    //    {
                    //        e.Appearance.BackColor = Color.Salmon;
                    //        e.Appearance.BackColor2 = Color.SeaShell;
                    //        e.HighPriority = true;
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenAttendanceForm(0, string.Empty, string.Empty);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {

            //XtraForm_EmployeeAttendence xtraForm_EmployeeAttendence = new XtraForm_EmployeeAttendence() { s1 = btnAdd.Text, Text = "User Addition" }; ;


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
            //txtEmpName.Text = string.Empty;
            //txtDept.Text = string.Empty;

            //txtPreviousInstlmnt.Text = "0";


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
                        txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                        lblemp.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                        //txtDept.Text = ds.Tables[0].Rows[0]["DeptDesc"].ToString();

                        //LastInstlmnt();
                        //txtLoanAmount.Focus();
                        // btnLoad_Data.Focus();
                        btnLoad_Data_Click(sender, e);
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
                txtEmpName.Text = row["EmpName"].ToString();
                lblemp.Text = row["EmpName"].ToString();
                //txtDept.Text = row["DeptDesc"].ToString();
                HelpGrid.Visible = false;
                btnLoad_Data.Focus();

                //LastInstlmnt();
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
        /////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////

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

        private void SetMyControls2()
        {
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.GirdViewVisualize(gridView_AttendanceData);
            GridEvents();
        }


        private void GridEvents()
        {
            PrintLogWin.PrintLog("*[ GridEvents ]*");


            //Disableed

            //gridControl_AttendanceData.Load += gridControl_AttendanceData_Load;
            //In Non-Editable Mode
            gridView_AttendanceData.ShowingEditor += gridView_UserMaster_ShowingEditor;
            //gridView_UserMaster.DoubleClick += gridView_DoubleClick;

            //gridControl_AttendanceData.DoubleClick += gridControl_AttendanceData_DoubleClick;
            gridView_AttendanceData.DoubleClick += gridControl_AttendanceData_DoubleClick;


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

        private void btnLoad_Data_Click(object sender, EventArgs e)
        {
            if (ValidateData_GridLoad())
            {
                LoadAttendanceDataGrid();

            }

        }

        private bool ValidateData_GridLoad()
        {
            if (txtEmpCode.Text.Trim().Length == 0)
            {
                //XtraMessageBox.Show("Invalid Emp Code", "Inalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectFunctions.SpeakError("Enter Employee Code");
                txtEmpCode.Focus();
                return false;
            }
            return true;
        }

        private void Report_Print_Preview(string action)
        {
            XtraReport_EmployeeAttendance Xtra_Report_EmployeeAttendanceList = new XtraReport_EmployeeAttendance();

            DynamicParameters paramSalary = new DynamicParameters();
            paramSalary.Add("@Emp_Code_Processing", txtEmpCode.EditValue);
            paramSalary.Add("@Salary_Month", DtStartDate.EditValue);
            paramSalary.Add("@Deduct_Advance", 1);
            paramSalary.Add("@Deduct_Loan", 1);
            paramSalary.Add("@TeaRate", 0);
            paramSalary.Add("@NoOfCups", 0);


            DynamicParameters param = new DynamicParameters();
            param.Add("@EmpCode", txtEmpCode.EditValue);
            param.Add("@Attendance_Month", DtStartDate.EditValue);

            DynamicParameters paramEmp = new DynamicParameters();
            paramEmp.Add("@EmpCode", txtEmpCode.EditValue);

            ProgramMasterModel programMaster = ProgramMasterData.GetProgramMasterModel(GlobalVariables.ProgCode);



            EmployeeAttendanceDetails_Model employeeAttendanceDetails_Model = new EmployeeAttendanceDetails_Model
            {
                EmpCode = txtEmpCode.EditValue + string.Empty,
                AttendanceMonth = ConvertTo.DateTimeVal(DtStartDate.EditValue),
                EmployeeAttendance_Get_List = EmployeeData.EmployeeAttendance_Get(programMaster.ProgProcName + "_v2", param),
                EmployeesSalaryList = EmployeeData.GetEmployeesSalaryList("sp_Salary_Process", paramSalary),
                EmployeeMasterDataList = EmployeeData.GetEmployeeMasterDataList("sp_LoadEmpMstFEditing", paramEmp)
            };
            //EmployeeMasterModel
            attendanceBindingSource.DataSource = employeeAttendanceDetails_Model;

            Xtra_Report_EmployeeAttendanceList.DataSource = attendanceBindingSource;

            //MessageBox.Show(employeeAttendanceDetails_Model.EmployeesSalaryList.Count + "");

            ReportPrintTool tool = new ReportPrintTool(Xtra_Report_EmployeeAttendanceList);

            if (action.Equals("preview"))
            {
                tool.ShowRibbonPreviewDialog();
            }
            if (action.Equals("print"))
            {
                tool.PrintDialog();
            }


        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (ComparisonUtils.IsEmpty(DtStartDate.EditValue) || ComparisonUtils.IsEmpty(txtEmpCode.EditValue))
            {
                ProjectFunctions.SpeakError("Enter Attendance Month and Employee Code");
                txtEmpCode.Focus();
            }
            else
            {
                Report_Print_Preview("preview");
            }

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (ComparisonUtils.IsEmpty(DtStartDate.EditValue) || ComparisonUtils.IsEmpty(txtEmpCode.EditValue))
            {
                ProjectFunctions.SpeakError("Enter Attendance Month and Employee Code");
                txtEmpCode.Focus();
            }
            else
            {
                Report_Print_Preview("print");
            }

        }

        private void btnExportXsls_Click(object sender, EventArgs e)
        {
            if (ComparisonUtils.IsEmpty(DtStartDate.EditValue) || ComparisonUtils.IsEmpty(txtEmpCode.EditValue))
            {
                ProjectFunctions.SpeakError("Enter Attendance Month and Employee Code");
                txtEmpCode.Focus();
            }
            else
            {
                string path = txtEmpCode.EditValue + "_Attendance_For_Month_" + ConvertTo.DateFormatDb(DtStartDate.EditValue) + ".xlsx";
                gridControl_AttendanceData.ExportToXlsx(path);
                // Open the created XLSX file with the default application.
                Process.Start(path);
            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
