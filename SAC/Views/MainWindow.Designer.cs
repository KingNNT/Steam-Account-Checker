﻿namespace SAC.Views
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckAccounts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabManualCheck = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSteamAccountName = new System.Windows.Forms.TextBox();
            this.tabAutomaticCheck = new System.Windows.Forms.TabPage();
            this.btnBrowserLocationToExport = new System.Windows.Forms.Button();
            this.textBoxLocalToExport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExportSteamGuardProtectedAccount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkedLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.badLabel = new System.Windows.Forms.Label();
            this.steamGuardLabel = new System.Windows.Forms.Label();
            this.loggableLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExportBadAccount = new System.Windows.Forms.Button();
            this.btnExportGoodAccount = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.CheckboxShowColouredItemsInAccountList = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.btnSoftwareLicense = new System.Windows.Forms.Button();
            this.btnViewThirdPartyLibraries = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContactMe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.StatusColumn = new System.Windows.Forms.ColumnHeader();
            this.UsernameColumn = new System.Windows.Forms.ColumnHeader();
            this.PasswordColumn = new System.Windows.Forms.ColumnHeader();
            this.ResultColumn = new System.Windows.Forms.ColumnHeader();
            this.ctxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.loadingImage = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabManualCheck.SuspendLayout();
            this.tabAutomaticCheck.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ctxMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steam account name:";
            // 
            // btnCheckAccounts
            // 
            this.btnCheckAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAccounts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckAccounts.Location = new System.Drawing.Point(714, 448);
            this.btnCheckAccounts.Name = "btnCheckAccounts";
            this.btnCheckAccounts.Size = new System.Drawing.Size(158, 26);
            this.btnCheckAccounts.TabIndex = 0;
            this.btnCheckAccounts.Text = "Check for accounts";
            this.btnCheckAccounts.UseVisualStyleBackColor = true;
            this.btnCheckAccounts.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password: ";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabManualCheck);
            this.tabControl.Controls.Add(this.tabAutomaticCheck);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 4;
            this.tabControl.Size = new System.Drawing.Size(860, 430);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabManualCheck
            // 
            this.tabManualCheck.BackColor = System.Drawing.Color.White;
            this.tabManualCheck.Controls.Add(this.label5);
            this.tabManualCheck.Controls.Add(this.txtPassword);
            this.tabManualCheck.Controls.Add(this.txtSteamAccountName);
            this.tabManualCheck.Controls.Add(this.label2);
            this.tabManualCheck.Controls.Add(this.label1);
            this.tabManualCheck.Location = new System.Drawing.Point(4, 24);
            this.tabManualCheck.Name = "tabManualCheck";
            this.tabManualCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabManualCheck.Size = new System.Drawing.Size(852, 402);
            this.tabManualCheck.TabIndex = 0;
            this.tabManualCheck.Text = "Manual";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Check an account by manually entering an account username and a password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(283, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // txtSteamAccountName
            // 
            this.txtSteamAccountName.Location = new System.Drawing.Point(146, 70);
            this.txtSteamAccountName.Name = "txtSteamAccountName";
            this.txtSteamAccountName.Size = new System.Drawing.Size(283, 23);
            this.txtSteamAccountName.TabIndex = 5;
            // 
            // tabAutomaticCheck
            // 
            this.tabAutomaticCheck.BackColor = System.Drawing.Color.White;
            this.tabAutomaticCheck.Controls.Add(this.btnBrowserLocationToExport);
            this.tabAutomaticCheck.Controls.Add(this.textBoxLocalToExport);
            this.tabAutomaticCheck.Controls.Add(this.label11);
            this.tabAutomaticCheck.Controls.Add(this.btnExportSteamGuardProtectedAccount);
            this.tabAutomaticCheck.Controls.Add(this.groupBox1);
            this.tabAutomaticCheck.Controls.Add(this.btnExportBadAccount);
            this.tabAutomaticCheck.Controls.Add(this.btnExportGoodAccount);
            this.tabAutomaticCheck.Controls.Add(this.btnBrowseFile);
            this.tabAutomaticCheck.Controls.Add(this.label7);
            this.tabAutomaticCheck.Controls.Add(this.textBoxFile);
            this.tabAutomaticCheck.Controls.Add(this.label6);
            this.tabAutomaticCheck.Location = new System.Drawing.Point(4, 24);
            this.tabAutomaticCheck.Name = "tabAutomaticCheck";
            this.tabAutomaticCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomaticCheck.Size = new System.Drawing.Size(852, 402);
            this.tabAutomaticCheck.TabIndex = 1;
            this.tabAutomaticCheck.Text = "Automatic";
            // 
            // btnBrowserLocationToExport
            // 
            this.btnBrowserLocationToExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowserLocationToExport.Location = new System.Drawing.Point(391, 84);
            this.btnBrowserLocationToExport.Name = "btnBrowserLocationToExport";
            this.btnBrowserLocationToExport.Size = new System.Drawing.Size(35, 25);
            this.btnBrowserLocationToExport.TabIndex = 9;
            this.btnBrowserLocationToExport.Text = "...";
            this.btnBrowserLocationToExport.UseVisualStyleBackColor = true;
            this.btnBrowserLocationToExport.Click += new System.EventHandler(this.btnBrowserLocationToExport_Click);
            // 
            // textBoxLocalToExport
            // 
            this.textBoxLocalToExport.AllowDrop = true;
            this.textBoxLocalToExport.Location = new System.Drawing.Point(134, 85);
            this.textBoxLocalToExport.Name = "textBoxLocalToExport";
            this.textBoxLocalToExport.Size = new System.Drawing.Size(252, 23);
            this.textBoxLocalToExport.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Location to export:";
            // 
            // btnExportSteamGuardProtectedAccount
            // 
            this.btnExportSteamGuardProtectedAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportSteamGuardProtectedAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportSteamGuardProtectedAccount.Location = new System.Drawing.Point(21, 359);
            this.btnExportSteamGuardProtectedAccount.Name = "btnExportSteamGuardProtectedAccount";
            this.btnExportSteamGuardProtectedAccount.Size = new System.Drawing.Size(235, 24);
            this.btnExportSteamGuardProtectedAccount.TabIndex = 7;
            this.btnExportSteamGuardProtectedAccount.Text = "Export SteamGuard protected accounts...";
            this.btnExportSteamGuardProtectedAccount.UseVisualStyleBackColor = true;
            this.btnExportSteamGuardProtectedAccount.Click += new System.EventHandler(this.btnExportSteamGuardProtectedAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.remainingLabel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.checkedLabel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.badLabel);
            this.groupBox1.Controls.Add(this.steamGuardLabel);
            this.groupBox1.Controls.Add(this.loggableLabel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(21, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // remainingLabel
            // 
            this.remainingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remainingLabel.Location = new System.Drawing.Point(154, 111);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(47, 15);
            this.remainingLabel.TabIndex = 8;
            this.remainingLabel.Text = "0";
            this.remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(19, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Remaining:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkedLabel
            // 
            this.checkedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedLabel.Location = new System.Drawing.Point(154, 90);
            this.checkedLabel.Name = "checkedLabel";
            this.checkedLabel.Size = new System.Drawing.Size(47, 15);
            this.checkedLabel.TabIndex = 8;
            this.checkedLabel.Text = "0";
            this.checkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(19, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Checked:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // badLabel
            // 
            this.badLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.badLabel.Location = new System.Drawing.Point(154, 69);
            this.badLabel.Name = "badLabel";
            this.badLabel.Size = new System.Drawing.Size(47, 15);
            this.badLabel.TabIndex = 8;
            this.badLabel.Text = "0";
            this.badLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // steamGuardLabel
            // 
            this.steamGuardLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.steamGuardLabel.Location = new System.Drawing.Point(154, 48);
            this.steamGuardLabel.Name = "steamGuardLabel";
            this.steamGuardLabel.Size = new System.Drawing.Size(47, 15);
            this.steamGuardLabel.TabIndex = 8;
            this.steamGuardLabel.Text = "0";
            this.steamGuardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loggableLabel
            // 
            this.loggableLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loggableLabel.Location = new System.Drawing.Point(154, 26);
            this.loggableLabel.Name = "loggableLabel";
            this.loggableLabel.Size = new System.Drawing.Size(47, 15);
            this.loggableLabel.TabIndex = 8;
            this.loggableLabel.Text = "0";
            this.loggableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(19, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bad:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "SteamGuard protected:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Loggable:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExportBadAccount
            // 
            this.btnExportBadAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportBadAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportBadAccount.Location = new System.Drawing.Point(260, 359);
            this.btnExportBadAccount.Name = "btnExportBadAccount";
            this.btnExportBadAccount.Size = new System.Drawing.Size(161, 24);
            this.btnExportBadAccount.TabIndex = 7;
            this.btnExportBadAccount.Text = "Export bad accounts...";
            this.btnExportBadAccount.UseVisualStyleBackColor = true;
            this.btnExportBadAccount.Click += new System.EventHandler(this.btnExportBadAccount_Click);
            // 
            // btnExportGoodAccount
            // 
            this.btnExportGoodAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportGoodAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportGoodAccount.Location = new System.Drawing.Point(21, 332);
            this.btnExportGoodAccount.Name = "btnExportGoodAccount";
            this.btnExportGoodAccount.Size = new System.Drawing.Size(400, 24);
            this.btnExportGoodAccount.TabIndex = 7;
            this.btnExportGoodAccount.Text = "Export good accounts...";
            this.btnExportGoodAccount.UseVisualStyleBackColor = true;
            this.btnExportGoodAccount.Click += new System.EventHandler(this.btnExportGoodAccount_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowseFile.Location = new System.Drawing.Point(391, 54);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(35, 25);
            this.btnBrowseFile.TabIndex = 9;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select a file with multiple accounts to check";
            // 
            // textBoxFile
            // 
            this.textBoxFile.AllowDrop = true;
            this.textBoxFile.Location = new System.Drawing.Point(55, 55);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(331, 23);
            this.textBoxFile.TabIndex = 8;
            this.textBoxFile.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragOver);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "File:";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.CheckboxShowColouredItemsInAccountList);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(852, 402);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // CheckboxShowColouredItemsInAccountList
            // 
            this.CheckboxShowColouredItemsInAccountList.AutoSize = true;
            this.CheckboxShowColouredItemsInAccountList.Checked = true;
            this.CheckboxShowColouredItemsInAccountList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxShowColouredItemsInAccountList.Location = new System.Drawing.Point(19, 19);
            this.CheckboxShowColouredItemsInAccountList.Name = "CheckboxShowColouredItemsInAccountList";
            this.CheckboxShowColouredItemsInAccountList.Size = new System.Drawing.Size(234, 19);
            this.CheckboxShowColouredItemsInAccountList.TabIndex = 8;
            this.CheckboxShowColouredItemsInAccountList.Text = "Show coloured items in the account list";
            this.CheckboxShowColouredItemsInAccountList.UseVisualStyleBackColor = true;
            this.CheckboxShowColouredItemsInAccountList.CheckedChanged += new System.EventHandler(this.checkShowPasswordInLogs_CheckedChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Controls.Add(this.btnSoftwareLicense);
            this.tabAbout.Controls.Add(this.btnViewThirdPartyLibraries);
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.label4);
            this.tabAbout.Controls.Add(this.btnContactMe);
            this.tabAbout.Controls.Add(this.label3);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(852, 402);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            // 
            // btnSoftwareLicense
            // 
            this.btnSoftwareLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoftwareLicense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSoftwareLicense.Location = new System.Drawing.Point(211, 362);
            this.btnSoftwareLicense.Name = "btnSoftwareLicense";
            this.btnSoftwareLicense.Size = new System.Drawing.Size(132, 24);
            this.btnSoftwareLicense.TabIndex = 6;
            this.btnSoftwareLicense.Text = "View software license";
            this.btnSoftwareLicense.UseVisualStyleBackColor = true;
            this.btnSoftwareLicense.Click += new System.EventHandler(this.ButtonViewSoftwareLicense_Click);
            // 
            // btnViewThirdPartyLibraries
            // 
            this.btnViewThirdPartyLibraries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewThirdPartyLibraries.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewThirdPartyLibraries.Location = new System.Drawing.Point(345, 362);
            this.btnViewThirdPartyLibraries.Name = "btnViewThirdPartyLibraries";
            this.btnViewThirdPartyLibraries.Size = new System.Drawing.Size(162, 24);
            this.btnViewThirdPartyLibraries.TabIndex = 6;
            this.btnViewThirdPartyLibraries.Text = "View third party libraries...";
            this.btnViewThirdPartyLibraries.UseVisualStyleBackColor = true;
            this.btnViewThirdPartyLibraries.Click += new System.EventHandler(this.ButtonViewThirdPartyLibraries_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(390, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(293, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Update by KingNNT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContactMe
            // 
            this.btnContactMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContactMe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnContactMe.Location = new System.Drawing.Point(510, 362);
            this.btnContactMe.Name = "btnContactMe";
            this.btnContactMe.Size = new System.Drawing.Size(132, 24);
            this.btnContactMe.TabIndex = 6;
            this.btnContactMe.Text = "Contact Me";
            this.btnContactMe.UseVisualStyleBackColor = true;
            this.btnContactMe.Click += new System.EventHandler(this.btnContactMe_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(320, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Steam Account Checker";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewResult
            // 
            this.listViewResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StatusColumn,
            this.UsernameColumn,
            this.PasswordColumn,
            this.ResultColumn});
            this.listViewResult.ContextMenuStrip = this.ctxMenuStrip;
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.GridLines = true;
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(455, 40);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(410, 400);
            this.listViewResult.TabIndex = 5;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 45;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.Name = "UsernameColumn";
            this.UsernameColumn.Text = "Username";
            this.UsernameColumn.Width = 90;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Text = "Password";
            this.PasswordColumn.Width = 90;
            // 
            // ResultColumn
            // 
            this.ResultColumn.Name = "ResultColumn";
            this.ResultColumn.Text = "Result";
            this.ResultColumn.Width = 180;
            // 
            // ctxMenuStrip
            // 
            this.ctxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.ctxMenuStrip.Name = "contextMSAutomaticAccounts";
            this.ctxMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMenuStrip.Size = new System.Drawing.Size(204, 98);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem4.Text = "Copy all";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem1.Text = "Copy selected";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem2.Text = "Copy selected username";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem3.Text = "Copy selected password";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // loadingImage
            // 
            this.loadingImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingImage.Location = new System.Drawing.Point(3, 3);
            this.loadingImage.Name = "loadingImage";
            this.loadingImage.Size = new System.Drawing.Size(26, 26);
            this.loadingImage.TabIndex = 5;
            this.loadingImage.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(35, 2);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.labelStatus.Size = new System.Drawing.Size(637, 28);
            this.labelStatus.TabIndex = 6;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Username";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Password";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "Result";
            this.columnHeader7.Width = 180;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.loadingImage);
            this.flowLayoutPanel1.Controls.Add(this.labelStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 444);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(695, 34);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCheckAccounts);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 525);
            this.Name = "MainWindow";
            this.Text = "Steam Account Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabManualCheck.ResumeLayout(false);
            this.tabManualCheck.PerformLayout();
            this.tabAutomaticCheck.ResumeLayout(false);
            this.tabAutomaticCheck.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ctxMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabManualCheck;
        private System.Windows.Forms.TabPage tabAutomaticCheck;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContactMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExportGoodAccount;
        private System.Windows.Forms.Button btnExportBadAccount;
        private System.Windows.Forms.Button btnExportSteamGuardProtectedAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrowserLocationToExport;
        public System.Windows.Forms.Button btnCheckAccounts;
        public System.Windows.Forms.Label badLabel;
        public System.Windows.Forms.Label steamGuardLabel;
        public System.Windows.Forms.Label loggableLabel;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox txtSteamAccountName;
        public System.Windows.Forms.TextBox textBoxFile;
        public System.Windows.Forms.Label remainingLabel;
        public System.Windows.Forms.Label checkedLabel;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.CheckBox CheckboxShowColouredItemsInAccountList;
        public System.Windows.Forms.TextBox textBoxLocalToExport;
        private System.Windows.Forms.Button btnViewThirdPartyLibraries;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.PictureBox loadingImage;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSoftwareLicense;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button oo;
        private System.Windows.Forms.Button Bro;
        public System.Windows.Forms.Button C;
        public System.Windows.Forms.ListView ist;
        public System.Windows.Forms.TextBox Stea;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.ListView listViewResult;
        public System.Windows.Forms.ColumnHeader StatusColumn;
        public System.Windows.Forms.ColumnHeader UsernameColumn;
        public System.Windows.Forms.ColumnHeader PasswordColumn;
        public System.Windows.Forms.ColumnHeader ResultColumn;
    }
}

