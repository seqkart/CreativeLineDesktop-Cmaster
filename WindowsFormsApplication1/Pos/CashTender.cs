using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.Data.Mask;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Pos;
using WindowsFormsApplication1.Prints;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1.Pos
{
	public partial class CashTender : DevExpress.XtraEditors.XtraForm
	{
		public string S1 { get; set; }
		public string MemoNo { get; set; }
		public DateTime MemoDate { get; set; }
		public decimal CardPayment { get; set; }
		public decimal PGPayment { get; set; }
		public decimal TotalMemoAmount { get; set; }
		public PrinterSettings PrinterSettings { get; private set; }

		public CashTender()
		{
			InitializeComponent();
		}

		private void CashTender_Load(object sender, EventArgs e)
		{
			try

			{
				txtCashMemoNo.Text = MemoNo;
				txtCashMemoDate.Text = MemoDate.ToString("dd-MM-yyyy");
				txtCardPayment.Text = CardPayment.ToString("0.00");
				txtPGPayment.Text = PGPayment.ToString("0.00");
				txtCashMemoAmount.Text = TotalMemoAmount.ToString("0.00");
				DataSet ds = ProjectFunctions.GetDataSet("Select * from CASHTENDER Where CATMEMONO='" + MemoNo + "' And CATMEMODATE='" + MemoDate.Date.ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
				if (ds.Tables[0].Rows.Count > 0)
				{
					txtCashMemoNo.Text = ds.Tables[0].Rows[0]["CATMEMONO"].ToString();
					txtCashMemoDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CATMEMODATE"]).ToString("yyyy-MM-dd");
					txtPGPayment.Text = ds.Tables[0].Rows[0]["CATPGAMT"].ToString();
					txtCardPayment.Text = ds.Tables[0].Rows[0]["CATCARDAMT"].ToString();
					txtCashPayment.Text = ds.Tables[0].Rows[0]["CASHAmount"].ToString();
					txtPGPaymentActual.Text = ds.Tables[0].Rows[0]["CATPGAMT"].ToString();
					txtCardPaymentActual.Text = ds.Tables[0].Rows[0]["CATCARDAMT"].ToString();
					txtCashPaymentActual.Text = ds.Tables[0].Rows[0]["CASHAmount"].ToString();
					txtCardType.Text = ds.Tables[0].Rows[0]["CATCARDTYPE"].ToString();
					txtUPIDType.Text = ds.Tables[0].Rows[0]["UPIDType"].ToString();
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message);
			}
		}
		private void Btvisa_Click(object sender, EventArgs e)
		{
			txtCardType.Text = "VISA";
			txtCardPaymentActual.Focus();
		}

		private void Btmaestro_Click(object sender, EventArgs e)
		{
			txtCardType.Text = "MAESTRO";
			txtCardPaymentActual.Focus();
		}

		private void Btamex_Click(object sender, EventArgs e)
		{
			txtCardType.Text = "AMEX";
			txtCardPaymentActual.Focus();
		}

		private void Btmaster_Click(object sender, EventArgs e)
		{
			txtCardType.Text = "MASTER CARD";
			txtCardPaymentActual.Focus();
		}

		private void Btdci_Click(object sender, EventArgs e)
		{
			txtCardType.Text = "DINERS CLUB";
			txtCardPaymentActual.Focus();
		}

		private void BtnPayTM_Click(object sender, EventArgs e)
		{
			txtUPIDType.Text = "PayTM";
			txtPGPaymentActual.Focus();
		}

		private void BtnGooglePay_Click(object sender, EventArgs e)
		{
			txtUPIDType.Text = "GooglePay";
			txtPGPaymentActual.Focus();
		}

		private void BtnPhonePe_Click(object sender, EventArgs e)
		{
			txtUPIDType.Text = "PhonePe";
			txtPGPaymentActual.Focus();
		}

		private void Calculate()
		{
			txtTotalPayBack.Text = (Convert.ToDecimal(txtCashMemoAmount.Text) - Convert.ToDecimal(txtCardPaymentActual.Text) - Convert.ToDecimal(txtPGPaymentActual.Text) - Convert.ToDecimal(txtCashPaymentActual.Text)).ToString("0.00");
			txtTotalReceived.Text = (Convert.ToDecimal(txtCardPaymentActual.Text) + Convert.ToDecimal(txtPGPaymentActual.Text) + Convert.ToDecimal(txtCashPaymentActual.Text)).ToString("0.00");
		}

		private void GroupControl2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void TxtCashInCount1_EditValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void Save()
		{
			using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
			{
				sqlcon.Open();
				var sqlcom = sqlcon.CreateCommand();
				sqlcom.Connection = sqlcon;
				sqlcom.CommandType = CommandType.Text;
				try
				{
					DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from CASHTENDER where CATMEMONO='" + txtCashMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd") + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
					if (dsCheck.Tables[0].Rows.Count == 0)
					{
						sqlcom.CommandText = "Insert into CASHTENDER(CATMEMONO,CATMEMODATE,CATMEMOAMT,CATCARDAMT,CATPGAMT,CASHAmount,UnitCode,CATCARDTYPE,UPIDType)values(@CATMEMONO,@CATMEMODATE,@CATMEMOAMT,@CATCARDAMT,@CATPGAMT,@CASHAmount,@UnitCode,@CATCARDTYPE,@UPIDType)";
						sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = txtCashMemoNo.Text;
						sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd");
						sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCashMemoAmount.Text);
						sqlcom.Parameters.Add("@CATCARDAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCardPaymentActual.Text);
						sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtPGPaymentActual.Text);
						sqlcom.Parameters.Add("@CASHAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCashPaymentActual.Text);
						sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
						sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = txtCardType.Text;
						sqlcom.Parameters.Add("@UPIDType", SqlDbType.NVarChar).Value = txtUPIDType.Text;
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
					}
					else
					{
						sqlcom.CommandText = "Update CASHTENDER Set CATMEMOAMT=@CATMEMOAMT,CATCARDAMT=@CATCARDAMT,CATPGAMT=@CATPGAMT,CASHAmount=@CASHAmount,CATCARDTYPE=@CATCARDTYPE,UPIDType=@UPIDType Where CATMEMODATE='" + Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd") + "' And CATMEMONO='" + txtCashMemoNo.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "'";
						sqlcom.Parameters.Add("@CATMEMONO", SqlDbType.NVarChar).Value = txtCashMemoNo.Text;
						sqlcom.Parameters.Add("@CATMEMODATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd");
						sqlcom.Parameters.Add("@CATMEMOAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCashMemoAmount.Text);
						sqlcom.Parameters.Add("@CATCARDAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCardPaymentActual.Text);
						sqlcom.Parameters.Add("@CATPGAMT", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtPGPaymentActual.Text);
						sqlcom.Parameters.Add("@CASHAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(txtCashPaymentActual.Text);
						sqlcom.Parameters.Add("@CATCARDTYPE", SqlDbType.NVarChar).Value = txtCardType.Text;
						sqlcom.Parameters.Add("@UPIDType", SqlDbType.NVarChar).Value = txtUPIDType.Text;
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
					}
					sqlcon.Close();
					Close();
				}
				catch (Exception)
				{
				}
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			Save();

			ProjectFunctions.GetDataSet("update CASHTENDER set CATMODE = 2 WHERE CATMEMONO='" + txtCashMemoNo.Text + "' And CATMEMODATE='" + Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd") + "' ANd UnitCode='" + GlobalVariables.CUnitID + "'");
			ProjectFunctions.GetDataSet("update SALEINVMAIN set NOTPAID = 'N' Where SIMDATE='" + Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd") + "' And SIMNO='" + txtCashMemoNo.Text + "' And SIMSERIES='" + 'S' + "' And UnitCode='" + GlobalVariables.CUnitID + "'");

			CASHMEMO rpt = new CASHMEMO();
			ProjectFunctions.PrintDocument(txtCashMemoNo.Text, Convert.ToDateTime(txtCashMemoDate.Text), "S", rpt);
			Close();
		}

		private void SimpleButton2_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void BtnSaveOnly_Click(object sender, EventArgs e)
		{
			Save();
			Close();
		}

		private void CashTender_KeyDown(object sender, KeyEventArgs e)
		{
			ProjectFunctions.SalePopUPForAllWindows(this, e);
		}

		private void GroupControl3_Paint(object sender, PaintEventArgs e)
		{
		}

		private void BtnWhatsapp_Click(object sender, EventArgs e)
		{
			Save();
			CASHMEMONOR rpt = new CASHMEMONOR();
			ProjectFunctions.PrintPDFDocumentONLY(txtCashMemoNo.Text, Convert.ToDateTime(txtCashMemoDate.Text), "S", rpt);
			DataSet ds = ProjectFunctions.GetDataSet("SELECT CAFINFO.CAFMOBILE FROM SALEINVMAIN INNER JOIN CAFINFO ON SALEINVMAIN.CustCode = CAFINFO.CAFSYSID WHERE  (SALEINVMAIN.SIMSERIES = 'S') And SIMNO='" + txtCashMemoNo.Text + "' aND SIMDATE='" + Convert.ToDateTime(txtCashMemoDate.Text).ToString("yyyy-MM-dd") + "'");
			if (ds.Tables[0].Rows[0]["CAFMOBILE"].ToString().Length >= 10)
			{
				ProjectFunctions.SendCashMemoImageAsync(ds.Tables[0].Rows[0]["CAFMOBILE"].ToString(), txtCashMemoNo.Text, Convert.ToDateTime(txtCashMemoDate.Text));
			}
			Close();
		}

		private void TxtCashPaymentActual_EditValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void TxtCardPaymentActual_EditValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void TxtPGPaymentActual_EditValueChanged(object sender, EventArgs e)
		{
			Calculate();
		}
	}
}