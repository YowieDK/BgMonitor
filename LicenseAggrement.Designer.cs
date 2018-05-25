using System.Windows.Forms;

namespace BgLevelApp
{
    partial class LicenseAgrement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseAgrement));
            this.LicenseText = new System.Windows.Forms.TextBox();
            this.AcceptPanel = new System.Windows.Forms.Panel();
            this.DeclinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LicenseText
            // 
            this.LicenseText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LicenseText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LicenseText.ForeColor = System.Drawing.SystemColors.Info;
            this.LicenseText.Location = new System.Drawing.Point(9, 9);
            this.LicenseText.Multiline = true;
            this.LicenseText.Name = "LicenseText";
            this.LicenseText.ReadOnly = true;
            this.LicenseText.ShortcutsEnabled = false;
            this.LicenseText.Size = new System.Drawing.Size(244, 294);
            this.LicenseText.TabIndex = 0;
            this.LicenseText.TabStop = false;
            this.LicenseText.Text = resources.GetString("LicenseText.Text");
            this.LicenseText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AcceptPanel
            // 
            this.AcceptPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AcceptPanel.BackgroundImage")));
            this.AcceptPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AcceptPanel.Location = new System.Drawing.Point(12, 309);
            this.AcceptPanel.Name = "AcceptPanel";
            this.AcceptPanel.Size = new System.Drawing.Size(99, 52);
            this.AcceptPanel.TabIndex = 1;
            this.AcceptPanel.Click += new System.EventHandler(this.Acceptpanel_Click);
            this.AcceptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AcceptPanel_Paint);
            // 
            // DeclinePanel
            // 
            this.DeclinePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeclinePanel.BackgroundImage")));
            this.DeclinePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeclinePanel.Location = new System.Drawing.Point(151, 309);
            this.DeclinePanel.Name = "DeclinePanel";
            this.DeclinePanel.Size = new System.Drawing.Size(99, 52);
            this.DeclinePanel.TabIndex = 2;
            this.DeclinePanel.Click += new System.EventHandler(this.Declinpanel_Click);
            this.DeclinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Decline_Paint);
            // 
            // LicenseAgrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(262, 362);
            this.Controls.Add(this.DeclinePanel);
            this.Controls.Add(this.AcceptPanel);
            this.Controls.Add(this.LicenseText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LicenseAgrement";
            this.ShowInTaskbar = false;
            this.Text = "Use of this app";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Licens_FormClosing);
            this.Load += new System.EventHandler(this.LicenseAgrement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LicenseText;
        private System.Windows.Forms.Panel AcceptPanel;
        private System.Windows.Forms.Panel DeclinePanel;
    }
}