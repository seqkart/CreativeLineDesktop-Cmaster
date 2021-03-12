using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Transaction
{
    public partial class frmImportSaleGSTDiffData : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frmImportSaleGSTDiffData()
        {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateData()
        {
            foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
            {
                if (dr["SNO#"].ToString().Trim().Length > 0)
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
        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dt.Rows.Clear();
            var xlConn = string.Empty;
            xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter(" SELECT * FROM [Sheet1$] ", xlConn))
            {
                myCommand.Fill(dt);

                InfoGrid.DataSource = dt;
                InfoGridView.BestFitColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                String DocNo = ProjectFunctions.GetDataSet("SELECT RIGHT('0000000000' + CAST((ISNULL(MAX(CAST(DocNo AS INT)), 0) + 1) AS VARCHAR(10)), 10) AS NewCode FROM SaleGSTDiffData").Tables[0].Rows[0][0].ToString().PadLeft(10, '0');
                foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
                {
                    if (dr["SNO#"].ToString().Trim().Length > 0)
                    {
                        string Query = "Insert into SaleGSTDiffData(AccCode,DocNo,DocDate, [SNO.],[BRANCH NAME],[BILL NO.] ,[BILL Date],[ITEM CODE],[ITEM NAME],[PACK / SIZE],[NET QUANTITY],[SALE Return QUANTITY],[MRP TOTAL],[CD VALUE],[NET AMOUNT],[SGST],[CGST])values(";
                        Query = Query + "'" + txtDebitPartyCode.Text + "',";
                        Query = Query + "'" + DocNo + "',";
                        Query = Query + "'" + DateTime.Now.ToString("yyyy-MM-dd") + "',";
                        Query = Query + "'" + dr["SNO#"].ToString() + "',";
                        Query = Query + "'" + dr["BRANCH NAME"].ToString() + "',";
                        Query = Query + "'" + dr["BILL NO#"].ToString() + "',";
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
                ProjectFunctions.SpeakError("Pura Ho gya");
            }
        }

        private void txtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
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

        private void txtDebitPartyCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

        private void frmImportSaleGSTDiffData_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DataSet ds= ProjectFunctions.GetDataSet("sp_GSTSaleDiffData '','',''");
            if(ds.Tables[0].Rows.Count>0)
            {
                InfoGrid.DataSource = ds.Tables[0];
                InfoGridView.BestFitColumns();
            }
            else
            {
                InfoGrid.DataSource = null;
                InfoGridView.BestFitColumns();
            }
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = ProjectFunctions.GetDataSet("sp_GSTSaleDiffData '' ,'',''");
                ds.WriteXmlSchema("C:\\Temp\\abc.xml");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    WindowsFormsApplication1.Prints.PartyReco rpt = new Prints.PartyReco();
                    rpt.DataSource = ds;
                    payroll.FormReports.PrintReportViewer frm = new payroll.FormReports.PrintReportViewer();
                    frm.documentViewer1.DocumentSource = rpt;
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
    }
}
