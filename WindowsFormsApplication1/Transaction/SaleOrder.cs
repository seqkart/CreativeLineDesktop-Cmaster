using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class SaleOrder : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public string S1 { get; set; }
        public string DocNo { get; set; }
        public DateTime DocDate { get; set; }
        DataSet dsPopUps = new DataSet();
        int RowIndex = 0;
        string UpdateTag = "N";
        public SaleOrder()
        {
            InitializeComponent();
            dt.Columns.Add("EANNo", typeof(string));
            dt.Columns.Add("ArticleID", typeof(string));
            dt.Columns.Add("ArtNo", typeof(string));
            dt.Columns.Add("ArticleDesc", typeof(string));
            dt.Columns.Add("ColorId", typeof(string));
            dt.Columns.Add("ColorDesc", typeof(string));
            dt.Columns.Add("SizeId", typeof(string));
            dt.Columns.Add("SizeDesc", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("MRP", typeof(string));
            dt.Columns.Add("BaseCost", typeof(string));
            dt.Columns.Add("CGSTPer", typeof(string));
            dt.Columns.Add("SGSTPer", typeof(string));
            dt.Columns.Add("IGSTPer", typeof(string));
            dt.Columns.Add("CGSTAmount", typeof(string));
            dt.Columns.Add("SGSTAmount", typeof(string));
            dt.Columns.Add("IGSTAmount", typeof(string));
            dsPopUps = ProjectFunctions.GetDataSet("sp_LoadBarPrintPopUps");

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
            txtDelieveryCode.Text = string.Empty;
            txtDelieveryName.Text = string.Empty;
            txtDelAddress1.Text = string.Empty;
            txtDelAddress2.Text = string.Empty;
            txtDelAddress3.Text = string.Empty;
            txtDelieveryState.Text = string.Empty;
            txtDelieveryCity.Text = string.Empty;
            txtDelZipCode.Text = string.Empty;
            txtDelTransID.Text = string.Empty;
            txtGSTNo.Text = string.Empty;
        }

        private void TxtDebitPartyCode_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

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

        private void TxtDebitPartyCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

                        txtDelieveryCode.Focus();


                        if (ds.Tables[0].Rows[0]["AccTaxType"].ToString() == "IN")
                        {
                            txtTaxType.Text = "IN";
                        }
                        else
                        {
                            txtTaxType.Text = "EX";
                        }
                    }

                    else
                    {
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

        private void TxtDelieveryCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDelieveryName.Text = string.Empty;
            txtDelAddress1.Text = string.Empty;
            txtDelAddress2.Text = string.Empty;
            txtDelAddress3.Text = string.Empty;
            txtDelieveryCity.Text = string.Empty;
            txtDelZipCode.Text = string.Empty;
            txtDelieveryState.Text = string.Empty;
            txtDelTransID.Text = string.Empty;
        }
        private void LoadDelAddresses()
        {
            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActDelAddresses '" + txtDebitPartyCode.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
                HelpGrid.Show();
                HelpGrid.Focus();
            }
            else
            {
                HelpGrid.DataSource = null;
                HelpGridView.BestFitColumns();
            }


        }
        private void TxtDelieveryCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtDelieveryCode";
                LoadDelAddresses();
            }
            e.Handled = true;
        }

        private void TxtTransporterCode_EditValueChanged(object sender, EventArgs e)
        {
            txtTransporterName.Text = string.Empty;
        }

        private void TxtTransporterCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER", " Where AccCode", txtTransporterCode, txtTransporterName, txtTransporterCode, HelpGrid, HelpGridView, e);
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid.Visible = false;
            }
        }


        private void Calculation()
        {
            decimal TotalSubValue = 0;
            decimal TotalDiscValue = 0;
            decimal TotalTaxValue = 0;

            foreach (DataRow dr in dt.Rows)
            {
                TotalSubValue += Convert.ToDecimal(dr["BaseCost"]);
                TotalTaxValue = TotalTaxValue + Convert.ToDecimal(dr["CGSTAmount"]) + Convert.ToDecimal(dr["SGSTAmount"]) + Convert.ToDecimal(dr["IGSTAmount"]);
            }

            txtSubTotal.EditValue = TotalSubValue;
            txtTotalTax.EditValue = TotalTaxValue;
            txtTotalDiscount.EditValue = TotalDiscValue;

            txtRoundOff.EditValue = Math.Round((Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtTotalTax.Text) + Convert.ToDecimal(txtFreight.Text)), 2) - (Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtTotalTax.Text) + Convert.ToDecimal(txtFreight.Text));

            txtNetAmount.EditValue = (Convert.ToDecimal(txtSubTotal.Text) + Convert.ToDecimal(txtTotalTax.Text) + Convert.ToDecimal(txtFreight.Text) + Convert.ToDecimal(txtRoundOff.Text));

        }
        private void SaleOrder_Load(object sender, EventArgs e)
        {
            ProjectFunctions.TextBoxVisualize(groupControl1);
            ProjectFunctions.TextBoxVisualize(groupControl2);
            ProjectFunctions.TextBoxVisualize(groupControl3);
            ProjectFunctions.TextBoxVisualize(xtraTabPage3);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            dtOrderDate.Enabled = false;
            txtOrderNo.Enabled = false;
            if (S1 == "&Add")
            {
                txtDebitPartyCode.Select();

                dtOrderDate.EditValue = DateTime.Now;
                txtDelieveryDate.EditValue = DateTime.Now;
            }
            if (S1 == "Edit")
            {
                DataSet ds = ProjectFunctions.GetDataSet("[sp_LoadSaleOrderMstFEdit] '" + DocDate.Date.ToString("yyyy-MM-dd") + "','" + DocNo + "'");

                dtOrderDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["DocDate"]).ToString("yyyy-MM-dd");
                txtOrderNo.Text = ds.Tables[0].Rows[0]["DocNo"].ToString();
                txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["BuyerCode"].ToString();
                txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                txtBillingAddress1.Text = ds.Tables[0].Rows[0]["BillingAddress1"].ToString();
                txtBillingAddress2.Text = ds.Tables[0].Rows[0]["BillingAddress2"].ToString();
                txtBillingAddress3.Text = ds.Tables[0].Rows[0]["BillingAddress3"].ToString();
                txtBillingCity.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                txtBillingZip.Text = ds.Tables[0].Rows[0]["BillingZipCode"].ToString();
                txtBuyerDANo.Text = ds.Tables[0].Rows[0]["BuyerDANo"].ToString();
                txtBuyerPONo.Text = ds.Tables[0].Rows[0]["BuyerPONo"].ToString();


                txtDelAccName.Text = ds.Tables[0].Rows[0]["DelAccName"].ToString();

                txtDelieveryCode.Text = ds.Tables[0].Rows[0]["BuyerCode"].ToString();
                txtDelieveryDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["DelieveryDate"]).ToString("yyyy-MM-dd");
                txtDelieveryName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                txtDelTransID.Text = ds.Tables[0].Rows[0]["DelieveryTransID"].ToString();
                txtDelAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                txtDelAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                txtDelAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                txtDelieveryCity.Text = ds.Tables[0].Rows[0]["DeliveryCity"].ToString();
                txtDelZipCode.Text = ds.Tables[0].Rows[0]["DelZipCode"].ToString();
                txtFreight.Text = ds.Tables[0].Rows[0]["FreightValue"].ToString();
                txtGSTNo.Text = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
                txtMargin.Text = ds.Tables[0].Rows[0]["Margin"].ToString();
                txtNetAmount.Text = ds.Tables[0].Rows[0]["NetAmount"].ToString();
                txtRoundOff.Text = ds.Tables[0].Rows[0]["RoundOff"].ToString();
                txtSubTotal.Text = ds.Tables[0].Rows[0]["TaxableValue"].ToString();
                txtTaxType.Text = ds.Tables[0].Rows[0]["TaxType"].ToString();
                txtTC1.Text = ds.Tables[0].Rows[0]["Term1"].ToString();
                txtTC2.Text = ds.Tables[0].Rows[0]["Term2"].ToString();
                txtTC3.Text = ds.Tables[0].Rows[0]["Term3"].ToString();
                txtTotalDiscount.Text = ds.Tables[0].Rows[0]["TotalDiscValue"].ToString();
                txtTotalTax.Text = ds.Tables[0].Rows[0]["TotalTaxValue"].ToString();
                txtTransporterCode.Text = ds.Tables[0].Rows[0]["TransporterCode"].ToString();
                txtTransporterName.Text = ds.Tables[0].Rows[0]["TrpName"].ToString();
                dt = ds.Tables[1];
                if (dt.Rows.Count > 0)
                {
                    InfoGrid.DataSource = dt;
                    InfoGridView.BestFitColumns();
                }
                else
                {
                    InfoGrid.DataSource = null;
                    InfoGridView.BestFitColumns();
                }
            }
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
                txtTransporterCode.Focus();
            }
            if (HelpGrid.Text == "txtDelieveryCode")
            {

                txtDelieveryCode.Text = row["AccCode"].ToString();
                txtDelieveryName.Text = row["AccName"].ToString();
                txtDelAddress1.Text = row["AccAddress1"].ToString();
                txtDelAddress2.Text = row["AccAddress2"].ToString();
                txtDelAddress3.Text = row["AccAddress3"].ToString();
                txtDelieveryCity.Text = row["CTNAME"].ToString();
                txtDelTransID.Text = row["TransId"].ToString();
                txtDelAccName.Text = row["DelAccName"].ToString();
                txtDelZipCode.Text = row["DelZipCode"].ToString();
                HelpGrid.Visible = false;
                txtBuyerPONo.Focus();
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
                txtDelieveryCode.Text = row["AccCode"].ToString();
                txtDelieveryName.Text = row["AccName"].ToString();

                txtGSTNo.Text = row["AccGSTNo"].ToString();
                if (row["AccTaxType"].ToString() == "IN")
                {
                    txtTaxType.Text = "IN";
                }
                else
                {
                    txtTaxType.Text = "EX";
                }
                HelpGrid.Visible = false;
                txtDelieveryCode.Focus();
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            InfoGrid.Refresh();
            DataTable ExcelTable = new DataTable();
            string xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", xlConn))
            {
                myCommand.Fill(ExcelTable);

                if (ExcelTable.Rows.Count > 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("Select * from DataTemplates Where TemplateCode=(Select TemplateCode from ActMst Where AccCode='" + txtDebitPartyCode.Text + "')");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ExcelTable.Rows)
                        {
                            DataRow dataRow = dt.NewRow();
                            foreach (DataRow drTemplate in ds.Tables[0].Rows)
                            {


                                if (drTemplate["DFieldName"].ToString().ToUpper() == "ARTICLEID")
                                {
                                    dataRow["ArtNo"] = dr[drTemplate["SFieldName"].ToString()];
                                }
                                else
                                {
                                    if (drTemplate["DFieldName"].ToString().ToUpper() == "COLORID")
                                    {
                                        dataRow["ColorDesc"] = dr[drTemplate["SFieldName"].ToString()];
                                    }
                                    else
                                    {
                                        if (drTemplate["DFieldName"].ToString().ToUpper() == "SIZEID")
                                        {
                                            dataRow["SizeDesc"] = dr[drTemplate["SFieldName"].ToString()];
                                        }
                                        else
                                        {
                                            dataRow[drTemplate["DFieldName"].ToString()] = dr[drTemplate["SFieldName"].ToString()];
                                        }
                                    }
                                }
                            }
                            dt.Rows.Add(dataRow);
                        }
                    }
                }


                if (dt.Rows.Count > 0)
                {
                    txtBuyerPONo.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                    foreach (DataRow dr in dt.Rows)
                    {
                        DataSet dsArticle = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + dr["ArtNo"].ToString() + "'");
                        if (dsArticle.Tables[0].Rows.Count > 0)
                        {
                            dr["ArticleID"] = dsArticle.Tables[0].Rows[0]["ARTSYSID"].ToString();
                            dr["ArtNo"] = dsArticle.Tables[0].Rows[0]["ARTNO"].ToString();
                            dr["ArticleDesc"] = dsArticle.Tables[0].Rows[0]["ARTDESC"].ToString();
                        }

                        DataSet dsColor = ProjectFunctions.GetDataSet("Select * from COLOURS where COLNAME='" + dr["ColorDesc"].ToString() + "'");
                        if (dsColor.Tables[0].Rows.Count > 0)
                        {
                            dr["ColorId"] = dsColor.Tables[0].Rows[0]["COLSYSID"].ToString();
                            dr["ColorDesc"] = dsColor.Tables[0].Rows[0]["COLNAME"].ToString();
                        }
                        DataSet dsSize = ProjectFunctions.GetDataSet("Select * from SIZEMAST where SZNAME='" + dr["SizeDesc"] + "' ");
                        if (dsSize.Tables[0].Rows.Count > 0)
                        {
                            dr["SizeId"] = dsSize.Tables[0].Rows[0]["SZSYSID"].ToString();
                            dr["SizeDesc"] = dsSize.Tables[0].Rows[0]["SZNAME"].ToString();

                        }
                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                        Calculation();
                    }
                }
                else
                {
                    InfoGrid.DataSource = null;
                    InfoGridView.BestFitColumns();
                }

            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private bool ValidateDataForSaving()
        {
            try

            {
                if (InfoGridView.DataSource == null)
                {
                    ProjectFunctions.SpeakError("No Data To Save");
                }
                if (txtMargin.Text.Trim().Length == 0)
                {

                    txtMargin.Text = "0";
                }
                return true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
                return false;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataForSaving())
            {
                Calculation();
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {

                    var MaxRow = (InfoGrid.FocusedView as GridView).RowCount;
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    sqlcom.Connection = sqlcon;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {

                        if (S1 == "&Add")
                        {


                            txtOrderNo.Text = ProjectFunctions.GetDataSet("select isnull(max(DocNo),0)+1 from SaleOrderMst ").Tables[0].Rows[0][0].ToString();

                            sqlcom.CommandText = "Insert into SaleOrderMst(DocNo,DocDate,BuyerCode,DelieveryTransID,BuyerPONo,BuyerDANo," +
                                "Term1,Term2,Term3,Margin,TaxType,TransporterCode,DelieveryDate,TaxableValue,TotalTaxValue,TotalDiscValue,FreightValue,RoundOff,NetAmount)values(" +
                                "@DocNo,@DocDate,@BuyerCode,@DelieveryTransID,@BuyerPONo,@BuyerDANo," +
                                "@Term1,@Term2,@Term3,@Margin,@TaxType,@TransporterCode,@DelieveryDate,@TaxableValue,@TotalTaxValue,@TotalDiscValue,@FreightValue,@RoundOff,@NetAmount)";
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = txtOrderNo.Text;
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtOrderDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@BuyerCode", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text.Trim();
                            sqlcom.Parameters.Add("@DelieveryTransID", SqlDbType.NVarChar).Value = txtDelTransID.Text.Trim();
                            sqlcom.Parameters.Add("@BuyerPONo", SqlDbType.NVarChar).Value = txtBuyerPONo.Text.Trim();
                            sqlcom.Parameters.Add("@BuyerDANo", SqlDbType.NVarChar).Value = txtBuyerDANo.Text.Trim();
                            sqlcom.Parameters.Add("@Term1", SqlDbType.NVarChar).Value = txtTC1.Text.Trim();
                            sqlcom.Parameters.Add("@Term2", SqlDbType.NVarChar).Value = txtTC2.Text.Trim();
                            sqlcom.Parameters.Add("@Term3", SqlDbType.NVarChar).Value = txtTC3.Text.Trim();
                            sqlcom.Parameters.Add("@Margin", SqlDbType.NVarChar).Value = txtMargin.Text.Trim();
                            sqlcom.Parameters.Add("@TaxType", SqlDbType.NVarChar).Value = txtTaxType.Text.Trim();
                            sqlcom.Parameters.Add("@TransporterCode", SqlDbType.NVarChar).Value = txtTransporterCode.Text.Trim();
                            sqlcom.Parameters.Add("@DelieveryDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDelieveryDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@TaxableValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtSubTotal.Text);
                            sqlcom.Parameters.Add("@TotalTaxValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalTax.Text);
                            sqlcom.Parameters.Add("@TotalDiscValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalDiscount.Text);
                            sqlcom.Parameters.Add("@FreightValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtFreight.Text);
                            sqlcom.Parameters.Add("@RoundOff", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOff.Text);
                            sqlcom.Parameters.Add("@NetAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtNetAmount.Text);
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = "Update SaleOrderMst Set BuyerCode=@BuyerCode,DelieveryTransID=@DelieveryTransID,BuyerPONo=@BuyerPONo,BuyerDANo=@BuyerDANo,Term1=@Term1,Term2=@Term2," +
                                "Term3=@Term3,Margin=@Margin,TaxType=@TaxType,TransporterCode=@TransporterCode,DelieveryDate=@DelieveryDate,TaxableValue=@TaxableValue,TotalTaxValue=@TotalTaxValue," +
                                "TotalDiscValue=@TotalDiscValue,FreightValue=@FreightValue,RoundOff=@RoundOff,NetAmount=@NetAmount Where DocDate='" + Convert.ToDateTime(DocDate).ToString("yyyy-MM-dd") + "' And DocNo='" + DocNo + "'";
                            sqlcom.Parameters.Add("@BuyerCode", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text.Trim();
                            sqlcom.Parameters.Add("@DelieveryTransID", SqlDbType.NVarChar).Value = txtDelTransID.Text.Trim();
                            sqlcom.Parameters.Add("@BuyerPONo", SqlDbType.NVarChar).Value = txtBuyerPONo.Text.Trim();
                            sqlcom.Parameters.Add("@BuyerDANo", SqlDbType.NVarChar).Value = txtBuyerDANo.Text.Trim();
                            sqlcom.Parameters.Add("@Term1", SqlDbType.NVarChar).Value = txtTC1.Text.Trim();
                            sqlcom.Parameters.Add("@Term2", SqlDbType.NVarChar).Value = txtTC2.Text.Trim();
                            sqlcom.Parameters.Add("@Term3", SqlDbType.NVarChar).Value = txtTC3.Text.Trim();
                            sqlcom.Parameters.Add("@Margin", SqlDbType.NVarChar).Value = txtMargin.Text.Trim();
                            sqlcom.Parameters.Add("@TaxType", SqlDbType.NVarChar).Value = txtTaxType.Text.Trim();
                            sqlcom.Parameters.Add("@TransporterCode", SqlDbType.NVarChar).Value = txtTransporterCode.Text.Trim();
                            sqlcom.Parameters.Add("@DelieveryDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDelieveryDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@TaxableValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtSubTotal.Text);
                            sqlcom.Parameters.Add("@TotalTaxValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalTax.Text);
                            sqlcom.Parameters.Add("@TotalDiscValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtTotalDiscount.Text);
                            sqlcom.Parameters.Add("@FreightValue", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtFreight.Text);
                            sqlcom.Parameters.Add("@RoundOff", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtRoundOff.Text);
                            sqlcom.Parameters.Add("@NetAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtNetAmount.Text);
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();

                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = "Delete from SaleOrderData Where DocNo=@DocNo And DocDate=@DocDate";
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtOrderDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtOrderNo.Text).ToString("yyyy-MM-dd");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        for (var i = 0; i < MaxRow; i++)
                        {
                            sqlcom.CommandType = CommandType.Text;
                            var currentrow = InfoGridView.GetDataRow(i);
                            sqlcom.CommandText = " Insert into SaleOrderData "
                                                        + " (DocNo,DocDate,BuyerCode,EANNo,ArticleID,ColorId,SizeId,Quantity,MRP,CGSTPer,SGSTPer,IGSTPer,CGSTAmount,SGSTAmount,IGSTAmount,BaseCost)values("
                                                        + "@DocNo,@DocDate,@BuyerCode,@EANNo,@ArticleID,@ColorId,@SizeId,@Quantity,@MRP,@CGSTPer,@SGSTPer,@IGSTPer,@CGSTAmount,@SGSTAmount,@IGSTAmount,@BaseCost)";
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(dtOrderDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = txtOrderNo.Text;
                            sqlcom.Parameters.Add("@BuyerCode", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text;
                            sqlcom.Parameters.Add("@EANNo", SqlDbType.NVarChar).Value = currentrow["EANNo"].ToString();

                            sqlcom.Parameters.Add("@ArticleID", SqlDbType.NVarChar).Value = currentrow["ArticleID"].ToString();
                            sqlcom.Parameters.Add("@ColorId", SqlDbType.NVarChar).Value = currentrow["ColorId"].ToString();
                            sqlcom.Parameters.Add("@SizeId", SqlDbType.NVarChar).Value = currentrow["SizeId"].ToString();
                            sqlcom.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["Quantity"]);
                            sqlcom.Parameters.Add("@MRP", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["MRP"]);
                            sqlcom.Parameters.Add("@CGSTPer", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["CGSTPer"]);
                            sqlcom.Parameters.Add("@SGSTPer", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SGSTAmount"]);
                            sqlcom.Parameters.Add("@IGSTPer", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SGSTAmount"]);
                            sqlcom.Parameters.Add("@CGSTAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SGSTAmount"]);
                            sqlcom.Parameters.Add("@SGSTAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["SGSTAmount"]);
                            sqlcom.Parameters.Add("@IGSTAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["IGSTAmount"]);
                            sqlcom.Parameters.Add("@BaseCost", SqlDbType.NVarChar).Value = Convert.ToDecimal(currentrow["BaseCost"]);

                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }

                        ProjectFunctions.SpeakError("Invoice Data Saved Successfully");
                        sqlcon.Close();

                        Close();
                    }

                    catch (Exception ex)

                    {
                        ProjectFunctions.SpeakError(ex.Message);

                    }
                    Close();
                }
            }
        }

        private void InfoGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                GridControlView1.Columns.Clear();
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
                                        if (InfoGridView.FocusedColumn.FieldName == "ArtNo")
                                        {
                                            if (currentrow == null)
                                            {
                                                GridControl1.Text = "ArtNo";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + ProjectFunctions.CheckNull(currentrow["ArtNo"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";
                                                    GridControl1.Text = "ArtNo";
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
                                                    GridControl1.Text = "ArtNo";
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
                                        if (InfoGridView.FocusedColumn.FieldName == "ColorId")
                                        {
                                            if (currentrow == null)
                                            {
                                                GridControl1.Text = "ColorId";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from COLOURS where COLSYSID='" + ProjectFunctions.CheckNull(currentrow["ColorId"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";

                                                    GridControl1.Text = "ColorId";
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
                                                    GridControl1.Text = "ColorId";
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

                                        if (InfoGridView.FocusedColumn.FieldName == "SizeId")
                                        {
                                            if (currentrow == null)
                                            {
                                                GridControl1.Text = "SizeId";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;


                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SIZEMAST where SZSYSID='" + ProjectFunctions.CheckNull(currentrow["SizeId"].ToString()) + "' ORDER BY SZINDEX,SZSYSID");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";

                                                    GridControl1.Text = "SizeId";
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
                                                    GridControl1.Text = "SizeId";
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

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void GridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dt.AcceptChanges();
                DataRow row = GridControlView1.GetDataRow(GridControlView1.FocusedRowHandle);


                if (GridControlView1.RowCount > 0)
                {
                    if (GridControl1.Text == "ArtNo")
                    {
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["ArticleID"], row["ARTSYSID"].ToString());
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["ArtNo"], row["ARTNO"].ToString());
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["ArticleDesc"], row["ARTDESC"].ToString());

                        InfoGridView.CloseEditor();
                        InfoGridView.UpdateCurrentRow();


                        UpdateTag = "N";
                        panelControl1.Visible = false;
                        InfoGridView.Focus();

                        InfoGridView.FocusedColumn = InfoGridView.Columns["ColorId"];
                        InfoGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = string.Empty;
                        dt.AcceptChanges();
                    }

                    //InitializeComponent();


                    if (GridControl1.Text == "ColorId")
                    {
                        InfoGridView.UpdateCurrentRow();
                        UpdateTag = "N";
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["ColorId"], row["COLSYSID"].ToString());
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["ColorDesc"], row["COLNAME"].ToString());
                        InfoGridView.Focus();
                        panelControl1.Visible = false;

                        InfoGridView.FocusedColumn = InfoGridView.Columns["SizeId"];
                        InfoGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = string.Empty;
                        dt.AcceptChanges();
                    }
                    if (GridControl1.Text == "SizeId")
                    {
                        UpdateTag = "N";

                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SizeId"], row["SZSYSID"].ToString());
                        InfoGridView.SetRowCellValue(RowIndex, InfoGridView.Columns["SizeDesc"], row["SZNAME"].ToString());
                        panelControl1.Visible = false;
                        InfoGridView.Focus();
                        InfoGridView.FocusedColumn = InfoGridView.Columns["Quantity"];
                        InfoGridView.FocusedRowHandle = RowIndex;


                        txtSearchBox.Text = string.Empty;

                        dt.AcceptChanges();

                    }
                }

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
                GridControl1.Show();
                if (GridControl1.Text == "ArtNo")
                {
                    DataTable dtNew = dsPopUps.Tables[0].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[0].Select("ARTNO like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["ARTNO"] = dr["ARTNO"];
                        NewRow["ARTDESC"] = dr["ARTDESC"];
                        NewRow["ARTSYSID"] = dr["ARTSYSID"];
                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        GridControl1.DataSource = dtNew;
                        GridControlView1.BestFitColumns();
                    }
                    else
                    {
                        GridControl1.DataSource = null;
                        GridControlView1.BestFitColumns();
                    }
                }
                if (GridControl1.Text == "ColorId")
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
                        GridControl1.DataSource = dtNew;
                        GridControlView1.BestFitColumns();
                    }
                    else
                    {
                        GridControl1.DataSource = null;
                        GridControlView1.BestFitColumns();
                    }
                }
                if (GridControl1.Text == "SizeId")
                {
                    DataTable dtNew = dsPopUps.Tables[2].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[2].Select("SZNAME like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["SZNAME"] = dr["SZNAME"];
                        NewRow["SZSYSID"] = dr["SZSYSID"];

                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        GridControl1.DataSource = dtNew;
                        GridControlView1.BestFitColumns();

                        GridControlView1.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                        GridControlView1.FocusedRowHandle = 0;
                    }
                    else
                    {
                        GridControl1.DataSource = null;
                        GridControlView1.BestFitColumns();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void TxtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            try

            {
                GridControlView1.CloseEditor();
                GridControlView1.UpdateCurrentRow();
                if (e.KeyCode == Keys.Enter)
                {
                    GridControl1_DoubleClick(null, e);
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

        private void TxtFreight_EditValueChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void HelpGrid_Click(object sender, EventArgs e)
        {

        }
    }
}