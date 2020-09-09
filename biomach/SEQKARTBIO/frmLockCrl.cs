﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEQKARTBIO
{
    public partial class frmLockCtrl : Form
    {
        public frmLockCtrl()
        {
            InitializeComponent();
        }

        AxSBXPCLib.AxSBXPC bpc;

        private void cmdGetDoorStatus_Click(object sender, EventArgs e)
        {
            int vValue = 0;
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.GetDoorStatus(Program.gMachineNumber, ref vValue);
            if (vRet)
            {
                if (vValue == 1)
                    lblMessage.Text = "Uncond Door Open State!";
                else if (vValue == 2)
                    lblMessage.Text = "Uncond Door Close State!";
                else if (vValue == 3)
                    lblMessage.Text = "Door Open State!";
                else if (vValue == 4)
                    lblMessage.Text = "Auto Recover State!";
                else if (vValue == 5)
                    lblMessage.Text = "Door Close State!";
                else if (vValue == 6)
                    lblMessage.Text = "Watching for Close!";
                else if (vValue == 7)
                    lblMessage.Text = "Illegal open!";
                else
                    lblMessage.Text = "User State !";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdDoorOpen_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 3);
            if (vRet)
            {
                lblMessage.Text = "Door Open Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdAutoRecover_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 4);
            if (vRet)
            {
                lblMessage.Text = "Auto Recover Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 5);
            if (vRet)
            {
                lblMessage.Text = "Reboot Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdUncondOpen_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 1);
            if (vRet)
            {
                lblMessage.Text = "Uncond Door Open Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdUncondClose_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 2);
            if (vRet)
            {
                lblMessage.Text = "Uncond Door Close Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void cmdWarnCancel_Click(object sender, EventArgs e)
        {
            int vErrorCode = 0;
            Boolean vRet;

            lblMessage.Text = "Working...";
            Application.DoEvents();

            vRet = bpc.EnableDevice(Program.gMachineNumber, 0); // 0 : false
            if (!vRet)
            {
                lblMessage.Text = util.gstrNoDevice;
                return;
            }

            vRet = bpc.SetDoorStatus(Program.gMachineNumber, 6);
            if (vRet)
            {
                lblMessage.Text = "Warning cancel Success!";
            }
            else
            {
                bpc.GetLastError(ref vErrorCode);
                lblMessage.Text = util.ErrorPrint(vErrorCode);
            }

            bpc.EnableDevice(Program.gMachineNumber, 1); // 1 : true
            Application.DoEvents();
        }

        private void frmLockCrl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmMain"].Visible = true;
        }

        private void frmLockCrl_Load(object sender, EventArgs e)
        {
            bpc = (AxSBXPCLib.AxSBXPC)Application.OpenForms["frmMain"].Controls["SBXPC1"];
        }
    }
}
