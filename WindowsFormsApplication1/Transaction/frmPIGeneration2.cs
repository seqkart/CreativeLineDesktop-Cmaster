using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class FrmPIGeneration2 : DevExpress.XtraEditors.XtraForm
    {

        int i = 0;


        DataTable dt = new DataTable();
        public string S1 { get; set; }
        public string DocNo { get; set; }

        public string FromExcel { get; set; }
        public DateTime DocDate { get; set; }
        public FrmPIGeneration2()
        {
            InitializeComponent();

            dt.Columns.Add("ARTNO", typeof(string));
            dt.Columns.Add("ARTALIAS", typeof(string));
            dt.Columns.Add("VARIANTART", typeof(string));
            dt.Columns.Add("ARTMRP", typeof(string));
            dt.Columns.Add("SIZE", typeof(string));
            dt.Columns.Add("COLOR", typeof(string));
            dt.Columns.Add("COLSYSID", typeof(string));
            dt.Columns.Add("SZSYSID", typeof(string));
            dt.Columns.Add("ARTSYSID", typeof(string));
            dt.Columns.Add("GrpDesc", typeof(string));
            dt.Columns.Add("GrpSubDesc", typeof(string));
            dt.Columns.Add("GrpHSNCode", typeof(string));
            dt.Columns.Add("EANNo", typeof(string));
            dt.Columns.Add("PIQty", typeof(string));


        }
        private void SetMyControls()
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string GetNewInvoiceDocumentNo()
        {
            var s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(PINo as int)),000000) from PIMstNew ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }
            return s2;
        }
        private void FrmPIGeneration2_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtPIDate.EditValue = DateTime.Now;
                txtPINo.Text = GetNewInvoiceDocumentNo().PadLeft(6, '0');
            }
            if (S1 == "Edit")
            {
                txtPIDate.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadPIMstNewFEDit '" + DocNo + "','" + Convert.ToDateTime(DocDate).ToString("yyyy-MM-dd") + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPIDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["PIDate"]);
                    txtPINo.Text = ds.Tables[0].Rows[0]["PINo"].ToString();
                    txtStoreCode.Text = ds.Tables[0].Rows[0]["PIStoreCode"].ToString();

                    // DataTable TempTable = new DataTable();
                    //TempTable = ds.Tables[1];


                    //foreach (DataRow dr in TempTable.Rows)
                    //{
                    //    DataSet dsInner = ProjectFunctions.GetDataSet("sp_LoadEANDataNew '" + dr["EANNo"].ToString() + "'");
                    //    if (dsInner.Tables[0].Rows.Count > 0)
                    //    {
                    //        DataRow dataRow = dt.NewRow();

                    //        dataRow["ARTNO"] = dsInner.Tables[0].Rows[0]["ARTNO"].ToString();
                    //        dataRow["ARTALIAS"] = dsInner.Tables[0].Rows[0]["ARTALIAS"].ToString();
                    //        dataRow["VARIANTART"] = dsInner.Tables[0].Rows[0]["VARIANT ART"].ToString();
                    //        dataRow["ARTMRP"] = dsInner.Tables[0].Rows[0]["ARTMRP"].ToString();
                    //        dataRow["SIZE"] = dsInner.Tables[0].Rows[0]["SIZE"].ToString();
                    //        dataRow["COLOR"] = dsInner.Tables[0].Rows[0]["COLOR"].ToString();
                    //        dataRow["COLSYSID"] = dsInner.Tables[0].Rows[0]["COLSYSID"].ToString();
                    //        dataRow["SZSYSID"] = dsInner.Tables[0].Rows[0]["SZSYSID"].ToString();
                    //        dataRow["ARTSYSID"] = dsInner.Tables[0].Rows[0]["ARTSYSID"].ToString();
                    //        dataRow["GrpDesc"] = dsInner.Tables[0].Rows[0]["GrpDesc"].ToString();
                    //        dataRow["GrpSubDesc"] = dsInner.Tables[0].Rows[0]["GrpSubDesc"].ToString();




                    //        dataRow["PIQty"] = Convert.ToDecimal(dr["PIQty"]);
                    //        dataRow["EANNo"] = Convert.ToDecimal(dr["EANNo"]);

                    //        dataRow["GrpHSNCode"] = dsInner.Tables[0].Rows[0]["GrpHSNCode"].ToString();
                    //        dt.Rows.Add(dataRow);
                    //    }
                    //}


                    //foreach (DataRow dr in TempTable.Rows)
                    //{

                    //    foreach (DataRow dr2 in ds.Tables[2].Rows)
                    //    {
                    //        if (dr["EANNo"].ToString().ToUpper() == dr2["EAN NUMBER"].ToString().ToUpper())
                    //        {
                    //            DataRow dataRow = dt.NewRow();

                    //            dataRow["ARTNO"] = dr2["ARTNO"].ToString();
                    //            dataRow["ARTALIAS"] = dr2["ARTALIAS"].ToString();
                    //            dataRow["VARIANTART"] = dr2["VARIANT ART"].ToString();
                    //            dataRow["ARTMRP"] = dr2["ARTMRP"].ToString();
                    //            dataRow["SIZE"] = dr2["SIZE"].ToString();
                    //            dataRow["COLOR"] = dr2["COLOR"].ToString();
                    //            dataRow["COLSYSID"] = dr2["COLSYSID"].ToString();
                    //            dataRow["SZSYSID"] = dr2["SZSYSID"].ToString();
                    //            dataRow["ARTSYSID"] = dr2["ARTSYSID"].ToString();
                    //            dataRow["GrpDesc"] = dr2["GrpDesc"].ToString();
                    //            dataRow["GrpSubDesc"] = dr2["GrpSubDesc"].ToString();
                    //            dataRow["PIQty"] = Convert.ToDecimal(dr["PIQty"]);
                    //            dataRow["EANNo"] = Convert.ToDecimal(dr["EANNo"]);
                    //            dataRow["GrpHSNCode"] = dr2["GrpHSNCode"].ToString();
                    //            dt.Rows.Add(dataRow);
                    //            break;
                    //        }

                    //    }

                    //}


                    dt = ds.Tables[1];
                    if (dt.Rows.Count > 0)
                    {
                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                    }
                    else
                    {
                        InfoGrid.DataSource = null;
                        InfoGridView.BestFitColumns();
                    }

                }
            }
        }

        private void InfoGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            InfoGridView.CloseEditor();
            InfoGridView.UpdateCurrentRow();
        }

        private void InfoGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            InfoGridView.CloseEditor();
            InfoGridView.UpdateCurrentRow();
        }
        private bool ValidateData()
        {



            if (txtPIDate.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid PI Date");
                txtPIDate.Focus();
                return false;
            }
            if (txtStoreCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Store ");
                txtStoreCode.Focus();
                return false;
            }


            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Loading Data ");

            if (ValidateData())
            {
                InfoGridView.CloseEditor();
                InfoGridView.UpdateCurrentRow();
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    var transaction = sqlcon.BeginTransaction("SaveTransaction");
                    sqlcom.Connection = sqlcon;
                    sqlcom.Transaction = transaction;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        if (S1 == "&Add")
                        {
                            txtPINo.Text = GetNewInvoiceDocumentNo().PadLeft(6, '0');

                            sqlcom.CommandText = "Insert into PIMstNew(PINo,PIDate,PIStoreCode)values(@PINo,@PIDate,@PIStoreCode)";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.Parameters.AddWithValue("@PIStoreCode", txtStoreCode.Text.Trim());

                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }

                        if (S1 == "Edit")
                        {

                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = "Update PIMstNew Set PIStoreCode=@PIStoreCode Where PINo = @PINo And PIDate=@PIDate ";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.Parameters.AddWithValue("@PIStoreCode", txtStoreCode.Text.Trim());
                            sqlcom.Parameters.Clear();


                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = " Delete from PIDataNew Where PINo = @PINo And PIDate=@PIDate ";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }


                        SplashScreenManager.Default.SetWaitFormDescription("Saving Data ");
                        //foreach (DataRow dr in dt.Rows)
                        //{
                        //    sqlcom.CommandType = CommandType.Text;


                        //    sqlcom.CommandText = " Insert into PIDataNew"
                        //                               + " (PINo,PIDate,PIQty,EANNo)"
                        //                               + " values(@PINo,@PIDate,@PIQty,@EANNo)";

                        //    sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                        //    sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                        //    sqlcom.Parameters.AddWithValue("@PIQty", Convert.ToDecimal(dr["PIQty"]));
                        //    sqlcom.Parameters.AddWithValue("@EANNo", dr["EANNo"].ToString());

                        //    sqlcom.ExecuteNonQuery();
                        //    sqlcom.Parameters.Clear();
                        //}




                        DataTable dtFinal = new DataTable();
                        dtFinal.Columns.Add("PINo", typeof(string));
                        dtFinal.Columns.Add("PIDate", typeof(string));
                        dtFinal.Columns.Add("PIQty", typeof(string));
                        dtFinal.Columns.Add("EANNo", typeof(string));

                        dtFinal.Rows.Clear();
                        foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
                        {
                            DataRow drRow = dtFinal.NewRow();
                            drRow["PINo"] = txtPINo.Text.Trim();
                            drRow["PIDate"] = Convert.ToDateTime(txtPIDate.Text).ToString("yyyy-MM-dd");
                            drRow["PIQty"] = dr["PIQty"].ToString();
                            drRow["EANNo"] = dr["EANNo"].ToString();
                            dtFinal.Rows.Add(drRow);
                        }
                        dtFinal.AcceptChanges();
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.CommandText = "sp_InsertPINew";
                        sqlcom.CommandTimeout = 600000;
                        SqlParameter param = new SqlParameter
                        {
                            ParameterName = "@PerformaInv",
                            Value = dtFinal
                        };
                        sqlcom.Parameters.Add(param);
                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();




                        transaction.Commit();
                        //ProjectFunctions.SpeakError("PI Data Saved Successfully");
                        sqlcon.Close();

                        if (FromExcel == "Y")
                        {
                            //  SplashScreenManager.Default.SetWaitFormDescription("Saving PI " + i.ToString());
                            i++;


                            LoadSheet();
                            DevExpress.Spreadsheet.Workbook workbook = new DevExpress.Spreadsheet.Workbook();
                            workbook.LoadDocument(openFileDialog1.FileName);
                            DevExpress.Spreadsheet.Worksheet worksheet = workbook.Worksheets[i];
                            if (i <= workbook.Sheets.Count)
                            {
                                BtnSave_Click(null, e);
                            }
                            else
                            {
                                SplashScreenManager.CloseForm(false);
                                Close();
                            }
                        }
                        else
                        {
                            SplashScreenManager.CloseForm(false);
                        }
                        Close();
                        FromExcel = "N";
                    }
                    catch (Exception ex)
                    {
                        ProjectFunctions.SpeakError("Something Wrong. \n I am going to Roll Back." + ex.Message);
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            ProjectFunctions.SpeakError("Something Wrong. \n Roll Back Failed." + ex2.Message);
                        }
                    }
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }


        private void LoadSheet()
        {
            dt.Rows.Clear();
            DevExpress.Spreadsheet.Workbook workbook = new DevExpress.Spreadsheet.Workbook();
            workbook.LoadDocument(openFileDialog1.FileName);
            DevExpress.Spreadsheet.Worksheet worksheet = workbook.Worksheets[i];
            if (i <= workbook.Sheets.Count)
            {
                txtStoreCode.Text = worksheet.Name;

                DataTable TempTable = new DataTable();
                string xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtAddress.Text + ";Extended Properties=\"Excel 12.0;\";";
                using (var myCommand = new OleDbDataAdapter("SELECT [EAN Code],[PI Qty] as [PI Qty] FROM [" + txtStoreCode.Text + "$]", xlConn))
                {
                    myCommand.Fill(TempTable);
                    if (TempTable.Rows.Count > 0)
                    {
                        foreach (DataRow dr in TempTable.Rows)
                        {
                            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadEANDataNew '" + dr["EAN Code"].ToString() + "'");
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow dataRow = dt.NewRow();

                                dataRow["ARTNO"] = ds.Tables[0].Rows[0]["ARTNO"].ToString();
                                dataRow["ARTALIAS"] = ds.Tables[0].Rows[0]["ARTALIAS"].ToString();
                                dataRow["VARIANTART"] = ds.Tables[0].Rows[0]["VARIANT ART"].ToString();
                                dataRow["ARTMRP"] = ds.Tables[0].Rows[0]["ARTMRP"].ToString();
                                dataRow["SIZE"] = ds.Tables[0].Rows[0]["SIZE"].ToString();
                                dataRow["COLOR"] = ds.Tables[0].Rows[0]["COLOR"].ToString();
                                dataRow["COLSYSID"] = ds.Tables[0].Rows[0]["COLSYSID"].ToString();
                                dataRow["SZSYSID"] = ds.Tables[0].Rows[0]["SZSYSID"].ToString();
                                dataRow["ARTSYSID"] = ds.Tables[0].Rows[0]["ARTSYSID"].ToString();
                                dataRow["GrpDesc"] = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                                dataRow["GrpSubDesc"] = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();
                                if (dr["PI Qty"].ToString().Trim().Length == 0)
                                {
                                    dr["PI Qty"] = 0;
                                }
                                dataRow["PIQty"] = Convert.ToDecimal(dr["PI Qty"]);
                                dataRow["EANNo"] = Convert.ToDecimal(dr["EAN Code"]);

                                dataRow["GrpHSNCode"] = ds.Tables[0].Rows[0]["GrpHSNCode"].ToString();
                                dt.Rows.Add(dataRow);

                            }
                        }


                        InfoGrid.DataSource = dt;
                        InfoGridView.BestFitColumns();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("PIS Created Successfully");

            }
        }
        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FromExcel = "Y";
            txtAddress.Text = openFileDialog1.FileName;
            LoadSheet();



        }

        private void BtnSKU_Click(object sender, EventArgs e)
        {
            DataSet ds = ProjectFunctions.GetDataSet("select distinct SKUVOUCHNO, SKUFNYR from SKU where SKUSYSDATE >= '2021-04-01' and isnull(skupartybarcode,'') <>'' order by SKUFNYR, SKUVOUCHNO desc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                HelpGridView.Columns.Clear();
                HelpGrid.Text = "SKU";
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
                HelpGrid.Show();
                HelpGrid.Focus();

            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow currentrow = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "SKU")
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadSKUForPI '" + currentrow["SKUVOUCHNO"].ToString() + "' ,'" + currentrow["SKUFNYR"].ToString() + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dt = ds.Tables[0];
                    InfoGrid.DataSource = ds.Tables[0];
                    InfoGridView.BestFitColumns();
                    HelpGrid.Visible = false;
                }
                else
                {
                    InfoGrid.DataSource = null;
                    InfoGridView.BestFitColumns();
                }
            }
            if (HelpGrid.Text == "STORE")
            {
                txtStoreCode.Text = currentrow["AccDCCode"].ToString();
                HelpGrid.Visible = false;
            }
        }

        private void HelpGrid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                HelpGrid.Visible = false;
            }

        }

        private void TxtStoreCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSet ds = ProjectFunctions.GetDataSet("select AccDCCode,AccName from ActMstAddInf  where isnull(AccDCCode,'') <>''");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    HelpGridView.Columns.Clear();
                    HelpGrid.Text = "STORE";
                    HelpGrid.DataSource = ds.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Show();
                    HelpGrid.Focus();

                }
            }
            e.Handled = true;
        }
    }
}