namespace Modulifier
{
    partial class PipInstall
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PipInstall));
            tabControl = new MetroFramework.Controls.MetroTabControl();
            manual_tab = new TabPage();
            manual_packages_add = new MetroFramework.Controls.MetroButton();
            manual_packages_list = new FlowLayoutPanel();
            manual_packages_pkg1 = new TextBox();
            manual_install_start = new Button();
            tabControl.SuspendLayout();
            manual_tab.SuspendLayout();
            manual_packages_list.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(manual_tab);
            tabControl.CustomBackground = true;
            tabControl.Location = new Point(12, 44);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(6, 8);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(516, 255);
            tabControl.TabIndex = 0;
            // 
            // manual_tab
            // 
            manual_tab.Controls.Add(manual_packages_add);
            manual_tab.Controls.Add(manual_packages_list);
            manual_tab.Location = new Point(4, 35);
            manual_tab.Name = "manual_tab";
            manual_tab.Size = new Size(508, 216);
            manual_tab.TabIndex = 0;
            manual_tab.Text = "Manual Entry";
            // 
            // manual_packages_add
            // 
            manual_packages_add.Anchor = AnchorStyles.Bottom;
            manual_packages_add.Image = (Image)resources.GetObject("manual_packages_add.Image");
            manual_packages_add.Location = new Point(12, 181);
            manual_packages_add.Name = "manual_packages_add";
            manual_packages_add.Size = new Size(172, 32);
            manual_packages_add.TabIndex = 1;
            manual_packages_add.Text = "Add";
            manual_packages_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            manual_packages_add.Click += manual_packages_add_Click;
            // 
            // manual_packages_list
            // 
            manual_packages_list.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            manual_packages_list.BorderStyle = BorderStyle.FixedSingle;
            manual_packages_list.Controls.Add(manual_packages_pkg1);
            manual_packages_list.FlowDirection = FlowDirection.TopDown;
            manual_packages_list.Location = new Point(12, 37);
            manual_packages_list.Name = "manual_packages_list";
            manual_packages_list.Size = new Size(172, 138);
            manual_packages_list.TabIndex = 0;
            // 
            // manual_packages_pkg1
            // 
            manual_packages_pkg1.Location = new Point(3, 3);
            manual_packages_pkg1.MaxLength = 34;
            manual_packages_pkg1.Name = "manual_packages_pkg1";
            manual_packages_pkg1.Size = new Size(136, 23);
            manual_packages_pkg1.TabIndex = 0;
            // 
            // manual_install_start
            // 
            manual_install_start.Anchor = AnchorStyles.Bottom;
            manual_install_start.Image = (Image)resources.GetObject("manual_install_start.Image");
            manual_install_start.Location = new Point(389, 301);
            manual_install_start.Name = "manual_install_start";
            manual_install_start.Size = new Size(135, 23);
            manual_install_start.TabIndex = 1;
            manual_install_start.Text = "Start";
            manual_install_start.TextAlign = ContentAlignment.MiddleRight;
            manual_install_start.TextImageRelation = TextImageRelation.ImageBeforeText;
            manual_install_start.UseVisualStyleBackColor = true;
            // 
            // PipInstall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 328);
            Controls.Add(manual_install_start);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PipInstall";
            ShowIcon = false;
            Text = "Install...";
            tabControl.ResumeLayout(false);
            manual_tab.ResumeLayout(false);
            manual_packages_list.ResumeLayout(false);
            manual_packages_list.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private TabPage manual_tab;
        private FlowLayoutPanel manual_packages_list;
        private MetroFramework.Controls.MetroButton manual_packages_add;
        private TextBox manual_packages_pkg1;
        private Button manual_install_start;
    }
}