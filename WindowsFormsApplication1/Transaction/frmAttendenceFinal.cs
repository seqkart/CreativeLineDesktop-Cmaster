using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmAttendenceFinal : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        Decimal DutyHours = 0;
        Decimal DeductLunch = 0;
        public FrmAttendenceFinal()
        {
            InitializeComponent();
            dt.Columns.Add("attendance_date", typeof(DateTime));
            dt.Columns.Add("status_id", typeof(string));
            dt.Columns.Add("attendance_in_first", typeof(DateTime));
            dt.Columns.Add("attendance_out_first", typeof(DateTime));
            dt.Columns.Add("attendance_in_last", typeof(DateTime));
            dt.Columns.Add("attendance_out_last", typeof(DateTime));
            dt.Columns.Add("ot_deducton_time", typeof(Decimal));
            dt.Columns.Add("ot_deducton_time_f", typeof(Decimal));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("status_code", typeof(string));
            dt.Columns.Add("status_type", typeof(string));
            dt.Columns.Add("working_hours", typeof(Decimal));
            dt.Columns.Add("working_hours_f", typeof(Decimal));
            dt.Columns.Add("attendence_in_night", typeof(DateTime));
            dt.Columns.Add("attendence_out_night", typeof(DateTime));
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmpCode_EditValueChanged(object sender, EventArgs e)
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
                    DataSet ds = ProjectFunctions.GetDataSet("select EmpCode,EmpName,WorkingHours,isnull(LunchBreak,0)+isnull(TeaBreakTime,0)+isnull(TeaBreak,0) as DeductLunch from EmpMst");
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
                    DataSet ds = ProjectFunctions.GetDataSet("select EmpCode,EmpName,WorkingHours,isnull(LunchBreak,0)+isnull(TeaBreakTime,0)+isnull(TeaBreak,0) as DeductLunch from EmpMst Where  EmpCode= '" + txtEmpCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtEmpCode.Text = ds.Tables[0].Rows[0]["EmpCode"].ToString();
                        txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                        DutyHours = Convert.ToDecimal(ds.Tables[0].Rows[0]["WorkingHours"]);
                        DeductLunch = Convert.ToDecimal(ds.Tables[0].Rows[0]["DeductLunch"]);
                        btnLoad.PerformClick();
                        CalculateHrs();
                        // btnLoad.Focus();
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("select EmpCode,EmpName,WorkingHours,isnull(LunchBreak,0)+isnull(TeaBreakTime,0)+isnull(TeaBreak,0) as DeductLunch from EmpMst");
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
                DutyHours = Convert.ToDecimal(Row["WorkingHours"]);
                DeductLunch = Convert.ToDecimal(Row["DeductLunch"]);
                CalculateHrs();
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

                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    dr["working_hours_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(Convert.ToDouble(dr["working_hours"])));
                    dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(Convert.ToDouble(dr["ot_deducton_time_f"])));
                }


                dt = ds.Tables[0];
                AttendenceGrid.DataSource = dt;
                AttendenceGridView.BestFitColumns();
            }
            else
            {
                DataSet dsDummy = ProjectFunctions.GetDataSet("sp_LoadDummyAttendence '" + Convert.ToDateTime(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "','" + txtEmpCode.Text + "'");
                if (dsDummy.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsDummy.Tables[0].Rows)
                    {
                        dr["working_hours_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(Convert.ToDouble(dr["working_hours"])));
                        dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(Convert.ToDouble(dr["ot_deducton_time_f"])));
                    }
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
            CalculateHrs();
        }

        private void FrmAttendenceFinal_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
         
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
                        if (currentrow["status_code"].ToString().ToUpper() != "NA")
                        {
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

        private void Calculate_Click(object sender, EventArgs e)
        {

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["status_code"].ToString() == "PP")
                {
                    DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_first"]).ToString("HH:mm"));
                    DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_last"]).ToString("HH:mm"));
                    TimeSpan spanattendence = endTime.Subtract(startTime);
                    double TotalMinutes = spanattendence.TotalMinutes;
                    DateTime lunchstartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_first"]).ToString("HH:mm"));
                    DateTime lunchendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_last"]).ToString("HH:mm"));
                    TimeSpan spanbreak = lunchendTime.Subtract(lunchstartTime);
                    double TotalBreakMinutes = spanbreak.TotalMinutes;
                    double OvertimeMinutes = 0;
                    if (DeductLunch > 0)
                    {
                        TotalMinutes -= TotalBreakMinutes;
                        OvertimeMinutes -= TotalBreakMinutes;
                    }
                    if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                    {
                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                    }
                    else
                    {
                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                    }
                    if (dr["attendence_in_night"].ToString().Length > 0 && dr["attendence_out_night"].ToString().Length > 0)
                    {
                        DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_in_night"]).ToString("HH:mm"));
                        DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                        }
                        else
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        }

                        TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                        OvertimeMinutes += spanovertime.TotalMinutes;
                    }
                    dr["working_hours"] = TotalMinutes;
                    dr["working_hours_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes));
                    dr["ot_deducton_time"] = OvertimeMinutes;
                    dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes));

                }
                if (dr["status_code"].ToString() == "RR" || dr["status_code"].ToString() == "HH")
                {
                    double TotalBreakMinutes = 0;
                    double TotalMinutes = 0;
                    double OvertimeMinutes = 0;
                    if (dr["attendance_in_first"].ToString().Length > 0 || dr["attendance_out_first"].ToString().Length > 0)
                    {
                        if (dr["attendance_out_last"].ToString().Length > 0 && dr["attendance_in_last"].ToString().Length > 0)
                        {
                            DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_first"]).ToString("HH:mm"));
                            DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_last"]).ToString("HH:mm"));
                            TimeSpan spanattendence = endTime.Subtract(startTime);
                            TotalMinutes = spanattendence.TotalMinutes;

                            DateTime lunchstartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_first"]).ToString("HH:mm"));
                            DateTime lunchendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_last"]).ToString("HH:mm"));
                            TimeSpan spanbreak = lunchendTime.Subtract(lunchstartTime);
                            TotalBreakMinutes = spanbreak.TotalMinutes;
                            if (DeductLunch > 0)
                            {
                                TotalMinutes -= TotalBreakMinutes;
                            }
                        }
                        else
                        {
                            DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_first"]).ToString("HH:mm"));
                            DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_first"]).ToString("HH:mm"));
                            TimeSpan spanattendence = endTime.Subtract(startTime);
                            TotalMinutes = spanattendence.TotalMinutes;
                        }
                        OvertimeMinutes = TotalMinutes;
                        if (dr["attendence_in_night"].ToString().Length > 0 && dr["attendence_out_night"].ToString().Length > 0)
                        {
                            DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_in_night"]).ToString("HH:mm"));
                            DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                            if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                            {
                                overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                            }
                            else
                            {
                                overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                            }
                            TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                            OvertimeMinutes += spanovertime.TotalMinutes;
                        }
                    }
                    dr["working_hours"] = 0;
                    dr["working_hours_f"] = Convert.ToDecimal("0");
                    dr["ot_deducton_time"] = OvertimeMinutes;
                    dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes));
                }

                if (dr["status_code"].ToString() == "PA")
                {

                    DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_first"]).ToString("HH:mm"));
                    DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_first"]).ToString("HH:mm"));
                    TimeSpan spanattendence = endTime.Subtract(startTime);
                    double TotalMinutes = spanattendence.TotalMinutes;

                    double TotalBreakMinutes = 0;
                    double OvertimeMinutes = 0;
                    if (DeductLunch > 0)
                    {
                        TotalMinutes -= TotalBreakMinutes;
                        OvertimeMinutes -= TotalBreakMinutes;
                    }
                    if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                    {
                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                    }
                    else
                    {
                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                    }




                    if (dr["attendence_in_night"].ToString().Length > 0 && dr["attendence_out_night"].ToString().Length > 0)
                    {
                        DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_in_night"]).ToString("HH:mm"));
                        DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                        }
                        else
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        }

                        TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                        OvertimeMinutes += spanovertime.TotalMinutes;
                        TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                    }
                    dr["working_hours"] = TotalMinutes;
                    dr["working_hours_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes));
                    dr["ot_deducton_time"] = OvertimeMinutes;
                    dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes));
                }

                if (dr["status_code"].ToString() == "HA")
                {
                    DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_in_last"]).ToString("HH:mm"));
                    DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendance_out_last"]).ToString("HH:mm"));
                    TimeSpan spanattendence = endTime.Subtract(startTime);
                    double TotalMinutes = spanattendence.TotalMinutes;

                    double OvertimeMinutes = 0;
                    if (DeductLunch > 0)
                    {
                        //TotalMinutes = TotalMinutes - TotalBreakMinutes;
                        //OvertimeMinutes = OvertimeMinutes - TotalBreakMinutes;
                    }
                    if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                    {
                        TotalMinutes -= Convert.ToDouble(DutyHours * 60);
                    }
                    else
                    {
                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                    }
                    if (dr["attendence_in_night"].ToString().Length > 0 && dr["attendence_out_night"].ToString().Length > 0)
                    {
                        DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_in_night"]).ToString("HH:mm"));
                        DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                        }
                        else
                        {
                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(dr["attendence_out_night"]).ToString("HH:mm"));
                        }

                        TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                        OvertimeMinutes += spanovertime.TotalMinutes;
                    }
                    dr["working_hours"] = TotalMinutes;
                    dr["working_hours_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes));
                    dr["ot_deducton_time"] = OvertimeMinutes;
                    dr["ot_deducton_time_f"] = Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes));
                }
            }
            CalculateHrs();



        }

        private void CalculateHrs()
        {
            Decimal TotalWorkingHrs = 0;
            Decimal TotalOTHrs = 0;

            foreach (DataRow dr in dt.Rows)
            {
                TotalWorkingHrs += Convert.ToDecimal(dr["working_hours"]);
                TotalOTHrs += Convert.ToDecimal(dr["ot_deducton_time"]);
            }
            txtTotalWoringMins.Text = TotalWorkingHrs.ToString("0.00");
            txtTotalOTMins.Text = TotalOTHrs.ToString("0.00");
            txtTotalWorkingHours.Text = ProjectFunctions.TimeFromMinutes(Convert.ToDouble(TotalWorkingHrs)).ToString("0.00");
            txtTotalOTHours.Text = ProjectFunctions.TimeFromMinutes(Convert.ToDouble(TotalOTHrs)).ToString("0.00");
        }

        private void AttendenceGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string status_code = View.GetRowCellDisplayText(e.RowHandle, View.Columns["status_code"]);
                if (status_code.ToUpper() == "RR")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
                }
                if (status_code.ToUpper() == "HH")
                {
                    e.Appearance.BackColor = Color.Orange;
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
                }
                if (status_code.ToUpper() == "PA" || status_code.ToUpper() == "HA")
                {
                    e.Appearance.BackColor = Color.LightYellow;
                    e.Appearance.ForeColor = Color.Black;
                }
                if (status_code.ToUpper() == "AA")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.FontStyleDelta = FontStyle.Bold;
                }
            }
        }

        private void AttendenceGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                

                if (e.KeyCode == Keys.Enter)
                {

                    repositoryItemDateEdit2.EndUpdate();
                    AttendenceGridView.CloseEditor();
                    AttendenceGridView.UpdateCurrentRow();

                    if (AttendenceGridView.DataSource != null)
                    {
                        DataRow currentrow = AttendenceGridView.GetDataRow(AttendenceGridView.FocusedRowHandle);


                        if (AttendenceGridView.FocusedColumn.FieldName == "status_code")
                        {
                            if (currentrow["status_code"].ToString() == "PPH" || currentrow["status_code"].ToString() == "AA" || currentrow["status_code"].ToString() == "HH" || currentrow["status_code"].ToString() == "RR" || currentrow["status_code"].ToString() == "NA")
                            {
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_first"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_first"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_last"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_last"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_in_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_out_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("00:00:00"));

                            }
                            if (currentrow["status_code"].ToString() == "PP")
                            {
                                DataSet ds = ProjectFunctions.GetDataSet("select TimeInFirst,TimeOutFirst,TimeInLast,TimeOutLast,WorkingHours from EmpMST where empcode='" + txtEmpCode.Text + "' ");
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], Convert.ToDecimal(ds.Tables[0].Rows[0]["WorkingHours"]) * 60);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], Convert.ToDecimal(ds.Tables[0].Rows[0]["WorkingHours"]));

                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_first"], Convert.ToDateTime("2001-01-01 " + ds.Tables[0].Rows[0]["TimeInFirst"].ToString()).ToString("HH:mm:ss"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_first"], Convert.ToDateTime("2001-01-01 " + ds.Tables[0].Rows[0]["TimeOutFirst"].ToString()).ToString("HH:mm:ss"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_in_last"], Convert.ToDateTime("2001-01-01 " + ds.Tables[0].Rows[0]["TimeInLast"].ToString()).ToString("HH:mm:ss"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendance_out_last"], Convert.ToDateTime("2001-01-01 " + ds.Tables[0].Rows[0]["TimeOutLast"].ToString()).ToString("HH:mm:ss"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_in_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("HH:mm:ss"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["attendence_out_night"], Convert.ToDateTime("1900-01-01 00:00:00").ToString("HH:mm:ss"));

                            }
                        }


                        if (currentrow["status_code"].ToString() == "PP")
                        {
                            if (AttendenceGridView.FocusedColumn.FieldName == "attendance_in_first" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_first" || AttendenceGridView.FocusedColumn.FieldName == "attendance_in_last" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_last" || AttendenceGridView.FocusedColumn.FieldName == "attendence_out_night" || AttendenceGridView.FocusedColumn.FieldName == "attendence_in_night")
                            {

                                double TotalBreakMinutes = 0;
                                double TotalMinutes = 0;

                                DateTime startTime = Convert.ToDateTime("2001-01-01 "+ Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
                                DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_last"]).ToString("HH:mm"));
                                TimeSpan spanattendence = endTime.Subtract(startTime);
                                TotalMinutes = spanattendence.TotalMinutes;


                                DateTime lunchstartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_first"]).ToString("HH:mm"));
                                DateTime lunchendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_last"]).ToString("HH:mm"));
                                TimeSpan spanbreak = lunchendTime.Subtract(lunchstartTime);
                                TotalBreakMinutes = spanbreak.TotalMinutes;
                                double OvertimeMinutes = 0;
                                if (DeductLunch > 0)
                                {
                                    TotalMinutes -= TotalBreakMinutes;
                                    OvertimeMinutes -= TotalBreakMinutes;
                                }
                                if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                                {
                                    OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                }
                                else
                                {
                                    OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                }
                                if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                                {
                                    DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_in_night"]).ToString("HH:mm"));
                                    DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                    if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                    {
                                        overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                                    }
                                    else
                                    {
                                        overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                    }

                                    TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                    OvertimeMinutes += spanovertime.TotalMinutes;
                                }
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes)));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes)));


                            }
                        }
                        if (currentrow["status_code"].ToString() == "RR" || currentrow["status_code"].ToString() == "HH")
                        {
                            double TotalBreakMinutes = 0;
                            double TotalMinutes = 0;
                            double OvertimeMinutes = 0;
                            if (AttendenceGridView.FocusedColumn.FieldName == "attendance_in_first" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_first" || AttendenceGridView.FocusedColumn.FieldName == "attendance_in_last" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_last" || AttendenceGridView.FocusedColumn.FieldName == "attendence_out_night" || AttendenceGridView.FocusedColumn.FieldName == "attendence_in_night")
                            {

                                if (currentrow["attendance_in_first"].ToString().Length > 0 || currentrow["attendance_out_first"].ToString().Length > 0)
                                {
                                    if (currentrow["attendance_out_last"].ToString().Length > 0 && currentrow["attendance_in_last"].ToString().Length > 0)
                                    {
                                        DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
                                        DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_last"]).ToString("HH:mm"));
                                        TimeSpan spanattendence = endTime.Subtract(startTime);
                                        TotalMinutes = spanattendence.TotalMinutes;

                                        DateTime lunchstartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_first"]).ToString("HH:mm"));
                                        DateTime lunchendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_last"]).ToString("HH:mm"));
                                        TimeSpan spanbreak = lunchendTime.Subtract(lunchstartTime);
                                        TotalBreakMinutes = spanbreak.TotalMinutes;
                                        if (DeductLunch > 0)
                                        {
                                            TotalMinutes -= TotalBreakMinutes;
                                        }
                                    }
                                    else
                                    {
                                        DateTime startTime = Convert.ToDateTime("2001-01-01 "+ Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
                                        DateTime endTime = Convert.ToDateTime("2001-01-01 "+ Convert.ToDateTime(currentrow["attendance_out_first"]).ToString("HH:mm"));
                                        TimeSpan spanattendence = endTime.Subtract(startTime);
                                        TotalMinutes = spanattendence.TotalMinutes;
                                    }
                                    OvertimeMinutes = TotalMinutes;
                                    if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                                    {
                                        DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_in_night"]).ToString("HH:mm"));
                                        DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                        if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                        {
                                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                                        }
                                        else
                                        {
                                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                        }

                                        TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                        OvertimeMinutes += spanovertime.TotalMinutes;
                                    }

                                }

                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], 0);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], Convert.ToDecimal("0"));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes)));


                            }
                        }

                        if (currentrow["status_code"].ToString() == "PA")
                        {
                            if (AttendenceGridView.FocusedColumn.FieldName == "attendance_in_first" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_first")
                            {
                                DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
                                DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_first"]).ToString("HH:mm"));
                                TimeSpan spanattendence = endTime.Subtract(startTime);
                                double TotalMinutes = spanattendence.TotalMinutes;

                                double TotalBreakMinutes = 0;
                                double OvertimeMinutes = 0;
                                if (DeductLunch > 0)
                                {
                                    TotalMinutes -= TotalBreakMinutes;
                                    OvertimeMinutes -= TotalBreakMinutes;
                                }

                                if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                                {
                                    OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                }
                                else
                                {
                                    OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                }



                                if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                                {
                                    DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_in_night"]).ToString("HH:mm"));
                                    DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                    if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                    {
                                        overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                                    }
                                    else
                                    {
                                        overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                    }

                                    TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                    OvertimeMinutes += spanovertime.TotalMinutes;
                                    TotalMinutes = TotalMinutes - TotalBreakMinutes + OvertimeMinutes;
                                }
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes)));
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);
                                AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes)));

                            }
                        }
                        if (currentrow["status_code"].ToString() == "HA")

                        {
                            if (AttendenceGridView.FocusedColumn.FieldName == "attendance_in_last" || AttendenceGridView.FocusedColumn.FieldName == "attendance_out_last" || AttendenceGridView.FocusedColumn.FieldName == "attendence_out_night" || AttendenceGridView.FocusedColumn.FieldName == "attendence_in_night")
                            {


                                double TotalBreakMinutes = 0;
                                double TotalMinutes = 0;
                                if (currentrow["attendance_in_last"].ToString().Length > 0 || currentrow["attendance_out_last"].ToString().Length > 0)
                                {
                                    DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_last"]).ToString("HH:mm"));
                                    DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_last"]).ToString("HH:mm"));
                                    TimeSpan spanattendence = endTime.Subtract(startTime);
                                    TotalMinutes = spanattendence.TotalMinutes;

                                    double OvertimeMinutes = 0;
                                    if (DeductLunch > 0)
                                    {
                                        //TotalMinutes = TotalMinutes - TotalBreakMinutes;
                                        //OvertimeMinutes = OvertimeMinutes - TotalBreakMinutes;
                                    }
                                    if (spanattendence.TotalMinutes > Convert.ToDouble(DutyHours * 60))
                                    {
                                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                    }
                                    else
                                    {
                                        OvertimeMinutes = TotalMinutes - Convert.ToDouble(DutyHours * 60);
                                    }
                                    if (currentrow["attendence_in_night"].ToString().Length > 0 && currentrow["attendence_out_night"].ToString().Length > 0)
                                    {
                                        DateTime overtimestartTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_in_night"]).ToString("HH:mm"));
                                        DateTime overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                        if (overtimestartTime.Hour + overtimeendTime.Hour > 24)
                                        {
                                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm")).AddDays(1);
                                        }
                                        else
                                        {
                                            overtimeendTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendence_out_night"]).ToString("HH:mm"));
                                        }

                                        TimeSpan spanovertime = overtimeendTime.Subtract(overtimestartTime);
                                        OvertimeMinutes += spanovertime.TotalMinutes;
                                    }

                                    AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours"], TotalMinutes);
                                    AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["working_hours_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(TotalMinutes)));
                                    AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time"], OvertimeMinutes);
                                    AttendenceGridView.SetRowCellValue(AttendenceGridView.FocusedRowHandle, AttendenceGridView.Columns["ot_deducton_time_f"], Convert.ToDecimal(ProjectFunctions.TimeFromMinutes(OvertimeMinutes)));
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void AttendenceGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            AttendenceGrid_KeyDown(null, e);
        }

        private void RepositoryItemTextEdit1_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            e.Value = Convert.ToDateTime(e.Value).ToString("HH:mm:ss");
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}