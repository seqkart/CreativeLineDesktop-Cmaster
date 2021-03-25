namespace TaxProEinvoiceApiIntigrationDemo.NET
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGspName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAspUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAspPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTokenExp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSek = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGstin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rtbResponce = new System.Windows.Forms.RichTextBox();
            this.txtResponceHdr = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAuthToken = new System.Windows.Forms.Button();
            this.btnGenIRN = new System.Windows.Forms.Button();
            this.btnCancelIRN = new System.Windows.Forms.Button();
            this.btnGSTINDet = new System.Windows.Forms.Button();
            this.btnGetEDetailsbyIRN = new System.Windows.Forms.Button();
            this.btnApiSetting = new System.Windows.Forms.Button();
            this.btnSaveLoginDetails = new System.Windows.Forms.Button();
            this.btnGetEDetailbyAck = new System.Windows.Forms.Button();
            this.btnDecGenIRN = new System.Windows.Forms.Button();
            this.btnDecryptedAuthToken = new System.Windows.Forms.Button();
            this.btnDecCancelIRN = new System.Windows.Forms.Button();
            this.btnGetEinvDetailByDec = new System.Windows.Forms.Button();
            this.btnGenEWB = new System.Windows.Forms.Button();
            this.txtEwbBaseUrl = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnDecGenEwbByIRN = new System.Windows.Forms.Button();
            this.txtCancelEWB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCancelEwayBill = new System.Windows.Forms.Button();
            this.btnCancelEwbByDec = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSandBoxSetting = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnVerifySignedInv = new System.Windows.Forms.Button();
            this.btnGetEWBByIRN = new System.Windows.Forms.Button();
            this.btnGetSyncGSTINDetails = new System.Windows.Forms.Button();
            this.btnGetIRNDetailsByDocDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Id";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(117, 45);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(202, 22);
            this.txtClientId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "EInvoice API Setting";
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(117, 73);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.ReadOnly = true;
            this.txtClientSecret.Size = new System.Drawing.Size(202, 22);
            this.txtClientSecret.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Secret";
            // 
            // txtGspName
            // 
            this.txtGspName.Location = new System.Drawing.Point(117, 101);
            this.txtGspName.Name = "txtGspName";
            this.txtGspName.ReadOnly = true;
            this.txtGspName.Size = new System.Drawing.Size(202, 22);
            this.txtGspName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gsp Name";
            // 
            // txtAspUserId
            // 
            this.txtAspUserId.Location = new System.Drawing.Point(117, 129);
            this.txtAspUserId.Name = "txtAspUserId";
            this.txtAspUserId.Size = new System.Drawing.Size(202, 22);
            this.txtAspUserId.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Asp User Id";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(117, 212);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.ReadOnly = true;
            this.txtBaseUrl.Size = new System.Drawing.Size(202, 22);
            this.txtBaseUrl.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Base Url";
            // 
            // txtAuthUrl
            // 
            this.txtAuthUrl.Location = new System.Drawing.Point(117, 184);
            this.txtAuthUrl.Name = "txtAuthUrl";
            this.txtAuthUrl.ReadOnly = true;
            this.txtAuthUrl.Size = new System.Drawing.Size(202, 22);
            this.txtAuthUrl.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Auth Url";
            // 
            // txtAspPassword
            // 
            this.txtAspPassword.Location = new System.Drawing.Point(117, 156);
            this.txtAspPassword.Name = "txtAspPassword";
            this.txtAspPassword.Size = new System.Drawing.Size(202, 22);
            this.txtAspPassword.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Asp Password";
            // 
            // txtTokenExp
            // 
            this.txtTokenExp.Location = new System.Drawing.Point(117, 547);
            this.txtTokenExp.Name = "txtTokenExp";
            this.txtTokenExp.ReadOnly = true;
            this.txtTokenExp.Size = new System.Drawing.Size(202, 22);
            this.txtTokenExp.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Token Exp";
            // 
            // txtSek
            // 
            this.txtSek.Location = new System.Drawing.Point(117, 519);
            this.txtSek.Name = "txtSek";
            this.txtSek.ReadOnly = true;
            this.txtSek.Size = new System.Drawing.Size(202, 22);
            this.txtSek.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sek";
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Location = new System.Drawing.Point(117, 491);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.ReadOnly = true;
            this.txtAuthToken.Size = new System.Drawing.Size(202, 22);
            this.txtAuthToken.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "AuthToken";
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(117, 464);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.ReadOnly = true;
            this.txtAppKey.Size = new System.Drawing.Size(202, 22);
            this.txtAppKey.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "App Key";
            // 
            // txtGstin
            // 
            this.txtGstin.Location = new System.Drawing.Point(117, 436);
            this.txtGstin.Name = "txtGstin";
            this.txtGstin.Size = new System.Drawing.Size(202, 22);
            this.txtGstin.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 436);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "GSTIN";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 408);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(202, 22);
            this.txtPassword.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "EInvoice API Login Details";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 380);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 22);
            this.txtUserName.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "User Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(408, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 17);
            this.label17.TabIndex = 30;
            this.label17.Text = "EInvoice API List";
            // 
            // rtbResponce
            // 
            this.rtbResponce.Location = new System.Drawing.Point(611, 102);
            this.rtbResponce.Name = "rtbResponce";
            this.rtbResponce.Size = new System.Drawing.Size(613, 420);
            this.rtbResponce.TabIndex = 36;
            this.rtbResponce.Text = "";
            // 
            // txtResponceHdr
            // 
            this.txtResponceHdr.Location = new System.Drawing.Point(611, 35);
            this.txtResponceHdr.Name = "txtResponceHdr";
            this.txtResponceHdr.Size = new System.Drawing.Size(613, 22);
            this.txtResponceHdr.TabIndex = 37;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(796, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(232, 17);
            this.label23.TabIndex = 38;
            this.label23.Text = "EInvoice API Responce in Json";
            // 
            // btnAuthToken
            // 
            this.btnAuthToken.Location = new System.Drawing.Point(352, 45);
            this.btnAuthToken.Name = "btnAuthToken";
            this.btnAuthToken.Size = new System.Drawing.Size(244, 30);
            this.btnAuthToken.TabIndex = 39;
            this.btnAuthToken.Text = "Get Auth Token";
            this.btnAuthToken.UseVisualStyleBackColor = true;
            this.btnAuthToken.Click += new System.EventHandler(this.btnAuthToken_Click);
            // 
            // btnGenIRN
            // 
            this.btnGenIRN.Location = new System.Drawing.Point(443, 81);
            this.btnGenIRN.Name = "btnGenIRN";
            this.btnGenIRN.Size = new System.Drawing.Size(153, 30);
            this.btnGenIRN.TabIndex = 40;
            this.btnGenIRN.Text = "Generate IRN";
            this.btnGenIRN.UseVisualStyleBackColor = true;
            this.btnGenIRN.Click += new System.EventHandler(this.btnGenIRN_Click);
            // 
            // btnCancelIRN
            // 
            this.btnCancelIRN.Location = new System.Drawing.Point(352, 152);
            this.btnCancelIRN.Name = "btnCancelIRN";
            this.btnCancelIRN.Size = new System.Drawing.Size(244, 30);
            this.btnCancelIRN.TabIndex = 41;
            this.btnCancelIRN.Text = "Cancel IRN";
            this.btnCancelIRN.UseVisualStyleBackColor = true;
            this.btnCancelIRN.Click += new System.EventHandler(this.btnCancelIRN_Click);
            // 
            // btnGSTINDet
            // 
            this.btnGSTINDet.Location = new System.Drawing.Point(352, 294);
            this.btnGSTINDet.Name = "btnGSTINDet";
            this.btnGSTINDet.Size = new System.Drawing.Size(244, 30);
            this.btnGSTINDet.TabIndex = 43;
            this.btnGSTINDet.Text = "Get GSTIN Details";
            this.btnGSTINDet.UseVisualStyleBackColor = true;
            this.btnGSTINDet.Click += new System.EventHandler(this.btnGSTINDet_Click);
            // 
            // btnGetEDetailsbyIRN
            // 
            this.btnGetEDetailsbyIRN.Location = new System.Drawing.Point(352, 187);
            this.btnGetEDetailsbyIRN.Name = "btnGetEDetailsbyIRN";
            this.btnGetEDetailsbyIRN.Size = new System.Drawing.Size(244, 30);
            this.btnGetEDetailsbyIRN.TabIndex = 42;
            this.btnGetEDetailsbyIRN.Text = "Get E-Invoice Details by IRN";
            this.btnGetEDetailsbyIRN.UseVisualStyleBackColor = true;
            this.btnGetEDetailsbyIRN.Click += new System.EventHandler(this.btnGetEDetails_Click);
            // 
            // btnApiSetting
            // 
            this.btnApiSetting.Location = new System.Drawing.Point(9, 592);
            this.btnApiSetting.Name = "btnApiSetting";
            this.btnApiSetting.Size = new System.Drawing.Size(132, 27);
            this.btnApiSetting.TabIndex = 44;
            this.btnApiSetting.Text = "Save Api Settings";
            this.btnApiSetting.UseVisualStyleBackColor = true;
            this.btnApiSetting.Click += new System.EventHandler(this.btnApiSetting_Click);
            // 
            // btnSaveLoginDetails
            // 
            this.btnSaveLoginDetails.Location = new System.Drawing.Point(147, 592);
            this.btnSaveLoginDetails.Name = "btnSaveLoginDetails";
            this.btnSaveLoginDetails.Size = new System.Drawing.Size(147, 27);
            this.btnSaveLoginDetails.TabIndex = 45;
            this.btnSaveLoginDetails.Text = "Save Login Details";
            this.btnSaveLoginDetails.UseVisualStyleBackColor = true;
            this.btnSaveLoginDetails.Click += new System.EventHandler(this.btnSaveLoginDetails_Click);
            // 
            // btnGetEDetailbyAck
            // 
            this.btnGetEDetailbyAck.Location = new System.Drawing.Point(352, 222);
            this.btnGetEDetailbyAck.Name = "btnGetEDetailbyAck";
            this.btnGetEDetailbyAck.Size = new System.Drawing.Size(244, 30);
            this.btnGetEDetailbyAck.TabIndex = 46;
            this.btnGetEDetailbyAck.Text = "Get E-Invoice Details by Ack";
            this.btnGetEDetailbyAck.UseVisualStyleBackColor = true;
            this.btnGetEDetailbyAck.Click += new System.EventHandler(this.btnGetEDetailbyAck_Click);
            // 
            // btnDecGenIRN
            // 
            this.btnDecGenIRN.Location = new System.Drawing.Point(352, 519);
            this.btnDecGenIRN.Name = "btnDecGenIRN";
            this.btnDecGenIRN.Size = new System.Drawing.Size(244, 30);
            this.btnDecGenIRN.TabIndex = 47;
            this.btnDecGenIRN.Text = "Generate IRN By Decrypted Url";
            this.btnDecGenIRN.UseVisualStyleBackColor = true;
            this.btnDecGenIRN.Click += new System.EventHandler(this.btnDecGenIRN_Click);
            // 
            // btnDecryptedAuthToken
            // 
            this.btnDecryptedAuthToken.Location = new System.Drawing.Point(352, 483);
            this.btnDecryptedAuthToken.Name = "btnDecryptedAuthToken";
            this.btnDecryptedAuthToken.Size = new System.Drawing.Size(244, 30);
            this.btnDecryptedAuthToken.TabIndex = 48;
            this.btnDecryptedAuthToken.Text = "Decrypted Auth Token";
            this.btnDecryptedAuthToken.UseVisualStyleBackColor = true;
            this.btnDecryptedAuthToken.Click += new System.EventHandler(this.btnDecryptedAuthToken_Click);
            // 
            // btnDecCancelIRN
            // 
            this.btnDecCancelIRN.Location = new System.Drawing.Point(352, 553);
            this.btnDecCancelIRN.Name = "btnDecCancelIRN";
            this.btnDecCancelIRN.Size = new System.Drawing.Size(244, 30);
            this.btnDecCancelIRN.TabIndex = 49;
            this.btnDecCancelIRN.Text = "Cancel IRN By Decrypted";
            this.btnDecCancelIRN.UseVisualStyleBackColor = true;
            this.btnDecCancelIRN.Click += new System.EventHandler(this.btnDecCancelIRN_Click);
            // 
            // btnGetEinvDetailByDec
            // 
            this.btnGetEinvDetailByDec.Location = new System.Drawing.Point(352, 589);
            this.btnGetEinvDetailByDec.Name = "btnGetEinvDetailByDec";
            this.btnGetEinvDetailByDec.Size = new System.Drawing.Size(244, 30);
            this.btnGetEinvDetailByDec.TabIndex = 50;
            this.btnGetEinvDetailByDec.Text = "GetEinvDetailByDec";
            this.btnGetEinvDetailByDec.UseVisualStyleBackColor = true;
            this.btnGetEinvDetailByDec.Click += new System.EventHandler(this.btnGetEinvDetailByDec_Click);
            // 
            // btnGenEWB
            // 
            this.btnGenEWB.Location = new System.Drawing.Point(352, 261);
            this.btnGenEWB.Name = "btnGenEWB";
            this.btnGenEWB.Size = new System.Drawing.Size(244, 30);
            this.btnGenEWB.TabIndex = 51;
            this.btnGenEWB.Text = "Generate Ewaybill by IRN";
            this.btnGenEWB.UseVisualStyleBackColor = true;
            this.btnGenEWB.Click += new System.EventHandler(this.btnGenEWB_Click);
            // 
            // txtEwbBaseUrl
            // 
            this.txtEwbBaseUrl.Location = new System.Drawing.Point(117, 241);
            this.txtEwbBaseUrl.Name = "txtEwbBaseUrl";
            this.txtEwbBaseUrl.ReadOnly = true;
            this.txtEwbBaseUrl.Size = new System.Drawing.Size(202, 22);
            this.txtEwbBaseUrl.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 52;
            this.label18.Text = "EWB Url";
            // 
            // btnDecGenEwbByIRN
            // 
            this.btnDecGenEwbByIRN.Location = new System.Drawing.Point(352, 625);
            this.btnDecGenEwbByIRN.Name = "btnDecGenEwbByIRN";
            this.btnDecGenEwbByIRN.Size = new System.Drawing.Size(244, 30);
            this.btnDecGenEwbByIRN.TabIndex = 54;
            this.btnDecGenEwbByIRN.Text = "Generate Ewaybill by IRN Decrypt";
            this.btnDecGenEwbByIRN.UseVisualStyleBackColor = true;
            this.btnDecGenEwbByIRN.Click += new System.EventHandler(this.btnDecGenEwbByIRN_Click);
            // 
            // txtCancelEWB
            // 
            this.txtCancelEWB.Location = new System.Drawing.Point(117, 269);
            this.txtCancelEWB.Name = "txtCancelEWB";
            this.txtCancelEWB.ReadOnly = true;
            this.txtCancelEWB.Size = new System.Drawing.Size(202, 22);
            this.txtCancelEWB.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Cancel EWB Url";
            // 
            // btnCancelEwayBill
            // 
            this.btnCancelEwayBill.Location = new System.Drawing.Point(352, 358);
            this.btnCancelEwayBill.Name = "btnCancelEwayBill";
            this.btnCancelEwayBill.Size = new System.Drawing.Size(244, 30);
            this.btnCancelEwayBill.TabIndex = 57;
            this.btnCancelEwayBill.Text = "Cancel EWB";
            this.btnCancelEwayBill.UseVisualStyleBackColor = true;
            this.btnCancelEwayBill.Click += new System.EventHandler(this.btnCancelEwayBill_Click);
            // 
            // btnCancelEwbByDec
            // 
            this.btnCancelEwbByDec.Location = new System.Drawing.Point(352, 662);
            this.btnCancelEwbByDec.Name = "btnCancelEwbByDec";
            this.btnCancelEwbByDec.Size = new System.Drawing.Size(244, 30);
            this.btnCancelEwbByDec.TabIndex = 58;
            this.btnCancelEwbByDec.Text = "Cancel Ewb by Dec";
            this.btnCancelEwbByDec.UseVisualStyleBackColor = true;
            this.btnCancelEwbByDec.Click += new System.EventHandler(this.btnCancelEwbByDec_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 30);
            this.btnBrowse.TabIndex = 59;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSandBoxSetting
            // 
            this.btnSandBoxSetting.Location = new System.Drawing.Point(147, 625);
            this.btnSandBoxSetting.Name = "btnSandBoxSetting";
            this.btnSandBoxSetting.Size = new System.Drawing.Size(147, 45);
            this.btnSandBoxSetting.TabIndex = 61;
            this.btnSandBoxSetting.Text = "Default SandBox Setting";
            this.btnSandBoxSetting.UseVisualStyleBackColor = true;
            this.btnSandBoxSetting.Click += new System.EventHandler(this.btnSandBoxSetting_Click);
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(9, 625);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(132, 45);
            this.btnProduction.TabIndex = 60;
            this.btnProduction.Text = "Default Production Setting";
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnVerifySignedInv
            // 
            this.btnVerifySignedInv.Location = new System.Drawing.Point(352, 116);
            this.btnVerifySignedInv.Name = "btnVerifySignedInv";
            this.btnVerifySignedInv.Size = new System.Drawing.Size(244, 30);
            this.btnVerifySignedInv.TabIndex = 62;
            this.btnVerifySignedInv.Text = "Verify Signed Invoice";
            this.btnVerifySignedInv.UseVisualStyleBackColor = true;
            this.btnVerifySignedInv.Click += new System.EventHandler(this.btnVerifySignedInv_Click);
            // 
            // btnGetEWBByIRN
            // 
            this.btnGetEWBByIRN.Location = new System.Drawing.Point(352, 394);
            this.btnGetEWBByIRN.Name = "btnGetEWBByIRN";
            this.btnGetEWBByIRN.Size = new System.Drawing.Size(244, 31);
            this.btnGetEWBByIRN.TabIndex = 63;
            this.btnGetEWBByIRN.Text = "Get EWB By IRN";
            this.btnGetEWBByIRN.UseVisualStyleBackColor = true;
            this.btnGetEWBByIRN.Click += new System.EventHandler(this.btnGetEWBByIRN_Click);
            // 
            // btnGetSyncGSTINDetails
            // 
            this.btnGetSyncGSTINDetails.Location = new System.Drawing.Point(352, 331);
            this.btnGetSyncGSTINDetails.Name = "btnGetSyncGSTINDetails";
            this.btnGetSyncGSTINDetails.Size = new System.Drawing.Size(244, 23);
            this.btnGetSyncGSTINDetails.TabIndex = 64;
            this.btnGetSyncGSTINDetails.Text = "Sync GSTIN Details";
            this.btnGetSyncGSTINDetails.UseVisualStyleBackColor = true;
            this.btnGetSyncGSTINDetails.Click += new System.EventHandler(this.btnGetSyncGSTINDetails_Click);
            // 
            // btnGetIRNDetailsByDocDetails
            // 
            this.btnGetIRNDetailsByDocDetails.Location = new System.Drawing.Point(352, 433);
            this.btnGetIRNDetailsByDocDetails.Name = "btnGetIRNDetailsByDocDetails";
            this.btnGetIRNDetailsByDocDetails.Size = new System.Drawing.Size(244, 29);
            this.btnGetIRNDetailsByDocDetails.TabIndex = 65;
            this.btnGetIRNDetailsByDocDetails.Text = "Get IRN Details By Doc Details";
            this.btnGetIRNDetailsByDocDetails.UseVisualStyleBackColor = true;
            this.btnGetIRNDetailsByDocDetails.Click += new System.EventHandler(this.btnGetIRNDetailsByDocDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 704);
            this.Controls.Add(this.btnGetIRNDetailsByDocDetails);
            this.Controls.Add(this.btnGetSyncGSTINDetails);
            this.Controls.Add(this.btnGetEWBByIRN);
            this.Controls.Add(this.btnVerifySignedInv);
            this.Controls.Add(this.btnSandBoxSetting);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancelEwbByDec);
            this.Controls.Add(this.btnCancelEwayBill);
            this.Controls.Add(this.txtCancelEWB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnDecGenEwbByIRN);
            this.Controls.Add(this.txtEwbBaseUrl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnGenEWB);
            this.Controls.Add(this.btnGetEinvDetailByDec);
            this.Controls.Add(this.btnDecCancelIRN);
            this.Controls.Add(this.btnDecryptedAuthToken);
            this.Controls.Add(this.btnDecGenIRN);
            this.Controls.Add(this.btnGetEDetailbyAck);
            this.Controls.Add(this.btnSaveLoginDetails);
            this.Controls.Add(this.btnApiSetting);
            this.Controls.Add(this.btnGSTINDet);
            this.Controls.Add(this.btnGetEDetailsbyIRN);
            this.Controls.Add(this.btnCancelIRN);
            this.Controls.Add(this.btnGenIRN);
            this.Controls.Add(this.btnAuthToken);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtResponceHdr);
            this.Controls.Add(this.rtbResponce);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtTokenExp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAuthToken);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAppKey);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGstin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBaseUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAuthUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAspPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAspUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGspName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGspName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAspUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAspPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTokenExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAuthToken;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGstin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtbResponce;
        private System.Windows.Forms.TextBox txtResponceHdr;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAuthToken;
        private System.Windows.Forms.Button btnGenIRN;
        private System.Windows.Forms.Button btnCancelIRN;
        private System.Windows.Forms.Button btnGSTINDet;
        private System.Windows.Forms.Button btnGetEDetailsbyIRN;
        private System.Windows.Forms.Button btnApiSetting;
        private System.Windows.Forms.Button btnSaveLoginDetails;
        private System.Windows.Forms.Button btnGetEDetailbyAck;
        private System.Windows.Forms.Button btnDecGenIRN;
        private System.Windows.Forms.Button btnDecryptedAuthToken;
        private System.Windows.Forms.Button btnDecCancelIRN;
        private System.Windows.Forms.Button btnGetEinvDetailByDec;
        private System.Windows.Forms.Button btnGenEWB;
        private System.Windows.Forms.TextBox txtEwbBaseUrl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnDecGenEwbByIRN;
        private System.Windows.Forms.TextBox txtCancelEWB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCancelEwayBill;
        private System.Windows.Forms.Button btnCancelEwbByDec;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSandBoxSetting;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnVerifySignedInv;
		private System.Windows.Forms.Button btnGetEWBByIRN;
		private System.Windows.Forms.Button btnGetSyncGSTINDetails;
        private System.Windows.Forms.Button btnGetIRNDetailsByDocDetails;
    }
}

