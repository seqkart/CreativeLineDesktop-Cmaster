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
        }


        private void LoadActMst()
        {
            DataSet dsLoaActMst = ProjectFunctions.GetDataSet("select AccCode,AccName from ActMst");
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
