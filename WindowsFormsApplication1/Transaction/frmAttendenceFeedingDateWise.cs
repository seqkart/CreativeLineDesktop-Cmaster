using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmAttendenceFeedingDateWise : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        Decimal DutyHours = 0;
        Decimal DeductLunch = 0;
        public frmAttendenceFeedingDateWise()
        {
            InitializeComponent();
            dt.Columns.Add("EmpCode", typeof(string));
            dt.Columns.Add("EmpName", typeof(string));
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

            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadAttendenceDateWise '" + Convert.ToDateTime(DtStartDate.EditValue).ToString("yyyy-MM-dd") + "'");
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
        }
        
        private void frmAttendenceFeedingDateWise_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            DtStartDate.EditValue = DateTime.Now;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
        }

        private void AttendenceGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            AttendenceGrid_KeyDown(null, e);
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
                        DataSet dsEmp = ProjectFunctions.GetDataSet("select EmpCode,EmpName,WorkingHours,isnull(LunchBreak,0)+isnull(TeaBreakTime,0)+isnull(TeaBreak,0) as DeductLunch from EmpMst Where  EmpCode= '" + currentrow["EmpCode"].ToString() + "'") ;
                        if (dsEmp.Tables[0].Rows.Count > 0)
                        {
                            DutyHours = Convert.ToDecimal(dsEmp.Tables[0].Rows[0]["WorkingHours"]);
                            DeductLunch = Convert.ToDecimal(dsEmp.Tables[0].Rows[0]["DeductLunch"]);
                        }

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
                                DataSet ds = ProjectFunctions.GetDataSet("select TimeInFirst,TimeOutFirst,TimeInLast,TimeOutLast,WorkingHours from EmpMST where empcode='" + currentrow["Emp?Code"].ToString() + "' ");
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

                                DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
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
                                    TotalMinutes = TotalMinutes - TotalBreakMinutes;
                                    OvertimeMinutes = OvertimeMinutes - TotalBreakMinutes;
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
                                    OvertimeMinutes = OvertimeMinutes + spanovertime.TotalMinutes;
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
                                            TotalMinutes = TotalMinutes - TotalBreakMinutes;
                                        }
                                    }
                                    else
                                    {
                                        DateTime startTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_in_first"]).ToString("HH:mm"));
                                        DateTime endTime = Convert.ToDateTime("2001-01-01 " + Convert.ToDateTime(currentrow["attendance_out_first"]).ToString("HH:mm"));
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
                                        OvertimeMinutes = OvertimeMinutes + spanovertime.TotalMinutes;
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
                                    TotalMinutes = TotalMinutes - TotalBreakMinutes;
                                    OvertimeMinutes = OvertimeMinutes - TotalBreakMinutes;
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
                                    OvertimeMinutes = OvertimeMinutes + spanovertime.TotalMinutes;
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
                                        OvertimeMinutes = OvertimeMinutes + spanovertime.TotalMinutes;
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
    }
}