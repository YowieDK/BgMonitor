using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BgLevelApp
{
    public partial class BgMonitor : Form
    {
        private BgRip newBgRip = new BgRip();
        private MiscHelpers NewHelper = new MiscHelpers();
        private AppSettings appSet = new AppSettings();
        private Alarm alarm = new Alarm();
        public bool hoverClose = false;
        private bool mouseIsOverApp = false;
        private bool mouseIsOverSettings = false;
        private bool mouseIsOverLicense = false;
        private bool mouseIsOverBgLabel = false;
        private bool mouseIsOverMinnustSince = false;
        private bool mouseIsOverClose = false;
        private bool bgHighAlarmActive = false;
        private bool bgHighAlarmStopped = false;
        private bool bgLowAlarmActive = false;
        private bool bgLowAlarmStopped = false;
        private bool missingBgAlarmActive = false;
        private bool missingBgAlarmStopped = false;
        private bool connectionAlarmStopped = false;
        private bool connectionError = false; 
        private bool connectionAlarmOn = false;
        private int previousMinutes = 0;


        public int scalingNumberGlobal = 1;

        public BgMonitor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Make moveable
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        void moveOnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool colorAndSizeIsSet = false;
                //set this form global so I can use functions from this class from other classes
                Globals.form = this;

                if (!appSet.LicenseAgrRead)
                {
                    LicenseAgrement licenseWindow = new LicenseAgrement();
                    licenseWindow.ShowDialog();
                }

                //Set size and color if settings and license is done. This is done to make sure you don't see default color and size before it changes
                if (appSet.SettingsIsDone && appSet.LicenseAgrRead)
                {
                    //Setbackground color
                    SetBackgroundColor(appSet.BackgroundColor);
                    //Set app size
                    ScaleApp(appSet.ApplicationSize);
                    colorAndSizeIsSet = true;
                }

                //Make form moveable MinimizedBox
                this.MouseDown += new MouseEventHandler(moveOnMouseDown);
                BgLabel.MouseDown += new MouseEventHandler(moveOnMouseDown);
                minutesSinceLastBgLabel.MouseDown += new MouseEventHandler(moveOnMouseDown);
                ArrowStraitBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                ArrowOneUpBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                ArrowOneDownBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                ArrowDoubleUpBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                ArrowDoubleDownBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                Arrow45UpBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                Arrow45DownBox.MouseDown += new MouseEventHandler(moveOnMouseDown);
                //MinimizedBox.MouseDown += new MouseEventHandler(moveOnMouseDown);

                this.FormClosing += new FormClosingEventHandler(bgMonitor_FormClosing);
                this.TopMost = appSet.AppAlwaysOnTop;
                this.FormBorderStyle = FormBorderStyle.None;

                double windowScale = 1.0;
                int windowWidth = this.Width;
                int windowHeight = this.Height;

                this.Width = System.Convert.ToInt32(Math.Round(windowWidth * windowScale));
                this.Height = System.Convert.ToInt32(Math.Round(windowHeight * windowScale));
                closeWindow.Location = new Point(System.Convert.ToInt32(Math.Round(closeWindow.Location.X * windowScale)), System.Convert.ToInt32(Math.Round(closeWindow.Location.Y * windowScale)));

                //Hide alarm indicator
                this.AlarmpictureBox.Hide();
                appSet.getAllSettings();
                if (NewHelper.CheckConnectionToNs(appSet.NightscoutUrl) == "ok")
                {
                    newBgRip.getSourceFromUrl(appSet.NightscoutUrl);
                    minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes since last sgv";
                    var BgLabelText = newBgRip.CalcBg;
                    BgLabel.Text = BgLabelText;
                    BgLabel.ForeColor = NewHelper.CalculateColorFromBg(BgLabelText);
                }
                //Start timer
                GetBgTimer.Start();

                //Start timer that closes the app to avoid closing exception
                if (!appSet.LicenseAgrRead)
                {
                    CloseDownTimer.Start();
                }
                else
                {
                    this.Enabled = true;
                }

                //Open settings if not done and licensagreement read and accepted
                BgSettings settingsWindow = new BgSettings();
                if (!appSet.SettingsIsDone && appSet.LicenseAgrRead)
                {
                    settingsWindow.ShowDialog();
                    appSet.getAllSettings();

                }

                //Get first bg here
                GetBg_Tick(null, null);

                //make syre this don't run twice in load app
                if (!colorAndSizeIsSet)
                {
                    //Setbackground color
                    SetBackgroundColor(appSet.BackgroundColor);
                    //Set app size
                    ScaleApp(appSet.ApplicationSize);
                }

                //Set minimize tooltip                               
                SetButtonMinimizeToolTopText(appSet.MinutesToMinimize.ToString());

                //Call add to opened counter
                newBgRip.callAddToCounter();
            }
            catch (Exception)
            {
                //TODO
            }
        }

        //Set tooltip text
        public void SetButtonMinimizeToolTopText(string toolTipMinutsText)
        {
            string template = "Minimize app for {0} minutes";
            string minutesData = toolTipMinutsText;
            string toolTipMessage = string.Format(template, minutesData);
            toolTip1.SetToolTip(buttonMinimized, toolTipMessage);
        }
        //Kill the alarm untill next alarm
        public void KillAlarm()
        {
            if (bgLowAlarmActive || bgHighAlarmActive)
            {
                bgHighAlarmStopped = true;
                bgLowAlarmStopped = true;
            }
            if (missingBgAlarmActive)
            {
                missingBgAlarmStopped = true;
            }
            if (connectionError)
            {
                connectionAlarmStopped = true;
                connectionAlarmOn = false;
            }
            TurnOnAlarm(BgLabel.Text);
        }


        //Snooze the alarm
        public void SnoozeAlarm(int minutesToSnooze)
        {
            if (bgLowAlarmActive || bgHighAlarmActive)
            {
                SnoozeBgTimer.Interval = minutesToSnooze * 60000;
                bgLowAlarmActive = false;
                bgHighAlarmActive = false;
                alarm.alarmBgIsSnoozed = true;
                this.AlarmpictureBox.Hide();
                SnoozeBgTimer.Start();
                alarm.StopBgAlarm();
            }

            if (missingBgAlarmActive || connectionError)
            {
                SnoozeMinutesSinceTimer.Interval = minutesToSnooze * 60000;
                missingBgAlarmActive = false;
                connectionError = false;
                connectionAlarmOn = false;
                alarm.alarmTimeIsSnoozed = true;
                this.AlarmpictureBox.Hide();
                SnoozeMinutesSinceTimer.Start();
                alarm.StopTimeAlarm();
            }
        }

        //Turns on alarms if needed
        private void TurnOnAlarm(string bgvalue)
        {
            double bgAsDouble = NewHelper.BgStringToDouble(bgvalue);
            int minutesSinceLastBgAlarm = appSet.MinutesForBgMissingAlarm;
            int minutesGoneSinceLastBg;
            if (!connectionError)
            {
                minutesGoneSinceLastBg = int.Parse(newBgRip.MinutesSinceLastBg);
                previousMinutes = minutesGoneSinceLastBg;
            }
            else
            {
                minutesGoneSinceLastBg = previousMinutes;
            }
            

            //Check for alarm on high and low bg if we have a readable bg
            if (bgAsDouble != -99)
            {
                double highBgValue = appSet.BgHighValue;
                double lowBgValue = appSet.BgLowValue;

                //check for low and high bg alarm
                if (bgAsDouble >= highBgValue || bgAsDouble <= lowBgValue)
                {
                    if (!alarm.alarmBgIsSnoozed)
                    {
                        if (appSet.AlarmOnHighBg && !bgHighAlarmStopped && bgAsDouble >= highBgValue)
                        {
                            alarm.StartBgAlarm();
                            bgHighAlarmActive = true;
                            this.AlarmpictureBox.Show();
                        }
                        else
                        {
                            bgHighAlarmActive = false;
                        }

                        if (appSet.AlarmOnLowBg && !bgLowAlarmStopped && bgAsDouble <= lowBgValue)
                        {
                            alarm.StartBgAlarm();
                            bgLowAlarmActive = true;
                            this.AlarmpictureBox.Show();
                        }
                        else
                        {
                            bgLowAlarmActive = false;
                        }

                        if (!bgLowAlarmActive && !bgHighAlarmActive && !missingBgAlarmActive)
                        {
                            alarm.StopBgAlarm();
                            this.AlarmpictureBox.Hide();
                        }
                    }
                }
                else
                {
                    alarm.StopBgAlarm();
                    if (!missingBgAlarmActive)
                    {
                        this.AlarmpictureBox.Hide();
                    }
                    bgHighAlarmStopped = false;
                    bgHighAlarmActive = false;
                    bgLowAlarmStopped = false;
                    bgLowAlarmActive = false;
                }
            }
            else
            {
                alarm.StopBgAlarm();
                if (!missingBgAlarmActive)
                {
                    this.AlarmpictureBox.Hide();
                }
                bgHighAlarmStopped = false;
                bgHighAlarmActive = false;
                bgLowAlarmStopped = false;
                bgLowAlarmActive = false;
            }

            //Check for missing bg alarm 
            if (minutesSinceLastBgAlarm <= minutesGoneSinceLastBg)
            {
                if (!alarm.alarmTimeIsSnoozed)
                {
                    if (appSet.AlarmOnMissingBgFromNs && !missingBgAlarmStopped && minutesSinceLastBgAlarm <= minutesGoneSinceLastBg)
                    {
                        alarm.StartTimeAlarm();
                        missingBgAlarmActive = true;
                        this.AlarmpictureBox.Show();
                    }
                    else
                    {
                        missingBgAlarmActive = false;
                        alarm.StopTimeAlarm();
                        if (!bgLowAlarmActive && !bgHighAlarmActive)
                        {
                            this.AlarmpictureBox.Hide();
                        }
                    }
                }
            }
            else
            {
                alarm.StopTimeAlarm();
                if (!bgLowAlarmActive && !bgHighAlarmActive)
                {
                    this.AlarmpictureBox.Hide();
                }
                missingBgAlarmActive = false;
                missingBgAlarmStopped = false;
            }

        }

        // Show and hide the direction arrow based on NS value
        private void HandleTrend(string direction)
        {
            if (scalingNumberGlobal == 1 || scalingNumberGlobal == 2)
            {
                switch (direction)
                {
                    case "Flat":
                        ArrowStraitBox.Visible = true;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;

                    case "SingleDown":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = true;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;

                    case "SingleUp":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = true;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;

                    case "FortyFiveUp":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = true;
                        Arrow45DownBox.Visible = false;
                        break;

                    case "FortyFiveDown":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = true;
                        break;

                    case "DoubleDown":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = true;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;

                    case "DoubleUp":
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = true;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;

                    default:
                        ArrowStraitBox.Visible = false;
                        ArrowOneUpBox.Visible = false;
                        ArrowOneDownBox.Visible = false;
                        ArrowDoubleUpBox.Visible = false;
                        ArrowDoubleDownBox.Visible = false;
                        Arrow45UpBox.Visible = false;
                        Arrow45DownBox.Visible = false;
                        break;
                }
            }
            else
            {
                ArrowStraitBox.Visible = false;
                ArrowOneUpBox.Visible = false;
                ArrowOneDownBox.Visible = false;
                ArrowDoubleUpBox.Visible = false;
                ArrowDoubleDownBox.Visible = false;
                Arrow45UpBox.Visible = false;
                Arrow45DownBox.Visible = false;
            }
        }

        //Made to be able to call GetBg_Tick from other class fx. when steeings is updated
        public void CallBgTick()
        {
            GetBg_Tick(null, null);
        }

        public void StartCloseDownTimer()
        {
            CloseDownTimer.Start();
        }

        public void SetBgLabelTooltip(string TooltipText)
        {
            toolTip1.SetToolTip(this.BgLabel, TooltipText);
                           
        }

        //public method so SetBacground can be called from other class, 1 for blue and 2 for black
        public void SetBackgroundColor(int color)
        {
            if (color == 2)
            {
                this.BackgroundImage = Properties.Resources.BackgroundBlackElipse;
                buttonMinimized.Image = Properties.Resources.minimize15White;
                buttonInfoHelp.BackgroundImage = Properties.Resources.InfoWhite;
                buttonSettings.BackgroundImage = Properties.Resources.settingsIcoWhite;
                buttonGoToNS.Image = Properties.Resources.NSlogoWhite;
            }
            else if (color ==1)
            {
                this.BackgroundImage = Properties.Resources.BackgroundBlueElipse;
                buttonMinimized.Image = Properties.Resources.minimize15;
                buttonInfoHelp.BackgroundImage = Properties.Resources.Info;
                buttonSettings.BackgroundImage = Properties.Resources.settingsIco;
                buttonGoToNS.Image = Properties.Resources.NSlogoBlack;
            }
        }

        //When app is cllosing do this
        void bgMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
           // appSet.saveAllSettings();
        }       

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();    
            
        }

        //Set opacity onMouse enter and leave on components on the form
        private void Form1_MouseHover(object sender, EventArgs e)
        {            
            mouseIsOverApp = true;
            this.Opacity = 1.0;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverApp = false;
            transparentOffTimer.Start();
        }


        private void BgLabel_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverBgLabel = true;
            this.Opacity = 1.0;
        }

        private void BgLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverBgLabel = false;
            transparentOffTimer.Start();

        }


        private void licensAgree_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverLicense = true;
            this.Opacity = 1.0;
        }

        private void licensAgree_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverLicense = false;
            transparentOffTimer.Start();
        }

        private void buttonSettings_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverSettings = true;
            this.Opacity = 1.0;
        }

        private void buttonSettings_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverSettings = false;
            transparentOffTimer.Start();
        }

        private void minutesSinceLastBgLabel_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverMinnustSince = true;
            this.Opacity = 1.0;
        }

        private void minutesSinceLastBgLabel_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverMinnustSince = false;
            transparentOffTimer.Start();
        }

        private void closeWindow_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void closeWindow_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        //Set opacity when mouse is over direction labels
        private void ArrowStraitBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void ArrowStraitBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        private void ArrowOneUpBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void ArrowOneUpBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        private void ArrowOneDownBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void ArrowOneDownBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        private void ArrowDoubleUpBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void ArrowDoubleUpBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        private void ArrowDoubleDownBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void ArrowDoubleDownBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        private void Arrow45UpBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void Arrow45UpBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }

        private void Arrow45DownBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void Arrow45DownBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }
        //Minimize button
        private void MinimizedBox_MouseHover(object sender, EventArgs e)
        {
            mouseIsOverClose = true;
            this.Opacity = 1.0;
        }

        private void MinimizedBox_MouseLeave(object sender, EventArgs e)
        {
            mouseIsOverClose = false;
            transparentOffTimer.Start();
        }

        private void transparentOffTimer_Tick(object sender, EventArgs e)
        {
            if (!mouseIsOverApp && !mouseIsOverSettings && !mouseIsOverLicense && !mouseIsOverBgLabel && !mouseIsOverMinnustSince && !mouseIsOverClose && !bgLowAlarmActive && !bgHighAlarmActive && !missingBgAlarmActive)
            {
                double opacity = (double)(NewHelper.GetTransparencyPercentage(BgLabel.Text));
                this.Opacity = opacity;                
            }
            transparentOffTimer.Stop();
        }

        private void BgLabel_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetBg_Tick(object sender, EventArgs e)
        {
            string BgToShow;
            //Update steeings
            appSet.getAllSettings();
            //Get bg from nightschout
           if (NewHelper.CheckConnectionToNs(appSet.NightscoutUrl) == "ok")
            {
                //Reset connection alarm stop and connection error if connection is ok, if connection is back
                connectionError = false;
                connectionAlarmStopped = false;
                newBgRip.getSourceFromUrl(appSet.NightscoutUrl);
                BgToShow = newBgRip.CalcBg;
                BgLabel.Text = BgToShow;
                //Get minutes since last update from nightScout
                if (scalingNumberGlobal == 1)
                {
                    minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes since last sgv";
                }
                else
                {
                    minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes";
                }
                //Set Font 
                this.BgLabel.Font = NewHelper.GetFontForBgLabel(scalingNumberGlobal);
                //Get color for text
                BgLabel.ForeColor = NewHelper.CalculateColorFromBg(BgToShow);
                //Check for alarm
                TurnOnAlarm(BgToShow);
                //Set trend arrow
                string newDirection = newBgRip.GetTrendDirection();
                HandleTrend(newDirection);
                //Set opacity
                if (!mouseIsOverApp && !mouseIsOverSettings && !mouseIsOverLicense && !mouseIsOverBgLabel && !mouseIsOverMinnustSince && !mouseIsOverClose && !bgLowAlarmActive && !bgHighAlarmActive && !missingBgAlarmActive)
                {
                    double opacity = (double)(NewHelper.GetTransparencyPercentage(BgToShow));
                    this.Opacity = opacity;
                }
                else
                {
                    this.Opacity = 1;
                }

                //set always on top
                if (appSet.AppAlwaysOnTop)
                {
                    this.TopMost = true;
                }
                else
                {
                    this.TopMost = false;
                }                
            }
            else
            {
                //Set connection error indicator
                connectionError = true;
                if (!alarm.alarmTimeIsSnoozed)
                {
                    if (!connectionAlarmStopped && !connectionAlarmOn && appSet.SettingsIsDone)
                    {
                        alarm.StartTimeAlarm();
                        connectionAlarmOn = true;
                        this.AlarmpictureBox.Show();
                        BgLabel.Text = "---";                        //Show error message
                        MessageBox.Show("Bg monitor can not access your NightScout site. \nPlease check your internet connection and NightScout site", "Connection error");
                    }                   
                }
            }
        }


        private void CloseDownTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoHelp_Click(object sender, EventArgs e)
        {
            InfoFormWindow infoWindow = new InfoFormWindow();
            infoWindow.ShowDialog();            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            BgSettings settingsWindowButton = new BgSettings();
            settingsWindowButton.ShowDialog();
        }

        private void AlarmpictureBox_Click(object sender, EventArgs e)
        {
            Point alarmActionLocation;
            alarmActionPanel alarmPanel = new alarmActionPanel();
            if (scalingNumberGlobal == 1)
            {
                alarmActionLocation = new Point(this.Location.X + 200, this.Location.Y + 178);
            }
            else if (scalingNumberGlobal == 2)
            {
                alarmActionLocation = new Point(this.Location.X + 143, this.Location.Y + 147);
            }
            else
            {
                alarmActionLocation = new Point(this.Location.X + 74, this.Location.Y + 101);
            }
            alarmPanel.StartPosition = FormStartPosition.Manual;
            alarmPanel.Location = alarmActionLocation;
            alarmPanel.ShowDialog();
            
        }

        private void SnoozeBgTimer_Tick(object sender, EventArgs e)
        {            
            alarm.alarmBgIsSnoozed = false;
            SnoozeBgTimer.Stop();
            TurnOnAlarm(BgLabel.Text);
        }

        private void SnoozeMinutesSinceTimer_Tick(object sender, EventArgs e)
        {
            alarm.alarmTimeIsSnoozed = false;
            SnoozeMinutesSinceTimer.Stop();
            TurnOnAlarm(BgLabel.Text);
        }

        private void ArrowOneDownBox_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeTimer_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MinimizeTimer.Stop();
        }

        private void MinimizedBox_Click(object sender, EventArgs e)
        {
            MinimizeTimer.Stop();
            this.WindowState = FormWindowState.Minimized;
            appSet.getAllSettings();
            var millisecondsToMinimizeApp = appSet.MinutesToMinimize * 60000;
            MinimizeTimer.Interval = millisecondsToMinimizeApp;             
            MinimizeTimer.Start();
        }

        //Click on big scaling
        private void Size1Box_Click(object sender, EventArgs e)
        {
            ScaleApp(1);
        }
        //Click on medium scaling
        private void Size2Box_Click(object sender, EventArgs e)
        {
            ScaleApp(2);
        }
        //click on small scaling
        private void Size3Box_Click(object sender, EventArgs e)
        {
            ScaleApp(3);
        }
        //Set size, hide, show and posistion on components when the app is resized
        public void ScaleApp(int scalingNumber)
        {
            //Scaling big
            if (scalingNumber == 1)
            {
                scalingNumberGlobal = 1;
                //Set size of form as all locations goes from that
                this.Size = new Size(300, 223);
                //Set location of all the components
                ArrowStraitBox.Location = new Point(235, 90);
                ArrowOneUpBox.Location = new Point(235, 90);
                ArrowOneDownBox.Location = new Point(235, 90);
                ArrowDoubleUpBox.Location = new Point(235, 90);
                ArrowDoubleDownBox.Location = new Point(235, 90);
                Arrow45UpBox.Location = new Point(235, 90);
                Arrow45DownBox.Location = new Point(235, 90);
                AlarmpictureBox.Location = new Point(204, 160);
                BgLabel.Location = new Point(31, 55);
                minutesSinceLastBgLabel.Location = new Point(76, 40);
                buttonMinimized.Location = new Point(95, 174);                
                buttonSettings.Location = new Point(165, 177);
                closeWindow.Location = new Point(141, 12);
                buttonGoToNS.Location = new Point(13, 94);
                     

                //Set the size font of some of the components             
                BgLabel.Size = new Size(216, 108);
                minutesSinceLastBgLabel.Size = new Size(165, 15);
                buttonGoToNS.Size = new Size(28, 38);
                BgLabel.Font = new Font(BgLabel.Font.FontFamily, 72);
                minutesSinceLastBgLabel.Font = new Font(minutesSinceLastBgLabel.Font.FontFamily, 9, FontStyle.Bold);
                

                //Set text in minutes 
                minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes since last sgv";

                //Show and hide components that are not visible in all views
                buttonMinimized.Show();
                buttonInfoHelp.Show();               
            }
            //scaling medium
            if (scalingNumber == 2)
            {
                scalingNumberGlobal = 2;
                //Set size of form as all locations goes from that
                this.Size = new Size(236, 175);
                //Set location of all the components
                ArrowStraitBox.Location = new Point(175, 60);
                ArrowOneUpBox.Location = new Point(175, 60);
                ArrowOneDownBox.Location = new Point(175, 60);
                ArrowDoubleUpBox.Location = new Point(175, 60);
                ArrowDoubleDownBox.Location = new Point(175, 60);
                Arrow45UpBox.Location = new Point(175, 60);
                Arrow45DownBox.Location = new Point(175, 60);
                AlarmpictureBox.Location = new Point(145, 129);
                BgLabel.Location = new Point(28, 39);
                minutesSinceLastBgLabel.Location = new Point(83, 34);
                buttonMinimized.Location = new Point(79, 130);
                buttonSettings.Location = new Point(114, 130);
                closeWindow.Location = new Point(111, 9);
                buttonGoToNS.Location = new Point(10, 75);


                //Set the size font of some of the components             
                BgLabel.Size = new Size(175, 90);
                buttonGoToNS.Size = new Size(22, 30);
                minutesSinceLastBgLabel.Size = new Size(76, 15);
                BgLabel.Font = new Font(BgLabel.Font.FontFamily, 56);
                minutesSinceLastBgLabel.Font = new Font(minutesSinceLastBgLabel.Font.FontFamily, 9, FontStyle.Bold);
                

                //Set text in minutes 
                minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes";

                //Show and hide components that are not visible in all views
                buttonMinimized.Show();
                buttonInfoHelp.Hide();
            }
            //scaling small
            if (scalingNumber == 3)
            {
                scalingNumberGlobal = 3;
                //Set size of form as all locations goes from that
                this.Size = new Size(150, 116);
                //Set location of all the components
                AlarmpictureBox.Location = new Point(74, 84);
                BgLabel.Location = new Point(26, 25);
                minutesSinceLastBgLabel.Location = new Point(46, 21);                
                buttonSettings.Location = new Point(43, 78);
                closeWindow.Location = new Point(67, 2);
                buttonGoToNS.Location = new Point(6, 45);

                //Set the size font of some of the components             
                BgLabel.Size = new Size(121, 50);
                buttonGoToNS.Size = new Size(20, 27);
                minutesSinceLastBgLabel.Size = new Size(67, 13);
                BgLabel.Font = new Font(BgLabel.Font.FontFamily, 36);
                minutesSinceLastBgLabel.Font = new Font(minutesSinceLastBgLabel.Font.FontFamily, 7, FontStyle.Bold);                

                //Set text in minutes 
                minutesSinceLastBgLabel.Text = newBgRip.MinutesSinceLastBg + " Minutes";

                //Show and hide components that are not visible in all views
                buttonMinimized.Hide();
                buttonInfoHelp.Hide();
                ArrowStraitBox.Visible = false;
                ArrowOneUpBox.Visible = false;
                ArrowOneDownBox.Visible = false;
                ArrowDoubleUpBox.Visible = false;
                ArrowDoubleDownBox.Visible = false;
                Arrow45UpBox.Visible = false;
                Arrow45DownBox.Visible = false;
            }

        }

        private void buttonGoToNS_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Ns in default browser
                System.Diagnostics.Process.Start(appSet.NightscoutUrl);
            }
            catch (Exception)
            {
                //TODO error message
            }
        }

        //set tmp Visibillity when window becomes active
        private void BgMonitor_Activated(object sender, EventArgs e)
        {
            var appOpacity = this.Opacity;
            if (appOpacity != 1)
            {
                this.Opacity = 1.0;
                transparentOffTimer.Start();
            }
        }
    }
}
