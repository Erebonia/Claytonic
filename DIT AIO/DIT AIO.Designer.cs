namespace DIT_AIO
{
    partial class Runetonic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runetonic));
            this.btn_Restore_User_Data = new System.Windows.Forms.Button();
            this.btn_Firewall = new System.Windows.Forms.Button();
            this.btn_Check_User_Accounts = new System.Windows.Forms.Button();
            this.btn_MF_Unsuspend = new System.Windows.Forms.Button();
            this.btn_MF_PW_Reset = new System.Windows.Forms.Button();
            this.btn_Backup_Printers = new System.Windows.Forms.Button();
            this.btn_Restore_Printers = new System.Windows.Forms.Button();
            this.btn_Paperport = new System.Windows.Forms.Button();
            this.btn_Esignature = new System.Windows.Forms.Button();
            this.btn_MF_Guide = new System.Windows.Forms.Button();
            this.btn_Ping_IP = new System.Windows.Forms.Button();
            this.btn_SFC = new System.Windows.Forms.Button();
            this.btn_DISM = new System.Windows.Forms.Button();
            this.btn_blank_login = new System.Windows.Forms.Button();
            this.btn_outlook_cache = new System.Windows.Forms.Button();
            this.btn_CCH_Deploy = new System.Windows.Forms.Button();
            this.btn_MF_PS_Printer_Data = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.programicon = new System.Windows.Forms.Panel();
            this.programName = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.btnBackup_User_Data = new System.Windows.Forms.Button();
            this.Master = new System.Windows.Forms.Panel();
            this.DataRecovery = new System.Windows.Forms.Panel();
            this.DESC_Restore_User_Data = new System.Windows.Forms.Label();
            this.Desc_Backup_User_Data = new System.Windows.Forms.Label();
            this.Title_Data_Recovery = new System.Windows.Forms.Label();
            this.Diagnostics = new System.Windows.Forms.Panel();
            this.Title_Diagnostics = new System.Windows.Forms.Label();
            this.SystemSetup = new System.Windows.Forms.Panel();
            this.Title_SystemSetup = new System.Windows.Forms.Label();
            this.Mainframe = new System.Windows.Forms.Panel();
            this.Title_Mainframe = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Panel();
            this.Title_Settings = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Panel();
            this.Title_Home = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.DESC_Backup_Printers = new System.Windows.Forms.Label();
            this.DESC_Restore_Printers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMainframe = new System.Windows.Forms.Button();
            this.btnSystemSetup = new System.Windows.Forms.Button();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.btnDataRecovery = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.warning_printers = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DESC_Check_User_Account = new System.Windows.Forms.Label();
            this.DESC_Ping = new System.Windows.Forms.Label();
            this.DESC_SFC = new System.Windows.Forms.Label();
            this.DESC_DISM = new System.Windows.Forms.Label();
            this.DESC_CCH_Deploy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.programicon.SuspendLayout();
            this.Master.SuspendLayout();
            this.DataRecovery.SuspendLayout();
            this.Diagnostics.SuspendLayout();
            this.SystemSetup.SuspendLayout();
            this.Mainframe.SuspendLayout();
            this.Settings.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_printers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Restore_User_Data
            // 
            this.btn_Restore_User_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restore_User_Data.Location = new System.Drawing.Point(26, 161);
            this.btn_Restore_User_Data.Name = "btn_Restore_User_Data";
            this.btn_Restore_User_Data.Size = new System.Drawing.Size(105, 38);
            this.btn_Restore_User_Data.TabIndex = 2;
            this.btn_Restore_User_Data.Tag = "DataRecovery";
            this.btn_Restore_User_Data.Text = "Restore User Data";
            this.btn_Restore_User_Data.UseVisualStyleBackColor = true;
            this.btn_Restore_User_Data.Visible = false;
            this.btn_Restore_User_Data.Click += new System.EventHandler(this.Restore_Data);
            // 
            // btn_Firewall
            // 
            this.btn_Firewall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Firewall.Location = new System.Drawing.Point(26, 233);
            this.btn_Firewall.Name = "btn_Firewall";
            this.btn_Firewall.Size = new System.Drawing.Size(105, 38);
            this.btn_Firewall.TabIndex = 5;
            this.btn_Firewall.Tag = "SystemSetup";
            this.btn_Firewall.Text = "Firewall Off";
            this.btn_Firewall.UseVisualStyleBackColor = true;
            this.btn_Firewall.Visible = false;
            this.btn_Firewall.Click += new System.EventHandler(this.DisableFirewall);
            // 
            // btn_Check_User_Accounts
            // 
            this.btn_Check_User_Accounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Check_User_Accounts.Location = new System.Drawing.Point(26, 85);
            this.btn_Check_User_Accounts.Name = "btn_Check_User_Accounts";
            this.btn_Check_User_Accounts.Size = new System.Drawing.Size(105, 38);
            this.btn_Check_User_Accounts.TabIndex = 6;
            this.btn_Check_User_Accounts.Tag = "Diagnostics";
            this.btn_Check_User_Accounts.Text = "Check User Account";
            this.btn_Check_User_Accounts.UseVisualStyleBackColor = true;
            this.btn_Check_User_Accounts.Visible = false;
            this.btn_Check_User_Accounts.Click += new System.EventHandler(this.Net_User);
            // 
            // btn_MF_Unsuspend
            // 
            this.btn_MF_Unsuspend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MF_Unsuspend.Location = new System.Drawing.Point(26, 101);
            this.btn_MF_Unsuspend.Name = "btn_MF_Unsuspend";
            this.btn_MF_Unsuspend.Size = new System.Drawing.Size(105, 38);
            this.btn_MF_Unsuspend.TabIndex = 8;
            this.btn_MF_Unsuspend.Tag = "Mainframe";
            this.btn_MF_Unsuspend.Text = "Install Unsuspend Macro";
            this.btn_MF_Unsuspend.UseVisualStyleBackColor = true;
            this.btn_MF_Unsuspend.Visible = false;
            this.btn_MF_Unsuspend.Click += new System.EventHandler(this.Install_ACID_Unsuspend);
            // 
            // btn_MF_PW_Reset
            // 
            this.btn_MF_PW_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MF_PW_Reset.Location = new System.Drawing.Point(26, 145);
            this.btn_MF_PW_Reset.Name = "btn_MF_PW_Reset";
            this.btn_MF_PW_Reset.Size = new System.Drawing.Size(105, 38);
            this.btn_MF_PW_Reset.TabIndex = 9;
            this.btn_MF_PW_Reset.Tag = "Mainframe";
            this.btn_MF_PW_Reset.Text = "Install PW Reset Macro";
            this.btn_MF_PW_Reset.UseVisualStyleBackColor = true;
            this.btn_MF_PW_Reset.Visible = false;
            this.btn_MF_PW_Reset.Click += new System.EventHandler(this.Install_ACID_Reset);
            // 
            // btn_Backup_Printers
            // 
            this.btn_Backup_Printers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Backup_Printers.Location = new System.Drawing.Point(26, 233);
            this.btn_Backup_Printers.Name = "btn_Backup_Printers";
            this.btn_Backup_Printers.Size = new System.Drawing.Size(105, 38);
            this.btn_Backup_Printers.TabIndex = 10;
            this.btn_Backup_Printers.Tag = "DataRecovery";
            this.btn_Backup_Printers.Text = "Backup Printers";
            this.btn_Backup_Printers.UseVisualStyleBackColor = true;
            this.btn_Backup_Printers.Visible = false;
            this.btn_Backup_Printers.Click += new System.EventHandler(this.Backup_Printers);
            // 
            // btn_Restore_Printers
            // 
            this.btn_Restore_Printers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restore_Printers.Location = new System.Drawing.Point(26, 304);
            this.btn_Restore_Printers.Name = "btn_Restore_Printers";
            this.btn_Restore_Printers.Size = new System.Drawing.Size(105, 38);
            this.btn_Restore_Printers.TabIndex = 11;
            this.btn_Restore_Printers.Tag = "DataRecovery";
            this.btn_Restore_Printers.Text = "Restore Printers";
            this.btn_Restore_Printers.UseVisualStyleBackColor = true;
            this.btn_Restore_Printers.Visible = false;
            this.btn_Restore_Printers.Click += new System.EventHandler(this.Restore_Printers);
            // 
            // btn_Paperport
            // 
            this.btn_Paperport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Paperport.Location = new System.Drawing.Point(26, 101);
            this.btn_Paperport.Name = "btn_Paperport";
            this.btn_Paperport.Size = new System.Drawing.Size(105, 38);
            this.btn_Paperport.TabIndex = 12;
            this.btn_Paperport.Tag = "SystemSetup";
            this.btn_Paperport.Text = "Paperport and Scanning";
            this.btn_Paperport.UseVisualStyleBackColor = true;
            this.btn_Paperport.Visible = false;
            this.btn_Paperport.Click += new System.EventHandler(this.Scanner_Setup);
            // 
            // btn_Esignature
            // 
            this.btn_Esignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Esignature.Location = new System.Drawing.Point(26, 145);
            this.btn_Esignature.Name = "btn_Esignature";
            this.btn_Esignature.Size = new System.Drawing.Size(105, 38);
            this.btn_Esignature.TabIndex = 13;
            this.btn_Esignature.Tag = "SystemSetup";
            this.btn_Esignature.Text = "Electronic Signature";
            this.btn_Esignature.UseVisualStyleBackColor = true;
            this.btn_Esignature.Visible = false;
            this.btn_Esignature.Click += new System.EventHandler(this.Electronic_Signature);
            // 
            // btn_MF_Guide
            // 
            this.btn_MF_Guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MF_Guide.Location = new System.Drawing.Point(26, 233);
            this.btn_MF_Guide.Name = "btn_MF_Guide";
            this.btn_MF_Guide.Size = new System.Drawing.Size(105, 38);
            this.btn_MF_Guide.TabIndex = 14;
            this.btn_MF_Guide.Tag = "Mainframe";
            this.btn_MF_Guide.Text = "Guide";
            this.btn_MF_Guide.UseVisualStyleBackColor = true;
            this.btn_MF_Guide.Visible = false;
            this.btn_MF_Guide.Click += new System.EventHandler(this.Mainframe_Guides);
            // 
            // btn_Ping_IP
            // 
            this.btn_Ping_IP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ping_IP.Location = new System.Drawing.Point(26, 145);
            this.btn_Ping_IP.Name = "btn_Ping_IP";
            this.btn_Ping_IP.Size = new System.Drawing.Size(105, 38);
            this.btn_Ping_IP.TabIndex = 15;
            this.btn_Ping_IP.Tag = "Diagnostics";
            this.btn_Ping_IP.Text = "Ping IP Address";
            this.btn_Ping_IP.UseVisualStyleBackColor = true;
            this.btn_Ping_IP.Visible = false;
            this.btn_Ping_IP.Click += new System.EventHandler(this.ping_ipaddress);
            // 
            // btn_SFC
            // 
            this.btn_SFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SFC.Location = new System.Drawing.Point(26, 200);
            this.btn_SFC.Name = "btn_SFC";
            this.btn_SFC.Size = new System.Drawing.Size(105, 38);
            this.btn_SFC.TabIndex = 21;
            this.btn_SFC.Tag = "Diagnostics";
            this.btn_SFC.Text = "SFC Scan";
            this.btn_SFC.UseVisualStyleBackColor = true;
            this.btn_SFC.Visible = false;
            this.btn_SFC.Click += new System.EventHandler(this.SFC_Scan);
            // 
            // btn_DISM
            // 
            this.btn_DISM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DISM.Location = new System.Drawing.Point(26, 261);
            this.btn_DISM.Name = "btn_DISM";
            this.btn_DISM.Size = new System.Drawing.Size(105, 38);
            this.btn_DISM.TabIndex = 22;
            this.btn_DISM.Tag = "Diagnostics";
            this.btn_DISM.Text = "DISM";
            this.btn_DISM.UseVisualStyleBackColor = true;
            this.btn_DISM.Visible = false;
            this.btn_DISM.Click += new System.EventHandler(this.DISM);
            // 
            // btn_blank_login
            // 
            this.btn_blank_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_blank_login.Location = new System.Drawing.Point(26, 189);
            this.btn_blank_login.Name = "btn_blank_login";
            this.btn_blank_login.Size = new System.Drawing.Size(105, 38);
            this.btn_blank_login.TabIndex = 23;
            this.btn_blank_login.Tag = "SystemSetup";
            this.btn_blank_login.Text = "Wipe Windows Logins";
            this.btn_blank_login.UseVisualStyleBackColor = true;
            this.btn_blank_login.Visible = false;
            this.btn_blank_login.Click += new System.EventHandler(this.Blank_Login);
            // 
            // btn_outlook_cache
            // 
            this.btn_outlook_cache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_outlook_cache.Location = new System.Drawing.Point(26, 282);
            this.btn_outlook_cache.Name = "btn_outlook_cache";
            this.btn_outlook_cache.Size = new System.Drawing.Size(105, 38);
            this.btn_outlook_cache.TabIndex = 24;
            this.btn_outlook_cache.Tag = "SystemSetup";
            this.btn_outlook_cache.Text = "Clear Outlook Cache";
            this.btn_outlook_cache.UseVisualStyleBackColor = true;
            this.btn_outlook_cache.Visible = false;
            this.btn_outlook_cache.Click += new System.EventHandler(this.Outlook_Cache_Removal);
            // 
            // btn_CCH_Deploy
            // 
            this.btn_CCH_Deploy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CCH_Deploy.Location = new System.Drawing.Point(26, 320);
            this.btn_CCH_Deploy.Name = "btn_CCH_Deploy";
            this.btn_CCH_Deploy.Size = new System.Drawing.Size(105, 38);
            this.btn_CCH_Deploy.TabIndex = 25;
            this.btn_CCH_Deploy.Tag = "Diagnostics";
            this.btn_CCH_Deploy.Text = "CCH Deploy Apps";
            this.btn_CCH_Deploy.UseVisualStyleBackColor = true;
            this.btn_CCH_Deploy.Visible = false;
            this.btn_CCH_Deploy.Click += new System.EventHandler(this.CCH_Deploy);
            // 
            // btn_MF_PS_Printer_Data
            // 
            this.btn_MF_PS_Printer_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MF_PS_Printer_Data.Location = new System.Drawing.Point(26, 189);
            this.btn_MF_PS_Printer_Data.Name = "btn_MF_PS_Printer_Data";
            this.btn_MF_PS_Printer_Data.Size = new System.Drawing.Size(105, 38);
            this.btn_MF_PS_Printer_Data.TabIndex = 26;
            this.btn_MF_PS_Printer_Data.Tag = "Mainframe";
            this.btn_MF_PS_Printer_Data.Text = "Clear PS_PrinterData";
            this.btn_MF_PS_Printer_Data.UseVisualStyleBackColor = true;
            this.btn_MF_PS_Printer_Data.Visible = false;
            this.btn_MF_PS_Printer_Data.Click += new System.EventHandler(this.Clear_PS_PrinterData);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnMainframe);
            this.panel1.Controls.Add(this.btnSystemSetup);
            this.panel1.Controls.Add(this.btnDiagnostics);
            this.panel1.Controls.Add(this.btnDataRecovery);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.programicon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 452);
            this.panel1.TabIndex = 27;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // programicon
            // 
            this.programicon.Controls.Add(this.programName);
            this.programicon.Controls.Add(this.Subtitle);
            this.programicon.Controls.Add(this.pictureBox2);
            this.programicon.Dock = System.Windows.Forms.DockStyle.Top;
            this.programicon.Location = new System.Drawing.Point(0, 0);
            this.programicon.Name = "programicon";
            this.programicon.Size = new System.Drawing.Size(186, 144);
            this.programicon.TabIndex = 0;
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.programName.Location = new System.Drawing.Point(39, 97);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(103, 16);
            this.programName.TabIndex = 1;
            this.programName.Text = "DIT Helpdesk";
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.Subtitle.Location = new System.Drawing.Point(58, 113);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(56, 12);
            this.Subtitle.TabIndex = 2;
            this.Subtitle.Text = "Runetonic";
            // 
            // btnBackup_User_Data
            // 
            this.btnBackup_User_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup_User_Data.Location = new System.Drawing.Point(26, 87);
            this.btnBackup_User_Data.Name = "btnBackup_User_Data";
            this.btnBackup_User_Data.Size = new System.Drawing.Size(105, 38);
            this.btnBackup_User_Data.TabIndex = 0;
            this.btnBackup_User_Data.Tag = "DataRecovery";
            this.btnBackup_User_Data.Text = "Backup User Data";
            this.btnBackup_User_Data.UseVisualStyleBackColor = true;
            this.btnBackup_User_Data.Visible = false;
            this.btnBackup_User_Data.Click += new System.EventHandler(this.Backup_Data);
            // 
            // Master
            // 
            this.Master.Controls.Add(this.Diagnostics);
            this.Master.Controls.Add(this.SystemSetup);
            this.Master.Controls.Add(this.Mainframe);
            this.Master.Controls.Add(this.Settings);
            this.Master.Controls.Add(this.Home);
            this.Master.Controls.Add(this.DataRecovery);
            this.Master.Location = new System.Drawing.Point(192, 12);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(611, 430);
            this.Master.TabIndex = 28;
            // 
            // DataRecovery
            // 
            this.DataRecovery.AutoSize = true;
            this.DataRecovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.DataRecovery.Controls.Add(this.label2);
            this.DataRecovery.Controls.Add(this.warning_printers);
            this.DataRecovery.Controls.Add(this.DESC_Restore_Printers);
            this.DataRecovery.Controls.Add(this.DESC_Backup_Printers);
            this.DataRecovery.Controls.Add(this.DESC_Restore_User_Data);
            this.DataRecovery.Controls.Add(this.Desc_Backup_User_Data);
            this.DataRecovery.Controls.Add(this.Title_Data_Recovery);
            this.DataRecovery.Controls.Add(this.btnBackup_User_Data);
            this.DataRecovery.Controls.Add(this.btn_Restore_User_Data);
            this.DataRecovery.Controls.Add(this.btn_Backup_Printers);
            this.DataRecovery.Controls.Add(this.btn_Restore_Printers);
            this.DataRecovery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataRecovery.Location = new System.Drawing.Point(0, 0);
            this.DataRecovery.Name = "DataRecovery";
            this.DataRecovery.Size = new System.Drawing.Size(611, 430);
            this.DataRecovery.TabIndex = 29;
            this.DataRecovery.Tag = "DataRecovery";
            this.DataRecovery.Visible = false;
            // 
            // DESC_Restore_User_Data
            // 
            this.DESC_Restore_User_Data.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_Restore_User_Data.Location = new System.Drawing.Point(139, 161);
            this.DESC_Restore_User_Data.Name = "DESC_Restore_User_Data";
            this.DESC_Restore_User_Data.Size = new System.Drawing.Size(449, 38);
            this.DESC_Restore_User_Data.TabIndex = 14;
            this.DESC_Restore_User_Data.Text = "Restores user Documents, Downloads, Pictures, Videos, Outlook PSTs, Outlook signa" +
    "tures, and Printers";
            // 
            // Desc_Backup_User_Data
            // 
            this.Desc_Backup_User_Data.ForeColor = System.Drawing.Color.BurlyWood;
            this.Desc_Backup_User_Data.Location = new System.Drawing.Point(138, 87);
            this.Desc_Backup_User_Data.Name = "Desc_Backup_User_Data";
            this.Desc_Backup_User_Data.Size = new System.Drawing.Size(450, 39);
            this.Desc_Backup_User_Data.TabIndex = 13;
            this.Desc_Backup_User_Data.Text = "Backs up user Documents, Downloads, Pictures, Videos, Outlook PSTs, Outlook Signa" +
    "tures, and Printers";
            this.Desc_Backup_User_Data.Click += new System.EventHandler(this.Desc_Backup_User_Data_Click);
            // 
            // Title_Data_Recovery
            // 
            this.Title_Data_Recovery.AutoSize = true;
            this.Title_Data_Recovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Data_Recovery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_Data_Recovery.Location = new System.Drawing.Point(20, 17);
            this.Title_Data_Recovery.Name = "Title_Data_Recovery";
            this.Title_Data_Recovery.Size = new System.Drawing.Size(213, 32);
            this.Title_Data_Recovery.TabIndex = 12;
            this.Title_Data_Recovery.Text = "Data Recovery";
            // 
            // Diagnostics
            // 
            this.Diagnostics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Diagnostics.Controls.Add(this.DESC_CCH_Deploy);
            this.Diagnostics.Controls.Add(this.DESC_DISM);
            this.Diagnostics.Controls.Add(this.DESC_SFC);
            this.Diagnostics.Controls.Add(this.DESC_Ping);
            this.Diagnostics.Controls.Add(this.DESC_Check_User_Account);
            this.Diagnostics.Controls.Add(this.Title_Diagnostics);
            this.Diagnostics.Controls.Add(this.btn_Check_User_Accounts);
            this.Diagnostics.Controls.Add(this.btn_Ping_IP);
            this.Diagnostics.Controls.Add(this.btn_SFC);
            this.Diagnostics.Controls.Add(this.btn_DISM);
            this.Diagnostics.Controls.Add(this.btn_CCH_Deploy);
            this.Diagnostics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Diagnostics.Location = new System.Drawing.Point(0, 0);
            this.Diagnostics.Name = "Diagnostics";
            this.Diagnostics.Size = new System.Drawing.Size(611, 430);
            this.Diagnostics.TabIndex = 28;
            this.Diagnostics.Tag = "Diagnostics";
            this.Diagnostics.Visible = false;
            // 
            // Title_Diagnostics
            // 
            this.Title_Diagnostics.AutoSize = true;
            this.Title_Diagnostics.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Diagnostics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_Diagnostics.Location = new System.Drawing.Point(20, 17);
            this.Title_Diagnostics.Name = "Title_Diagnostics";
            this.Title_Diagnostics.Size = new System.Drawing.Size(173, 32);
            this.Title_Diagnostics.TabIndex = 26;
            this.Title_Diagnostics.Text = "Diagnostics";
            // 
            // SystemSetup
            // 
            this.SystemSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SystemSetup.Controls.Add(this.Title_SystemSetup);
            this.SystemSetup.Controls.Add(this.btn_Paperport);
            this.SystemSetup.Controls.Add(this.btn_Esignature);
            this.SystemSetup.Controls.Add(this.btn_blank_login);
            this.SystemSetup.Controls.Add(this.btn_Firewall);
            this.SystemSetup.Controls.Add(this.btn_outlook_cache);
            this.SystemSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemSetup.Location = new System.Drawing.Point(0, 0);
            this.SystemSetup.Name = "SystemSetup";
            this.SystemSetup.Size = new System.Drawing.Size(611, 430);
            this.SystemSetup.TabIndex = 30;
            this.SystemSetup.Tag = "SystemSetup";
            this.SystemSetup.Visible = false;
            // 
            // Title_SystemSetup
            // 
            this.Title_SystemSetup.AutoSize = true;
            this.Title_SystemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_SystemSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_SystemSetup.Location = new System.Drawing.Point(20, 17);
            this.Title_SystemSetup.Name = "Title_SystemSetup";
            this.Title_SystemSetup.Size = new System.Drawing.Size(202, 32);
            this.Title_SystemSetup.TabIndex = 25;
            this.Title_SystemSetup.Text = "System Setup";
            // 
            // Mainframe
            // 
            this.Mainframe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Mainframe.Controls.Add(this.Title_Mainframe);
            this.Mainframe.Controls.Add(this.btn_MF_Unsuspend);
            this.Mainframe.Controls.Add(this.btn_MF_PW_Reset);
            this.Mainframe.Controls.Add(this.btn_MF_PS_Printer_Data);
            this.Mainframe.Controls.Add(this.btn_MF_Guide);
            this.Mainframe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainframe.Location = new System.Drawing.Point(0, 0);
            this.Mainframe.Name = "Mainframe";
            this.Mainframe.Size = new System.Drawing.Size(611, 430);
            this.Mainframe.TabIndex = 31;
            this.Mainframe.Tag = "Mainframe";
            this.Mainframe.Visible = false;
            // 
            // Title_Mainframe
            // 
            this.Title_Mainframe.AutoSize = true;
            this.Title_Mainframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Mainframe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_Mainframe.Location = new System.Drawing.Point(20, 17);
            this.Title_Mainframe.Name = "Title_Mainframe";
            this.Title_Mainframe.Size = new System.Drawing.Size(157, 32);
            this.Title_Mainframe.TabIndex = 27;
            this.Title_Mainframe.Text = "Mainframe";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Settings.Controls.Add(this.Title_Settings);
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(611, 430);
            this.Settings.TabIndex = 32;
            this.Settings.Tag = "Settings";
            this.Settings.Visible = false;
            // 
            // Title_Settings
            // 
            this.Title_Settings.AutoSize = true;
            this.Title_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_Settings.Location = new System.Drawing.Point(20, 17);
            this.Title_Settings.Name = "Title_Settings";
            this.Title_Settings.Size = new System.Drawing.Size(126, 32);
            this.Title_Settings.TabIndex = 13;
            this.Title_Settings.Text = "Settings";
            // 
            // Home
            // 
            this.Home.Controls.Add(this.Title_Home);
            this.Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(611, 430);
            this.Home.TabIndex = 27;
            this.Home.Tag = "Home";
            this.Home.Visible = false;
            // 
            // Title_Home
            // 
            this.Title_Home.AutoSize = true;
            this.Title_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.Title_Home.Location = new System.Drawing.Point(20, 17);
            this.Title_Home.Name = "Title_Home";
            this.Title_Home.Size = new System.Drawing.Size(93, 32);
            this.Title_Home.TabIndex = 0;
            this.Title_Home.Text = "Home";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DESC_Backup_Printers
            // 
            this.DESC_Backup_Printers.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_Backup_Printers.Location = new System.Drawing.Point(139, 233);
            this.DESC_Backup_Printers.Name = "DESC_Backup_Printers";
            this.DESC_Backup_Printers.Size = new System.Drawing.Size(449, 48);
            this.DESC_Backup_Printers.TabIndex = 15;
            this.DESC_Backup_Printers.Text = resources.GetString("DESC_Backup_Printers.Text");
            // 
            // DESC_Restore_Printers
            // 
            this.DESC_Restore_Printers.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_Restore_Printers.Location = new System.Drawing.Point(139, 304);
            this.DESC_Restore_Printers.Name = "DESC_Restore_Printers";
            this.DESC_Restore_Printers.Size = new System.Drawing.Size(449, 38);
            this.DESC_Restore_Printers.TabIndex = 16;
            this.DESC_Restore_Printers.Text = "Restores printers and drivers from the previously backed up PrinterExport.export " +
    "file in the users/printers folder.";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DIT_AIO.Properties.Resources.minimize;
            this.button1.Location = new System.Drawing.Point(740, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Image = global::DIT_AIO.Properties.Resources.exit;
            this.exit_button.Location = new System.Drawing.Point(770, 10);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(29, 26);
            this.exit_button.TabIndex = 13;
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::DIT_AIO.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 410);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnMainframe
            // 
            this.btnMainframe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainframe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainframe.FlatAppearance.BorderSize = 0;
            this.btnMainframe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainframe.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainframe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMainframe.Image = global::DIT_AIO.Properties.Resources.mainframe;
            this.btnMainframe.Location = new System.Drawing.Point(0, 312);
            this.btnMainframe.Name = "btnMainframe";
            this.btnMainframe.Size = new System.Drawing.Size(186, 42);
            this.btnMainframe.TabIndex = 1;
            this.btnMainframe.Text = "Mainframe";
            this.btnMainframe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainframe.UseVisualStyleBackColor = true;
            // 
            // btnSystemSetup
            // 
            this.btnSystemSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemSetup.FlatAppearance.BorderSize = 0;
            this.btnSystemSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSetup.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSystemSetup.Image = global::DIT_AIO.Properties.Resources.system;
            this.btnSystemSetup.Location = new System.Drawing.Point(0, 270);
            this.btnSystemSetup.Name = "btnSystemSetup";
            this.btnSystemSetup.Size = new System.Drawing.Size(186, 42);
            this.btnSystemSetup.TabIndex = 1;
            this.btnSystemSetup.Text = "System Setup";
            this.btnSystemSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemSetup.UseVisualStyleBackColor = true;
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiagnostics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnostics.FlatAppearance.BorderSize = 0;
            this.btnDiagnostics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDiagnostics.Image = global::DIT_AIO.Properties.Resources.datarecov;
            this.btnDiagnostics.Location = new System.Drawing.Point(0, 228);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(186, 42);
            this.btnDiagnostics.TabIndex = 1;
            this.btnDiagnostics.Text = "Diagnostics";
            this.btnDiagnostics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiagnostics.UseVisualStyleBackColor = true;
            // 
            // btnDataRecovery
            // 
            this.btnDataRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataRecovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataRecovery.FlatAppearance.BorderSize = 0;
            this.btnDataRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataRecovery.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataRecovery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDataRecovery.Image = global::DIT_AIO.Properties.Resources.diag;
            this.btnDataRecovery.Location = new System.Drawing.Point(0, 186);
            this.btnDataRecovery.Name = "btnDataRecovery";
            this.btnDataRecovery.Size = new System.Drawing.Size(186, 42);
            this.btnDataRecovery.TabIndex = 1;
            this.btnDataRecovery.Text = "Data Recovery";
            this.btnDataRecovery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataRecovery.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::DIT_AIO.Properties.Resources.Home;
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Home";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DIT_AIO.Properties.Resources._1237969505477722112;
            this.pictureBox2.Location = new System.Drawing.Point(60, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // warning_printers
            // 
            this.warning_printers.Image = global::DIT_AIO.Properties.Resources.warning;
            this.warning_printers.Location = new System.Drawing.Point(106, 357);
            this.warning_printers.Name = "warning_printers";
            this.warning_printers.Size = new System.Drawing.Size(40, 39);
            this.warning_printers.TabIndex = 17;
            this.warning_printers.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(152, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sometimes printers fail to restore when going across windows versions. Always dou" +
    "ble check if it was successful!";
            // 
            // DESC_Check_User_Account
            // 
            this.DESC_Check_User_Account.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_Check_User_Account.Location = new System.Drawing.Point(139, 88);
            this.DESC_Check_User_Account.Name = "DESC_Check_User_Account";
            this.DESC_Check_User_Account.Size = new System.Drawing.Size(449, 38);
            this.DESC_Check_User_Account.TabIndex = 27;
            this.DESC_Check_User_Account.Text = "Opens cmd and utilizes the netuser command to check active directory. It highligh" +
    "ts key information such as locked accounts, inactive accounts, and checks VPN / " +
    "Telework roles";
            // 
            // DESC_Ping
            // 
            this.DESC_Ping.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_Ping.Location = new System.Drawing.Point(139, 148);
            this.DESC_Ping.Name = "DESC_Ping";
            this.DESC_Ping.Size = new System.Drawing.Size(449, 38);
            this.DESC_Ping.TabIndex = 28;
            this.DESC_Ping.Text = "Opens cmd and lets you type an IP Address in. It checks if it can ping the addres" +
    "s and after it finishes it loops if more addresses need to be checked.";
            // 
            // DESC_SFC
            // 
            this.DESC_SFC.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_SFC.Location = new System.Drawing.Point(139, 202);
            this.DESC_SFC.Name = "DESC_SFC";
            this.DESC_SFC.Size = new System.Drawing.Size(449, 38);
            this.DESC_SFC.TabIndex = 29;
            this.DESC_SFC.Text = "Opens cmd and runs the /sfc scannow command. This checks windows for corruption a" +
    "nd it is recommended to run DISM afterwards.";
            // 
            // DESC_DISM
            // 
            this.DESC_DISM.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_DISM.Location = new System.Drawing.Point(139, 266);
            this.DESC_DISM.Name = "DESC_DISM";
            this.DESC_DISM.Size = new System.Drawing.Size(449, 38);
            this.DESC_DISM.TabIndex = 30;
            this.DESC_DISM.Text = "Opens cmd and runs the /DISM command. This usually helps resolve windows operatin" +
    "g system issues and windows update.";
            // 
            // DESC_CCH_Deploy
            // 
            this.DESC_CCH_Deploy.ForeColor = System.Drawing.Color.BurlyWood;
            this.DESC_CCH_Deploy.Location = new System.Drawing.Point(139, 320);
            this.DESC_CCH_Deploy.Name = "DESC_CCH_Deploy";
            this.DESC_CCH_Deploy.Size = new System.Drawing.Size(449, 38);
            this.DESC_CCH_Deploy.TabIndex = 31;
            this.DESC_CCH_Deploy.Text = "Connects to the network drive and opens up the CCH Deployment Server. This is han" +
    "dy for installing all the applications we use during our windows images.";
            // 
            // Runetonic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(810, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Master);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Runetonic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runetonic";
            this.panel1.ResumeLayout(false);
            this.programicon.ResumeLayout(false);
            this.programicon.PerformLayout();
            this.Master.ResumeLayout(false);
            this.Master.PerformLayout();
            this.DataRecovery.ResumeLayout(false);
            this.DataRecovery.PerformLayout();
            this.Diagnostics.ResumeLayout(false);
            this.Diagnostics.PerformLayout();
            this.SystemSetup.ResumeLayout(false);
            this.SystemSetup.PerformLayout();
            this.Mainframe.ResumeLayout(false);
            this.Mainframe.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning_printers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Restore_User_Data;
        private System.Windows.Forms.Button btn_Firewall;
        private System.Windows.Forms.Button btn_Check_User_Accounts;
        private System.Windows.Forms.Button btn_MF_Unsuspend;
        private System.Windows.Forms.Button btn_MF_PW_Reset;
        private System.Windows.Forms.Button btn_Backup_Printers;
        private System.Windows.Forms.Button btn_Restore_Printers;
        private System.Windows.Forms.Button btn_Paperport;
        private System.Windows.Forms.Button btn_Esignature;
        private System.Windows.Forms.Button btn_MF_Guide;
        private System.Windows.Forms.Button btn_Ping_IP;
        private System.Windows.Forms.Button btn_SFC;
        private System.Windows.Forms.Button btn_DISM;
        private System.Windows.Forms.Button btn_blank_login;
        private System.Windows.Forms.Button btn_outlook_cache;
        private System.Windows.Forms.Button btn_CCH_Deploy;
        private System.Windows.Forms.Button btn_MF_PS_Printer_Data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel programicon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSystemSetup;
        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.Button btnDataRecovery;
        private System.Windows.Forms.Button btnMainframe;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnBackup_User_Data;
        private System.Windows.Forms.Panel Master;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Panel DataRecovery;
        private System.Windows.Forms.Panel Diagnostics;
        private System.Windows.Forms.Panel SystemSetup;
        private System.Windows.Forms.Panel Mainframe;
        private System.Windows.Forms.Panel Settings;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Title_Home;
        private System.Windows.Forms.Label Title_Data_Recovery;
        private System.Windows.Forms.Label Title_Mainframe;
        private System.Windows.Forms.Label Title_Diagnostics;
        private System.Windows.Forms.Label Title_SystemSetup;
        private System.Windows.Forms.Label Title_Settings;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DESC_Restore_User_Data;
        private System.Windows.Forms.Label Desc_Backup_User_Data;
        private System.Windows.Forms.Label DESC_Restore_Printers;
        private System.Windows.Forms.Label DESC_Backup_Printers;
        private System.Windows.Forms.PictureBox warning_printers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DESC_Check_User_Account;
        private System.Windows.Forms.Label DESC_Ping;
        private System.Windows.Forms.Label DESC_SFC;
        private System.Windows.Forms.Label DESC_CCH_Deploy;
        private System.Windows.Forms.Label DESC_DISM;
    }
}

