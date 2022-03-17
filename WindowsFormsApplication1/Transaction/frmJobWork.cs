using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmJobWork : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }

        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        DataTable dtColors = new DataTable();

        DataSet dsPopUps = new DataSet();

        string ColumnName = "";

        int RowIndex = 0;
        string UpdateTag = "N";
        public FrmJobWork()
        {
            InitializeComponent();
            dsPopUps = ProjectFunctions.GetDataSet("[sp_LoadBarPrintPopUps2]");

        }

        private void LoadProductionOrderColorAndSize()
        {
            try
            {
                DataTable dsProductionOrder = new DataTable();
                dsProductionOrder.Columns.Add("COLSYSID", typeof(Int64));
                dsProductionOrder.Columns.Add("COLNAME", typeof(string));
                OrderGridView.Columns.Clear();



                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadProductionOrderColorAndSize '" + txtArtID.Text + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dsProductionOrder.Columns.Add(dr["SZDESC"].ToString().Trim());
                    }
                    int Count = 0;

                    OrderGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                    OrderGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                    OrderGridView.Columns[Count].Visible = true;
                    OrderGridView.Columns[Count].Caption = "COLSYSID";
                    OrderGridView.Columns[Count].FieldName = "COLSYSID";

                    Count++;

                    OrderGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                    OrderGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                    OrderGridView.Columns[Count].Visible = true;
                    OrderGridView.Columns[Count].Caption = "COLNAME";
                    OrderGridView.Columns[Count].FieldName = "COLNAME";



                    Count++;

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        OrderGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        OrderGridView.Columns[Count].OptionsColumn.AllowEdit = true;
                        OrderGridView.Columns[Count].Visible = true;
                        OrderGridView.Columns[Count].Caption = dr["SZDESC"].ToString();
                        OrderGridView.Columns[Count].FieldName = dr["SZSYSID"].ToString();
                        Count++;
                    }
                    if (dsProductionOrder.Rows.Count > 0)
                    {
                        OrderGrid.DataSource = dsProductionOrder;
                        OrderGridView.BestFitColumns();
                    }
                    else
                    {
                        OrderGrid.DataSource = null;
                        OrderGridView.BestFitColumns();
                    }
                }
            }
            catch(Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtPartyName.Text = string.Empty;
        }

        private void TxtArtNo_EditValueChanged(object sender, EventArgs e)
        {
            txtArtID.Text = string.Empty;
            txtArtDesc.Text = string.Empty;
        }

        private void FrmJobWork_Load(object sender, EventArgs e)
        {
            try
            {
                panelControl1.Visible = false;
                ProjectFunctions.TextBoxVisualize(groupControl1);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

                // LoadProductionOrderColorAndSize();
                txtSeason.Properties.Items.Clear();
                DataSet dsSeason = ProjectFunctions.GetDataSet("Select SeasonName from SeasonMst");
                if (dsSeason.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsSeason.Tables[0].Rows)
                    {
                        txtSeason.Properties.Items.Add(dr["SeasonName"].ToString());
                    }
                }

                if (S1 == "&Add")
                {
                    txtOrderDate.EditValue = DateTime.Now;
                    txtOrderDate.Select();
                }
                if (S1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadProductionOrderMstFEdit '" + OrderNo + "','" + OrderDate.Date.ToString("yyyy-MM-dd") + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtOrderNo.Text = ds.Tables[0].Rows[0]["OrderNo"].ToString();
                        txtOrderDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["OrderDate"]);
                        txtPartyCode.Text = ds.Tables[0].Rows[0]["PartyCode"].ToString();
                        txtPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                        txtArtID.Text = ds.Tables[0].Rows[0]["ArtID"].ToString();
                        txtArtNo.Text = ds.Tables[0].Rows[0]["ARTNO"].ToString();
                        txtArtDesc.Text = ds.Tables[0].Rows[0]["ARTALIAS"].ToString();
                        txtBrandCode.Text = ds.Tables[0].Rows[0]["BrandCode"].ToString();
                        txtBrandName.Text = ds.Tables[0].Rows[0]["BRNAME"].ToString();
                        txtSeason.Text = ds.Tables[0].Rows[0]["Season"].ToString();
                        txtSampleSize.Text = ds.Tables[0].Rows[0]["SampleSize"].ToString();
                        txtSampleWeight.Text = ds.Tables[0].Rows[0]["SampleWeight"].ToString();
                        txtSampleType.Text = ds.Tables[0].Rows[0]["SampleType"].ToString();
                        txtKnitCut.Text = ds.Tables[0].Rows[0]["KnitCut"].ToString();
                        txtFitType.Text = ds.Tables[0].Rows[0]["FitType"].ToString();
                        txtRemarks.Text = ds.Tables[0].Rows[0]["Remarks"].ToString();
                        txtPartyCode.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

            private void TxtArtNo_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "txtArtNo";
                if (txtArtNo.Text.Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode ");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGridView.BestFitColumns();
                        HelpGrid.Show();
                        HelpGrid.Focus();
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode Where ARTICLE.ARTNO='" + txtArtNo.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtArtNo.Text = ds.Tables[0].Rows[0]["ARTNO"].ToString();
                        txtArtID.Text = ds.Tables[0].Rows[0]["ARTSYSID"].ToString();
                        txtArtDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();
                        LoadProductionOrderColorAndSize();
                        txtSampleSize.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("SELECT ARTICLE.ARTSYSID, ARTICLE.ARTNO, ARTICLE.ARTNAME,  GrpMst.GrpSubDesc  FROM     ARTICLE INNER JOIN GrpMst ON ARTICLE.ARTSECTIONID = GrpMst.GrpCode AND ARTICLE.ARTSBSECTIONID = GrpMst.GrpSubCode ");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds1.Tables[0];
                            HelpGridView.BestFitColumns();
                            HelpGrid.Show();
                            HelpGrid.Focus();
                        }
                    }
                }
            }
            e.Handled = true;
        }

        private void HelpGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                HelpGrid.Visible = false;
            }
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow currentrow = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
                if (HelpGrid.Text == "txtArtNo")
                {
                    txtArtNo.Text = currentrow["ARTNO"].ToString();
                    txtArtID.Text = currentrow["ARTSYSID"].ToString();
                    txtArtDesc.Text = currentrow["GrpSubDesc"].ToString();
                    LoadProductionOrderColorAndSize();
                    HelpGrid.Visible = false;
                    txtSampleSize.Focus();
                }
                if (HelpGrid.Text == "txtBrandCode")
                {
                    txtBrandCode.Text = currentrow["BRSYSID"].ToString();
                    txtBrandName.Text = currentrow["BRNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtSampleType.Focus();
                }
                if (HelpGrid.Text == "txtPartyCode")
                {
                    txtPartyCode.Text = currentrow["AccCode"].ToString();
                    txtPartyName.Text = currentrow["AccName"].ToString();
                    HelpGrid.Visible = false;
                    txtSeason.Focus();
                }
                if (HelpGrid.Text == "COLOR")
                {
                    DataTable dtColor = new DataTable();
                    dtColor.Columns.Add("COLSYSID", typeof(string));
                    dtColor.Columns.Add("COLNAME", typeof(string));
                    foreach (DataRow dr in (HelpGrid.DataSource as DataTable).Rows)
                    {
                        if (dr["Select"].ToString().ToUpper() == "TRUE")
                        {
                            DataRow drNewRow = dtColor.NewRow();
                            drNewRow["COLSYSID"] = dr["COLSYSID"].ToString();
                            drNewRow["COLNAME"] = dr["COLNAME"].ToString();
                            dtColor.Rows.Add(drNewRow);
                        }
                    }

                    if (dtColor.Rows.Count > 0)
                    {
                        ColorGrid.DataSource = dtColor;
                        ColorGridView.BestFitColumns();
                    }
                    else
                    {
                        ColorGrid.DataSource = null;
                        ColorGridView.BestFitColumns();
                    }
                    HelpGrid.Visible = false;
                }

                if (HelpGrid.Text == "SIZE")
                {
                    DataTable dtSize = new DataTable();
                    dtSize.Columns.Add("COMBO", typeof(string));

                    DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn();
                    col1.FieldName = "COMBO";
                    col1.Caption = "COMBO";
                    col1.Visible = true;
                    col1.OptionsColumn.AllowEdit = false;
                    SizeGridView.Columns.Add(col1);
                    foreach (DataRow dr in (HelpGrid.DataSource as DataTable).Rows)
                    {
                        if (dr["Select"].ToString().ToUpper() == "TRUE")
                        {
                            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
                            col2.FieldName = dr["SZSYSID"].ToString();
                            col2.Caption = dr["SZDESC"].ToString();
                            col2.Visible = true;
                            col2.OptionsColumn.AllowEdit = true;
                            SizeGridView.Columns.Add(col2);

                            dtSize.Columns.Add(dr["SZSYSID"].ToString(), typeof(string));
                        }
                    }

                    foreach (GridColumn col in ColorGridView.Columns)
                    {
                        DataRow drNewRow = dtSize.NewRow();
                        drNewRow["COMBO"] = col.FieldName.ToString();
                        dtSize.Rows.Add(drNewRow);
                    }

                    if (dtSize.Rows.Count > 0)
                    {
                        SizeGrid.DataSource = dtSize;
                        SizeGridView.BestFitColumns();
                    }
                    else
                    {
                        SizeGrid.DataSource = null;
                        SizeGridView.BestFitColumns();
                    }
                    HelpGrid.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtBrandCode_EditValueChanged(object sender, EventArgs e)
        {
            txtBrandName.Text = string.Empty;
        }
        private void PrepareBrandMstHelpGrid()
        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            col1.FieldName = "BRNAME";
            col1.Caption = "BRNAME";
            col1.Visible = true;
            col1.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col1);

            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            col1.FieldName = "BRSYSID";
            col1.Caption = "BRSYSID";
            col1.Visible = true;
            col1.OptionsColumn.AllowEdit = false;
            HelpGridView.Columns.Add(col2);

        }
        private void TxtBrandCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("select BRSYSID,BRNAME from BRANDS", " Where BRSYSID", txtBrandCode, txtBrandName, txtSampleType, HelpGrid, HelpGridView, e);
        }

        private void TxtOrderDate_EditValueChanged(object sender, EventArgs e)
        {
            LoadProductionOrderColorAndSize();
        }

        private void TxtPartyCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select AccName,AccCode from ActMst ", " Where AccCode", txtPartyCode, txtPartyName, txtSeason, HelpGrid, HelpGridView, e);
        }

        private void TxtSampleWeight_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void TxtArtDesc_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void PrepareActMstHelpGrid()
        {
            try
            {
                HelpGridView.Columns.Clear();
                DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn();
                col1.FieldName = "AccName";
                col1.Caption = "AccName";
                col1.Visible = true;
                col1.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col1);

                DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
                col1.FieldName = "AccCode";
                col1.Caption = "AccCode";
                col1.Visible = true;
                col1.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col2);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void PrepareColorMstHelpGrid()
        {
            try
            {
                HelpGridView.Columns.Clear();
                DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn();
                col1.FieldName = "COLSYSID";
                col1.Caption = "COLSYSID";
                col1.Visible = true;
                col1.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col1);

                DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
                col2.FieldName = "COLNAME";
                col2.Caption = "COLNAME";
                col2.Visible = true;
                col2.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col2);

                DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn();
                col3.FieldName = "Select";
                col3.Caption = "Select";
                col3.Visible = true;
                col3.OptionsColumn.AllowEdit = true;
                HelpGridView.Columns.Add(col3);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }
        private void BtnLoadColors_Click(object sender, EventArgs e)
        {
            try
            {
                HelpGrid.Text = "COLOR";
                PrepareColorMstHelpGrid();
                DataSet dsColors = ProjectFunctions.GetDataSet("select COLSYSID,COLNAME from COLOURS order by COLNAME");
                if (dsColors.Tables[0].Rows.Count > 0)
                {
                    dsColors.Tables[0].Columns.Add("Select", typeof(bool));
                    foreach (DataRow dr in dsColors.Tables[0].Rows)
                    {
                        dr["Select"] = false;
                    }

                    HelpGrid.DataSource = dsColors.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Visible = true;
                    HelpGrid.Focus();
                }
                else
                {
                    ProjectFunctions.SpeakError("No Color To Load");
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void PrepareSizeMstHelpGrid()
        {
            try
            {
                HelpGridView.Columns.Clear();
                DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn();
                col1.FieldName = "SZSYSID";
                col1.Caption = "SZSYSID";
                col1.Visible = true;
                col1.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col1);

                DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
                col2.FieldName = "SZDESC";
                col2.Caption = "SZDESC";
                col2.Visible = true;
                col2.OptionsColumn.AllowEdit = false;
                HelpGridView.Columns.Add(col2);

                DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn();
                col3.FieldName = "Select";
                col3.Caption = "Select";
                col3.Visible = true;
                col3.OptionsColumn.AllowEdit = true;
                HelpGridView.Columns.Add(col3);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }
        private void BtnLoadSizes_Click(object sender, EventArgs e)
        {
            try
            {
                HelpGrid.Text = "SIZE";
                PrepareSizeMstHelpGrid();
                DataSet dsSize = ProjectFunctions.GetDataSet("select SZSYSID,SZDESC from SIZEMAST order by SZDESC");
                if (dsSize.Tables[0].Rows.Count > 0)
                {
                    dsSize.Tables[0].Columns.Add("Select", typeof(bool));
                    foreach (DataRow dr in dsSize.Tables[0].Rows)
                    {
                        dr["Select"] = false;
                    }

                    HelpGrid.DataSource = dsSize.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Visible = true;
                    HelpGrid.Focus();
                }
                else
                {
                    ProjectFunctions.SpeakError("No Color To Load");
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtComboCount_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            { 
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    int MaxCols = Convert.ToInt32(txtComboCount.Text);
                    for (int i = 0; i < MaxCols; i++)
                    {
                        DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn();
                        col2.FieldName = "CB" + (i + 1).ToString();
                        col2.Caption = "CB" + (i + 1).ToString();
                        col2.Visible = true;
                        col2.OptionsColumn.AllowEdit = false;
                        ColorGridView.Columns.Add(col2);
                        dtColors.Columns.Add("CB" + (i + 1).ToString(), typeof(string));
                    }

                    ColorGrid.DataSource = dtColors;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtComboCount_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ProjectFunctions.NumberOnly(e);
        }

        private void ColorGridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                HelpGridControlView.Columns.Clear();
                DataRow currentrow = ColorGridView.GetDataRow(ColorGridView.FocusedRowHandle);
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
                                        if (ColorGridView.FocusedColumn.FieldName == "CB1"|| ColorGridView.FocusedColumn.FieldName == "CB2"|| ColorGridView.FocusedColumn.FieldName == "CB3"|| ColorGridView.FocusedColumn.FieldName == "CB4"|| ColorGridView.FocusedColumn.FieldName == "CB5"|| ColorGridView.FocusedColumn.FieldName == "CB6"|| ColorGridView.FocusedColumn.FieldName == "CB7"|| ColorGridView.FocusedColumn.FieldName == "CB8"|| ColorGridView.FocusedColumn.FieldName == "CB9"|| ColorGridView.FocusedColumn.FieldName == "CB10"|| ColorGridView.FocusedColumn.FieldName == "CB11"|| ColorGridView.FocusedColumn.FieldName == "CB12"|| ColorGridView.FocusedColumn.FieldName == "CB13"|| ColorGridView.FocusedColumn.FieldName == "CB14"|| ColorGridView.FocusedColumn.FieldName == "CB15"|| ColorGridView.FocusedColumn.FieldName == "CB16"|| ColorGridView.FocusedColumn.FieldName == "CB17"|| ColorGridView.FocusedColumn.FieldName == "CB18")
                                        {
                                            ColumnName= ColorGridView.FocusedColumn.FieldName;
                                            if (currentrow == null)
                                            {
                                                HelpGridControl.Text = "COLNAME";
                                                txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from COLOURS where COLNAME='" + ProjectFunctions.CheckNull(currentrow[ColumnName].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";
                                                    HelpGridControl.Text = "COLNAME";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = ColorGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGridControl.Text = "COLNAME";
                                                    txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = ColorGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        dtColors.AcceptChanges();
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

        private void HelpGridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow row = HelpGridControlView.GetDataRow(HelpGridControlView.FocusedRowHandle);
                dtColors.AcceptChanges();

                if (HelpGridControl.Text == "COLNAME")
                {
                    if (ColumnName == "CB1")
                    {
                        DataRow dtNewRow = dtColors.NewRow();
                        dtNewRow["CB1"] = row["COLNAME"].ToString();

                        dtColors.Rows.Add(dtNewRow);
                        if (dtColors.Rows.Count > 0)
                        {
                            ColorGrid.DataSource = dtColors;
                            ColorGrid.DataSource = dtColors;
                            ColorGridView.BestFitColumns();
                        }

                        UpdateTag = "N";
                        panelControl1.Visible = false;
                        ColorGridView.Focus();
                        ColorGridView.MoveLast();
                        ColorGridView.FocusedColumn = ColorGridView.Columns["CB1"];
                        txtSearchBox.Text = string.Empty;
                    }
                    else
                    {

                        ColorGridView.UpdateCurrentRow();
                        UpdateTag = "N";
                        ColorGridView.SetRowCellValue(RowIndex, ColorGridView.Columns[ColumnName], row["COLNAME"].ToString());
                        //ColorGridView.SetRowCellValue(RowIndex, ColorGridView.Columns[ColumnName], row["COLSYSID"].ToString());
                        ColorGridView.Focus();
                        panelControl1.Visible = false;
                        ColorGridView.FocusedColumn = ColorGridView.Columns[ColumnName];
                        ColorGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = string.Empty;
                        dtColors.AcceptChanges();
                    }
                }
            }

            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void HelpGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            try

            {
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGridControl_DoubleClick(null, e);
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

        private void TxtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow currentrow = HelpGridControlView.GetDataRow(HelpGridControlView.FocusedRowHandle);
                HelpGridControl.Show();
                if (HelpGridControl.Text == "COLNAME")
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
                        HelpGridControl.DataSource = dtNew;
                        HelpGridControlView.BestFitColumns();
                    }
                    else
                    {
                        HelpGridControl.DataSource = null;
                        HelpGridControlView.BestFitColumns();
                    }
                }
                
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
                HelpGridControlView.CloseEditor();
                HelpGridControlView.UpdateCurrentRow();
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGridControl_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Down)
                {
                    HelpGridControl.Focus();
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

        private void SizeGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                var formatRulesMenu = new DXPopupMenu();
                var view = sender as GridView;

                DXMenuItem Copy;
                DXMenuItem Paste;
               
                DataRow CurrentRow = SizeGridView.GetDataRow(SizeGridView.FocusedRowHandle);
                
                Copy = new DXMenuItem("Copy",
                                      (o1, e1) =>
                                      {
                                          view.OptionsSelection.MultiSelect = true;
                                          view.CopyToClipboard();
                                      });

                Paste = new DXMenuItem("Paste",
                                          (o1, e1) =>
                                          {
                                              //foreach (int row in view.GetSelectedRows())
                                              //{
                                              //    view.SetRowCellValue(row, view.Columns["Category"], barEditItem1.EditValue);
                                              //}


                                          });

                e.Menu.Items.Add(Copy);
                e.Menu.Items.Add(Paste);
               
            }
            catch (Exception ex)

            {
                MessageBox_Debug.ShowBox(ex);
            }
        }

        private void LoadColorComboData()
        {
            dtColors.Columns.Clear();
            DataSet dsCombo=   ProjectFunctions.GetDataSet("Select Distinct ComboName from ProductionOrderComboMst Where OrderNo='" + txtOrderNo.Text + "'");
            foreach(DataRow dr in dsCombo.Tables[0].Rows)
            {
                dtColors.Columns.Add(dr["ComboName"].ToString(), typeof(String));
            }

            
        }
        private void SaveColorComboData()
        {
            ProjectFunctions.GetDataSet("Delete From ProductionOrderComboMst Where OrderNo='" + txtOrderNo.Text + "' And OrderDate ='" + Convert.ToDateTime(txtOrderDate.Text).ToString("yyyy-MM-dd") + "'");
            foreach (DataRow drRow in (ColorGrid.DataSource as DataTable).Rows)
            {
                foreach(DataColumn drColumn in (ColorGrid.DataSource as DataTable).Columns)
                {
                    String ColorID = ProjectFunctions.GetDataSet("select distinct COLSYSID from COLOURS WHERE COLNAME='" + drRow[drColumn.ColumnName] + "' ").Tables[0].Rows[0][0].ToString();
                    String Query = "Insert into ProductionOrderComboMst(OrderNo,OrderDate,ComboName,ColorID)values('" + txtOrderNo.Text + "','" + Convert.ToDateTime(txtOrderDate.Text).ToString("yyyy-MM-dd") + "','" + drColumn.ColumnName + "','" + ColorID + "')";
                    ProjectFunctions.GetDataSet(Query);
                }
            }

        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateDataForSaving()
        {
            if(txtSampleWeight.Text.Trim().Length>0)
            {
                txtSampleWeight.Text = "0";
            }
            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataForSaving())
            {
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {

                    //var MaxRow = (InfoGrid.FocusedView as GridView).RowCount;
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    sqlcom.Connection = sqlcon;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        if (S1 == "&Add")
                        {
                            string BillNo = string.Empty;

                            BillNo = ProjectFunctions.GetDataSet("select isnull(max(OrderNo),0)+1 from ProductionOrderMst ").Tables[0].Rows[0][0].ToString();


                            sqlcom.CommandText = "Insert into ProductionOrderMst(OrderNo,OrderDate,PartyCode,ArtID,Season,SampleSize,SampleWeight," +
                                "BrandCode,SampleType,KnitCut,FitType,Remarks)values(" +
                                "@OrderNo,@OrderDate,@PartyCode,@ArtID,@Season,@SampleSize,@SampleWeight," +
                                "@BrandCode,@SampleType,@KnitCut,@FitType,@Remarks)";
                            sqlcom.Parameters.Add("@OrderNo", SqlDbType.NVarChar).Value = BillNo;
                            sqlcom.Parameters.Add("@OrderDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtOrderDate.Text).ToString("yyyy-MM-dd HH:mm:ss");
                            sqlcom.Parameters.Add("@PartyCode", SqlDbType.NVarChar).Value = txtPartyCode.Text;
                            sqlcom.Parameters.Add("@ArtID", SqlDbType.NVarChar).Value = txtArtID.Text;
                            sqlcom.Parameters.Add("@Season", SqlDbType.NVarChar).Value = txtSeason.Text;
                            sqlcom.Parameters.Add("@SampleSize", SqlDbType.NVarChar).Value = txtSampleSize.Text.Trim();
                            sqlcom.Parameters.Add("@SampleWeight", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtSampleWeight.Text);
                            sqlcom.Parameters.Add("@BrandCode", SqlDbType.NVarChar).Value = txtBrandCode.Text.Trim();
                            sqlcom.Parameters.Add("@SampleType", SqlDbType.NVarChar).Value = txtSampleType.Text.Trim();
                            sqlcom.Parameters.Add("@KnitCut", SqlDbType.NVarChar).Value = txtKnitCut.Text.Trim();
                            sqlcom.Parameters.Add("@FitType", SqlDbType.NVarChar).Value = txtFitType.Text.Trim();
                            sqlcom.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text.Trim();
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = "Update ProductionOrderMst Set PartyCode=@PartyCode,ArtID=@ArtID,Season=@Season,SampleSize=@SampleSize,SampleWeight=@SampleWeight,BrandCode=@BrandCode," +
                                "SampleType=@SampleType,KnitCut=@KnitCut,FitType=@FitType,Remarks=@Remarks Where OrderDate=@OrderDate And OrderNo=@OrderNo";

                            sqlcom.Parameters.Add("@OrderNo", SqlDbType.NVarChar).Value = txtOrderNo.Text;
                            sqlcom.Parameters.Add("@OrderDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtOrderDate.Text).ToString("yyyy-MM-dd HH:mm:ss");
                            sqlcom.Parameters.Add("@PartyCode", SqlDbType.NVarChar).Value = txtPartyCode.Text;
                            sqlcom.Parameters.Add("@ArtID", SqlDbType.NVarChar).Value = txtArtID.Text;
                            sqlcom.Parameters.Add("@Season", SqlDbType.NVarChar).Value = txtSeason.Text;
                            sqlcom.Parameters.Add("@SampleSize", SqlDbType.NVarChar).Value = txtSampleSize.Text.Trim();
                            sqlcom.Parameters.Add("@SampleWeight", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtSampleWeight.Text);
                            sqlcom.Parameters.Add("@BrandCode", SqlDbType.NVarChar).Value = txtBrandCode.Text.Trim();
                            sqlcom.Parameters.Add("@SampleType", SqlDbType.NVarChar).Value = txtSampleType.Text.Trim();
                            sqlcom.Parameters.Add("@KnitCut", SqlDbType.NVarChar).Value = txtKnitCut.Text.Trim();
                            sqlcom.Parameters.Add("@FitType", SqlDbType.NVarChar).Value = txtFitType.Text.Trim();
                            sqlcom.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text.Trim();
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                        }


                        SaveColorComboData();
                        ProjectFunctions.SpeakError("Invoice Data Saved Successfully");
                        sqlcon.Close();

                        Close();
                    }

                    catch (Exception ex)

                    {
                        ProjectFunctions.SpeakError(ex.Message);
                        Close();
                    }
                }
            }
        }
    }
}