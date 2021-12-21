using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Pos
{
    public partial class frmOnlinePayment : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string MemoNo { get; set; }
        public DateTime MemoDate { get; set; }
        public decimal CardPayment { get; set; }
        public decimal PGPayment { get; set; }
        public decimal TotalMemoAmount { get; set; }
        public frmOnlinePayment()
        {
            InitializeComponent();
        }

        private void BtnPayTM_Click(object sender, EventArgs e)
        {
            txtUPIDType.Text = "PayTM";
        }

        private void BtnGooglePay_Click(object sender, EventArgs e)
        {
            txtUPIDType.Text = "GooglePay";
        }

        private void BtnPhonePe_Click(object sender, EventArgs e)
        {
            txtUPIDType.Text = "PhonePe";
        }

        private void FrmOnlinePayment_Load(object sender, EventArgs e)
        {
            try

            {
                lblMemoNo.Text = MemoNo;
                lblMemoDate.Text = MemoDate.ToString("dd-MM-yyyy");

                txtMemoAmount.Text = TotalMemoAmount.ToString("0.00");




                DataSet ds = ProjectFunctions.GetDataSet("Select * from CASHTENDER Where CATMEMONO='" + MemoNo + "' And CATMEMODATE='" + MemoDate.Date.ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUPIDType.Text = ds.Tables[0].Rows[0]["UPIDType"].ToString();
                    txtUPIDMobileNo.Text = ds.Tables[0].Rows[0]["UPIDMobileNo"].ToString();
                    txtNameOnUPID.Text = ds.Tables[0].Rows[0]["UPIDName"].ToString();
                    txtUPID.Text = ds.Tables[0].Rows[0]["UPIDAddress"].ToString();





                    txtAmountPaid.EditValue = ds.Tables[0].Rows[0]["CATPGAMT"].ToString();
                    txtBalanceAmount.EditValue = (Convert.ToDecimal(txtMemoAmount.Text) - Convert.ToDecimal(txtAmountPaid.Text));
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
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

                            sqlcom.CommandText = "Insert into CASHTENDER(UPIDType,UPIDMobileNo,UPIDName,UPIDAddress,CATMEMONO,CATMEMODATE,CATMEMOAMT,CATCARDAMT,CATPGAMT,CURIN2000,CURIN1000,CURIN200,CURIN500,CURIN100,CURIN50,CURIN20,CURIN10,CURIN5," +
                                "  CURIN2,CURIN1,CURINTOT,CUROUT2000,CUROUT1000,CUROUT200,CUROUT500,CUROUT100,CUROUT50,CUROUT20,CUROUT10,CUROUT5,CUROUT2,CUROUT1,CUROUTTOT,CATCARDTYPE,CATCARDNO,CATCARDNAME,CATCARDSLIPNO,UnitCode,CASHAmount,AutoCashAmount)values(" +
                                "@UPIDType,@UPIDMobileNo,@UPIDName,@UPIDAddress,@CATMEMONO,@CATMEMODATE,@CATMEMOAMT,@CATCARDAMT,@CATPGAMT,@CURIN2000,@CURIN1000,@CURIN200,@CURIN500,@CURIN100,@CURIN50,@CURIN20,@CURIN10,@CURIN5," +
                                "  @CURIN2,@CURIN1,@CURINTOT,@CUROUT2000,@CUROUT1000,@CUROUT200,@CUROUT500,@CUROUT100,@CUROUT50,@CUROUT20,@CUROUT10,@CUROUT5,@CUROUT2,@CUROUT1,@CUROUTTOT,@CATCARDTYPE,@CATCARDNO,@CATCARDNAME,@CATCARDSLIPNO,@UnitCode,@CASHAmount,@AutoCashAmount)";
                            sqlcom.Parameters.Add("@UPIDType", SqlDbType.NVarChar).Value = txtUPIDType.Text;
                            sqlcom.Parameters.Add("@UPIDMobileNo", SqlDbType.NVarChar).Value = txtUPIDMobileNo.Text;
                            sqlcom.Parameters.Add("@UPIDName", SqlDbType.NVarChar).Value = txtNameOnUPID.Text;
                            sqlcom.Parameters.Add("@UPIDAddress", SqlDbType.NVarChar).Value = txtUPID.Text;
                            sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = lblMemoNo.Text;
                            sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = TotalMemoAmount.ToString("0.00");
                            sqlcom.Parameters.Add("@CATCARDAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtAmountPaid.Text);
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
                            sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDNO", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDNAME", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDSLIPNO", SqlDbType.NVarChar).Value = txtSLipNo.Text.Trim();
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
                            sqlcom.Parameters.Add("@CASHAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.Parameters.Add("@AutoCashAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal("0");
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                        else
                        {
                            sqlcom.CommandText = "Update CASHTENDER Set AutoCashAmount=@AutoCashAmount,UPIDType=@UPIDType,UPIDMobileNo=@UPIDMobileNo,UPIDName=@UPIDName,UPIDAddress=@UPIDAddress,CURIN2000=@CURIN2000,CURIN1000=@CURIN1000,CURIN200=@CURIN200,CURIN500=@CURIN500," +
                                "CURIN100=@CURIN100,CURIN50=@CURIN50,CURIN20=@CURIN20,CURIN10=@CURIN10,CURIN5=@CURIN5,CURIN2=@CURIN2,CURIN1=@CURIN1,CASHAmount=@CASHAmount,CATMEMOAMT=@CATMEMOAMT,CATPGAMT=@CATPGAMT,CATCARDTYPE=@CATCARDTYPE,CATCARDNO=@CATCARDNO,CATCARDNAME=@CATCARDNAME,CATCARDSLIPNO=@CATCARDSLIPNO " +
                                " Where CATMEMODATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "' And CATMEMONO='" + lblMemoNo.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "'";

                            sqlcom.Parameters.Add("@UPIDType", SqlDbType.NVarChar).Value = txtUPIDType.Text;
                            sqlcom.Parameters.Add("@UPIDMobileNo", SqlDbType.NVarChar).Value = txtUPIDMobileNo.Text;
                            sqlcom.Parameters.Add("@UPIDName", SqlDbType.NVarChar).Value = txtNameOnUPID.Text;
                            sqlcom.Parameters.Add("@UPIDAddress", SqlDbType.NVarChar).Value = txtUPID.Text;
                            sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = lblMemoNo.Text;
                            sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd");
                            sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = TotalMemoAmount.ToString("0.00");
                            sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtAmountPaid.Text);
                            sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDNO", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDNAME", SqlDbType.NVarChar).Value = string.Empty;
                            sqlcom.Parameters.Add("@CATCARDSLIPNO", SqlDbType.NVarChar).Value = txtSLipNo.Text.Trim();

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
        private void BtnRevert_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnSaveOnly_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

      
        private void BtnWhatsapp_Click(object sender, EventArgs e)
        {
            Save();
            Prints.CASHMEMONOR rpt = new Prints.CASHMEMONOR();
            ProjectFunctions.PrintPDFDocumentONLY(lblMemoNo.Text, Convert.ToDateTime(lblMemoDate.Text), "S", rpt);

            DataSet ds = ProjectFunctions.GetDataSet("SELECT CAFINFO.CAFMOBILE FROM SALEINVMAIN INNER JOIN CAFINFO ON SALEINVMAIN.CustCode = CAFINFO.CAFSYSID WHERE  (SALEINVMAIN.SIMSERIES = 'S') And SIMNO='" + lblMemoNo.Text + "' aND SIMDATE='" + Convert.ToDateTime(lblMemoDate.Text).ToString("yyyy-MM-dd") + "'");
            if (ds.Tables[0].Rows[0]["CAFMOBILE"].ToString().Length >= 10)
            {
                ProjectFunctions.SendCashMemoImageAsync(ds.Tables[0].Rows[0]["CAFMOBILE"].ToString(), lblMemoNo.Text, Convert.ToDateTime(lblMemoDate.Text));
            }

            Close();
        }
    }
}