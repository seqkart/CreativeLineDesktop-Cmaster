using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.FormReports;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Export;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmImportSaleGSTDiffData : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();

        public String S1 { get; set; }
        public String DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public FrmImportSaleGSTDiffData()
        {
            InitializeComponent();
          
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateData()
        {
            foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
            {
                if (dr["SNO."].ToString().Trim().Length > 0)
                {
                    if (dr["NET QUANTITY"].ToString().Trim().Length == 0)
                    {
                        dr["NET QUANTITY"] = "0";
                    }
                    if (dr["SALE Return QUANTITY"].ToString().Trim().Length == 0)
                    {
                        dr["SALE Return QUANTITY"] = "0";
                    }
                    if (dr["MRP TOTAL"].ToString().Trim().Length == 0)
                    {
                        dr["MRP TOTAL"] = "0";
                    }
                    if (dr["CD VALUE"].ToString().Trim().Length == 0)
                    {
                        dr["CD VALUE"] = "0";
                    }
                    if (dr["NET AMOUNT"].ToString().Trim().Length == 0)
                    {
                        dr["NET AMOUNT"] = "0";
                    }
                    if (dr["SGST"].ToString().Trim().Length == 0)
                    {
                        dr["SGST"] = "0";
                    }
                    if (dr["CGST"].ToString().Trim().Length == 0)
                    {
                        dr["CGST"] = "0";
                    }
                }
            }
            return true;
        }

        



        
        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dt.Clear();
            dt.Columns.Clear();
            ProjectFunctions.CreateDataTableHeader(openFileDialog1.FileName, dt);
            ProjectFunctions.BindExcelToGrid(openFileDialog1.FileName, dt, InfoGrid, InfoGridView);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (S1 == "&Add")
                {
                    txtDocNo.Text = GetNewDocCode().PadLeft(10, '0');
                }
                else
                {
                    ProjectFunctions.GetDataSet("Delete from SaleGSTDiffData Where DocNo='" + txtDocNo.Text + "'");
                }

                foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
                {
                    if (dr["SNO."].ToString().Trim().Length > 0)
                    {
                        string Query = "Insert into SaleGSTDiffData(AccCode,DocNo,DocDate, [SNO.],[BRANCH NAME],[BILL NO.] ,[BILL Date],[ITEM CODE],[ITEM NAME],[PACK / SIZE],[NET QUANTITY],[SALE Return QUANTITY],[MRP TOTAL],[CD VALUE],[NET AMOUNT],[SGST],[CGST])values(";
                        Query = Query + "'" + txtDebitPartyCode.Text + "',";
                        Query = Query + "'" + txtDocNo.Text + "',";
                        Query = Query + "'" + Convert.ToDateTime(txtDocDate.Text).ToString("yyyy-MM-dd") + "',";
                        Query = Query + "'" + dr["SNO."].ToString() + "',";
                        Query = Query + "'" + dr["BRANCH NAME"].ToString() + "',";
                        Query = Query + "'" + dr["BILL NO."].ToString() + "',";
                        Query = Query + "'" + Convert.ToDateTime(dr["BILL Date"]).ToString("yyyy-MM-dd") + "',";
                        Query = Query + "'" + dr["ITEM CODE"].ToString() + "',";
                        Query = Query + "'" + dr["ITEM NAME"].ToString() + "',";
                        Query = Query + "'" + dr["PACK / SIZE"].ToString() + "',";
                        Query = Query + "'" + dr["NET QUANTITY"].ToString() + "',";
                        Query = Query + "'" + dr["SALE Return QUANTITY"].ToString() + "',";
                        Query = Query + "'" + dr["MRP TOTAL"].ToString() + "',";
                        Query = Query + "'" + dr["CD VALUE"].ToString() + "',";
                        Query = Query + "'" + dr["NET AMOUNT"].ToString() + "',";
                        Query = Query + "'" + dr["SGST"].ToString() + "',";
                        Query = Query + "'" + dr["CGST"].ToString() + "')";

                        ProjectFunctions.GetDataSet(Query);
                    }
                }
                this.Close();
            }
        }

        private void TxtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDebitPartyName.Text = String.Empty;
        }
        private void PrepareActMstHelpGrid()

        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn

            {
                FieldName = "AccName",

                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 0
            };
            HelpGridView.Columns.Add(col1);

            // HelpGridView.Columns.ColumnByName("'Acc Name'").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

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

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtDebitPartyCode")
            {
                txtDebitPartyCode.Text = row["AccCode"].ToString();
                txtDebitPartyName.Text = row["AccName"].ToString();
                HelpGrid.Visible = false;
                txtDebitPartyCode.Focus();
            }
        }

        private void HelpGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
        private string GetNewDocCode()
        {

            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("SELECT RIGHT('0000000000' + CAST((ISNULL(MAX(CAST(DocNo AS INT)), 0)) AS VARCHAR(10)), 10) AS NewCode FROM SaleGSTDiffData");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;

        }
        private void FrmImportSaleGSTDiffData_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            if (S1 == "&Add")
            {
                txtDocNo.Text = GetNewDocCode().PadLeft(10, '0');
                txtDocDate.EditValue = DateTime.Now;
            }
            if (S1 == "Edit")
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadGSTSaleDiffMstFEdit '" + DocNo + "','" + Convert.ToDateTime(DocDate).ToString("yyyy-MM-dd") + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDocDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["DocDate"]);
                    txtDocNo.Text = ds.Tables[0].Rows[0]["DocNo"].ToString();
                    txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["AccCode"].ToString();
                    txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();

                    txtFromDate.EditValue = Convert.ToDateTime(ds.Tables[1].Rows[0]["FromDate"]);
                    txtToDate.EditValue = Convert.ToDateTime(ds.Tables[1].Rows[0]["ToDate"]);

                    dt = ds.Tables[0];
                    InfoGrid.DataSource = dt;
                   
                    InfoGridView.BestFitColumns();
                    SimpleButton4_Click(null, e);
                }
            }
        }
    

        private void SimpleButton4_Click(object sender, EventArgs e)
        {

            DataSet ds = ProjectFunctions.GetDataSet("sp_GSTSaleDiffData '" + txtDocNo.Text + "' ,'" + Convert.ToDateTime(txtDocDate.Text).ToString("yyyy-MM-dd") + "'");
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    dt= ds.Tables[0];
            //    InfoGrid.DataSource = dt;
            //    InfoGridView.BestFitColumns();
            //}
            //else
            //{
            //    InfoGrid.DataSource = null;
            //    InfoGridView.BestFitColumns();
            //}
            if (ds.Tables[1].Rows.Count > 0)
            {
                FreshGrid.DataSource = ds.Tables[1];
                FreshGridView.BestFitColumns();
            }
            else
            {
                FreshGrid.DataSource = null;
                FreshGridView.BestFitColumns();
            }
            if (ds.Tables[2].Rows.Count > 0)
            {
                EOSSGrid.DataSource = ds.Tables[2];
                EOSSGridView.BestFitColumns();
            }
            else
            {
                EOSSGrid.DataSource = null;
                EOSSGridView.BestFitColumns();
            }
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = ProjectFunctions.GetDataSet("sp_GSTSaleDiffData '" + txtDocNo.Text + "' ,'" + Convert.ToDateTime(txtDocDate.Text).ToString("yyyy-MM-dd") + "'");
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    WindowsFormsApplication1.Prints.PartyReco rpt = new Prints.PartyReco
                    {
                        DataSource = ds
                    };

                    foreach (XRSubreport sub in rpt.AllControls<XRSubreport>())
                    {
                        sub.ReportSource.DataSource = ds;
                    }


                    if(ds.Tables[3].Rows.Count>0)
                    {
                        ds.Tables[3].Columns.Add("Total", typeof(Decimal));
                        ds.Tables[3].Rows[0]["Total"] = Convert.ToDecimal(ds.Tables[1].Rows[4][1]) + Convert.ToDecimal(ds.Tables[2].Rows[4][1]);
                    }

                    ds.WriteXmlSchema("C:\\Temp\\abc.xml");
                    PrintReportViewer frm = new PrintReportViewer();
                    frm.documentViewer1.DocumentSource = rpt;
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }
    }
}
