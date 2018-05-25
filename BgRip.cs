using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace BgLevelApp
{
    class BgRip
    {
        public BgRip ()
        {
            
        }
        private MiscHelpers BgRipHelper = new MiscHelpers();        
        public string fullBg;
        private string calcBg;
        private string bgDate;
        private string minutesSinceLastBg;
        private string directionTrend;
        private DateTime dateTimeForOldBg;
        public DateTime dateTimeFromNs;

        
        public string BgDate { get => bgDate; set => bgDate = value; }
        public string MinutesSinceLastBg { get => minutesSinceLastBg; set => minutesSinceLastBg = value; }
        public DateTime DateTimeForOldBg { get => dateTimeForOldBg; set => dateTimeForOldBg = value; }
        public string CalcBg { get => calcBg; set => calcBg = value; }
        public string DirectionTrend { get => directionTrend; set => directionTrend = value; }

        public string LastBg()
        {
            Random rnd = new Random();
            int generatedPart1Bg = rnd.Next(3, 24);
            int generatedPart2Bg = rnd.Next(0, 9);

            fullBg = generatedPart1Bg.ToString() + "," + generatedPart2Bg.ToString();

            return fullBg;
        }


        public void callAddToCounter()
        {
            try
            {
                string stringFromCounter = "";
                using (WebClient client = new WebClient())
                {
                    stringFromCounter = client.DownloadString("https://us-central1-bgrtest-202711.cloudfunctions.net/BgCountAdd");
                }
                Console.WriteLine(stringFromCounter);
            }
            catch (Exception)
            {
                //do nothing if counter fails
            }
            
        }

        public string GetTrendDirection()
        {
            string directionFromNS = "";
            if (DirectionTrend != null && DirectionTrend != "")
            {
                directionFromNS = DirectionTrend;
            }
            return directionFromNS;
        }


        public string getSourceFromUrl(string nightScoutUrl)
        {
            string stringFromApi = "";
            try
            {
                if (nightScoutUrl == null)
                {
                    throw new ArgumentNullException("NightScout Url cannot be null.");
                }
                string url = nightScoutUrl + "/api/v1/entries/current.json";
                using (WebClient client = new WebClient())
                {
                    stringFromApi = client.DownloadString(url);
                    stringFromApi = stringFromApi.Replace("[", "").Replace("]", "");
                    string jsonString = stringFromApi;
                    JObject jObject = JObject.Parse(jsonString);
                    string bgId = (string)jObject.SelectToken("_id");
                    string bgDate = (string)jObject.SelectToken("date");
                    string bgSgv = (string)jObject.SelectToken("sgv");
                    string bgDateString = (string)jObject.SelectToken("dateString");
                    string bgDirection = (string)jObject.SelectToken("direction");
                    Console.WriteLine(stringFromApi);
                    Console.WriteLine("{0}, {1}, {2}", bgDateString, bgDirection, bgSgv);
                    
                    this.calcBg = BgRipHelper.ConvertBg(bgSgv);
                    DirectionTrend = bgDirection;

                    dateTimeFromNs = BgRipHelper.StrToDateTime(bgDateString);
                    //Get time since last bg reading
                    if (this.DateTimeForOldBg == DateTime.MinValue)
                    {
                        this.minutesSinceLastBg = BgRipHelper.MinutesFromDatesTillNow(dateTimeFromNs);
                        this.DateTimeForOldBg = dateTimeFromNs;
                    }
                    else if (this.DateTimeForOldBg != dateTimeFromNs)
                    {
                        this.DateTimeForOldBg = dateTimeFromNs;
                        this.minutesSinceLastBg = BgRipHelper.MinutesFromDatesTillNow(this.DateTimeForOldBg);
                    }
                    else
                    {
                        this.minutesSinceLastBg = BgRipHelper.MinutesFromDatesTillNow(this.DateTimeForOldBg);
                    }
                    /// [{"_id":"5ac638b17506964365490fdb","date":1.522.940.048.238,"dateString":"Thu Apr 05 16:54:08 CEST 2018","direction":"SingleUp","key600":"CGM80FAE727","sgv":136,"type":"sgv"}]
                }
            }
            catch (Exception)
            {
                //Do something
            }

            return stringFromApi;            
        }
    }
}
