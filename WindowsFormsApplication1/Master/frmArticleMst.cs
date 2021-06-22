using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmArticleMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }

        public string PrdCode { get; set; }

        public frmArticleMst() { InitializeComponent(); }


        private void TxtUMCode_EditValueChanged(object sender, EventArgs e)
        {

            txtUMDesc.Text = string.Empty;

        }

        private void TxtUMCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select UomCode,UomDesc from UomMst",
                                                        " Where UomCode",
                                                        txtUMCode,
                                                        txtUMDesc,
                                                        txtUMCode,
                                                        HelpGrid,
                                                        HelpGridView,
                                                        e);
            }

            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void TxtSGrpCode_EditValueChanged(object sender, EventArgs e)
        {
            txtSGrpDesc.Text = string.Empty;
            //txtGrpCode.Text = "";
            txtSGrpDesc.Text = string.Empty;
        }

        private void TxtSGrpCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGridView.Columns.Clear();
                    HelpGrid.Text = "txtSGrpCode";
                    DataSet ds = ProjectFunctions.GetDataSet("Select GrpSubCode,GrpSubDesc,GrpCode,GrpDesc,GrpHSNCode from GrpMst");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Visible = true;
                        HelpGrid.Focus();
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void SetMyControls()
        {
            try
            {
                ProjectFunctions.TextBoxVisualize(this);

                ProjectFunctions.TextBoxVisualize(GroupBox16);
                ProjectFunctions.TextBoxVisualize(GroupBox2);
                ProjectFunctions.TextBoxVisualize(GroupBox3);
                ProjectFunctions.TextBoxVisualize(GroupBox4);
                ProjectFunctions.TextBoxVisualize(GroupBox6);
                ProjectFunctions.TextBoxVisualize(GroupBox7);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);


                txtAlias.Properties.MaxLength = 100;
                txtArticleName.Properties.MaxLength = 100;
                txtArtNo.Properties.MaxLength = 100;
                txtDescription.Properties.MaxLength = 100;
                txtHSNCode.Properties.MaxLength = 100;
                txtMargin.Properties.MaxLength = 100;

                txtMRP.Properties.MaxLength = 100;
                txtPurPrice.Properties.MaxLength = 100;
                txtRSP.Properties.MaxLength = 100;
                txtTo.Properties.MaxLength = 100;


                txtWSP.Properties.MaxLength = 100;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
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

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

                if (HelpGrid.Text == "txtTaxCodeL")
                {
                    txtTaxCodeL.Text = row["TaxCode"].ToString();
                    txtTaxCodeLDesc.Text = row["TaxDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtTaxCodeC.Focus();
                }
                if (HelpGrid.Text == "txtTaxCodeC")
                {
                    txtTaxCodeC.Text = row["TaxCode"].ToString();
                    txtTaxCodeCDesc.Text = row["TaxDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtTaxCodeC.Focus();
                }
                if (HelpGrid.Text == "txtUMCode")
                {
                    txtUMCode.Text = row["UomCode"].ToString();
                    txtUMDesc.Text = row["UomDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtMRP.Focus();
                }
                if (HelpGrid.Text == "txtBrandCode")
                {
                    txtBrandCode.Text = row["BRSYSID"].ToString();
                    txtBrandDesc.Text = row["BRNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtUMCode.Focus();
                }
                if (HelpGrid.Text == "txtSGrpCode")
                {
                    txtSGrpCode.Text = row["GrpSubCode"].ToString();
                    txtSGrpDesc.Text = row["GrpSubDesc"].ToString();
                    txtGrpCode.Text = row["GrpCode"].ToString();
                    txtGrpDesc.Text = row["GrpDesc"].ToString();
                    txtHSNCode.Text = row["GrpHSNCode"].ToString();
                    HelpGrid.Visible = false;
                    txtArtNo.Focus();
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e) { Close(); }

        private void FrmArticleMst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnSave_Click(null, e);
            }
        }

        private void CaptureScreen()
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                ArticleImageBox.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);



                using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                {
                    sqlcon.Open();
                    string str = string.Empty;
                    DataSet ds = ProjectFunctions.GetDataSet("Select * from article where ARTSYSID='" + PrdCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        str = "update article Set ARTIMAGE= @photo Where ARTSYSID=@ARTSYSID";

                        var sqlcom = new SqlCommand(str, sqlcon);
                        sqlcom.Parameters.AddWithValue("@photo", photo);
                        sqlcom.Parameters.AddWithValue("@ARTSYSID", PrdCode);
                        sqlcom.CommandType = CommandType.Text;
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Picture Saved Successfully");
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void FrmArticleMst_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (S1 == "&Add")
                {
                    GroupBox4.Focus();
                    txtSGrpCode.Focus();
                    RBMANUART.Checked = true;
                    RBARTINDVI.Checked = true;
                    txtMargin.Text = "37.50";
                    RBARTUNIQUE.Checked = true;
                }
                if (S1 == "Edit")
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadArticleMstFEdit '" + PrdCode + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtSysID.Text = PrdCode;
                        txtAlias.Text = ds.Tables[0].Rows[0]["ARTALIAS"].ToString();
                        txtArticleName.Text = ds.Tables[0].Rows[0]["ARTNAME"].ToString();
                        txtArtNo.Text = ds.Tables[0].Rows[0]["ARTNO"].ToString();
                        txtBrandCode.Text = ds.Tables[0].Rows[0]["ARTBRANDID"].ToString();
                        txtBrandDesc.Text = ds.Tables[0].Rows[0]["BRNAME"].ToString();
                        txtDescription.Text = ds.Tables[0].Rows[0]["ARTDESC"].ToString();


                        txtGrpCode.Text = ds.Tables[0].Rows[0]["ARTSECTIONID"].ToString();
                        txtGrpDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                        txtHSNCode.Text = ds.Tables[0].Rows[0]["GrpHSNCode"].ToString();
                        txtSGrpCode.Text = ds.Tables[0].Rows[0]["ARTSBSECTIONID"].ToString();
                        txtSGrpDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();
                        //////txtTo.Text = ds.Tables[0].Rows[0]["PrdTaxCodeC"].ToString();
                        txtUMCode.Text = ds.Tables[0].Rows[0]["ARTUOM"].ToString();
                        txtUMDesc.Text = ds.Tables[0].Rows[0]["UomDesc"].ToString();


                        txtTaxCodeL.Text = ds.Tables[0].Rows[0]["ATaxCodeLocal"].ToString();
                        txtTaxCodeLDesc.Text = ds.Tables[0].Rows[0]["TaxDesc"].ToString();
                        txtTaxCodeC.Text = ds.Tables[0].Rows[0]["ATaxCodeCentral"].ToString();
                        txtTaxCodeCDesc.Text = ds.Tables[0].Rows[0]["Expr1"].ToString();


                        txtMRP.Text = ds.Tables[0].Rows[0]["ARTMRP"].ToString();
                        txtPurPrice.Text = ds.Tables[0].Rows[0]["ARTPURPRICE"].ToString();

                        txtWSP.Text = ds.Tables[0].Rows[0]["ARTWSP"].ToString();
                        txtMargin.Text = ds.Tables[0].Rows[0]["ARTMARGIN"].ToString();
                        txtRSP.Text = ds.Tables[0].Rows[0]["ARTRSP"].ToString();

                        if (ds.Tables[0].Rows[0]["ARTCODSCHEM"].ToString() == "0")
                        {
                            RBARTUNIQUE.Checked = true;
                        }
                        else
                        {
                            if (ds.Tables[0].Rows[0]["ARTCODSCHEM"].ToString() == "1")
                            {
                                RBARTFIXD.Checked = true;
                            }
                            else
                            {
                                RBARTLOT.Checked = false;
                            }
                        }


                        if (ds.Tables[0].Rows[0]["ARTGENMODAUTO"].ToString() == "1")
                        {
                            RBMANUART.Checked = false;
                            RBARTINDVI.Checked = false;
                            RBAUTOART.Checked = true;
                        }
                        else
                        {
                            RBMANUART.Checked = true;
                            RBARTINDVI.Checked = true;
                            RBAUTOART.Checked = false;
                        }
                        if (ds.Tables[0].Rows[0]["ARTIDENTMOD"].ToString() == "1")
                        {
                            RBARTINDVI.Checked = true;
                        }
                        else
                        {
                            RBARTINDVI.Checked = false;
                        }


                        if (ds.Tables[0].Rows[0]["ARTSETNAME"].ToString() == "1")
                        {
                            RBARTSET.Checked = true;
                        }
                        else
                        {
                            RBARTSET.Checked = false;
                        }

                        if (ds.Tables[0].Rows[0]["ARTNMAINTSTK"].ToString() == "1")
                        {
                            CHKARTNONMAINT.Checked = true;
                        }
                        else
                        {
                            CHKARTNONMAINT.Checked = false;
                        }
                        if (ds.Tables[0].Rows[0]["ARTMRKFXPRC"].ToString() == "1")
                        {
                            CHKARTFXPRICE.Checked = true;
                        }
                        else
                        {
                            CHKARTFXPRICE.Checked = false;
                        }

                        txtSGrpCode.Focus();

                        if (ds.Tables[0].Rows[0]["ARTIMAGE"].ToString().Trim() != string.Empty)
                        {
                            byte[] MyData = new byte[0];
                            MyData = (byte[])ds.Tables[0].Rows[0]["ARTIMAGE"];
                            MemoryStream stream = new MemoryStream(MyData) { Position = 0 };

                            ArticleImageBox.Image = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private bool ValidateData()
        {
            try
            {
                if (txtSGrpCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Article Sub Group");
                    txtSGrpCode.Focus();
                    return false;
                }
                if (txtArtNo.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Article");
                    txtArtNo.Focus();
                    return false;
                }
                if (txtBrandCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Article Brand");
                    txtBrandCode.Focus();
                    return false;
                }

                if (txtUMCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Article Unit Of Measurment");
                    txtUMCode.Focus();
                    return false;
                }


                if (txtHSNCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Article HSN");
                    //  txtHSNCode.Focus();
                    return false;
                }
                if (txtTaxCodeL.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Tax Code Local");
                    txtTaxCodeL.Focus();
                    return false;
                }
                if (txtTaxCodeLDesc.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Tax Code Local");
                    txtTaxCodeL.Focus();
                    return false;
                }
                if (txtTaxCodeC.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Tax Code Central");
                    txtTaxCodeC.Focus();
                    return false;
                }
                if (txtTaxCodeCDesc.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Tax Code Central");
                    txtTaxCodeC.Focus();
                    return false;
                }
                if (txtMargin.Text.Trim().Length == 0)
                {
                    txtMargin.Text = "0";
                }

                if (txtMRP.Text.Trim().Length == 0)
                {
                    txtMRP.Text = "0";
                }
                if (txtPurPrice.Text.Trim().Length == 0)
                {
                    txtPurPrice.Text = "0";
                }
                if (txtRSP.Text.Trim().Length == 0)
                {
                    txtRSP.Text = "0";
                }

                if (txtWSP.Text.Trim().Length == 0)
                {
                    txtWSP.Text = "0";
                }
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
            try
            {
                if (ValidateData())
                {
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
                                sqlcom.CommandText = "Insert into ARTICLE" +
                                    " (ARTCODSCHEM, ARTGENMODAUTO,ARTIDENTMOD,ARTDATE,ARTNO,ARTALIAS,ARTSETNAME,ARTNAME,ARTDESC,ARTSECTIONID," +
                                    " ARTSBSECTIONID,ARTBRANDID,ARTUOM,ARTPURPRICE,ARTWSP,ARTMRP,ARTMARGIN,ARTNMAINTSTK,ARTMRKFXPRC,ATaxCodeLocal,ATaxCodeCentral)" +
                                    " values(@ARTCODSCHEM,@ARTGENMODAUTO,@ARTIDENTMOD,@ARTDATE,@ARTNO,@ARTALIAS,@ARTSETNAME,@ARTNAME,@ARTDESC,@ARTSECTIONID," +
                                    " @ARTSBSECTIONID,@ARTBRANDID,@ARTUOM,@ARTPURPRICE,@ARTWSP,@ARTMRP,@ARTMARGIN,@ARTNMAINTSTK,@ARTMRKFXPRC,@ATaxCodeLocal,@ATaxCodeCentral)";
                            }
                            if (S1 == "Edit")
                            {
                                sqlcom.CommandText = " UPDATE  ARTICLE Set" +
                                    " ARTCODSCHEM=@ARTCODSCHEM,ARTGENMODAUTO=@ARTGENMODAUTO,ARTIDENTMOD=@ARTIDENTMOD,ARTDATE=@ARTDATE,ARTNO=@ARTNO,ARTALIAS=@ARTALIAS,ARTSETNAME=@ARTSETNAME,ARTNAME=@ARTNAME,ARTDESC=@ARTDESC,ARTBRANDID=@ARTBRANDID,ARTSECTIONID=@ARTSECTIONID,ARTSBSECTIONID=@ARTSBSECTIONID, " +
                                    "ARTUOM=@ARTUOM,ARTPURPRICE=@ARTPURPRICE,ARTWSP=@ARTWSP,ARTMRP=@ARTMRP,ARTMARGIN=@ARTMARGIN,ARTNMAINTSTK=@ARTNMAINTSTK,ARTMRKFXPRC=@ARTMRKFXPRC,ATaxCodeLocal=@ATaxCodeLocal,ATaxCodeCentral=@ATaxCodeCentral" +
                                    " Where ARTSYSID=@ARTSYSID";
                                sqlcom.Parameters.AddWithValue("@ARTSYSID", txtSysID.Text.Trim());
                                CaptureScreen();
                            }
                            if (RBARTUNIQUE.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "0");
                            }
                            else
                            {
                                if (RBARTFIXD.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "1");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "2");
                                }
                            }
                            if (RBMANUART.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTGENMODAUTO", "0");
                            }
                            else
                            {
                                sqlcom.Parameters.AddWithValue("@ARTGENMODAUTO", "1");
                            }
                            if (RBARTINDVI.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTIDENTMOD", "0");
                            }
                            else
                            {
                                sqlcom.Parameters.AddWithValue("@ARTIDENTMOD", "1");
                            }
                            sqlcom.Parameters.AddWithValue("@ARTDATE", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            sqlcom.Parameters.AddWithValue("@ARTNO", txtArtNo.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTALIAS", txtAlias.Text.Trim());
                            if (RBARTSET.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTSETNAME", "1");
                            }
                            else
                            {
                                sqlcom.Parameters.AddWithValue("@ARTSETNAME", "0");
                            }

                            sqlcom.Parameters.AddWithValue("@ARTNAME", txtArticleName.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTDESC", txtDescription.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTBRANDID", txtBrandCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTSECTIONID", txtGrpCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTSBSECTIONID", txtSGrpCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTUOM", txtUMCode.Text.Trim());
                            sqlcom.Parameters.AddWithValue("@ARTPURPRICE", Convert.ToDecimal(txtPurPrice.Text));

                            sqlcom.Parameters.AddWithValue("@ARTWSP", Convert.ToDecimal(txtWSP.Text));
                            sqlcom.Parameters.AddWithValue("@ARTMRP", Convert.ToDecimal(txtMRP.Text));

                            sqlcom.Parameters.AddWithValue("@ARTRSP", Convert.ToDecimal(txtRSP.Text));
                            sqlcom.Parameters.AddWithValue("@ARTMARGIN", Convert.ToDecimal(txtMargin.Text));
                            if (CHKARTNONMAINT.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTNMAINTSTK", "1");
                            }
                            else
                            {
                                sqlcom.Parameters.AddWithValue("@ARTNMAINTSTK", "0");
                            }
                            if (CHKARTFXPRICE.Checked)
                            {
                                sqlcom.Parameters.AddWithValue("@ARTMRKFXPRC", "1");
                            }
                            else
                            {
                                sqlcom.Parameters.AddWithValue("@ARTMRKFXPRC", "0");
                            }
                            sqlcom.Parameters.AddWithValue("@ATaxCodeLocal", txtTaxCodeL.Text);
                            sqlcom.Parameters.AddWithValue("@ATaxCodeCentral", txtTaxCodeC.Text);
                            sqlcom.ExecuteNonQuery();
                            transaction.Commit();
                            sqlcon.Close();
                            ProjectFunctions.SpeakError("Data Saved Successfully");
                            Close();
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
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtBrandCode_EditValueChanged(object sender, EventArgs e) { txtBrandDesc.Text = string.Empty; }

        private void TxtBrandCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select BRSYSID,BRNAME from BRANDS",
                                                        " Where BRSYSID",
                                                        txtBrandCode,
                                                        txtBrandDesc,
                                                        txtUMCode,
                                                        HelpGrid,
                                                        HelpGridView,
                                                        e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtPurPrice_KeyPress(object sender, KeyPressEventArgs e)
        { ProjectFunctions.NumericWithDecimal(e); }



        private void TxtDescription_Enter(object sender, EventArgs e)
        { txtDescription.Text = txtGrpDesc.Text + " - " + txtSGrpDesc.Text; }


        private void CalculationMRP()
        {
            if (txtMRP.Text.Trim().Length == 0)
            {
                txtMRP.Text = "0";
            }
            if (txtMargin.Text.Trim().Length == 0)
            {
                txtMargin.Text = "0";
            }
            if (txtWSP.Text.Trim().Length == 0)
            {
                txtWSP.Text = "0";
            }
            if (Convert.ToDecimal(txtMRP.Text) > 0)
            {
                txtWSP.Text = (Convert.ToDecimal(txtMRP.Text) -
                    ((Convert.ToDecimal(txtMRP.Text) * Convert.ToDecimal(txtMargin.Text)) / 100)).ToString("0.00");
            }
            else
            {
                txtWSP.EditValue = Convert.ToDecimal("0");
            }
        }

        private void CalculationWSP()
        {
            if (txtMRP.Text.Trim().Length == 0)
            {
                txtMRP.Text = "0";
            }
            if (txtMargin.Text.Trim().Length == 0)
            {
                txtMargin.Text = "0";
            }
            if (txtWSP.Text.Trim().Length == 0)
            {
                txtWSP.Text = "0";
            }

            txtMRP.EditValue = ProjectFunctions.RoundFive((Convert.ToDecimal(txtWSP.Text) /
                (100 - Convert.ToDecimal(txtMargin.Text)) * 100));
        }



        private void TxtMRP_EditValueChanged(object sender, EventArgs e)
        {
            //CalculationMRP();
        }

        private void TxtWSP_EditValueChanged(object sender, EventArgs e)
        {
            // CalculationWSP();
        }

        private void TxtWSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculationWSP();
            }
        }

        private void TxtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculationMRP();
            }
        }

        private void TxtArtNo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (S1 == "&Add")
                    {
                        DataSet dsArtNo = ProjectFunctions.GetDataSet("select ARTNO from ARTICLE where ARTNO='" + txtArtNo.Text + "'");
                        if (dsArtNo.Tables[0].Rows.Count > 0)
                        {
                            XtraMessageBox.Show("Article No Already Exists");
                            txtArtNo.Text = string.Empty;
                            txtArtNo.Focus();
                        }

                        txtArticleName.Text = txtArtNo.Text;
                        txtDescription.Text = txtGrpDesc.Text + " - " + txtSGrpDesc.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                    {
                        sqlcon.Open();
                        var sqlcom = sqlcon.CreateCommand();
                        sqlcom.Connection = sqlcon;
                        sqlcom.CommandType = CommandType.Text;
                        if (S1 == "&Add")
                        {
                            for (int i = Convert.ToInt32(txtFrom.Text); i <= Convert.ToInt32(txtTo.Text); i++)
                            {
                                sqlcom.CommandText = "Insert into ARTICLE" +
                                    " (ARTCODSCHEM, ARTGENMODAUTO,ARTIDENTMOD,ARTDATE,ARTNO,ARTALIAS,ARTSETNAME,ARTNAME,ARTDESC,ARTSECTIONID," +
                                    " ARTSBSECTIONID,ARTBRANDID,ARTUOM,ARTPURPRICE,ARTWPPRCN,ARTWSP,ARTMRP,ARTMPPRCN,ARTRSP,ARTMARGIN,ARTNMAINTSTK,ARTMRKFXPRC,ATaxCodeLocal,ATaxCodeCentral)" +
                                    " values(@ARTCODSCHEM,@ARTGENMODAUTO,@ARTIDENTMOD,@ARTDATE,@ARTNO,@ARTALIAS,@ARTSETNAME,@ARTNAME,@ARTDESC,@ARTSECTIONID," +
                                    " @ARTSBSECTIONID,@ARTBRANDID,@ARTUOM,@ARTPURPRICE,@ARTWPPRCN,@ARTWSP,@ARTMRP,@ARTMPPRCN,@ARTRSP,@ARTMARGIN,@ARTNMAINTSTK,@ARTMRKFXPRC,@ATaxCodeLocal,@ATaxCodeCentral)";


                                if (RBARTUNIQUE.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "0");
                                }
                                else if (RBARTFIXD.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "1");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTCODSCHEM", "2");
                                }

                                if (RBMANUART.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTGENMODAUTO", "0");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTGENMODAUTO", "1");
                                }

                                if (RBARTINDVI.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTIDENTMOD", "0");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTIDENTMOD", "1");
                                }

                                sqlcom.Parameters.AddWithValue("@ARTDATE", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                sqlcom.Parameters
                                    .AddWithValue("@ARTNO", txtPreFIx.Text.Trim() + i.ToString().PadLeft(2, '0'));
                                sqlcom.Parameters.AddWithValue("@ARTALIAS", txtAlias.Text.Trim());
                                if (RBARTSET.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTSETNAME", "1");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTSETNAME", "0");
                                }

                                sqlcom.Parameters.AddWithValue("@ARTNAME", txtArticleName.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTDESC", txtDescription.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTBRANDID", txtBrandCode.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTSECTIONID", txtGrpCode.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTSBSECTIONID", txtSGrpCode.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTUOM", txtUMCode.Text.Trim());
                                sqlcom.Parameters.AddWithValue("@ARTPURPRICE", Convert.ToDecimal(txtPurPrice.Text));

                                sqlcom.Parameters.AddWithValue("@ARTWSP", Convert.ToDecimal(txtWSP.Text));
                                sqlcom.Parameters.AddWithValue("@ARTMRP", Convert.ToDecimal(txtMRP.Text));

                                sqlcom.Parameters.AddWithValue("@ARTRSP", Convert.ToDecimal(txtRSP.Text));
                                sqlcom.Parameters.AddWithValue("@ARTMARGIN", Convert.ToDecimal(txtMargin.Text));
                                if (CHKARTNONMAINT.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTNMAINTSTK", "1");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTNMAINTSTK", "0");
                                }

                                if (CHKARTFXPRICE.Checked)
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTMRKFXPRC", "1");
                                }
                                else
                                {
                                    sqlcom.Parameters.AddWithValue("@ARTMRKFXPRC", "0");
                                }

                                sqlcom.Parameters.AddWithValue("@ATaxCodeLocal", txtTaxCodeL.Text);
                                sqlcom.Parameters.AddWithValue("@ATaxCodeCentral", txtTaxCodeC.Text);
                                sqlcom.ExecuteNonQuery();
                                sqlcom.Parameters.Clear();
                            }
                        }

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void RBMANUART_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMANUART.Checked)
            {
                Label3.Visible = true;
                txtArtNo.Visible = true;

                label16.Visible = false;
                label10.Visible = false;
                label13.Visible = false;

                txtFrom.Visible = false;
                txtTo.Visible = false;
                txtPreFIx.Visible = false;

                btnSave.Visible = true;
            }
            else
            {
                Label3.Visible = false;
                txtArtNo.Visible = false;

                label16.Visible = false;
                label10.Visible = false;
                label13.Visible = false;

                txtFrom.Visible = false;
                txtTo.Visible = false;
                txtPreFIx.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void RBAUTOART_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAUTOART.Checked)
            {
                Label3.Visible = false;
                txtArtNo.Visible = false;

                label16.Visible = true;
                label10.Visible = true;
                label13.Visible = true;

                txtFrom.Visible = true;
                txtTo.Visible = true;
                txtPreFIx.Visible = true;

                btnSaveAll.Visible = true;
            }
            else
            {
                Label3.Visible = true;
                txtArtNo.Visible = true;
                label16.Visible = false;
                label10.Visible = false;
                label13.Visible = false;

                txtFrom.Visible = false;
                txtTo.Visible = false;
                txtPreFIx.Visible = false;
                btnSaveAll.Visible = false;
            }
        }

        private void TxtTaxCodeL_EditValueChanged(object sender, EventArgs e) { txtTaxCodeLDesc.Text = string.Empty; }

        private void TxtTaxCodeC_EditValueChanged(object sender, EventArgs e) { txtTaxCodeCDesc.Text = string.Empty; }

        private void TxtTaxCodeL_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select TaxCode,TaxDesc from TaxMst",
                                                        " Where TaxCode",
                                                        txtTaxCodeL,
                                                        txtTaxCodeLDesc,
                                                        txtTaxCodeC,
                                                        HelpGrid,
                                                        HelpGridView,
                                                        e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtTaxCodeC_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select TaxCode,TaxDesc from TaxMst",
                                                        " Where TaxCode",
                                                        txtTaxCodeC,
                                                        txtTaxCodeCDesc,
                                                        txtTaxCodeC,
                                                        HelpGrid,
                                                        HelpGridView,
                                                        e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }


    }
}