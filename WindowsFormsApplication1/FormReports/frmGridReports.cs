using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.FormReports
{
    public partial class FrmGridReports : DevExpress.XtraEditors.XtraForm
    {
        RangeSelector _RangeSelector = new RangeSelector() { StartDate = GlobalVariables.FinYearStartDate, EndDate = GlobalVariables.FinYearEndDate };
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public FrmGridReports()
        {
            InitializeComponent();
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
                DXMenuItem EXPORTTOEXCEL;

                EXPORTTOEXCEL = new DXMenuItem("EXPORT TO EXCEL", (o1, e1) =>
                {
                    xtraSaveFileDialog1.FileName = "SALE.xlsx";
                    xtraSaveFileDialog1.ShowDialog();

                });

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
                e.Menu.Items.Add(EXPORTTOEXCEL);

            }

            catch (Exception ex)

            {
                
            }
        }

        void BtnLoad_Click(object sender, EventArgs e)
        {
            ProjectFunctions.BindReportToGrid(ProjectFunctions.GetDataSet("Select ProgProcName from ProgramMaster Where ProgCode='" + GlobalVariables.ProgCode + "'").Tables[0].Rows[0]["ProgProcName"].ToString(), _RangeSelector.DtFrom.DateTime.Date, _RangeSelector.DtEnd.DateTime.Date, MasterGrid, MasterGridView);
            _RangeSelector.Visible = false;
        }

        private void FrmGridReports_Load(object sender, EventArgs e)
        {
            ProjectFunctions.GirdViewVisualize(MasterGridView);
        }

        private void MasterGrid_DoubleClick(object sender, EventArgs e)
        {
            if (GlobalVariables.ProgCode == "PROG201")
            {
                DataRow currentrow = MasterGridView.GetDataRow(MasterGridView.FocusedRowHandle);

                Transaction.challans.Frm_ChallanOutward frm = new Transaction.challans.Frm_ChallanOutward { S1 = "Edit", Text = "Challan Outward Edition", ImNo = currentrow["CHONO"].ToString(), ImDate = Convert.ToDateTime(currentrow["CHODATE"]) };
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(Parent);
            }

        }

       

        private void XtraSaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MasterGridView.ExportToXlsx(xtraSaveFileDialog1.FileName, new XlsxExportOptionsEx());
        }
    }
}