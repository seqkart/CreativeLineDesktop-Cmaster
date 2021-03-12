using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmProcessWiseRateFeeding : DevExpress.XtraEditors.XtraForm
    {
        public frmProcessWiseRateFeeding()
        {
            InitializeComponent();
        }

        private void chContratcor_CheckedChanged(object sender, EventArgs e)
        {
            if(chContratcor.Checked)
            {
             
                txtWorkerCode.Visible = false;
                txtWorkerName.Visible = false;
                lblWorker.Visible = false;

                chWorker.Checked = false;

                txtContractorCode.Visible = true;
                txtContractorDesc.Visible = true;
                lblContrator.Visible = true;
                InforGrid.DataSource = null;
            }
        }

        private void chWorker_CheckedChanged(object sender, EventArgs e)
        {
            if (chWorker.Checked)
            {
                
                txtWorkerCode.Visible = true;
                txtWorkerName.Visible = true;
                lblWorker.Visible = true;

                chContratcor.Checked = false;


                txtContractorCode.Visible = false;
                txtContractorDesc.Visible = false;
                lblContrator.Visible = false;

                InforGrid.DataSource = null;
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            if (HelpGrid.Text == "txtContractorCode")
            {
                txtContractorCode.Text = row["CNTSYSID"].ToString();
                txtContractorDesc.Text = row["CNTNAME"].ToString();
                HelpGrid.Visible = false;
                txtContractorCode.Focus();
                GetData();
            }
            if (HelpGrid.Text == "txtWorkerCode")
            {
                txtWorkerCode.Text = row["WRKSYSID"].ToString();
                txtWorkerName.Text = row["WRKNAME"].ToString();
                HelpGrid.Visible = false;
                txtWorkerName.Focus();
                GetData();
            }
        }


        private void GetData()
        {
            DataSet ds = new DataSet();
            if (chContratcor.Checked)
            {
                ds = ProjectFunctions.GetDataSet("sp_LoadProcessRateContractor '" + txtContractorCode.Text + "'");

            }
            else
            {
                ds = ProjectFunctions.GetDataSet("sp_LoadProcessRateWorker '" + txtWorkerCode.Text + "'");

            }
            if(ds.Tables[0].Rows.Count>0)
            {
                InforGrid.DataSource = ds.Tables[0];
                InforGridView.BestFitColumns();
            }
            else
            {
                InforGrid.DataSource = null;
                InforGridView.BestFitColumns();
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

        private void txtContractorCode_EditValueChanged(object sender, EventArgs e)
        {
            txtContractorDesc.Text = String.Empty;
        }

        private void txtContractorCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select CNTSYSID,CNTNAME from CONTRACTOR", " Where CNTSYSID", txtContractorCode, txtContractorDesc, txtContractorCode, HelpGrid, HelpGridView, e);
        
        }

        private void txtWorkerCode_EditValueChanged(object sender, EventArgs e)
        {
            txtWorkerName.Text = String.Empty;
        }

        private void txtWorkerCode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select WRKSYSID,WRKNAME from WORKER", " Where WRKSYSID", txtWorkerCode, txtWorkerName, txtWorkerCode, HelpGrid, HelpGridView, e);
          
        }

        private void frmProcessWiseRateFeeding_Load(object sender, EventArgs e)
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            //chContratcor.Checked = true;
            //lblWorker.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(chContratcor.Checked)
            {
                ProjectFunctions.GetDataTable("Delete from ProcessRateMaster Where ContractorCode='" + txtContractorCode.Text + "'");
                foreach(DataRow dr in (InforGrid.DataSource as DataTable).Rows)
                {
                    if(Convert.ToDecimal(dr["ProcessRate"])>0)
                    {
                        ProjectFunctions.GetDataTable("Insert into ProcessRateMaster(ContractorCode,SubProcessCode,ProcessRate)values('" + txtContractorCode.Text + "','" + dr["SubProcessCode"].ToString() + "','" + Convert.ToDecimal(dr["ProcessRate"]) + "')");
                    }
                }
                InforGrid.DataSource = null;
            }
            if (chWorker.Checked)
            {
                ProjectFunctions.GetDataTable("Delete from ProcessRateMaster Where WorkerCode='" + txtWorkerCode.Text + "'");
                foreach (DataRow dr in (InforGrid.DataSource as DataTable).Rows)
                {
                    if (Convert.ToDecimal(dr["ProcessRate"]) > 0)
                    {
                        ProjectFunctions.GetDataTable("Insert into ProcessRateMaster(WorkerCode,SubProcessCode,ProcessRate)values('" + txtWorkerCode.Text + "','" + dr["SubProcessCode"].ToString() + "','" + Convert.ToDecimal(dr["ProcessRate"]) + "')");
                    }
                }
                InforGrid.DataSource = null;
            }
            
        }

        private void lblContrator_Click(object sender, EventArgs e)
        {

        }
    }
}