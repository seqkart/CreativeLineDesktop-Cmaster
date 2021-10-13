using Dapper;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using SeqKartLibrary;
using SeqKartLibrary.HelperClass;
using SeqKartLibrary.Models;
using SeqKartLibrary.Repository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class FrmEmployeeMstAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string EmpCode { get; set; }
        public FrmEmployeeMstAddEdit()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.TextBoxVisualize(panelControl1);
            ProjectFunctions.TextBoxVisualize(panelControl2);
            ProjectFunctions.TextBoxVisualize(panelControl3);
            ProjectFunctions.TextBoxVisualize(panelControl4);
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.TimePickerVisualize(panelControl2);

            //ProjectFunctions.ToolstripVisualize(Menu_ToolStrip);

            lblFilename.Text = null;

            txtEmpCode.Enabled = false;
        }

        private bool ValidateData()
        {
            if (txtEmpCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Emp Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpCode.Focus();
                return false;
            }
            if (txtEmpName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Emp Name", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpName.Focus();
                return false;
            }
            if (txtDeptCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Department Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDeptCode.Focus();
                return false;
            }
            if (txtDeptDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Department Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDeptCode.Focus();
                return false;
            }
            if (txtDesgCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesgCode.Focus();
                return false;
            }
            if (txtDesgDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Designation Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtDesgCode.Focus();
                return false;
            }

            if (txtUnitCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Unit Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUnitCode.Focus();
                return false;
            }
            if (txtUnitDesc.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Unit Name", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUnitDesc.Focus();
                return false;
            }

            if (chkDailyWage.Checked)
            {
                if (txtDailyWageRate.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Please Enter Daily Wage Rates");
                    txtDailyWageRate.Focus();
                    return false;
                }
                else
                {
                    if (!ComparisonUtils.IsDecimal(txtDailyWageRate.Text))
                    {
                        ProjectFunctions.SpeakError("Daily Wage Rates Should be Numbers");
                        txtDailyWageRate.Focus();
                        return false;
                    }
                }

                //if (txtDailyWageHours.Text.Trim().Length == 0)
                //{
                //    ProjectFunctions.SpeakError("Please Enter Daily Wager Working Hours");
                //    txtDailyWageHours.Focus();
                //    return false;
                //}
                //else
                //{
                //    if (!ComparisonUtils.IsNumeric(txtDailyWageHours.Text))
                //    {
                //        ProjectFunctions.SpeakError("Daily Wage Working Hours Should be Numbers");
                //        txtDailyWageHours.Focus();
                //        return false;
                //    }
                //}
            }

            if (chkTeaBreak.Checked)
            {
                if (txtTeaBreakTime.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Please Enter Tea Break Time");
                    txtTeaBreakTime.Focus();
                    return false;
                }
                else
                {
                    if (!ComparisonUtils.IsNumeric(txtTeaBreakTime.Text))
                    {
                        ProjectFunctions.SpeakError("Daily Tea Break Time Should be Numbers");
                        txtTeaBreakTime.Focus();
                        return false;
                    }
                }

            }


            if (txtHealthInsurance.Text.Trim().Length == 0)
            {
                txtHealthInsurance.Text = "0";
            }
            if (txtTDS.Text.Trim().Length == 0)
            {
                txtTDS.Text = "0";
            }
            if (txtMiscDed.Text.Trim().Length == 0)
            {
                txtMiscDed.Text = "0";
            }

            return true;
        }


        private bool form_loaded = false;
        private void FrmEmployeeMstAddEdit_Load(object sender, EventArgs e)
        {
            EmployeeFormData_Load();
        }
        //string fileName1 = "";
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //Read image file //JPEG|*.jpg
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName1 = ofd.FileName;
                    lblFilename.Text = Path.GetFileName(fileName1);
                    pictureBox1.Image = Image.FromFile(fileName1);
                }
            }
        }

        //Convert image to binary
        byte[] ConvertImageToBinary(Image img)
        {
            try
            {
                if (img != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return ms.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                PrintLogWin.PrintLog(ex);

            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Properties.Resources.profile_icon.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                PrintLogWin.PrintLog(ex);

            }

            return null;
        }
        //Convert binary to image
        Image ConvertBinaryToImage(byte[] data)
        {
            try
            {
                if (data != null)
                {
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        return Image.FromStream(ms);

                    }
                }

            }
            catch (Exception ex)
            {
                PrintLogWin.PrintLog(ex);
            }
            return null;
        }
        private void EmployeeFormData_Load()
        {

            SetMyControls();
            if (S1 == "&Add")
            {
                chkDailyWage.Checked = true;
                chkDailyWage.Checked = false;

                chkTeaBreak.Checked = true;
                chkTeaBreak.Checked = false;

                txtEmpName.Select();
                txtEmpCode.Text = ProjectFunctionsUtils.GetNewEmpCode();//.PadLeft(5, '0');
                form_loaded = true;
            }
            if (S1 == "Edit")
            {
                RepList<EmployeeMasterModel> lista = new RepList<EmployeeMasterModel>();
                DynamicParameters param = new DynamicParameters();
                param.Add("@EmpCode", EmpCode);

                EmployeeMasterModel empData = lista.returnClass_SP(SQL_QUERIES._frmEmployeeMstAddEdit.sp_LoadEmpMstFEditing(), param);


                //PrintLogWin.PrintLog("**************** =========> Line 120 => listData => " + listData.Count + "");
                if (empData != null)
                {
                    if (empData.EmpTeaTag == "Y")
                    {
                        chTeaTag.Checked = true;
                    }
                    else
                    {
                        chTeaTag.Checked = false;
                    }


                    txtEmpCode.Text = empData.EmpCode;// ds.Tables[0].Rows[0]["EmpCode"].ToString();
                    txtEmpName.Text = empData.EmpName;
                    txtRelationTag.Text = empData.EmpFHRelationTag;//ds.Tables[0].Rows[0]["EmpFHRelationTag"].ToString();
                    txtFHName.Text = empData.EmpFHName;//ds.Tables[0].Rows[0]["EmpFHName"].ToString();
                    txtDeptCode.Text = empData.EmpDeptCode;//ds.Tables[0].Rows[0]["EmpDeptCode"].ToString();
                    txtDeptDesc.Text = empData.DeptDesc;//ds.Tables[0].Rows[0]["DeptDesc"].ToString();
                    txtDesgCode.Text = empData.EmpDesgCode;//ds.Tables[0].Rows[0]["EmpDesgCode"].ToString();
                    txtDesgDesc.Text = empData.DesgDesc;//ds.Tables[0].Rows[0]["DesgDesc"].ToString();

                    txtUnitCode.Text = empData.UnitCode;//ds.Tables[0].Rows[0]["EmpDesgCode"].ToString();
                    txtUnitDesc.Text = empData.UnitName;//ds.Tables[0].Rows[0]["DesgDesc"].ToString();

                    txtEmpSex.Text = empData.EmpSex;//ds.Tables[0].Rows[0]["EmpSex"].ToString();
                    if (empData.EmpDOJ.ToString() == string.Empty)
                    {

                    }
                    else
                    {
                        txtDOJ.EditValue = Convert.ToDateTime(empData.EmpDOJ);
                    }
                    if (empData.EmpDOL.ToString() == string.Empty)
                    {

                    }
                    else
                    {
                        txtDOL.EditValue = Convert.ToDateTime(empData.EmpDOL);
                    }

                    txtEPFTag.Text = empData.EmpPFDTag;//ds.Tables[0].Rows[0]["EmpPFDTag"].ToString();
                    txtESIDTag.Text = empData.EmpESIDTag;//ds.Tables[0].Rows[0]["EmpESIDTag"].ToString();
                    txtEPFNo.Text = empData.EmpPFno;//ds.Tables[0].Rows[0]["EmpPFno"].ToString();
                    txtESICNo.Text = empData.EmpESIno;//ds.Tables[0].Rows[0]["EmpESIno"].ToString();

                    txtTDS.Text = empData.EmpTDS.ToString();//ds.Tables[0].Rows[0]["EmpTDS"].ToString();
                    txtEmpLeft.Text = empData.EmpLeft;//ds.Tables[0].Rows[0]["EmpLeft"].ToString();
                    txtRemarks.Text = empData.EmpRemarks;//ds.Tables[0].Rows[0]["EmpRemarks"].ToString();
                    txtMotherName.Text = empData.EmpMotherNm;//ds.Tables[0].Rows[0]["EmpMotherNm"].ToString();

                    txtState.Text = empData.EmpPerState;//ds.Tables[0].Rows[0]["EmpPerState"].ToString();
                    txtState.Text = empData.EmpPerCountry;//ds.Tables[0].Rows[0]["EmpPerCountry"].ToString();

                    txtNationality.Text = empData.EmpNationality;//ds.Tables[0].Rows[0]["EmpNationality"].ToString();
                    txtEmail.Text = empData.EmpEmail;//ds.Tables[0].Rows[0]["EmpEmail"].ToString();
                    txtCategoryCode.Text = empData.EmpCategory;//ds.Tables[0].Rows[0]["EmpCategory"].ToString();

                    txtCategoryDesc.Text = empData.CatgDesc;//ds.Tables[0].Rows[0]["CatgDesc"].ToString();

                    txtDOB.EditValue = Convert.ToDateTime(empData.EmpDoB);
                    txtPanNo.Text = empData.EmpPanNo;//ds.Tables[0].Rows[0]["EmpPanNo"].ToString();
                    txtPassPortNo.Text = empData.EmpPassportNo;//ds.Tables[0].Rows[0]["EmpPassportNo"].ToString();


                    txtEmployeeReligion.Text = empData.EmpReligion;//ds.Tables[0].Rows[0]["EmpReligion"].ToString();
                    txtMaritalStatus.Text = empData.EmpMaritalStatus;//ds.Tables[0].Rows[0]["EmpMaritalStatus"].ToString();
                    txtPaymentMode.Text = empData.EmpPymtMode;//ds.Tables[0].Rows[0]["EmpPymtMode"].ToString();
                    txtIfscCode.Text = empData.EmpBankIFSCode;//ds.Tables[0].Rows[0]["EmpBankIFSCode"].ToString();
                    txtBankAccountNo.Text = empData.EmpBankAcNo;//ds.Tables[0].Rows[0]["EmpBankAcNo"].ToString();
                    txtBankName.Text = empData.EmpBankName;//ds.Tables[0].Rows[0]["EmpBankName"].ToString();
                    txtNomineeName.Text = empData.EmpNominee;//ds.Tables[0].Rows[0]["EmpNominee"].ToString();
                    txtNomineeRelation.Text = empData.EmpNomineeRelation;//ds.Tables[0].Rows[0]["EmpNomineeRelation"].ToString();
                    if (empData.EmpNomineeDOB.ToString() == string.Empty)
                    {

                    }
                    else
                    {
                        txtNomineeDOB.EditValue = Convert.ToDateTime(empData.EmpNomineeDOB);
                    }



                    txtAdharCardNo.Text = empData.EmpAdharCardNo;//ds.Tables[0].Rows[0]["EmpAdharCardNo"].ToString();

                    txtHealthInsurance.Text = empData.EmpGHISDed.ToString();//ds.Tables[0].Rows[0]["EmpGHISDed"].ToString();

                    txtMiscDed.Text = empData.EmpMscD1.ToString();//ds.Tables[0].Rows[0]["EmpMscD1"].ToString();

                    txtAddress1.Text = empData.EmpAddress1;//ds.Tables[0].Rows[0]["EmpAddress1"].ToString();
                    txtAddress2.Text = empData.EmpAddress2;//ds.Tables[0].Rows[0]["EmpAddress2"].ToString();
                    txtAddress3.Text = empData.EmpAddress3;//ds.Tables[0].Rows[0]["EmpAddress3"].ToString();

                    txtState.Text = empData.EmpState;//ds.Tables[0].Rows[0]["EmpState"].ToString();
                    txtCountry.Text = empData.EmpCountry;//ds.Tables[0].Rows[0]["EmpCountry"].ToString();

                    txtEFPFTag.Text = empData.EmpFpfDTag;//ds.Tables[0].Rows[0]["EmpFpfDTag"].ToString();

                    //NULL Exception
                    //txtUANNo.Text = ds.Tables[0].Rows[0]["EmpUANNo"].ToString();
                    //txtUnitCode.Text = ds.Tables[0].Rows[0]["UnitCode"].ToString();
                    //txtUnitName.Text = ds.Tables[0].Rows[0]["UnitName"].ToString();
                    //txtAccCode.Text = ds.Tables[0].Rows[0]["EmpPartyCode"].ToString();
                    //txtBankBranchCode.Text = ds.Tables[0].Rows[0]["EmpBankBranchCode"].ToString();
                    txtCategoryCode.Focus();

                    timeEdit_Time_In_First.EditValue = empData.TimeInFirst.ToString();
                    timeEdit_Time_Out_First.EditValue = empData.TimeOutFirst.ToString();
                    timeEdit_Time_In_Last.EditValue = empData.TimeInLast.ToString();
                    timeEdit_Time_Out_Last.EditValue = empData.TimeOutLast.ToString();
                    totalWorkingHours_Text.EditValue = empData.WorkingHours;
                    pictureBox1.Image = ConvertBinaryToImage(empData.EmpImage);

                    chkTeaBreak.Checked = (empData.TeaBreak == 1) ? true : false;
                    txtTeaBreakTime.EditValue = empData.TeaBreakTime;
                    PrintLogWin.PrintLog("chkTeaBreak.Checked =========> " + chkTeaBreak.Checked + string.Empty);
                    PrintLogWin.PrintLog("empData.TeaBreak =========> " + empData.TeaBreak + string.Empty);

                    chkDailyWage.Checked = empData.DailyWage;
                    PrintLogWin.PrintLog("chkDailyWage.Checked =========> " + chkDailyWage.Checked + string.Empty);
                    PrintLogWin.PrintLog("empData.DailyWage =========> " + empData.DailyWage + string.Empty);

                    //DAILY WAGER//////////////////////////////
                    if (chkDailyWage.Checked)
                    {
                        if (empData.DailyWageRate != null && empData.DailyWageRate != 0)
                        {
                            txtDailyWageRate.EditValue = empData.DailyWageRate;
                            txtDailyWageRate.Tag = empData.DailyWageRate;
                        }
                        else
                        {
                            txtDailyWageRate.EditValue = null;
                        }

                        if (empData.DailyWageMinutes != null && empData.DailyWageMinutes != 0)
                        {
                            txtDailyWageHours.EditValue = empData.DailyWageMinutes / 60;
                            txtDailyWageHours.Tag = empData.DailyWageMinutes / 60;
                        }
                        else
                        {
                            txtDailyWageHours.EditValue = null;
                        }
                    }
                    else
                    {
                        txtDailyWageRate.Enabled = false;
                        txtDailyWageRate.EditValue = null;

                        txtDailyWageHours.Enabled = false;
                        txtDailyWageHours.EditValue = null;
                    }

                    //TEA BREAK//////////////////////////////
                    if (chkTeaBreak.Checked)
                    {
                        if (empData.TeaBreakTime != null && empData.TeaBreakTime != 0)
                        {
                            txtTeaBreakTime.EditValue = empData.TeaBreakTime;
                            txtTeaBreakTime.Tag = empData.TeaBreakTime;
                        }
                        else
                        {
                            txtTeaBreakTime.EditValue = null;
                        }
                    }
                    else
                    {
                        txtTeaBreakTime.Enabled = false;
                        txtTeaBreakTime.EditValue = null;

                    }
                }

                form_loaded = true;

                txtEmpName.Enabled = false;
                PrintLogWin.PrintLog("frmEmployeeMstAddEdit_Load =========> Line 131 => sp_LoadEmpMstFEditing '" + EmpCode + "'");


            }
        }

        private void FrmEmployeeMstAddEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
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
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

            if (HelpGrid.Text == "txtCategoryCode")
            {
                txtCategoryCode.Text = row["CatgCode"].ToString();
                txtCategoryDesc.Text = row["CatgDesc"].ToString();
                HelpGrid.Visible = false;
                txtDeptCode.Focus();
            }
            if (HelpGrid.Text == "txtDeptCode")
            {
                txtDeptCode.Text = row["DeptCode"].ToString();
                txtDeptDesc.Text = row["DeptDesc"].ToString();
                HelpGrid.Visible = false;
                txtDesgCode.Focus();
            }
            if (HelpGrid.Text == "txtDesgCode")
            {
                txtDesgCode.Text = row["DesgCode"].ToString();
                txtDesgDesc.Text = row["DesgDesc"].ToString();
                HelpGrid.Visible = false;
                txtUnitCode.Focus();
            }


            if (HelpGrid.Text == "txtUnitCode")
            {
                txtUnitCode.Text = row["UnitCode"].ToString();
                txtUnitDesc.Text = row["UnitName"].ToString();
                HelpGrid.Visible = false;
                txtDOJ.Focus();
            }

        }

        private void TxtDeptCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDeptDesc.Text = string.Empty;
        }

        private void TxtDesgCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDesgDesc.Text = string.Empty;
        }

        private void TxtUnitCode_EditValueChanged(object sender, EventArgs e)
        {
            txtUnitDesc.Text = string.Empty;
        }

        private void TxtDeptCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select DeptCode,DeptDesc from DeptMst", " Where DeptCode", txtDeptCode, txtDeptDesc, txtDesgDesc, HelpGrid, HelpGridView, e);
        }

        private void TxtDesgCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select DesgCode,DesgDesc from DesgMst", " Where DesgCode", txtDesgCode, txtDesgDesc, txtUnitCode, HelpGrid, HelpGridView, e);
        }

        private void TxtUnitCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select UnitCode, UnitName from UNITS", " Where UnitCode", txtUnitCode, txtUnitDesc, txtRemarks, HelpGrid, HelpGridView, e);
        }

        private void SaveEmployeeData()
        {
            string sql = string.Empty;
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
                            string empCode_SQL = "(SELECT RIGHT('0000' + CAST((ISNULL(MAX(CAST(EmpCode AS INT)), 0) + 1) AS VARCHAR(4)), 4) FROM EmpMst)";// SQL_QUERIES._frmEmployeeMstAddEdit._GetNewEmpCode(hasRtnCol:false);

                            sql = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                 + " Insert into EmpMst"
                                                 + " (EmpCode,EmpName,EmpFHRelationTag,EmpFHName, UnitCode, EmpDeptCode,EmpDesgCode,EmpCategory,"
                                                 + " EmpSex,EmpDOJ,EmpDOL,EmpPFDTag,"
                                                 + " EmpESIDTag,EmpPFno,EmpESIno,EmpBasic,EmpHRA,EmpConv,"
                                                 + " EmpPET,EmpTDS,EmpLeft,EmpRemarks,EmpMotherNm,"
                                                 + " EmpNationality,EmpEmail,EmpDoB,EmpPanNo,"
                                                 + " EmpPassportNo                           ,"
                                                 + " EmpSplAlw,EmpReligion,EmpMaritalStatus,EmpPymtMode,EmpBankIFSCode,"
                                                 + " EmpBankAcNo,EmpBankName,EmpNominee,EmpNomineeRelation,EmpNomineeDOB,EmpAdharCardNo,EmpGHISDed,EmpFPFDTag,EmpMscD1,EmpAddress1,EmpAddress2,EmpAddress3,EmpDistCity,EmpState,EmpCountry,EmpUANNo,EmpBankBranchCode," +
string.Empty +
                                                 "   TimeInFirst, TimeOutFirst, TimeInLast, TimeOutLast, WorkingHours, EmpImage, DailyWage, DailyWageRate, DailyWageMinutes, TeaBreak, TeaBreakTime,EmpTeaTag)"
                                                 + " values(" + empCode_SQL + ",@EmpName,@EmpFHRelationTag,@EmpFHName, @UnitCode, @EmpDeptCode,@EmpDesgCode,@EmpCategory,"
                                                 + " @EmpSex,@EmpDOJ,@EmpDOL,@EmpPFDTag,"
                                                 + " @EmpESIDTag,@EmpPFno,@EmpESIno,@EmpBasic,@EmpHRA,@EmpConv,"
                                                 + " @EmpPET,@EmpTDS,@EmpLeft,@EmpRemarks,@EmpMotherNm,"
                                                 + " @EmpNationality,@EmpEmail,@EmpDoB,@EmpPanNo,"
                                                 + " @EmpPassportNo,"
                                                 + " @EmpSplAlw,@EmpReligion,@EmpMaritalStatus,@EmpPymtMode,@EmpBankIFSCode,"
                                                 + " @EmpBankAcNo,@EmpBankName,@EmpNominee,@EmpNomineeRelation,@EmpNomineeDOB,@EmpAdharCardNo,@EmpGHISDed,@EmpFPFDTag,@EmpMscD1,@EmpAddress1,@EmpAddress2,@EmpAddress3,@EmpDistCity,@EmpState,@EmpCountry,@EmpUANNo,@EmpBankBranchCode," +
                                                    "@TimeInFirst, @TimeOutFirst, @TimeInLast, @TimeOutLast, @WorkingHours, @EmpImage, @DailyWage, @DailyWageRate, @DailyWageMinutes, @TeaBreak, @TeaBreakTime,@EmpTeaTag)"
                                                 + " Commit ";
                            sqlcom.CommandText = sql;

                            PrintLogWin.PrintLog(sql);
                        }
                        if (S1 == "Edit")
                        {
                            sql = " UPDATE EmpMst SET "
                                                + " EmpFHRelationTag=@EmpFHRelationTag,EmpFHName=@EmpFHName, UnitCode=@UnitCode, EmpDeptCode=@EmpDeptCode,EmpDesgCode=@EmpDesgCode,EmpCategory=@EmpCategory, "
                                                + " EmpSex=@EmpSex,EmpDOJ=@EmpDOJ,EmpDOL=@EmpDOL,EmpPFDTag=@EmpPFDTag, "
                                                + " EmpESIDTag=@EmpESIDTag,EmpPFno=@EmpPFno,EmpESIno=@EmpESIno,EmpBasic=@EmpBasic,EmpHRA=@EmpHRA,EmpConv=@EmpConv, "
                                                + " EmpPET=@EmpPET,EmpTDS=@EmpTDS,EmpLeft=@EmpLeft,EmpRemarks=@EmpRemarks,EmpMotherNm=@EmpMotherNm,EmpNationality=@EmpNationality, "
                                                + " EmpEmail=@EmpEmail,EmpDoB=@EmpDoB,EmpPanNo=@EmpPanNo,EmpPassportNo=@EmpPassportNo,EmpSplAlw=@EmpSplAlw,"
                                                + " EmpReligion=@EmpReligion,EmpMaritalStatus=@EmpMaritalStatus,EmpPymtMode=@EmpPymtMode,EmpBankIFSCode=@EmpBankIFSCode, "
                                                + " EmpBankAcNo=@EmpBankAcNo,EmpBankName=@EmpBankName,EmpNominee=@EmpNominee,EmpNomineeRelation=@EmpNomineeRelation,EmpNomineeDOB=@EmpNomineeDOB, "
                                                + " EmpAdharCardNo=@EmpAdharCardNo,EmpGHISDed=@EmpGHISDed,EmpFPFDTag=@EmpFPFDTag,EmpMscD1=@EmpMscD1,EmpAddress1=@EmpAddress1,EmpAddress2=@EmpAddress2,EmpAddress3=@EmpAddress3,EmpDistCity=@EmpDistCity,EmpState=@EmpState,EmpCountry=@EmpCountry ,EmpUANNo=@EmpUANNo,EmpBankBranchCode=@EmpBankBranchCode, " +
                                                "   TimeInFirst = @TimeInFirst," +
                                                "   TimeOutFirst = @TimeOutFirst," +
                                                "   TimeInLast = @TimeInLast," +
                                                "   TimeOutLast = @TimeOutLast," +
                                                "   WorkingHours = @WorkingHours, " +
                                                "   EmpImage = @EmpImage," +
                                                "   DailyWage = @DailyWage," +
                                                "   DailyWageRate = @DailyWageRate," +
                                                "   DailyWageMinutes = @DailyWageMinutes," +
                                                "   TeaBreak = @TeaBreak," +
                                                "   TeaBreakTime = @TeaBreakTime,EmpTeaTag=@EmpTeaTag" +
                                                "   Where EmpCode=@EmpCode";

                            sqlcom.CommandText = sql;

                            PrintLogWin.PrintLog(sql);
                        }

                        sqlcom.Parameters.AddWithValue("@EmpCode", txtEmpCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpFHRelationTag", txtRelationTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpFHName", txtFHName.Text.Trim());

                        sqlcom.Parameters.AddWithValue("@UnitCode", txtUnitCode.Text.Trim());

                        sqlcom.Parameters.AddWithValue("@EmpDeptCode", txtDeptCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpDesgCode", txtDesgCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpCategory", txtCategoryCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpSex", txtEmpSex.Text.Trim());

                        if (txtDOJ.Text.Length == 0)
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDOJ", System.Data.SqlTypes.SqlDateTime.Null);
                        }
                        else
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDOJ", ConvertTo.DateTimeVal(txtDOJ.Text));
                        }
                        if (txtDOL.Text.Length == 0)
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDOL", System.Data.SqlTypes.SqlDateTime.Null);
                        }
                        else
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDOL", ConvertTo.DateTimeVal(txtDOL.Text));
                        }
                        sqlcom.Parameters.AddWithValue("@EmpPFDTag", txtEPFTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpESIDTag", txtESIDTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpPFno", txtEPFNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpESIno", txtESICNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpBasic", 0);
                        sqlcom.Parameters.AddWithValue("@EmpHRA", 0);
                        sqlcom.Parameters.AddWithValue("@EmpConv", 0);
                        sqlcom.Parameters.AddWithValue("@EmpPET", 0);
                        sqlcom.Parameters.AddWithValue("@EmpTDS", ConvertTo.DecimalVal(txtTDS.Text));
                        sqlcom.Parameters.AddWithValue("@EmpLeft", txtEmpLeft.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpRemarks", txtRemarks.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpMotherNm", txtMotherName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpNationality", txtNationality.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpEmail", txtEmail.Text.Trim());
                        if (txtDOB.Text.Length == 0)
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDoB", ConvertTo.DateTimeVal(txtDOB.Text));
                        }
                        else
                        {
                            sqlcom.Parameters.AddWithValue("@EmpDoB", ConvertTo.DateTimeVal(txtDOB.Text));
                        }
                        sqlcom.Parameters.AddWithValue("@EmpPanNo", txtPanNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpPassportNo", txtPassPortNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpSplAlw", 0);
                        sqlcom.Parameters.AddWithValue("@EmpReligion", txtEmployeeReligion.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpMaritalStatus", txtMaritalStatus.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpPymtMode", txtPaymentMode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpBankIFSCode", txtIfscCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpBankAcNo", txtBankAccountNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpBankName", txtBankName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpNominee", txtNomineeName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpNomineeRelation", txtNomineeRelation.Text.Trim());
                        if (txtNomineeDOB.Text.Length == 0)
                        {
                            sqlcom.Parameters.AddWithValue("@EmpNomineeDOB", System.Data.SqlTypes.SqlDateTime.Null);
                        }
                        else
                        {
                            sqlcom.Parameters.AddWithValue("@EmpNomineeDOB", ConvertTo.DateTimeVal(txtNomineeDOB.Text));
                        }
                        sqlcom.Parameters.AddWithValue("@EmpAdharCardNo", txtAdharCardNo.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpGHISDed", ConvertTo.DecimalVal(txtHealthInsurance.Text));
                        sqlcom.Parameters.AddWithValue("@EmpFPFDTag", txtEFPFTag.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpMscD1", ConvertTo.DecimalVal(txtMiscDed.Text));
                        sqlcom.Parameters.AddWithValue("@EmpAddress1", txtAddress1.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpAddress2", txtAddress2.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpAddress3", txtAddress3.Text.Trim());

                        sqlcom.Parameters.AddWithValue("@EmpDistCity", string.Empty);

                        sqlcom.Parameters.AddWithValue("@EmpState", txtState.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpCountry", txtCountry.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@EmpUANNo", txtUANNo.Text.Trim());

                        sqlcom.Parameters.AddWithValue("@EmpBankBranchCode", txtBankBranchCode.Text.Trim());

                        sqlcom.Parameters.AddWithValue("@TimeInFirst", ConvertTo.DateTimeVal(timeEdit_Time_In_First.Text.ToString().Trim()));
                        sqlcom.Parameters.AddWithValue("@TimeOutFirst", ConvertTo.DateTimeVal(timeEdit_Time_Out_First.Text.ToString().Trim()));
                        sqlcom.Parameters.AddWithValue("@TimeInLast", ConvertTo.DateTimeVal(timeEdit_Time_In_Last.Text.ToString().Trim()));
                        sqlcom.Parameters.AddWithValue("@TimeOutLast", ConvertTo.DateTimeVal(timeEdit_Time_Out_Last.Text.ToString().Trim()));
                        sqlcom.Parameters.AddWithValue("@WorkingHours", ConvertTo.IntVal(totalWorkingHours_Text.Text.ToString().Trim()));





                        if (ComparisonUtilsWin.PictureBox_IsNullOrEmpty(pictureBox1))
                        {
                            byte[] byteEmpty = ConvertImageToBinary(WindowsFormsApplication1.Properties.Resources.profile_icon);
                            sqlcom.Parameters.AddWithValue("@EmpImage", byteEmpty);
                            PrintLogWin.PrintLog("================== 1");
                        }
                        else
                        {
                            sqlcom.Parameters.AddWithValue("@EmpImage", ConvertImageToBinary(pictureBox1.Image));
                            PrintLogWin.PrintLog("================== 2");
                        }

                        sqlcom.Parameters.AddWithValue("@DailyWage", chkDailyWage.Checked);
                        sqlcom.Parameters.AddWithValue("@DailyWageRate", (txtDailyWageRate.Text.Length == 0) ? 0 : txtDailyWageRate.EditValue);
                        sqlcom.Parameters.AddWithValue("@DailyWageMinutes", (txtDailyWageMinutes.Text.Length == 0) ? 0 : txtDailyWageMinutes.EditValue);

                        sqlcom.Parameters.AddWithValue("@TeaBreak", (chkTeaBreak.Checked) ? 1 : 0);
                        sqlcom.Parameters.AddWithValue("@TeaBreakTime", (txtTeaBreakTime.EditValue == null) ? 0 : txtTeaBreakTime.EditValue);
                        sqlcom.Parameters.AddWithValue("@EmpTeaTag", chTeaTag.Checked ? "Y" : "N");

                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        //XtraMessageBox.Show("Data Saved Successfully");
                        ProjectFunctions.SpeakError("Data Saved Successfully");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        PrintLogWin.PrintLog(sql);


                        PrintLogWin.PrintLog("Line 663 : " + ex);
                        XtraMessageBox.Show("Something Wrong. \n I am going to Roll Back." + ex.Message, ex.GetType().ToString());
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            XtraMessageBox.Show("Something Wrong. \n Roll Back Failed." + ex2.Message, ex2.GetType().ToString());
                        }
                    }
                }
            }
        }

        private void TxtCategory_EditValueChanged(object sender, EventArgs e)
        {
            txtCategoryDesc.Text = string.Empty;
        }

        private void TxtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select CatgCode,CatgDesc from CatgMst", " Where CatgCode", txtCategoryCode, txtCategoryDesc, txtDOJ, HelpGrid, HelpGridView, e);
        }

        private void TxtEmpLeft_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEmpLeft.Text == "Y" || txtEmpLeft.Text == "N")
            {
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Valid Values are Y,N", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEmpLeft.Focus();
            }
        }

        private void TxtEPFTag_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEPFTag.Text == "Y" || txtEPFTag.Text == "N")
            {
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Valid Values are Y,N", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtEPFTag.Focus();
            }
        }

        private void TxtESIDTag_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtESIDTag.Text == "Y" || txtESIDTag.Text == "N")
            {
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Valid Values are Y,N", "Save", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtESIDTag.Focus();
            }
        }

        private void WindowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();

            switch (tag)
            {
                case "save":
                    /* Navigate to page A */
                    SaveEmployeeData();
                    break;
                case "save_close":
                    /* Navigate to page B */

                    break;
                case "save_new":
                    /* Navigate to page C*/

                    break;
                case "reset":
                    /* Navigate to page D */
                    if (XtraMessageBox.Show("Do you want to reset the form?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        form_loaded = false;
                        EmployeeFormData_Load();

                    }
                    break;
                case "add_new":
                    /* Navigate to page C*/



                    break;
                case "close":
                    /* Navigate to page E */
                    Close();

                    break;
            }
        }

        private void TimeEdit_Time_In_First_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDUtyHours();
        }

        private void TimeEdit_Time_Out_First_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDUtyHours();

        }
        private void TimeEdit_Time_In_Last_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDUtyHours();
        }

        private void TimeEdit_Time_Out_Last_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDUtyHours();
        }

        private void CalculateDUtyHours()
        {
            //DateTime.ParseExact(Eval("aeStart").ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture).ToShortTimeString()
            //int shift_id = 1;

            PrintLogWin.PrintLog("************* CalculateDUtyHours => CalculateDUtyHours");

            try
            {

                PrintLogWin.PrintLog("************* form_loaded => " + form_loaded + string.Empty);

                PrintLogWin.PrintLog("************* timeEdit_Time_In_First.EditValue => " + timeEdit_Time_In_First.EditValue + string.Empty);
                PrintLogWin.PrintLog("************* timeEdit_Time_Out_First.EditValue => " + timeEdit_Time_Out_First.EditValue + string.Empty);
                PrintLogWin.PrintLog("************* timeEdit_Time_In_Last.EditValue => " + timeEdit_Time_In_Last.EditValue + string.Empty);
                PrintLogWin.PrintLog("************* timeEdit_Time_Out_Last.EditValue => " + timeEdit_Time_Out_Last.EditValue + string.Empty);


                if (!form_loaded)
                {

                }
                else
                {
                    double totalHrs_First = 0;
                    double totalHrs_Last = 0;

                    if (timeEdit_Time_In_First.EditValue != null && timeEdit_Time_Out_First.EditValue != null)
                    {
                        DateTime dateTime_In_2 = ConvertTo.TimeToDate(timeEdit_Time_In_First.Text + string.Empty);
                        DateTime dateTime_Out_2 = ConvertTo.TimeToDate(timeEdit_Time_Out_First.Text + string.Empty);

                        if (dateTime_Out_2 < dateTime_In_2)
                        {
                            if (S1 == "Edit")
                            {
                                ProjectFunctions.SpeakError("Time Out First cannot be less than Time In First in Day Shift");
                                timeEdit_Time_Out_First.EditValue = null;
                            }
                        }
                        else
                        {
                            totalHrs_First = (dateTime_Out_2 - dateTime_In_2).TotalHours;
                            if (totalHrs_First < 0)
                            {
                                totalHrs_First = totalHrs_First * -1;
                            }
                        }
                    }

                    if (timeEdit_Time_In_Last.EditValue != null && timeEdit_Time_Out_Last.EditValue != null)
                    {
                        DateTime dateTime_In_Last = ConvertTo.TimeToDate(timeEdit_Time_In_Last.Text + string.Empty);
                        DateTime dateTime_Out_Last = ConvertTo.TimeToDate(timeEdit_Time_Out_Last.Text + string.Empty);
                        if (timeEdit_Time_Out_First.EditValue != null)
                        {
                            DateTime dateTime_Out_1 = ConvertTo.TimeToDate(timeEdit_Time_Out_First.Text + string.Empty);

                            if (dateTime_In_Last < dateTime_Out_1)
                            {
                                if (S1 == "Edit")
                                {
                                    ProjectFunctions.SpeakError("Time In Last cannot be less than Time Out First in Day Shift");
                                    timeEdit_Time_In_Last.EditValue = null;
                                }
                            }
                            else
                            {
                                if (dateTime_Out_Last < dateTime_In_Last)
                                {
                                    if (S1 == "Edit")
                                    {
                                        ProjectFunctions.SpeakError("Time Out Last cannot be less than Time In Last in Day Shift");
                                        timeEdit_Time_Out_Last.EditValue = null;
                                    }
                                }
                                else
                                {
                                    totalHrs_Last = (dateTime_Out_Last - dateTime_In_Last).TotalHours;
                                    if (totalHrs_Last < 0)
                                    {
                                        totalHrs_Last = totalHrs_Last * -1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (dateTime_Out_Last < dateTime_In_Last)
                            {
                                if (S1 == "Edit")
                                {
                                    ProjectFunctions.SpeakError("Time Out Last cannot be less than Time In Last in Day Shift");
                                    timeEdit_Time_Out_Last.EditValue = null;
                                }
                            }
                            else
                            {
                                totalHrs_Last = (dateTime_Out_Last - dateTime_In_Last).TotalHours;
                                if (totalHrs_Last < 0)
                                {
                                    totalHrs_Last = totalHrs_Last * -1;
                                }
                            }
                        }

                    }

                    double totalHrs_FullDay = totalHrs_First + totalHrs_Last;

                    totalWorkingHours_Text.Text = (totalHrs_FullDay).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(timeEdit_Time_In_First.EditValue + "\n\n" + ex + string.Empty);
            }

        }

        private void ChkDailyWage_CheckedChanged(object sender, EventArgs e)
        {

            if (S1 == "&Add")
            {
                if (chkDailyWage.Checked)
                {
                    txtDailyWageRate.Enabled = true;
                    txtDailyWageHours.Enabled = true;

                    //RelationShipGrid123.TabPages[1].PageVisible = false;
                }
                else
                {
                    txtDailyWageRate.Enabled = false;
                    txtDailyWageHours.Enabled = false;

                    //RelationShipGrid123.TabPages[1].PageVisible = true;
                }
            }
            if (S1 == "Edit")
            {
                if (chkDailyWage.Checked)
                {
                    txtDailyWageRate.Enabled = true;

                    if (txtDailyWageRate.Tag != null)
                    {
                        txtDailyWageRate.EditValue = txtDailyWageRate.Tag;
                    }
                    else
                    {
                        txtDailyWageRate.EditValue = null;
                    }

                    txtDailyWageHours.Enabled = true;

                    if (txtDailyWageHours.Tag != null)
                    {
                        txtDailyWageHours.EditValue = txtDailyWageHours.Tag;
                    }
                    else
                    {
                        txtDailyWageHours.EditValue = null;
                    }

                    //RelationShipGrid123.TabPages[1].PageVisible = false;

                }
                else
                {
                    txtDailyWageRate.Enabled = false;
                    txtDailyWageRate.EditValue = null;

                    txtDailyWageHours.Enabled = false;
                    txtDailyWageHours.EditValue = null;

                    // RelationShipGrid123.TabPages[1].PageVisible = true;

                }
            }
        }

        private void TxtDailyWageHours_EditValueChanged(object sender, EventArgs e)
        {
            txtDailyWageMinutes.EditValue = ConvertTo.IntVal(txtDailyWageHours.EditValue) * 60;
        }

        private void ChkTeaBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (S1 == "&Add")
            {
                if (chkTeaBreak.Checked)
                {
                    txtTeaBreakTime.Enabled = true;
                }
                else
                {
                    txtTeaBreakTime.Enabled = false;
                }
            }
            if (S1 == "Edit")
            {
                if (chkTeaBreak.Checked)
                {
                    txtTeaBreakTime.Enabled = true;

                    if (txtTeaBreakTime.Tag != null)
                    {
                        txtTeaBreakTime.EditValue = txtTeaBreakTime.Tag;
                    }
                    else
                    {
                        txtTeaBreakTime.EditValue = null;
                    }

                }
                else
                {
                    txtTeaBreakTime.Enabled = false;
                    txtTeaBreakTime.EditValue = null;
                }
            }
        }

       
    }
}
