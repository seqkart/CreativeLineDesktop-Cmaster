﻿namespace WindowsFormsApplication1.Transaction
{
    partial class FrmTdsDeductionAddEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTdsDeductionAddEdit));
            this.txtReference = new DevExpress.XtraEditors.TextEdit();
            this.txtTDSDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtOnAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtTTNo = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPCode = new DevExpress.XtraEditors.TextEdit();
            this.txtPDesc = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTDSCode = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTDSRate = new DevExpress.XtraEditors.TextEdit();
            this.txtTDSSurcharge = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.TextAuthenticate = new System.Windows.Forms.ToolStripTextBox();
            this.dtTransDate = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTDSAmount = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSurcOnTDS = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnderSection = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new DevExpress.XtraEditors.LabelControl();
            this.MyValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTTNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSSurcharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurcOnTDS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnderSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReference
            // 
            this.txtReference.EnterMoveNextControl = true;
            this.txtReference.Location = new System.Drawing.Point(367, 183);
            this.txtReference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReference.Name = "txtReference";
            this.txtReference.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReference.Size = new System.Drawing.Size(463, 22);
            this.txtReference.TabIndex = 6;
            this.txtReference.Leave += new System.EventHandler(this.TxtReference_Leave);
            // 
            // txtTDSDesc
            // 
            this.txtTDSDesc.Enabled = false;
            this.txtTDSDesc.Location = new System.Drawing.Point(294, 141);
            this.txtTDSDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDSDesc.Name = "txtTDSDesc";
            this.txtTDSDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTDSDesc.Properties.ReadOnly = true;
            this.txtTDSDesc.Size = new System.Drawing.Size(535, 22);
            this.txtTDSDesc.TabIndex = 208;
            // 
            // txtOnAmount
            // 
            this.txtOnAmount.EnterMoveNextControl = true;
            this.txtOnAmount.Location = new System.Drawing.Point(141, 183);
            this.txtOnAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOnAmount.Name = "txtOnAmount";
            this.txtOnAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOnAmount.Properties.Mask.BeepOnError = true;
            this.txtOnAmount.Properties.Mask.EditMask = "N2";
            this.txtOnAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOnAmount.Size = new System.Drawing.Size(128, 22);
            this.txtOnAmount.TabIndex = 5;
            this.txtOnAmount.EditValueChanged += new System.EventHandler(this.TxtOnAmount_EditValueChanged);
            this.txtOnAmount.Leave += new System.EventHandler(this.TxtOnAmount_Leave);
            // 
            // txtTTNo
            // 
            this.txtTTNo.EnterMoveNextControl = true;
            this.txtTTNo.Location = new System.Drawing.Point(141, 60);
            this.txtTTNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTTNo.Name = "txtTTNo";
            this.txtTTNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTTNo.Properties.ReadOnly = true;
            this.txtTTNo.Size = new System.Drawing.Size(128, 22);
            this.txtTTNo.TabIndex = 0;
            this.txtTTNo.TabStop = false;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(290, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 215;
            this.label13.Text = "Reference";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(621, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 214;
            this.label3.Text = "TDS Rate";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 213;
            this.label2.Text = "On Amount";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 212;
            this.label1.Text = "Transction No";
            // 
            // txtPCode
            // 
            this.txtPCode.Location = new System.Drawing.Point(141, 102);
            this.txtPCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPCode.Properties.MaxLength = 6;
            this.txtPCode.Size = new System.Drawing.Size(128, 22);
            this.txtPCode.TabIndex = 3;
            this.txtPCode.EditValueChanged += new System.EventHandler(this.TxtPCode_EditValueChanged);
            this.txtPCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPCode_KeyDown);
            this.txtPCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPCode_KeyPress);
            // 
            // txtPDesc
            // 
            this.txtPDesc.Enabled = false;
            this.txtPDesc.Location = new System.Drawing.Point(294, 102);
            this.txtPDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPDesc.Name = "txtPDesc";
            this.txtPDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPDesc.Properties.ReadOnly = true;
            this.txtPDesc.Size = new System.Drawing.Size(535, 22);
            this.txtPDesc.TabIndex = 220;
            this.txtPDesc.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(91, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 221;
            this.label4.Text = "Party";
            // 
            // txtTDSCode
            // 
            this.txtTDSCode.Location = new System.Drawing.Point(141, 141);
            this.txtTDSCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDSCode.Name = "txtTDSCode";
            this.txtTDSCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTDSCode.Properties.MaxLength = 4;
            this.txtTDSCode.Size = new System.Drawing.Size(128, 22);
            this.txtTDSCode.TabIndex = 4;
            this.txtTDSCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTDSCode_KeyDown);
            this.txtTDSCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPCode_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(62, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 223;
            this.label5.Text = "TDS Code";
            // 
            // txtTDSRate
            // 
            this.txtTDSRate.Enabled = false;
            this.txtTDSRate.Location = new System.Drawing.Point(692, 267);
            this.txtTDSRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDSRate.Name = "txtTDSRate";
            this.txtTDSRate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTDSRate.Size = new System.Drawing.Size(138, 22);
            this.txtTDSRate.TabIndex = 8;
            // 
            // txtTDSSurcharge
            // 
            this.txtTDSSurcharge.Enabled = false;
            this.txtTDSSurcharge.Location = new System.Drawing.Point(692, 309);
            this.txtTDSSurcharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDSSurcharge.Name = "txtTDSSurcharge";
            this.txtTDSSurcharge.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTDSSurcharge.Properties.NullText = "0";
            this.txtTDSSurcharge.Properties.NullValuePrompt = "0";
            this.txtTDSSurcharge.Size = new System.Drawing.Size(138, 22);
            this.txtTDSSurcharge.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(590, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 225;
            this.label6.Text = "TDS Surcharge";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(28, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 228;
            // 
            // txtRemarks
            // 
            this.txtRemarks.EnterMoveNextControl = true;
            this.txtRemarks.Location = new System.Drawing.Point(141, 350);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemarks.Size = new System.Drawing.Size(691, 22);
            this.txtRemarks.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(70, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 230;
            this.label8.Text = "Remarks";
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave,
            this.TextAuthenticate});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(887, 27);
            this.Menu_ToolStrip.TabIndex = 231;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TextAuthenticate
            // 
            this.TextAuthenticate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TextAuthenticate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAuthenticate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextAuthenticate.Name = "TextAuthenticate";
            this.TextAuthenticate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextAuthenticate.Size = new System.Drawing.Size(116, 27);
            // 
            // dtTransDate
            // 
            this.dtTransDate.EditValue = null;
            this.dtTransDate.EnterMoveNextControl = true;
            this.dtTransDate.Location = new System.Drawing.Point(716, 60);
            this.dtTransDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTransDate.Name = "dtTransDate";
            this.dtTransDate.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtTransDate.Properties.Appearance.Options.UseBorderColor = true;
            this.dtTransDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.AliceBlue;
            this.dtTransDate.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.DodgerBlue;
            this.dtTransDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.dtTransDate.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.dtTransDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dtTransDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTransDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtTransDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtTransDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtTransDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtTransDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtTransDate.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.dtTransDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dtTransDate.Properties.Mask.BeepOnError = true;
            this.dtTransDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtTransDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dtTransDate.Size = new System.Drawing.Size(114, 22);
            this.dtTransDate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(674, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 233;
            this.label9.Text = "Date";
            // 
            // txtTDSAmount
            // 
            this.txtTDSAmount.Enabled = false;
            this.txtTDSAmount.Location = new System.Drawing.Point(141, 267);
            this.txtTDSAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDSAmount.Name = "txtTDSAmount";
            this.txtTDSAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTDSAmount.Properties.Mask.BeepOnError = true;
            this.txtTDSAmount.Properties.Mask.EditMask = "N0";
            this.txtTDSAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTDSAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTDSAmount.Properties.NullText = "0";
            this.txtTDSAmount.Properties.NullValuePrompt = "0";
            this.txtTDSAmount.Size = new System.Drawing.Size(128, 22);
            this.txtTDSAmount.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(48, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 235;
            this.label10.Text = "TDS Amount";
            // 
            // txtSurcOnTDS
            // 
            this.txtSurcOnTDS.Enabled = false;
            this.txtSurcOnTDS.Location = new System.Drawing.Point(141, 309);
            this.txtSurcOnTDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurcOnTDS.Name = "txtSurcOnTDS";
            this.txtSurcOnTDS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurcOnTDS.Properties.Mask.BeepOnError = true;
            this.txtSurcOnTDS.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSurcOnTDS.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSurcOnTDS.Properties.MaskSettings.Set("mask", "N0");
            this.txtSurcOnTDS.Properties.NullText = "0";
            this.txtSurcOnTDS.Properties.NullValuePrompt = "0";
            this.txtSurcOnTDS.Size = new System.Drawing.Size(128, 22);
            this.txtSurcOnTDS.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(19, 312);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 237;
            this.label11.Text = "Surchare on TDS ";
            // 
            // txtUnderSection
            // 
            this.txtUnderSection.Enabled = false;
            this.txtUnderSection.EnterMoveNextControl = true;
            this.txtUnderSection.Location = new System.Drawing.Point(141, 225);
            this.txtUnderSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnderSection.Name = "txtUnderSection";
            this.txtUnderSection.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnderSection.Size = new System.Drawing.Size(689, 22);
            this.txtUnderSection.TabIndex = 295;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(38, 228);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 296;
            this.label12.Text = "Under Section";
            // 
            // MyValidationProvider
            // 
            this.MyValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(211, 31);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(676, 387);
            this.HelpGrid.TabIndex = 369;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView,
            this.gridView4,
            this.gridView5});
            this.HelpGrid.Visible = false;
            this.HelpGrid.DoubleClick += new System.EventHandler(this.HelpGrid_DoubleClick);
            // 
            // HelpGridView
            // 
            this.HelpGridView.DetailHeight = 458;
            this.HelpGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.HelpGridView.GridControl = this.HelpGrid;
            this.HelpGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.HelpGridView.Name = "HelpGridView";
            this.HelpGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.HelpGridView.OptionsBehavior.Editable = false;
            this.HelpGridView.OptionsView.ShowGroupPanel = false;
            this.HelpGridView.OptionsView.ShowIndicator = false;
            this.HelpGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.HelpGrid;
            this.gridView4.Name = "gridView4";
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 458;
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.GridControl = this.HelpGrid;
            this.gridView5.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // FrmTdsDeductionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(887, 418);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtUnderSection);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSurcOnTDS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTDSAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtTransDate);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTDSSurcharge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTDSRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTDSCode);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.txtPDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtTDSDesc);
            this.Controls.Add(this.txtOnAmount);
            this.Controls.Add(this.txtTTNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTdsDeductionAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmTdsDeductionAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTdsDeductionAddEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTTNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSSurcharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTransDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTDSAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurcOnTDS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnderSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtReference;
        private DevExpress.XtraEditors.TextEdit txtTDSDesc;
        private DevExpress.XtraEditors.TextEdit txtOnAmount;
        private DevExpress.XtraEditors.TextEdit txtTTNo;
        private DevExpress.XtraEditors.LabelControl label13;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtPCode;
        private DevExpress.XtraEditors.TextEdit txtPDesc;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtTDSCode;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit txtTDSRate;
        private DevExpress.XtraEditors.TextEdit txtTDSSurcharge;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtRemarks;
        private DevExpress.XtraEditors.LabelControl label8;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.DateEdit dtTransDate;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.TextEdit txtTDSAmount;
        private DevExpress.XtraEditors.LabelControl label10;
        private DevExpress.XtraEditors.TextEdit txtSurcOnTDS;
        private DevExpress.XtraEditors.LabelControl label11;
        private DevExpress.XtraEditors.TextEdit txtUnderSection;
        private DevExpress.XtraEditors.LabelControl label12;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider MyValidationProvider;
        private System.Windows.Forms.ToolStripTextBox TextAuthenticate;
        private System.Windows.Forms.ErrorProvider Error;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
    }
}