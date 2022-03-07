using DevExpress.Utils.Menu;
using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmJournalVoucher : DevExpress.XtraEditors.XtraForm
    {
        public String S1 { get; set; }
        DataSet dsPopUps = new DataSet();
        public String VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }

        DataTable dt = new DataTable();
        int RowIndex;
        public FrmJournalVoucher()
        {
            InitializeComponent();
            dt.Columns.Add("CRDR", typeof(String));
            dt.Columns.Add("AccCode", typeof(String));
            dt.Columns.Add("AccName", typeof(String));
            dt.Columns.Add("Debit", typeof(Decimal));
            dt.Columns.Add("Credit", typeof(Decimal));
            dt.Columns.Add("Narration", typeof(String));


            //  VoucherGrid.DataSource = dt;


            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadVoucherPopUps '" + GlobalVariables.ProgCode + "'");
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e)
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
                txtCatgCode.Focus();
            }
            if (HelpGrid.Text == "txtCatgCode")
            {
                txtCatgCode.Text = row["CatgCode"].ToString();
                txtCatgDesc.Text = row["CatgDesc"].ToString();
                HelpGrid.Visible = false;
                panelControl2.Visible = false;
                txtShortNarration.Focus();
            }

            if (HelpGrid.Text == "CRDR")
            {

                DataRow dtNewRow = dt.NewRow();
                dtNewRow["AccCode"] = string.Empty;
                dtNewRow["AccName"] = string.Empty;
                dtNewRow["Debit"] = Convert.ToDecimal("0.00");
                dtNewRow["Credit"] = Convert.ToDecimal("0.00");
                dtNewRow["Narration"] = string.Empty;
                dtNewRow["CRDR"] = row["ValueCode"].ToString();
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
                VoucherGridView.FocusedColumn = VoucherGridView.Columns["AccCode"];
                VoucherGridView.Focus();
                HelpGrid.Visible = false;
                panelControl2.Visible = false;

            }
            if (HelpGrid.Text == "AccCode")
            {
                if (HelpGridView.RowCount > 0)
                {

                    VoucherGridView.SetRowCellValue(RowIndex, VoucherGridView.Columns["AccCode"], row["AccCode"].ToString());
                    VoucherGridView.SetRowCellValue(RowIndex, VoucherGridView.Columns["AccName"], row["AccName"].ToString());
                    panelControl2.Visible = false;
                    VoucherGridView.Focus();

                    VoucherGridView.FocusedRowHandle = RowIndex;



                    DataRow CurrentRow = VoucherGridView.GetDataRow(RowIndex);
                    if (CurrentRow["CRDR"].ToString().ToUpper() == "CR")
                    {
                        VoucherGridView.FocusedColumn = VoucherGridView.Columns["Credit"];
                        VoucherGridView.ShowEditor();
                    }
                    if (CurrentRow["CRDR"].ToString().ToUpper() == "DR")
                    {
                        VoucherGridView.FocusedColumn = VoucherGridView.Columns["Debit"];
                        VoucherGridView.ShowEditor();
                    }

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

                if (HelpGrid.Text == "txtCatgCode")
                {

                    DataTable dtNew = dsPopUps.Tables[4].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[4].Select("CatgDesc like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["CatgCode"] = dr["CatgCode"];
                        NewRow["CatgDesc"] = dr["CatgDesc"];


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
                if (HelpGrid.Text == "CRDR")
                {

                    DataTable dtNew = dsPopUps.Tables[5].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[5].Select("ValueName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["ValueCode"] = dr["ValueCode"];
                        NewRow["ValueName"] = dr["ValueName"];
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

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtVoucherTypeCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreateRohitStylePopUpTwoInputs(HelpGrid, HelpGridView, txtSearchBox, txtVoucherTypeCode, panelControl2, e);
        }

        private void VoucherGrid_KeyDown(object sender, KeyEventArgs e)
        {
            RowIndex = VoucherGridView.FocusedRowHandle;
            if (VoucherGridView.FocusedColumn.FieldName == "AccCode")
            {
                ProjectFunctions.CreateRohitStylePopUpGridHelp(VoucherGrid, VoucherGridView, HelpGrid, HelpGridView, "AccCode", txtSearchBox, panelControl2, e);

            }
            if (VoucherGridView.FocusedColumn.FieldName == "CRDR")
            {
                ProjectFunctions.CreateRohitStylePopUpGridHelp(VoucherGrid, VoucherGridView, HelpGrid, HelpGridView, "CRDR", txtSearchBox, panelControl2, e);

            }
        }

        private void VoucherGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //DataRow currentrow = VoucherGridView.GetDataRow(VoucherGridView.FocusedRowHandle);
            //if (VoucherGridView.FocusedColumn.FieldName == "CRDR")
            //{
            //    if(currentrow["CRDR"].ToString().ToUpper()=="CR")
            //    {
            //        VoucherGridView.FocusedColumn = VoucherGridView.Columns["Credit"];
            //    }
            //    if (currentrow["CRDR"].ToString().ToUpper() == "DR")
            //    {
            //        VoucherGridView.FocusedColumn = VoucherGridView.Columns["Debit"];

            //    }
            //}
        }
        private string GetNewInvoiceDocumentNo()
        {
            var s2 = string.Empty;
            try
            {
                var strsql = string.Empty;
                var ds = new DataSet();
                strsql += "select isnull(max(Cast(VumNo as int)),0) from VuMst Where  VumType='JL'";
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
        private void AddInvoice()
        {
            Decimal VoucherAmount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToDecimal(dr["Debit"]) > 0)
                {
                    VoucherAmount += Convert.ToDecimal(dr["Debit"]);
                }

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
                    string str = "Insert Into VuMst(VumNo,VumDate,VumType,VumAmt,VumAutoGen,ShortNarration,LongNarration,VumCatgCode)values(";
                    str = str + "'" + DocNo + "',";
                    str = str + "'" + Convert.ToDateTime(txtVoucherDate.EditValue).ToString("yyyy-MM-dd") + "',";
                    str = str + "'" + txtVoucherTypeCode.Text.Trim() + "',";
                    str = str + "'" + VoucherAmount + "','N','" + txtShortNarration.Text.Trim() + "','" + txtLongNarration.Text.Trim() + "','" + txtCatgCode.Text + "')";
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
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Credit"]) + "',";
                        if (dr["CRDR"].ToString().ToUpper() == "DR")
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Debit"]) + "',";
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "','" + txtLongNarration.Text + "')";


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
                if (Convert.ToDecimal(dr["Debit"]) > 0)
                {
                    VoucherAmount += Convert.ToDecimal(dr["Debit"]);

                }

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
                    str = str + " VumAmt='" + VoucherAmount + "',";
                    str = str + " VumCatgCode='" + txtCatgCode.Text.Trim() + "',";
                    str = str + " ShortNarration='" + txtShortNarration.Text.Trim() + "',LongNarration='" + txtLongNarration.Text + "'";
                    str = str + " Where VumNo='" + VoucherNo + "' And VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    var query = "Delete from VuData Where VutNo='" + VoucherNo + "' And VutDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + " And Vuttype='JL'";
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
                            str1 = str1 + "'" + -Convert.ToDecimal(dr["Credit"]) + "',";
                        }
                        if (dr["CRDR"].ToString().ToUpper() == "DR")
                        {
                            str1 = str1 + "'" + Convert.ToDecimal(dr["Debit"]) + "',";
                        }
                        str1 = str1 + "'" + dr["AccCode"].ToString() + "',";
                        str1 = str1 + "'" + dr["Narration"].ToString() + "','" + txtLongNarration.Text + "')";


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
                    ProjectFunctions.SpeakError(ex.Message);
                    transaction.Rollback();
                }
            }
        }
        private bool ValidateDataForSaving()
        {

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
            //if (txtShortNarration.Text.Length <= 10)
            //{
            //    //ProjectFunctions.SpeakError("Short Narration Should Be At Least 10 Characters");
            //    txtShortNarration.Focus();
            //    return false;
            //}
            //if (txtLongNarration.Text.Length <= 100)
            //{
            //  //  ProjectFunctions.SpeakError("Long Narration Should Be At Least 100 Characters");
            //    txtLongNarration.Focus();
            //    return false;
            //}
            decimal DebitAmt = 0;
            decimal CreditAmt = 0;
            foreach (DataRow dr in dt.Rows)
            {
                DebitAmt += Convert.ToDecimal(dr["Debit"]);
                CreditAmt += Convert.ToDecimal(dr["Credit"]);
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

        private void FrmJournalVoucher_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(panelControl1);
            ProjectFunctions.TextBoxVisualize(panelControl2);
            ProjectFunctions.TextBoxVisualize(this);

            if (S1 == "&Add")
            {
                txtVoucherDate.EditValue = DateTime.Now;
                txtVoucherNo.Text = GetNewInvoiceDocumentNo().ToString();
                txtVoucherTypeCode.Select();
            }
            else
            {
                txtVoucherDate.Enabled = false;
                txtVoucherTypeCode.Enabled = false;
                var str = "[sp_LoadJournalVouDataFEditing] @VumNo='" + VoucherNo + "',@VumDate='" + Convert.ToDateTime(VoucherDate).ToString("yyyy-MM-dd") + "'";
                DataSet ds = ProjectFunctions.GetDataSet(str);
                txtVoucherNo.Text = VoucherNo;
                txtVoucherDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["VumDate"]).ToString("yyyy-MM-dd");
                txtVoucherTypeCode.Text = ds.Tables[0].Rows[0]["VumType"].ToString();
                txtVoucherTypeDesc.Text = ds.Tables[0].Rows[0]["VouDesc"].ToString();
                txtShortNarration.Text = ds.Tables[0].Rows[0]["ShortNarration"].ToString();
                txtLongNarration.Text = ds.Tables[0].Rows[0]["LongNarration"].ToString();
                txtCatgCode.Text = ds.Tables[0].Rows[0]["VumCatgCode"].ToString();
                txtCatgDesc.Text = ds.Tables[0].Rows[0]["CatgDesc"].ToString();
                if (ds.Tables[1].Rows.Count > 0)
                {
                    ds.Tables[1].Columns.Add("Debit", typeof(Decimal));
                    ds.Tables[1].Columns.Add("Credit", typeof(Decimal));


                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        if (Convert.ToDecimal(dr["Amount"]) < 0)
                        {
                            dr["CRDR"] = "CR";
                            dr["Credit"] = -Convert.ToDecimal(dr["Amount"]);
                            dr["Debit"] = -Convert.ToDecimal("0");
                        }
                        if (Convert.ToDecimal(dr["Amount"]) > 0)
                        {
                            dr["CRDR"] = "DR";
                            dr["Debit"] = Convert.ToDecimal(dr["Amount"]);
                            dr["Credit"] = -Convert.ToDecimal("0");
                        }
                    }
                    dt = ds.Tables[1];
                    VoucherGrid.DataSource = dt;
                    VoucherGridView.BestFitColumns();
                }




                txtCatgCode.Focus();
            }
        }

        private void TxtCatgCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreateRohitStylePopUpTwoInputs(HelpGrid, HelpGridView, txtSearchBox, txtCatgCode, panelControl2, e);
        }

        private void VoucherGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (VoucherGridView.FocusedColumn.FieldName == "Credit" || VoucherGridView.FocusedColumn.FieldName == "Debit")
                {
                    VoucherGridView.FocusedColumn = VoucherGridView.Columns["Narration"];
                    VoucherGridView.ShowEditor();
                }
            }
        }
    }
}