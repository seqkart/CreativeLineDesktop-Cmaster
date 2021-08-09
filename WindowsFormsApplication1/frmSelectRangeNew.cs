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

namespace WindowsFormsApplication1
{
    public partial class frmSelectRangeNew : DevExpress.XtraEditors.XtraUserControl
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public frmSelectRangeNew()
        {
            InitializeComponent();
        }
        private void ValidateDates()
        {
            if (Convert.ToDateTime(DtFrom.EditValue) < Convert.ToDateTime(GlobalVariables.FinYearStartDate) || Convert.ToDateTime(DtFrom.EditValue) > Convert.ToDateTime(GlobalVariables.FinYearEndDate))
            {
                ProjectFunctions.SpeakError("From Date Is Out Of The Financial Year");
                DtFrom.Focus();
            }
            if (Convert.ToDateTime(DtEnd.EditValue) < Convert.ToDateTime(GlobalVariables.FinYearStartDate) || Convert.ToDateTime(DtEnd.EditValue) > Convert.ToDateTime(GlobalVariables.FinYearEndDate))
            {
                ProjectFunctions.SpeakError("End Date Is Out Of The Financial Year");
                DtFrom.Focus();
            }
        }
        private void frmSelectRangeNew_Load(object sender, EventArgs e)
        {
            ProjectFunctions.DatePickerVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
            DtFrom.EditValue = StartDate;
            DtEnd.EditValue = EndDate;
            ValidateDates();
            LoadActMst();
            LoadArticleGroupMst();
            LoadLedgerMst();
        }


        private void LoadActMst()
        {
            DataSet dsLoaActMst = ProjectFunctions.GetDataSet("select AccCode,AccName from ActMst Order By AccName");
            if (dsLoaActMst.Tables[0].Rows.Count > 0)
            {
                txtParty.Properties.Items.Clear();

                foreach (DataRow dr in dsLoaActMst.Tables[0].Rows)
                {
                    DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    {
                        Description = dr["AccName"].ToString(),
                        Value = dr["AccCode"].ToString(),
                        CheckState = CheckState.Unchecked
                    };
                    txtParty.Properties.Items.Add(item);
                }
            }
        }

        private void LoadArticleGroupMst()
        {
            DataSet dsLoaArticleMst = ProjectFunctions.GetDataSet("select Distinct GrpCode,GrpDesc from GrpMst");
            if (dsLoaArticleMst.Tables[0].Rows.Count > 0)
            {
                txtGroups.Properties.Items.Clear();

                foreach (DataRow dr in dsLoaArticleMst.Tables[0].Rows)
                {
                    DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    {
                        Description = dr["GrpDesc"].ToString(),
                        Value = dr["GrpCode"].ToString(),
                        CheckState = CheckState.Unchecked
                    };
                    txtGroups.Properties.Items.Add(item);
                }
            }
        }



        private void LoadLedgerMst()
        {
            DataSet dsLedgerMst = ProjectFunctions.GetDataSet("Select LgrCode,LgrDesc from LgrMst");
            if (dsLedgerMst.Tables[0].Rows.Count > 0)
            {
                txtLedger.Properties.Items.Clear();
                foreach (DataRow dr in dsLedgerMst.Tables[0].Rows)
                {
                    DevExpress.XtraEditors.Controls.CheckedListBoxItem item = new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    {
                        Description = dr["LgrDesc"].ToString(),
                        Value = dr["LgrCode"].ToString(),
                        CheckState = CheckState.Unchecked
                    };
                    txtLedger.Properties.Items.Add(item);
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void chArticle_CheckedChanged(object sender, EventArgs e)
        {
            if (chArticle.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtGroups.Properties.Items)
                {
                    item.CheckState = CheckState.Checked;
                }
            }
            if (!chArticle.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtGroups.Properties.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void chParty_CheckedChanged(object sender, EventArgs e)
        {
            if (chParty.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtParty.Properties.Items)
                {
                    item.CheckState = CheckState.Checked;
                }
            }

            if (!chParty.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtParty.Properties.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }

        }

        private void chLedger_CheckedChanged(object sender, EventArgs e)
        {
            if (chLedger.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtLedger.Properties.Items)
                {
                    item.CheckState = CheckState.Checked;
                }
            }
            if (!chArticle.Checked)
            {
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in txtLedger.Properties.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }
    }
}
