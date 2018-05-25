using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace BgLevelApp
{
    class Alarm
    {
        private AppSettings appSetAlarm = new AppSettings();
        private SoundPlayer alarmSound = new SoundPlayer(Properties.Resources.alarmSoundWav);
        public bool alarmBgIsOn = false;
        public bool alarmBgIsSnoozed = false;
        public bool alarmTimeIsOn = false;
        public bool alarmTimeIsSnoozed = false;

        public void StartBgAlarm()
        {
            if (!alarmBgIsOn && !alarmBgIsSnoozed)
            {
                alarmSound.PlayLooping();
                alarmBgIsOn = true;
            }
        }

        public void StopBgAlarm()
        {
            if (alarmBgIsOn)
            {
                alarmSound.Stop();
                alarmBgIsOn = false;
            }
        }

        public void SnoozeBgAlarm()
        {
            alarmBgIsSnoozed = true;
            StopBgAlarm();
        }

        public void StartTimeAlarm()
        {
            if (!alarmTimeIsOn && !alarmTimeIsSnoozed)
            {
                alarmSound.PlayLooping();                
                alarmTimeIsOn = true;
            }
        }

        public void StopTimeAlarm()
        {
            if (alarmTimeIsOn)
            {
                alarmSound.Stop();
                alarmTimeIsOn = false;
            }
        }

        public void SnoozeTimeAlarm()
        {
            alarmTimeIsSnoozed = true;
            StopTimeAlarm();
        }


    }
}
