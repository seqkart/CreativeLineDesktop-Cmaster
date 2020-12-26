using DevExpress.XtraEditors;
using System;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmAttendenceReading : DevExpress.XtraEditors.XtraForm
    {

        public frmAttendenceReading()
        {
            InitializeComponent();
        }


        private void ConnectMachine()
        {
            try
            {




                //if (SBXPC1.ConnectTcpip(1, ref lpszIPAddress, 5005, 12345))
                //{
                //    ProjectFunctions.SpeakError("Connected To Attendence MAchine");
                //}
                //else
                //{
                //    ProjectFunctions.SpeakError("Unable Connected To Attendence MAchine");
                //}
                //int gMachineNumber = SBXPC1.ConnectP2p(ref lpszDevId, ref lpszIPAddress, Convert.ToInt32("5005"), Convert.ToInt32(12345), ref nError);
                //if (gMachineNumber != 0)
                //{
                //    ProjectFunctions.SpeakError("Connected To Attendence MAchine");
                //}
                //else
                //{
                //    ProjectFunctions.SpeakError("Unable Connected To Attendence MAchine");
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void frmAttendenceReading_Load(object sender, EventArgs e)
        {

        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            ConnectMachine();
        }
    }
}