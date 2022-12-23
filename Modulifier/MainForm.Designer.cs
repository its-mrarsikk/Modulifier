namespace Modulifier
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.pipTab = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pip_other_update = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pip_packages_uninstall = new MetroFramework.Controls.MetroButton();
            this.pip_packages_download = new MetroFramework.Controls.MetroButton();
            this.pip_packages_install = new MetroFramework.Controls.MetroButton();
            this.pip_packages_title = new MetroFramework.Controls.MetroLabel();
            this.pip_welcome2 = new MetroFramework.Controls.MetroLabel();
            this.pip_welcome1 = new MetroFramework.Controls.MetroLabel();
            this.pip_welcomePic = new System.Windows.Forms.PictureBox();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.mainmenu_contribute3 = new MetroFramework.Controls.MetroLink();
            this.mainmenu_verticalSeparator = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_contribute2 = new MetroFramework.Controls.MetroLink();
            this.mainmenu_contribute1 = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_issue2 = new MetroFramework.Controls.MetroLink();
            this.mainmenu_issue1 = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_releases2 = new MetroFramework.Controls.MetroLink();
            this.mainmenu_releases1 = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_welcomeLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_welcomeLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mainmenu_welcomePic = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.name_1 = new MetroFramework.Controls.MetroLabel();
            this.name_2 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.pipTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pip_welcomePic)).BeginInit();
            this.mainMenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu_welcomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pipTab);
            this.tabControl.Controls.Add(this.mainMenuTab);
            this.tabControl.Location = new System.Drawing.Point(2, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(647, 406);
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pipTab
            // 
            this.pipTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pipTab.Controls.Add(this.metroButton1);
            this.pipTab.Controls.Add(this.pip_other_update);
            this.pipTab.Controls.Add(this.metroLabel1);
            this.pipTab.Controls.Add(this.pip_packages_uninstall);
            this.pipTab.Controls.Add(this.pip_packages_download);
            this.pipTab.Controls.Add(this.pip_packages_install);
            this.pipTab.Controls.Add(this.pip_packages_title);
            this.pipTab.Controls.Add(this.pip_welcome2);
            this.pipTab.Controls.Add(this.pip_welcome1);
            this.pipTab.Controls.Add(this.pip_welcomePic);
            this.pipTab.Location = new System.Drawing.Point(4, 35);
            this.pipTab.Name = "pipTab";
            this.pipTab.Size = new System.Drawing.Size(639, 367);
            this.pipTab.TabIndex = 1;
            this.pipTab.Text = "Python PIP";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(235, 255);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Other command...";
            // 
            // pip_other_update
            // 
            this.pip_other_update.Location = new System.Drawing.Point(150, 255);
            this.pip_other_update.Name = "pip_other_update";
            this.pip_other_update.Size = new System.Drawing.Size(79, 23);
            this.pip_other_update.TabIndex = 8;
            this.pip_other_update.Text = "Update PIP";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(145, 227);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Other";
            // 
            // pip_packages_uninstall
            // 
            this.pip_packages_uninstall.Location = new System.Drawing.Point(303, 162);
            this.pip_packages_uninstall.Name = "pip_packages_uninstall";
            this.pip_packages_uninstall.Size = new System.Drawing.Size(78, 23);
            this.pip_packages_uninstall.TabIndex = 6;
            this.pip_packages_uninstall.Text = "Uninstall";
            // 
            // pip_packages_download
            // 
            this.pip_packages_download.Location = new System.Drawing.Point(219, 162);
            this.pip_packages_download.Name = "pip_packages_download";
            this.pip_packages_download.Size = new System.Drawing.Size(78, 23);
            this.pip_packages_download.TabIndex = 5;
            this.pip_packages_download.Text = "Download";
            // 
            // pip_packages_install
            // 
            this.pip_packages_install.Location = new System.Drawing.Point(150, 162);
            this.pip_packages_install.Name = "pip_packages_install";
            this.pip_packages_install.Size = new System.Drawing.Size(63, 23);
            this.pip_packages_install.TabIndex = 4;
            this.pip_packages_install.Text = "Install";
            // 
            // pip_packages_title
            // 
            this.pip_packages_title.AutoSize = true;
            this.pip_packages_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_packages_title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pip_packages_title.Location = new System.Drawing.Point(145, 136);
            this.pip_packages_title.Name = "pip_packages_title";
            this.pip_packages_title.Size = new System.Drawing.Size(84, 25);
            this.pip_packages_title.TabIndex = 3;
            this.pip_packages_title.Text = "Packages";
            // 
            // pip_welcome2
            // 
            this.pip_welcome2.AutoSize = true;
            this.pip_welcome2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_welcome2.Location = new System.Drawing.Point(145, 50);
            this.pip_welcome2.Name = "pip_welcome2";
            this.pip_welcome2.Size = new System.Drawing.Size(439, 75);
            this.pip_welcome2.TabIndex = 2;
            this.pip_welcome2.Text = "You can install or delete Python packages, seek for other\r\npackages on PyPi and u" +
    "pdate pip.\r\n";
            // 
            // pip_welcome1
            // 
            this.pip_welcome1.AutoSize = true;
            this.pip_welcome1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_welcome1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pip_welcome1.Location = new System.Drawing.Point(145, 25);
            this.pip_welcome1.Name = "pip_welcome1";
            this.pip_welcome1.Size = new System.Drawing.Size(173, 25);
            this.pip_welcome1.TabIndex = 1;
            this.pip_welcome1.Text = "Python PIP Manager";
            // 
            // pip_welcomePic
            // 
            this.pip_welcomePic.Image = ((System.Drawing.Image)(resources.GetObject("pip_welcomePic.Image")));
            this.pip_welcomePic.Location = new System.Drawing.Point(27, 25);
            this.pip_welcomePic.Name = "pip_welcomePic";
            this.pip_welcomePic.Size = new System.Drawing.Size(112, 106);
            this.pip_welcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pip_welcomePic.TabIndex = 0;
            this.pip_welcomePic.TabStop = false;
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainMenuTab.Controls.Add(this.mainmenu_contribute3);
            this.mainMenuTab.Controls.Add(this.mainmenu_verticalSeparator);
            this.mainMenuTab.Controls.Add(this.mainmenu_contribute2);
            this.mainMenuTab.Controls.Add(this.mainmenu_contribute1);
            this.mainMenuTab.Controls.Add(this.mainmenu_issue2);
            this.mainMenuTab.Controls.Add(this.mainmenu_issue1);
            this.mainMenuTab.Controls.Add(this.mainmenu_releases2);
            this.mainMenuTab.Controls.Add(this.mainmenu_releases1);
            this.mainMenuTab.Controls.Add(this.mainmenu_welcomeLabel2);
            this.mainMenuTab.Controls.Add(this.mainmenu_welcomeLabel1);
            this.mainMenuTab.Controls.Add(this.mainmenu_welcomePic);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 35);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Size = new System.Drawing.Size(192, 61);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.ToolTipText = "Main Menu";
            // 
            // mainmenu_contribute3
            // 
            this.mainmenu_contribute3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenu_contribute3.CustomForeColor = true;
            this.mainmenu_contribute3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_contribute3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_contribute3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainmenu_contribute3.Location = new System.Drawing.Point(307, 323);
            this.mainmenu_contribute3.Name = "mainmenu_contribute3";
            this.mainmenu_contribute3.Size = new System.Drawing.Size(197, 23);
            this.mainmenu_contribute3.TabIndex = 10;
            this.mainmenu_contribute3.Text = "Create a Pull Request on GitHub";
            this.mainmenu_contribute3.Click += new System.EventHandler(this.mainmenu_contribute3_Click);
            // 
            // mainmenu_verticalSeparator
            // 
            this.mainmenu_verticalSeparator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainmenu_verticalSeparator.CustomBackground = true;
            this.mainmenu_verticalSeparator.Location = new System.Drawing.Point(303, 328);
            this.mainmenu_verticalSeparator.Name = "mainmenu_verticalSeparator";
            this.mainmenu_verticalSeparator.Size = new System.Drawing.Size(1, 15);
            this.mainmenu_verticalSeparator.TabIndex = 9;
            this.mainmenu_verticalSeparator.Text = " ";
            // 
            // mainmenu_contribute2
            // 
            this.mainmenu_contribute2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenu_contribute2.CustomForeColor = true;
            this.mainmenu_contribute2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_contribute2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_contribute2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainmenu_contribute2.Location = new System.Drawing.Point(135, 323);
            this.mainmenu_contribute2.Name = "mainmenu_contribute2";
            this.mainmenu_contribute2.Size = new System.Drawing.Size(166, 23);
            this.mainmenu_contribute2.TabIndex = 8;
            this.mainmenu_contribute2.Text = "Fork this project on GitHub";
            this.mainmenu_contribute2.Click += new System.EventHandler(this.mainmenu_contribute2_Click);
            // 
            // mainmenu_contribute1
            // 
            this.mainmenu_contribute1.AutoSize = true;
            this.mainmenu_contribute1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_contribute1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_contribute1.Location = new System.Drawing.Point(134, 295);
            this.mainmenu_contribute1.Name = "mainmenu_contribute1";
            this.mainmenu_contribute1.Size = new System.Drawing.Size(183, 25);
            this.mainmenu_contribute1.TabIndex = 7;
            this.mainmenu_contribute1.Text = "Become a contributor";
            // 
            // mainmenu_issue2
            // 
            this.mainmenu_issue2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenu_issue2.CustomForeColor = true;
            this.mainmenu_issue2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_issue2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_issue2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainmenu_issue2.Location = new System.Drawing.Point(134, 253);
            this.mainmenu_issue2.Name = "mainmenu_issue2";
            this.mainmenu_issue2.Size = new System.Drawing.Size(359, 23);
            this.mainmenu_issue2.TabIndex = 6;
            this.mainmenu_issue2.Text = "See already shared issues and suggestions, and share yours!";
            this.mainmenu_issue2.Click += new System.EventHandler(this.mainmenu_issue2_Click);
            // 
            // mainmenu_issue1
            // 
            this.mainmenu_issue1.AutoSize = true;
            this.mainmenu_issue1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_issue1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_issue1.Location = new System.Drawing.Point(134, 225);
            this.mainmenu_issue1.Name = "mainmenu_issue1";
            this.mainmenu_issue1.Size = new System.Drawing.Size(196, 25);
            this.mainmenu_issue1.TabIndex = 5;
            this.mainmenu_issue1.Text = "Issues and suggestions";
            // 
            // mainmenu_releases2
            // 
            this.mainmenu_releases2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainmenu_releases2.CustomForeColor = true;
            this.mainmenu_releases2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_releases2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_releases2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainmenu_releases2.Location = new System.Drawing.Point(134, 184);
            this.mainmenu_releases2.Name = "mainmenu_releases2";
            this.mainmenu_releases2.Size = new System.Drawing.Size(204, 23);
            this.mainmenu_releases2.TabIndex = 4;
            this.mainmenu_releases2.Text = "Check for new versions available!";
            this.mainmenu_releases2.Click += new System.EventHandler(this.mainmenu_releases2_Click);
            // 
            // mainmenu_releases1
            // 
            this.mainmenu_releases1.AutoSize = true;
            this.mainmenu_releases1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_releases1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_releases1.Location = new System.Drawing.Point(134, 156);
            this.mainmenu_releases1.Name = "mainmenu_releases1";
            this.mainmenu_releases1.Size = new System.Drawing.Size(178, 25);
            this.mainmenu_releases1.TabIndex = 3;
            this.mainmenu_releases1.Text = "Get the latest version";
            // 
            // mainmenu_welcomeLabel2
            // 
            this.mainmenu_welcomeLabel2.AutoSize = true;
            this.mainmenu_welcomeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.mainmenu_welcomeLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_welcomeLabel2.Location = new System.Drawing.Point(134, 50);
            this.mainmenu_welcomeLabel2.Name = "mainmenu_welcomeLabel2";
            this.mainmenu_welcomeLabel2.Size = new System.Drawing.Size(501, 125);
            this.mainmenu_welcomeLabel2.TabIndex = 2;
            this.mainmenu_welcomeLabel2.Text = "This is the main menu. Use the tabs to navigate through modes. \r\nUse the below li" +
    "nks to contribute to this app, \r\nshare an issue or a suggestion, or to see new r" +
    "eleases.\r\n\r\n";
            // 
            // mainmenu_welcomeLabel1
            // 
            this.mainmenu_welcomeLabel1.AutoSize = true;
            this.mainmenu_welcomeLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_welcomeLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_welcomeLabel1.Location = new System.Drawing.Point(134, 25);
            this.mainmenu_welcomeLabel1.Name = "mainmenu_welcomeLabel1";
            this.mainmenu_welcomeLabel1.Size = new System.Drawing.Size(90, 25);
            this.mainmenu_welcomeLabel1.TabIndex = 1;
            this.mainmenu_welcomeLabel1.Text = "Welcome!";
            // 
            // mainmenu_welcomePic
            // 
            this.mainmenu_welcomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainmenu_welcomePic.Image = ((System.Drawing.Image)(resources.GetObject("mainmenu_welcomePic.Image")));
            this.mainmenu_welcomePic.Location = new System.Drawing.Point(27, 25);
            this.mainmenu_welcomePic.Name = "mainmenu_welcomePic";
            this.mainmenu_welcomePic.Size = new System.Drawing.Size(101, 92);
            this.mainmenu_welcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainmenu_welcomePic.TabIndex = 0;
            this.mainmenu_welcomePic.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(46, 49);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.name_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.name_1.Location = new System.Drawing.Point(64, 28);
            this.name_1.Name = "name_1";
            this.name_1.Size = new System.Drawing.Size(93, 25);
            this.name_1.TabIndex = 2;
            this.name_1.Text = "Modulifier";
            // 
            // name_2
            // 
            this.name_2.AutoSize = true;
            this.name_2.Location = new System.Drawing.Point(64, 51);
            this.name_2.Name = "name_2";
            this.name_2.Size = new System.Drawing.Size(188, 19);
            this.name_2.TabIndex = 3;
            this.name_2.Text = "Tool for fast package installing.";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(651, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBoxToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBoxToolStripMenuItem
            // 
            this.aboutBoxToolStripMenuItem.Name = "aboutBoxToolStripMenuItem";
            this.aboutBoxToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutBoxToolStripMenuItem.Text = "About";
            this.aboutBoxToolStripMenuItem.Click += new System.EventHandler(this.aboutBoxToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConsoleToolStripMenuItem,
            this.writeToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // openConsoleToolStripMenuItem
            // 
            this.openConsoleToolStripMenuItem.Name = "openConsoleToolStripMenuItem";
            this.openConsoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openConsoleToolStripMenuItem.Text = "Open";
            this.openConsoleToolStripMenuItem.Click += new System.EventHandler(this.openConsoleToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Enabled = false;
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 491);
            this.Controls.Add(this.name_2);
            this.Controls.Add(this.name_1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulifier Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.pipTab.ResumeLayout(false);
            this.pipTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pip_welcomePic)).EndInit();
            this.mainMenuTab.ResumeLayout(false);
            this.mainMenuTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainmenu_welcomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private TabPage mainMenuTab;
        private TabPage pipTab;
        private PictureBox logo;
        private MetroFramework.Controls.MetroLabel name_1;
        private MetroFramework.Controls.MetroLabel name_2;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem aboutBoxToolStripMenuItem;
        private PictureBox mainmenu_welcomePic;
        private MetroFramework.Controls.MetroLabel mainmenu_welcomeLabel1;
        private MetroFramework.Controls.MetroLabel mainmenu_welcomeLabel2;
        private MetroFramework.Controls.MetroLabel mainmenu_releases1;
        private MetroFramework.Controls.MetroLink mainmenu_releases2;
        private MetroFramework.Controls.MetroLink mainmenu_issue2;
        private MetroFramework.Controls.MetroLabel mainmenu_issue1;
        private MetroFramework.Controls.MetroLink mainmenu_contribute2;
        private MetroFramework.Controls.MetroLabel mainmenu_contribute1;
        private MetroFramework.Controls.MetroLink mainmenu_contribute3;
        private MetroFramework.Controls.MetroLabel mainmenu_verticalSeparator;
        private PictureBox pip_welcomePic;
        private MetroFramework.Controls.MetroLabel pip_welcome1;
        private MetroFramework.Controls.MetroLabel pip_welcome2;
        private MetroFramework.Controls.MetroButton pip_packages_install;
        private MetroFramework.Controls.MetroLabel pip_packages_title;
        private MetroFramework.Controls.MetroButton pip_packages_download;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton pip_other_update;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton pip_packages_uninstall;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem openConsoleToolStripMenuItem;
        private ToolStripMenuItem writeToolStripMenuItem;
    }
}