using SeqKartLibrary;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.TimeOffice
{
    public partial class FrmAdvanceAddEdit : DevExpress.XtraEditors.XtraForm
    {




        public string S1 { get; set; }
        public string ExId { get; set; }
        public FrmAdvanceAddEdit()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetMyControls()
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }


        private void GetBasicDetail()
        {
            string sql = "Select"
            + " (isnull(EmpBasic,0) "
            + " + isnull(EmpHRA,0) "
            + " + isnull(EmpConv,0) "
            + " + isnull(EmpPET,0) "
            + " + isnull(EmpMscA1,0) "
            + " + isnull(EmpMscA2,0) "
            + " + isnull(EmpCHstlAlw,0) "
            + " + isnull(EmpProDevAlw,0) "
            + " + isnull(EmpNewsPapAlw,0) "
            + " + isnull(EmpMedAlw,0) "
            + " + isnull(EmpUnformAlw,0) "
            + " + isnull(EmpSplAlw,0)) as EmpSalary"
            + " , isnull(EmpxBasic,0) as EmpSalaryC"
            + " , EmpDummy"
            + " , EmpDOL from EmpMst Where EmpCode='" + txtEmpCode.Text + "'";

            //DataSet ds = ProjectFunctions.GetDataSet("Select  isnull(EmpBasic,0) + isnull(EmpHRA,0) +isnull(EmpConv,0) +isnull(EmpPET,0) +isnull(EmpMscA1,0) +isnull(EmpMscA2,0) +isnull(EmpCHstlAlw,0) +isnull(EmpProDevAlw,0) +isnull(EmpNewsPapAlw,0) +isnull(EmpMedAlw,0) +isnull(EmpUnformAlw,0) +isnull(EmpSplAlw,0) as EmpSalary,isnull(EmpxBasic,0) as EmpSalaryC ,EmpDummy,EmpDOL from EmpMst Where EmpCode='" + txtEmpCode.Text + "'");
            DataSet ds = ProjectFunctions.GetDataSet(sql);
            txtSalary.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void FrmAdvanceAddEdit_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "Add")
            {
                DtDate.Enabled = true;
                DtDate.EditValue = DateTime.Now;
                DtDateforMonth.EditValue = DateTime.Now;
                txtAdvanceNo.Text = GetNewLoanPassNo().PadLeft(6, '0');
                txtType.Text = "A";
                DtDate.Focus();
            }
            if (S1 == "Edit")
            {
                DtDateforMonth.Enabled = false;
                DtDate.Enabled = false;
                txtType.Enabled = false;


                string str = "SELECT "
                + " ExMst.ExPostHead, "
                + " ExMst.ExVoucherType, "
                + " ExMst.ExVoucherNo, "
                + " ExMst.ExVoucherDt, "
                + " ExMst.ExNo, "
                + " ExMst.ExId, "
                + " ExMst.ExDate, "
                + " ExMst.ExEmpCode, "
                + " ExMst.ExAmt, "
                + " ExMst.ExTag, "
                + " ExMst.ExDatePost, "
                + " ExMst.ExLoadTag, "
                + " ExMst.ExEmpCCode, "
                + " ExMst.ExFedDate, "
                + " ExMst.ExLoadedDate, "
                + " empmst.EmpName, "
                + " actmst.AccName "
                + " FROM ExMst "
                + " LEFT OUTER JOIN EmpMST ON ExMst.ExEmpCode = empmst.EmpCode "
                + " LEFT OUTER JOIN ActMst ON ExMst.ExPostHead = actmst.AccCode "
                + " WHERE ExId='" + ExId + "';" +
string.Empty;

                //var qr = " SELECT     ExMst.ExPostHead, ExMst.ExVoucherType, ExMst.ExVoucherNo, ExMst.ExVoucherDt, ExMst.ExNo, ExMst.ExId, ExMst.ExDate, ExMst.ExEmpCode, ExMst.ExAmt, ExMst.ExTag, ExMst.ExDatePost, ";
                //qr = qr + " ExMst.ExLoadTag, ExMst.ExEmpCCode, ExMst.ExFedDate, ExMst.ExLoadedDate, empmst.EmpName, EmpEmplrRef.ERMDesc, actmst.AccName ";
                //qr = qr + " FROM         ExMst LEFT OUTER JOIN ";
                //qr = qr + "      empmst ON ExMst.ExEmpCode = empmst.EmpCode LEFT OUTER JOIN ";
                //qr = qr + "      EmpEmplrRef ON ExMst.ExEmpCCode = EmpEmplrRef.ERMCode LEFT OUTER JOIN ";
                //qr = qr + "      actmst ON ExMst.ExPostHead = actmst.AccCode ";
                //qr = qr + " WHERE ExId='" + ExId + "'";

                PrintLogWin.PrintLog(str);

                var ds = ProjectFunctionsUtils.GetDataSet(str);

                try
                {
                    txtAdvanceNo.Text = ds.Tables[0].Rows[0]["ExNo"].ToString();
                    DtDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["ExDate"]);
                    DtDateforMonth.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["ExDatePost"]);
                    txtEmpCode.Text = ds.Tables[0].Rows[0]["ExEmpCode"].ToString();
                    txtEmpCodeDesc.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                    txtType.Text = ds.Tables[0].Rows[0]["ExTag"].ToString();
                    txtAmount.Text = ds.Tables[0].Rows[0]["ExAmt"].ToString();
                }
                catch (Exception ex)
                {
                    PrintLogWin.PrintLog(ex);
                }

                //GetBasicDetail();

            }
        }
        private bool ValidateData()
        {

            if (DtDate.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Date", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DtDate.Focus();
                return false;
            }
            if (Convert.ToDateTime(DtDate.Text).Date > DateTime.Now.Date)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Wrong Date Selected", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DtDate.Focus();
                return false;
            }
            if (DtDateforMonth.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Date Of Month", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DtDateforMonth.Focus();
                return false;
            }
            if (txtEmpCode.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid EmpName", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpCode.Focus();
                return false;
            }
            if (txtEmpCodeDesc.Text.Trim().Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid EmpName", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpCode.Focus();
                return false;
            }
            if (S1 == "Add")
            {
                DataSet ds = ProjectFunctions.GetDataSet("Select * from ExMst Where ExEmpCode='" + txtEmpCode.Text + "' And ExDate='" + Convert.ToDateTime(DtDate.Text).ToString("yyyy-MM-dd") + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Advance Already Feeded", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtEmpCode.Focus();
                    return false;
                }
            }

            if (txtAmount.Text.Length == 0)
            {
                txtAmount.Text = "0";
            }
            if (txtSalary.Text.Length == 0)
            {
                txtSalary.Text = "0";
            }

            if (txtType.Text == "A" || txtType.Text == "C" || txtType.Text == "F" || txtType.Text == "L" | txtType.Text == "T")
            {
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Valid Values are Advance(a),Fine(F),Coupon(C),Lunch(L),Telephone(T)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtType.Focus();
                return false;
            }

            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (S1 == "Add")
                {
                    if (Convert.ToDateTime(DtDate.Text).Date.Day <= 10)
                    {
                        DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text).AddMonths(-1);
                    }
                    else
                    {
                        DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text);
                    }
                    if (ValidateData())
                    {
                        string DocNo = GetNewLoanPassNo().PadLeft(6, '0');
                        var str = "Insert into ExMst(ExDate,ExEmpCode,ExAmt,ExTag,ExDatePost,ExFedDate,ExNo";
                        str = str + ")values(";
                        str = str + "'" + Convert.ToDateTime(DtDate.Text).ToString("yyyy-MM-dd") + "',";
                        str = str + "'" + txtEmpCode.Text.Trim() + "',";
                        str = str + "'" + Convert.ToDecimal(txtAmount.Text) + "',";
                        str = str + "'" + txtType.Text.Trim() + "',";
                        str = str + "'" + Convert.ToDateTime(DtDateforMonth.Text).ToString("yyyy-MM-dd") + "',";
                        str = str + "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + DocNo + "')";


                        using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(str, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();

                            sqlcon.Close();
                            txtEmpCode.Text = string.Empty;
                            txtEmpCodeDesc.Text = string.Empty;
                            txtAmount.Text = string.Empty;

                        }
                        ProjectFunctions.SpeakError("Data has been saved.");
                        //this.Close();
                    }
                }
                if (S1 == "Edit")
                {
                    if (ValidateData())
                    {
                        var str = " UPDATE    ExMst";
                        str = str + " SET  ";
                        str = str + " ExEmpCode='" + txtEmpCode.Text.Trim() + "',";
                        str = str + " ExAmt='" + Convert.ToDecimal(txtAmount.Text) + "',";
                        str = str + " ExTag='" + txtType.Text.Trim() + "',";

                        str = str + " ExFedDate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where ExId='" + ExId + "'";
                        using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                        {
                            sqlcon.Open();
                            var sqlcom = new SqlCommand(str, sqlcon)
                            {
                                CommandType = CommandType.Text
                            };
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                            sqlcon.Close();
                            txtEmpCode.Text = string.Empty;
                            txtEmpCodeDesc.Text = string.Empty;
                            txtAmount.Text = string.Empty;
                            //clear();
                        }
                        ProjectFunctions.SpeakError("Data has been saved.");
                        // this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetNewLoanPassNo()
        {
            var s2 = string.Empty;

            var strsql = string.Empty;
            var ds = new DataSet();
            strsql = strsql + "select isnull(max(Cast(ExNo as int)),00000) from ExMst";

            ds = ProjectFunctionsUtils.GetDataSet(strsql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }
            return s2;
        }
        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void TxtEmpCode_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpCodeDesc.Text = string.Empty;
        }





        private void PrepareEmpGrid()
        {
            HelpGridView.Columns.Clear();
            HelpGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
            HelpGridView.Columns[0].Visible = true;
            HelpGridView.Columns[0].Caption = "Description";
            HelpGridView.Columns[0].FieldName = "Description";
            HelpGridView.Columns[0].OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
            HelpGridView.Columns[1].Visible = true;
            HelpGridView.Columns[1].Caption = "EmpFHName";
            HelpGridView.Columns[1].FieldName = "EmpFHName";
            HelpGridView.Columns[1].OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
            HelpGridView.Columns[2].Visible = true;
            HelpGridView.Columns[2].Caption = "Code";
            HelpGridView.Columns[2].FieldName = "Code";
            HelpGridView.Columns[2].OptionsColumn.AllowEdit = false;
        }


        private void TxtEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                PrepareEmpGrid();
                var strQry = string.Empty;
                HelpGrid.Text = "Emp";
                var ds = new DataSet();
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtEmpCode.Text.Length == 0)
                    {
                        strQry = strQry + "select Empcode as Code,Empname as Description,EmpFHName from EmpMst  order by Empname";
                        ds = ProjectFunctions.GetDataSet(strQry);
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGridView.BestFitColumns();
                        HelpGrid.Show();
                        HelpGrid.Focus();
                    }
                    else
                    {
                        strQry = strQry + "select empcode as Code,empname as Description,EmpFHName from EmpMst wHERE  empcode= '" + txtEmpCode.Text.ToString().Trim() + "' ";

                        ds = ProjectFunctions.GetDataSet(strQry);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtEmpCode.Text = ds.Tables[0].Rows[0]["Code"].ToString().Trim().ToUpper();
                            txtEmpCodeDesc.Text = ds.Tables[0].Rows[0]["Description"].ToString().Trim().ToUpper();
                            txtType.Focus();
                            GetBasicDetail();
                        }
                        else
                        {
                            var strQry1 = string.Empty;
                            strQry1 = strQry1 + "select empcode as Code,empname as Description,EmpFHName from EmpMst  order by Empname";
                            var ds1 = ProjectFunctions.GetDataSet(strQry1);
                            HelpGrid.DataSource = ds1.Tables[0];
                            HelpGridView.BestFitColumns();
                            HelpGrid.Show();
                            HelpGrid.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            e.Handled = true;
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

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            var row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "Emp")
            {
                txtEmpCode.Text = row["Code"].ToString().Trim();
                txtEmpCodeDesc.Text = row["Description"].ToString().Trim();
                HelpGrid.Visible = false;
                GetBasicDetail();
                txtType.Focus();
            }
            //if (HelpGrid.Text == "ERMCode")
            //{
            //    txtContCode.Text = row["ERMCode"].ToString().Trim();
            //    txtContCodeDesc.Text = row["ERMDesc"].ToString().Trim();
            //    HelpGrid.Visible = false;
            //    txtEmpCode.Focus();
            //}

        }

        private void TxtType_Validating(object sender, CancelEventArgs e)
        {
            if (txtType.Text == "A" || txtType.Text == "C" || txtType.Text == "F" || txtType.Text == "L" || txtType.Text == "T")
            {
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Valid Values are Advance(a),Fine(F),Coupon(C),Telephone(T),Lunch(L)", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtType.Focus();
            }
        }

        private void FrmAdvanceAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    System.Windows.Forms.SendKeys.Send("+{TAB}");
                }

                if (e.Control && e.KeyCode == Keys.S)
                {
                    btnSave.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (S1 == "Add")
            {
                if (txtPassword.Text == "ADV123")
                {
                    DtDate.Enabled = true;
                }
            }
        }

        private void TxtEmpCode_Leave(object sender, EventArgs e)
        {
        }

        private void TxtEmpCode_Enter(object sender, EventArgs e)
        {

        }

        private void TxtType_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {

        }

        private void TxtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSave_Click(null, e);
            }
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void DtDate_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(DtDate.Text).Date.Day <= 10)
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text).AddMonths(-1);
            }
            else
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text);
            }
        }

        private void DtDate_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDateTime(DtDate.Text).Date.Day <= 10)
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text).AddMonths(-1);
            }
            else
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text);
            }
        }

        private void DtDateforMonth_Enter(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(DtDate.Text).Date.Day <= 10)
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text).AddMonths(-1);
            }
            else
            {
                DtDateforMonth.EditValue = Convert.ToDateTime(DtDate.Text);
            }
        }
    }
}
