using SeqKartLibrary;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmJournalVoucher : DevExpress.XtraEditors.XtraForm
    {
        public String S1 { get; set; }
        DataSet dsPopUps = new DataSet();
        public String VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }

        DataTable dt = new DataTable();
        public frmJournalVoucher()
        {
            InitializeComponent();
            dt.Columns.Add("CRDR", typeof(String));
            dt.Columns.Add("AccCode", typeof(String));
            dt.Columns.Add("AccName", typeof(String));
            dt.Columns.Add("Debit", typeof(Decimal));
            dt.Columns.Add("Credit", typeof(Decimal));
            dt.Columns.Add("Narration", typeof(String));



            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadVoucherPopUps");
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


            if (HelpGrid.Text == "AccCode")
            {
                if (HelpGridView.RowCount > 0)
                {
                    DataRow dtNewRow = dt.NewRow();
                    dtNewRow["AccCode"] = row["AccCode"].ToString();
                    dtNewRow["AccName"] = row["AccName"].ToString();
                    dtNewRow["Debit"] = Convert.ToDecimal("0.00");
                    dtNewRow["Credit"] = Convert.ToDecimal("0.00");
                    dtNewRow["Narration"] = string.Empty;
                    dtNewRow["CRDR"] = "DR";

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
            ProjectFunctions.CreateRohitStylePopUpGridHelp(VoucherGrid, VoucherGridView, HelpGrid, HelpGridView, "AccCode", txtSearchBox, panelControl2, e);

        }

        private void VoucherGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            DataRow currentrow = VoucherGridView.GetDataRow(VoucherGridView.FocusedRowHandle);
            if (VoucherGridView.FocusedColumn.FieldName == "CRDR")
            {
                if(currentrow["CRDR"].ToString().ToUpper()=="CR")
                {
                    VoucherGridView.FocusedColumn = VoucherGridView.Columns["Credit"];
                }
                if (currentrow["CRDR"].ToString().ToUpper() == "DR")
                {
                    VoucherGridView.FocusedColumn = VoucherGridView.Columns["Debit"];
                    
                }
            }
        }
    }
}