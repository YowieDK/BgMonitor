using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void BgSettings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            SetValuesOnSettingsPanel();
        }

        //Make form draggeable when no boarders
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
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
            }
            else
            {
                this.checkBoxUseMmol.Checked = false;
            }
            
            this.textBoxBgHigh.Text = appSet.BgHighValue.ToString();
            this.textBoxBgLow.Text = appSet.BgLowValue.ToString();
            this.checkBoxAutoTrans.Checked = appSet.AppAutoTransparent;
            this.checkBoxAlwaysOnTop.Checked = appSet.AppAlwaysOnTop;
            this.checkBoxAlarmOnHigh.Checked = appSet.AlarmOnHighBg;
            this.checkBoxAlarmOnLow.Checked = appSet.AlarmOnLowBg;
            this.checkAlarmOnMissingBg.Checked = appSet.AlarmOnMissingBgFromNs;
            this.textMinutesForMissingBgAlarm.Text = appSet.MinutesForBgMissingAlarm.ToString();            
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
            int tmpNumber;

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
            isNumber = int.TryParse(this.textBoxBgHigh.Text, out tmpNumber);
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
            isNumber = int.TryParse(this.textBoxBgLow.Text, out tmpNumber);
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
            isNumber = int.TryParse(this.textMinutesForMissingBgAlarm.Text, out tmpNumber);
            if (!isNumber)
            {
                urlOk = false;
                allOk = false;
                messageForMessageBox = "You must enter a number as minutes value";
                captionForMessagBox = "Minutes";
            }
            else
            {
                
                if (tmpNumber < 1 || tmpNumber > 999)
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
                int.TryParse(this.textBoxBgHigh.Text, out tmpNumber);
                appSet.BgHighValue = tmpNumber;

                int.TryParse(this.textBoxBgLow.Text, out tmpNumber);
                appSet.BgLowValue = tmpNumber; 

                appSet.AppAutoTransparent = this.checkBoxAutoTrans.Checked;
                appSet.AppAlwaysOnTop = this.checkBoxAlwaysOnTop.Checked;
                appSet.AlarmOnHighBg = this.checkBoxAlarmOnHigh.Checked;
                appSet.AlarmOnLowBg = this.checkBoxAlarmOnLow.Checked;
                appSet.AlarmOnMissingBgFromNs = this.checkAlarmOnMissingBg.Checked;

                int.TryParse(this.textMinutesForMissingBgAlarm.Text, out tmpNumber);
                appSet.MinutesForBgMissingAlarm = tmpNumber;
                appSet.SettingsIsDone = true;
                appSet.saveAllSettings();
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
    }

}
