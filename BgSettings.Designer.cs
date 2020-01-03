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
            this.textBoxNightUrl = new System.Windows.Forms.TextBox();
            this.rbtSizeBig = new System.Windows.Forms.RadioButton();
            this.rbtSizeMedium = new System.Windows.Forms.RadioButton();
            this.rbtSizeSmall = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtBackColorBlue = new System.Windows.Forms.RadioButton();
            this.rbtBackColorBlack = new System.Windows.Forms.RadioButton();
            this.checkAlarmOnMissingBg = new System.Windows.Forms.CheckBox();
            this.textMinutesForMissingBgAlarm = new System.Windows.Forms.TextBox();
            this.checkBoxStartWithWindows = new System.Windows.Forms.CheckBox();
            this.mmolRbt = new System.Windows.Forms.RadioButton();
            this.mgDlRbt = new System.Windows.Forms.RadioButton();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonCloseSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStartWithWindows = new System.Windows.Forms.Label();
            this.nsConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.alarmSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MiscGroupBox = new System.Windows.Forms.GroupBox();
            this.BacgroundColorPanel = new System.Windows.Forms.Panel();
            this.appSizePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textMinutesToMinimize = new System.Windows.Forms.TextBox();
            this.setMinimizeTimerLabel = new System.Windows.Forms.Label();
            this.setBackgroundColorLabel = new System.Windows.Forms.Label();
            this.setAppSizeLabel = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.nsConnectionGroupBox.SuspendLayout();
            this.alarmSettingsGroupBox.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            this.BacgroundColorPanel.SuspendLayout();
            this.appSizePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNightScoutUrl
            // 
            this.labelNightScoutUrl.AutoSize = true;
            this.labelNightScoutUrl.BackColor = System.Drawing.Color.Transparent;
            this.labelNightScoutUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNightScoutUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelNightScoutUrl.Location = new System.Drawing.Point(3, 21);
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
            this.labelHighAlarm.Location = new System.Drawing.Point(3, 19);
            this.labelHighAlarm.Name = "labelHighAlarm";
            this.labelHighAlarm.Size = new System.Drawing.Size(86, 15);
            this.labelHighAlarm.TabIndex = 3;
            this.labelHighAlarm.Text = "Alarm on high:";
            // 
            // labelAlwaysOnTop
            // 
            this.labelAlwaysOnTop.AutoSize = true;
            this.labelAlwaysOnTop.BackColor = System.Drawing.Color.Transparent;
            this.labelAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlwaysOnTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAlwaysOnTop.Location = new System.Drawing.Point(3, 75);
            this.labelAlwaysOnTop.Name = "labelAlwaysOnTop";
            this.labelAlwaysOnTop.Size = new System.Drawing.Size(166, 15);
            this.labelAlwaysOnTop.TabIndex = 4;
            this.labelAlwaysOnTop.Text = "Make app always stay on top:";
            this.toolTip1.SetToolTip(this.labelAlwaysOnTop, "Always on top. Can interfere with some full screen games");
            // 
            // labelAutoTrans
            // 
            this.labelAutoTrans.AutoSize = true;
            this.labelAutoTrans.BackColor = System.Drawing.Color.Transparent;
            this.labelAutoTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelAutoTrans.Location = new System.Drawing.Point(3, 102);
            this.labelAutoTrans.Name = "labelAutoTrans";
            this.labelAutoTrans.Size = new System.Drawing.Size(157, 15);
            this.labelAutoTrans.TabIndex = 5;
            this.labelAutoTrans.Text = "Make app auto transparent:";
            // 
            // labelBgLow
            // 
            this.labelBgLow.AutoSize = true;
            this.labelBgLow.BackColor = System.Drawing.Color.Transparent;
            this.labelBgLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBgLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelBgLow.Location = new System.Drawing.Point(241, 48);
            this.labelBgLow.Name = "labelBgLow";
            this.labelBgLow.Size = new System.Drawing.Size(79, 15);
            this.labelBgLow.TabIndex = 6;
            this.labelBgLow.Text = "Bg low value:";
            // 
            // labelBgHigh
            // 
            this.labelBgHigh.AutoSize = true;
            this.labelBgHigh.BackColor = System.Drawing.Color.Transparent;
            this.labelBgHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBgHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelBgHigh.Location = new System.Drawing.Point(3, 46);
            this.labelBgHigh.Name = "labelBgHigh";
            this.labelBgHigh.Size = new System.Drawing.Size(84, 15);
            this.labelBgHigh.TabIndex = 7;
            this.labelBgHigh.Text = "Bg high value:";
            // 
            // labelUseMmol
            // 
            this.labelUseMmol.AutoSize = true;
            this.labelUseMmol.BackColor = System.Drawing.Color.Transparent;
            this.labelUseMmol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseMmol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelUseMmol.Location = new System.Drawing.Point(3, 19);
            this.labelUseMmol.Name = "labelUseMmol";
            this.labelUseMmol.Size = new System.Drawing.Size(158, 15);
            this.labelUseMmol.TabIndex = 8;
            this.labelUseMmol.Text = "Use mmol/L or mg/dL units:";
            // 
            // labelLoowAlarm
            // 
            this.labelLoowAlarm.AutoSize = true;
            this.labelLoowAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelLoowAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoowAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelLoowAlarm.Location = new System.Drawing.Point(241, 19);
            this.labelLoowAlarm.Name = "labelLoowAlarm";
            this.labelLoowAlarm.Size = new System.Drawing.Size(81, 15);
            this.labelLoowAlarm.TabIndex = 9;
            this.labelLoowAlarm.Text = "Alarm on low:";
            // 
            // checkBoxUseMmol
            // 
            this.checkBoxUseMmol.AutoSize = true;
            this.checkBoxUseMmol.Location = new System.Drawing.Point(347, 21);
            this.checkBoxUseMmol.Name = "checkBoxUseMmol";
            this.checkBoxUseMmol.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUseMmol.TabIndex = 10;
            this.checkBoxUseMmol.UseVisualStyleBackColor = true;
            this.checkBoxUseMmol.Visible = false;
            // 
            // checkBoxAutoTrans
            // 
            this.checkBoxAutoTrans.AutoSize = true;
            this.checkBoxAutoTrans.Location = new System.Drawing.Point(189, 104);
            this.checkBoxAutoTrans.Name = "checkBoxAutoTrans";
            this.checkBoxAutoTrans.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoTrans.TabIndex = 11;
            this.toolTip1.SetToolTip(this.checkBoxAutoTrans, "You can make app auto transparent. The closer to 6 mmol/L \r\nor 108 mg/dL your BG " +
        "is, the less visible the app is.");
            this.checkBoxAutoTrans.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(189, 78);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlwaysOnTop.TabIndex = 12;
            this.toolTip1.SetToolTip(this.checkBoxAlwaysOnTop, "Turn off if problems with fullscreen games");
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlarmOnHigh
            // 
            this.checkBoxAlarmOnHigh.AutoSize = true;
            this.checkBoxAlarmOnHigh.Location = new System.Drawing.Point(106, 21);
            this.checkBoxAlarmOnHigh.Name = "checkBoxAlarmOnHigh";
            this.checkBoxAlarmOnHigh.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlarmOnHigh.TabIndex = 13;
            this.toolTip1.SetToolTip(this.checkBoxAlarmOnHigh, "Turn BG high alarm on and off");
            this.checkBoxAlarmOnHigh.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlarmOnLow
            // 
            this.checkBoxAlarmOnLow.AutoSize = true;
            this.checkBoxAlarmOnLow.Location = new System.Drawing.Point(334, 21);
            this.checkBoxAlarmOnLow.Name = "checkBoxAlarmOnLow";
            this.checkBoxAlarmOnLow.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlarmOnLow.TabIndex = 14;
            this.toolTip1.SetToolTip(this.checkBoxAlarmOnLow, "Turn low BG alarm on and off");
            this.checkBoxAlarmOnLow.UseVisualStyleBackColor = true;
            // 
            // textBoxBgHigh
            // 
            this.textBoxBgHigh.Location = new System.Drawing.Point(106, 45);
            this.textBoxBgHigh.Name = "textBoxBgHigh";
            this.textBoxBgHigh.Size = new System.Drawing.Size(37, 22);
            this.textBoxBgHigh.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBoxBgHigh, "set BG value where you want BG high alarm to sound");
            // 
            // textBoxBgLow
            // 
            this.textBoxBgLow.Location = new System.Drawing.Point(334, 45);
            this.textBoxBgLow.Name = "textBoxBgLow";
            this.textBoxBgLow.Size = new System.Drawing.Size(37, 22);
            this.textBoxBgLow.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBoxBgLow, "set BG value where you want BG low alarm to sound");
            // 
            // textBoxNightUrl
            // 
            this.textBoxNightUrl.Location = new System.Drawing.Point(118, 19);
            this.textBoxNightUrl.Name = "textBoxNightUrl";
            this.textBoxNightUrl.Size = new System.Drawing.Size(254, 22);
            this.textBoxNightUrl.TabIndex = 0;
            this.textBoxNightUrl.Text = "https://YOUR_SITE_HERE";
            this.toolTip1.SetToolTip(this.textBoxNightUrl, "Ex. https://{yoursite}.herokuapp.com or https://{yoursite}.azurewebsites.net");
            // 
            // rbtSizeBig
            // 
            this.rbtSizeBig.AutoSize = true;
            this.rbtSizeBig.Location = new System.Drawing.Point(33, 3);
            this.rbtSizeBig.Name = "rbtSizeBig";
            this.rbtSizeBig.Size = new System.Drawing.Size(45, 20);
            this.rbtSizeBig.TabIndex = 35;
            this.rbtSizeBig.TabStop = true;
            this.rbtSizeBig.Text = "Big";
            this.toolTip1.SetToolTip(this.rbtSizeBig, "Set app size to big");
            this.rbtSizeBig.UseVisualStyleBackColor = true;
            // 
            // rbtSizeMedium
            // 
            this.rbtSizeMedium.AutoSize = true;
            this.rbtSizeMedium.Location = new System.Drawing.Point(84, 3);
            this.rbtSizeMedium.Name = "rbtSizeMedium";
            this.rbtSizeMedium.Size = new System.Drawing.Size(72, 20);
            this.rbtSizeMedium.TabIndex = 36;
            this.rbtSizeMedium.TabStop = true;
            this.rbtSizeMedium.Text = "Medium";
            this.toolTip1.SetToolTip(this.rbtSizeMedium, "Set app size to big");
            this.rbtSizeMedium.UseVisualStyleBackColor = true;
            // 
            // rbtSizeSmall
            // 
            this.rbtSizeSmall.AutoSize = true;
            this.rbtSizeSmall.Location = new System.Drawing.Point(159, 3);
            this.rbtSizeSmall.Name = "rbtSizeSmall";
            this.rbtSizeSmall.Size = new System.Drawing.Size(59, 20);
            this.rbtSizeSmall.TabIndex = 37;
            this.rbtSizeSmall.TabStop = true;
            this.rbtSizeSmall.Text = "Small";
            this.toolTip1.SetToolTip(this.rbtSizeSmall, "Set app size to big");
            this.rbtSizeSmall.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 20);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Big";
            this.toolTip1.SetToolTip(this.radioButton1, "Set app size to big");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 20);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Small";
            this.toolTip1.SetToolTip(this.radioButton2, "Set app size to big");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(84, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 20);
            this.radioButton3.TabIndex = 36;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Medium";
            this.toolTip1.SetToolTip(this.radioButton3, "Set app size to big");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtBackColorBlue
            // 
            this.rbtBackColorBlue.AutoSize = true;
            this.rbtBackColorBlue.Location = new System.Drawing.Point(33, 3);
            this.rbtBackColorBlue.Name = "rbtBackColorBlue";
            this.rbtBackColorBlue.Size = new System.Drawing.Size(52, 20);
            this.rbtBackColorBlue.TabIndex = 35;
            this.rbtBackColorBlue.TabStop = true;
            this.rbtBackColorBlue.Text = "Blue";
            this.toolTip1.SetToolTip(this.rbtBackColorBlue, "Set app background color to blue");
            this.rbtBackColorBlue.UseVisualStyleBackColor = true;
            // 
            // rbtBackColorBlack
            // 
            this.rbtBackColorBlack.AutoSize = true;
            this.rbtBackColorBlack.Location = new System.Drawing.Point(110, 3);
            this.rbtBackColorBlack.Name = "rbtBackColorBlack";
            this.rbtBackColorBlack.Size = new System.Drawing.Size(59, 20);
            this.rbtBackColorBlack.TabIndex = 36;
            this.rbtBackColorBlack.TabStop = true;
            this.rbtBackColorBlack.Text = "Black";
            this.toolTip1.SetToolTip(this.rbtBackColorBlack, "Set app background color to blue");
            this.rbtBackColorBlack.UseVisualStyleBackColor = true;
            // 
            // checkAlarmOnMissingBg
            // 
            this.checkAlarmOnMissingBg.AutoSize = true;
            this.checkAlarmOnMissingBg.Location = new System.Drawing.Point(191, 86);
            this.checkAlarmOnMissingBg.Name = "checkAlarmOnMissingBg";
            this.checkAlarmOnMissingBg.Size = new System.Drawing.Size(15, 14);
            this.checkAlarmOnMissingBg.TabIndex = 21;
            this.toolTip1.SetToolTip(this.checkAlarmOnMissingBg, "Turn missing BG alarm on and off");
            this.checkAlarmOnMissingBg.UseVisualStyleBackColor = true;
            // 
            // textMinutesForMissingBgAlarm
            // 
            this.textMinutesForMissingBgAlarm.Location = new System.Drawing.Point(190, 107);
            this.textMinutesForMissingBgAlarm.Name = "textMinutesForMissingBgAlarm";
            this.textMinutesForMissingBgAlarm.Size = new System.Drawing.Size(37, 22);
            this.textMinutesForMissingBgAlarm.TabIndex = 24;
            this.toolTip1.SetToolTip(this.textMinutesForMissingBgAlarm, "Set the time, in minutes, before alarm sounds when no new BG from NightScout has " +
        "been recived");
            // 
            // checkBoxStartWithWindows
            // 
            this.checkBoxStartWithWindows.AutoSize = true;
            this.checkBoxStartWithWindows.Location = new System.Drawing.Point(263, 51);
            this.checkBoxStartWithWindows.Name = "checkBoxStartWithWindows";
            this.checkBoxStartWithWindows.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStartWithWindows.TabIndex = 26;
            this.toolTip1.SetToolTip(this.checkBoxStartWithWindows, "Check to make app start with Windows");
            this.checkBoxStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // mmolRbt
            // 
            this.mmolRbt.AutoSize = true;
            this.mmolRbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mmolRbt.Location = new System.Drawing.Point(172, 18);
            this.mmolRbt.Name = "mmolRbt";
            this.mmolRbt.Size = new System.Drawing.Size(69, 20);
            this.mmolRbt.TabIndex = 29;
            this.mmolRbt.TabStop = true;
            this.mmolRbt.Text = "mmol/L";
            this.toolTip1.SetToolTip(this.mmolRbt, "View BG values in mmol/L units");
            this.mmolRbt.UseVisualStyleBackColor = true;
            this.mmolRbt.CheckedChanged += new System.EventHandler(this.mmolRbt_CheckedChanged);
            // 
            // mgDlRbt
            // 
            this.mgDlRbt.AutoSize = true;
            this.mgDlRbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mgDlRbt.Location = new System.Drawing.Point(252, 18);
            this.mgDlRbt.Name = "mgDlRbt";
            this.mgDlRbt.Size = new System.Drawing.Size(62, 20);
            this.mgDlRbt.TabIndex = 30;
            this.mgDlRbt.TabStop = true;
            this.mgDlRbt.Text = "mg/dL";
            this.toolTip1.SetToolTip(this.mgDlRbt, "View BG values in mg/dL units");
            this.mgDlRbt.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(10, 458);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(134, 23);
            this.buttonSaveSettings.TabIndex = 17;
            this.buttonSaveSettings.Text = "Save settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonCloseSettings
            // 
            this.buttonCloseSettings.Location = new System.Drawing.Point(157, 459);
            this.buttonCloseSettings.Name = "buttonCloseSettings";
            this.buttonCloseSettings.Size = new System.Drawing.Size(134, 23);
            this.buttonCloseSettings.TabIndex = 18;
            this.buttonCloseSettings.Text = "Close without saving";
            this.buttonCloseSettings.UseVisualStyleBackColor = true;
            this.buttonCloseSettings.Click += new System.EventHandler(this.buttonCloseSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alarm on/off for missing Bg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(2, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Minutes untill missing Bg alarm:";
            // 
            // labelStartWithWindows
            // 
            this.labelStartWithWindows.AutoSize = true;
            this.labelStartWithWindows.BackColor = System.Drawing.Color.Transparent;
            this.labelStartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartWithWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelStartWithWindows.Location = new System.Drawing.Point(3, 48);
            this.labelStartWithWindows.Name = "labelStartWithWindows";
            this.labelStartWithWindows.Size = new System.Drawing.Size(245, 15);
            this.labelStartWithWindows.TabIndex = 25;
            this.labelStartWithWindows.Text = "Make BgMonitor start when Windows starts:";
            // 
            // nsConnectionGroupBox
            // 
            this.nsConnectionGroupBox.Controls.Add(this.labelNightScoutUrl);
            this.nsConnectionGroupBox.Controls.Add(this.textBoxNightUrl);
            this.nsConnectionGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsConnectionGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nsConnectionGroupBox.Location = new System.Drawing.Point(10, 9);
            this.nsConnectionGroupBox.Name = "nsConnectionGroupBox";
            this.nsConnectionGroupBox.Size = new System.Drawing.Size(385, 52);
            this.nsConnectionGroupBox.TabIndex = 27;
            this.nsConnectionGroupBox.TabStop = false;
            this.nsConnectionGroupBox.Text = "NightScout connection";
            // 
            // alarmSettingsGroupBox
            // 
            this.alarmSettingsGroupBox.Controls.Add(this.textMinutesForMissingBgAlarm);
            this.alarmSettingsGroupBox.Controls.Add(this.label3);
            this.alarmSettingsGroupBox.Controls.Add(this.checkAlarmOnMissingBg);
            this.alarmSettingsGroupBox.Controls.Add(this.label2);
            this.alarmSettingsGroupBox.Controls.Add(this.textBoxBgLow);
            this.alarmSettingsGroupBox.Controls.Add(this.textBoxBgHigh);
            this.alarmSettingsGroupBox.Controls.Add(this.checkBoxAlarmOnLow);
            this.alarmSettingsGroupBox.Controls.Add(this.checkBoxAlarmOnHigh);
            this.alarmSettingsGroupBox.Controls.Add(this.labelLoowAlarm);
            this.alarmSettingsGroupBox.Controls.Add(this.labelBgHigh);
            this.alarmSettingsGroupBox.Controls.Add(this.labelBgLow);
            this.alarmSettingsGroupBox.Controls.Add(this.labelHighAlarm);
            this.alarmSettingsGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmSettingsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.alarmSettingsGroupBox.Location = new System.Drawing.Point(10, 69);
            this.alarmSettingsGroupBox.Name = "alarmSettingsGroupBox";
            this.alarmSettingsGroupBox.Size = new System.Drawing.Size(385, 144);
            this.alarmSettingsGroupBox.TabIndex = 28;
            this.alarmSettingsGroupBox.TabStop = false;
            this.alarmSettingsGroupBox.Text = "Alarm settings";
            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.BacgroundColorPanel);
            this.MiscGroupBox.Controls.Add(this.appSizePanel);
            this.MiscGroupBox.Controls.Add(this.textMinutesToMinimize);
            this.MiscGroupBox.Controls.Add(this.setMinimizeTimerLabel);
            this.MiscGroupBox.Controls.Add(this.setBackgroundColorLabel);
            this.MiscGroupBox.Controls.Add(this.setAppSizeLabel);
            this.MiscGroupBox.Controls.Add(this.mgDlRbt);
            this.MiscGroupBox.Controls.Add(this.mmolRbt);
            this.MiscGroupBox.Controls.Add(this.checkBoxStartWithWindows);
            this.MiscGroupBox.Controls.Add(this.labelStartWithWindows);
            this.MiscGroupBox.Controls.Add(this.checkBoxAlwaysOnTop);
            this.MiscGroupBox.Controls.Add(this.checkBoxAutoTrans);
            this.MiscGroupBox.Controls.Add(this.checkBoxUseMmol);
            this.MiscGroupBox.Controls.Add(this.labelAutoTrans);
            this.MiscGroupBox.Controls.Add(this.labelUseMmol);
            this.MiscGroupBox.Controls.Add(this.labelAlwaysOnTop);
            this.MiscGroupBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MiscGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MiscGroupBox.Location = new System.Drawing.Point(10, 223);
            this.MiscGroupBox.Name = "MiscGroupBox";
            this.MiscGroupBox.Size = new System.Drawing.Size(385, 219);
            this.MiscGroupBox.TabIndex = 31;
            this.MiscGroupBox.TabStop = false;
            this.MiscGroupBox.Text = "Miscellaneous";
            // 
            // BacgroundColorPanel
            // 
            this.BacgroundColorPanel.Controls.Add(this.rbtBackColorBlue);
            this.BacgroundColorPanel.Controls.Add(this.rbtBackColorBlack);
            this.BacgroundColorPanel.Location = new System.Drawing.Point(156, 148);
            this.BacgroundColorPanel.Name = "BacgroundColorPanel";
            this.BacgroundColorPanel.Size = new System.Drawing.Size(221, 27);
            this.BacgroundColorPanel.TabIndex = 39;
            // 
            // appSizePanel
            // 
            this.appSizePanel.Controls.Add(this.panel1);
            this.appSizePanel.Controls.Add(this.rbtSizeBig);
            this.appSizePanel.Controls.Add(this.rbtSizeSmall);
            this.appSizePanel.Controls.Add(this.rbtSizeMedium);
            this.appSizePanel.Location = new System.Drawing.Point(156, 123);
            this.appSizePanel.Name = "appSizePanel";
            this.appSizePanel.Size = new System.Drawing.Size(221, 27);
            this.appSizePanel.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 27);
            this.panel1.TabIndex = 39;
            // 
            // textMinutesToMinimize
            // 
            this.textMinutesToMinimize.Location = new System.Drawing.Point(189, 177);
            this.textMinutesToMinimize.Name = "textMinutesToMinimize";
            this.textMinutesToMinimize.Size = new System.Drawing.Size(37, 22);
            this.textMinutesToMinimize.TabIndex = 34;
            // 
            // setMinimizeTimerLabel
            // 
            this.setMinimizeTimerLabel.AutoSize = true;
            this.setMinimizeTimerLabel.BackColor = System.Drawing.Color.Transparent;
            this.setMinimizeTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setMinimizeTimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setMinimizeTimerLabel.Location = new System.Drawing.Point(2, 179);
            this.setMinimizeTimerLabel.Name = "setMinimizeTimerLabel";
            this.setMinimizeTimerLabel.Size = new System.Drawing.Size(169, 15);
            this.setMinimizeTimerLabel.TabIndex = 33;
            this.setMinimizeTimerLabel.Text = "Set minutes to minimize app: ";
            // 
            // setBackgroundColorLabel
            // 
            this.setBackgroundColorLabel.AutoSize = true;
            this.setBackgroundColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.setBackgroundColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBackgroundColorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setBackgroundColorLabel.Location = new System.Drawing.Point(2, 152);
            this.setBackgroundColorLabel.Name = "setBackgroundColorLabel";
            this.setBackgroundColorLabel.Size = new System.Drawing.Size(150, 15);
            this.setBackgroundColorLabel.TabIndex = 32;
            this.setBackgroundColorLabel.Text = "Set app background color:";
            // 
            // setAppSizeLabel
            // 
            this.setAppSizeLabel.AutoSize = true;
            this.setAppSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.setAppSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAppSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.setAppSizeLabel.Location = new System.Drawing.Point(3, 126);
            this.setAppSizeLabel.Name = "setAppSizeLabel";
            this.setAppSizeLabel.Size = new System.Drawing.Size(110, 15);
            this.setAppSizeLabel.TabIndex = 31;
            this.setAppSizeLabel.Text = "Set size of the app:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(310, 459);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 23);
            this.buttonReset.TabIndex = 32;
            this.buttonReset.Text = "Reset settings";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // BgSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 488);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.MiscGroupBox);
            this.Controls.Add(this.alarmSettingsGroupBox);
            this.Controls.Add(this.nsConnectionGroupBox);
            this.Controls.Add(this.buttonCloseSettings);
            this.Controls.Add(this.buttonSaveSettings);
            this.Name = "BgSettings";
            this.Text = "BgMonitor Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BgSettings_Load);
            this.nsConnectionGroupBox.ResumeLayout(false);
            this.nsConnectionGroupBox.PerformLayout();
            this.alarmSettingsGroupBox.ResumeLayout(false);
            this.alarmSettingsGroupBox.PerformLayout();
            this.MiscGroupBox.ResumeLayout(false);
            this.MiscGroupBox.PerformLayout();
            this.BacgroundColorPanel.ResumeLayout(false);
            this.BacgroundColorPanel.PerformLayout();
            this.appSizePanel.ResumeLayout(false);
            this.appSizePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.CheckBox checkBoxStartWithWindows;
        private System.Windows.Forms.Label labelStartWithWindows;
        private System.Windows.Forms.GroupBox nsConnectionGroupBox;
        private System.Windows.Forms.TextBox textBoxNightUrl;
        private System.Windows.Forms.GroupBox alarmSettingsGroupBox;
        private System.Windows.Forms.RadioButton mmolRbt;
        private System.Windows.Forms.RadioButton mgDlRbt;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton rbtSizeSmall;
        private System.Windows.Forms.RadioButton rbtSizeMedium;
        private System.Windows.Forms.RadioButton rbtSizeBig;
        private System.Windows.Forms.TextBox textMinutesToMinimize;
        private System.Windows.Forms.Label setMinimizeTimerLabel;
        private System.Windows.Forms.Label setAppSizeLabel;
        private System.Windows.Forms.Label setBackgroundColorLabel;
        private System.Windows.Forms.Panel appSizePanel;
        private System.Windows.Forms.Panel BacgroundColorPanel;
        private System.Windows.Forms.RadioButton rbtBackColorBlue;
        private System.Windows.Forms.RadioButton rbtBackColorBlack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}