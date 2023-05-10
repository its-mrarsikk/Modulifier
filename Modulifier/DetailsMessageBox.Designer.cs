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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DetailsMessageBox));
            this.icon = new PictureBox();
            this.msgText = new Label();
            this.okButton = new Button();
            this.toggleDetails = new Button();
            this.quitButton = new Button();
            this.details = new RichTextBox();
            this.copyBtn = new Button();
            ((ISupportInitialize)this.icon).BeginInit();
            SuspendLayout();
            // 
            // icon
            // 
            this.icon.ImageLocation = "";
            this.icon.Location = new Point(23, 33);
            this.icon.Name = "icon";
            this.icon.Size = new Size(64, 64);
            this.icon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // msgText
            // 
            this.msgText.Location = new Point(102, 13);
            this.msgText.Name = "msgText";
            this.msgText.Size = new Size(285, 105);
            this.msgText.TabIndex = 1;
            this.msgText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi non sagittis tellus,\r\nvel suscipit orci. Nulla et sapien augue. Donec tristique tellus quis turpis maximus.";
            this.msgText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.DialogResult = DialogResult.OK;
            this.okButton.Location = new Point(379, 141);
            this.okButton.Name = "okButton";
            this.okButton.Size = new Size(41, 32);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += okButton_Click;
            // 
            // toggleDetails
            // 
            this.toggleDetails.Location = new Point(12, 141);
            this.toggleDetails.Name = "toggleDetails";
            this.toggleDetails.Size = new Size(84, 32);
            this.toggleDetails.TabIndex = 3;
            this.toggleDetails.Text = "Show Details";
            this.toggleDetails.UseVisualStyleBackColor = true;
            this.toggleDetails.Click += toggleDetails_Click;
            // 
            // quitButton
            // 
            this.quitButton.DialogResult = DialogResult.Cancel;
            this.quitButton.Location = new Point(325, 141);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new Size(48, 32);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += quitButton_Click;
            // 
            // details
            // 
            this.details.Location = new Point(12, 179);
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Size = new Size(408, 235);
            this.details.TabIndex = 4;
            this.details.Text = resources.GetString("details.Text");
            this.details.LinkClicked += details_LinkClicked;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new Point(12, 420);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new Size(75, 23);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += copyBtn_Click;
            // 
            // DetailsMessageBox
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(432, 176);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.details);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.toggleDetails);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsMessageBox";
            this.ShowIcon = false;
            this.Text = "Caption";
            this.TopMost = true;
            ((ISupportInitialize)this.icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox icon;
        private Label msgText;
        private Button okButton;
        private Button toggleDetails;
        private Button quitButton;
        private RichTextBox details;
        private Button copyBtn;
    }
}
