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
            tabControl = new MetroFramework.Controls.MetroTabControl();
            mainMenuTab = new TabPage();
            mainmenu_contribute3 = new MetroFramework.Controls.MetroLink();
            mainmenu_verticalSeparator = new MetroFramework.Controls.MetroLabel();
            mainmenu_contribute2 = new MetroFramework.Controls.MetroLink();
            mainmenu_contribute1 = new MetroFramework.Controls.MetroLabel();
            mainmenu_issue2 = new MetroFramework.Controls.MetroLink();
            mainmenu_issue1 = new MetroFramework.Controls.MetroLabel();
            mainmenu_releases2 = new MetroFramework.Controls.MetroLink();
            mainmenu_releases1 = new MetroFramework.Controls.MetroLabel();
            mainmenu_welcomeLabel2 = new MetroFramework.Controls.MetroLabel();
            mainmenu_welcomeLabel1 = new MetroFramework.Controls.MetroLabel();
            mainmenu_welcomePic = new PictureBox();
            pipTab = new TabPage();
            metroButton1 = new MetroFramework.Controls.MetroButton();
            pip_other_update = new MetroFramework.Controls.MetroButton();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            pip_packages_uninstall = new MetroFramework.Controls.MetroButton();
            pip_packages_download = new MetroFramework.Controls.MetroButton();
            pip_packages_install = new MetroFramework.Controls.MetroButton();
            pip_packages_title = new MetroFramework.Controls.MetroLabel();
            pip_welcome2 = new MetroFramework.Controls.MetroLabel();
            pip_welcome1 = new MetroFramework.Controls.MetroLabel();
            pip_welcomePic = new PictureBox();
            logo = new PictureBox();
            name_1 = new MetroFramework.Controls.MetroLabel();
            name_2 = new MetroFramework.Controls.MetroLabel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            preferencesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            restartWithDebugToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutBoxToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            mainMenuTab.SuspendLayout();
            ((ISupportInitialize)mainmenu_welcomePic).BeginInit();
            pipTab.SuspendLayout();
            ((ISupportInitialize)pip_welcomePic).BeginInit();
            ((ISupportInitialize)logo).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(mainMenuTab);
            tabControl.Controls.Add(pipTab);
            tabControl.Location = new Point(2, 73);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(6, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(647, 406);
            tabControl.TabIndex = 0;
            tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // mainMenuTab
            // 
            mainMenuTab.BackColor = SystemColors.ButtonHighlight;
            mainMenuTab.Controls.Add(mainmenu_contribute3);
            mainMenuTab.Controls.Add(mainmenu_verticalSeparator);
            mainMenuTab.Controls.Add(mainmenu_contribute2);
            mainMenuTab.Controls.Add(mainmenu_contribute1);
            mainMenuTab.Controls.Add(mainmenu_issue2);
            mainMenuTab.Controls.Add(mainmenu_issue1);
            mainMenuTab.Controls.Add(mainmenu_releases2);
            mainMenuTab.Controls.Add(mainmenu_releases1);
            mainMenuTab.Controls.Add(mainmenu_welcomeLabel2);
            mainMenuTab.Controls.Add(mainmenu_welcomeLabel1);
            mainMenuTab.Controls.Add(mainmenu_welcomePic);
            mainMenuTab.Location = new Point(4, 35);
            mainMenuTab.Name = "mainMenuTab";
            mainMenuTab.Size = new Size(639, 367);
            mainMenuTab.TabIndex = 0;
            mainMenuTab.Text = "Main Menu";
            mainMenuTab.ToolTipText = "Main Menu";
            // 
            // mainmenu_contribute3
            // 
            mainmenu_contribute3.Cursor = Cursors.Hand;
            mainmenu_contribute3.CustomForeColor = true;
            mainmenu_contribute3.FontSize = MetroFramework.MetroLinkSize.Medium;
            mainmenu_contribute3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            mainmenu_contribute3.ForeColor = SystemColors.Highlight;
            mainmenu_contribute3.Location = new Point(307, 323);
            mainmenu_contribute3.Name = "mainmenu_contribute3";
            mainmenu_contribute3.Size = new Size(197, 23);
            mainmenu_contribute3.TabIndex = 10;
            mainmenu_contribute3.Text = "Create a Pull Request on GitHub";
            mainmenu_contribute3.Click += mainmenu_contribute3_Click;
            // 
            // mainmenu_verticalSeparator
            // 
            mainmenu_verticalSeparator.BackColor = SystemColors.ActiveCaptionText;
            mainmenu_verticalSeparator.CustomBackground = true;
            mainmenu_verticalSeparator.Location = new Point(303, 328);
            mainmenu_verticalSeparator.Name = "mainmenu_verticalSeparator";
            mainmenu_verticalSeparator.Size = new Size(1, 15);
            mainmenu_verticalSeparator.TabIndex = 9;
            mainmenu_verticalSeparator.Text = " ";
            // 
            // mainmenu_contribute2
            // 
            mainmenu_contribute2.Cursor = Cursors.Hand;
            mainmenu_contribute2.CustomForeColor = true;
            mainmenu_contribute2.FontSize = MetroFramework.MetroLinkSize.Medium;
            mainmenu_contribute2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            mainmenu_contribute2.ForeColor = SystemColors.Highlight;
            mainmenu_contribute2.Location = new Point(135, 323);
            mainmenu_contribute2.Name = "mainmenu_contribute2";
            mainmenu_contribute2.Size = new Size(166, 23);
            mainmenu_contribute2.TabIndex = 8;
            mainmenu_contribute2.Text = "Fork this project on GitHub";
            mainmenu_contribute2.Click += mainmenu_contribute2_Click;
            // 
            // mainmenu_contribute1
            // 
            mainmenu_contribute1.AutoSize = true;
            mainmenu_contribute1.FontSize = MetroFramework.MetroLabelSize.Tall;
            mainmenu_contribute1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            mainmenu_contribute1.Location = new Point(134, 295);
            mainmenu_contribute1.Name = "mainmenu_contribute1";
            mainmenu_contribute1.Size = new Size(183, 25);
            mainmenu_contribute1.TabIndex = 7;
            mainmenu_contribute1.Text = "Become a contributor";
            // 
            // mainmenu_issue2
            // 
            mainmenu_issue2.Cursor = Cursors.Hand;
            mainmenu_issue2.CustomForeColor = true;
            mainmenu_issue2.FontSize = MetroFramework.MetroLinkSize.Medium;
            mainmenu_issue2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            mainmenu_issue2.ForeColor = SystemColors.Highlight;
            mainmenu_issue2.Location = new Point(134, 253);
            mainmenu_issue2.Name = "mainmenu_issue2";
            mainmenu_issue2.Size = new Size(359, 23);
            mainmenu_issue2.TabIndex = 6;
            mainmenu_issue2.Text = "See already shared issues and suggestions, and share yours!";
            mainmenu_issue2.Click += mainmenu_issue2_Click;
            // 
            // mainmenu_issue1
            // 
            mainmenu_issue1.AutoSize = true;
            mainmenu_issue1.FontSize = MetroFramework.MetroLabelSize.Tall;
            mainmenu_issue1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            mainmenu_issue1.Location = new Point(134, 225);
            mainmenu_issue1.Name = "mainmenu_issue1";
            mainmenu_issue1.Size = new Size(196, 25);
            mainmenu_issue1.TabIndex = 5;
            mainmenu_issue1.Text = "Issues and suggestions";
            // 
            // mainmenu_releases2
            // 
            mainmenu_releases2.Cursor = Cursors.Hand;
            mainmenu_releases2.CustomForeColor = true;
            mainmenu_releases2.FontSize = MetroFramework.MetroLinkSize.Medium;
            mainmenu_releases2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            mainmenu_releases2.ForeColor = SystemColors.Highlight;
            mainmenu_releases2.Location = new Point(134, 184);
            mainmenu_releases2.Name = "mainmenu_releases2";
            mainmenu_releases2.Size = new Size(204, 23);
            mainmenu_releases2.TabIndex = 4;
            mainmenu_releases2.Text = "Check for new versions available!";
            mainmenu_releases2.Click += mainmenu_releases2_Click;
            // 
            // mainmenu_releases1
            // 
            mainmenu_releases1.AutoSize = true;
            mainmenu_releases1.FontSize = MetroFramework.MetroLabelSize.Tall;
            mainmenu_releases1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            mainmenu_releases1.Location = new Point(134, 156);
            mainmenu_releases1.Name = "mainmenu_releases1";
            mainmenu_releases1.Size = new Size(178, 25);
            mainmenu_releases1.TabIndex = 3;
            mainmenu_releases1.Text = "Get the latest version";
            // 
            // mainmenu_welcomeLabel2
            // 
            mainmenu_welcomeLabel2.AutoSize = true;
            mainmenu_welcomeLabel2.BackColor = Color.Transparent;
            mainmenu_welcomeLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            mainmenu_welcomeLabel2.Location = new Point(134, 50);
            mainmenu_welcomeLabel2.Name = "mainmenu_welcomeLabel2";
            mainmenu_welcomeLabel2.Size = new Size(501, 125);
            mainmenu_welcomeLabel2.TabIndex = 2;
            mainmenu_welcomeLabel2.Text = "This is the main menu. Use the tabs to navigate through modes. \r\nUse the below links to contribute to this app, \r\nshare an issue or a suggestion, or to see new releases.\r\n\r\n";
            // 
            // mainmenu_welcomeLabel1
            // 
            mainmenu_welcomeLabel1.AutoSize = true;
            mainmenu_welcomeLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            mainmenu_welcomeLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            mainmenu_welcomeLabel1.Location = new Point(134, 25);
            mainmenu_welcomeLabel1.Name = "mainmenu_welcomeLabel1";
            mainmenu_welcomeLabel1.Size = new Size(90, 25);
            mainmenu_welcomeLabel1.TabIndex = 1;
            mainmenu_welcomeLabel1.Text = "Welcome!";
            // 
            // mainmenu_welcomePic
            // 
            mainmenu_welcomePic.BackgroundImageLayout = ImageLayout.Stretch;
            mainmenu_welcomePic.Image = (Image)resources.GetObject("mainmenu_welcomePic.Image");
            mainmenu_welcomePic.Location = new Point(27, 25);
            mainmenu_welcomePic.Name = "mainmenu_welcomePic";
            mainmenu_welcomePic.Size = new Size(101, 92);
            mainmenu_welcomePic.SizeMode = PictureBoxSizeMode.StretchImage;
            mainmenu_welcomePic.TabIndex = 0;
            mainmenu_welcomePic.TabStop = false;
            // 
            // pipTab
            // 
            pipTab.BackColor = SystemColors.ButtonHighlight;
            pipTab.Controls.Add(metroButton1);
            pipTab.Controls.Add(pip_other_update);
            pipTab.Controls.Add(metroLabel1);
            pipTab.Controls.Add(pip_packages_uninstall);
            pipTab.Controls.Add(pip_packages_download);
            pipTab.Controls.Add(pip_packages_install);
            pipTab.Controls.Add(pip_packages_title);
            pipTab.Controls.Add(pip_welcome2);
            pipTab.Controls.Add(pip_welcome1);
            pipTab.Controls.Add(pip_welcomePic);
            pipTab.Location = new Point(4, 35);
            pipTab.Name = "pipTab";
            pipTab.Size = new Size(192, 61);
            pipTab.TabIndex = 1;
            pipTab.Text = "Python PIP";
            // 
            // metroButton1
            // 
            metroButton1.Location = new Point(235, 255);
            metroButton1.Name = "metroButton1";
            metroButton1.Size = new Size(119, 23);
            metroButton1.TabIndex = 9;
            metroButton1.Text = "Other command...";
            // 
            // pip_other_update
            // 
            pip_other_update.Location = new Point(150, 255);
            pip_other_update.Name = "pip_other_update";
            pip_other_update.Size = new Size(79, 23);
            pip_other_update.TabIndex = 8;
            pip_other_update.Text = "Update PIP";
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new Point(145, 227);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(57, 25);
            metroLabel1.TabIndex = 7;
            metroLabel1.Text = "Other";
            // 
            // pip_packages_uninstall
            // 
            pip_packages_uninstall.Location = new Point(303, 162);
            pip_packages_uninstall.Name = "pip_packages_uninstall";
            pip_packages_uninstall.Size = new Size(78, 23);
            pip_packages_uninstall.TabIndex = 6;
            pip_packages_uninstall.Text = "Uninstall";
            // 
            // pip_packages_download
            // 
            pip_packages_download.Location = new Point(219, 162);
            pip_packages_download.Name = "pip_packages_download";
            pip_packages_download.Size = new Size(78, 23);
            pip_packages_download.TabIndex = 5;
            pip_packages_download.Text = "Download";
            // 
            // pip_packages_install
            // 
            pip_packages_install.Location = new Point(150, 162);
            pip_packages_install.Name = "pip_packages_install";
            pip_packages_install.Size = new Size(63, 23);
            pip_packages_install.TabIndex = 4;
            pip_packages_install.Text = "Install";
            // 
            // pip_packages_title
            // 
            pip_packages_title.AutoSize = true;
            pip_packages_title.FontSize = MetroFramework.MetroLabelSize.Tall;
            pip_packages_title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            pip_packages_title.Location = new Point(145, 136);
            pip_packages_title.Name = "pip_packages_title";
            pip_packages_title.Size = new Size(84, 25);
            pip_packages_title.TabIndex = 3;
            pip_packages_title.Text = "Packages";
            // 
            // pip_welcome2
            // 
            pip_welcome2.AutoSize = true;
            pip_welcome2.FontSize = MetroFramework.MetroLabelSize.Tall;
            pip_welcome2.Location = new Point(145, 50);
            pip_welcome2.Name = "pip_welcome2";
            pip_welcome2.Size = new Size(439, 75);
            pip_welcome2.TabIndex = 2;
            pip_welcome2.Text = "You can install or delete Python packages, seek for other\r\npackages on PyPi and update pip.\r\n";
            // 
            // pip_welcome1
            // 
            pip_welcome1.AutoSize = true;
            pip_welcome1.FontSize = MetroFramework.MetroLabelSize.Tall;
            pip_welcome1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            pip_welcome1.Location = new Point(145, 25);
            pip_welcome1.Name = "pip_welcome1";
            pip_welcome1.Size = new Size(173, 25);
            pip_welcome1.TabIndex = 1;
            pip_welcome1.Text = "Python PIP Manager";
            // 
            // pip_welcomePic
            // 
            pip_welcomePic.Image = (Image)resources.GetObject("pip_welcomePic.Image");
            pip_welcomePic.Location = new Point(27, 25);
            pip_welcomePic.Name = "pip_welcomePic";
            pip_welcomePic.Size = new Size(112, 106);
            pip_welcomePic.SizeMode = PictureBoxSizeMode.StretchImage;
            pip_welcomePic.TabIndex = 0;
            pip_welcomePic.TabStop = false;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 28);
            logo.Name = "logo";
            logo.Size = new Size(46, 49);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // name_1
            // 
            name_1.AutoSize = true;
            name_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_1.FontSize = MetroFramework.MetroLabelSize.Tall;
            name_1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            name_1.Location = new Point(64, 28);
            name_1.Name = "name_1";
            name_1.Size = new Size(93, 25);
            name_1.TabIndex = 2;
            name_1.Text = "Modulifier";
            // 
            // name_2
            // 
            name_2.AutoSize = true;
            name_2.Location = new Point(64, 51);
            name_2.Name = "name_2";
            name_2.Size = new Size(188, 19);
            name_2.TabIndex = 3;
            name_2.Text = "Tool for fast package installing.";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, manageToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.System;
            menuStrip.Size = new Size(651, 24);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preferencesToolStripMenuItem, toolStripSeparator1, restartWithDebugToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(180, 22);
            preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // restartWithDebugToolStripMenuItem
            // 
            restartWithDebugToolStripMenuItem.Name = "restartWithDebugToolStripMenuItem";
            restartWithDebugToolStripMenuItem.Size = new Size(180, 22);
            restartWithDebugToolStripMenuItem.Text = "Restart with Debug";
            restartWithDebugToolStripMenuItem.Click += restartWithDebugToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(62, 20);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutBoxToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBoxToolStripMenuItem
            // 
            aboutBoxToolStripMenuItem.Name = "aboutBoxToolStripMenuItem";
            aboutBoxToolStripMenuItem.Size = new Size(107, 22);
            aboutBoxToolStripMenuItem.Text = "About";
            aboutBoxToolStripMenuItem.Click += aboutBoxToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(651, 491);
            Controls.Add(name_2);
            Controls.Add(name_1);
            Controls.Add(logo);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modulifier Main Menu";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            mainMenuTab.ResumeLayout(false);
            mainMenuTab.PerformLayout();
            ((ISupportInitialize)mainmenu_welcomePic).EndInit();
            pipTab.ResumeLayout(false);
            pipTab.PerformLayout();
            ((ISupportInitialize)pip_welcomePic).EndInit();
            ((ISupportInitialize)logo).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton pip_other_update;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton pip_packages_uninstall;
        private ToolStripMenuItem restartWithDebugToolStripMenuItem;
    }
}