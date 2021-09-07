using System;
using System.Data;

namespace WindowsFormsApplication1.FormReports
{
    public partial class FrmPartyAccounts : DevExpress.XtraEditors.XtraForm
    {
        RangeSelectorLedger _SelectRange;
        public DataSet DsGetData { get; set; }
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
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();





                if(_SelectRange.chBSHead.Checked)
                {
                    DataRow currentrow = _SelectRange.HelpGridView.GetDataRow(_SelectRange.HelpGridView.FocusedRowHandle);
                    DataSet dsBSHeads = ProjectFunctions.GetDataSet("Select AccCode,AccName from ActMst Where AccBSHcode ='" + currentrow["BSCode"].ToString() + "'");
                    if(dsBSHeads.Tables[0].Rows.Count>0)
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
                        _SelectRange.HelpGrid.DataSource = null ;
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
                        ds = ProjectFunctions.GetDataSet("[sp_ZoomPartyActGrid] '" + Convert.ToDateTime(_SelectRange.DtFrom.EditValue).ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(_SelectRange.DtEnd.EditValue).ToString("yyyy-MM-dd") + "','" + dr["AccCode"].ToString() + "'");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            int Count = 0;
                            for (Count = 0; Count < ds.Tables[0].Rows.Count; Count++)
                            {
                                if (Count == 0)
                                {
                                    ds.Tables[0].Rows[0]["Balance"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["Debit"]) - Convert.ToDecimal(ds.Tables[0].Rows[0]["Credit"]);
                                }
                                else
                                {
                                    ds.Tables[0].Rows[Count]["Balance"] = Convert.ToDecimal(ds.Tables[0].Rows[Count - 1]["Balance"]) + Convert.ToDecimal(ds.Tables[0].Rows[Count]["Debit"]) - Convert.ToDecimal(ds.Tables[0].Rows[Count]["Credit"]);
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
            LedgerGridView.ShowRibbonPrintPreview();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}