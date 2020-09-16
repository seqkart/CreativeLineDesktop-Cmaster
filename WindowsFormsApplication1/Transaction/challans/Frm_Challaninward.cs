using SeqKartLibrary;
using System;
using System.Data;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Transaction.challans
{
    public partial class Frm_Challaninward : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String ImNo { get; set; }
        public DateTime ImDate { get; set; }
        DataTable dt = new DataTable();
        DataSet dsPopUps = new DataSet();
        int RowIndex = 0;
        String UpdateTag = "N";
        String ProductFeedTag = "N";

        public Frm_Challaninward()
        {
            InitializeComponent();
            dt.Columns.Add("CHOPrdCode", typeof(String));
            dt.Columns.Add("CHOPrdName", typeof(String));
            dt.Columns.Add("CHOManualDesc", typeof(String));
            dt.Columns.Add("CHOArtNo", typeof(String));
            dt.Columns.Add("CHOArtDesc", typeof(String));
            dt.Columns.Add("CHOArtID", typeof(String));
            dt.Columns.Add("CHOColID", typeof(String));
            dt.Columns.Add("CHOColName", typeof(String));
            dt.Columns.Add("CHOSizeID", typeof(String));
            dt.Columns.Add("CHOSizeName", typeof(String));
            dt.Columns.Add("CHOLotNo", typeof(String));
            dt.Columns.Add("CHOTotQtyKgs", typeof(String));
            dt.Columns.Add("CHOUom", typeof(String));
            dt.Columns.Add("CHORemarks", typeof(String));
            dt.Columns.Add("CHOKgsType", typeof(String));
            dt.Columns.Add("CHOTotQty", typeof(String));

            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadBarPrintPopUps");
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Challaninward_Load(object sender, EventArgs e)
        {

        }

        private void TxtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDebitPartyName.Text = String.Empty;
            txtBillingAddress1.Text = String.Empty;
            txtBillingAddress2.Text = String.Empty;
            txtBillingAddress3.Text = String.Empty;
            txtBillingCity.Text = String.Empty;

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

            DevExpress.XtraGrid.Columns.GridColumn col7 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "STNAME",
                Visible = false
            };
            HelpGridView.Columns.Add(col7);

            DevExpress.XtraGrid.Columns.GridColumn col8 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccZipCode",
                Visible = false
            };
            HelpGridView.Columns.Add(col8);


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
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActMstHelp '" + txtDebitPartyCode.Text.Trim() + "'");//sp_LoadActMstHelpWithCode
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

        private void TxtTransporterCode_EditValueChanged(object sender, EventArgs e)
        {
            txtTransporterName.Text = String.Empty;
        }
        private bool ValidateDataForSaving()
        {
            try

            {
                if (BarCodeGrid.DataSource == null)
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

                if (HelpGrid.Text == "CHOPrdName")
                {
                    DataRow dtNewRow = dt.NewRow();
                    dtNewRow["CHOPrdCode"] = row["PrdCode"].ToString();
                    dtNewRow["CHOPrdName"] = row["PrdName"].ToString();

                    dt.Rows.Add(dtNewRow);
                    if (dt.Rows.Count > 0)
                    {
                        BarCodeGrid.DataSource = dt;
                        BarCodeGridView.BestFitColumns();
                    }
                    panelControl1.Visible = false;
                    BarCodeGridView.Focus();
                    BarCodeGridView.MoveLast();
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOManualDesc"];
                    txtSearchBox.Text = String.Empty;

                    if (BarCodeGridView.FocusedColumn.FieldName == "CHOManualDesc")
                    {
                        BarCodeGridView.ShowEditor();
                    }


                    ProductFeedTag = "Y";
                }
                if (HelpGrid.Text == "CHOArtNo")
                {
                    if (ProductFeedTag == "N")
                    {
                        DataRow dtNewRow = dt.NewRow();
                        dtNewRow["CHOArtNo"] = row["ARTNO"].ToString();
                        dtNewRow["CHOArtDesc"] = row["ARTDESC"].ToString();
                        dtNewRow["CHOArtID"] = row["ARTSYSID"].ToString();
                        dt.Rows.Add(dtNewRow);
                        if (dt.Rows.Count > 0)
                        {
                            BarCodeGrid.DataSource = dt;
                            BarCodeGridView.BestFitColumns();
                        }
                        panelControl1.Visible = false;
                        BarCodeGridView.Focus();
                        BarCodeGridView.MoveLast();
                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOColName"];
                        txtSearchBox.Text = String.Empty;
                    }
                    else
                    {
                        BarCodeGridView.UpdateCurrentRow();
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOArtNo"], row["ARTNO"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOArtDesc"], row["ARTDESC"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOArtID"], row["ARTSYSID"].ToString());
                        BarCodeGridView.Focus();
                        panelControl1.Visible = false;
                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOColName"];
                        BarCodeGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = String.Empty;
                        dt.AcceptChanges();
                        ProductFeedTag = "N";
                    }



                }


                if (HelpGrid.Text == "CHOColName")
                {
                    BarCodeGridView.UpdateCurrentRow();
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOColID"], row["COLSYSID"].ToString());
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOColName"], row["COLNAME"].ToString());
                    BarCodeGridView.Focus();
                    panelControl1.Visible = false;
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOSizeName"];
                    BarCodeGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = String.Empty;
                    dt.AcceptChanges();
                }
                if (HelpGrid.Text == "CHOSizeName")
                {

                    UpdateTag = "N";
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOSizeID"], row["SZSYSID"].ToString());
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["CHOSizeName"], row["SZNAME"].ToString());
                    panelControl1.Visible = false;
                    BarCodeGridView.Focus();
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOLotNo"];
                    BarCodeGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = String.Empty;
                    dt.AcceptChanges();
                    BarCodeGridView.ShowEditor();
                }
            }
        }

        private void BarCodeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                HelpGridView.Columns.Clear();
                DataRow currentrow = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);

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

                                        if (BarCodeGridView.FocusedColumn.FieldName == "CHOPrdName")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "CHOPrdName";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from PrdMst where PrdCode='" + ProjectFunctions.CheckNull(currentrow["CHOPrdCode"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "CHOPrdName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "CHOPrdName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (BarCodeGridView.FocusedColumn.FieldName == "CHOArtNo")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "CHOArtNo";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + ProjectFunctions.CheckNull(currentrow["CHOArtNo"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "CHOArtNo";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "CHOArtNo";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (BarCodeGridView.FocusedColumn.FieldName == "CHOColName")
                                        {

                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "CHOColName";
                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from COLOURS where COLSYSID='" + ProjectFunctions.CheckNull(currentrow["CHOColID"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "CHOColName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "CHOColName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }

                                        if (BarCodeGridView.FocusedColumn.FieldName == "CHOSizeName")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "CHOSizeName";
                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;


                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SIZEMAST where SZSYSID='" + ProjectFunctions.CheckNull(currentrow["CHOSizeID"].ToString()) + "' ORDER BY SZINDEX,SZSYSID");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "CHOSizeName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "CHOSizeName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl1.Visible = true;
                                                    panelControl1.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;

                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
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


                ProjectFunctions.DeleteCurrentRowOnKeyDown(BarCodeGrid, BarCodeGridView, e);

                if (BarCodeGridView.FocusedColumn.FieldName == "CHOTotQtyKgs" || BarCodeGridView.FocusedColumn.FieldName == "CHOLotNo" || BarCodeGridView.FocusedColumn.FieldName == "CHOTotQtyKgs" || BarCodeGridView.FocusedColumn.FieldName == "CHOTotQty")
                {
                    BarCodeGridView.ShowEditor();
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

                HelpGrid.Show();
                if (HelpGrid.Text == "CHOPrdName")
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
                if (HelpGrid.Text == "CHOArtNo")
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
                if (HelpGrid.Text == "CHOColName")
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
                if (HelpGrid.Text == "CHOSizeName")
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

            }
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}