using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.Diagnostics;

namespace BgLevelApp
{
    class AppSettings
    {
        public AppSettings()
        {
            //Reset settings if debug
        /*if (Debugger.IsAttached)
                Properties.Settings.Default.Reset();  */              
            getAllSettings();       
        }

        private string nightscoutUrl;
        private string appShowMmolOrMgDl;
        private int bgHighValue;
        private int bgLowValue;
        private bool appAutoTransparent;
        private int appWindowHight;
        private int appWindowWidth;
        private Point poiappWindowLocation = new Point();
        private bool appAlwaysOnTop;
        private bool licenseAgrRead;
        private bool alarmOnHighBg;
        private bool alarmOnLowBg;
        private bool alarmOnMissingBgFromNs;
        private int minutesForBgMissingAlarm;
        private bool settingsIsDone;


        public string NightscoutUrl { get => nightscoutUrl; set => nightscoutUrl = value; }

        public string AppShowMmolOrMgDl { get => appShowMmolOrMgDl; set => appShowMmolOrMgDl = value; }
        public int BgHighValue { get => bgHighValue; set => bgHighValue = value; }
        public int BgLowValue { get => bgLowValue; set => bgLowValue = value; }
        public bool AppAutoTransparent { get => appAutoTransparent; set => appAutoTransparent = value; }
        public int AppWindowHight { get => appWindowHight; set => appWindowHight = value; }
        public int AppWindowWidth { get => appWindowWidth; set => appWindowWidth = value; }
        public Point PoiappWindowLocation { get => poiappWindowLocation; set => poiappWindowLocation = value; }
        public bool AppAlwaysOnTop { get => appAlwaysOnTop; set => appAlwaysOnTop = value; }
        public bool LicenseAgrRead { get => licenseAgrRead; set => licenseAgrRead = value; }
        public bool AlarmOnHighBg { get => alarmOnHighBg; set => alarmOnHighBg = value; }
        public bool AlarmOnLowBg { get => alarmOnLowBg; set => alarmOnLowBg = value; }
        public bool AlarmOnMissingBgFromNs { get => alarmOnMissingBgFromNs; set => alarmOnMissingBgFromNs = value; }
        public int MinutesForBgMissingAlarm { get => minutesForBgMissingAlarm; set => minutesForBgMissingAlarm = value; }
        public bool SettingsIsDone { get => settingsIsDone; set => settingsIsDone = value; }

        public void getAllSettings(){
          /*  Properties.Settings.Default.mmolOrMgDl = "mgDl";
            Properties.Settings.Default.Save();*/
            nightscoutUrl = Properties.Settings.Default.urlForNightScout;
            appShowMmolOrMgDl = Properties.Settings.Default.mmolOrMgDl;
            bgHighValue = Properties.Settings.Default.bgHigh;
            bgLowValue = Properties.Settings.Default.bgLow;
            appAutoTransparent = Properties.Settings.Default.autoTransparent;
            appWindowHight = Properties.Settings.Default.windowHight;
            appWindowWidth = Properties.Settings.Default.windowWidth;
            poiappWindowLocation = Properties.Settings.Default.windowLocation;
            appAlwaysOnTop = Properties.Settings.Default.appOnTop;
            licenseAgrRead = Properties.Settings.Default.licenseRead;
            alarmOnHighBg = Properties.Settings.Default.alarmOnHigh;
            alarmOnLowBg = Properties.Settings.Default.alarmOnLow;
            alarmOnMissingBgFromNs = Properties.Settings.Default.alarmOnMissingBg;
            minutesForBgMissingAlarm = Properties.Settings.Default.timeForMissingBg;
            settingsIsDone = Properties.Settings.Default.settingsDoneOk;
        }

        public void saveAllSettings() {
            Properties.Settings.Default.urlForNightScout = nightscoutUrl;
            Properties.Settings.Default.mmolOrMgDl = appShowMmolOrMgDl;
            Properties.Settings.Default.bgHigh = bgHighValue;
            Properties.Settings.Default.bgLow = bgLowValue;
            Properties.Settings.Default.autoTransparent = appAutoTransparent;
            Properties.Settings.Default.windowHight = appWindowHight;
            Properties.Settings.Default.windowWidth = appWindowWidth;
            Properties.Settings.Default.windowLocation = poiappWindowLocation;
            Properties.Settings.Default.appOnTop = appAlwaysOnTop;
            Properties.Settings.Default.licenseRead = licenseAgrRead;
            Properties.Settings.Default.alarmOnHigh = alarmOnHighBg;
            Properties.Settings.Default.alarmOnLow = alarmOnLowBg;
            Properties.Settings.Default.alarmOnMissingBg = alarmOnMissingBgFromNs;
            Properties.Settings.Default.timeForMissingBg = minutesForBgMissingAlarm;
            Properties.Settings.Default.settingsDoneOk = settingsIsDone;

            Properties.Settings.Default.Save();

            //Call tick to get the value updated when settings change
            Globals.form.CallBgTick();
        }

    }
}
