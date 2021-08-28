using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmVouchers : DevExpress.XtraEditors.XtraForm
    {
        public String S1 { get; set; }
        DataSet dsPopUps = new DataSet();
        public String VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }



        DataTable dt = new DataTable();
        public FrmVouchers()
        {
            InitializeComponent();
            dt.Columns.Add("AccCode", typeof(String));
            dt.Columns.Add("AccName", typeof(String));
            dt.Columns.Add("Amount", typeof(Decimal));
            dt.Columns.Add("Narration", typeof(String));



            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadVoucherPopUps");

        }

        private string getNewInvoiceDocumentNo()
        {
            var s2 = string.Empty;
            try
            {
                var strsql = string.Empty;
                var ds = new DataSet();
                strsql = strsql + "select isnull(max(Cast(VumNo as int)),0000000) from VuMst Where  VumDate='" + txtVoucherDate.DateTime.Date.ToString("yyyy-MM-dd") + "'";
                ds = ProjectFunctions.GetDataSet(strsql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                    s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return s2;
        }
        private bool ValidateDataForSaving()
        {
            if (txtAccountCode.Text.Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Account Code");
                txtAccountCode.Focus();
                return false;
            }
            if (txtAccountName.Text.Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Account Name");
                txtAccountCode.Focus();
                return false;
            }
            if (txtVoucherTypeCode.Text.Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid VuType");
                txtVoucherTypeCode.Focus();
                return false;
            }
            if (txtVoucherTypeDesc.Text.Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid VuType");
                txtVoucherTypeCode.Focus();
                return false;
            }

            decimal DebitAmt = 0;
            decimal CreditAmt = 0;
            foreach (DataRow dr in dt.Rows)
            {
                DebitAmt = DebitAmt + Convert.ToDecimal(dr["Debit"]);
                CreditAmt = CreditAmt + Convert.ToDecimal(dr["Credit"]);
            }
            if (DebitAmt == CreditAmt)
            {
                //  VoucherAmount = DebitAmt;
            }
            else
            {
                ProjectFunctions.SpeakError("Debit Amount Should Be Equal To Credit Amount");
                return false;
            }

            return true;
        }
        private void FrmVouchers_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(panelControl1);
            ProjectFunctions.TextBoxVisualize(panelControl2);
            ProjectFunctions.TextBoxVisualize(this);

            if (S1 == "&Add")
            {
                txtVoucherDate.EditValue = DateTime.Now;
                txtVoucherTypeCode.Focus();
            }
            else
            {
                txtVoucherDate.Enabled = false;
                txtVoucherTypeCode.Enabled = false;
                var str = "[sp_LoadVouDataFEditing] @VumNo='" + VoucherNo + "',@VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                DataSet ds = ProjectFunctions.GetDataSet(str);
                txtVoucherDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["VumDate"]).ToString("yyyy-MM-dd");
                txtVoucherTypeCode.Text = ds.Tables[0].Rows[0]["VumType"].ToString();
                txtVoucherTypeDesc.Text = ds.Tables[0].Rows[0]["VouDesc"].ToString();

                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    if (Convert.ToDecimal(dr["Amount"]) < 0)
                    {
                        dr["CrDr"] = "CR";
                    }
                    if (Convert.ToDecimal(dr["Amount"]) > 0)
                    {
                        dr["CrDr"] = "DR";
                    }
                }


                dt = ds.Tables[1];
                VoucherGrid.DataSource = dt;
                VoucherGridView.BestFitColumns();
                txtAccountCode.Focus();
            }

        }

        private void HelpGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try

            {
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGrid_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Escape)
                {
                    panelControl2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtSearchBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try

            {
                HelpGridView.CloseEditor();
                HelpGridView.UpdateCurrentRow();
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGrid_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Down)
                {
                    HelpGrid.Focus();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    panelControl2.Visible = false;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            HelpGridView.CloseEditor();
            HelpGridView.UpdateCurrentRow();
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

            if (HelpGrid.Text == "txtVoucherTypeCode")
            {
                txtVoucherTypeCode.Text = row["VouCode"].ToString();
                txtVoucherTypeDesc.Text = row["VouDesc"].ToString();
                HelpGrid.Visible = false;
                panelControl2.Visible = false;
                txtAccountCode.Focus();
            }
            if (HelpGrid.Text == "txtAccountCode")
            {
                txtAccountCode.Text = row["AccCode"].ToString();
                txtAccountName.Text = row["AccName"].ToString();
                HelpGrid.Visible = false;
                panelControl2.Visible = false;
                txtAccountCode.Focus();
            }

            if (HelpGrid.Text == "AccCode")
            {
                if (HelpGridView.RowCount > 0)
                {
                    DataRow dtNewRow = dt.NewRow();
                    dtNewRow["AccCode"] = row["AccCode"].ToString();
                    dtNewRow["AccName"] = row["AccName"].ToString();
                    dtNewRow["Amount"] = Convert.ToDecimal("0.00");
                    dtNewRow["Narration"] = string.Empty;

                    dt.Rows.Add(dtNewRow);
                    if (dt.Rows.Count > 0)
                    {
                        VoucherGrid.DataSource = dt;
                        VoucherGridView.BestFitColumns();
                    }
                    else
                    {
                        VoucherGrid.DataSource = null;
                        VoucherGridView.BestFitColumns();
                    }
                    panelControl2.Visible = false;
                    VoucherGridView.Focus();
                    VoucherGridView.MoveLast();
                    VoucherGridView.FocusedColumn = VoucherGridView.Columns["Amount"];
                    txtSearchBox.Text = string.Empty;
                }
            }
        }

        private void TxtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                HelpGrid.Show();

                if (HelpGrid.Text == "txtVoucherTypeCode")
                {

                    DataTable dtNew = dsPopUps.Tables[0].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[0].Select("VouDesc like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["VouCode"] = dr["VouCode"];
                        NewRow["VouDesc"] = dr["VouDesc"];


                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGridView.Columns.Clear();
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();

                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
                if (HelpGrid.Text == "txtAccountCode" || HelpGrid.Text == "AccCode")
                {

                    DataTable dtNew = dsPopUps.Tables[1].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[1].Select("AccName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["AccCode"] = dr["AccCode"];
                        NewRow["AccName"] = dr["AccName"];


                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGridView.Columns.Clear();
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }


            }

            catch (Exception)
            {

            }
        }

        private void TxtVoucherTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreateRohitStylePopUpTwoInputs(HelpGrid, HelpGridView, txtSearchBox, txtVoucherTypeCode, panelControl2, e);
        }

        private void TxtAccountCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreateRohitStylePopUpTwoInputs(HelpGrid, HelpGridView, txtSearchBox, txtAccountCode, panelControl2, e);
        }

        private void BarCodeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreateRohitStylePopUpGridHelp(VoucherGrid, VoucherGridView, HelpGrid, HelpGridView, "AccCode", txtSearchBox, panelControl2, e);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddInvoice()
        {
            using (var con = new SqlConnection(ProjectFunctions.GetConnection()))
            {
                con.Open();
                var cmd = new SqlCommand
                {
                    Connection = con
                };
                var transaction = con.BeginTransaction("SaveTransaction");
                cmd.Transaction = transaction;
                try
                {
                    string DocNo = getNewInvoiceDocumentNo().ToString().PadLeft(7, '0');
                    string str = "Insert Into VuMst(VumNo,VumDate,VumType,VumAmt,VumAutoGen)values(";
                    str = str + "'" + DocNo + "',";
                    str = str + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                    str = str + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                    //   str = str + "'" + VoucherAmount + "','N')";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    foreach (DataRow dr in dt.Rows)
                    {
                        string str1 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart)values(";
                        str1 = str1 + "'" + VoucherNo + "',";
                        str1 = str1 + "'" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "',";
                        str1 = str1 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                        if (dr["CrDr"].ToString().ToUpper() == "CR")
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Amount"]) + "',";
                        if (dr["CrDr"].ToString().ToUpper() == "DR")
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Amount"]) + "',";
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "')";


                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = str1;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }
                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }


        private void EditInvoice()
        {
            using (var con = new SqlConnection(ProjectFunctions.GetConnection()))
            {
                con.Open();
                var cmd = new SqlCommand
                {
                    Connection = con
                };
                var transaction = con.BeginTransaction("SaveTransaction");
                cmd.Transaction = transaction;
                try
                {

                    string str = "Update VuMst Set ";
                    // str = str + " VumAmt='" + VoucherAmount + "'";
                    str = str + " Where VumNo='" + VoucherNo + "' And VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    var query = "Delete from VuData Where VutNo='" + VoucherNo + "' And VutDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();



                    foreach (DataRow dr in dt.Rows)
                    {
                        string str1 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart)values(";
                        str1 = str1 + "'" + VoucherNo + "',";
                        str1 = str1 + "'" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "',";
                        str1 = str1 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                        if (dr["CrDr"].ToString().ToUpper() == "CR")
                        {
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Amount"]) + "',";
                        }
                        if (dr["CrDr"].ToString().ToUpper() == "DR")
                        {
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Amount"]) + "',";
                        }
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "')";


                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = str1;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }
                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataForSaving())
            {
                if (S1 == "&Add")
                {
                    AddInvoice();
                }
                if (S1 == "Edit")
                {
                    EditInvoice();
                }
            }
        }
    }
}