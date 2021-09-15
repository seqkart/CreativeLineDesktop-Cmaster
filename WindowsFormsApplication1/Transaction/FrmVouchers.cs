using DevExpress.Utils.Menu;
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
            dt.Columns.Add("CRDR", typeof(String));
            dt.Columns.Add("AccCode", typeof(String));
            dt.Columns.Add("AccName", typeof(String));
            dt.Columns.Add("Amount", typeof(Decimal));
            dt.Columns.Add("Narration", typeof(String));

            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadVoucherPopUps '" + GlobalVariables.ProgCode + "'");

        }

        private string GetNewInvoiceDocumentNo()
        {
            var s2 = string.Empty;
            try
            {
                var strsql = string.Empty;
                var ds = new DataSet();
                strsql = strsql + "select isnull(max(Cast(VumNo as int)),0) from VuMst Where  vumType ='" + txtVoucherTypeCode.Text + "'";
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
            if (txtShortNarration.Text.Length <= 10)
            {
                ProjectFunctions.SpeakError("Short Narration Should Be At Least 10 Characters");
                txtShortNarration.Focus();
                return false;
            }
            if (txtLongNarration.Text.Length <= 100)
            {
                ProjectFunctions.SpeakError("Long Narration Should Be At Least 100 Characters");
                txtLongNarration.Focus();
                return false;
            }
            //decimal DebitAmt = 0;
            //decimal CreditAmt = 0;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    DebitAmt = DebitAmt + Convert.ToDecimal(dr["Debit"]);
            //    CreditAmt = CreditAmt + Convert.ToDecimal(dr["Credit"]);
            //}
            //if (DebitAmt == CreditAmt)
            //{
            //    //  VoucherAmount = DebitAmt;
            //}
            //else
            //{
            //    ProjectFunctions.SpeakError("Debit Amount Should Be Equal To Credit Amount");
            //    return false;
            //}

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
                txtVoucherTypeCode.Select();

                txtVoucherNo.Text = GetNewInvoiceDocumentNo().ToString();
            }
            else
            {
                txtVoucherDate.Enabled = false;
                txtVoucherTypeCode.Enabled = false;
                var str = "[sp_LoadVouDataFEditing] @VumNo='" + VoucherNo + "',@VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                DataSet ds = ProjectFunctions.GetDataSet(str);
                txtVoucherNo.Text = VoucherNo;
                txtVoucherDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["VumDate"]).ToString("yyyy-MM-dd");
                txtVoucherTypeCode.Text = ds.Tables[0].Rows[0]["VumType"].ToString();
                txtVoucherTypeDesc.Text = ds.Tables[0].Rows[0]["VouDesc"].ToString();
                txtAccountCode.Text = ds.Tables[0].Rows[0]["VumBcode"].ToString();
                txtAccountName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                txtShortNarration.Text = ds.Tables[0].Rows[0]["ShortNarration"].ToString();
                txtLongNarration.Text = ds.Tables[0].Rows[0]["LongNarration"].ToString();

                foreach (DataRow dr in ds.Tables[1].Rows)
                {
                    if (Convert.ToDecimal(dr["Amount"]) < 0)
                    {
                        dr["CRDR"] = "CR";

                        
                    }
                    if (Convert.ToDecimal(dr["Amount"]) > 0)
                    {
                        dr["CRDR"] = "DR";
                    }


                    if (Convert.ToDecimal(dr["Amount"]) < 0)
                    {
                        dr["Amount"] = -Convert.ToDecimal(dr["Amount"]);
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
                txtShortNarration.Focus();
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
                    dtNewRow["CRDR"] = SetCrDrValue();

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
                    VoucherGridView.ShowEditor();
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
         
                if (HelpGrid.Text == "txtAccountCode")
                {

                    DataTable dtNew = new DataTable();
                    DataRow[] dtRow;

                    if (txtVoucherTypeCode.Text.Trim() == "BR" || txtVoucherTypeCode.Text.Trim() == "BP")
                    {
                        dtNew = dsPopUps.Tables[2].Clone();
                        dtRow = dsPopUps.Tables[2].Select("AccName like '" + txtSearchBox.Text + "%'");
                    }
                    else
                    {
                        if (txtVoucherTypeCode.Text.Trim() == "CR" || txtVoucherTypeCode.Text.Trim() == "CP")
                        {
                            dtNew = dsPopUps.Tables[3].Clone();
                            dtRow = dsPopUps.Tables[3].Select("AccName like '" + txtSearchBox.Text + "%'");
                        }
                        else
                        {
                            dtNew = dsPopUps.Tables[1].Clone();
                            dtRow = dsPopUps.Tables[1].Select("AccName like '" + txtSearchBox.Text + "%'");
                        }
                    }

                    
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

                if (HelpGrid.Text == "AccCode")
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
            Decimal VoucherAmount = 0;
            foreach(DataRow dr in dt.Rows)
            {
                VoucherAmount = VoucherAmount + Convert.ToDecimal(dr["Amount"]);
            }


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
                    string DocNo = GetNewInvoiceDocumentNo().ToString();
                    string str = "Insert Into VuMst(VumNo,VumDate,VumType,VumAmt,VumAutoGen,VumBCode,ShortNarration,LongNarration)values(";
                    str = str + "'" + DocNo + "',";
                    str = str + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                    str = str + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                    str = str + "'" + VoucherAmount + "','N','" + txtAccountCode.Text.Trim() + "','" + txtShortNarration.Text.Trim() + "','" + txtLongNarration.Text.Trim() + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    String DRCR = String.Empty;

                    foreach (DataRow dr in dt.Rows)
                    {
                        string str1 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart,LongNarration)values(";
                        str1 = str1 + "'" + DocNo + "',";
                        str1 = str1 + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                        str1 = str1 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                        if (dr["CRDR"].ToString().ToUpper() == "CR")
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Amount"]) + "',";
                        if (dr["CRDR"].ToString().ToUpper() == "DR")
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Amount"]) + "',";
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "','" + txtLongNarration.Text + "')";


                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = str1;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        DRCR = dr["CRDR"].ToString().ToUpper();

                    }

                    string str2 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart,LongNarration)values(";
                    str2 = str2 + "'" + DocNo + "',";
                    str2 = str2 + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                    str2 = str2 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                    if (DRCR == "CR")
                    {
                        str2 = str2 + "'" + VoucherAmount + "',";
                    }
                    if (DRCR == "DR")
                    {
                        str2 = str2 + "'" + -VoucherAmount + "',";
                    }
                    str2 = str2 + "'" + txtAccountCode.Text + "',";
                    str2 = str2 + "'" + txtLongNarration + "','" + txtLongNarration.Text + "')";


                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str2;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    ProjectFunctions.SpeakError(ex.Message);
                    transaction.Rollback();
                }
            }
        }


        private void EditInvoice()
        {
            Decimal VoucherAmount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                VoucherAmount = VoucherAmount + Convert.ToDecimal(dr["Amount"]);
            }

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
                    str = str + " VumAmt='" + VoucherAmount + "',VumBCode='" + txtAccountCode.Text + "',";
                    str = str + " ShortNarration='" + txtShortNarration.Text.Trim() + "',LongNarration='" + txtLongNarration.Text + "'";
                    str = str + " Where VumNo='" + VoucherNo + "' And VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    var query = "Delete from VuData Where VutNo='" + VoucherNo + "' And VutDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "' And Vuttype='" + txtVoucherTypeCode.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();


                    String DRCR = String.Empty;


                    foreach (DataRow dr in dt.Rows)
                    {
                        string str1 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart,LongNarration)values(";
                        str1 = str1 + "'" + VoucherNo + "',";
                        str1 = str1 + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                        str1 = str1 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                        if (dr["CRDR"].ToString().ToUpper() == "CR")
                        {
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Amount"]) + "',";
                        }
                        if (dr["CRDR"].ToString().ToUpper() == "DR")
                        {
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Amount"]) + "',";
                        }
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "','" + txtLongNarration.Text + "')";


                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = str1;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                        DRCR = dr["CRDR"].ToString().ToUpper();


                    }

                    string str2 = "Insert Into VuData(VutNo,VutDate,VutType,VutAmt,VutACode,VutNart,LongNarration)values(";
                    str2 = str2 + "'" + VoucherNo + "',";
                    str2 = str2 + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                    str2 = str2 + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                    if (DRCR == "CR")
                    {
                        str2 = str2 + "'" + VoucherAmount + "',";
                    }
                    if (DRCR == "DR")
                    {
                        str2 = str2 + "'" + -VoucherAmount + "',";
                    }
                    str2 = str2 + "'" + txtAccountCode.Text + "',";
                    str2 = str2 + "'" + txtLongNarration + "','" + txtLongNarration.Text + "')";


                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str2;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();



                    transaction.Commit();
                    Close();
                }
                catch (Exception ex)
                {
                    ProjectFunctions.SpeakError(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private string SetCrDrValue()
        {
            String DrCrVariable = string.Empty;
            if (txtVoucherTypeCode.Text == "CP")
            {
                DrCrVariable = "DR";
            }
            if (txtVoucherTypeCode.Text == "CR")
            {
                DrCrVariable = "CR";
            }
            
            if (txtVoucherTypeCode.Text == "BP")
            {
                DrCrVariable = "DR";
            }
            if (txtVoucherTypeCode.Text == "BR")
            {
                DrCrVariable = "CR";
            }
            return DrCrVariable;
        }
        private void BtnSave_Click(object sender, EventArgs e)
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

        private void VoucherGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRow currentrow = VoucherGridView.GetDataRow(VoucherGridView.FocusedRowHandle);
            if (VoucherGridView.FocusedColumn.FieldName == "AccCode")
            {
                VoucherGridView.SetRowCellValue(VoucherGridView.FocusedRowHandle, VoucherGridView.Columns["CRDR"], SetCrDrValue());
            }
        }

        private void VoucherGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VoucherGridView.FocusedColumn.FieldName == "Amount")
                {
                    VoucherGridView.FocusedColumn = VoucherGridView.Columns["Narration"];
                    VoucherGridView.ShowEditor();
                }
            }
        }

        private void VoucherGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DXMenuItem("Delete Current Row", (o1, e1) =>
                {
                    VoucherGridView.DeleteRow(VoucherGridView.FocusedRowHandle);
                    dt.AcceptChanges();
                }));
            }
            catch (Exception ex)
            {
                MessageBox_Debug.ShowBox(ex);
            }
        }
    }
}