using DevExpress.XtraEditors;
using System;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class RangeSelectorLedger : XtraUserControl
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public RangeSelectorLedger()
        {
            InitializeComponent();

        }
        private void ValidateDates()
        {
            if (Convert.ToDateTime(DtFrom.EditValue) < Convert.ToDateTime(GlobalVariables.FinYearStartDate) || Convert.ToDateTime(DtFrom.EditValue) > Convert.ToDateTime(GlobalVariables.FinYearEndDate))
            {
                ProjectFunctions.SpeakError("From Date Is Out Of The Financial Year");
                DtFrom.Focus();
            }
            if (Convert.ToDateTime(DtEnd.EditValue) < Convert.ToDateTime(GlobalVariables.FinYearStartDate) || Convert.ToDateTime(DtEnd.EditValue) > Convert.ToDateTime(GlobalVariables.FinYearEndDate))
            {
                ProjectFunctions.SpeakError("End Date Is Out Of The Financial Year");
                DtFrom.Focus();
            }
        }

        private void PrepareActMstHelpGrid()

        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn

            {
                FieldName = "AccName",

                Visible = true,
                SortOrder = DevExpress.Data.ColumnSortOrder.Ascending,
                VisibleIndex = 0
            };
            col1.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col1);


            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccCode",
                Visible = true,
                VisibleIndex = 1
            };
            col2.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "Select",
                Visible = true,
                VisibleIndex = 1,

            };
            col3.OptionsColumn.AllowEdit = true;
            HelpGridView.Columns.Add(col3);



        }
        private void PrepareBSHMstHelpGrid()

        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn

            {
                FieldName = "BSCode",

                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 0
            };
            col1.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col1);


            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "BSDesc",
                Visible = true,
                VisibleIndex = 1
            };
            col2.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "Select",
                Visible = true,
                VisibleIndex = 1,

            };
            col3.OptionsColumn.AllowEdit = true;
            HelpGridView.Columns.Add(col3);



        }

        private void PrepareLedgerGroupMstHelpGrid()

        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn

            {
                FieldName = "LgrCode",

                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 0
            };
            col1.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col1);


            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "LgrDesc",
                Visible = true,
                VisibleIndex = 1
            };
            col2.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "Select",
                Visible = true,
                VisibleIndex = 1,

            };
            col3.OptionsColumn.AllowEdit = true;
            HelpGridView.Columns.Add(col3);



        }
        private void RangeSelector_Load(object sender, EventArgs e)
        {
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
            DtFrom.EditValue = StartDate;
            DtEnd.EditValue = EndDate;
            ValidateDates();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void FillPartyGrid()
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select AccCode,AccName from ActMst where  AccActive='y' order by AccName ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }
                PrepareActMstHelpGrid();
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
            }
            else
            {
                HelpGrid.DataSource = null;
                HelpGridView.BestFitColumns();
            }
        }
        private void FillLedgerGrid()
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select LgrCode,LgrDesc from LgrMst order by LgrDesc ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }
                PrepareLedgerGroupMstHelpGrid();
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
            }
            else
            {
                HelpGrid.DataSource = null;
                HelpGridView.BestFitColumns();
            }
        }
        private void FillBSGrid()
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select BSCode,BSDesc from bshmst order by BSDesc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }
                PrepareBSHMstHelpGrid();
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
            }
            else
            {
                HelpGrid.DataSource = null;
                HelpGridView.BestFitColumns();
            }
        }
        private void ChParty_CheckedChanged(object sender, EventArgs e)
        {
            if (chParty.Checked)
            {
                chLedger.Checked = false;
                chBSHead.Checked = false;
                FillPartyGrid();
            }
        }

        private void ChBSHead_CheckedChanged(object sender, EventArgs e)
        {
            if (chBSHead.Checked)
            {
                chLedger.Checked = false;
                chParty.Checked = false;
                FillBSGrid();
            }
        }

        private void ChLedger_CheckedChanged(object sender, EventArgs e)
        {
            if (chLedger.Checked)
            {
                chBSHead.Checked = false;
                chParty.Checked = false;
                FillLedgerGrid();
            }
        }




    }
}
