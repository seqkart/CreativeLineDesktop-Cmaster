using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Transaction.challans
{
    public partial class Frm_Challaninward : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string ImNo { get; set; }
        public DateTime ImDate { get; set; }
        DataTable dt = new DataTable();
        DataSet dsPopUps = new DataSet();
        int RowIndex = 0;
        string UpdateTag = "N";
        string ProductFeedTag = "N";



        public Frm_Challaninward()
        {


            InitializeComponent();
            dt.Columns.Add("AgnstChallanType", typeof(string));
            dt.Columns.Add("AgnstChallanNo", typeof(string));
            dt.Columns.Add("PrdCode", typeof(string));
            dt.Columns.Add("PrdName", typeof(string));
            dt.Columns.Add("ARTNO", typeof(string));
            dt.Columns.Add("ARTDESC", typeof(string));
            dt.Columns.Add("ARTID", typeof(string));
            dt.Columns.Add("IssuedQty", typeof(decimal));
            dt.Columns.Add("IssuedQtyInKgs", typeof(decimal));
            dt.Columns.Add("UomCode", typeof(string));
            dt.Columns.Add("UomDesc", typeof(string));
            dt.Columns.Add("Bal", typeof(decimal));
            dt.Columns.Add("ReceivedQty", typeof(decimal));
            dt.Columns.Add("ReceivedQtyInKgs", typeof(decimal));
            dt.Columns.Add("WastageQty", typeof(decimal));
            dt.Columns.Add("WastageQtyInKgs", typeof(decimal));
            dt.Columns.Add("ProcessCode", typeof(string));
            dt.Columns.Add("ProcessName", typeof(string));
            dt.Columns.Add("Rate", typeof(decimal));
            dt.Columns.Add("CalculationType", typeof(string));
            dt.Columns.Add("CalcAmount", typeof(decimal));
            dt.Columns.Add("Remarks", typeof(string));
            dt.Columns.Add("ActualQty", typeof(decimal));
            dt.Columns.Add("ActualQtyInKgs", typeof(decimal));
            dt.Columns.Add("TransID", typeof(decimal));


            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadBarPrintPopUps");
        }

       
        private void GetOurwardData()
        {
            DataSet ds = ProjectFunctions.GetDataSet("select CHOTYPE,CHONO,CHODATE from CHOUTMain Where CHOPARTYCODE='" + txtDebitPartyCode.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("Select", typeof(bool));
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }
                ChallanGrid.DataSource = ds.Tables[0];
                ChallanGridView.BestFitColumns();
            }
            else
            {
                ChallanGrid.DataSource = null;
                ChallanGridView.BestFitColumns();
            }
        }


        private void GetOurwardDataFProcess()
        {
            dt.Clear();
            ChallanGridView.CloseEditor();
            ChallanGridView.UpdateCurrentRow();
            foreach (DataRow drchallan in (ChallanGrid.DataSource as DataTable).Rows)
            {
                if (drchallan["Select"].ToString().ToUpper() == "TRUE")
                {
                    
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadChallanDataFProcess '" + drchallan["CHOTYPE"].ToString() + "','" + drchallan["CHONO"].ToString() + "','" + Convert.ToDateTime(drchallan["CHODATE"]).ToString("yyyy-MM-dd") + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            dt.ImportRow(dr);

                        }
                    }
                }
            }
            if(dt.Rows.Count>0)
            { 

                BarCodeGrid.DataSource = dt;
                BarCodeGridView.BestFitColumns();
            }
            else
            {
                BarCodeGrid.DataSource = null;
                BarCodeGridView.BestFitColumns();
            }
        }

        private void Frm_Challaninward_Load(object sender, EventArgs e)
        {

            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(groupControl1);
            if (S1 == "&Add")
            {
               
                txtTransDate.EditValue = DateTime.Now;
                txtReceivingDate.EditValue = DateTime.Now;
                txtGateEntryNo.Focus();
            }
            if (S1 == "Edit")
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadCHINDataFEdit '" + ImNo + "','" + ImDate.Date.ToString("yyyy-MM-dd") + "','"+GlobalVariables.CUnitID+"'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDocNo.Text = ds.Tables[0].Rows[0]["DocNo"].ToString();
                    txtDocDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["DocDate"]);
                    txtGateEntryNo.Text = ds.Tables[0].Rows[0]["CHIGateEntryNo"].ToString();
                    txtTransNo.Text = ds.Tables[0].Rows[0]["CHINO"].ToString();
                    txtDocType.Text = ds.Tables[0].Rows[0]["CHITYPE"].ToString();
                    txtTransDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["CHIDATE"]);
                    txtReceivingDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["CHIReceiveDate"]);
                    txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["CHIPARTYCODE"].ToString();
                    txtRemarks.Text = ds.Tables[0].Rows[0]["CHOREMARKS"].ToString();
                    txtTransporterCode.Text = ds.Tables[0].Rows[0]["CHOTRPID"].ToString();
                    txtTransporterName.Text = ds.Tables[0].Rows[0]["TrpName"].ToString();
                    txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                    txtBillingAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                    txtBillingAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                    txtBillingAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                    txtContactDetails.Text = ds.Tables[0].Rows[0]["AccTeleFax"].ToString();

                    txtBillingCity.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();

                    if(ds.Tables[1].Rows.Count>0)
                    {
                        dt = ds.Tables[1];
                        BarCodeGrid.DataSource = dt;
                        BarCodeGridView.BestFitColumns();
                        GetOurwardData();

                    }
                    else
                    {
                        BarCodeGrid.DataSource = null;
                        BarCodeGridView.BestFitColumns();
                    }

                }
            }
        }

        private void TxtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDebitPartyName.Text = string.Empty;
            txtBillingAddress1.Text = string.Empty;
            txtBillingAddress2.Text = string.Empty;
            txtBillingAddress3.Text = string.Empty;
            txtBillingCity.Text = string.Empty;

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
            if (e.KeyCode != Keys.Back)
            {
                if (e.KeyCode != Keys.Delete)
                {
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
                                            PrepareActMstHelpGrid();
                                            HelpGrid.Text = "txtDebitPartyCode";
                                            txtSearchBox.Text = string.Empty;
                                            txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                            HelpGrid.Show();
                                            panelControl2.Visible = true;
                                            HelpGrid.Visible = true;

                                            txtSearchBox.Focus();
                                            txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                            txtSearchBox.SelectionLength = 0;
                                            txtDebitPartyCode.Text = string.Empty;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //e.Handled = true;

        }

        private void TxtTransporterCode_EditValueChanged(object sender, EventArgs e)
        {
            txtTransporterName.Text = string.Empty;
        }
        private void TxtTransporterCode_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode != Keys.Back)
            {
                if (e.KeyCode != Keys.Delete)
                {
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

                                            HelpGrid.Text = "txtTransporterCode";
                                            HelpGridView.Columns.Clear();
                                            txtSearchBox.Text = string.Empty;
                                            txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                            HelpGrid.Show();
                                            panelControl2.Visible = true;
                                            HelpGrid.Visible = true;

                                            txtSearchBox.Focus();
                                            txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                            txtSearchBox.SelectionLength = 0;

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            e.Handled = true;
            //if (e.KeyCode == Keys.Enter)
            //{

            //    HelpGridView.Columns.Clear();
            //    HelpGrid.Text = "txtTransporterCode";
            //    if (txtTransporterCode.Text.Trim().Length == 0)
            //    {
            //        DataSet ds = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            HelpGrid.DataSource = ds.Tables[0];
            //            HelpGrid.Show();
            //            panelControl1.Visible = true;
            //            HelpGrid.Visible = true;
            //            HelpGrid.Focus();
            //            HelpGridView.BestFitColumns();
            //        }
            //        else
            //        {
            //            ProjectFunctions.SpeakError("No Records To Display");
            //        }
            //    }
            //    else
            //    {
            //        DataSet ds = ProjectFunctions.GetDataSet(" select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER Where  TRPRSYSID='" + txtTransporterCode.Text.Trim() + "'");
            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            txtTransporterCode.Text = ds.Tables[0].Rows[0]["TRPRSYSID"].ToString();
            //            txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();

            //            txtTransporterCode.Focus();
            //            panelControl1.Visible = false;
            //        }

            //        else
            //        {
            //            DataSet ds1 = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
            //            if (ds1.Tables[0].Rows.Count > 0)
            //            {
            //                HelpGrid.DataSource = ds.Tables[0];
            //                HelpGrid.Show();
            //                panelControl1.Visible = true;
            //                HelpGrid.Visible = true;
            //                HelpGrid.Focus();
            //                HelpGridView.BestFitColumns();
            //            }
            //            else
            //            {
            //                ProjectFunctions.SpeakError("No Records To Display");
            //            }
            //        }
            //    }
            //}
            //e.Handled = true;
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
                panelControl2.Visible = false;
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
                panelControl2.Visible = false;
                txtTransporterCode.Focus();
                GetOurwardData();
            }
            if (HelpGridView.RowCount > 0)
            {

                if (HelpGrid.Text == "ProcessName")
                {
                    BarCodeGridView.UpdateCurrentRow();
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ProcessCode"], row["ProcessCode"].ToString());
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ProcessName"], row["ProcessName"].ToString());
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["Rate"], Convert.ToDecimal(row["Rate"]));
                    BarCodeGridView.Focus();
                    panelControl2.Visible = false;
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["Rate"];
                    BarCodeGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                    dt.AcceptChanges();

                    if (BarCodeGridView.FocusedColumn.FieldName == "Rate")
                    {
                        BarCodeGridView.ShowEditor();
                    }
                }
                if (HelpGrid.Text == "UomDesc")
                {
                    BarCodeGridView.UpdateCurrentRow();
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["UomCode"], row["UomCode"].ToString());
                    BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["UomDesc"], row["UomDesc"].ToString());
                    BarCodeGridView.Focus();
                    panelControl2.Visible = false;
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["Rate"];
                    BarCodeGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                    dt.AcceptChanges();

                    if (BarCodeGridView.FocusedColumn.FieldName == "Rate")
                    {
                        BarCodeGridView.ShowEditor();
                    }
                }

                if (HelpGrid.Text == "ARTNO")
                {
                    ProductFeedTag = "Y";
                    if (ProductFeedTag == "N")
                    {
                        DataRow dtNewRow = dt.NewRow();
                        dtNewRow["ARTNO"] = row["ARTNO"].ToString();
                        dtNewRow["ARTDESC"] = row["ARTDESC"].ToString();
                        dtNewRow["ARTID"] = row["ARTSYSID"].ToString();
                        dt.Rows.Add(dtNewRow);
                        if (dt.Rows.Count > 0)
                        {
                            BarCodeGrid.DataSource = dt;
                            BarCodeGridView.BestFitColumns();
                        }
                        panelControl2.Visible = false;
                        BarCodeGridView.Focus();
                        BarCodeGridView.MoveLast();
                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["CHOColName"];
                        txtSearchBox.Text = string.Empty;
                    }
                    else
                    {
                        BarCodeGridView.UpdateCurrentRow();
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ARTNO"], row["ARTNO"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ARTDESC"], row["ARTDESC"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ARTID"], row["ARTSYSID"].ToString());
                        BarCodeGridView.Focus();
                        panelControl2.Visible = false;
                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["UOMDesc"];
                        BarCodeGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = string.Empty;
                        dt.AcceptChanges();
                        ProductFeedTag = "N";
                    }
                }

                if (HelpGrid.Text == "PrdName")
                {
                    ProductFeedTag = "Y";
                    DataRow dtNewRow = dt.NewRow();
                    dtNewRow["PrdCode"] = row["PrdCode"].ToString();
                    dtNewRow["PrdName"] = row["PrdName"].ToString();

                    dt.Rows.Add(dtNewRow);
                    if (dt.Rows.Count > 0)
                    {
                        BarCodeGrid.DataSource = dt;
                        BarCodeGridView.BestFitColumns();
                    }
                    panelControl2.Visible = false;
                    BarCodeGridView.Focus();
                    BarCodeGridView.MoveLast();
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["UOMDesc"];
                    txtSearchBox.Text = string.Empty;

                    //if (BarCodeGridView.FocusedColumn.FieldName == "CHOManualDesc")
                    //{
                    //    BarCodeGridView.ShowEditor();
                    //}


                    ProductFeedTag = "Y";
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

                                        if (BarCodeGridView.FocusedColumn.FieldName == "PrdName")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "PrdName";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl2.Visible = true;
                                                panelControl2.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from PrdMst where PrdCode='" + ProjectFunctions.CheckNull(currentrow["PrdCode"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "PrdName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "PrdName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (BarCodeGridView.FocusedColumn.FieldName == "ARTNO")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "ARTNO";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl2.Visible = true;
                                                panelControl2.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + ProjectFunctions.CheckNull(currentrow["ARTNO"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "ARTNO";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "ARTNO";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (BarCodeGridView.FocusedColumn.FieldName == "UomDesc")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "UomDesc";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl2.Visible = true;
                                                panelControl2.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from UomMst where UomCode='" + ProjectFunctions.CheckNull(currentrow["UomCode"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "UomDesc";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "UomDesc";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                            }
                                        }
                                        if (BarCodeGridView.FocusedColumn.FieldName == "ProcessName")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "ProcessName";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl2.Visible = true;
                                                panelControl2.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ProcessMst where ProcessCode='" + ProjectFunctions.CheckNull(currentrow["ProcessCode"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "ProcessName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
                                                    txtSearchBox.Focus();
                                                    txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                    txtSearchBox.SelectionLength = 0;
                                                    RowIndex = BarCodeGridView.FocusedRowHandle;
                                                }
                                                else
                                                {
                                                    HelpGrid.Text = "ProcessName";
                                                    txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                    panelControl2.Visible = true;
                                                    panelControl2.Select();
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

                if (BarCodeGridView.FocusedColumn.FieldName == "ReceivedQty" || BarCodeGridView.FocusedColumn.FieldName == "ReceivedQtyInKgs" || BarCodeGridView.FocusedColumn.FieldName == "WastageQty" || BarCodeGridView.FocusedColumn.FieldName == "WastageQtyInKgs" || BarCodeGridView.FocusedColumn.FieldName == "Rate" || BarCodeGridView.FocusedColumn.FieldName == "CalculationType")
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
                if (HelpGrid.Text == "txtTransporterCode")
                {

                    DataTable dtNew = dsPopUps.Tables[7].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[7].Select("TRPRNAME like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["TRPRSYSID"] = dr["TRPRSYSID"];
                        NewRow["TRPRNAME"] = dr["TRPRNAME"];


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
                if (HelpGrid.Text == "txtDebitPartyCode")
                {

                    DataTable dtNew = dsPopUps.Tables[6].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[6].Select("AccName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["AccCode"] = dr["AccCode"];
                        NewRow["AccName"] = dr["AccName"];
                        NewRow["AccAddress1"] = dr["AccAddress1"];
                        NewRow["AccAddress2"] = dr["AccAddress2"];
                        NewRow["AccAddress3"] = dr["AccAddress3"];
                        NewRow["CTNAME"] = dr["CTNAME"];
                        NewRow["STNAME"] = dr["STNAME"];
                        NewRow["AccZipCode"] = dr["AccZipCode"];
                        NewRow["AccTeleFax"] = dr["AccTeleFax"];

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
                if (HelpGrid.Text == "UomDesc")
                {
                    DataTable dtNew = dsPopUps.Tables[5].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[5].Select("UomDesc like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["UomCode"] = dr["UomCode"];
                        NewRow["UomDesc"] = dr["UomDesc"];
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
                if (HelpGrid.Text == "ProcessName")
                {
                    DataTable dtNew = dsPopUps.Tables[4].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[4].Select("ProcessName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {
                        DataRow NewRow = dtNew.NewRow();
                        NewRow["ProcessCode"] = dr["ProcessCode"];
                        NewRow["ProcessName"] = dr["ProcessName"];
                        NewRow["Rate"] = dr["Rate"];
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
                if (HelpGrid.Text == "PrdName")
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
                if (HelpGrid.Text == "ARTNO")
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

            }

            catch (Exception)
            {

            }
        }

        private void GroupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChallanGrid_DoubleClick(object sender, EventArgs e)
        {
            GetOurwardDataFProcess();
        }

        private void BarCodeGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (BarCodeGrid.DataSource != null)
                {
                    if (e.Column.FieldName == "ReceivedQty" || e.Column.FieldName == "ReceivedQtyInKgs" || e.Column.FieldName == "WastageQty" || e.Column.FieldName == "WastageQtyInKgs" || e.Column.FieldName == "Rate")
                    {
                        BarCodeGridView.CloseEditor();
                        BarCodeGridView.UpdateCurrentRow();
                        DataRow row = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);


                        BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["ActualQty"], Convert.ToDecimal(row["ReceivedQty"]) - Convert.ToDecimal(row["WastageQty"]));
                        BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["ActualQtyInKgs"], Convert.ToDecimal(row["ReceivedQtyInKgs"]) - Convert.ToDecimal(row["WastageQtyInKgs"]));
                        if (row["CalculationType"].ToString().ToUpper() == "D")
                        {
                            BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["CalcAmount"], Convert.ToDecimal(row["ActualQty"]) * (Convert.ToDecimal(row["Rate"]) / 12));
                        }
                        else
                        {
                            if (row["CalculationType"].ToString().ToUpper() == "PCS")
                            {
                                BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["CalcAmount"], Convert.ToDecimal(row["ActualQty"]) * Convert.ToDecimal(row["Rate"]));

                            }
                            else
                            {
                                BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["CalcAmount"], Convert.ToDecimal(row["ActualQtyInKgs"]) * Convert.ToDecimal(row["Rate"]));
                            }
                        }

                        if (Convert.ToDecimal(row["ActualQty"]) > Convert.ToDecimal(row["Bal"]))
                        {

                            ProjectFunctions.SpeakError("Actual Quantity Cannot Be Greater Than Issued Quantity");

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private bool ValidateDataForSaving()
        {
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dt.AcceptChanges();
                if (ValidateDataForSaving())
                {
                    using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                    {
                        sqlcon.Open();
                        var sqlcom = sqlcon.CreateCommand();
                        sqlcom.Connection = sqlcon;
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.CommandType = CommandType.Text;
                        if (S1 == "&Add")
                        {

                            txtTransNo.Text = ProjectFunctions.GetDataSet("Select isnull(Max(CHINO),0)+1 from CHINMain WHere CHIFYR='" + GlobalVariables.FinancialYear + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
                            sqlcom.CommandText = " Insert into CHINMain "
                                                        + " (DocNo,DocDate,CHIReceiveDate,CHIGateEntryNo,CHIFYR,CHINO,CHITYPE,CHIDATE,CHIPARTYCODE,CHOREMARKS,UnitCode,CHOTRPID)values("
                                                        + " @DocNo,@DocDate,@CHIReceiveDate,@CHIGateEntryNo,@CHIFYR,@CHINO,@CHITYPE,@CHIDATE,@CHIPARTYCODE,@CHOREMARKS,@UnitCode,@CHOTRPID)";
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = txtDocNo.Text;
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDocDate.Text).ToString("yyyy-MM-dd");

                            sqlcom.Parameters.Add("@CHIReceiveDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtReceivingDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CHIGateEntryNo", SqlDbType.NVarChar).Value = txtGateEntryNo.Text;
                            sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = txtTransNo.Text;
                            sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = txtDocType.Text;
                            sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtTransDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CHIPARTYCODE", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text;
                            sqlcom.Parameters.Add("@CHOREMARKS", SqlDbType.NVarChar).Value = txtRemarks.Text;
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@CHOTRPID", SqlDbType.NVarChar).Value =txtTransporterCode.Text;
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " update CHINMain Set  "
                                                        + "DocNo=@DocNo,DocDate=@DocDate,CHIReceiveDate=@CHIReceiveDate,CHIGateEntryNo=@CHIGateEntryNo,CHIPARTYCODE=@CHIPARTYCODE,CHOREMARKS=@CHOREMARKS,CHOTRPID=@CHOTRPID "
                                                        + " where CHINO='" + txtTransNo.Text + "' And CHIDATE='" + Convert.ToDateTime(txtTransDate.Text).ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "'";
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = txtDocNo.Text;
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtDocDate.Text).ToString("yyyy-MM-dd");

                            sqlcom.Parameters.Add("@CHIReceiveDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtReceivingDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CHIGateEntryNo", SqlDbType.NVarChar).Value = txtGateEntryNo.Text;
                            sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                            sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = txtTransNo.Text;
                            sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = txtDocType.Text;
                            sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtTransDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CHIPARTYCODE", SqlDbType.NVarChar).Value = txtDebitPartyCode.Text;
                            sqlcom.Parameters.Add("@CHOREMARKS", SqlDbType.NVarChar).Value = txtRemarks.Text;
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@CHOTRPID", SqlDbType.NVarChar).Value = txtTransporterCode.Text;
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                            ProjectFunctions.GetDataSet("Delete from CHINData Where CHINO='" + txtTransNo.Text + "' And CHIDATE='" + Convert.ToDateTime(txtTransDate.Text).ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
                        }

                        foreach (DataRow dr in dt.Rows)
                        {
                            if (Convert.ToDecimal(dr["ReceivedQty"]) > 0 || Convert.ToDecimal(dr["ReceivedQtyInKgs"]) > 0)
                            {
                                sqlcom.CommandText = " Insert into CHINData "
                                                        + " (CHIFYR,CHINO,CHITYPE,CHIDATE,AgnstChallanType,AgnstChallanNo,PrdCode,"
                                                        + " ARTID,UomCode,ReceivedQty,ReceivedQtyInKgs,WastageQty,WastageQtyInKgs,ProcessCode,Rate,"
                                                        + " CalculationType,CalcAmount,Remarks,ActualQty,ActualQtyInKgs,UnitCode,CHOUTTransID)"
                                                        + " values(@CHIFYR,@CHINO,@CHITYPE,@CHIDATE,@AgnstChallanType,@AgnstChallanNo,@PrdCode,"
                                                        + " @ARTID,@UomCode,@ReceivedQty,@ReceivedQtyInKgs,@WastageQty,@WastageQtyInKgs,@ProcessCode,@Rate,"
                                                        + " @CalculationType,@CalcAmount,@Remarks,@ActualQty,@ActualQtyInKgs,@UnitCode,@CHOUTTransID)";
                                sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                                sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = txtTransNo.Text;
                                sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = txtDocType.Text;
                                sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtTransDate.Text).ToString("yyyy-MM-dd");
                                sqlcom.Parameters.Add("@AgnstChallanType", SqlDbType.NVarChar).Value = dr["AgnstChallanType"].ToString();
                                sqlcom.Parameters.Add("@AgnstChallanNo", SqlDbType.NVarChar).Value = dr["AgnstChallanNo"].ToString();
                                sqlcom.Parameters.Add("@PrdCode", SqlDbType.NVarChar).Value = dr["PrdCode"].ToString();
                                sqlcom.Parameters.Add("@ARTID", SqlDbType.NVarChar).Value = dr["ARTID"].ToString();
                                sqlcom.Parameters.Add("@UomCode", SqlDbType.NVarChar).Value = dr["UomCode"].ToString();
                                sqlcom.Parameters.Add("@ReceivedQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["ReceivedQty"]);
                                sqlcom.Parameters.Add("@ReceivedQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["ReceivedQtyInKgs"]);
                                sqlcom.Parameters.Add("@WastageQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["WastageQty"]);
                                sqlcom.Parameters.Add("@WastageQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["WastageQtyInKgs"]); ;
                                sqlcom.Parameters.Add("@ProcessCode", SqlDbType.NVarChar).Value = dr["Rate"].ToString();
                                sqlcom.Parameters.Add("@Rate", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["ReceivedQty"]);
                                sqlcom.Parameters.Add("@CalculationType", SqlDbType.NVarChar).Value = dr["CalculationType"].ToString();
                                sqlcom.Parameters.Add("@CalcAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["CalcAmount"]);
                                sqlcom.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = dr["Remarks"].ToString();
                                sqlcom.Parameters.Add("@ActualQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["ActualQty"]);
                                sqlcom.Parameters.Add("@ActualQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr["ActualQtyInKgs"]);
                                sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                                sqlcom.Parameters.Add("@CHOUTTransID", SqlDbType.NVarChar).Value = dr["TransID"].ToString() ;

                                sqlcom.ExecuteNonQuery();
                                sqlcom.Parameters.Clear();
                            }

                        }

                        ProjectFunctions.SpeakError(" Data Saved Successfully");
                        sqlcon.Close();
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
    }
}