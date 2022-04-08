using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Transaction;
namespace WindowsFormsApplication1.Transaction
{
	public partial class FrmBoxAddEdit : DevExpress.XtraEditors.XtraForm
	{
		DataTable dt = new DataTable();
		public string S1 { get; set; }
		public string SFMTOTBOX { get; set; }
		public string UpdateTag { get; set; }
		public string SFDVNO { get; set; }
		public FrmBoxAddEdit()
		{
			InitializeComponent();
			dt.Columns.Add("SFDBOXNO", typeof(string));
			dt.Columns.Add("SFDBARCODE", typeof(string));
			dt.Columns.Add("SFDARTNO", typeof(string));
			dt.Columns.Add("SFDARTDESC", typeof(string));
			dt.Columns.Add("SFDCOLN", typeof(string));
			dt.Columns.Add("SFDSIZN", typeof(string));
			dt.Columns.Add("SFDSCANQTY", typeof(decimal));
			dt.Columns.Add("SFDARTMRP", typeof(decimal));
			dt.Columns.Add("SFDARTWSP", typeof(decimal));
			dt.Columns.Add("SFDARTID", typeof(string));
			dt.Columns.Add("SFDCOLID", typeof(string));
			dt.Columns.Add("SFDSIZID", typeof(string));
		}

		private void ShowImage(string ArticleID)
		{
			try
			{
				DataSet dsImage = ProjectFunctions.GetDataSet("Select ARTIMAGE from ARTICLE Where ARTSYSID='" + ArticleID + "'");
				if (dsImage.Tables[0].Rows[0]["ARTIMAGE"].ToString().Trim() != string.Empty)
				{
					byte[] MyData = new byte[0];
					MyData = (byte[])dsImage.Tables[0].Rows[0]["ARTIMAGE"];
					MemoryStream stream = new MemoryStream(MyData)
					{
						Position = 0L
					};
					ArticleImageBox.Image = Image.FromStream(stream);
				}
				else
				{
					ArticleImageBox.Image = null;
				}
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void BtnQuit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FrmBoxAddEdit_Load(object sender, EventArgs e)
		{
			try
			{
				ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
				ProjectFunctions.GirdViewVisualize(BarCodeGridView);
				ProjectFunctions.GirdViewVisualize(HelpGridView);
				ProjectFunctions.TextBoxVisualize(this);
				if (S1 == "&Add")
				{
					string MemoNo = ProjectFunctions.GetDataSet("select isnull(max(SFMVNO),0)+1 from SFMAIN where SFMFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
					txtMemoNo.Text = MemoNo;
					lblBox.Text = "1";
					txtMemoDate.EditValue = DateTime.Now;
					lblTotQty.Text = "0";
					txtBarCode.Focus();
				}
				if (!(S1 == "Edit"))
				{
					return;
				}
				DataSet ds = ProjectFunctions.GetDataSet("SP_LoadBoxDataFEdit '" + SFDVNO + "' ,'" + SFMTOTBOX + "','" + GlobalVariables.FinancialYear + "','" + GlobalVariables.CUnitID + "' ");
				if (ds.Tables[0].Rows.Count <= 0)
				{
					return;
				}
				txtMemoDate.EditValue = Convert.ToDateTime(ds.Tables[0].Rows[0]["SFDVDATE"]);
				txtMemoNo.EditValue = SFDVNO;
				dt = ds.Tables[0];
				BarCodeGrid.DataSource = dt;
				BarCodeGridView.BestFitColumns();
				decimal QtySum = default(decimal);
				foreach (DataRow dr in dt.Rows)
				{
					lblBox.Text = Convert.ToDecimal(dr["SFDBOXNO"]).ToString("0");
					QtySum += Convert.ToDecimal(dr["SFDSCANQTY"]);
				}
				lblTotQty.Text = QtySum.ToString("0");
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void TxtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SKU Where SKUPRODUCTCODE='" + txtBarCode.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
					if (dsCheck.Tables[0].Rows.Count <= 0)
					{
						ProjectFunctions.SpeakError("Bar Code Not Generated");
						txtBarCode.SelectAll();
						txtBarCode.Focus();
						e.Handled = true;
						return;
					}
					if (dsCheck.Tables[0].Rows[0]["Used"].ToString().ToUpper() == "Y")
					{
						ProjectFunctions.SpeakError("BarCode Already Loaded");
						txtBarCode.SelectAll();
						txtBarCode.Focus();
						e.Handled = true;
						return;
					}
					foreach (DataRow dr in dt.Rows)
					{
						if (dr["SFDBARCODE"].ToString().ToUpper() == txtBarCode.Text.Trim().ToUpper())
						{
							ProjectFunctions.SpeakError("BarCode Already Loaded In This Document");
							txtBarCode.SelectAll();
							txtBarCode.Focus();
							e.Handled = true;
							return;
						}
					}
					DataSet ds = ProjectFunctions.GetDataSet("sp_LoadDataFromSKU '" + txtBarCode.Text + "','" + GlobalVariables.CUnitID + "'");
					DataRow drNewRow = dt.NewRow();
					drNewRow["SFDBOXNO"] = lblBox.Text;
					drNewRow["SFDBARCODE"] = ds.Tables[0].Rows[0]["SKUPRODUCTCODE"].ToString();
					drNewRow["SFDARTNO"] = ds.Tables[0].Rows[0]["ARTNO"].ToString();
					drNewRow["SFDARTDESC"] = ds.Tables[0].Rows[0]["ARTDESC"].ToString();
					drNewRow["SFDCOLN"] = ds.Tables[0].Rows[0]["COLNAME"].ToString();
					drNewRow["SFDSIZN"] = ds.Tables[0].Rows[0]["SZNAME"].ToString();
					drNewRow["SFDSCANQTY"] = Convert.ToDecimal("1");
					drNewRow["SFDARTMRP"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUMRP"]);
					drNewRow["SFDARTWSP"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUWSP"]);
					drNewRow["SFDARTID"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUARTID"]).ToString();
					ShowImage(Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUARTID"]).ToString());
					drNewRow["SFDCOLID"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUCOLID"]);
					drNewRow["SFDSIZID"] = Convert.ToDecimal(ds.Tables[0].Rows[0]["SKUSIZID"]);
					dt.Rows.Add(drNewRow);
					if (dt.Rows.Count > 0)
					{
						BarCodeGrid.DataSource = dt;
						BarCodeGridView.BestFitColumns();
						txtBarCode.Text = string.Empty;
						lblTotQty.Text = Convert.ToDecimal(gridColumn7.SummaryItem.SummaryValue).ToString("0");
					}
					else
					{
						BarCodeGrid.DataSource = null;
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

		private bool ValidateDataForSaving()
		{
			try
			{
				if (BarCodeGrid.DataSource == null)
				{
					ProjectFunctions.SpeakError("No Data To Save");
				}
				SplashScreenManager.ShowForm(this, typeof(WaitForm1), useFadeIn: true, useFadeOut: true, throwExceptionIfAlreadyOpened: false);
				int i = 0;
				foreach (DataRow dr in dt.Rows)
				{
					i = checked(i + 1);
					SplashScreenManager.Default.SetWaitFormDescription("Validating Item " + i + " / " + dt.Rows.Count);
					if (ProjectFunctions.CheckAllPossible(dr["SFDARTID"].ToString(), Convert.ToDecimal(dr["SFDARTMRP"]), dr["SFDCOLID"].ToString(), dr["SFDSIZID"].ToString()))
					{
						continue;
					}
					return false;
				}
				SplashScreenManager.CloseForm(throwExceptionIfAlreadyClosed: false);
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
				dt.AcceptChanges();
				if (!ValidateDataForSaving())
				{
					return;
				}
					using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
					{
						sqlcon.Open();
						var sqlcom = sqlcon.CreateCommand();
						sqlcom.Connection = sqlcon;
						sqlcom.CommandType = CommandType.Text;

					if (S1 == "&Add")
					{
						sqlcom.CommandText = " Insert into SFMAIN  (SFMSYSDATE,SFMFNYR,SFMVNO,SFMLOC,SFMTOTBOX,SFMREMARKS, SFMTOTQTY,SFMTOTMRPVAL,SFMTOTWSPVAL,SFMWRONGMRPQTY,SFMWCORRECTMRPQTY,UnitCode) values(@SFMSYSDATE,@SFMFNYR,@SFMVNO,@SFMLOC,@SFMTOTBOX,@SFMREMARKS, @SFMTOTQTY,@SFMTOTMRPVAL,@SFMTOTWSPVAL,@SFMWRONGMRPQTY,@SFMWCORRECTMRPQTY,@UnitCode)";
						sqlcom.Parameters.Add("@SFMSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						sqlcom.Parameters.Add("@SFMFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
						sqlcom.Parameters.Add("@SFMVNO", SqlDbType.NVarChar).Value = txtMemoNo.Text;
						sqlcom.Parameters.Add("@SFMLOC", SqlDbType.NVarChar).Value = txtLocation.Text;
						sqlcom.Parameters.Add("@SFMTOTBOX", SqlDbType.NVarChar).Value = lblBox.Text;
						sqlcom.Parameters.Add("@SFMREMARKS", SqlDbType.NVarChar).Value = txtRemarks.Text;
						sqlcom.Parameters.Add("@SFMTOTQTY", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn7.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMTOTMRPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn9.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMTOTWSPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn10.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMWRONGMRPQTY", SqlDbType.NVarChar).Value = "0";
						sqlcom.Parameters.Add("@SFMWCORRECTMRPQTY", SqlDbType.NVarChar).Value = "0";
						sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
					}
					if (S1 == "Edit")
					{
						sqlcom.CommandText = " update SFMAIN Set  SFMLOC=@SFMLOC,SFMTOTBOX=@SFMTOTBOX,SFMREMARKS=@SFMREMARKS, SFMTOTQTY=@SFMTOTQTY,SFMTOTMRPVAL=@SFMTOTMRPVAL,SFMTOTWSPVAL=@SFMTOTWSPVAL,SFMWRONGMRPQTY=@SFMWRONGMRPQTY,SFMWCORRECTMRPQTY=@SFMWCORRECTMRPQTY where SFMVNO='" + txtMemoNo.Text + "' And SFMTOTBOX='" + lblBox.Text + "'";
						sqlcom.Parameters.Add("@SFMLOC", SqlDbType.NVarChar).Value = txtLocation.Text;
						sqlcom.Parameters.Add("@SFMTOTBOX", SqlDbType.NVarChar).Value = lblBox.Text;
						sqlcom.Parameters.Add("@SFMREMARKS", SqlDbType.NVarChar).Value = txtRemarks.Text;
						sqlcom.Parameters.Add("@SFMTOTQTY", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn7.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMTOTMRPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn9.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMTOTWSPVAL", SqlDbType.NVarChar).Value = Convert.ToDecimal(gridColumn10.SummaryItem.SummaryValue).ToString("0.00");
						sqlcom.Parameters.Add("@SFMWRONGMRPQTY", SqlDbType.NVarChar).Value = "0";
						sqlcom.Parameters.Add("@SFMWCORRECTMRPQTY", SqlDbType.NVarChar).Value = "0";
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
						ProjectFunctions.GetDataSet("update SKU set Used='N' where SKUPRODUCTCODE in (Select SFDBARCODE from SFDET Where SFDVNO='" + txtMemoNo.Text + "' And SFDBOXNO='" + lblBox.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "' And SFDFNYR='" + GlobalVariables.FinancialYear + "') And UnitCode='" + GlobalVariables.CUnitID + "' And SKUFNYR='" + GlobalVariables.FinancialYear + "'");
						ProjectFunctions.GetDataSet("Delete from SFDET Where SFDVNO='" + txtMemoNo.Text + "' And SFDBOXNO='" + lblBox.Text + "' And UnitCode='" + GlobalVariables.CUnitID + "' And SFDFNYR='" + GlobalVariables.FinancialYear + "'");
					}
					foreach (DataRow dr in dt.Rows)
					{
						sqlcom.CommandText = " Insert into SFDET  (SFDSYSDATE,SFDFNYR,SFDVDATE,SFDVNO,SFDBOXNO,SFDBARCODE, SFDARTNO,SFDARTID,SFDARTDESC,SFDCOLN,SFDCOLID,SFDSIZN,SFDSIZID,SFDSCANQTY, SFDARTMRP,SFDARTWSP,SFDBOXQTY,SFDBOXMRPVAL,SFDBOXWSPVAL,SFDWRONGMRP,UnitCode) values(@SFDSYSDATE,@SFDFNYR,@SFDVDATE,@SFDVNO,@SFDBOXNO,@SFDBARCODE, @SFDARTNO,@SFDARTID,@SFDARTDESC,@SFDCOLN,@SFDCOLID,@SFDSIZN,@SFDSIZID,@SFDSCANQTY, @SFDARTMRP,@SFDARTWSP,@SFDBOXQTY,@SFDBOXMRPVAL,@SFDBOXWSPVAL,@SFDWRONGMRP,@UnitCode)";
						sqlcom.Parameters.Add("@SFDSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
						sqlcom.Parameters.Add("@SFDFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
						sqlcom.Parameters.Add("@SFDVDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(txtMemoDate.Text).ToString("yyyy-MM-dd");
						sqlcom.Parameters.Add("@SFDVNO", SqlDbType.NVarChar).Value = txtMemoNo.Text;
						sqlcom.Parameters.Add("@SFDBOXNO", SqlDbType.NVarChar).Value = dr["SFDBOXNO"].ToString();
						sqlcom.Parameters.Add("@SFDBARCODE", SqlDbType.NVarChar).Value = dr["SFDBARCODE"].ToString();
						sqlcom.Parameters.Add("@SFDARTNO", SqlDbType.NVarChar).Value = dr["SFDARTNO"].ToString();
						sqlcom.Parameters.Add("@SFDARTID", SqlDbType.NVarChar).Value = dr["SFDARTID"].ToString();
						sqlcom.Parameters.Add("@SFDARTDESC", SqlDbType.NVarChar).Value = dr["SFDARTDESC"].ToString();
						sqlcom.Parameters.Add("@SFDCOLN", SqlDbType.NVarChar).Value = dr["SFDCOLN"].ToString();
						sqlcom.Parameters.Add("@SFDCOLID", SqlDbType.NVarChar).Value = dr["SFDCOLID"].ToString();
						sqlcom.Parameters.Add("@SFDSIZN", SqlDbType.NVarChar).Value = dr["SFDSIZN"].ToString();
						sqlcom.Parameters.Add("@SFDSIZID", SqlDbType.NVarChar).Value = dr["SFDSIZID"].ToString();
						sqlcom.Parameters.Add("@SFDSCANQTY", SqlDbType.NVarChar).Value = dr["SFDSCANQTY"].ToString();
						sqlcom.Parameters.Add("@SFDARTMRP", SqlDbType.NVarChar).Value = dr["SFDARTMRP"].ToString();
						sqlcom.Parameters.Add("@SFDARTWSP", SqlDbType.NVarChar).Value = dr["SFDARTWSP"].ToString();
						sqlcom.Parameters.Add("@SFDBOXQTY", SqlDbType.NVarChar).Value = dr["SFDBOXNO"].ToString();
						sqlcom.Parameters.Add("@SFDBOXMRPVAL", SqlDbType.NVarChar).Value = dr["SFDARTMRP"].ToString();
						sqlcom.Parameters.Add("@SFDBOXWSPVAL", SqlDbType.NVarChar).Value = dr["SFDARTWSP"].ToString();
						sqlcom.Parameters.Add("@SFDWRONGMRP", SqlDbType.NVarChar).Value = "0";
						sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = GlobalVariables.CUnitID;
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
						ProjectFunctions.GetDataSet("update SKU set Used='Y' where SKUPRODUCTCODE='" + dr["SFDBARCODE"].ToString() + "' And UnitCode='" + GlobalVariables.CUnitID + "'");
					}
					ProjectFunctions.SpeakError(" Box Saved Successfully");
					sqlcon.Close();
					if (S1 == "&Add")
					{
						lblBox.Text = checked(Convert.ToInt32(lblBox.Text) + 1).ToString();
						BarCodeGrid.DataSource = null;
						dt.Clear();
						lblTotQty.Text = "0";
						return;
					}
					lblBox.Text = ProjectFunctions.GetDataSet("select isnull( max(SFMTOTBOX),0)+1 from SFMAIN where SFMVNO='" + txtMemoNo.Text + "' And SFMFNYR='" + GlobalVariables.FinancialYear + "' And UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
					BarCodeGrid.DataSource = null;
					dt.Clear();
					lblTotQty.Text = "0";
					S1 = "&Add";
				}
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void BtnImportBarode_Click(object sender, EventArgs e)
		{
			try
			{
				HelpGridView.Columns.Clear();
				HelpGrid.Text = "Load";
				DataSet ds = ProjectFunctions.GetDataSet("sp_LoadDataFSKU '" + GlobalVariables.CUnitID + "'");
				if (ds.Tables[0].Rows.Count <= 0)
				{
					return;
				}
				ds.Tables[0].Columns.Add("Select", typeof(bool));
				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					dr["Select"] = false;
				}
				HelpGrid.DataSource = ds.Tables[0];
				HelpGrid.Show();
				HelpGrid.Focus();
				HelpGridView.BestFitColumns();
				HelpGridView.OptionsBehavior.Editable = true;
				foreach (GridColumn col in HelpGridView.Columns)
				{
					if (col.FieldName == "Select")
					{
						col.OptionsColumn.AllowEdit = true;
					}
					else
					{
						col.OptionsColumn.AllowEdit = false;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void HelpGrid_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (!(HelpGrid.Text == "Load"))
				{
					return;
				}
				int i = 0;
				foreach (DataRow dr2 in (HelpGrid.DataSource as DataTable).Rows)
				{
					if (dr2["Select"].ToString().ToUpper() == "TRUE")
					{
						DataSet ds = ProjectFunctions.GetDataSet("sp_LoadDataFSKUFGrid '" + dr2["SKUVOUCHNO"].ToString() + "','" + GlobalVariables.FinancialYear + "','" + GlobalVariables.CUnitID + "'");
						if (i == 0)
						{
							dt.Clear();
							dt = ds.Tables[0];
							i = checked(i + 1);
						}
						else
						{
							dt.Merge(ds.Tables[0]);
						}
					}
				}
				if (dt.Rows.Count > 0)
				{
					decimal QtySum = default(decimal);
					foreach (DataRow dr in dt.Rows)
					{
						dr["SFDBOXNO"] = Convert.ToDecimal(lblBox.Text);
						QtySum += Convert.ToDecimal(dr["SFDSCANQTY"]);
					}
					lblTotQty.Text = QtySum.ToString("0");
					BarCodeGrid.DataSource = dt;
					BarCodeGridView.BestFitColumns();
				}
				else
				{
					BarCodeGrid.DataSource = null;
				}
				HelpGrid.Visible = false;
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void BarCodeGrid_KeyDown(object sender, KeyEventArgs e)
		{
			ProjectFunctions.DeleteCurrentRowOnKeyDown(BarCodeGrid, BarCodeGridView, e);
			dt.AcceptChanges();
			decimal QtySum = default(decimal);
			foreach (DataRow dr in dt.Rows)
			{
				QtySum += Convert.ToDecimal(dr["SFDSCANQTY"]);
			}
			lblTotQty.Text = QtySum.ToString("0");
		}

		private void BarCodeGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{
			try
			{
				e.Menu.Items.Add(new DXMenuItem("Delete Current Record", delegate
				{
					ProjectFunctions.DeleteCurrentRowOnRightClick(BarCodeGrid, BarCodeGridView);
					dt.AcceptChanges();
					decimal num = default(decimal);
					foreach (DataRow dataRow in dt.Rows)
					{
						num += Convert.ToDecimal(dataRow["SFDSCANQTY"]);
					}
					lblTotQty.Text = num.ToString("0");
				}));
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void BarCodeGrid_Click(object sender, EventArgs e)
		{
			try
			{
				DataRow currentrow = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);
				ShowImage(currentrow["SFDARTID"].ToString());
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void HelpGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{
			e.Menu.Items.Add(new DXMenuItem("Select All Records", delegate
			{
				int rowCount = (HelpGrid.KeyboardFocusView as GridView).RowCount;
				for (int i = 0; i < rowCount; i = checked(i + 1))
				{
					HelpGridView.SetRowCellValue(i, HelpGridView.Columns["Select"], true);
				}
			}));
		}

		private void FrmBoxAddEdit_KeyDown(object sender, KeyEventArgs e)
		{
			ProjectFunctions.SalePopUPForAllWindows(this, e);
		}

		private void HelpGrid_Click(object sender, EventArgs e)
		{
		}

	}
}