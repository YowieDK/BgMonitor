namespace BgLevelApp
{
    partial class InfoFormWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoFormWindow));
            this.bgMonitorInfoHeader = new System.Windows.Forms.Label();
            this.historyBehindLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeSnoozePanel = new System.Windows.Forms.Label();
            this.btnOpenLicenseAgree = new System.Windows.Forms.Button();
            this.btnCloseInfo = new System.Windows.Forms.Button();
            this.toolTipInfoWindow = new System.Windows.Forms.ToolTip(this.components);
            this.appByLabel = new System.Windows.Forms.Label();
            this.userGuideLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgMonitorInfoHeader
            // 
            this.bgMonitorInfoHeader.AutoSize = true;
            this.bgMonitorInfoHeader.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgMonitorInfoHeader.ForeColor = System.Drawing.Color.Yellow;
            this.bgMonitorInfoHeader.Location = new System.Drawing.Point(3, 6);
            this.bgMonitorInfoHeader.Name = "bgMonitorInfoHeader";
            this.bgMonitorInfoHeader.Size = new System.Drawing.Size(138, 24);
            this.bgMonitorInfoHeader.TabIndex = 0;
            this.bgMonitorInfoHeader.Text = "BgMonitor Info";
            // 
            // historyBehindLabel
            // 
            this.historyBehindLabel.AutoSize = true;
            this.historyBehindLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBehindLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.historyBehindLabel.Location = new System.Drawing.Point(4, 36);
            this.historyBehindLabel.Name = "historyBehindLabel";
            this.historyBehindLabel.Size = new System.Drawing.Size(427, 180);
            this.historyBehindLabel.TabIndex = 1;
            this.historyBehindLabel.Text = resources.GetString("historyBehindLabel.Text");
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.userGuideLabel);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 263);
            this.panel1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(46, 1332);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // closeSnoozePanel
            // 
            this.closeSnoozePanel.AutoSize = true;
            this.closeSnoozePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeSnoozePanel.ForeColor = System.Drawing.Color.SeaShell;
            this.closeSnoozePanel.Location = new System.Drawing.Point(380, 11);
            this.closeSnoozePanel.Name = "closeSnoozePanel";
            this.closeSnoozePanel.Size = new System.Drawing.Size(50, 13);
            this.closeSnoozePanel.TabIndex = 5;
            this.closeSnoozePanel.Text = "X Close";
            this.closeSnoozePanel.Click += new System.EventHandler(this.closeSnoozePanel_Click);
            // 
            // btnOpenLicenseAgree
            // 
            this.btnOpenLicenseAgree.Location = new System.Drawing.Point(152, 490);
            this.btnOpenLicenseAgree.Name = "btnOpenLicenseAgree";
            this.btnOpenLicenseAgree.Size = new System.Drawing.Size(130, 22);
            this.btnOpenLicenseAgree.TabIndex = 6;
            this.btnOpenLicenseAgree.Text = "View license agreement";
            this.toolTipInfoWindow.SetToolTip(this.btnOpenLicenseAgree, "View License Agreement");
            this.btnOpenLicenseAgree.UseVisualStyleBackColor = true;
            this.btnOpenLicenseAgree.Click += new System.EventHandler(this.btnOpenLicenseAggre_Click);
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.Location = new System.Drawing.Point(7, 490);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(130, 22);
            this.btnCloseInfo.TabIndex = 7;
            this.btnCloseInfo.Text = "Close info";
            this.toolTipInfoWindow.SetToolTip(this.btnCloseInfo, "Close this window");
            this.btnCloseInfo.UseVisualStyleBackColor = true;
            this.btnCloseInfo.Click += new System.EventHandler(this.btnCloseInfo_Click);
            // 
            // appByLabel
            // 
            this.appByLabel.AutoSize = true;
            this.appByLabel.Font = new System.Drawing.Font("Arial", 7F);
            this.appByLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.appByLabel.Location = new System.Drawing.Point(334, 506);
            this.appByLabel.Name = "appByLabel";
            this.appByLabel.Size = new System.Drawing.Size(100, 13);
            this.appByLabel.TabIndex = 8;
            this.appByLabel.Text = "Made by Søren Høy";
            // 
            // userGuideLabel
            // 
            this.userGuideLabel.AutoSize = true;
            this.userGuideLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGuideLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.userGuideLabel.Location = new System.Drawing.Point(3, 6);
            this.userGuideLabel.Name = "userGuideLabel";
            this.userGuideLabel.Size = new System.Drawing.Size(71, 15);
            this.userGuideLabel.TabIndex = 4;
            this.userGuideLabel.Text = "User guide:";
            // 
            // InfoFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(436, 520);
            this.Controls.Add(this.appByLabel);
            this.Controls.Add(this.btnCloseInfo);
            this.Controls.Add(this.btnOpenLicenseAgree);
            this.Controls.Add(this.closeSnoozePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyBehindLabel);
            this.Controls.Add(this.bgMonitorInfoHeader);
            this.Name = "InfoFormWindow";
            this.Text = "InfoFormWindow";
            this.Load += new System.EventHandler(this.InfoFormWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bgMonitorInfoHeader;
        private System.Windows.Forms.Label historyBehindLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeSnoozePanel;
        private System.Windows.Forms.Button btnOpenLicenseAgree;
        private System.Windows.Forms.Button btnCloseInfo;
        private System.Windows.Forms.ToolTip toolTipInfoWindow;
        private System.Windows.Forms.Label appByLabel;
        private System.Windows.Forms.Label userGuideLabel;
    }
}