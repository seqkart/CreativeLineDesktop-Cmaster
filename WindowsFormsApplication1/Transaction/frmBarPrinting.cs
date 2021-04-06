using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmBarPrinting : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtGeneric = new DataTable();
        DataTable dtVariants = new DataTable();
        public string S1 { get; set; }
#pragma warning disable CS0108 // 'frmBarPrinting.Tag' hides inherited member 'Control.Tag'. Use the new keyword if hiding was intended.
        public string Tag { get; set; }
#pragma warning restore CS0108 // 'frmBarPrinting.Tag' hides inherited member 'Control.Tag'. Use the new keyword if hiding was intended.
        public string SKUVOUCHNO { get; set; }
        DataTable dt = new DataTable();
        DataSet dsPopUps = new DataSet();

        int RowIndex = 0;
        string UpdateTag = "N";


        public frmBarPrinting()
        {
            InitializeComponent();
            dt.Columns.Add("SKUPRODUCTCODE", typeof(string));
            dt.Columns.Add("SKUPARTYBARCODE", typeof(string));
            dt.Columns.Add("SKUFIXBARCODE", typeof(string));
            dt.Columns.Add("SKUARTNO", typeof(string));
            dt.Columns.Add("ARTDESC", typeof(string));
            dt.Columns.Add("SKUCOLN", typeof(string));
            dt.Columns.Add("SKUSIZN", typeof(string));
            dt.Columns.Add("SKUFEDQTY", typeof(decimal));
            dt.Columns.Add("SKUMRP", typeof(string));
            dt.Columns.Add("SKUWSP", typeof(string));
            dt.Columns.Add("SKUMRPVAL", typeof(decimal));
            dt.Columns.Add("SKUWSPVAL", typeof(decimal));
            dt.Columns.Add("SKUARTID", typeof(string));
            dt.Columns.Add("SKUCOLID", typeof(string));
            dt.Columns.Add("SKUSIZID", typeof(string));
            dt.Columns.Add("SKUARTCOLSET", typeof(string));
            dt.Columns.Add("SKUARTSIZSET", typeof(string));
            dt.Columns.Add("SKUSIZINDX", typeof(string));
            dt.Columns.Add("SKUCODE", typeof(string));
            dt.Columns.Add("SKUVOUCHNO", typeof(string));
            dt.Columns.Add("SKUFNYR", typeof(string));
            dt.Columns.Add("DISCPRCN", typeof(string));
            dt.Columns.Add("FLATMRP", typeof(string));
            dt.Columns.Add("SKUPPRICE", typeof(string));
            dt.Columns.Add("GrpHSNCode", typeof(string));
            dt.Columns.Add("VARIANTART", typeof(string));

            dsPopUps = ProjectFunctions.GetDataSet("[sp_LoadBarPrintPopUps2]");

        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dt.AcceptChanges();
                DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

                if (HelpGrid.Text == "txtDeptCode")
                {
                    txtDeptCode.Text = row["DeptCode"].ToString();
                    txtDeptDesc.Text = row["DeptDesc"].ToString();
                    panelControl1.Visible = false;
                    txtOrderNo.Focus();
                }


                if (HelpGridView.RowCount > 0)
                {
                    if (HelpGrid.Text == "SKUARTNO")
                    {
                        if (UpdateTag == "N")
                        {
                            DataRow dtNewRow = dt.NewRow();
                            dtNewRow["SKUARTNO"] = row["ARTNO"].ToString();
                            dtNewRow["ARTDESC"] = row["ARTDESC"].ToString();
                            dtNewRow["SKUMRP"] = row["ARTMRP"].ToString();
                            dtNewRow["SKUWSP"] = row["ARTWSP"].ToString();
                            dtNewRow["SKUFEDQTY"] = Convert.ToDecimal("1");

                            dtNewRow["SKUMRPVAL"] = Convert.ToDecimal(row["ARTMRP"]);
                            dtNewRow["SKUWSPVAL"] = Convert.ToDecimal(row["ARTWSP"]);

                            dtNewRow["SKUARTID"] = row["ARTSYSID"].ToString();
                            dt.Rows.Add(dtNewRow);
                            if (dt.Rows.Count > 0)
                            {
                                BarCodeGrid.DataSource = dt;
                                BarCodeGridView.BestFitColumns();
                            }

                            UpdateTag = "N";
                            panelControl1.Visible = false;
                            BarCodeGridView.Focus();
                            BarCodeGridView.MoveLast();
                            BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUCOLN"];
                            txtSearchBox.Text = string.Empty;
                            ProjectFunctions.ShowImage(row["ARTSYSID"].ToString(), ArticleImageBox);
                        }
                        else
                        {
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUARTID"], string.Empty);
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUCOLID"], string.Empty);
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZID"], string.Empty);
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUCOLN"], string.Empty);
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZN"], string.Empty);


                            //int i = BarCodeGridView.FocusedRowHandle;

                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUARTID"], row["ARTSYSID"].ToString());
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUARTNO"], row["ARTNO"].ToString());
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["ARTDESC"], row["ARTDESC"].ToString());
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUMRP"], Convert.ToDecimal(row["ARTMRP"]));
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUWSP"], Convert.ToDecimal(row["ARTWSP"]));
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUMRPVAL"], row["ARTMRP"].ToString());
                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUFEDQTY"], Convert.ToDecimal("1"));

                            BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUWSPVAL"], Convert.ToDecimal(row["ARTWSP"]));


                            BarCodeGridView.CloseEditor();
                            BarCodeGridView.UpdateCurrentRow();


                            UpdateTag = "N";
                            panelControl1.Visible = false;
                            BarCodeGridView.Focus();

                            BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUCOLN"];
                            BarCodeGridView.FocusedRowHandle = RowIndex;
                            txtSearchBox.Text = string.Empty;
                            ProjectFunctions.ShowImage(row["ARTSYSID"].ToString(), ArticleImageBox);
                            dt.AcceptChanges();
                        }


                    }

                    if (HelpGrid.Text == "SKUCOLN")
                    {
                        BarCodeGridView.UpdateCurrentRow();
                        UpdateTag = "N";
                        //int i = BarCodeGridView.FocusedRowHandle;

                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUCOLID"], row["COLSYSID"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUCOLN"], row["COLNAME"].ToString());
                        BarCodeGridView.Focus();
                        panelControl1.Visible = false;

                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUSIZN"];
                        BarCodeGridView.FocusedRowHandle = RowIndex;
                        txtSearchBox.Text = string.Empty;
                        dt.AcceptChanges();
                    }
                    if (HelpGrid.Text == "SKUSIZN")
                    {
                        UpdateTag = "N";
                        //int i = BarCodeGridView.FocusedRowHandle;


                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZID"], row["SZSYSID"].ToString());
                        BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZN"], row["SZNAME"].ToString());
                        panelControl1.Visible = false;
                        BarCodeGridView.Focus();

                        dt.AcceptChanges();

                        BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUFEDQTY"];
                        BarCodeGridView.ShowEditor();
                        BarCodeGridView.FocusedRowHandle = RowIndex;

                        txtSearchBox.Text = string.Empty;

                    }
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

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
                                        if (BarCodeGridView.FocusedColumn.FieldName == "SKUARTNO")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SKUARTNO";

                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" + ProjectFunctions.CheckNull(currentrow["SKUARTNO"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";


                                                    HelpGrid.Text = "SKUARTNO";
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
                                                    HelpGrid.Text = "SKUARTNO";
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
                                        if (BarCodeGridView.FocusedColumn.FieldName == "SKUCOLN")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SKUCOLN";
                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;
                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from COLOURS where COLSYSID='" + ProjectFunctions.CheckNull(currentrow["SKUCOLID"].ToString()) + "'");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {

                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "SKUCOLN";
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
                                                    HelpGrid.Text = "SKUCOLN";
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

                                        if (BarCodeGridView.FocusedColumn.FieldName == "SKUSIZN")
                                        {
                                            if (currentrow == null)
                                            {
                                                HelpGrid.Text = "SKUSIZN";
                                                txtSearchBox.Text = txtSearchBox.Text + ProjectFunctions.ValidateKeysForSearchBox(e);
                                                panelControl1.Visible = true;
                                                panelControl1.Select();
                                                txtSearchBox.Focus();
                                                txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
                                                txtSearchBox.SelectionLength = 0;


                                            }
                                            else
                                            {
                                                DataSet dsCheck = ProjectFunctions.GetDataSet("sp_LoadSizes '" + currentrow["SKUARTNO"].ToString() + "', '" + ProjectFunctions.CheckNull(currentrow["SKUSIZID"].ToString()) + "' ");
                                                if (dsCheck.Tables[0].Rows.Count > 0)
                                                {
                                                    UpdateTag = "Y";

                                                    HelpGrid.Text = "SKUSIZN";
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
                                                    HelpGrid.Text = "SKUSIZN";
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

                if (e.KeyCode == Keys.F12)
                {
                    BarCodeGridView.CloseEditor();
                    BarCodeGridView.UpdateCurrentRow();
                    DataRow row = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);
                    DataSet dsNewSize = ProjectFunctions.GetDataSet("sp_LoadSizes2  '" + row["SKUARTNO"].ToString() + "','" + row["SKUSIZID"].ToString() + "'");
                    if (dsNewSize.Tables[0].Rows.Count > 0)
                    {
                        DataRow dtNewRow = dt.NewRow();
                        dtNewRow["SKUARTNO"] = row["SKUARTNO"].ToString();
                        dtNewRow["ARTDESC"] = row["ARTDESC"].ToString();
                        dtNewRow["SKUMRP"] = row["SKUMRP"].ToString();
                        dtNewRow["SKUWSP"] = row["SKUWSP"].ToString();
                        dtNewRow["SKUFEDQTY"] = Convert.ToDecimal(row["SKUFEDQTY"]);
                        dtNewRow["SKUARTID"] = row["SKUARTID"].ToString();
                        dtNewRow["SKUCOLID"] = row["SKUCOLID"].ToString();
                        dtNewRow["SKUCOLN"] = row["SKUCOLN"].ToString();
                        dtNewRow["SKUSIZID"] = dsNewSize.Tables[0].Rows[0]["SZSYSID"].ToString();
                        dtNewRow["SKUSIZN"] = dsNewSize.Tables[0].Rows[0]["SZNAME"].ToString();
                        dtNewRow["SKUMRPVAL"] = Convert.ToDecimal(row["SKUFEDQTY"]) * Convert.ToDecimal(row["SKUMRP"]);
                        dtNewRow["SKUWSPVAL"] = Convert.ToDecimal(row["SKUFEDQTY"]) * Convert.ToDecimal(row["SKUWSP"]);

                        dt.Rows.Add(dtNewRow);
                        if (dt.Rows.Count > 0)
                        {
                            BarCodeGrid.DataSource = dt;
                            BarCodeGridView.BestFitColumns();
                            BarCodeGridView.MoveLast();
                        }
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Size Further");
                    }
                }
                ProjectFunctions.DeleteCurrentRowOnKeyDown(BarCodeGrid, BarCodeGridView, e);

                if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
                {
                    BarCodeGridView.ShowEditor();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void BarCodeGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (BarCodeGrid.DataSource != null)
                {
                    if (e.Column.FieldName == "SKUFEDQTY")
                    {
                        BarCodeGridView.CloseEditor();
                        BarCodeGridView.UpdateCurrentRow();
                        DataRow row = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);
                        BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["SKUMRPVAL"], Convert.ToDecimal(row["SKUMRP"]) * Convert.ToDecimal(row["SKUFEDQTY"]));
                        BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["SKUWSPVAL"], Convert.ToDecimal(row["SKUWSP"]) * Convert.ToDecimal(row["SKUFEDQTY"]));
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }


        private bool ValidateDataForSaving()
        {
            try
            {
                dt.AcceptChanges();
                if (BarCodeGrid.DataSource == null)
                {
                    ProjectFunctions.SpeakError("No Data To Save");

                }


                DataSet dsCheckART = ProjectFunctions.GetDataSet("sp_CheckSKUData2 ");

                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    i++;
                    SplashScreenManager.Default.SetWaitFormDescription("Validating Item " + i.ToString() + " / " + dt.Rows.Count.ToString());

                    //if (ProjectFunctions.CheckAllPossible(dr["SKUARTID"].ToString(), Convert.ToDecimal(dr["SKUMRP"]), dr["SKUCOLID"].ToString(), dr["SKUSIZID"].ToString()))
                    //{

                    //}
                    //else
                    //{
                    //    return false;
                    //}



                    if (dsCheckART.Tables[0].Rows.Count > 0)
                    {
                      

                        foreach (DataRow drInner in dsCheckART.Tables[0].Rows)
                        {
                            if (drInner["ARTSYSID"].ToString() == dr["SKUARTID"].ToString())
                            {
                                if (Convert.ToDecimal(dr["SKUMRP"]) == Convert.ToDecimal(drInner["ARTMRP"]))
                                {
                                    continue;
                                }
                                else
                                {
                                    ProjectFunctions.SpeakError("Wrong MRP Found");
                                    return false;
                                }
                            }
                        }


                        int colorcount = 0;
                        foreach (DataRow drInner in dsCheckART.Tables[1].Rows)
                        {
                            if (drInner["COLSYSID"].ToString() == dr["SKUCOLID"].ToString())
                            {
                                colorcount++;
                                break;
                            }
                        }

                        if (colorcount == 0)
                        {
                            ProjectFunctions.SpeakError("No Color Found");
                            return false;
                        }


                        int sizecount = 0;
                        foreach (DataRow drInner in dsCheckART.Tables[2].Rows)
                        {
                            if (drInner["SZSYSID"].ToString() == dr["SKUSIZID"].ToString())
                            {
                                sizecount++;
                                break;
                            }
                        }

                        if (sizecount == 0)
                        {
                            ProjectFunctions.SpeakError("No Size Found");
                            return false;
                        }
                    }
                }
                SplashScreenManager.CloseForm(false);
                return true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
                return false;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateDataForSaving())
            {
                if (S1 == "&Add")
                {
                    using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                    {
                        sqlcon.Open();
                        var sqlcom = sqlcon.CreateCommand();
                        sqlcom.Connection = sqlcon;
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        try
                        {

                            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                            SplashScreenManager.Default.SetWaitFormDescription("Saving Items");

                            int i = 0;

                            if (ChkFixedBarCode.Checked == false)
                            {
                                DataTable dtFinal = new DataTable();

                                dtFinal.Columns.Add("SKUPARTYBARCODE", typeof(string));
                                dtFinal.Columns.Add("SKUFNYR", typeof(string));
                                dtFinal.Columns.Add("SKUARTNO", typeof(string));
                                dtFinal.Columns.Add("SKUARTID", typeof(string));
                                dtFinal.Columns.Add("SKUCOLN", typeof(string));
                                dtFinal.Columns.Add("SKUCOLID", typeof(string));
                                dtFinal.Columns.Add("SKUSIZN", typeof(string));
                                dtFinal.Columns.Add("SKUSIZID", typeof(string));
                                dtFinal.Columns.Add("SKUFEDQTY", typeof(string));
                                dtFinal.Columns.Add("SKUGENMODAUTO", typeof(string));
                                dtFinal.Columns.Add("SKUCODSCHEM", typeof(string));
                                dtFinal.Columns.Add("SKUWSP", typeof(decimal));
                                dtFinal.Columns.Add("SKUMRP", typeof(decimal));
                                dtFinal.Columns.Add("SKUWSPVAL", typeof(decimal));
                                dtFinal.Columns.Add("SKUMRPVAL", typeof(decimal));
                                dtFinal.Columns.Add("SKUASORDR", typeof(string));
                                dtFinal.Columns.Add("SKUNMAINTSTK", typeof(string));
                                dtFinal.Columns.Add("SKUARTCOLSET", typeof(string));
                                dtFinal.Columns.Add("SKUARTSIZSET", typeof(string));
                                dtFinal.Columns.Add("SKUSIZINDX", typeof(string));
                                dtFinal.Columns.Add("UnitCode", typeof(string));
                                dtFinal.Rows.Clear();


                               foreach (DataRow dr in (BarCodeGrid.DataSource as DataTable).Rows)
                                {
                                    if (Convert.ToDecimal(dr["SKUFEDQTY"]) > 0)
                                    {
                                        DataRow drRow = dtFinal.NewRow();
                                        drRow["SKUPARTYBARCODE"] = dr["SKUPARTYBARCODE"].ToString();
                                        drRow["SKUFNYR"] = GlobalVariables.FinancialYear;
                                        drRow["SKUARTNO"] = dr["SKUARTNO"].ToString();
                                        drRow["SKUARTID"] = dr["SKUARTID"].ToString();
                                        drRow["SKUCOLN"] = dr["SKUCOLN"].ToString();
                                        drRow["SKUCOLID"] = dr["SKUCOLID"].ToString();
                                        drRow["SKUSIZN"] = dr["SKUSIZN"].ToString();
                                        drRow["SKUSIZID"] = dr["SKUSIZID"].ToString();
                                        drRow["SKUFEDQTY"] = dr["SKUFEDQTY"].ToString() ;
                                        drRow["SKUGENMODAUTO"] = "0";
                                        drRow["SKUCODSCHEM"] = "0";
                                        drRow["SKUWSP"] = Convert.ToDecimal(dr["SKUWSP"]);
                                        drRow["SKUMRP"] = Convert.ToDecimal(dr["SKUMRP"]);
                                        drRow["SKUWSPVAL"] = Convert.ToDecimal(dr["SKUWSP"]);
                                        drRow["SKUMRPVAL"] = Convert.ToDecimal(dr["SKUMRP"]);
                                        drRow["SKUASORDR"] = "0";
                                        drRow["SKUNMAINTSTK"] = "0";
                                        drRow["SKUARTCOLSET"] = "0";
                                        drRow["SKUARTSIZSET"] = "0";
                                        drRow["SKUSIZINDX"] = dr["SKUSIZINDX"].ToString();
                                        drRow["UnitCode"] = GlobalVariables.CUnitID;
                                        dtFinal.Rows.Add(drRow);
                                    }
                                }

                                dtFinal.AcceptChanges();
                                sqlcom.CommandType = CommandType.StoredProcedure;
                                sqlcom.CommandText = "sp_InsertBarCodeData";
                                sqlcom.CommandTimeout = 600000;
                                SqlParameter param = new SqlParameter
                                {
                                    ParameterName = "@BarCodeTable",
                                    Value = dtFinal
                                };
                                sqlcom.Parameters.Add(param);
                                sqlcom.ExecuteNonQuery();
                                sqlcom.Parameters.Clear();

                                SplashScreenManager.CloseForm();
                            }
                            else
                            {

                                i++;
                                SplashScreenManager.Default.SetWaitFormDescription("Saving Item " + i.ToString() + " / " + (BarCodeGrid.DataSource as DataTable).Rows.Count);
                                txtSysID.Text = ProjectFunctions.GetDataSet("select isnull(max(SKUVOUCHNO),0)+1 from SKU_Fix Where UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
                                //txtSysID.Text = ProjectFunctions.GetDataSet("select isnull(max(SKUVOUCHNO),0)+1 from SKU_Fix Where SKUFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();


                                foreach (DataRow dr in (BarCodeGrid.DataSource as DataTable).Rows)
                                {
                                    string SKUCode = ProjectFunctions.GetDataSet("select isnull(max(SKUCODE),0)+1 from SKU_FIx where UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
                                    //String SKUCode = ProjectFunctions.GetDataSet("select isnull(max(SKUCODE),0)+1 from SKU_FIx where SKUFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
                                    string SKUPRODUCTCODE = "X" + SKUCode.PadLeft(9, '0');

                                    DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SKU_FIx Where SKUARTID='" + dr["SKUARTID"].ToString() + "'ANd SKUCOLID='" + dr["SKUCOLID"].ToString() + "' And SKUSIZID='" + dr["SKUSIZID"].ToString() + "'");
                                    if (dsCheck.Tables[0].Rows.Count > 0)
                                    {

                                        SKUPRODUCTCODE = dsCheck.Tables[0].Rows[0]["SKUPRODUCTCODE"].ToString();
                                        SKUCode = dsCheck.Tables[0].Rows[0]["SKUCODE"].ToString();

                                        //ProjectFunctions.GetDataSet("Update SKU_FIx set SKUFEDQTY=SKUFEDQTY +'" + dr["SKUFEDQTY"].ToString() + "' SKU_FIx Where SKUARTID='" + dr["SKUARTID"].ToString() + "'ANd SKUCOLID='" + dr["SKUCOLID"].ToString() + "' And SKUSIZID='" + dr["SKUSIZID"].ToString() + "' And SKUAccCode='" + txtAccCode.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
                                    }

                                    sqlcom.CommandType = CommandType.Text;
                                    sqlcom.CommandTimeout = 600000;
                                    sqlcom.CommandText = " Insert into SKU_FIx "
                                                                + " (SKUSYSDATE,SKUFNYR,SKUCODE,SKUVOUCHNO,SKUPRODUCTCODE,SKUARTNO,"
                                                                + " SKUARTID,SKUCOLN,SKUCOLID,SKUSIZN,SKUSIZID,SKUFEDQTY,"
                                                                + " SKUGENMODAUTO,SKUCODSCHEM,SKUWSP,SKUMRP,SKUWSPVAL,SKUMRPVAL,SKUASORDR,SKUNMAINTSTK,SKUARTCOLSET,SKUARTSIZSET,SKUSIZINDX,UnitCode)"
                                                                + " values(@SKUSYSDATE,@SKUFNYR,@SKUCODE,@SKUVOUCHNO,@SKUPRODUCTCODE,@SKUARTNO,"
                                                                + " @SKUARTID,@SKUCOLN,@SKUCOLID,@SKUSIZN,@SKUSIZID,@SKUFEDQTY,"
                                                                + " @SKUGENMODAUTO,@SKUCODSCHEM,@SKUWSP,@SKUMRP,@SKUWSPVAL,@SKUMRPVAL,@SKUASORDR,@SKUNMAINTSTK,@SKUARTCOLSET,@SKUARTSIZSET,@SKUSIZINDX,@UnitCode )";
                                    sqlcom.Parameters.Add("@SKUSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                    sqlcom.Parameters.Add("@SKUFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
                                    sqlcom.Parameters.Add("@SKUCODE", SqlDbType.NVarChar).Value = SKUCode;
                                    sqlcom.Parameters.Add("@SKUVOUCHNO", SqlDbType.NVarChar).Value = txtSysID.Text;
                                    sqlcom.Parameters.Add("@SKUPRODUCTCODE", SqlDbType.NVarChar).Value = SKUPRODUCTCODE;
                                    sqlcom.Parameters.Add("@SKUARTNO", SqlDbType.NVarChar).Value = dr["SKUARTNO"].ToString();
                                    sqlcom.Parameters.Add("@SKUARTID", SqlDbType.NVarChar).Value = dr["SKUARTID"].ToString();
                                    sqlcom.Parameters.Add("@SKUCOLN", SqlDbType.NVarChar).Value = dr["SKUCOLN"].ToString();
                                    sqlcom.Parameters.Add("@SKUCOLID", SqlDbType.NVarChar).Value = dr["SKUCOLID"].ToString();
                                    sqlcom.Parameters.Add("@SKUSIZN", SqlDbType.NVarChar).Value = dr["SKUSIZN"].ToString();
                                    sqlcom.Parameters.Add("@SKUSIZID", SqlDbType.NVarChar).Value = dr["SKUSIZID"].ToString();
                                    sqlcom.Parameters.Add("@SKUFEDQTY", SqlDbType.NVarChar).Value = dr["SKUFEDQTY"].ToString();

                                    sqlcom.Parameters.Add("@SKUGENMODAUTO", SqlDbType.NVarChar).Value = "0";

                                    sqlcom.Parameters.Add("@SKUCODSCHEM", SqlDbType.NVarChar).Value = "0";
                                    if (dr["SKUWSP"].ToString() == string.Empty)
                                    {
                                        dr["SKUWSP"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUWSP", SqlDbType.NVarChar).Value = dr["SKUWSP"].ToString();
                                    if (dr["SKUMRP"].ToString() == string.Empty)
                                    {
                                        dr["SKUMRP"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUMRP", SqlDbType.NVarChar).Value = dr["SKUMRP"].ToString();
                                    if (dr["SKUWSPVAL"].ToString() == string.Empty)
                                    {
                                        dr["SKUWSPVAL"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUWSPVAL", SqlDbType.NVarChar).Value = dr["SKUWSPVAL"].ToString();
                                    if (dr["SKUMRPVAL"].ToString() == string.Empty)
                                    {
                                        dr["SKUMRPVAL"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUMRPVAL", SqlDbType.NVarChar).Value = dr["SKUMRPVAL"].ToString();

                                    sqlcom.Parameters.Add("@SKUASORDR", SqlDbType.NVarChar).Value = "0";

                                    sqlcom.Parameters.Add("@SKUNMAINTSTK", SqlDbType.NVarChar).Value = "0";
                                    if (dr["SKUARTCOLSET"].ToString() == string.Empty)
                                    {
                                        dr["SKUARTCOLSET"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUARTCOLSET", SqlDbType.NVarChar).Value = dr["SKUARTCOLSET"].ToString();
                                    if (dr["SKUARTSIZSET"].ToString() == string.Empty)
                                    {
                                        dr["SKUARTSIZSET"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUARTSIZSET", SqlDbType.NVarChar).Value = dr["SKUARTSIZSET"].ToString();
                                    if (dr["SKUSIZINDX"].ToString() == string.Empty)
                                    {
                                        dr["SKUSIZINDX"] = "0";
                                    }
                                    sqlcom.Parameters.Add("@SKUSIZINDX", SqlDbType.NVarChar).Value = dr["SKUSIZINDX"].ToString();
                                    sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;

                                    sqlcom.ExecuteNonQuery();
                                    sqlcom.Parameters.Clear();

                                }

                                SplashScreenManager.CloseForm();
                            }



                            ProjectFunctions.SpeakError("Barcode Generated Successfully");
                            sqlcon.Close();
                            btnSave.Enabled = false;
                            SKUVOUCHNO = txtSysID.Text;
                            FillGrid();

                            Close();
                        }
                        catch (Exception ex)
                        {
                            ProjectFunctions.SpeakError("Something Wrong." + ex.Message);
                        }
                    }
                }
            }
        }

        private void FrmBarPrinting_Load(object sender, EventArgs e)
        {
            try
            {
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                ProjectFunctions.GirdViewVisualize(BarCodeGridView);
                ProjectFunctions.GirdViewVisualize(HelpGridView);
                RBDIRECT.Checked = true;
                panelControl1.Visible = false;

                if (GlobalVariables.ProgCode == "PROG171")
                {
                    txtBarCode.Visible = true;
                    label2.Visible = true;
                    btnPrint.Visible = true;
                    S1 = "&Add";
                    //btnSave.Visible = false;
                }
                else
                {
                    ////txtBarCode.Visible = false;
                    ////label2.Visible = false;
                    ////btnPrint.Visible = false;
                    ////btnSave.Visible = true;
                }



                if (S1 == "&Add")
                {
                    BarCodeGrid.Focus();
                    BarCodeGridView.MoveLast();
                    BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUARTNO"];
                }
                if (S1 == "Edit")
                {
                    FillGrid();
                    btnSave.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void FillGrid()
        {
            try
            {
                DataSet ds = ProjectFunctions.GetDataSet("[sp_LoadBarCodeVouchersEdit2] '" + SKUVOUCHNO + "','" + GlobalVariables.FinancialYear + "','" + Tag + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtSysID.Text = SKUVOUCHNO;
                    txtDeptCode.Text = ds.Tables[0].Rows[0]["StoreCode"].ToString();
                    dt = ds.Tables[0];
                    BarCodeGrid.DataSource = dt;
                    BarCodeGridView.BestFitColumns();

                    //if (Tag == "Fixed")
                    //{
                    //    ChkFixedBarCode.Checked = true;
                    //}
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

                DataRow currentrow = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);


                HelpGrid.Show();
                if (HelpGrid.Text == "SKUARTNO")
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
                if (HelpGrid.Text == "SKUCOLN")
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
                if (HelpGrid.Text == "SKUSIZN")
                {
                    DataSet dsGroups = ProjectFunctions.GetDataSet("Select ARTSECTIONID,ARTSBSECTIONID from Article Where ARTNO='" + currentrow["SKUARTNO"].ToString() + "'");



                    DataTable dtNew = dsPopUps.Tables[2].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[2].Select("SZNAME like '" + txtSearchBox.Text + "%' And GrpCode='" + dsGroups.Tables[0].Rows[0]["ARTSECTIONID"].ToString() + "' And GrpSubCode='" + dsGroups.Tables[0].Rows[0]["ARTSBSECTIONID"].ToString() + "'");
                    //DataRow[] dtRow = dsPopUps.Tables[2].Select("SZNAME like '" + txtSearchBox.Text + "%'");

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

                        HelpGridView.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                        //HelpGridView.Columns[2].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
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

        private void BarCodeGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete Current Record", (o1, e1) =>
                {
                    ProjectFunctions.DeleteCurrentRowOnRightClick(BarCodeGrid, BarCodeGridView);
                }));
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Export To CSV", (o1, e1) =>
                {
                    BarCodeGridView.ExportToCsv(Application.StartupPath + @"\label\Stic.csv");

                    System.Diagnostics.Process.Start(Application.StartupPath + @"\label\EAN.btw");

                }));
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BarCodeGrid_Click(object sender, EventArgs e)
        {
            //            try
            //            {
            //                ArticleImageBox = null;

            //                DataRow currentrow = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);
            //                ProjectFunctions.ShowImage(currentrow["SKUARTID"].ToString(), ArticleImageBox);
            //            }
            //#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            //            catch (Exception ex)
            //#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            //            {
            //                //ProjectFunctions.SpeakError(ex.Message);
            //            }
        }



        private void FrmBarPrinting_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.SalePopUPForAllWindows(this, e);
        }

        private void BarCodeGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
            {
                BarCodeGridView.CloseEditor();
                BarCodeGridView.UpdateCurrentRow();
                BarCodeGridView.ShowEditor();
            }
        }

        private void BarCodeGridView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
            {
                BarCodeGridView.ShowEditor();
            }
        }

        private void BarCodeGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
            {
                BarCodeGridView.ShowEditor();
            }
        }

     

        private void BarCodeGrid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            BarCodeGrid_KeyDown(null, e);
        }

        private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        DataSet dsCheck = ProjectFunctions.GetDataSet(" sp_LoadRePrintBarCode '" + txtBarCode.Text + "','01'");
                        if (dsCheck.Tables[0].Rows.Count > 0)
                        {

                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["SKUPRODUCTCODE"].ToString().ToUpper() == txtBarCode.Text.Trim().ToUpper())
                                {
                                    ProjectFunctions.SpeakError("BarCode Already Loaded In This Document");
                                    txtBarCode.SelectAll();
                                    txtBarCode.Focus();
                                    e.Handled = true;
                                    return;
                                }
                            }
                            foreach (DataRow dr in dsCheck.Tables[0].Rows)
                            {
                                dt.ImportRow(dr);
                            }


                            if (dt.Rows.Count > 0)
                            {
                                BarCodeGrid.DataSource = dt;
                                BarCodeGridView.BestFitColumns();
                                txtBarCode.Text = string.Empty;
                            }
                            else
                            {
                                BarCodeGrid.DataSource = null;
                            }
                        }
                        else
                        {
                            ProjectFunctions.SpeakError("Bar Code Not Generated");
                            txtBarCode.SelectAll();
                            txtBarCode.Focus();
                            e.Handled = true;
                            return;
                        }
                    }
                    txtBarCode.Focus();
                }
                catch (Exception ex)
                {
                    ProjectFunctions.SpeakError(ex.Message);
                }
                e.Handled = true;
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            int i = 0;
            DataTable dtNew = new DataTable();
            foreach (DataRow dr in (BarCodeGrid.DataSource as DataTable).Rows)
            {

                DataSet ds = ProjectFunctions.GetDataSet("[sp_PrintBarCodeDuplicate1] '" + dr["SKUPRODUCTCODE"].ToString() + "','" + GlobalVariables.CUnitID + "'");
                if (i == 0)
                {
                    dtNew = ds.Tables[0].Clone();
                    dtNew = ds.Tables[0];
                    i++;
                }
                else
                {
                    dtNew.Merge(ds.Tables[0]);
                }

            }
            if (dtNew.Rows.Count > 0)
            {
                using (var pt = new DevExpress.XtraReports.UI.ReportPrintTool(new Prints.BarPrinting() { DataSource = dtNew }))
                {
                    pt.ShowRibbonPreviewDialog();
                }
            }
        }



     
       
        private void BarCodeGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            BarCodeGridView.ShowEditor();

        }

        private void BarCodeGridView_ColumnChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
                {
                    BarCodeGridView.ShowEditor();
                }

            }

        }

        private void BarCodeGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
                {
                    BarCodeGridView.ShowEditor();
                }

            }
        }

        private void BarCodeGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
                {
                    BarCodeGridView.ShowEditor();
                }

            }
        }

        private void BarCodeGridView_GotFocus(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
                {
                    BarCodeGridView.ShowEditor();
                }

            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            var xlConn = string.Empty;
            xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter("SELECT [GENERIC ART],[GENERIC ARTICLE NAME],SEGMENT,[BRICK DESCRIPTION],[HSN CODE] FROM [Sheet1$]", xlConn))
            {
                myCommand.Fill(dtGeneric);

                foreach (DataRow dr in dtGeneric.Rows)
                {
                    DataSet dsCheckGroup = ProjectFunctions.GetDataSet("select GrpDesc from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'");
                    if (dsCheckGroup.Tables[0].Rows.Count > 0)
                    {

                    }
                    else
                    {
                        ProjectFunctions.GetDataSet(" Insert into GrpMst(GrpCode,GrpDesc)values((Select max(isnull(GrpCode,0))+1 from GrpMst),'" + dr["SEGMENT"].ToString().Trim() + "')");

                    }
                    DataSet dsCheckSubGroup = ProjectFunctions.GetDataSet("select GrpSubDesc,GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "' And GrpSubDesc='" + dr["BRICK DESCRIPTION"].ToString().Trim() + "'");
                    if (dsCheckSubGroup.Tables[0].Rows.Count > 0)
                    {

                    }
                    else
                    {
                        ProjectFunctions.GetDataSet(" Insert into GrpMst(GrpCode,GrpSubCode,GrpDesc,GrpSubDesc,GrpHSNCode)values((Select Distinct GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'),((Select max(isnull(GrpSubCode,0))+1 from GrpMst Where GrpCode=(Select Distinct GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'))),'" + dr["SEGMENT"].ToString().Trim() + "','" + dr["BRICK DESCRIPTION"].ToString().Trim() + "','" + dr["HSN CODE"].ToString() + "')");

                    }
                }
            }

            XtraMessageBox.Show("Process Completed");
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog2.ShowDialog();
        }

        private void OpenFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {

                var xlConn2 = string.Empty;
                xlConn2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog2.FileName + ";Extended Properties=\"Excel 12.0;\";";
                using (var myCommand = new OleDbDataAdapter("SELECT [GENERIC ART],[GENERIC ARTICLE NAME],[MRP], [SIZE],[COLOR]  FROM [Sheet1$]", xlConn2))
                {
                    myCommand.Fill(dtVariants);

                    foreach (DataRow dr in dtVariants.Rows)
                    {
                        DataSet dsCheckSIZE = ProjectFunctions.GetDataSet("select SZNAME from SIZEMAST Where SZNAME='" + dr["SIZE"].ToString().Trim() + "'");
                        if (dsCheckSIZE.Tables[0].Rows.Count > 0)
                        {

                        }
                        else
                        {
                            ProjectFunctions.GetDataSet("  Insert into SIZEMAST (SZNAME,SZDESC)values('" + dr["SIZE"].ToString().Trim() + "','" + dr["SIZE"].ToString().Trim() + "')");

                        }
                        DataSet dsCheckColor = ProjectFunctions.GetDataSet("select COLNAME from COLOURS Where COLNAME='" + dr["COLOR"].ToString().Trim() + "'");
                        if (dsCheckColor.Tables[0].Rows.Count > 0)
                        {

                        }
                        else
                        {
                            ProjectFunctions.GetDataSet(" Insert into COLOURS(COLNAME)values('" + dr["COLOR"].ToString().Trim() + "')");
                        }
                    }
                }


                foreach (DataRow dr in dtGeneric.Rows)
                {

                    DataSet dsCheckArticle = ProjectFunctions.GetDataSet("select * from Article Where ARTNO='" + dr["GENERIC ARTICLE NAME"].ToString().Trim() + "'");
                    if (dsCheckArticle.Tables[0].Rows.Count > 0)
                    {

                    }
                    else
                    {
                        DataSet dsCheckGroup = ProjectFunctions.GetDataSet("select GrpCode,GrpDesc from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'");
                        DataSet dsCheckSubGroup = ProjectFunctions.GetDataSet("select GrpSubDesc,GrpCode,GrpSubCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "' And GrpSubDesc='" + dr["BRICK DESCRIPTION"].ToString().Trim() + "'");

                        decimal MRP = 0;
                        foreach (DataRow drMRP in dtVariants.Rows)
                        {
                            if (dr["GENERIC ART"].ToString() == drMRP["GENERIC ART"].ToString())
                            {
                                MRP = Convert.ToDecimal(drMRP["MRP"]);
                                break;
                            }
                        }
                        ProjectFunctions.GetDataSet("Insert into Article (ARTDATE,ARTNO,ARTSECTIONID,ARTSBSECTIONID,ARTMRP,ATaxCodeLocal,ATaxCodeCentral,ARTBRANDID,ARTUOM,ARTMARGIN)values(getdate(), '" + dr["GENERIC ARTICLE NAME"].ToString().Trim() + "','" + dsCheckGroup.Tables[0].Rows[0]["GrpCode"].ToString() + "','" + dsCheckSubGroup.Tables[0].Rows[0]["GrpSubCode"].ToString() + "','" + MRP + "','0001','0002','1','0002','37.50')");

                    }

                }

                ProjectFunctions.GetDataSet("update ARTICLE Set ARTICLE.ARTALIAS=cast(PISourceData.[GENERIC ART] as bigint) from ARTICLE inner join PISourceData  on ARTICLE.ARTNO=PISourceData.[GENERIC ARTICLE NAME]");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void TxtDeptCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadEANDataFStore '" + txtDeptCode.Text + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                    BarCodeGrid.DataSource = dt;
                    BarCodeGridView.BestFitColumns();
                }
                else
                {
                    BarCodeGrid.DataSource = null;
                    BarCodeGridView.BestFitColumns();

                }
            }
        }

        private void RBIMPORT_CheckedChanged(object sender, EventArgs e)
        {

            btnImport.Visible = true;
            BTNIMPORT2.Visible = true;


        }

        private void RBDIRECT_CheckedChanged(object sender, EventArgs e)
        {
            btnImport.Visible = false;
            BTNIMPORT2.Visible = false;
        }

        private void TxtDeptCode_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}