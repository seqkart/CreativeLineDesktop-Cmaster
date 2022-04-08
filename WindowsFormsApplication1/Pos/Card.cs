using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Pos
{
    public partial class Card : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string MemoNo { get; set; }
        public DateTime MemoDate { get; set; }
        public decimal CardPayment { get; set; }
        public decimal PGPayment { get; set; }

        public decimal TotalMemoAmount { get; set; }
        public Card()
        {
            InitializeComponent();
        }

        private void Btvisa_Click(object sender, EventArgs e)
        {
            txtCardType.Text = "VISA";
            txtAmountPaid.Text = txtMemoAmount.Text;
            btnSave.PerformClick();
          //  txtAmountPaid.Focus();
        }



        private void Btmaestro_Click(object sender, EventArgs e)
        {
            txtCardType.Text = "MAESTRO";
            txtAmountPaid.Text = txtMemoAmount.Text;
            btnSave.PerformClick();
            //txtAmountPaid.Focus();
        }

        private void Btamex_Click(object sender, EventArgs e)
        {
            txtCardType.Text = "AMEX";
            txtAmountPaid.Text = txtMemoAmount.Text;
            btnSave.PerformClick();
           // txtAmountPaid.Focus();
        }

        private void Btmaster_Click(object sender, EventArgs e)
        {
            txtCardType.Text = "MASTER CARD";
            txtAmountPaid.Text = txtMemoAmount.Text;
            btnSave.PerformClick();

           // txtAmountPaid.Focus();
        }

        private void Btdci_Click(object sender, EventArgs e)
        {
            txtCardType.Text = "DINERS CLUB";
            txtAmountPaid.Text = txtMemoAmount.Text;
            btnSave.PerformClick();
           // txtAmountPaid.Focus();
        }





        private void Card_Load(object sender, EventArgs e)
        {
            try
            {
               
                lblMemoNo.Text = MemoNo;
                lblMemoDate.Text = MemoDate.ToString("dd-MM-yyyy");


                txtMemoAmount.Text = TotalMemoAmount.ToString("0.00");




                DataSet ds = ProjectFunctions.GetDataSet("Select * from CASHTENDER Where CATMEMONO='" + MemoNo + "' And CATMEMODATE='" + MemoDate.Date.ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtCardType.Text = ds.Tables[0].Rows[0]["CATCARDTYPE"].ToString();
                    txtCardNo.Text = ds.Tables[0].Rows[0]["CATCARDNO"].ToString();
                    txtNameOnCard.Text = ds.Tables[0].Rows[0]["CATCARDNAME"].ToString();
                    txtSLipNo.Text = ds.Tables[0].Rows[0]["CATCARDSLIPNO"].ToString();


                    txtAmountPaid.EditValue = ds.Tables[0].Rows[0]["CATCARDAMT"].ToString();
                    txtBalanceAmount.EditValue = (Convert.ToDecimal(txtMemoAmount.Text) - Convert.ToDecimal(txtAmountPaid.Text));

                    //if (Convert.ToDecimal(txtBalanceAmount.EditValue) > 0)
                    //{
                    //    WindowsFormsApplication1.Transaction.CashTender frm = new WindowsFormsApplication1.Transaction.CashTender() { MemoNo = lblMemoNo.Text, MemoDate = Convert.ToDateTime(lblMemoDate.Text), TotalMemoAmount = Convert.ToDecimal(txtMemoAmount.Text) };
                    //    var P = ProjectFunctions.GetPositionInForm(this);
                    //    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    //    frm.ShowDialog(this.Parent);
                    //}
                }
                txtCardType.Focus();
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnRevert_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private bool ValidateDataForSaving()
        {
            if (Convert.ToDecimal(txtAmountPaid.Text) > 0)
            {

            }
            else
            {
                txtAmountPaid.Focus();
                return false;
            }
            return true;
        }
        private void Save()
        {
            if (ValidateDataForSaving())
            {
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    sqlcom.Connection = sqlcon;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from CASHTENDER where CATMEMONO='" + lblMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
                        if (dsCheck.Tables[0].Rows.Count == 0)
                        {

                            sqlcom.CommandText = "Insert into CASHTENDER(CATMEMONO,CATMEMODATE,CATMEMOAMT,CATCARDAMT,CATPGAMT,CURIN2000,CURIN1000,CURIN200,CURIN500,CURIN100,CURIN50,CURIN20,CURIN10,CURIN5," +
                                "  CURIN2,CURIN1,CURINTOT,CUROUT2000,CUROUT1000,CUROUT200,CUROUT500,CUROUT100,CUROUT50,CUROUT20,CUROUT10,CUROUT5,CUROUT2,CUROUT1,CUROUTTOT,CATCARDTYPE,CATCARDNO,CATCARDNAME,CATCARDSLIPNO,UnitCode,CASHAmount,AutoCashAmount)values(" +
                                "@CATMEMONO,@CATMEMODATE,@CATMEMOAMT,@CATCARDAMT,@CATPGAMT,@CURIN2000,@CURIN1000,@CURIN200,@CURIN500,@CURIN100,@CURIN50,@CURIN20,@CURIN10,@CURIN5," +
                                "  @CURIN2,@CURIN1,@CURINTOT,@CUROUT2000,@CUROUT1000,@CUROUT200,@CUROUT500,@CUROUT100,@CUROUT50,@CUROUT20,@CUROUT10,@CUROUT5,@CUROUT2,@CUROUT1,@CUROUTTOT,@CATCARDTYPE,@CATCARDNO,@CATCARDNAME,@CATCARDSLIPNO,@UnitCode,@CASHAmount,@AutoCashAmount)";
                            sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = lblMemoNo.Text;
                            sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = TotalMemoAmount.ToString("0.00");
                            sqlcom.Parameters.Add("@CATCARDAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtAmountPaid.Text);
                            sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");

                            sqlcom.Parameters.Add("@CURIN2000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN1000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN200", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN500", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN100", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN50", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN20", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN10", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN5", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN2", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN1", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURINTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT2000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT1000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT200", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT500", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT100", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT50", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT20", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT10", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT5", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT2", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT1", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUTTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = txtCardType.Text;
                            sqlcom.Parameters.Add("@CATCARDNO", SqlDbType.NVarChar).Value = txtCardNo.Text;
                            sqlcom.Parameters.Add("@CATCARDNAME", SqlDbType.NVarChar).Value = txtNameOnCard.Text;
                            sqlcom.Parameters.Add("@CATCARDSLIPNO", SqlDbType.NVarChar).Value = txtSLipNo.Text.Trim();
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@CASHAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@AutoCashAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        else
                        {
                            sqlcom.CommandText = "Update CASHTENDER Set AutoCashAmount=@AutoCashAmount,CURIN2000=@CURIN2000,CURIN1000=@CURIN1000,CURIN200=@CURIN200,CURIN500=@CURIN500," +
                                "CURIN100=@CURIN100,CURIN50=@CURIN50,CURIN20=@CURIN20,CURIN10=@CURIN10,CURIN5=@CURIN5,CURIN2=@CURIN2,CURIN1=@CURIN1,CASHAmount=@CASHAmount,CATMEMOAMT=@CATMEMOAMT,CATCARDAMT=@CATCARDAMT,CATCARDTYPE=@CATCARDTYPE,CATCARDNO=@CATCARDNO,CATCARDNAME=@CATCARDNAME,CATCARDSLIPNO=@CATCARDSLIPNO " +
                                " Where CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' And CATMEMONO='" + lblMemoNo.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "'";


                            sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = lblMemoNo.Text;
                            sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = TotalMemoAmount.ToString("0.00");
                            sqlcom.Parameters.Add("@CATCARDAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtAmountPaid.Text);
                            sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = txtCardType.Text;
                            sqlcom.Parameters.Add("@CATCARDNO", SqlDbType.NVarChar).Value = txtCardNo.Text;
                            sqlcom.Parameters.Add("@CATCARDNAME", SqlDbType.NVarChar).Value = txtNameOnCard.Text;
                            sqlcom.Parameters.Add("@CATCARDSLIPNO", SqlDbType.NVarChar).Value = txtSLipNo.Text.Trim();
                            sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN2000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN1000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN200", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN500", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN100", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN50", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN20", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN10", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN5", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN2", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURIN1", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CURINTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT2000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT1000", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT200", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT500", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT100", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT50", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT20", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT10", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT5", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT2", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUT1", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CUROUTTOT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CASHAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@AutoCashAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");

                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        sqlcon.Close();

                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
            ProjectFunctions.GetDataSet("update CASHTENDER set CATMODE = 2 WHERE CATMEMONO='" + lblMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
            ProjectFunctions.GetDataSet("update SALEINVMAIN set NOTPAID = 'Y' Where SIMDATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' And SIMNO='" + lblMemoNo.Text + "' And SIMSERIES='" + 'S' + "' And UnitCode='" + GlobalVariables.CUnitID + "'");

            Prints.CASHMEMO rpt = new Prints.CASHMEMO();
            ProjectFunctions.PrintDocument(lblMemoNo.Text, Convert.ToDateTime(lblMemoDate.Text), "S", rpt);
            Close();
            

        }



        private void TxtCardDigits_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {



                    string MainValue = txtCardDigits.Text;
                    MainValue = MainValue.Substring(0, MainValue.IndexOf("/"));
                    MainValue = MainValue.Replace("\n", string.Empty);
                    MainValue = MainValue.Replace("\r", string.Empty);
                    MainValue = MainValue.Replace("\t", string.Empty);
                    txtCardDigits.Text = MainValue;
                    string Value = MainValue;

                    Value = Value.Replace("%b".ToUpper(), string.Empty).Replace("%b", string.Empty);
                    Value = Value.Substring(0, Value.IndexOf("^"));
                    txtCardNo.Text = Value.Trim();

                    string Value2 = MainValue;
                    Value2 = Value2.Replace("%b".ToUpper(), string.Empty).Replace("%b", string.Empty);
                    Value2 = Value2.Replace(Value, string.Empty).Replace("^", string.Empty);
                    //Value2 = Value2.Substring(0, Value2.LastIndexOf("/"));


                    txtNameOnCard.Text = Value2.Trim().ToUpper();
                    txtCardDigits.Text = string.Empty;

                    textEdit1.Focus();


                }
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            e.Handled = true;
        }

        private void TxtAmountPaid_EditValueChanged(object sender, EventArgs e)
        {
          txtBalanceAmount.EditValue = Convert.ToDecimal(txtMemoAmount.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue);
        }



        private void TextEdit1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                txtAmountPaid.Focus();
            }
        }

        private void BtnSaveOnly_Click(object sender, EventArgs e)
        {
            Save();
            ProjectFunctions.GetDataSet("update CASHTENDER set CATMODE = 2 WHERE CATMEMONO='" + lblMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
            ProjectFunctions.GetDataSet("update SALEINVMAIN set NOTPAID = 'Y' Where SIMDATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' And SIMNO='" + lblMemoNo.Text + "' And SIMSERIES='" + 'S' + "' And UnitCode='" + GlobalVariables.CUnitID + "'");

            Close();
           

        }

        private void Card_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            ProjectFunctions.SalePopUPForAllWindows(this, e);
        }

        private void BtnWhatsapp_Click(object sender, EventArgs e)
        {
            Save();
            ProjectFunctions.GetDataSet("update CASHTENDER set CATMODE = 2 WHERE CATMEMONO='" + lblMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
            ProjectFunctions.GetDataSet("update SALEINVMAIN set NOTPAID = 'Y' Where SIMDATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' And SIMNO='" + lblMemoNo.Text + "' And SIMSERIES='" + 'S' + "' And UnitCode='" + GlobalVariables.CUnitID + "'");

            Prints.CASHMEMONOR rpt = new Prints.CASHMEMONOR();
            ProjectFunctions.PrintPDFDocumentONLY(lblMemoNo.Text, Convert.ToDateTime(lblMemoDate.Text), "S", rpt);
            DataSet ds = ProjectFunctions.GetDataSet("SELECT CAFINFO.CAFMOBILE FROM SALEINVMAIN INNER JOIN CAFINFO ON SALEINVMAIN.CustCode = CAFINFO.CAFSYSID WHERE  (SALEINVMAIN.SIMSERIES = 'S') And SIMNO='" + lblMemoNo.Text + "' aND SIMDATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "'");
            if (ds.Tables[0].Rows[0]["CAFMOBILE"].ToString().Length >= 10)
            {
                ProjectFunctions.SendCashMemoImageAsync(ds.Tables[0].Rows[0]["CAFMOBILE"].ToString(), lblMemoNo.Text, Convert.ToDateTime(lblMemoDate.Text));
            }

            Close();
        }

        private void TxtCardType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmountPaid.Text = txtMemoAmount.Text;
                txtAmountPaid.Focus();
                txtAmountPaid.SelectAll();
                
            }
        }

        private void TxtAmountPaid_KeyDown(object sender, KeyEventArgs e)
        {
            btnSave.PerformClick();
        }
    }
}