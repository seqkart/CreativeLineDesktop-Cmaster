﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace SEQKARTBIO
{
    public partial class frmBellInfo : Form
    {
        public frmBellInfo()
        {
            InitializeComponent();
        }

        AxSBXPCLib.AxSBXPC bpc;

        int mBellCount;
        const int MAX_BELLCOUNT_DAY = 12;
        const int dataLen = MAX_BELLCOUNT_DAY * 3;
        CheckBox[] chkValid;
        TextBox[] txtHour;
        TextBox[] txtMinute;
        Byte[] dbBellInfoList;

        private void BellInfoInit()
        {
            txtHour = new TextBox[MAX_BELLCOUNT_DAY];
            txtMinute = new TextBox[MAX_BELLCOUNT_DAY];
            chkValid = new CheckBox[MAX_BELLCOUNT_DAY];
            dbBellInfoList = new Byte[dataLen];

            txtHour[0] = _txtHour_0;
            txtHour[1] = _txtHour_1;
            txtHour[2] = _txtHour_2;
            txtHour[3] = _txtHour_3;
            txtHour[4] = _txtHour_4;
            txtHour[5] = _txtHour_5;
            txtHour[6] = _txtHour_6;
            txtHour[7] = _txtHour_7;
            txtHour[8] = _txtHour_8;
            txtHour[9] = _txtHour_9;
            txtHour[10] = _txtHour_10;
            txtHour[11] = _txtHour_11;

            txtMinute[0] = _txtMinute_0;
            txtMinute[1] = _txtMinute_1;
            txtMinute[2] = _txtMinute_2;
            txtMinute[3] = _txtMinute_3;
            txtMinute[4] = _txtMinute_4;
            txtMinute[5] = _txtMinute_5;
            txtMinute[6] = _txtMinute_6;
            txtMinute[7] = _txtMinute_7;
            txtMinute[8] = _txtMinute_8;
            txtMinute[9] = _txtMinute_9;
            txtMinute[10] = _txtMinute_10;
            txtMinute[11] = _txtMinute_11;

            chkValid[0] = _chkValid_0;
            chkValid[1] = _chkValid_1;
            chkValid[2] = _chkValid_2;
            chkValid[3] = _chkValid_3;
            chkValid[4] = _chkValid_4;
            chkValid[5] = _chkValid_5;
            chkValid[6] = _chkValid_6;
            chkValid[7] = _chkValid_7;
            chkValid[8] = _chkValid_8;
            chkValid[9] = _chkValid_9;
            chkValid[10] = _chkValid_10;
            chkValid[11] = _chkValid_11;
        }

        private void ShowValue()
        {
            int i;

            for (i = 0; i < MAX_BELLCOUNT_DAY; i++)
            {
                if (dbBellInfoList[i] > 1)
                    dbBellInfoList[i] = 0;
                chkValid[i].Checked = dbBellInfoList[i] == 1;
                txtHour[i].Text = Convert.ToString(dbBellInfoList[i + MAX_BELLCOUNT_DAY]);
                txtMinute[i].Text = Convert.ToString(dbBellInfoList[i + MAX_BELLCOUNT_DAY * 2]);
            }
            txtBellCount.Text = Convert.ToString(mBellCount);
        }

        private Boolean GetValue()
        {
            int i;

            for (i = 0; i < MAX_BELLCOUNT_DAY; i++)
            {
                dbBellInfoList[i] = chkValid[i].Checked ? (byte)1 : (byte)0;
                if (Convert.ToInt32(txtHour[i].Text == "" ? "0" : txtHour[i].Text) < 0 ||
                    Convert.ToInt32(txtHour[i].Text == "" ? "0" : txtHour[i].Text) > 23)
                {
                    return false;
                }
                dbBellInfoList[i + MAX_BELLCOUNT_DAY] = Convert.ToByte(txtHour[i].Text == "" ? "0" : txtHour[i].Text);

                if (Convert.ToInt32(txtMinute[i].Text == "" ? "0" : txtMinute[i].Text) < 0 ||
                    Convert.ToInt32(txtMinute[i].Text == "" ? "0" : txtMinute[i].Text) > 59)
                {
                    return false;
                }
                dbBellInfoList[i + MAX_BELLCOUNT_DAY * 2] = Convert.ToByte(txtMinute[i].Text == "" ? "0" : txtMinute[i].Text);

            }
            mBellCount = Convert.ToInt32(txtBellCount.Text == "" ? "0" : txtBellCount.Text);

            return true;
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            Boolean vRet = true;
            int vErrorCode = 0;

            lblMessage.Text = "Waiting...";
            Application.DoEvents();

            if (!bpc.EnableDevice(Program.gMachineNumber, 0)) // 0 : false
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            GCHandle gh = GCHandle.Alloc(dbBellInfoList, GCHandleType.Pinned);
            IntPtr AddrOfmlngBellInfo = gh.AddrOfPinnedObject();
            int nAddr = AddrOfmlngBellInfo.ToInt32();

            vRet = bpc.GetBellTime(Program.gMachineNumber, ref mBellCount, ref nAddr);

            if (vRet)
            {
                ShowValue();
                lblMessage.Text = "Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            gh.Free();
            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            Boolean vRet;
            int vErrorCode = 0;

            lblMessage.Text = "Waiting...";
            Application.DoEvents();

            if (!bpc.EnableDevice(Program.gMachineNumber, 0)) // 0 : false
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            if (!GetValue())
            {
                util.MessageBox(new IntPtr(0), "Invalid Value.", "Bell info", 1);
            }
            else
            {
                GCHandle gh = GCHandle.Alloc(dbBellInfoList, GCHandleType.Pinned);
                IntPtr AddrOfmlngBellInfo = gh.AddrOfPinnedObject();
                int nAddr = AddrOfmlngBellInfo.ToInt32();

                vRet = bpc.SetBellTime(Program.gMachineNumber, mBellCount, ref nAddr);
                gh.Free();

                if (vRet)
                {
                    ShowValue();
                    lblMessage.Text = "Success!";
                }
                else
                {
                    bpc.GetLastError(ref vErrorCode);
                    lblMessage.Text = util.ErrorPrint(vErrorCode);
                }
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
        }

        private void frmBellInfo_Load(object sender, EventArgs e)
        {
            BellInfoInit();
            bpc = (AxSBXPCLib.AxSBXPC)Application.OpenForms["frmMain"].Controls["SBXPC1"];
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["frmMain"].Visible = true;
        }

    }
}
