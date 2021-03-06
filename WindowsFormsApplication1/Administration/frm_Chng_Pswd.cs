﻿using DevExpress.XtraEditors;
using SeqKartLibrary;
using System;
namespace WindowsFormsApplication1
{
    public partial class Frm_Chng_Pswd : XtraUserControl
    {
        public Frm_Chng_Pswd()
        {
            InitializeComponent();
        }
        //private  projectFunctionsUtils;
        private void Btn_Chnge_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOldPass.Text) || string.IsNullOrWhiteSpace(txtOldPass.Text))
                {
                    ProjectFunctions.SpeakError("Please Enter Old Password.");
                    txtNewPass.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    ProjectFunctions.SpeakError("Please Enter New Password.");
                    txtNewPass.Focus();
                    return;
                }

                if ((txtNewPass.Text != txtConfirmPass.Text))
                {
                    ProjectFunctions.SpeakError("Password doesn't Match.");
                    txtOldPass.Focus();
                    return;
                }

                var validUserPass = ProjectFunctionsUtils.GetDataSet_T(SQL_QUERIES._frm_Chng_Pswd.SQL_UserMaster(GlobalVariables.CurrentUser, txtConfirmPass.Text));

                if (validUserPass.Item1)
                {
                    int intResult = ProjectFunctionsUtils.InsertQuery(SQL_QUERIES._frm_Chng_Pswd.SQL_UserMaster_Update_Pass(GlobalVariables.CurrentUser, txtConfirmPass.Text));//String.Format("Update UserMaster Set UserPwd='{0}' where username='{1}'", txtConfirmPass.Text, GlobalVariables.CurrentUser)

                    GlobalVariables.UserPwd = txtConfirmPass.Text;
                    ProjectFunctions.SpeakError("Password Changed.");
                }
                else
                {
                    ProjectFunctions.SpeakError("Old Password is Not Valid.");
                    txtOldPass.Focus();
                    return;
                }

                Dispose();
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void Frm_Chng_Pswd_Load(object sender, EventArgs e)
        {
            //projectFunctionsUtils = new ProjectFunctionsUtils();

            try
            {
                txtOldPass.Focus();
                ProjectFunctions.TextBoxVisualize(groupControl1);
                ProjectFunctions.ButtonVisualize(groupControl1);
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}