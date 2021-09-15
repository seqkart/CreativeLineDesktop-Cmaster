﻿using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmMachineBrandMst : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string BrandCode { get; set; }
        public FrmMachineBrandMst()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);

            txtBrandName.Properties.MaxLength = 100;

            txtBrandCode.Enabled = false;
        }

        private string GetNewBrandCode()
        {

            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(BrandCode as int)),0000) from MachineBrandMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;

        }
        private bool ValidateData()
        {
            if (txtBrandCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Brand Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtBrandCode.Focus();
                return false;
            }
            if (txtBrandName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Brand Description", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtBrandName.Focus();
                return false;
            }

            return true;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMachineBrandMst_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtBrandName.Focus();
                txtBrandCode.Text = GetNewBrandCode().PadLeft(4, '0');
            }
            if (S1 == "Edit")
            {
                //txtCatgDesc.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet("SELECT BrandCode,BrandDesc FROM MachineBrandMst Where BrandCode='" + BrandCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtBrandCode.Text = ds.Tables[0].Rows[0]["BrandCode"].ToString();
                    txtBrandName.Text = ds.Tables[0].Rows[0]["BrandDesc"].ToString();
                    txtBrandName.Focus();
                }
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
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into MachineBrandMst"
                                                    + " (BrandCode,BrandDesc)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(BrandCode as int)),0)+1 AS VARCHAR(4)),4)from MachineBrandMst),@BrandDesc)"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE MachineBrandMst SET "
                                                + " BrandDesc=@BrandDesc"
                                                + " Where BrandCode=@BrandCode";

                        }
                        sqlcom.Parameters.AddWithValue("@BrandCode", txtBrandCode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@BrandDesc", txtBrandName.Text.Trim());
                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Data Saved Successfully");



                        Close();
                    }
                    catch (Exception ex)
                    {
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
    }
}