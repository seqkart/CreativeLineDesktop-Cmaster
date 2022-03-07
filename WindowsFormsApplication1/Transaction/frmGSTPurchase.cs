using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmGSTPurchase : DevExpress.XtraEditors.XtraForm
    {
        DataSet dsPopUps = new DataSet();
        int RowIndex = 0;
        string UpdateTag = "N";
        public string S1 { get; set; }
        DataTable dt = new DataTable();

        public string ImNo { get; set; }
        public DateTime ImDate { get; set; }
        public string ImSeries { get; set; }

        public FrmGSTPurchase()
        {
            InitializeComponent();
            dt.Columns.Add("SIDPRDCODE", typeof(string));
            dt.Columns.Add("SIDPRDNAME", typeof(string));
            dt.Columns.Add("SIDARTNO", typeof(string));
            dt.Columns.Add("SIDARTDESC", typeof(string));
            dt.Columns.Add("SIDCOLN", typeof(string));
            dt.Columns.Add("SIDSIZN", typeof(string));
            dt.Columns.Add("SIDITMRATE", typeof(decimal));
            dt.Columns.Add("SIDITMDISCPRCN", typeof(decimal));
            dt.Columns.Add("SIDITMDISCAMT", typeof(decimal));
            dt.Columns.Add("SIDITMNETAMT", typeof(decimal));
            dt.Columns.Add("SIDARTID", typeof(string));
            dt.Columns.Add("SIDCOLID", typeof(string));
            dt.Columns.Add("SIDSIZID", typeof(string));
            dt.Columns.Add("SIDQTY", typeof(string));
            dt.Columns.Add("SIDSGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDCGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDIGSTAMT", typeof(decimal));
            dt.Columns.Add("SIDCGSTPER", typeof(decimal));
            dt.Columns.Add("SIDSGSTPER", typeof(decimal));
            dt.Columns.Add("SIDIGSTPER", typeof(decimal));
            dt.Columns.Add("TAXCODE", typeof(string));
            dt.Columns.Add("GRPHSNCODE", typeof(string));

            dsPopUps = ProjectFunctions.GetDataSet("sp_LoadBarPrintPopUps");
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

                SumValueOfGoods += Convert.ToDecimal(dr["SIDITMNETAMT"]);
                SumDiscAmount += Convert.ToDecimal(dr["SIDITMDISCAMT"]);
                SumCGSTAmount += Convert.ToDecimal(dr["SIDCGSTAMT"]);
                SumSGSTAmount += Convert.ToDecimal(dr["SIDSGSTAMT"]);
                SumIGSTAmount += Convert.ToDecimal(dr["SIDIGSTAMT"]);

            }

            txtTotalTaxAmount.Text = (SumCGSTAmount + SumSGSTAmount + SumIGSTAmount).ToString("0.00");
            txtValueOfGoods.Text = SumValueOfGoods.ToString("0.00");
            decimal NetAmount = 0;
            NetAmount = (SumValueOfGoods + SumCGSTAmount + SumSGSTAmount + SumIGSTAmount);
            txtRNetAmount.Text = Math.Round(NetAmount, 0).ToString("0.00");
            txtRoundOffAmount.Text = (Convert.ToDecimal(txtRNetAmount.Text) - NetAmount).ToString("0.00");
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



        private void TxtDebitPartyCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                PrepareActMstHelpGrid();
                HelpGrid.Text = "txtDebitPartyCode";
                if (txtDebitPartyCode.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Show();
                        panelControl1.Visible = true;
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

                        txtBillingCity.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                        txtTransporterCode.Focus();
                        panelControl1.Visible = false;
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds.Tables[0];
                            HelpGrid.Show();
                            panelControl1.Visible = true;
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

            if (HelpGrid.Text == "txtTransporterCode")
            {
                txtTransporterCode.Text = row["TRPRSYSID"].ToString();
                txtTransporterName.Text = row["TRPRNAME"].ToString();
                HelpGrid.Visible = false;
                panelControl1.Visible = false;
                txtTransporterCode.Focus();
            }

            if (HelpGrid.Text == "txtDebitPartyCode")
            {
                txtDebitPartyCode.Text = row["AccCode"].ToString();
                txtDebitPartyName.Text = row["AccName"].ToString();
                txtBillingAddress1.Text = row["AccAddress1"].ToString();
                txtBillingAddress2.Text = row["AccAddress2"].ToString();
                txtBillingAddress3.Text = row["AccAddress3"].ToString();

                txtBillingCity.Text = row["CTNAME"].ToString();

                HelpGrid.Visible = false;
                panelControl1.Visible = false;
                txtTransporterCode.Focus();
            }
            if (HelpGridView.RowCount > 0)
            {

                if (HelpGrid.Text == "SIDPRDNAME")
                {
                    DataRow dtNewRow = dt.NewRow();
                    dtNewRow["SIDPRDCODE"] = row["PrdCode"].ToString();
                    dtNewRow["SIDPRDNAME"] = row["PrdName"].ToString();
                    dtNewRow["SIDITMDISCPRCN"] = Convert.ToDecimal("0");
                    dtNewRow["SIDITMDISCAMT"] = Convert.ToDecimal("0");
                    dtNewRow["SIDITMRATE"] = Convert.ToDecimal("0");
                    dtNewRow["SIDITMNETAMT"] = Convert.ToDecimal("0");
                    dtNewRow["SIDQTY"] = Convert.ToDecimal("0");
                    dtNewRow["SIDSGSTAMT"] = Convert.ToDecimal("0");
                    dtNewRow["SIDCGSTAMT"] = Convert.ToDecimal("0");
                    dtNewRow["SIDIGSTAMT"] = Convert.ToDecimal("0");
                    dtNewRow["SIDCGSTPER"] = Convert.ToDecimal("0");
                    dtNewRow["SIDSGSTPER"] = Convert.ToDecimal("0");
                    dtNewRow["SIDIGSTPER"] = Convert.ToDecimal("0");

                    dt.Rows.Add(dtNewRow);
                    if (dt.Rows.Count > 0)
                    {
                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                    }
                    panelControl1.Visible = false;
                    InfoGridView.Focus();
                    InfoGridView.MoveLast();
                    InfoGridView.FocusedColumn = InfoGridView.Columns["SIDARTNO"];
                    txtSearchBox.Text = string.Empty;
                    Calculation();
                }
                if (HelpGrid.Text == "SIDARTNO")
                {
                    //DataRow dtNewRow = dt.NewRow();
                    //dtNewRow["SIDARTNO"] = row["ARTNO"].ToString();
                    //dtNewRow["SIDARTDESC"] = row["ARTDESC"].ToString();
                    //dtNewRow["SIDARTID"] = row["ARTSYSID"].ToString();
                    //dtNewRow["SIDITMDISCPRCN"] = Convert.ToDecimal("0");
                    //dtNewRow["SIDITMDISCAMT"] = Convert.ToDecimal("0");
                    //dtNewRow["SIDITMRATE"] = Convert.ToDecimal("0");

                    //dt.Rows.Add(dtNewRow);
                    //if (dt.Rows.Count > 0)
                    //{
                    //    InfoGrid.DataSource = dt;
                    //    InfoGridView.BestFitColumns();
                    //}
                    //panelControl1.Visible = false;
                    //InfoGridView.Focus();
                    //InfoGridView.MoveLast();
                    //InfoGridView.FocusedColumn = InfoGridView.Columns["SIDCOLN"];
                    //txtSearchBox.Text = String.Empty;



                    InfoGridView.UpdateCurrentRow();
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDARTNO"], row["ARTNO"].ToString());
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDARTDESC"], row["ARTDESC"].ToString());
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDARTID"], row["ARTSYSID"].ToString());


                    InfoGridView.Focus();
                    panelControl1.Visible = false;
                    InfoGridView.FocusedColumn = InfoGridView.Columns["SIDCOLN"];
                    InfoGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                    dt.AcceptChanges();
                }



                if (HelpGrid.Text == "SIDCOLN")
                {

                    InfoGridView.UpdateCurrentRow();

                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDCOLID"], row["COLSYSID"].ToString());
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDCOLN"], row["COLNAME"].ToString());
                    InfoGridView.Focus();
                    panelControl1.Visible = false;
                    InfoGridView.FocusedColumn = InfoGridView.Columns["SIDSIZN"];
                    InfoGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                    dt.AcceptChanges();
                }
                if (HelpGrid.Text == "SIDSIZN")
                {

                    UpdateTag = "N";
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDSIZID"], row["SZSYSID"].ToString());
                    InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SIDSIZN"], row["SZNAME"].ToString());
                    panelControl1.Visible = false;
                    InfoGridView.Focus();
                    InfoGridView.FocusedColumn = InfoGridView.Columns["SIDQTY"];
                    InfoGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                    dt.AcceptChanges();
                    InfoGridView.ShowEditor();
                }
            }
        }





        private bool ValidateDataForSaving()
        {
            try

            {
                if (InfoGridView.DataSource == null)
                {
                    ProjectFunctions.SpeakError("No Data To Save");
                }

                return true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
                return false;
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
                    DataSet ds = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Show();
                        panelControl1.Visible = true;
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
                    DataSet ds = ProjectFunctions.GetDataSet(" select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER Where  TRPRSYSID='" + txtTransporterCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtTransporterCode.Text = ds.Tables[0].Rows[0]["TRPRSYSID"].ToString();
                        txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();

                        txtTransporterCode.Focus();
                        panelControl1.Visible = false;
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds.Tables[0];
                            HelpGrid.Show();
                            panelControl1.Visible = true;
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
                Visible = false
            };
            //col6.VisibleIndex = 5;
            HelpGridView.Columns.Add(col6);

        }


        private void FrmGSTPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                panelControl1.Visible = false;
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                ProjectFunctions.TextBoxVisualize(groupControl1);
                ProjectFunctions.TextBoxVisualize(groupControl2);
                ProjectFunctions.GirdViewVisualize(HelpGridView);
                ProjectFunctions.GirdViewVisualize(InfoGridView);
                ProjectFunctions.TextBoxVisualize(this);
                if (S1 == "&Add")
                {
                    groupControl1.Focus();
                    txtDebitPartyCode.Select();
                    txtPurchaseDate.EditValue = DateTime.Now;

                }
                if (S1 == "Edit")
                {

                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadPurchaseMstFEdit '" + ImNo + "' ,'" + ImDate.ToString("yyyy-MM-dd") + "','" + GlobalVariables.CUnitID + "' ");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtPurchaseNo.Text = ds.Tables[0].Rows[0]["SIMNO"].ToString();
                        txtPurchaseDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["SIMDATE"]);
                        txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["SIMPARTYCODE"].ToString();
                        txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                        txtBillingAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                        txtBillingAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                        txtBillingAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                        txtPartyDocNo.Text = ds.Tables[0].Rows[0]["SIMPBILLNO"].ToString();
                        if (ds.Tables[0].Rows[0]["SIMPBILLDATE"].ToString().Length == 0)
                        {

                        }
                        else
                        {
                            txtPartyDocDate.Text = ds.Tables[0].Rows[0]["SIMPBILLDATE"].ToString();
                        }

                        txtValueOfGoods.Text = ds.Tables[0].Rows[0]["SIMTXBAMT"].ToString();
                        txtTotalTaxAmount.Text = ds.Tables[0].Rows[0]["SIMTAXAMT"].ToString();
                        txtRNetAmount.Text = ds.Tables[0].Rows[0]["SIMNETAMTRO"].ToString();
                        txtRoundOffAmount.Text = ds.Tables[0].Rows[0]["SIMROUNDOFF"].ToString();
                        txtGRNo.Text = ds.Tables[0].Rows[0]["SIMGRNO"].ToString();

                        if (ds.Tables[0].Rows[0]["SIMGRDATE"].ToString().Length == 0)
                        {

                        }
                        else
                        {
                            txtGRDate.Text = ds.Tables[0].Rows[0]["SIMGRDATE"].ToString();
                        }
                        txtTransporterCode.Text = ds.Tables[0].Rows[0]["SIMTRANSPORTERID"].ToString();
                        txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();
                        groupControl1.Focus();
                        txtDebitPartyCode.Focus();
                        dt = ds.Tables[1];
                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                        LoadDocs();


                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void LoadDocs()
        {
            DataSet dsDocs = ProjectFunctions.GetDataSet("Select * from ImagesData Where DocType='PUR' And DocNo='" + txtPurchaseNo.Text + "' And DocDate='" + Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd") + "'", ProjectFunctions.ImageConnectionString);
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dt.AcceptChanges();
                if (ValidateDataForSaving())
                {
                    using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                    {
                        sqlcon.Open();
                        var sqlcom = sqlcon.CreateCommand();
                        sqlcom.Connection = sqlcon;
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.CommandType = CommandType.Text;
                        if (S1 == "&Add")
                        {

                            txtPurchaseNo.Text = ProjectFunctions.GetDataSet("Select isnull(Max(SIMNO),0)+1 from PURCHASEMAIN WHere SIMFYR='" + GlobalVariables.FinancialYear + "' ANd UnitCode='" + GlobalVariables.CUnitID + "' And SIMTYPE='RM'").Tables[0].Rows[0][0].ToString();
                            sqlcom.CommandText = " Insert into PURCHASEMAIN "
                                                        + " (SIMTYPE,SIMFYR,SIMNO,SIMDATE,SIMPARTYCODE,UnitCode,SIMPBILLNO,SIMPBILLDATE,SIMTXBAMT,SIMTAXAMT,SIMNETAMTRO,SIMROUNDOFF,SIMGRNO,SIMGRDATE,SIMTRANSPORTERID)values("
                                                        + " @SIMTYPE,@SIMFYR,@SIMNO,@SIMDATE,@SIMPARTYCODE,@UnitCode,@SIMPBILLNO,@SIMPBILLDATE,@SIMTXBAMT,@SIMTAXAMT,@SIMNETAMTRO,@SIMROUNDOFF,@SIMGRNO,@SIMGRDATE,@SIMTRANSPORTERID)";
                            sqlcom.Parameters.Add("@SIMTYPE", SqlDbType.NVarChar).Value = "RM";
                            sqlcom.Parameters.Add("@SIMFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIMNO", SqlDbType.NVarChar).Value = txtPurchaseNo.Text;
                            sqlcom.Parameters.Add("@SIMDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMPARTYCODE", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text;
                            sqlcom.Parameters.Add("@SIMPBILLNO", SqlDbType.NVarChar).Value = txtPartyDocNo.Text;
                            sqlcom.Parameters.Add("@SIMPBILLDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtPartyDocDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMTXBAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtValueOfGoods.Text);
                            sqlcom.Parameters.Add("@SIMTAXAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalTaxAmount.Text);
                            sqlcom.Parameters.Add("@SIMNETAMTRO", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRNetAmount.Text);
                            sqlcom.Parameters.Add("@SIMROUNDOFF", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOffAmount.Text);
                            sqlcom.Parameters.Add("@SIMGRNO", SqlDbType.NVarChar).Value = txtGRNo.Text;
                            if (txtGRDate.Text.Trim().Length == 0)
                            {
                                sqlcom.Parameters.Add("@SIMGRDATE", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                            }
                            else
                            {
                                sqlcom.Parameters.Add("@SIMGRDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtGRDate.Text).ToString("yyyy-MM-dd");
                            }
                            sqlcom.Parameters.Add("@SIMTRANSPORTERID", SqlDbType.NVarChar).Value = txtTransporterCode.Text;
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " update PURCHASEMAIN Set  "
                                                        + "SIMFYR=@SIMFYR,SIMNO=@SIMNO,SIMDATE=@SIMDATE,"
                                                        + " SIMPARTYCODE=@SIMPARTYCODE,SIMPBILLNO=@SIMPBILLNO,SIMPBILLDATE=@SIMPBILLDATE,SIMTXBAMT=@SIMTXBAMT,SIMTAXAMT=@SIMTAXAMT,SIMNETAMTRO=@SIMNETAMTRO,UnitCode=@UnitCode,SIMGRNO=@SIMGRNO,SIMGRDATE=@SIMGRDATE,SIMTRANSPORTERID=@SIMTRANSPORTERID,SIMROUNDOFF=@SIMROUNDOFF where SIMNO='" + txtPurchaseNo.Text + "' And SIMDATE='" + Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "' And SIMTYPE='RM'";
                            sqlcom.Parameters.Add("@SIMTYPE", SqlDbType.NVarChar).Value = "RM";
                            sqlcom.Parameters.Add("@SIMFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIMNO", SqlDbType.NVarChar).Value = txtPurchaseNo.Text;
                            sqlcom.Parameters.Add("@SIMDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@SIMPARTYCODE", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text;
                            sqlcom.Parameters.Add("@SIMPBILLNO", SqlDbType.NVarChar).Value = txtPartyDocNo.Text;

                            if (txtPartyDocDate.Text.Trim().Length == 0)
                            {
                                sqlcom.Parameters.Add("@SIMPBILLDATE", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                            }
                            else
                            {
                                sqlcom.Parameters.Add("@SIMPBILLDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtPartyDocDate.Text).ToString("yyyy-MM-dd");
                            }



                            sqlcom.Parameters.Add("@SIMTXBAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtValueOfGoods.Text);
                            sqlcom.Parameters.Add("@SIMTAXAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalTaxAmount.Text);
                            sqlcom.Parameters.Add("@SIMNETAMTRO", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRNetAmount.Text);
                            sqlcom.Parameters.Add("@SIMROUNDOFF", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOffAmount.Text);
                            sqlcom.Parameters.Add("@SIMGRNO", SqlDbType.NVarChar).Value = txtGRNo.Text;
                            if (txtGRDate.Text.Trim().Length == 0)
                            {
                                sqlcom.Parameters.Add("@SIMGRDATE", SqlDbType.NVarChar).Value = System.Data.SqlTypes.SqlDateTime.Null;
                            }
                            else
                            {
                                sqlcom.Parameters.Add("@SIMGRDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtGRDate.Text).ToString("yyyy-MM-dd");
                            }
                            sqlcom.Parameters.Add("@SIMTRANSPORTERID", SqlDbType.NVarChar).Value = txtTransporterCode.Text;
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                            ProjectFunctions.GetDataSet("Delete from PURCHASEDET Where SIDNO='" + txtPurchaseNo.Text + "' And SIDDATE='" + Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "' aND SIDTYPE='RM'");
                        }

                        foreach (DataRow dr in dt.Rows)
                        {
                            sqlcom.CommandText = " Insert into PURCHASEDET "
                                                    + " (SIDFYR,SIDNO,SIDTYPE,SIDDATE,SIDPrdCode,"
                                                    + " SIDARTID,SIDCOLID,SIDSIZID,SIDITMRATE,SIDITMNETAMT,SIDITMDISCPRCN,SIDITMDISCAMT,SIDQTY,"
                                                    + " SIDSGSTAMT,SIDCGSTAMT,SIDIGSTAMT,SIDCGSTPER,SIDSGSTPER,SIDIGSTPER,TAXCODE,GRPHSNCODE,UnitCode)"
                                                    + " values(@SIDFYR,@SIDNO,@SIDTYPE,@SIDDATE,@SIDPrdCode,"
                                                    + " @SIDARTID,@SIDCOLID,@SIDSIZID,@SIDITMRATE,@SIDITMNETAMT,@SIDITMDISCPRCN,@SIDITMDISCAMT,@SIDQTY,"
                                                    + " @SIDSGSTAMT,@SIDCGSTAMT,@SIDIGSTAMT,@SIDCGSTPER,@SIDSGSTPER,@SIDIGSTPER,@TAXCODE,@GRPHSNCODE,@UnitCode)";
                            sqlcom.Parameters.Add("@SIDFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@SIDNO", SqlDbType.NVarChar).Value = txtPurchaseNo.Text;
                            sqlcom.Parameters.Add("@SIDTYPE", SqlDbType.NVarChar).Value = "RM";
                            sqlcom.Parameters.Add("@SIDDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd");
                            if (dr["SIDPrdCode"].ToString() == string.Empty)
                            {
                                dr["SIDPrdCode"] = "0";
                            }
                            sqlcom.Parameters.Add("@SIDPrdCode", SqlDbType.NVarChar).Value = dr["SIDPrdCode"].ToString();
                            if (dr["SIDARTID"].ToString() == string.Empty)
                            {
                                dr["SIDARTID"] = "0";
                            }


                            sqlcom.Parameters.Add("@SIDARTID", SqlDbType.NVarChar).Value = dr["SIDARTID"].ToString();
                            if (dr["SIDCOLID"].ToString() == string.Empty)
                            {
                                dr["SIDCOLID"] = "0";
                            }
                            sqlcom.Parameters.Add("@SIDCOLID", SqlDbType.NVarChar).Value = dr["SIDCOLID"].ToString();
                            if (dr["SIDSIZID"].ToString() == string.Empty)
                            {
                                dr["SIDSIZID"] = "0";
                            }
                            sqlcom.Parameters.Add("@SIDSIZID", SqlDbType.NVarChar).Value = dr["SIDSIZID"].ToString();
                            sqlcom.Parameters.Add("@SIDITMRATE", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDITMRATE"]);
                            sqlcom.Parameters.Add("@SIDITMNETAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDITMNETAMT"]);
                            sqlcom.Parameters.Add("@SIDITMDISCPRCN", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDITMDISCPRCN"]);
                            sqlcom.Parameters.Add("@SIDITMDISCAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDITMDISCAMT"]);
                            sqlcom.Parameters.Add("@SIDQTY", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDQTY"]);
                            sqlcom.Parameters.Add("@SIDSGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDSGSTAMT"]);
                            sqlcom.Parameters.Add("@SIDCGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDCGSTAMT"]);
                            sqlcom.Parameters.Add("@SIDIGSTAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDIGSTAMT"]);
                            sqlcom.Parameters.Add("@SIDCGSTPER", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDCGSTPER"]);
                            sqlcom.Parameters.Add("@SIDSGSTPER", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDSGSTPER"]);
                            sqlcom.Parameters.Add("@SIDIGSTPER", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["SIDIGSTPER"]);
                            sqlcom.Parameters.Add("@TAXCODE", SqlDbType.NVarChar).Value = dr["TAXCODE"].ToString();
                            sqlcom.Parameters.Add("@GRPHSNCODE", SqlDbType.NVarChar).Value = dr["GRPHSNCODE"].ToString();
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                        }

                        ProjectFunctions.SpeakError(" Purchase Saved Successfully");
                        sqlcon.Close();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
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
                    panelControl1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void InfoGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                HelpGridView.Columns.Clear();
                DataRow currentrow = InfoGridView.GetDataRow(InfoGridView.FocusedRowHandle);

                if (e.KeyCode != Keys.Up)
                {
                    if (e.KeyCode != Keys.Down)
                    {
                        if (e.KeyCode != Keys.Left)
                        {
                            if (e.KeyCode != Keys.Right)
                            {
                                if (e.KeyCode != Keys.F12)
                                {
                                    if (e.KeyCode != Keys.Enter)
                                    {

                                        if (InfoGridView.FocusedColumn.FieldName == "SIDPRDNAME")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SIDPRDNAME";

                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from PrdMst where PrdCode='" + ProjectFunctions.CheckNull(currentrow["SIDPRDCODE"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "SIDPRDNAME";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "SIDPRDNAME";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (InfoGridView.FocusedColumn.FieldName == "SIDARTNO")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SIDARTNO";

                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + ProjectFunctions.CheckNull(currentrow["SIDARTID"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "SIDARTNO";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "SIDARTNO";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (InfoGridView.FocusedColumn.FieldName == "SIDCOLN")
                                        {

                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SIDCOLN";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from COLOURS where COLSYSID='" + ProjectFunctions.CheckNull(currentrow["SIDCOLID"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "SIDCOLN";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "SIDCOLN";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                            }
                                        }

                                        if (InfoGridView.FocusedColumn.FieldName == "SIDSIZN")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SIDSIZN";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;


                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SIZEMAST where SZSYSID='" + ProjectFunctions.CheckNull(currentrow["SIDSIZID"].ToString()) + "' ORDER BY SZINDEX,SZSYSID");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "SIDSIZN";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "SIDSIZN";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = InfoGridView.FocusedRowHandle;
                                                }
                                            }
                                        }


                                        dt.AcceptChanges();
                                    }
                                }
                            }
                        }
                    }
                }


                ProjectFunctions.DeleteCurrentRowOnKeyDown(InfoGrid, InfoGridView, e);

                if (InfoGridView.FocusedColumn.FieldName == "SIDQTY" || InfoGridView.FocusedColumn.FieldName == "SIDITMRATE" || InfoGridView.FocusedColumn.FieldName == "SIDITMDISCAMT")
                {
                    InfoGridView.ShowEditor();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void InfoGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete Current Record", (o1, e1) =>
                {
                    ProjectFunctions.DeleteCurrentRowOnRightClick(InfoGrid, InfoGridView);
                }));

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
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
                    panelControl1.Visible = false;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                HelpGrid.Show();
                if (HelpGrid.Text == "SIDPRDNAME")
                {
                    DataTable dtNew = dsPopUps.Tables[3].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[3].Select("PrdName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["PrdCode"] = dr["PrdCode"];
                        NewRow["PrdName"] = dr["PrdName"];
                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
                if (HelpGrid.Text == "SIDARTNO")
                {
                    DataTable dtNew = dsPopUps.Tables[0].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[0].Select("ARTNO like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["ARTNO"] = dr["ARTNO"];
                        NewRow["ARTDESC"] = dr["ARTDESC"];
                        NewRow["ARTMRP"] = dr["ARTMRP"];
                        NewRow["ARTWSP"] = dr["ARTWSP"];
                        NewRow["ARTSYSID"] = dr["ARTSYSID"];
                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
                if (HelpGrid.Text == "SIDCOLN")
                {
                    DataTable dtNew = dsPopUps.Tables[1].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[1].Select("COLNAME like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["COLNAME"] = dr["COLNAME"];
                        NewRow["COLSYSID"] = dr["COLSYSID"];
                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
                if (HelpGrid.Text == "SIDSIZN")
                {
                    DataTable dtNew = dsPopUps.Tables[2].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[2].Select("SZNAME like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["SZNAME"] = dr["SZNAME"];
                        NewRow["SZSYSID"] = dr["SZSYSID"];
                        NewRow["SZINDEX"] = dr["SZINDEX"];
                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();

                        HelpGridView.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                        HelpGridView.FocusedRowHandle = 0;
                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
            }

            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (InfoGrid.DataSource != null)
                {
                    if (e.Column.FieldName == "SIDITMRATE" || e.Column.FieldName == "SIDQTY" || e.Column.FieldName == "SIDITMDISCAMT")
                    {
                        InfoGridView.CloseEditor();
                        InfoGridView.UpdateCurrentRow();

                        string LCTag = ProjectFunctions.GetDataSet("Select AccLcTag from ActMst Where AccCode='" + txtDebitPartyCode.Text + "'").Tables[0].Rows[0]["AccLcTag"].ToString();
                        DataRow currentrow = InfoGridView.GetDataRow(InfoGridView.FocusedRowHandle);
                        var str = "Exec [sp_LoadTaxMstFPurchase] @PrdCode='" + currentrow["SIDARTID"].ToString() + "',";
                        str = str + "@LCTag='" + LCTag + "'";
                        DataSet dsTax = ProjectFunctions.GetDataSet(str);
                        if (dsTax.Tables[0].Rows.Count > 0)
                        {
                            currentrow["SIDCGSTPER"] = Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxCGSTRate"]);
                            currentrow["SIDSGSTPER"] = Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxSGSTRate"]);
                            currentrow["SIDIGSTPER"] = Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxIGSTRate"]);
                        }

                        currentrow["SIDITMNETAMT"] = (Convert.ToDecimal(currentrow["SIDITMRATE"]) * Convert.ToDecimal(currentrow["SIDQTY"])) - Convert.ToDecimal(currentrow["SIDITMDISCAMT"]);
                        currentrow["SIDSGSTAMT"] = (Convert.ToDecimal(currentrow["SIDITMNETAMT"]) * Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxSGSTRate"])) / 100;
                        currentrow["SIDCGSTAMT"] = (Convert.ToDecimal(currentrow["SIDITMNETAMT"]) * Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxCGSTRate"])) / 100;
                        currentrow["SIDIGSTAMT"] = (Convert.ToDecimal(currentrow["SIDITMNETAMT"]) * Convert.ToDecimal(dsTax.Tables[0].Rows[0]["TaxIGSTRate"])) / 100;
                        currentrow["TAXCODE"] = dsTax.Tables[0].Rows[0]["TaxCode"].ToString();
                        currentrow["GRPHSNCODE"] = dsTax.Tables[0].Rows[0]["GrpHSNCode"].ToString();
                        Calculation();

                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
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
                    sqlcom.Parameters.AddWithValue("@DocType", "PUR");
                    sqlcom.Parameters.AddWithValue("@DocNo", txtPurchaseNo.Text);
                    sqlcom.Parameters.AddWithValue("@DocDate", Convert.ToDateTime(txtPurchaseDate.Text).ToString("yyyy-MM-dd"));
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

        private void XtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DocsGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow currentrow = DocsGridView.GetDataRow(DocsGridView.FocusedRowHandle);
            DataSet ds = ProjectFunctions.GetDataSet("Select * from ImagesData Where Transid='" + Convert.ToInt64(currentrow["Transid"]) + "'", ProjectFunctions.ImageConnectionString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                byte[] MyData = new byte[0];
                MyData = (byte[])ds.Tables[0].Rows[0]["DocImage"];
                MemoryStream stream = new MemoryStream(MyData)
                {
                    Position = 0
                };

                pictureEdit1.Image = Image.FromStream(stream);
                pictureEdit1.Image.Save("C:\\Temp\\A.jpg");

                XtraReport1 rpt = new XtraReport1();
                rpt.xrPictureBox1.ImageUrl = "C:\\Temp\\A.jpg";
                using (var pt = new ReportPrintTool(rpt))
                {
                    pt.ShowRibbonPreviewDialog();
                }
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

                //e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Attach Document", (o1, e1) =>
                //{
                //   LoadDocs();
                //}));

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
    }
}