namespace Win10Clean
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabMetro = new System.Windows.Forms.TabPage();
            this.appPanel = new System.Windows.Forms.Panel();
            this.appBox = new System.Windows.Forms.CheckedListBox();
            this.UninstallBtn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.aboutBox = new System.Windows.Forms.RichTextBox();
            this.toggleSwitch7 = new Win10Clean.ToggleSwitch();
            this.btnOneDrive = new Win10Clean.ToggleSwitch();
            this.btnStartAds = new Win10Clean.ToggleSwitch();
            this.btnSilentAppInstall = new Win10Clean.ToggleSwitch();
            this.btnHomeGroup = new Win10Clean.ToggleSwitch();
            this.toggleSwitch2 = new Win10Clean.ToggleSwitch();
            this.btnDefender = new Win10Clean.ToggleSwitch();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabMetro.SuspendLayout();
            this.appPanel.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabMetro);
            this.tabControl1.Controls.Add(this.tabConsole);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.toggleSwitch7);
            this.tabHome.Controls.Add(this.btnOneDrive);
            this.tabHome.Controls.Add(this.btnStartAds);
            this.tabHome.Controls.Add(this.btnSilentAppInstall);
            this.tabHome.Controls.Add(this.btnHomeGroup);
            this.tabHome.Controls.Add(this.toggleSwitch2);
            this.tabHome.Controls.Add(this.btnDefender);
            this.tabHome.Controls.Add(this.btnExit);
            this.tabHome.Controls.Add(this.btnUpdate);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(644, 444);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Location = new System.Drawing.Point(557, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 40);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Location = new System.Drawing.Point(472, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabMetro
            // 
            this.tabMetro.Controls.Add(this.appPanel);
            this.tabMetro.Controls.Add(this.UninstallBtn);
            this.tabMetro.Controls.Add(this.btnRefresh);
            this.tabMetro.Controls.Add(this.chkDelete);
            this.tabMetro.Controls.Add(this.chkAll);
            this.tabMetro.Location = new System.Drawing.Point(4, 25);
            this.tabMetro.Name = "tabMetro";
            this.tabMetro.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetro.Size = new System.Drawing.Size(644, 444);
            this.tabMetro.TabIndex = 1;
            this.tabMetro.Text = "Win10 / metro apps";
            this.tabMetro.UseVisualStyleBackColor = true;
            this.tabMetro.Enter += new System.EventHandler(this.tabMetro_Enter);
            // 
            // appPanel
            // 
            this.appPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appPanel.Controls.Add(this.appBox);
            this.appPanel.Location = new System.Drawing.Point(6, 6);
            this.appPanel.Name = "appPanel";
            this.appPanel.Size = new System.Drawing.Size(468, 426);
            this.appPanel.TabIndex = 12;
            // 
            // appBox
            // 
            this.appBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appBox.CheckOnClick = true;
            this.appBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appBox.FormattingEnabled = true;
            this.appBox.Location = new System.Drawing.Point(0, 0);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(466, 424);
            this.appBox.TabIndex = 0;
            // 
            // UninstallBtn
            // 
            this.UninstallBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UninstallBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.UninstallBtn.Location = new System.Drawing.Point(480, 135);
            this.UninstallBtn.Name = "UninstallBtn";
            this.UninstallBtn.Size = new System.Drawing.Size(79, 40);
            this.UninstallBtn.TabIndex = 11;
            this.UninstallBtn.Text = "Uninstall";
            this.UninstallBtn.UseVisualStyleBackColor = true;
            this.UninstallBtn.Click += new System.EventHandler(this.UninstallBtn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.Location = new System.Drawing.Point(480, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Enabled = false;
            this.chkDelete.Location = new System.Drawing.Point(480, 36);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(115, 21);
            this.chkDelete.TabIndex = 2;
            this.chkDelete.Text = "Fully uninstall";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(480, 6);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(84, 21);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "All users";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.btnExport);
            this.tabConsole.Controls.Add(this.consoleBox);
            this.tabConsole.Location = new System.Drawing.Point(4, 25);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(644, 444);
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExport.Location = new System.Drawing.Point(557, 392);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(79, 40);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Location = new System.Drawing.Point(8, 6);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(628, 380);
            this.consoleBox.TabIndex = 0;
            this.consoleBox.Text = "";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.aboutBox);
            this.tabAbout.Location = new System.Drawing.Point(4, 25);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(644, 444);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // aboutBox
            // 
            this.aboutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutBox.Location = new System.Drawing.Point(3, 3);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.ReadOnly = true;
            this.aboutBox.Size = new System.Drawing.Size(638, 438);
            this.aboutBox.TabIndex = 1;
            this.aboutBox.Text = resources.GetString("aboutBox.Text");
            // 
            // toggleSwitch7
            // 
            this.toggleSwitch7.Location = new System.Drawing.Point(314, 131);
            this.toggleSwitch7.Name = "toggleSwitch7";
            this.toggleSwitch7.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch7.OffText = "Cleanup Context Menus";
            this.toggleSwitch7.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch7.OnText = "Cleanup Context Menus";
            this.toggleSwitch7.Size = new System.Drawing.Size(286, 44);
            this.toggleSwitch7.TabIndex = 16;
            // 
            // btnOneDrive
            // 
            this.btnOneDrive.Location = new System.Drawing.Point(314, 81);
            this.btnOneDrive.Name = "btnOneDrive";
            this.btnOneDrive.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDrive.OffText = "Uninstall OneDrive";
            this.btnOneDrive.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDrive.OnText = "Uninstall OneDrive";
            this.btnOneDrive.Size = new System.Drawing.Size(286, 44);
            this.btnOneDrive.TabIndex = 15;
            this.btnOneDrive.Click += new System.EventHandler(this.btnOneDrive_Click);
            // 
            // btnStartAds
            // 
            this.btnStartAds.Location = new System.Drawing.Point(314, 31);
            this.btnStartAds.Name = "btnStartAds";
            this.btnStartAds.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAds.OffText = "Disable Start Menu Ads";
            this.btnStartAds.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAds.OnText = "Disable Start Menu Ads";
            this.btnStartAds.Size = new System.Drawing.Size(286, 44);
            this.btnStartAds.TabIndex = 14;
            this.btnStartAds.Click += new System.EventHandler(this.btnStartAds_Click);
            // 
            // btnSilentAppInstall
            // 
            this.btnSilentAppInstall.Location = new System.Drawing.Point(22, 181);
            this.btnSilentAppInstall.Name = "btnSilentAppInstall";
            this.btnSilentAppInstall.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilentAppInstall.OffText = "Don\'t Reinstall Modern Apps";
            this.btnSilentAppInstall.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilentAppInstall.OnText = "Don\'t Reinstall Modern Apps";
            this.btnSilentAppInstall.Size = new System.Drawing.Size(286, 44);
            this.btnSilentAppInstall.TabIndex = 13;
            this.btnSilentAppInstall.Click += new System.EventHandler(this.btnSilentAppInstall_Click);
            // 
            // btnHomeGroup
            // 
            this.btnHomeGroup.Location = new System.Drawing.Point(22, 131);
            this.btnHomeGroup.Name = "btnHomeGroup";
            this.btnHomeGroup.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGroup.OffText = "Disable HomeGroup Service";
            this.btnHomeGroup.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeGroup.OnText = "Disable HomeGroup Service";
            this.btnHomeGroup.Size = new System.Drawing.Size(286, 44);
            this.btnHomeGroup.TabIndex = 12;
            this.btnHomeGroup.Click += new System.EventHandler(this.btnHomeGroup_Click);
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.Location = new System.Drawing.Point(22, 81);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch2.OffText = "Revert Explorer to Windows 7 Style";
            this.toggleSwitch2.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch2.OnText = "Revert Explorer to Windows 7 Style";
            this.toggleSwitch2.Size = new System.Drawing.Size(286, 44);
            this.toggleSwitch2.TabIndex = 11;
            // 
            // btnDefender
            // 
            this.btnDefender.Location = new System.Drawing.Point(22, 31);
            this.btnDefender.Name = "btnDefender";
            this.btnDefender.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefender.OffText = "Disable Windows Defender";
            this.btnDefender.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefender.OnText = "Disable Windows Defender";
            this.btnDefender.Size = new System.Drawing.Size(286, 44);
            this.btnDefender.TabIndex = 10;
            this.btnDefender.Click += new System.EventHandler(this.btnDefender_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(652, 473);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win10Clean";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabMetro.ResumeLayout(false);
            this.tabMetro.PerformLayout();
            this.appPanel.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabMetro;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.RichTextBox aboutBox;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Panel appPanel;
        private System.Windows.Forms.Button UninstallBtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckedListBox appBox;
        private ToggleSwitch btnDefender;
        private ToggleSwitch toggleSwitch7;
        private ToggleSwitch btnOneDrive;
        private ToggleSwitch btnStartAds;
        private ToggleSwitch btnSilentAppInstall;
        private ToggleSwitch btnHomeGroup;
        private ToggleSwitch toggleSwitch2;
    }
}

