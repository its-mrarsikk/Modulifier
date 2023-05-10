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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.mainMenuTab = new TabPage();
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
            this.mainmenu_welcomePic = new PictureBox();
            this.pipTab = new TabPage();
            this.pip_other_cmd = new MetroFramework.Controls.MetroButton();
            this.pip_other_update = new MetroFramework.Controls.MetroButton();
            this.pip_other_title = new MetroFramework.Controls.MetroLabel();
            this.pip_packages_uninstall = new MetroFramework.Controls.MetroButton();
            this.pip_packages_download = new MetroFramework.Controls.MetroButton();
            this.pip_packages_install = new MetroFramework.Controls.MetroButton();
            this.pip_packages_title = new MetroFramework.Controls.MetroLabel();
            this.pip_welcome2 = new MetroFramework.Controls.MetroLabel();
            this.pip_welcome1 = new MetroFramework.Controls.MetroLabel();
            this.pip_welcomePic = new PictureBox();
            this.logo = new PictureBox();
            this.name_1 = new MetroFramework.Controls.MetroLabel();
            this.name_2 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.restartWithDebugToolStripMenuItem = new ToolStripMenuItem();
            this.quitToolStripMenuItem = new ToolStripMenuItem();
            this.manageToolStripMenuItem = new ToolStripMenuItem();
            this.aboutToolStripMenuItem = new ToolStripMenuItem();
            this.aboutBoxToolStripMenuItem = new ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            ((ISupportInitialize)this.mainmenu_welcomePic).BeginInit();
            this.pipTab.SuspendLayout();
            ((ISupportInitialize)this.pip_welcomePic).BeginInit();
            ((ISupportInitialize)this.logo).BeginInit();
            this.menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainMenuTab);
            this.tabControl.Controls.Add(this.pipTab);
            this.tabControl.Location = new Point(2, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new Point(6, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(647, 406);
            this.tabControl.SizeMode = TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.BackColor = SystemColors.ButtonHighlight;
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
            this.mainMenuTab.Location = new Point(4, 35);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Size = new Size(639, 367);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.ToolTipText = "Main Menu";
            // 
            // mainmenu_contribute3
            // 
            this.mainmenu_contribute3.Cursor = Cursors.Hand;
            this.mainmenu_contribute3.CustomForeColor = true;
            this.mainmenu_contribute3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_contribute3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_contribute3.ForeColor = SystemColors.Highlight;
            this.mainmenu_contribute3.Location = new Point(307, 323);
            this.mainmenu_contribute3.Name = "mainmenu_contribute3";
            this.mainmenu_contribute3.Size = new Size(197, 23);
            this.mainmenu_contribute3.TabIndex = 10;
            this.mainmenu_contribute3.Text = "Create a Pull Request on GitHub";
            this.mainmenu_contribute3.Click += mainmenu_contribute3_Click;
            // 
            // mainmenu_verticalSeparator
            // 
            this.mainmenu_verticalSeparator.BackColor = SystemColors.ActiveCaptionText;
            this.mainmenu_verticalSeparator.CustomBackground = true;
            this.mainmenu_verticalSeparator.Location = new Point(303, 328);
            this.mainmenu_verticalSeparator.Name = "mainmenu_verticalSeparator";
            this.mainmenu_verticalSeparator.Size = new Size(1, 15);
            this.mainmenu_verticalSeparator.TabIndex = 9;
            this.mainmenu_verticalSeparator.Text = " ";
            // 
            // mainmenu_contribute2
            // 
            this.mainmenu_contribute2.Cursor = Cursors.Hand;
            this.mainmenu_contribute2.CustomForeColor = true;
            this.mainmenu_contribute2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_contribute2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_contribute2.ForeColor = SystemColors.Highlight;
            this.mainmenu_contribute2.Location = new Point(135, 323);
            this.mainmenu_contribute2.Name = "mainmenu_contribute2";
            this.mainmenu_contribute2.Size = new Size(166, 23);
            this.mainmenu_contribute2.TabIndex = 8;
            this.mainmenu_contribute2.Text = "Fork this project on GitHub";
            this.mainmenu_contribute2.Click += mainmenu_contribute2_Click;
            // 
            // mainmenu_contribute1
            // 
            this.mainmenu_contribute1.AutoSize = true;
            this.mainmenu_contribute1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_contribute1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_contribute1.Location = new Point(134, 295);
            this.mainmenu_contribute1.Name = "mainmenu_contribute1";
            this.mainmenu_contribute1.Size = new Size(183, 25);
            this.mainmenu_contribute1.TabIndex = 7;
            this.mainmenu_contribute1.Text = "Become a contributor";
            // 
            // mainmenu_issue2
            // 
            this.mainmenu_issue2.Cursor = Cursors.Hand;
            this.mainmenu_issue2.CustomForeColor = true;
            this.mainmenu_issue2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_issue2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_issue2.ForeColor = SystemColors.Highlight;
            this.mainmenu_issue2.Location = new Point(134, 253);
            this.mainmenu_issue2.Name = "mainmenu_issue2";
            this.mainmenu_issue2.Size = new Size(359, 23);
            this.mainmenu_issue2.TabIndex = 6;
            this.mainmenu_issue2.Text = "See already shared issues and suggestions, and share yours!";
            this.mainmenu_issue2.Click += mainmenu_issue2_Click;
            // 
            // mainmenu_issue1
            // 
            this.mainmenu_issue1.AutoSize = true;
            this.mainmenu_issue1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_issue1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_issue1.Location = new Point(134, 225);
            this.mainmenu_issue1.Name = "mainmenu_issue1";
            this.mainmenu_issue1.Size = new Size(196, 25);
            this.mainmenu_issue1.TabIndex = 5;
            this.mainmenu_issue1.Text = "Issues and suggestions";
            // 
            // mainmenu_releases2
            // 
            this.mainmenu_releases2.Cursor = Cursors.Hand;
            this.mainmenu_releases2.CustomForeColor = true;
            this.mainmenu_releases2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mainmenu_releases2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mainmenu_releases2.ForeColor = SystemColors.Highlight;
            this.mainmenu_releases2.Location = new Point(134, 184);
            this.mainmenu_releases2.Name = "mainmenu_releases2";
            this.mainmenu_releases2.Size = new Size(204, 23);
            this.mainmenu_releases2.TabIndex = 4;
            this.mainmenu_releases2.Text = "Check for new versions available!";
            this.mainmenu_releases2.Click += mainmenu_releases2_Click;
            // 
            // mainmenu_releases1
            // 
            this.mainmenu_releases1.AutoSize = true;
            this.mainmenu_releases1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_releases1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_releases1.Location = new Point(134, 156);
            this.mainmenu_releases1.Name = "mainmenu_releases1";
            this.mainmenu_releases1.Size = new Size(178, 25);
            this.mainmenu_releases1.TabIndex = 3;
            this.mainmenu_releases1.Text = "Get the latest version";
            // 
            // mainmenu_welcomeLabel2
            // 
            this.mainmenu_welcomeLabel2.AutoSize = true;
            this.mainmenu_welcomeLabel2.BackColor = Color.Transparent;
            this.mainmenu_welcomeLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_welcomeLabel2.Location = new Point(134, 50);
            this.mainmenu_welcomeLabel2.Name = "mainmenu_welcomeLabel2";
            this.mainmenu_welcomeLabel2.Size = new Size(501, 125);
            this.mainmenu_welcomeLabel2.TabIndex = 2;
            this.mainmenu_welcomeLabel2.Text = "This is the main menu. Use the tabs to navigate through modes. \r\nUse the below links to contribute to this app, \r\nshare an issue or a suggestion, or to see new releases.\r\n\r\n";
            // 
            // mainmenu_welcomeLabel1
            // 
            this.mainmenu_welcomeLabel1.AutoSize = true;
            this.mainmenu_welcomeLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mainmenu_welcomeLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mainmenu_welcomeLabel1.Location = new Point(134, 25);
            this.mainmenu_welcomeLabel1.Name = "mainmenu_welcomeLabel1";
            this.mainmenu_welcomeLabel1.Size = new Size(90, 25);
            this.mainmenu_welcomeLabel1.TabIndex = 1;
            this.mainmenu_welcomeLabel1.Text = "Welcome!";
            // 
            // mainmenu_welcomePic
            // 
            this.mainmenu_welcomePic.BackgroundImageLayout = ImageLayout.Stretch;
            this.mainmenu_welcomePic.Image = (Image)resources.GetObject("mainmenu_welcomePic.Image");
            this.mainmenu_welcomePic.Location = new Point(27, 25);
            this.mainmenu_welcomePic.Name = "mainmenu_welcomePic";
            this.mainmenu_welcomePic.Size = new Size(101, 92);
            this.mainmenu_welcomePic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.mainmenu_welcomePic.TabIndex = 0;
            this.mainmenu_welcomePic.TabStop = false;
            // 
            // pipTab
            // 
            this.pipTab.BackColor = SystemColors.ButtonHighlight;
            this.pipTab.Controls.Add(this.pip_other_cmd);
            this.pipTab.Controls.Add(this.pip_other_update);
            this.pipTab.Controls.Add(this.pip_other_title);
            this.pipTab.Controls.Add(this.pip_packages_uninstall);
            this.pipTab.Controls.Add(this.pip_packages_download);
            this.pipTab.Controls.Add(this.pip_packages_install);
            this.pipTab.Controls.Add(this.pip_packages_title);
            this.pipTab.Controls.Add(this.pip_welcome2);
            this.pipTab.Controls.Add(this.pip_welcome1);
            this.pipTab.Controls.Add(this.pip_welcomePic);
            this.pipTab.Location = new Point(4, 35);
            this.pipTab.Name = "pipTab";
            this.pipTab.Size = new Size(639, 367);
            this.pipTab.TabIndex = 1;
            this.pipTab.Text = "Python PIP";
            // 
            // pip_other_cmd
            // 
            this.pip_other_cmd.Enabled = false;
            this.pip_other_cmd.Location = new Point(235, 255);
            this.pip_other_cmd.Name = "pip_other_cmd";
            this.pip_other_cmd.Size = new Size(119, 23);
            this.pip_other_cmd.TabIndex = 9;
            this.pip_other_cmd.Text = "Other command...";
            // 
            // pip_other_update
            // 
            this.pip_other_update.Enabled = false;
            this.pip_other_update.Location = new Point(150, 255);
            this.pip_other_update.Name = "pip_other_update";
            this.pip_other_update.Size = new Size(79, 23);
            this.pip_other_update.TabIndex = 8;
            this.pip_other_update.Text = "Update PIP";
            // 
            // pip_other_title
            // 
            this.pip_other_title.AutoSize = true;
            this.pip_other_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_other_title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pip_other_title.Location = new Point(145, 227);
            this.pip_other_title.Name = "pip_other_title";
            this.pip_other_title.Size = new Size(57, 25);
            this.pip_other_title.TabIndex = 7;
            this.pip_other_title.Text = "Other";
            // 
            // pip_packages_uninstall
            // 
            this.pip_packages_uninstall.Enabled = false;
            this.pip_packages_uninstall.Location = new Point(303, 162);
            this.pip_packages_uninstall.Name = "pip_packages_uninstall";
            this.pip_packages_uninstall.Size = new Size(78, 23);
            this.pip_packages_uninstall.TabIndex = 6;
            this.pip_packages_uninstall.Text = "Uninstall";
            // 
            // pip_packages_download
            // 
            this.pip_packages_download.Enabled = false;
            this.pip_packages_download.Location = new Point(219, 162);
            this.pip_packages_download.Name = "pip_packages_download";
            this.pip_packages_download.Size = new Size(78, 23);
            this.pip_packages_download.TabIndex = 5;
            this.pip_packages_download.Text = "Download";
            // 
            // pip_packages_install
            // 
            this.pip_packages_install.Enabled = false;
            this.pip_packages_install.Location = new Point(150, 162);
            this.pip_packages_install.Name = "pip_packages_install";
            this.pip_packages_install.Size = new Size(63, 23);
            this.pip_packages_install.TabIndex = 4;
            this.pip_packages_install.Text = "Install";
            this.pip_packages_install.Click += pip_packages_install_Click;
            // 
            // pip_packages_title
            // 
            this.pip_packages_title.AutoSize = true;
            this.pip_packages_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_packages_title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pip_packages_title.Location = new Point(145, 136);
            this.pip_packages_title.Name = "pip_packages_title";
            this.pip_packages_title.Size = new Size(84, 25);
            this.pip_packages_title.TabIndex = 3;
            this.pip_packages_title.Text = "Packages";
            // 
            // pip_welcome2
            // 
            this.pip_welcome2.AutoSize = true;
            this.pip_welcome2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_welcome2.Location = new Point(145, 50);
            this.pip_welcome2.Name = "pip_welcome2";
            this.pip_welcome2.Size = new Size(439, 75);
            this.pip_welcome2.TabIndex = 2;
            this.pip_welcome2.Text = "You can install or delete Python packages, seek for other\r\npackages on PyPi and update pip.\r\n";
            // 
            // pip_welcome1
            // 
            this.pip_welcome1.AutoSize = true;
            this.pip_welcome1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.pip_welcome1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.pip_welcome1.Location = new Point(145, 25);
            this.pip_welcome1.Name = "pip_welcome1";
            this.pip_welcome1.Size = new Size(173, 25);
            this.pip_welcome1.TabIndex = 1;
            this.pip_welcome1.Text = "Python PIP Manager";
            // 
            // pip_welcomePic
            // 
            this.pip_welcomePic.Image = (Image)resources.GetObject("pip_welcomePic.Image");
            this.pip_welcomePic.Location = new Point(27, 25);
            this.pip_welcomePic.Name = "pip_welcomePic";
            this.pip_welcomePic.Size = new Size(112, 106);
            this.pip_welcomePic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pip_welcomePic.TabIndex = 0;
            this.pip_welcomePic.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = ImageLayout.Stretch;
            this.logo.Image = (Image)resources.GetObject("logo.Image");
            this.logo.Location = new Point(12, 28);
            this.logo.Name = "logo";
            this.logo.Size = new Size(46, 49);
            this.logo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // name_1
            // 
            this.name_1.AutoSize = true;
            this.name_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            this.name_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.name_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.name_1.Location = new Point(64, 28);
            this.name_1.Name = "name_1";
            this.name_1.Size = new Size(93, 25);
            this.name_1.TabIndex = 2;
            this.name_1.Text = "Modulifier";
            // 
            // name_2
            // 
            this.name_2.AutoSize = true;
            this.name_2.BackColor = Color.Transparent;
            this.name_2.Location = new Point(64, 51);
            this.name_2.Name = "name_2";
            this.name_2.Size = new Size(207, 19);
            this.name_2.TabIndex = 3;
            this.name_2.Text = "A tool for fast module installation.";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem, this.manageToolStripMenuItem, this.aboutToolStripMenuItem });
            this.menuStrip.Location = new Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = ToolStripRenderMode.System;
            this.menuStrip.Size = new Size(651, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.preferencesToolStripMenuItem, this.toolStripSeparator1, this.restartWithDebugToolStripMenuItem, this.quitToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new Size(174, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(171, 6);
            // 
            // restartWithDebugToolStripMenuItem
            // 
            this.restartWithDebugToolStripMenuItem.Name = "restartWithDebugToolStripMenuItem";
            this.restartWithDebugToolStripMenuItem.Size = new Size(174, 22);
            this.restartWithDebugToolStripMenuItem.Text = "Restart with Debug";
            this.restartWithDebugToolStripMenuItem.Click += restartWithDebugToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new Size(174, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutBoxToolStripMenuItem });
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBoxToolStripMenuItem
            // 
            this.aboutBoxToolStripMenuItem.Name = "aboutBoxToolStripMenuItem";
            this.aboutBoxToolStripMenuItem.Size = new Size(107, 22);
            this.aboutBoxToolStripMenuItem.Text = "About";
            this.aboutBoxToolStripMenuItem.Click += aboutBoxToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonHighlight;
            this.ClientSize = new Size(651, 491);
            this.Controls.Add(this.name_2);
            this.Controls.Add(this.name_1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Modulifier DEV";
            this.Load += MainForm_Load;
            this.tabControl.ResumeLayout(false);
            this.mainMenuTab.ResumeLayout(false);
            this.mainMenuTab.PerformLayout();
            ((ISupportInitialize)this.mainmenu_welcomePic).EndInit();
            this.pipTab.ResumeLayout(false);
            this.pipTab.PerformLayout();
            ((ISupportInitialize)this.pip_welcomePic).EndInit();
            ((ISupportInitialize)this.logo).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MetroFramework.Controls.MetroButton pip_other_cmd;
        private MetroFramework.Controls.MetroButton pip_other_update;
        private MetroFramework.Controls.MetroLabel pip_other_title;
        private MetroFramework.Controls.MetroButton pip_packages_uninstall;
        private ToolStripMenuItem restartWithDebugToolStripMenuItem;
    }
}