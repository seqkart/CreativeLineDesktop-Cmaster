using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmAttendenceFeeding : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public FrmAttendenceFeeding()
        {
            InitializeComponent(); ;
            dt.Columns.Add("attendance_date", typeof(DateTime));
            dt.Columns.Add("status_id", typeof(string));
            dt.Columns.Add("attendance_in_first", typeof(DateTime));
            dt.Columns.Add("attendance_out_first", typeof(DateTime));
            dt.Columns.Add("attendance_in_last", typeof(DateTime));
            dt.Columns.Add("attendance_out_last", typeof(DateTime));
            dt.Columns.Add("ot_deducton_time", typeof(decimal));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("status_code", typeof(string));
            dt.Columns.Add("status_type", typeof(string));
            dt.Columns.Add("working_hours", typeof(Decimal));
            dt.Columns.Add("attendence_in_night", typeof(DateTime));
            dt.Columns.Add("attendence_out_night", typeof(DateTime));
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmpID_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpName.Text = string.Empty;
        }

        private void TxtEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtEmpCode";
                if (txtEmpCode.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("select EmpCode,EmpName from EmpMst");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Show();
                        HelpGrid.Visible = true;
                        HelpGrid.Focus();
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet("select EmpCode,EmpName from EmpMst Where  EmpCode= '" + txtEmpCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEmpCode.Text = ds.Tables[0].Rows[0]["EmpCode"].ToString();
                        txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                        btnLoad.Focus();
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("select EmpCode,EmpName from EmpMst");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds.Tables[0];
                            HelpGrid.Show();
                            HelpGrid.Visible = true;
                            HelpGrid.Focus();
                            HelpGridView.BestFitColumns();
                        }
                        else
                        {
                            ProjectFunctions.SpeakError("No Records To Display");
                        }
                    }
                }
            }
            e.Handled = true;

        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow Row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtEmpCode")
            {
                txtEmpCode.Text = Row["EmpCode"].ToString();
                txtEmpName.Text = Row["EmpName"].ToString();
                HelpGrid.Visible = false;
                btnLoad.Focus();
            }
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

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (DtStartDate.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid MonthYear");
                DtStartDate.Focus();
                return;
            }
            if (txtEmpCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid EmpCode");
                txtEmpCode.Focus();
                return;
            }
            if (txtEmpName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid EmpName");
                txtEmpName.Focus();
                return;
            }


            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadAttendence '" + Convert.ToDateTime(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "','" + txtEmpCode.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
                AttendenceGrid.DataSource = dt;
                AttendenceGridView.BestFitColumns();
            }
            else
            {
                DataSet dsDummy = ProjectFunctions.GetDataSet("sp_LoadDummyAttendence '" + Convert.ToDateTime(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "','" + txtEmpCode.Text + "'");
                if (dsDummy.Tables[0].Rows.Count > 0)
                {
                    dt = dsDummy.Tables[0];
                    AttendenceGrid.DataSource = dt;
                    AttendenceGridView.BestFitColumns();
                }
                else
                {

                    AttendenceGrid.DataSource = null;
                    AttendenceGridView.BestFitColumns();
                }
            }
        }

        private void F_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }


        private void LoadCombobox()
        {
            repositoryItemComboBox1.Items.Clear();
            DataSet ds = ProjectFunctions.GetDataSet("select distinct status_code from AttendanceStatus");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    repositoryItemComboBox2.Items.Add(dr["status_code"].ToString());
                }
            }
        }
        private void FrmAttendenceFeeding_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
        }

        private void AttendenceGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (AttendenceGridView.DataSource != null)
                {
                    DataRow currentrow = AttendenceGridView.GetDataRow(AttendenceGridView.FocusedRowHandle);
                    if (currentrow["status_code"].ToString() == "PP")
                    {

                        if (e.Column.FieldName == "attendance_in_first" || e.Column.FieldName == "attendance_out_first" || e.Column.FieldName == "attendance_in_last" || e.Column.FieldName == "attendance_out_last" || e.Column.FieldName == "attendence_out_night" || e.Column.FieldName == "attendence_in_night")
                        {
                            DateTime startTime = Convert.ToDateTime(currentrow["attendance_in_first"].ToString());
                            DateTime endTime = Convert.ToDateTime(currentrow["attendance_out_last"].ToString());
                            TimeSpan spanattendence = endTime.Subtract(startTime);
                            double TotalMinutes = spanattendence.TotalMinutes;


                            DateTime lunchstartTime = Convert.ToDateTime(currentrow["attendance_out_first"].ToString()); ;
                            DateTime lunchendTime = Convert.ToDateTime(currentrow["attendance_in_last"].ToString());
                            TimeSpan spanbreak = lunchendTime.Subtract(lunchstartTime);
                            double TotalBreakMinutes = spanbreak.TotalMinutes;
                            TotalMinutes -= TotalBreakMinutes;


                            double OvertimeMinutes = 0;


                            if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                            {
                                DateTime overtimestartTime = Convert.ToDateTime(currentrow["attendence_in_night"].ToString());
                                DateTime overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString()).AddDays(1);
                                }
                                else
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                }

                                TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                OvertimeMinutes = spanovertime.TotalMinutes;

                                TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                                OvertimeMinutes -= TotalBreakMinutes;
                            }
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);


                        }
                    }
                    if (currentrow["status_code"].ToString() == "RR" || currentrow["status_code"].ToString() == "HH")
                    {

                        if (e.Column.FieldName == "attendance_in_first" || e.Column.FieldName == "attendance_out_first" || e.Column.FieldName == "attendance_in_last" || e.Column.FieldName == "attendance_out_last" || e.Column.FieldName == "attendence_out_night" || e.Column.FieldName == "attendence_in_night")
                        {
                            double TotalMinutes = 0;
                            double TotalBreakMinutes = 0;
                            double OvertimeMinutes = 0;
                            if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                            {
                                DateTime overtimestartTime = Convert.ToDateTime(currentrow["attendence_in_night"].ToString());
                                DateTime overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString()).AddDays(1);
                                }
                                else
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                }

                                TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                OvertimeMinutes = spanovertime.TotalMinutes;
                                TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                                OvertimeMinutes -= TotalBreakMinutes;
                            }
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);
                        }
                    }

                    if (currentrow["status_code"].ToString() == "PA")
                    {
                        if (e.Column.FieldName == "attendance_in_first" || e.Column.FieldName == "attendance_out_first")
                        {
                            DateTime startTime = Convert.ToDateTime(currentrow["attendance_in_first"].ToString());
                            DateTime endTime = Convert.ToDateTime(currentrow["attendance_out_first"].ToString());
                            TimeSpan spanattendence = endTime.Subtract(startTime);
                            double TotalMinutes = spanattendence.TotalMinutes;

                            double TotalBreakMinutes = 0;
                            TotalMinutes -= TotalBreakMinutes;

                            double OvertimeMinutes = 0;


                            if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                            {
                                DateTime overtimestartTime = Convert.ToDateTime(currentrow["attendence_in_night"].ToString());
                                DateTime overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString()).AddDays(1);
                                }
                                else
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                }

                                TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                OvertimeMinutes = spanovertime.TotalMinutes;

                                TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                                OvertimeMinutes -= TotalBreakMinutes;
                            }
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);

                        }
                    }
                    if (currentrow["status_code"].ToString() == "HA")
                    {
                        if (e.Column.FieldName == "attendance_in_last" || e.Column.FieldName == "attendance_out_last")
                        {
                            DateTime startTime = Convert.ToDateTime(currentrow["attendance_in_last"].ToString());
                            DateTime endTime = Convert.ToDateTime(currentrow["attendance_out_last"].ToString());
                            TimeSpan spanattendence = endTime.Subtract(startTime);
                            double TotalMinutes = spanattendence.TotalMinutes;

                            double TotalBreakMinutes = 0;
                            TotalMinutes -= TotalBreakMinutes;

                            double OvertimeMinutes = 0;


                            if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                            {
                                DateTime overtimestartTime = Convert.ToDateTime(currentrow["attendence_in_night"].ToString());
                                DateTime overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString()).AddDays(1);
                                }
                                else
                                {
                                    overtimeendTime = Convert.ToDateTime(currentrow["attendence_out_night"].ToString());
                                }

                                TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                OvertimeMinutes = spanovertime.TotalMinutes;

                                TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                                OvertimeMinutes -= TotalBreakMinutes;
                            }
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                            AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void RepositoryItemComboBox2_EditValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBoxEdit).Text == "PPH" || (sender as ComboBoxEdit).Text == "AA" || (sender as ComboBoxEdit).Text == "HH" || (sender as ComboBoxEdit).Text == "RR" || (sender as ComboBoxEdit).Text == "NA")
            {
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], 0);
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], 0);
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_first"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_first"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_last"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_last"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_in_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_out_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
            {


                //var MaxRow = ((InfoGrid.FocusedView as GridView).RowCount);

                var MaxRow = ((AttendenceGrid.FocusedView as GridView).RowCount);
                sqlcon.Open();
                var sqlcom = sqlcon.CreateCommand();
                var transaction = sqlcon.BeginTransaction("SaveTransaction");
                sqlcom.Connection = sqlcon;
                sqlcom.Transaction = transaction;
                sqlcom.CommandType = CommandType.StoredProcedure;
                try
                {
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.CommandText = "Delete from EmployeeAttendance Where employee_code='" + txtEmpCode.Text + "'  and MONTH(attendance_date)='" + Convert.ToDateTime(DtStartDate.Text).Month + "' and year(attendance_date)='" + Convert.ToDateTime(DtStartDate.Text).Year + "'";
                    sqlcom.ExecuteNonQuery();
                    sqlcom.Parameters.Clear();
                    for (var i = 0; i < MaxRow; i++)
                    {
                        sqlcom.CommandType = CommandType.Text;
                        var currentrow = AttendenceGridView.GetDataRow(i);
                        sqlcom.CommandText = " Insert into EmployeeAttendance "
                                                    + " (entry_date, attendance_date, employee_code, status_id, attendance_in_first, attendance_out_first, attendance_in_last, attendance_out_last, " +
                                                    "working_hours, shift_id, ot_deducton_time, attendence_in_night, attendence_out_night)"
                                                    + " values(@entry_date, @attendance_date, @employee_code, @status_id, @attendance_in_first, @attendance_out_first, @attendance_in_last, @attendance_out_last," +
                                                    "@working_hours,@shift_id, @ot_deducton_time, @attendence_in_night, " +
                                                    "@attendence_out_night)";
                        sqlcom.Parameters.Add("@entry_date", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        sqlcom.Parameters.Add("@attendance_date", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendance_date"]).ToString("yyyy-MM-dd");
                        sqlcom.Parameters.Add("@employee_code", SqlDbType.NVarChar).Value = txtEmpCode.Text;
                        sqlcom.Parameters.Add("@status_id", SqlDbType.NVarChar).Value = ProjectFunctions.GetDataSet("select status_id from AttendanceStatus where status_code='" + currentrow["status_code"].ToString() + "'").Tables[0].Rows[0][0].ToString();
                        if (currentrow["attendance_in_first"].ToString().Trim() == "" || currentrow["attendance_in_first"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendance_in_first", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendance_in_first", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendance_in_first"].ToString()).ToString("HH:mm:ss");
                        }
                        if (currentrow["attendance_out_first"].ToString().Trim() == "" || currentrow["attendance_out_first"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendance_out_first", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendance_out_first", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendance_out_first"].ToString()).ToString("HH:mm:ss");
                        }
                        if (currentrow["attendance_in_last"].ToString().Trim() == "" || currentrow["attendance_in_last"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendance_in_last", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendance_in_last", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendance_in_last"].ToString()).ToString("HH:mm:ss");
                        }
                        if (currentrow["attendance_out_last"].ToString().Trim() == "" || currentrow["attendance_out_last"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendance_out_last", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendance_out_last", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendance_out_last"].ToString()).ToString("HH:mm:ss");
                        }
                        sqlcom.Parameters.Add("@working_hours", SqlDbType.NVarChar).Value = Convert.ToInt32(currentrow["working_hours"]);
                        sqlcom.Parameters.Add("@shift_id", SqlDbType.NVarChar).Value = "1";
                        sqlcom.Parameters.Add("@ot_deducton_time", SqlDbType.NVarChar).Value = Convert.ToInt32(currentrow["ot_deducton_time"]);
                        if (currentrow["attendence_in_night"].ToString().Trim() == "" || currentrow["attendence_in_night"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendence_in_night", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendence_in_night", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendence_in_night"].ToString()).ToString("HH:mm:ss");
                        }
                        if (currentrow["attendence_out_night"].ToString().Trim() == "" || currentrow["attendence_out_night"].ToString().Trim() == "00:00:00")
                        {
                            sqlcom.Parameters.Add("@attendence_out_night", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                        }
                        else
                        {
                            sqlcom.Parameters.Add("@attendence_out_night", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["attendence_out_night"].ToString()).ToString("HH:mm:ss");
                        }
                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();




                    }
                    transaction.Commit();


                    sqlcon.Close();
                    ProjectFunctions.SpeakError("Attendence Saved");
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