using Modulifier;
using Modulifier.Properties;

namespace Modulifier
{
    partial class DetailsMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsMessageBox));
            this.icon = new System.Windows.Forms.PictureBox();
            this.msgText = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.toggleDetails = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // icon
            // 
            this.icon.ImageLocation = "";
            this.icon.Location = new System.Drawing.Point(12, 48);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(84, 84);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // msgText
            // 
            this.msgText.Location = new System.Drawing.Point(102, 38);
            this.msgText.Name = "msgText";
            this.msgText.Size = new System.Drawing.Size(285, 105);
            this.msgText.TabIndex = 1;
            this.msgText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi non sagittis tellu" +
    "s,\r\nvel suscipit orci. Nulla et sapien augue. Donec tristique tellus quis turpis" +
    " maximus.";
            this.msgText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(379, 176);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(41, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // toggleDetails
            // 
            this.toggleDetails.Location = new System.Drawing.Point(12, 176);
            this.toggleDetails.Name = "toggleDetails";
            this.toggleDetails.Size = new System.Drawing.Size(84, 32);
            this.toggleDetails.TabIndex = 3;
            this.toggleDetails.Text = "Show Details";
            this.toggleDetails.UseVisualStyleBackColor = true;
            this.toggleDetails.Click += new System.EventHandler(this.toggleDetails_Click);
            // 
            // quitButton
            // 
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Location = new System.Drawing.Point(325, 176);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(48, 32);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(12, 214);
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Size = new System.Drawing.Size(408, 235);
            this.details.TabIndex = 4;
            this.details.Text = resources.GetString("details.Text");
            this.details.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.details_LinkClicked);
            // 
            // DetailsMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 211);
            this.Controls.Add(this.details);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.toggleDetails);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsMessageBox";
            this.ShowIcon = false;
            this.Text = "Caption";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox icon;
        private Label msgText;
        private Button okButton;
        private Button toggleDetails;
        private Button quitButton;
        private RichTextBox details;
    }
}
