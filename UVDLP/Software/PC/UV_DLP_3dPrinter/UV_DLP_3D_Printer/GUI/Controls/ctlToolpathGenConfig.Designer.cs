﻿namespace UV_DLP_3D_Printer.GUI.Controls
{
    partial class ctlToolpathGenConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.tbOptions = new System.Windows.Forms.TabPage();
            this.comboExportSvg = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkExportPNG = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttResinCalib = new System.Windows.Forms.Button();
            this.comboResin = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResinPriceL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtnumbottom = new System.Windows.Forms.TextBox();
            this.txtLayerTime = new System.Windows.Forms.TextBox();
            this.lblLayerTime = new System.Windows.Forms.Label();
            this.txtZThick = new System.Windows.Forms.TextBox();
            this.txtFirstLayerTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAAVal = new System.Windows.Forms.TextBox();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.lblProfName = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkReflectY = new System.Windows.Forms.CheckBox();
            this.chkReflectX = new System.Windows.Forms.CheckBox();
            this.grpLift = new System.Windows.Forms.GroupBox();
            this.cmdAutoCalc = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtliftfeed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtretractfeed = new System.Windows.Forms.TextBox();
            this.txtLiftDistance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSlideTilt = new System.Windows.Forms.TextBox();
            this.cmbBuildDirection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBlankTime = new System.Windows.Forms.TextBox();
            this.chkantialiasing = new System.Windows.Forms.CheckBox();
            this.cmdApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYOffset = new System.Windows.Forms.TextBox();
            this.txtXOffset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGCode = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.lbGCodeSection = new System.Windows.Forms.ListBox();
            this.cmdReloadGCode = new System.Windows.Forms.Button();
            this.cmdSaveGCode = new System.Windows.Forms.Button();
            this.txtGCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSliceProfiles = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstSliceProfiles = new System.Windows.Forms.ListBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdNew = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmdDelResin = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.cmdNewResin = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.tabOptions.SuspendLayout();
            this.tbOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpLift.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbGCode.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.tbOptions);
            this.tabOptions.Controls.Add(this.tbGCode);
            this.tabOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOptions.Location = new System.Drawing.Point(248, 15);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(779, 534);
            this.tabOptions.TabIndex = 46;
            // 
            // tbOptions
            // 
            this.tbOptions.Controls.Add(this.groupBox6);
            this.tbOptions.Controls.Add(this.groupBox5);
            this.tbOptions.Controls.Add(this.groupBox2);
            this.tbOptions.Controls.Add(this.lblProfName);
            this.tbOptions.Controls.Add(this.txtNotes);
            this.tbOptions.Controls.Add(this.label15);
            this.tbOptions.Controls.Add(this.label9);
            this.tbOptions.Controls.Add(this.groupBox3);
            this.tbOptions.Controls.Add(this.grpLift);
            this.tbOptions.Controls.Add(this.cmdApply);
            this.tbOptions.Controls.Add(this.groupBox1);
            this.tbOptions.Location = new System.Drawing.Point(4, 27);
            this.tbOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOptions.Name = "tbOptions";
            this.tbOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOptions.Size = new System.Drawing.Size(771, 503);
            this.tbOptions.TabIndex = 0;
            this.tbOptions.Text = "Options";
            this.tbOptions.UseVisualStyleBackColor = true;
            // 
            // comboExportSvg
            // 
            this.comboExportSvg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExportSvg.FormattingEnabled = true;
            this.comboExportSvg.Items.AddRange(new object[] {
            "None",
            "Compound path",
            "Filled polygons",
            "Compound path (old)",
            "Filled polygons (old)"});
            this.comboExportSvg.Location = new System.Drawing.Point(112, 81);
            this.comboExportSvg.Name = "comboExportSvg";
            this.comboExportSvg.Size = new System.Drawing.Size(142, 26);
            this.comboExportSvg.TabIndex = 67;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 18);
            this.label19.TabIndex = 66;
            this.label19.Text = "Export SVG:";
            // 
            // chkExportPNG
            // 
            this.chkExportPNG.AutoSize = true;
            this.chkExportPNG.Location = new System.Drawing.Point(6, 54);
            this.chkExportPNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExportPNG.Name = "chkExportPNG";
            this.chkExportPNG.Size = new System.Drawing.Size(168, 22);
            this.chkExportPNG.TabIndex = 65;
            this.chkExportPNG.Text = "Export Slices to Disk";
            this.chkExportPNG.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttResinCalib);
            this.groupBox2.Controls.Add(this.cmdDelResin);
            this.groupBox2.Controls.Add(this.cmdNewResin);
            this.groupBox2.Controls.Add(this.comboResin);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtResinPriceL);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(18, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 118);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resin";
            // 
            // buttResinCalib
            // 
            this.buttResinCalib.Location = new System.Drawing.Point(6, 57);
            this.buttResinCalib.Name = "buttResinCalib";
            this.buttResinCalib.Size = new System.Drawing.Size(97, 30);
            this.buttResinCalib.TabIndex = 66;
            this.buttResinCalib.Text = "Calibrate";
            this.buttResinCalib.UseVisualStyleBackColor = true;
            this.buttResinCalib.Click += new System.EventHandler(this.buttResinCalib_Click);
            // 
            // comboResin
            // 
            this.comboResin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboResin.FormattingEnabled = true;
            this.comboResin.Location = new System.Drawing.Point(55, 23);
            this.comboResin.Name = "comboResin";
            this.comboResin.Size = new System.Drawing.Size(134, 26);
            this.comboResin.TabIndex = 62;
            this.comboResin.SelectedIndexChanged += new System.EventHandler(this.comboResin_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 18);
            this.label18.TabIndex = 61;
            this.label18.Text = "Resin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Slice Thickness (mm)";
            // 
            // txtResinPriceL
            // 
            this.txtResinPriceL.Location = new System.Drawing.Point(183, 89);
            this.txtResinPriceL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResinPriceL.Name = "txtResinPriceL";
            this.txtResinPriceL.Size = new System.Drawing.Size(64, 24);
            this.txtResinPriceL.TabIndex = 58;
            this.txtResinPriceL.Text = "50";
            this.txtResinPriceL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "# Bottom Layers";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 57;
            this.label17.Text = "Price per liter:";
            // 
            // txtnumbottom
            // 
            this.txtnumbottom.Location = new System.Drawing.Point(183, 113);
            this.txtnumbottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnumbottom.Name = "txtnumbottom";
            this.txtnumbottom.Size = new System.Drawing.Size(66, 24);
            this.txtnumbottom.TabIndex = 41;
            this.txtnumbottom.Text = "3";
            this.txtnumbottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLayerTime
            // 
            this.txtLayerTime.Location = new System.Drawing.Point(183, 51);
            this.txtLayerTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLayerTime.Name = "txtLayerTime";
            this.txtLayerTime.Size = new System.Drawing.Size(64, 24);
            this.txtLayerTime.TabIndex = 26;
            this.txtLayerTime.Text = "5000";
            this.txtLayerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLayerTime
            // 
            this.lblLayerTime.AutoSize = true;
            this.lblLayerTime.Location = new System.Drawing.Point(8, 54);
            this.lblLayerTime.Name = "lblLayerTime";
            this.lblLayerTime.Size = new System.Drawing.Size(143, 18);
            this.lblLayerTime.TabIndex = 27;
            this.lblLayerTime.Text = "Exposure Time (ms)";
            // 
            // txtZThick
            // 
            this.txtZThick.Location = new System.Drawing.Point(183, 23);
            this.txtZThick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZThick.Name = "txtZThick";
            this.txtZThick.Size = new System.Drawing.Size(64, 24);
            this.txtZThick.TabIndex = 29;
            this.txtZThick.Text = ".05";
            this.txtZThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstLayerTime
            // 
            this.txtFirstLayerTime.Location = new System.Drawing.Point(183, 81);
            this.txtFirstLayerTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstLayerTime.Name = "txtFirstLayerTime";
            this.txtFirstLayerTime.Size = new System.Drawing.Size(64, 24);
            this.txtFirstLayerTime.TabIndex = 32;
            this.txtFirstLayerTime.Text = "5000";
            this.txtFirstLayerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bottom Exposure (ms)";
            // 
            // txtAAVal
            // 
            this.txtAAVal.Location = new System.Drawing.Point(183, 147);
            this.txtAAVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAAVal.Name = "txtAAVal";
            this.txtAAVal.Size = new System.Drawing.Size(64, 24);
            this.txtAAVal.TabIndex = 60;
            this.txtAAVal.Text = "1.5";
            this.txtAAVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAAVal.TextChanged += new System.EventHandler(this.txtAAVal_TextChanged);
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Location = new System.Drawing.Point(6, 28);
            this.chkExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(174, 22);
            this.chkExport.TabIndex = 59;
            this.chkExport.Text = "Export Slices to CWS";
            this.chkExport.UseVisualStyleBackColor = true;
            this.chkExport.CheckedChanged += new System.EventHandler(this.chkExport_CheckedChanged);
            // 
            // lblProfName
            // 
            this.lblProfName.AutoSize = true;
            this.lblProfName.Location = new System.Drawing.Point(124, 13);
            this.lblProfName.Name = "lblProfName";
            this.lblProfName.Size = new System.Drawing.Size(94, 18);
            this.lblProfName.TabIndex = 56;
            this.lblProfName.Text = "Profile Name";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(18, 54);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(259, 53);
            this.txtNotes.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 54;
            this.label15.Text = "Notes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Profile Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkReflectY);
            this.groupBox3.Controls.Add(this.chkReflectX);
            this.groupBox3.Location = new System.Drawing.Point(287, 283);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(272, 54);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Reflection";
            // 
            // chkReflectY
            // 
            this.chkReflectY.AutoSize = true;
            this.chkReflectY.Location = new System.Drawing.Point(117, 22);
            this.chkReflectY.Name = "chkReflectY";
            this.chkReflectY.Size = new System.Drawing.Size(89, 22);
            this.chkReflectY.TabIndex = 1;
            this.chkReflectY.Text = "Reflect Y";
            this.chkReflectY.UseVisualStyleBackColor = true;
            // 
            // chkReflectX
            // 
            this.chkReflectX.AutoSize = true;
            this.chkReflectX.Location = new System.Drawing.Point(6, 22);
            this.chkReflectX.Name = "chkReflectX";
            this.chkReflectX.Size = new System.Drawing.Size(90, 22);
            this.chkReflectX.TabIndex = 0;
            this.chkReflectX.Text = "Reflect X";
            this.chkReflectX.UseVisualStyleBackColor = true;
            // 
            // grpLift
            // 
            this.grpLift.Controls.Add(this.cmdAutoCalc);
            this.grpLift.Controls.Add(this.label14);
            this.grpLift.Controls.Add(this.txtliftfeed);
            this.grpLift.Controls.Add(this.label13);
            this.grpLift.Controls.Add(this.txtretractfeed);
            this.grpLift.Controls.Add(this.txtLiftDistance);
            this.grpLift.Controls.Add(this.label10);
            this.grpLift.Controls.Add(this.label11);
            this.grpLift.Controls.Add(this.label12);
            this.grpLift.Controls.Add(this.txtSlideTilt);
            this.grpLift.Controls.Add(this.cmbBuildDirection);
            this.grpLift.Controls.Add(this.label5);
            this.grpLift.Controls.Add(this.txtBlankTime);
            this.grpLift.Location = new System.Drawing.Point(287, 46);
            this.grpLift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLift.Name = "grpLift";
            this.grpLift.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLift.Size = new System.Drawing.Size(272, 233);
            this.grpLift.TabIndex = 46;
            this.grpLift.TabStop = false;
            this.grpLift.Text = "Lift and Sequence";
            // 
            // cmdAutoCalc
            // 
            this.cmdAutoCalc.Location = new System.Drawing.Point(71, 43);
            this.cmdAutoCalc.Name = "cmdAutoCalc";
            this.cmdAutoCalc.Size = new System.Drawing.Size(104, 23);
            this.cmdAutoCalc.TabIndex = 49;
            this.cmdAutoCalc.Text = "Auto Calc";
            this.cmdAutoCalc.UseVisualStyleBackColor = true;
            this.cmdAutoCalc.Click += new System.EventHandler(this.cmdAutoCalc_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 18);
            this.label14.TabIndex = 48;
            this.label14.Text = "Z Lift Speed (mm/m)";
            // 
            // txtliftfeed
            // 
            this.txtliftfeed.Location = new System.Drawing.Point(187, 107);
            this.txtliftfeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtliftfeed.Name = "txtliftfeed";
            this.txtliftfeed.Size = new System.Drawing.Size(68, 24);
            this.txtliftfeed.TabIndex = 47;
            this.txtliftfeed.Text = "0";
            this.txtliftfeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 18);
            this.label13.TabIndex = 46;
            this.label13.Text = "Z Retract Speed (mm/m)";
            // 
            // txtretractfeed
            // 
            this.txtretractfeed.Location = new System.Drawing.Point(187, 138);
            this.txtretractfeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtretractfeed.Name = "txtretractfeed";
            this.txtretractfeed.Size = new System.Drawing.Size(68, 24);
            this.txtretractfeed.TabIndex = 45;
            this.txtretractfeed.Text = "0";
            this.txtretractfeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLiftDistance
            // 
            this.txtLiftDistance.Location = new System.Drawing.Point(187, 74);
            this.txtLiftDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLiftDistance.Name = "txtLiftDistance";
            this.txtLiftDistance.Size = new System.Drawing.Size(68, 24);
            this.txtLiftDistance.TabIndex = 37;
            this.txtLiftDistance.Text = "5";
            this.txtLiftDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Z Lift Distance (mm)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 18);
            this.label11.TabIndex = 44;
            this.label11.Text = "Slide / Tilt Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "Build Direction";
            // 
            // txtSlideTilt
            // 
            this.txtSlideTilt.Location = new System.Drawing.Point(187, 171);
            this.txtSlideTilt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlideTilt.Name = "txtSlideTilt";
            this.txtSlideTilt.Size = new System.Drawing.Size(68, 24);
            this.txtSlideTilt.TabIndex = 43;
            this.txtSlideTilt.Text = "0";
            this.txtSlideTilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbBuildDirection
            // 
            this.cmbBuildDirection.FormattingEnabled = true;
            this.cmbBuildDirection.Location = new System.Drawing.Point(134, 201);
            this.cmbBuildDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBuildDirection.Name = "cmbBuildDirection";
            this.cmbBuildDirection.Size = new System.Drawing.Size(121, 26);
            this.cmbBuildDirection.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Lift and Sequence Time (ms)";
            // 
            // txtBlankTime
            // 
            this.txtBlankTime.Location = new System.Drawing.Point(9, 44);
            this.txtBlankTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBlankTime.Name = "txtBlankTime";
            this.txtBlankTime.Size = new System.Drawing.Size(56, 24);
            this.txtBlankTime.TabIndex = 35;
            this.txtBlankTime.Text = "5000";
            this.txtBlankTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkantialiasing
            // 
            this.chkantialiasing.AutoSize = true;
            this.chkantialiasing.Location = new System.Drawing.Point(8, 147);
            this.chkantialiasing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkantialiasing.Name = "chkantialiasing";
            this.chkantialiasing.Size = new System.Drawing.Size(158, 22);
            this.chkantialiasing.TabIndex = 45;
            this.chkantialiasing.Text = "Enable Anti-Aliasing";
            this.chkantialiasing.UseVisualStyleBackColor = true;
            this.chkantialiasing.CheckedChanged += new System.EventHandler(this.chkantialiasing_CheckedChanged);
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(63, 439);
            this.cmdApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(166, 46);
            this.cmdApply.TabIndex = 24;
            this.cmdApply.Text = "Apply Changes";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYOffset);
            this.groupBox1.Controls.Add(this.txtXOffset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(565, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(199, 97);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Pixel Offsets";
            this.groupBox1.Visible = false;
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(72, 65);
            this.txtYOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(68, 24);
            this.txtYOffset.TabIndex = 3;
            this.txtYOffset.Text = "0";
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(72, 25);
            this.txtXOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(68, 24);
            this.txtXOffset.TabIndex = 2;
            this.txtXOffset.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "X Offset";
            // 
            // tbGCode
            // 
            this.tbGCode.Controls.Add(this.label16);
            this.tbGCode.Controls.Add(this.lbGCodeSection);
            this.tbGCode.Controls.Add(this.cmdReloadGCode);
            this.tbGCode.Controls.Add(this.cmdSaveGCode);
            this.tbGCode.Controls.Add(this.txtGCode);
            this.tbGCode.Location = new System.Drawing.Point(4, 27);
            this.tbGCode.Name = "tbGCode";
            this.tbGCode.Size = new System.Drawing.Size(771, 503);
            this.tbGCode.TabIndex = 7;
            this.tbGCode.Text = "GCode";
            this.tbGCode.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "GCode Section";
            // 
            // lbGCodeSection
            // 
            this.lbGCodeSection.FormattingEnabled = true;
            this.lbGCodeSection.ItemHeight = 18;
            this.lbGCodeSection.Items.AddRange(new object[] {
            "Start",
            "Pre-Slice",
            "Lift",
            "End"});
            this.lbGCodeSection.Location = new System.Drawing.Point(4, 42);
            this.lbGCodeSection.Name = "lbGCodeSection";
            this.lbGCodeSection.Size = new System.Drawing.Size(122, 220);
            this.lbGCodeSection.TabIndex = 9;
            this.lbGCodeSection.SelectedIndexChanged += new System.EventHandler(this.lbGCodeSection_SelectedIndexChanged);
            // 
            // cmdReloadGCode
            // 
            this.cmdReloadGCode.Location = new System.Drawing.Point(319, 308);
            this.cmdReloadGCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdReloadGCode.Name = "cmdReloadGCode";
            this.cmdReloadGCode.Size = new System.Drawing.Size(188, 43);
            this.cmdReloadGCode.TabIndex = 8;
            this.cmdReloadGCode.Text = "Reload";
            this.cmdReloadGCode.UseVisualStyleBackColor = true;
            this.cmdReloadGCode.Click += new System.EventHandler(this.cmdReloadGCode_Click);
            // 
            // cmdSaveGCode
            // 
            this.cmdSaveGCode.Location = new System.Drawing.Point(132, 308);
            this.cmdSaveGCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSaveGCode.Name = "cmdSaveGCode";
            this.cmdSaveGCode.Size = new System.Drawing.Size(181, 43);
            this.cmdSaveGCode.TabIndex = 7;
            this.cmdSaveGCode.Text = "Save";
            this.cmdSaveGCode.UseVisualStyleBackColor = true;
            this.cmdSaveGCode.Click += new System.EventHandler(this.cmdSaveGCode_Click);
            // 
            // txtGCode
            // 
            this.txtGCode.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGCode.Location = new System.Drawing.Point(132, 6);
            this.txtGCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGCode.Multiline = true;
            this.txtGCode.Name = "txtGCode";
            this.txtGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGCode.Size = new System.Drawing.Size(788, 298);
            this.txtGCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Profile in Use:";
            // 
            // cmbSliceProfiles
            // 
            this.cmbSliceProfiles.FormattingEnabled = true;
            this.cmbSliceProfiles.Location = new System.Drawing.Point(7, 43);
            this.cmbSliceProfiles.Name = "cmbSliceProfiles";
            this.cmbSliceProfiles.Size = new System.Drawing.Size(228, 24);
            this.cmbSliceProfiles.TabIndex = 63;
            this.cmbSliceProfiles.SelectedIndexChanged += new System.EventHandler(this.cmbSliceProfiles_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lstSliceProfiles);
            this.groupBox4.Controls.Add(this.cmdDelete);
            this.groupBox4.Controls.Add(this.cmdNew);
            this.groupBox4.Location = new System.Drawing.Point(8, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 246);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configured Slicing Profiles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "All Profiles:";
            // 
            // lstSliceProfiles
            // 
            this.lstSliceProfiles.FormattingEnabled = true;
            this.lstSliceProfiles.ItemHeight = 16;
            this.lstSliceProfiles.Location = new System.Drawing.Point(6, 48);
            this.lstSliceProfiles.Name = "lstSliceProfiles";
            this.lstSliceProfiles.Size = new System.Drawing.Size(200, 132);
            this.lstSliceProfiles.TabIndex = 54;
            this.lstSliceProfiles.SelectedIndexChanged += new System.EventHandler(this.lstSliceProfiles_SelectedIndexChanged);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(112, 201);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(101, 33);
            this.cmdDelete.TabIndex = 56;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(5, 201);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(101, 33);
            this.cmdNew.TabIndex = 55;
            this.cmdNew.Text = "Create";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtFirstLayerTime);
            this.groupBox5.Controls.Add(this.txtZThick);
            this.groupBox5.Controls.Add(this.lblLayerTime);
            this.groupBox5.Controls.Add(this.txtLayerTime);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtAAVal);
            this.groupBox5.Controls.Add(this.txtnumbottom);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.chkantialiasing);
            this.groupBox5.Location = new System.Drawing.Point(18, 232);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(259, 190);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exposure Settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkExport);
            this.groupBox6.Controls.Add(this.chkExportPNG);
            this.groupBox6.Controls.Add(this.comboExportSvg);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(288, 342);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(271, 143);
            this.groupBox6.TabIndex = 69;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Export Options";
            // 
            // cmdDelResin
            // 
            this.cmdDelResin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdDelResin.Checked = false;
            this.cmdDelResin.CheckImage = null;
            this.cmdDelResin.Gapx = 5;
            this.cmdDelResin.Gapy = 5;
            this.cmdDelResin.GLBackgroundImage = null;
            this.cmdDelResin.GLImage = null;
            this.cmdDelResin.GLVisible = false;
            this.cmdDelResin.GuiAnchor = null;
            this.cmdDelResin.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelResin.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.cmdDelResin.Location = new System.Drawing.Point(226, 23);
            this.cmdDelResin.Name = "cmdDelResin";
            this.cmdDelResin.Size = new System.Drawing.Size(26, 26);
            this.cmdDelResin.StyleName = null;
            this.cmdDelResin.TabIndex = 65;
            this.cmdDelResin.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdDelResin.Click += new System.EventHandler(this.cmdDelResin_Click);
            // 
            // cmdNewResin
            // 
            this.cmdNewResin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmdNewResin.Checked = false;
            this.cmdNewResin.CheckImage = null;
            this.cmdNewResin.Gapx = 5;
            this.cmdNewResin.Gapy = 5;
            this.cmdNewResin.GLBackgroundImage = null;
            this.cmdNewResin.GLImage = null;
            this.cmdNewResin.GLVisible = false;
            this.cmdNewResin.GuiAnchor = null;
            this.cmdNewResin.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdNewResin.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.cmdNewResin.Location = new System.Drawing.Point(195, 23);
            this.cmdNewResin.Name = "cmdNewResin";
            this.cmdNewResin.Size = new System.Drawing.Size(26, 26);
            this.cmdNewResin.StyleName = null;
            this.cmdNewResin.TabIndex = 64;
            this.cmdNewResin.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.cmdNewResin.Click += new System.EventHandler(this.cmdNewResin_Click);
            // 
            // ctlToolpathGenConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSliceProfiles);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabOptions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctlToolpathGenConfig";
            this.Size = new System.Drawing.Size(1312, 551);
            this.tabOptions.ResumeLayout(false);
            this.tbOptions.ResumeLayout(false);
            this.tbOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpLift.ResumeLayout(false);
            this.grpLift.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbGCode.ResumeLayout(false);
            this.tbGCode.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage tbOptions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkReflectY;
        private System.Windows.Forms.CheckBox chkReflectX;
        private System.Windows.Forms.GroupBox grpLift;
        private System.Windows.Forms.Button cmdAutoCalc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtliftfeed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtretractfeed;
        private System.Windows.Forms.TextBox txtLiftDistance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSlideTilt;
        private System.Windows.Forms.ComboBox cmbBuildDirection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBlankTime;
        private System.Windows.Forms.CheckBox chkantialiasing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnumbottom;
        private System.Windows.Forms.TextBox txtLayerTime;
        private System.Windows.Forms.Label lblLayerTime;
        private System.Windows.Forms.TextBox txtZThick;
        private System.Windows.Forms.TextBox txtFirstLayerTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYOffset;
        private System.Windows.Forms.TextBox txtXOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSliceProfiles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstSliceProfiles;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProfName;
        private System.Windows.Forms.TabPage tbGCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbGCodeSection;
        private System.Windows.Forms.Button cmdReloadGCode;
        private System.Windows.Forms.Button cmdSaveGCode;
        private System.Windows.Forms.TextBox txtGCode;
        private System.Windows.Forms.TextBox txtResinPriceL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.TextBox txtAAVal;
        private System.Windows.Forms.ComboBox comboResin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomGUI.ctlImageButton cmdDelResin;
        private CustomGUI.ctlImageButton cmdNewResin;
        private System.Windows.Forms.Button buttResinCalib;
        private System.Windows.Forms.CheckBox chkExportPNG;
        private System.Windows.Forms.ComboBox comboExportSvg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}
