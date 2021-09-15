using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmInvoiceMstAddCR : DevExpress.XtraEditors.XtraForm
    {
        public string ProgCode { get; set; }
        public string S1 { get; set; }
        DataTable dt = new DataTable();
        public string ImNo { get; set; }
        public DateTime ImDate { get; set; }
        public string ImSeries { get; set; }

        private static readonly string empty = string.Empty;
        string StkTransfer = empty;
        decimal AccMRPMarkDown = 0;


        string FixPartyTag;
        public FrmInvoiceMstAddCR()
        {
            InitializeComponent();
            dt.Columns.Add("SIDBARCODE", typeof(string));
            dt.Columns.Add("SIDARTNO", typeof(string));
            dt.Columns.Add("SIDARTDESC", typeof(string));
            dt.Columns.Add("SIDCOLN", typeof(string));
            dt.Columns.Add("SIDSIZN", typeof(string));
            dt.Columns.Add("SIDSCANQTY", typeof(decimal));
            dt.Columns.Add("SIDARTMRP", typeof(decimal));
            dt.Columns.Add("SIDARTWSP", typeof(decimal));
            dt.Columns.Add("SIDITMDISCPRCN", typeof(decimal));
            dt.Columns.Add("SIDITMDISCAMT", typeof(decimal));
            dt.Columns.Add("SIDITMNETAMT", typeof(decimal));
            dt.Columns.Add("SIDBOXQTY", typeof(decimal));
            dt.Columns.Add("SIDBOXMRPVAL", typeof(decimal));
            dt.Columns.Add("SIDBOXWSPVAL", typeof(decimal));
            dt.Columns.Add("SIDARTID", typeof(string));
            dt.Columns.Add("SIDCOLID", typeof(string));
            dt.Columns.Add("SIDSIZID", typeof(string));
            dt.Columns.Add("SIDPSDATE", typeof(DateTime));
            dt.Columns.Add("SIDPSID", typeof(string));
            dt.Columns.Add("SIDPSNO", typeof(string));
            dt.Columns.Add("SIDSGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDCGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDIGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDCGSTPER", typeof(decimal));
            dt.Columns.Add("SIDSGSTPER", typeof(decimal));
            dt.Columns.Add("SIDIGSTPER", typeof(decimal));
            dt.Columns.Add("ARTMARGIN", typeof(decimal));
            dt.Columns.Add("TAXCODE", typeof(string));
            dt.Columns.Add("GRPHSNCODE", typeof(string));
            dt.Columns.Add("BillNo", typeof(string));
            dt.Columns.Add("BillDate", typeof(DateTime));

        }
        private void SetMyControls()
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.TextBoxVisualize(groupControl1);
            ProjectFunctions.DatePickerVisualize(groupControl2);
            ProjectFunctions.ButtonVisualize(this);
            ProjectFunctions.TextBoxVisualize(groupControl2);
        }



        private void Calculation()
        {
            InfoGridView.CloseEditor();
            InfoGridView.UpdateCurrentRow();
            BeginInvoke(new MethodInvoker(delegate
            {
                InfoGridView.PostEditor();
                InfoGridView.UpdateCurrentRow();
            }));
            DataSet ds = new DataSet();
            decimal SumDiscAmount = 0;
            decimal SumValueOfGoods = 0;
            decimal SumCGSTAmount = 0;
            decimal SumSGSTAmount = 0;
            decimal SumIGSTAmount = 0;
            foreach (DataRow dr in dt.Rows)
            {

                SumValueOfGoods = SumValueOfGoods + Convert.ToDecimal(dr["SIDITMNETAMT"]);
                SumDiscAmount = SumDiscAmount + Convert.ToDecimal(dr["SIDITMDISCAMT"]);
                SumCGSTAmount = SumCGSTAmount + Convert.ToDecimal(dr["SIDCGSTAMT"]);
                SumSGSTAmount = SumSGSTAmount + Convert.ToDecimal(dr["SIDSGSTAMT"]);
                SumIGSTAmount = SumIGSTAmount + Convert.ToDecimal(dr["SIDIGSTAMT"]);

            }

            txtTotalTaxAmount.Text = (SumCGSTAmount + SumSGSTAmount + SumIGSTAmount).ToString("0.00");
            txtMainDiscVal.Text = "0.00";
            txtValueOfGoods.Text = SumValueOfGoods.ToString("0.00");
            txtTotalDisc.Text = SumDiscAmount.ToString("0.00");
            txtInsuranceAmount.Text = ((Convert.ToDecimal(txtValueOfGoods.Text) * Convert.ToDecimal(txtInsurancePer.Text)) / 100).ToString("0.00");
            decimal NetAmount = 0;
            NetAmount = (SumValueOfGoods + SumCGSTAmount + SumSGSTAmount + SumIGSTAmount + Convert.ToDecimal(txtInsuranceAmount.Text) + Convert.ToDecimal(txtPKGFrt.Text) + Convert.ToDecimal(txtOctoriAmount.Text));
            txtRNetAmount.Text = Math.Round(NetAmount + Convert.ToDecimal(txtRound2.Text), 0).ToString("0.00");
            txtRoundOffAmount.Text = (Convert.ToDecimal(txtRNetAmount.Text) - NetAmount).ToString("0.00");



            TaxCodeWiseSummary();
            HSNWiseSummary();

            labelControl6.Text = Convert.ToDecimal(dt.Compute("SUM(SIDSCANQTY)", string.Empty)).ToString("0");


        }
        private void TaxCodeWiseSummary()
        {
            DataTable dtTax1 = new DataTable();

            dtTax1.Columns.Add("SIDSCANQTY", typeof(decimal));
            dtTax1.Columns.Add("SIDITMNETAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDSGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDCGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDIGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDCGSTPER", typeof(decimal));
            dtTax1.Columns.Add("SIDSGSTPER", typeof(decimal));
            dtTax1.Columns.Add("SIDIGSTPER", typeof(decimal));
            dtTax1.Columns.Add("TAXCODE", typeof(string));
            var distinctRows = (from DataRow dRow in dt.Rows
                                select (Convert.ToDecimal(dRow["SIDCGSTPER"]) + Convert.ToDecimal(dRow["SIDSGSTPER"]) + Convert.ToDecimal(dRow["SIDIGSTPER"]))).Distinct();
            foreach (var v in distinctRows)
            {
                decimal SIDSCANQTY = 0;
                decimal SIDITMNETAMT = 0;
                decimal SIDSGSTAMT = 0;
                decimal SIDCGSTAMT = 0;
                decimal SIDIGSTAMT = 0;
                decimal SIDCGSTPER = 0;
                decimal SIDSGSTPER = 0;
                decimal SIDIGSTPER = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    if ((Convert.ToDecimal(dr["SIDCGSTPER"]) + Convert.ToDecimal(dr["SIDSGSTPER"]) + Convert.ToDecimal(dr["SIDIGSTPER"])).ToString("0.00") == Convert.ToDecimal(v).ToString("0.00"))
                    {
                        SIDSCANQTY = SIDSCANQTY + Convert.ToDecimal(dr["SIDSCANQTY"]);
                        SIDITMNETAMT = SIDITMNETAMT + Convert.ToDecimal(dr["SIDITMNETAMT"]);
                        SIDSGSTAMT = SIDSGSTAMT + Convert.ToDecimal(dr["SIDSGSTAMT"]);
                        SIDCGSTAMT = SIDCGSTAMT + Convert.ToDecimal(dr["SIDCGSTAMT"]);
                        SIDIGSTAMT = SIDIGSTAMT + Convert.ToDecimal(dr["SIDIGSTAMT"]);
                        SIDCGSTPER = Convert.ToDecimal(dr["SIDCGSTPER"]);
                        SIDSGSTPER = Convert.ToDecimal(dr["SIDSGSTPER"]);
                        SIDIGSTPER = Convert.ToDecimal(dr["SIDIGSTPER"]);
                    }
                }

                DataRow newrow1 = dtTax1.NewRow();
                newrow1["TAXCODE"] = v.ToString();
                newrow1["SIDSCANQTY"] = SIDSCANQTY;
                newrow1["SIDITMNETAMT"] = SIDITMNETAMT;
                newrow1["SIDSGSTAMT"] = SIDSGSTAMT;
                newrow1["SIDCGSTAMT"] = SIDCGSTAMT;
                newrow1["SIDIGSTAMT"] = SIDIGSTAMT;
                newrow1["SIDCGSTPER"] = SIDCGSTPER;
                newrow1["SIDSGSTPER"] = SIDSGSTPER;
                newrow1["SIDIGSTPER"] = SIDIGSTPER;
                dtTax1.Rows.Add(newrow1);
            }

            if (dtTax1.Rows.Count > 0)
            {
                TaxCodeGrid.DataSource = dtTax1;
                gridView3.BestFitColumns();
            }
            else
            {
                TaxCodeGrid.DataSource = null;
            }
        }
        private void HSNWiseSummary()
        {
            DataTable dtTax1 = new DataTable();

            dtTax1.Columns.Add("SIDSCANQTY", typeof(decimal));
            dtTax1.Columns.Add("SIDITMNETAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDSGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDCGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDIGSTAMT", typeof(decimal));
            dtTax1.Columns.Add("SIDCGSTPER", typeof(decimal));
            dtTax1.Columns.Add("SIDSGSTPER", typeof(decimal));
            dtTax1.Columns.Add("SIDIGSTPER", typeof(decimal));
            dtTax1.Columns.Add("GRPHSNCODE", typeof(string));


            var distinctRows = (from DataRow dRow in dt.Rows
                                select (Convert.ToDecimal(dRow["SIDCGSTPER"]) + Convert.ToDecimal(dRow["SIDSGSTPER"]) + Convert.ToDecimal(dRow["SIDIGSTPER"])).ToString("0.00") + dRow["GRPHSNCODE"]).Distinct();
            foreach (var v in distinctRows)

            {
                decimal SIDSCANQTY = 0;
                decimal SIDITMNETAMT = 0;
                decimal SIDSGSTAMT = 0;
                decimal SIDCGSTAMT = 0;
                decimal SIDIGSTAMT = 0;
                decimal SIDCGSTPER = 0;
                decimal SIDSGSTPER = 0;
                decimal SIDIGSTPER = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    if (((Convert.ToDecimal(dr["SIDCGSTPER"]) + Convert.ToDecimal(dr["SIDSGSTPER"]) + Convert.ToDecimal(dr["SIDIGSTPER"])).ToString("0.00") + dr["GRPHSNCODE"]) == v.ToString())
                    {
                        SIDSCANQTY = SIDSCANQTY + Convert.ToDecimal(dr["SIDSCANQTY"]);
                        SIDITMNETAMT = SIDITMNETAMT + Convert.ToDecimal(dr["SIDITMNETAMT"]);
                        SIDSGSTAMT = SIDSGSTAMT + Convert.ToDecimal(dr["SIDSGSTAMT"]);
                        SIDCGSTAMT = SIDCGSTAMT + Convert.ToDecimal(dr["SIDCGSTAMT"]);
                        SIDIGSTAMT = SIDIGSTAMT + Convert.ToDecimal(dr["SIDIGSTAMT"]);
                        SIDCGSTPER = Convert.ToDecimal(dr["SIDCGSTPER"]);
                        SIDSGSTPER = Convert.ToDecimal(dr["SIDSGSTPER"]);
                        SIDIGSTPER = Convert.ToDecimal(dr["SIDIGSTPER"]);
                    }
                }

                DataRow newrow1 = dtTax1.NewRow();
                newrow1["GRPHSNCODE"] = v.ToString();
                newrow1["SIDSCANQTY"] = SIDSCANQTY;
                newrow1["SIDITMNETAMT"] = SIDITMNETAMT;
                newrow1["SIDSGSTAMT"] = SIDSGSTAMT;
                newrow1["SIDCGSTAMT"] = SIDCGSTAMT;
                newrow1["SIDIGSTAMT"] = SIDIGSTAMT;
                newrow1["SIDCGSTPER"] = SIDCGSTPER;
                newrow1["SIDSGSTPER"] = SIDSGSTPER;
                newrow1["SIDIGSTPER"] = SIDIGSTPER;
                dtTax1.Rows.Add(newrow1);
            }

            if (dtTax1.Rows.Count > 0)
            {
                HSNGrid.DataSource = dtTax1;
                gridView3.BestFitColumns();
            }
            else
            {
                HSNGrid.DataSource = null;
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateDataForSaving()
        {

            if (InfoGrid.DataSource == null)
            {
                ProjectFunctions.SpeakError("Blank Bill Cannot Be Saved");
                txtDebitPartyCode.Focus();
                return false;

            }
            else
            {

            }

            if (txtDebitPartyCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Debit Party");
                txtDebitPartyCode.Focus();
                return false;
            }
            if (txtDebitPartyName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Debit Party");
                txtDebitPartyCode.Focus();
                return false;
            }

            if (txtDebitPartyName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Debit Party");
                txtDebitPartyCode.Focus();
                return false;
            }
            if (txtDebitNoteNo.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Debit Note No");
                txtDebitNoteNo.Focus();
                return false;
            }
            if (txtDEbitNoteDate.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Debit Note Date");
                txtDEbitNoteDate.Focus();
                return false;
            }
            if (txtDEbitNoteQty.Text.Trim().Length == 0)
            {
                txtDEbitNoteQty.Text = "0";
            }
            if (txtDebitNoteAmount.Text.Trim().Length == 0)
            {
                txtDebitNoteAmount.Text = "0";
            }
            if (txtbox.Text.Trim().Length == 0)
            {
                txtbox.Text = "0";
            }
            return true;
        }

        private void FrmInvoiceMstAdd_Load(object sender, EventArgs e)
        {
            SetMyControls();

            if (S1 == "&Add")
            {
                txtDebitPartyCode.Focus();
                txtserial.Text = string.Empty;

                dtInvoiceDate.EditValue = DateTime.Now;
            }
            if (S1 == "Edit")
            {

                DataSet ds = ProjectFunctions.GetDataSet("[sp_LoadCRMstFEDit] '" + ImDate.Date.ToString("yyyy-MM-dd") + "','" + ImNo + "','" + ImSeries + "','" + GlobalVariables.CUnitID + "','" + GlobalVariables.FinancialYear + "'");

                dtInvoiceDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["BillDate"]).ToString("yyyy-MM-dd");
                txtSerialNo.Text = ds.Tables[0].Rows[0]["BillNo"].ToString();
                txtserial.Text = ds.Tables[0].Rows[0]["BillSeries"].ToString();
                txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["SIMPartyC"].ToString();
                txtDebitPartyName.Text = ds.Tables[0].Rows[0]["DebitPartyName"].ToString();
                txtBillingAddress1.Text = ds.Tables[0].Rows[0]["DebitPartyAddress1"].ToString();
                txtBillingAddress2.Text = ds.Tables[0].Rows[0]["DebitPartyAddress2"].ToString();
                txtBillingAddress3.Text = ds.Tables[0].Rows[0]["DebitPartyAddress3"].ToString();
                txtBillingCity.Text = ds.Tables[0].Rows[0]["DebitPartyCity"].ToString();
                txtBillingState.Text = ds.Tables[0].Rows[0]["DebitStateName"].ToString();
                txtBillingZip.Text = ds.Tables[0].Rows[0]["DebitPartyZipCode"].ToString();

                FixPartyTag = ds.Tables[0].Rows[0]["AccFixBarCodeTag"].ToString();



                txtTransporterCode.Text = ds.Tables[0].Rows[0]["SIMTRANSPORTERID"].ToString();
                txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();
                txtGRNo.Text = ds.Tables[0].Rows[0]["SIMGRNRRNO"].ToString();
                if (ds.Tables[0].Rows[0]["SIMGRNRRDATE"].ToString().Trim().Length == 0)
                {


                }
                else
                {
                    txtGRDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["SIMGRNRRDATE"]);
                }

                txtGSTNo.Text = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();


                txtDebitNoteNo.Text = ds.Tables[0].Rows[0]["SIMDebitNoteNo"].ToString();
                txtDEbitNoteDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["SIMDebitNoteDate"]);
                txtDEbitNoteQty.Text = ds.Tables[0].Rows[0]["SIMDebitNoteQty"].ToString();
                txtDebitNoteAmount.Text = ds.Tables[0].Rows[0]["SIMDebitNoteAmount"].ToString();
                txtReason.Text = ds.Tables[0].Rows[0]["SIMReason"].ToString();
                txtOtherReason.Text = ds.Tables[0].Rows[0]["SIMOtherReason"].ToString();
                TXMAINREMARKS.Text = ds.Tables[0].Rows[0]["SIMRemarks"].ToString();
                txtbox.Text = ds.Tables[0].Rows[0]["SIMTOTBOXES"].ToString();


                dt = ds.Tables[1];
                InfoGrid.DataSource = dt;
                InfoGridView.BestFitColumns();
                txtDebitPartyCode.Focus();


                BtnRecalculate_Click(null, e);

                LoadDocs();


            }
        }



        private void LoadDocs()
        {
            DataSet dsDocs = ProjectFunctions.GetDataSet("Select * from ImagesData Where DocType='" + txtserial.Text + "' And DocNo='" + txtSerialNo.Text + "' And DocDate='" + Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd") + "'", ProjectFunctions.ImageConnectionString);
            if (dsDocs.Tables[0].Rows.Count > 0)
            {
                DocsGrid.DataSource = dsDocs.Tables[0];
                DocsGridView.BestFitColumns();
            }
            else
            {
                DocsGrid.DataSource = null;
                DocsGridView.BestFitColumns();
            }
        }

        [Obsolete]
        private void SaveInvoice()
        {
            if (ValidateDataForSaving())
            {
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {

                    var MaxRow = (InfoGrid.KeyboardFocusView as GridView).RowCount;

                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    sqlcom.Connection = sqlcon;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        if (S1 == "&Add")
                        {
                            string BillNo = string.Empty;

                            BillNo = ProjectFunctions.GetDataSet("select isnull(max(SIMNO),0)+1 from CRMAIN where SIMSERIES='RG' And SIMFNYR='" + GlobalVariables.FinancialYear + "'").Tables[0].Rows[0][0].ToString();
                            txtSerialNo.Text = BillNo;
                            txtserial.Text = "RG";

                            sqlcom.CommandText = "Insert into CRMAIN(SIMTOTBOXES,SIMSYSDATE,SIMFNYR,SIMDATE,SIMNO,SIMSERIES,SIMPartyC," +
                                "SIMTRANSPORTERID,SIMGRNRRNO,SIMGRNRRDATE," +
                                "SIMDISCPRCN,SIMDISCAMT,SIMINSURPRCN,SIMINSURANCEAMT, " +
                                "SIMFREIGHTAMT,SIMOCTORIAMT,SIMROFFAMT,SIMGRANDTOT,UnitCode ,SIMDebitNoteNo,SIMDebitNoteDate,SIMDebitNoteQty,SIMDebitNoteAmount,SIMReason,SIMOtherReason,SIMRemarks )values(" +
                                "@SIMTOTBOXES,@SIMSYSDATE,@SIMFNYR,@SIMDATE,@SIMNO,@SIMSERIES,@SIMPartyC" +
                                ",@SIMTRANSPORTERID,@SIMGRNRRNO,@SIMGRNRRDATE," +
                                "@SIMDISCPRCN,@SIMDISCAMT,@SIMINSURPRCN,@SIMINSURANCEAMT, " +
                                "@SIMFREIGHTAMT,@SIMOCTORIAMT,@SIMROFFAMT,@SIMGRANDTOT,@UnitCode ,@SIMDebitNoteNo,@SIMDebitNoteDate,@SIMDebitNoteQty,@SIMDebitNoteAmount,@SIMReason,@SIMOtherReason,@SIMRemarks )";
                            sqlcom.Parameters.Add("@SIMTOTBOXES", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtbox.Text);
                            sqlcom.Parameters.Add("@SIMSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            sqlcom.Parameters.Add("@SIMFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIMDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMNO", SqlDbType.NVarChar).Value = txtSerialNo.Text.Trim();
                            sqlcom.Parameters.Add("@SIMSERIES", SqlDbType.NVarChar).Value = txtserial.Text.Trim();
                            sqlcom.Parameters.Add("@SIMPartyC", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text.Trim();
                            sqlcom.Parameters.Add("@SIMTRANSPORTERID", SqlDbType.NVarChar).Value = txtTransporterCode.Text.Trim();
                            sqlcom.Parameters.Add("@SIMGRNRRNO", SqlDbType.NVarChar).Value = txtGRNo.Text;
                            if (txtGRDate.Text.Trim().Length == 0)
                            {
                                sqlcom.Parameters.Add("@SIMGRNRRDATE", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                            }
                            else
                            {
                                sqlcom.Parameters.Add("@SIMGRNRRDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtGRDate.Text).ToString("yyyy-MM-dd");

                            }
                            sqlcom.Parameters.Add("@SIMDISCTYPE", SqlDbType.NVarChar).Value = cmbTradeDisc.Text.Trim();
                            sqlcom.Parameters.Add("@SIMDISCPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtMainDisc.Text);
                            sqlcom.Parameters.Add("@SIMDISCAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtMainDiscVal.Text);
                            sqlcom.Parameters.Add("@SIMINSURPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtInsurancePer.Text);
                            sqlcom.Parameters.Add("@SIMINSURANCEAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtInsuranceAmount.Text);
                            sqlcom.Parameters.Add("@SIMFREIGHTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtPKGFrt.Text);
                            sqlcom.Parameters.Add("@SIMOCTORIAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtOctoriAmount.Text);
                            sqlcom.Parameters.Add("@SIMROFFAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOffAmount.Text);
                            sqlcom.Parameters.Add("@SIMGRANDTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRNetAmount.Text);
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@SIMDebitNoteNo", SqlDbType.NVarChar).Value = txtDebitNoteNo.Text;
                            sqlcom.Parameters.Add("@SIMDebitNoteDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDEbitNoteDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMDebitNoteQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtDEbitNoteQty.Text);
                            sqlcom.Parameters.Add("@SIMDebitNoteAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtDebitNoteAmount.Text);
                            sqlcom.Parameters.Add("@SIMReason", SqlDbType.NVarChar).Value = txtReason.Text.Trim();
                            sqlcom.Parameters.Add("@SIMOtherReason", SqlDbType.NVarChar).Value = txtOtherReason.Text.Trim();
                            sqlcom.Parameters.Add("@SIMRemarks", SqlDbType.NVarChar).Value = TXMAINREMARKS.Text.Trim();
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        if (S1 == "Edit")
                        {

                            sqlcom.CommandText = "Update CRMAIN Set SIMTOTBOXES=@SIMTOTBOXES,SIMSYSDATE=@SIMSYSDATE,SIMFNYR=@SIMFNYR,SIMDATE=@SIMDATE,SIMNO=@SIMNO,SIMSERIES=@SIMSERIES,SIMPartyC=@SIMPartyC," +
                                "SIMTRANSPORTERID=@SIMTRANSPORTERID,SIMGRNRRNO=@SIMGRNRRNO,SIMGRNRRDATE=@SIMGRNRRDATE," +

                                "SIMDISCPRCN=@SIMDISCPRCN,SIMDISCAMT=@SIMDISCAMT,SIMINSURPRCN=@SIMINSURPRCN,SIMINSURANCEAMT=@SIMINSURANCEAMT, " +
                                "SIMFREIGHTAMT=@SIMFREIGHTAMT,SIMOCTORIAMT=@SIMOCTORIAMT,SIMROFFAMT=@SIMROFFAMT,SIMGRANDTOT=@SIMGRANDTOT,UnitCode=@UnitCode,SIMDebitNoteNo=@SIMDebitNoteNo,SIMDebitNoteDate=@SIMDebitNoteDate,SIMDebitNoteQty=@SIMDebitNoteQty,SIMDebitNoteAmount=@SIMDebitNoteAmount,SIMReason=@SIMReason,SIMOtherReason=@SIMOtherReason, SIMRemarks=@SIMRemarks Where SIMDATE='" + Convert.ToDateTime(ImDate).ToString("yyyy-MM-dd") + "' And SIMNO='" + ImNo + "' And SIMSERIES='" + ImSeries + "' And UnitCode='" + GlobalVariables.CUnitID + "' And SIMFNYR='" + GlobalVariables.FinancialYear + "'";
                            sqlcom.Parameters.Add("@SIMTOTBOXES", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtbox.Text);

                            sqlcom.Parameters.Add("@SIMSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            sqlcom.Parameters.Add("@SIMFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIMDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMNO", SqlDbType.NVarChar).Value = txtSerialNo.Text.Trim();
                            sqlcom.Parameters.Add("@SIMSERIES", SqlDbType.NVarChar).Value = txtserial.Text.Trim();
                            sqlcom.Parameters.Add("@SIMPartyC", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text.Trim();
                            sqlcom.Parameters.Add("@SIMTRANSPORTERID", SqlDbType.NVarChar).Value = txtTransporterCode.Text.Trim();
                            sqlcom.Parameters.Add("@SIMGRNRRNO", SqlDbType.NVarChar).Value = txtGRNo.Text;
                            if (txtGRDate.Text.Trim().Length == 0)
                            {
                                sqlcom.Parameters.Add("@SIMGRNRRDATE", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;

                            }
                            else
                            {
                                sqlcom.Parameters.Add("@SIMGRNRRDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtGRDate.Text).ToString("yyyy-MM-dd");

                            }






                            sqlcom.Parameters.Add("@SIMDISCTYPE", SqlDbType.NVarChar).Value = cmbTradeDisc.Text.Trim();
                            sqlcom.Parameters.Add("@SIMDISCPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtMainDisc.Text);
                            sqlcom.Parameters.Add("@SIMDISCAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtMainDiscVal.Text);
                            sqlcom.Parameters.Add("@SIMINSURPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtInsurancePer.Text);
                            sqlcom.Parameters.Add("@SIMINSURANCEAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtInsuranceAmount.Text);
                            sqlcom.Parameters.Add("@SIMFREIGHTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtPKGFrt.Text);
                            sqlcom.Parameters.Add("@SIMOCTORIAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtOctoriAmount.Text);
                            sqlcom.Parameters.Add("@SIMROFFAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOffAmount.Text);
                            sqlcom.Parameters.Add("@SIMGRANDTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRNetAmount.Text);

                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@SIMDebitNoteNo", SqlDbType.NVarChar).Value = txtDebitNoteNo.Text;
                            sqlcom.Parameters.Add("@SIMDebitNoteDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDEbitNoteDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMDebitNoteQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtDEbitNoteQty.Text);
                            sqlcom.Parameters.Add("@SIMDebitNoteAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtDebitNoteAmount.Text);
                            sqlcom.Parameters.Add("@SIMReason", SqlDbType.NVarChar).Value = txtReason.Text.Trim();
                            sqlcom.Parameters.Add("@SIMOtherReason", SqlDbType.NVarChar).Value = txtOtherReason.Text.Trim();
                            sqlcom.Parameters.Add("@SIMRemarks", SqlDbType.NVarChar).Value = TXMAINREMARKS.Text.Trim();
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = " update SFDet Set Used='Y' Where UnitCode='" + GlobalVariables.CUnitID + "' And SFDBARCODE in   (Select SIDBARCODE from CRDET Where SIDSERIES=@SIDSERIES And SIDNO=@SIDNO And SIDDATE=@SIDDATE  And SIDFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "')";
                            sqlcom.Parameters.Add("@SIDSERIES", SqlDbType.NVarChar).Value = txtserial.Text.Trim();
                            sqlcom.Parameters.Add("@SIDNO", SqlDbType.NVarChar).Value = txtSerialNo.Text.Trim();
                            sqlcom.Parameters.Add("@SIDDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();



                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = "Delete from CRDET Where SIDSERIES=@SIDSERIES And SIDNO=@SIDNO And SIDDATE=@SIDDATE  And SIDFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "'";
                            sqlcom.Parameters.Add("@SIDSERIES", SqlDbType.NVarChar).Value = txtserial.Text.Trim();
                            sqlcom.Parameters.Add("@SIDNO", SqlDbType.NVarChar).Value = txtSerialNo.Text.Trim();
                            sqlcom.Parameters.Add("@SIDDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();




                        }


                        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                        int j = 0;
                        for (var i = 0; i < MaxRow; i++)
                        {
                            j++;

                            SplashScreenManager.Default.SetWaitFormDescription("Saving Item " + j.ToString() + " / " + MaxRow.ToString());

                            sqlcom.CommandType = CommandType.Text;
                            var currentrow = InfoGridView.GetDataRow(i);
                            sqlcom.CommandText = " Insert into CRDET "
                                                        + " (SIDSYSDATE,SIDFNYR,SIDDATE,SIDNO,SIDSERIES,SIDPartyC,"
                                                        + " SIDPSNO,SIDBOXNO,SIDBARCODE,SIDARTNO,SIDARTID,SIDCOLID,"
                                                        + " SIDSIZID,SIDSCANQTY,SIDARTMRP,SIDARTWSP,SIDBOXQTY,SIDBOXMRPVAL,SIDBOXWSPVAL,SIDITMDISCPRCN,"
                                                        + "SIDITMDISCAMT,SIDITMNETAMT,SIDSGSTPRCN,SIDSGSTAMT,SIDCGSTPRCN,SIDCGSTAMT,SIDIGSTPRCN,SIDIGSTAMT,TAXCODE,UnitCode ,BillNo,BillDate )"
                                                        + " values(@SIDSYSDATE,@SIDFNYR,@SIDDATE,@SIDNO,@SIDSERIES,@SIDPartyC,"
                                                        + " @SIDPSNO,@SIDBOXNO,@SIDBARCODE,@SIDARTNO,@SIDARTID,@SIDCOLID,"
                                                        + " @SIDSIZID,@SIDSCANQTY,@SIDARTMRP,@SIDARTWSP,@SIDBOXQTY,@SIDBOXMRPVAL,@SIDBOXWSPVAL,@SIDITMDISCPRCN,@SIDITMDISCAMT,"
                                                        + " @SIDITMNETAMT,@SIDSGSTPRCN,@SIDSGSTAMT,@SIDCGSTPRCN,@SIDCGSTAMT,@SIDIGSTPRCN,@SIDIGSTAMT,@TAXCODE,@UnitCode,@BillNo,@BillDate)";
                            sqlcom.Parameters.Add("@SIDSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            sqlcom.Parameters.Add("@SIDFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIDDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIDNO", SqlDbType.NVarChar).Value = txtSerialNo.Text;
                            sqlcom.Parameters.Add("@SIDSERIES", SqlDbType.NVarChar).Value = txtserial.Text.Trim();
                            sqlcom.Parameters.Add("@SIDPartyC", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text.Trim();
                            sqlcom.Parameters.Add("@SIDPSNO", SqlDbType.NVarChar).Value = currentrow["SIDPSNO"].ToString();
                            sqlcom.Parameters.Add("@SIDBOXNO", SqlDbType.NVarChar).Value = "0";
                            sqlcom.Parameters.Add("@SIDBARCODE", SqlDbType.NVarChar).Value = currentrow["SIDBARCODE"].ToString();
                            sqlcom.Parameters.Add("@SIDARTNO", SqlDbType.NVarChar).Value = currentrow["SIDARTNO"].ToString();
                            sqlcom.Parameters.Add("@SIDARTID", SqlDbType.NVarChar).Value = currentrow["SIDARTID"].ToString();
                            sqlcom.Parameters.Add("@SIDCOLID", SqlDbType.NVarChar).Value = currentrow["SIDCOLID"].ToString();
                            sqlcom.Parameters.Add("@SIDSIZID", SqlDbType.NVarChar).Value = currentrow["SIDSIZID"].ToString();
                            sqlcom.Parameters.Add("@SIDSCANQTY", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDSCANQTY"]);
                            sqlcom.Parameters.Add("@SIDARTMRP", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDARTMRP"]);
                            sqlcom.Parameters.Add("@SIDARTWSP", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDARTWSP"]);
                            sqlcom.Parameters.Add("@SIDBOXQTY", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDBOXQTY"]);
                            sqlcom.Parameters.Add("@SIDBOXMRPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDBOXMRPVAL"]);
                            sqlcom.Parameters.Add("@SIDBOXWSPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDBOXWSPVAL"]);
                            sqlcom.Parameters.Add("@SIDITMDISCPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDITMDISCPRCN"]);
                            sqlcom.Parameters.Add("@SIDITMDISCAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDITMDISCAMT"]);
                            sqlcom.Parameters.Add("@SIDITMNETAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDITMNETAMT"]);
                            sqlcom.Parameters.Add("@SIDSGSTPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDSGSTPER"]);
                            sqlcom.Parameters.Add("@SIDSGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDSGSTAMT"]);
                            sqlcom.Parameters.Add("@SIDCGSTPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDCGSTPER"]);
                            sqlcom.Parameters.Add("@SIDCGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDCGSTAMT"]);
                            sqlcom.Parameters.Add("@SIDIGSTPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDIGSTPER"]);
                            sqlcom.Parameters.Add("@SIDIGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SIDIGSTAMT"]);
                            sqlcom.Parameters.Add("@TAXCODE", SqlDbType.NVarChar).Value = currentrow["TAXCODE"].ToString();
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@BillNo", SqlDbType.NVarChar).Value = currentrow["BillNo"].ToString();
                            sqlcom.Parameters.Add("@BillDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(currentrow["BillDate"]).ToString("yyyy-MM-dd");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();




                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = " update SFDet Set Used='N' Where UnitCode='" + GlobalVariables.CUnitID + "' And SFDBARCODE='" + currentrow["SIDBARCODE"].ToString() + "'";
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                        }


                        ProjectFunctions.GetDataSet(" [SP_SRVPosting] '" + txtSerialNo.Text + "','" + Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd") + "','RG','" + GlobalVariables.CUnitID + "' ");

                        SplashScreenManager.CloseForm();
                        ProjectFunctions.SpeakError("Credit Note Saved Successfully");
                        sqlcon.Close();

                        Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
        }





        private void BtnSave_Click(object sender, EventArgs e)
        {

            SaveInvoice();
        }



        private void FrmInvoiceMstAdd_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.SalePopUPForAllWindows(this, e);
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void TxtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDebitPartyName.Text = string.Empty;
            txtBillingAddress1.Text = string.Empty;
            txtBillingAddress2.Text = string.Empty;
            txtBillingAddress3.Text = string.Empty;
            txtBillingState.Text = string.Empty;
            txtBillingCity.Text = string.Empty;
            txtBillingZip.Text = string.Empty;


            txtGSTNo.Text = string.Empty;
        }



        private void PrepareActMstHelpGrid()
        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccName",
                Visible = true,
                VisibleIndex = 0
            };
            HelpGridView.Columns.Add(col1);

            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccCode",
                Visible = true,
                VisibleIndex = 1
            };
            HelpGridView.Columns.Add(col2);

            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccAddress1",
                Visible = false
            };
            //col3.VisibleIndex = 2;
            HelpGridView.Columns.Add(col3);

            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccAddress2",
                Visible = false
            };
            //col4.VisibleIndex = 3;
            HelpGridView.Columns.Add(col4);

            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccAddress3",
                Visible = false
            };
            //col5.VisibleIndex = 4;
            HelpGridView.Columns.Add(col5);


            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "CTNAME",
                Visible = true
            };
            //col6.VisibleIndex = 5;
            HelpGridView.Columns.Add(col6);

        }

        private void TxtDebitPartyCode_KeyDown(object sender, KeyEventArgs e)
        {




            if (e.KeyCode == Keys.Enter)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtDebitPartyCode";
                if (txtDebitPartyCode.Text.Trim().Length == 0)
                {
                    PrepareActMstHelpGrid();
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
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
                    DataSet ds = ProjectFunctions.GetDataSet(" sp_LoadActMstHelpWithCode '" + txtDebitPartyCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["AccCode"].ToString();
                        txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                        txtBillingAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                        txtBillingAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                        txtBillingAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                        txtBillingState.Text = ds.Tables[0].Rows[0]["STNAME"].ToString();
                        txtBillingCity.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                        txtBillingZip.Text = ds.Tables[0].Rows[0]["AccZipCode"].ToString();


                        txtGSTNo.Text = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
                        AccMRPMarkDown = Convert.ToDecimal(ds.Tables[0].Rows[0]["AccMrpMarkDown"]);
                        StkTransfer = ds.Tables[0].Rows[0]["AccStkTrf"].ToString();

                        FixPartyTag = ds.Tables[0].Rows[0]["AccFixBarCodeTag"].ToString();
                    }

                    else
                    {
                        PrepareActMstHelpGrid();
                        DataSet ds1 = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
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
            HelpGridView.CloseEditor();
            HelpGridView.UpdateCurrentRow();
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "Load")
            {
                foreach (DataRow dr in (HelpGrid.DataSource as DataTable).Rows)
                {
                    if (dr["Select"].ToString().ToUpper() == "TRUE")
                    {

                        DataSet ds = ProjectFunctions.GetDataSet("sp_LoadBarCOdeForCreditNote '" + dr["SIDBARCODE"].ToString() + "','" + txtDebitPartyCode.Text + "','01'");
                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            if (dt.Rows.Count == 0)
                            {
                                dt = ds.Tables[0];
                            }
                            else
                            {
                                foreach (DataRow drRows in dt.Rows)
                                {
                                    if (ds.Tables[0].Rows[0]["SIDBARCODE"].ToString() == drRows["SIDBARCODE"].ToString())
                                    {
                                        ProjectFunctions.SpeakError("This BarCode Already Loaded In This Document");
                                        txtBarCode.SelectAll();
                                        txtBarCode.Focus();
                                        return;
                                    }
                                }
                                dt.Merge(ds.Tables[0]);
                            }
                        }

                    }
                }
                if (dt.Rows.Count > 0)
                {
                    InfoGrid.DataSource = dt;
                    InfoGridView.BestFitColumns();
                }
                else
                {
                    InfoGrid.DataSource = null;
                }
                HelpGrid.Visible = false;
                Calculation();
            }
            if (HelpGrid.Text == "txtTransporterCode")
            {
                txtTransporterCode.Text = row["TRPRSYSID"].ToString();
                txtTransporterName.Text = row["TRPRNAME"].ToString();
                HelpGrid.Visible = false;
                txtGRNo.Focus();

            }

            if (HelpGrid.Text == "txtDebitPartyCode")
            {
                txtDebitPartyCode.Text = row["AccCode"].ToString();
                txtDebitPartyName.Text = row["AccName"].ToString();
                txtBillingAddress1.Text = row["AccAddress1"].ToString();
                txtBillingAddress2.Text = row["AccAddress2"].ToString();
                txtBillingAddress3.Text = row["AccAddress3"].ToString();
                txtBillingState.Text = row["STNAME"].ToString();
                txtBillingCity.Text = row["CTNAME"].ToString();
                txtBillingZip.Text = row["AccZipCode"].ToString();


                txtGSTNo.Text = row["AccGSTNo"].ToString();


                AccMRPMarkDown = Convert.ToDecimal(row["AccMrpMarkDown"]);

                StkTransfer = row["AccStkTrf"].ToString();
                FixPartyTag = row["AccFixBarCodeTag"].ToString();


                HelpGrid.Visible = false;
                txtDebitNoteNo.Focus();
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
                if (HelpGrid.Text == "txtTransporterCode")
                {
                    txtTransporterCode.Focus();
                }
                if (HelpGrid.Text == "txtDebitPartyCode")
                {

                    txtDebitPartyCode.Focus();
                }

                if (HelpGrid.Text == "Load")
                {
                    txtBarCode.Focus();
                }
            }
        }

        private void TxtTransporterCode_EditValueChanged(object sender, EventArgs e)
        {
            txtTransporterName.Text = string.Empty;
        }

        private void TxtTransporterCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtTransporterCode";
                if (txtTransporterCode.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("select TRPRNAME,TRPRSYSID,TRPRADD from TRANSPORTMASTER");
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
                    DataSet ds = ProjectFunctions.GetDataSet(" select TRPRNAME,TRPRSYSID,TRPRADD from TRANSPORTMASTER Where TRPRSYSID= '" + txtTransporterCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtTransporterCode.Text = ds.Tables[0].Rows[0]["TRPRSYSID"].ToString();
                        txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();
                        txtGRNo.Focus();
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("select TRPRNAME,TRPRSYSID,TRPRADD from TRANSPORTMASTER");
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

        private void BtnRecalculate_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)

        {
            try
            {
                if (e.KeyCode == Keys.F3)
                {
                    HelpGridView.Columns.Clear();
                    HelpGrid.Text = "Load";
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadF3DataFReturn '" + GlobalVariables.CUnitID + "','" + txtDebitPartyCode.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Tables[0].Columns.Add("Select", typeof(bool));
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dr["Select"] = false;
                        }
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Show();
                        HelpGrid.Focus();
                        HelpGridView.BestFitColumns();

                        HelpGridView.OptionsBehavior.Editable = true;
                        foreach (DevExpress.XtraGrid.Columns.GridColumn col in HelpGridView.Columns)
                        {
                            if (col.FieldName == "Select")
                            {
                                col.VisibleIndex = 0;
                                col.OptionsColumn.AllowEdit = true;
                            }
                            else
                            {
                                col.OptionsColumn.AllowEdit = false;
                            }
                        }
                    }

                }



                if (e.KeyCode == Keys.Enter)
                {

                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadBarCOdeForCreditNote '" + txtBarCode.Text + "','" + txtDebitPartyCode.Text + "','01'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        if (dt.Rows.Count == 0)
                        {
                            dt = ds.Tables[0];
                        }
                        else
                        {
                            if (FixPartyTag != "Y")
                            {
                                foreach (DataRow drRows in dt.Rows)
                                {
                                    if (ds.Tables[0].Rows[0]["SIDBARCODE"].ToString() == drRows["SIDBARCODE"].ToString())
                                    {
                                        ProjectFunctions.SpeakError("This BarCode Already Loaded In This Document");
                                        txtBarCode.SelectAll();
                                        txtBarCode.Focus();
                                        e.Handled = true;
                                        return;
                                    }

                                }
                                dt.Merge(ds.Tables[0]);
                            }
                            else
                            {
                                int i = 0;
                                foreach (DataRow drRows in dt.Rows)
                                {
                                    if (drRows["SIDBARCODE"].ToString().ToUpper() == ds.Tables[0].Rows[0]["SIDBARCODE"].ToString())
                                    {
                                        drRows["SIDSCANQTY"] = Convert.ToDecimal(drRows["SIDSCANQTY"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDSCANQTY"]);
                                        drRows["SIDITMDISCAMT"] = Convert.ToDecimal(drRows["SIDITMDISCAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDITMDISCAMT"]);
                                        drRows["SIDITMNETAMT"] = Convert.ToDecimal(drRows["SIDITMNETAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDITMNETAMT"]);
                                        drRows["SIDSGSTAMT"] = Convert.ToDecimal(drRows["SIDSGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDSGSTAMT"]);
                                        drRows["SIDCGSTAMT"] = Convert.ToDecimal(drRows["SIDCGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDCGSTAMT"]);
                                        drRows["SIDIGSTAMT"] = Convert.ToDecimal(drRows["SIDIGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDIGSTAMT"]);
                                        i++;
                                    }
                                }
                                if (i == 0)
                                {
                                    dt.Merge(ds.Tables[0]);
                                }
                            }

                        }
                    }
                    else


                    {
                        if (ds.Tables.Count > 2)
                        {
                            if (ds.Tables[2].Rows.Count > 0)
                            {
                                if (FixPartyTag != "Y")
                                {
                                    ProjectFunctions.SpeakError("Return Has Already Been Taken Against This BarCode");
                                    txtBarCode.SelectAll();
                                    txtBarCode.Focus();
                                    e.Handled = true;
                                    return;
                                }
                                else
                                {
                                    int i = 0;
                                    foreach (DataRow drRows in dt.Rows)
                                    {
                                        if (drRows["SIDBARCODE"].ToString().ToUpper() == ds.Tables[0].Rows[0]["SIDBARCODE"].ToString())
                                        {
                                            drRows["SIDSCANQTY"] = Convert.ToDecimal(drRows["SIDSCANQTY"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDSCANQTY"]);
                                            drRows["SIDITMDISCAMT"] = Convert.ToDecimal(drRows["SIDITMDISCAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDITMDISCAMT"]);
                                            drRows["SIDITMNETAMT"] = Convert.ToDecimal(drRows["SIDITMNETAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDITMNETAMT"]);
                                            drRows["SIDSGSTAMT"] = Convert.ToDecimal(drRows["SIDSGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDSGSTAMT"]);
                                            drRows["SIDCGSTAMT"] = Convert.ToDecimal(drRows["SIDCGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDCGSTAMT"]);
                                            drRows["SIDIGSTAMT"] = Convert.ToDecimal(drRows["SIDIGSTAMT"]) + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIDIGSTAMT"]);
                                            i++;
                                        }
                                    }
                                    if (i == 0)
                                    {
                                        dt.Merge(ds.Tables[0]);
                                    }
                                }
                            }
                        }

                        else
                        {


                            if (chMultiParty.Checked)
                            {
                                if (chMultiParty.Checked && ProjectFunctions.GetDataSet("SELECT AccLCTag FROM ACTMST WHERE AccCode='" + ds.Tables[1].Rows[0]["SIDPARTYC"].ToString() + "'").Tables[0].Rows[0][0].ToString() == ProjectFunctions.GetDataSet("SELECT AccLCTag FROM ACTMST WHERE AccCode='" + txtDebitPartyCode.Text + "'").Tables[0].Rows[0][0].ToString())
                                {
                                    dt.Merge(ds.Tables[1]);
                                }
                                else
                                {
                                    if ((Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDSGSTAMT"]) + Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDCGSTAMT"])) > 0)
                                    {
                                        ds.Tables[1].Rows[0]["SIDIGSTAMT"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDSGSTAMT"]) + Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDCGSTAMT"]);
                                        ds.Tables[1].Rows[0]["SIDSGSTAMT"] = 0;
                                        ds.Tables[1].Rows[0]["SIDCGSTAMT"] = 0;


                                        ds.Tables[1].Rows[0]["SIDIGSTPER"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDCGSTPER"]) + Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDSGSTPER"]);
                                        ds.Tables[1].Rows[0]["SIDCGSTPER"] = 0;
                                        ds.Tables[1].Rows[0]["SIDSGSTPER"] = 0;

                                        ds.Tables[1].Rows[0]["TAXCODE"] = "0002";



                                        dt.Merge(ds.Tables[1]);
                                    }
                                    else
                                    {
                                        ds.Tables[1].Rows[0]["SIDCGSTAMT"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDIGSTAMT"]) / 2;
                                        ds.Tables[1].Rows[0]["SIDSGSTAMT"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDIGSTAMT"]) / 2;
                                        ds.Tables[1].Rows[0]["SIDIGSTAMT"] = 0;


                                        ds.Tables[1].Rows[0]["SIDCGSTPER"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDIGSTPER"]) / 2;
                                        ds.Tables[1].Rows[0]["SIDSGSTPER"] = Convert.ToDecimal(ds.Tables[1].Rows[0]["SIDIGSTPER"]) / 2;
                                        ds.Tables[1].Rows[0]["SIDIGSTPER"] = 0;
                                        ds.Tables[1].Rows[0]["TAXCODE"] = "0001";

                                        dt.Merge(ds.Tables[1]);
                                    }
                                }
                            }
                            else
                            {

                                if (ds.Tables[1].Rows.Count > 0)
                                {
                                    ProjectFunctions.SpeakError("This BarCode Belongs To Party -" + ds.Tables[1].Rows[0]["AccName"].ToString());
                                    txtBarCode.SelectAll();
                                    txtBarCode.Focus();
                                    e.Handled = true;
                                    return;
                                }
                                else
                                {
                                    ProjectFunctions.SpeakError("NO Sale Made Against This BarCode");
                                    txtBarCode.SelectAll();
                                    txtBarCode.Focus();
                                    e.Handled = true;
                                    return;
                                }
                            }
                        }


                    }
                    if (dt.Rows.Count > 0)
                    {
                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                        Calculation();
                    }
                    else
                    {
                        InfoGrid.DataSource = null;
                        InfoGridView.BestFitColumns();
                        Calculation();
                    }
                    txtBarCode.Text = string.Empty;
                    txtBarCode.Focus();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
            e.Handled = true;
        }

        private void TxtReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtReason.SelectedItem.ToString().ToUpper() == "OTHERS")
            {
                txtOtherReason.Visible = true;
                txtOtherReason.Focus();
            }
            else
            {
                txtOtherReason.Visible = false;
            }
        }

        private void InfoGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete Current Record", (o1, e1) =>
                {
                    ProjectFunctions.DeleteCurrentRowOnRightClick(InfoGrid, InfoGridView);
                    dt.AcceptChanges();
                    Calculation();
                }));
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        private void TxtRound2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculation();
            }
        }

        private void TxtBarCode_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void CaptureScreen()
        {
            try
            {

                MemoryStream ms = new MemoryStream();
                pictureEdit1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);

                using (var sqlcon = new SqlConnection(ProjectFunctions.ImageConnectionString))
                {
                    sqlcon.Open();
                    string str = string.Empty;

                    str = "insert into ImagesData(DocType,DocNo,DocDate,DocImage) values(@DocType,@DocNo,@DocDate,@DocImage)";
                    var sqlcom = new SqlCommand(str, sqlcon);
                    sqlcom.Parameters.AddWithValue("@DocType", txtserial.Text);
                    sqlcom.Parameters.AddWithValue("@DocNo", txtSerialNo.Text);
                    sqlcom.Parameters.AddWithValue("@DocDate", Convert.ToDateTime(dtInvoiceDate.Text).ToString("yyyy-MM-dd"));
                    sqlcom.Parameters.AddWithValue("@DocImage", photo);
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();
                    XtraMessageBox.Show("Document Saved Successfully");
                    LoadDocs();


                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        private void DocsGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow currentrow = DocsGridView.GetDataRow(DocsGridView.FocusedRowHandle);
            DataSet ds = ProjectFunctions.GetDataSet("Select * from ImagesData Where Transid='" + Convert.ToInt64(currentrow["Transid"]) + "'", ProjectFunctions.ImageConnectionString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                _ = new byte[0];
                byte[] MyData = (byte[])ds.Tables[0].Rows[0]["DocImage"];
                MemoryStream stream = new MemoryStream(MyData)
                {
                    Position = 0
                };
                pictureEdit1.Image = Image.FromStream(stream);
                pictureEdit1.Image.Save("C:\\Temp\\A.jpg");
                WindowsFormsApplication1.Transaction.challans.XtraReport1 rpt = new Transaction.challans.XtraReport1();
                rpt.xrPictureBox1.ImageUrl = "C:\\Temp\\A.jpg";
                using (var pt = new ReportPrintTool(rpt))
                {
                    pt.ShowRibbonPreviewDialog();
                }
            }
        }

        private void PictureEdit1_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            try
            {
                e.PopupMenu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Save Current Document", (o1, e1) =>
                {
                    CaptureScreen();
                }));

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void DocsGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete Current Record", (o1, e1) =>
                {
                    DataRow currentrow = DocsGridView.GetDataRow(DocsGridView.FocusedRowHandle);

                    ProjectFunctions.GetDataSet("Delete from ImagesData Where Transid='" + Convert.ToInt64(currentrow["Transid"]) + "'", ProjectFunctions.ImageConnectionString);
                    LoadDocs();
                }));

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtDebitNoteNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                this.txtDEbitNoteDate.Focus();
        }

        private void HelpGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //HelpGrid.MainView = View1;
            //View.GridControl = HelpGrid;
            //View1.Name = "HelpGridView";
            //View1.OptionsBehavior.Editable = false;
        }

        private void TxtPKGFrt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculation();
            }
        }
    }
}