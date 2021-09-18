using System;
using System.Data;

namespace WindowsFormsApplication1.FormReports
{
    public partial class FrmPartyAccounts : DevExpress.XtraEditors.XtraForm
    {
        RangeSelectorLedger _SelectRange;
        public DataSet DsGetData { get; set; }

        DataTable dt = new DataTable();
        public FrmPartyAccounts()
        {
            InitializeComponent();
        }

        private void FrmPartyAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                _SelectRange = new RangeSelectorLedger() { StartDate = GlobalVariables.FinYearStartDate, EndDate = GlobalVariables.FinYearEndDate };
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                _SelectRange.BtnLoad.Click += BtnLoad_Click;
                Controls.Add(_SelectRange);
                _SelectRange.BringToFront();
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void PrepareActMstHelpGrid()

        {
            _SelectRange.HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn

            {
                FieldName = "AccName",

                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 0
            };
            col1.OptionsColumn.AllowEdit = false;
            _SelectRange.HelpGridView.Columns.Add(col1);


            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccCode",
                Visible = true,
                VisibleIndex = 1
            };
            col2.OptionsColumn.AllowEdit = false;
            _SelectRange.HelpGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "Select",
                Visible = true,
                VisibleIndex = 1,

            };
            col3.OptionsColumn.AllowEdit = true;
            _SelectRange.HelpGridView.Columns.Add(col3);



        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {

                dt.Clear();
                DataSet ds = new DataSet();


                if (_SelectRange.chBSHead.Checked)
                {
                    DataRow currentrow = _SelectRange.HelpGridView.GetDataRow(_SelectRange.HelpGridView.FocusedRowHandle);
                    DataSet dsBSHeads = ProjectFunctions.GetDataSet("Select AccCode,AccName from ActMst Where AccBSHcode ='" + currentrow["BSCode"].ToString() + "'");
                    if (dsBSHeads.Tables[0].Rows.Count > 0)
                    {
                        dsBSHeads.Tables[0].Columns.Add("Select", typeof(bool));
                        foreach (DataRow dr in dsBSHeads.Tables[0].Rows)
                        {
                            dr["Select"] = true;
                        }
                        PrepareActMstHelpGrid();
                        _SelectRange.HelpGrid.DataSource = dsBSHeads.Tables[0];
                        _SelectRange.HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        _SelectRange.HelpGrid.DataSource = null;
                        _SelectRange.HelpGridView.BestFitColumns();
                    }
                }
                if (_SelectRange.chLedger.Checked)
                {
                    DataRow currentrow = _SelectRange.HelpGridView.GetDataRow(_SelectRange.HelpGridView.FocusedRowHandle);
                    DataSet dsLedgerHeads = ProjectFunctions.GetDataSet("Select AccCode,AccName from ActMst Where AccLedger ='" + currentrow["LgrCode"].ToString() + "'");
                    if (dsLedgerHeads.Tables[0].Rows.Count > 0)
                    {
                        dsLedgerHeads.Tables[0].Columns.Add("Select", typeof(bool));
                        foreach (DataRow dr in dsLedgerHeads.Tables[0].Rows)
                        {
                            dr["Select"] = true;
                        }
                        PrepareActMstHelpGrid();
                        _SelectRange.HelpGrid.DataSource = dsLedgerHeads.Tables[0];
                        _SelectRange.HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        _SelectRange.HelpGrid.DataSource = null;
                        _SelectRange.HelpGridView.BestFitColumns();
                    }
                }




                foreach (DataRow dr in (_SelectRange.HelpGrid.DataSource as DataTable).Rows)
                {
                    if (dr["Select"].ToString().ToUpper() == "TRUE")
                    {
                        String SubEntries = String.Empty;
                        if (_SelectRange.chSubEntries.Checked)
                        {
                            SubEntries = "Y";
                        }

                        ds = ProjectFunctions.GetDataSet("[sp_ZoomPartyActGrid] '" + Convert.ToDateTime(_SelectRange.DtFrom.EditValue).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(_SelectRange.DtEnd.EditValue).ToString("yyyy-MM-dd") + "','" + dr["AccCode"].ToString() + "','" + SubEntries + "'");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            int Count = 0;
                            Decimal Balance = 0;
                            for (Count = 0; Count < ds.Tables[0].Rows.Count; Count++)
                            {
                                if (Count == 0)
                                {
                                    ds.Tables[0].Rows[0]["Balance"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["Debit"]) - Convert.ToDecimal(ds.Tables[0].Rows[0]["Credit"]);
                                    Balance = Convert.ToDecimal(ds.Tables[0].Rows[0]["Balance"]);
                                }
                                else
                                {
                                    if (ds.Tables[0].Rows[Count]["VutID"].ToString() != "-1")
                                    {

                                        ds.Tables[0].Rows[Count]["Balance"] = Balance + Convert.ToDecimal(ds.Tables[0].Rows[Count]["Debit"]) - Convert.ToDecimal(ds.Tables[0].Rows[Count]["Credit"]);
                                        Balance = Convert.ToDecimal(ds.Tables[0].Rows[Count]["Balance"]);
                                    }
                                    else
                                    {
                                        ds.Tables[0].Rows[Count]["Debit"] = Convert.ToDecimal("0");
                                        ds.Tables[0].Rows[Count]["Credit"] = Convert.ToDecimal("0");
                                        ds.Tables[0].Rows[Count]["VutNo"] = null;
                                        ds.Tables[0].Rows[Count]["VutDesc"] = null;
                                        ds.Tables[0].Rows[Count]["VutDate"] = Convert.ToDateTime("1900-01-01");

                                        ds.Tables[0].Rows[Count]["VutType"] = null;
                                    }
                                }
                            }

                            if (ds.Tables[0].Rows.Count > 0)
                            {

                                if (dt.Rows.Count > 0)
                                {
                                    dt.Merge(ds.Tables[0]);
                                }
                                else
                                {
                                    dt = ds.Tables[0];
                                }
                            }
                        }
                    }
                }




                if (dt.Rows.Count > 0)
                {

                    dt.Columns.Add("CRDR", typeof(String));
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (Convert.ToDecimal(dr["Balance"]) > 0)
                        {
                            dr["CRDR"] = "Dr.";
                        }
                        if (Convert.ToDecimal(dr["Balance"]) < 0)
                        {
                            dr["CRDR"] = "Cr.";
                            dr["Balance"] = -(Convert.ToDecimal(dr["Balance"]));
                        }
                    }


                    dt.WriteXmlSchema("C://Temp//abc.xml");
                    LedgerGrid.DataSource = dt;
                    LedgerGridView.BestFitColumns();
                    LedgerGridView.Columns["LedgerPartyName"].GroupIndex = 0;
                    LedgerGridView.ExpandAllGroups();
                }
                else
                {
                    LedgerGrid.DataSource = null;
                }
                _SelectRange.Visible = false;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            _SelectRange.Visible = true;
            _SelectRange.BringToFront();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {


            // LedgerGridView.ShowRibbonPrintPreview();
            payroll.FormReports.PrintReportViewer frm = new payroll.FormReports.PrintReportViewer();
            Prints.PartyLedgerUpdated Report = new Prints.PartyLedgerUpdated();
            Report.txtCompanyName.Text = GlobalVariables.CompanyName;
            Report.txtReportName.Text = "Statement of Accounts";
            Report.txtDateRange.Text = "From " + Convert.ToDateTime(_SelectRange.DtFrom.Text).ToString("dd-MM-yyyy") + " To " + Convert.ToDateTime(_SelectRange.DtEnd.Text).ToString("dd-MM-yyyy");


            int count = 0;
            foreach(DataRow dr in (_SelectRange.HelpGrid.DataSource as DataTable).Rows)
            {
                if(dr["Select"].ToString().ToUpper()=="TRUE")
                {
                    count++;
                }
            }

            if (count==1)
            {
                Report.txtensumd.Visible = false;
                Report.txtenbal.Visible = false;
                Report.txtensunc.Visible = false;
                Report.xrLine1.Visible = false;
                Report.xrLabel16.Visible = false;
            }
            else
            {
                Report.txtensumd.Visible = true;
                Report.txtenbal.Visible = true;
                Report.txtensunc.Visible = true;
                Report.xrLine1.Visible = true;
                Report.xrLabel16.Visible = true;
            }
            Report.DataSource = dt;
            frm.documentViewer1.DocumentSource = Report;
            frm.ShowDialog();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LedgerGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Debit")
            {
                if (Convert.ToDecimal(e.Value) == 0)
                {
                    e.DisplayText = string.Empty;
                }
            }
            if (e.Column.FieldName == "Credit")
            {
                if (Convert.ToDecimal(e.Value) == 0)
                {
                    e.DisplayText = string.Empty;
                }
            }
            if (e.Column.FieldName == "Balance")
            {
                if (Convert.ToDecimal(e.Value) == 0)
                {
                    e.DisplayText = string.Empty;
                }
            }
            if (e.Column.FieldName == "VutDate")
            {
                if (Convert.ToDateTime(e.Value).Date == Convert.ToDateTime("1900-01-01").Date)
                {
                    e.DisplayText = string.Empty;
                }
            }
            
        }
    }
}