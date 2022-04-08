using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Transaction;

namespace WindowsFormsApplication1.Transaction
{
	public partial class FrmBarPrinting : DevExpress.XtraEditors.XtraForm
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


		public FrmBarPrinting()
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
			dt.Columns.Add("SizeMappingTransID", typeof(string));
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
				if (HelpGridView.RowCount <= 0)
				{
					return;
				}
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
						BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUFEDQTY"];
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
						BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SizeMappingTransID"], string.Empty);
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
					BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZID"], row["SZSYSID"].ToString());
					BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SKUSIZN"], row["SZNAME"].ToString());
					BarCodeGridView.SetRowCellValue(RowIndex, BarCodeGridView.Columns["SizeMappingTransID"], row["SizeMappingTransID"].ToString());
					panelControl1.Visible = false;
					BarCodeGridView.Focus();
					dt.AcceptChanges();
					BarCodeGridView.FocusedColumn = BarCodeGridView.Columns["SKUFEDQTY"];
					BarCodeGridView.ShowEditor();
					BarCodeGridView.FocusedRowHandle = RowIndex;
					txtSearchBox.Text = string.Empty;
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
				if (e.KeyCode == Keys.Return)
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
				if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.F12 && e.KeyCode != Keys.Return)
				{
					if (BarCodeGridView.FocusedColumn.FieldName == "SKUARTNO")
					{
						if (currentrow == null)
						{
							HelpGrid.Text = "SKUARTNO";
							txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
							txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
							panelControl1.Visible = true;
							panelControl1.Select();
							txtSearchBox.Focus();
							txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
							txtSearchBox.SelectionLength = 0;
						}
						else
						{
							DataSet dsCheck2 = ProjectFunctions.GetDataSet("Select * from COLOURS where COLSYSID='" + ProjectFunctions.CheckNull(currentrow["SKUCOLID"].ToString()) + "'");
							if (dsCheck2.Tables[0].Rows.Count > 0)
							{
								UpdateTag = "Y";
								HelpGrid.Text = "SKUCOLN";
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
							txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
							panelControl1.Visible = true;
							panelControl1.Select();
							txtSearchBox.Focus();
							txtSearchBox.SelectionStart = txtSearchBox.Text.Length;
							txtSearchBox.SelectionLength = 0;
						}
						else
						{
							DataSet dsCheck3 = ProjectFunctions.GetDataSet("sp_LoadSizes '" + currentrow["SKUARTNO"].ToString() + "', '" + ProjectFunctions.CheckNull(currentrow["SKUSIZID"].ToString()) + "' ");
							if (dsCheck3.Tables[0].Rows.Count > 0)
							{
								UpdateTag = "Y";
								HelpGrid.Text = "SKUSIZN";
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
								txtSearchBox.Text += ProjectFunctions.ValidateKeysForSearchBox(e);
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
						DataSet dsSizeTransID = ProjectFunctions.GetDataSet("sp_LoadSizeMappingID '" + row["SKUARTID"].ToString() + "','" + dsNewSize.Tables[0].Rows[0]["SZSYSID"].ToString() + "','" + row["SizeMappingTransID"].ToString() + "'");
						if (dsSizeTransID.Tables[0].Rows.Count <= 0)
						{
							ProjectFunctions.SpeakError("Size Not mapped further kindly update mapping");
							return;
						}
						dtNewRow["SizeMappingTransID"] = dsSizeTransID.Tables[0].Rows[0][0].ToString();
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

		private void BarCodeGridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
		{
			try
			{
				if (BarCodeGrid.DataSource != null && e.Column.FieldName == "SKUFEDQTY")
				{
					BarCodeGridView.CloseEditor();
					BarCodeGridView.UpdateCurrentRow();
					DataRow row = BarCodeGridView.GetDataRow(BarCodeGridView.FocusedRowHandle);
					BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["SKUMRPVAL"], Convert.ToDecimal(row["SKUMRP"]) * Convert.ToDecimal(row["SKUFEDQTY"]));
					BarCodeGridView.SetRowCellValue(BarCodeGridView.FocusedRowHandle, BarCodeGridView.Columns["SKUWSPVAL"], Convert.ToDecimal(row["SKUWSP"]) * Convert.ToDecimal(row["SKUFEDQTY"]));
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
				SplashScreenManager.ShowForm(this, typeof(WaitForm1), useFadeIn: true, useFadeOut: true, throwExceptionIfAlreadyOpened: false);
				int i = 0;
				foreach (DataRow dr in dt.Rows)
				{
					i = checked(i + 1);
					SplashScreenManager.Default.SetWaitFormDescription("Validating Item " + i + " / " + dt.Rows.Count);
					if (dsCheckART.Tables[0].Rows.Count <= 0)
					{
						continue;
					}
					foreach (DataRow drInner in dsCheckART.Tables[0].Rows)
					{
						if (!(drInner["ARTSYSID"].ToString() == dr["SKUARTID"].ToString()) || Convert.ToDecimal(dr["SKUMRP"]) == Convert.ToDecimal(drInner["ARTMRP"]))
						{
							continue;
						}
						ProjectFunctions.SpeakError("Wrong MRP Found");
						return false;
					}
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
			if (!ValidateDataForSaving() || !(S1 == "&Add"))
			{
				return;
			}
			using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
			{
				sqlcon.Open();
				var sqlcom = sqlcon.CreateCommand();
				sqlcom.Connection = sqlcon;
				sqlcom.CommandType = CommandType.Text;
				try
				{
					SplashScreenManager.ShowForm(this, typeof(WaitForm1), useFadeIn: true, useFadeOut: true, throwExceptionIfAlreadyOpened: false);
					SplashScreenManager.Default.SetWaitFormDescription("Saving Items");
					int i = 0;
					if (!ChkFixedBarCode.Checked)
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
						dtFinal.Columns.Add("SizeMappingTransID", typeof(string));
						dtFinal.Rows.Clear();
						foreach (DataRow dr in (BarCodeGrid.DataSource as DataTable).Rows)
						{
							if (Convert.ToDecimal(dr["SKUFEDQTY"]) > 0m)
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
								drRow["SKUFEDQTY"] = dr["SKUFEDQTY"].ToString();
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
								drRow["SizeMappingTransID"] = dr["SizeMappingTransID"].ToString();
								dtFinal.Rows.Add(drRow);
							}
						}
						dtFinal.AcceptChanges();
						sqlcom.CommandType = CommandType.StoredProcedure;
						sqlcom.CommandText = "sp_InsertBarCodeData2";
						sqlcom.CommandTimeout = 600000;
						SqlParameter param = new SqlParameter
						{
							ParameterName = "@BarCodeTable2",
							Value = dtFinal
						};
						sqlcom.Parameters.Add(param);
						sqlcom.ExecuteNonQuery();
						sqlcom.Parameters.Clear();
						SplashScreenManager.CloseForm();
					}
					else
					{
						i = checked(i + 1);
						SplashScreenManager.Default.SetWaitFormDescription("Saving Item " + i + " / " + (BarCodeGrid.DataSource as DataTable).Rows.Count);
						txtSysID.Text = ProjectFunctions.GetDataSet("select isnull(max(SKUVOUCHNO),0)+1 from SKU_Fix Where UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
						foreach (DataRow dr2 in (BarCodeGrid.DataSource as DataTable).Rows)
						{
							string SKUCode = ProjectFunctions.GetDataSet("select isnull(max(SKUCODE),0)+1 from SKU_FIx where UnitCode='" + GlobalVariables.CUnitID + "'").Tables[0].Rows[0][0].ToString();
							string SKUPRODUCTCODE = "X" + SKUCode.PadLeft(9, '0');
							DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SKU_FIx Where SKUARTID='" + dr2["SKUARTID"].ToString() + "'ANd SKUCOLID='" + dr2["SKUCOLID"].ToString() + "' And SKUSIZID='" + dr2["SKUSIZID"].ToString() + "'");
							if (dsCheck.Tables[0].Rows.Count > 0)
							{
								SKUPRODUCTCODE = dsCheck.Tables[0].Rows[0]["SKUPRODUCTCODE"].ToString();
								SKUCode = dsCheck.Tables[0].Rows[0]["SKUCODE"].ToString();
							}
							sqlcom.CommandType = CommandType.Text;
							sqlcom.CommandTimeout = 600000;
							sqlcom.CommandText = " Insert into SKU_FIx  (SKUSYSDATE,SKUFNYR,SKUCODE,SKUVOUCHNO,SKUPRODUCTCODE,SKUARTNO, SKUARTID,SKUCOLN,SKUCOLID,SKUSIZN,SKUSIZID,SKUFEDQTY, SKUGENMODAUTO,SKUCODSCHEM,SKUWSP,SKUMRP,SKUWSPVAL,SKUMRPVAL,SKUASORDR,SKUNMAINTSTK,SKUARTCOLSET,SKUARTSIZSET,SKUSIZINDX,UnitCode) values(@SKUSYSDATE,@SKUFNYR,@SKUCODE,@SKUVOUCHNO,@SKUPRODUCTCODE,@SKUARTNO, @SKUARTID,@SKUCOLN,@SKUCOLID,@SKUSIZN,@SKUSIZID,@SKUFEDQTY, @SKUGENMODAUTO,@SKUCODSCHEM,@SKUWSP,@SKUMRP,@SKUWSPVAL,@SKUMRPVAL,@SKUASORDR,@SKUNMAINTSTK,@SKUARTCOLSET,@SKUARTSIZSET,@SKUSIZINDX,@UnitCode )";
							sqlcom.Parameters.Add("@SKUSYSDATE", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
							sqlcom.Parameters.Add("@SKUFNYR", SqlDbType.NVarChar).Value = GlobalVariables.FinancialYear;
							sqlcom.Parameters.Add("@SKUCODE", SqlDbType.NVarChar).Value = SKUCode;
							sqlcom.Parameters.Add("@SKUVOUCHNO", SqlDbType.NVarChar).Value = txtSysID.Text;
							sqlcom.Parameters.Add("@SKUPRODUCTCODE", SqlDbType.NVarChar).Value = SKUPRODUCTCODE;
							sqlcom.Parameters.Add("@SKUARTNO", SqlDbType.NVarChar).Value = dr2["SKUARTNO"].ToString();
							sqlcom.Parameters.Add("@SKUARTID", SqlDbType.NVarChar).Value = dr2["SKUARTID"].ToString();
							sqlcom.Parameters.Add("@SKUCOLN", SqlDbType.NVarChar).Value = dr2["SKUCOLN"].ToString();
							sqlcom.Parameters.Add("@SKUCOLID", SqlDbType.NVarChar).Value = dr2["SKUCOLID"].ToString();
							sqlcom.Parameters.Add("@SKUSIZN", SqlDbType.NVarChar).Value = dr2["SKUSIZN"].ToString();
							sqlcom.Parameters.Add("@SKUSIZID", SqlDbType.NVarChar).Value = dr2["SKUSIZID"].ToString();
							sqlcom.Parameters.Add("@SKUFEDQTY", SqlDbType.NVarChar).Value = dr2["SKUFEDQTY"].ToString();
							sqlcom.Parameters.Add("@SKUGENMODAUTO", SqlDbType.NVarChar).Value = "0";
							sqlcom.Parameters.Add("@SKUCODSCHEM", SqlDbType.NVarChar).Value = "0";
							if (dr2["SKUWSP"].ToString() == string.Empty)
							{
								dr2["SKUWSP"] = "0";
							}
							sqlcom.Parameters.Add("@SKUWSP", SqlDbType.NVarChar).Value = dr2["SKUWSP"].ToString();
							if (dr2["SKUMRP"].ToString() == string.Empty)
							{
								dr2["SKUMRP"] = "0";
							}
							sqlcom.Parameters.Add("@SKUMRP", SqlDbType.NVarChar).Value = dr2["SKUMRP"].ToString();
							if (dr2["SKUWSPVAL"].ToString() == string.Empty)
							{
								dr2["SKUWSPVAL"] = "0";
							}
							sqlcom.Parameters.Add("@SKUWSPVAL", SqlDbType.NVarChar).Value = dr2["SKUWSPVAL"].ToString();
							if (dr2["SKUMRPVAL"].ToString() == string.Empty)
							{
								dr2["SKUMRPVAL"] = "0";
							}
							sqlcom.Parameters.Add("@SKUMRPVAL", SqlDbType.NVarChar).Value = dr2["SKUMRPVAL"].ToString();
							sqlcom.Parameters.Add("@SKUASORDR", SqlDbType.NVarChar).Value = "0";
							sqlcom.Parameters.Add("@SKUNMAINTSTK", SqlDbType.NVarChar).Value = "0";
							if (dr2["SKUARTCOLSET"].ToString() == string.Empty)
							{
								dr2["SKUARTCOLSET"] = "0";
							}
							sqlcom.Parameters.Add("@SKUARTCOLSET", SqlDbType.NVarChar).Value = dr2["SKUARTCOLSET"].ToString();
							if (dr2["SKUARTSIZSET"].ToString() == string.Empty)
							{
								dr2["SKUARTSIZSET"] = "0";
							}
							sqlcom.Parameters.Add("@SKUARTSIZSET", SqlDbType.NVarChar).Value = dr2["SKUARTSIZSET"].ToString();
							if (dr2["SKUSIZINDX"].ToString() == string.Empty)
							{
								dr2["SKUSIZINDX"] = "0";
							}
							sqlcom.Parameters.Add("@SKUSIZINDX", SqlDbType.NVarChar).Value = dr2["SKUSIZINDX"].ToString();
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
				DataSet ds = ProjectFunctions.GetDataSet("[sp_LoadBarCodeVouchersEdit3] '" + SKUVOUCHNO + "','" + GlobalVariables.FinancialYear + "','" + Tag + "'");
				if (ds.Tables[0].Rows.Count > 0)
				{
					txtSysID.Text = SKUVOUCHNO;
					txtDeptCode.Text = ds.Tables[0].Rows[0]["StoreCode"].ToString();
					dt = ds.Tables[0];
					BarCodeGrid.DataSource = dt;
					BarCodeGridView.BestFitColumns();
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
					DataTable dtNew2 = dsPopUps.Tables[0].Clone();
					DataRow[] dtRow3 = dsPopUps.Tables[0].Select("ARTNO like '" + txtSearchBox.Text + "%'");
					DataRow[] array = dtRow3;
					foreach (DataRow dr3 in array)
					{
						DataRow NewRow3 = dtNew2.NewRow();
						NewRow3["ARTNO"] = dr3["ARTNO"];
						NewRow3["ARTDESC"] = dr3["ARTDESC"];
						NewRow3["ARTMRP"] = dr3["ARTMRP"];
						NewRow3["ARTWSP"] = dr3["ARTWSP"];
						NewRow3["ARTSYSID"] = dr3["ARTSYSID"];
						dtNew2.Rows.Add(NewRow3);
					}
					if (dtNew2.Rows.Count > 0)
					{
						HelpGrid.DataSource = dtNew2;
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
					DataTable dtNew3 = dsPopUps.Tables[1].Clone();
					DataRow[] dtRow2 = dsPopUps.Tables[1].Select("COLNAME like '" + txtSearchBox.Text + "%'");
					DataRow[] array2 = dtRow2;
					foreach (DataRow dr2 in array2)
					{
						DataRow NewRow2 = dtNew3.NewRow();
						NewRow2["COLNAME"] = dr2["COLNAME"];
						NewRow2["COLSYSID"] = dr2["COLSYSID"];
						dtNew3.Rows.Add(NewRow2);
					}
					if (dtNew3.Rows.Count > 0)
					{
						HelpGrid.DataSource = dtNew3;
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
					DataRow[] array3 = dtRow;
					foreach (DataRow dr in array3)
					{
						DataRow NewRow = dtNew.NewRow();
						NewRow["SZNAME"] = dr["SZNAME"];
						NewRow["SZSYSID"] = dr["SZSYSID"];
						NewRow["SZINDEX"] = dr["SZINDEX"];
						NewRow["SizeMappingTransID"] = dr["SizeMappingTransID"];
						dtNew.Rows.Add(NewRow);
					}
					if (dtNew.Rows.Count > 0)
					{
						HelpGrid.DataSource = dtNew;
						HelpGridView.BestFitColumns();
						HelpGridView.Columns[1].SortOrder = ColumnSortOrder.Ascending;
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
				if (e.KeyCode == Keys.Return)
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

		private void BarCodeGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{
			try
			{
				e.Menu.Items.Add(new DXMenuItem("Delete Current Record", delegate
				{
					ProjectFunctions.DeleteCurrentRowOnRightClick(BarCodeGrid, BarCodeGridView);
				}));
				e.Menu.Items.Add(new DXMenuItem("Export To CSV", delegate
				{
					BarCodeGridView.ExportToCsv(Application.StartupPath + "\\label\\Stic.csv");
					Process.Start(Application.StartupPath + "\\label\\EAN.btw");
				}));
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
		}

		private void BarCodeGrid_Click(object sender, EventArgs e)
		{
		}

		private void FrmBarPrinting_KeyDown(object sender, KeyEventArgs e)
		{
			ProjectFunctions.SalePopUPForAllWindows(this, e);
		}

		private void BarCodeGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.CloseEditor();
				BarCodeGridView.UpdateCurrentRow();
				BarCodeGridView.ShowEditor();
			}
		}

		private void BarCodeGridView_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
		{
			if (BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.ShowEditor();
			}
		}

		private void BarCodeGridView_InitNewRow(object sender, InitNewRowEventArgs e)
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
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			try
			{
				if (e.KeyCode == Keys.Return)
				{
					DataSet dsCheck = ProjectFunctions.GetDataSet(" sp_LoadRePrintBarCode '" + txtBarCode.Text + "','01'");
					
					
					
					if (dsCheck.Tables[0].Rows.Count <= 0)
					{
						ProjectFunctions.SpeakError("BarCode Not Generated");
						txtBarCode.SelectAll();
						txtBarCode.Focus();
						e.Handled = true;
						return;
					}
					foreach (DataRow dr2 in dt.Rows)
					{
						if (dr2["SKUPRODUCTCODE"].ToString().ToUpper() == txtBarCode.Text.Trim().ToUpper())
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
				txtQty.Focus();
			}
			catch (Exception ex)
			{
				ProjectFunctions.SpeakError(ex.Message);
			}
			e.Handled = true;
		}

		private void BtnPrint_Click(object sender, EventArgs e)
		{

			DataRow dtNewRow = dt.NewRow();
			foreach (DataRow drInner in dsPopUps.Tables[0].Rows)
			{
				if (drInner["ARTEAN"].ToString().ToUpper() == txtBarCode.Text.ToUpper())
				{
					dtNewRow["SKUARTNO"] = drInner["ARTNO"].ToString();
					dtNewRow["ARTDESC"] = drInner["ARTDESC"].ToString();
					dtNewRow["SKUMRP"] = drInner["ARTMRP"].ToString();
					dtNewRow["SKUWSP"] = drInner["ARTWSP"].ToString();
					dtNewRow["SKUFEDQTY"] = Convert.ToDecimal(txtQty.Text);
					dtNewRow["SKUMRPVAL"] = Convert.ToDecimal(drInner["ARTMRP"]);
					dtNewRow["SKUWSPVAL"] = Convert.ToDecimal(drInner["ARTWSP"]);
					dtNewRow["SKUARTID"] = drInner["ARTSYSID"].ToString();
					dt.Rows.Add(dtNewRow);
					break;
				}
			}
			if (dt.Rows.Count > 0)
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

		private void BarCodeGridView_RowUpdated(object sender, RowObjectEventArgs e)
		{
			BarCodeGridView.ShowEditor();
		}

		private void BarCodeGridView_ColumnChanged(object sender, EventArgs e)
		{
			if (dt.Rows.Count > 0 && BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.ShowEditor();
			}
		}

		private void BarCodeGridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
		{
			if (dt.Rows.Count > 0 && BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.ShowEditor();
			}
		}

		private void BarCodeGridView_ValidateRow(object sender, ValidateRowEventArgs e)
		{
			if (dt.Rows.Count > 0 && BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.ShowEditor();
			}
		}

		private void BarCodeGridView_GotFocus(object sender, EventArgs e)
		{
			if (dt.Rows.Count > 0 && BarCodeGridView.FocusedColumn.FieldName == "SKUFEDQTY")
			{
				BarCodeGridView.ShowEditor();
			}
		}

		private void BtnImport_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
			openFileDialog1.ShowDialog();
		}

		private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			string xlConn = string.Empty;
			DataSet dsGeneric = ProjectFunctions.GetDataSet("SELECT distinct [GENERIC ART],[GENERIC ARTICLE NAME], (case when segment like'%WOMEN%'then   'LADIES' else SEGMENT END) AS Segment,[POS DESCRIPTION],[HSN CODE] from PISourceData Where Feeddt>='2021-11-02'");
			if (dsGeneric.Tables[0].Rows.Count > 0)
			{
				dtGeneric = dsGeneric.Tables[0];
				foreach (DataRow dr in dtGeneric.Rows)
				{
					DataSet dsCheckGroup = ProjectFunctions.GetDataSet("select GrpDesc from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'");
					if (dsCheckGroup.Tables[0].Rows.Count <= 0)
					{
						ProjectFunctions.GetDataSet(" Insert into GrpMst(GrpCode,GrpDesc)values((Select max(isnull(GrpCode,0))+1 from GrpMst),'" + dr["SEGMENT"].ToString().Trim() + "')");
					}
					DataSet dsCheckSubGroup = ProjectFunctions.GetDataSet("select GrpSubDesc,GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "' And GrpSubDesc='" + dr["POS DESCRIPTION"].ToString().Trim() + "'");
					if (dsCheckSubGroup.Tables[0].Rows.Count <= 0)
					{
						ProjectFunctions.GetDataSet(" Insert into GrpMst(GrpCode,GrpSubCode,GrpDesc,GrpSubDesc,GrpHSNCode)values((Select Distinct GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'),((Select max(isnull(GrpSubCode,0))+1 from GrpMst Where GrpCode=(Select Distinct GrpCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'))),'" + dr["SEGMENT"].ToString().Trim() + "','" + dr["POS DESCRIPTION"].ToString().Trim() + "','" + dr["HSN CODE"].ToString() + "')");
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

		private void OpenFileDialog2_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				DataSet dsVariant = ProjectFunctions.GetDataSet("SELECT [GENERIC ART],[GENERIC ARTICLE NAME],[MRP], [SIZE],[COLOR] from PISourceVariants Where Feeddt>='2021-11-02'");
				if (dsVariant.Tables[0].Rows.Count > 0)
				{
					dtVariants = dsVariant.Tables[0];
					foreach (DataRow dr2 in dtVariants.Rows)
					{
						DataSet dsCheckSIZE = ProjectFunctions.GetDataSet("select SZNAME from SIZEMAST Where SZNAME='" + dr2["SIZE"].ToString().Trim() + "'");
						if (dsCheckSIZE.Tables[0].Rows.Count <= 0)
						{
							ProjectFunctions.GetDataSet("  Insert into SIZEMAST (SZNAME,SZDESC)values('" + dr2["SIZE"].ToString().Trim() + "','" + dr2["SIZE"].ToString().Trim() + "')");
						}
						DataSet dsCheckColor = ProjectFunctions.GetDataSet("select COLNAME from COLOURS Where COLNAME='" + dr2["COLOR"].ToString().Trim() + "'");
						if (dsCheckColor.Tables[0].Rows.Count <= 0)
						{
							ProjectFunctions.GetDataSet(" Insert into COLOURS(COLNAME)values('" + dr2["COLOR"].ToString().Trim() + "')");
						}
					}
				}
				foreach (DataRow dr in dtGeneric.Rows)
				{
					DataSet dsCheckArticle = ProjectFunctions.GetDataSet("select * from Article Where ARTNO='" + dr["GENERIC ARTICLE NAME"].ToString().Trim() + "'");
					if (dsCheckArticle.Tables[0].Rows.Count > 0)
					{
						continue;
					}
					DataSet dsCheckGroup = ProjectFunctions.GetDataSet("select GrpCode,GrpDesc from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "'");
					DataSet dsCheckSubGroup = ProjectFunctions.GetDataSet("select GrpSubDesc,GrpCode,GrpSubCode from GrpMst Where GrpDesc='" + dr["SEGMENT"].ToString().Trim() + "' And GrpSubDesc='" + dr["POS DESCRIPTION"].ToString().Trim() + "'");
					decimal MRP = default(decimal);
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
				ProjectFunctions.GetDataSet("update ARTICLE Set ARTICLE.ARTALIAS=cast(PISourceData.[GENERIC ART] as bigint) from ARTICLE inner join PISourceData  on ARTICLE.ARTNO=PISourceData.[GENERIC ARTICLE NAME]");
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message);
			}
		}

		private void TxtDeptCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
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
			simpleButton1.Visible = false;
		}

		private void RBDIRECT_CheckedChanged(object sender, EventArgs e)
		{
			btnImport.Visible = false;
			BTNIMPORT2.Visible = false;
			simpleButton1.Visible = true;
		}

		private void SimpleButton1_Click_1(object sender, EventArgs e)
		{
			DataSet ds = ProjectFunctions.GetDataSet("sp_LoadBarCodeEANSourceVaariant ");
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

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
			ProjectFunctions.NumberOnly(e);
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
			
			DataSet ds = ProjectFunctions.GetDataSet("select [ITCODE,C,15] as ARTEAN,1 as Stock from Sheet1$ where [BALANCE1,N,14,3]<=0");
			foreach (DataRow dr in ds.Tables[0].Rows)
			{
				foreach (DataRow drInner in dsPopUps.Tables[0].Rows)
				{
					if (drInner["ARTEAN"].ToString().ToUpper() == dr["ARTEAN"].ToString().ToUpper())
					{
						DataRow dtNewRow = dt.NewRow();

						dtNewRow["SKUARTNO"] = drInner["ARTNO"].ToString();
						dtNewRow["ARTDESC"] = drInner["ARTDESC"].ToString();
						dtNewRow["SKUMRP"] = drInner["ARTMRP"].ToString();
						dtNewRow["SKUWSP"] = drInner["ARTWSP"].ToString();
						dtNewRow["SKUFEDQTY"] = Convert.ToDecimal("1");
						dtNewRow["SKUMRPVAL"] = Convert.ToDecimal(drInner["ARTMRP"]);
						dtNewRow["SKUWSPVAL"] = Convert.ToDecimal(drInner["ARTWSP"]);
						dtNewRow["SKUARTID"] = drInner["ARTSYSID"].ToString();
						dt.Rows.Add(dtNewRow);
						break;
					}
				}
			}
			if (dt.Rows.Count > 0)
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
    }
}