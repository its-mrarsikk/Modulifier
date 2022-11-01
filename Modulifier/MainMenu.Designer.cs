namespace Modulifier
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.pipTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainMenuTab);
            this.tabControl.Controls.Add(this.pipTab);
            this.tabControl.Location = new System.Drawing.Point(2, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 8);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(647, 413);
            this.tabControl.TabIndex = 0;
            this.tabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.Location = new System.Drawing.Point(4, 35);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Size = new System.Drawing.Size(639, 374);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.ToolTipText = "Main Menu";
            // 
            // pipTab
            // 
            this.pipTab.BackColor = System.Drawing.SystemColors.Control;
            this.pipTab.Location = new System.Drawing.Point(4, 35);
            this.pipTab.Name = "pipTab";
            this.pipTab.Size = new System.Drawing.Size(192, 61);
            this.pipTab.TabIndex = 1;
            this.pipTab.Text = "Python PIP";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Modulifier Main Menu";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private TabPage mainMenuTab;
        private TabPage pipTab;
    }
}