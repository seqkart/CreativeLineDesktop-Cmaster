using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmNewFormAAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string ProgCode { get; set; }

        String FileType;
        public frmNewFormAAddEdit()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetMyControls()
        {
            try
            {
                //ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.DatePickerVisualize(this);
                //ProjectFunctions.TextBoxVisualize(this);
                ProjectFunctions.ButtonVisualize(this);
                ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void GetAllForminCurrentProject()
        {
            txtFormName.Properties.Items.Clear();
            txtSubFormName.Properties.Items.Clear();
            Type formType = typeof(XtraForm);
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (formType.IsAssignableFrom(t))
                {
                    txtFormName.Properties.Items.Add(t.FullName);
                    txtSubFormName.Properties.Items.Add(t.FullName);
                }
            }
        }
        private void LoadPrinters()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                txtPrinters.Properties.Items.Add(printer);
            }
        }
        private void FrmNewFormAAddEdit_Load(object sender, EventArgs e)
        {
            try
            {
                GetAllForminCurrentProject();
                LoadPrinters();
                SetMyControls();
                if (S1 == "&Add")
                {
                    txtFormCode.Focus();

                }
                if (S1 == "Edit")
                {
                    txtFormCode.Enabled = false;
                    // txtFormName.Enabled = false;
                    txtstatusTag.Focus();
                    DataSet ds = ProjectFunctions.GetDataSet(string.Format(" sp_LoadProgMstFEdit '" + ProgCode + "'"));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtFormCode.Text = ds.Tables[0].Rows[0]["ProgCode"].ToString();
                        txtFormName.Text = ds.Tables[0].Rows[0]["ProgFormLink"].ToString();
                        txtFormDesc.Text = ds.Tables[0].Rows[0]["ProgDesc"].ToString();
                        txtstatusTag.Text = ds.Tables[0].Rows[0]["ProgActive"].ToString();
                        txtNfaTag.Text = ds.Tables[0].Rows[0]["ProgNFA"].ToString();
                        txtMenuName.Text = ds.Tables[0].Rows[0]["ProgInMenu"].ToString();
                        txtSMenuName.Text = ds.Tables[0].Rows[0]["ProgInMenuGroup"].ToString();
                        txtProcName.Text = ds.Tables[0].Rows[0]["ProgProcName"].ToString();
                        txtRoleCode.Text = ds.Tables[0].Rows[0]["RoleCode"].ToString();
                        txtRoleDesc.Text = ds.Tables[0].Rows[0]["RoleDesc"].ToString();
                        txtOrderBy.Text = ds.Tables[0].Rows[0]["OrderBy"].ToString();
                        txtPrinters.SelectedItem = ds.Tables[0].Rows[0]["ProgPrinterName"].ToString();
                        txtRadialTag.Text = ds.Tables[0].Rows[0]["ProgRadialTag"].ToString();
                        txtSubFormName.Text = ds.Tables[0].Rows[0]["ProgSubMainForm"].ToString();




                        if (ds.Tables[0].Rows[0]["ProgSVG1"].ToString().Trim().Length > 0)
                        {
                            Byte[] MyData = new byte[0];
                            MyData = (Byte[])ds.Tables[0].Rows[0]["ProgSVG1"];
                            MemoryStream stream = new MemoryStream(MyData);
                            stream.Position = 0;
                            svgImageBox1.SvgImage = DevExpress.Utils.Svg.SvgImage.FromStream(stream);
                        }

                        if (ds.Tables[0].Rows[0]["ProgSVG2"].ToString().Trim().Length > 0)
                        {
                            Byte[] MyData = new byte[0];
                            MyData = (Byte[])ds.Tables[0].Rows[0]["ProgSVG2"];
                            MemoryStream stream = new MemoryStream(MyData);
                            stream.Position = 0;
                            svgImageBox2.SvgImage = DevExpress.Utils.Svg.SvgImage.FromStream(stream);
                        }

                        if (ds.Tables[0].Rows[0]["ProgSVG3"].ToString().Trim().Length > 0)
                        {
                            Byte[] MyData = new byte[0];
                            MyData = (Byte[])ds.Tables[0].Rows[0]["ProgSVG3"];
                            MemoryStream stream = new MemoryStream(MyData);
                            stream.Position = 0;
                            svgImageBox3.SvgImage = DevExpress.Utils.Svg.SvgImage.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }
        private void TxtMenuName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProjectFunctions.CreatePopUpForOneBox(" Select Distinct ProgInMenu as Description from ProgramMaster", " Where ProgInMenu", txtMenuName, txtSMenuName, HelpGrid, HelpGridView);
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtSMenuName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProjectFunctions.CreatePopUpForOneBox("select Distinct ProgInMenuGroup as Description from ProgramMaster Where ProgInMenu='" + txtMenuName.Text + "'", " And ProgInMenuGroup", txtSMenuName, txtNfaTag, HelpGrid, HelpGridView);
                }
                e.Handled = true;
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
                var row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
                if (HelpGrid.Text == "txtMenuName")
                {
                    txtMenuName.Text = row["Description"].ToString();
                    HelpGrid.Visible = false;
                    txtSMenuName.Focus();
                }
                if (HelpGrid.Text == "txtSMenuName")
                {
                    txtSMenuName.Text = row["Description"].ToString();
                    HelpGrid.Visible = false;
                    txtNfaTag.Focus();
                }
                if (HelpGrid.Text == "txtRoleCode")
                {
                    txtRoleCode.Text = row["RoleCode"].ToString();
                    txtRoleDesc.Text = row["RoleDesc"].ToString();
                    HelpGrid.Visible = false;
                    txtRoleCode.Focus();
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
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGrid_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Escape)
                {
                    HelpGrid.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void TxtMenuName_EditValueChanged(object sender, EventArgs e)
        {
            txtSMenuName.Text = string.Empty;
        }
        private bool ValidateData()
        {
            try
            {
                if (txtFormCode.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Form Code");
                    txtFormCode.Focus();
                    return false;
                }
                if (txtFormDesc.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Form Desc Name");
                    txtFormDesc.Focus();
                    return false;
                }
                if (txtFormName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Form Name");
                    txtFormName.Focus();
                    return false;
                }
                if (txtMenuName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Sub Menu");
                    txtMenuName.Focus();
                    return false;
                }
                if (txtSMenuName.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Sub Menu Name ");
                    txtSMenuName.Focus();
                    return false;
                }
                if (txtstatusTag.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Status Tag");
                    txtstatusTag.Focus();
                    return false;
                }
                if (txtNfaTag.Text.Trim().Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid NFA Tag");
                    txtNfaTag.Focus();
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
            try
            {
                if (S1 == "&Add")
                {
                    DataSet ds = ProjectFunctions.GetDataSet(string.Format("Select ProgCode From ProgramMaster Where ProgCode='" + txtFormCode.Text.Trim() + "'"));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ProjectFunctions.SpeakError("Program Code Already Used For Some Other Form");
                    }
                    else
                    {
                        if (ValidateData())
                        {

                            var str = "Insert Into ProgramMaster(ProgSubMainForm,OrderBy,RoleCode,ProgCode,ProgDesc,ProgFormLink,ProgInMenu,ProgInMenuGroup,ProgActive,ProgNFA,ProgProcName,ProgPrinterName,ProgRadialTag)values(";
                            str = str + "'" + ProjectFunctions.SqlString(txtSubFormName.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtOrderBy.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtRoleCode.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtFormCode.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtFormDesc.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtFormName.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtMenuName.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtSMenuName.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtstatusTag.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtNfaTag.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtProcName.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtPrinters.Text.Trim()) + "',";
                            str = str + "'" + ProjectFunctions.SqlString(txtRadialTag.Text.Trim()) + "')";
                            ProjectFunctions.GetDataSet(str);
                            ProjectFunctions.SpeakError("Entry Added Successfully");
                            CaptureSVG1Screen();
                            CaptureSVG2Screen();
                            CaptureSVG3Screen();
                        }
                    }
                }
                if (S1 == "Edit")
                {
                    if (ValidateData())
                    {
                        var str = " UPDATE    ProgramMaster";
                        str += " SET  ";

                        str = str + "ProgSubMainForm ='" + ProjectFunctions.SqlString(txtSubFormName.Text.Trim()) + "',";
                        str = str + "ProgRadialTag ='" + ProjectFunctions.SqlString(txtRadialTag.Text.Trim()) + "',";
                        str = str + "OrderBy ='" + ProjectFunctions.SqlString(txtOrderBy.Text.Trim()) + "',";
                        str = str + "RoleCode ='" + ProjectFunctions.SqlString(txtRoleCode.Text.Trim()) + "',";
                        str = str + "ProgCode ='" + ProjectFunctions.SqlString(txtFormCode.Text.Trim()) + "',";
                        str = str + "ProgDesc ='" + ProjectFunctions.SqlString(txtFormDesc.Text.Trim()) + "',";
                        str = str + "ProgFormLink ='" + ProjectFunctions.SqlString(txtFormName.Text.Trim()) + "',";
                        str = str + "ProgInMenu ='" + ProjectFunctions.SqlString(txtMenuName.Text.Trim()) + "',";
                        str = str + "ProgInMenuGroup ='" + ProjectFunctions.SqlString(txtSMenuName.Text.Trim()) + "',";
                        str = str + "ProgActive ='" + ProjectFunctions.SqlString(txtstatusTag.Text.Trim()) + "',";
                        str = str + "ProgNFA ='" + ProjectFunctions.SqlString(txtNfaTag.Text.Trim()) + "',";
                        str = str + "ProgProcName ='" + ProjectFunctions.SqlString(txtProcName.Text.Trim()) + "',";
                        str = str + "ProgPrinterName ='" + ProjectFunctions.SqlString(txtPrinters.Text.Trim()) + "'";
                        str = str + " Where ProgCode='" + ProgCode + "'";
                        ProjectFunctions.GetDataSet(str);
                        ProjectFunctions.SpeakError("Entry Updated Successfully");
                        CaptureSVG1Screen();
                        CaptureSVG2Screen();
                        CaptureSVG3Screen();
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void FrmNewFormAAddEdit_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtNfaTag_Validating(object sender, CancelEventArgs e)
        {
            if (txtNfaTag.Text.ToUpper() == "Y" || (txtNfaTag.Text.ToUpper() == "N"))
            {
                txtNfaTag.Text = txtNfaTag.Text.ToUpper();
            }
            else
            {
                ProjectFunctions.SpeakError("Valid Value Are Y/N");
                txtNfaTag.Focus();
            }
        }
        private void CaptureSVG1Screen()
        {
            try
            {
                System.IO.MemoryStream ms = new MemoryStream();
                svgImageBox1.SvgImage.Save(ms);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);
                using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                {
                    sqlcon.Open();
                    String str = "update ProgramMaster Set ProgSVG1= @photo Where ProgCode='" + txtFormCode.Text + "'";

                    var sqlcom = new SqlCommand(str, sqlcon);
                    sqlcom.Parameters.AddWithValue("@photo", photo);
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }



        private void CaptureSVG2Screen()
        {
            try
            {
                System.IO.MemoryStream ms = new MemoryStream();
                svgImageBox2.SvgImage.Save(ms);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);
                using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                {
                    sqlcon.Open();
                    String str = "update ProgramMaster Set ProgSVG2= @photo Where ProgCode='" + txtFormCode.Text + "'";

                    var sqlcom = new SqlCommand(str, sqlcon);
                    sqlcom.Parameters.AddWithValue("@photo", photo);
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }

        private void CaptureSVG3Screen()
        {
            try
            {
                System.IO.MemoryStream ms = new MemoryStream();
                svgImageBox3.SvgImage.Save(ms);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);
                using (var sqlcon = new SqlConnection(ProjectFunctions.ConnectionString))
                {
                    sqlcon.Open();
                    String str = "update ProgramMaster Set ProgSVG3= @photo Where ProgCode='" + txtFormCode.Text + "'";

                    var sqlcom = new SqlCommand(str, sqlcon);
                    sqlcom.Parameters.AddWithValue("@photo", photo);
                    sqlcom.CommandType = CommandType.Text;
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }

        }
        private void TxtstatusTag_Validating(object sender, CancelEventArgs e)
        {
            if (txtstatusTag.Text.ToUpper() == "Y" || (txtstatusTag.Text.ToUpper() == "N"))
            {
                txtstatusTag.Text = txtstatusTag.Text.ToUpper();
            }
            else
            {
                ProjectFunctions.SpeakError("Valid Value Are Y/N");
                txtstatusTag.Focus();
            }
        }

        private void TxtRoleCode_EditValueChanged(object sender, EventArgs e)
        {
            txtRoleDesc.Text = string.Empty;
        }

        private void TxtRoleCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ProjectFunctions.CreatePopUpForTwoBoxes("Select RoleCode,RoleDesc from RoleMst ", " Where RoleCode ", txtRoleCode, txtRoleDesc, txtRoleCode, HelpGrid, HelpGridView, e);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            FileType = "1";

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //if(FileType=="1")
            //{
            //    svgImageBox1.SvgImage = DevExpress.Utils.Svg.SvgImage.FromResources ()


            //       // .FromFile(openFileDialog1.FileName);
            //}
            //if (FileType == "2")
            //{
            //    svgImageBox2.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile(openFileDialog1.FileName);
            //}
            //if (FileType == "3")
            //{
            //    svgImageBox3.SvgImage = DevExpress.Utils.Svg.SvgImage.FromFile(openFileDialog1.FileName);
            //}
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FileType = "2";
            openFileDialog1.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FileType = "3";
            openFileDialog1.ShowDialog();
        }
    }
}