using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BgLevelApp
{
    public partial class BgSettings : Form
    {
        private AppSettings appSet = new AppSettings();
        private MiscHelpers newMiscHelper = new MiscHelpers();

        public BgSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        // ********************** Make moveable Start ****************
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        void moveOnMouseDownOnSettings(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        // *****************  Make moveable End *******************

        private void BgSettings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //Add mouse down to components to make form draggeable
            this.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            nsConnectionGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            alarmSettingsGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            MiscGroupBox.MouseDown += new MouseEventHandler(moveOnMouseDownOnSettings);
            SetValuesOnSettingsPanel();
        }
       
        public void SetValuesOnSettingsPanel()
        {
            appSet.getAllSettings();
            if (newMiscHelper.CheckConnectionToNs(appSet.NightscoutUrl) == "ok")
            {
                this.textBoxNightUrl.Text = appSet.NightscoutUrl;
            }
            if (appSet.AppShowMmolOrMgDl == "mmol")
            {
                this.checkBoxUseMmol.Checked = true;
                //set value of dummy radiobuttons
                mmolRbt.Checked = true;
                mgDlRbt.Checked = false;               
            }
            else
            {
                this.checkBoxUseMmol.Checked = false;
                //set value of dummy radiobuttons
                mmolRbt.Checked = false;
                mgDlRbt.Checked = true;
            }
            
            this.textBoxBgHigh.Text = appSet.BgHighValue.ToString();
            this.textBoxBgLow.Text = appSet.BgLowValue.ToString();
            this.checkBoxAutoTrans.Checked = appSet.AppAutoTransparent;
            this.checkBoxAlwaysOnTop.Checked = appSet.AppAlwaysOnTop;
            this.checkBoxAlarmOnHigh.Checked = appSet.AlarmOnHighBg;
            this.checkBoxAlarmOnLow.Checked = appSet.AlarmOnLowBg;
            this.checkAlarmOnMissingBg.Checked = appSet.AlarmOnMissingBgFromNs;
            this.textMinutesForMissingBgAlarm.Text = appSet.MinutesForBgMissingAlarm.ToString();
            this.checkBoxStartWithWindows.Checked = appSet.StartWithWindows;
        }

        public bool saveValuesFromSettingsForm()
        {
            bool allOk = true;
            bool urlOk = true;
            bool bgHighOk = true;
            bool bgLowOk = true;
            bool minutesForMissingBgOk = true;
            string messageForMessageBox = "Error";
            string captionForMessagBox = "Error";
            bool isNumber;
            double tmpNumber;
            int tmpMinutesNumber;

            //Check value entered in NightScoutURL
            //Remove / in end of url, as it is noT allowed
            if (this.textBoxNightUrl.Text.EndsWith("/"))
            {
                this.textBoxNightUrl.Text = this.textBoxNightUrl.Text.Substring(0, (this.textBoxNightUrl.Text.Length - 1));
            }

            if (!(newMiscHelper.CheckConnectionToNs(this.textBoxNightUrl.Text) == "ok"))
            {
                urlOk = false;
                allOk = false;
                messageForMessageBox = "URL for NightScout is not valid or site not responding";
                captionForMessagBox = "Url for NightScout";
            }

            //Check value entered in high Bg
            isNumber = double.TryParse(this.textBoxBgHigh.Text, out tmpNumber);
            if (!isNumber)
            {
                urlOk = false;
                allOk = false;
                messageForMessageBox = "You must enter a number as Bg high value";
                captionForMessagBox = "Bg high";
            }
            else
            {
                //If units is in mmol
                if (checkBoxUseMmol.Checked && (tmpNumber < 6 || tmpNumber > 20))
                {
                    urlOk = false;
                    allOk = false;
                    messageForMessageBox = "You must enter a number between 6 and 20 as Bg high value";
                    captionForMessagBox = "Bg high";
                }
                else if (!checkBoxUseMmol.Checked && (tmpNumber < 108 || tmpNumber > 360)) //If units in mg/dl
                {
                    urlOk = false;
                    allOk = false;
                    messageForMessageBox = "You must enter a number between 108 and 360 as Bg high value";
                    captionForMessagBox = "Bg high";
                }

            }

            //Check value entered in Low Bg
            isNumber = double.TryParse(this.textBoxBgLow.Text, out tmpNumber);
            if (!isNumber)
            {
                urlOk = false;
                allOk = false;
                messageForMessageBox = "You must enter a number as Bg Low value";
                captionForMessagBox = "Bg Low";
            }
            else
            {
                //If units is in mmol
                if (checkBoxUseMmol.Checked && (tmpNumber < 2 || tmpNumber > 6))
                {
                    urlOk = false;
                    allOk = false;
                    messageForMessageBox = "You must enter a number between 2 and 6 as Bg Low value";
                    captionForMessagBox = "Bg Low";
                }
                else if (!checkBoxUseMmol.Checked && (tmpNumber < 36 || tmpNumber > 108)) //If units in mg/dl
                {
                    urlOk = false;
                    allOk = false;
                    messageForMessageBox = "You must enter a number between 36 and 108 as Bg Low value";
                    captionForMessagBox = "Bg Low";
                }

            }

            //Check if entered minutes is ok
            isNumber = int.TryParse(this.textMinutesForMissingBgAlarm.Text, out tmpMinutesNumber);
            if (!isNumber)
            {
                urlOk = false;
                allOk = false;
                messageForMessageBox = "You must enter a number as minutes value";
                captionForMessagBox = "Minutes";
            }
            else
            {
                
                if (tmpMinutesNumber < 1 || tmpMinutesNumber > 999)
                {
                    urlOk = false;
                    allOk = false;
                    messageForMessageBox = "You must enter a number between 6 and 20 as minutes";
                    captionForMessagBox = "minutes";
                }
            }


            if (!allOk)
            {
                //Show error message
                MessageBox.Show(messageForMessageBox, captionForMessagBox);
            }
            else
            {
               //Set and save all settings                
                try
                { 
                    //Call method in helpers
                    newMiscHelper.MakeAppStartWithWindows(this.checkBoxStartWithWindows.Checked);                  
                
                    //Save if all ok
                    appSet.NightscoutUrl = this.textBoxNightUrl.Text;
                    if (this.checkBoxUseMmol.Checked)
                    {
                    
                        appSet.AppShowMmolOrMgDl = "mmol";
                    }
                    else
                    {
                        appSet.AppShowMmolOrMgDl = "mgDl";
                    }
                    double.TryParse(this.textBoxBgHigh.Text, out tmpNumber);
                    appSet.BgHighValue = tmpNumber;

                    double.TryParse(this.textBoxBgLow.Text, out tmpNumber);
                    appSet.BgLowValue = tmpNumber;

                    appSet.StartWithWindows = this.checkBoxStartWithWindows.Checked;
                    appSet.AppAutoTransparent = this.checkBoxAutoTrans.Checked;
                    appSet.AppAlwaysOnTop = this.checkBoxAlwaysOnTop.Checked;
                    appSet.AlarmOnHighBg = this.checkBoxAlarmOnHigh.Checked;
                    appSet.AlarmOnLowBg = this.checkBoxAlarmOnLow.Checked;
                    appSet.AlarmOnMissingBgFromNs = this.checkAlarmOnMissingBg.Checked;

                    int.TryParse(this.textMinutesForMissingBgAlarm.Text, out tmpMinutesNumber);
                    appSet.MinutesForBgMissingAlarm = tmpMinutesNumber;
                    appSet.SettingsIsDone = true;
                    appSet.saveAllSettings();
                }
                catch (Exception)
                {
                    //To Doo error message
                }
            }


            return allOk;
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (saveValuesFromSettingsForm())
            {
                this.Close();
            }
        }

        private void buttonCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mmolRbt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (mmolRbt.Checked)
                {
                    //Check the checkbox acuatually in charge of this
                    checkBoxUseMmol.Checked = true;
                    //change alarm value when changing between mmol and mg/dL 
                    var tmpBgHighAsInt = 0;
                    var bgHighIsNumber = int.TryParse(this.textBoxBgHigh.Text , out tmpBgHighAsInt);
                    var tmpBgLowAsInt = 0;
                    var bgLowIsNumber = int.TryParse(this.textBoxBgLow.Text, out tmpBgLowAsInt);
                    if (bgHighIsNumber && bgLowIsNumber)
                    {
                        //If BG high or low is set higher than 30, we assume that it is a mg/dL value
                        if (tmpBgHighAsInt > 30)
                        {
                            var calculatedMmolHighBg = Math.Round(((double)tmpBgHighAsInt / 18), 1);
                            textBoxBgHigh.Text = calculatedMmolHighBg.ToString();
                        }
                        if (tmpBgLowAsInt > 30)
                        {
                            var calculatedMmolLowBg = Math.Round(((double)tmpBgLowAsInt / 18), 1);
                            textBoxBgLow.Text = calculatedMmolLowBg.ToString();
                        }
                    }
                }
                else
                {
                    checkBoxUseMmol.Checked = false;
                    //change alarm value when changing between mmol and mg/dL 
                    var tmpBgHighAsInt = 0.0;
                    var bgHighIsNumber = double.TryParse(this.textBoxBgHigh.Text, out tmpBgHighAsInt);
                    var tmpBgLowAsInt = 0.0;
                    var bgLowIsNumber = double.TryParse(this.textBoxBgLow.Text, out tmpBgLowAsInt);
                    if (bgHighIsNumber && bgLowIsNumber)
                    {
                        //If BG high or low is set higher than 30, we assume that it is a mg/dL value
                        if (tmpBgHighAsInt < 30)
                        {
                            var calculatedMmolHighBg = Math.Round(((double)tmpBgHighAsInt * 18));
                            textBoxBgHigh.Text = calculatedMmolHighBg.ToString();
                        }
                        if (tmpBgLowAsInt < 30)
                        {
                            var calculatedMmolLowBg = Math.Round(((double)tmpBgLowAsInt * 18));
                            textBoxBgLow.Text = calculatedMmolLowBg.ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //To doo error handling
            }
        }
    }

}
