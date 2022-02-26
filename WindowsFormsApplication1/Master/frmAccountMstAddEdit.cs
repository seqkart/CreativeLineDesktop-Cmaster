﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeqKartLibrary;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxProEWB.API;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmAccountMstAddEdit : XtraForm
    {
        string TransID;
        public string S1 { get; set; }
        public string AccCode { get; set; }
        public FrmAccountMstAddEdit()
        {
            InitializeComponent();

        }
        private void LoadDelAddresses()
        {
            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActDelAddresses '" + txtAcCode.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                InfoGrid.DataSource = ds.Tables[0];
                InfoGridView.BestFitColumns();
            }
            else
            {
                InfoGrid.DataSource = null;
                InfoGridView.BestFitColumns();
            }

            txtDelAddress1.Text = string.Empty;
            txtDelAddress2.Text = string.Empty;
            txtDelAddress3.Text = string.Empty;
            txtDelCitycode.Text = string.Empty;
            txtDelCityName.Text = string.Empty;
            txtDelGSTNo.Text = string.Empty;
            txtDelAccName.Text = string.Empty;
            txtDelZipCode.Text = string.Empty;
        }
        private void TxtSLCode_EditValueChanged(object sender, EventArgs e)
        {
            txtSLDesc.Text = string.Empty;
        }
        private void SetMyControls()
        {
            try
            {
                txtAcCode.Enabled = false;
                ProjectFunctions.TextBoxVisualize(this);

                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
                ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.TextBoxVisualize(panelControl2);
                ProjectFunctions.TextBoxVisualize(xtraTabPage1);
                ProjectFunctions.TextBoxVisualize(panelControl3);
                ProjectFunctions.ButtonVisualize(this);
                ProjectFunctions.XtraFormVisualize(this);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void TxtBCCode_EditValueChanged(object sender, EventArgs e)
        {
            txtBSDesc.Text = string.Empty;
        }

        private void TxtEmpCode_EditValueChanged(object sender, EventArgs e)
        {
            txtEmpName.Text = string.Empty;
        }

        private void FrmAccountMstAddEdit_Load(object sender, EventArgs e)
        {
            try
            {
                SetMyControls();
                if (S1 == "&Add")
                {
                    txtAcCategory.Focus();
                    txtAcCode.Text = ProjectFunctions.GetNewTransactionCode("select max(Cast(AccCode as int)) from ActMst");
                }
                if (S1 == "Edit")
                {
                    //txtAcName.Enabled = false;
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActMstFEditing '" + AccCode + "'");
                    txtAccCodeBusy.Text = ds.Tables[0].Rows[0]["AccCodeBusy"].ToString();
                    txtAcCategory.Text = ds.Tables[0].Rows[0]["AccType"].ToString();
                    txtAcCode.Text = ds.Tables[0].Rows[0]["AccCode"].ToString();
                    txtAcName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                    txtAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                    txtAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                    txtAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                    txtBankAccNo.Text = ds.Tables[0].Rows[0]["AccBankAccNo"].ToString();
                    txtBankName.Text = ds.Tables[0].Rows[0]["AccAcinBankName"].ToString();
                    txtBillingName.Text = ds.Tables[0].Rows[0]["BillingName"].ToString();
                    txtBSCode.Text = ds.Tables[0].Rows[0]["AccBSHcode"].ToString();
                    txtBSDesc.Text = ds.Tables[0].Rows[0]["BSDesc"].ToString();
                    txtChequeName.Text = ds.Tables[0].Rows[0]["AccChqName"].ToString();
                    txtContactPerson.Text = ds.Tables[0].Rows[0]["AccContactPerson"].ToString();
                    txtCstPst.Text = ds.Tables[0].Rows[0]["AccPSTCST"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["AccEmail"].ToString();
                    txtEmpCode.Text = ds.Tables[0].Rows[0]["AccEmpCode"].ToString();
                    txtEmpName.Text = ds.Tables[0].Rows[0]["EmpName"].ToString();
                    txtGSTNo.Text = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
                    txtNameAsOnBankAcc.Text = ds.Tables[0].Rows[0]["AccNameAsInBank"].ToString();
                    txtOBalance.Text = ds.Tables[0].Rows[0]["ActOpBal"].ToString();
                    txtPanNo.Text = ds.Tables[0].Rows[0]["AccPANno"].ToString();
                    txtSLCode.Text = ds.Tables[0].Rows[0]["AccLedger"].ToString();
                    txtSLDesc.Text = ds.Tables[0].Rows[0]["LgrDesc"].ToString();

                    txtStatusTag.Text = ds.Tables[0].Rows[0]["AccAnATag"].ToString();

                    txtTel.Text = ds.Tables[0].Rows[0]["AccTeleFax"].ToString();
                    txtTinNo.Text = ds.Tables[0].Rows[0]["AccTIN"].ToString();
                    txtGSTStateCode.Text = ds.Tables[0].Rows[0]["AccGSTStateCode"].ToString();

                    txtGSTStateDesc.Text = ds.Tables[0].Rows[0]["GSTStateDesc"].ToString();
                    txtGSTType.Text = ds.Tables[0].Rows[0]["AccGSTType"].ToString();


                    txtLCTag.Text = ds.Tables[0].Rows[0]["AccLCTag"].ToString();
                    txtMobileNo.Text = ds.Tables[0].Rows[0]["AccMobNo"].ToString();
                    txtAltMobileNo.Text = ds.Tables[0].Rows[0]["AccAltMobNo"].ToString();
                    txtCityCode.Text = ds.Tables[0].Rows[0]["AccCityCode"].ToString();
                    txtCityName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                    txtState.Text = ds.Tables[0].Rows[0]["STNAME"].ToString();
                    txtCountry.Text = ds.Tables[0].Rows[0]["UNDERRG"].ToString();
                    txtMRPMarkDown.Text = ds.Tables[0].Rows[0]["AccMrpMarkDown"].ToString();
                    txtAgentCode.Text = ds.Tables[0].Rows[0]["AccBrokerID"].ToString();
                    txtAgentName.Text = ds.Tables[0].Rows[0]["AgentName"].ToString();
                    txtAccDCCode.Text = ds.Tables[0].Rows[0]["AccDCCode"].ToString();
                    txtZipCode.Text = ds.Tables[0].Rows[0]["AccZipCode"].ToString();
                    txtEnableTDS.EditValue = ds.Tables[0].Rows[0]["AccTDSEnable"].ToString();
                    txtStockTransferTag.Text = ds.Tables[0].Rows[0]["AccStkTrf"].ToString();
                    txtFixBArCodeTag.Text = ds.Tables[0].Rows[0]["AccFixBarCodeTag"].ToString();

                    txtUnitCode.Text = ds.Tables[0].Rows[0]["AccUnitCode"].ToString();
                    txtUnitName.Text = ds.Tables[0].Rows[0]["UNITNAME"].ToString();
                    cmbTaxType.SelectedItem = ds.Tables[0].Rows[0]["AccTaxType"].ToString();

                    txtAddress4.Text = ds.Tables[0].Rows[0]["AccAddress4"].ToString();
                    txtWhatsAppNo.Text = ds.Tables[0].Rows[0]["WhatsAppNo"].ToString();

                    txtMainLedgerCode.Text = ds.Tables[0].Rows[0]["AccMainLedgerCode"].ToString();
                    txtMainLedgerDesc.Text = ds.Tables[0].Rows[0]["GrpDesc"].ToString();
                    txtSubLedgerCode.Text = ds.Tables[0].Rows[0]["AccSubLedgerCode"].ToString();
                    txtSubLedgerDesc.Text = ds.Tables[0].Rows[0]["GrpSubDesc"].ToString();








                    txtAcCategory.Focus();
                    LoadDelAddresses();
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void FrmAccountMstAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidateData()
        {
            try
            {
                if (txtMainLedgerCode.Text.Trim().Length == 0)
                {
                    txtMainLedgerCode.Text = "0";

                }
                if (txtSubLedgerCode.Text.Trim().Length == 0)
                {
                    txtSubLedgerCode.Text = "0";
                }
                if (txtOBalance.Text.Trim().Length == 0)
                {
                    txtOBalance.Text = "0";
                }
                if (txtAgentCode.Text.Trim().Length == 0)
                {
                    txtAgentCode.Text = "0";
                }
                if (txtZipCode.Text.Trim().Length == 0)
                {
                    txtZipCode.Text = "0";
                }
                if (txtAcCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Account Code");
                    txtAcCode.Focus();
                    return false;
                }
                if (txtAcName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Account Name");
                    txtAcName.Focus();
                    return false;
                }
                if (txtMRPMarkDown.Text.Trim().Length == 0)
                {
                    txtMRPMarkDown.Text = "0";
                }



                if (txtLCTag.Text.ToUpper() == "L" || (txtLCTag.Text.ToUpper() == "C"))
                {
                    txtLCTag.Text = txtLCTag.Text.ToUpper();
                }
                else
                {
                    ProjectFunctions.SpeakError("Valid Vales Are L/C");
                    txtLCTag.Text = string.Empty;
                    return false;
                }

                if (txtGSTStateCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid GST State Desc");
                    txtGSTStateCode.Focus();
                    return false;
                }
                if (txtGSTStateDesc.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid GST State Desc");
                    txtGSTStateCode.Focus();
                    return false;
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
                            sqlcom.CommandText = " Insert into ActMst"
                            + " (AccTaxType,AccActive,AccCode,AccType,AccName,AccLedger,ActOpBal,AccEmpCode,AccBSHcode,AccGSTNo,AccGSTStateCode,AccLCTag,AccGSTType,AccStkTrf,AccUnitCode,AccFixBarCodeTag,AccCodeBusy,AccMainLedgerCode,AccSubLedgerCode)"
                            + " values(@AccTaxType,@AccActive,@AccCode,@AccType,@AccName,@AccLedger,@ActOpBal,@AccEmpCode,@AccBSHcode,@AccGSTNo,@AccGSTStateCode,@AccLCTag,@AccGSTType,@AccStkTrf,@AccUnitCode,@AccFixBarCodeTag,@AccCodeBusy,@AccMainLedgerCode,@AccSubLedgerCode)";
                            txtAcCode.Text = ProjectFunctions.GetNewTransactionCode("select max(Cast(AccCode as int)) from ActMst");
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE    ActMst SET "
                                                     + " AccTaxType=@AccTaxType,AccActive=@AccActive, AccType=@AccType,AccName=@AccName,AccLedger=@AccLedger,ActOpBal=@ActOpBal,"
                                                     + " AccEmpCode=@AccEmpCode,AccBSHcode=@AccBSHcode,AccGSTNo=@AccGSTNo,AccGSTStateCode=@AccGSTStateCode,AccLCTag=@AccLCTag,AccGSTType=@AccGSTType,AccStkTrf=@AccStkTrf,AccUnitCode=@AccUnitCode,AccFixBarCodeTag=@AccFixBarCodeTag,AccCodeBusy=@AccCodeBusy,AccMainLedgerCode=@AccMainLedgerCode,AccSubLedgerCode=@AccSubLedgerCode "
                                                     + " Where AccCode=@AccCode";
                        }
                        sqlcom.Parameters.AddWithValue("@AccTaxType", cmbTaxType.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccActive", txtStatusTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccCode", txtAcCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccType", txtAcCategory.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccName", txtAcName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccLedger", txtSLCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ActOpBal", Convert.ToDecimal(txtOBalance.Text.Trim()));
                        sqlcom.Parameters.AddWithValue("@AccEmpCode", txtEmpCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccBSHcode", txtBSCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccGSTType", txtGSTType.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccGSTNo", txtGSTNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccGSTStateCode", txtGSTStateCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccLCTag", txtLCTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccStkTrf", txtStockTransferTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccUnitCode", txtUnitCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccFixBarCodeTag", txtFixBArCodeTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccCodeBusy", txtAccCodeBusy.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccMainLedgerCode", txtMainLedgerCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccSubLedgerCode", txtSubLedgerCode.Text.Trim());

                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();
                        if (S1 == "&Add")
                        {
                            sqlcom.CommandText = " Insert into ActMstAddInf"
                                                   + " (AccCode,AccName,AccType,AccAddress1,AccAddress2,AccAddress3,AccAddress4,WhatsAppNo,AccTeleFax,AccEmail,AccContactPerson,"
                                                   + "AccPSTCST,AccAnATag,AccChqName,AccTIN,AccPANno,"
                                                   + " AccAcinBankName,AccNameAsInBank,AccBankAccNo,"
                                                    + " AccAltMobNo,AccBrokerID,AccMobNo,"
                                                     + " AccZipCode,AccCityCode,AccTDSEnable,AccMrpMarkDown,AccDCCode)"
                                                   + " values(@AccCode,@AccName,@AccType,@AccAddress1,@AccAddress2,@AccAddress3,@AccAddress4,@WhatsAppNo,@AccTeleFax,@AccEmail,@AccContactPerson,"
                                                   + "@AccPSTCST,@AccAnATag,@AccChqName,@AccTIN,@AccPANno,"
                                                   + " @AccAcinBankName,@AccNameAsInBank,@AccBankAccNo,"
                            + " @AccAltMobNo,@AccBrokerID,@AccMobNo,"
                            + " @AccZipCode,@AccCityCode,@AccTDSEnable,@AccMrpMarkDown,@AccDCCode)";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE    ActMstAddInf SET  "
                                                + "AccName=@AccName,AccType=@AccType,AccAddress1=@AccAddress1,AccAddress2=@AccAddress2,"
                                                + "AccAddress3=@AccAddress3,AccAddress4=@AccAddress4,WhatsAppNo=@WhatsAppNo,AccTeleFax=@AccTeleFax,AccEmail=@AccEmail,AccContactPerson=@AccContactPerson,"
                                                + "AccPSTCST=@AccPSTCST,"
                                                + "AccAnATag=@AccAnATag,AccChqName=@AccChqName,AccTIN=@AccTIN,"
                                                + "AccPANno=@AccPANno,AccAcinBankName=@AccAcinBankName,AccNameAsInBank=@AccNameAsInBank,"
                                                + "AccBankAccNo=@AccBankAccNo,AccAltMobNo=@AccAltMobNo,AccBrokerID=@AccBrokerID,AccMobNo=@AccMobNo,AccZipCode=@AccZipCode ,AccCityCode=@AccCityCode,AccTDSEnable=@AccTDSEnable,AccMrpMarkDown=@AccMrpMarkDown,AccDCCode=@AccDCCode"
                                                + " Where AccCode=@AccCode";
                        }


                        sqlcom.Parameters.AddWithValue("@AccCode", txtAcCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccName", txtBillingName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccType", txtAcCategory.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAddress1", txtAddress1.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAddress2", txtAddress2.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAddress3", txtAddress3.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAddress4", txtAddress4.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@WhatsAppNo", txtWhatsAppNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccTeleFax", txtTel.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccEmail", txtEmail.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccContactPerson", txtContactPerson.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccPSTCST", txtCstPst.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAnATag", txtStatusTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccChqName", txtChequeName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccTIN", txtTinNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccPANno", txtPanNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAcinBankName", txtBankName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccNameAsInBank", txtNameAsOnBankAcc.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccBankAccNo", txtBankAccNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccAltMobNo", txtAltMobileNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccBrokerID", txtAgentCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccMobNo", txtMobileNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccZipCode", txtZipCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccCityCode", txtCityCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccTDSEnable", txtEnableTDS.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@AccMrpMarkDown", Convert.ToDecimal(txtMRPMarkDown.Text));
                        sqlcom.Parameters.AddWithValue("@AccDCCode", txtAccDCCode.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();

                        transaction.Commit();
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
        private void TxtSLCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select LgrCode,LgrDesc from LgrMst", " Where LgrCode", txtSLCode, txtSLDesc, txtBSCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtBSCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select BSCode,BSDesc from BshMst", " Where BSCode", txtBSCode, txtBSDesc, txtBSCode, HelpGrid, HelpGridView, e);
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

                DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
                if (HelpGrid.Text == "txtAccCodeBusy")
                {
                    txtAccCodeBusy.Text = row["MasterCode1"].ToString();
                    txtAccNameBusy.Text = row["PRINTNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtAccCodeBusy.Focus();

                    if (chImportAll.Checked)
                    {
                        DataSet ds = ProjectFunctionsUtils.GetDataSetBusy("Select * from MasterAddressInfo where MasterCode='" + txtAccCodeBusy.Text + "'");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            txtAcName.Text = txtAccNameBusy.Text;
                            txtBillingName.Text = txtAccNameBusy.Text;
                            txtAddress1.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                            txtAddress2.Text = ds.Tables[0].Rows[0]["Address2"].ToString();
                            txtAddress3.Text = ds.Tables[0].Rows[0]["Address3"].ToString();
                            txtAddress4.Text = ds.Tables[0].Rows[0]["Address4"].ToString();
                            txtZipCode.Text = ds.Tables[0].Rows[0]["PINCode"].ToString();


                            DataSet dsCity = ProjectFunctions.GetDataSet("SELECT CITYMASTER.CTSYSID, CITYMASTER.CTNAME,STATEMASTER.STNAME,STATEMASTER.UNDERRG FROM CITYMASTER INNER JOIN STATEMASTER ON CITYMASTER.UNDERSTID = STATEMASTER.STSYSID Where CITYMASTER.CTNAME like'%" + ds.Tables[0].Rows[0]["Station"].ToString() + "%'");
                            if (dsCity.Tables[0].Rows.Count > 0)
                            {
                                txtCityCode.Text = dsCity.Tables[0].Rows[0]["CTSYSID"].ToString();
                                txtCityName.Text = dsCity.Tables[0].Rows[0]["CTNAME"].ToString();
                                txtState.Text = dsCity.Tables[0].Rows[0]["STNAME"].ToString();
                                txtCountry.Text = dsCity.Tables[0].Rows[0]["UNDERRG"].ToString();
                            }




                            txtTel.Text = ds.Tables[0].Rows[0]["TelNo"].ToString() + "," + ds.Tables[0].Rows[0]["Mobile"].ToString();
                            txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                            txtTinNo.Text = ds.Tables[0].Rows[0]["TINNo"].ToString();
                            txtCstPst.Text = ds.Tables[0].Rows[0]["CST"].ToString();
                            txtPanNo.Text = ds.Tables[0].Rows[0]["ITPAN"].ToString();
                            txtGSTNo.Text = ds.Tables[0].Rows[0]["GSTNo"].ToString();
                            txtWhatsAppNo.Text = ds.Tables[0].Rows[0]["WhatsAppNo"].ToString();



                        }
                    }
                }
                if (HelpGrid.Text == "txtSLCode")
                {
                    txtSLCode.Text = row["LgrCode"].ToString();
                    txtSLDesc.Text = row["LgrDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtBSCode.Focus();
                }
                if (HelpGrid.Text == "txtBSCode")
                {
                    txtBSCode.Text = row["BSCode"].ToString();
                    txtBSDesc.Text = row["BSDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtBSCode.Focus();
                }
                if (HelpGrid.Text == "txtMainLedgerCode")
                {
                    txtMainLedgerCode.Text = row["GrpCode"].ToString();
                    txtMainLedgerDesc.Text = row["GrpDesc"].ToString();
                    txtSubLedgerCode.Text = row["GrpSubCode"].ToString();
                    txtSubLedgerDesc.Text = row["GrpSubDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtBSCode.Focus();
                }
                if (HelpGrid.Text == "txtEmpCode")
                {
                    txtEmpCode.Text = row["EmpCode"].ToString();
                    txtEmpName.Text = row["EmpName"].ToString();
                    HelpGrid.Visible = false;
                    txtChequeName.Focus();
                }
                if (HelpGrid.Text == "txtGSTStateCode")
                {
                    txtGSTStateCode.Text = row["GSTStateCode"].ToString();
                    txtGSTStateDesc.Text = row["GSTStateDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtChequeName.Focus();
                }
                if (HelpGrid.Text == "txtCityCode")
                {
                    txtCityCode.Text = row["CTSYSID"].ToString();
                    txtCityName.Text = row["CTNAME"].ToString();
                    txtState.Text = row["STNAME"].ToString();
                    txtCountry.Text = row["UNDERRG"].ToString();
                    HelpGrid.Visible = false;
                    txtContactPerson.Focus();
                }
                if (HelpGrid.Text == "txtAgentCode")
                {
                    txtAgentCode.Text = row["AgentCode"].ToString();
                    txtAgentName.Text = row["AgentName"].ToString();
                    HelpGrid.Visible = false;
                    txtAgentCode.Focus();
                }
                if (HelpGrid.Text == "txtUnitCode")
                {
                    txtUnitCode.Text = row["UNITID"].ToString();
                    txtUnitName.Text = row["UNITNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtUnitCode.Focus();
                }
                if (HelpGrid.Text == "txtDelCitycode")
                {
                    txtDelCitycode.Text = row["CTSYSID"].ToString();
                    txtDelCityName.Text = row["CTNAME"].ToString();
                    HelpGrid.Visible = false;
                    txtDelGSTNo.Focus();
                }

            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }


        public void HelpGrid_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtEmpCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select EmpCode,EmpName from EmpMst", " Where EmpCode", txtEmpCode, txtEmpName, txtChequeName, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtAcCategory_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtAcCategory.Text.ToUpper() == "A" || (txtAcCategory.Text.ToUpper() == "L") || txtAcCategory.Text.ToUpper() == "S" || (txtAcCategory.Text.ToUpper() == "P") || txtAcCategory.Text.ToUpper() == "E" || (txtAcCategory.Text.ToUpper() == "I"))
            {
                txtAcCategory.Text = txtAcCategory.Text.ToUpper();
            }
            else
            {
                ProjectFunctions.SpeakError("Valid Vales Are A/L/E/P/I/S");
                txtAcCategory.Text = string.Empty;
                txtAcCategory.Focus();
            }
        }

        private void TxtOBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.NumericWithDecimal(e);
        }

        private void TxtEmpCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProjectFunctions.TextOnly(e);
        }

        private void TxtGSTStateCode_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTStateDesc.Text = string.Empty;
        }

        private void TxtGSTStateCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select GSTStateCode,GSTStateDesc from GSTStateMst", " Where GSTStateCode", txtGSTStateCode, txtGSTStateDesc, txtGSTStateCode, HelpGrid, HelpGridView, e);


            }

            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtCityCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForFourBoxes("SELECT CITYMASTER.CTSYSID, CITYMASTER.CTNAME,STATEMASTER.STNAME,STATEMASTER.UNDERRG FROM CITYMASTER INNER JOIN STATEMASTER ON CITYMASTER.UNDERSTID = STATEMASTER.STSYSID", " Where CTSYSID", txtCityCode, txtCityName, txtState, txtCountry, txtContactPerson, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtAgentCode_EditValueChanged(object sender, EventArgs e)
        {
            txtAgentName.Text = string.Empty;
        }

        private void TxtAgentCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select AgentCode,AgentName from AgentMst", " Where AgentCode", txtAgentCode, txtAgentName, txtBSCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtUnitCode_EditValueChanged(object sender, EventArgs e)
        {
            txtUnitName.Text = string.Empty;
        }

        private void TxtUnitCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("select  UNITID,UNITNAME from UNITS", " Where UNITID", txtUnitCode, txtUnitName, txtUnitCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtAcName_EditValueChanged(object sender, EventArgs e)
        {
            txtChequeName.Text = txtAcName.Text;
            txtBillingName.Text = txtAcName.Text;
            txtNameAsOnBankAcc.Text = txtAcName.Text;
        }

        private void TxtDelCitycode_EditValueChanged(object sender, EventArgs e)
        {
            txtDelCityName.Text = string.Empty;
        }

        private void TxtDelCitycode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select CTSYSID,CTNAME from CITYMASTER", " Where CTSYSID", txtDelCitycode, txtDelCityName, txtDelGSTNo, HelpGrid, HelpGridView, e);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (txtDelAccName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Del Account Name ");
                txtDelAccName.Focus();
                return;
            }
            if (txtDelAddress1.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Del Address1 ");
                txtDelAddress1.Focus();
                return;
            }
            if (txtDelCitycode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Del City Name ");
                txtDelCitycode.Focus();
                return;
            }
            if (txtDelCityName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Del City Name");
                txtDelCitycode.Focus();
                return;
            }
            if (BtnOK.Text.ToUpper() == "&OK")
            {
                ProjectFunctions.GetDataSet("Insert into ActDelAddresses(DelAccName,DelZipCode,AccCode,AccAddress1,AccAddress2,AccAddress3,CityCode,AccGSTNo)values('" + txtDelAccName.Text + "','" + txtDelZipCode.Text + "','" + txtAcCode.Text + "','" + txtDelAddress1.Text + "','" + txtDelAddress2.Text + "','" + txtDelAddress3.Text + "','" + txtDelCitycode.Text + "','" + txtDelGSTNo.Text + "')");
                LoadDelAddresses();
            }
            else
            {
                string Query = "update ActDelAddresses Set ";
                Query = Query + " DelAccName='" + txtDelAccName.Text + "',";
                Query = Query + " DelZipCode='" + txtDelZipCode.Text + "',";
                Query = Query + " AccAddress1='" + txtDelAddress1.Text + "',";
                Query = Query + " AccAddress2='" + txtDelAddress2.Text + "',";
                Query = Query + " AccAddress3='" + txtDelAddress3.Text + "',";
                Query = Query + " CityCode='" + txtDelCitycode.Text + "',";
                Query = Query + " AccGSTNo='" + txtDelGSTNo.Text + "' Where TransID='" + TransID + "'";

                ProjectFunctions.GetDataSet(Query);
                LoadDelAddresses();
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ProjectFunctions.GetDataSet("Delete from ActDelAddresses Where TransID='" + TransID + "'");
            LoadDelAddresses();
        }

        private void InfoGrid_DoubleClick(object sender, EventArgs e)
        {
            var MaxRow = ((InfoGrid.FocusedView as GridView).RowCount);
            if (MaxRow == 0)
            {
                ProjectFunctions.SpeakError("Invalid Operation");
            }
            else
            {
                BtnOK.Text = "&Update";
                DataRow currentrow = InfoGridView.GetDataRow(InfoGridView.FocusedRowHandle);
                TransID = currentrow["TransId"].ToString();
                DataSet ds = ProjectFunctions.GetDataSet("sp_LoadDelAddress '" + TransID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtDelAccName.Text = ds.Tables[0].Rows[0]["DelAccName"].ToString();
                    txtDelZipCode.Text = ds.Tables[0].Rows[0]["DelZipCode"].ToString();
                    txtDelAddress1.Text = ds.Tables[0].Rows[0]["AccAddress1"].ToString();
                    txtDelAddress2.Text = ds.Tables[0].Rows[0]["AccAddress2"].ToString();
                    txtDelAddress3.Text = ds.Tables[0].Rows[0]["AccAddress3"].ToString();
                    txtDelCitycode.Text = ds.Tables[0].Rows[0]["CityCode"].ToString();
                    txtDelCityName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                    txtDelGSTNo.Text = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
                    txtDelAddress1.Focus();
                }
            }
        }
        private void Clear()
        {
            BtnOK.Text = "&OK";
            txtDelAddress1.Text = string.Empty;
            txtDelAddress2.Text = string.Empty;
            txtDelAddress3.Text = string.Empty;
            txtDelCitycode.Text = string.Empty;
            txtDelCityName.Text = string.Empty;
            txtDelGSTNo.Text = string.Empty;
            txtDelAccName.Text = string.Empty;
            txtDelZipCode.Text = string.Empty;
            txtDelAddress1.Focus();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private async Task GetGSTINDataAsync()
        {
            EWBSession EwbSession = new EWBSession();
            EwbSession.EwbApiLoginDetails.EwbGstin = GlobalVariables.EWBGSTIN;
            EwbSession.EwbApiLoginDetails.EwbUserID = GlobalVariables.EWBUserID;
            EwbSession.EwbApiLoginDetails.EwbPassword = GlobalVariables.EWBPassword;
            EwbSession.EwbApiSetting.GSPName = GlobalVariables.GSPName;
            EwbSession.EwbApiSetting.AspPassword = GlobalVariables.ASPPassword;
            EwbSession.EwbApiSetting.AspUserId = GlobalVariables.ASPNetUser;
            EwbSession.EwbApiSetting.BaseUrl = GlobalVariables.BaseUrl;


            TxnRespWithObjAndInfo<EWBSession> TxnResp2 = await EWBAPI.GetAuthTokenAsync(EwbSession);
            if (TxnResp2.IsSuccess)
            {
                //TxnRespWithObjAndInfo<RespGetEWBDetail> TxnResp = await EWBAPI.GetEWBDetailAsync(EwbSession, EwbNo);

                TxnRespWithObjAndInfo<GSTINDetail> TxnResp = await EWBAPI.GetGSTNDetailAsync(EwbSession, txtGSTNo.Text);

                if (TxnResp.IsSuccess)



                {
                    TextEdit t = new TextEdit
                    {
                        Text = JsonConvert.SerializeObject(TxnResp.RespObj)
                    };
                    var details = JObject.Parse(t.Text);


                    if (details["status"].ToString().ToUpper() == "ACT")
                    {
                        lblGstInfo.Text = "Status - Active As on Date - " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                    }
                    txtGSTType.Text = details["txpType"].ToString();

                    txtGSTStateCode.Text = details["stateCode"].ToString().PadLeft(2, '0');
                    txtGSTStateDesc.Text = ProjectFunctions.GetDataSet("select GSTStateDesc from GSTStateMst where GSTStateCode='" + details["stateCode"].ToString().PadLeft(2, '0') + "' ").Tables[0].Rows[0][0].ToString();





                    XtraMessageBox.Show(JsonConvert.SerializeObject(TxnResp.RespObj));
                }
                else
                {
                    XtraMessageBox.Show(JsonConvert.SerializeObject(TxnResp.TxnOutcome));
                }
            }
        }
        private void BtnValidate_Click(object sender, EventArgs e)
        {
            GetGSTINDataAsync();
        }

        private void TxtAccCodeBusy_EditValueChanged(object sender, EventArgs e)
        {
            txtAccNameBusy.Text = string.Empty;
        }

        private void TxtAccCodeBusy_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxesFromBusy("SELECT DISTINCT MasterCode1,PRINTNAME FROM TRAN2  INNER JOIN MASTER1 ON TRAN2.MASTERCODE1 = MASTER1.CODE", " Where MasterCode1", txtAccCodeBusy, txtAccNameBusy, txtAccCodeBusy, HelpGrid, HelpGridView, e);
        }

        private void BtnBestMatch_Click(object sender, EventArgs e)
        {
            DataSet ds = ProjectFunctionsUtils.GetDataSetBusy("Select Code as MasterCode1,Name as PrintName from MASTER1  Where Name like '%" + txtAcName.Text + "%'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                HelpGrid.Text = "txtAccCodeBusy";
                HelpGrid.DataSource = ds.Tables[0];
                HelpGrid.BringToFront();
                HelpGrid.Show();
                HelpGrid.Focus();
                HelpGridView.BestFitColumns();
            }


        }

        private void TxtMainLedgerCode_EditValueChanged(object sender, EventArgs e)
        {
            txtMainLedgerDesc.Text = string.Empty;
        }

        private void TxtSubLedgerCode_EditValueChanged(object sender, EventArgs e)
        {
            txtSubLedgerDesc.Text = string.Empty;
        }

        private void TxtSubLedgerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataSet ds = ProjectFunctions.GetDataSet(" select GrpSubDesc,GrpDesc,GrpCode,GrpSubCode  from BSHeadGrpMst Where grpsubcode is not null");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    HelpGrid.Text = "txtMainLedgerCode";
                    HelpGridView.Columns.Clear();
                    HelpGrid.DataSource = ds.Tables[0];
                    HelpGridView.BestFitColumns();
                    HelpGrid.Show();
                    HelpGrid.BringToFront();
                    HelpGrid.Focus();

                }
            }
            e.Handled = true;
        }
    }
}