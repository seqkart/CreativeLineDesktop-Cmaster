using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.FormReports
{
    public partial class FrmSaleReportParameterised : DevExpress.XtraEditors.XtraForm
    {
        frmSelectRangeNew _RangeSelector = new frmSelectRangeNew() { StartDate = GlobalVariables.FinYearStartDate, EndDate = GlobalVariables.FinYearEndDate };
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public FrmSaleReportParameterised()
        {
            InitializeComponent();
        }
        void BtnLoad_Click(object sender, EventArgs e)
        {
           
            String PartyString = String.Empty;
            String ArticleString = String.Empty;
            String LedgerString = String.Empty;
            int i = 0;
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in _RangeSelector.txtParty.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    if (i == 0)
                    {
                        PartyString = item.Value.ToString() + ",";
                    }
                    else
                    {
                        PartyString = PartyString + item.Value.ToString() + ",";
                    }
                    i++;
                }
            }
            PartyString = PartyString.Remove(PartyString.Length - 1, 1);




            i = 0;
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in _RangeSelector.txtGroups.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    if (i == 0)
                    {
                        ArticleString = item.Value.ToString() + ",";
                    }
                    else
                    {
                        ArticleString = ArticleString + item.Value.ToString() + ",";
                    }
                    i++;
                }
            }
            ArticleString = ArticleString.Remove(ArticleString.Length - 1, 1);


            i = 0;
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in _RangeSelector.txtLedger.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    if (i == 0)
                    {
                        LedgerString = item.Value.ToString() + ",";
                    }
                    else
                    {
                        LedgerString = LedgerString + item.Value.ToString() + ",";
                    }
                    i++;
                }
            }
            LedgerString = LedgerString.Remove(LedgerString.Length - 1, 1);

            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadSaleDataParm '" + _RangeSelector.DtFrom.DateTime.Date.ToString("yyy-MM-dd") + "','" + _RangeSelector.DtEnd.DateTime.Date.ToString("yyy-MM-dd") + "','01','" + PartyString + "','" + ArticleString + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                MasterGrid.DataSource = ds.Tables[0];
                MasterGridView.BestFitColumns();

                //MasterGridView.ActiveFilterString = "([SIDPARTYC] IS ANY OF " + PartyString + ")";
            }
            else
            {
                MasterGrid.DataSource = null;
                MasterGridView.BestFitColumns();
            }

            _RangeSelector.Visible = false;
        }
        private void MasterGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Select Report Data Range", (o1, e1) =>
                {
                    Controls.Add(_RangeSelector);
                    _RangeSelector.BtnLoad.Click += new EventHandler(BtnLoad_Click);
                    _RangeSelector.BringToFront();
                    _RangeSelector.Location = new Point(e.Point.X + 20, e.Point.Y + 20);
                    _RangeSelector.Show();
                    _RangeSelector.DtFrom.Focus();
                }));


                var formatRulesMenu = new DXPopupMenu();
                var view = sender as GridView;

                DXMenuItem Copy;


                DXMenuItem SAR;



                DXMenuItem Collapse;
                DXMenuItem Expand;
                DXMenuItem FixLeft;
                DXMenuItem FixRight;
                DXMenuItem UnFix;


                Copy = new DXMenuItem("Copy", (o1, e1) =>
                {
                    view.OptionsSelection.MultiSelect = true;
                    view.CopyToClipboard();
                });
                SAR = new DXMenuItem("Select All Records", (o1, e1) =>
                {
                    view.OptionsSelection.MultiSelect = true;
                    view.SelectAll();
                });
                Expand = new DXMenuItem("Expand All", (o1, e1) =>
                {
                    MasterGridView.ExpandAllGroups();
                });
                Collapse = new DXMenuItem("Collapse All", (o1, e1) =>
                {
                    MasterGridView.CollapseAllGroups();
                });
                FixLeft = new DXMenuItem("Fix Column Left", (o1, e1) =>
                {
                    MasterGridView.OptionsView.ColumnAutoWidth = false;
                    var hitInfo = MasterGridView.CalcHitInfo(MasterGrid.PointToClient(Control.MousePosition));
                    if (hitInfo.InRowCell)
                    {
                        int rowHandle = hitInfo.RowHandle;
                        DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                        column = hitInfo.Column;
                        column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    }
                });
                FixRight = new DXMenuItem("Fix Column Right", (o1, e1) =>
                {
                    MasterGridView.OptionsView.ColumnAutoWidth = false;
                    var hitInfo = MasterGridView.CalcHitInfo(MasterGrid.PointToClient(Control.MousePosition));
                    if (hitInfo.InRowCell)
                    {
                        int rowHandle = hitInfo.RowHandle;
                        DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                        column = hitInfo.Column;
                        column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
                    }
                });
                UnFix = new DXMenuItem("Unfix Column", (o1, e1) =>
                {
                    MasterGridView.OptionsView.ColumnAutoWidth = false;
                    var hitInfo = MasterGridView.CalcHitInfo(MasterGrid.PointToClient(Control.MousePosition));
                    if (hitInfo.InRowCell)
                    {
                        int rowHandle = hitInfo.RowHandle;
                        DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                        column = hitInfo.Column;
                        column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                    }
                });
                e.Menu.Items.Add(Copy);
                e.Menu.Items.Add(SAR);
                e.Menu.Items.Add(Collapse);
                e.Menu.Items.Add(Expand);
                e.Menu.Items.Add(FixLeft);
                e.Menu.Items.Add(FixRight);
                e.Menu.Items.Add(UnFix);

            }

            catch (Exception ex)

            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
    }
}