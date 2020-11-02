using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmProformaMst : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtAll = new DataTable();

        DataTable dt = new DataTable();
        public String s1 { get; set; }
        public String DocNo { get; set; }
        public DateTime DocDate { get; set; }
        public frmProformaMst()
        {
            InitializeComponent();
            dt.Columns.Add("PIBrand", typeof(String));
            dt.Columns.Add("PIEANNo", typeof(String));
            dt.Columns.Add("PIArticle", typeof(String));
            dt.Columns.Add("PIHSNCode", typeof(String));
            dt.Columns.Add("PIQyt", typeof(Decimal));
            dt.Columns.Add("PIMrp", typeof(Decimal));
            dt.Columns.Add("PTTaxPer", typeof(Decimal));
            dt.Columns.Add("PICoreFashion", typeof(String));
            dt.Columns.Add("Season", typeof(String));
            dtAll.Columns.Add("PIBrand", typeof(String));
            dtAll.Columns.Add("PIEANNo", typeof(String));
            dtAll.Columns.Add("PIArticle", typeof(String));
            dtAll.Columns.Add("PIHSNCode", typeof(String));
            dtAll.Columns.Add("PIQyt", typeof(Decimal));
            dtAll.Columns.Add("PIMrp", typeof(Decimal));
            dtAll.Columns.Add("PTTaxPer", typeof(Decimal));
            dtAll.Columns.Add("PICoreFashion", typeof(String));
            dtAll.Columns.Add("Season", typeof(String));

        }
        private void SetMyControls()
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }
        private void FrmProformaMst_Load(object sender, EventArgs e)
        {

            SetMyControls();
            if (s1 == "&Add")
            {
                txtPIDate.EditValue = DateTime.Now;
                txtPINo.Text = GetNewInvoiceDocumentNo().PadLeft(6, '0');
            }
            if (s1 == "Edit")
            {
                txtPIDate.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadPIMstFEDit '" + DocNo + "','" + Convert.ToDateTime(DocDate).ToString("yyyy-MM-dd") + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPIDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["PIDate"]);
                    txtPINo.Text = ds.Tables[0].Rows[0]["PINo"].ToString();
                    txtAccCode.Text = ds.Tables[0].Rows[0]["PIPartyCode"].ToString();
                    txtAccName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                    dt = ds.Tables[1];



                    InvoiceGrid.DataSource = dt;
                    InvoiceGridView.BestFitColumns();
                    InfoGrid.DataSource = dt;
                    InfoGridView.BestFitColumns();
                }
            }
        }

        private string GetNewInvoiceDocumentNo()
        {
            var s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(PINo as int)),000000) from PIMst ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString().Trim();
                s2 = (Convert.ToInt32(s2) + 1).ToString().Trim();
            }
            return s2;
        }

        private void TxtAccCode_EditValueChanged(object sender, EventArgs e)
        {
            txtAccName.Text = string.Empty;
            dt = null;
        }

        private void FrmProformaMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnSave_Click(null, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
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


        private void AddRowsToDatatable()
        {
            try
            {
                if (dt != null)
                {


                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
                        {
                            dtAll.ImportRow(dr);
                        }

                        if (dtAll.Rows.Count > 0)
                        {
                            InvoiceGrid.DataSource = dtAll;
                            InvoiceGridView.BestFitColumns();
                        }
                        else
                        {
                            InvoiceGrid.DataSource = null;
                            InvoiceGridView.BestFitColumns();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtAccCode")
            {
                txtAccCode.Text = row["AccCode"].ToString();
                txtAccName.Text = row["AccName"].ToString();
                HelpGrid.Visible = false;
                txtAccCode.Focus();
            }
            if (HelpGrid.Text == "Load")
            {
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadEANData '" + row[0].ToString() + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    AddRowsToDatatable();
                    dt = ds.Tables[0];
                    InfoGrid.DataSource = dt;
                    InfoGridView.BestFitColumns();
                    HelpGrid.Visible = false;
                }
                else
                {
                    InfoGrid.DataSource = null;
                }

            }
        }

        private void TxtAccCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select AccCode,AccName from ActMst ", " Where  AccCode ", txtAccCode, txtAccName, txtAccCode, HelpGrid, HelpGridView, e);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtAccCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Party ");
                txtAccCode.Focus();
                return false;
            }
            if (txtAccName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Party ");
                txtAccCode.Focus();
                return false;
            }

            return true;
        }

        private void Menu_ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                AddRowsToDatatable();
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
                        if (s1 == "&Add")
                        {
                            txtPINo.Text = GetNewInvoiceDocumentNo().PadLeft(6, '0');

                            sqlcom.CommandText = "Insert into PIMst(PINo,PIDate,PIPartyCode,PITaxableAmount,PITaxAmount,PITotalAmount)values(@PINo,@PIDate,@PIPartyCode,@PITaxableAmount,@PITaxAmount,@PITotalAmount)";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.Parameters.AddWithValue("@PIPartyCode", txtAccCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PITaxableAmount", "0");
                            sqlcom.Parameters.AddWithValue("@PITaxAmount", "0");
                            sqlcom.Parameters.AddWithValue("@PITotalAmount", "0");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }

                        if (s1 == "Edit")
                        {

                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = "Update PIMst Set PIPartyCode=@PIPartyCode,PITaxableAmount=@PITaxableAmount,PITaxAmount=@PITaxAmount,PITotalAmount=@PITotalAmount Where PINo = @PINo And PIDate=@PIDate ";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.Parameters.AddWithValue("@PIPartyCode", txtAccCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PITaxableAmount", "0");
                            sqlcom.Parameters.AddWithValue("@PITaxAmount", "0");
                            sqlcom.Parameters.AddWithValue("@PITotalAmount", "0"); sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();


                            sqlcom.CommandType = CommandType.Text;
                            sqlcom.CommandText = " Delete from PIData Where PINo = @PINo And PIDate=@PIDate ";
                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }



                        foreach (DataRow dr in dtAll.Rows)
                        {
                            sqlcom.CommandType = CommandType.Text;

                            sqlcom.CommandText = " Insert into PIData"
                                                       + " (PINo,PIDate,PIBrand,PIEANNo,PIArticle,PIHSNCode,PIQyt,PIMrp,PTTaxPer,PICoreFashion,Season)"
                                                       + " values(@PINo,@PIDate,@PIBrand,@PIEANNo,@PIArticle,@PIHSNCode,@PIQyt,@PIMrp,@PTTaxPer,@PICoreFashion,@Season)";

                            sqlcom.Parameters.AddWithValue("@PINo", txtPINo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@PIDate", Convert.ToDateTime(txtPIDate.Text));
                            sqlcom.Parameters.AddWithValue("@PIBrand", dr["PIBrand"].ToString());
                            sqlcom.Parameters.AddWithValue("@PIEANNo", dr["PIEANNo"].ToString());
                            sqlcom.Parameters.AddWithValue("@PIArticle", dr["PIArticle"].ToString());
                            sqlcom.Parameters.AddWithValue("@PIHSNCode", dr["PIHSNCode"].ToString());
                            sqlcom.Parameters.AddWithValue("@PIQyt", Convert.ToDecimal(dr["PIQyt"]));
                            sqlcom.Parameters.AddWithValue("@PIMrp", Convert.ToDecimal(dr["PIMrp"]));
                            sqlcom.Parameters.AddWithValue("@PTTaxPer", Convert.ToDecimal(dr["PTTaxPer"]));
                            sqlcom.Parameters.AddWithValue("@PICoreFashion", dr["PICoreFashion"].ToString());
                            sqlcom.Parameters.AddWithValue("@Season", dr["Season"].ToString());

                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        transaction.Commit();
                        ProjectFunctions.SpeakError("PI Data Saved Successfully");
                        sqlcon.Close();

                        this.Close();
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
            HelpGridView.Columns.Clear();
            HelpGrid.Text = "Load";
            DataSet ds = ProjectFunctions.GetDataSet("select [GENERIC ART] from PISourceData");
            if (ds.Tables[0].Rows.Count > 0)
            {
                //dt = ds.Tables[0];
                HelpGrid.DataSource = ds.Tables[0];
                HelpGridView.BestFitColumns();
                HelpGrid.Visible = true;
                HelpGrid.Show();
                HelpGrid.Focus();
            }
            else
            {
                HelpGrid.DataSource = null;
            }
        }
    }
}