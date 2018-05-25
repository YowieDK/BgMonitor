namespace BgLevelApp
{
    partial class BgSettings
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
            this.textBoxNightUrl = new System.Windows.Forms.TextBox();
            this.labelNightScoutUrl = new System.Windows.Forms.Label();
            this.labelHighAlarm = new System.Windows.Forms.Label();
            this.labelAlwaysOnTop = new System.Windows.Forms.Label();
            this.labelAutoTrans = new System.Windows.Forms.Label();
            this.labelBgLow = new System.Windows.Forms.Label();
            this.labelBgHigh = new System.Windows.Forms.Label();
            this.labelUseMmol = new System.Windows.Forms.Label();
            this.labelLoowAlarm = new System.Windows.Forms.Label();
            this.checkBoxUseMmol = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoTrans = new System.Windows.Forms.CheckBox();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxAlarmOnHigh = new System.Windows.Forms.CheckBox();
            this.checkBoxAlarmOnLow = new System.Windows.Forms.CheckBox();
            this.textBoxBgHigh = new System.Windows.Forms.TextBox();
            this.textBoxBgLow = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonCloseSettings = new System.Windows.Forms.Button();
            this.checkAlarmOnMissingBg = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMinutesForMissingBgAlarm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNightUrl
            // 
            this.textBoxNightUrl.Location = new System.Drawing.Point(127, 26);
            this.textBoxNightUrl.Name = "textBoxNightUrl";
            this.textBoxNightUrl.Size = new System.Drawing.Size(298, 20);
            this.textBoxNightUrl.TabIndex = 0;
            this.textBoxNightUrl.Text = "https://YOUR_SITE_HERE";
            this.toolTip1.SetToolTip(this.textBoxNightUrl, "Ex. https://{yoursite}.herokuapp.com or https://{yoursite}.azurewebsites.net");
            // 
            // labelNightScoutUrl
            // 
            this.labelNightScoutUrl.AutoSize = true;
            this.labelNightScoutUrl.BackColor = System.Drawing.Color.Transparent;
            this.labelNightScoutUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNightScoutUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelNightScoutUrl.Location = new System.Drawing.Point(12, 29);
            this.labelNightScoutUrl.Name = "labelNightScoutUrl";
            this.labelNightScoutUrl.Size = new System.Drawing.Size(95, 15);
            this.labelNightScoutUrl.TabIndex = 1;
            this.labelNightScoutUrl.Text = "NightScout URL";
            // 
            // labelHighAlarm
            // 
            this.labelHighAlarm.AutoSize = true;
            this.labelHighAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelHighAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelHighAlarm.Location = new System.Drawing.Point(10, 268);
            this.labelHighAlarm.Name = "labelHighAlarm";
            this.labelHighAlarm.Size = new System.Drawing.Size(83, 15);
            this.labelHighAlarm.TabIndex = 3;
            this.labelHighAlarm.Text = "Alarm on high";
            // 
            // labelAlwaysOnTop
            // 
            this.labelAlwaysOnTop.AutoSize = true;
            this.labelAlwaysOnTop.BackColor = System.Drawing.Color.Transparent;
            this.labelAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAlwaysOnTop.Location = new System.Drawing.Point(10, 234);
            this.labelAlwaysOnTop.Name = "labelAlwaysOnTop";
            this.labelAlwaysOnTop.Size = new System.Drawing.Size(105, 15);
            this.labelAlwaysOnTop.TabIndex = 4;
            this.labelAlwaysOnTop.Text = "App always on top";
            // 
            // labelAutoTrans
            // 
            this.labelAutoTrans.AutoSize = true;
            this.labelAutoTrans.BackColor = System.Drawing.Color.Transparent;
            this.labelAutoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAutoTrans.Location = new System.Drawing.Point(12, 194);
            this.labelAutoTrans.Name = "labelAutoTrans";
            this.labelAutoTrans.Size = new System.Drawing.Size(120, 15);
            this.labelAutoTrans.TabIndex = 5;
            this.labelAutoTrans.Text = "App auto transparent";
            // 
            // labelBgLow
            // 
            this.labelBgLow.AutoSize = true;
            this.labelBgLow.BackColor = System.Drawing.Color.Transparent;
            this.labelBgLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBgLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelBgLow.Location = new System.Drawing.Point(12, 151);
            this.labelBgLow.Name = "labelBgLow";
            this.labelBgLow.Size = new System.Drawing.Size(76, 15);
            this.labelBgLow.TabIndex = 6;
            this.labelBgLow.Text = "Bg low value";
            // 
            // labelBgHigh
            // 
            this.labelBgHigh.AutoSize = true;
            this.labelBgHigh.BackColor = System.Drawing.Color.Transparent;
            this.labelBgHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBgHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelBgHigh.Location = new System.Drawing.Point(12, 109);
            this.labelBgHigh.Name = "labelBgHigh";
            this.labelBgHigh.Size = new System.Drawing.Size(81, 15);
            this.labelBgHigh.TabIndex = 7;
            this.labelBgHigh.Text = "Bg high value";
            // 
            // labelUseMmol
            // 
            this.labelUseMmol.AutoSize = true;
            this.labelUseMmol.BackColor = System.Drawing.Color.Transparent;
            this.labelUseMmol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseMmol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUseMmol.Location = new System.Drawing.Point(12, 67);
            this.labelUseMmol.Name = "labelUseMmol";
            this.labelUseMmol.Size = new System.Drawing.Size(102, 15);
            this.labelUseMmol.TabIndex = 8;
            this.labelUseMmol.Text = "Use mmol values";
            // 
            // labelLoowAlarm
            // 
            this.labelLoowAlarm.AutoSize = true;
            this.labelLoowAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelLoowAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoowAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelLoowAlarm.Location = new System.Drawing.Point(10, 304);
            this.labelLoowAlarm.Name = "labelLoowAlarm";
            this.labelLoowAlarm.Size = new System.Drawing.Size(78, 15);
            this.labelLoowAlarm.TabIndex = 9;
            this.labelLoowAlarm.Text = "Alarm on low";
            // 
            // checkBoxUseMmol
            // 
            this.checkBoxUseMmol.AutoSize = true;
            this.checkBoxUseMmol.Location = new System.Drawing.Point(152, 67);
            this.checkBoxUseMmol.Name = "checkBoxUseMmol";
            this.checkBoxUseMmol.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUseMmol.TabIndex = 10;
            this.checkBoxUseMmol.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoTrans
            // 
            this.checkBoxAutoTrans.AutoSize = true;
            this.checkBoxAutoTrans.Location = new System.Drawing.Point(152, 195);
            this.checkBoxAutoTrans.Name = "checkBoxAutoTrans";
            this.checkBoxAutoTrans.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoTrans.TabIndex = 11;
            this.checkBoxAutoTrans.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(150, 232);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlwaysOnTop.TabIndex = 12;
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlarmOnHigh
            // 
            this.checkBoxAlarmOnHigh.AutoSize = true;
            this.checkBoxAlarmOnHigh.Location = new System.Drawing.Point(150, 268);
            this.checkBoxAlarmOnHigh.Name = "checkBoxAlarmOnHigh";
            this.checkBoxAlarmOnHigh.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlarmOnHigh.TabIndex = 13;
            this.checkBoxAlarmOnHigh.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlarmOnLow
            // 
            this.checkBoxAlarmOnLow.AutoSize = true;
            this.checkBoxAlarmOnLow.Location = new System.Drawing.Point(150, 305);
            this.checkBoxAlarmOnLow.Name = "checkBoxAlarmOnLow";
            this.checkBoxAlarmOnLow.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlarmOnLow.TabIndex = 14;
            this.checkBoxAlarmOnLow.UseVisualStyleBackColor = true;
            // 
            // textBoxBgHigh
            // 
            this.textBoxBgHigh.Location = new System.Drawing.Point(152, 108);
            this.textBoxBgHigh.Name = "textBoxBgHigh";
            this.textBoxBgHigh.Size = new System.Drawing.Size(37, 20);
            this.textBoxBgHigh.TabIndex = 15;
            // 
            // textBoxBgLow
            // 
            this.textBoxBgLow.Location = new System.Drawing.Point(152, 151);
            this.textBoxBgLow.Name = "textBoxBgLow";
            this.textBoxBgLow.Size = new System.Drawing.Size(37, 20);
            this.textBoxBgLow.TabIndex = 16;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(30, 431);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(134, 23);
            this.buttonSaveSettings.TabIndex = 17;
            this.buttonSaveSettings.Text = "Save settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonCloseSettings
            // 
            this.buttonCloseSettings.Location = new System.Drawing.Point(265, 431);
            this.buttonCloseSettings.Name = "buttonCloseSettings";
            this.buttonCloseSettings.Size = new System.Drawing.Size(134, 23);
            this.buttonCloseSettings.TabIndex = 18;
            this.buttonCloseSettings.Text = "Close without saving";
            this.buttonCloseSettings.UseVisualStyleBackColor = true;
            this.buttonCloseSettings.Click += new System.EventHandler(this.buttonCloseSettings_Click);
            // 
            // checkAlarmOnMissingBg
            // 
            this.checkAlarmOnMissingBg.AutoSize = true;
            this.checkAlarmOnMissingBg.Location = new System.Drawing.Point(150, 345);
            this.checkAlarmOnMissingBg.Name = "checkAlarmOnMissingBg";
            this.checkAlarmOnMissingBg.Size = new System.Drawing.Size(15, 14);
            this.checkAlarmOnMissingBg.TabIndex = 21;
            this.checkAlarmOnMissingBg.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(10, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alarm on missing Bg";
            // 
            // textMinutesForMissingBgAlarm
            // 
            this.textMinutesForMissingBgAlarm.Location = new System.Drawing.Point(176, 386);
            this.textMinutesForMissingBgAlarm.Name = "textMinutesForMissingBgAlarm";
            this.textMinutesForMissingBgAlarm.Size = new System.Drawing.Size(37, 20);
            this.textMinutesForMissingBgAlarm.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(10, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Minutes for missing Bg alarm";
            // 
            // BgSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(440, 481);
            this.Controls.Add(this.textMinutesForMissingBgAlarm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkAlarmOnMissingBg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCloseSettings);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.textBoxBgLow);
            this.Controls.Add(this.textBoxBgHigh);
            this.Controls.Add(this.checkBoxAlarmOnLow);
            this.Controls.Add(this.checkBoxAlarmOnHigh);
            this.Controls.Add(this.checkBoxAlwaysOnTop);
            this.Controls.Add(this.checkBoxAutoTrans);
            this.Controls.Add(this.checkBoxUseMmol);
            this.Controls.Add(this.labelLoowAlarm);
            this.Controls.Add(this.labelUseMmol);
            this.Controls.Add(this.labelBgHigh);
            this.Controls.Add(this.labelBgLow);
            this.Controls.Add(this.labelAutoTrans);
            this.Controls.Add(this.labelAlwaysOnTop);
            this.Controls.Add(this.labelHighAlarm);
            this.Controls.Add(this.labelNightScoutUrl);
            this.Controls.Add(this.textBoxNightUrl);
            this.Name = "BgSettings";
            this.Text = "BgMonitor Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BgSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNightUrl;
        private System.Windows.Forms.Label labelNightScoutUrl;
        private System.Windows.Forms.Label labelHighAlarm;
        private System.Windows.Forms.Label labelAlwaysOnTop;
        private System.Windows.Forms.Label labelAutoTrans;
        private System.Windows.Forms.Label labelBgLow;
        private System.Windows.Forms.Label labelBgHigh;
        private System.Windows.Forms.Label labelUseMmol;
        private System.Windows.Forms.Label labelLoowAlarm;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxUseMmol;
        private System.Windows.Forms.CheckBox checkBoxAutoTrans;
        private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
        private System.Windows.Forms.CheckBox checkBoxAlarmOnHigh;
        private System.Windows.Forms.CheckBox checkBoxAlarmOnLow;
        private System.Windows.Forms.TextBox textBoxBgHigh;
        private System.Windows.Forms.TextBox textBoxBgLow;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCloseSettings;
        private System.Windows.Forms.CheckBox checkAlarmOnMissingBg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMinutesForMissingBgAlarm;
        private System.Windows.Forms.Label label3;
    }
}