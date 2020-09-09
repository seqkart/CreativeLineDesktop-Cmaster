﻿namespace SEQKARTBIO
{
    partial class frmTMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDoorMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTMode = new System.Windows.Forms.ListBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.lblEnrollData = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDoorMode
            // 
            this.cmbDoorMode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbDoorMode.FormattingEnabled = true;
            this.cmbDoorMode.Items.AddRange(new object[] {
            "Any",
            "FP&CD",
            "FP&PWD",
            "CD&PWD",
            "FP&CD&PWD"});
            this.cmbDoorMode.Location = new System.Drawing.Point(226, 92);
            this.cmbDoorMode.Name = "cmbDoorMode";
            this.cmbDoorMode.Size = new System.Drawing.Size(226, 27);
            this.cmbDoorMode.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(221, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Door Mode:";
            // 
            // lstTMode
            // 
            this.lstTMode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lstTMode.FormattingEnabled = true;
            this.lstTMode.ItemHeight = 19;
            this.lstTMode.Location = new System.Drawing.Point(24, 130);
            this.lstTMode.Name = "lstTMode";
            this.lstTMode.Size = new System.Drawing.Size(501, 384);
            this.lstTMode.TabIndex = 102;
            this.lstTMode.SelectedIndexChanged += new System.EventHandler(this.lstTMode_SelectedIndexChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dtEnd.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEnd.Location = new System.Drawing.Point(75, 91);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(119, 26);
            this.dtEnd.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 91);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 100;
            this.label1.Text = "End:";
            // 
            // dtStart
            // 
            this.dtStart.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dtStart.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStart.Location = new System.Drawing.Point(75, 62);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(119, 26);
            this.dtStart.TabIndex = 99;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdExit.Location = new System.Drawing.Point(548, 469);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdExit.Size = new System.Drawing.Size(104, 46);
            this.cmdExit.TabIndex = 98;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdWrite
            // 
            this.cmdWrite.BackColor = System.Drawing.SystemColors.Control;
            this.cmdWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdWrite.Location = new System.Drawing.Point(548, 405);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdWrite.Size = new System.Drawing.Size(104, 46);
            this.cmdWrite.TabIndex = 97;
            this.cmdWrite.Text = "Write";
            this.cmdWrite.UseVisualStyleBackColor = false;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // cmdRead
            // 
            this.cmdRead.BackColor = System.Drawing.SystemColors.Control;
            this.cmdRead.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdRead.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdRead.Location = new System.Drawing.Point(548, 340);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdRead.Size = new System.Drawing.Size(104, 46);
            this.cmdRead.TabIndex = 96;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = false;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUpdate.Location = new System.Drawing.Point(548, 131);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUpdate.Size = new System.Drawing.Size(104, 46);
            this.cmdUpdate.TabIndex = 95;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = false;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // lblEnrollData
            // 
            this.lblEnrollData.AutoSize = true;
            this.lblEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollData.Location = new System.Drawing.Point(20, 62);
            this.lblEnrollData.Name = "lblEnrollData";
            this.lblEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollData.Size = new System.Drawing.Size(41, 19);
            this.lblEnrollData.TabIndex = 94;
            this.lblEnrollData.Text = "Start:";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(20, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(632, 28);
            this.lblMessage.TabIndex = 93;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmTMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 526);
            this.Controls.Add(this.cmbDoorMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTMode);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.lblEnrollData);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmTMode";
            this.Text = "frmTMode";
            this.Load += new System.EventHandler(this.frmTMode_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTMode_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoorMode;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTMode;
        private System.Windows.Forms.DateTimePicker dtEnd;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtStart;
        public System.Windows.Forms.Button cmdExit;
        public System.Windows.Forms.Button cmdWrite;
        public System.Windows.Forms.Button cmdRead;
        public System.Windows.Forms.Button cmdUpdate;
        public System.Windows.Forms.Label lblEnrollData;
        public System.Windows.Forms.Label lblMessage;
    }
}