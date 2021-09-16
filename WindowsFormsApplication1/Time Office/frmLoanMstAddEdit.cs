﻿using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Forms_Master
{
    public partial class FrmLoanMstAddEdit : DevExpress.XtraEditors.XtraForm
    {

        public string _s1 = null;
        public string _empcode = null;

        public string LoanNo { get; set; }
        public string LoanADate { get; set; }
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

        public string MonthYear { get; set; }
        public FrmLoanMstAddEdit()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetMyControls()
        {
            ProjectFunctions.XtraFormVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }
        private void LastInstlmnt()
        {
            DataSet dsLastInstlmnt = ProjectFunctions.GetDataSet("Select LoanInstlmnt from LoanMst Where EmpCode='" + txtEmpCode.Text + "'");
            if (dsLastInstlmnt.Tables[0].Rows.Count > 0)
            {
                txtPreviousInstlmnt.Text = dsLastInstlmnt.Tables[0].Rows[0]["LoanInstlmnt"].ToString();
            }
            else
            {
                txtPreviousInstlmnt.Text = "0";
            }
        }
        private bool ValidateData()
        {

            if (txtMonthYear.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Month Year", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtMonthYear.Focus();
                return false;
            }


            if (txtEmpCode.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid EmpCode", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpCode.Focus();
                return false;
            }

            if (txtEmpName.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid EmpName", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpCode.Focus();
                return false;
            }

            if (txtLoanAmount.Text.Trim().Length == 0)
            {
                txtLoanAmount.Text = "0";
            }


            if (txtLoanInstlmnt.Text.Trim().Length == 0)
            {
                txtLoanInstlmnt.Text = "0";
            }





            return true;
        }


        //private void GetBasicDetail()
        //{

        //    DataSet ds = ProjectFunctions.GetDataSet("Select  isnull(EmpBasic,0) + isnull(EmpHRA,0) +isnull(EmpConv,0) +isnull(EmpPET,0) +isnull(EmpMscA1,0) +isnull(EmpMscA2,0) +isnull(EmpCHstlAlw,0) +isnull(EmpProDevAlw,0) +isnull(EmpNewsPapAlw,0) +isnull(EmpMedAlw,0) +isnull(EmpUnformAlw,0) +isnull(EmpSplAlw,0) as EmpSalary,isnull(EmpxBasic,0) as EmpSalaryC ,EmpDummy,EmpDOL from EmpMst Where EmpCode='" + txtEmpCode.Text + "'");

        //}


        private void FrmLoanMstAddEdit_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "Add")
            {
                txtMonthYear.Focus();
                txtMonthYear.EditValue = Convert.ToDateTime(DateTime.Now);
                txtLoanDate.EditValue = Convert.ToDateTime(DateTime.Now);
                txtEmpCode.Focus();

                txtLoanNo.Text = GetNewLoanNo().PadLeft(5, '0');

            }
            if (S1 == "Edit" || S1 == "View")
            {
                txtMonthYear.Enabled = false;
                txtEmpCode.Enabled = false;

                if (S1 == "View")
                {
                    btnSave.Enabled = false;
                }

                string sql_query = "sp_LoadLoan_Details '" + LoanNo + "', '" + Convert.ToDateTime(LoanADate).ToString("yyyy-MM-dd") + "'";
                PrintLogWin.PrintLog(sql_query);


                var ds = ProjectFunctionsUtils.GetDataSet(sql_query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    PrintLogWin.PrintLog("************* " + ds.Tables[0].Rows[0]["DeptDesc"].ToString());
                    txtLoanNo.Text = ds.Tables[0].Rows[0]["LoanANo"].ToString();
                    //txtDept.Text = ds.Tables[0].Rows[0]["DeptDesc"].ToString();
                    txtEmpCode.Text = ds.Tables[0].Rows[0]["EmpCode"].ToString();
                    txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                    txtLoanAmount.Text = ds.Tables[0].Rows[0]["LoanAmt"].ToString();
                    txtLoanInstlmnt.Text = ds.Tables[0].Rows[0]["LoanInstlmnt"].ToString();
                    txtMonthYear.Text = ds.Tables[0].Rows[0]["LoanLUyrmn"].ToString();
                    txtLoanDate.Text = ds.Tables[0].Rows[0]["LoanADate"].ToString();

                    txtDept.Text = ds.Tables[0].Rows[0]["DeptDesc"].ToString();

                    //txtDept.Text = "HELOO";
                    //GetBasicDetail();
                }

                txtLoanAmount.Focus();
            }
        }

        private void TxtLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void TxtLoanInstlmnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }
        private string GetNewLoanNo()
        {
            var s2 = string.Empty;

            var strsql = string.Empty;
            var ds = new DataSet();
            strsql = strsql + "select isnull(max(Cast(LoanANo as int)),00000) from LoanMst";

            ds = ProjectFunctions.GetDataSet(strsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }
            return s2;
        }




        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (S1 == "Add")
                {
                    var strQry = " Insert into LoanMst";
                    strQry = strQry + " (EmpCode,LoanAmt,LoanInstlmnt,LoanLUyrmn,LoanANo,LoanFBy,LoanFDt,LoanADate)";
                    strQry = strQry + " values(";
                    strQry = strQry + "'" + txtEmpCode.Text.Trim() + "',";
                    strQry = strQry + "'" + Convert.ToDecimal(txtLoanAmount.Text) + "',";
                    strQry = strQry + "'" + Convert.ToDecimal(txtLoanInstlmnt.Text) + "',";
                    strQry = strQry + "'" + Convert.ToDateTime(txtMonthYear.Text).ToString("MM-yyyy") + "',";
                    strQry = strQry + "'" + GetNewLoanNo().PadLeft(5, '0') + "',";
                    strQry = strQry + "'" + GlobalVariables.CurrentUser + "',";
                    strQry = strQry + "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                    strQry = strQry + "'" + Convert.ToDateTime(txtLoanDate.Text).ToString("yyyy-MM-dd") + "')";


                    using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                    {
                        sqlcon.Open();
                        var sqlcom = new SqlCommand(strQry, sqlcon)
                        {
                            CommandType = CommandType.Text
                        };
                        sqlcom.ExecuteNonQuery();
                        //UpDateLoanInstlmnt();
                        ProjectFunctions.SpeakError("Data has been Added");
                        Close();
                    }
                }

                if (S1 == "Edit")
                {
                    var strQry = " UPDATE    LoanMst";
                    strQry = strQry + " SET  ";
                    strQry = strQry + "EmpCode ='" + txtEmpCode.Text.Trim() + "',";
                    strQry = strQry + "LoanAmt ='" + Convert.ToDecimal(txtLoanAmount.Text) + "',";
                    strQry = strQry + "LoanInstlmnt ='" + Convert.ToDecimal(txtLoanInstlmnt.Text) + "',";
                    strQry = strQry + "LoanLUyrmn ='" + Convert.ToDateTime(txtMonthYear.Text).ToString("MM-yyyy") + "',";
                    strQry = strQry + "LoanFBy ='" + GlobalVariables.CurrentUser + "',";
                    strQry = strQry + "LoanFDt ='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    strQry = strQry + " Where LoanANo='" + LoanNo + "' And LoanADate='" + Convert.ToDateTime(LoanADate).ToString("yyyy-MM-dd") + "'";
                    using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                    {
                        sqlcon.Open();
                        var sqlcom = new SqlCommand(strQry, sqlcon)
                        {
                            CommandType = CommandType.Text
                        };
                        sqlcom.ExecuteNonQuery();
                        //UpDateLoanInstlmnt();
                        ProjectFunctions.SpeakError("Data has been Updated");
                        Close();
                    }
                }
            }
        }

        private void TxtEmpCode_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpName.Text = string.Empty;
            txtDept.Text = string.Empty;
            txtPreviousInstlmnt.Text = "0";
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
                        txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                        txtDept.Text = ds.Tables[0].Rows[0]["DeptDesc"].ToString();
                        //GetBasicDetail();
                        LastInstlmnt();
                        txtLoanAmount.Focus();
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
                txtDept.Text = row["DeptDesc"].ToString();
                HelpGrid.Visible = false;
                txtLoanAmount.Focus();
                //GetBasicDetail();
                LastInstlmnt();
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

        private void Menu_ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }
    }
}
