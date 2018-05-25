using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;


namespace BgLevelApp
{
    class MiscHelpers
    {        
        private AppSettings appSetMisc = new AppSettings();
        private Dictionary<string, string> myTimeZones = new Dictionary<string, string>() {{"ACDT", "+1030"},{"ACST", "+0930"}, {"ADT", "-0300"},{"AEDT", "+1100"},{"AEST", "+1000"},{"AHDT", "-0900"},{"AHST", "-1000"},{"AST", "-0400"},{"AT", "-0200"},{"AWDT", "+0900"},{"AWST", "+0800"},{"BAT", "+0300"},{"BDST", "+0200"},{"BET", "-1100"},{"BST", "-0300"},{"BT", "+0300"},{"BZT2", "-0300"},{"CADT", "+1030"},{"CAST", "+0930"},{"CAT", "-1000"},{"CCT", "+0800"},{"CDT", "-0500"},{"CED", "+0200"},{"CET", "+0100"},{"CEST", "+0200"},{"CST", "-0600"},{"EAST", "+1000"},{"EDT", "-0400"},{"EED", "+0300"},{"EET", "+0200"},{"EEST", "+0300"},{"EST", "-0500"},{"FST", "+0200"},{"FWT", "+0100"},{"GMT", "GMT"},{"GST", "+1000"},{"HDT", "-0900"},{"HST", "-1000"},{"IDLE", "+1200"},{"IDLW", "-1200"},{"IST", "+0530"},{"IT", "+0330"},{"JST", "+0900"},{"JT", "+0700"},{"MDT", "-0600"},{"MED", "+0200"},{"MET", "+0100"},{"MEST", "+0200"},{"MEWT", "+0100"},{"MST", "-0700"},{"MT", "+0800"},{"NDT", "-0230"},{"NFT", "-0330"},{"NT", "-1100"},{"NST", "+0630"},{"NZ", "+1100"},{"NZST", "+1200"},{"NZDT", "+1300"},{"NZT", "+1200"},{"PDT", "-0700"},{"PST", "-0800"},{"ROK", "+0900"},{"SAD", "+1000"},{"SAST", "+0900"},{"SAT", "+0900"},{"SDT", "+1000"},{"SST", "+0200"},{"SWT", "+0100"},{"USZ3", "+0400"},{"USZ4", "+0500"},{"USZ5", "+0600"},{"USZ6", "+0700"},{"UT", "-0000"},{"UTC", "-0000"},{"UZ10", "+1100"},{"WAT", "-0100"},{"WET", "-0000"},{"WST", "+0800"},{"YDT", "-0800"},{"YST", "-0900"},{"ZP4", "+0400"},{"ZP5", "+0500"},{"ZP6", "+0600"}};

        public double BgStringToDouble(string bgIn) {
            double bgOut = -99;
            bool didConvert = false;
            if (bgIn != null)
            {
                didConvert = double.TryParse(bgIn, out bgOut);                
            }
            if (!didConvert)
            {
                bgOut = -99;
            }

            return bgOut;
        }

        //Returns font for bg label
        public Font GetFontForBgLabel(int currentScale)
        {            
            BgRip bgRipMisc = new BgRip();
            appSetMisc.getAllSettings();
            bgRipMisc.getSourceFromUrl(appSetMisc.NightscoutUrl);
            Font returnFont;
            if (currentScale == 1)
            {
                returnFont = new Font("Impact", 72, FontStyle.Regular);
            }
            else if (currentScale == 2)
            {
                returnFont = new Font("Impact", 56, FontStyle.Regular);
            }
            else
            {
                returnFont = new Font("Impact", 36, FontStyle.Regular);
            }
            try
            {
                int minutesSinceLastBg = int.Parse(bgRipMisc.MinutesSinceLastBg);
                if (minutesSinceLastBg > 18)
                {
                    if (currentScale == 1)
                    {
                        returnFont = new Font("Impact", 72, FontStyle.Strikeout | FontStyle.Italic);
                    }
                    else if (currentScale == 2)
                    {
                        returnFont = new Font("Impact", 56, FontStyle.Strikeout | FontStyle.Italic);
                    }
                    else
                    {
                        returnFont = new Font("Impact", 36, FontStyle.Strikeout | FontStyle.Italic);
                    }
                    
                }
            }
            catch (Exception)
            {
                //What to doo
            }

            return returnFont;
        }

        public string ConvertBg(string bgAsMgDl)
        {
            string calculatedBg;
            float tmpCalcFloat;
            appSetMisc.getAllSettings();

            if (appSetMisc.AppShowMmolOrMgDl == "mgDl")
            {
                tmpCalcFloat = float.Parse(bgAsMgDl);
                if (tmpCalcFloat <= 30)
                {
                    calculatedBg = "---";
                }
                else
                {
                    calculatedBg = bgAsMgDl;
                }
            }
            else
            {
                tmpCalcFloat = float.Parse(bgAsMgDl);
                if (tmpCalcFloat <= 30)
                { calculatedBg = "---";
                }
                else
                {
                    calculatedBg = Math.Round((tmpCalcFloat / 18), 1).ToString();
                }
            }

            return calculatedBg;
        }
        public string MinutesFromDatesTillNow(DateTime oldTime)
        {
            DateTime dateTimeNow = DateTime.Now ;
            string timeDiffString;
            try
            {
                int totalMinutes = (int)(dateTimeNow - oldTime).TotalMinutes;
                if (totalMinutes >=0)
                { 
                timeDiffString = Convert.ToString(totalMinutes);
                }
                else
                {
                    timeDiffString = "--";
                }
            }
            catch (Exception) {
                timeDiffString = "--";
            }
            return timeDiffString;
        }

        public DateTime StrToDateTime(string strDateTime)
        {
            //Handle crappy dates from api :-)            
            var dateStrPart1 = strDateTime.Substring(0,strDateTime.LastIndexOf(' ')).Trim(); 
            dateStrPart1 = dateStrPart1.Substring(dateStrPart1.LastIndexOf(' ')).Trim();            
            string valueFromTimeZones;
            if (!myTimeZones.TryGetValue(dateStrPart1, out valueFromTimeZones))
            {
                //the key isn't in the dictionary set to central eurpean time.
                valueFromTimeZones = "+0200";
            }
            DateTime returnDateTime = new DateTime();
            CultureInfo provider = CultureInfo.InvariantCulture;
            var format = "ddd MMM dd HH:mm:ss zzz yyyy";            
            returnDateTime = DateTime.ParseExact(strDateTime.Replace(dateStrPart1, valueFromTimeZones), format, provider);
            //returnDateTime = DateTime.ParseExact(dateStrModi, format, provider);

            return returnDateTime;
        }

        //Calculate taansparentcyrate
        public double GetTransparencyPercentage(string bgIn)
        {
            appSetMisc.getAllSettings();   
            float bgAsFloat;
            int multiplexFactor = 1;
            if (appSetMisc.AppShowMmolOrMgDl == "mgDl")
            {
                multiplexFactor = 18;
            }
            double transPer = 0.5;
            bool didConvert = float.TryParse(bgIn,out bgAsFloat);
            if (didConvert && appSetMisc.AppAutoTransparent)
            {                
                int FULL_NON_TRANS_UP = 10 * multiplexFactor;
                int FULL_NON_TRANS_DOWN = 4 * multiplexFactor;
                int MEDIAN_MOST_TRANS = 6 * multiplexFactor;

                if (bgAsFloat < FULL_NON_TRANS_DOWN || bgAsFloat > FULL_NON_TRANS_UP)
                {
                    transPer = 100;
                }
                else
                {
                    double spanValueUp = (FULL_NON_TRANS_UP - MEDIAN_MOST_TRANS);
                    double spanValueDown = (MEDIAN_MOST_TRANS - FULL_NON_TRANS_DOWN);
                    
                    if (bgAsFloat > MEDIAN_MOST_TRANS)
                    {
                        double bgOverMedian = (bgAsFloat - MEDIAN_MOST_TRANS);
                        double onePercentValue = 100 / spanValueUp;
                        transPer = (onePercentValue * bgOverMedian) / 100;
                    }
                    else
                    {
                        double bgUnderMedian = (MEDIAN_MOST_TRANS - bgAsFloat);
                        double onePercentValue = 100 / spanValueDown;
                        transPer = (onePercentValue * bgUnderMedian) / 100;
                    }
                }
                //Set the least amount of transparency
                if (transPer < 0.04)
                {
                    transPer = 0.04;
                }
            }
            else
            {
                transPer = 1.0;
            }

            return transPer;
        }

        public Color CalculateGradientColor(int percentGreenToRed)
        {
            Color calcColorForBg;
            int rgbR;
            int rgbG;
            float tmpCalcValue;
            if (percentGreenToRed < 50)
            {
                tmpCalcValue = ((255 / 50) * (percentGreenToRed));
                rgbR = (int)Math.Round(tmpCalcValue);
                rgbG = 255;
            }
            else
            {
                int invertedValue = 100 - percentGreenToRed;
                tmpCalcValue = ((255 / 50) * (invertedValue));
                rgbR = 255;
                rgbG = (int)Math.Round(tmpCalcValue);
            }

            calcColorForBg = Color.FromArgb(rgbR, rgbG, 0);
            return calcColorForBg;
        }

        private int percentFromMidHigh(float currentHighBg)
        {
            var bgHigh = appSetMisc.BgHighValue;
            int multiplexFactor = 1;
            if (appSetMisc.AppShowMmolOrMgDl == "mgDl")
            {
                multiplexFactor = 18;
            }
            int percentcolor;
            double spanValue = (bgHigh - (5.5* multiplexFactor));
            double bgOver5_5 = (currentHighBg - (5.5 * multiplexFactor));
            double onePercentValue =  100/ spanValue;
            percentcolor = (int)(onePercentValue * bgOver5_5);
            return percentcolor;
        }

        private int percentFromMidLow(float currentLowBg)
        {
            int multiplexFactor = 1;
            if (appSetMisc.AppShowMmolOrMgDl == "mgDl")
            {
                multiplexFactor = 18;
            }
            var bgLow = appSetMisc.BgLowValue;
            int percentColor;
            double spanValue = ((multiplexFactor*5.5) - bgLow);
            double bgUnder5_5 = ((multiplexFactor * 5.5) - currentLowBg);
            double onePercentValue = 100 / spanValue;
            percentColor = (int)(onePercentValue * bgUnder5_5);
            return percentColor;
        }

        public Color CalculateColorFromBg(string bg)
        {
            var textForToolTip = "";
            Color calcColorForBg;
            Double numForTest;
            string bgReplased = bg.Replace(",",".");
            var bgHigh = appSetMisc.BgHighValue;
            var bgLow = appSetMisc.BgLowValue;
            float currentBg;
            if (bg == "---" || !Double.TryParse(bg, out numForTest))
            {
                calcColorForBg = Color.Red;
                textForToolTip = "No BG from NightScout. Can be missing calibration";
            }
            else if ((appSetMisc.AppShowMmolOrMgDl == "mmol" && numForTest < 1.8) || (appSetMisc.AppShowMmolOrMgDl == "mgDl" && numForTest < 30))
            {
                textForToolTip = "No BG from NightScout. Can be missing calibration";
                calcColorForBg = Color.Red;
            }
            else
            {
                currentBg = float.Parse(bg);                

                if (currentBg >= bgHigh)
                {
                    calcColorForBg = Color.Red;
                }
                else if (currentBg <= bgLow)
                {
                    calcColorForBg = Color.Red;
                }
                else if (currentBg >= 5.5)
                {
                    if (bgHigh <= 5.5)
                    {
                        calcColorForBg = Color.Red;
                    }
                    else
                    {
                        calcColorForBg = CalculateGradientColor(percentFromMidHigh(currentBg));
                    }
                }
                else if (currentBg <= 5.5)
                {
                    if (bgLow >= 5.5)
                    {
                        calcColorForBg = Color.Red;
                    }
                    else
                    {
                        calcColorForBg = CalculateGradientColor(percentFromMidLow(currentBg));
                    }
                }
                else {
                    calcColorForBg = Color.FromArgb(255, 0, 0);
                }
                textForToolTip = "BG from NightScout.";
            }
            //Need to call globals to call function in Form1 class
            Globals.form.SetBgLabelTooltip(textForToolTip);
            
            return calcColorForBg;
        }       

        public string CheckConnectionToNs(string NsUrl)
        {
            string checkResult = "";
            string url;
            if (NsUrl == null)
            {
                checkResult = "NightScout Url cannot be null.";
            }
            else if (!NsUrl.Contains("http://") && !NsUrl.Contains("https://"))
            {
                checkResult = "You must have http:// or https:// in your NightScout URL";
            }
            else
            {
                try
                {
                    url = NsUrl + "/api/v1/entries/current.json";
                    using (WebClient client = new WebClient())
                    {
                        string stringFromApi = client.DownloadString(url);
                        stringFromApi = stringFromApi.Replace("[", "").Replace("]", "");
                        string jsonString = stringFromApi;
                        JObject jObject = JObject.Parse(jsonString);
                        string bgSgv = (string)jObject.SelectToken("sgv");
                        if (bgSgv != null && bgSgv !="")
                        {
                            checkResult = "ok";
                        }
                    }                    
                }
                catch (Exception ex)            
                {
                    if (ex is WebException)
                    {                        
                        checkResult = "Could not resolve host from the given URL\n Please check you entered correct URL for NightScout";
                    }
                    if (ex is Newtonsoft.Json.JsonReaderException)
                    {
                        checkResult = "Could not get bg from the given URL\n Please check you entered correct URL for NightScout";
                    }
                }

            }
            return checkResult;
        }

        //Load a textfile from disk
        public string LoadTextFromFile()
        {
            string returnString = "";
            // Read the file as one string.
            try
            {
                returnString = System.IO.File.ReadAllText(@"c:\BgStrings.txt");
            }
            catch (Exception ) {

            }
            return returnString;             
        }

        //Write values to textfile
        /*string fileContent = LoadTextFromFile();
        string writeToFile = "";
        if (bgDirection != null && fileContent.IndexOf(bgDirection)== -1)
        {
            writeToFile = fileContent + ";" + bgDirection;
            WriteStringToFile(writeToFile);
        }*/
        //Save a text fil to disk
        public void WriteStringToFile(string input)
        {
            System.IO.File.WriteAllText(@"c:\BgStrings.txt", input);
        }
    }
}
